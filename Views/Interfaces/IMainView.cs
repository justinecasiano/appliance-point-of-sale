namespace AppliancePointOfSale.Views.Interfaces;

public interface IMainView 
{
    Panel PlaceHolder { get; }
    event EventHandler ChangeViewEvent;
}
