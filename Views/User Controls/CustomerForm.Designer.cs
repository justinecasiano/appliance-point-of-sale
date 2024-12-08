namespace AppliancePointOfSale.Views.User_Controls
{
    partial class CustomerForm
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
            pnlSeniorOrPwd = new Panel();
            panel12 = new Panel();
            chkSeniorPwd = new CheckBox();
            pnlAddress = new Panel();
            panel10 = new Panel();
            txtAddress = new TextBox();
            pnlEmail = new Panel();
            panel8 = new Panel();
            txtEmailAddress = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            pnlPhoneNumber = new Panel();
            panel6 = new Panel();
            txtPhoneNumber = new TextBox();
            pnlName = new Panel();
            panel4 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            pnlSeniorOrPwd.SuspendLayout();
            panel12.SuspendLayout();
            pnlAddress.SuspendLayout();
            panel10.SuspendLayout();
            pnlEmail.SuspendLayout();
            panel8.SuspendLayout();
            pnlPhoneNumber.SuspendLayout();
            panel6.SuspendLayout();
            pnlName.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnlSeniorOrPwd);
            panel1.Controls.Add(pnlAddress);
            panel1.Controls.Add(pnlEmail);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pnlPhoneNumber);
            panel1.Controls.Add(pnlName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 545);
            panel1.TabIndex = 0;
            // 
            // pnlSeniorOrPwd
            // 
            pnlSeniorOrPwd.BackColor = Color.FromArgb(172, 172, 172);
            pnlSeniorOrPwd.Controls.Add(panel12);
            pnlSeniorOrPwd.Location = new Point(46, 414);
            pnlSeniorOrPwd.Name = "pnlSeniorOrPwd";
            pnlSeniorOrPwd.Padding = new Padding(1);
            pnlSeniorOrPwd.Size = new Size(224, 45);
            pnlSeniorOrPwd.TabIndex = 14;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(chkSeniorPwd);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(1, 1);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(15, 10, 15, 10);
            panel12.Size = new Size(222, 43);
            panel12.TabIndex = 5;
            // 
            // chkSeniorPwd
            // 
            chkSeniorPwd.AutoSize = true;
            chkSeniorPwd.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            chkSeniorPwd.ForeColor = Color.FromArgb(65, 65, 65);
            chkSeniorPwd.Location = new Point(15, 10);
            chkSeniorPwd.Name = "chkSeniorPwd";
            chkSeniorPwd.Size = new Size(134, 27);
            chkSeniorPwd.TabIndex = 14;
            chkSeniorPwd.Text = "SENIOR/PWD";
            chkSeniorPwd.TextAlign = ContentAlignment.MiddleCenter;
            chkSeniorPwd.UseVisualStyleBackColor = true;
            // 
            // pnlAddress
            // 
            pnlAddress.BackColor = Color.FromArgb(172, 172, 172);
            pnlAddress.Controls.Add(panel10);
            pnlAddress.Location = new Point(46, 358);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Padding = new Padding(1);
            pnlAddress.Size = new Size(448, 45);
            pnlAddress.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txtAddress);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1, 1);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(15, 10, 15, 10);
            panel10.Size = new Size(446, 43);
            panel10.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtAddress.ForeColor = Color.FromArgb(65, 65, 65);
            txtAddress.Location = new Point(15, 10);
            txtAddress.Margin = new Padding(0);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "ADDRESS";
            txtAddress.Size = new Size(416, 22);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(172, 172, 172);
            pnlEmail.Controls.Add(panel8);
            pnlEmail.Location = new Point(47, 302);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Padding = new Padding(1);
            pnlEmail.Size = new Size(447, 45);
            pnlEmail.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(txtEmailAddress);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1, 1);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(15, 10, 15, 10);
            panel8.Size = new Size(445, 43);
            panel8.TabIndex = 5;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.None;
            txtEmailAddress.Dock = DockStyle.Fill;
            txtEmailAddress.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtEmailAddress.ForeColor = Color.FromArgb(65, 65, 65);
            txtEmailAddress.Location = new Point(15, 10);
            txtEmailAddress.Margin = new Padding(0);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderText = "EMAIL ADDRESS";
            txtEmailAddress.Size = new Size(415, 22);
            txtEmailAddress.TabIndex = 3;
            txtEmailAddress.TextChanged += txtEmailAddress_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 52, 40);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(215, 478);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(279, 48);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
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
            btnBack.Location = new Point(46, 478);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 48);
            btnBack.TabIndex = 10;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlPhoneNumber
            // 
            pnlPhoneNumber.BackColor = Color.FromArgb(172, 172, 172);
            pnlPhoneNumber.Controls.Add(panel6);
            pnlPhoneNumber.Location = new Point(47, 246);
            pnlPhoneNumber.Name = "pnlPhoneNumber";
            pnlPhoneNumber.Padding = new Padding(1);
            pnlPhoneNumber.Size = new Size(447, 45);
            pnlPhoneNumber.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(txtPhoneNumber);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 1);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(15, 10, 15, 10);
            panel6.Size = new Size(445, 43);
            panel6.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Dock = DockStyle.Fill;
            txtPhoneNumber.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.FromArgb(65, 65, 65);
            txtPhoneNumber.Location = new Point(15, 10);
            txtPhoneNumber.Margin = new Padding(0);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "PHONE NUMBER";
            txtPhoneNumber.Size = new Size(415, 22);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // pnlName
            // 
            pnlName.BackColor = Color.FromArgb(172, 172, 172);
            pnlName.Controls.Add(panel4);
            pnlName.Location = new Point(46, 190);
            pnlName.Name = "pnlName";
            pnlName.Padding = new Padding(1);
            pnlName.Size = new Size(448, 45);
            pnlName.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtName);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 10, 15, 10);
            panel4.Size = new Size(446, 43);
            panel4.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Inria Sans", 13F, FontStyle.Bold);
            txtName.ForeColor = Color.FromArgb(65, 65, 65);
            txtName.Location = new Point(15, 10);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "CUSTOMER NAME";
            txtName.Size = new Size(416, 22);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inria Sans", 11F);
            label2.ForeColor = Color.FromArgb(65, 65, 65);
            label2.Location = new Point(126, 129);
            label2.Name = "label2";
            label2.Size = new Size(281, 38);
            label2.TabIndex = 2;
            label2.Text = "Please input customer information before\npreceding to payment!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 20F, FontStyle.Bold);
            label1.Location = new Point(127, 85);
            label1.Name = "label1";
            label1.Size = new Size(280, 34);
            label1.TabIndex = 1;
            label1.Text = "Customer Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.hanabishi_logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(154, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 41);
            panel2.TabIndex = 0;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 52, 40);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Padding = new Padding(2);
            Size = new Size(542, 549);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSeniorOrPwd.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            pnlAddress.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            pnlEmail.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnlPhoneNumber.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlName.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Panel pnlName;
        private Panel panel4;
        private Button btnBack;
        private Button btnSubmit;
        private Panel pnlAddress;
        private Panel panel10;
        private TextBox txtAddress;
        private CheckBox chkSeniorPwd;
        private Panel pnlSeniorOrPwd;
        private Panel panel12;
        private Panel pnlEmail;
        private Panel panel8;
        private TextBox txtEmailAddress;
        private Panel pnlPhoneNumber;
        private Panel panel6;
        private TextBox txtPhoneNumber;
    }
}
