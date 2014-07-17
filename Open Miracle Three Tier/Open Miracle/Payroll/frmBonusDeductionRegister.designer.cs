namespace Open_Miracle
{
    partial class frmBonusDeductionRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonusDeductionRegister));
            this.dgvBonusDeduction = new System.Windows.Forms.DataGridView();
            this.dgvtxtBonusDeductionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtemployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmpolyeeName = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonusDeduction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBonusDeduction
            // 
            this.dgvBonusDeduction.AllowUserToAddRows = false;
            this.dgvBonusDeduction.AllowUserToDeleteRows = false;
            this.dgvBonusDeduction.AllowUserToResizeColumns = false;
            this.dgvBonusDeduction.AllowUserToResizeRows = false;
            this.dgvBonusDeduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBonusDeduction.BackgroundColor = System.Drawing.Color.White;
            this.dgvBonusDeduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBonusDeduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBonusDeduction.ColumnHeadersHeight = 25;
            this.dgvBonusDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBonusDeduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtBonusDeductionId,
            this.dgvtxtSlNo,
            this.dgvtxtemployeeCode,
            this.dgvtxtEmployeeName,
            this.dgvtxtMonth,
            this.dgvtxtBonus,
            this.dgvtxtDeduction});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBonusDeduction.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBonusDeduction.EnableHeadersVisualStyles = false;
            this.dgvBonusDeduction.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBonusDeduction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvBonusDeduction.Location = new System.Drawing.Point(18, 100);
            this.dgvBonusDeduction.MultiSelect = false;
            this.dgvBonusDeduction.Name = "dgvBonusDeduction";
            this.dgvBonusDeduction.ReadOnly = true;
            this.dgvBonusDeduction.RowHeadersVisible = false;
            this.dgvBonusDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBonusDeduction.Size = new System.Drawing.Size(764, 481);
            this.dgvBonusDeduction.TabIndex = 5;
            this.dgvBonusDeduction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBonusDeduction_CellDoubleClick);
            this.dgvBonusDeduction.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBonusDeduction_DataBindingComplete);
            
            // 
            // dgvtxtBonusDeductionId
            // 
            this.dgvtxtBonusDeductionId.DataPropertyName = "bonusDeductionId";
            this.dgvtxtBonusDeductionId.HeaderText = "BonusDeductionId";
            this.dgvtxtBonusDeductionId.Name = "dgvtxtBonusDeductionId";
            this.dgvtxtBonusDeductionId.ReadOnly = true;
            this.dgvtxtBonusDeductionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBonusDeductionId.Visible = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtemployeeCode
            // 
            this.dgvtxtemployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtemployeeCode.HeaderText = "Employee Code";
            this.dgvtxtemployeeCode.Name = "dgvtxtemployeeCode";
            this.dgvtxtemployeeCode.ReadOnly = true;
            this.dgvtxtemployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployeeName
            // 
            this.dgvtxtEmployeeName.DataPropertyName = "employeeName";
            this.dgvtxtEmployeeName.HeaderText = "Employee Name";
            this.dgvtxtEmployeeName.Name = "dgvtxtEmployeeName";
            this.dgvtxtEmployeeName.ReadOnly = true;
            this.dgvtxtEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtMonth
            // 
            this.dgvtxtMonth.DataPropertyName = "month";
            this.dgvtxtMonth.HeaderText = "Month";
            this.dgvtxtMonth.Name = "dgvtxtMonth";
            this.dgvtxtMonth.ReadOnly = true;
            this.dgvtxtMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBonus
            // 
            this.dgvtxtBonus.DataPropertyName = "bonusAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtBonus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBonus.HeaderText = "Bonus";
            this.dgvtxtBonus.Name = "dgvtxtBonus";
            this.dgvtxtBonus.ReadOnly = true;
            this.dgvtxtBonus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDeduction
            // 
            this.dgvtxtDeduction.DataPropertyName = "deductionAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtDeduction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtDeduction.HeaderText = "Deduction";
            this.dgvtxtDeduction.Name = "dgvtxtDeduction";
            this.dgvtxtDeduction.ReadOnly = true;
            this.dgvtxtDeduction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(128, 16);
            this.cmbEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeName.TabIndex = 0;
            this.cmbEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeName_KeyDown);
            // 
            // lblEmpolyeeName
            // 
            this.lblEmpolyeeName.AutoSize = true;
            this.lblEmpolyeeName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpolyeeName.Location = new System.Drawing.Point(20, 19);
            this.lblEmpolyeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmpolyeeName.Name = "lblEmpolyeeName";
            this.lblEmpolyeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmpolyeeName.TabIndex = 57;
            this.lblEmpolyeeName.Text = "Employee Name";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.Location = new System.Drawing.Point(20, 46);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 59;
            this.lblMonth.Text = "Month";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(128, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(219, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMMMyyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(128, 42);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpMonth.TabIndex = 1;
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // frmBonusDeductionRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbEmployeeName);
            this.Controls.Add(this.lblEmpolyeeName);
            this.Controls.Add(this.dgvBonusDeduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBonusDeductionRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus or Deduction Register";
            this.Load += new System.EventHandler(this.frmBonusDeductionRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBonusDeductionRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonusDeduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblEmpolyeeName;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.DataGridView dgvBonusDeduction;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBonusDeductionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtemployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDeduction;
    }
}