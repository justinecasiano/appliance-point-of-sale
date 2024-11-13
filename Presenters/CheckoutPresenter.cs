using AppliancePointOfSale.Data;
using AppliancePointOfSale.Views;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Presenters;

public class CheckoutPresenter
{
    public IRepository Repository { get; init; } 
    public ICheckoutView CheckoutView { get; init; }

    public CheckoutPresenter(IRepository repository)
    {
        Repository = repository;
        CheckoutView = new CheckoutView();
    }
}
