namespace Open_Miracle
{
    partial class frmContraVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContraVoucher));
            this.btnBankAccountAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintafterSave = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBankAccount = new System.Windows.Forms.ComboBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.rbtnWithdrawal = new System.Windows.Forms.RadioButton();
            this.dtpContraVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.txtContraVoucherDate = new System.Windows.Forms.TextBox();
            this.dgvContraVoucher = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbBankorCashAccount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBankAccountAdd
            // 
            this.btnBankAccountAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnBankAccountAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBankAccountAdd.FlatAppearance.BorderSize = 0;
            this.btnBankAccountAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAccountAdd.ForeColor = System.Drawing.Color.White;
            this.btnBankAccountAdd.Location = new System.Drawing.Point(339, 61);
            this.btnBankAccountAdd.Name = "btnBankAccountAdd";
            this.btnBankAccountAdd.Size = new System.Drawing.Size(21, 20);
            this.btnBankAccountAdd.TabIndex = 5;
            this.btnBankAccountAdd.UseVisualStyleBackColor = true;
            this.btnBankAccountAdd.Click += new System.EventHandler(this.btnBankAccountAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(470, 535);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 541;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(580, 531);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // cbxPrintafterSave
            // 
            this.cbxPrintafterSave.AutoSize = true;
            this.cbxPrintafterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintafterSave.Location = new System.Drawing.Point(18, 568);
            this.cbxPrintafterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintafterSave.Name = "cbxPrintafterSave";
            this.cbxPrintafterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintafterSave.TabIndex = 324;
            this.cbxPrintafterSave.Text = "Print after save";
            this.cbxPrintafterSave.UseVisualStyleBackColor = true;
            this.cbxPrintafterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintafterSave_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(20, 501);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 538;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(132, 501);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 7;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(470, 41);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 535;
            this.lblDate.Text = "Date";
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(119, 62);
            this.cmbBankAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.Size = new System.Drawing.Size(200, 21);
            this.cmbBankAccount.TabIndex = 4;
            this.cmbBankAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBankAccount_KeyDown);
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBankAccount.Location = new System.Drawing.Point(18, 66);
            this.lblBankAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(81, 13);
            this.lblBankAccount.TabIndex = 533;
            this.lblBankAccount.Text = "Bank/Cash a/c";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(733, 500);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 532;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(694, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 12;
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
            this.btnDelete.Location = new System.Drawing.Point(603, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 11;
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
            this.btnClear.Location = new System.Drawing.Point(512, 556);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 10;
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
            this.btnSave.Location = new System.Drawing.Point(421, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(18, 41);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 527;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(119, 37);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.ForeColor = System.Drawing.Color.White;
            this.rbtnDeposit.Location = new System.Drawing.Point(119, 15);
            this.rbtnDeposit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbtnDeposit.TabIndex = 0;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "Deposit";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            this.rbtnDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnDeposit_KeyDown);
            // 
            // rbtnWithdrawal
            // 
            this.rbtnWithdrawal.AutoSize = true;
            this.rbtnWithdrawal.ForeColor = System.Drawing.Color.White;
            this.rbtnWithdrawal.Location = new System.Drawing.Point(190, 15);
            this.rbtnWithdrawal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnWithdrawal.Name = "rbtnWithdrawal";
            this.rbtnWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.rbtnWithdrawal.TabIndex = 1;
            this.rbtnWithdrawal.TabStop = true;
            this.rbtnWithdrawal.Text = "Withdrawal";
            this.rbtnWithdrawal.UseVisualStyleBackColor = true;
            this.rbtnWithdrawal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnWithdrawal_KeyDown);
            // 
            // dtpContraVoucherDate
            // 
            this.dtpContraVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpContraVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContraVoucherDate.Location = new System.Drawing.Point(758, 37);
            this.dtpContraVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpContraVoucherDate.Name = "dtpContraVoucherDate";
            this.dtpContraVoucherDate.Size = new System.Drawing.Size(22, 20);
            this.dtpContraVoucherDate.TabIndex = 456;
            this.dtpContraVoucherDate.CloseUp += new System.EventHandler(this.dtpContraVoucherDate_CloseUp);
            this.dtpContraVoucherDate.ValueChanged += new System.EventHandler(this.dtpContraVoucherDate_ValueChanged);
            // 
            // txtContraVoucherDate
            // 
            this.txtContraVoucherDate.Location = new System.Drawing.Point(580, 37);
            this.txtContraVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtContraVoucherDate.Name = "txtContraVoucherDate";
            this.txtContraVoucherDate.Size = new System.Drawing.Size(178, 20);
            this.txtContraVoucherDate.TabIndex = 3;
            this.txtContraVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraVoucherDate_KeyDown);
            this.txtContraVoucherDate.Leave += new System.EventHandler(this.txtContraVoucherDate_Leave);
            // 
            // dgvContraVoucher
            // 
            this.dgvContraVoucher.AllowUserToResizeRows = false;
            this.dgvContraVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContraVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvContraVoucher.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvContraVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContraVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContraVoucher.ColumnHeadersHeight = 25;
            this.dgvContraVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContraVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtCheck,
            this.dgvtxtDetailsId,
            this.masterId,
            this.dgvtxtLedgerPostingId,
            this.dgvcmbBankorCashAccount,
            this.dgvtxtAmount,
            this.dgvcmbCurrency,
            this.dgvtxtChequeNo,
            this.dgvtxtChequeDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContraVoucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContraVoucher.EnableHeadersVisualStyles = false;
            this.dgvContraVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvContraVoucher.Location = new System.Drawing.Point(18, 87);
            this.dgvContraVoucher.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvContraVoucher.Name = "dgvContraVoucher";
            this.dgvContraVoucher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContraVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContraVoucher.RowHeadersVisible = false;
            this.dgvContraVoucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContraVoucher.Size = new System.Drawing.Size(764, 409);
            this.dgvContraVoucher.TabIndex = 6;
            this.dgvContraVoucher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContraVoucher_CellEnter);
            this.dgvContraVoucher.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContraVoucher_CellLeave);
            this.dgvContraVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContraVoucher_CellValueChanged);
            this.dgvContraVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvContraVoucher_DataError);
            this.dgvContraVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvContraVoucher_EditingControlShowing);
            this.dgvContraVoucher.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContraVoucher_RowsAdded);
            this.dgvContraVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvContraVoucher_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.HeaderText = "Check";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // dgvtxtDetailsId
            // 
            this.dgvtxtDetailsId.DataPropertyName = "contraDetailsId";
            this.dgvtxtDetailsId.HeaderText = "detailsId";
            this.dgvtxtDetailsId.Name = "dgvtxtDetailsId";
            this.dgvtxtDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDetailsId.Visible = false;
            // 
            // masterId
            // 
            this.masterId.DataPropertyName = "contraMasterId";
            this.masterId.HeaderText = "Column1";
            this.masterId.Name = "masterId";
            this.masterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.masterId.Visible = false;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.DataPropertyName = "ledgerPostingId";
            this.dgvtxtLedgerPostingId.HeaderText = "ledgerPostingId";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerPostingId.Visible = false;
            // 
            // dgvcmbBankorCashAccount
            // 
            this.dgvcmbBankorCashAccount.HeaderText = "Bank/Cash a/c";
            this.dgvcmbBankorCashAccount.Name = "dgvcmbBankorCashAccount";
            this.dgvcmbBankorCashAccount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtAmount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 8;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.DataPropertyName = "exchangeRateId";
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(326, 69);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 543;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // frmContraVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.dgvContraVoucher);
            this.Controls.Add(this.txtContraVoucherDate);
            this.Controls.Add(this.dtpContraVoucherDate);
            this.Controls.Add(this.rbtnWithdrawal);
            this.Controls.Add(this.rbtnDeposit);
            this.Controls.Add(this.btnBankAccountAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxPrintafterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbBankAccount);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.txtVoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmContraVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contra Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContraVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmContraVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContraVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBankAccountAdd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbxPrintafterSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbBankAccount;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.RadioButton rbtnWithdrawal;
        private System.Windows.Forms.DateTimePicker dtpContraVoucherDate;
        private System.Windows.Forms.TextBox txtContraVoucherDate;
        private dgv.DataGridViewEnter dgvContraVoucher;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBankorCashAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
        
    }
}