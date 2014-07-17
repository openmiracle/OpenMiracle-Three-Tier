namespace Open_Miracle
{
    partial class frmMonthlySalaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlySalaryReport));
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvMonthlySalary = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtSalaryMonth = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(306, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1210;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(578, 40);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeCode.TabIndex = 3;
            this.cmbEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeCode_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(578, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(669, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(127, 40);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 2;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(470, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1205;
            this.label3.Text = "Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1204;
            this.label5.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(470, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1202;
            this.label4.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1201;
            this.label2.Text = "From Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(752, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(26, 20);
            this.dtpToDate.TabIndex = 1211;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1212;
            this.label6.Text = "Salary Month";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(20, 556);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvMonthlySalary
            // 
            this.dgvMonthlySalary.AllowUserToAddRows = false;
            this.dgvMonthlySalary.AllowUserToDeleteRows = false;
            this.dgvMonthlySalary.AllowUserToResizeRows = false;
            this.dgvMonthlySalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthlySalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlySalary.ColumnHeadersHeight = 25;
            this.dgvMonthlySalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonthlySalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column1,
            this.Column2,
            this.Column3,
            this.dgvtxtTotalAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlySalary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlySalary.EnableHeadersVisualStyles = false;
            this.dgvMonthlySalary.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMonthlySalary.Location = new System.Drawing.Point(18, 99);
            this.dgvMonthlySalary.Name = "dgvMonthlySalary";
            this.dgvMonthlySalary.ReadOnly = true;
            this.dgvMonthlySalary.RowHeadersVisible = false;
            this.dgvMonthlySalary.Size = new System.Drawing.Size(764, 451);
            this.dgvMonthlySalary.TabIndex = 8;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "SlNo";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 151;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "employeeCode";
            this.Column1.HeaderText = "Employee Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 151;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "employeeName";
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 151;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "salaryMonth";
            this.Column3.HeaderText = "Salary Month";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 151;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "totalAmount";
            this.dgvtxtTotalAmount.HeaderText = "Amount";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.ReadOnly = true;
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTotalAmount.Width = 151;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(474, 569);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1218;
            this.label7.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(582, 565);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 1219;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.CustomFormat = "MMM-yyyy";
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(306, 66);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(21, 20);
            this.dtpSalaryMonth.TabIndex = 1220;
            this.dtpSalaryMonth.ValueChanged += new System.EventHandler(this.dtpSalaryMonth_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(180, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(578, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtSalaryMonth
            // 
            this.txtSalaryMonth.Location = new System.Drawing.Point(127, 66);
            this.txtSalaryMonth.Margin = new System.Windows.Forms.Padding(5);
            this.txtSalaryMonth.Name = "txtSalaryMonth";
            this.txtSalaryMonth.Size = new System.Drawing.Size(180, 20);
            this.txtSalaryMonth.TabIndex = 4;
            this.txtSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryMonth_KeyDown);
            this.txtSalaryMonth.Leave += new System.EventHandler(this.txtSalaryMonth_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(119, 557);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMonthlySalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtSalaryMonth);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvMonthlySalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cmbEmployeeCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMonthlySalaryReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Salary Report";
            this.Load += new System.EventHandler(this.frmMonthlySalaryReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonthlySalaryReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvMonthlySalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtSalaryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
        private System.Windows.Forms.Button btnExport;
    }
}