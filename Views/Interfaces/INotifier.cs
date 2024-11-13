namespace AppliancePointOfSale.Views.Interfaces;

public interface INotifier
{
    string Message { get; set; }
    event EventHandler NotifyEvent;
}
