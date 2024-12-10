namespace AppliancePointOfSale.Views.User_Controls
{
    partial class CustomDropDown
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
            cboDropDown = new ComboBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // cboDropDown
            // 
            cboDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboDropDown.BackColor = Color.White;
            cboDropDown.Font = new Font("Inria Sans", 12F);
            cboDropDown.FormattingEnabled = true;
            cboDropDown.Location = new Point(0, 0);
            cboDropDown.Name = "cboDropDown";
            cboDropDown.Size = new Size(76, 28);
            cboDropDown.TabIndex = 1;
            cboDropDown.SelectedIndexChanged += cboDropDown_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Inria Sans", 13F);
            lblTitle.Location = new Point(1, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 23);
            lblTitle.TabIndex = 2;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomDropDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(cboDropDown);
            Name = "CustomDropDown";
            Size = new Size(76, 28);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboDropDown;
        private Label lblTitle;
    }
}
