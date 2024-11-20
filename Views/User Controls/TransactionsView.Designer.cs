namespace AppliancePointOfSale.Views.User_Controls
{
    partial class TransactionsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchBox = new SearchBox();
            pnlSummary = new Panel();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.Cursor = Cursors.Hand;
            searchBox.Location = new Point(42, 29);
            searchBox.Name = "searchBox";
            searchBox.SearchEvent = null;
            searchBox.Size = new Size(834, 33);
            searchBox.TabIndex = 34;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Dock = DockStyle.Right;
            pnlSummary.Location = new Point(984, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(317, 711);
            pnlSummary.TabIndex = 23;
            // 
            // TransactionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.mainview_bg;
            Controls.Add(searchBox);
            Controls.Add(pnlSummary);
            Name = "TransactionsView";
            Size = new Size(1301, 711);
            ResumeLayout(false);
        }

        #endregion
        private SearchBox searchBox;
        private Panel pnlSummary;
    }
}
