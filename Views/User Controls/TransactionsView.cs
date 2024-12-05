using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class TransactionsView : UserControl, ITransactionsView
{
    public event EventHandler ViewTransactionEvent;
    public event EventHandler SearchEvent;
    public event EventHandler SortByEvent;

    private List<TransactionItemView> transactions;
    private TransactionItemView selectedTransaction;

    public TransactionsView()
    {
        InitializeComponent();
        searchBox.SearchEvent += Search;
        ViewTransactionEvent += ViewTransaction;
    }

    public void GenerateTransactionList(List<Transaction> transactions)
    {
        this.transactions = new List<TransactionItemView>();
        foreach (Transaction transaction in transactions)
            this.transactions.Add(new TransactionItemView(transaction, ViewTransactionEvent));
        RefreshListView(this.transactions);
    }

    private void TransactionSelected(TransactionItemView transactionView)
    {
        if (transactionView == selectedTransaction) transactionView.UnselectTransaction();
        else
        {
            if (selectedTransaction != null) selectedTransaction.UnselectTransaction();
            transactionView.SelectTransaction();
        }
    }

    private void ViewTransaction(object? sender, EventArgs e)
    {
        bool isSame = false;
        var transaction = sender as TransactionItemView;
        TransactionSelected(transaction);

        if (selectedTransaction != null)
        {
            if (selectedTransaction == transaction) isSame = true;
            selectedTransaction = null;

            lblGuide.Visible = true;
            pboTransaction.Visible = false;
        }

        if (selectedTransaction == null && !isSame)
        {
            selectedTransaction = transaction;
            lblGuide.Visible = false;
            pboTransaction.Visible = true;

            pboTransaction.Image = Image.FromFile(transaction.ReceiptImagePath);
            pboTransaction.SizeMode = PictureBoxSizeMode.StretchImage;

            int width = (pboTransaction.Image.Size.Height > 711) ? 300 : 317;
            pboTransaction.Size = new Size(width, pboTransaction.Image.Size.Height);
        }
    }

    private void RefreshListView(List<TransactionItemView> transactions)
    {
        var header = flpTransactionsList.Controls.Find("pnlHeader", false).FirstOrDefault();
        if (transactions.Count > 8) flpTransactionsList.Width = 864;
        else flpTransactionsList.Width = 845;

        flpTransactionsList.Controls.Clear();
        flpTransactionsList.Controls.Add(header);
        flpTransactionsList.Controls.AddRange(transactions.ToArray());
    }

    private void Search(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
