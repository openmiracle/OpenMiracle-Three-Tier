namespace Open_Miracle
{
    partial class frmEmployeeAddressBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAddressBook));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvEmployeeAddressBook = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAddressBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(583, 35);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(473, 39);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhone.Location = new System.Drawing.Point(473, 14);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 67;
            this.lblPhone.Text = "Phone";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMobile.Location = new System.Drawing.Point(15, 40);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(5);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 62;
            this.lblMobile.Text = "Mobile";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployee.Location = new System.Drawing.Point(15, 14);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(81, 13);
            this.lblEmployee.TabIndex = 61;
            this.lblEmployee.Text = "Employee Code";
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
            this.btnReset.Location = new System.Drawing.Point(674, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(125, 10);
            this.cmbEmployeeCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeCode.TabIndex = 0;
            this.cmbEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeCode_KeyDown);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(125, 36);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 20);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(583, 10);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // dgvEmployeeAddressBook
            // 
            this.dgvEmployeeAddressBook.AllowUserToAddRows = false;
            this.dgvEmployeeAddressBook.AllowUserToDeleteRows = false;
            this.dgvEmployeeAddressBook.AllowUserToResizeRows = false;
            this.dgvEmployeeAddressBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeAddressBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeAddressBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeAddressBook.ColumnHeadersHeight = 35;
            this.dgvEmployeeAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeAddressBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.EmployeeId,
            this.EmployeeCode,
            this.Employee,
            this.Designation,
            this.Phone,
            this.Mobile,
            this.Email,
            this.Address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeAddressBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeAddressBook.EnableHeadersVisualStyles = false;
            this.dgvEmployeeAddressBook.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEmployeeAddressBook.Location = new System.Drawing.Point(18, 97);
            this.dgvEmployeeAddressBook.MultiSelect = false;
            this.dgvEmployeeAddressBook.Name = "dgvEmployeeAddressBook";
            this.dgvEmployeeAddressBook.ReadOnly = true;
            this.dgvEmployeeAddressBook.RowHeadersVisible = false;
            this.dgvEmployeeAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeAddressBook.Size = new System.Drawing.Size(764, 457);
            this.dgvEmployeeAddressBook.TabIndex = 7;
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNo.Width = 95;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "employeeId";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmployeeId.Visible = false;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "employeeCode";
            this.EmployeeCode.HeaderText = "Employee Code";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            this.EmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EmployeeCode.Width = 96;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "employeeName";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employee.Width = 95;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "designationName";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Designation.Width = 95;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phoneNumber";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Phone.Width = 95;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "mobileNumber";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mobile.Width = 96;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Width = 95;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 95;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(607, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(697, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmEmployeeAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvEmployeeAddressBook);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.cmbEmployeeCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeAddressBook";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Address Book";
            this.Load += new System.EventHandler(this.frmEmployeeAddressBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployeeAddressBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAddressBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvEmployeeAddressBook;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button btnExport;
    }
}