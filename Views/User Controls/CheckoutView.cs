using AppliancePointOfSale.Models;
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
    private Dialog dialog;

    public CheckoutView(EventHandler addLineItem, EventHandler editAppliance)
    {
        InitializeComponent();
        dialog = new Dialog();

        searchBox.SearchEvent += Search;
        ApplianceSelectedEvent += ApplianceSelected;
        AddLineItemEvent += addLineItem;
        EditApplianceEvent = editAppliance;
        NotifyEvent += Notify;

        SetClickEvents();
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
        view.Stocks = appliance.Stocks.ToString();
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
            currentCategory.BackColor = Color.FromArgb(251, 251, 251);
            foreach (Label label in currentCategory.Controls) label.Visible = false;
            foreach (Label label in currentCategory.Controls)
            {
                if (label.Name == "picAirConditioning") label.Image = Properties.Resources.air_conditioning_icon_black;
                else if (label.Name == "picEntertainment") label.Image = Properties.Resources.entertainment_icon_black;
                else if (label.Name == "picGarmentCare") label.Image = Properties.Resources.garment_care_icon_black;
                else if (label.Name == "picKitchen") label.Image = Properties.Resources.kitchen_icon_black;
                else if (label.Name == "picCleaningSterilizing") label.Image = Properties.Resources.cleaning_sterilizing_icon_black;
                else if (label.Name == "picFansAndAirCoolers") label.Image = Properties.Resources.fans_and_air_coolers_icon_black;
                else label.ForeColor = Color.Black;
            }
            foreach (Label label in currentCategory.Controls) label.Visible = true;
            currentCategory = null;
        }
        else if (panel != null)
        {
            panel.BackColor = Color.FromArgb(192, 52, 40);
            foreach (Label label in panel.Controls) label.Visible = false;
            foreach (Label label in panel.Controls)
            {
                if (label.Name == "picAirConditioning") label.Image = Properties.Resources.air_conditioning_icon_white;
                else if (label.Name == "picEntertainment") label.Image = Properties.Resources.entertainment_icon_white;
                else if (label.Name == "picGarmentCare") label.Image = Properties.Resources.garment_care_icon_white;
                else if (label.Name == "picKitchen") label.Image = Properties.Resources.kitchen_icon_white;
                else if (label.Name == "picCleaningSterilizing") label.Image = Properties.Resources.cleaning_sterilizing_icon_white;
                else if (label.Name == "picFansAndAirCoolers") label.Image = Properties.Resources.fans_and_air_coolers_icon_white;
                else label.ForeColor = Color.White;
            }
            foreach (Label label in panel.Controls) label.Visible = true;
            currentCategory = panel;
        }
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
        btnReset.Visible = btnEdit.Visible = lblPayTotalAmount.Visible = false;
        lblReferenceNo.Visible = pnlTotalPaid.Visible = pnlChange.Visible = true;

        lblPay.Text = "SUCCESSFUL TRANSACTION!";
        lblPay.Font = new Font("Inria Sans", 15, FontStyle.Bold);

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
        foreach (Control control in pnlAirConditioning.Controls) control.Click += (s, e) => ShowByCategory(pnlAirConditioning, "Air Conditioning");

        pnlEntertainment.Click += (s, e) => ShowByCategory(s, "Entertainment");
        foreach (Control control in pnlEntertainment.Controls) control.Click += (s, e) => ShowByCategory(pnlEntertainment, "Entertainment");

        pnlGarmentCare.Click += (s, e) => ShowByCategory(s, "Garment Care");
        foreach (Control control in pnlGarmentCare.Controls) control.Click += (s, e) => ShowByCategory(pnlGarmentCare, "Garment Care");

        pnlKitchen.Click += (s, e) => ShowByCategory(s, "Kitchen");
        foreach (Control control in pnlKitchen.Controls) control.Click += (s, e) => ShowByCategory(pnlKitchen, "Kitchen");

        pnlCleaningSterilizing.Click += (s, e) => ShowByCategory(s, "Cleaning Sterilizing");
        foreach (Control control in pnlCleaningSterilizing.Controls) control.Click += (s, e) => ShowByCategory(pnlCleaningSterilizing, "Cleaning Sterilizing");

        pnlFansAndAirCoolers.Click += (s, e) => ShowByCategory(s, "Fans and Air Coolers");
        foreach (Control control in pnlFansAndAirCoolers.Controls) control.Click += (s, e) => ShowByCategory(pnlFansAndAirCoolers, "Fans and Air Coolers");

        btnEdit.Click += (s, e) => EditCustomerDetailsEvent.Invoke(s, e);
        btnReset.Click += (s, e) => ResetCheckoutEvent.Invoke(s, e);
        btnPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPayTotalAmount.Click += (s, e) => PaymentEvent.Invoke(s, e);
    }
}
