namespace Open_Miracle
{
    partial class frmBonusDeductionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonusDeductionReport));
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.Label();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dgvBonusDeductionReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnDeduction = new System.Windows.Forms.RadioButton();
            this.rbtnBonus = new System.Windows.Forms.RadioButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.gbxPDCPayable = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTodate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonusDeductionReport)).BeginInit();
            this.gbxPDCPayable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(758, 13);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(27, 20);
            this.dtpToDate.TabIndex = 456;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(292, 13);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 543;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(584, 37);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 3;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(584, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(675, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtDesignation
            // 
            this.txtDesignation.AutoSize = true;
            this.txtDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDesignation.Location = new System.Drawing.Point(492, 41);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(63, 13);
            this.txtDesignation.TabIndex = 1227;
            this.txtDesignation.Text = "Designation";
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryMonth.Location = new System.Drawing.Point(19, 42);
            this.lblSalaryMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(69, 13);
            this.lblSalaryMonth.TabIndex = 1226;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(492, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1225;
            this.label4.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(19, 17);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1224;
            this.lblFromDate.Text = "From Date";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(114, 63);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 4;
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployee.Location = new System.Drawing.Point(19, 67);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(81, 13);
            this.lblEmployee.TabIndex = 1234;
            this.lblEmployee.Text = "Employee Code";
            // 
            // dgvBonusDeductionReport
            // 
            this.dgvBonusDeductionReport.AllowUserToAddRows = false;
            this.dgvBonusDeductionReport.AllowUserToDeleteRows = false;
            this.dgvBonusDeductionReport.AllowUserToResizeRows = false;
            this.dgvBonusDeductionReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvBonusDeductionReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonusDeductionReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBonusDeductionReport.ColumnHeadersHeight = 25;
            this.dgvBonusDeductionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBonusDeductionReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.amount,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBonusDeductionReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBonusDeductionReport.EnableHeadersVisualStyles = false;
            this.dgvBonusDeductionReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBonusDeductionReport.Location = new System.Drawing.Point(18, 146);
            this.dgvBonusDeductionReport.Name = "dgvBonusDeductionReport";
            this.dgvBonusDeductionReport.ReadOnly = true;
            this.dgvBonusDeductionReport.RowHeadersVisible = false;
            this.dgvBonusDeductionReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonusDeductionReport.Size = new System.Drawing.Size(764, 407);
            this.dgvBonusDeductionReport.TabIndex = 1238;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sl No";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 127;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "date";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 127;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "employeeCode";
            this.Column3.HeaderText = "Employee Code";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 126;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employeeName";
            this.Column4.HeaderText = "Employee";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 127;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 127;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "narration";
            this.Column6.HeaderText = "Naration";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 127;
            // 
            // rbtnDeduction
            // 
            this.rbtnDeduction.AutoSize = true;
            this.rbtnDeduction.ForeColor = System.Drawing.Color.White;
            this.rbtnDeduction.Location = new System.Drawing.Point(78, 15);
            this.rbtnDeduction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnDeduction.Name = "rbtnDeduction";
            this.rbtnDeduction.Size = new System.Drawing.Size(74, 17);
            this.rbtnDeduction.TabIndex = 1;
            this.rbtnDeduction.TabStop = true;
            this.rbtnDeduction.Text = "Deduction";
            this.rbtnDeduction.UseVisualStyleBackColor = true;
            // 
            // rbtnBonus
            // 
            this.rbtnBonus.AutoSize = true;
            this.rbtnBonus.ForeColor = System.Drawing.Color.White;
            this.rbtnBonus.Location = new System.Drawing.Point(17, 15);
            this.rbtnBonus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnBonus.Name = "rbtnBonus";
            this.rbtnBonus.Size = new System.Drawing.Size(55, 17);
            this.rbtnBonus.TabIndex = 0;
            this.rbtnBonus.TabStop = true;
            this.rbtnBonus.Text = "Bonus";
            this.rbtnBonus.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(471, 563);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 1241;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnPrint
            // 
            this.btnPrint.AllowDrop = true;
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(18, 559);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 26);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(582, 559);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 1243;
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.CustomFormat = "MMM-yyyy";
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(114, 38);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpSalaryMonth.TabIndex = 2;
            this.dtpSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalaryMonth_KeyDown);
            // 
            // gbxPDCPayable
            // 
            this.gbxPDCPayable.Controls.Add(this.rbtnDeduction);
            this.gbxPDCPayable.Controls.Add(this.rbtnBonus);
            this.gbxPDCPayable.Location = new System.Drawing.Point(583, 65);
            this.gbxPDCPayable.Margin = new System.Windows.Forms.Padding(5);
            this.gbxPDCPayable.Name = "gbxPDCPayable";
            this.gbxPDCPayable.Size = new System.Drawing.Size(202, 40);
            this.gbxPDCPayable.TabIndex = 5;
            this.gbxPDCPayable.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(114, 13);
            this.txtDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(584, 13);
            this.txtTodate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(182, 20);
            this.txtTodate.TabIndex = 1;
            this.txtTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTodate_KeyDown);
            this.txtTodate.Leave += new System.EventHandler(this.txtTodate_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(114, 559);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmBonusDeductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTodate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.gbxPDCPayable);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvBonusDeductionReport);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.lblSalaryMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBonusDeductionReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus/Deduction Report";
            this.Load += new System.EventHandler(this.frmBonusDeductionReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBonusDeductionReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonusDeductionReport)).EndInit();
            this.gbxPDCPayable.ResumeLayout(false);
            this.gbxPDCPayable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label txtDesignation;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DataGridView dgvBonusDeductionReport;
        private System.Windows.Forms.RadioButton rbtnDeduction;
        private System.Windows.Forms.RadioButton rbtnBonus;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.GroupBox gbxPDCPayable;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnExport;
    }
}