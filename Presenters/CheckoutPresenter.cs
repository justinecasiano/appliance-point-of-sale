﻿using AppliancePointOfSale.Data;
using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Presenters;

public class CheckoutPresenter
{
    private Transaction transaction;
    public IRepository Repository { get; init; }
    public ICheckoutView CheckoutView;

    public CheckoutPresenter(IRepository repository)
    {
        Repository = repository;
        CheckoutView = new CheckoutView(AddLineItem, EditAppliance);
        transaction = new Transaction() { LineItems = [], Customer = new Customer() };
        CheckoutView.UpdateSummary(transaction);
        CheckoutView.GenerateApplianceList(Repository.Appliances);

        Repository.OnUpdateApplianceEvent += (s, e) => CheckoutView.GenerateApplianceList(Repository.Appliances);
        CheckoutView.UpdateLineItemEvent += UpdateLineItem;
        CheckoutView.EditCustomerDetailsEvent += EditCustomerDetails;
        CheckoutView.PaymentEvent += Payment;
        CheckoutView.ResetCheckoutEvent += ResetCheckout;
    }

    private void AddLineItem(object? sender, EventArgs e)
    {
        var selected = Repository.GetAppliance((string)sender);
        var item = new LineItem() { ID = selected.ID, Name = selected.Name, Price = selected.Price, Quantity = 1, AvailableStocks = selected.Stocks };
        CheckoutView.ClearSelectedAppliance();

        if (selected.InStock)
        {
            if (!IsLineItemPresent(item.ID))
            {
                transaction.LineItems.Add(item);
                CheckoutView.AddLineItemView(item);
            }
        }
        else CheckoutView.Message = "Appliance not in stock";
        CheckoutView.UpdateSummary(transaction, true);
    }

    private void UpdateLineItem(object? sender, EventArgs e)
    {
        var item = sender as LineItem;
        if (item.Quantity == 0)
        {
            transaction.LineItems.Remove(item);
            CheckoutView.UpdateLineItemView(item);
        }
        else if (item.Quantity <= item.AvailableStocks)
        {
            transaction.LineItems.Find(x => x.ID == item.ID).Quantity = item.Quantity;
            CheckoutView.UpdateLineItemView(item);
        }
        else
        {
            item.Quantity--;
            CheckoutView.UpdateLineItemView(item);
            CheckoutView.Message = "Not enough stocks for the selected appliance";
        }
        CheckoutView.UpdateSummary(transaction, true);
    }

    private void EditAppliance(object? sender, EventArgs e)
    {
        var appliances = Repository.Appliances;
        var appliance = sender as Appliance;

        if (appliance.Stocks < 0) CheckoutView.Message = "Stocks cannot be negative";
        else if (appliance.Stocks > 99) CheckoutView.Message = "Stocks cannot be greater than 99";
        else if (transaction.LineItems.Where(x => x.ID == appliance.ID).Any())
            CheckoutView.Message = "Cannot edit stocks of appliance";
        else
        {
            var edited = appliances.Find(x => x.ID == appliance.ID);
            edited.Stocks = appliance.Stocks;
            CheckoutView.EditAppliance(appliance);
            Repository.UpdateAppliance(edited);
            MessageBox.Show("Stocks successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }
    }

    private void EditCustomerDetails(object? sender, EventArgs e)
    {
        CheckoutView.EditCustomerDetails(transaction.Customer);
        if (transaction.Customer.FullName != null) CheckoutView.UpdateSummary(transaction);
    }

    private void UpdateStocks(List<LineItem> lineItems)
    {
        List<Appliance> appliances = new List<Appliance>();
        foreach (LineItem item in lineItems)
        {
            Appliance appliance = Repository.GetAppliance(item.ID);
            appliance.Stocks -= item.Quantity;
            appliances.Add(appliance);
        }
        Repository.UpdateAppliances(appliances);
    }

    private void Payment(object? sender, EventArgs e)
    {
        if (transaction.Customer.FullName == null) CheckoutView.Message = "Please provide customer details";
        else if (transaction.LineItems.Count == 0) CheckoutView.Message = "Please add an appliance to checkout";
        else
        {
            CheckoutView.Payment(transaction);
            if (transaction.Status != "Success") return;

            CheckoutView.UpdateSummary(transaction);
            UpdateStocks(transaction.LineItems);
            CheckoutView.GenerateReceipt(transaction);
            Repository.AddTransaction(transaction);
            CheckoutView.ConfirmReceipt(transaction);

            MessageBox.Show("Transaction successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            ResetCheckout(sender, e);
        }
    }

    private void ResetCheckout(object? sender, EventArgs e)
    {
        if ((sender as Control).Name == "btnReset" && !CheckoutView.ShouldReset(transaction)) return;
        transaction = new Transaction() { LineItems = [], Customer = new Customer() };
        CheckoutView.ResetCheckout(transaction);
    }

    private bool IsLineItemPresent(string id) =>
        transaction.LineItems.Exists(x => x.ID == id);

}
