using AppliancePointOfSale.Data;
using AppliancePointOfSale.Views.Interfaces;
using AppliancePointOfSale.Views.User_Controls;

namespace AppliancePointOfSale.Presenters;

public class TransactionsPresenter
{
    public IRepository Repository { get; init; }
    public ITransactionsView TransactionsView;

    public TransactionsPresenter(IRepository repository)
    {
        Repository = repository;
        TransactionsView = new TransactionsView();
        TransactionsView.GenerateTransactionList(Repository.Transactions);

        Repository.OnAddTransactionEvent += (s, e) => TransactionsView.GenerateTransactionList(Repository.Transactions);
    }
}
