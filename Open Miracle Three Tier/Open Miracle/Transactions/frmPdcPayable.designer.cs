namespace Open_Miracle
{
    partial class frmPdcPayable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdcPayable));
            this.cbxPrint = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.btnNewAccountLedger = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblAccountledger = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblvoucherNo = new System.Windows.Forms.Label();
            this.txtvoucherNo = new System.Windows.Forms.TextBox();
            this.btnAgainstRef = new System.Windows.Forms.Button();
            this.gpxDetails = new System.Windows.Forms.GroupBox();
            this.lblBankValidator = new System.Windows.Forms.Label();
            this.lblChecknoValidator = new System.Windows.Forms.Label();
            this.lbAmountValidator = new System.Windows.Forms.Label();
            this.dtpchekdate = new System.Windows.Forms.DateTimePicker();
            this.txtChequeDate = new System.Windows.Forms.TextBox();
            this.lblCheckdate = new System.Windows.Forms.Label();
            this.btnNewAccountLedger2 = new System.Windows.Forms.Button();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblCheckNo = new System.Windows.Forms.Label();
            this.txtcheckNo = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherDate = new System.Windows.Forms.TextBox();
            this.lblAccountLedgerValidator = new System.Windows.Forms.Label();
            this.lblVoucherNoManualValidator = new System.Windows.Forms.Label();
            this.gpxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPrint
            // 
            this.cbxPrint.AutoSize = true;
            this.cbxPrint.ForeColor = System.Drawing.Color.White;
            this.cbxPrint.Location = new System.Drawing.Point(15, 277);
            this.cbxPrint.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrint.Name = "cbxPrint";
            this.cbxPrint.Size = new System.Drawing.Size(97, 17);
            this.cbxPrint.TabIndex = 10;
            this.cbxPrint.Text = "Print after save";
            this.cbxPrint.UseVisualStyleBackColor = true;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(285, 164);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 473;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(380, 164);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(400, 100);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // btnNewAccountLedger
            // 
            this.btnNewAccountLedger.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnNewAccountLedger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewAccountLedger.FlatAppearance.BorderSize = 0;
            this.btnNewAccountLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccountLedger.ForeColor = System.Drawing.Color.White;
            this.btnNewAccountLedger.Location = new System.Drawing.Point(320, 40);
            this.btnNewAccountLedger.Name = "btnNewAccountLedger";
            this.btnNewAccountLedger.Size = new System.Drawing.Size(21, 20);
            this.btnNewAccountLedger.TabIndex = 2;
            this.btnNewAccountLedger.UseVisualStyleBackColor = true;
            this.btnNewAccountLedger.Click += new System.EventHandler(this.btnNewAccountLedger_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(487, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 463;
            this.lblDate.Text = "Date";
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(115, 40);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 1;
            this.cmbAccountLedger.SelectedIndexChanged += new System.EventHandler(this.cmbAccountLedger_SelectedIndexChanged);
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            this.cmbAccountLedger.Leave += new System.EventHandler(this.cmbAccountLedger_Leave);
            // 
            // lblAccountledger
            // 
            this.lblAccountledger.AutoSize = true;
            this.lblAccountledger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountledger.Location = new System.Drawing.Point(20, 44);
            this.lblAccountledger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountledger.Name = "lblAccountledger";
            this.lblAccountledger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountledger.TabIndex = 457;
            this.lblAccountledger.Text = "Account Ledger";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblvoucherNo
            // 
            this.lblvoucherNo.AutoSize = true;
            this.lblvoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvoucherNo.Location = new System.Drawing.Point(20, 19);
            this.lblvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblvoucherNo.Name = "lblvoucherNo";
            this.lblvoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblvoucherNo.TabIndex = 451;
            this.lblvoucherNo.Text = "Voucher No.";
            // 
            // txtvoucherNo
            // 
            this.txtvoucherNo.Location = new System.Drawing.Point(115, 15);
            this.txtvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtvoucherNo.Name = "txtvoucherNo";
            this.txtvoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtvoucherNo.TabIndex = 7568;
            this.txtvoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucherNo_KeyDown);
            // 
            // btnAgainstRef
            // 
            this.btnAgainstRef.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnAgainstRef.Enabled = false;
            this.btnAgainstRef.FlatAppearance.BorderSize = 0;
            this.btnAgainstRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgainstRef.ForeColor = System.Drawing.Color.White;
            this.btnAgainstRef.Location = new System.Drawing.Point(368, 33);
            this.btnAgainstRef.Name = "btnAgainstRef";
            this.btnAgainstRef.Size = new System.Drawing.Size(85, 27);
            this.btnAgainstRef.TabIndex = 3;
            this.btnAgainstRef.Text = "Against Ref.";
            this.btnAgainstRef.UseVisualStyleBackColor = true;
            this.btnAgainstRef.Click += new System.EventHandler(this.btnAgainstRef_Click);
            // 
            // gpxDetails
            // 
            this.gpxDetails.Controls.Add(this.lblBankValidator);
            this.gpxDetails.Controls.Add(this.lblChecknoValidator);
            this.gpxDetails.Controls.Add(this.lbAmountValidator);
            this.gpxDetails.Controls.Add(this.dtpchekdate);
            this.gpxDetails.Controls.Add(this.txtChequeDate);
            this.gpxDetails.Controls.Add(this.lblCheckdate);
            this.gpxDetails.Controls.Add(this.btnNewAccountLedger2);
            this.gpxDetails.Controls.Add(this.cmbBank);
            this.gpxDetails.Controls.Add(this.lblBank);
            this.gpxDetails.Controls.Add(this.lblCheckNo);
            this.gpxDetails.Controls.Add(this.txtcheckNo);
            this.gpxDetails.Controls.Add(this.lblAmount);
            this.gpxDetails.Controls.Add(this.txtAmount);
            this.gpxDetails.ForeColor = System.Drawing.Color.White;
            this.gpxDetails.Location = new System.Drawing.Point(15, 68);
            this.gpxDetails.Margin = new System.Windows.Forms.Padding(5);
            this.gpxDetails.Name = "gpxDetails";
            this.gpxDetails.Padding = new System.Windows.Forms.Padding(10);
            this.gpxDetails.Size = new System.Drawing.Size(765, 86);
            this.gpxDetails.TabIndex = 4;
            this.gpxDetails.TabStop = false;
            this.gpxDetails.Text = "Details";
            // 
            // lblBankValidator
            // 
            this.lblBankValidator.AutoSize = true;
            this.lblBankValidator.ForeColor = System.Drawing.Color.Red;
            this.lblBankValidator.Location = new System.Drawing.Point(698, 25);
            this.lblBankValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblBankValidator.Name = "lblBankValidator";
            this.lblBankValidator.Size = new System.Drawing.Size(11, 13);
            this.lblBankValidator.TabIndex = 1150;
            this.lblBankValidator.Text = "*";
            // 
            // lblChecknoValidator
            // 
            this.lblChecknoValidator.AutoSize = true;
            this.lblChecknoValidator.ForeColor = System.Drawing.Color.Red;
            this.lblChecknoValidator.Location = new System.Drawing.Point(331, 50);
            this.lblChecknoValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblChecknoValidator.Name = "lblChecknoValidator";
            this.lblChecknoValidator.Size = new System.Drawing.Size(11, 13);
            this.lblChecknoValidator.TabIndex = 1149;
            this.lblChecknoValidator.Text = "*";
            // 
            // lbAmountValidator
            // 
            this.lbAmountValidator.AutoSize = true;
            this.lbAmountValidator.ForeColor = System.Drawing.Color.Red;
            this.lbAmountValidator.Location = new System.Drawing.Point(331, 25);
            this.lbAmountValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lbAmountValidator.Name = "lbAmountValidator";
            this.lbAmountValidator.Size = new System.Drawing.Size(11, 13);
            this.lbAmountValidator.TabIndex = 1148;
            this.lbAmountValidator.Text = "*";
            // 
            // dtpchekdate
            // 
            this.dtpchekdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpchekdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpchekdate.Location = new System.Drawing.Point(678, 46);
            this.dtpchekdate.Name = "dtpchekdate";
            this.dtpchekdate.Size = new System.Drawing.Size(20, 20);
            this.dtpchekdate.TabIndex = 480;
            this.dtpchekdate.CloseUp += new System.EventHandler(this.dtpchekdate_CloseUp);
            this.dtpchekdate.ValueChanged += new System.EventHandler(this.dtpchekdate_ValueChanged);
            // 
            // txtChequeDate
            // 
            this.txtChequeDate.Location = new System.Drawing.Point(498, 46);
            this.txtChequeDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeDate.Name = "txtChequeDate";
            this.txtChequeDate.Size = new System.Drawing.Size(200, 20);
            this.txtChequeDate.TabIndex = 4;
            this.txtChequeDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeDate_KeyDown);
            this.txtChequeDate.Leave += new System.EventHandler(this.txtChequeDate_Leave);
            // 
            // lblCheckdate
            // 
            this.lblCheckdate.AutoSize = true;
            this.lblCheckdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckdate.Location = new System.Drawing.Point(388, 50);
            this.lblCheckdate.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckdate.Name = "lblCheckdate";
            this.lblCheckdate.Size = new System.Drawing.Size(70, 13);
            this.lblCheckdate.TabIndex = 475;
            this.lblCheckdate.Text = "Cheque Date";
            // 
            // btnNewAccountLedger2
            // 
            this.btnNewAccountLedger2.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnNewAccountLedger2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewAccountLedger2.FlatAppearance.BorderSize = 0;
            this.btnNewAccountLedger2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccountLedger2.ForeColor = System.Drawing.Color.White;
            this.btnNewAccountLedger2.Location = new System.Drawing.Point(717, 21);
            this.btnNewAccountLedger2.Name = "btnNewAccountLedger2";
            this.btnNewAccountLedger2.Size = new System.Drawing.Size(21, 20);
            this.btnNewAccountLedger2.TabIndex = 2;
            this.btnNewAccountLedger2.UseVisualStyleBackColor = true;
            this.btnNewAccountLedger2.Click += new System.EventHandler(this.btnNewAccountLedger2_Click);
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(498, 21);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(200, 21);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBank_KeyDown);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBank.Location = new System.Drawing.Point(389, 25);
            this.lblBank.Margin = new System.Windows.Forms.Padding(5);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 472;
            this.lblBank.Text = "Bank";
            // 
            // lblCheckNo
            // 
            this.lblCheckNo.AutoSize = true;
            this.lblCheckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckNo.Location = new System.Drawing.Point(15, 50);
            this.lblCheckNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblCheckNo.Name = "lblCheckNo";
            this.lblCheckNo.Size = new System.Drawing.Size(64, 13);
            this.lblCheckNo.TabIndex = 455;
            this.lblCheckNo.Text = "Cheque No.";
            // 
            // txtcheckNo
            // 
            this.txtcheckNo.Location = new System.Drawing.Point(126, 46);
            this.txtcheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckNo.Name = "txtcheckNo";
            this.txtcheckNo.Size = new System.Drawing.Size(200, 20);
            this.txtcheckNo.TabIndex = 3;
            this.txtcheckNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckNo_KeyDown);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(16, 25);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 453;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(126, 21);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(762, 15);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(20, 20);
            this.dtpVoucherDate.TabIndex = 478;
            this.dtpVoucherDate.CloseUp += new System.EventHandler(this.dtpVoucherDate_CloseUp);
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.Location = new System.Drawing.Point(582, 15);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(181, 20);
            this.txtVoucherDate.TabIndex = 0;
            this.txtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDate_KeyDown);
            this.txtVoucherDate.Leave += new System.EventHandler(this.txtVoucherDate_Leave);
            // 
            // lblAccountLedgerValidator
            // 
            this.lblAccountLedgerValidator.AutoSize = true;
            this.lblAccountLedgerValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAccountLedgerValidator.Location = new System.Drawing.Point(347, 44);
            this.lblAccountLedgerValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblAccountLedgerValidator.Name = "lblAccountLedgerValidator";
            this.lblAccountLedgerValidator.Size = new System.Drawing.Size(11, 13);
            this.lblAccountLedgerValidator.TabIndex = 1147;
            this.lblAccountLedgerValidator.Text = "*";
            // 
            // lblVoucherNoManualValidator
            // 
            this.lblVoucherNoManualValidator.AutoSize = true;
            this.lblVoucherNoManualValidator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNoManualValidator.Location = new System.Drawing.Point(329, 19);
            this.lblVoucherNoManualValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherNoManualValidator.Name = "lblVoucherNoManualValidator";
            this.lblVoucherNoManualValidator.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherNoManualValidator.TabIndex = 1150;
            this.lblVoucherNoManualValidator.Text = "*";
            this.lblVoucherNoManualValidator.Visible = false;
            // 
            // frmPdcPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.lblVoucherNoManualValidator);
            this.Controls.Add(this.lblAccountLedgerValidator);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.gpxDetails);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.btnAgainstRef);
            this.Controls.Add(this.cbxPrint);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.btnNewAccountLedger);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountledger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblvoucherNo);
            this.Controls.Add(this.txtvoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPdcPayable";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Payable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPdcPayable_FormClosing);
            this.Load += new System.EventHandler(this.frmPdcPayable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPdcPayable_KeyDown);
            this.gpxDetails.ResumeLayout(false);
            this.gpxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPrint;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Button btnNewAccountLedger;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblAccountledger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblvoucherNo;
        private System.Windows.Forms.TextBox txtvoucherNo;
        private System.Windows.Forms.Button btnAgainstRef;
        private System.Windows.Forms.GroupBox gpxDetails;
        private System.Windows.Forms.Label lblCheckdate;
        private System.Windows.Forms.Button btnNewAccountLedger2;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblCheckNo;
        private System.Windows.Forms.TextBox txtcheckNo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.TextBox txtVoucherDate;
        private System.Windows.Forms.DateTimePicker dtpchekdate;
        private System.Windows.Forms.TextBox txtChequeDate;
        private System.Windows.Forms.Label lblAccountLedgerValidator;
        private System.Windows.Forms.Label lblBankValidator;
        private System.Windows.Forms.Label lblChecknoValidator;
        private System.Windows.Forms.Label lbAmountValidator;
        private System.Windows.Forms.Label lblVoucherNoManualValidator;
    }
}