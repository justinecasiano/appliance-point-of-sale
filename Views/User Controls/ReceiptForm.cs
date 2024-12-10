namespace AppliancePointOfSale.Views.User_Controls;

public partial class ReceiptForm : UserControl
{
    private Form form;

    public ReceiptForm(Form form, string receiptImagePath)
    {
        InitializeComponent();
        this.form = form;
        pboReceipt.Image = Image.FromFile(receiptImagePath);
        pboReceipt.Height = pboReceipt.Image.Height;
        pboReceipt.Width = (pboReceipt.Height > 328) ? 300 : 317;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        form.Close();
    }
}
