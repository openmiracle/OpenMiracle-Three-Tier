namespace Open_Miracle
{
    partial class frmBillallocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillallocation));
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBillAllocation = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfromdate = new System.Windows.Forms.TextBox();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.txttodate = new System.Windows.Forms.TextBox();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillAllocation)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(580, 38);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 3;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(483, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1351;
            this.label3.Text = "Account Ledger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(483, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1349;
            this.label5.Text = "To Date";
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(115, 38);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountGroup.TabIndex = 2;
            this.cmbAccountGroup.SelectedIndexChanged += new System.EventHandler(this.cmbAccountGroup_SelectedIndexChanged);
            this.cmbAccountGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountGroup_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1347;
            this.label6.Text = "Account Group";
            // 
            // dgvBillAllocation
            // 
            this.dgvBillAllocation.AllowUserToAddRows = false;
            this.dgvBillAllocation.AllowUserToResizeRows = false;
            this.dgvBillAllocation.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillAllocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillAllocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillAllocation.ColumnHeadersHeight = 35;
            this.dgvBillAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.typeOfVoucher,
            this.voucherTypeId,
            this.accountGroupName,
            this.numbr,
            this.VoucherType,
            this.voucherNo,
            this.Column1,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillAllocation.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBillAllocation.EnableHeadersVisualStyles = false;
            this.dgvBillAllocation.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBillAllocation.Location = new System.Drawing.Point(21, 98);
            this.dgvBillAllocation.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvBillAllocation.Name = "dgvBillAllocation";
            this.dgvBillAllocation.ReadOnly = true;
            this.dgvBillAllocation.RowHeadersVisible = false;
            this.dgvBillAllocation.Size = new System.Drawing.Size(761, 479);
            this.dgvBillAllocation.TabIndex = 7;
            this.dgvBillAllocation.TabStop = false;
            this.dgvBillAllocation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillAllocation_CellDoubleClick);
            this.dgvBillAllocation.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBillAllocation_RowsAdded);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.HeaderText = "SlNo";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtslno.Width = 108;
            // 
            // typeOfVoucher
            // 
            this.typeOfVoucher.DataPropertyName = "typeOfVoucher";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.typeOfVoucher.DefaultCellStyle = dataGridViewCellStyle2;
            this.typeOfVoucher.HeaderText = "typeOfVoucher";
            this.typeOfVoucher.Name = "typeOfVoucher";
            this.typeOfVoucher.ReadOnly = true;
            this.typeOfVoucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.typeOfVoucher.Visible = false;
            // 
            // voucherTypeId
            // 
            this.voucherTypeId.DataPropertyName = "voucherTypeId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.voucherTypeId.DefaultCellStyle = dataGridViewCellStyle3;
            this.voucherTypeId.HeaderText = "voucherTypeId";
            this.voucherTypeId.Name = "voucherTypeId";
            this.voucherTypeId.ReadOnly = true;
            this.voucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherTypeId.Visible = false;
            // 
            // accountGroupName
            // 
            this.accountGroupName.DataPropertyName = "accountGroupName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.accountGroupName.DefaultCellStyle = dataGridViewCellStyle4;
            this.accountGroupName.HeaderText = "Account Group";
            this.accountGroupName.Name = "accountGroupName";
            this.accountGroupName.ReadOnly = true;
            this.accountGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountGroupName.Visible = false;
            // 
            // numbr
            // 
            this.numbr.DataPropertyName = "date";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.numbr.DefaultCellStyle = dataGridViewCellStyle5;
            this.numbr.HeaderText = "Date";
            this.numbr.Name = "numbr";
            this.numbr.ReadOnly = true;
            this.numbr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numbr.Width = 109;
            // 
            // VoucherType
            // 
            this.VoucherType.DataPropertyName = "voucherTypeName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.VoucherType.DefaultCellStyle = dataGridViewCellStyle6;
            this.VoucherType.HeaderText = "Voucher Type";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.ReadOnly = true;
            this.VoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherType.Width = 108;
            // 
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.voucherNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.voucherNo.HeaderText = "Voucher No";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Width = 108;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ledgerName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Ledger";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 108;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "debit";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Debit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 109;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "credit";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column5.HeaderText = "Credit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 108;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(115, 65);
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
            this.btnReset.Location = new System.Drawing.Point(208, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(18, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1339;
            this.label8.Text = "From Date";
            // 
            // txtfromdate
            // 
            this.txtfromdate.Location = new System.Drawing.Point(115, 13);
            this.txtfromdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtfromdate.Name = "txtfromdate";
            this.txtfromdate.Size = new System.Drawing.Size(183, 20);
            this.txtfromdate.TabIndex = 0;
            this.txtfromdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfromdate_KeyDown);
            this.txtfromdate.Leave += new System.EventHandler(this.txtfromdate_Leave);
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.CustomFormat = "dd-MMM-YYYY";
            this.dtpfromdate.Location = new System.Drawing.Point(295, 13);
            this.dtpfromdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(20, 20);
            this.dtpfromdate.TabIndex = 1483;
            this.dtpfromdate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpfromdate.ValueChanged += new System.EventHandler(this.dtpfromdate_ValueChanged);
            // 
            // txttodate
            // 
            this.txttodate.Location = new System.Drawing.Point(580, 13);
            this.txttodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txttodate.Name = "txttodate";
            this.txttodate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttodate.Size = new System.Drawing.Size(181, 20);
            this.txttodate.TabIndex = 1;
            this.txttodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttodate_KeyDown);
            this.txttodate.Leave += new System.EventHandler(this.txttodate_Leave);
            // 
            // dtptodate
            // 
            this.dtptodate.CustomFormat = "dd-MMM-YYYY";
            this.dtptodate.Location = new System.Drawing.Point(760, 13);
            this.dtptodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(20, 20);
            this.dtptodate.TabIndex = 1485;
            this.dtptodate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtptodate.ValueChanged += new System.EventHandler(this.dtptodate_ValueChanged);
            // 
            // frmBillallocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txttodate);
            this.Controls.Add(this.dtptodate);
            this.Controls.Add(this.txtfromdate);
            this.Controls.Add(this.dtpfromdate);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvBillAllocation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBillallocation";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Allocation";
            this.Load += new System.EventHandler(this.frmBillallocation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBillallocation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillAllocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBillAllocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfromdate;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.TextBox txttodate;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}