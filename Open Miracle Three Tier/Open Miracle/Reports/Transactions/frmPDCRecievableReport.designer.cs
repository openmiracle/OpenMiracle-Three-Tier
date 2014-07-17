namespace Open_Miracle
{
    partial class frmPDCRecievableReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDCRecievableReport));
            this.label9 = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.dgvPdcReceivableSearch = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdcReceivableMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbVouchertype = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblaccountledger = new System.Windows.Forms.Label();
            this.lblCheckNo = new System.Windows.Forms.Label();
            this.lblCheckdateFrom = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCheckDateTo = new System.Windows.Forms.Label();
            this.lblTodate = new System.Windows.Forms.Label();
            this.lblfromdate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.txtcheckdateFrom = new System.Windows.Forms.TextBox();
            this.dtpCheckDateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dtpCheckDateTo = new System.Windows.Forms.DateTimePicker();
            this.txtCheckDateTo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdcReceivableSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(476, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1311;
            this.label9.Text = "Voucher No";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(14, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1309;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // dgvPdcReceivableSearch
            // 
            this.dgvPdcReceivableSearch.AllowUserToAddRows = false;
            this.dgvPdcReceivableSearch.AllowUserToDeleteRows = false;
            this.dgvPdcReceivableSearch.AllowUserToResizeRows = false;
            this.dgvPdcReceivableSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvPdcReceivableSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdcReceivableSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPdcReceivableSearch.ColumnHeadersHeight = 30;
            this.dgvPdcReceivableSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPdcReceivableSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.pdcReceivableMasterId,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPdcReceivableSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPdcReceivableSearch.EnableHeadersVisualStyles = false;
            this.dgvPdcReceivableSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPdcReceivableSearch.Location = new System.Drawing.Point(18, 150);
            this.dgvPdcReceivableSearch.Name = "dgvPdcReceivableSearch";
            this.dgvPdcReceivableSearch.ReadOnly = true;
            this.dgvPdcReceivableSearch.RowHeadersVisible = false;
            this.dgvPdcReceivableSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPdcReceivableSearch.Size = new System.Drawing.Size(764, 398);
            this.dgvPdcReceivableSearch.TabIndex = 1307;
            this.dgvPdcReceivableSearch.TabStop = false;
            this.dgvPdcReceivableSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPdcReceivableSearch_CellDoubleClick);
            this.dgvPdcReceivableSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPdcReceivableSearch_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 85;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "Voucher Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherNo";
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Account Ledger";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 84;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "chequeNo";
            this.Column5.HeaderText = "Cheque No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "checkDate";
            this.Column6.HeaderText = "Cheque Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "narration";
            this.Column8.HeaderText = "Narration";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 85;
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
            // Column9
            // 
            this.Column9.DataPropertyName = "voucherNo";
            this.Column9.HeaderText = "voucherNo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Visible = false;
            // 
            // cmbVouchertype
            // 
            this.cmbVouchertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVouchertype.FormattingEnabled = true;
            this.cmbVouchertype.Location = new System.Drawing.Point(120, 40);
            this.cmbVouchertype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVouchertype.Name = "cmbVouchertype";
            this.cmbVouchertype.Size = new System.Drawing.Size(200, 21);
            this.cmbVouchertype.TabIndex = 2;
            this.cmbVouchertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVouchertype_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(582, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(673, 116);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(120, 66);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 4;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblaccountledger
            // 
            this.lblaccountledger.AutoSize = true;
            this.lblaccountledger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblaccountledger.Location = new System.Drawing.Point(14, 70);
            this.lblaccountledger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblaccountledger.Name = "lblaccountledger";
            this.lblaccountledger.Size = new System.Drawing.Size(83, 13);
            this.lblaccountledger.TabIndex = 1300;
            this.lblaccountledger.Text = "Account Ledger";
            // 
            // lblCheckNo
            // 
            this.lblCheckNo.AutoSize = true;
            this.lblCheckNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckNo.Location = new System.Drawing.Point(14, 121);
            this.lblCheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckNo.Name = "lblCheckNo";
            this.lblCheckNo.Size = new System.Drawing.Size(61, 13);
            this.lblCheckNo.TabIndex = 1314;
            this.lblCheckNo.Text = "Cheque No";
            // 
            // lblCheckdateFrom
            // 
            this.lblCheckdateFrom.AutoSize = true;
            this.lblCheckdateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckdateFrom.Location = new System.Drawing.Point(14, 96);
            this.lblCheckdateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckdateFrom.Name = "lblCheckdateFrom";
            this.lblCheckdateFrom.Size = new System.Drawing.Size(96, 13);
            this.lblCheckdateFrom.TabIndex = 1316;
            this.lblCheckdateFrom.Text = "Cheque Date From";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Cleared",
            "Bounced"});
            this.cmbStatus.Location = new System.Drawing.Point(582, 66);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(476, 70);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1320;
            this.lblStatus.Text = "Status";
            // 
            // lblCheckDateTo
            // 
            this.lblCheckDateTo.AutoSize = true;
            this.lblCheckDateTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckDateTo.Location = new System.Drawing.Point(476, 96);
            this.lblCheckDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckDateTo.Name = "lblCheckDateTo";
            this.lblCheckDateTo.Size = new System.Drawing.Size(86, 13);
            this.lblCheckDateTo.TabIndex = 1321;
            this.lblCheckDateTo.Text = "Cheque Date To";
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.ForeColor = System.Drawing.Color.White;
            this.lblTodate.Location = new System.Drawing.Point(476, 19);
            this.lblTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(46, 13);
            this.lblTodate.TabIndex = 1322;
            this.lblTodate.Text = "To Date";
            // 
            // lblfromdate
            // 
            this.lblfromdate.AutoSize = true;
            this.lblfromdate.ForeColor = System.Drawing.Color.White;
            this.lblfromdate.Location = new System.Drawing.Point(14, 19);
            this.lblfromdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblfromdate.Name = "lblfromdate";
            this.lblfromdate.Size = new System.Drawing.Size(56, 13);
            this.lblfromdate.TabIndex = 1324;
            this.lblfromdate.Text = "From Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(604, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dtpFrmDate
            // 
            this.dtpFrmDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFrmDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFrmDate.Name = "dtpFrmDate";
            this.dtpFrmDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFrmDate.TabIndex = 1466;
            this.dtpFrmDate.ValueChanged += new System.EventHandler(this.dtpFrmDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(762, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(582, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(121, 117);
            this.txtCheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(200, 20);
            this.txtCheckNo.TabIndex = 8;
            this.txtCheckNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckNo_KeyDown);
            // 
            // txtcheckdateFrom
            // 
            this.txtcheckdateFrom.Location = new System.Drawing.Point(120, 92);
            this.txtcheckdateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckdateFrom.Name = "txtcheckdateFrom";
            this.txtcheckdateFrom.Size = new System.Drawing.Size(182, 20);
            this.txtcheckdateFrom.TabIndex = 6;
            this.txtcheckdateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckdateFrom_KeyDown);
            this.txtcheckdateFrom.Leave += new System.EventHandler(this.txtcheckdateFrom_Leave);
            // 
            // dtpCheckDateFrom
            // 
            this.dtpCheckDateFrom.Location = new System.Drawing.Point(300, 92);
            this.dtpCheckDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpCheckDateFrom.Name = "dtpCheckDateFrom";
            this.dtpCheckDateFrom.Size = new System.Drawing.Size(21, 20);
            this.dtpCheckDateFrom.TabIndex = 1472;
            this.dtpCheckDateFrom.ValueChanged += new System.EventHandler(this.dtpCheckDateFrom_ValueChanged);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(582, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // dtpCheckDateTo
            // 
            this.dtpCheckDateTo.Location = new System.Drawing.Point(762, 92);
            this.dtpCheckDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpCheckDateTo.Name = "dtpCheckDateTo";
            this.dtpCheckDateTo.Size = new System.Drawing.Size(21, 20);
            this.dtpCheckDateTo.TabIndex = 1475;
            this.dtpCheckDateTo.ValueChanged += new System.EventHandler(this.dtpCheckDateTo_ValueChanged);
            // 
            // txtCheckDateTo
            // 
            this.txtCheckDateTo.Location = new System.Drawing.Point(582, 92);
            this.txtCheckDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCheckDateTo.Name = "txtCheckDateTo";
            this.txtCheckDateTo.Size = new System.Drawing.Size(182, 20);
            this.txtCheckDateTo.TabIndex = 7;
            this.txtCheckDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckDateTo_KeyDown);
            this.txtCheckDateTo.Leave += new System.EventHandler(this.txtCheckDateTo_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(695, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPDCRecievableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpCheckDateTo);
            this.Controls.Add(this.txtCheckDateTo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dtpCheckDateFrom);
            this.Controls.Add(this.txtcheckdateFrom);
            this.Controls.Add(this.txtCheckNo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTodate);
            this.Controls.Add(this.lblfromdate);
            this.Controls.Add(this.lblCheckDateTo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblCheckdateFrom);
            this.Controls.Add(this.lblCheckNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.dgvPdcReceivableSearch);
            this.Controls.Add(this.cmbVouchertype);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblaccountledger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDCRecievableReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Receivable Report";
            this.Load += new System.EventHandler(this.frmPDCRecievableReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDCRecievableReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdcReceivableSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.DataGridView dgvPdcReceivableSearch;
        private System.Windows.Forms.ComboBox cmbVouchertype;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblaccountledger;
        private System.Windows.Forms.Label lblCheckNo;
        private System.Windows.Forms.Label lblCheckdateFrom;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCheckDateTo;
        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.Label lblfromdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.TextBox txtcheckdateFrom;
        private System.Windows.Forms.DateTimePicker dtpCheckDateFrom;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DateTimePicker dtpCheckDateTo;
        private System.Windows.Forms.TextBox txtCheckDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdcReceivableMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnExport;
    }
}