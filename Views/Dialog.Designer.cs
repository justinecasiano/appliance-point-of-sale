namespace AppliancePointOfSale.Views
{
    partial class Dialog
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
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 5, 19);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 5, 19);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(54, 84);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(288, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 196);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
    }
}