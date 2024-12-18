﻿namespace AppliancePointOfSale.Views
{
    partial class CheckoutView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutView));
            pnlSummary = new Panel();
            flpPlaceholder = new FlowLayoutPanel();
            flpCustomer = new FlowLayoutPanel();
            lblFullName = new Label();
            chkIsSeniorOrPwd = new CheckBox();
            lblContact = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblPaymentMode = new Label();
            lblReferenceNo = new Label();
            btnEdit = new Label();
            panel3 = new Panel();
            label5 = new Label();
            flpLineItems = new Custom_Controls.CustomFlowLayout();
            panel1 = new Panel();
            flpTransactionDetails = new FlowLayoutPanel();
            pnlAmount = new Panel();
            lblAmount = new Label();
            label4 = new Label();
            pnlSenior = new Panel();
            lblDiscount = new Label();
            label14 = new Label();
            pnlVAT = new Panel();
            lblVAT = new Label();
            label7 = new Label();
            pnlTotalAmount = new Panel();
            lblTotal = new Label();
            label11 = new Label();
            pnlTotalPaid = new Panel();
            lblTotalPaid = new Label();
            label8 = new Label();
            pnlChange = new Panel();
            lblChange = new Label();
            label3 = new Label();
            btnPay = new Panel();
            lblPayTotalAmount = new Label();
            lblPay = new Label();
            btnReset = new Label();
            lblTransactionID = new Label();
            lblDate = new Label();
            button1 = new Button();
            label10 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pnlHighlight = new Panel();
            label2 = new Label();
            label6 = new Label();
            pnlAirConditioning = new Panel();
            pnlEntertainment = new Panel();
            pnlKitchen = new Panel();
            label18 = new Label();
            pnlGarmentCare = new Panel();
            pnlFansAndAirCoolers = new Panel();
            pnlCleaningSterilizing = new Panel();
            pictureBox1 = new PictureBox();
            searchBox = new User_Controls.SearchBox();
            flpAppliancesList = new Custom_Controls.CustomFlowLayout();
            cboSortBy = new User_Controls.CustomDropDown();
            pnlSummary.SuspendLayout();
            flpPlaceholder.SuspendLayout();
            flpCustomer.SuspendLayout();
            flpTransactionDetails.SuspendLayout();
            pnlAmount.SuspendLayout();
            pnlSenior.SuspendLayout();
            pnlVAT.SuspendLayout();
            pnlTotalAmount.SuspendLayout();
            pnlTotalPaid.SuspendLayout();
            pnlChange.SuspendLayout();
            btnPay.SuspendLayout();
            pnlKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(flpPlaceholder);
            pnlSummary.Controls.Add(btnReset);
            pnlSummary.Controls.Add(lblTransactionID);
            pnlSummary.Controls.Add(lblDate);
            pnlSummary.Controls.Add(button1);
            pnlSummary.Controls.Add(label10);
            pnlSummary.Controls.Add(panel2);
            pnlSummary.Controls.Add(label1);
            pnlSummary.Controls.Add(pnlHighlight);
            pnlSummary.Dock = DockStyle.Right;
            pnlSummary.Location = new Point(984, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(317, 711);
            pnlSummary.TabIndex = 4;
            // 
            // flpPlaceholder
            // 
            flpPlaceholder.Controls.Add(flpCustomer);
            flpPlaceholder.Controls.Add(btnEdit);
            flpPlaceholder.Controls.Add(panel3);
            flpPlaceholder.Controls.Add(label5);
            flpPlaceholder.Controls.Add(flpLineItems);
            flpPlaceholder.Controls.Add(panel1);
            flpPlaceholder.Controls.Add(flpTransactionDetails);
            flpPlaceholder.Controls.Add(btnPay);
            flpPlaceholder.Location = new Point(14, 174);
            flpPlaceholder.Name = "flpPlaceholder";
            flpPlaceholder.Size = new Size(297, 515);
            flpPlaceholder.TabIndex = 27;
            // 
            // flpCustomer
            // 
            flpCustomer.AutoScroll = true;
            flpCustomer.Controls.Add(lblFullName);
            flpCustomer.Controls.Add(chkIsSeniorOrPwd);
            flpCustomer.Controls.Add(lblContact);
            flpCustomer.Controls.Add(lblEmail);
            flpCustomer.Controls.Add(lblAddress);
            flpCustomer.Controls.Add(lblPaymentMode);
            flpCustomer.Controls.Add(lblReferenceNo);
            flpCustomer.FlowDirection = FlowDirection.TopDown;
            flpCustomer.Location = new Point(0, 0);
            flpCustomer.Margin = new Padding(0);
            flpCustomer.Name = "flpCustomer";
            flpCustomer.Size = new Size(243, 119);
            flpCustomer.TabIndex = 0;
            flpCustomer.WrapContents = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(3, 0);
            lblFullName.Margin = new Padding(3, 0, 5, 0);
            lblFullName.MaximumSize = new Size(210, 0);
            lblFullName.MinimumSize = new Size(210, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(210, 19);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "Customer Name: ";
            // 
            // chkIsSeniorOrPwd
            // 
            chkIsSeniorOrPwd.AutoSize = true;
            chkIsSeniorOrPwd.Cursor = Cursors.Hand;
            chkIsSeniorOrPwd.Enabled = false;
            chkIsSeniorOrPwd.Font = new Font("Inria Sans", 11F);
            chkIsSeniorOrPwd.ForeColor = Color.FromArgb(65, 65, 65);
            chkIsSeniorOrPwd.Location = new Point(0, 19);
            chkIsSeniorOrPwd.Margin = new Padding(0);
            chkIsSeniorOrPwd.Name = "chkIsSeniorOrPwd";
            chkIsSeniorOrPwd.Padding = new Padding(3, 0, 0, 0);
            chkIsSeniorOrPwd.RightToLeft = RightToLeft.Yes;
            chkIsSeniorOrPwd.Size = new Size(116, 23);
            chkIsSeniorOrPwd.TabIndex = 25;
            chkIsSeniorOrPwd.Text = "Senior / PWD";
            chkIsSeniorOrPwd.TextAlign = ContentAlignment.MiddleRight;
            chkIsSeniorOrPwd.UseVisualStyleBackColor = true;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Inria Sans", 11F);
            lblContact.ForeColor = Color.FromArgb(65, 65, 65);
            lblContact.Location = new Point(3, 42);
            lblContact.Margin = new Padding(3, 0, 5, 0);
            lblContact.MaximumSize = new Size(210, 0);
            lblContact.MinimumSize = new Size(210, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(210, 19);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Inria Sans", 11F);
            lblEmail.ForeColor = Color.FromArgb(65, 65, 65);
            lblEmail.Location = new Point(3, 61);
            lblEmail.Margin = new Padding(3, 0, 5, 0);
            lblEmail.MaximumSize = new Size(210, 0);
            lblEmail.MinimumSize = new Size(210, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(210, 19);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email Address";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Inria Sans", 11F);
            lblAddress.ForeColor = Color.FromArgb(65, 65, 65);
            lblAddress.Location = new Point(3, 80);
            lblAddress.Margin = new Padding(3, 0, 5, 0);
            lblAddress.MaximumSize = new Size(210, 0);
            lblAddress.MinimumSize = new Size(210, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(210, 19);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Font = new Font("Inria Sans", 11F);
            lblPaymentMode.ForeColor = Color.FromArgb(65, 65, 65);
            lblPaymentMode.Location = new Point(3, 99);
            lblPaymentMode.Margin = new Padding(3, 0, 5, 0);
            lblPaymentMode.MaximumSize = new Size(210, 0);
            lblPaymentMode.MinimumSize = new Size(210, 0);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(210, 19);
            lblPaymentMode.TabIndex = 12;
            lblPaymentMode.Text = "Mode of Payment: ";
            // 
            // lblReferenceNo
            // 
            lblReferenceNo.AutoSize = true;
            lblReferenceNo.Font = new Font("Inria Sans", 11F);
            lblReferenceNo.ForeColor = Color.FromArgb(65, 65, 65);
            lblReferenceNo.Location = new Point(3, 118);
            lblReferenceNo.Margin = new Padding(3, 0, 5, 0);
            lblReferenceNo.MaximumSize = new Size(210, 0);
            lblReferenceNo.MinimumSize = new Size(210, 0);
            lblReferenceNo.Name = "lblReferenceNo";
            lblReferenceNo.Size = new Size(210, 19);
            lblReferenceNo.TabIndex = 13;
            lblReferenceNo.Text = "Reference #:";
            lblReferenceNo.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Inria Sans", 14F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(255, 5, 19);
            btnEdit.Location = new Point(243, 20);
            btnEdit.Margin = new Padding(0, 20, 0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(48, 24);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "EDIT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(172, 172, 172);
            panel3.Location = new Point(0, 127);
            panel3.Margin = new Padding(0, 8, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 2);
            panel3.TabIndex = 30;
            // 
            // label5
            // 
            label5.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 132);
            label5.Margin = new Padding(3, 3, 5, 3);
            label5.Name = "label5";
            label5.Size = new Size(288, 19);
            label5.TabIndex = 11;
            label5.Text = "Purchases";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flpLineItems
            // 
            flpLineItems.AutoScroll = true;
            flpLineItems.Location = new Point(3, 157);
            flpLineItems.Name = "flpLineItems";
            flpLineItems.Size = new Size(288, 197);
            flpLineItems.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(172, 172, 172);
            panel1.Location = new Point(0, 357);
            panel1.Margin = new Padding(0, 0, 0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 2);
            panel1.TabIndex = 29;
            // 
            // flpTransactionDetails
            // 
            flpTransactionDetails.AutoScroll = true;
            flpTransactionDetails.Controls.Add(pnlAmount);
            flpTransactionDetails.Controls.Add(pnlSenior);
            flpTransactionDetails.Controls.Add(pnlVAT);
            flpTransactionDetails.Controls.Add(pnlTotalAmount);
            flpTransactionDetails.Controls.Add(pnlTotalPaid);
            flpTransactionDetails.Controls.Add(pnlChange);
            flpTransactionDetails.FlowDirection = FlowDirection.TopDown;
            flpTransactionDetails.Location = new Point(3, 365);
            flpTransactionDetails.Name = "flpTransactionDetails";
            flpTransactionDetails.Size = new Size(293, 96);
            flpTransactionDetails.TabIndex = 27;
            flpTransactionDetails.WrapContents = false;
            // 
            // pnlAmount
            // 
            pnlAmount.Controls.Add(lblAmount);
            pnlAmount.Controls.Add(label4);
            pnlAmount.Location = new Point(1, 3);
            pnlAmount.Margin = new Padding(1, 3, 1, 3);
            pnlAmount.Name = "pnlAmount";
            pnlAmount.Size = new Size(267, 18);
            pnlAmount.TabIndex = 16;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(56, 56, 56);
            lblAmount.Location = new Point(166, 0);
            lblAmount.MaximumSize = new Size(106, 19);
            lblAmount.MinimumSize = new Size(106, 19);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(106, 19);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "₱ 0.00";
            lblAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(56, 56, 56);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 10;
            label4.Text = "Amount:";
            // 
            // pnlSenior
            // 
            pnlSenior.Controls.Add(lblDiscount);
            pnlSenior.Controls.Add(label14);
            pnlSenior.Location = new Point(1, 27);
            pnlSenior.Margin = new Padding(1, 3, 1, 3);
            pnlSenior.Name = "pnlSenior";
            pnlSenior.Size = new Size(267, 18);
            pnlSenior.TabIndex = 17;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.FromArgb(56, 56, 56);
            lblDiscount.Location = new Point(166, 0);
            lblDiscount.MaximumSize = new Size(106, 19);
            lblDiscount.MinimumSize = new Size(106, 19);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(106, 19);
            lblDiscount.TabIndex = 11;
            lblDiscount.Text = "₱ 0.00";
            lblDiscount.TextAlign = ContentAlignment.TopRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Left;
            label14.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(56, 56, 56);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(155, 19);
            label14.TabIndex = 10;
            label14.Text = "Senior/PWD Discount:\r\n";
            // 
            // pnlVAT
            // 
            pnlVAT.Controls.Add(lblVAT);
            pnlVAT.Controls.Add(label7);
            pnlVAT.Location = new Point(1, 51);
            pnlVAT.Margin = new Padding(1, 3, 1, 3);
            pnlVAT.Name = "pnlVAT";
            pnlVAT.Size = new Size(267, 18);
            pnlVAT.TabIndex = 17;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblVAT.ForeColor = Color.FromArgb(56, 56, 56);
            lblVAT.Location = new Point(166, 0);
            lblVAT.MaximumSize = new Size(106, 19);
            lblVAT.MinimumSize = new Size(106, 19);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(106, 19);
            lblVAT.TabIndex = 11;
            lblVAT.Text = "₱ 0.00";
            lblVAT.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(56, 56, 56);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 10;
            label7.Text = "VAT Amount:";
            // 
            // pnlTotalAmount
            // 
            pnlTotalAmount.Controls.Add(lblTotal);
            pnlTotalAmount.Controls.Add(label11);
            pnlTotalAmount.Location = new Point(1, 75);
            pnlTotalAmount.Margin = new Padding(1, 3, 1, 3);
            pnlTotalAmount.Name = "pnlTotalAmount";
            pnlTotalAmount.Size = new Size(267, 18);
            pnlTotalAmount.TabIndex = 21;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(56, 56, 56);
            lblTotal.Location = new Point(166, 0);
            lblTotal.MaximumSize = new Size(106, 19);
            lblTotal.MinimumSize = new Size(106, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 19);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "₱ 0.00";
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(56, 56, 56);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(105, 19);
            label11.TabIndex = 10;
            label11.Text = "Total Amount: ";
            // 
            // pnlTotalPaid
            // 
            pnlTotalPaid.Controls.Add(lblTotalPaid);
            pnlTotalPaid.Controls.Add(label8);
            pnlTotalPaid.Location = new Point(1, 99);
            pnlTotalPaid.Margin = new Padding(1, 3, 1, 3);
            pnlTotalPaid.Name = "pnlTotalPaid";
            pnlTotalPaid.Size = new Size(267, 18);
            pnlTotalPaid.TabIndex = 20;
            pnlTotalPaid.Visible = false;
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblTotalPaid.ForeColor = Color.FromArgb(56, 56, 56);
            lblTotalPaid.Location = new Point(166, 0);
            lblTotalPaid.MaximumSize = new Size(106, 19);
            lblTotalPaid.MinimumSize = new Size(106, 19);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(106, 19);
            lblTotalPaid.TabIndex = 11;
            lblTotalPaid.Text = "₱ 0.00";
            lblTotalPaid.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(56, 56, 56);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 19);
            label8.TabIndex = 10;
            label8.Text = "Total Paid:";
            // 
            // pnlChange
            // 
            pnlChange.Controls.Add(lblChange);
            pnlChange.Controls.Add(label3);
            pnlChange.Location = new Point(1, 123);
            pnlChange.Margin = new Padding(1, 3, 1, 3);
            pnlChange.Name = "pnlChange";
            pnlChange.Size = new Size(267, 18);
            pnlChange.TabIndex = 19;
            pnlChange.Visible = false;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblChange.ForeColor = Color.FromArgb(56, 56, 56);
            lblChange.Location = new Point(166, 0);
            lblChange.MaximumSize = new Size(106, 19);
            lblChange.MinimumSize = new Size(106, 19);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(106, 19);
            lblChange.TabIndex = 11;
            lblChange.Text = "₱ 0.00";
            lblChange.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(56, 56, 56);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 10;
            label3.Text = "Change:";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 5, 19);
            btnPay.Controls.Add(lblPayTotalAmount);
            btnPay.Controls.Add(lblPay);
            btnPay.Cursor = Cursors.Hand;
            btnPay.Location = new Point(6, 467);
            btnPay.Margin = new Padding(6, 3, 3, 3);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(275, 45);
            btnPay.TabIndex = 26;
            // 
            // lblPayTotalAmount
            // 
            lblPayTotalAmount.AutoSize = true;
            lblPayTotalAmount.BackColor = Color.FromArgb(255, 5, 19);
            lblPayTotalAmount.Cursor = Cursors.Hand;
            lblPayTotalAmount.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            lblPayTotalAmount.ForeColor = Color.White;
            lblPayTotalAmount.Location = new Point(109, 8);
            lblPayTotalAmount.MaximumSize = new Size(160, 28);
            lblPayTotalAmount.MinimumSize = new Size(160, 28);
            lblPayTotalAmount.Name = "lblPayTotalAmount";
            lblPayTotalAmount.Size = new Size(160, 28);
            lblPayTotalAmount.TabIndex = 25;
            lblPayTotalAmount.Text = "₱ 0.00";
            lblPayTotalAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.BackColor = Color.FromArgb(255, 5, 19);
            lblPay.Cursor = Cursors.Hand;
            lblPay.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            lblPay.ForeColor = Color.White;
            lblPay.Location = new Point(7, 8);
            lblPay.MaximumSize = new Size(0, 28);
            lblPay.MinimumSize = new Size(0, 28);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(48, 28);
            lblPay.TabIndex = 24;
            lblPay.Text = "PAY";
            lblPay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(255, 5, 19);
            btnReset.Location = new Point(283, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(25, 28);
            btnReset.TabIndex = 26;
            btnReset.Text = "X";
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Inria Sans", 11F);
            lblTransactionID.ForeColor = Color.FromArgb(65, 65, 65);
            lblTransactionID.Location = new Point(17, 152);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(130, 19);
            lblTransactionID.TabIndex = 5;
            lblTransactionID.Text = "#001939012912930";
            lblTransactionID.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Inria Sans", 11F);
            lblDate.ForeColor = Color.FromArgb(65, 65, 65);
            lblDate.Location = new Point(18, 131);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(176, 19);
            lblDate.TabIndex = 4;
            lblDate.Text = "Sunday, November 3, 2024";
            lblDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(84, 93);
            button1.Name = "button1";
            button1.Size = new Size(143, 31);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inria Sans", 9.5F);
            label10.ForeColor = Color.FromArgb(65, 65, 65);
            label10.Location = new Point(23, 58);
            label10.Name = "label10";
            label10.Size = new Size(270, 32);
            label10.TabIndex = 2;
            label10.Text = "Blk. 2 Lot 14, Avanti St., Sterling Industrial Park,\r\nBarrio Iba, Meycauayan Bulacan";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 49, 37);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 699);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 10);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            label1.Location = new Point(51, 28);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 1;
            label1.Text = "PURCHASE SUMMARY";
            // 
            // pnlHighlight
            // 
            pnlHighlight.BackColor = Color.FromArgb(191, 49, 37);
            pnlHighlight.Dock = DockStyle.Top;
            pnlHighlight.Location = new Point(0, 0);
            pnlHighlight.Name = "pnlHighlight";
            pnlHighlight.Size = new Size(315, 10);
            pnlHighlight.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label2.Location = new Point(68, 70);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 7;
            label2.Text = "CATEGORIES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label6.Location = new Point(68, 214);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 14;
            label6.Text = "APPLIANCES LIST";
            // 
            // pnlAirConditioning
            // 
            pnlAirConditioning.BackColor = Color.FromArgb(251, 251, 251);
            pnlAirConditioning.BackgroundImage = Properties.Resources.air_conditioning_black;
            pnlAirConditioning.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAirConditioning.Cursor = Cursors.Hand;
            pnlAirConditioning.Location = new Point(72, 98);
            pnlAirConditioning.Name = "pnlAirConditioning";
            pnlAirConditioning.Size = new Size(130, 105);
            pnlAirConditioning.TabIndex = 23;
            // 
            // pnlEntertainment
            // 
            pnlEntertainment.BackColor = Color.FromArgb(251, 251, 251);
            pnlEntertainment.BackgroundImage = Properties.Resources.entertainment_black;
            pnlEntertainment.BackgroundImageLayout = ImageLayout.Stretch;
            pnlEntertainment.Cursor = Cursors.Hand;
            pnlEntertainment.Location = new Point(213, 98);
            pnlEntertainment.Name = "pnlEntertainment";
            pnlEntertainment.Size = new Size(130, 105);
            pnlEntertainment.TabIndex = 24;
            // 
            // pnlKitchen
            // 
            pnlKitchen.BackColor = Color.FromArgb(251, 251, 251);
            pnlKitchen.BackgroundImage = Properties.Resources.kitchen_black;
            pnlKitchen.BackgroundImageLayout = ImageLayout.Stretch;
            pnlKitchen.Controls.Add(label18);
            pnlKitchen.Cursor = Cursors.Hand;
            pnlKitchen.Location = new Point(495, 98);
            pnlKitchen.Name = "pnlKitchen";
            pnlKitchen.Size = new Size(130, 105);
            pnlKitchen.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Inria Sans", 7F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(56, 56, 56);
            label18.Location = new Point(155, 61);
            label18.Name = "label18";
            label18.Size = new Size(45, 13);
            label18.TabIndex = 1;
            label18.Text = "KITCHEN";
            // 
            // pnlGarmentCare
            // 
            pnlGarmentCare.BackColor = Color.FromArgb(251, 251, 251);
            pnlGarmentCare.BackgroundImage = Properties.Resources.garment_care_black;
            pnlGarmentCare.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGarmentCare.Cursor = Cursors.Hand;
            pnlGarmentCare.Location = new Point(354, 98);
            pnlGarmentCare.Name = "pnlGarmentCare";
            pnlGarmentCare.Size = new Size(130, 105);
            pnlGarmentCare.TabIndex = 25;
            // 
            // pnlFansAndAirCoolers
            // 
            pnlFansAndAirCoolers.BackColor = Color.FromArgb(251, 251, 251);
            pnlFansAndAirCoolers.BackgroundImage = Properties.Resources.fans_and_air_coolers_black;
            pnlFansAndAirCoolers.BackgroundImageLayout = ImageLayout.Stretch;
            pnlFansAndAirCoolers.Cursor = Cursors.Hand;
            pnlFansAndAirCoolers.Location = new Point(778, 98);
            pnlFansAndAirCoolers.Name = "pnlFansAndAirCoolers";
            pnlFansAndAirCoolers.Size = new Size(130, 105);
            pnlFansAndAirCoolers.TabIndex = 28;
            // 
            // pnlCleaningSterilizing
            // 
            pnlCleaningSterilizing.BackColor = Color.FromArgb(251, 251, 251);
            pnlCleaningSterilizing.BackgroundImage = Properties.Resources.cleaning_sterilizing_black;
            pnlCleaningSterilizing.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCleaningSterilizing.Cursor = Cursors.Hand;
            pnlCleaningSterilizing.Location = new Point(637, 98);
            pnlCleaningSterilizing.Name = "pnlCleaningSterilizing";
            pnlCleaningSterilizing.Size = new Size(130, 105);
            pnlCleaningSterilizing.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.search_icon;
            pictureBox1.Location = new Point(875, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.Cursor = Cursors.Hand;
            searchBox.Location = new Point(72, 29);
            searchBox.Name = "searchBox";
            searchBox.SearchEvent = null;
            searchBox.Size = new Size(836, 33);
            searchBox.TabIndex = 35;
            // 
            // flpAppliancesList
            // 
            flpAppliancesList.AutoScroll = true;
            flpAppliancesList.BackColor = Color.Transparent;
            flpAppliancesList.Location = new Point(65, 248);
            flpAppliancesList.Name = "flpAppliancesList";
            flpAppliancesList.Size = new Size(865, 448);
            flpAppliancesList.TabIndex = 36;
            // 
            // cboSortBy
            // 
            cboSortBy.Location = new Point(235, 214);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(76, 28);
            cboSortBy.TabIndex = 37;
            cboSortBy.Title = "";
            // 
            // CheckoutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(cboSortBy);
            Controls.Add(flpAppliancesList);
            Controls.Add(pictureBox1);
            Controls.Add(pnlFansAndAirCoolers);
            Controls.Add(pnlCleaningSterilizing);
            Controls.Add(pnlKitchen);
            Controls.Add(pnlEntertainment);
            Controls.Add(pnlGarmentCare);
            Controls.Add(pnlAirConditioning);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pnlSummary);
            Controls.Add(searchBox);
            Name = "CheckoutView";
            Size = new Size(1301, 711);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            flpPlaceholder.ResumeLayout(false);
            flpPlaceholder.PerformLayout();
            flpCustomer.ResumeLayout(false);
            flpCustomer.PerformLayout();
            flpTransactionDetails.ResumeLayout(false);
            pnlAmount.ResumeLayout(false);
            pnlAmount.PerformLayout();
            pnlSenior.ResumeLayout(false);
            pnlSenior.PerformLayout();
            pnlVAT.ResumeLayout(false);
            pnlVAT.PerformLayout();
            pnlTotalAmount.ResumeLayout(false);
            pnlTotalAmount.PerformLayout();
            pnlTotalPaid.ResumeLayout(false);
            pnlTotalPaid.PerformLayout();
            pnlChange.ResumeLayout(false);
            pnlChange.PerformLayout();
            btnPay.ResumeLayout(false);
            btnPay.PerformLayout();
            pnlKitchen.ResumeLayout(false);
            pnlKitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSummary;
        private Label btnEdit;
        private FlowLayoutPanel flpCustomer;
        private Label lblFullName;
        private Label lblContact;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblTransactionID;
        private Label lblDate;
        private Button button1;
        private Label label10;
        private Panel panel2;
        private Label label1;
        private Panel pnlHighlight;
        private Label label2;
        private Label label6;
        private Custom_Controls.CustomFlowLayout flpAppliancesList;
        private User_Controls.SearchBox searchBox;
        private CheckBox chkIsSeniorOrPwd;
        private Label btnReset;
        private FlowLayoutPanel flpPlaceholder;
        private Panel btnPay;
        private Label lblPay;
        private Custom_Controls.CustomFlowLayout flpLineItems;
        private FlowLayoutPanel flpTransactionDetails;
        private Panel pnlAmount;
        private Label lblAmount;
        private Label label4;
        private Panel pnlSenior;
        private Label lblDiscount;
        private Label label14;
        private Panel pnlVAT;
        private Label lblVAT;
        private Label label7;
        private Panel pnlChange;
        private Label lblChange;
        private Label label3;
        private Panel pnlTotalPaid;
        private Label lblTotalPaid;
        private Label label8;
        private Panel pnlTotalAmount;
        private Label lblTotal;
        private Label label11;
        private Label lblPaymentMode;
        private Label lblReferenceNo;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label lblPayTotalAmount;
        private Panel pnlAirConditioning;
        private Panel pnlEntertainment;
        private Panel pnlKitchen;
        private Label label18;
        private Panel pnlGarmentCare;
        private Panel pnlFansAndAirCoolers;
        private Panel pnlCleaningSterilizing;
        private PictureBox pictureBox1;
        private User_Controls.CustomDropDown cboSortBy;
    }
}
