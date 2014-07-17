namespace Open_Miracle
{
    partial class frmMaterialReceiptReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialReceiptReport));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMaterialReceiptReport = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPOVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMaterialReceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialReceiptReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 115);
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
            this.btnSearch.Location = new System.Drawing.Point(580, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(474, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1467;
            this.label8.Text = "Order No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1466;
            this.label6.Text = "Cash / Party";
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
            this.cmbCashOrParty.SelectedIndexChanged += new System.EventHandler(this.cmbCashOrParty_SelectedIndexChanged);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1461;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1463;
            this.label7.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1474;
            this.label3.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All ",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(120, 92);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(474, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1478;
            this.label5.Text = "Product Code";
            // 
            // dgvMaterialReceiptReport
            // 
            this.dgvMaterialReceiptReport.AllowUserToAddRows = false;
            this.dgvMaterialReceiptReport.AllowUserToResizeRows = false;
            this.dgvMaterialReceiptReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialReceiptReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterialReceiptReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialReceiptReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterialReceiptReport.ColumnHeadersHeight = 35;
            this.dgvMaterialReceiptReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Quantity,
            this.dgvtxtPOVoucherTypeId,
            this.purchaseOrderMasterId,
            this.dgvtxtproductId,
            this.dgvtxtMaterialReceiptMasterId,
            this.dgvtxtVoucherType,
            this.voucherTypeId,
            this.dgvtxtVoucherNo,
            this.Column3,
            this.dgvtxtLedger,
            this.dgvtxtOrderNo,
            this.totalAmount,
            this.dgvtxtNarration,
            this.dgvtxtUser});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialReceiptReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaterialReceiptReport.EnableHeadersVisualStyles = false;
            this.dgvMaterialReceiptReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMaterialReceiptReport.Location = new System.Drawing.Point(18, 148);
            this.dgvMaterialReceiptReport.Name = "dgvMaterialReceiptReport";
            this.dgvMaterialReceiptReport.ReadOnly = true;
            this.dgvMaterialReceiptReport.RowHeadersVisible = false;
            this.dgvMaterialReceiptReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialReceiptReport.Size = new System.Drawing.Size(764, 406);
            this.dgvMaterialReceiptReport.TabIndex = 11;
            this.dgvMaterialReceiptReport.TabStop = false;
            this.dgvMaterialReceiptReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialReceiptReport_CellDoubleClick);
            this.dgvMaterialReceiptReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMaterialReceiptReport_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SL.NO";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Visible = false;
            // 
            // dgvtxtPOVoucherTypeId
            // 
            this.dgvtxtPOVoucherTypeId.DataPropertyName = "purchaseOrderVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.HeaderText = "purchaseOrderVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.Name = "dgvtxtPOVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.ReadOnly = true;
            this.dgvtxtPOVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPOVoucherTypeId.Visible = false;
            // 
            // purchaseOrderMasterId
            // 
            this.purchaseOrderMasterId.DataPropertyName = "purchaseOrderMasterId";
            this.purchaseOrderMasterId.HeaderText = "purchaseOrderMasterId";
            this.purchaseOrderMasterId.Name = "purchaseOrderMasterId";
            this.purchaseOrderMasterId.ReadOnly = true;
            this.purchaseOrderMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchaseOrderMasterId.Visible = false;
            // 
            // dgvtxtproductId
            // 
            this.dgvtxtproductId.DataPropertyName = "productId";
            this.dgvtxtproductId.HeaderText = "productId";
            this.dgvtxtproductId.Name = "dgvtxtproductId";
            this.dgvtxtproductId.ReadOnly = true;
            this.dgvtxtproductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductId.Visible = false;
            // 
            // dgvtxtMaterialReceiptMasterId
            // 
            this.dgvtxtMaterialReceiptMasterId.DataPropertyName = "materialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.HeaderText = "materialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.Name = "dgvtxtMaterialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.ReadOnly = true;
            this.dgvtxtMaterialReceiptMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMaterialReceiptMasterId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedger
            // 
            this.dgvtxtLedger.DataPropertyName = "ledgerName";
            this.dgvtxtLedger.HeaderText = "Cash/Party";
            this.dgvtxtLedger.Name = "dgvtxtLedger";
            this.dgvtxtLedger.ReadOnly = true;
            this.dgvtxtLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOrderNo
            // 
            this.dgvtxtOrderNo.DataPropertyName = "OrderNo";
            this.dgvtxtOrderNo.HeaderText = "Order No";
            this.dgvtxtOrderNo.Name = "dgvtxtOrderNo";
            this.dgvtxtOrderNo.ReadOnly = true;
            this.dgvtxtOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalAmount
            // 
            this.totalAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUser
            // 
            this.dgvtxtUser.DataPropertyName = "userName";
            this.dgvtxtUser.HeaderText = "Done By";
            this.dgvtxtUser.Name = "dgvtxtUser";
            this.dgvtxtUser.ReadOnly = true;
            this.dgvtxtUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(609, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
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
            this.dtpFromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1481;
            this.dtpFromDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(183, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1483;
            this.dtpToDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(474, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1488;
            this.label9.Text = "Voucher No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1486;
            this.label1.Text = "Voucher Type";
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
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(580, 66);
            this.cmbOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(200, 21);
            this.cmbOrderNo.TabIndex = 5;
            this.cmbOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrderNo_KeyDown);
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
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(580, 92);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 7;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(700, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMaterialReceiptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvMaterialReceiptReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMaterialReceiptReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Receipt Report";
            this.Load += new System.EventHandler(this.frmMaterialReceiptReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMaterialReceiptReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialReceiptReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMaterialReceiptReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPOVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMaterialReceiptMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUser;
        private System.Windows.Forms.Button btnExport;
    }
}