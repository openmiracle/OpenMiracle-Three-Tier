namespace Open_Miracle
{
    partial class frmSalaryPackageRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryPackageRegister));
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.dgvSalaryPackageRegister = new System.Windows.Forms.DataGridView();
            this.dgvTxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPackagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtsalaryPackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtSalaryPackageDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackageRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(129, 15);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(200, 20);
            this.txtPackageName.TabIndex = 0;
            this.txtPackageName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPackageName_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(470, 19);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 149;
            this.lblStatus.Text = "Active";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(671, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPackageName.Location = new System.Drawing.Point(20, 19);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(81, 13);
            this.lblPackageName.TabIndex = 145;
            this.lblPackageName.Text = "Package Name";
            // 
            // dgvSalaryPackageRegister
            // 
            this.dgvSalaryPackageRegister.AllowUserToAddRows = false;
            this.dgvSalaryPackageRegister.AllowUserToDeleteRows = false;
            this.dgvSalaryPackageRegister.AllowUserToResizeColumns = false;
            this.dgvSalaryPackageRegister.AllowUserToResizeRows = false;
            this.dgvSalaryPackageRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryPackageRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaryPackageRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryPackageRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryPackageRegister.ColumnHeadersHeight = 25;
            this.dgvSalaryPackageRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalaryPackageRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtSlNo,
            this.dgvTxtPackagename,
            this.dgvtxtActive,
            this.dgvTxtAmount,
            this.dgvTxtsalaryPackageId,
            this.dgvTxtSalaryPackageDetailsId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryPackageRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryPackageRegister.EnableHeadersVisualStyles = false;
            this.dgvSalaryPackageRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalaryPackageRegister.Location = new System.Drawing.Point(18, 72);
            this.dgvSalaryPackageRegister.MultiSelect = false;
            this.dgvSalaryPackageRegister.Name = "dgvSalaryPackageRegister";
            this.dgvSalaryPackageRegister.ReadOnly = true;
            this.dgvSalaryPackageRegister.RowHeadersVisible = false;
            this.dgvSalaryPackageRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryPackageRegister.Size = new System.Drawing.Size(764, 511);
            this.dgvSalaryPackageRegister.TabIndex = 7;
            this.dgvSalaryPackageRegister.TabStop = false;
            this.dgvSalaryPackageRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryPackageRegister_CellDoubleClick);
            this.dgvSalaryPackageRegister.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSalaryPackageRegister_DataBindingComplete);
            this.dgvSalaryPackageRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalaryPackageRegister_KeyDown);
            this.dgvSalaryPackageRegister.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvSalaryPackageRegister_KeyUp);
            // 
            // dgvTxtSlNo
            // 
            this.dgvTxtSlNo.DataPropertyName = "SLNO";
            this.dgvTxtSlNo.HeaderText = "Sl No";
            this.dgvTxtSlNo.Name = "dgvTxtSlNo";
            this.dgvTxtSlNo.ReadOnly = true;
            this.dgvTxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtPackagename
            // 
            this.dgvTxtPackagename.DataPropertyName = "salaryPackageName";
            this.dgvTxtPackagename.HeaderText = "Package Name";
            this.dgvTxtPackagename.Name = "dgvTxtPackagename";
            this.dgvTxtPackagename.ReadOnly = true;
            this.dgvTxtPackagename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtActive
            // 
            this.dgvtxtActive.DataPropertyName = "isactive";
            this.dgvtxtActive.HeaderText = "Active";
            this.dgvtxtActive.Name = "dgvtxtActive";
            this.dgvtxtActive.ReadOnly = true;
            this.dgvtxtActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtAmount
            // 
            this.dgvTxtAmount.DataPropertyName = "totalAmount";
            this.dgvTxtAmount.HeaderText = "Amount";
            this.dgvTxtAmount.Name = "dgvTxtAmount";
            this.dgvTxtAmount.ReadOnly = true;
            this.dgvTxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtsalaryPackageId
            // 
            this.dgvTxtsalaryPackageId.DataPropertyName = "salaryPackageId";
            this.dgvTxtsalaryPackageId.HeaderText = "Salary Package Id";
            this.dgvTxtsalaryPackageId.Name = "dgvTxtsalaryPackageId";
            this.dgvTxtsalaryPackageId.ReadOnly = true;
            this.dgvTxtsalaryPackageId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTxtsalaryPackageId.Visible = false;
            // 
            // dgvTxtSalaryPackageDetailsId
            // 
            this.dgvTxtSalaryPackageDetailsId.DataPropertyName = "salarypackageDetailsid";
            this.dgvTxtSalaryPackageDetailsId.HeaderText = "Salary package Details Id";
            this.dgvTxtSalaryPackageDetailsId.Name = "dgvTxtSalaryPackageDetailsId";
            this.dgvTxtSalaryPackageDetailsId.ReadOnly = true;
            this.dgvTxtSalaryPackageDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTxtSalaryPackageDetailsId.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbStatus.Location = new System.Drawing.Point(580, 15);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // frmSalaryPackageRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.dgvSalaryPackageRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalaryPackageRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Package Register";
            this.Activated += new System.EventHandler(this.frmSalaryPackageRegister_Activated);
            this.Load += new System.EventHandler(this.frmSalaryPackageRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalaryPackageRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackageRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.DataGridView dgvSalaryPackageRegister;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPackagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtsalaryPackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtSalaryPackageDetailsId;
    }
}