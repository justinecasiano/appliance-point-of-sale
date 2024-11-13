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

    public MainPresenter(IRepository repository, IMainView mainView)
    {
        this.Repository = repository;
        this.MainView = mainView;
        CheckoutPresenter = new CheckoutPresenter(Repository);
        TransactionsPresenter = new TransactionsPresenter(Repository);

        MainView.NotifyEvent += ShowNotification;
        MainView.ChangeViewEvent += ChangeView;
        MainView.PlaceHolder.Controls.Add(new CheckoutView());
    }

    private void ChangeView(object? sender, EventArgs e)
    {
        var button = sender as Button;
    }

    public void ShowNotification(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
