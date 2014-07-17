namespace Open_Miracle
{
    partial class frmSalesInvoiceRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvoiceRegister));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblTodate = new System.Windows.Forms.Label();
            this.cmbCashorParty = new System.Windows.Forms.ComboBox();
            this.lblSalesMode = new System.Windows.Forms.Label();
            this.dgvSiRegister = new System.Windows.Forms.DataGridView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbVoucherNo = new System.Windows.Forms.ComboBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.cmbSalesMode = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvTxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVouchertypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtQuotationOrOrderNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalesMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date";
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.ForeColor = System.Drawing.Color.White;
            this.lblTodate.Location = new System.Drawing.Point(464, 19);
            this.lblTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(46, 13);
            this.lblTodate.TabIndex = 9;
            this.lblTodate.Text = "To Date";
            // 
            // cmbCashorParty
            // 
            this.cmbCashorParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashorParty.Location = new System.Drawing.Point(136, 66);
            this.cmbCashorParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashorParty.Name = "cmbCashorParty";
            this.cmbCashorParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashorParty.TabIndex = 4;
            this.cmbCashorParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashorParty_KeyDown);
            // 
            // lblSalesMode
            // 
            this.lblSalesMode.AutoSize = true;
            this.lblSalesMode.ForeColor = System.Drawing.Color.White;
            this.lblSalesMode.Location = new System.Drawing.Point(464, 70);
            this.lblSalesMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesMode.Name = "lblSalesMode";
            this.lblSalesMode.Size = new System.Drawing.Size(63, 13);
            this.lblSalesMode.TabIndex = 15;
            this.lblSalesMode.Text = "Sales Mode";
            // 
            // dgvSiRegister
            // 
            this.dgvSiRegister.AllowUserToAddRows = false;
            this.dgvSiRegister.AllowUserToResizeColumns = false;
            this.dgvSiRegister.AllowUserToResizeRows = false;
            this.dgvSiRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvSiRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSiRegister.ColumnHeadersHeight = 35;
            this.dgvSiRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSiRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtSlno,
            this.dgvtxtVouchertypeName,
            this.dgvTxtVoucherNo,
            this.dgvTxtVoucherDate,
            this.dgvTxtCashOrParty,
            this.dgvTxtBillAmount,
            this.dgvTxtNarration,
            this.dgvTxtCurrency,
            this.dgvTxtQuotationOrOrderNote,
            this.dgvTxtDoneBy,
            this.dgvtxtPos,
            this.dgvtxtsalesMasterId,
            this.ledgerId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSiRegister.EnableHeadersVisualStyles = false;
            this.dgvSiRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSiRegister.Location = new System.Drawing.Point(18, 125);
            this.dgvSiRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSiRegister.MultiSelect = false;
            this.dgvSiRegister.Name = "dgvSiRegister";
            this.dgvSiRegister.ReadOnly = true;
            this.dgvSiRegister.RowHeadersVisible = false;
            this.dgvSiRegister.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSiRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiRegister.Size = new System.Drawing.Size(764, 427);
            this.dgvSiRegister.TabIndex = 1159;
            this.dgvSiRegister.TabStop = false;
            this.dgvSiRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiRegister_CellDoubleClick);
            this.dgvSiRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSiRegister_KeyDown);
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
            this.btnViewDetails.TabIndex = 8;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewDetails_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // cmbVoucherNo
            // 
            this.cmbVoucherNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherNo.Location = new System.Drawing.Point(580, 40);
            this.cmbVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherNo.Name = "cmbVoucherNo";
            this.cmbVoucherNo.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherNo.TabIndex = 3;
            this.cmbVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(464, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1154;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // cmbSalesMode
            // 
            this.cmbSalesMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMode.Items.AddRange(new object[] {
            "All",
            "NA",
            "Against SalesOrder",
            "Against Quotation",
            "Against DeliveryNote"});
            this.cmbSalesMode.Location = new System.Drawing.Point(580, 66);
            this.cmbSalesMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMode.Name = "cmbSalesMode";
            this.cmbSalesMode.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMode.TabIndex = 5;
            this.cmbSalesMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMode_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(21, 70);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1152;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFormDate.Location = new System.Drawing.Point(317, 15);
            this.dtpFormDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFormDate.TabIndex = 1284;
            this.dtpFormDate.ValueChanged += new System.EventHandler(this.dtpFormDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(136, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(761, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1286;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
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
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.Location = new System.Drawing.Point(136, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.SelectedValueChanged += new System.EventHandler(this.cmbVoucherType_SelectedValueChanged);
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.Color.White;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1288;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(582, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(673, 92);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // dgvTxtSlno
            // 
            this.dgvTxtSlno.DataPropertyName = "dgvTxtSlno";
            this.dgvTxtSlno.HeaderText = "Sl No";
            this.dgvTxtSlno.Name = "dgvTxtSlno";
            this.dgvTxtSlno.ReadOnly = true;
            this.dgvTxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVouchertypeName
            // 
            this.dgvtxtVouchertypeName.DataPropertyName = "voucherTypeName";
            this.dgvtxtVouchertypeName.HeaderText = "VoucherName";
            this.dgvtxtVouchertypeName.Name = "dgvtxtVouchertypeName";
            this.dgvtxtVouchertypeName.ReadOnly = true;
            // 
            // dgvTxtVoucherNo
            // 
            this.dgvTxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvTxtVoucherNo.HeaderText = "Voucher No";
            this.dgvTxtVoucherNo.Name = "dgvTxtVoucherNo";
            this.dgvTxtVoucherNo.ReadOnly = true;
            this.dgvTxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtVoucherDate
            // 
            this.dgvTxtVoucherDate.DataPropertyName = "date";
            this.dgvTxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvTxtVoucherDate.Name = "dgvTxtVoucherDate";
            this.dgvTxtVoucherDate.ReadOnly = true;
            this.dgvTxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtCashOrParty
            // 
            this.dgvTxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvTxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvTxtCashOrParty.Name = "dgvTxtCashOrParty";
            this.dgvTxtCashOrParty.ReadOnly = true;
            this.dgvTxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtBillAmount
            // 
            this.dgvTxtBillAmount.DataPropertyName = "grandTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvTxtBillAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTxtBillAmount.HeaderText = "Bill Amount";
            this.dgvTxtBillAmount.Name = "dgvTxtBillAmount";
            this.dgvTxtBillAmount.ReadOnly = true;
            this.dgvTxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtNarration
            // 
            this.dgvTxtNarration.DataPropertyName = "narration";
            this.dgvTxtNarration.HeaderText = "Narration";
            this.dgvTxtNarration.Name = "dgvTxtNarration";
            this.dgvTxtNarration.ReadOnly = true;
            this.dgvTxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtCurrency
            // 
            this.dgvTxtCurrency.DataPropertyName = "currencyName";
            this.dgvTxtCurrency.HeaderText = "Currency";
            this.dgvTxtCurrency.Name = "dgvTxtCurrency";
            this.dgvTxtCurrency.ReadOnly = true;
            this.dgvTxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtQuotationOrOrderNote
            // 
            this.dgvTxtQuotationOrOrderNote.DataPropertyName = "invoiceRefNo";
            this.dgvTxtQuotationOrOrderNote.HeaderText = "Quot / Order Note";
            this.dgvTxtQuotationOrOrderNote.Name = "dgvTxtQuotationOrOrderNote";
            this.dgvTxtQuotationOrOrderNote.ReadOnly = true;
            this.dgvTxtQuotationOrOrderNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtDoneBy
            // 
            this.dgvTxtDoneBy.DataPropertyName = "userName";
            this.dgvTxtDoneBy.HeaderText = "Done By";
            this.dgvTxtDoneBy.Name = "dgvTxtDoneBy";
            this.dgvTxtDoneBy.ReadOnly = true;
            this.dgvTxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPos
            // 
            this.dgvtxtPos.DataPropertyName = "pos";
            this.dgvtxtPos.HeaderText = "POS";
            this.dgvtxtPos.Name = "dgvtxtPos";
            this.dgvtxtPos.ReadOnly = true;
            this.dgvtxtPos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPos.Visible = false;
            // 
            // dgvtxtsalesMasterId
            // 
            this.dgvtxtsalesMasterId.DataPropertyName = "salesMasterId";
            this.dgvtxtsalesMasterId.HeaderText = "dgvtxtsalesMasterId";
            this.dgvtxtsalesMasterId.Name = "dgvtxtsalesMasterId";
            this.dgvtxtsalesMasterId.ReadOnly = true;
            this.dgvtxtsalesMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsalesMasterId.Visible = false;
            // 
            // ledgerId
            // 
            this.ledgerId.DataPropertyName = "ledgerId";
            this.ledgerId.HeaderText = "ledgerId";
            this.ledgerId.Name = "ledgerId";
            this.ledgerId.ReadOnly = true;
            this.ledgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ledgerId.Visible = false;
            // 
            // frmSalesInvoiceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFormDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvSiRegister);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.cmbSalesMode);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.cmbCashorParty);
            this.Controls.Add(this.lblSalesMode);
            this.Controls.Add(this.lblTodate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesInvoiceRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice Register";
            this.Load += new System.EventHandler(this.frmSalesInvoiceRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesInvoiceRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.ComboBox cmbCashorParty;
        private System.Windows.Forms.Label lblSalesMode;
        private System.Windows.Forms.DataGridView dgvSiRegister;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.ComboBox cmbSalesMode;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVouchertypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtQuotationOrOrderNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalesMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledgerId;
    }
}