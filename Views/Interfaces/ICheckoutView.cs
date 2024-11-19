using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.User_Controls;

namespace AppliancePointOfSale.Views.Interfaces;

public interface ICheckoutView : INotifier
{
    decimal Amount { get; set; }

    event EventHandler AddLineItemEvent;
    event EventHandler UpdateLineItemEvent;
    event EventHandler ApplianceSelectedEvent;
    event EventHandler EditApplianceEvent;
    event EventHandler EditCustomerDetailsEvent;
    event EventHandler PaymentEvent;

    void ClearSelectedAppliance();
    void AddLineItemView(LineItem item);
    void UpdateLineItemView(LineItem item);
    void EditCustomerDetails(Customer customer);
    void Payment(Transaction transaction);
    void UpdateSidebar(Transaction transaction, bool breakdownOnly = false);
}
