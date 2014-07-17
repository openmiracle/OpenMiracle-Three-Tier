namespace Open_Miracle
{
    partial class frmDeliveryNoteReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryNoteReport));
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOrderOrQuotation = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeliveryMode = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.dgvDeliveryNoteReport = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDeliveryNoteMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNoteReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(474, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 1605;
            this.label13.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(580, 118);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(14, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 1601;
            this.label11.Text = "Product Code";
            // 
            // lblOrderOrQuotation
            // 
            this.lblOrderOrQuotation.AutoSize = true;
            this.lblOrderOrQuotation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderOrQuotation.Location = new System.Drawing.Point(474, 96);
            this.lblOrderOrQuotation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblOrderOrQuotation.Name = "lblOrderOrQuotation";
            this.lblOrderOrQuotation.Size = new System.Drawing.Size(50, 13);
            this.lblOrderOrQuotation.TabIndex = 1598;
            this.lblOrderOrQuotation.Text = "Order No";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(201, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(580, 66);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(201, 21);
            this.cmbSalesMan.TabIndex = 5;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(474, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1595;
            this.label9.Text = "Sales Man";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1594;
            this.label3.Text = "Type";
            // 
            // cmbDeliveryMode
            // 
            this.cmbDeliveryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMode.FormattingEnabled = true;
            this.cmbDeliveryMode.Items.AddRange(new object[] {
            "NA",
            "Against Quotation",
            "Against Order"});
            this.cmbDeliveryMode.Location = new System.Drawing.Point(121, 92);
            this.cmbDeliveryMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbDeliveryMode.Name = "cmbDeliveryMode";
            this.cmbDeliveryMode.Size = new System.Drawing.Size(200, 21);
            this.cmbDeliveryMode.TabIndex = 6;
            this.cmbDeliveryMode.SelectedValueChanged += new System.EventHandler(this.cmbDeliveryMode_SelectedValueChanged);
            this.cmbDeliveryMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDeliveryMode_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 11;
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
            this.btnSearch.Location = new System.Drawing.Point(580, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1590;
            this.label1.Text = "Cash / Party";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(121, 66);
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
            this.label8.Location = new System.Drawing.Point(474, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1588;
            this.label8.Text = "Voucher No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1587;
            this.label6.Text = "Voucher Type";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1582;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1584;
            this.label7.Text = "From Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(607, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 12;
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
            this.dtpFromDate.TabIndex = 4356;
            this.dtpFromDate.CloseUp += new System.EventHandler(this.dtpFromDate_CloseUp);
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
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 6457;
            this.dtpToDate.CloseUp += new System.EventHandler(this.dtpToDate_CloseUp);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(580, 92);
            this.cmbOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(201, 21);
            this.cmbOrderNo.TabIndex = 7;
            this.cmbOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrderNo_KeyDown);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(121, 118);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 8;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // dgvDeliveryNoteReport
            // 
            this.dgvDeliveryNoteReport.AllowUserToAddRows = false;
            this.dgvDeliveryNoteReport.AllowUserToResizeRows = false;
            this.dgvDeliveryNoteReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryNoteReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeliveryNoteReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryNoteReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveryNoteReport.ColumnHeadersHeight = 35;
            this.dgvDeliveryNoteReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeliveryNoteReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo,
            this.productName,
            this.productCode,
            this.size,
            this.brand,
            this.modalNo,
            this.dgvtxtTotalAmount,
            this.dgvtxtDeliveryNoteMasterId,
            this.Employee,
            this.userName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveryNoteReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeliveryNoteReport.EnableHeadersVisualStyles = false;
            this.dgvDeliveryNoteReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDeliveryNoteReport.Location = new System.Drawing.Point(18, 175);
            this.dgvDeliveryNoteReport.MultiSelect = false;
            this.dgvDeliveryNoteReport.Name = "dgvDeliveryNoteReport";
            this.dgvDeliveryNoteReport.ReadOnly = true;
            this.dgvDeliveryNoteReport.RowHeadersVisible = false;
            this.dgvDeliveryNoteReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryNoteReport.Size = new System.Drawing.Size(764, 379);
            this.dgvDeliveryNoteReport.TabIndex = 1606;
            this.dgvDeliveryNoteReport.TabStop = false;
            this.dgvDeliveryNoteReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryNoteReport_CellDoubleClick);
            this.dgvDeliveryNoteReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDeliveryNoteReport_KeyDown);
            // 
            // slNo
            // 
            this.slNo.DataPropertyName = "slNo";
            this.slNo.HeaderText = "SlNo";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            this.slNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "voucherNo";
            this.productName.HeaderText = "Voucher No";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productCode
            // 
            this.productCode.DataPropertyName = "voucherTypeName";
            this.productCode.HeaderText = "Voucher Type";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // size
            // 
            this.size.DataPropertyName = "date";
            this.size.HeaderText = "Date";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "ledgerName";
            this.brand.HeaderText = "Cash Or Party";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modalNo
            // 
            this.modalNo.DataPropertyName = "OrderNoOrQuotationNo";
            this.modalNo.HeaderText = "Order/ QuotationNo";
            this.modalNo.Name = "modalNo";
            this.modalNo.ReadOnly = true;
            this.modalNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtTotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtTotalAmount.HeaderText = "Total Amount";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.ReadOnly = true;
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDeliveryNoteMasterId
            // 
            this.dgvtxtDeliveryNoteMasterId.DataPropertyName = "deliveryNotemasterId";
            this.dgvtxtDeliveryNoteMasterId.HeaderText = "DeliveryNoteMasterId";
            this.dgvtxtDeliveryNoteMasterId.Name = "dgvtxtDeliveryNoteMasterId";
            this.dgvtxtDeliveryNoteMasterId.ReadOnly = true;
            this.dgvtxtDeliveryNoteMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDeliveryNoteMasterId.Visible = false;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "employeename";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Visible = false;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Done By";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(698, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDeliveryNoteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDeliveryNoteReport);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblOrderOrQuotation);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDeliveryMode);
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
            this.Name = "frmDeliveryNoteReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Note Report";
            this.Load += new System.EventHandler(this.frmDeliveryNoteReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeliveryNoteReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNoteReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOrderOrQuotation;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDeliveryMode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.DataGridView dgvDeliveryNoteReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDeliveryNoteMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.Button btnExport;
    }
}