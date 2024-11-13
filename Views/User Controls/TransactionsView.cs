using AppliancePointOfSale.Views.Interfaces;
using System.Transactions;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class TransactionsView : UserControl, ITransactionsView
{
    public string SelectedTransaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Transaction Transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string SortValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event EventHandler ViewTransactionEvent;
    public event EventHandler SearchEvent;
    public event EventHandler SortEvent;
    public event EventHandler NotifyEvent;

    public TransactionsView()
    {
        InitializeComponent();
    }
}
