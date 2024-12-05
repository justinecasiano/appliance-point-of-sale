namespace AppliancePointOfSale.Views.User_Controls
{
    partial class TransactionItemView
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
            pnlHeader = new Panel();
            lblDate = new Label();
            lblTransactionID = new Label();
            lblCustomerName = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Controls.Add(lblTransactionID);
            pnlHeader.Controls.Add(lblCustomerName);
            pnlHeader.Cursor = Cursors.Hand;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(843, 63);
            pnlHeader.TabIndex = 1;
            pnlHeader.Click += pnlHeader_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(56, 56, 56);
            lblDate.Location = new Point(711, 20);
            lblDate.MaximumSize = new Size(110, 23);
            lblDate.MinimumSize = new Size(110, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(110, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "DATE";
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblTransactionID.ForeColor = Color.FromArgb(56, 56, 56);
            lblTransactionID.Location = new Point(44, 20);
            lblTransactionID.MaximumSize = new Size(260, 23);
            lblTransactionID.MinimumSize = new Size(260, 23);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(260, 23);
            lblTransactionID.TabIndex = 0;
            lblTransactionID.Text = "TRANSACTION ID";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.FromArgb(56, 56, 56);
            lblCustomerName.Location = new Point(380, 20);
            lblCustomerName.MaximumSize = new Size(280, 0);
            lblCustomerName.MinimumSize = new Size(280, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(280, 23);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "CUSTOMER NAME";
            // 
            // TransactionItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(172, 172, 172);
            Controls.Add(pnlHeader);
            Margin = new Padding(0);
            Name = "TransactionItemView";
            Padding = new Padding(1);
            Size = new Size(845, 65);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDate;
        private Label lblTransactionID;
        private Label lblCustomerName;
    }
}
