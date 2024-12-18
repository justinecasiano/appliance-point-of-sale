﻿using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;
using AppliancePointOfSale.Views.User_Controls;
using System.Drawing.Imaging;

namespace AppliancePointOfSale.Views;

public partial class CheckoutView : UserControl, ICheckoutView
{
    public string message;
    public string Message
    {
        get { return message; }
        set
        {
            message = value;
            NotifyEvent.Invoke(null, null);
        }
    }

    public event EventHandler AddLineItemEvent;
    public event EventHandler UpdateLineItemEvent;
    public event EventHandler ApplianceSelectedEvent;
    public event EventHandler EditApplianceEvent;
    public event EventHandler EditCustomerDetailsEvent;
    public event EventHandler PaymentEvent;
    public event EventHandler ResetCheckoutEvent;
    public event EventHandler SortByEvent;
    public event EventHandler NotifyEvent;

    private List<ApplianceItemView> appliances;
    private ApplianceItemView selectedAppliance;
    private Appliance currentlyEditing;
    private Panel currentCategory;
    private string currentSort;
    private Dialog dialog;

    public CheckoutView(EventHandler addLineItem, EventHandler editAppliance)
    {
        InitializeComponent();
        dialog = new Dialog();

        searchBox.SearchEvent += Search;
        ApplianceSelectedEvent += ApplianceSelected;
        AddLineItemEvent += addLineItem;
        EditApplianceEvent = editAppliance;
        SortByEvent += SortBy;
        NotifyEvent += Notify;

        SetClickEvents();
        InitializeSortBy();
    }

    public void GenerateApplianceList(List<Appliance> appliances)
    {
        this.appliances = new List<ApplianceItemView>();
        foreach (var appliance in appliances)
            this.appliances.Add(new ApplianceItemView(
                appliance,
                ApplianceSelectedEvent,
                AddLineItemEvent,
                EditApplianceEvent,
                (value) => currentlyEditing = value));
        RefreshListView(this.appliances);
    }

    public void AddLineItemView(LineItem item)
    {
        flpLineItems.Controls.Add(new LineItemView(item, UpdateLineItemEvent));
    }

    public void UpdateLineItemView(LineItem item)
    {
        var view = (LineItemView)flpLineItems.Controls.Find(item.ID, true)[0];
        if (item.Quantity == 0) flpLineItems.Controls.Remove(view);
        else view.Quantity = item.Quantity;
    }

    private void ApplianceSelected(object? sender, EventArgs e)
    {
        if (currentlyEditing != null) return;
        var selected = sender as ApplianceItemView;
        var isSame = false;

        if (selectedAppliance != null)
        {
            if (selectedAppliance == selected) isSame = true;
            ClearSelectedAppliance();
        }

        if (selectedAppliance != selected && !isSame)
        {
            selected.Height += 28;
            selected.BackColor = Color.FromArgb(255, 5, 19);
            selectedAppliance = selected;
        }
    }

    public void ClearSelectedAppliance()
    {
        if (selectedAppliance != null)
        {
            selectedAppliance.Height -= 28;
            selectedAppliance.BackColor = Color.White;
            selectedAppliance = null;
        }
    }

    public void EditAppliance(Appliance appliance)
    {
        ToggleCategory();
        var view = appliances.Find(x => appliance.ID == x.ID);
        view.Stocks = $"{appliance.Stocks}";
        currentlyEditing = null;
    }

    public void EditCustomerDetails(Customer customer)
    {
        dialog.Add(new CustomerForm(dialog, customer));
        dialog.ShowDialog();
    }

    public void Payment(Transaction transaction)
    {
        dialog.Add(new PaymentForm(dialog, transaction));
        dialog.ShowDialog();
    }

    public void ConfirmReceipt(Transaction transaction)
    {
        dialog.Add(new ReceiptForm(dialog, transaction.ReceiptImagePath));
        dialog.ShowDialog();
    }

