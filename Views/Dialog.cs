namespace AppliancePointOfSale.Views;

public partial class Dialog : Form
{
    public Dialog()
    {
        InitializeComponent();
    }

    public void Add(UserControl control)
    {
        Size = control.Size;
        control.Dock = DockStyle.Fill;

        Controls.Clear();
        Controls.Add(control);
    }

}
