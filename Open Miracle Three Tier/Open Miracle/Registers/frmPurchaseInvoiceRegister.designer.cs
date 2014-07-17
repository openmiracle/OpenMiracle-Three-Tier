namespace Open_Miracle
{
    partial class frmPurchaseInvoiceRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseInvoiceRegister));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtnVoucherDate = new System.Windows.Forms.RadioButton();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rbtnInvoiceDate = new System.Windows.Forms.RadioButton();
            this.cmbPurchaseMode = new System.Windows.Forms.ComboBox();
            this.lblPurchaseMode = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPurchaseRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnVoucherDate
            // 
            this.rbtnVoucherDate.AutoSize = true;
            this.rbtnVoucherDate.ForeColor = System.Drawing.Color.White;
            this.rbtnVoucherDate.Location = new System.Drawing.Point(110, 15);
            this.rbtnVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnVoucherDate.Name = "rbtnVoucherDate";
            this.rbtnVoucherDate.Size = new System.Drawing.Size(91, 17);
            this.rbtnVoucherDate.TabIndex = 0;
            this.rbtnVoucherDate.TabStop = true;
            this.rbtnVoucherDate.Text = "Voucher Date";
            this.rbtnVoucherDate.UseVisualStyleBackColor = true;
            this.rbtnVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnVoucherDate_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(388, 40);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1189;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(19, 41);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1187;
            this.lblFromDate.Text = "From Date";
            // 
            // rbtnInvoiceDate
            // 
            this.rbtnInvoiceDate.AutoSize = true;
            this.rbtnInvoiceDate.ForeColor = System.Drawing.Color.White;
            this.rbtnInvoiceDate.Location = new System.Drawing.Point(207, 15);
            this.rbtnInvoiceDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnInvoiceDate.Name = "rbtnInvoiceDate";
            this.rbtnInvoiceDate.Size = new System.Drawing.Size(86, 17);
            this.rbtnInvoiceDate.TabIndex = 1;
            this.rbtnInvoiceDate.TabStop = true;
            this.rbtnInvoiceDate.Text = "Invoice Date";
            this.rbtnInvoiceDate.UseVisualStyleBackColor = true;
            this.rbtnInvoiceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnInvoiceDate_KeyDown);
            // 
            // cmbPurchaseMode
            // 
            this.cmbPurchaseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseMode.Items.AddRange(new object[] {
            "All",
            "NA",
            "Against PurchaseOrder",
            "Against MaterialReceipt"});
            this.cmbPurchaseMode.Location = new System.Drawing.Point(495, 61);
            this.cmbPurchaseMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPurchaseMode.Name = "cmbPurchaseMode";
            this.cmbPurchaseMode.Size = new System.Drawing.Size(196, 21);
            this.cmbPurchaseMode.TabIndex = 5;
            this.cmbPurchaseMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPurchaseMode_KeyDown);
            // 
            // lblPurchaseMode
            // 
            this.lblPurchaseMode.AutoSize = true;
            this.lblPurchaseMode.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseMode.Location = new System.Drawing.Point(388, 65);
            this.lblPurchaseMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPurchaseMode.Name = "lblPurchaseMode";
            this.lblPurchaseMode.Size = new System.Drawing.Size(82, 13);
            this.lblPurchaseMode.TabIndex = 1197;
            this.lblPurchaseMode.Text = "Purchase Mode";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(110, 62);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(19, 66);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1195;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.Color.White;
            this.lblVoucherType.Location = new System.Drawing.Point(19, 92);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1201;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(495, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(586, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.BackgroundImage")));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 584);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 10;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewDetails_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // dgvPurchaseRegister
            // 
            this.dgvPurchaseRegister.AllowUserToAddRows = false;
            this.dgvPurchaseRegister.AllowUserToDeleteRows = false;
            this.dgvPurchaseRegister.AllowUserToResizeRows = false;
            this.dgvPurchaseRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseRegister.ColumnHeadersHeight = 35;
            this.dgvPurchaseRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtPurchaseMasterId,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherTypeName,
            this.dgvtxtVoucherDate,
            this.dgvtxtInvoiceDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtBillAmount,
            this.Column8,
            this.Column9,
            this.Column10,
            this.dgvtxtNarration});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseRegister.EnableHeadersVisualStyles = false;
            this.dgvPurchaseRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseRegister.Location = new System.Drawing.Point(18, 145);
            this.dgvPurchaseRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvPurchaseRegister.Name = "dgvPurchaseRegister";
            this.dgvPurchaseRegister.ReadOnly = true;
            this.dgvPurchaseRegister.RowHeadersVisible = false;
            this.dgvPurchaseRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseRegister.Size = new System.Drawing.Size(764, 431);
            this.dgvPurchaseRegister.TabIndex = 10;
            this.dgvPurchaseRegister.TabStop = false;
            this.dgvPurchaseRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseRegister_CellDoubleClick);
            this.dgvPurchaseRegister.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPurchaseRegister_CurrentCellDirtyStateChanged);
            this.dgvPurchaseRegister.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPurchaseRegister_RowsAdded);
            this.dgvPurchaseRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseRegister_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.FillWeight = 50F;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 41;
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
            this.dgvtxtVoucherNo.Width = 82;
            // 
            // dgvtxtVoucherTypeName
            // 
            this.dgvtxtVoucherTypeName.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherTypeName.HeaderText = "Voucher Type Name";
            this.dgvtxtVoucherTypeName.Name = "dgvtxtVoucherTypeName";
            this.dgvtxtVoucherTypeName.ReadOnly = true;
            // 
            // dgvtxtVoucherDate
            // 
            this.dgvtxtVoucherDate.DataPropertyName = "voucherDate";
            this.dgvtxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvtxtVoucherDate.Name = "dgvtxtVoucherDate";
            this.dgvtxtVoucherDate.ReadOnly = true;
            this.dgvtxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherDate.Width = 82;
            // 
            // dgvtxtInvoiceDate
            // 
            this.dgvtxtInvoiceDate.DataPropertyName = "invoiceDate";
            this.dgvtxtInvoiceDate.HeaderText = "Invoice Date";
            this.dgvtxtInvoiceDate.Name = "dgvtxtInvoiceDate";
            this.dgvtxtInvoiceDate.ReadOnly = true;
            this.dgvtxtInvoiceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceDate.Width = 82;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCashOrParty.Width = 82;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "grandTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBillAmount.Width = 81;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "currencyName";
            this.Column8.HeaderText = "Currency";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 82;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "no";
            this.Column9.HeaderText = "Order No / Receipt No";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 82;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "userName";
            this.Column10.HeaderText = "Done By";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 82;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 82;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(291, 37);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1280;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(110, 37);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(183, 20);
            this.txtFromDate.TabIndex = 2;
            this.txtFromDate.TextChanged += new System.EventHandler(this.txtFromDate_TextChanged);
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(672, 36);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1282;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(495, 36);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(178, 20);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.TextChanged += new System.EventHandler(this.txtToDate_TextChanged);
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.Location = new System.Drawing.Point(110, 88);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 6;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(388, 91);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1201;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(495, 87);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(196, 20);
            this.txtVoucherNo.TabIndex = 7;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // frmPurchaseInvoiceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(796, 616);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvPurchaseRegister);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.cmbPurchaseMode);
            this.Controls.Add(this.lblPurchaseMode);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.rbtnInvoiceDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.rbtnVoucherDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseInvoiceRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice Register";
            this.Load += new System.EventHandler(this.frmPurchaseInvoiceRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseInvoiceRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVoucherDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RadioButton rbtnInvoiceDate;
        private System.Windows.Forms.ComboBox cmbPurchaseMode;
        private System.Windows.Forms.Label lblPurchaseMode;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPurchaseRegister;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
    }
}