    public void GenerateReceipt(Transaction transaction)
    {
        pnlTotalPaid.Visible = pnlChange.Visible = true;
        pnlSummary.Visible = false;
        HideAndResizeElements();

        var path = $"../../../Assets/Receipts/{transaction.ID}.png";
        transaction.ReceiptImagePath = path;

        var image = new Bitmap(pnlSummary.Width, pnlSummary.Height);
        pnlSummary.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
        image.Save(path, ImageFormat.Png);

        UndoHideAndResizeElements();
        pnlSummary.Visible = true;
    }

    public bool ShouldReset(Transaction transaction)
    {
        bool shouldReset = true;
        if (transaction.Customer.FullName == null && transaction.LineItems.Count == 0)
        {
            Message = "Customer details and line items are empty";
            shouldReset = false;
        }
        else
        {
            var choice = MessageBox.Show("Do you want to discard the current checkout?", "Reset Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No) shouldReset = false;
        }
        return shouldReset;
    }

    public void ResetCheckout(Transaction transaction)
    {
        flpLineItems.Controls.Clear();
        UpdateSummary(transaction);
    }

    private void RefreshListView(List<ApplianceItemView> appliancesView)
    {
        flpAppliancesList.Controls.Clear();
        flpAppliancesList.Controls.AddRange(appliancesView.ToArray());
    }

    private void Search(object? sender, EventArgs e)
    {
        if (currentlyEditing != null)
        {
            searchBox.Clear();
            return;
        }
        ClearSelectedAppliance();
        if (currentCategory != null) ToggleCategory();

        var identifier = sender as string;
        var searchList = identifier == "" ? appliances : appliances.AsParallel()
            .Where((appliance) =>
            appliance.ID.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.ApplianceName.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Price.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Stocks.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Category.Contains(identifier, StringComparison.OrdinalIgnoreCase)
            ).ToList();

        RefreshListView(searchList);
    }

    private void ShowByCategory(object? sender, string category)
    {
        if (currentlyEditing != null) return;
        searchBox.Clear();
        ClearSelectedAppliance();

        var isSameCategory = false;
        var panel = sender as Panel;
        var controlsCategory = appliances;

        if (currentCategory != null)
        {
            if (string.Equals(panel.Name, currentCategory.Name, StringComparison.OrdinalIgnoreCase)) isSameCategory = true;
            ToggleCategory();
        }

        if (currentCategory == null && !isSameCategory)
        {
            ToggleCategory(panel);
            controlsCategory = appliances.AsParallel().Where(x => x.Category == category).ToList();
        }

        RefreshListView(controlsCategory);
    }

    private void ToggleCategory(Panel panel = null)
    {
        if (currentCategory != null)
        {
            if (currentCategory.Name == "pnlAirConditioning") currentCategory.BackgroundImage = Properties.Resources.air_conditioning_black;
            else if (currentCategory.Name == "pnlEntertainment") currentCategory.BackgroundImage = Properties.Resources.entertainment_black;
            else if (currentCategory.Name == "pnlGarmentCare") currentCategory.BackgroundImage = Properties.Resources.garment_care_black;
            else if (currentCategory.Name == "pnlKitchen") currentCategory.BackgroundImage = Properties.Resources.kitchen_black;
            else if (currentCategory.Name == "pnlCleaningSterilizing") currentCategory.BackgroundImage = Properties.Resources.cleaning_sterilizing_black;
            else if (currentCategory.Name == "pnlFansAndAirCoolers") currentCategory.BackgroundImage = Properties.Resources.fans_and_air_coolers_black;
            currentCategory = null;
        }
        else if (panel != null)
        {
            currentCategory = panel;
            if (currentCategory.Name == "pnlAirConditioning") currentCategory.BackgroundImage = Properties.Resources.air_conditioning_white;
            else if (currentCategory.Name == "pnlEntertainment") currentCategory.BackgroundImage = Properties.Resources.entertainment_white;
            else if (currentCategory.Name == "pnlGarmentCare") currentCategory.BackgroundImage = Properties.Resources.garment_care_white;
            else if (currentCategory.Name == "pnlKitchen") currentCategory.BackgroundImage = Properties.Resources.kitchen_white;
            else if (currentCategory.Name == "pnlCleaningSterilizing") currentCategory.BackgroundImage = Properties.Resources.cleaning_sterilizing_white;
            else if (currentCategory.Name == "pnlFansAndAirCoolers") currentCategory.BackgroundImage = Properties.Resources.fans_and_air_coolers_white;
        }
    }

    private void InitializeSortBy()
    {
        cboSortBy.Title = "Sort By: ";
        cboSortBy.Items = ["Name ↑", "Name ↓", "Category ↑", "Category ↓", "Price ↑", "Price ↓", "Stocks ↑", "Stocks ↓"];
        cboSortBy.MaxDropDownWidth = 115;
        cboSortBy.SelectEvent += SortByEvent;
    }

    private void SortBy(object? sender, EventArgs e)
    {
        if (currentlyEditing != null) return;
        if (currentCategory != null) ToggleCategory();
        searchBox.Clear();
        ClearSelectedAppliance();

        bool isSame = false;
        string sortValue = sender as string;
        List<ApplianceItemView> sortedAppliances = appliances;

        if (currentSort != null)
        {
            if (currentSort == sortValue)
            {
                isSame = true;
                cboSortBy.Title = "Sort by: ";
            }
            currentSort = null;
        }

        if (currentSort == null && !isSame)
        {
            if (sortValue == "Name ↑") sortedAppliances = appliances.OrderBy(x => x.Appliance.Name).ToList();
            else if (sortValue == "Name ↓") sortedAppliances = appliances.OrderByDescending(x => x.Appliance.Name).ToList();
            else if (sortValue == "Category ↑") sortedAppliances = appliances.OrderBy(x => x.Appliance.Category).ToList();
            else if (sortValue == "Category ↓") sortedAppliances = appliances.OrderByDescending(x => x.Appliance.Category).ToList();
            else if (sortValue == "Price ↑") sortedAppliances = appliances.OrderBy(x => x.Appliance.Price).ToList();
            else if (sortValue == "Price ↓") sortedAppliances = appliances.OrderByDescending(x => x.Appliance.Price).ToList();
            else if (sortValue == "Stocks ↑") sortedAppliances = appliances.OrderBy(x => x.Appliance.Stocks).ToList();
            else if (sortValue == "Stocks ↓") sortedAppliances = appliances.OrderByDescending(x => x.Appliance.Stocks).ToList();
            currentSort = sortValue;
        }
        RefreshListView(sortedAppliances);
    }

    private void Notify(object? sender, EventArgs e)
    {
        MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void UpdateSummary(Transaction transaction, bool breakdownOnly = false)
    {
        if (!breakdownOnly)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            lblTransactionID.Text = transaction.ID;
            chkIsSeniorOrPwd.Checked = transaction.Customer.IsSeniorOrPwd;
            lblFullName.Text = $"Customer Name: {transaction.Customer.FullName}";
            lblContact.Text = transaction.Customer.ContactNumber ?? "Contact Number";
            lblPaymentMode.Text = $"Mode of Payment: {transaction.PaymentMode}";
            lblReferenceNo.Text = $"Reference #: {transaction.ReferenceNumber}";
            lblEmail.Text = transaction.Customer.Email ?? "Email Address";
            lblAddress.Text = transaction.Customer.Address ?? "Address";

            if (transaction.PaymentMode == "GCash" || transaction.PaymentMode == "Credit Card") lblReferenceNo.Visible = true;
            else lblReferenceNo.Visible = false;
        }

        lblAmount.Text = $"₱ {transaction.SubTotal:N2}";
        lblDiscount.Text = $"₱ {transaction.Discount:N2}";
        lblVAT.Text = $"₱ {transaction.AmountVAT:N2}";
        lblTotal.Text = $"₱ {transaction.Total:N2}";
        lblTotalPaid.Text = $"₱ {transaction.AmountPaid:N2}";
        lblChange.Text = $"₱ {transaction.Change:N2}";
        lblPayTotalAmount.Text = $"₱ {transaction.Total:N2}";
    }

    public void HideAndResizeElements()
    {
        btnReset.Visible = btnEdit.Visible = lblPayTotalAmount.Visible = false;
        pnlTotalPaid.Visible = pnlChange.Visible = true;
        if (lblPaymentMode.Text == "Mode of Payment: Pay with Cash") lblReferenceNo.Visible = false;
        else lblReferenceNo.Visible = true;

        lblPay.Text = "SUCCESSFUL TRANSACTION!";
        lblPay.Font = new Font("Inria Sans", 15, FontStyle.Bold);

        int addtlHeight = 0, customerDetailsHeight = 0;
        flpCustomer.Width = 288;
        foreach (Control control in flpCustomer.Controls)
        {
            if (control.Name == "lblReferenceNo" && lblPaymentMode.Text == "Mode of Payment: Pay with Cash") continue;
            if (control.Name.Contains("lbl"))
            {
                control.MaximumSize = new Size(255, 0);
                control.Width = 255;
            }
            customerDetailsHeight += control.Height;
        }

        addtlHeight += customerDetailsHeight - flpCustomer.Height;
        flpCustomer.Height = customerDetailsHeight;

        int lineItemsHeight = 0;
        foreach (LineItemView item in flpLineItems.Controls)
        {
            item.HideControls();
            lineItemsHeight += item.Height;
        }

        int subtractHeight = 0;
        if (flpLineItems.Height < lineItemsHeight) addtlHeight += lineItemsHeight - flpLineItems.Height;
        else subtractHeight = flpLineItems.Height - lineItemsHeight;
        flpLineItems.Height = lineItemsHeight;

        addtlHeight += pnlTotalPaid.Height + 6 + pnlChange.Height + 6;
        flpTransactionDetails.Height += pnlTotalPaid.Height + 6 + pnlChange.Height + 6;

        flpPlaceholder.Height += addtlHeight;
        flpPlaceholder.Height -= subtractHeight;

        pnlSummary.Dock = DockStyle.None;
        pnlSummary.Height += addtlHeight;
        pnlSummary.Height -= subtractHeight;
    }

    public void UndoHideAndResizeElements()
    {
        btnReset.Visible = btnEdit.Visible = lblPayTotalAmount.Visible = true;
        lblReferenceNo.Visible = pnlTotalPaid.Visible = pnlChange.Visible = false;

        lblPay.Text = "PAY";
        lblPay.Font = new Font("Inria Sans", 16, FontStyle.Bold);

        flpCustomer.Width = 243;
        foreach (Control control in flpCustomer.Controls)
        {
            if (control.Name.Contains("lbl"))
            {
                control.MaximumSize = new Size(210, 0);
                control.Width = 210;
            }
        }

        foreach (LineItemView item in flpLineItems.Controls) item.UndoHideControls();
        flpCustomer.Height = 119;
        flpLineItems.Height = 197;
        flpTransactionDetails.Height = 96;
        flpPlaceholder.Height = 515;
        pnlSummary.Height = 711;
        pnlSummary.Dock = DockStyle.Right;
    }

    private void SetClickEvents()
    {
        pnlAirConditioning.Click += (s, e) => ShowByCategory(s, "Air Conditioning");
        pnlEntertainment.Click += (s, e) => ShowByCategory(s, "Entertainment");
        pnlGarmentCare.Click += (s, e) => ShowByCategory(s, "Garment Care");
        pnlKitchen.Click += (s, e) => ShowByCategory(s, "Kitchen");
        pnlCleaningSterilizing.Click += (s, e) => ShowByCategory(s, "Cleaning Sterilizing");
        pnlFansAndAirCoolers.Click += (s, e) => ShowByCategory(s, "Fans and Air Coolers");

        btnEdit.Click += (s, e) => EditCustomerDetailsEvent.Invoke(s, e);
        btnReset.Click += (s, e) => ResetCheckoutEvent.Invoke(s, e);
        btnPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPayTotalAmount.Click += (s, e) => PaymentEvent.Invoke(s, e);
    }
}
