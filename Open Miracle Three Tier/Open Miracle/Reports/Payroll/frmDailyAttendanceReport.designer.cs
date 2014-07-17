namespace Open_Miracle
{
    partial class frmDailyAttendanceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyAttendanceReport));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvDailyAttendanceReport = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyAttendanceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Present",
            "Absent"});
            this.cmbStatus.Location = new System.Drawing.Point(580, 41);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
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
            this.btnReset.Location = new System.Drawing.Point(671, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(125, 40);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 2;
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(472, 44);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1195;
            this.lblStatus.Text = "Status";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployee.Location = new System.Drawing.Point(15, 44);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 1194;
            this.lblEmployee.Text = "Employee";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(580, 15);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 1;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(472, 19);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 1191;
            this.lblDesignation.Text = "Designation";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(16, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1190;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(304, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(22, 20);
            this.dtpDate.TabIndex = 1200;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(592, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvDailyAttendanceReport
            // 
            this.dgvDailyAttendanceReport.AllowUserToAddRows = false;
            this.dgvDailyAttendanceReport.AllowUserToDeleteRows = false;
            this.dgvDailyAttendanceReport.AllowUserToResizeRows = false;
            this.dgvDailyAttendanceReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvDailyAttendanceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyAttendanceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyAttendanceReport.ColumnHeadersHeight = 25;
            this.dgvDailyAttendanceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDailyAttendanceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.dgvtxtEmployeeCode,
            this.dgvtxtEmployee,
            this.dgvtxtDesignation,
            this.dgvtxtAttendanceStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailyAttendanceReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDailyAttendanceReport.EnableHeadersVisualStyles = false;
            this.dgvDailyAttendanceReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDailyAttendanceReport.Location = new System.Drawing.Point(18, 100);
            this.dgvDailyAttendanceReport.Name = "dgvDailyAttendanceReport";
            this.dgvDailyAttendanceReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyAttendanceReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDailyAttendanceReport.RowHeadersVisible = false;
            this.dgvDailyAttendanceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailyAttendanceReport.Size = new System.Drawing.Size(764, 454);
            this.dgvDailyAttendanceReport.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(688, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 152;
            // 
            // dgvtxtEmployeeCode
            // 
            this.dgvtxtEmployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtEmployeeCode.HeaderText = "Employee Code";
            this.dgvtxtEmployeeCode.Name = "dgvtxtEmployeeCode";
            this.dgvtxtEmployeeCode.ReadOnly = true;
            this.dgvtxtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployeeCode.Width = 152;
            // 
            // dgvtxtEmployee
            // 
            this.dgvtxtEmployee.DataPropertyName = "employeeName";
            this.dgvtxtEmployee.HeaderText = "Employee Name";
            this.dgvtxtEmployee.Name = "dgvtxtEmployee";
            this.dgvtxtEmployee.ReadOnly = true;
            this.dgvtxtEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployee.Width = 153;
            // 
            // dgvtxtDesignation
            // 
            this.dgvtxtDesignation.DataPropertyName = "designationName";
            this.dgvtxtDesignation.HeaderText = "Designation";
            this.dgvtxtDesignation.Name = "dgvtxtDesignation";
            this.dgvtxtDesignation.ReadOnly = true;
            this.dgvtxtDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDesignation.Width = 152;
            // 
            // dgvtxtAttendanceStatus
            // 
            this.dgvtxtAttendanceStatus.DataPropertyName = "status";
            this.dgvtxtAttendanceStatus.HeaderText = "Attendance Status";
            this.dgvtxtAttendanceStatus.Name = "dgvtxtAttendanceStatus";
            this.dgvtxtAttendanceStatus.ReadOnly = true;
            this.dgvtxtAttendanceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAttendanceStatus.Width = 152;
            // 
            // frmDailyAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDailyAttendanceReport);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDailyAttendanceReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Attendance Report";
            this.Load += new System.EventHandler(this.frmDailyAttendanceReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDailyAttendanceReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyAttendanceReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvDailyAttendanceReport;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAttendanceStatus;
    }
}