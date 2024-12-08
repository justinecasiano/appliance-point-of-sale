using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class TransactionItemView : UserControl
{
    public Transaction Transaction;
    public string ID { get => lblTransactionID.Text; set => lblTransactionID.Text = value; }
    public string CustomerName { get => lblCustomerName.Text; set => lblCustomerName.Text = value; }
    public string Date { get => lblDate.Text; set => lblDate.Text = value; }
    public string ReceiptImagePath;

    private event EventHandler ViewTransactionEvent;

    public TransactionItemView(Transaction transaction, EventHandler viewTransaction)
    {
        InitializeComponent();
        ID = transaction.ID;
        CustomerName = transaction.Customer.FullName;
        Date = transaction.Date.ToString("MM/dd/yyyy");
        ReceiptImagePath = transaction.ReceiptImagePath;
        Transaction = transaction;

        ViewTransactionEvent += viewTransaction;

        AdjustHeight();
        DetectHit();
    }

    public void SelectTransaction()
    {
        pnlHeader.BackColor = Color.FromArgb(191, 49, 37);
        lblTransactionID.ForeColor = Color.White;
        lblCustomerName.ForeColor = Color.White;
        lblDate.ForeColor = Color.White;
    }

    public void UnselectTransaction()
    {

        pnlHeader.BackColor = Color.White;
        lblTransactionID.ForeColor = Color.FromArgb(56, 56, 56);
        lblCustomerName.ForeColor = Color.FromArgb(56, 56, 56);
        lblDate.ForeColor = Color.FromArgb(56, 56, 56);
    }

    private void AdjustHeight()
    {
        if (lblCustomerName.Height > 23) Height += lblCustomerName.Height - 23;
    }

    private void DetectHit()
    {
        foreach (Control control in pnlHeader.Controls) control.Click += pnlHeader_Click;
    }

    private void pnlHeader_Click(object sender, EventArgs e)
        => ViewTransactionEvent?.Invoke(this, e);
}
