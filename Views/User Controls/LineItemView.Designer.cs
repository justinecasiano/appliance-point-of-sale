namespace AppliancePointOfSale.Views
{
    partial class LineItemView
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
            pnlQuantity = new Panel();
            lblQuantity = new Label();
            btnAdd = new Label();
            btnSubtract = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblApplianceName = new Label();
            lblPrice = new Label();
            pnlQuantity.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlQuantity
            // 
            pnlQuantity.Controls.Add(lblQuantity);
            pnlQuantity.Controls.Add(btnAdd);
            pnlQuantity.Controls.Add(btnSubtract);
            pnlQuantity.Dock = DockStyle.Left;
            pnlQuantity.Location = new Point(0, 0);
            pnlQuantity.Name = "pnlQuantity";
            pnlQuantity.Size = new Size(89, 47);
            pnlQuantity.TabIndex = 23;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(255, 214, 0);
            lblQuantity.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(25, 9);
            lblQuantity.MaximumSize = new Size(40, 30);
            lblQuantity.MinimumSize = new Size(40, 30);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(40, 30);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "1X";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Inria Sans", 18F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(56, 56, 56);
            btnAdd.Location = new Point(64, 8);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(27, 30);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.AutoSize = true;
            btnSubtract.BackColor = Color.Transparent;
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.Font = new Font("Inria Sans", 18F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.FromArgb(56, 56, 56);
            btnSubtract.Location = new Point(3, 9);
            btnSubtract.Margin = new Padding(0);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(23, 30);
            btnSubtract.TabIndex = 18;
            btnSubtract.Text = "-";
            btnSubtract.Click += btnSubtract_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblApplianceName);
            flowLayoutPanel1.Controls.Add(lblPrice);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(88, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(179, 47);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // lblApplianceName
            // 
            lblApplianceName.AutoSize = true;
            lblApplianceName.Dock = DockStyle.Top;
            lblApplianceName.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            lblApplianceName.ForeColor = Color.FromArgb(63, 63, 63);
            lblApplianceName.Location = new Point(5, 5);
            lblApplianceName.Margin = new Padding(5, 5, 5, 2);
            lblApplianceName.Name = "lblApplianceName";
            lblApplianceName.Size = new Size(66, 18);
            lblApplianceName.TabIndex = 26;
            lblApplianceName.Text = "Line Item";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(3, 25);
            lblPrice.MaximumSize = new Size(170, 15);
            lblPrice.MinimumSize = new Size(170, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(170, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "₱ 0.00";
            lblPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // LineItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlQuantity);
            Margin = new Padding(0);
            Name = "LineItemView";
            Size = new Size(267, 47);
            pnlQuantity.ResumeLayout(false);
            pnlQuantity.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlQuantity;
        private Label lblQuantity;
        private Label btnAdd;
        private Label btnSubtract;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblApplianceName;
        private Label lblPrice;
    }
}
