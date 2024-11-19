using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;
using AppliancePointOfSale.Views.User_Controls;
using System.Data.Common;

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
    public decimal TotalAmount { get => decimal.Parse(lblTotalAmount.Text.Replace("₱", "")); set => lblTotalAmount.Text = $"₱ {value:N2}"; }
    public ApplianceItemView SelectedAppliance { get; set; }

    private Dialog dialog;
    private Control[] controls;
    private Button currentCategory;

    public event EventHandler AddLineItemEvent;
    public event EventHandler UpdateLineItemEvent;
    public event EventHandler ApplianceSelectedEvent;
    public event EventHandler EditApplianceEvent;
    public event EventHandler EditCustomerDetailsEvent;
    public event EventHandler PaymentEvent;
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

    public void UpdateSidebar(Transaction transaction, bool breakdownOnly = false)
    {
        if (!breakdownOnly)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            lblTransactionID.Text = transaction.ID;
            lblFullName.Text = transaction.Customer.FullName ?? "Customer Name:";
            lblContact.Text = transaction.Customer.ContactNumber ?? "Contact Number";
            lblEmail.Text = transaction.Customer.Email ?? "Email Address";
            lblAddress.Text = transaction.Customer.Address ?? "Address";
        }

        lblAmount.Text = $"₱ {transaction.SubTotal:N2}";
        lblDiscount.Text = $"₱ {transaction.Discount:N2}";
        lblVAT.Text = $"₱ {transaction.AmountVAT:N2}";
        lblTotalAmount.Text = $"₱ {transaction.Total:N2}";
        lblPayTotalAmount.Text = $"₱ {transaction.Total:N2}";
    }

    private void Search(object? sender, EventArgs e)
    {
        ClearSelectedAppliance();
        if (currentCategory != null) currentCategory.BackColor = Color.FromArgb(251, 251, 251);

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
        searchBox.Clear();
        ClearSelectedAppliance();

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

    private void SetClickEvents()
    {
        btnAirConditioning.Click += (s, e) => ShowByCategory(s, "Air Conditioning");
        btnEntertainment.Click += (s, e) => ShowByCategory(s, "Entertainment");
        btnGarmentCare.Click += (s, e) => ShowByCategory(s, "Garment Care");
        btnKitchen.Click += (s, e) => ShowByCategory(s, "Kitchen");
        btnCleaningSterilizing.Click += (s, e) => ShowByCategory(s, "Cleaning Sterilizing");
        btnFansAndAirCoolers.Click += (s, e) => ShowByCategory(s, "Fans and Air Coolers");
        btnEdit.Click += (s, e) => EditCustomerDetailsEvent.Invoke(s, e);
        btnPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPay.Click += (s, e) => PaymentEvent.Invoke(s, e);
        lblPayTotalAmount.Click += (s, e) => PaymentEvent.Invoke(s, e);
    }
}
