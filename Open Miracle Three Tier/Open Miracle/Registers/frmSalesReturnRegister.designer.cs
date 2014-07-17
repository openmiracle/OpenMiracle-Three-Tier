namespace Open_Miracle
{
    partial class frmSalesReturnRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReturnRegister));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.cmpvoucherType = new System.Windows.Forms.ComboBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvSalesReturnRegister = new System.Windows.Forms.DataGridView();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSalesReturnNumber = new System.Windows.Forms.Label();
            this.txtSalesReturnNumber = new System.Windows.Forms.TextBox();
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.lblvoucherType = new System.Windows.Forms.Label();
            this.dgvSINo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReturnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtgrandtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesReturnMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturnRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 18);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(474, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 5;
            this.lblToDate.Text = "To Date";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(580, 39);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(474, 43);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 13;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // cmpvoucherType
            // 
            this.cmpvoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpvoucherType.Location = new System.Drawing.Point(126, 63);
            this.cmpvoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmpvoucherType.Name = "cmpvoucherType";
            this.cmpvoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmpvoucherType.TabIndex = 4;
            this.cmpvoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceNo_KeyDown);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceNo.Location = new System.Drawing.Point(20, 93);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNo.TabIndex = 17;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(580, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvSalesReturnRegister
            // 
            this.dgvSalesReturnRegister.AllowUserToAddRows = false;
            this.dgvSalesReturnRegister.AllowUserToResizeRows = false;
            this.dgvSalesReturnRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesReturnRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturnRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesReturnRegister.ColumnHeadersHeight = 35;
            this.dgvSalesReturnRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesReturnRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSINo,
            this.dgvReturnNo,
            this.dgvDate,
            this.dgvCashOrParty,
            this.dgvBillAmount,
            this.dgvtxtgrandtotal,
            this.dgvCurrency,
            this.dgvInvoiceNo,
            this.dgvNarration,
            this.dgvDoneBy,
            this.dgvVoucherNo,
            this.dgvVoucherTypeId,
            this.dgvSalesReturnMasterId,
            this.dgvSalesMasterId,
            this.dgvSalesAccount});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturnRegister.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSalesReturnRegister.EnableHeadersVisualStyles = false;
            this.dgvSalesReturnRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesReturnRegister.Location = new System.Drawing.Point(18, 114);
            this.dgvSalesReturnRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSalesReturnRegister.Name = "dgvSalesReturnRegister";
            this.dgvSalesReturnRegister.ReadOnly = true;
            this.dgvSalesReturnRegister.RowHeadersVisible = false;
            this.dgvSalesReturnRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReturnRegister.Size = new System.Drawing.Size(764, 438);
            this.dgvSalesReturnRegister.TabIndex = 8;
            this.dgvSalesReturnRegister.TabStop = false;
            this.dgvSalesReturnRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReturnRegister_CellDoubleClick);
            this.dgvSalesReturnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesReturnRegister_KeyDown);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(126, 14);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
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
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(305, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1293;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(761, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1294;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // lblSalesReturnNumber
            // 
            this.lblSalesReturnNumber.AutoSize = true;
            this.lblSalesReturnNumber.ForeColor = System.Drawing.Color.White;
            this.lblSalesReturnNumber.Location = new System.Drawing.Point(20, 42);
            this.lblSalesReturnNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesReturnNumber.Name = "lblSalesReturnNumber";
            this.lblSalesReturnNumber.Size = new System.Drawing.Size(85, 13);
            this.lblSalesReturnNumber.TabIndex = 1295;
            this.lblSalesReturnNumber.Text = "Sales Return No";
            // 
            // txtSalesReturnNumber
            // 
            this.txtSalesReturnNumber.Location = new System.Drawing.Point(126, 38);
            this.txtSalesReturnNumber.Name = "txtSalesReturnNumber";
            this.txtSalesReturnNumber.Size = new System.Drawing.Size(200, 20);
            this.txtSalesReturnNumber.TabIndex = 2;
            this.txtSalesReturnNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalesReturnNumber_KeyDown);
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(126, 90);
            this.cmbInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(200, 21);
            this.cmbInvoiceNo.TabIndex = 1296;
            // 
            // lblvoucherType
            // 
            this.lblvoucherType.AutoSize = true;
            this.lblvoucherType.ForeColor = System.Drawing.Color.White;
            this.lblvoucherType.Location = new System.Drawing.Point(20, 71);
            this.lblvoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblvoucherType.Name = "lblvoucherType";
            this.lblvoucherType.Size = new System.Drawing.Size(71, 13);
            this.lblvoucherType.TabIndex = 1298;
            this.lblvoucherType.Text = "VoucherType";
            // 
            // dgvSINo
            // 
            this.dgvSINo.DataPropertyName = "slNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSINo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSINo.HeaderText = "Sl No";
            this.dgvSINo.Name = "dgvSINo";
            this.dgvSINo.ReadOnly = true;
            this.dgvSINo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSINo.Width = 85;
            // 
            // dgvReturnNo
            // 
            this.dgvReturnNo.DataPropertyName = "invoiceNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvReturnNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnNo.HeaderText = "Return No";
            this.dgvReturnNo.Name = "dgvReturnNo";
            this.dgvReturnNo.ReadOnly = true;
            this.dgvReturnNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvReturnNo.Width = 84;
            // 
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            this.dgvDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDate.Width = 85;
            // 
            // dgvCashOrParty
            // 
            this.dgvCashOrParty.DataPropertyName = "ledgerName";
            this.dgvCashOrParty.HeaderText = "Cash / Party";
            this.dgvCashOrParty.Name = "dgvCashOrParty";
            this.dgvCashOrParty.ReadOnly = true;
            this.dgvCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvCashOrParty.Width = 84;
            // 
            // dgvBillAmount
            // 
            this.dgvBillAmount.DataPropertyName = "grandTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvBillAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBillAmount.HeaderText = "Bill Amount";
            this.dgvBillAmount.Name = "dgvBillAmount";
            this.dgvBillAmount.ReadOnly = true;
            this.dgvBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvBillAmount.Visible = false;
            this.dgvBillAmount.Width = 85;
            // 
            // dgvtxtgrandtotal
            // 
            this.dgvtxtgrandtotal.DataPropertyName = "grandTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtgrandtotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtgrandtotal.HeaderText = "GrandTotal";
            this.dgvtxtgrandtotal.Name = "dgvtxtgrandtotal";
            this.dgvtxtgrandtotal.ReadOnly = true;
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.DataPropertyName = "currencyName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCurrency.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCurrency.HeaderText = "Currency";
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvCurrency.Width = 84;
            // 
            // dgvInvoiceNo
            // 
            this.dgvInvoiceNo.DataPropertyName = "AgainstInvoiceNo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvInvoiceNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoiceNo.HeaderText = "Invoice No";
            this.dgvInvoiceNo.Name = "dgvInvoiceNo";
            this.dgvInvoiceNo.ReadOnly = true;
            this.dgvInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvInvoiceNo.Width = 85;
            // 
            // dgvNarration
            // 
            this.dgvNarration.DataPropertyName = "narration";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvNarration.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNarration.HeaderText = "Narration";
            this.dgvNarration.Name = "dgvNarration";
            this.dgvNarration.ReadOnly = true;
            this.dgvNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvNarration.Width = 84;
            // 
            // dgvDoneBy
            // 
            this.dgvDoneBy.DataPropertyName = "userName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDoneBy.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDoneBy.HeaderText = "Done By";
            this.dgvDoneBy.Name = "dgvDoneBy";
            this.dgvDoneBy.ReadOnly = true;
            this.dgvDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDoneBy.Width = 85;
            // 
            // dgvVoucherNo
            // 
            this.dgvVoucherNo.DataPropertyName = "voucherNo";
            this.dgvVoucherNo.HeaderText = "VoucherNo";
            this.dgvVoucherNo.Name = "dgvVoucherNo";
            this.dgvVoucherNo.ReadOnly = true;
            this.dgvVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvVoucherNo.Visible = false;
            // 
            // dgvVoucherTypeId
            // 
            this.dgvVoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvVoucherTypeId.HeaderText = "VouchertypeId";
            this.dgvVoucherTypeId.Name = "dgvVoucherTypeId";
            this.dgvVoucherTypeId.ReadOnly = true;
            this.dgvVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvVoucherTypeId.Visible = false;
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
            // dgvSalesMasterId
            // 
            this.dgvSalesMasterId.DataPropertyName = "salesMasterId";
            this.dgvSalesMasterId.HeaderText = "SalesMasterId";
            this.dgvSalesMasterId.Name = "dgvSalesMasterId";
            this.dgvSalesMasterId.ReadOnly = true;
            this.dgvSalesMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSalesMasterId.Visible = false;
            // 
            // dgvSalesAccount
            // 
            this.dgvSalesAccount.DataPropertyName = "salesAccount";
            this.dgvSalesAccount.HeaderText = "SalesAccount";
            this.dgvSalesAccount.Name = "dgvSalesAccount";
            this.dgvSalesAccount.ReadOnly = true;
            this.dgvSalesAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvSalesAccount.Visible = false;
            // 
            // frmSalesReturnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblvoucherType);
            this.Controls.Add(this.cmbInvoiceNo);
            this.Controls.Add(this.txtSalesReturnNumber);
            this.Controls.Add(this.lblSalesReturnNumber);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvSalesReturnRegister);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmpvoucherType);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesReturnRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return Register";
            this.Load += new System.EventHandler(this.frmSalesReturnRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesReturnRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturnRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.ComboBox cmpvoucherType;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DataGridView dgvSalesReturnRegister;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblSalesReturnNumber;
        private System.Windows.Forms.TextBox txtSalesReturnNumber;
        private System.Windows.Forms.ComboBox cmbInvoiceNo;
        private System.Windows.Forms.Label lblvoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSINo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReturnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtgrandtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesReturnMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesAccount;
    }
}