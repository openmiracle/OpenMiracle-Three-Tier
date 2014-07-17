namespace Open_Miracle
{
    partial class frmDailySalaryRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailySalaryRegister));
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblVoucherDateTo = new System.Windows.Forms.Label();
            this.lblVoucherDateFrom = new System.Windows.Forms.Label();
            this.lblSalaryDateTo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSalaryDateFrom = new System.Windows.Forms.Label();
            this.dgvDailySalaryRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvttxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalarydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvouchertypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDailySalaryVoucherMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtledgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpSalaryDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpSalaryDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpVoucherDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpVoucherDateTo = new System.Windows.Forms.DateTimePicker();
            this.txtSalaryDateFrom = new System.Windows.Forms.TextBox();
            this.txtVoucherDateFrom = new System.Windows.Forms.TextBox();
            this.txtSalaryDateTo = new System.Windows.Forms.TextBox();
            this.txtVoucherDateTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalaryRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(15, 67);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 144;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // lblVoucherDateTo
            // 
            this.lblVoucherDateTo.AutoSize = true;
            this.lblVoucherDateTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDateTo.Location = new System.Drawing.Point(451, 42);
            this.lblVoucherDateTo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblVoucherDateTo.Name = "lblVoucherDateTo";
            this.lblVoucherDateTo.Size = new System.Drawing.Size(89, 13);
            this.lblVoucherDateTo.TabIndex = 142;
            this.lblVoucherDateTo.Text = "Voucher Date To";
            // 
            // lblVoucherDateFrom
            // 
            this.lblVoucherDateFrom.AutoSize = true;
            this.lblVoucherDateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDateFrom.Location = new System.Drawing.Point(15, 42);
            this.lblVoucherDateFrom.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblVoucherDateFrom.Name = "lblVoucherDateFrom";
            this.lblVoucherDateFrom.Size = new System.Drawing.Size(99, 13);
            this.lblVoucherDateFrom.TabIndex = 140;
            this.lblVoucherDateFrom.Text = "Voucher Date From";
            // 
            // lblSalaryDateTo
            // 
            this.lblSalaryDateTo.AutoSize = true;
            this.lblSalaryDateTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryDateTo.Location = new System.Drawing.Point(451, 13);
            this.lblSalaryDateTo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblSalaryDateTo.Name = "lblSalaryDateTo";
            this.lblSalaryDateTo.Size = new System.Drawing.Size(78, 13);
            this.lblSalaryDateTo.TabIndex = 138;
            this.lblSalaryDateTo.Text = "Salary Date To";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(125, 63);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(220, 20);
            this.txtVoucherNo.TabIndex = 4;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(125, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
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
            this.btnClear.Location = new System.Drawing.Point(216, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // 
            // lblSalaryDateFrom
            // 
            this.lblSalaryDateFrom.AutoSize = true;
            this.lblSalaryDateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryDateFrom.Location = new System.Drawing.Point(15, 13);
            this.lblSalaryDateFrom.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lblSalaryDateFrom.Name = "lblSalaryDateFrom";
            this.lblSalaryDateFrom.Size = new System.Drawing.Size(88, 13);
            this.lblSalaryDateFrom.TabIndex = 132;
            this.lblSalaryDateFrom.Text = "Salary Date From";
            // 
            // dgvDailySalaryRegister
            // 
            this.dgvDailySalaryRegister.AllowUserToAddRows = false;
            this.dgvDailySalaryRegister.AllowUserToDeleteRows = false;
            this.dgvDailySalaryRegister.AllowUserToResizeColumns = false;
            this.dgvDailySalaryRegister.AllowUserToResizeRows = false;
            this.dgvDailySalaryRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailySalaryRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvDailySalaryRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailySalaryRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailySalaryRegister.ColumnHeadersHeight = 25;
            this.dgvDailySalaryRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDailySalaryRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvttxtDate,
            this.dgvtxtsalarydate,
            this.dgvtxtvouchertypename,
            this.dgvtxtvoucherno,
            this.dgvtxtDailySalaryVoucherMasterId,
            this.dgvtxtledgerId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailySalaryRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDailySalaryRegister.EnableHeadersVisualStyles = false;
            this.dgvDailySalaryRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDailySalaryRegister.Location = new System.Drawing.Point(18, 122);
            this.dgvDailySalaryRegister.MultiSelect = false;
            this.dgvDailySalaryRegister.Name = "dgvDailySalaryRegister";
            this.dgvDailySalaryRegister.ReadOnly = true;
            this.dgvDailySalaryRegister.RowHeadersVisible = false;
            this.dgvDailySalaryRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailySalaryRegister.Size = new System.Drawing.Size(764, 459);
            this.dgvDailySalaryRegister.TabIndex = 8;
            this.dgvDailySalaryRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailySalaryRegister_CellDoubleClick);
            this.dgvDailySalaryRegister.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDailySalaryRegister_DataBindingComplete);
            this.dgvDailySalaryRegister.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDailySalaryRegister_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvttxtDate
            // 
            this.dgvttxtDate.DataPropertyName = "date";
            this.dgvttxtDate.HeaderText = "Voucher Date";
            this.dgvttxtDate.Name = "dgvttxtDate";
            this.dgvttxtDate.ReadOnly = true;
            this.dgvttxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtsalarydate
            // 
            this.dgvtxtsalarydate.DataPropertyName = "salaryDate";
            this.dgvtxtsalarydate.HeaderText = "Salary Date";
            this.dgvtxtsalarydate.Name = "dgvtxtsalarydate";
            this.dgvtxtsalarydate.ReadOnly = true;
            this.dgvtxtsalarydate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtvouchertypename
            // 
            this.dgvtxtvouchertypename.DataPropertyName = "voucherTypeName";
            this.dgvtxtvouchertypename.HeaderText = "Voucher Type";
            this.dgvtxtvouchertypename.Name = "dgvtxtvouchertypename";
            this.dgvtxtvouchertypename.ReadOnly = true;
            this.dgvtxtvouchertypename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtvoucherno
            // 
            this.dgvtxtvoucherno.DataPropertyName = "invoiceNo";
            this.dgvtxtvoucherno.HeaderText = "Voucher No.";
            this.dgvtxtvoucherno.Name = "dgvtxtvoucherno";
            this.dgvtxtvoucherno.ReadOnly = true;
            this.dgvtxtvoucherno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDailySalaryVoucherMasterId
            // 
            this.dgvtxtDailySalaryVoucherMasterId.DataPropertyName = "dailySalaryVoucherMasterId";
            this.dgvtxtDailySalaryVoucherMasterId.HeaderText = "Daily Salary Voucher Master Id";
            this.dgvtxtDailySalaryVoucherMasterId.Name = "dgvtxtDailySalaryVoucherMasterId";
            this.dgvtxtDailySalaryVoucherMasterId.ReadOnly = true;
            this.dgvtxtDailySalaryVoucherMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDailySalaryVoucherMasterId.Visible = false;
            // 
            // dgvtxtledgerId
            // 
            this.dgvtxtledgerId.DataPropertyName = "ledgerId";
            this.dgvtxtledgerId.HeaderText = "LedgerId";
            this.dgvtxtledgerId.Name = "dgvtxtledgerId";
            this.dgvtxtledgerId.ReadOnly = true;
            this.dgvtxtledgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtledgerId.Visible = false;
            // 
            // dtpSalaryDateFrom
            // 
            this.dtpSalaryDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpSalaryDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryDateFrom.Location = new System.Drawing.Point(324, 13);
            this.dtpSalaryDateFrom.Name = "dtpSalaryDateFrom";
            this.dtpSalaryDateFrom.Size = new System.Drawing.Size(21, 20);
            this.dtpSalaryDateFrom.TabIndex = 50;
            this.dtpSalaryDateFrom.ValueChanged += new System.EventHandler(this.dtpSalaryDateFrom_ValueChanged);
            // 
            // dtpSalaryDateTo
            // 
            this.dtpSalaryDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpSalaryDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryDateTo.Location = new System.Drawing.Point(760, 13);
            this.dtpSalaryDateTo.Name = "dtpSalaryDateTo";
            this.dtpSalaryDateTo.Size = new System.Drawing.Size(22, 20);
            this.dtpSalaryDateTo.TabIndex = 51;
            this.dtpSalaryDateTo.ValueChanged += new System.EventHandler(this.dtpSalaryDateTo_ValueChanged);
            // 
            // dtpVoucherDateFrom
            // 
            this.dtpVoucherDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDateFrom.Location = new System.Drawing.Point(324, 38);
            this.dtpVoucherDateFrom.Name = "dtpVoucherDateFrom";
            this.dtpVoucherDateFrom.Size = new System.Drawing.Size(21, 20);
            this.dtpVoucherDateFrom.TabIndex = 53;
            this.dtpVoucherDateFrom.ValueChanged += new System.EventHandler(this.dtpVoucherDateFrom_ValueChanged);
            // 
            // dtpVoucherDateTo
            // 
            this.dtpVoucherDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDateTo.Location = new System.Drawing.Point(760, 38);
            this.dtpVoucherDateTo.Name = "dtpVoucherDateTo";
            this.dtpVoucherDateTo.Size = new System.Drawing.Size(22, 20);
            this.dtpVoucherDateTo.TabIndex = 54;
            this.dtpVoucherDateTo.ValueChanged += new System.EventHandler(this.dtpVoucherDateTo_ValueChanged);
            // 
            // txtSalaryDateFrom
            // 
            this.txtSalaryDateFrom.Location = new System.Drawing.Point(125, 13);
            this.txtSalaryDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSalaryDateFrom.Name = "txtSalaryDateFrom";
            this.txtSalaryDateFrom.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryDateFrom.TabIndex = 0;
            this.txtSalaryDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryDateFrom_KeyDown);
            this.txtSalaryDateFrom.Leave += new System.EventHandler(this.txtSalaryDateFrom_Leave);
            // 
            // txtVoucherDateFrom
            // 
            this.txtVoucherDateFrom.Location = new System.Drawing.Point(125, 38);
            this.txtVoucherDateFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDateFrom.Name = "txtVoucherDateFrom";
            this.txtVoucherDateFrom.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherDateFrom.TabIndex = 2;
            this.txtVoucherDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDateFrom_KeyDown);
            this.txtVoucherDateFrom.Leave += new System.EventHandler(this.txtVoucherDateFrom_Leave);
            // 
            // txtSalaryDateTo
            // 
            this.txtSalaryDateTo.Location = new System.Drawing.Point(561, 13);
            this.txtSalaryDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSalaryDateTo.Name = "txtSalaryDateTo";
            this.txtSalaryDateTo.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryDateTo.TabIndex = 1;
            this.txtSalaryDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryDateTo_KeyDown);
            this.txtSalaryDateTo.Leave += new System.EventHandler(this.txtSalaryDateTo_Leave);
            // 
            // txtVoucherDateTo
            // 
            this.txtVoucherDateTo.Location = new System.Drawing.Point(561, 38);
            this.txtVoucherDateTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDateTo.Name = "txtVoucherDateTo";
            this.txtVoucherDateTo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherDateTo.TabIndex = 3;
            this.txtVoucherDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDateTo_KeyDown);
            this.txtVoucherDateTo.Leave += new System.EventHandler(this.txtVoucherDateTo_Leave);
            // 
            // frmDailySalaryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtVoucherDateTo);
            this.Controls.Add(this.txtSalaryDateTo);
            this.Controls.Add(this.txtVoucherDateFrom);
            this.Controls.Add(this.txtSalaryDateFrom);
            this.Controls.Add(this.dtpVoucherDateTo);
            this.Controls.Add(this.dtpVoucherDateFrom);
            this.Controls.Add(this.dtpSalaryDateTo);
            this.Controls.Add(this.dtpSalaryDateFrom);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVoucherDateTo);
            this.Controls.Add(this.lblVoucherDateFrom);
            this.Controls.Add(this.lblSalaryDateTo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSalaryDateFrom);
            this.Controls.Add(this.dgvDailySalaryRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDailySalaryRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Salary Register";
            this.Activated += new System.EventHandler(this.frmDailySalaryRegister_Activated);
            this.Load += new System.EventHandler(this.frmDailySalaryRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDailySalaryRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalaryRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblVoucherDateTo;
        private System.Windows.Forms.Label lblVoucherDateFrom;
        private System.Windows.Forms.Label lblSalaryDateTo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSalaryDateFrom;
        private System.Windows.Forms.DataGridView dgvDailySalaryRegister;
        private System.Windows.Forms.DateTimePicker dtpSalaryDateFrom;
        private System.Windows.Forms.DateTimePicker dtpSalaryDateTo;
        private System.Windows.Forms.DateTimePicker dtpVoucherDateFrom;
        private System.Windows.Forms.DateTimePicker dtpVoucherDateTo;
        private System.Windows.Forms.TextBox txtSalaryDateFrom;
        private System.Windows.Forms.TextBox txtVoucherDateFrom;
        private System.Windows.Forms.TextBox txtSalaryDateTo;
        private System.Windows.Forms.TextBox txtVoucherDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvttxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalarydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvouchertypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDailySalaryVoucherMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtledgerId;
    }
}