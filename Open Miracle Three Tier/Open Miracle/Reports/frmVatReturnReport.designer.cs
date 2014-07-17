namespace Open_Miracle
{
    partial class frmVatReturnReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatReturnReport));
            this.cmbVouchertype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVatreturn = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalesmasterid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMailingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtbillDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxableAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxttax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnFormat1 = new System.Windows.Forms.RadioButton();
            this.rbtnFormat2 = new System.Windows.Forms.RadioButton();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.cmbTypeofVoucher = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVouchertype
            // 
            this.cmbVouchertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVouchertype.FormattingEnabled = true;
            this.cmbVouchertype.Location = new System.Drawing.Point(580, 38);
            this.cmbVouchertype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVouchertype.Name = "cmbVouchertype";
            this.cmbVouchertype.Size = new System.Drawing.Size(200, 21);
            this.cmbVouchertype.TabIndex = 2;
            this.cmbVouchertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVouchertype_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1243;
            this.label3.Text = "Type of Voucher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1238;
            this.label4.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1240;
            this.label1.Text = "From Date";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
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
            this.btnSearch.Location = new System.Drawing.Point(580, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvVatreturn
            // 
            this.dgvVatreturn.AllowUserToAddRows = false;
            this.dgvVatreturn.AllowUserToResizeColumns = false;
            this.dgvVatreturn.AllowUserToResizeRows = false;
            this.dgvVatreturn.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatreturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVatreturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVatreturn.ColumnHeadersHeight = 30;
            this.dgvVatreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVatreturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.dgvtxtVoucherType,
            this.dgvtxtvoucherName,
            this.dgvtxtsalesmasterid,
            this.dgvtxtInvoiceNo,
            this.dgvtxtDate,
            this.dgvtxtPartyName,
            this.dgvtxtMailingName,
            this.dgvtxtTinNo,
            this.dgvtxtQty,
            this.dgvtxtSalesAmount,
            this.dgvtxtTaxAmount,
            this.dgvtxtCess,
            this.dgvtxtNetAmount,
            this.dgvtxtbillDiscount,
            this.dgvtxtGrandTotal,
            this.dgvtxtTaxName,
            this.dgvtxtTaxableAmount,
            this.dgvtxttax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVatreturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVatreturn.EnableHeadersVisualStyles = false;
            this.dgvVatreturn.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVatreturn.Location = new System.Drawing.Point(18, 119);
            this.dgvVatreturn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvVatreturn.Name = "dgvVatreturn";
            this.dgvVatreturn.ReadOnly = true;
            this.dgvVatreturn.RowHeadersVisible = false;
            this.dgvVatreturn.Size = new System.Drawing.Size(764, 435);
            this.dgvVatreturn.TabIndex = 9;
            this.dgvVatreturn.TabStop = false;
            this.dgvVatreturn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatreturn_CellDoubleClick);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.HeaderText = "Sl No";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.ReadOnly = true;
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlno.Width = 59;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.HeaderText = "VoucherType";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.Visible = false;
            this.dgvtxtVoucherType.Width = 59;
            // 
            // dgvtxtvoucherName
            // 
            this.dgvtxtvoucherName.HeaderText = "VoucherName";
            this.dgvtxtvoucherName.Name = "dgvtxtvoucherName";
            this.dgvtxtvoucherName.ReadOnly = true;
            this.dgvtxtvoucherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvoucherName.Width = 90;
            // 
            // dgvtxtsalesmasterid
            // 
            this.dgvtxtsalesmasterid.HeaderText = "SalesMasterId";
            this.dgvtxtsalesmasterid.Name = "dgvtxtsalesmasterid";
            this.dgvtxtsalesmasterid.ReadOnly = true;
            this.dgvtxtsalesmasterid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsalesmasterid.Visible = false;
            // 
            // dgvtxtInvoiceNo
            // 
            this.dgvtxtInvoiceNo.HeaderText = "Invoice No";
            this.dgvtxtInvoiceNo.Name = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.ReadOnly = true;
            this.dgvtxtInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceNo.Width = 59;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDate.Width = 58;
            // 
            // dgvtxtPartyName
            // 
            this.dgvtxtPartyName.HeaderText = "Party Name";
            this.dgvtxtPartyName.Name = "dgvtxtPartyName";
            this.dgvtxtPartyName.ReadOnly = true;
            this.dgvtxtPartyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPartyName.Width = 59;
            // 
            // dgvtxtMailingName
            // 
            this.dgvtxtMailingName.HeaderText = "Mailing Name";
            this.dgvtxtMailingName.Name = "dgvtxtMailingName";
            this.dgvtxtMailingName.ReadOnly = true;
            this.dgvtxtMailingName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMailingName.Width = 58;
            // 
            // dgvtxtTinNo
            // 
            this.dgvtxtTinNo.HeaderText = "TinNo";
            this.dgvtxtTinNo.Name = "dgvtxtTinNo";
            this.dgvtxtTinNo.ReadOnly = true;
            this.dgvtxtTinNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTinNo.Width = 59;
            // 
            // dgvtxtQty
            // 
            this.dgvtxtQty.HeaderText = "Qty";
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.ReadOnly = true;
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQty.Width = 58;
            // 
            // dgvtxtSalesAmount
            // 
            this.dgvtxtSalesAmount.HeaderText = "Amount";
            this.dgvtxtSalesAmount.Name = "dgvtxtSalesAmount";
            this.dgvtxtSalesAmount.ReadOnly = true;
            this.dgvtxtSalesAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesAmount.Width = 59;
            // 
            // dgvtxtTaxAmount
            // 
            this.dgvtxtTaxAmount.HeaderText = "Tax Amount";
            this.dgvtxtTaxAmount.Name = "dgvtxtTaxAmount";
            this.dgvtxtTaxAmount.ReadOnly = true;
            this.dgvtxtTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxAmount.Width = 58;
            // 
            // dgvtxtCess
            // 
            this.dgvtxtCess.HeaderText = "Cess";
            this.dgvtxtCess.Name = "dgvtxtCess";
            this.dgvtxtCess.ReadOnly = true;
            this.dgvtxtCess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCess.Visible = false;
            // 
            // dgvtxtNetAmount
            // 
            this.dgvtxtNetAmount.HeaderText = "Net Amount";
            this.dgvtxtNetAmount.Name = "dgvtxtNetAmount";
            this.dgvtxtNetAmount.ReadOnly = true;
            this.dgvtxtNetAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNetAmount.Width = 59;
            // 
            // dgvtxtbillDiscount
            // 
            this.dgvtxtbillDiscount.HeaderText = "Adjust";
            this.dgvtxtbillDiscount.Name = "dgvtxtbillDiscount";
            this.dgvtxtbillDiscount.ReadOnly = true;
            this.dgvtxtbillDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtbillDiscount.Width = 58;
            // 
            // dgvtxtGrandTotal
            // 
            this.dgvtxtGrandTotal.HeaderText = "Grand Total";
            this.dgvtxtGrandTotal.Name = "dgvtxtGrandTotal";
            this.dgvtxtGrandTotal.ReadOnly = true;
            this.dgvtxtGrandTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtGrandTotal.Width = 59;
            // 
            // dgvtxtTaxName
            // 
            this.dgvtxtTaxName.HeaderText = "Tax";
            this.dgvtxtTaxName.Name = "dgvtxtTaxName";
            this.dgvtxtTaxName.ReadOnly = true;
            this.dgvtxtTaxName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxName.Visible = false;
            // 
            // dgvtxtTaxableAmount
            // 
            this.dgvtxtTaxableAmount.HeaderText = "Taxable Amount";
            this.dgvtxtTaxableAmount.Name = "dgvtxtTaxableAmount";
            this.dgvtxtTaxableAmount.ReadOnly = true;
            this.dgvtxtTaxableAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxableAmount.Visible = false;
            // 
            // dgvtxttax
            // 
            this.dgvtxttax.HeaderText = "TaxAmount";
            this.dgvtxttax.Name = "dgvtxttax";
            this.dgvtxttax.ReadOnly = true;
            this.dgvtxttax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxttax.Visible = false;
            // 
            // rbtnFormat1
            // 
            this.rbtnFormat1.AutoSize = true;
            this.rbtnFormat1.ForeColor = System.Drawing.Color.White;
            this.rbtnFormat1.Location = new System.Drawing.Point(580, 66);
            this.rbtnFormat1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnFormat1.Name = "rbtnFormat1";
            this.rbtnFormat1.Size = new System.Drawing.Size(66, 17);
            this.rbtnFormat1.TabIndex = 4;
            this.rbtnFormat1.Text = "Format 1";
            this.rbtnFormat1.UseVisualStyleBackColor = true;
            this.rbtnFormat1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnFormat1_KeyDown);
            // 
            // rbtnFormat2
            // 
            this.rbtnFormat2.AutoSize = true;
            this.rbtnFormat2.ForeColor = System.Drawing.Color.White;
            this.rbtnFormat2.Location = new System.Drawing.Point(656, 66);
            this.rbtnFormat2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnFormat2.Name = "rbtnFormat2";
            this.rbtnFormat2.Size = new System.Drawing.Size(66, 17);
            this.rbtnFormat2.TabIndex = 5;
            this.rbtnFormat2.Text = "Format 2";
            this.rbtnFormat2.UseVisualStyleBackColor = true;
            this.rbtnFormat2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnFormat2_KeyDown);
            // 
            // dtpFrmDate
            // 
            this.dtpFrmDate.Location = new System.Drawing.Point(309, 15);
            this.dtpFrmDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFrmDate.Name = "dtpFrmDate";
            this.dtpFrmDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFrmDate.TabIndex = 1466;
            this.dtpFrmDate.ValueChanged += new System.EventHandler(this.dtpFrmDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(129, 15);
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
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(604, 561);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(130, 66);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 3;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(26, 71);
            this.lblTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 1471;
            this.lblTax.Text = "Tax";
            // 
            // cmbTypeofVoucher
            // 
            this.cmbTypeofVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeofVoucher.FormattingEnabled = true;
            this.cmbTypeofVoucher.Location = new System.Drawing.Point(129, 39);
            this.cmbTypeofVoucher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTypeofVoucher.Name = "cmbTypeofVoucher";
            this.cmbTypeofVoucher.Size = new System.Drawing.Size(201, 21);
            this.cmbTypeofVoucher.TabIndex = 1472;
            this.cmbTypeofVoucher.SelectedIndexChanged += new System.EventHandler(this.cmbTypeofVoucher_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(474, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1473;
            this.label7.Text = "Voucher Type";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(695, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmVatReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbTypeofVoucher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvVatreturn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbtnFormat2);
            this.Controls.Add(this.rbtnFormat1);
            this.Controls.Add(this.cmbVouchertype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmVatReturnReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAT Return Report";
            this.Load += new System.EventHandler(this.frmVatReturnReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVatReturnReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVouchertype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVatreturn;
        private System.Windows.Forms.RadioButton rbtnFormat1;
        private System.Windows.Forms.RadioButton rbtnFormat2;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.ComboBox cmbTypeofVoucher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalesmasterid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMailingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTinNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtbillDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxableAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxttax;
        private System.Windows.Forms.Button btnExport;
    }
}