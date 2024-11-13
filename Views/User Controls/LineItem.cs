namespace AppliancePointOfSale.Views;

public partial class LineItem : UserControl
{
    public LineItem()
    {
        InitializeComponent();
    }

    public LineItem(string name, decimal price, int quantity, EventHandler subtract, EventHandler add)
    {
        InitializeComponent();
        lblApplianceName.Text = name;
        lblPrice.Text = $"₱ {price:N2}";
        lblQuantity.Text = $"{quantity}X";
        btnSubtractQuantity.Click += subtract;
        btnAddQuantity.Click += add;

        AdjustHeight();
    }

    public void AdjustHeight()
    {
        if (lblApplianceName.Height > 15) this.Height += lblApplianceName.Height - 15;
    }
}
