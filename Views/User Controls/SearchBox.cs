namespace AppliancePointOfSale.Views.User_Controls
{
    public partial class SearchBox : UserControl
    {

        public EventHandler SearchEvent { get; set; }

        private string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }

        public SearchBox()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtSearch.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            SearchEvent?.Invoke(SearchValue, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                SearchEvent?.Invoke(SearchValue, e);
                return;
            }
            timer.Stop();
            timer.Start();
        }
    }
}
