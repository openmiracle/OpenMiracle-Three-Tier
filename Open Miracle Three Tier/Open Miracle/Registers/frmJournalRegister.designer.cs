namespace Open_Miracle
{
    partial class frmJournalRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalRegister));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dgvJournalRegister = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtJournalMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSuffixPrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFinancialyearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtraDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalRegister)).BeginInit();
            this.SuspendLayout();
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
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(566, 42);
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
            this.btnReset.Location = new System.Drawing.Point(657, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1281;
            this.label5.Text = "Voucher No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(455, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1290;
            this.label4.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1292;
            this.label2.Text = "From Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(180, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(299, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1295;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(564, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(761, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1297;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dgvJournalRegister
            // 
            this.dgvJournalRegister.AllowUserToAddRows = false;
            this.dgvJournalRegister.AllowUserToDeleteRows = false;
            this.dgvJournalRegister.AllowUserToResizeColumns = false;
            this.dgvJournalRegister.AllowUserToResizeRows = false;
            this.dgvJournalRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournalRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvJournalRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournalRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJournalRegister.ColumnHeadersHeight = 35;
            this.dgvJournalRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJournalRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.dgvtxtVoucherNo,
            this.Column1,
            this.dgvtxtDate,
            this.dgvtxtAmount,
            this.dgvtxtNarration,
            this.dgvtxtJournalMasterId,
            this.dgvtxtSuffixPrefixId,
            this.dgvtxtUserId,
            this.dgvtxtVoucherTypeId,
            this.dgvtxtExchangeRateId,
            this.dgvtxtFinancialyearId,
            this.dgvtxtExtraDate,
            this.dgvtxtExtra1,
            this.dgvtxtExtra2,
            this.voucher});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJournalRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJournalRegister.EnableHeadersVisualStyles = false;
            this.dgvJournalRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvJournalRegister.Location = new System.Drawing.Point(18, 73);
            this.dgvJournalRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvJournalRegister.Name = "dgvJournalRegister";
            this.dgvJournalRegister.ReadOnly = true;
            this.dgvJournalRegister.RowHeadersVisible = false;
            this.dgvJournalRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJournalRegister.Size = new System.Drawing.Size(764, 480);
            this.dgvJournalRegister.TabIndex = 7;
            this.dgvJournalRegister.TabStop = false;
            this.dgvJournalRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournalRegister_CellDoubleClick);
            this.dgvJournalRegister.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvJournalRegister_CurrentCellDirtyStateChanged);
            this.dgvJournalRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvJournalRegister_KeyDown);
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "Sl No";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "Voucher Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
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
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtJournalMasterId
            // 
            this.dgvtxtJournalMasterId.DataPropertyName = "journalMasterId";
            this.dgvtxtJournalMasterId.HeaderText = "MasterId";
            this.dgvtxtJournalMasterId.Name = "dgvtxtJournalMasterId";
            this.dgvtxtJournalMasterId.ReadOnly = true;
            this.dgvtxtJournalMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtJournalMasterId.Visible = false;
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
            // voucher
            // 
            this.voucher.DataPropertyName = "voucherNo";
            this.voucher.HeaderText = "Column1";
            this.voucher.Name = "voucher";
            this.voucher.ReadOnly = true;
            this.voucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucher.Visible = false;
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(120, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // frmJournalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvJournalRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmJournalRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Register";
            this.Load += new System.EventHandler(this.frmJournalRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJournalRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridView dgvJournalRegister;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtJournalMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSuffixPrefixId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFinancialyearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtraDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher;
    }
}