namespace Open_Miracle
{
    partial class frmProductVsBatchReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductVsBatchReport));
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProductBatch = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(475, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1376;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1378;
            this.lblFromDate.Text = "From Date";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatchNo.Location = new System.Drawing.Point(20, 96);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(52, 13);
            this.lblBatchNo.TabIndex = 1394;
            this.lblBatchNo.Text = "Batch No";
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Location = new System.Drawing.Point(120, 92);
            this.cmbBatchNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(200, 21);
            this.cmbBatchNo.TabIndex = 6;
            this.cmbBatchNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatchNo_KeyDown);
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(120, 66);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 4;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(20, 70);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 1391;
            this.lblProductGroup.Text = "Product Group";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1390;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(120, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(475, 69);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1397;
            this.lblProductCode.Text = "Product Code";
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(580, 65);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(200, 21);
            this.cmbProductCode.TabIndex = 5;
            this.cmbProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductCode_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(475, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1395;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProductBatch
            // 
            this.dgvProductBatch.AllowUserToAddRows = false;
            this.dgvProductBatch.AllowUserToDeleteRows = false;
            this.dgvProductBatch.AllowUserToResizeRows = false;
            this.dgvProductBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductBatch.ColumnHeadersHeight = 25;
            this.dgvProductBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.VoucherType,
            this.VoucherNo,
            this.ProductCode,
            this.ProductName,
            this.Date,
            this.BatchNo,
            this.Unit,
            this.Inward,
            this.Outward});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductBatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductBatch.EnableHeadersVisualStyles = false;
            this.dgvProductBatch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductBatch.Location = new System.Drawing.Point(18, 125);
            this.dgvProductBatch.Name = "dgvProductBatch";
            this.dgvProductBatch.ReadOnly = true;
            this.dgvProductBatch.RowHeadersVisible = false;
            this.dgvProductBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductBatch.Size = new System.Drawing.Size(764, 429);
            this.dgvProductBatch.TabIndex = 1401;
            this.dgvProductBatch.TabStop = false;
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNo.Width = 76;
            // 
            // VoucherType
            // 
            this.VoucherType.DataPropertyName = "VoucherTypeName";
            this.VoucherType.HeaderText = "VoucherType";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.ReadOnly = true;
            this.VoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherType.Width = 76;
            // 
            // VoucherNo
            // 
            this.VoucherNo.DataPropertyName = "VoucherNo";
            this.VoucherNo.HeaderText = "VoucherNo";
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.ReadOnly = true;
            this.VoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherNo.Width = 76;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductCode.Width = 76;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductName.Width = 76;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 77;
            // 
            // BatchNo
            // 
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.HeaderText = "BatchNo";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            this.BatchNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BatchNo.Width = 76;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "unitName";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Unit.Width = 76;
            // 
            // Inward
            // 
            this.Inward.DataPropertyName = "inwardQty";
            this.Inward.HeaderText = "Inward";
            this.Inward.Name = "Inward";
            this.Inward.ReadOnly = true;
            this.Inward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Inward.Width = 76;
            // 
            // Outward
            // 
            this.Outward.DataPropertyName = "outwardQty";
            this.Outward.HeaderText = "Outward";
            this.Outward.Name = "Outward";
            this.Outward.ReadOnly = true;
            this.Outward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Outward.Width = 76;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(601, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1466;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Location = new System.Drawing.Point(761, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(692, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmProductVsBatchReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvProductBatch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.cmbProductCode);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.cmbBatchNo);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductVsBatchReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Vs Batch Report";
            this.Load += new System.EventHandler(this.frmProductVsBatchReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductVsBatchReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProductBatch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outward;
        private System.Windows.Forms.Button btnExport;
    }
}