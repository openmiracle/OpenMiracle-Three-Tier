namespace Open_Miracle
{
    partial class frmTaxReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTaxReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCessAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.gbxIpOp = new System.Windows.Forms.GroupBox();
            this.rbtnOutput = new System.Windows.Forms.RadioButton();
            this.rbtnInput = new System.Windows.Forms.RadioButton();
            this.gbxBillProd = new System.Windows.Forms.GroupBox();
            this.rbtnProductwise = new System.Windows.Forms.RadioButton();
            this.rbtnBillwise = new System.Windows.Forms.RadioButton();
            this.cmbTypeOfVoucher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxReport)).BeginInit();
            this.gbxIpOp.SuspendLayout();
            this.gbxBillProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1232;
            this.label1.Text = "From Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(480, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1230;
            this.label4.Text = "To Date";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(121, 64);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 2;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1244;
            this.label6.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(480, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1242;
            this.label7.Text = "Voucher Type";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(678, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
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
            this.btnSearch.Location = new System.Drawing.Point(587, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvTaxReport
            // 
            this.dgvTaxReport.AllowUserToAddRows = false;
            this.dgvTaxReport.AllowUserToDeleteRows = false;
            this.dgvTaxReport.AllowUserToResizeColumns = false;
            this.dgvTaxReport.AllowUserToResizeRows = false;
            this.dgvTaxReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaxReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaxReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaxReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaxReport.ColumnHeadersHeight = 35;
            this.dgvTaxReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaxReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtDate,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtBillNo,
            this.dgvtxtItem,
            this.dgvtxtCashParty,
            this.dgvtxtTIN,
            this.dgvtxtCST,
            this.dgvtxtBillAmount,
            this.dgvtxtTax,
            this.dgvtxtTaxAmount,
            this.dgvtxtCessAmount,
            this.dgvtxtTotalAmount,
            this.dgvtxtId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaxReport.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTaxReport.EnableHeadersVisualStyles = false;
            this.dgvTaxReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTaxReport.Location = new System.Drawing.Point(18, 137);
            this.dgvTaxReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvTaxReport.Name = "dgvTaxReport";
            this.dgvTaxReport.ReadOnly = true;
            this.dgvTaxReport.RowHeadersVisible = false;
            this.dgvTaxReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaxReport.Size = new System.Drawing.Size(764, 418);
            this.dgvTaxReport.TabIndex = 1248;
            this.dgvTaxReport.TabStop = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "Date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "Voucher Type";
            this.dgvtxtVoucherType.FillWeight = 110F;
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "Voucher No";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBillNo
            // 
            this.dgvtxtBillNo.DataPropertyName = "Bill No";
            this.dgvtxtBillNo.HeaderText = "Bill No";
            this.dgvtxtBillNo.Name = "dgvtxtBillNo";
            this.dgvtxtBillNo.ReadOnly = true;
            this.dgvtxtBillNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtItem
            // 
            this.dgvtxtItem.DataPropertyName = "Item";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtxtItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtItem.HeaderText = "Item";
            this.dgvtxtItem.Name = "dgvtxtItem";
            this.dgvtxtItem.ReadOnly = true;
            this.dgvtxtItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCashParty
            // 
            this.dgvtxtCashParty.DataPropertyName = "Cash/Party";
            this.dgvtxtCashParty.HeaderText = "Cash/Party";
            this.dgvtxtCashParty.Name = "dgvtxtCashParty";
            this.dgvtxtCashParty.ReadOnly = true;
            this.dgvtxtCashParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTIN
            // 
            this.dgvtxtTIN.DataPropertyName = "TIN";
            this.dgvtxtTIN.HeaderText = "TIN";
            this.dgvtxtTIN.Name = "dgvtxtTIN";
            this.dgvtxtTIN.ReadOnly = true;
            this.dgvtxtTIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCST
            // 
            this.dgvtxtCST.DataPropertyName = "CST";
            this.dgvtxtCST.HeaderText = "CST";
            this.dgvtxtCST.Name = "dgvtxtCST";
            this.dgvtxtCST.ReadOnly = true;
            this.dgvtxtCST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "Bill Amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTax
            // 
            this.dgvtxtTax.DataPropertyName = "Tax %";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvtxtTax.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtTax.HeaderText = "Tax %";
            this.dgvtxtTax.Name = "dgvtxtTax";
            this.dgvtxtTax.ReadOnly = true;
            this.dgvtxtTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTaxAmount
            // 
            this.dgvtxtTaxAmount.DataPropertyName = "Tax Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvtxtTaxAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtTaxAmount.HeaderText = "Tax Amount";
            this.dgvtxtTaxAmount.Name = "dgvtxtTaxAmount";
            this.dgvtxtTaxAmount.ReadOnly = true;
            this.dgvtxtTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCessAmount
            // 
            this.dgvtxtCessAmount.DataPropertyName = "Cess Amount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvtxtCessAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtCessAmount.HeaderText = "Cess Amount";
            this.dgvtxtCessAmount.Name = "dgvtxtCessAmount";
            this.dgvtxtCessAmount.ReadOnly = true;
            this.dgvtxtCessAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "Total Amount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.dgvtxtTotalAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtxtTotalAmount.HeaderText = "Total Amount";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.ReadOnly = true;
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtId
            // 
            this.dgvtxtId.DataPropertyName = "ID";
            this.dgvtxtId.HeaderText = "ID";
            this.dgvtxtId.Name = "dgvtxtId";
            this.dgvtxtId.ReadOnly = true;
            this.dgvtxtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtId.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(596, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1251;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(121, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(186, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(758, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1253;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(587, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(176, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(587, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(193, 21);
            this.cmbVoucherType.TabIndex = 3;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // gbxIpOp
            // 
            this.gbxIpOp.Controls.Add(this.rbtnOutput);
            this.gbxIpOp.Controls.Add(this.rbtnInput);
            this.gbxIpOp.Location = new System.Drawing.Point(121, 89);
            this.gbxIpOp.Name = "gbxIpOp";
            this.gbxIpOp.Size = new System.Drawing.Size(200, 40);
            this.gbxIpOp.TabIndex = 4;
            this.gbxIpOp.TabStop = false;
            // 
            // rbtnOutput
            // 
            this.rbtnOutput.AutoSize = true;
            this.rbtnOutput.ForeColor = System.Drawing.Color.White;
            this.rbtnOutput.Location = new System.Drawing.Point(101, 14);
            this.rbtnOutput.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnOutput.Name = "rbtnOutput";
            this.rbtnOutput.Size = new System.Drawing.Size(57, 17);
            this.rbtnOutput.TabIndex = 1;
            this.rbtnOutput.TabStop = true;
            this.rbtnOutput.Text = "Output";
            this.rbtnOutput.UseVisualStyleBackColor = true;
            this.rbtnOutput.CheckedChanged += new System.EventHandler(this.rbtnOutput_CheckedChanged);
            this.rbtnOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnOutput_KeyDown);
            // 
            // rbtnInput
            // 
            this.rbtnInput.AutoSize = true;
            this.rbtnInput.ForeColor = System.Drawing.Color.White;
            this.rbtnInput.Location = new System.Drawing.Point(17, 14);
            this.rbtnInput.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnInput.Name = "rbtnInput";
            this.rbtnInput.Size = new System.Drawing.Size(49, 17);
            this.rbtnInput.TabIndex = 0;
            this.rbtnInput.TabStop = true;
            this.rbtnInput.Text = "Input";
            this.rbtnInput.UseVisualStyleBackColor = true;
            this.rbtnInput.CheckedChanged += new System.EventHandler(this.rbtnInput_CheckedChanged);
            this.rbtnInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnInput_KeyDown);
            // 
            // gbxBillProd
            // 
            this.gbxBillProd.Controls.Add(this.rbtnProductwise);
            this.gbxBillProd.Controls.Add(this.rbtnBillwise);
            this.gbxBillProd.Location = new System.Drawing.Point(326, 88);
            this.gbxBillProd.Name = "gbxBillProd";
            this.gbxBillProd.Size = new System.Drawing.Size(200, 41);
            this.gbxBillProd.TabIndex = 5;
            this.gbxBillProd.TabStop = false;
            // 
            // rbtnProductwise
            // 
            this.rbtnProductwise.AutoSize = true;
            this.rbtnProductwise.ForeColor = System.Drawing.Color.White;
            this.rbtnProductwise.Location = new System.Drawing.Point(93, 14);
            this.rbtnProductwise.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnProductwise.Name = "rbtnProductwise";
            this.rbtnProductwise.Size = new System.Drawing.Size(83, 17);
            this.rbtnProductwise.TabIndex = 1;
            this.rbtnProductwise.TabStop = true;
            this.rbtnProductwise.Text = "Productwise";
            this.rbtnProductwise.UseVisualStyleBackColor = true;
            this.rbtnProductwise.CheckedChanged += new System.EventHandler(this.rbtnProductwise_CheckedChanged);
            this.rbtnProductwise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnProductwise_KeyDown);
            // 
            // rbtnBillwise
            // 
            this.rbtnBillwise.AutoSize = true;
            this.rbtnBillwise.ForeColor = System.Drawing.Color.White;
            this.rbtnBillwise.Location = new System.Drawing.Point(24, 14);
            this.rbtnBillwise.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnBillwise.Name = "rbtnBillwise";
            this.rbtnBillwise.Size = new System.Drawing.Size(59, 17);
            this.rbtnBillwise.TabIndex = 0;
            this.rbtnBillwise.TabStop = true;
            this.rbtnBillwise.Text = "Billwise";
            this.rbtnBillwise.UseVisualStyleBackColor = true;
            this.rbtnBillwise.CheckedChanged += new System.EventHandler(this.rbtnBillwise_CheckedChanged);
            this.rbtnBillwise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnBillwise_KeyDown);
            // 
            // cmbTypeOfVoucher
            // 
            this.cmbTypeOfVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfVoucher.FormattingEnabled = true;
            this.cmbTypeOfVoucher.Location = new System.Drawing.Point(121, 39);
            this.cmbTypeOfVoucher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTypeOfVoucher.Name = "cmbTypeOfVoucher";
            this.cmbTypeOfVoucher.Size = new System.Drawing.Size(201, 21);
            this.cmbTypeOfVoucher.TabIndex = 1254;
            this.cmbTypeOfVoucher.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfVoucher_SelectedIndexChanged);
            this.cmbTypeOfVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTypeOfVoucher_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1255;
            this.label2.Text = "Type of Voucher ";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(687, 565);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmTaxReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypeOfVoucher);
            this.Controls.Add(this.gbxBillProd);
            this.Controls.Add(this.gbxIpOp);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvTaxReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTaxReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Report";
            this.Load += new System.EventHandler(this.frmTaxReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTaxReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxReport)).EndInit();
            this.gbxIpOp.ResumeLayout(false);
            this.gbxIpOp.PerformLayout();
            this.gbxBillProd.ResumeLayout(false);
            this.gbxBillProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTaxReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.GroupBox gbxIpOp;
        private System.Windows.Forms.RadioButton rbtnOutput;
        private System.Windows.Forms.RadioButton rbtnInput;
        private System.Windows.Forms.GroupBox gbxBillProd;
        private System.Windows.Forms.RadioButton rbtnProductwise;
        private System.Windows.Forms.RadioButton rbtnBillwise;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCST;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCessAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtId;
        private System.Windows.Forms.ComboBox cmbTypeOfVoucher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
    }
}