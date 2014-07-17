namespace Open_Miracle
{
    partial class frmPurchaseReturnReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReturnReport));
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dgvPurchaseReturnReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseReturnMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturnReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceNo.FormattingEnabled = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(579, 66);
            this.cmbInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(200, 21);
            this.cmbInvoiceNo.TabIndex = 5;
            this.cmbInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceNo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(474, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1530;
            this.label9.Text = "Invoice No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1529;
            this.label3.Text = "Product Code";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(670, 92);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 8;
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
            this.btnSearch.Location = new System.Drawing.Point(579, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1525;
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
            this.cmbCashOrParty.SelectedValueChanged += new System.EventHandler(this.cmbCashOrParty_SelectedValueChanged);
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
            this.label8.TabIndex = 1523;
            this.label8.Text = "Voucher No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1522;
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
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1517;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1519;
            this.label7.Text = "From Date";
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
            // dgvPurchaseReturnReport
            // 
            this.dgvPurchaseReturnReport.AllowUserToAddRows = false;
            this.dgvPurchaseReturnReport.AllowUserToResizeRows = false;
            this.dgvPurchaseReturnReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseReturnReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseReturnReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReturnReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseReturnReport.ColumnHeadersHeight = 25;
            this.dgvPurchaseReturnReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseReturnReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.VoucherTypeId,
            this.purchaseMasterId,
            this.dgvtxtPurchaseReturnMasterId,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtInvoiceNo,
            this.dgvtxtCashOrParty,
            this.dgvtxtTotalAmount,
            this.dgvtxtDate,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReturnReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseReturnReport.EnableHeadersVisualStyles = false;
            this.dgvPurchaseReturnReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseReturnReport.Location = new System.Drawing.Point(18, 133);
            this.dgvPurchaseReturnReport.Name = "dgvPurchaseReturnReport";
            this.dgvPurchaseReturnReport.RowHeadersVisible = false;
            this.dgvPurchaseReturnReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseReturnReport.Size = new System.Drawing.Size(764, 422);
            this.dgvPurchaseReturnReport.TabIndex = 14;
            this.dgvPurchaseReturnReport.TabStop = false;
            this.dgvPurchaseReturnReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseReturnReport_CellDoubleClick);
            this.dgvPurchaseReturnReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseReturnReport_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(24, 563);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 9;
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
            this.dtpFrmDate.TabIndex = 1541;
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
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1543;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(597, 563);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "TotalAmount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(670, 560);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 1545;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.White;
            this.txtProductCode.Location = new System.Drawing.Point(120, 92);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(115, 564);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VoucherTypeId
            // 
            this.VoucherTypeId.DataPropertyName = "voucherTypeId";
            this.VoucherTypeId.HeaderText = "VoucherTypeId";
            this.VoucherTypeId.Name = "VoucherTypeId";
            this.VoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherTypeId.Visible = false;
            // 
            // purchaseMasterId
            // 
            this.purchaseMasterId.DataPropertyName = "purchaseMasterId";
            this.purchaseMasterId.HeaderText = "PurchaseMasterId";
            this.purchaseMasterId.Name = "purchaseMasterId";
            this.purchaseMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchaseMasterId.Visible = false;
            // 
            // dgvtxtPurchaseReturnMasterId
            // 
            this.dgvtxtPurchaseReturnMasterId.DataPropertyName = "purchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.HeaderText = "PurchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.Name = "dgvtxtPurchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseReturnMasterId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "VoucherType";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "VoucherNo";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtInvoiceNo
            // 
            this.dgvtxtInvoiceNo.DataPropertyName = "voucherNo";
            this.dgvtxtInvoiceNo.HeaderText = "InvoiceNo";
            this.dgvtxtInvoiceNo.Name = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceNo.Visible = false;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "CashOrParty";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtTotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtTotalAmount.HeaderText = "GrandTotal";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "userName";
            this.Column7.HeaderText = "DoneBy";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPurchaseReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPurchaseReturnReport);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.cmbInvoiceNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
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
            this.Name = "frmPurchaseReturnReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Return Report";
            this.Load += new System.EventHandler(this.frmPurchaseReturnReport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPurchaseReturnReport_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturnReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInvoiceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridView dgvPurchaseReturnReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseReturnMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}