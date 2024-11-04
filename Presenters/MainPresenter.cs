using AppliancePointOfSale.Data;
using AppliancePointOfSale.Views;

namespace AppliancePointOfSale.Presenters;

public class MainPresenter
{
    public IRepository Repository { get; init; }
    public IMainView MainView { get; init; }
    public IRegisterView RegisterView { get; init; }
    public ILoginView LoginView { get; init; }
    public ICheckoutView CheckoutView { get; init; }
    public ITransactionsView TransactionsView { get; init; }

    public MainPresenter(IRepository repository, IMainView mainView)
    {
        this.Repository = repository;
        this.MainView = mainView;
        MainView.NotifyEvent += ShowNotification;
    }

    public void ShowNotification(object sender, EventArgs e) { }
}
