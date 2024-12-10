using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.Interfaces;

public interface ITransactionsView
{
    event EventHandler ViewTransactionEvent;
    event EventHandler SortByEvent;

    void GenerateTransactionList(List<Transaction> transactions);
}
