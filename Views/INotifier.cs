namespace AppliancePointOfSale.Views;

public interface INotifier
{
    string Message { get; set; }
    event EventHandler NotifyEvent;
}
