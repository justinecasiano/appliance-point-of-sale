namespace AppliancePointOfSale.Views.User_Controls
{
    partial class ApplianceItemView
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
            flpHitbox = new FlowLayoutPanel();
            pnlThumbnail = new Panel();
            panel2 = new Panel();
            lblName = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblPrice = new Label();
            lblStocks = new Label();
            flpOptions = new FlowLayoutPanel();
            btnAddToCheckout = new Button();
            btnEditAppliance = new Button();
            flpHitbox.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // flpHitbox
            // 
            flpHitbox.BackColor = Color.White;
            flpHitbox.Controls.Add(pnlThumbnail);
            flpHitbox.Controls.Add(panel2);
            flpHitbox.Controls.Add(lblName);
            flpHitbox.Controls.Add(flowLayoutPanel2);
            flpHitbox.Controls.Add(flpOptions);
            flpHitbox.Dock = DockStyle.Fill;
            flpHitbox.Location = new Point(3, 3);
            flpHitbox.Margin = new Padding(0);
            flpHitbox.Name = "flpHitbox";
            flpHitbox.Size = new Size(249, 229);
            flpHitbox.TabIndex = 1;
            flpHitbox.Click += flpHitbox_Click;
            // 
            // pnlThumbnail
            // 
            pnlThumbnail.BackColor = Color.White;
            pnlThumbnail.BackgroundImageLayout = ImageLayout.Center;
            pnlThumbnail.Dock = DockStyle.Top;
            pnlThumbnail.Location = new Point(0, 0);
            pnlThumbnail.Margin = new Padding(0);
            pnlThumbnail.Name = "pnlThumbnail";
            pnlThumbnail.Size = new Size(255, 166);
            pnlThumbnail.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(172, 172, 172);
            panel2.Location = new Point(0, 170);
            panel2.Margin = new Padding(0, 4, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 2);
            panel2.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(63, 63, 63);
            lblName.Location = new Point(10, 182);
            lblName.Margin = new Padding(10, 10, 10, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(221, 18);
            lblName.TabIndex = 3;
            lblName.Text = "Hanabishi Portable Airconditioner ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblPrice);
            flowLayoutPanel2.Controls.Add(lblStocks);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 203);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(252, 28);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(56, 56, 56);
            lblPrice.Location = new Point(10, 5);
            lblPrice.Margin = new Padding(10, 5, 0, 10);
            lblPrice.MaximumSize = new Size(120, 18);
            lblPrice.MinimumSize = new Size(120, 18);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 18);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "₱ 17,899.00";
            // 
            // lblStocks
            // 
            lblStocks.AutoSize = true;
            lblStocks.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            lblStocks.ForeColor = Color.FromArgb(112, 112, 112);
            lblStocks.Location = new Point(130, 5);
            lblStocks.Margin = new Padding(0, 5, 10, 10);
            lblStocks.MaximumSize = new Size(112, 18);
            lblStocks.MinimumSize = new Size(112, 18);
            lblStocks.Name = "lblStocks";
            lblStocks.Size = new Size(112, 18);
            lblStocks.TabIndex = 5;
            lblStocks.Text = "In stock 4";
            lblStocks.TextAlign = ContentAlignment.TopRight;
            // 
            // flpOptions
            // 
            flpOptions.BackColor = Color.FromArgb(255, 5, 19);
            flpOptions.Controls.Add(btnAddToCheckout);
            flpOptions.Controls.Add(btnEditAppliance);
            flpOptions.Dock = DockStyle.Top;
            flpOptions.Location = new Point(0, 231);
            flpOptions.Margin = new Padding(0);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(252, 30);
            flpOptions.TabIndex = 6;
            // 
            // btnAddToCheckout
            // 
            btnAddToCheckout.FlatAppearance.BorderColor = Color.White;
            btnAddToCheckout.FlatAppearance.BorderSize = 0;
            btnAddToCheckout.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 5, 19);
            btnAddToCheckout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 5, 19);
            btnAddToCheckout.FlatStyle = FlatStyle.Flat;
            btnAddToCheckout.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            btnAddToCheckout.ForeColor = Color.White;
            btnAddToCheckout.Location = new Point(3, 3);
            btnAddToCheckout.Name = "btnAddToCheckout";
            btnAddToCheckout.Size = new Size(141, 25);
            btnAddToCheckout.TabIndex = 0;
            btnAddToCheckout.Text = "ADD TO CHECKOUT";
            btnAddToCheckout.UseVisualStyleBackColor = true;
            btnAddToCheckout.Click += btnAddToCheckout_Click;
            // 
            // btnEditAppliance
            // 
            btnEditAppliance.FlatAppearance.BorderColor = Color.White;
            btnEditAppliance.FlatAppearance.BorderSize = 0;
            btnEditAppliance.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 5, 19);
            btnEditAppliance.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 5, 19);
            btnEditAppliance.FlatStyle = FlatStyle.Flat;
            btnEditAppliance.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            btnEditAppliance.ForeColor = Color.White;
            btnEditAppliance.Location = new Point(185, 3);
            btnEditAppliance.Margin = new Padding(38, 3, 3, 3);
            btnEditAppliance.Name = "btnEditAppliance";
            btnEditAppliance.Size = new Size(62, 25);
            btnEditAppliance.TabIndex = 1;
            btnEditAppliance.Text = "EDIT";
            btnEditAppliance.UseVisualStyleBackColor = true;
            btnEditAppliance.Click += btnEditAppliance_Click;
            // 
            // ApplianceItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpHitbox);
            Margin = new Padding(10);
            Name = "ApplianceItemView";
            Padding = new Padding(3);
            Size = new Size(255, 235);
            flpHitbox.ResumeLayout(false);
            flpHitbox.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flpOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpHitbox;
        private Panel pnlThumbnail;
        private Panel panel2;
        private Label lblName;
        private Label lblPrice;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblStocks;
        private FlowLayoutPanel flpOptions;
        private Button btnAddToCheckout;
        private Button btnEditAppliance;
    }
}
