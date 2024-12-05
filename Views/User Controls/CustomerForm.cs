using AppliancePointOfSale.Models;
using System.Text.RegularExpressions;

namespace AppliancePointOfSale.Views.User_Controls
{
    public partial class CustomerForm : UserControl
    {
        private Form form;
        private Customer customer;

        public CustomerForm(Form form, Customer customer)
        {
            InitializeComponent();
            this.form = form;
            this.customer = customer;

            txtName.Text = customer.FullName;
            txtPhoneNumber.Text = customer.ContactNumber;
            txtEmailAddress.Text = customer.Email;
            txtAddress.Text = customer.Address;
            chkSeniorPwd.Checked = customer.IsSeniorOrPwd;
            pnlSeniorOrPwd.BackColor = Color.ForestGreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (pnlName.BackColor != Color.ForestGreen) MessageBox.Show("Name is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pnlPhoneNumber.BackColor != Color.ForestGreen) MessageBox.Show("Phone number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pnlEmail.BackColor != Color.ForestGreen) MessageBox.Show("Email address is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (pnlAddress.BackColor != Color.ForestGreen) MessageBox.Show("Address is too short", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else form.Close();

            customer.FullName = txtName.Text;
            customer.ContactNumber = txtPhoneNumber.Text;
            customer.Email = txtEmailAddress.Text;
            customer.Address = txtAddress.Text;
            customer.IsSeniorOrPwd = chkSeniorPwd.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e) => form.Close();

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            if (name.Length > 5) pnlName.BackColor = Color.ForestGreen;
            else pnlName.BackColor = Color.Crimson;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            var phoneNumber = txtPhoneNumber.Text.Trim();
            if (Regex.IsMatch(phoneNumber, @"^(639|09)\d{9}$")) pnlPhoneNumber.BackColor = Color.ForestGreen;
            else pnlPhoneNumber.BackColor = Color.Crimson;
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            var email = txtEmailAddress.Text.Trim();
            if (Regex.IsMatch(email, @"^[\w\d]{1,}@[\w\d]{1,}\.[\w\d]{1,}$")) pnlEmail.BackColor = Color.ForestGreen;
            else pnlEmail.BackColor = Color.Crimson;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            var address = txtAddress.Text.Trim();
            if (address.Length > 7) pnlAddress.BackColor = Color.ForestGreen;
            else pnlAddress.BackColor = Color.Crimson;
        }
    }
}
