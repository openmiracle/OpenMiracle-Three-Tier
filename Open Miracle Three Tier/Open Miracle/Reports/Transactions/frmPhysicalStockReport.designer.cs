namespace Open_Miracle
{
    partial class frmPhysicalStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhysicalStockReport));
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPhysicalStockReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPhysicalStockMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPhysicalStockDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtbrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmodelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysicalStockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 38);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(475, 42);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1432;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 41);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1431;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(118, 38);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(202, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(474, 17);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1426;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 17);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1428;
            this.lblFromDate.Text = "From Date";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(20, 68);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1435;
            this.lblProductCode.Text = "Product Code";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvPhysicalStockReport
            // 
            this.dgvPhysicalStockReport.AllowUserToAddRows = false;
            this.dgvPhysicalStockReport.AllowUserToResizeRows = false;
            this.dgvPhysicalStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhysicalStockReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhysicalStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhysicalStockReport.ColumnHeadersHeight = 35;
            this.dgvPhysicalStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhysicalStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.dgvtxtPhysicalStockMasterId,
            this.dgvtxtPhysicalStockDetailsId,
            this.dgvtxtproductCode,
            this.dgvtxtproductName,
            this.dgvtxtbrandName,
            this.dgvtxtsize,
            this.dgvtxtmodelNo,
            this.dgvtxtpurchaseRate,
            this.dgvtxtsalesRate,
            this.dgvtxtmrp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhysicalStockReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhysicalStockReport.EnableHeadersVisualStyles = false;
            this.dgvPhysicalStockReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPhysicalStockReport.Location = new System.Drawing.Point(18, 113);
            this.dgvPhysicalStockReport.Name = "dgvPhysicalStockReport";
            this.dgvPhysicalStockReport.ReadOnly = true;
            this.dgvPhysicalStockReport.RowHeadersVisible = false;
            this.dgvPhysicalStockReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhysicalStockReport.Size = new System.Drawing.Size(763, 449);
            this.dgvPhysicalStockReport.TabIndex = 9;
            this.dgvPhysicalStockReport.TabStop = false;
            this.dgvPhysicalStockReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhysicalStockReport_CellDoubleClick);
            this.dgvPhysicalStockReport.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPhysicalStockReport_RowsAdded);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.DataPropertyName = "slno";
            this.dgvtxtSlno.FillWeight = 50F;
            this.dgvtxtSlno.HeaderText = "Sl No";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.ReadOnly = true;
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlno.Width = 45;
            // 
            // dgvtxtPhysicalStockMasterId
            // 
            this.dgvtxtPhysicalStockMasterId.DataPropertyName = "physicalStockMasterId";
            this.dgvtxtPhysicalStockMasterId.HeaderText = "physicalStockMasterId";
            this.dgvtxtPhysicalStockMasterId.Name = "dgvtxtPhysicalStockMasterId";
            this.dgvtxtPhysicalStockMasterId.ReadOnly = true;
            this.dgvtxtPhysicalStockMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPhysicalStockMasterId.Visible = false;
            // 
            // dgvtxtPhysicalStockDetailsId
            // 
            this.dgvtxtPhysicalStockDetailsId.HeaderText = "physicalStockDetailsId";
            this.dgvtxtPhysicalStockDetailsId.Name = "dgvtxtPhysicalStockDetailsId";
            this.dgvtxtPhysicalStockDetailsId.ReadOnly = true;
            this.dgvtxtPhysicalStockDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPhysicalStockDetailsId.Visible = false;
            // 
            // dgvtxtproductCode
            // 
            this.dgvtxtproductCode.DataPropertyName = "productCode";
            this.dgvtxtproductCode.HeaderText = "Product Code";
            this.dgvtxtproductCode.Name = "dgvtxtproductCode";
            this.dgvtxtproductCode.ReadOnly = true;
            this.dgvtxtproductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductCode.Width = 89;
            // 
            // dgvtxtproductName
            // 
            this.dgvtxtproductName.DataPropertyName = "productName";
            this.dgvtxtproductName.HeaderText = "Product Name";
            this.dgvtxtproductName.Name = "dgvtxtproductName";
            this.dgvtxtproductName.ReadOnly = true;
            this.dgvtxtproductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductName.Width = 90;
            // 
            // dgvtxtbrandName
            // 
            this.dgvtxtbrandName.DataPropertyName = "brandName";
            this.dgvtxtbrandName.HeaderText = "Brand";
            this.dgvtxtbrandName.Name = "dgvtxtbrandName";
            this.dgvtxtbrandName.ReadOnly = true;
            this.dgvtxtbrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtbrandName.Width = 89;
            // 
            // dgvtxtsize
            // 
            this.dgvtxtsize.DataPropertyName = "size";
            this.dgvtxtsize.HeaderText = "Size";
            this.dgvtxtsize.Name = "dgvtxtsize";
            this.dgvtxtsize.ReadOnly = true;
            this.dgvtxtsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsize.Width = 89;
            // 
            // dgvtxtmodelNo
            // 
            this.dgvtxtmodelNo.DataPropertyName = "modelNo";
            this.dgvtxtmodelNo.HeaderText = "Modal No.";
            this.dgvtxtmodelNo.Name = "dgvtxtmodelNo";
            this.dgvtxtmodelNo.ReadOnly = true;
            this.dgvtxtmodelNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmodelNo.Width = 90;
            // 
            // dgvtxtpurchaseRate
            // 
            this.dgvtxtpurchaseRate.DataPropertyName = "purchaseRate";
            this.dgvtxtpurchaseRate.HeaderText = "Purchase Rate";
            this.dgvtxtpurchaseRate.Name = "dgvtxtpurchaseRate";
            this.dgvtxtpurchaseRate.ReadOnly = true;
            this.dgvtxtpurchaseRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpurchaseRate.Width = 89;
            // 
            // dgvtxtsalesRate
            // 
            this.dgvtxtsalesRate.DataPropertyName = "salesRate";
            this.dgvtxtsalesRate.HeaderText = "Sales Rate";
            this.dgvtxtsalesRate.Name = "dgvtxtsalesRate";
            this.dgvtxtsalesRate.ReadOnly = true;
            this.dgvtxtsalesRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsalesRate.Width = 90;
            // 
            // dgvtxtmrp
            // 
            this.dgvtxtmrp.DataPropertyName = "mrp";
            this.dgvtxtmrp.HeaderText = "MRP";
            this.dgvtxtmrp.Name = "dgvtxtmrp";
            this.dgvtxtmrp.ReadOnly = true;
            this.dgvtxtmrp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmrp.Width = 89;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(604, 568);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(298, 13);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 1466;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(118, 13);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(760, 13);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 13);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(20, 93);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1471;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(118, 90);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(202, 20);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(118, 64);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(201, 21);
            this.cmbProductCode.TabIndex = 4;
            this.cmbProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductCode_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(695, 568);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPhysicalStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbProductCode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPhysicalStockReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPhysicalStockReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physical Stock Report";
            this.Load += new System.EventHandler(this.frmPhysicalStockReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhysicalStockReport_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhysicalStockReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPhysicalStockReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPhysicalStockMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPhysicalStockDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtbrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmodelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmrp;
        private System.Windows.Forms.Button btnExport;
    }
}