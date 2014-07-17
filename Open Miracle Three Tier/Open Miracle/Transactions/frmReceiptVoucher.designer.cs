namespace Open_Miracle
{
    partial class frmReceiptVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptVoucher));
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintafterSave = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbCashOrBank = new System.Windows.Forms.ComboBox();
            this.lblBankOrCash = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.btnLedgerAdd = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvReceiptVoucher = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtreceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtreceiptDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtledgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbAccountLedger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvbtnAgainst = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(470, 532);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 496;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(580, 528);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 4543;
            // 
            // cbxPrintafterSave
            // 
            this.cbxPrintafterSave.AutoSize = true;
            this.cbxPrintafterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintafterSave.Location = new System.Drawing.Point(20, 568);
            this.cbxPrintafterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintafterSave.Name = "cbxPrintafterSave";
            this.cbxPrintafterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintafterSave.TabIndex = 6;
            this.cbxPrintafterSave.Text = "Print after save";
            this.cbxPrintafterSave.UseVisualStyleBackColor = true;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(20, 494);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 493;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(130, 494);
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
            this.lblDate.Location = new System.Drawing.Point(470, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 490;
            this.lblDate.Text = "Date";
            // 
            // cmbCashOrBank
            // 
            this.cmbCashOrBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBank.FormattingEnabled = true;
            this.cmbCashOrBank.Location = new System.Drawing.Point(130, 40);
            this.cmbCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrBank.Name = "cmbCashOrBank";
            this.cmbCashOrBank.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrBank.TabIndex = 2;
            this.cmbCashOrBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBank_KeyDown);
            // 
            // lblBankOrCash
            // 
            this.lblBankOrCash.AutoSize = true;
            this.lblBankOrCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBankOrCash.Location = new System.Drawing.Point(20, 44);
            this.lblBankOrCash.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankOrCash.Name = "lblBankOrCash";
            this.lblBankOrCash.Size = new System.Drawing.Size(67, 13);
            this.lblBankOrCash.TabIndex = 488;
            this.lblBankOrCash.Text = "Bank / Cash";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lnklblRemove.Location = new System.Drawing.Point(732, 495);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 435;
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
            this.btnClose.Location = new System.Drawing.Point(697, 556);
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
            this.btnDelete.Location = new System.Drawing.Point(606, 556);
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
            this.btnClear.Location = new System.Drawing.Point(515, 556);
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
            this.btnSave.Location = new System.Drawing.Point(424, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(20, 19);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 482;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(130, 15);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.ReadOnly = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // btnLedgerAdd
            // 
            this.btnLedgerAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnLedgerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLedgerAdd.FlatAppearance.BorderSize = 0;
            this.btnLedgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedgerAdd.ForeColor = System.Drawing.Color.White;
            this.btnLedgerAdd.Location = new System.Drawing.Point(338, 40);
            this.btnLedgerAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnLedgerAdd.Name = "btnLedgerAdd";
            this.btnLedgerAdd.Size = new System.Drawing.Size(21, 20);
            this.btnLedgerAdd.TabIndex = 3;
            this.btnLedgerAdd.UseVisualStyleBackColor = true;
            this.btnLedgerAdd.Click += new System.EventHandler(this.btnLedgerAdd_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(579, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(181, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(757, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(23, 20);
            this.dtpDate.TabIndex = 504;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvReceiptVoucher
            // 
            this.dgvReceiptVoucher.AllowUserToResizeRows = false;
            this.dgvReceiptVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptVoucher.ColumnHeadersHeight = 25;
            this.dgvReceiptVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtreceiptMasterId,
            this.dgvtxtreceiptDetailsId,
            this.dgvtxtledgerPostingId,
            this.dgvcmbAccountLedger,
            this.dgvbtnAgainst,
            this.dgvtxtAmount,
            this.dgvcmbCurrency,
            this.dgvtxtChequeNo,
            this.dgvtxtChequeDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptVoucher.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceiptVoucher.EnableHeadersVisualStyles = false;
            this.dgvReceiptVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReceiptVoucher.Location = new System.Drawing.Point(18, 67);
            this.dgvReceiptVoucher.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvReceiptVoucher.Name = "dgvReceiptVoucher";
            this.dgvReceiptVoucher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceiptVoucher.Size = new System.Drawing.Size(764, 422);
            this.dgvReceiptVoucher.TabIndex = 4;
            this.dgvReceiptVoucher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvReceiptVoucher_CellBeginEdit);
            this.dgvReceiptVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptVoucher_CellClick);
            this.dgvReceiptVoucher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptVoucher_CellEnter);
            this.dgvReceiptVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptVoucher_CellValueChanged);
            this.dgvReceiptVoucher.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvReceiptVoucher_CurrentCellDirtyStateChanged);
            this.dgvReceiptVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvReceiptVoucher_DataError);
            this.dgvReceiptVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvReceiptVoucher_EditingControlShowing);
            this.dgvReceiptVoucher.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvReceiptVoucher_RowsAdded);
            this.dgvReceiptVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvReceiptVoucher_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.FillWeight = 50F;
            this.dgvtxtSlNo.HeaderText = "Sl No.";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtreceiptMasterId
            // 
            this.dgvtxtreceiptMasterId.DataPropertyName = "receiptMasterId";
            this.dgvtxtreceiptMasterId.HeaderText = "receiptMasterId";
            this.dgvtxtreceiptMasterId.Name = "dgvtxtreceiptMasterId";
            this.dgvtxtreceiptMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtreceiptMasterId.Visible = false;
            // 
            // dgvtxtreceiptDetailsId
            // 
            this.dgvtxtreceiptDetailsId.DataPropertyName = "receiptDetailsId";
            this.dgvtxtreceiptDetailsId.HeaderText = "receiptDetailsId";
            this.dgvtxtreceiptDetailsId.Name = "dgvtxtreceiptDetailsId";
            this.dgvtxtreceiptDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtreceiptDetailsId.Visible = false;
            // 
            // dgvtxtledgerPostingId
            // 
            this.dgvtxtledgerPostingId.DataPropertyName = "ledgerPostingId";
            this.dgvtxtledgerPostingId.HeaderText = "ledgerPostingId";
            this.dgvtxtledgerPostingId.Name = "dgvtxtledgerPostingId";
            this.dgvtxtledgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtledgerPostingId.Visible = false;
            // 
            // dgvcmbAccountLedger
            // 
            this.dgvcmbAccountLedger.DataPropertyName = "ledgerId";
            this.dgvcmbAccountLedger.HeaderText = "Account Ledger";
            this.dgvcmbAccountLedger.Name = "dgvcmbAccountLedger";
            this.dgvcmbAccountLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvbtnAgainst
            // 
            this.dgvbtnAgainst.DataPropertyName = "Against";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Against";
            this.dgvbtnAgainst.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbtnAgainst.HeaderText = "";
            this.dgvbtnAgainst.Name = "dgvbtnAgainst";
            this.dgvbtnAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnAgainst.Text = "Against";
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.DataPropertyName = "chequeNo";
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.DataPropertyName = "chequeDate";
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmReceiptVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnLedgerAdd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxPrintafterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbCashOrBank);
            this.Controls.Add(this.lblBankOrCash);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dgvReceiptVoucher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmReceiptVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceiptVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmReceiptVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReceiptVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbxPrintafterSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbCashOrBank;
        private System.Windows.Forms.Label lblBankOrCash;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private dgv.DataGridViewEnter dgvReceiptVoucher;
        private System.Windows.Forms.Button btnLedgerAdd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtreceiptMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtreceiptDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtledgerPostingId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbAccountLedger;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnAgainst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
        //private System.Windows.Forms.DataGridView dgvReceiptVoucher;
    }
}