namespace Open_Miracle
{
    partial class frmPaymentVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentVoucher));
            this.btnLedgerAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintafterSave = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBankorCash = new System.Windows.Forms.ComboBox();
            this.lblBankorCash = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVoucheNo = new System.Windows.Forms.Label();
            this.dgvPaymentVoucher = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpaymentMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpaymentDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbAccountLedger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvbtnAgainst = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLedgerAdd
            // 
            this.btnLedgerAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnLedgerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLedgerAdd.FlatAppearance.BorderSize = 0;
            this.btnLedgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedgerAdd.ForeColor = System.Drawing.Color.White;
            this.btnLedgerAdd.Location = new System.Drawing.Point(358, 42);
            this.btnLedgerAdd.Name = "btnLedgerAdd";
            this.btnLedgerAdd.Size = new System.Drawing.Size(21, 20);
            this.btnLedgerAdd.TabIndex = 3;
            this.btnLedgerAdd.UseVisualStyleBackColor = true;
            this.btnLedgerAdd.Click += new System.EventHandler(this.btnLedgerAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(487, 539);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 520;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(582, 535);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // cbxPrintafterSave
            // 
            this.cbxPrintafterSave.AutoSize = true;
            this.cbxPrintafterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintafterSave.Location = new System.Drawing.Point(20, 566);
            this.cbxPrintafterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintafterSave.Name = "cbxPrintafterSave";
            this.cbxPrintafterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintafterSave.TabIndex = 11;
            this.cbxPrintafterSave.Text = "Print after save";
            this.cbxPrintafterSave.UseVisualStyleBackColor = true;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(487, 480);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 517;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(582, 480);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(485, 21);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 515;
            this.lblDate.Text = "Date";
            // 
            // cmbBankorCash
            // 
            this.cmbBankorCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankorCash.FormattingEnabled = true;
            this.cmbBankorCash.Location = new System.Drawing.Point(138, 42);
            this.cmbBankorCash.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBankorCash.Name = "cmbBankorCash";
            this.cmbBankorCash.Size = new System.Drawing.Size(200, 21);
            this.cmbBankorCash.TabIndex = 3;
            this.cmbBankorCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBankorCash_KeyDown);
            // 
            // lblBankorCash
            // 
            this.lblBankorCash.AutoSize = true;
            this.lblBankorCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBankorCash.Location = new System.Drawing.Point(18, 46);
            this.lblBankorCash.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankorCash.Name = "lblBankorCash";
            this.lblBankorCash.Size = new System.Drawing.Size(67, 13);
            this.lblBankorCash.TabIndex = 512;
            this.lblBankorCash.Text = "Bank / Cash";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(737, 461);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(515, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 8;
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
            this.btnSave.Location = new System.Drawing.Point(424, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblVoucheNo
            // 
            this.lblVoucheNo.AutoSize = true;
            this.lblVoucheNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucheNo.Location = new System.Drawing.Point(18, 21);
            this.lblVoucheNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucheNo.Name = "lblVoucheNo";
            this.lblVoucheNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucheNo.TabIndex = 514;
            this.lblVoucheNo.Text = "Voucher No.";
            // 
            // dgvPaymentVoucher
            // 
            this.dgvPaymentVoucher.AllowUserToResizeColumns = false;
            this.dgvPaymentVoucher.AllowUserToResizeRows = false;
            this.dgvPaymentVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentVoucher.ColumnHeadersHeight = 25;
            this.dgvPaymentVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtLedgerPostingId,
            this.dgvtxtpaymentMasterId,
            this.dgvtxtpaymentDetailsId,
            this.dgvcmbAccountLedger,
            this.dgvbtnAgainst,
            this.dgvtxtAmount,
            this.dgvcmbCurrency,
            this.dgvtxtChequeNo,
            this.dgvtxtChequeDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentVoucher.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPaymentVoucher.EnableHeadersVisualStyles = false;
            this.dgvPaymentVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPaymentVoucher.Location = new System.Drawing.Point(18, 71);
            this.dgvPaymentVoucher.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvPaymentVoucher.MultiSelect = false;
            this.dgvPaymentVoucher.Name = "dgvPaymentVoucher";
            this.dgvPaymentVoucher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPaymentVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentVoucher.Size = new System.Drawing.Size(764, 385);
            this.dgvPaymentVoucher.TabIndex = 4;
            this.dgvPaymentVoucher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPaymentVoucher_CellBeginEdit);
            this.dgvPaymentVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentVoucher_CellClick);
            this.dgvPaymentVoucher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentVoucher_CellEnter);
            this.dgvPaymentVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentVoucher_CellValueChanged);
            this.dgvPaymentVoucher.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPaymentVoucher_CurrentCellDirtyStateChanged);
            this.dgvPaymentVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPaymentVoucher_DataError);
            this.dgvPaymentVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPaymentVoucher_EditingControlShowing);
            this.dgvPaymentVoucher.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPaymentVoucher_RowsAdded);
            this.dgvPaymentVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPaymentVoucher_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 103;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.DataPropertyName = "ledgerPostingId";
            this.dgvtxtLedgerPostingId.HeaderText = "LedgerPostingId";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerPostingId.Visible = false;
            // 
            // dgvtxtpaymentMasterId
            // 
            this.dgvtxtpaymentMasterId.DataPropertyName = "paymentMasterId";
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvtxtpaymentMasterId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtpaymentMasterId.HeaderText = "paymentMasterId";
            this.dgvtxtpaymentMasterId.Name = "dgvtxtpaymentMasterId";
            this.dgvtxtpaymentMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpaymentMasterId.Visible = false;
            // 
            // dgvtxtpaymentDetailsId
            // 
            this.dgvtxtpaymentDetailsId.DataPropertyName = "paymentDetailsid";
            dataGridViewCellStyle3.NullValue = "0";
            this.dgvtxtpaymentDetailsId.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtpaymentDetailsId.HeaderText = "paymentDetailsId";
            this.dgvtxtpaymentDetailsId.Name = "dgvtxtpaymentDetailsId";
            this.dgvtxtpaymentDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpaymentDetailsId.Visible = false;
            // 
            // dgvcmbAccountLedger
            // 
            this.dgvcmbAccountLedger.DataPropertyName = "ledgerId";
            this.dgvcmbAccountLedger.HeaderText = "Account Ledger";
            this.dgvcmbAccountLedger.Name = "dgvcmbAccountLedger";
            this.dgvcmbAccountLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbAccountLedger.Width = 103;
            // 
            // dgvbtnAgainst
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Against";
            this.dgvbtnAgainst.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvbtnAgainst.HeaderText = "";
            this.dgvbtnAgainst.Name = "dgvbtnAgainst";
            this.dgvbtnAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnAgainst.Text = "";
            this.dgvbtnAgainst.Width = 103;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 8;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 103;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.DataPropertyName = "exchangeRateId";
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbCurrency.Width = 103;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.DataPropertyName = "chequeNo";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvtxtChequeNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeNo.Width = 103;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.DataPropertyName = "chequeDate";
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeDate.Width = 103;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(580, 17);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(181, 20);
            this.txtDate.TabIndex = 2;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(761, 17);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(19, 20);
            this.dtpDate.TabIndex = 524;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(138, 17);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 1;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(339, 21);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 1246;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1247;
            this.label1.Text = "*";
            // 
            // frmPaymentVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.dgvPaymentVoucher);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnLedgerAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxPrintafterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbBankorCash);
            this.Controls.Add(this.lblBankorCash);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVoucheNo);
            this.Controls.Add(this.txtVoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPaymentVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaymentVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmPaymentVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaymentVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLedgerAdd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbxPrintafterSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbBankorCash;
        private System.Windows.Forms.Label lblBankorCash;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVoucheNo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private dgv.DataGridViewEnter dgvPaymentVoucher;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpaymentMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpaymentDetailsId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbAccountLedger;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnAgainst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
    }
}