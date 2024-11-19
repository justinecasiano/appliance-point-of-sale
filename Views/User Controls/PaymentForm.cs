
using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class PaymentForm : UserControl
{
    private Form form;
    private Transaction transaction;

    public PaymentForm(Form form, Transaction transaction)
    {
        InitializeComponent();
        this.form = form;
        this.transaction = transaction;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        form.Close();
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
        form.Close();
    }
}
