using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Views;

public partial class MainView : Form, IMainView
{

    public List<UserControl> Views { get; set; }
    public event EventHandler ChangeViewEvent;
    private string CurrentView { get; set; }

    public MainView()
    {
        InitializeComponent();
    }

    public void ChangeView(string view)
    {
        if (CurrentView == view) return;
        CurrentView = view;

        pnlMiddle.Visible = false;
        pnlMiddle.Controls.Clear();
        pnlMiddle.Controls.Add(Views.Find(v => v.Name == view));
        pnlMiddle.Visible = true;
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var selected = MessageBox.Show(this, "Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (selected == DialogResult.Yes) Application.Exit();
    }

    private void btnCheckout_Click(object sender, EventArgs e)
    {
        btnCheckout.BackgroundImage = Properties.Resources.checkout_icon_white;
        btnTransaction.BackgroundImage = Properties.Resources.transaction_icon_black;

        Task.Delay(200).Wait();
        ChangeViewEvent.Invoke("CheckoutView", e);
    }

    private void btnTransaction_Click(object sender, EventArgs e)
    {
        btnTransaction.BackgroundImage = Properties.Resources.transaction_icon_white;
        btnCheckout.BackgroundImage = Properties.Resources.checkout_icon_black;

        Task.Delay(200).Wait();
        ChangeViewEvent.Invoke("TransactionsView", e);
    }
}
