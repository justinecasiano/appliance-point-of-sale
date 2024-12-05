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
            pnlEditStocks = new Panel();
            btnCancelEdit = new Button();
            btnConfirmEdit = new Button();
            numEditStocks = new NumericUpDown();
            pnlInfo = new FlowLayoutPanel();
            lblPrice = new Label();
            lblStocks = new Label();
            flpOptions = new FlowLayoutPanel();
            btnAddToCheckout = new Button();
            btnEditAppliance = new Button();
            flpHitbox.SuspendLayout();
            pnlEditStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEditStocks).BeginInit();
            pnlInfo.SuspendLayout();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // flpHitbox
            // 
            flpHitbox.BackColor = Color.White;
            flpHitbox.Controls.Add(pnlThumbnail);
            flpHitbox.Controls.Add(panel2);
            flpHitbox.Controls.Add(lblName);
            flpHitbox.Controls.Add(pnlEditStocks);
            flpHitbox.Controls.Add(pnlInfo);
            flpHitbox.Controls.Add(flpOptions);
            flpHitbox.Cursor = Cursors.Hand;
            flpHitbox.Dock = DockStyle.Fill;
            flpHitbox.Location = new Point(3, 3);
            flpHitbox.Margin = new Padding(0);
            flpHitbox.Name = "flpHitbox";
            flpHitbox.Size = new Size(249, 232);
            flpHitbox.TabIndex = 1;
            flpHitbox.Click += flpHitbox_Click;
            // 
            // pnlThumbnail
            // 
            pnlThumbnail.BackColor = Color.White;
            pnlThumbnail.BackgroundImageLayout = ImageLayout.Center;
            pnlThumbnail.Cursor = Cursors.Hand;
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
            lblName.Cursor = Cursors.Hand;
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
            // pnlEditStocks
            // 
            pnlEditStocks.Controls.Add(btnCancelEdit);
            pnlEditStocks.Controls.Add(btnConfirmEdit);
            pnlEditStocks.Controls.Add(numEditStocks);
            pnlEditStocks.Location = new Point(0, 202);
            pnlEditStocks.Margin = new Padding(0, 2, 0, 3);
            pnlEditStocks.Name = "pnlEditStocks";
            pnlEditStocks.Size = new Size(243, 29);
            pnlEditStocks.TabIndex = 6;
            pnlEditStocks.Visible = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.FromArgb(255, 5, 19);
            btnCancelEdit.FlatAppearance.BorderColor = Color.White;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 5, 19);
            btnCancelEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 5, 19);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(178, 3);
            btnCancelEdit.Margin = new Padding(38, 3, 3, 3);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(63, 24);
            btnCancelEdit.TabIndex = 3;
            btnCancelEdit.Text = "CANCEL";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.BackColor = Color.ForestGreen;
            btnConfirmEdit.FlatAppearance.BorderColor = Color.White;
            btnConfirmEdit.FlatAppearance.BorderSize = 0;
            btnConfirmEdit.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnConfirmEdit.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnConfirmEdit.FlatStyle = FlatStyle.Flat;
            btnConfirmEdit.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            btnConfirmEdit.ForeColor = Color.White;
            btnConfirmEdit.Location = new Point(104, 3);
            btnConfirmEdit.Margin = new Padding(38, 3, 3, 3);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(74, 24);
            btnConfirmEdit.TabIndex = 2;
            btnConfirmEdit.Text = "CONFIRM";
            btnConfirmEdit.UseVisualStyleBackColor = false;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // numEditStocks
            // 
            numEditStocks.BorderStyle = BorderStyle.FixedSingle;
            numEditStocks.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
            numEditStocks.ForeColor = Color.FromArgb(63, 63, 63);
            numEditStocks.Location = new Point(3, 0);
            numEditStocks.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numEditStocks.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numEditStocks.Name = "numEditStocks";
            numEditStocks.RightToLeft = RightToLeft.No;
            numEditStocks.Size = new Size(95, 28);
            numEditStocks.TabIndex = 0;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblPrice);
            pnlInfo.Controls.Add(lblStocks);
            pnlInfo.Dock = DockStyle.Top;
            pnlInfo.Location = new Point(0, 236);
            pnlInfo.Margin = new Padding(0, 2, 0, 3);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(252, 28);
            pnlInfo.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(56, 56, 56);
            lblPrice.Location = new Point(5, 5);
            lblPrice.Margin = new Padding(5, 5, 0, 10);
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
            lblStocks.Cursor = Cursors.Hand;
            lblStocks.Font = new Font("Inria Sans", 10F, FontStyle.Bold);
            lblStocks.ForeColor = Color.FromArgb(112, 112, 112);
            lblStocks.Location = new Point(130, 5);
            lblStocks.Margin = new Padding(5, 5, 10, 10);
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
            flpOptions.Location = new Point(0, 267);
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
            btnAddToCheckout.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
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
            btnEditAppliance.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
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
            Size = new Size(255, 238);
            flpHitbox.ResumeLayout(false);
            flpHitbox.PerformLayout();
            pnlEditStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numEditStocks).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            flpOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpHitbox;
        private Panel pnlThumbnail;
        private Panel panel2;
        private Label lblName;
        private Label lblPrice;
        private FlowLayoutPanel pnlInfo;
        private Label lblStocks;
        private FlowLayoutPanel flpOptions;
        private Button btnAddToCheckout;
        private Button btnEditAppliance;
        private Panel pnlEditStocks;
        private NumericUpDown numEditStocks;
        private Button btnConfirmEdit;
        private Button btnCancelEdit;
    }
}
