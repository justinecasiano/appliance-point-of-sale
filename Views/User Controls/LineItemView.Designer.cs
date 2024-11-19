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
            panel3 = new Panel();
            lblQuantity = new Label();
            btnAdd = new Label();
            btnSubtract = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblApplianceName = new Label();
            lblPrice = new Label();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(lblQuantity);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnSubtract);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 48);
            panel3.TabIndex = 23;
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
            lblQuantity.Text = "1X";
            lblQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(56, 56, 56);
            btnAdd.Location = new Point(61, 8);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(24, 25);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.AutoSize = true;
            btnSubtract.BackColor = Color.Transparent;
            btnSubtract.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.FromArgb(56, 56, 56);
            btnSubtract.Location = new Point(5, 9);
            btnSubtract.Margin = new Padding(0);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(20, 25);
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
            flowLayoutPanel1.Size = new Size(179, 48);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // lblApplianceName
            // 
            lblApplianceName.AutoSize = true;
            lblApplianceName.Dock = DockStyle.Top;
            lblApplianceName.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblApplianceName.ForeColor = Color.FromArgb(63, 63, 63);
            lblApplianceName.Location = new Point(5, 5);
            lblApplianceName.Margin = new Padding(5);
            lblApplianceName.Name = "lblApplianceName";
            lblApplianceName.Size = new Size(57, 15);
            lblApplianceName.TabIndex = 26;
            lblApplianceName.Text = "Line Item";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
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
            Controls.Add(panel3);
            Margin = new Padding(0);
            Name = "LineItemView";
            Size = new Size(267, 48);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label lblQuantity;
        private Label btnAdd;
        private Label btnSubtract;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblApplianceName;
        private Label lblPrice;
    }
}
