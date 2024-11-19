using AppliancePointOfSale.Models;
using System.ComponentModel;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class ApplianceItemView : UserControl
{
    public string ID { get => Name; }
    public string ApplianceName { get => lblName.Text; }
    public string Price { get => lblPrice.Text; }
    public string Stock { get => lblStocks.Text; }
    public string Category { get; init; }

    private EventHandler ApplianceSelectedEvent { get; set; }
    private EventHandler AddLineItemEvent { get; set; }
    private EventHandler EditApplianceEvent { get; set; }

    public ApplianceItemView(Appliance appliance, EventHandler applianceSelectedEvent, EventHandler addLineItemEvent, EventHandler editApplianceEvent)
    {
        InitializeComponent();
        Name = appliance.ID;
        Category = appliance.Category;
        lblName.Text = appliance.Name;
        lblPrice.Text = $"₱ {appliance.Price:N2}";
        lblStocks.Text = appliance.InStock ? $"In Stock: {appliance.Stocks}" : "Out of Stock";
        pnlThumbnail.BackgroundImage = Image.FromFile($@"../../../Assets/Appliances/{appliance.Category}/{appliance.Name}.png");

        ApplianceSelectedEvent += applianceSelectedEvent;
        AddLineItemEvent += addLineItemEvent;
        EditApplianceEvent += editApplianceEvent;

        AdjustHeight();
        DetectHit();
    }

    public void AdjustHeight()
    {
        if (lblName.Height > 18) Height += lblName.Height - 18;
    }

    public void DetectHit()
    {
        foreach (Control control in flpHitbox.Controls) control.Click += flpHitbox_Click;
        lblPrice.Click += flpHitbox_Click;
        lblStocks.Click += flpHitbox_Click;
    }

    private void flpHitbox_Click(object sender, EventArgs e)
    {
        ApplianceSelectedEvent.Invoke(this, e);
    }

    private void btnAddToCheckout_Click(object sender, EventArgs e)
    {
        AddLineItemEvent.Invoke(Name, e);
    }

    private void btnEditAppliance_Click(object sender, EventArgs e)
    {
        EditApplianceEvent.Invoke(Name, e);
    }
}
