namespace Open_Miracle
{
    partial class frmSalesReturnReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReturnReport));
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrPArty = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.lblSalesMan = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvsalesReturnReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvSINo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesReturnMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesReturnReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(473, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1384;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 18);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1386;
            this.lblFromDate.Text = "From Date";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1398;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(133, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(133, 66);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrPArty
            // 
            this.lblCashOrPArty.AutoSize = true;
            this.lblCashOrPArty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrPArty.Location = new System.Drawing.Point(20, 69);
            this.lblCashOrPArty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrPArty.Name = "lblCashOrPArty";
            this.lblCashOrPArty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrPArty.TabIndex = 1399;
            this.lblCashOrPArty.Text = "Cash / Party";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(20, 95);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1401;
            this.lblProductCode.Text = "Product Code";
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(580, 65);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 5;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // lblSalesMan
            // 
            this.lblSalesMan.AutoSize = true;
            this.lblSalesMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesMan.Location = new System.Drawing.Point(473, 68);
            this.lblSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesMan.Name = "lblSalesMan";
            this.lblSalesMan.Size = new System.Drawing.Size(57, 13);
            this.lblSalesMan.TabIndex = 1405;
            this.lblSalesMan.Text = "Sales Man";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(473, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1404;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 90);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 90);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvsalesReturnReport
            // 
            this.dgvsalesReturnReport.AllowUserToAddRows = false;
            this.dgvsalesReturnReport.AllowUserToResizeRows = false;
            this.dgvsalesReturnReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvsalesReturnReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsalesReturnReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsalesReturnReport.ColumnHeadersHeight = 25;
            this.dgvsalesReturnReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvsalesReturnReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSINo,
            this.dgvVoucherType,
            this.dgvVoucherNo,
            this.dgvCashOrParty,
            this.dgvDate,
            this.dgvGrandTotal,
            this.dgvTotalAmount,
            this.dgvDoneBy,
            this.dgvSalesReturnMasterId,
            this.dgvInvoiceNo,
            this.dgvVoucherTypeId,
            this.dgvSalesMasterId});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsalesReturnReport.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvsalesReturnReport.EnableHeadersVisualStyles = false;
            this.dgvsalesReturnReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvsalesReturnReport.Location = new System.Drawing.Point(18, 120);
            this.dgvsalesReturnReport.Name = "dgvsalesReturnReport";
            this.dgvsalesReturnReport.ReadOnly = true;
            this.dgvsalesReturnReport.RowHeadersVisible = false;
            this.dgvsalesReturnReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsalesReturnReport.Size = new System.Drawing.Size(764, 434);
            this.dgvsalesReturnReport.TabIndex = 1419;
            this.dgvsalesReturnReport.TabStop = false;
            this.dgvsalesReturnReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesReturnReport_CellDoubleClick);
            this.dgvsalesReturnReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvsalesReturnReport_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(598, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(313, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1466;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(133, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
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
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(133, 92);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 6;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(689, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvSINo
            // 
            this.dgvSINo.DataPropertyName = "slNo";
            this.dgvSINo.HeaderText = "Sl No";
            this.dgvSINo.Name = "dgvSINo";
            this.dgvSINo.ReadOnly = true;
            this.dgvSINo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSINo.Width = 109;
            // 
            // dgvVoucherType
            // 
            this.dgvVoucherType.DataPropertyName = "voucherTypeName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvVoucherType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVoucherType.HeaderText = "VoucherType";
            this.dgvVoucherType.Name = "dgvVoucherType";
            this.dgvVoucherType.ReadOnly = true;
            this.dgvVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvVoucherType.Width = 108;
            // 
            // dgvVoucherNo
            // 
            this.dgvVoucherNo.DataPropertyName = "voucherNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvVoucherNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoucherNo.HeaderText = "VoucherNo";
            this.dgvVoucherNo.Name = "dgvVoucherNo";
            this.dgvVoucherNo.ReadOnly = true;
            this.dgvVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvVoucherNo.Width = 109;
            // 
            // dgvCashOrParty
            // 
            this.dgvCashOrParty.DataPropertyName = "ledgerName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCashOrParty.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCashOrParty.HeaderText = "CashOrParty";
            this.dgvCashOrParty.Name = "dgvCashOrParty";
            this.dgvCashOrParty.ReadOnly = true;
            this.dgvCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvCashOrParty.Width = 109;
            // 
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "date";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            this.dgvDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDate.Width = 109;
            // 
            // dgvGrandTotal
            // 
            this.dgvGrandTotal.DataPropertyName = "grandTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvGrandTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGrandTotal.HeaderText = "GrandTotal";
            this.dgvGrandTotal.Name = "dgvGrandTotal";
            this.dgvGrandTotal.ReadOnly = true;
            // 
            // dgvTotalAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvTotalAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTotalAmount.HeaderText = "TotalAmount";
            this.dgvTotalAmount.Name = "dgvTotalAmount";
            this.dgvTotalAmount.ReadOnly = true;
            this.dgvTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTotalAmount.Visible = false;
            this.dgvTotalAmount.Width = 108;
            // 
            // dgvDoneBy
            // 
            this.dgvDoneBy.DataPropertyName = "userName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDoneBy.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDoneBy.HeaderText = "DoneBy";
            this.dgvDoneBy.Name = "dgvDoneBy";
            this.dgvDoneBy.ReadOnly = true;
            this.dgvDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDoneBy.Width = 109;
            // 
            // dgvSalesReturnMasterId
            // 
            this.dgvSalesReturnMasterId.DataPropertyName = "salesReturnMasterId";
            this.dgvSalesReturnMasterId.HeaderText = "SalesReturnMasterId";
            this.dgvSalesReturnMasterId.Name = "dgvSalesReturnMasterId";
            this.dgvSalesReturnMasterId.ReadOnly = true;
            this.dgvSalesReturnMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSalesReturnMasterId.Visible = false;
            // 
            // dgvInvoiceNo
            // 
            this.dgvInvoiceNo.DataPropertyName = "invoiceNo";
            this.dgvInvoiceNo.HeaderText = "InvoiceNo";
            this.dgvInvoiceNo.Name = "dgvInvoiceNo";
            this.dgvInvoiceNo.ReadOnly = true;
            this.dgvInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvInvoiceNo.Visible = false;
            // 
            // dgvVoucherTypeId
            // 
            this.dgvVoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvVoucherTypeId.HeaderText = "VoucherTypeId";
            this.dgvVoucherTypeId.Name = "dgvVoucherTypeId";
            this.dgvVoucherTypeId.ReadOnly = true;
            this.dgvVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvVoucherTypeId.Visible = false;
            // 
            // dgvSalesMasterId
            // 
            this.dgvSalesMasterId.DataPropertyName = "salesMasterId";
            this.dgvSalesMasterId.HeaderText = "SalesMasterId";
            this.dgvSalesMasterId.Name = "dgvSalesMasterId";
            this.dgvSalesMasterId.ReadOnly = true;
            this.dgvSalesMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSalesMasterId.Visible = false;
            // 
            // frmSalesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvsalesReturnReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.lblSalesMan);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrPArty);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesReturnReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return Report";
            this.Load += new System.EventHandler(this.frmSalesReturnReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesReturnReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesReturnReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrPArty;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label lblSalesMan;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvsalesReturnReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSINo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesReturnMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesMasterId;
    }
}