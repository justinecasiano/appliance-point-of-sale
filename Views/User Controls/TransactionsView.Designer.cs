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
            pnlSummary = new Panel();
            flpTransactionDetails = new FlowLayoutPanel();
            pnlAmount = new Panel();
            lblAmount = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblDiscount = new Label();
            label6 = new Label();
            pnlVAT = new Panel();
            lblVAT = new Label();
            label7 = new Label();
            panel3 = new Panel();
            lblTotalAmount = new Label();
            label3 = new Label();
            pnlTotalPaid = new Panel();
            lblTotalPaid = new Label();
            label16 = new Label();
            pnlChange = new Panel();
            lblChange = new Label();
            label5 = new Label();
            flpLineItems = new FlowLayoutPanel();
            flpCustomer = new FlowLayoutPanel();
            lblFullName = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblTransactionID = new Label();
            lblDate = new Label();
            button1 = new Button();
            label10 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnSummary = new Button();
            pnlHighlight = new Panel();
            searchBox = new SearchBox();
            pnlSummary.SuspendLayout();
            flpTransactionDetails.SuspendLayout();
            pnlAmount.SuspendLayout();
            panel1.SuspendLayout();
            pnlVAT.SuspendLayout();
            panel3.SuspendLayout();
            pnlTotalPaid.SuspendLayout();
            pnlChange.SuspendLayout();
            flpCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(flpTransactionDetails);
            pnlSummary.Controls.Add(flpLineItems);
            pnlSummary.Controls.Add(flpCustomer);
            pnlSummary.Controls.Add(lblTransactionID);
            pnlSummary.Controls.Add(lblDate);
            pnlSummary.Controls.Add(button1);
            pnlSummary.Controls.Add(label10);
            pnlSummary.Controls.Add(panel2);
            pnlSummary.Controls.Add(label1);
            pnlSummary.Controls.Add(btnSummary);
            pnlSummary.Controls.Add(pnlHighlight);
            pnlSummary.Dock = DockStyle.Right;
            pnlSummary.Location = new Point(904, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(317, 554);
            pnlSummary.TabIndex = 3;
            // 
            // flpTransactionDetails
            // 
            flpTransactionDetails.AutoScroll = true;
            flpTransactionDetails.Controls.Add(pnlAmount);
            flpTransactionDetails.Controls.Add(panel1);
            flpTransactionDetails.Controls.Add(pnlVAT);
            flpTransactionDetails.Controls.Add(panel3);
            flpTransactionDetails.Controls.Add(pnlTotalPaid);
            flpTransactionDetails.Controls.Add(pnlChange);
            flpTransactionDetails.FlowDirection = FlowDirection.TopDown;
            flpTransactionDetails.Location = new Point(19, 364);
            flpTransactionDetails.Name = "flpTransactionDetails";
            flpTransactionDetails.Size = new Size(288, 112);
            flpTransactionDetails.TabIndex = 15;
            flpTransactionDetails.WrapContents = false;
            // 
            // pnlAmount
            // 
            pnlAmount.Controls.Add(lblAmount);
            pnlAmount.Controls.Add(label4);
            pnlAmount.Location = new Point(3, 3);
            pnlAmount.Name = "pnlAmount";
            pnlAmount.Size = new Size(255, 15);
            pnlAmount.TabIndex = 16;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Right;
            lblAmount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(56, 56, 56);
            lblAmount.Location = new Point(149, 0);
            lblAmount.MaximumSize = new Size(106, 19);
            lblAmount.MinimumSize = new Size(106, 19);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(106, 19);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "₱ 0.00";
            lblAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(56, 56, 56);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Amount:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 22);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 15);
            panel1.TabIndex = 20;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Dock = DockStyle.Right;
            lblDiscount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.FromArgb(56, 56, 56);
            lblDiscount.Location = new Point(149, 0);
            lblDiscount.MaximumSize = new Size(106, 19);
            lblDiscount.MinimumSize = new Size(106, 19);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(106, 19);
            lblDiscount.TabIndex = 11;
            lblDiscount.Text = "₱ 0.00";
            lblDiscount.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(56, 56, 56);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 10;
            label6.Text = "Senior/PWD Discount:";
            // 
            // pnlVAT
            // 
            pnlVAT.Controls.Add(lblVAT);
            pnlVAT.Controls.Add(label7);
            pnlVAT.Location = new Point(3, 41);
            pnlVAT.Name = "pnlVAT";
            pnlVAT.Size = new Size(255, 15);
            pnlVAT.TabIndex = 17;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Dock = DockStyle.Right;
            lblVAT.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblVAT.ForeColor = Color.FromArgb(56, 56, 56);
            lblVAT.Location = new Point(149, 0);
            lblVAT.MaximumSize = new Size(106, 19);
            lblVAT.MinimumSize = new Size(106, 19);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(106, 19);
            lblVAT.TabIndex = 11;
            lblVAT.Text = "₱ 0.00";
            lblVAT.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(56, 56, 56);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 10;
            label7.Text = "VAT:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalAmount);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 15);
            panel3.TabIndex = 19;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Dock = DockStyle.Right;
            lblTotalAmount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(56, 56, 56);
            lblTotalAmount.Location = new Point(149, 0);
            lblTotalAmount.MaximumSize = new Size(106, 19);
            lblTotalAmount.MinimumSize = new Size(106, 19);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(106, 19);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "₱ 0.00";
            lblTotalAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(56, 56, 56);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 10;
            label3.Text = "Total Amount: ";
            // 
            // pnlTotalPaid
            // 
            pnlTotalPaid.Controls.Add(lblTotalPaid);
            pnlTotalPaid.Controls.Add(label16);
            pnlTotalPaid.Location = new Point(3, 83);
            pnlTotalPaid.Name = "pnlTotalPaid";
            pnlTotalPaid.Size = new Size(255, 15);
            pnlTotalPaid.TabIndex = 18;
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Dock = DockStyle.Right;
            lblTotalPaid.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblTotalPaid.ForeColor = Color.FromArgb(56, 56, 56);
            lblTotalPaid.Location = new Point(149, 0);
            lblTotalPaid.MaximumSize = new Size(106, 19);
            lblTotalPaid.MinimumSize = new Size(106, 19);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(106, 19);
            lblTotalPaid.TabIndex = 11;
            lblTotalPaid.Text = "₱ 0.00";
            lblTotalPaid.TextAlign = ContentAlignment.TopRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Left;
            label16.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(56, 56, 56);
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 10;
            label16.Text = "Total Paid:";
            // 
            // pnlChange
            // 
            pnlChange.Controls.Add(lblChange);
            pnlChange.Controls.Add(label5);
            pnlChange.Location = new Point(3, 104);
            pnlChange.Name = "pnlChange";
            pnlChange.Size = new Size(255, 15);
            pnlChange.TabIndex = 17;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Dock = DockStyle.Right;
            lblChange.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblChange.ForeColor = Color.FromArgb(56, 56, 56);
            lblChange.Location = new Point(149, 0);
            lblChange.MaximumSize = new Size(106, 19);
            lblChange.MinimumSize = new Size(106, 19);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(106, 19);
            lblChange.TabIndex = 11;
            lblChange.Text = "₱ 0.00";
            lblChange.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(56, 56, 56);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Change:";
            // 
            // flpLineItems
            // 
            flpLineItems.AutoScroll = true;
            flpLineItems.FlowDirection = FlowDirection.TopDown;
            flpLineItems.Location = new Point(19, 248);
            flpLineItems.Name = "flpLineItems";
            flpLineItems.Size = new Size(288, 110);
            flpLineItems.TabIndex = 14;
            flpLineItems.WrapContents = false;
            // 
            // flpCustomer
            // 
            flpCustomer.AutoScroll = true;
            flpCustomer.Controls.Add(lblFullName);
            flpCustomer.Controls.Add(lblContact);
            flpCustomer.Controls.Add(lblEmail);
            flpCustomer.Controls.Add(lblAddress);
            flpCustomer.FlowDirection = FlowDirection.TopDown;
            flpCustomer.Location = new Point(13, 167);
            flpCustomer.Name = "flpCustomer";
            flpCustomer.Size = new Size(243, 78);
            flpCustomer.TabIndex = 0;
            flpCustomer.WrapContents = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(3, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(122, 19);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "Customer Name: ";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Inria Sans", 10F);
            lblContact.ForeColor = Color.FromArgb(65, 65, 65);
            lblContact.Location = new Point(3, 19);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(107, 18);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Inria Sans", 10F);
            lblEmail.ForeColor = Color.FromArgb(65, 65, 65);
            lblEmail.Location = new Point(3, 37);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 18);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Inria Sans", 10F);
            lblAddress.ForeColor = Color.FromArgb(65, 65, 65);
            lblAddress.Location = new Point(3, 55);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 18);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Inria Sans", 10F);
            lblTransactionID.ForeColor = Color.FromArgb(65, 65, 65);
            lblTransactionID.Location = new Point(16, 145);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(94, 18);
            lblTransactionID.TabIndex = 5;
            lblTransactionID.Text = "Transaction ID";
            lblTransactionID.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Inria Sans", 10F);
            lblDate.ForeColor = Color.FromArgb(65, 65, 65);
            lblDate.Location = new Point(16, 127);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(88, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "Day and Date";
            lblDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.hanabishi_logo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(100, 93);
            button1.Name = "button1";
            button1.Size = new Size(114, 24);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inria Sans", 9F);
            label10.ForeColor = Color.FromArgb(65, 65, 65);
            label10.Location = new Point(34, 56);
            label10.Name = "label10";
            label10.Size = new Size(249, 30);
            label10.TabIndex = 2;
            label10.Text = "Blk. 2 Lot 14, Avanti St., Sterling Industrial Park,\r\nBarrio Iba, Meycauayan Bulacan";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 49, 37);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 542);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 10);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            label1.Location = new Point(51, 28);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 1;
            label1.Text = "PURCHASE SUMMARY";
            // 
            // btnSummary
            // 
            btnSummary.BackColor = Color.FromArgb(255, 5, 19);
            btnSummary.FlatAppearance.BorderSize = 0;
            btnSummary.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSummary.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSummary.FlatStyle = FlatStyle.Flat;
            btnSummary.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnSummary.ForeColor = Color.White;
            btnSummary.Location = new Point(16, 485);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(288, 45);
            btnSummary.TabIndex = 0;
            btnSummary.Text = "TRANSACTION STATUS";
            btnSummary.UseVisualStyleBackColor = false;
            // 
            // pnlHighlight
            // 
            pnlHighlight.BackColor = Color.FromArgb(191, 49, 37);
            pnlHighlight.Dock = DockStyle.Top;
            pnlHighlight.Location = new Point(0, 0);
            pnlHighlight.Name = "pnlHighlight";
            pnlHighlight.Size = new Size(315, 10);
            pnlHighlight.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.Location = new Point(40, 31);
            searchBox.Name = "searchBox";
            searchBox.SearchEvent = null;
            searchBox.Size = new Size(749, 33);
            searchBox.TabIndex = 23;
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
            Size = new Size(1221, 554);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            flpTransactionDetails.ResumeLayout(false);
            pnlAmount.ResumeLayout(false);
            pnlAmount.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlVAT.ResumeLayout(false);
            pnlVAT.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlTotalPaid.ResumeLayout(false);
            pnlTotalPaid.PerformLayout();
            pnlChange.ResumeLayout(false);
            pnlChange.PerformLayout();
            flpCustomer.ResumeLayout(false);
            flpCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSummary;
        private FlowLayoutPanel flpTransactionDetails;
        private Panel pnlAmount;
        private Label lblAmount;
        private Label label4;
        private Panel pnlVAT;
        private Label lblVAT;
        private Label label7;
        private Panel panel3;
        private Label lblTotalAmount;
        private Label label3;
        private Panel pnlTotalPaid;
        private Label lblTotalPaid;
        private Label label16;
        private Panel pnlChange;
        private Label lblChange;
        private Label label5;
        private FlowLayoutPanel flpLineItems;
        private FlowLayoutPanel flpCustomer;
        private Label lblFullName;
        private Label lblContact;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblTransactionID;
        private Label lblDate;
        private Button button1;
        private Label label10;
        private Panel panel2;
        private Label label1;
        private Button btnSummary;
        private Panel pnlHighlight;
        private SearchBox searchBox;
        private Panel panel1;
        private Label lblDiscount;
        private Label label6;
    }
}
