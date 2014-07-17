namespace Open_Miracle
{
    partial class frmJournalVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalVoucher));
            this.label12 = new System.Windows.Forms.Label();
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDebitTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dgvJournalVoucher = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbAccountLedger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbDrOrCr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvbtnAgainst = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(472, 539);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 478;
            this.label12.Text = "Credit Total";
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(580, 535);
            this.txtCreditTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCreditTotal.TabIndex = 477;
            this.txtCreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(472, 514);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 476;
            this.label11.Text = "Debit Total";
            // 
            // txtDebitTotal
            // 
            this.txtDebitTotal.Location = new System.Drawing.Point(580, 510);
            this.txtDebitTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDebitTotal.Name = "txtDebitTotal";
            this.txtDebitTotal.ReadOnly = true;
            this.txtDebitTotal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebitTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDebitTotal.TabIndex = 475;
            this.txtDebitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(20, 568);
            this.cbxPrintAfterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 8;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(16, 514);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 473;
            this.label10.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(126, 514);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 3;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(453, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 463;
            this.label5.Text = "Voucher Date";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(733, 493);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 456;
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
            this.btnClose.TabIndex = 7;
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
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyUp);
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
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyUp);
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
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 5435;
            this.label7.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(167, 15);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // dgvJournalVoucher
            // 
            this.dgvJournalVoucher.AllowUserToResizeColumns = false;
            this.dgvJournalVoucher.AllowUserToResizeRows = false;
            this.dgvJournalVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvJournalVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournalVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJournalVoucher.ColumnHeadersHeight = 35;
            this.dgvJournalVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJournalVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvcmbAccountLedger,
            this.dgvcmbDrOrCr,
            this.dgvbtnAgainst,
            this.dgvtxtAmount,
            this.dgvcmbCurrency,
            this.dgvtxtChequeNo,
            this.dgvtxtChequeDate,
            this.dgvtxtDetailsId,
            this.dgvtxtLedgerPostingId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJournalVoucher.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJournalVoucher.EnableHeadersVisualStyles = false;
            this.dgvJournalVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvJournalVoucher.Location = new System.Drawing.Point(18, 38);
            this.dgvJournalVoucher.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvJournalVoucher.MultiSelect = false;
            this.dgvJournalVoucher.Name = "dgvJournalVoucher";
            this.dgvJournalVoucher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournalVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJournalVoucher.Size = new System.Drawing.Size(764, 450);
            this.dgvJournalVoucher.TabIndex = 2;
            this.dgvJournalVoucher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvJournalVoucher_CellBeginEdit);
            this.dgvJournalVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalVoucher_CellClick);
            this.dgvJournalVoucher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalVoucher_CellEnter);
            this.dgvJournalVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalVoucher_CellValueChanged);
            this.dgvJournalVoucher.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvJournalVoucher_CurrentCellDirtyStateChanged);
            this.dgvJournalVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvJournalVoucher_DataError);
            this.dgvJournalVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvJournalVoucher_EditingControlShowing);
            this.dgvJournalVoucher.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvJournalVoucher_RowsAdded);
            this.dgvJournalVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvJournalVoucher_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 90;
            // 
            // dgvcmbAccountLedger
            // 
            this.dgvcmbAccountLedger.DataPropertyName = "ledgerId";
            this.dgvcmbAccountLedger.HeaderText = "Account Ledger";
            this.dgvcmbAccountLedger.Name = "dgvcmbAccountLedger";
            this.dgvcmbAccountLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbAccountLedger.Width = 90;
            // 
            // dgvcmbDrOrCr
            // 
            this.dgvcmbDrOrCr.HeaderText = "Dr/Cr";
            this.dgvcmbDrOrCr.Name = "dgvcmbDrOrCr";
            this.dgvcmbDrOrCr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbDrOrCr.Width = 90;
            // 
            // dgvbtnAgainst
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Against";
            this.dgvbtnAgainst.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbtnAgainst.HeaderText = "Against";
            this.dgvbtnAgainst.Name = "dgvbtnAgainst";
            this.dgvbtnAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnAgainst.Text = "";
            this.dgvbtnAgainst.Width = 91;
            // 
            // dgvtxtAmount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 13;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 90;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbCurrency.Width = 90;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.DataPropertyName = "chequeNo";
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeNo.Width = 90;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.DataPropertyName = "chequeDate";
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeDate.Width = 90;
            // 
            // dgvtxtDetailsId
            // 
            this.dgvtxtDetailsId.DataPropertyName = "journalDetailsId";
            this.dgvtxtDetailsId.HeaderText = "DetailsId";
            this.dgvtxtDetailsId.Name = "dgvtxtDetailsId";
            this.dgvtxtDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDetailsId.Visible = false;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.HeaderText = "LedgerPostingId";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerPostingId.Visible = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(561, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Location = new System.Drawing.Point(759, 15);
            this.dtpVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(21, 20);
            this.dtpVoucherDate.TabIndex = 15;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // frmJournalVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDebitTotal);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dgvJournalVoucher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmJournalVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Voucher                               ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJournalVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmJournalVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJournalVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDebitTotal;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private dgv.DataGridViewEnter dgvJournalVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbAccountLedger;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbDrOrCr;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnAgainst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
    }
}