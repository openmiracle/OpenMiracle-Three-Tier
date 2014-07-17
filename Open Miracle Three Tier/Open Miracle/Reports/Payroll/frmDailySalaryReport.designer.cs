namespace Open_Miracle
{
    partial class frmDailySalaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailySalaryReport));
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDailySalary = new System.Windows.Forms.DataGridView();
            this.SlNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(473, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 1095;
            this.label13.Text = "To Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(17, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1093;
            this.label10.Text = "From Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1091;
            this.label7.Text = "Employee Code";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(583, 15);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 1;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(473, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1089;
            this.label3.Text = "Designation";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(306, 41);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1294;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(760, 41);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1295;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1296;
            this.label1.Text = "Status";
            this.label1.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "paid"});
            this.cmbStatus.Location = new System.Drawing.Point(127, 66);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.Visible = false;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(127, 15);
            this.cmbEmployeeCode.Margin = new System.Windows.Forms.Padding(5);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeCode.TabIndex = 0;
            this.cmbEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeCode_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(674, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
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
            this.btnSearch.Location = new System.Drawing.Point(583, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvDailySalary
            // 
            this.dgvDailySalary.AllowUserToAddRows = false;
            this.dgvDailySalary.AllowUserToDeleteRows = false;
            this.dgvDailySalary.AllowUserToResizeRows = false;
            this.dgvDailySalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvDailySalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailySalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailySalary.ColumnHeadersHeight = 35;
            this.dgvDailySalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDailySalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNO,
            this.employeeId,
            this.employeeCode,
            this.employeeName,
            this.designationName,
            this.voucherType,
            this.voucherNo,
            this.date,
            this.amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailySalary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDailySalary.EnableHeadersVisualStyles = false;
            this.dgvDailySalary.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDailySalary.Location = new System.Drawing.Point(18, 97);
            this.dgvDailySalary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvDailySalary.MultiSelect = false;
            this.dgvDailySalary.Name = "dgvDailySalary";
            this.dgvDailySalary.ReadOnly = true;
            this.dgvDailySalary.RowHeadersVisible = false;
            this.dgvDailySalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailySalary.Size = new System.Drawing.Size(764, 456);
            this.dgvDailySalary.TabIndex = 1302;
            // 
            // SlNO
            // 
            this.SlNO.DataPropertyName = "SlNo";
            this.SlNO.HeaderText = "SlNo";
            this.SlNO.Name = "SlNO";
            this.SlNO.ReadOnly = true;
            this.SlNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNO.Width = 95;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "employeeId";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeId.Visible = false;
            // 
            // employeeCode
            // 
            this.employeeCode.DataPropertyName = "employeeCode";
            this.employeeCode.HeaderText = "Employee Code";
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.ReadOnly = true;
            this.employeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeCode.Width = 95;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employeeName";
            this.employeeName.HeaderText = "Employee Name";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeName.Width = 95;
            // 
            // designationName
            // 
            this.designationName.DataPropertyName = "designationName";
            this.designationName.HeaderText = "Designation";
            this.designationName.Name = "designationName";
            this.designationName.ReadOnly = true;
            this.designationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.designationName.Width = 95;
            // 
            // voucherType
            // 
            this.voucherType.DataPropertyName = "voucherTypeName";
            this.voucherType.HeaderText = "Voucher Type";
            this.voucherType.Name = "voucherType";
            this.voucherType.ReadOnly = true;
            this.voucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherType.Width = 95;
            // 
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            this.voucherNo.HeaderText = "Voucher No";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Width = 95;
            // 
            // date
            // 
            this.date.DataPropertyName = "salaryDate";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 95;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "wage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 95;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(612, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 41);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(180, 20);
            this.txtFromDate.TabIndex = 2;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(583, 41);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(703, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDailySalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDailySalary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbEmployeeCode);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDailySalaryReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Salary Report";
            this.Load += new System.EventHandler(this.frmDailySalaryReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDailySalaryReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDailySalary;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button btnExport;
    }
}