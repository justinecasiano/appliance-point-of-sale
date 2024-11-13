using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Views;

public partial class CheckoutView : UserControl, ICheckoutView
{
    public string SelectedAppliance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Transaction Transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string SortValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event EventHandler CheckoutEvent;
    public event EventHandler EditCustomerDetailsEvent;
    public event EventHandler AddQuantityEvent;
    public event EventHandler SubtractQuantityEvent;
    public event EventHandler PaymentEvent;
    public event EventHandler GenerateReceiptEvent;
    public event EventHandler SearchEvent;
    public event EventHandler SortEvent;
    public event EventHandler NotifyEvent;

    public CheckoutView()
    {
        InitializeComponent();
    }
}
