using AppliancePointOfSale.Presenters;

namespace AppliancePointOfSale.Views;

public partial class Login : Form
{
    private MainPresenter mainPresenter;

    public Login(MainPresenter presenter)
    {
        InitializeComponent();
        this.mainPresenter = presenter;
    }

    private void frmHanabishi_Load(object sender, EventArgs e)
    {
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtPassword.PasswordChar = '*';
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {

        if (txtUsername.Text == "Semaphore" && txtPassword.Text == "Group1")
        {
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            var view = mainPresenter.MainView as Form;
            view.ShowDialog();
            this.Close();

        }
        else
        {
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
        }
    }


    private void btnShowpassword_Click(object sender, EventArgs e)
    {
        if (txtPassword.PasswordChar == '*')
        {
            txtPassword.PasswordChar = '\0';
            txtUsername.ForeColor = Color.Black;
        }
        else
        {
            txtPassword.PasswordChar = '*';
            txtUsername.ForeColor = Color.Black;
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        var choice = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (choice == DialogResult.Yes) Close();
    }
}
