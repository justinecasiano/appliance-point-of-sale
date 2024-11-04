namespace AppliancePointOfSale.Views;

public interface ITransactionsView : INotifier
{
    string SelectedTransaction { get; set; }
    string SearchValue { get; set; }
    string SortValue { get; set; }

    event EventHandler ViewTransactionEvent;
    event EventHandler SearchEvent;
    event EventHandler SortEvent;
}
