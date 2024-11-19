namespace AppliancePointOfSale.Views.Custom_Controls;

public class CustomFlowLayout : FlowLayoutPanel
{
    public CustomFlowLayout()
    {
        DoubleBuffered = true;
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;
            return cp;
        }
    }

    protected override void OnScroll(ScrollEventArgs se)
    {
        Invalidate();
        base.OnScroll(se);
    }
}
