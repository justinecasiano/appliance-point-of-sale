using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views.User_Controls;

public partial class ApplianceItemView : UserControl
{
    public string ID { get => Name; set => Name = value; }
    public string ApplianceName { get => lblName.Text; set => lblName.Text = value; }
    public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
    public string Stocks { get => lblStocks.Text; set => lblStocks.Text = (int.Parse(value) > 0 ? $"In Stock: {value}" : "Out of Stock"); }
    public string Category;

    private string path;
    public string Thumbnail
    {
        get => path;
        set
        {
            path = $@"../../../Assets/Appliances/{value}.png";
            pnlThumbnail.BackgroundImage = Image.FromFile(path);
        }
    }

    private Appliance appliance;
    private Action<Appliance> currentlyEditing;
    private EventHandler ApplianceSelectedEvent;
    private EventHandler AddLineItemEvent;
    private EventHandler EditApplianceEvent;

    public ApplianceItemView(
        Appliance appliance,
        EventHandler applianceSelectedEvent,
        EventHandler addLineItemEvent,
        EventHandler editApplianceEvent,
        Action<Appliance> currentlyEditing)
    {
        InitializeComponent();
        Name = appliance.ID;
        Category = appliance.Category;
        ApplianceName = appliance.Name;
        Price = $"₱ {appliance.Price:N2}";
        Stocks = appliance.Stocks.ToString();
        Thumbnail = $"{appliance.Category}/{appliance.Name}";
        this.appliance = appliance;
        this.currentlyEditing = currentlyEditing;
        numEditStocks.Value = appliance.Stocks;

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
    private void btnEditAppliance_Click(object sender, EventArgs e)
    {
        currentlyEditing(appliance);
        pnlEditStocks.Visible = true;
        pnlInfo.Visible = false;
        Height -= 26;
    }

    private void btnCancelEdit_Click(object sender, EventArgs e)
    {
        currentlyEditing(null);
        pnlEditStocks.Visible = false;
        pnlInfo.Visible = true;
        Height += 26;
    }

    private void flpHitbox_Click(object sender, EventArgs e)
        => ApplianceSelectedEvent.Invoke(this, e);

    private void btnAddToCheckout_Click(object sender, EventArgs e)
        => AddLineItemEvent.Invoke(Name, e);

    private void btnConfirmEdit_Click(object sender, EventArgs e)
    {
        appliance.Stocks = (int)numEditStocks.Value;
        EditApplianceEvent.Invoke(appliance, e);
    }
}
