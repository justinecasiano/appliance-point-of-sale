namespace AppliancePointOfSale.Views.User_Controls;

public partial class CustomDropDown : UserControl
{
    public string Title
    {
        get => lblTitle.Text;
        set
        {
            lblTitle.Text = value;
            Width = lblTitle.Width + 21;
            MessageBox.Show(Width.ToString());
        }
    }

    public int FontSize
    {
        set
        {
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, value);
            cboDropDown.Font = new Font(cboDropDown.Font.FontFamily, value);
            Height = lblTitle.Font.Height + 10;
            MessageBox.Show(Height.ToString());
        }
    }

    public string[] Items
    {
        get => cboDropDown.Items.OfType<string>().ToArray();
        set { cboDropDown.Items.AddRange(value); }
    }

    public event EventHandler SelectEvent;

    public CustomDropDown()
    {
        InitializeComponent();
    }

    private void cboDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        cboDropDown.Visible = false;
        Title = $"{cboDropDown.SelectedItem}";
        SelectEvent.Invoke(cboDropDown.SelectedItem, e);
        cboDropDown.Visible = true;
    }
}
