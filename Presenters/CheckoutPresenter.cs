using AppliancePointOfSale.Data;
using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Presenters;

public class CheckoutPresenter
{
    private Transaction transaction;
    public IRepository Repository { get; init; }
    public ICheckoutView CheckoutView { get; init; }

    public CheckoutPresenter(IRepository repository)
    {
        Repository = repository;

        CheckoutView = new CheckoutView(Repository.Appliances, AddLineItem, EditAppliance);
        CheckoutView.UpdateLineItemEvent += UpdateLineItem;
        CheckoutView.EditCustomerDetailsEvent += EditCustomerDetails;
        CheckoutView.PaymentEvent += Payment;
        CheckoutView.ResetCheckoutEvent += ResetCheckout;

        transaction = new Transaction() { LineItems = [], Customer = new Customer() };
        CheckoutView.UpdateSummary(transaction);
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
    }

    private void EditCustomerDetails(object? sender, EventArgs e)
    {
        CheckoutView.EditCustomerDetails(transaction.Customer);
    }

    private void Payment(object? sender, EventArgs e)
    {
        if (transaction.Customer.FullName == null) CheckoutView.Message = "Please provide customer details";
        else if (transaction.LineItems.Count == 0) CheckoutView.Message = "Please add an appliance to checkout";
        else
        {
            CheckoutView.Payment(transaction);
            if (transaction.Status == "Failed") return;
            CheckoutView.GenerateReceipt(transaction);
            ResetCheckout(sender, e);
        }
    }

    private void ResetCheckout(object? sender, EventArgs e)
    {
        if (!CheckoutView.ShouldReset(transaction)) return;
        transaction = new Transaction() { LineItems = [], Customer = new Customer() };
        CheckoutView.ResetCheckout(transaction);
    }

    private bool IsLineItemPresent(string id) =>
        transaction.LineItems.Exists(x => x.ID == id);

}
