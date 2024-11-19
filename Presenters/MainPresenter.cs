using AppliancePointOfSale.Data;
using AppliancePointOfSale.Views;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Presenters;

public class MainPresenter
{
    public IRepository Repository { get; init; }
    public IMainView MainView { get; init; }
    public CheckoutPresenter CheckoutPresenter { get; init; }
    public TransactionsPresenter TransactionsPresenter { get; init; }
    public string CurrentView { get; set; }

    public MainPresenter(IRepository repository, IMainView mainView)
    {
        this.Repository = repository;
        this.MainView = mainView;
        CheckoutPresenter = new CheckoutPresenter(Repository);
        TransactionsPresenter = new TransactionsPresenter(Repository);

        MainView.ChangeViewEvent += ChangeView;
        MainView.PlaceHolder.Controls.Add((UserControl)CheckoutPresenter.CheckoutView);
        CurrentView = "btnCheckout";
    }

    private void ChangeView(object? sender, EventArgs e)
    {
        var button = sender as Button;
        if (button is null || button.Name.Contains(CurrentView)) return;

        var view = (button.Name == "btnCheckout") ? (UserControl)CheckoutPresenter.CheckoutView : (UserControl)TransactionsPresenter.TransactionsView;
        CurrentView = button.Name;

        MainView.PlaceHolder.Visible = false;
        MainView.PlaceHolder.Controls.Clear();
        MainView.PlaceHolder.Controls.Add(view);
        MainView.PlaceHolder.Visible = true;
    }

    public void ShowNotification(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
