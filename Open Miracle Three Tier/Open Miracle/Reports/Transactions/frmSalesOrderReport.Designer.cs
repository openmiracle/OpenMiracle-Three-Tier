namespace Open_Miracle
{
    partial class frmSalesOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderReport));
            this.cmbQuotationNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvSalesOrderReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesQuotationVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesOrderMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesQuotationMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbQuotationNo
            // 
            this.cmbQuotationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuotationNo.FormattingEnabled = true;
            this.cmbQuotationNo.Location = new System.Drawing.Point(582, 92);
            this.cmbQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbQuotationNo.Name = "cmbQuotationNo";
            this.cmbQuotationNo.Size = new System.Drawing.Size(200, 21);
            this.cmbQuotationNo.TabIndex = 7;
            this.cmbQuotationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbQuotationNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(476, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1572;
            this.label5.Text = "Quotation No";
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
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Due",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(582, 66);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(476, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1569;
            this.label9.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1568;
            this.label3.Text = "Sales Man";
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(120, 92);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 6;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(673, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(582, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1564;
            this.label1.Text = "Cash / Party";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(120, 66);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(476, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1562;
            this.label8.Text = "Voucher No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1561;
            this.label6.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(120, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(476, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1556;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1558;
            this.label7.Text = "From Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(20, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 1577;
            this.label10.Text = "Area";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(120, 144);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(200, 21);
            this.cmbArea.TabIndex = 10;
            this.cmbArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArea_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(20, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 1575;
            this.label11.Text = "Product Group";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(120, 118);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 8;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(476, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 1581;
            this.label12.Text = "Route";
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(582, 144);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(200, 21);
            this.cmbRoute.TabIndex = 11;
            this.cmbRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRoute_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(476, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 1579;
            this.label13.Text = "Product Code";
            // 
            // dgvSalesOrderReport
            // 
            this.dgvSalesOrderReport.AllowUserToAddRows = false;
            this.dgvSalesOrderReport.AllowUserToDeleteRows = false;
            this.dgvSalesOrderReport.AllowUserToResizeRows = false;
            this.dgvSalesOrderReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesOrderReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrderReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOrderReport.ColumnHeadersHeight = 25;
            this.dgvSalesOrderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesOrderReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.salesQuotationVoucherTypeId,
            this.dgvtxtSalesOrderMasterId,
            this.VoucherTypeName,
            this.VoucherNo,
            this.Date,
            this.dgvtxtLedgerName,
            this.dgvtxtCurrencyName,
            this.dgvtxtSalesQuotationMasterId,
            this.dgvtxtTotalAmount,
            this.Column4,
            this.narration,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrderReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesOrderReport.EnableHeadersVisualStyles = false;
            this.dgvSalesOrderReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesOrderReport.Location = new System.Drawing.Point(18, 201);
            this.dgvSalesOrderReport.Name = "dgvSalesOrderReport";
            this.dgvSalesOrderReport.ReadOnly = true;
            this.dgvSalesOrderReport.RowHeadersVisible = false;
            this.dgvSalesOrderReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrderReport.Size = new System.Drawing.Size(764, 327);
            this.dgvSalesOrderReport.TabIndex = 15;
            this.dgvSalesOrderReport.TabStop = false;
            this.dgvSalesOrderReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderReport_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 77;
            // 
            // salesQuotationVoucherTypeId
            // 
            this.salesQuotationVoucherTypeId.DataPropertyName = "salesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.HeaderText = "SalesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.Name = "salesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.ReadOnly = true;
            this.salesQuotationVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.salesQuotationVoucherTypeId.Visible = false;
            // 
            // dgvtxtSalesOrderMasterId
            // 
            this.dgvtxtSalesOrderMasterId.DataPropertyName = "salesOrderMasterId";
            this.dgvtxtSalesOrderMasterId.HeaderText = "SalesOrderMasterId";
            this.dgvtxtSalesOrderMasterId.Name = "dgvtxtSalesOrderMasterId";
            this.dgvtxtSalesOrderMasterId.ReadOnly = true;
            this.dgvtxtSalesOrderMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesOrderMasterId.Visible = false;
            // 
            // VoucherTypeName
            // 
            this.VoucherTypeName.DataPropertyName = "voucherTypeName";
            this.VoucherTypeName.HeaderText = "VoucherTypeName";
            this.VoucherTypeName.Name = "VoucherTypeName";
            this.VoucherTypeName.ReadOnly = true;
            this.VoucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherTypeName.Width = 77;
            // 
            // VoucherNo
            // 
            this.VoucherNo.DataPropertyName = "invoiceNo";
            this.VoucherNo.HeaderText = "VoucherNo";
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.ReadOnly = true;
            this.VoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherNo.Width = 76;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 77;
            // 
            // dgvtxtLedgerName
            // 
            this.dgvtxtLedgerName.DataPropertyName = "ledgerName";
            this.dgvtxtLedgerName.HeaderText = "Cash/Party";
            this.dgvtxtLedgerName.Name = "dgvtxtLedgerName";
            this.dgvtxtLedgerName.ReadOnly = true;
            this.dgvtxtLedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerName.Width = 77;
            // 
            // dgvtxtCurrencyName
            // 
            this.dgvtxtCurrencyName.DataPropertyName = "currencyName";
            this.dgvtxtCurrencyName.HeaderText = "Currency";
            this.dgvtxtCurrencyName.Name = "dgvtxtCurrencyName";
            this.dgvtxtCurrencyName.ReadOnly = true;
            this.dgvtxtCurrencyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrencyName.Width = 77;
            // 
            // dgvtxtSalesQuotationMasterId
            // 
            this.dgvtxtSalesQuotationMasterId.DataPropertyName = "QuotationNo";
            this.dgvtxtSalesQuotationMasterId.HeaderText = "QuotationNo";
            this.dgvtxtSalesQuotationMasterId.Name = "dgvtxtSalesQuotationMasterId";
            this.dgvtxtSalesQuotationMasterId.ReadOnly = true;
            this.dgvtxtSalesQuotationMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesQuotationMasterId.Width = 77;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtTotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtTotalAmount.HeaderText = "Amount";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.ReadOnly = true;
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTotalAmount.Width = 76;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dueDate";
            this.Column4.HeaderText = "DueDate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 77;
            // 
            // narration
            // 
            this.narration.DataPropertyName = "narration";
            this.narration.HeaderText = "Narration";
            this.narration.Name = "narration";
            this.narration.ReadOnly = true;
            this.narration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.narration.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "userName";
            this.Column5.HeaderText = "Doneby";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 77;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(595, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1585;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
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
            this.dtpToDate.TabIndex = 1587;
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
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(682, 534);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 6456;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(569, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 1590;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(582, 118);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 9;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(686, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmSalesOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvSalesOrderReport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.cmbQuotationNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesOrderReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order Report";
            this.Load += new System.EventHandler(this.frmSalesOrderReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesOrderReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbQuotationNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvSalesOrderReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesQuotationVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesOrderMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesQuotationMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnExport;
    }
}