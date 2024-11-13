using AppliancePointOfSale.Models;
using AppliancePointOfSale.Views.Interfaces;

namespace AppliancePointOfSale.Views
{
    public partial class MainView : Form, IMainView
    {

        public Form Dialog { get; init; }
        public Panel PlaceHolder { get => pnlMiddle; }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private bool IsMenuOpen;

        public event EventHandler ChangeViewEvent;
        public event EventHandler NotifyEvent;

        public MainView()
        {
            InitializeComponent();
            Dialog = new Dialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (IsMenuOpen)
            {
                pnlSide.Size = new Size(76, 554);
            }
            else
            {
                pnlSide.Size = new Size(200, 554);
            }
            IsMenuOpen = !IsMenuOpen;
            Dialog.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var selected = MessageBox.Show(this, "Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selected == DialogResult.Yes) Application.Exit();
        }
    }
}
