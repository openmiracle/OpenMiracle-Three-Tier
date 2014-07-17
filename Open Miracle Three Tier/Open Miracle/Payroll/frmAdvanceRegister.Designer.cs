namespace Open_Miracle
{
    partial class frmAdvanceRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvanceRegister));
            this.txtAdvanceVoucher = new System.Windows.Forms.TextBox();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.lblAdvanceVoucher = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAdvanceRegister = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFinancialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancePaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanceRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdvanceVoucher
            // 
            this.txtAdvanceVoucher.Location = new System.Drawing.Point(147, 15);
            this.txtAdvanceVoucher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAdvanceVoucher.Name = "txtAdvanceVoucher";
            this.txtAdvanceVoucher.Size = new System.Drawing.Size(200, 20);
            this.txtAdvanceVoucher.TabIndex = 0;
            this.txtAdvanceVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdvanceVoucher_KeyDown);
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryMonth.Location = new System.Drawing.Point(485, 44);
            this.lblSalaryMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(69, 13);
            this.lblSalaryMonth.TabIndex = 47;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // lblAdvanceVoucher
            // 
            this.lblAdvanceVoucher.AutoSize = true;
            this.lblAdvanceVoucher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdvanceVoucher.Location = new System.Drawing.Point(15, 19);
            this.lblAdvanceVoucher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAdvanceVoucher.Name = "lblAdvanceVoucher";
            this.lblAdvanceVoucher.Size = new System.Drawing.Size(113, 13);
            this.lblAdvanceVoucher.TabIndex = 45;
            this.lblAdvanceVoucher.Text = "Advance Voucher No.";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(595, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
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
            this.btnClear.Location = new System.Drawing.Point(686, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvAdvanceRegister
            // 
            this.dgvAdvanceRegister.AllowUserToAddRows = false;
            this.dgvAdvanceRegister.AllowUserToDeleteRows = false;
            this.dgvAdvanceRegister.AllowUserToResizeColumns = false;
            this.dgvAdvanceRegister.AllowUserToResizeRows = false;
            this.dgvAdvanceRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdvanceRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvanceRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvanceRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvanceRegister.ColumnHeadersHeight = 25;
            this.dgvAdvanceRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdvanceRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.dgvtxtFinancialYearId,
            this.AdvancePaymentId,
            this.dgvtxtVoucherName,
            this.dgvtxtVoucherNo,
            this.Column1,
            this.dgvtxtEmployee,
            this.Column3,
            this.Column4,
            this.EmployeeId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdvanceRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdvanceRegister.EnableHeadersVisualStyles = false;
            this.dgvAdvanceRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAdvanceRegister.Location = new System.Drawing.Point(18, 98);
            this.dgvAdvanceRegister.MultiSelect = false;
            this.dgvAdvanceRegister.Name = "dgvAdvanceRegister";
            this.dgvAdvanceRegister.ReadOnly = true;
            this.dgvAdvanceRegister.RowHeadersVisible = false;
            this.dgvAdvanceRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvanceRegister.Size = new System.Drawing.Size(779, 484);
            this.dgvAdvanceRegister.TabIndex = 10;
            this.dgvAdvanceRegister.TabStop = false;
            this.dgvAdvanceRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvanceRegister_CellDoubleClick);
            this.dgvAdvanceRegister.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAdvanceRegister_DataBindingComplete);
            this.dgvAdvanceRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAdvanceRegister_KeyDown);
            
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SLNO";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtFinancialYearId
            // 
            this.dgvtxtFinancialYearId.DataPropertyName = "financialYearId";
            this.dgvtxtFinancialYearId.HeaderText = "FinancialYearId";
            this.dgvtxtFinancialYearId.Name = "dgvtxtFinancialYearId";
            this.dgvtxtFinancialYearId.ReadOnly = true;
            this.dgvtxtFinancialYearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtFinancialYearId.Visible = false;
            // 
            // AdvancePaymentId
            // 
            this.AdvancePaymentId.DataPropertyName = "advancePaymentId";
            this.AdvancePaymentId.HeaderText = "AdvancePaymentId";
            this.AdvancePaymentId.Name = "AdvancePaymentId";
            this.AdvancePaymentId.ReadOnly = true;
            this.AdvancePaymentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AdvancePaymentId.Visible = false;
            // 
            // dgvtxtVoucherName
            // 
            this.dgvtxtVoucherName.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherName.HeaderText = "Voucher Name";
            this.dgvtxtVoucherName.Name = "dgvtxtVoucherName";
            this.dgvtxtVoucherName.ReadOnly = true;
            this.dgvtxtVoucherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "voucherNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "employeeCode";
            this.Column1.HeaderText = "Employee Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployee
            // 
            this.dgvtxtEmployee.DataPropertyName = "employeeName";
            this.dgvtxtEmployee.HeaderText = "Employee";
            this.dgvtxtEmployee.Name = "dgvtxtEmployee";
            this.dgvtxtEmployee.ReadOnly = true;
            this.dgvtxtEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Month";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "amount";
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "employeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmployeeId.Visible = false;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeCode.Location = new System.Drawing.Point(485, 19);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeCode.TabIndex = 57;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(147, 40);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeName.TabIndex = 2;
            this.txtEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeName_KeyDown);
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChequeNo.Location = new System.Drawing.Point(15, 44);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(84, 13);
            this.lblChequeNo.TabIndex = 59;
            this.lblChequeNo.Text = "Employee Name";
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.CustomFormat = "MMMM yyyy";
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(595, 40);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpSalaryMonth.TabIndex = 3;
            this.dtpSalaryMonth.Value = new System.DateTime(2013, 3, 30, 0, 0, 0, 0);
            this.dtpSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalaryMonth_KeyDown);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(595, 15);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeCode.TabIndex = 1;
            this.txtEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeCode_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(15, 69);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 59;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(147, 65);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 4;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // frmAdvanceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(815, 600);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblChequeNo);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.txtAdvanceVoucher);
            this.Controls.Add(this.lblSalaryMonth);
            this.Controls.Add(this.lblAdvanceVoucher);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAdvanceRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAdvanceRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Register";
            this.Activated += new System.EventHandler(this.frmAdvanceRegister_Activated);
            this.Load += new System.EventHandler(this.frmAdvanceRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdvanceRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanceRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdvanceVoucher;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.Label lblAdvanceVoucher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAdvanceRegister;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFinancialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvancePaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
    }
}