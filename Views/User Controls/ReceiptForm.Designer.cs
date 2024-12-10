namespace AppliancePointOfSale.Views.User_Controls
{
    partial class ReceiptForm
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
            pnlReceiptHolder = new Panel();
            pboReceipt = new PictureBox();
            btnConfirm = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            pnlReceiptHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboReceipt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnlReceiptHolder);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 596);
            panel1.TabIndex = 2;
            // 
            // pnlReceiptHolder
            // 
            pnlReceiptHolder.AutoScroll = true;
            pnlReceiptHolder.Controls.Add(pboReceipt);
            pnlReceiptHolder.Location = new Point(111, 181);
            pnlReceiptHolder.Name = "pnlReceiptHolder";
            pnlReceiptHolder.Size = new Size(317, 328);
            pnlReceiptHolder.TabIndex = 19;
            // 
            // pboReceipt
            // 
            pboReceipt.Location = new Point(0, 0);
            pboReceipt.Name = "pboReceipt";
            pboReceipt.Size = new Size(317, 328);
            pboReceipt.TabIndex = 18;
            pboReceipt.TabStop = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 52, 40);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 52, 40);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(111, 527);
            btnConfirm.Margin = new Padding(0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(317, 48);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inria Sans", 11F);
            label2.ForeColor = Color.FromArgb(65, 65, 65);
            label2.Location = new Point(85, 127);
            label2.Name = "label2";
            label2.Size = new Size(381, 38);
            label2.TabIndex = 2;
            label2.Text = "Blk. 2 Lot 14, Avanti St., Sterling Industrial Park, Barrio Iba,\r\nMeycauayan Bulacan";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 20F, FontStyle.Bold);
            label1.Location = new Point(138, 84);
            label1.Name = "label1";
            label1.Size = new Size(280, 34);
            label1.TabIndex = 1;
            label1.Text = "TRANSACTION RECEIPT";
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
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 52, 40);
            Controls.Add(panel1);
            Name = "ReceiptForm";
            Padding = new Padding(2);
            Size = new Size(542, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlReceiptHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboReceipt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel pnlReceiptHolder;
        public PictureBox pboReceipt;
        private Button btnConfirm;
    }
}
