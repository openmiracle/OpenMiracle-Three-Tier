namespace Open_Miracle
{
    partial class frmPurchaseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPurchaseMode = new System.Windows.Forms.Label();
            this.cmbPurchaseMode = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dgvPurchaseReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnInvoiceDate = new System.Windows.Forms.RadioButton();
            this.rbtnVoucherDate = new System.Windows.Forms.RadioButton();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.cmbAgainstVoucherType = new System.Windows.Forms.ComboBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblAgainstVoucherType = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Fully Paid",
            "Partially Paid",
            "Unpaid",
            "Overdue"});
            this.cmbStatus.Location = new System.Drawing.Point(585, 57);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(480, 136);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProductName.Size = new System.Drawing.Size(75, 18);
            this.lblProductName.TabIndex = 1510;
            this.lblProductName.Text = "Product Name";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(18, 110);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblVoucherType.Size = new System.Drawing.Size(74, 18);
            this.lblVoucherType.TabIndex = 1509;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(120, 109);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 9;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(676, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(585, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // lblPurchaseMode
            // 
            this.lblPurchaseMode.AutoSize = true;
            this.lblPurchaseMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchaseMode.Location = new System.Drawing.Point(18, 84);
            this.lblPurchaseMode.Margin = new System.Windows.Forms.Padding(5);
            this.lblPurchaseMode.Name = "lblPurchaseMode";
            this.lblPurchaseMode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPurchaseMode.Size = new System.Drawing.Size(82, 18);
            this.lblPurchaseMode.TabIndex = 1505;
            this.lblPurchaseMode.Text = "Purchase Mode";
            // 
            // cmbPurchaseMode
            // 
            this.cmbPurchaseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseMode.FormattingEnabled = true;
            this.cmbPurchaseMode.Items.AddRange(new object[] {
            "All",
            "NA",
            "Against PurchaseOrder",
            "Against MaterialReceipt"});
            this.cmbPurchaseMode.Location = new System.Drawing.Point(120, 83);
            this.cmbPurchaseMode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbPurchaseMode.Name = "cmbPurchaseMode";
            this.cmbPurchaseMode.Size = new System.Drawing.Size(200, 21);
            this.cmbPurchaseMode.TabIndex = 6;
            this.cmbPurchaseMode.SelectedIndexChanged += new System.EventHandler(this.cmbPurchaseMode_SelectedIndexChanged);
            this.cmbPurchaseMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPurchaseMode_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(480, 58);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblStatus.Size = new System.Drawing.Size(37, 18);
            this.lblStatus.TabIndex = 1502;
            this.lblStatus.Text = "Status";
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrParty.Location = new System.Drawing.Point(18, 59);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 18);
            this.lblCashOrParty.TabIndex = 1501;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(120, 58);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(480, 33);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblToDate.Size = new System.Drawing.Size(46, 18);
            this.lblToDate.TabIndex = 1496;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(18, 34);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFromDate.Size = new System.Drawing.Size(56, 18);
            this.lblFromDate.TabIndex = 1498;
            this.lblFromDate.Text = "From Date";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(18, 136);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProductCode.Size = new System.Drawing.Size(72, 18);
            this.lblProductCode.TabIndex = 1513;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(480, 111);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 18);
            this.lblVoucherNo.TabIndex = 1514;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(608, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(298, 33);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1520;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 33);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 2;
            this.txtFromDate.TextChanged += new System.EventHandler(this.txtFromDate_TextChanged);
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(764, 32);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1522;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(585, 32);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.TextChanged += new System.EventHandler(this.txtToDate_TextChanged);
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dgvPurchaseReport
            // 
            this.dgvPurchaseReport.AllowUserToAddRows = false;
            this.dgvPurchaseReport.AllowUserToDeleteRows = false;
            this.dgvPurchaseReport.AllowUserToResizeRows = false;
            this.dgvPurchaseReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseReport.ColumnHeadersHeight = 35;
            this.dgvPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtPurchaseMasterId,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherDate,
            this.dgvtxtInvoiceDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtBillAmount,
            this.dgvtxtCurrency,
            this.dgvtxtNo,
            this.dgvtxtDoneBy,
            this.dgvtxtNarration});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchaseReport.EnableHeadersVisualStyles = false;
            this.dgvPurchaseReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseReport.Location = new System.Drawing.Point(18, 196);
            this.dgvPurchaseReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvPurchaseReport.Name = "dgvPurchaseReport";
            this.dgvPurchaseReport.ReadOnly = true;
            this.dgvPurchaseReport.RowHeadersVisible = false;
            this.dgvPurchaseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseReport.Size = new System.Drawing.Size(767, 331);
            this.dgvPurchaseReport.TabIndex = 16;
            this.dgvPurchaseReport.TabStop = false;
            this.dgvPurchaseReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseReport_CellDoubleClick);
            this.dgvPurchaseReport.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPurchaseReport_RowsAdded);
            this.dgvPurchaseReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseReport_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.FillWeight = 50F;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 40;
            // 
            // dgvtxtPurchaseMasterId
            // 
            this.dgvtxtPurchaseMasterId.DataPropertyName = "purchaseMasterId";
            this.dgvtxtPurchaseMasterId.HeaderText = "Purchase Master Id";
            this.dgvtxtPurchaseMasterId.Name = "dgvtxtPurchaseMasterId";
            this.dgvtxtPurchaseMasterId.ReadOnly = true;
            this.dgvtxtPurchaseMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseMasterId.Visible = false;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Width = 80;
            // 
            // dgvtxtVoucherDate
            // 
            this.dgvtxtVoucherDate.DataPropertyName = "voucherDate";
            this.dgvtxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvtxtVoucherDate.Name = "dgvtxtVoucherDate";
            this.dgvtxtVoucherDate.ReadOnly = true;
            this.dgvtxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherDate.Width = 80;
            // 
            // dgvtxtInvoiceDate
            // 
            this.dgvtxtInvoiceDate.DataPropertyName = "invoiceDate";
            this.dgvtxtInvoiceDate.HeaderText = "Invoice Date";
            this.dgvtxtInvoiceDate.Name = "dgvtxtInvoiceDate";
            this.dgvtxtInvoiceDate.ReadOnly = true;
            this.dgvtxtInvoiceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceDate.Width = 80;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCashOrParty.Width = 80;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "grandTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBillAmount.Width = 81;
            // 
            // dgvtxtCurrency
            // 
            this.dgvtxtCurrency.DataPropertyName = "currencyName";
            this.dgvtxtCurrency.HeaderText = "Currency";
            this.dgvtxtCurrency.Name = "dgvtxtCurrency";
            this.dgvtxtCurrency.ReadOnly = true;
            this.dgvtxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrency.Width = 80;
            // 
            // dgvtxtNo
            // 
            this.dgvtxtNo.DataPropertyName = "no";
            this.dgvtxtNo.HeaderText = "Order No / Receipt No";
            this.dgvtxtNo.Name = "dgvtxtNo";
            this.dgvtxtNo.ReadOnly = true;
            this.dgvtxtNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNo.Width = 80;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDoneBy.Width = 80;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 80;
            // 
            // rbtnInvoiceDate
            // 
            this.rbtnInvoiceDate.AutoSize = true;
            this.rbtnInvoiceDate.ForeColor = System.Drawing.Color.White;
            this.rbtnInvoiceDate.Location = new System.Drawing.Point(217, 15);
            this.rbtnInvoiceDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnInvoiceDate.Name = "rbtnInvoiceDate";
            this.rbtnInvoiceDate.Size = new System.Drawing.Size(86, 17);
            this.rbtnInvoiceDate.TabIndex = 1;
            this.rbtnInvoiceDate.TabStop = true;
            this.rbtnInvoiceDate.Text = "Invoice Date";
            this.rbtnInvoiceDate.UseVisualStyleBackColor = true;
            this.rbtnInvoiceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnInvoiceDate_KeyDown);
            // 
            // rbtnVoucherDate
            // 
            this.rbtnVoucherDate.AutoSize = true;
            this.rbtnVoucherDate.ForeColor = System.Drawing.Color.White;
            this.rbtnVoucherDate.Location = new System.Drawing.Point(120, 15);
            this.rbtnVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnVoucherDate.Name = "rbtnVoucherDate";
            this.rbtnVoucherDate.Size = new System.Drawing.Size(91, 17);
            this.rbtnVoucherDate.TabIndex = 0;
            this.rbtnVoucherDate.TabStop = true;
            this.rbtnVoucherDate.Text = "Voucher Date";
            this.rbtnVoucherDate.UseVisualStyleBackColor = true;
            this.rbtnVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnVoucherDate_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(585, 135);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 12;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(585, 110);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 10;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(720, 83);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(65, 20);
            this.txtOrderNo.TabIndex = 8;
            this.txtOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNo_KeyDown);
            // 
            // cmbAgainstVoucherType
            // 
            this.cmbAgainstVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgainstVoucherType.FormattingEnabled = true;
            this.cmbAgainstVoucherType.Location = new System.Drawing.Point(585, 83);
            this.cmbAgainstVoucherType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbAgainstVoucherType.Name = "cmbAgainstVoucherType";
            this.cmbAgainstVoucherType.Size = new System.Drawing.Size(80, 21);
            this.cmbAgainstVoucherType.TabIndex = 7;
            this.cmbAgainstVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAgainstVoucherType_KeyDown);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderNo.Location = new System.Drawing.Point(669, 87);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(62, 13);
            this.lblOrderNo.TabIndex = 1514;
            this.lblOrderNo.Text = "OrderNo";
            // 
            // lblAgainstVoucherType
            // 
            this.lblAgainstVoucherType.AutoSize = true;
            this.lblAgainstVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgainstVoucherType.Location = new System.Drawing.Point(480, 84);
            this.lblAgainstVoucherType.Margin = new System.Windows.Forms.Padding(5);
            this.lblAgainstVoucherType.Name = "lblAgainstVoucherType";
            this.lblAgainstVoucherType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAgainstVoucherType.Size = new System.Drawing.Size(74, 18);
            this.lblAgainstVoucherType.TabIndex = 1502;
            this.lblAgainstVoucherType.Text = "Voucher Type";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(120, 135);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 11;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(677, 532);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(108, 20);
            this.txtTotalAmount.TabIndex = 16;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(572, 533);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 18);
            this.lblTotalAmount.TabIndex = 1527;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(697, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.rbtnInvoiceDate);
            this.Controls.Add(this.rbtnVoucherDate);
            this.Controls.Add(this.dgvPurchaseReport);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.cmbAgainstVoucherType);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPurchaseMode);
            this.Controls.Add(this.cmbPurchaseMode);
            this.Controls.Add(this.lblAgainstVoucherType);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.frmPurchaseReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPurchaseMode;
        private System.Windows.Forms.ComboBox cmbPurchaseMode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridView dgvPurchaseReport;
        private System.Windows.Forms.RadioButton rbtnInvoiceDate;
        private System.Windows.Forms.RadioButton rbtnVoucherDate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.ComboBox cmbAgainstVoucherType;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblAgainstVoucherType;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.Button btnExport;
    }
}