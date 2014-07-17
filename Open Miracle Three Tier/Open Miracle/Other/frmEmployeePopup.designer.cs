namespace Open_Miracle
{
    partial class frmEmployeePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeePopup));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(115, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
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
            this.btnClear.Location = new System.Drawing.Point(206, 65);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           // this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeName.Location = new System.Drawing.Point(20, 44);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 170;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(115, 40);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeName.TabIndex = 2;
            this.txtEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeName_KeyDown);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeCode.Location = new System.Drawing.Point(20, 19);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeCode.TabIndex = 168;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(115, 15);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeCode.TabIndex = 1;
            this.txtEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeCode_KeyDown);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
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
            this.dgvtxtEmployeeCode,
            this.dgvtxtEmployeeName,
            this.dgvtxtDesignation,
            this.dgvtxtEmployeeId});
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
            this.dgvEmployee.Location = new System.Drawing.Point(18, 98);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(764, 483);
            this.dgvEmployee.TabIndex = 5;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            this.dgvEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployee_DataBindingComplete);
            //this.dgvEmployee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvEmployee_KeyUp);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // dgvtxtEmployeeId
            // 
            this.dgvtxtEmployeeId.DataPropertyName = "employeeId";
            this.dgvtxtEmployeeId.HeaderText = "EmployeeId";
            this.dgvtxtEmployeeId.Name = "dgvtxtEmployeeId";
            this.dgvtxtEmployeeId.ReadOnly = true;
            this.dgvtxtEmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmEmployeePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.dgvEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEmployeePopup";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeePopup_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeePopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployeePopup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeId;
    }
}