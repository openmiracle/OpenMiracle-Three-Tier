namespace Open_Miracle
{
    partial class frmSalesQuotationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesQuotationReport));
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.lblSalesMan = new System.Windows.Forms.Label();
            this.dgvSalesQuotationReport = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQuotationMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesQuotationReport)).BeginInit();
            this.SuspendLayout();
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
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Approved",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(579, 66);
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
            this.lblStatus.Location = new System.Drawing.Point(455, 69);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1551;
            this.lblStatus.Text = "Status";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(20, 96);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1550;
            this.lblProductCode.Text = "Product Code";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(670, 116);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
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
            this.btnSearch.Location = new System.Drawing.Point(579, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrParty.Location = new System.Drawing.Point(20, 70);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1546;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(146, 66);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(455, 43);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1544;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1543;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(146, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(455, 18);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1538;
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
            this.lblFromDate.TabIndex = 1540;
            this.lblFromDate.Text = "From Date";
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(579, 92);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 7;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // lblSalesMan
            // 
            this.lblSalesMan.AutoSize = true;
            this.lblSalesMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesMan.Location = new System.Drawing.Point(455, 95);
            this.lblSalesMan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSalesMan.Name = "lblSalesMan";
            this.lblSalesMan.Size = new System.Drawing.Size(57, 13);
            this.lblSalesMan.TabIndex = 1554;
            this.lblSalesMan.Text = "Sales Man";
            // 
            // dgvSalesQuotationReport
            // 
            this.dgvSalesQuotationReport.AllowUserToAddRows = false;
            this.dgvSalesQuotationReport.AllowUserToResizeRows = false;
            this.dgvSalesQuotationReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesQuotationReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesQuotationReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesQuotationReport.ColumnHeadersHeight = 25;
            this.dgvSalesQuotationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesQuotationReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.dgvtxtQuotationMasterId,
            this.VoucherType,
            this.VoucherTypeName,
            this.VoucherNo,
            this.CashOrParty,
            this.Date,
            this.Column2,
            this.Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesQuotationReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesQuotationReport.EnableHeadersVisualStyles = false;
            this.dgvSalesQuotationReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesQuotationReport.Location = new System.Drawing.Point(18, 149);
            this.dgvSalesQuotationReport.Name = "dgvSalesQuotationReport";
            this.dgvSalesQuotationReport.ReadOnly = true;
            this.dgvSalesQuotationReport.RowHeadersVisible = false;
            this.dgvSalesQuotationReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesQuotationReport.Size = new System.Drawing.Size(764, 379);
            this.dgvSalesQuotationReport.TabIndex = 12;
            this.dgvSalesQuotationReport.TabStop = false;
            this.dgvSalesQuotationReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesQuotationReport_CellDoubleClick);
            this.dgvSalesQuotationReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesQuotationReport_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 109;
            // 
            // dgvtxtQuotationMasterId
            // 
            this.dgvtxtQuotationMasterId.DataPropertyName = "quotationMasterId";
            this.dgvtxtQuotationMasterId.HeaderText = "QuotationMaterId";
            this.dgvtxtQuotationMasterId.Name = "dgvtxtQuotationMasterId";
            this.dgvtxtQuotationMasterId.ReadOnly = true;
            this.dgvtxtQuotationMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQuotationMasterId.Visible = false;
            // 
            // VoucherType
            // 
            this.VoucherType.DataPropertyName = "voucherTypeId";
            this.VoucherType.HeaderText = "VoucherId";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.ReadOnly = true;
            this.VoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherType.Visible = false;
            // 
            // VoucherTypeName
            // 
            this.VoucherTypeName.DataPropertyName = "voucherTypeName";
            this.VoucherTypeName.HeaderText = "VoucherTypeName";
            this.VoucherTypeName.Name = "VoucherTypeName";
            this.VoucherTypeName.ReadOnly = true;
            this.VoucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherTypeName.Width = 108;
            // 
            // VoucherNo
            // 
            this.VoucherNo.DataPropertyName = "voucherNo";
            this.VoucherNo.HeaderText = "VoucherNo";
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.ReadOnly = true;
            this.VoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherNo.Width = 109;
            // 
            // CashOrParty
            // 
            this.CashOrParty.DataPropertyName = "ledgerName";
            this.CashOrParty.HeaderText = "CashOrParty";
            this.CashOrParty.Name = "CashOrParty";
            this.CashOrParty.ReadOnly = true;
            this.CashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CashOrParty.Width = 108;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 109;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "userName";
            this.Column2.HeaderText = "DoneBy";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 108;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 109;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(605, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(326, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1559;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(146, 15);
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
            this.dtpToDate.TabIndex = 1561;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(579, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(579, 534);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(203, 20);
            this.txtTotalAmount.TabIndex = 1563;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(455, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1564;
            this.label2.Text = "TotalAmount";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(146, 92);
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
            this.btnExport.Location = new System.Drawing.Point(696, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmSalesQuotationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvSalesQuotationReport);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.lblSalesMan);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesQuotationReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Quotation Report";
            this.Load += new System.EventHandler(this.frmSalesQuotationReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesQuotationReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesQuotationReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label lblSalesMan;
        private System.Windows.Forms.DataGridView dgvSalesQuotationReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQuotationMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnExport;
    }
}