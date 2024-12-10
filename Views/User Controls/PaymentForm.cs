
using AppliancePointOfSale.Models;
using System.Text.RegularExpressions;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class PaymentForm : UserControl
{
    private Form form;
    private Transaction transaction;
    private string currentPaymentMethod;

    public PaymentForm(Form form, Transaction transaction)
    {
        InitializeComponent();
        this.form = form;
        this.transaction = transaction;
        cboPaymentMethod.SelectEvent += SelectPayment;

        InitializeForm();
        InitializeDropDown();
    }
    private void InitializeForm()
    {
        lblTotalAmount.Text = $"Total Amount: ₱ {transaction.Total:N2}";
        lblChange.Text = $"Change: ₱ {transaction.Change:N2}";
    }

    private void InitializeDropDown()
    {
        cboPaymentMethod.FontSize = 15;
        cboPaymentMethod.MaxDropDownWidth = 204;
        cboPaymentMethod.Items = ["Pay with Cash", "Pay with GCash", "Pay with Credit Card"];
        cboPaymentMethod.ShouldShowFirstIndex = true;
    }

    private void txtAmountPaid_TextChanged(object sender, EventArgs e)
    {
        if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
        {
            if (amountPaid >= Math.Round(transaction.Total))
            {
                lblChange.Text = $"Change: ₱ {(amountPaid - transaction.Total):N2}";
                pnlAmountPaid.BackColor = Color.ForestGreen;
            }
            else pnlAmountPaid.BackColor = Color.Crimson;
        }
        else pnlAmountPaid.BackColor = Color.Crimson;
    }

    private void txtReferenceNumber_TextChanged(object sender, EventArgs e)
    {
        if (Regex.IsMatch(txtReferenceNumber.Text, @"^[0-9A-Z]{10,16}$")) pnlReferenceNumber.BackColor = Color.ForestGreen;
        else pnlReferenceNumber.BackColor = Color.Crimson;
    }

    private void SelectPayment(object? sender, EventArgs e)
    {
        bool isSame = false;
        string selectedValue = sender as string;

        if (currentPaymentMethod == selectedValue)
        {
            isSame = true;
            cashPayment();
            cboPaymentMethod.ShouldShowFirstIndex = true;
        }

        if (!isSame)
        {
            if (selectedValue == "Pay with Cash") cashPayment();
            else gcashOrCreditPayment();
            currentPaymentMethod = selectedValue;
        }
    }

    private void cashPayment()
    {
        txtAmountPaid.Enabled = true;
        txtAmountPaid.Text = "";

        lblChange.Visible = true;
        pnlReferenceNumber.Visible = false;

        flpHolder.Height = 243;
        form.Height = 459;
    }

    private void gcashOrCreditPayment()
    {
        txtAmountPaid.Enabled = false;
        txtAmountPaid.Text = $"{transaction.Total:N2}";
        pnlAmountPaid.BackColor = Color.ForestGreen;

        lblChange.Visible = false;
        pnlReferenceNumber.Visible = true;

        flpHolder.Height = 263;
        form.Height = 479;
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
        if (currentPaymentMethod == "Pay with Cash")
        {
            if (txtAmountPaid.Text == "")
            {
                MessageBox.Show("Please enter the amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                if (amountPaid < transaction.Total)
                {
                    MessageBox.Show("Insufficient amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                transaction.PaymentMode = currentPaymentMethod;
                transaction.AmountPaid = amountPaid;
                transaction.ReferenceNumber = "";
                transaction.Status = "Success";

                form.Close();
            }
            else MessageBox.Show("Invalid amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (txtReferenceNumber.Text == "")
            {
                MessageBox.Show("Please enter the reference number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            transaction.PaymentMode = currentPaymentMethod;
            transaction.AmountPaid = transaction.Total;
            transaction.ReferenceNumber = txtReferenceNumber.Text;
            transaction.Status = "Success";

            form.Close();
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        form.Close();
    }
}
