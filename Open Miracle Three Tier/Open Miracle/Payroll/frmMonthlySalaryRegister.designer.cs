namespace Open_Miracle
{
    partial class frmMonthlySalaryRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlySalaryRegister));
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.lblVoucherDateTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblVoucherDateFrom = new System.Windows.Forms.Label();
            this.dgvMonthlySalaryRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFinancialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalaryVoucherMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmonthlySalaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashBankAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCashBankAC = new System.Windows.Forms.ComboBox();
            this.lblCashBankAC = new System.Windows.Forms.Label();
            this.dtpVoucherDateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtVoucherDateFrom = new System.Windows.Forms.TextBox();
            this.txtVoucherDateTo = new System.Windows.Forms.TextBox();
            this.dtpVoucherDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.cmbVoucherTypeName = new System.Windows.Forms.ComboBox();
            this.lblVoucherType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalaryRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.MaxLength = 15;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(474, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 165;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryMonth.Location = new System.Drawing.Point(20, 44);
            this.lblSalaryMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(69, 13);
            this.lblSalaryMonth.TabIndex = 164;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // lblVoucherDateTo
            // 
            this.lblVoucherDateTo.AutoSize = true;
            this.lblVoucherDateTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDateTo.Location = new System.Drawing.Point(474, 19);
            this.lblVoucherDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherDateTo.Name = "lblVoucherDateTo";
            this.lblVoucherDateTo.Size = new System.Drawing.Size(89, 13);
            this.lblVoucherDateTo.TabIndex = 163;
            this.lblVoucherDateTo.Text = "Voucher Date To";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(671, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblVoucherDateFrom
            // 
            this.lblVoucherDateFrom.AutoSize = true;
            this.lblVoucherDateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDateFrom.Location = new System.Drawing.Point(20, 19);
            this.lblVoucherDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherDateFrom.Name = "lblVoucherDateFrom";
            this.lblVoucherDateFrom.Size = new System.Drawing.Size(99, 13);
            this.lblVoucherDateFrom.TabIndex = 159;
            this.lblVoucherDateFrom.Text = "Voucher Date From";
            // 
            // dgvMonthlySalaryRegister
            // 
            this.dgvMonthlySalaryRegister.AllowUserToAddRows = false;
            this.dgvMonthlySalaryRegister.AllowUserToDeleteRows = false;
            this.dgvMonthlySalaryRegister.AllowUserToResizeColumns = false;
            this.dgvMonthlySalaryRegister.AllowUserToResizeRows = false;
            this.dgvMonthlySalaryRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlySalaryRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthlySalaryRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalaryRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlySalaryRegister.ColumnHeadersHeight = 25;
            this.dgvMonthlySalaryRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonthlySalaryRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtFinancialYearId,
            this.dgvtxtMonth,
            this.dgvtxtSalaryVoucherMasterID,
            this.dgvtxtmonthlySalaryId,
            this.dgvtxtDate,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherType,
            this.dgvtxtInvoiceNo,
            this.dgvtxtCashBankAC,
            this.dgvtxtLedgerId,
            this.dgvtxtAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlySalaryRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonthlySalaryRegister.EnableHeadersVisualStyles = false;
            this.dgvMonthlySalaryRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMonthlySalaryRegister.Location = new System.Drawing.Point(18, 123);
            this.dgvMonthlySalaryRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvMonthlySalaryRegister.MultiSelect = false;
            this.dgvMonthlySalaryRegister.Name = "dgvMonthlySalaryRegister";
            this.dgvMonthlySalaryRegister.ReadOnly = true;
            this.dgvMonthlySalaryRegister.RowHeadersVisible = false;
            this.dgvMonthlySalaryRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlySalaryRegister.Size = new System.Drawing.Size(764, 483);
            this.dgvMonthlySalaryRegister.TabIndex = 9;
            this.dgvMonthlySalaryRegister.TabStop = false;
            this.dgvMonthlySalaryRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonthlySalaryRegister_CellDoubleClick);
           this.dgvMonthlySalaryRegister.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvMonthlySalaryRegister_KeyUp);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Sl No";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtFinancialYearId
            // 
            this.dgvtxtFinancialYearId.DataPropertyName = "financialYearId";
            this.dgvtxtFinancialYearId.HeaderText = "Financial Year Id";
            this.dgvtxtFinancialYearId.Name = "dgvtxtFinancialYearId";
            this.dgvtxtFinancialYearId.ReadOnly = true;
            this.dgvtxtFinancialYearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtFinancialYearId.Visible = false;
            // 
            // dgvtxtMonth
            // 
            this.dgvtxtMonth.DataPropertyName = "month";
            this.dgvtxtMonth.HeaderText = "Month";
            this.dgvtxtMonth.Name = "dgvtxtMonth";
            this.dgvtxtMonth.ReadOnly = true;
            this.dgvtxtMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMonth.Visible = false;
            // 
            // dgvtxtSalaryVoucherMasterID
            // 
            this.dgvtxtSalaryVoucherMasterID.DataPropertyName = "salaryVoucherMasterId";
            this.dgvtxtSalaryVoucherMasterID.HeaderText = "SalaryVoucherMasterID";
            this.dgvtxtSalaryVoucherMasterID.Name = "dgvtxtSalaryVoucherMasterID";
            this.dgvtxtSalaryVoucherMasterID.ReadOnly = true;
            this.dgvtxtSalaryVoucherMasterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalaryVoucherMasterID.Visible = false;
            // 
            // dgvtxtmonthlySalaryId
            // 
            this.dgvtxtmonthlySalaryId.DataPropertyName = "salaryVoucherMasterId";
            this.dgvtxtmonthlySalaryId.HeaderText = "MonthlySalaryId";
            this.dgvtxtmonthlySalaryId.Name = "dgvtxtmonthlySalaryId";
            this.dgvtxtmonthlySalaryId.ReadOnly = true;
            this.dgvtxtmonthlySalaryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmonthlySalaryId.Visible = false;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No.";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtInvoiceNo
            // 
            this.dgvtxtInvoiceNo.DataPropertyName = "voucherNo";
            this.dgvtxtInvoiceNo.HeaderText = "Invoice No";
            this.dgvtxtInvoiceNo.Name = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.ReadOnly = true;
            this.dgvtxtInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceNo.Visible = false;
            // 
            // dgvtxtCashBankAC
            // 
            this.dgvtxtCashBankAC.DataPropertyName = "ledgerName";
            this.dgvtxtCashBankAC.HeaderText = "Cash/Bank a/c";
            this.dgvtxtCashBankAC.Name = "dgvtxtCashBankAC";
            this.dgvtxtCashBankAC.ReadOnly = true;
            this.dgvtxtCashBankAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "LedgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbCashBankAC
            // 
            this.cmbCashBankAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashBankAC.FormattingEnabled = true;
            this.cmbCashBankAC.Location = new System.Drawing.Point(130, 65);
            this.cmbCashBankAC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashBankAC.Name = "cmbCashBankAC";
            this.cmbCashBankAC.Size = new System.Drawing.Size(200, 21);
            this.cmbCashBankAC.TabIndex = 4;
            this.cmbCashBankAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashBankAC_KeyDown);
             // 
            // lblCashBankAC
            // 
            this.lblCashBankAC.AutoSize = true;
            this.lblCashBankAC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashBankAC.Location = new System.Drawing.Point(20, 69);
            this.lblCashBankAC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashBankAC.Name = "lblCashBankAC";
            this.lblCashBankAC.Size = new System.Drawing.Size(81, 13);
            this.lblCashBankAC.TabIndex = 172;
            this.lblCashBankAC.Text = "Cash/Bank a/c";
            // 
            // dtpVoucherDateFrom
            // 
            this.dtpVoucherDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDateFrom.Location = new System.Drawing.Point(308, 15);
            this.dtpVoucherDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpVoucherDateFrom.Name = "dtpVoucherDateFrom";
            this.dtpVoucherDateFrom.Size = new System.Drawing.Size(22, 20);
            this.dtpVoucherDateFrom.TabIndex = 174;
            this.dtpVoucherDateFrom.TabStop = false;
            this.dtpVoucherDateFrom.ValueChanged += new System.EventHandler(this.dtpVoucherDateFrom_ValueChanged);
            // 
            // txtVoucherDateFrom
            // 
            this.txtVoucherDateFrom.Location = new System.Drawing.Point(130, 15);
            this.txtVoucherDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDateFrom.Name = "txtVoucherDateFrom";
            this.txtVoucherDateFrom.Size = new System.Drawing.Size(179, 20);
            this.txtVoucherDateFrom.TabIndex = 0;
            this.txtVoucherDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDateFrom_KeyDown);
            this.txtVoucherDateFrom.Leave += new System.EventHandler(this.txtVoucherDateFrom_Leave);
            // 
            // txtVoucherDateTo
            // 
            this.txtVoucherDateTo.Location = new System.Drawing.Point(580, 15);
            this.txtVoucherDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDateTo.Name = "txtVoucherDateTo";
            this.txtVoucherDateTo.Size = new System.Drawing.Size(179, 20);
            this.txtVoucherDateTo.TabIndex = 1;
            this.txtVoucherDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDateTo_KeyDown);
            this.txtVoucherDateTo.Leave += new System.EventHandler(this.txtVoucherDateTo_Leave);
            // 
            // dtpVoucherDateTo
            // 
            this.dtpVoucherDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDateTo.Location = new System.Drawing.Point(757, 15);
            this.dtpVoucherDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpVoucherDateTo.Name = "dtpVoucherDateTo";
            this.dtpVoucherDateTo.Size = new System.Drawing.Size(23, 20);
            this.dtpVoucherDateTo.TabIndex = 176;
            this.dtpVoucherDateTo.TabStop = false;
            this.dtpVoucherDateTo.ValueChanged += new System.EventHandler(this.dtpVoucherDateTo_ValueChanged);
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.CustomFormat = "MMMM yyyy";
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(130, 40);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpSalaryMonth.TabIndex = 2;
            this.dtpSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalaryMonth_KeyDown);
            // 
            // cmbVoucherTypeName
            // 
            this.cmbVoucherTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherTypeName.FormattingEnabled = true;
            this.cmbVoucherTypeName.Location = new System.Drawing.Point(580, 65);
            this.cmbVoucherTypeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherTypeName.Name = "cmbVoucherTypeName";
            this.cmbVoucherTypeName.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherTypeName.TabIndex = 5;
            this.cmbVoucherTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherTypeName_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(474, 69);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 178;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // frmMonthlySalaryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherTypeName);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.txtVoucherDateTo);
            this.Controls.Add(this.dtpVoucherDateTo);
            this.Controls.Add(this.txtVoucherDateFrom);
            this.Controls.Add(this.dtpVoucherDateFrom);
            this.Controls.Add(this.cmbCashBankAC);
            this.Controls.Add(this.lblCashBankAC);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblSalaryMonth);
            this.Controls.Add(this.lblVoucherDateTo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblVoucherDateFrom);
            this.Controls.Add(this.dgvMonthlySalaryRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMonthlySalaryRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Salary Register";
            this.Load += new System.EventHandler(this.frmMonthlySalaryRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonthlySalaryRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalaryRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.Label lblVoucherDateTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblVoucherDateFrom;
        private System.Windows.Forms.DataGridView dgvMonthlySalaryRegister;
        private System.Windows.Forms.ComboBox cmbCashBankAC;
        private System.Windows.Forms.Label lblCashBankAC;
        private System.Windows.Forms.DateTimePicker dtpVoucherDateFrom;
        private System.Windows.Forms.TextBox txtVoucherDateFrom;
        private System.Windows.Forms.TextBox txtVoucherDateTo;
        private System.Windows.Forms.DateTimePicker dtpVoucherDateTo;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.ComboBox cmbVoucherTypeName;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFinancialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalaryVoucherMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmonthlySalaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashBankAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}