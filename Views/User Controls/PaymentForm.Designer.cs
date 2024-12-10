namespace AppliancePointOfSale.Views.User_Controls
{
    partial class PaymentForm
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
            panel1 = new Panel();
            flpHolder = new FlowLayoutPanel();
            cboPaymentMethod = new CustomDropDown();
            lblTotalAmount = new Label();
            pnlAmountPaid = new Panel();
            panel10 = new Panel();
            txtAmountPaid = new TextBox();
            lblChange = new Label();
            pnlReferenceNumber = new Panel();
            panel6 = new Panel();
            txtReferenceNumber = new TextBox();
            panel3 = new Panel();
            btnPay = new Button();
            btnBack = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flpHolder.SuspendLayout();
            pnlAmountPaid.SuspendLayout();
            panel10.SuspendLayout();
            pnlReferenceNumber.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flpHolder);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 455);
            panel1.TabIndex = 1;
            // 
            // flpHolder
            // 
            flpHolder.AutoScroll = true;
            flpHolder.Controls.Add(cboPaymentMethod);
            flpHolder.Controls.Add(lblTotalAmount);
            flpHolder.Controls.Add(pnlAmountPaid);
            flpHolder.Controls.Add(lblChange);
            flpHolder.Controls.Add(pnlReferenceNumber);
            flpHolder.Controls.Add(panel3);
            flpHolder.FlowDirection = FlowDirection.TopDown;
            flpHolder.Location = new Point(52, 190);
            flpHolder.Name = "flpHolder";
            flpHolder.Size = new Size(447, 243);
            flpHolder.TabIndex = 15;
            flpHolder.WrapContents = false;
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.Location = new Point(0, 0);
            cboPaymentMethod.Margin = new Padding(0, 0, 0, 15);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(21, 28);
            cboPaymentMethod.TabIndex = 0;
            cboPaymentMethod.Title = "";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(0, 43);
            lblTotalAmount.Margin = new Padding(0, 0, 0, 15);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(138, 23);
            lblTotalAmount.TabIndex = 17;
            lblTotalAmount.Text = "TOTAL AMOUNT:";
            // 
            // pnlAmountPaid
            // 
            pnlAmountPaid.BackColor = Color.FromArgb(172, 172, 172);
            pnlAmountPaid.Controls.Add(panel10);
            pnlAmountPaid.Location = new Point(0, 81);
            pnlAmountPaid.Margin = new Padding(0, 0, 0, 15);
            pnlAmountPaid.Name = "pnlAmountPaid";
            pnlAmountPaid.Padding = new Padding(1);
            pnlAmountPaid.Size = new Size(430, 45);
            pnlAmountPaid.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txtAmountPaid);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1, 1);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(15, 10, 15, 10);
            panel10.Size = new Size(428, 43);
            panel10.TabIndex = 5;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.BorderStyle = BorderStyle.None;
            txtAmountPaid.Dock = DockStyle.Fill;
            txtAmountPaid.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtAmountPaid.ForeColor = Color.FromArgb(65, 65, 65);
            txtAmountPaid.Location = new Point(15, 10);
            txtAmountPaid.Margin = new Padding(0);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.PlaceholderText = "ENTER AMOUNT";
            txtAmountPaid.Size = new Size(398, 22);
            txtAmountPaid.TabIndex = 3;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            lblChange.Location = new Point(0, 141);
            lblChange.Margin = new Padding(0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(84, 23);
            lblChange.TabIndex = 18;
            lblChange.Text = "CHANGE: ";
            lblChange.Visible = false;
            // 
            // pnlReferenceNumber
            // 
            pnlReferenceNumber.BackColor = Color.FromArgb(172, 172, 172);
            pnlReferenceNumber.Controls.Add(panel6);
            pnlReferenceNumber.Location = new Point(0, 164);
            pnlReferenceNumber.Margin = new Padding(0);
            pnlReferenceNumber.Name = "pnlReferenceNumber";
            pnlReferenceNumber.Padding = new Padding(1);
            pnlReferenceNumber.Size = new Size(430, 45);
            pnlReferenceNumber.TabIndex = 16;
            pnlReferenceNumber.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(txtReferenceNumber);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(15, 10, 15, 10);
            panel6.Size = new Size(428, 43);
            panel6.TabIndex = 5;
            // 
            // txtReferenceNumber
            // 
            txtReferenceNumber.BorderStyle = BorderStyle.None;
            txtReferenceNumber.Dock = DockStyle.Fill;
            txtReferenceNumber.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtReferenceNumber.ForeColor = Color.FromArgb(65, 65, 65);
            txtReferenceNumber.Location = new Point(15, 10);
            txtReferenceNumber.Margin = new Padding(0);
            txtReferenceNumber.Name = "txtReferenceNumber";
            txtReferenceNumber.PlaceholderText = "ENTER REFERENCE NUMBER";
            txtReferenceNumber.Size = new Size(398, 22);
            txtReferenceNumber.TabIndex = 3;
            txtReferenceNumber.TextChanged += txtReferenceNumber_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPay);
            panel3.Controls.Add(btnBack);
            panel3.Location = new Point(0, 229);
            panel3.Margin = new Padding(0, 20, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 48);
            panel3.TabIndex = 16;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(192, 52, 40);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(168, 0);
            btnPay.Margin = new Padding(0);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(262, 48);
            btnPay.TabIndex = 11;
            btnPay.Text = "PAY NOW";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 52, 40);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1, 0);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 48);
            btnBack.TabIndex = 10;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inria Sans", 11F);
            label2.ForeColor = Color.FromArgb(65, 65, 65);
            label2.Location = new Point(136, 128);
            label2.Name = "label2";
            label2.Size = new Size(274, 38);
            label2.TabIndex = 2;
            label2.Text = "Please ensure the correctness of amount\nto avoid payment of conflict!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 20F, FontStyle.Bold);
            label1.Location = new Point(139, 84);
            label1.Name = "label1";
            label1.Size = new Size(274, 34);
            label1.TabIndex = 1;
            label1.Text = "Payment Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.hanabishi_logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(163, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 41);
            panel2.TabIndex = 0;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 52, 40);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Padding = new Padding(2);
            Size = new Size(542, 459);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpHolder.ResumeLayout(false);
            flpHolder.PerformLayout();
            pnlAmountPaid.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            pnlReferenceNumber.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPay;
        private Button btnBack;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private CustomDropDown cboPaymentMethod;
        private FlowLayoutPanel flpHolder;
        private Panel pnlAmountPaid;
        private Panel panel10;
        private TextBox txtAmountPaid;
        private Panel pnlReferenceNumber;
        private Panel panel6;
        private TextBox txtReferenceNumber;
        private Label lblTotalAmount;
        private Label lblChange;
        private Panel panel3;
    }
}
