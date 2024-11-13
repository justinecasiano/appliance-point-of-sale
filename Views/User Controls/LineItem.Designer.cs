namespace AppliancePointOfSale.Views
{
    partial class LineItem
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
            pnlLineItem = new Panel();
            panel3 = new Panel();
            lblQuantity = new Label();
            btnAddQuantity = new Label();
            btnSubtractQuantity = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblApplianceName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblPrice = new Label();
            pnlLineItem.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLineItem
            // 
            pnlLineItem.BorderStyle = BorderStyle.FixedSingle;
            pnlLineItem.Controls.Add(panel3);
            pnlLineItem.Controls.Add(flowLayoutPanel1);
            pnlLineItem.Dock = DockStyle.Fill;
            pnlLineItem.Location = new Point(0, 0);
            pnlLineItem.Name = "pnlLineItem";
            pnlLineItem.Size = new Size(262, 44);
            pnlLineItem.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblQuantity);
            panel3.Controls.Add(btnAddQuantity);
            panel3.Controls.Add(btnSubtractQuantity);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 42);
            panel3.TabIndex = 18;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(255, 214, 0);
            lblQuantity.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(23, 10);
            lblQuantity.MaximumSize = new Size(40, 23);
            lblQuantity.MinimumSize = new Size(40, 23);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(40, 23);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "99X";
            lblQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddQuantity
            // 
            btnAddQuantity.AutoSize = true;
            btnAddQuantity.BackColor = Color.Transparent;
            btnAddQuantity.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            btnAddQuantity.ForeColor = Color.FromArgb(56, 56, 56);
            btnAddQuantity.Location = new Point(61, 8);
            btnAddQuantity.Margin = new Padding(0);
            btnAddQuantity.Name = "btnAddQuantity";
            btnAddQuantity.Size = new Size(24, 25);
            btnAddQuantity.TabIndex = 17;
            btnAddQuantity.Text = "+";
            // 
            // btnSubtractQuantity
            // 
            btnSubtractQuantity.AutoSize = true;
            btnSubtractQuantity.BackColor = Color.Transparent;
            btnSubtractQuantity.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            btnSubtractQuantity.ForeColor = Color.FromArgb(56, 56, 56);
            btnSubtractQuantity.Location = new Point(5, 9);
            btnSubtractQuantity.Margin = new Padding(0);
            btnSubtractQuantity.Name = "btnSubtractQuantity";
            btnSubtractQuantity.Size = new Size(20, 25);
            btnSubtractQuantity.TabIndex = 18;
            btnSubtractQuantity.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblApplianceName);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(88, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(172, 42);
            flowLayoutPanel1.TabIndex = 17;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblApplianceName
            // 
            lblApplianceName.AutoSize = true;
            lblApplianceName.Dock = DockStyle.Top;
            lblApplianceName.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblApplianceName.ForeColor = Color.FromArgb(63, 63, 63);
            lblApplianceName.Location = new Point(3, 0);
            lblApplianceName.Name = "lblApplianceName";
            lblApplianceName.Size = new Size(180, 15);
            lblApplianceName.TabIndex = 17;
            lblApplianceName.Text = "Hanabishi Portable ";
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 1);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPrice);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 17);
            panel2.TabIndex = 20;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(0, 0);
            lblPrice.MaximumSize = new Size(120, 15);
            lblPrice.MinimumSize = new Size(120, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 15);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "₱ 142,497.00";
            // 
            // LineItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLineItem);
            Name = "LineItem";
            Size = new Size(262, 44);
            pnlLineItem.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLineItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblApplianceName;
        private Panel panel1;
        private Panel panel2;
        private Label lblPrice;
        private Panel panel3;
        private Label lblQuantity;
        private Label btnAddQuantity;
        private Label btnSubtractQuantity;
    }
}
