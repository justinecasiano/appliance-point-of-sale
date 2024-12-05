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

        MainView.ChangeViewEvent += ChangeView;
        MainView.Views = [CheckoutPresenter.CheckoutView as UserControl, TransactionsPresenter.TransactionsView as UserControl];
        MainView.ChangeView("CheckoutView");
    }

    private void ChangeView(object? sender, EventArgs e)
    {
        MainView.ChangeView((string)sender);
    }
}
