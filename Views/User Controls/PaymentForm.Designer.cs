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
            panel5 = new Panel();
            panel6 = new Panel();
            txtPaidAmount = new TextBox();
            btnPay = new Button();
            btnBack = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flpHolder.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flpHolder);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 426);
            panel1.TabIndex = 1;
            // 
            // flpHolder
            // 
            flpHolder.Controls.Add(panel5);
            flpHolder.Location = new Point(48, 188);
            flpHolder.Name = "flpHolder";
            flpHolder.Size = new Size(447, 100);
            flpHolder.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(172, 172, 172);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(447, 45);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(txtPaidAmount);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(15, 10, 15, 10);
            panel6.Size = new Size(445, 43);
            panel6.TabIndex = 5;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.BorderStyle = BorderStyle.None;
            txtPaidAmount.Dock = DockStyle.Fill;
            txtPaidAmount.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtPaidAmount.ForeColor = Color.FromArgb(65, 65, 65);
            txtPaidAmount.Location = new Point(15, 10);
            txtPaidAmount.Margin = new Padding(0);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.PlaceholderText = "ENTER AMOUNT";
            txtPaidAmount.Size = new Size(415, 22);
            txtPaidAmount.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(192, 52, 40);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(215, 353);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(279, 48);
            btnPay.TabIndex = 11;
            btnPay.Text = "PAY NOW";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 52, 40);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(48, 353);
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
            Size = new Size(542, 430);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpHolder.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPay;
        private Button btnBack;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel flpHolder;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtPaidAmount;
    }
}
