namespace AppliancePointOfSale.Views.User_Controls;

public partial class CustomDropDown : UserControl
{
    public string Title
    {
        get => lblTitle.Text;
        set => lblTitle.Text = value;
    }

    public int FontSize
    {
        set
        {
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, value);
            cboDropDown.Font = new Font(cboDropDown.Font.FontFamily, value);
            Height = lblTitle.Font.Height + 10;
        }
    }

    public string[] Items
    {
        get => cboDropDown.Items.OfType<string>().ToArray();
        set => cboDropDown.Items.AddRange(value);
    }

    public int MaxDropDownWidth
    {
        set => Width = value;
    }

    public bool ShouldShowFirstIndex
    {
        set { if (value) cboDropDown.SelectedIndex = 0; }
    }

    public event EventHandler SelectEvent;

    public CustomDropDown()
    {
        InitializeComponent();
        lblTitle.Click += (s, e) => cboDropDown.DroppedDown = true;
        cboDropDown.Click += (s, e) => cboDropDown.DroppedDown = true;
    }

    private void cboDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        cboDropDown.Visible = false;
        Title = $"{cboDropDown.SelectedItem}";
        SelectEvent.Invoke(cboDropDown.SelectedItem, e);
        cboDropDown.Visible = true;
    }
}
