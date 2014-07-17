namespace Open_Miracle
{
    partial class frmPdcClearanceRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdcClearanceRegister));
            this.dgvClearanceSearch = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDCClearanceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixPrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgainstId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.txtCheckno = new System.Windows.Forms.TextBox();
            this.lblCheckno = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCheckDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVouchertype = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.txtCheckDate = new System.Windows.Forms.TextBox();
            this.dtpCheckdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClearanceSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClearanceSearch
            // 
            this.dgvClearanceSearch.AllowUserToAddRows = false;
            this.dgvClearanceSearch.AllowUserToDeleteRows = false;
            this.dgvClearanceSearch.AllowUserToResizeColumns = false;
            this.dgvClearanceSearch.AllowUserToResizeRows = false;
            this.dgvClearanceSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClearanceSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvClearanceSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClearanceSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClearanceSearch.ColumnHeadersHeight = 25;
            this.dgvClearanceSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClearanceSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.PDCClearanceMasterId,
            this.financialYearId,
            this.narration,
            this.suffixPrefixId,
            this.invoiceNo,
            this.voucherNo,
            this.userId,
            this.voucherTypeId,
            this.AgainstId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClearanceSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClearanceSearch.EnableHeadersVisualStyles = false;
            this.dgvClearanceSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvClearanceSearch.Location = new System.Drawing.Point(18, 151);
            this.dgvClearanceSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvClearanceSearch.Name = "dgvClearanceSearch";
            this.dgvClearanceSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClearanceSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClearanceSearch.RowHeadersVisible = false;
            this.dgvClearanceSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClearanceSearch.Size = new System.Drawing.Size(764, 403);
            this.dgvClearanceSearch.TabIndex = 587;
            this.dgvClearanceSearch.TabStop = false;
            this.dgvClearanceSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClearanceSearch_CellDoubleClick);
            this.dgvClearanceSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvClearanceSearch_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "voucherNo";
            this.Column6.HeaderText = "VoucherNo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "voucherTypeName";
            this.Column7.HeaderText = "VoucherTypeName";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ledgerName";
            this.Column1.HeaderText = "Account Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "date";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "type";
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PDCClearanceMasterId
            // 
            this.PDCClearanceMasterId.DataPropertyName = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.HeaderText = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.Name = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.ReadOnly = true;
            this.PDCClearanceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PDCClearanceMasterId.Visible = false;
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
            // narration
            // 
            this.narration.DataPropertyName = "narration";
            this.narration.HeaderText = "narration";
            this.narration.Name = "narration";
            this.narration.ReadOnly = true;
            this.narration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.narration.Visible = false;
            // 
            // suffixPrefixId
            // 
            this.suffixPrefixId.DataPropertyName = "suffixPrefixId";
            this.suffixPrefixId.HeaderText = "suffixPrefixId";
            this.suffixPrefixId.Name = "suffixPrefixId";
            this.suffixPrefixId.ReadOnly = true;
            this.suffixPrefixId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.suffixPrefixId.Visible = false;
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
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            this.voucherNo.HeaderText = "voucherNo";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Visible = false;
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
            // voucherTypeId
            // 
            this.voucherTypeId.DataPropertyName = "voucherTypeId";
            this.voucherTypeId.HeaderText = "voucherTypeId";
            this.voucherTypeId.Name = "voucherTypeId";
            this.voucherTypeId.ReadOnly = true;
            this.voucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherTypeId.Visible = false;
            // 
            // AgainstId
            // 
            this.AgainstId.DataPropertyName = "againstId";
            this.AgainstId.HeaderText = "AgainstId";
            this.AgainstId.Name = "AgainstId";
            this.AgainstId.ReadOnly = true;
            this.AgainstId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AgainstId.Visible = false;
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountLedger.Location = new System.Drawing.Point(20, 44);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountLedger.TabIndex = 591;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // txtCheckno
            // 
            this.txtCheckno.Location = new System.Drawing.Point(126, 66);
            this.txtCheckno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCheckno.Name = "txtCheckno";
            this.txtCheckno.Size = new System.Drawing.Size(200, 20);
            this.txtCheckno.TabIndex = 4;
            this.txtCheckno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckno_KeyDown);
            // 
            // lblCheckno
            // 
            this.lblCheckno.AutoSize = true;
            this.lblCheckno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckno.Location = new System.Drawing.Point(20, 70);
            this.lblCheckno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckno.Name = "lblCheckno";
            this.lblCheckno.Size = new System.Drawing.Size(64, 13);
            this.lblCheckno.TabIndex = 595;
            this.lblCheckno.Text = "Cheque No.";
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(126, 91);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(200, 21);
            this.cmbBank.TabIndex = 6;
            this.cmbBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBank_KeyDown);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBank.Location = new System.Drawing.Point(20, 95);
            this.lblBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 597;
            this.lblBank.Text = "Bank";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(676, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(580, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // lblCheckDate
            // 
            this.lblCheckDate.AutoSize = true;
            this.lblCheckDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckDate.Location = new System.Drawing.Point(473, 70);
            this.lblCheckDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckDate.Name = "lblCheckDate";
            this.lblCheckDate.Size = new System.Drawing.Size(70, 13);
            this.lblCheckDate.TabIndex = 580;
            this.lblCheckDate.Text = "Cheque Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(473, 44);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 593;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Cleared",
            "Bounced"});
            this.cmbStatus.Location = new System.Drawing.Point(580, 40);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(478, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 599;
            this.label9.Text = "Voucher Type";
            // 
            // cmbVouchertype
            // 
            this.cmbVouchertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVouchertype.FormattingEnabled = true;
            this.cmbVouchertype.Location = new System.Drawing.Point(580, 91);
            this.cmbVouchertype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVouchertype.Name = "cmbVouchertype";
            this.cmbVouchertype.Size = new System.Drawing.Size(200, 21);
            this.cmbVouchertype.TabIndex = 7;
            this.cmbVouchertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVouchertype_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(473, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1285;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1287;
            this.lblFromDate.Text = "From Date";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.BackgroundImage")));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 10;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(126, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(183, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpFromDate.Location = new System.Drawing.Point(306, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1485;
            this.dtpFromDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MMM-YYYY";
            this.dtpTodate.Location = new System.Drawing.Point(760, 15);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(20, 20);
            this.dtpTodate.TabIndex = 1487;
            this.dtpTodate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpTodate.ValueChanged += new System.EventHandler(this.dtpTodate_ValueChanged);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(126, 40);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 2;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Location = new System.Drawing.Point(580, 66);
            this.txtCheckDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.Size = new System.Drawing.Size(181, 20);
            this.txtCheckDate.TabIndex = 5;
            this.txtCheckDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckDate_KeyDown);
            this.txtCheckDate.Leave += new System.EventHandler(this.txtCheckDate_Leave);
            // 
            // dtpCheckdate
            // 
            this.dtpCheckdate.CustomFormat = "dd-MMM-YYYY";
            this.dtpCheckdate.Location = new System.Drawing.Point(760, 66);
            this.dtpCheckdate.Name = "dtpCheckdate";
            this.dtpCheckdate.Size = new System.Drawing.Size(20, 20);
            this.dtpCheckdate.TabIndex = 1492;
            this.dtpCheckdate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpCheckdate.ValueChanged += new System.EventHandler(this.dtpCheckdate_ValueChanged);
            // 
            // frmPdcClearanceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpCheckdate);
            this.Controls.Add(this.txtCheckDate);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.cmbVouchertype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txtCheckno);
            this.Controls.Add(this.lblCheckno);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.dgvClearanceSearch);
            this.Controls.Add(this.lblCheckDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPdcClearanceRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Clearance Register";
            this.Load += new System.EventHandler(this.frmPdcClearanceRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPdcClearanceRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClearanceSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClearanceSearch;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.TextBox txtCheckno;
        private System.Windows.Forms.Label lblCheckno;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCheckDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbVouchertype;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.TextBox txtCheckDate;
        private System.Windows.Forms.DateTimePicker dtpCheckdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDCClearanceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn financialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixPrefixId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgainstId;
    }
}