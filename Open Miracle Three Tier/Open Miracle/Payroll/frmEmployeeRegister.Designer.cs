namespace Open_Miracle
{
    partial class frmEmployeeRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeRegister));
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblLabourCardNumber = new System.Windows.Forms.Label();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtLabourCardNumber = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.cmbsalaryType = new System.Windows.Forms.ComboBox();
            this.txtVisaNumber = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblVisaNumber = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblSalaryType = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvtxtDesignation});
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
            this.dgvEmployee.Location = new System.Drawing.Point(18, 147);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.ShowCellToolTips = false;
            this.dgvEmployee.Size = new System.Drawing.Size(764, 432);
            this.dgvEmployee.TabIndex = 25;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            this.dgvEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployee_DataBindingComplete);
            this.dgvEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmployee_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployeeId
            // 
            this.dgvtxtEmployeeId.DataPropertyName = "employeeId";
            this.dgvtxtEmployeeId.HeaderText = "Employee Id";
            this.dgvtxtEmployeeId.Name = "dgvtxtEmployeeId";
            this.dgvtxtEmployeeId.ReadOnly = true;
            this.dgvtxtEmployeeId.Visible = false;
            // 
            // dgvtxtEmployeeCode
            // 
            this.dgvtxtEmployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtEmployeeCode.HeaderText = "Employee Code";
            this.dgvtxtEmployeeCode.Name = "dgvtxtEmployeeCode";
            this.dgvtxtEmployeeCode.ReadOnly = true;
            this.dgvtxtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployeeName
            // 
            this.dgvtxtEmployeeName.DataPropertyName = "employeeName";
            this.dgvtxtEmployeeName.HeaderText = "Employee Name";
            this.dgvtxtEmployeeName.Name = "dgvtxtEmployeeName";
            this.dgvtxtEmployeeName.ReadOnly = true;
            this.dgvtxtEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDesignation
            // 
            this.dgvtxtDesignation.DataPropertyName = "designationName";
            this.dgvtxtDesignation.HeaderText = "Designation";
            this.dgvtxtDesignation.Name = "dgvtxtDesignation";
            this.dgvtxtDesignation.ReadOnly = true;
            this.dgvtxtDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Location = new System.Drawing.Point(124, 66);
            this.txtBankAccountNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBankAccountNumber.TabIndex = 5;
            this.txtBankAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankAccountNumber_KeyDown);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(124, 15);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeCode.TabIndex = 1;
            this.txtEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeCode_KeyDown);
            // 
            // lblLabourCardNumber
            // 
            this.lblLabourCardNumber.AutoSize = true;
            this.lblLabourCardNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLabourCardNumber.Location = new System.Drawing.Point(14, 95);
            this.lblLabourCardNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblLabourCardNumber.Name = "lblLabourCardNumber";
            this.lblLabourCardNumber.Size = new System.Drawing.Size(85, 13);
            this.lblLabourCardNumber.TabIndex = 20;
            this.lblLabourCardNumber.Text = "Labour Card No.";
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.AutoSize = true;
            this.lblBankAccountNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(14, 70);
            this.lblBankAccountNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(73, 13);
            this.lblBankAccountNumber.TabIndex = 19;
            this.lblBankAccountNumber.Text = "Bank A/c No.";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignation.Location = new System.Drawing.Point(14, 44);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 18;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeCode.Location = new System.Drawing.Point(14, 19);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeCode.TabIndex = 16;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // txtLabourCardNumber
            // 
            this.txtLabourCardNumber.Location = new System.Drawing.Point(124, 91);
            this.txtLabourCardNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtLabourCardNumber.Name = "txtLabourCardNumber";
            this.txtLabourCardNumber.Size = new System.Drawing.Size(200, 20);
            this.txtLabourCardNumber.TabIndex = 7;
            this.txtLabourCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLabourCardNumber_KeyDown);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(124, 40);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 3;
            this.cmbDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDesignation_KeyDown);
            // 
            // cmbsalaryType
            // 
            this.cmbsalaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsalaryType.FormattingEnabled = true;
            this.cmbsalaryType.Items.AddRange(new object[] {
            "All",
            "Daily wage",
            "Monthly"});
            this.cmbsalaryType.Location = new System.Drawing.Point(580, 40);
            this.cmbsalaryType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbsalaryType.Name = "cmbsalaryType";
            this.cmbsalaryType.Size = new System.Drawing.Size(200, 21);
            this.cmbsalaryType.TabIndex = 4;
            this.cmbsalaryType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbsalaryType_KeyDown);
            // 
            // txtVisaNumber
            // 
            this.txtVisaNumber.Location = new System.Drawing.Point(580, 91);
            this.txtVisaNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVisaNumber.Name = "txtVisaNumber";
            this.txtVisaNumber.Size = new System.Drawing.Size(200, 20);
            this.txtVisaNumber.TabIndex = 8;
            this.txtVisaNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVisaNumber_KeyDown);
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(580, 66);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPassportNumber.TabIndex = 6;
            this.txtPassportNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassportNumber_KeyDown);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(580, 15);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeName.TabIndex = 2;
            this.txtEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeName_KeyDown);
            // 
            // lblVisaNumber
            // 
            this.lblVisaNumber.AutoSize = true;
            this.lblVisaNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVisaNumber.Location = new System.Drawing.Point(470, 95);
            this.lblVisaNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVisaNumber.Name = "lblVisaNumber";
            this.lblVisaNumber.Size = new System.Drawing.Size(47, 13);
            this.lblVisaNumber.TabIndex = 37;
            this.lblVisaNumber.Text = "Visa No.";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassportNumber.Location = new System.Drawing.Point(470, 70);
            this.lblPassportNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(68, 13);
            this.lblPassportNumber.TabIndex = 36;
            this.lblPassportNumber.Text = "Passport No.";
            // 
            // lblSalaryType
            // 
            this.lblSalaryType.AutoSize = true;
            this.lblSalaryType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryType.Location = new System.Drawing.Point(470, 44);
            this.lblSalaryType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryType.Name = "lblSalaryType";
            this.lblSalaryType.Size = new System.Drawing.Size(63, 13);
            this.lblSalaryType.TabIndex = 35;
            this.lblSalaryType.Text = "Salary Type";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeName.Location = new System.Drawing.Point(470, 19);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 34;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(671, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           // 
            // frmEmployeeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbsalaryType);
            this.Controls.Add(this.txtVisaNumber);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblVisaNumber);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.lblSalaryType);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtLabourCardNumber);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtBankAccountNumber);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.lblLabourCardNumber);
            this.Controls.Add(this.lblBankAccountNumber);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblEmployeeCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Register";
            this.Load += new System.EventHandler(this.frmEmployeeRegister_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEmployeeRegister_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblLabourCardNumber;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.TextBox txtLabourCardNumber;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.ComboBox cmbsalaryType;
        private System.Windows.Forms.TextBox txtVisaNumber;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblVisaNumber;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblSalaryType;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignation;
    }
}




