namespace AppliancePointOfSale.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            btnLogout = new Button();
            btnLogo = new Button();
            btnMenu = new Button();
            pnlSide = new Panel();
            pnlBack = new Panel();
            pnlMiddle = new Panel();
            panel1.SuspendLayout();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 237, 237);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnLogo);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 57);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = Properties.Resources.logout;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(1137, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(25, 31);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackgroundImage = Properties.Resources.hanabishi_logo;
            btnLogo.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(84, 12);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(171, 33);
            btnLogo.TabIndex = 1;
            btnLogo.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = Properties.Resources.hamburger_icon;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(21, 17);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(32, 23);
            btnMenu.TabIndex = 0;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.White;
            pnlSide.BorderStyle = BorderStyle.FixedSingle;
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 57);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(70, 554);
            pnlSide.TabIndex = 2;
            // 
            // pnlBack
            // 
            pnlBack.Controls.Add(pnlMiddle);
            pnlBack.Dock = DockStyle.Fill;
            pnlBack.Location = new Point(0, 0);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(1184, 611);
            pnlBack.TabIndex = 3;
            // 
            // pnlMiddle
            // 
            pnlMiddle.BorderStyle = BorderStyle.FixedSingle;
            pnlMiddle.Location = new Point(70, 57);
            pnlMiddle.Name = "pnlMiddle";
            pnlMiddle.Size = new Size(1114, 554);
            pnlMiddle.TabIndex = 0;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(pnlSide);
            Controls.Add(panel1);
            Controls.Add(pnlBack);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hanabishi - POS";
            panel1.ResumeLayout(false);
            pnlBack.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMenu;
        private Button btnLogo;
        private Button btnLogout;
        private Panel pnlSide;
        private Panel pnlBack;
        private Panel pnlMiddle;
    }
}