namespace Open_Miracle
{
    partial class frmPDCPayableReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDCPayableReport));
            this.lblTodate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblCheckDateTo = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblCheckdateFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblVouchertype = new System.Windows.Forms.Label();
            this.dgvPDCPayableReport = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpdcPayableMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblaccountLedger = new System.Windows.Forms.Label();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.txtTodate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtcheckdateFrom = new System.Windows.Forms.TextBox();
            this.dtpCheckDateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtcheckNo = new System.Windows.Forms.TextBox();
            this.txtcheckdateTo = new System.Windows.Forms.TextBox();
            this.dtpCheckdateTo = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDCPayableReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.ForeColor = System.Drawing.Color.White;
            this.lblTodate.Location = new System.Drawing.Point(473, 19);
            this.lblTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(46, 13);
            this.lblTodate.TabIndex = 1368;
            this.lblTodate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(14, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1370;
            this.lblFromDate.Text = "From Date";
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(610, 556);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(85, 27);
            this.btnprint.TabIndex = 11;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lblCheckDateTo
            // 
            this.lblCheckDateTo.AutoSize = true;
            this.lblCheckDateTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckDateTo.Location = new System.Drawing.Point(473, 95);
            this.lblCheckDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckDateTo.Name = "lblCheckDateTo";
            this.lblCheckDateTo.Size = new System.Drawing.Size(86, 13);
            this.lblCheckDateTo.TabIndex = 1366;
            this.lblCheckDateTo.Text = "Cheque Date To";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblstatus.Location = new System.Drawing.Point(473, 69);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 1365;
            this.lblstatus.Text = "Status";
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
            this.cmbStatus.Location = new System.Drawing.Point(579, 65);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblCheckdateFrom
            // 
            this.lblCheckdateFrom.AutoSize = true;
            this.lblCheckdateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCheckdateFrom.Location = new System.Drawing.Point(14, 96);
            this.lblCheckdateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCheckdateFrom.Name = "lblCheckdateFrom";
            this.lblCheckdateFrom.Size = new System.Drawing.Size(96, 13);
            this.lblCheckdateFrom.TabIndex = 1361;
            this.lblCheckdateFrom.Text = "Cheque Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1359;
            this.label2.Text = "Cheque No";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(473, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1358;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblVouchertype
            // 
            this.lblVouchertype.AutoSize = true;
            this.lblVouchertype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVouchertype.Location = new System.Drawing.Point(14, 44);
            this.lblVouchertype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVouchertype.Name = "lblVouchertype";
            this.lblVouchertype.Size = new System.Drawing.Size(74, 13);
            this.lblVouchertype.TabIndex = 1356;
            this.lblVouchertype.Text = "Voucher Type";
            // 
            // dgvPDCPayableReport
            // 
            this.dgvPDCPayableReport.AllowUserToAddRows = false;
            this.dgvPDCPayableReport.AllowUserToDeleteRows = false;
            this.dgvPDCPayableReport.AllowUserToResizeRows = false;
            this.dgvPDCPayableReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvPDCPayableReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPDCPayableReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPDCPayableReport.ColumnHeadersHeight = 30;
            this.dgvPDCPayableReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPDCPayableReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column1,
            this.Column2,
            this.Column3,
            this.ledgerName,
            this.chequeNo,
            this.chequeDate,
            this.Column7,
            this.Column8,
            this.dgvpdcPayableMasterId,
            this.status,
            this.DoneBy,
            this.invoiceNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPDCPayableReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPDCPayableReport.EnableHeadersVisualStyles = false;
            this.dgvPDCPayableReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPDCPayableReport.Location = new System.Drawing.Point(18, 147);
            this.dgvPDCPayableReport.Name = "dgvPDCPayableReport";
            this.dgvPDCPayableReport.ReadOnly = true;
            this.dgvPDCPayableReport.RowHeadersVisible = false;
            this.dgvPDCPayableReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPDCPayableReport.Size = new System.Drawing.Size(764, 403);
            this.dgvPDCPayableReport.TabIndex = 12;
            this.dgvPDCPayableReport.TabStop = false;
            this.dgvPDCPayableReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPDCPayableReport_CellDoubleClick);
            this.dgvPDCPayableReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPDCPayableReport_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "Voucher Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 76;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 76;
            // 
            // ledgerName
            // 
            this.ledgerName.DataPropertyName = "ledgerName";
            this.ledgerName.HeaderText = "Account Ledger";
            this.ledgerName.Name = "ledgerName";
            this.ledgerName.ReadOnly = true;
            this.ledgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ledgerName.Width = 76;
            // 
            // chequeNo
            // 
            this.chequeNo.DataPropertyName = "chequeNo";
            this.chequeNo.HeaderText = "Cheque No";
            this.chequeNo.Name = "chequeNo";
            this.chequeNo.ReadOnly = true;
            this.chequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chequeNo.Width = 77;
            // 
            // chequeDate
            // 
            this.chequeDate.DataPropertyName = "checkDate";
            this.chequeDate.HeaderText = "Cheque Date";
            this.chequeDate.Name = "chequeDate";
            this.chequeDate.ReadOnly = true;
            this.chequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chequeDate.Width = 76;
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
            this.Column7.Width = 76;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "narration";
            this.Column8.HeaderText = "Narration";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 76;
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
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Visible = false;
            // 
            // DoneBy
            // 
            this.DoneBy.DataPropertyName = "userName";
            this.DoneBy.HeaderText = "Done By";
            this.DoneBy.Name = "DoneBy";
            this.DoneBy.ReadOnly = true;
            this.DoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DoneBy.Width = 76;
            // 
            // invoiceNo
            // 
            this.invoiceNo.DataPropertyName = "voucherNo";
            this.invoiceNo.HeaderText = "invoiceNo";
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.ReadOnly = true;
            this.invoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invoiceNo.Visible = false;
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(121, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(579, 114);
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
            this.btnReset.Location = new System.Drawing.Point(670, 114);
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
            this.cmbAccountLedger.Location = new System.Drawing.Point(121, 66);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 4;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblaccountLedger
            // 
            this.lblaccountLedger.AutoSize = true;
            this.lblaccountLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblaccountLedger.Location = new System.Drawing.Point(14, 70);
            this.lblaccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblaccountLedger.Name = "lblaccountLedger";
            this.lblaccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblaccountLedger.TabIndex = 1350;
            this.lblaccountLedger.Text = "Account Ledger";
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
            // dtpTodate
            // 
            this.dtpTodate.Location = new System.Drawing.Point(758, 15);
            this.dtpTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(21, 20);
            this.dtpTodate.TabIndex = 1468;
            this.dtpTodate.ValueChanged += new System.EventHandler(this.dtpTodate_ValueChanged);
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(579, 15);
            this.txtTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(182, 20);
            this.txtTodate.TabIndex = 1;
            this.txtTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTodate_KeyDown);
            this.txtTodate.Leave += new System.EventHandler(this.txtTodate_Leave);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(121, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtcheckdateFrom
            // 
            this.txtcheckdateFrom.Location = new System.Drawing.Point(121, 92);
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
            this.dtpCheckDateFrom.TabIndex = 1471;
            this.dtpCheckDateFrom.ValueChanged += new System.EventHandler(this.dtpCheckDateFrom_ValueChanged);
            // 
            // txtcheckNo
            // 
            this.txtcheckNo.Location = new System.Drawing.Point(121, 117);
            this.txtcheckNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckNo.Name = "txtcheckNo";
            this.txtcheckNo.Size = new System.Drawing.Size(200, 20);
            this.txtcheckNo.TabIndex = 8;
            this.txtcheckNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckNo_KeyDown);
            // 
            // txtcheckdateTo
            // 
            this.txtcheckdateTo.Location = new System.Drawing.Point(579, 91);
            this.txtcheckdateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtcheckdateTo.Name = "txtcheckdateTo";
            this.txtcheckdateTo.Size = new System.Drawing.Size(182, 20);
            this.txtcheckdateTo.TabIndex = 7;
            this.txtcheckdateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcheckdateTo_KeyDown);
            this.txtcheckdateTo.Leave += new System.EventHandler(this.txtcheckdateTo_Leave);
            // 
            // dtpCheckdateTo
            // 
            this.dtpCheckdateTo.Location = new System.Drawing.Point(758, 91);
            this.dtpCheckdateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpCheckdateTo.Name = "dtpCheckdateTo";
            this.dtpCheckdateTo.Size = new System.Drawing.Size(21, 20);
            this.dtpCheckdateTo.TabIndex = 1474;
            this.dtpCheckdateTo.ValueChanged += new System.EventHandler(this.dtpCheckdateTo_ValueChanged);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(579, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(701, 556);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPDCPayableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dtpCheckdateTo);
            this.Controls.Add(this.txtcheckdateTo);
            this.Controls.Add(this.txtcheckNo);
            this.Controls.Add(this.dtpCheckDateFrom);
            this.Controls.Add(this.txtcheckdateFrom);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.txtTodate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.lblTodate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lblCheckDateTo);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblCheckdateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVouchertype);
            this.Controls.Add(this.dgvPDCPayableReport);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblaccountLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDCPayableReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Payable Report";
            this.Load += new System.EventHandler(this.frmPDCPayableReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDCPayableReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDCPayableReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lblCheckDateTo;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblCheckdateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblVouchertype;
        private System.Windows.Forms.DataGridView dgvPDCPayableReport;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblaccountLedger;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.TextBox txtTodate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtcheckdateFrom;
        private System.Windows.Forms.DateTimePicker dtpCheckDateFrom;
        private System.Windows.Forms.TextBox txtcheckNo;
        private System.Windows.Forms.TextBox txtcheckdateTo;
        private System.Windows.Forms.DateTimePicker dtpCheckdateTo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpdcPayableMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.Button btnExport;
    }
}