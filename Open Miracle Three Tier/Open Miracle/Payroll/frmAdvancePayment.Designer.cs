namespace Open_Miracle
{
    partial class frmAdvancePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvancePayment));
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnAdvancePaymentClose = new System.Windows.Forms.Button();
            this.btnAdvancePaymentDelete = new System.Windows.Forms.Button();
            this.txtAdvanceVoucherNo = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblAdvanceVoucherNo = new System.Windows.Forms.Label();
            this.btnAdvancePaymentSave = new System.Windows.Forms.Button();
            this.btnAdvancePaymetClear = new System.Windows.Forms.Button();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.lblCheckNo = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblCheckDate = new System.Windows.Forms.Label();
            this.cmbCashOrBank = new System.Windows.Forms.ComboBox();
            this.lblCashOrBank = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpCheckDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdvancePaymentEmployee = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCashOrBank = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdvanceVoucherNoValidator = new System.Windows.Forms.Label();
            this.lblEmployeeValidator = new System.Windows.Forms.Label();
            this.lblblSalaryMonthValidator = new System.Windows.Forms.Label();
            this.lblDateValidator = new System.Windows.Forms.Label();
            this.lblAmountValidator = new System.Windows.Forms.Label();
            this.lblCashOrBankValidator = new System.Windows.Forms.Label();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtChequeDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(133, 40);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 2;
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // btnAdvancePaymentClose
            // 
            this.btnAdvancePaymentClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnAdvancePaymentClose.FlatAppearance.BorderSize = 0;
            this.btnAdvancePaymentClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancePaymentClose.ForeColor = System.Drawing.Color.White;
            this.btnAdvancePaymentClose.Location = new System.Drawing.Point(697, 173);
            this.btnAdvancePaymentClose.Name = "btnAdvancePaymentClose";
            this.btnAdvancePaymentClose.Size = new System.Drawing.Size(85, 27);
            this.btnAdvancePaymentClose.TabIndex = 14;
            this.btnAdvancePaymentClose.Text = "Close";
            this.btnAdvancePaymentClose.UseVisualStyleBackColor = true;
            this.btnAdvancePaymentClose.Click += new System.EventHandler(this.btnAdvancePaymentClose_Click);
            // 
            // btnAdvancePaymentDelete
            // 
            this.btnAdvancePaymentDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnAdvancePaymentDelete.FlatAppearance.BorderSize = 0;
            this.btnAdvancePaymentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancePaymentDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdvancePaymentDelete.Location = new System.Drawing.Point(606, 173);
            this.btnAdvancePaymentDelete.Name = "btnAdvancePaymentDelete";
            this.btnAdvancePaymentDelete.Size = new System.Drawing.Size(85, 27);
            this.btnAdvancePaymentDelete.TabIndex = 13;
            this.btnAdvancePaymentDelete.Text = "Delete";
            this.btnAdvancePaymentDelete.UseVisualStyleBackColor = true;
            this.btnAdvancePaymentDelete.Click += new System.EventHandler(this.btnAdvancePaymentDelete_Click);
            // 
            // txtAdvanceVoucherNo
            // 
            this.txtAdvanceVoucherNo.Location = new System.Drawing.Point(133, 15);
            this.txtAdvanceVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAdvanceVoucherNo.Name = "txtAdvanceVoucherNo";
            this.txtAdvanceVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtAdvanceVoucherNo.TabIndex = 0;
            this.txtAdvanceVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdvanceVoucherNo_KeyDown);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployee.Location = new System.Drawing.Point(15, 43);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(84, 13);
            this.lblEmployee.TabIndex = 21;
            this.lblEmployee.Text = "Employee Name";
            // 
            // lblAdvanceVoucherNo
            // 
            this.lblAdvanceVoucherNo.AutoSize = true;
            this.lblAdvanceVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdvanceVoucherNo.Location = new System.Drawing.Point(15, 19);
            this.lblAdvanceVoucherNo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblAdvanceVoucherNo.Name = "lblAdvanceVoucherNo";
            this.lblAdvanceVoucherNo.Size = new System.Drawing.Size(113, 13);
            this.lblAdvanceVoucherNo.TabIndex = 20;
            this.lblAdvanceVoucherNo.Text = "Advance Voucher No.";
            // 
            // btnAdvancePaymentSave
            // 
            this.btnAdvancePaymentSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnAdvancePaymentSave.FlatAppearance.BorderSize = 0;
            this.btnAdvancePaymentSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancePaymentSave.ForeColor = System.Drawing.Color.White;
            this.btnAdvancePaymentSave.Location = new System.Drawing.Point(424, 173);
            this.btnAdvancePaymentSave.Name = "btnAdvancePaymentSave";
            this.btnAdvancePaymentSave.Size = new System.Drawing.Size(85, 27);
            this.btnAdvancePaymentSave.TabIndex = 11;
            this.btnAdvancePaymentSave.Text = "Save";
            this.btnAdvancePaymentSave.UseVisualStyleBackColor = true;
            this.btnAdvancePaymentSave.Click += new System.EventHandler(this.btnAdvancePaymentSave_Click);
            this.btnAdvancePaymentSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdvancePaymentSave_KeyDown);
            // 
            // btnAdvancePaymetClear
            // 
            this.btnAdvancePaymetClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnAdvancePaymetClear.FlatAppearance.BorderSize = 0;
            this.btnAdvancePaymetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancePaymetClear.ForeColor = System.Drawing.Color.White;
            this.btnAdvancePaymetClear.Location = new System.Drawing.Point(515, 173);
            this.btnAdvancePaymetClear.Name = "btnAdvancePaymetClear";
            this.btnAdvancePaymetClear.Size = new System.Drawing.Size(85, 27);
            this.btnAdvancePaymetClear.TabIndex = 12;
            this.btnAdvancePaymetClear.Text = "Clear";
            this.btnAdvancePaymetClear.UseVisualStyleBackColor = true;
            this.btnAdvancePaymetClear.Click += new System.EventHandler(this.btnAdvancePaymetClear_Click);
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryMonth.Location = new System.Drawing.Point(15, 70);
            this.lblSalaryMonth.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(69, 13);
            this.lblSalaryMonth.TabIndex = 22;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(133, 91);
            this.txtCheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(200, 20);
            this.txtCheckNo.TabIndex = 8;
            this.txtCheckNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckNo_KeyDown);
            // 
            // lblCheckNo
            // 
            this.lblCheckNo.AutoSize = true;
            this.lblCheckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckNo.Location = new System.Drawing.Point(15, 94);
            this.lblCheckNo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblCheckNo.Name = "lblCheckNo";
            this.lblCheckNo.Size = new System.Drawing.Size(61, 13);
            this.lblCheckNo.TabIndex = 23;
            this.lblCheckNo.Text = "Cheque No";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(543, 116);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 10;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(428, 116);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 28;
            this.lblNarration.Text = "Narration";
            // 
            // lblCheckDate
            // 
            this.lblCheckDate.AutoSize = true;
            this.lblCheckDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckDate.Location = new System.Drawing.Point(426, 94);
            this.lblCheckDate.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblCheckDate.Name = "lblCheckDate";
            this.lblCheckDate.Size = new System.Drawing.Size(70, 13);
            this.lblCheckDate.TabIndex = 27;
            this.lblCheckDate.Text = "Cheque Date";
            // 
            // cmbCashOrBank
            // 
            this.cmbCashOrBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBank.FormattingEnabled = true;
            this.cmbCashOrBank.Location = new System.Drawing.Point(543, 65);
            this.cmbCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrBank.Name = "cmbCashOrBank";
            this.cmbCashOrBank.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrBank.TabIndex = 6;
            this.cmbCashOrBank.SelectedValueChanged += new System.EventHandler(this.cmbCashOrBank_SelectedValueChanged);
            this.cmbCashOrBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBank_KeyDown);
            // 
            // lblCashOrBank
            // 
            this.lblCashOrBank.AutoSize = true;
            this.lblCashOrBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrBank.Location = new System.Drawing.Point(426, 70);
            this.lblCashOrBank.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblCashOrBank.Name = "lblCashOrBank";
            this.lblCashOrBank.Size = new System.Drawing.Size(87, 13);
            this.lblCashOrBank.TabIndex = 26;
            this.lblCashOrBank.Text = "Cash / Bank a/c";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(426, 43);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(426, 18);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // dtpCheckDate
            // 
            this.dtpCheckDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckDate.Location = new System.Drawing.Point(721, 91);
            this.dtpCheckDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpCheckDate.Name = "dtpCheckDate";
            this.dtpCheckDate.Size = new System.Drawing.Size(22, 20);
            this.dtpCheckDate.TabIndex = 80;
            this.dtpCheckDate.ValueChanged += new System.EventHandler(this.dtpCheckDate_ValueChanged);
            // 
            // btnAdvancePaymentEmployee
            // 
            this.btnAdvancePaymentEmployee.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAdvancePaymentEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdvancePaymentEmployee.FlatAppearance.BorderSize = 0;
            this.btnAdvancePaymentEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancePaymentEmployee.Location = new System.Drawing.Point(355, 41);
            this.btnAdvancePaymentEmployee.Name = "btnAdvancePaymentEmployee";
            this.btnAdvancePaymentEmployee.Size = new System.Drawing.Size(20, 20);
            this.btnAdvancePaymentEmployee.TabIndex = 3;
            this.btnAdvancePaymentEmployee.UseVisualStyleBackColor = true;
            this.btnAdvancePaymentEmployee.Click += new System.EventHandler(this.btnAdvancePaymentEmployee_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(543, 40);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAmount.MaxLength = 13;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "0";
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnCashOrBank
            // 
            this.btnCashOrBank.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnCashOrBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashOrBank.FlatAppearance.BorderSize = 0;
            this.btnCashOrBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOrBank.Location = new System.Drawing.Point(762, 65);
            this.btnCashOrBank.Name = "btnCashOrBank";
            this.btnCashOrBank.Size = new System.Drawing.Size(20, 20);
            this.btnCashOrBank.TabIndex = 7;
            this.btnCashOrBank.UseVisualStyleBackColor = true;
            this.btnCashOrBank.Click += new System.EventHandler(this.btnCashOrBank_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(721, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(22, 20);
            this.dtpDate.TabIndex = 75;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblAdvanceVoucherNoValidator
            // 
            this.lblAdvanceVoucherNoValidator.AutoSize = true;
            this.lblAdvanceVoucherNoValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAdvanceVoucherNoValidator.Location = new System.Drawing.Point(338, 22);
            this.lblAdvanceVoucherNoValidator.Name = "lblAdvanceVoucherNoValidator";
            this.lblAdvanceVoucherNoValidator.Size = new System.Drawing.Size(11, 13);
            this.lblAdvanceVoucherNoValidator.TabIndex = 73;
            this.lblAdvanceVoucherNoValidator.Text = "*";
            // 
            // lblEmployeeValidator
            // 
            this.lblEmployeeValidator.AutoSize = true;
            this.lblEmployeeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeValidator.Location = new System.Drawing.Point(338, 48);
            this.lblEmployeeValidator.Name = "lblEmployeeValidator";
            this.lblEmployeeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblEmployeeValidator.TabIndex = 74;
            this.lblEmployeeValidator.Text = "*";
            // 
            // lblblSalaryMonthValidator
            // 
            this.lblblSalaryMonthValidator.AutoSize = true;
            this.lblblSalaryMonthValidator.ForeColor = System.Drawing.Color.Red;
            this.lblblSalaryMonthValidator.Location = new System.Drawing.Point(338, 73);
            this.lblblSalaryMonthValidator.Name = "lblblSalaryMonthValidator";
            this.lblblSalaryMonthValidator.Size = new System.Drawing.Size(11, 13);
            this.lblblSalaryMonthValidator.TabIndex = 75;
            this.lblblSalaryMonthValidator.Text = "*";
            // 
            // lblDateValidator
            // 
            this.lblDateValidator.AutoSize = true;
            this.lblDateValidator.ForeColor = System.Drawing.Color.Red;
            this.lblDateValidator.Location = new System.Drawing.Point(746, 19);
            this.lblDateValidator.Name = "lblDateValidator";
            this.lblDateValidator.Size = new System.Drawing.Size(11, 13);
            this.lblDateValidator.TabIndex = 76;
            this.lblDateValidator.Text = "*";
            // 
            // lblAmountValidator
            // 
            this.lblAmountValidator.AutoSize = true;
            this.lblAmountValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAmountValidator.Location = new System.Drawing.Point(746, 50);
            this.lblAmountValidator.Name = "lblAmountValidator";
            this.lblAmountValidator.Size = new System.Drawing.Size(11, 13);
            this.lblAmountValidator.TabIndex = 77;
            this.lblAmountValidator.Text = "*";
            // 
            // lblCashOrBankValidator
            // 
            this.lblCashOrBankValidator.AutoSize = true;
            this.lblCashOrBankValidator.ForeColor = System.Drawing.Color.Red;
            this.lblCashOrBankValidator.Location = new System.Drawing.Point(746, 73);
            this.lblCashOrBankValidator.Name = "lblCashOrBankValidator";
            this.lblCashOrBankValidator.Size = new System.Drawing.Size(11, 13);
            this.lblCashOrBankValidator.TabIndex = 78;
            this.lblCashOrBankValidator.Text = "*";
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.CustomFormat = "MMM yyyy";
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(133, 66);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(199, 20);
            this.dtpSalaryMonth.TabIndex = 5;
            this.dtpSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalaryMonth_KeyDown);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(543, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // txtChequeDate
            // 
            this.txtChequeDate.Location = new System.Drawing.Point(543, 91);
            this.txtChequeDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeDate.Name = "txtChequeDate";
            this.txtChequeDate.Size = new System.Drawing.Size(180, 20);
            this.txtChequeDate.TabIndex = 9;
            this.txtChequeDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeDate_KeyDown);
            this.txtChequeDate.Leave += new System.EventHandler(this.txtChequeDate_Leave);
            // 
            // frmAdvancePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.txtChequeDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.lblCashOrBankValidator);
            this.Controls.Add(this.lblAmountValidator);
            this.Controls.Add(this.lblDateValidator);
            this.Controls.Add(this.lblblSalaryMonthValidator);
            this.Controls.Add(this.lblEmployeeValidator);
            this.Controls.Add(this.lblAdvanceVoucherNoValidator);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCashOrBank);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAdvancePaymentEmployee);
            this.Controls.Add(this.dtpCheckDate);
            this.Controls.Add(this.lblCheckDate);
            this.Controls.Add(this.cmbCashOrBank);
            this.Controls.Add(this.lblCashOrBank);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCheckNo);
            this.Controls.Add(this.lblCheckNo);
            this.Controls.Add(this.lblSalaryMonth);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnAdvancePaymentClose);
            this.Controls.Add(this.btnAdvancePaymentDelete);
            this.Controls.Add(this.txtAdvanceVoucherNo);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblAdvanceVoucherNo);
            this.Controls.Add(this.btnAdvancePaymentSave);
            this.Controls.Add(this.btnAdvancePaymetClear);
            this.Controls.Add(this.txtNarration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAdvancePayment";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdvancePayment_FormClosing);
            this.Load += new System.EventHandler(this.frmAdvancePayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdvancePayment_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAdvancePayment_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdvancePaymentClose;
        private System.Windows.Forms.Button btnAdvancePaymentDelete;
        private System.Windows.Forms.TextBox txtAdvanceVoucherNo;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblAdvanceVoucherNo;
        private System.Windows.Forms.Button btnAdvancePaymentSave;
        private System.Windows.Forms.Button btnAdvancePaymetClear;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label lblCheckNo;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblCheckDate;
        private System.Windows.Forms.ComboBox cmbCashOrBank;
        private System.Windows.Forms.Label lblCashOrBank;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpCheckDate;
        private System.Windows.Forms.Button btnAdvancePaymentEmployee;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCashOrBank;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblAdvanceVoucherNoValidator;
        private System.Windows.Forms.Label lblEmployeeValidator;
        private System.Windows.Forms.Label lblblSalaryMonthValidator;
        private System.Windows.Forms.Label lblDateValidator;
        private System.Windows.Forms.Label lblAmountValidator;
        private System.Windows.Forms.Label lblCashOrBankValidator;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtChequeDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
    }
}