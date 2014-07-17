namespace Open_Miracle{
    partial class frmPdcClearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdcClearance));
            this.cmbvouchertype = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblvoucherNo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtvoucherNo = new System.Windows.Forms.TextBox();
            this.lblvoucherDate = new System.Windows.Forms.Label();
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.lblAgainstVoucherNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtcheckdate = new System.Windows.Forms.TextBox();
            this.lblcheckdate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtcheckNo = new System.Windows.Forms.TextBox();
            this.lblcheckNo = new System.Windows.Forms.Label();
            this.txtAccountLedger = new System.Windows.Forms.TextBox();
            this.lblbank = new System.Windows.Forms.Label();
            this.lblaccountledger = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxPrint = new System.Windows.Forms.CheckBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherDate = new System.Windows.Forms.TextBox();
            this.lblVoucherNoManualValidator = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.lblAgainstInvoiceNumber = new System.Windows.Forms.Label();
            this.lblstatusSelect = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbvouchertype
            // 
            this.cmbvouchertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvouchertype.FormattingEnabled = true;
            this.cmbvouchertype.Location = new System.Drawing.Point(110, 39);
            this.cmbvouchertype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbvouchertype.Name = "cmbvouchertype";
            this.cmbvouchertype.Size = new System.Drawing.Size(200, 21);
            this.cmbvouchertype.TabIndex = 2;
            this.cmbvouchertype.SelectedIndexChanged += new System.EventHandler(this.cmbvouchertype_SelectedIndexChanged);
            this.cmbvouchertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbvouchertype_KeyDown);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(16, 43);
            this.lblType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 13);
            this.lblType.TabIndex = 533;
            this.lblType.Text = "Voucher Type";
            // 
            // lblvoucherNo
            // 
            this.lblvoucherNo.AutoSize = true;
            this.lblvoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvoucherNo.Location = new System.Drawing.Point(16, 18);
            this.lblvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblvoucherNo.Name = "lblvoucherNo";
            this.lblvoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblvoucherNo.TabIndex = 529;
            this.lblvoucherNo.Text = "Voucher No.";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtvoucherNo
            // 
            this.txtvoucherNo.Location = new System.Drawing.Point(110, 14);
            this.txtvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtvoucherNo.Name = "txtvoucherNo";
            this.txtvoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtvoucherNo.TabIndex = 0;
            this.txtvoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucherNo_KeyDown);
            // 
            // lblvoucherDate
            // 
            this.lblvoucherDate.AutoSize = true;
            this.lblvoucherDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvoucherDate.Location = new System.Drawing.Point(457, 18);
            this.lblvoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblvoucherDate.Name = "lblvoucherDate";
            this.lblvoucherDate.Size = new System.Drawing.Size(73, 13);
            this.lblvoucherDate.TabIndex = 538;
            this.lblvoucherDate.Text = "Voucher Date";
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceNo.FormattingEnabled = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(580, 39);
            this.cmbInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(200, 21);
            this.cmbInvoiceNo.TabIndex = 3;
            this.cmbInvoiceNo.SelectedValueChanged += new System.EventHandler(this.cmbInvoiceNo_SelectedValueChanged);
            this.cmbInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceNo_KeyDown);
            // 
            // lblAgainstVoucherNo
            // 
            this.lblAgainstVoucherNo.AutoSize = true;
            this.lblAgainstVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgainstVoucherNo.Location = new System.Drawing.Point(457, 43);
            this.lblAgainstVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAgainstVoucherNo.Name = "lblAgainstVoucherNo";
            this.lblAgainstVoucherNo.Size = new System.Drawing.Size(100, 13);
            this.lblAgainstVoucherNo.TabIndex = 540;
            this.lblAgainstVoucherNo.Text = "Against Invoice No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.txtcheckdate);
            this.groupBox1.Controls.Add(this.lblcheckdate);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblamount);
            this.groupBox1.Controls.Add(this.txtcheckNo);
            this.groupBox1.Controls.Add(this.lblcheckNo);
            this.groupBox1.Controls.Add(this.txtAccountLedger);
            this.groupBox1.Controls.Add(this.lblbank);
            this.groupBox1.Controls.Add(this.lblaccountledger);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(116, 71);
            this.txtBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(175, 20);
            this.txtBank.TabIndex = 4;
            // 
            // txtcheckdate
            // 
            this.txtcheckdate.Location = new System.Drawing.Point(562, 46);
            this.txtcheckdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckdate.Name = "txtcheckdate";
            this.txtcheckdate.ReadOnly = true;
            this.txtcheckdate.Size = new System.Drawing.Size(175, 20);
            this.txtcheckdate.TabIndex = 3;
            // 
            // lblcheckdate
            // 
            this.lblcheckdate.AutoSize = true;
            this.lblcheckdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcheckdate.Location = new System.Drawing.Point(482, 50);
            this.lblcheckdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcheckdate.Name = "lblcheckdate";
            this.lblcheckdate.Size = new System.Drawing.Size(70, 13);
            this.lblcheckdate.TabIndex = 544;
            this.lblcheckdate.Text = "Cheque Date";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(562, 21);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(175, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblamount.Location = new System.Drawing.Point(482, 25);
            this.lblamount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(43, 13);
            this.lblamount.TabIndex = 542;
            this.lblamount.Text = "Amount";
            // 
            // txtcheckNo
            // 
            this.txtcheckNo.Location = new System.Drawing.Point(116, 46);
            this.txtcheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckNo.Name = "txtcheckNo";
            this.txtcheckNo.ReadOnly = true;
            this.txtcheckNo.Size = new System.Drawing.Size(176, 20);
            this.txtcheckNo.TabIndex = 2;
            // 
            // lblcheckNo
            // 
            this.lblcheckNo.AutoSize = true;
            this.lblcheckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcheckNo.Location = new System.Drawing.Point(19, 50);
            this.lblcheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcheckNo.Name = "lblcheckNo";
            this.lblcheckNo.Size = new System.Drawing.Size(64, 13);
            this.lblcheckNo.TabIndex = 540;
            this.lblcheckNo.Text = "Cheque No.";
            // 
            // txtAccountLedger
            // 
            this.txtAccountLedger.Location = new System.Drawing.Point(116, 21);
            this.txtAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAccountLedger.Name = "txtAccountLedger";
            this.txtAccountLedger.ReadOnly = true;
            this.txtAccountLedger.Size = new System.Drawing.Size(176, 20);
            this.txtAccountLedger.TabIndex = 0;
            // 
            // lblbank
            // 
            this.lblbank.AutoSize = true;
            this.lblbank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbank.Location = new System.Drawing.Point(19, 75);
            this.lblbank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblbank.Name = "lblbank";
            this.lblbank.Size = new System.Drawing.Size(32, 13);
            this.lblbank.TabIndex = 543;
            this.lblbank.Text = "Bank";
            // 
            // lblaccountledger
            // 
            this.lblaccountledger.AutoSize = true;
            this.lblaccountledger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblaccountledger.Location = new System.Drawing.Point(19, 25);
            this.lblaccountledger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblaccountledger.Name = "lblaccountledger";
            this.lblaccountledger.Size = new System.Drawing.Size(83, 13);
            this.lblaccountledger.TabIndex = 538;
            this.lblaccountledger.Text = "Account Ledger";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(580, 178);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(510, 178);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 546;
            this.lblNarration.Text = "Narration";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Cleared",
            "Bounced"});
            this.cmbStatus.Location = new System.Drawing.Point(110, 178);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(16, 182);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 548;
            this.lblStatus.Text = "Status";
            // 
            // cbxPrint
            // 
            this.cbxPrint.AutoSize = true;
            this.cbxPrint.ForeColor = System.Drawing.Color.White;
            this.cbxPrint.Location = new System.Drawing.Point(20, 237);
            this.cbxPrint.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrint.Name = "cbxPrint";
            this.cbxPrint.Size = new System.Drawing.Size(97, 17);
            this.cbxPrint.TabIndex = 11;
            this.cbxPrint.Text = "Print after save";
            this.cbxPrint.UseVisualStyleBackColor = true;
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(760, 14);
            this.dtpVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(20, 20);
            this.dtpVoucherDate.TabIndex = 1147;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.Location = new System.Drawing.Point(580, 14);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(181, 20);
            this.txtVoucherDate.TabIndex = 1;
            this.txtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDate_KeyDown);
            this.txtVoucherDate.Leave += new System.EventHandler(this.txtVoucherDate_Leave);
            // 
            // lblVoucherNoManualValidator
            // 
            this.lblVoucherNoManualValidator.AutoSize = true;
            this.lblVoucherNoManualValidator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNoManualValidator.Location = new System.Drawing.Point(320, 18);
            this.lblVoucherNoManualValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNoManualValidator.Name = "lblVoucherNoManualValidator";
            this.lblVoucherNoManualValidator.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherNoManualValidator.TabIndex = 1151;
            this.lblVoucherNoManualValidator.Text = "*";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherType.Location = new System.Drawing.Point(320, 43);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherType.TabIndex = 1152;
            this.lblVoucherType.Text = "*";
            // 
            // lblAgainstInvoiceNumber
            // 
            this.lblAgainstInvoiceNumber.AutoSize = true;
            this.lblAgainstInvoiceNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAgainstInvoiceNumber.Location = new System.Drawing.Point(780, 43);
            this.lblAgainstInvoiceNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAgainstInvoiceNumber.Name = "lblAgainstInvoiceNumber";
            this.lblAgainstInvoiceNumber.Size = new System.Drawing.Size(11, 13);
            this.lblAgainstInvoiceNumber.TabIndex = 1153;
            this.lblAgainstInvoiceNumber.Text = "*";
            // 
            // lblstatusSelect
            // 
            this.lblstatusSelect.AutoSize = true;
            this.lblstatusSelect.ForeColor = System.Drawing.Color.Red;
            this.lblstatusSelect.Location = new System.Drawing.Point(320, 182);
            this.lblstatusSelect.Margin = new System.Windows.Forms.Padding(5);
            this.lblstatusSelect.Name = "lblstatusSelect";
            this.lblstatusSelect.Size = new System.Drawing.Size(11, 13);
            this.lblstatusSelect.TabIndex = 1154;
            this.lblstatusSelect.Text = "*";
            // 
            // frmPdcClearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.lblstatusSelect);
            this.Controls.Add(this.lblAgainstInvoiceNumber);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.lblVoucherNoManualValidator);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.cbxPrint);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbInvoiceNo);
            this.Controls.Add(this.lblAgainstVoucherNo);
            this.Controls.Add(this.lblvoucherDate);
            this.Controls.Add(this.txtvoucherNo);
            this.Controls.Add(this.cmbvouchertype);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblvoucherNo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPdcClearance";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Clearance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPdcClearance_FormClosing);
            this.Load += new System.EventHandler(this.frmPdcClearance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPdcClearance_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbvouchertype;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblvoucherNo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtvoucherNo;
        private System.Windows.Forms.Label lblvoucherDate;
        private System.Windows.Forms.ComboBox cmbInvoiceNo;
        private System.Windows.Forms.Label lblAgainstVoucherNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcheckdate;
        private System.Windows.Forms.Label lblcheckdate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtcheckNo;
        private System.Windows.Forms.Label lblcheckNo;
        private System.Windows.Forms.TextBox txtAccountLedger;
        private System.Windows.Forms.Label lblaccountledger;
        private System.Windows.Forms.Label lblbank;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbxPrint;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.TextBox txtVoucherDate;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblVoucherNoManualValidator;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.Label lblAgainstInvoiceNumber;
        private System.Windows.Forms.Label lblstatusSelect;

    }
}