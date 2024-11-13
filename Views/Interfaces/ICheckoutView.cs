using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.Interfaces;

public interface ICheckoutView : INotifier
{
    string SelectedAppliance { get; set; }
    Transaction Transaction { get; set; }
    string SearchValue { get; set; }
    string SortValue { get; set; }

    event EventHandler CheckoutEvent;
    event EventHandler EditCustomerDetailsEvent;
    event EventHandler AddQuantityEvent;
    event EventHandler SubtractQuantityEvent;
    event EventHandler PaymentEvent;
    event EventHandler GenerateReceiptEvent;
    event EventHandler SearchEvent;
    event EventHandler SortEvent;
}
