using AppliancePointOfSale.Data;
using AppliancePointOfSale.Presenters;
using AppliancePointOfSale.Views;

namespace AppliancePointOfSale;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see hjttps://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        var repository = new JSONRepository("Assets/appliances.json", "Assets/transactions.json");
        var mainPresenter = new MainPresenter(repository, new MainView());
        Application.Run(new Login(mainPresenter));
    }
}