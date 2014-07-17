namespace Open_Miracle
{
    partial class frmPDCPayableRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDCPayableRegister));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lblfromDate = new System.Windows.Forms.Label();
            this.lbltoDate = new System.Windows.Forms.Label();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.txtvoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvpdcPayableRegister = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpdcPayableMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sufixPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpfromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.txtTodate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpdcPayableRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(697, 560);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 27);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            // lblfromDate
            // 
            this.lblfromDate.AutoSize = true;
            this.lblfromDate.ForeColor = System.Drawing.Color.White;
            this.lblfromDate.Location = new System.Drawing.Point(13, 19);
            this.lblfromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblfromDate.Name = "lblfromDate";
            this.lblfromDate.Size = new System.Drawing.Size(56, 13);
            this.lblfromDate.TabIndex = 1264;
            this.lblfromDate.Text = "From Date";
            // 
            // lbltoDate
            // 
            this.lbltoDate.AutoSize = true;
            this.lbltoDate.ForeColor = System.Drawing.Color.White;
            this.lbltoDate.Location = new System.Drawing.Point(477, 19);
            this.lbltoDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbltoDate.Name = "lbltoDate";
            this.lbltoDate.Size = new System.Drawing.Size(46, 13);
            this.lbltoDate.TabIndex = 1262;
            this.lbltoDate.Text = "To Date";
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(120, 40);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 2;
           this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.Color.White;
            this.lblAccountLedger.Location = new System.Drawing.Point(14, 40);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountLedger.TabIndex = 1266;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // txtvoucherNo
            // 
            this.txtvoucherNo.Location = new System.Drawing.Point(579, 40);
            this.txtvoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtvoucherNo.Name = "txtvoucherNo";
            this.txtvoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtvoucherNo.TabIndex = 3;
            this.txtvoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(476, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1268;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Location = new System.Drawing.Point(579, 63);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(85, 27);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Search";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(670, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvpdcPayableRegister
            // 
            this.dgvpdcPayableRegister.AllowUserToAddRows = false;
            this.dgvpdcPayableRegister.AllowUserToDeleteRows = false;
            this.dgvpdcPayableRegister.AllowUserToResizeColumns = false;
            this.dgvpdcPayableRegister.AllowUserToResizeRows = false;
            this.dgvpdcPayableRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpdcPayableRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvpdcPayableRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpdcPayableRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpdcPayableRegister.ColumnHeadersHeight = 35;
            this.dgvpdcPayableRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvpdcPayableRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.voucherTypeName,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.dgvpdcPayableMasterId,
            this.invoiceNo,
            this.sufixPrefix,
            this.UserId,
            this.financialYearId,
            this.ExtraDate,
            this.Extra1,
            this.Extra2,
            this.voucherTypeId,
            this.voucherNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpdcPayableRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpdcPayableRegister.EnableHeadersVisualStyles = false;
            this.dgvpdcPayableRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvpdcPayableRegister.Location = new System.Drawing.Point(18, 96);
            this.dgvpdcPayableRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvpdcPayableRegister.Name = "dgvpdcPayableRegister";
            this.dgvpdcPayableRegister.ReadOnly = true;
            this.dgvpdcPayableRegister.RowHeadersVisible = false;
            this.dgvpdcPayableRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpdcPayableRegister.Size = new System.Drawing.Size(764, 456);
            this.dgvpdcPayableRegister.TabIndex = 7;
            this.dgvpdcPayableRegister.TabStop = false;
            this.dgvpdcPayableRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpdcPayableRegister_CellDoubleClick);
            this.dgvpdcPayableRegister.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvpdcPayableRegister_CurrentCellDirtyStateChanged);
            this.dgvpdcPayableRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvpdcPayableRegister_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SlNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // voucherTypeName
            // 
            this.voucherTypeName.DataPropertyName = "voucherTypeName";
            this.voucherTypeName.HeaderText = "Voucher TypeName";
            this.voucherTypeName.Name = "voucherTypeName";
            this.voucherTypeName.ReadOnly = true;
            this.voucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = " Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Account Ledger";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "narration";
            this.Column6.HeaderText = "Narration";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvpdcPayableMasterId
            // 
            this.dgvpdcPayableMasterId.DataPropertyName = "pdcPayableMasterId";
            this.dgvpdcPayableMasterId.HeaderText = "pdcPayableMasterId";
            this.dgvpdcPayableMasterId.Name = "dgvpdcPayableMasterId";
            this.dgvpdcPayableMasterId.ReadOnly = true;
            this.dgvpdcPayableMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvpdcPayableMasterId.Visible = false;
            // 
            // invoiceNo
            // 
            this.invoiceNo.DataPropertyName = "invoiceNo";
            this.invoiceNo.HeaderText = "invoiceNo";
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.ReadOnly = true;
            this.invoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invoiceNo.Visible = false;
            // 
            // sufixPrefix
            // 
            this.sufixPrefix.DataPropertyName = "suffixPrefixId";
            this.sufixPrefix.HeaderText = "sufixPrefix";
            this.sufixPrefix.Name = "sufixPrefix";
            this.sufixPrefix.ReadOnly = true;
            this.sufixPrefix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sufixPrefix.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "userId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserId.Visible = false;
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
            // ExtraDate
            // 
            this.ExtraDate.DataPropertyName = "extraDate";
            this.ExtraDate.HeaderText = "ExtraDate";
            this.ExtraDate.Name = "ExtraDate";
            this.ExtraDate.ReadOnly = true;
            this.ExtraDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExtraDate.Visible = false;
            // 
            // Extra1
            // 
            this.Extra1.DataPropertyName = "extra1";
            this.Extra1.HeaderText = "Extra1";
            this.Extra1.Name = "Extra1";
            this.Extra1.ReadOnly = true;
            this.Extra1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Extra1.Visible = false;
            // 
            // Extra2
            // 
            this.Extra2.DataPropertyName = "extra2";
            this.Extra2.HeaderText = "Extra2";
            this.Extra2.Name = "Extra2";
            this.Extra2.ReadOnly = true;
            this.Extra2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Extra2.Visible = false;
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
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            this.voucherNo.HeaderText = "voucherNo";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Visible = false;
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpfromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpfromDate.TabIndex = 1274;
            this.dtpfromDate.ValueChanged += new System.EventHandler(this.dtpfromDate_ValueChanged);
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
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(761, 15);
            this.dtpTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(19, 20);
            this.dtpTodate.TabIndex = 1276;
            this.dtpTodate.ValueChanged += new System.EventHandler(this.dtpTodate_ValueChanged);
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(579, 15);
            this.txtTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(183, 20);
            this.txtTodate.TabIndex = 1;
            this.txtTodate.TextChanged += new System.EventHandler(this.txtTodate_TextChanged);
            this.txtTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTodate_KeyDown);
            this.txtTodate.Leave += new System.EventHandler(this.txtTodate_Leave);
            // 
            // frmPDCPayableRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.txtTodate);
            this.Controls.Add(this.dtpfromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvpdcPayableRegister);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtvoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.lblfromDate);
            this.Controls.Add(this.lbltoDate);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnViewDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDCPayableRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Payable Register";
            this.Load += new System.EventHandler(this.frmPDCPayableRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDCPayableRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpdcPayableRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label lblfromDate;
        private System.Windows.Forms.Label lbltoDate;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.TextBox txtvoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvpdcPayableRegister;
        private System.Windows.Forms.DateTimePicker dtpfromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.TextBox txtTodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpdcPayableMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sufixPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;

    }
}