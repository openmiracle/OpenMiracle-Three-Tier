namespace Open_Miracle
{
    partial class frmDebitNoteRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebitNoteRegister));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dgvDebitNoteRegister = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebitNoteMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSuffixPrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFinancialyearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtraDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitNoteRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1207;
            this.label2.Text = "From Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(478, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1205;
            this.label4.Text = "To Date";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(128, 41);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(198, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1213;
            this.label5.Text = "Voucher No";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(582, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(674, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(307, 16);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1280;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(128, 16);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(761, 20);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1282;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(582, 20);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dgvDebitNoteRegister
            // 
            this.dgvDebitNoteRegister.AllowUserToAddRows = false;
            this.dgvDebitNoteRegister.AllowUserToDeleteRows = false;
            this.dgvDebitNoteRegister.AllowUserToResizeColumns = false;
            this.dgvDebitNoteRegister.AllowUserToResizeRows = false;
            this.dgvDebitNoteRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebitNoteRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebitNoteRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebitNoteRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDebitNoteRegister.ColumnHeadersHeight = 35;
            this.dgvDebitNoteRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDebitNoteRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.dgvtxtVoucherNo,
            this.Column2,
            this.dgvtxtDate,
            this.dgvtxtAmount,
            this.dgvtxtNarration,
            this.dgvtxtDebitNoteMasterId,
            this.dgvtxtSuffixPrefixId,
            this.dgvtxtUserId,
            this.dgvtxtVoucherTypeId,
            this.dgvtxtExchangeRateId,
            this.dgvtxtFinancialyearId,
            this.dgvtxtExtraDate,
            this.dgvtxtExtra1,
            this.dgvtxtExtra2,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebitNoteRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDebitNoteRegister.EnableHeadersVisualStyles = false;
            this.dgvDebitNoteRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDebitNoteRegister.Location = new System.Drawing.Point(18, 97);
            this.dgvDebitNoteRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvDebitNoteRegister.Name = "dgvDebitNoteRegister";
            this.dgvDebitNoteRegister.RowHeadersVisible = false;
            this.dgvDebitNoteRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebitNoteRegister.Size = new System.Drawing.Size(764, 455);
            this.dgvDebitNoteRegister.TabIndex = 1290;
            this.dgvDebitNoteRegister.TabStop = false;
            this.dgvDebitNoteRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitNoteRegister_CellDoubleClick);
            this.dgvDebitNoteRegister.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDebitNoteRegister_CurrentCellDirtyStateChanged);
            this.dgvDebitNoteRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDebitNoteRegister_KeyDown);
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherTypeName";
            this.Column2.HeaderText = "VoucherTypeName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDebitNoteMasterId
            // 
            this.dgvtxtDebitNoteMasterId.DataPropertyName = "debitNoteMasterId";
            this.dgvtxtDebitNoteMasterId.HeaderText = "MasterId";
            this.dgvtxtDebitNoteMasterId.Name = "dgvtxtDebitNoteMasterId";
            this.dgvtxtDebitNoteMasterId.ReadOnly = true;
            this.dgvtxtDebitNoteMasterId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtDebitNoteMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDebitNoteMasterId.Visible = false;
            // 
            // dgvtxtSuffixPrefixId
            // 
            this.dgvtxtSuffixPrefixId.DataPropertyName = "suffixPrefixId";
            this.dgvtxtSuffixPrefixId.HeaderText = "SuffixPrefixId";
            this.dgvtxtSuffixPrefixId.Name = "dgvtxtSuffixPrefixId";
            this.dgvtxtSuffixPrefixId.ReadOnly = true;
            this.dgvtxtSuffixPrefixId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSuffixPrefixId.Visible = false;
            // 
            // dgvtxtUserId
            // 
            this.dgvtxtUserId.DataPropertyName = "userId";
            this.dgvtxtUserId.HeaderText = "UserId";
            this.dgvtxtUserId.Name = "dgvtxtUserId";
            this.dgvtxtUserId.ReadOnly = true;
            this.dgvtxtUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUserId.Visible = false;
            // 
            // dgvtxtVoucherTypeId
            // 
            this.dgvtxtVoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvtxtVoucherTypeId.HeaderText = "VoucherTypeId";
            this.dgvtxtVoucherTypeId.Name = "dgvtxtVoucherTypeId";
            this.dgvtxtVoucherTypeId.ReadOnly = true;
            this.dgvtxtVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherTypeId.Visible = false;
            // 
            // dgvtxtExchangeRateId
            // 
            this.dgvtxtExchangeRateId.DataPropertyName = "exchangeRateId";
            this.dgvtxtExchangeRateId.HeaderText = "ExchangeRateId";
            this.dgvtxtExchangeRateId.Name = "dgvtxtExchangeRateId";
            this.dgvtxtExchangeRateId.ReadOnly = true;
            this.dgvtxtExchangeRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExchangeRateId.Visible = false;
            // 
            // dgvtxtFinancialyearId
            // 
            this.dgvtxtFinancialyearId.DataPropertyName = "financialYearId";
            this.dgvtxtFinancialyearId.HeaderText = "FinancialYearId";
            this.dgvtxtFinancialyearId.Name = "dgvtxtFinancialyearId";
            this.dgvtxtFinancialyearId.ReadOnly = true;
            this.dgvtxtFinancialyearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtFinancialyearId.Visible = false;
            // 
            // dgvtxtExtraDate
            // 
            this.dgvtxtExtraDate.DataPropertyName = "extraDate";
            this.dgvtxtExtraDate.HeaderText = "ExtraDate";
            this.dgvtxtExtraDate.Name = "dgvtxtExtraDate";
            this.dgvtxtExtraDate.ReadOnly = true;
            this.dgvtxtExtraDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtraDate.Visible = false;
            // 
            // dgvtxtExtra1
            // 
            this.dgvtxtExtra1.DataPropertyName = "extra1";
            this.dgvtxtExtra1.HeaderText = "Extra1";
            this.dgvtxtExtra1.Name = "dgvtxtExtra1";
            this.dgvtxtExtra1.ReadOnly = true;
            this.dgvtxtExtra1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtra1.Visible = false;
            // 
            // dgvtxtExtra2
            // 
            this.dgvtxtExtra2.DataPropertyName = "extra2";
            this.dgvtxtExtra2.HeaderText = "Extra2";
            this.dgvtxtExtra2.Name = "dgvtxtExtra2";
            this.dgvtxtExtra2.ReadOnly = true;
            this.dgvtxtExtra2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtra2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherNo";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // frmDebitNoteRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvDebitNoteRegister);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDebitNoteRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debit Note Register";
            this.Load += new System.EventHandler(this.frmDebitNoteRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDebitNoteRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitNoteRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridView dgvDebitNoteRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebitNoteMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSuffixPrefixId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFinancialyearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtraDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}