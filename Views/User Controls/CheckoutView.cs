using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;
using AppliancePointOfSale.Views.User_Controls;
using System.Data.Common;
using System.Drawing.Imaging;

namespace AppliancePointOfSale.Views;

public partial class CheckoutView : UserControl, ICheckoutView
{
    public decimal Amount
    {
        get => decimal.Parse(lblAmount.Text.Replace("₱", "")); set
        {
            lblAmount.Text = $"₱ {value:N2}";
            TotalAmount = value;
        }
    }
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
    public decimal TotalAmount { get => decimal.Parse(lblChange.Text.Replace("₱", "")); set => lblChange.Text = $"₱ {value:N2}"; }

    private Dialog dialog;
    private Control[] controls;
    private Button currentCategory;
    private ApplianceItemView SelectedAppliance { get; set; }

    public event EventHandler AddLineItemEvent;
    public event EventHandler UpdateLineItemEvent;
    public event EventHandler ApplianceSelectedEvent;
    public event EventHandler EditApplianceEvent;
    public event EventHandler EditCustomerDetailsEvent;
    public event EventHandler PaymentEvent;
    public event EventHandler ResetCheckoutEvent;
    public event EventHandler NotifyEvent;

    public CheckoutView(List<Appliance> appliances, EventHandler addLineItem, EventHandler editAppliance)
    {
        InitializeComponent();
        searchBox.SearchEvent += Search;
        ApplianceSelectedEvent += ApplianceSelected;
        AddLineItemEvent += addLineItem;
        EditApplianceEvent += editAppliance;
        NotifyEvent += Notify;

        dialog = new Dialog();
        appliances.ForEach((appliance) => flpAppliancesList.Controls.Add(new ApplianceItemView(appliance, ApplianceSelectedEvent, AddLineItemEvent, EditApplianceEvent)));
        controls = flpAppliancesList.Controls.OfType<Control>().ToArray();

        SetClickEvents();
    }

    private void ApplianceSelected(object? sender, EventArgs e)
    {
        var isSame = false;
        var selected = sender as ApplianceItemView;
        if (SelectedAppliance == selected || SelectedAppliance != null)
        {
            if (SelectedAppliance == selected) isSame = true;
            ClearSelectedAppliance();
        }

        if (SelectedAppliance != selected && !isSame)
        {
            selected.Height += 30;
            selected.BackColor = Color.FromArgb(255, 5, 19);
            SelectedAppliance = selected;
        }
    }

    public void ClearSelectedAppliance()
    {
        if (SelectedAppliance != null)
        {
            SelectedAppliance.Height -= 30;
            SelectedAppliance.BackColor = Color.White;
            SelectedAppliance = null;
        }
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

    public void GenerateReceipt(Transaction transaction)
    {
        HideAndResizeElements();
        var image = new Bitmap(pnlSummary.Width, pnlSummary.Height);
        pnlSummary.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
        image.Save($"../../../Assets/Receipts/{transaction.ID}.png", ImageFormat.Png);
        UndoHideAndResizeElements();
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

    private void Search(object? sender, EventArgs e)
    {
        ClearSelectedAppliance();
        if (currentCategory != null)
        {
            currentCategory.BackColor = Color.FromArgb(251, 251, 251);
            currentCategory = null;
        }

        var identifier = sender as string;
        var searchList = identifier == "" ? controls : controls.OfType<ApplianceItemView>().AsParallel()
            .Where((appliance) =>
            appliance.ID.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.ApplianceName.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Price.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Stock.Contains(identifier, StringComparison.OrdinalIgnoreCase) ||
            appliance.Category.Contains(identifier, StringComparison.OrdinalIgnoreCase)
            ).ToArray();

        flpAppliancesList.Controls.Clear();
        flpAppliancesList.Controls.AddRange(searchList);
    }

    private void ShowByCategory(object? sender, string category)
    {
        ClearSelectedAppliance();
        searchBox.Clear();

        var button = sender as Button;
        var controlsCategory = controls;
        var isSameCategory = false;

        if (currentCategory != null)
        {
            currentCategory.BackColor = Color.FromArgb(251, 251, 251);
            if (string.Equals(category, currentCategory.Text, StringComparison.OrdinalIgnoreCase)) isSameCategory = true;
            currentCategory = null;
        }

        if (currentCategory == null && !isSameCategory)
        {
            currentCategory = button;
            button.BackColor = Color.FromArgb(192, 52, 40);
            controlsCategory = controls.Where(x => ((ApplianceItemView)x).Category == category).ToArray();
        }

        flpAppliancesList.Controls.Clear();
        flpAppliancesList.Controls.AddRange(controlsCategory);
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
            lblPaymentMode.Text = $"Payment Mode: {transaction.PaymentMode}";
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
        btnReset.Visible = false;
        btnEdit.Visible = false;
        lblReferenceNo.Visible = true;
        pnlTotalPaid.Visible = true;
        pnlChange.Visible = true;

        int addtlHeight = 0, customerDetailsHeight = 0;
        foreach (Control control in flpCustomer.Controls) customerDetailsHeight += control.Height;
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

        addtlHeight += lblTotalPaid.Height + 6;
        flpTransactionDetails.Height += lblTotalPaid.Height + 6;
        addtlHeight += lblChange.Height + 6;
        flpTransactionDetails.Height += lblChange.Height + 6;

        flpPlaceholder.Height -= subtractHeight;
        flpPlaceholder.Height += addtlHeight;
        pnlSummary.Dock = DockStyle.None;
        pnlSummary.Height -= subtractHeight;
        pnlSummary.Height += addtlHeight;
    }

    public void UndoHideAndResizeElements()
    {
        btnReset.Visible = true;
        btnEdit.Visible = true;
        lblReferenceNo.Visible = false;
        pnlTotalPaid.Visible = false;
        pnlChange.Visible = false;

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
        btnAirConditioning.Click += (s, e) => ShowByCategory(s, "Air Conditioning");
        btnEntertainment.Click += (s, e) => ShowByCategory(s, "Entertainment");
        btnGarmentCare.Click += (s, e) => ShowByCategory(s, "Garment Care");
        btnKitchen.Click += (s, e) => ShowByCategory(s, "Kitchen");
        btnCleaningSterilizing.Click += (s, e) => ShowByCategory(s, "Cleaning Sterilizing");
        btnFansAndAirCoolers.Click += (s, e) => ShowByCategory(s, "Fans and Air Coolers");
        btnEdit.Click += (s, e) => EditCustomerDetailsEvent.Invoke(s, e);
        btnReset.Click += (s, e) => ResetCheckoutEvent.Invoke(s, e);
        btnPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPayTotalAmount.Click += (s, e) => PaymentEvent.Invoke(s, e);
        button1.Click += (s, e) => PaymentEvent.Invoke(s, e);
    }
}
