using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.Interfaces;

public interface ICheckoutView : INotifier
{
    event EventHandler AddLineItemEvent;
    event EventHandler UpdateLineItemEvent;
    event EventHandler ApplianceSelectedEvent;
    event EventHandler EditApplianceEvent;
    event EventHandler EditCustomerDetailsEvent;
    event EventHandler PaymentEvent;
    event EventHandler ResetCheckoutEvent;
    event EventHandler SortByEvent;

    void GenerateApplianceList(List<Appliance> appliances);
    void AddLineItemView(LineItem item);
    void UpdateLineItemView(LineItem item);
    void ClearSelectedAppliance();
    void EditAppliance(Appliance appliance);
    void EditCustomerDetails(Customer customer);
    void Payment(Transaction transaction);
    void ConfirmReceipt(Transaction transaction);
    void GenerateReceipt(Transaction transaction);
    bool ShouldReset(Transaction transaction);
    void ResetCheckout(Transaction transaction);
    void UpdateSummary(Transaction transaction, bool breakdownOnly = false);
}
