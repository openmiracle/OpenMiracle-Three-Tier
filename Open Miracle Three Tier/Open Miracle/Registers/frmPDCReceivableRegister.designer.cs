namespace Open_Miracle
{
    partial class frmPDCReceivableRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDCReceivableRegister));
            this.DgvPdCreceivable = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdcReceivableMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblfromDate = new System.Windows.Forms.Label();
            this.lblTodate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPdCreceivable)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPdCreceivable
            // 
            this.DgvPdCreceivable.AllowUserToAddRows = false;
            this.DgvPdCreceivable.AllowUserToDeleteRows = false;
            this.DgvPdCreceivable.AllowUserToResizeRows = false;
            this.DgvPdCreceivable.BackgroundColor = System.Drawing.Color.White;
            this.DgvPdCreceivable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPdCreceivable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPdCreceivable.ColumnHeadersHeight = 35;
            this.DgvPdCreceivable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPdCreceivable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.voucherNo,
            this.voucherTypeName,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.voucherTypeId,
            this.financialYearId,
            this.userId,
            this.pdcReceivableMasterId,
            this.invoiceNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPdCreceivable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPdCreceivable.EnableHeadersVisualStyles = false;
            this.DgvPdCreceivable.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvPdCreceivable.Location = new System.Drawing.Point(18, 97);
            this.DgvPdCreceivable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.DgvPdCreceivable.Name = "DgvPdCreceivable";
            this.DgvPdCreceivable.ReadOnly = true;
            this.DgvPdCreceivable.RowHeadersVisible = false;
            this.DgvPdCreceivable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPdCreceivable.Size = new System.Drawing.Size(764, 455);
            this.DgvPdCreceivable.TabIndex = 6;
            this.DgvPdCreceivable.TabStop = false;
            this.DgvPdCreceivable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPdCreceivable_CellDoubleClick);
            this.DgvPdCreceivable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvPdCreceivable_KeyDown);
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "Sl  No";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNo.Width = 109;
            // 
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "InvoiceNo";
            this.voucherNo.HeaderText = "Voucher No";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Width = 108;
            // 
            // voucherTypeName
            // 
            this.voucherTypeName.DataPropertyName = "voucherTypeName";
            this.voucherTypeName.HeaderText = "VoucherType Name";
            this.voucherTypeName.Name = "voucherTypeName";
            this.voucherTypeName.ReadOnly = true;
            this.voucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherTypeName.Width = 109;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = " Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 109;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Amount ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 109;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Account Ledger";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 108;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "narration";
            this.Column6.HeaderText = "Narration";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 109;
            // 
            // voucherTypeId
            // 
            this.voucherTypeId.DataPropertyName = "voucherTypeId";
            this.voucherTypeId.HeaderText = "voucherTypeId";
            this.voucherTypeId.Name = "voucherTypeId";
            this.voucherTypeId.ReadOnly = true;
            this.voucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherTypeId.Visible = false;
            // 
            // financialYearId
            // 
            this.financialYearId.DataPropertyName = "financialYearId";
            this.financialYearId.HeaderText = "financialYearId";
            this.financialYearId.Name = "financialYearId";
            this.financialYearId.ReadOnly = true;
            this.financialYearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.financialYearId.Visible = false;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "userId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userId.Visible = false;
            // 
            // pdcReceivableMasterId
            // 
            this.pdcReceivableMasterId.DataPropertyName = "pdcReceivableMasterId";
            this.pdcReceivableMasterId.HeaderText = "pdcReceivableMasterId";
            this.pdcReceivableMasterId.Name = "pdcReceivableMasterId";
            this.pdcReceivableMasterId.ReadOnly = true;
            this.pdcReceivableMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdcReceivableMasterId.Visible = false;
            // 
            // invoiceNo
            // 
            this.invoiceNo.DataPropertyName = "VoucherNo";
            this.invoiceNo.HeaderText = "invoiceNo";
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.ReadOnly = true;
            this.invoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invoiceNo.Visible = false;
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
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 6;
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
            this.btnRefresh.Location = new System.Drawing.Point(580, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 4;
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
            this.btnReset.Location = new System.Drawing.Point(675, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(126, 40);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(192, 21);
            this.cmbAccountLedger.TabIndex = 2;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1241;
            this.label3.Text = "Account Ledger";
            // 
            // txtvoucherNo
            // 
            this.txtvoucherNo.Location = new System.Drawing.Point(580, 40);
            this.txtvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtvoucherNo.Name = "txtvoucherNo";
            this.txtvoucherNo.Size = new System.Drawing.Size(199, 20);
            this.txtvoucherNo.TabIndex = 3;
            this.txtvoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(474, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1239;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblfromDate
            // 
            this.lblfromDate.AutoSize = true;
            this.lblfromDate.ForeColor = System.Drawing.Color.White;
            this.lblfromDate.Location = new System.Drawing.Point(20, 19);
            this.lblfromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblfromDate.Name = "lblfromDate";
            this.lblfromDate.Size = new System.Drawing.Size(56, 13);
            this.lblfromDate.TabIndex = 1237;
            this.lblfromDate.Text = "From Date";
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.ForeColor = System.Drawing.Color.White;
            this.lblTodate.Location = new System.Drawing.Point(472, 19);
            this.lblTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(46, 13);
            this.lblTodate.TabIndex = 1235;
            this.lblTodate.Text = "To Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(299, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(19, 20);
            this.dtpDate.TabIndex = 1276;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(126, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(173, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(758, 15);
            this.dtpTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(21, 20);
            this.dtpTodate.TabIndex = 1278;
            this.dtpTodate.ValueChanged += new System.EventHandler(this.dtpTodate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
           this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // frmPDCReceivableRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.DgvPdCreceivable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblfromDate);
            this.Controls.Add(this.lblTodate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDCReceivableRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Receivable Register";
            this.Load += new System.EventHandler(this.frmPDCReceivableRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDCReceivableRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPdCreceivable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPdCreceivable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblfromDate;
        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdcReceivableMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
    }
}