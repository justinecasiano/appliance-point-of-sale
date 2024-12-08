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
            flpTransactionsList = new Custom_Controls.CustomFlowLayout();
            pnlHeader = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            flpSummary = new Custom_Controls.CustomFlowLayout();
            lblGuide = new Label();
            pboTransaction = new PictureBox();
            cboSortBy = new CustomDropDown();
            flpTransactionsList.SuspendLayout();
            pnlHeader.SuspendLayout();
            flpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboTransaction).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.Cursor = Cursors.Hand;
            searchBox.Location = new Point(38, 29);
            searchBox.Name = "searchBox";
            searchBox.SearchEvent = null;
            searchBox.Size = new Size(760, 33);
            searchBox.TabIndex = 34;
            // 
            // flpTransactionsList
            // 
            flpTransactionsList.AutoScroll = true;
            flpTransactionsList.BackColor = Color.Transparent;
            flpTransactionsList.BackgroundImage = Properties.Resources.transactios_list_bg;
            flpTransactionsList.BackgroundImageLayout = ImageLayout.Stretch;
            flpTransactionsList.Controls.Add(pnlHeader);
            flpTransactionsList.Location = new Point(47, 81);
            flpTransactionsList.Name = "flpTransactionsList";
            flpTransactionsList.Size = new Size(845, 602);
            flpTransactionsList.TabIndex = 36;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(label3);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(845, 65);
            pnlHeader.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(56, 56, 56);
            label3.Location = new Point(711, 21);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "DATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 56, 56);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "TRANSACTION ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 56, 56);
            label2.Location = new Point(380, 21);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 1;
            label2.Text = "CUSTOMER NAME";
            // 
            // flpSummary
            // 
            flpSummary.AutoScroll = true;
            flpSummary.BackColor = Color.White;
            flpSummary.Controls.Add(lblGuide);
            flpSummary.Controls.Add(pboTransaction);
            flpSummary.Dock = DockStyle.Right;
            flpSummary.FlowDirection = FlowDirection.TopDown;
            flpSummary.Location = new Point(984, 0);
            flpSummary.Name = "flpSummary";
            flpSummary.Size = new Size(317, 711);
            flpSummary.TabIndex = 37;
            flpSummary.WrapContents = false;
            // 
            // lblGuide
            // 
            lblGuide.Font = new Font("Inria Sans", 20F, FontStyle.Bold);
            lblGuide.ForeColor = Color.FromArgb(56, 56, 56);
            lblGuide.Location = new Point(0, 0);
            lblGuide.Margin = new Padding(0);
            lblGuide.Name = "lblGuide";
            lblGuide.Padding = new Padding(17, 0, 0, 0);
            lblGuide.Size = new Size(297, 683);
            lblGuide.TabIndex = 3;
            lblGuide.Text = "Select a Transaction from the table \r\nto view receipt\r\n";
            lblGuide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pboTransaction
            // 
            pboTransaction.Location = new Point(0, 683);
            pboTransaction.Margin = new Padding(0);
            pboTransaction.Name = "pboTransaction";
            pboTransaction.Size = new Size(297, 711);
            pboTransaction.TabIndex = 4;
            pboTransaction.TabStop = false;
            pboTransaction.Visible = false;
            pboTransaction.WaitOnLoad = true;
            // 
            // cboSortBy
            // 
            cboSortBy.Location = new Point(804, 29);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(21, 28);
            cboSortBy.TabIndex = 38;
            cboSortBy.Title = "";
            // 
            // TransactionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.mainview_bg;
            Controls.Add(cboSortBy);
            Controls.Add(flpSummary);
            Controls.Add(flpTransactionsList);
            Controls.Add(searchBox);
            Name = "TransactionsView";
            Size = new Size(1301, 711);
            flpTransactionsList.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SearchBox searchBox;
        private Custom_Controls.CustomFlowLayout flpTransactionsList;
        private Panel pnlHeader;
        private Label label1;
        private Label label2;
        private Label label3;
        private Custom_Controls.CustomFlowLayout flpSummary;
        private Label lblGuide;
        private PictureBox pboTransaction;
        private CustomDropDown cboSortBy;
    }
}
