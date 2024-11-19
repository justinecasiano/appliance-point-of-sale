using AppliancePointOfSale.Models;

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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
