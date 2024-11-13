namespace AppliancePointOfSale.Views.Interfaces;

public interface IMainView : INotifier
{
    Form Dialog { get; init; }
    Panel PlaceHolder { get; }
    event EventHandler ChangeViewEvent;
}
