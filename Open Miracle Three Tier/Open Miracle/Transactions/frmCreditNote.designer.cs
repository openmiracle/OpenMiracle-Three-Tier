namespace Open_Miracle
{
    partial class frmCreditNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditNote));
            this.lblCreditTotal = new System.Windows.Forms.Label();
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.lblDebitTotal = new System.Windows.Forms.Label();
            this.txtDebitTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvCreditNote = new Open_Miracle.dgv.DataGridViewEnter();
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
            this.lblVoucherDate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditNote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreditTotal
            // 
            this.lblCreditTotal.AutoSize = true;
            this.lblCreditTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreditTotal.Location = new System.Drawing.Point(485, 538);
            this.lblCreditTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCreditTotal.Name = "lblCreditTotal";
            this.lblCreditTotal.Size = new System.Drawing.Size(61, 13);
            this.lblCreditTotal.TabIndex = 643;
            this.lblCreditTotal.Text = "Credit Total";
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Enabled = false;
            this.txtCreditTotal.Location = new System.Drawing.Point(580, 534);
            this.txtCreditTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCreditTotal.TabIndex = 242;
            this.txtCreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDebitTotal
            // 
            this.lblDebitTotal.AutoSize = true;
            this.lblDebitTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDebitTotal.Location = new System.Drawing.Point(485, 513);
            this.lblDebitTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDebitTotal.Name = "lblDebitTotal";
            this.lblDebitTotal.Size = new System.Drawing.Size(59, 13);
            this.lblDebitTotal.TabIndex = 641;
            this.lblDebitTotal.Text = "Debit Total";
            // 
            // txtDebitTotal
            // 
            this.txtDebitTotal.Enabled = false;
            this.txtDebitTotal.Location = new System.Drawing.Point(580, 509);
            this.txtDebitTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDebitTotal.Name = "txtDebitTotal";
            this.txtDebitTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDebitTotal.TabIndex = 436;
            this.txtDebitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(20, 560);
            this.cbxPrintAfterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 4;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.Enabled = false;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(20, 491);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 638;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(109, 491);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 3;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(733, 491);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 637;
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
            this.btnClose.TabIndex = 8;
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
            this.btnDelete.TabIndex = 7;
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
            this.btnClear.TabIndex = 6;
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
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // dgvCreditNote
            // 
            this.dgvCreditNote.AllowUserToResizeColumns = false;
            this.dgvCreditNote.AllowUserToResizeRows = false;
            this.dgvCreditNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditNote.BackgroundColor = System.Drawing.Color.White;
            this.dgvCreditNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditNote.ColumnHeadersHeight = 35;
            this.dgvCreditNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCreditNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCreditNote.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCreditNote.EnableHeadersVisualStyles = false;
            this.dgvCreditNote.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCreditNote.Location = new System.Drawing.Point(20, 42);
            this.dgvCreditNote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvCreditNote.MultiSelect = false;
            this.dgvCreditNote.Name = "dgvCreditNote";
            this.dgvCreditNote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCreditNote.Size = new System.Drawing.Size(762, 444);
            this.dgvCreditNote.TabIndex = 2;
            this.dgvCreditNote.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCreditNote_CellBeginEdit);
            this.dgvCreditNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditNote_CellClick);
            this.dgvCreditNote.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditNote_CellEnter);
            this.dgvCreditNote.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditNote_CellValueChanged);
            this.dgvCreditNote.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCreditNote_CurrentCellDirtyStateChanged);
            this.dgvCreditNote.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCreditNote_DataError);
            this.dgvCreditNote.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCreditNote_EditingControlShowing);
            this.dgvCreditNote.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCreditNote_RowsAdded);
            this.dgvCreditNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCreditNote_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.FillWeight = 15F;
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbAccountLedger
            // 
            this.dgvcmbAccountLedger.DataPropertyName = "ledgerId";
            this.dgvcmbAccountLedger.FillWeight = 35F;
            this.dgvcmbAccountLedger.HeaderText = "Account Ledger";
            this.dgvcmbAccountLedger.Name = "dgvcmbAccountLedger";
            this.dgvcmbAccountLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvcmbDrOrCr
            // 
            this.dgvcmbDrOrCr.FillWeight = 20F;
            this.dgvcmbDrOrCr.HeaderText = "Dr/Cr";
            this.dgvcmbDrOrCr.Name = "dgvcmbDrOrCr";
            this.dgvcmbDrOrCr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvbtnAgainst
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Against";
            this.dgvbtnAgainst.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbtnAgainst.FillWeight = 31.12702F;
            this.dgvbtnAgainst.HeaderText = "Against";
            this.dgvbtnAgainst.Name = "dgvbtnAgainst";
            this.dgvbtnAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnAgainst.Text = "";
            // 
            // dgvtxtAmount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtAmount.FillWeight = 31.12702F;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 13;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.FillWeight = 31.12702F;
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.DataPropertyName = "chequeNo";
            this.dgvtxtChequeNo.FillWeight = 31.12702F;
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.DataPropertyName = "chequeDate";
            this.dgvtxtChequeDate.FillWeight = 31.12702F;
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.txtDate.Location = new System.Drawing.Point(557, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(207, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // lblVoucherDate
            // 
            this.lblVoucherDate.AutoSize = true;
            this.lblVoucherDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDate.Location = new System.Drawing.Point(464, 19);
            this.lblVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherDate.Name = "lblVoucherDate";
            this.lblVoucherDate.Size = new System.Drawing.Size(73, 13);
            this.lblVoucherDate.TabIndex = 647;
            this.lblVoucherDate.Text = "Voucher Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(20, 19);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 646;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(118, 15);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(207, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Location = new System.Drawing.Point(761, 15);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(21, 20);
            this.dtpVoucherDate.TabIndex = 648;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // frmCreditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblVoucherDate);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblCreditTotal);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.lblDebitTotal);
            this.Controls.Add(this.txtDebitTotal);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCreditNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCreditNote";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreditNote_FormClosing);
            this.Load += new System.EventHandler(this.frmCreditNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreditNote_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreditTotal;
        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.Label lblDebitTotal;
        private System.Windows.Forms.TextBox txtDebitTotal;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private dgv.DataGridViewEnter dgvCreditNote;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblVoucherDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
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