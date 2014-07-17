namespace Open_Miracle
{
    partial class frmEmployeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeReport));
            this.cmbDesigantion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalaryPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDesigantion
            // 
            this.cmbDesigantion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesigantion.FormattingEnabled = true;
            this.cmbDesigantion.Location = new System.Drawing.Point(125, 10);
            this.cmbDesigantion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbDesigantion.Name = "cmbDesigantion";
            this.cmbDesigantion.Size = new System.Drawing.Size(200, 21);
            this.cmbDesigantion.TabIndex = 0;
            this.cmbDesigantion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesigantion_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(478, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1001;
            this.label4.Text = "Employee Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Designation";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(586, 10);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "inActive"});
            this.cmbStatus.Location = new System.Drawing.Point(125, 36);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1003;
            this.label3.Text = "Status";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(586, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
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
            this.btnReset.Location = new System.Drawing.Point(677, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(609, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeight = 25;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtEmployeeId,
            this.dgvtxtEmployeeCode,
            this.dgvtxtEmployeeName,
            this.dgvtxtDesignation,
            this.dgvtxtSalaryPackage,
            this.dgvtxtPhone,
            this.dgvtxtMobile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEmployee.Location = new System.Drawing.Point(18, 66);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(764, 491);
            this.dgvEmployee.TabIndex = 6;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 110;
            // 
            // dgvtxtEmployeeId
            // 
            this.dgvtxtEmployeeId.DataPropertyName = "employeeId";
            this.dgvtxtEmployeeId.HeaderText = "employeeId";
            this.dgvtxtEmployeeId.Name = "dgvtxtEmployeeId";
            this.dgvtxtEmployeeId.ReadOnly = true;
            this.dgvtxtEmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployeeId.Visible = false;
            // 
            // dgvtxtEmployeeCode
            // 
            this.dgvtxtEmployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtEmployeeCode.HeaderText = "Employee Code";
            this.dgvtxtEmployeeCode.Name = "dgvtxtEmployeeCode";
            this.dgvtxtEmployeeCode.ReadOnly = true;
            this.dgvtxtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployeeCode.Width = 109;
            // 
            // dgvtxtEmployeeName
            // 
            this.dgvtxtEmployeeName.DataPropertyName = "employeeName";
            this.dgvtxtEmployeeName.HeaderText = "Employee Name";
            this.dgvtxtEmployeeName.Name = "dgvtxtEmployeeName";
            this.dgvtxtEmployeeName.ReadOnly = true;
            this.dgvtxtEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployeeName.Width = 110;
            // 
            // dgvtxtDesignation
            // 
            this.dgvtxtDesignation.DataPropertyName = "designationName";
            this.dgvtxtDesignation.HeaderText = "Designation";
            this.dgvtxtDesignation.Name = "dgvtxtDesignation";
            this.dgvtxtDesignation.ReadOnly = true;
            this.dgvtxtDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDesignation.Width = 109;
            // 
            // dgvtxtSalaryPackage
            // 
            this.dgvtxtSalaryPackage.DataPropertyName = "salaryPackageName";
            this.dgvtxtSalaryPackage.HeaderText = "Salary Package";
            this.dgvtxtSalaryPackage.Name = "dgvtxtSalaryPackage";
            this.dgvtxtSalaryPackage.ReadOnly = true;
            this.dgvtxtSalaryPackage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalaryPackage.Width = 110;
            // 
            // dgvtxtPhone
            // 
            this.dgvtxtPhone.DataPropertyName = "phoneNumber";
            this.dgvtxtPhone.HeaderText = "Phone No";
            this.dgvtxtPhone.Name = "dgvtxtPhone";
            this.dgvtxtPhone.ReadOnly = true;
            this.dgvtxtPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPhone.Width = 109;
            // 
            // dgvtxtMobile
            // 
            this.dgvtxtMobile.DataPropertyName = "mobileNumber";
            this.dgvtxtMobile.HeaderText = "Mobile No";
            this.dgvtxtMobile.Name = "dgvtxtMobile";
            this.dgvtxtMobile.ReadOnly = true;
            this.dgvtxtMobile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMobile.Width = 110;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(702, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmEmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbDesigantion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.frmEmployeeReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployeeReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDesigantion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalaryPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMobile;
        private System.Windows.Forms.Button btnExport;
    }
}