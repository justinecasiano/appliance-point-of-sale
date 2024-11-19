using System.Transactions;

namespace AppliancePointOfSale.Views.Interfaces;

public interface ITransactionsView 
{
    string SelectedTransaction { get; set; }
    Transaction Transaction { get; set;  }
    string SearchValue { get; set; }
    string SortValue { get; set; }

    event EventHandler ViewTransactionEvent;
    event EventHandler SearchEvent;
    event EventHandler SortEvent;
}
