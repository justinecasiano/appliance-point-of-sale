namespace AppliancePointOfSale.Views;

partial class Login
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        picBg = new PictureBox();
        pictureBox1 = new PictureBox();
        lblDevelop = new Label();
        lblDeveloped = new Label();
        lblUsing = new Label();
        lblUsingProgram = new Label();
        lblPaymentMethod = new Label();
        lblMethodsOfpayment = new Label();
        lblAbout = new Label();
        lblHanabishi = new Label();
        label2 = new Label();
        btnClose = new Label();
        panel1 = new Panel();
        pictureBox2 = new PictureBox();
        btnShowpassword = new Button();
        btnLogin = new Button();
        label1 = new Label();
        lblWelcome = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        lblPassword = new Label();
        lblUsername = new Label();
        ((System.ComponentModel.ISupportInitialize)picBg).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // picBg
        // 
        picBg.Image = (Image)resources.GetObject("picBg.Image");
        picBg.Location = new Point(0, 72);
        picBg.Margin = new Padding(2);
        picBg.Name = "picBg";
        picBg.Size = new Size(1366, 537);
        picBg.TabIndex = 5;
        picBg.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.hanabishi_logo;
        pictureBox1.Location = new Point(47, 21);
        pictureBox1.Margin = new Padding(2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(183, 31);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // lblDevelop
        // 
        lblDevelop.AutoSize = true;
        lblDevelop.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
        lblDevelop.Location = new Point(137, 628);
        lblDevelop.Margin = new Padding(2, 0, 2, 0);
        lblDevelop.Name = "lblDevelop";
        lblDevelop.Size = new Size(113, 20);
        lblDevelop.TabIndex = 7;
        lblDevelop.Text = "DEVELOPED BY";
        // 
        // lblDeveloped
        // 
        lblDeveloped.AutoSize = true;
        lblDeveloped.Font = new Font("Inria Sans", 10F);
        lblDeveloped.Location = new Point(137, 658);
        lblDeveloped.Margin = new Padding(2, 0, 2, 0);
        lblDeveloped.Name = "lblDeveloped";
        lblDeveloped.Size = new Size(143, 54);
        lblDeveloped.TabIndex = 8;
        lblDeveloped.Text = "JUSTINE CASIANO\r\nWAYNE YSRAEL ELADO\r\nANGELA MAE CABRERA";
        // 
        // lblUsing
        // 
        lblUsing.AutoSize = true;
        lblUsing.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
        lblUsing.Location = new Point(391, 628);
        lblUsing.Margin = new Padding(2, 0, 2, 0);
        lblUsing.Name = "lblUsing";
        lblUsing.Size = new Size(53, 20);
        lblUsing.TabIndex = 9;
        lblUsing.Text = "USING";
        // 
        // lblUsingProgram
        // 
        lblUsingProgram.AutoSize = true;
        lblUsingProgram.Font = new Font("Inria Sans", 10F);
        lblUsingProgram.Location = new Point(391, 658);
        lblUsingProgram.Margin = new Padding(2, 0, 2, 0);
        lblUsingProgram.Name = "lblUsingProgram";
        lblUsingProgram.Size = new Size(99, 36);
        lblUsingProgram.TabIndex = 10;
        lblUsingProgram.Text = "VISUAL STUDIO\r\nC#\r\n";
        // 
        // lblPaymentMethod
        // 
        lblPaymentMethod.AutoSize = true;
        lblPaymentMethod.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
        lblPaymentMethod.Location = new Point(594, 628);
        lblPaymentMethod.Margin = new Padding(2, 0, 2, 0);
        lblPaymentMethod.Name = "lblPaymentMethod";
        lblPaymentMethod.Size = new Size(140, 20);
        lblPaymentMethod.TabIndex = 11;
        lblPaymentMethod.Text = "PAYMENT METHOD";
        // 
        // lblMethodsOfpayment
        // 
        lblMethodsOfpayment.AutoSize = true;
        lblMethodsOfpayment.Font = new Font("Inria Sans", 10F);
        lblMethodsOfpayment.Location = new Point(594, 658);
        lblMethodsOfpayment.Margin = new Padding(2, 0, 2, 0);
        lblMethodsOfpayment.Name = "lblMethodsOfpayment";
        lblMethodsOfpayment.Size = new Size(85, 54);
        lblMethodsOfpayment.TabIndex = 12;
        lblMethodsOfpayment.Text = "CASH\r\nGCASH\r\nCREDIT CARD";
        // 
        // lblAbout
        // 
        lblAbout.AutoSize = true;
        lblAbout.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
        lblAbout.Location = new Point(835, 629);
        lblAbout.Margin = new Padding(2, 0, 2, 0);
        lblAbout.Name = "lblAbout";
        lblAbout.Size = new Size(56, 20);
        lblAbout.TabIndex = 13;
        lblAbout.Text = "ABOUT\r\n";
        // 
        // lblHanabishi
        // 
        lblHanabishi.Font = new Font("Inria Sans", 10F);
        lblHanabishi.Location = new Point(835, 658);
        lblHanabishi.Margin = new Padding(2, 0, 2, 0);
        lblHanabishi.Name = "lblHanabishi";
        lblHanabishi.Size = new Size(412, 99);
        lblHanabishi.TabIndex = 14;
        lblHanabishi.Text = resources.GetString("lblHanabishi.Text");
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Inria Sans", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(261, 20);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(160, 34);
        label2.TabIndex = 15;
        label2.Text = "POS SYSTEM";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnClose
        // 
        btnClose.AutoSize = true;
        btnClose.Cursor = Cursors.Hand;
        btnClose.Font = new Font("Inria Sans", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnClose.ForeColor = Color.Red;
        btnClose.Location = new Point(1305, 17);
        btnClose.Margin = new Padding(2, 0, 2, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(34, 38);
        btnClose.TabIndex = 16;
        btnClose.Text = "X";
        btnClose.TextAlign = ContentAlignment.MiddleCenter;
        btnClose.Click += btnClose_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(251, 251, 251);
        panel1.Controls.Add(pictureBox2);
        panel1.Controls.Add(btnShowpassword);
        panel1.Controls.Add(btnLogin);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(lblWelcome);
        panel1.Controls.Add(txtUsername);
        panel1.Controls.Add(txtPassword);
        panel1.Controls.Add(lblPassword);
        panel1.Controls.Add(lblUsername);
        panel1.Location = new Point(395, 125);
        panel1.Name = "panel1";
        panel1.Size = new Size(576, 431);
        panel1.TabIndex = 17;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.hanabishi_logo;
        pictureBox2.Location = new Point(180, 36);
        pictureBox2.Margin = new Padding(2);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(204, 37);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 19;
        pictureBox2.TabStop = false;
        // 
        // btnShowpassword
        // 
        btnShowpassword.BackColor = Color.White;
        btnShowpassword.Cursor = Cursors.Hand;
        btnShowpassword.FlatStyle = FlatStyle.Flat;
        btnShowpassword.Image = (Image)resources.GetObject("btnShowpassword.Image");
        btnShowpassword.Location = new Point(469, 305);
        btnShowpassword.Margin = new Padding(2);
        btnShowpassword.Name = "btnShowpassword";
        btnShowpassword.Size = new Size(31, 31);
        btnShowpassword.TabIndex = 18;
        btnShowpassword.UseVisualStyleBackColor = false;
        btnShowpassword.Click += btnShowpassword_Click;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(192, 52, 40);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
        btnLogin.ForeColor = SystemColors.ButtonHighlight;
        btnLogin.Location = new Point(60, 355);
        btnLogin.Margin = new Padding(0);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(441, 40);
        btnLogin.TabIndex = 17;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Inria Sans", 12F);
        label1.ForeColor = Color.FromArgb(65, 65, 65);
        label1.Location = new Point(60, 138);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(460, 40);
        label1.TabIndex = 16;
        label1.Text = "Welcome to Hanabishi's POS System  where seamless transactions\r\nmeet quality appliances for a better shopping experience!";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Inria Sans", 22F, FontStyle.Bold);
        lblWelcome.Location = new Point(211, 87);
        lblWelcome.Margin = new Padding(2, 0, 2, 0);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(145, 38);
        lblWelcome.TabIndex = 15;
        lblWelcome.Text = "Welcome!";
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Inria Sans", 14F);
        txtUsername.Location = new Point(60, 230);
        txtUsername.Margin = new Padding(2);
        txtUsername.Multiline = true;
        txtUsername.Name = "txtUsername";
        txtUsername.PlaceholderText = "USERNAME";
        txtUsername.Size = new Size(440, 32);
        txtUsername.TabIndex = 13;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Inria Sans", 14F);
        txtPassword.Location = new Point(60, 305);
        txtPassword.Margin = new Padding(2);
        txtPassword.Multiline = true;
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.PlaceholderText = "PASSWORD";
        txtPassword.Size = new Size(441, 31);
        txtPassword.TabIndex = 14;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Inria Sans", 11F);
        lblPassword.ForeColor = Color.FromArgb(65, 65, 65);
        lblPassword.Location = new Point(57, 276);
        lblPassword.Margin = new Padding(2, 0, 2, 0);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(109, 19);
        lblPassword.TabIndex = 12;
        lblPassword.Text = "Enter Password";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Inria Sans", 11F);
        lblUsername.ForeColor = Color.FromArgb(65, 65, 65);
        lblUsername.Location = new Point(57, 201);
        lblUsername.Margin = new Padding(2, 0, 2, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(116, 19);
        lblUsername.TabIndex = 11;
        lblUsername.Text = "Enter Username";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(237, 237, 237);
        ClientSize = new Size(1366, 768);
        Controls.Add(panel1);
        Controls.Add(btnClose);
        Controls.Add(label2);
        Controls.Add(lblHanabishi);
        Controls.Add(lblAbout);
        Controls.Add(lblMethodsOfpayment);
        Controls.Add(lblPaymentMethod);
        Controls.Add(lblUsingProgram);
        Controls.Add(lblUsing);
        Controls.Add(lblDeveloped);
        Controls.Add(lblDevelop);
        Controls.Add(pictureBox1);
        Controls.Add(picBg);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hanabishi POS";
        Load += frmHanabishi_Load;
        ((System.ComponentModel.ISupportInitialize)picBg).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.PictureBox picBg;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblDevelop;
    private System.Windows.Forms.Label lblDeveloped;
    private System.Windows.Forms.Label lblUsing;
    private System.Windows.Forms.Label lblUsingProgram;
    private System.Windows.Forms.Label lblPaymentMethod;
    private System.Windows.Forms.Label lblMethodsOfpayment;
    private System.Windows.Forms.Label lblAbout;
    private System.Windows.Forms.Label lblHanabishi;
    private Label label2;
    private Label btnClose;
    private Panel panel1;
    private PictureBox pictureBox2;
    private Button btnShowpassword;
    private Button btnLogin;
    private Label label1;
    private Label lblWelcome;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Label lblPassword;
    private Label lblUsername;
}

