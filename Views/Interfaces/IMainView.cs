namespace AppliancePointOfSale.Views.Interfaces;

public interface IMainView 
{
    List<UserControl> Views { get; set; }
    event EventHandler ChangeViewEvent;

    void ChangeView(string view);
}
