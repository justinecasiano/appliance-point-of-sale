using AppliancePointOfSale.Data;

namespace AppliancePointOfSale.Views;

public interface IMainView : INotifier
{
    event EventHandler LoadEvent;
    event EventHandler RegisterViewEvent;
    event EventHandler LoginViewEvent;
    event EventHandler CheckoutViewEvent;
    event EventHandler TransactionsViewEvent;
}
