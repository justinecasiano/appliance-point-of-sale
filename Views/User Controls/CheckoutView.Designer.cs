namespace AppliancePointOfSale.Views
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
            pnlSummary = new Panel();
            chkIsSeniorOrPwd = new CheckBox();
            flpLineItems = new Custom_Controls.CustomFlowLayout();
            lblPayTotalAmount = new Label();
            lblPay = new Label();
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
            panel3 = new Panel();
            lblTotalAmount = new Label();
            label3 = new Label();
            btnEdit = new Label();
            flpCustomer = new FlowLayoutPanel();
            lblFullName = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblTransactionID = new Label();
            lblDate = new Label();
            button1 = new Button();
            label10 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnPay = new Button();
            pnlHighlight = new Panel();
            label2 = new Label();
            label6 = new Label();
            cmbSort = new ComboBox();
            btnFansAndAirCoolers = new Button();
            btnCleaningSterilizing = new Button();
            btnKitchen = new Button();
            btnGarmentCare = new Button();
            btnEntertainment = new Button();
            btnAirConditioning = new Button();
            flpAppliancesList = new Custom_Controls.CustomFlowLayout();
            searchBox = new User_Controls.SearchBox();
            pnlSummary.SuspendLayout();
            flpTransactionDetails.SuspendLayout();
            pnlAmount.SuspendLayout();
            pnlSenior.SuspendLayout();
            pnlVAT.SuspendLayout();
            panel3.SuspendLayout();
            flpCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(chkIsSeniorOrPwd);
            pnlSummary.Controls.Add(flpLineItems);
            pnlSummary.Controls.Add(lblPayTotalAmount);
            pnlSummary.Controls.Add(lblPay);
            pnlSummary.Controls.Add(flpTransactionDetails);
            pnlSummary.Controls.Add(btnEdit);
            pnlSummary.Controls.Add(flpCustomer);
            pnlSummary.Controls.Add(lblTransactionID);
            pnlSummary.Controls.Add(lblDate);
            pnlSummary.Controls.Add(button1);
            pnlSummary.Controls.Add(label10);
            pnlSummary.Controls.Add(panel2);
            pnlSummary.Controls.Add(label1);
            pnlSummary.Controls.Add(btnPay);
            pnlSummary.Controls.Add(pnlHighlight);
            pnlSummary.Dock = DockStyle.Right;
            pnlSummary.Location = new Point(904, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(317, 554);
            pnlSummary.TabIndex = 4;
            // 
            // chkIsSeniorOrPwd
            // 
            chkIsSeniorOrPwd.AutoSize = true;
            chkIsSeniorOrPwd.Cursor = Cursors.Hand;
            chkIsSeniorOrPwd.Font = new Font("Inria Sans", 10F);
            chkIsSeniorOrPwd.ForeColor = Color.FromArgb(65, 65, 65);
            chkIsSeniorOrPwd.Location = new Point(13, 239);
            chkIsSeniorOrPwd.Name = "chkIsSeniorOrPwd";
            chkIsSeniorOrPwd.RightToLeft = RightToLeft.Yes;
            chkIsSeniorOrPwd.Size = new Size(106, 22);
            chkIsSeniorOrPwd.TabIndex = 25;
            chkIsSeniorOrPwd.Text = "Senior / PWD";
            chkIsSeniorOrPwd.TextAlign = ContentAlignment.MiddleRight;
            chkIsSeniorOrPwd.UseVisualStyleBackColor = true;
            // 
            // flpLineItems
            // 
            flpLineItems.AutoScroll = true;
            flpLineItems.FlowDirection = FlowDirection.TopDown;
            flpLineItems.Location = new Point(19, 263);
            flpLineItems.Name = "flpLineItems";
            flpLineItems.Size = new Size(288, 136);
            flpLineItems.TabIndex = 24;
            flpLineItems.WrapContents = false;
            // 
            // lblPayTotalAmount
            // 
            lblPayTotalAmount.AutoSize = true;
            lblPayTotalAmount.BackColor = Color.FromArgb(255, 5, 19);
            lblPayTotalAmount.Cursor = Cursors.Hand;
            lblPayTotalAmount.Font = new Font("Inria Sans", 16F, FontStyle.Bold);
            lblPayTotalAmount.ForeColor = Color.White;
            lblPayTotalAmount.Location = new Point(142, 494);
            lblPayTotalAmount.MaximumSize = new Size(160, 28);
            lblPayTotalAmount.MinimumSize = new Size(160, 28);
            lblPayTotalAmount.Name = "lblPayTotalAmount";
            lblPayTotalAmount.Size = new Size(160, 28);
            lblPayTotalAmount.TabIndex = 23;
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
            lblPay.Location = new Point(27, 494);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(48, 28);
            lblPay.TabIndex = 22;
            lblPay.Text = "PAY";
            // 
            // flpTransactionDetails
            // 
            flpTransactionDetails.AutoScroll = true;
            flpTransactionDetails.Controls.Add(pnlAmount);
            flpTransactionDetails.Controls.Add(pnlSenior);
            flpTransactionDetails.Controls.Add(pnlVAT);
            flpTransactionDetails.Controls.Add(panel3);
            flpTransactionDetails.FlowDirection = FlowDirection.TopDown;
            flpTransactionDetails.Location = new Point(19, 405);
            flpTransactionDetails.Name = "flpTransactionDetails";
            flpTransactionDetails.Size = new Size(288, 71);
            flpTransactionDetails.TabIndex = 15;
            flpTransactionDetails.WrapContents = false;
            // 
            // pnlAmount
            // 
            pnlAmount.Controls.Add(lblAmount);
            pnlAmount.Controls.Add(label4);
            pnlAmount.Location = new Point(1, 1);
            pnlAmount.Margin = new Padding(1);
            pnlAmount.Name = "pnlAmount";
            pnlAmount.Size = new Size(278, 15);
            pnlAmount.TabIndex = 16;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Right;
            lblAmount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(56, 56, 56);
            lblAmount.Location = new Point(172, 0);
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
            label4.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(56, 56, 56);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Amount:";
            // 
            // pnlSenior
            // 
            pnlSenior.Controls.Add(lblDiscount);
            pnlSenior.Controls.Add(label14);
            pnlSenior.Location = new Point(1, 18);
            pnlSenior.Margin = new Padding(1);
            pnlSenior.Name = "pnlSenior";
            pnlSenior.Size = new Size(278, 15);
            pnlSenior.TabIndex = 17;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Dock = DockStyle.Right;
            lblDiscount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.FromArgb(56, 56, 56);
            lblDiscount.Location = new Point(172, 0);
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
            label14.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(56, 56, 56);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(122, 15);
            label14.TabIndex = 10;
            label14.Text = "Senior/PWD Discount:\r\n";
            // 
            // pnlVAT
            // 
            pnlVAT.Controls.Add(lblVAT);
            pnlVAT.Controls.Add(label7);
            pnlVAT.Location = new Point(1, 35);
            pnlVAT.Margin = new Padding(1);
            pnlVAT.Name = "pnlVAT";
            pnlVAT.Size = new Size(278, 15);
            pnlVAT.TabIndex = 17;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Dock = DockStyle.Right;
            lblVAT.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblVAT.ForeColor = Color.FromArgb(56, 56, 56);
            lblVAT.Location = new Point(172, 0);
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
            label7.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(56, 56, 56);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 10;
            label7.Text = "VAT Amount:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalAmount);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 52);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 15);
            panel3.TabIndex = 19;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Dock = DockStyle.Right;
            lblTotalAmount.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(56, 56, 56);
            lblTotalAmount.Location = new Point(172, 0);
            lblTotalAmount.MaximumSize = new Size(106, 19);
            lblTotalAmount.MinimumSize = new Size(106, 19);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(106, 19);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "₱ 0.00";
            lblTotalAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Inria Sans", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(56, 56, 56);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 10;
            label3.Text = "Total Amount: ";
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(255, 5, 19);
            btnEdit.Location = new Point(263, 188);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(41, 20);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "EDIT";
            // 
            // flpCustomer
            // 
            flpCustomer.AutoScroll = true;
            flpCustomer.Controls.Add(lblFullName);
            flpCustomer.Controls.Add(lblContact);
            flpCustomer.Controls.Add(lblEmail);
            flpCustomer.Controls.Add(lblAddress);
            flpCustomer.FlowDirection = FlowDirection.TopDown;
            flpCustomer.Location = new Point(12, 164);
            flpCustomer.Name = "flpCustomer";
            flpCustomer.Size = new Size(243, 78);
            flpCustomer.TabIndex = 0;
            flpCustomer.WrapContents = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Inria Sans", 11F, FontStyle.Bold);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(3, 0);
            lblFullName.MaximumSize = new Size(230, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(122, 19);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "Customer Name: ";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Inria Sans", 10F);
            lblContact.ForeColor = Color.FromArgb(65, 65, 65);
            lblContact.Location = new Point(3, 19);
            lblContact.MaximumSize = new Size(230, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(107, 18);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Inria Sans", 10F);
            lblEmail.ForeColor = Color.FromArgb(65, 65, 65);
            lblEmail.Location = new Point(3, 37);
            lblEmail.MaximumSize = new Size(230, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 18);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email Address";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Inria Sans", 10F);
            lblAddress.ForeColor = Color.FromArgb(65, 65, 65);
            lblAddress.Location = new Point(3, 55);
            lblAddress.MaximumSize = new Size(230, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(56, 18);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Inria Sans", 10F);
            lblTransactionID.ForeColor = Color.FromArgb(65, 65, 65);
            lblTransactionID.Location = new Point(16, 145);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(128, 18);
            lblTransactionID.TabIndex = 5;
            lblTransactionID.Text = "#001939012912930";
            lblTransactionID.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Inria Sans", 10F);
            lblDate.ForeColor = Color.FromArgb(65, 65, 65);
            lblDate.Location = new Point(16, 127);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(168, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "Sunday, November 3, 2024";
            lblDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.hanabishi_logo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(100, 93);
            button1.Name = "button1";
            button1.Size = new Size(114, 24);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inria Sans", 9F);
            label10.ForeColor = Color.FromArgb(65, 65, 65);
            label10.Location = new Point(34, 56);
            label10.Name = "label10";
            label10.Size = new Size(249, 30);
            label10.TabIndex = 2;
            label10.Text = "Blk. 2 Lot 14, Avanti St., Sterling Industrial Park,\r\nBarrio Iba, Meycauayan Bulacan";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 49, 37);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 542);
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
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(255, 5, 19);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 5, 19);
            btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 5, 19);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(16, 485);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(288, 45);
            btnPay.TabIndex = 0;
            btnPay.UseVisualStyleBackColor = false;
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
            label2.Location = new Point(34, 72);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 7;
            label2.Text = "CATEGORIES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inria Sans", 15F, FontStyle.Bold);
            label6.Location = new Point(34, 216);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 14;
            label6.Text = "APPLIANCES LIST";
            // 
            // cmbSort
            // 
            cmbSort.BackColor = Color.LightGray;
            cmbSort.Cursor = Cursors.Hand;
            cmbSort.FlatStyle = FlatStyle.Flat;
            cmbSort.Font = new Font("Inria Sans", 12F, FontStyle.Bold);
            cmbSort.ForeColor = Color.FromArgb(137, 137, 137);
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(200, 216);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(84, 28);
            cmbSort.TabIndex = 15;
            cmbSort.Text = "Sort by:";
            // 
            // btnFansAndAirCoolers
            // 
            btnFansAndAirCoolers.BackColor = Color.FromArgb(251, 251, 251);
            btnFansAndAirCoolers.FlatAppearance.BorderSize = 0;
            btnFansAndAirCoolers.FlatStyle = FlatStyle.Flat;
            btnFansAndAirCoolers.Location = new Point(754, 100);
            btnFansAndAirCoolers.Name = "btnFansAndAirCoolers";
            btnFansAndAirCoolers.Size = new Size(120, 105);
            btnFansAndAirCoolers.TabIndex = 20;
            btnFansAndAirCoolers.Text = "FANS AND AIR COOLERS";
            btnFansAndAirCoolers.UseVisualStyleBackColor = false;
            // 
            // btnCleaningSterilizing
            // 
            btnCleaningSterilizing.BackColor = Color.FromArgb(251, 251, 251);
            btnCleaningSterilizing.FlatAppearance.BorderSize = 0;
            btnCleaningSterilizing.FlatStyle = FlatStyle.Flat;
            btnCleaningSterilizing.Location = new Point(611, 100);
            btnCleaningSterilizing.Name = "btnCleaningSterilizing";
            btnCleaningSterilizing.Size = new Size(120, 105);
            btnCleaningSterilizing.TabIndex = 19;
            btnCleaningSterilizing.Text = "CLEANING STERILIZING";
            btnCleaningSterilizing.UseVisualStyleBackColor = false;
            // 
            // btnKitchen
            // 
            btnKitchen.BackColor = Color.FromArgb(251, 251, 251);
            btnKitchen.FlatAppearance.BorderSize = 0;
            btnKitchen.FlatStyle = FlatStyle.Flat;
            btnKitchen.Location = new Point(468, 100);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Size = new Size(120, 105);
            btnKitchen.TabIndex = 18;
            btnKitchen.Text = "KITCHEN";
            btnKitchen.UseVisualStyleBackColor = false;
            // 
            // btnGarmentCare
            // 
            btnGarmentCare.BackColor = Color.FromArgb(251, 251, 251);
            btnGarmentCare.FlatAppearance.BorderSize = 0;
            btnGarmentCare.FlatStyle = FlatStyle.Flat;
            btnGarmentCare.Location = new Point(325, 100);
            btnGarmentCare.Name = "btnGarmentCare";
            btnGarmentCare.Size = new Size(120, 105);
            btnGarmentCare.TabIndex = 17;
            btnGarmentCare.Text = "GARMENT CARE";
            btnGarmentCare.UseVisualStyleBackColor = false;
            // 
            // btnEntertainment
            // 
            btnEntertainment.BackColor = Color.FromArgb(251, 251, 251);
            btnEntertainment.FlatAppearance.BorderSize = 0;
            btnEntertainment.FlatStyle = FlatStyle.Flat;
            btnEntertainment.Location = new Point(182, 100);
            btnEntertainment.Name = "btnEntertainment";
            btnEntertainment.Size = new Size(120, 105);
            btnEntertainment.TabIndex = 9;
            btnEntertainment.Text = "ENTERTAINMENT";
            btnEntertainment.UseVisualStyleBackColor = false;
            // 
            // btnAirConditioning
            // 
            btnAirConditioning.BackColor = Color.FromArgb(251, 251, 251);
            btnAirConditioning.FlatAppearance.BorderSize = 0;
            btnAirConditioning.FlatStyle = FlatStyle.Flat;
            btnAirConditioning.Location = new Point(39, 100);
            btnAirConditioning.Name = "btnAirConditioning";
            btnAirConditioning.Size = new Size(120, 105);
            btnAirConditioning.TabIndex = 8;
            btnAirConditioning.Text = "AIR CONDITIONING";
            btnAirConditioning.UseVisualStyleBackColor = false;
            // 
            // flpAppliancesList
            // 
            flpAppliancesList.AutoScroll = true;
            flpAppliancesList.BackColor = Color.Transparent;
            flpAppliancesList.Location = new Point(29, 247);
            flpAppliancesList.Name = "flpAppliancesList";
            flpAppliancesList.Size = new Size(849, 287);
            flpAppliancesList.TabIndex = 21;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.Transparent;
            searchBox.Cursor = Cursors.Hand;
            searchBox.Location = new Point(40, 31);
            searchBox.Name = "searchBox";
            searchBox.SearchEvent = null;
            searchBox.Size = new Size(834, 33);
            searchBox.TabIndex = 22;
            // 
            // CheckoutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.mainview_bg;
            Controls.Add(searchBox);
            Controls.Add(flpAppliancesList);
            Controls.Add(btnFansAndAirCoolers);
            Controls.Add(btnCleaningSterilizing);
            Controls.Add(btnKitchen);
            Controls.Add(btnGarmentCare);
            Controls.Add(cmbSort);
            Controls.Add(label6);
            Controls.Add(btnEntertainment);
            Controls.Add(btnAirConditioning);
            Controls.Add(label2);
            Controls.Add(pnlSummary);
            Name = "CheckoutView";
            Size = new Size(1221, 554);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            flpTransactionDetails.ResumeLayout(false);
            pnlAmount.ResumeLayout(false);
            pnlAmount.PerformLayout();
            pnlSenior.ResumeLayout(false);
            pnlSenior.PerformLayout();
            pnlVAT.ResumeLayout(false);
            pnlVAT.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flpCustomer.ResumeLayout(false);
            flpCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSummary;
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
        private Panel panel3;
        private Label lblTotalAmount;
        private Label label3;
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
        private Button btnPay;
        private Panel pnlHighlight;
        private Label lblPay;
        private Label lblPayTotalAmount;
        private Label label2;
        private Label label6;
        private ComboBox cmbSort;
        private Button btnFansAndAirCoolers;
        private Button btnCleaningSterilizing;
        private Button btnKitchen;
        private Button btnGarmentCare;
        private Button btnEntertainment;
        private Button btnAirConditioning;
        private Custom_Controls.CustomFlowLayout flpAppliancesList;
        private Custom_Controls.CustomFlowLayout flpLineItems;
        private User_Controls.SearchBox searchBox;
        private CheckBox chkIsSeniorOrPwd;
    }
}
