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
            panel9 = new Panel();
            panel10 = new Panel();
            txtAddress = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            txtEmailAddress = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            txtPhoneNumber = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 496);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(172, 172, 172);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(46, 358);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(1);
            panel9.Size = new Size(448, 45);
            panel9.TabIndex = 13;
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
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(172, 172, 172);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(47, 302);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(1);
            panel7.Size = new Size(447, 45);
            panel7.TabIndex = 12;
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
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 52, 40);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(215, 418);
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
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(47, 418);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 48);
            btnBack.TabIndex = 10;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(172, 172, 172);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(47, 246);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(1);
            panel5.Size = new Size(447, 45);
            panel5.TabIndex = 5;
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(172, 172, 172);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(46, 190);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(448, 45);
            panel3.TabIndex = 4;
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
            Size = new Size(542, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtPhoneNumber;
        private Button btnBack;
        private Button btnSubmit;
        private Panel panel9;
        private Panel panel10;
        private TextBox txtAddress;
        private Panel panel7;
        private Panel panel8;
        private TextBox txtEmailAddress;
    }
}
