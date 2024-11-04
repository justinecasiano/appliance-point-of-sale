
using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views;

public interface ICheckoutView : INotifier
{
    Appliance SelectedAppliance { get; set; }
    string? SelectedColor { get; set; }
    string? SelectedSize { get; set; }
    int SelectedQuantity { get; set; }
    Customer CurrentCustomer { get; set; }
    decimal AmountPaid { get; set; }
    decimal Change { get; set; }
    bool IsSuccessful { get; set; }

    string SearchValue { get; set; }
    string SortValue { get; set; }

    event EventHandler CheckoutEvent;
    event EventHandler CustomerDetailsEvent;
    event EventHandler SearchEvent;
    event EventHandler SortEvent;
    event EventHandler PaymentEvent;
    event EventHandler GenerateReceiptEvent;
}
