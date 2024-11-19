using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views;

public partial class LineItemView : UserControl
{
    public int Quantity
    {
        get => int.Parse(lblQuantity.Text.Replace("X", ""));
        set => lblQuantity.Text = value + "X";
    }

    public LineItem LineItem { get; set; }
    private EventHandler UpdateLineItemEvent;

    public LineItemView(LineItem item, EventHandler updateLineItem)
    {
        InitializeComponent();
        LineItem = item;
        Name = item.ID;
        lblApplianceName.Text = item.Name;
        lblPrice.Text = $"₱ {item.Price:N2}";
        lblQuantity.Text = $"{item.Quantity}X";
        UpdateLineItemEvent += updateLineItem;

        AdjustHeight();
    }

    public void HideControls()
    {
        btnAdd.Visible = false;
        btnSubtract.Visible = false;
        BorderStyle = BorderStyle.None;
    }

    public void UndoHideControls()
    {
        btnAdd.Visible = true;
        btnSubtract.Visible = true;
        BorderStyle = BorderStyle.FixedSingle;
    }

    public void AdjustHeight()
    {
        if (lblApplianceName.Height > 15) this.Height += lblApplianceName.Height - 15;
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        LineItem.Quantity--;
        UpdateLineItemEvent.Invoke(LineItem, e);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        LineItem.Quantity++;
        UpdateLineItemEvent.Invoke(LineItem, e);
    }
}
