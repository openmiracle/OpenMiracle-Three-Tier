namespace Open_Miracle
{
    partial class frmRejectionOutReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRejectionOutReport));
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaterialReceiptNo = new System.Windows.Forms.ComboBox();
            this.dgvRejectionOutReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectionOutMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmaterialReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmaterialReceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectionOutReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(472, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 1494;
            this.label9.Text = "Voucher No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1492;
            this.label3.Text = "Product Code";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(676, 121);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
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
            this.btnSearch.Location = new System.Drawing.Point(579, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1488;
            this.label1.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(126, 66);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 4;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(579, 66);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 5;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(472, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 1485;
            this.label8.Text = "MaterialReceiptNo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(21, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1484;
            this.label6.Text = "Cash / Party";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(126, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.SelectedValueChanged += new System.EventHandler(this.cmbCashOrParty_SelectedValueChanged);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1479;
            this.label4.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1481;
            this.label7.Text = "From Date";
            // 
            // cmbMaterialReceiptNo
            // 
            this.cmbMaterialReceiptNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialReceiptNo.FormattingEnabled = true;
            this.cmbMaterialReceiptNo.Location = new System.Drawing.Point(579, 40);
            this.cmbMaterialReceiptNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbMaterialReceiptNo.Name = "cmbMaterialReceiptNo";
            this.cmbMaterialReceiptNo.Size = new System.Drawing.Size(200, 21);
            this.cmbMaterialReceiptNo.TabIndex = 3;
            this.cmbMaterialReceiptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaterialReceiptNo_KeyDown);
            // 
            // dgvRejectionOutReport
            // 
            this.dgvRejectionOutReport.AllowUserToAddRows = false;
            this.dgvRejectionOutReport.AllowUserToDeleteRows = false;
            this.dgvRejectionOutReport.AllowUserToResizeRows = false;
            this.dgvRejectionOutReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvRejectionOutReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRejectionOutReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRejectionOutReport.ColumnHeadersHeight = 25;
            this.dgvRejectionOutReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRejectionOutReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column6,
            this.dgvtxtproductName,
            this.Column5,
            this.Column4,
            this.rejectionOutMasterId,
            this.dgvtxtmaterialReceiptNo,
            this.dgvtxtmaterialReceiptMasterId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRejectionOutReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRejectionOutReport.EnableHeadersVisualStyles = false;
            this.dgvRejectionOutReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRejectionOutReport.Location = new System.Drawing.Point(15, 151);
            this.dgvRejectionOutReport.Name = "dgvRejectionOutReport";
            this.dgvRejectionOutReport.ReadOnly = true;
            this.dgvRejectionOutReport.RowHeadersVisible = false;
            this.dgvRejectionOutReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRejectionOutReport.Size = new System.Drawing.Size(764, 406);
            this.dgvRejectionOutReport.TabIndex = 11;
            this.dgvRejectionOutReport.TabStop = false;
            this.dgvRejectionOutReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRejectionOutReport_CellDoubleClick);
            this.dgvRejectionOutReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRejectionOutReport_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(600, 563);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(306, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFromDate.TabIndex = 57635;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(126, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(758, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 6789;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(579, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(126, 92);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 6;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(472, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1504;
            this.label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(579, 91);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 7;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(691, 563);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SL.NO";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 109;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 109;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "Voucher Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 108;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 109;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ledgerName";
            this.Column6.HeaderText = "CashOrParty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 109;
            // 
            // dgvtxtproductName
            // 
            this.dgvtxtproductName.DataPropertyName = "productName";
            this.dgvtxtproductName.HeaderText = "ProductName";
            this.dgvtxtproductName.Name = "dgvtxtproductName";
            this.dgvtxtproductName.ReadOnly = true;
            this.dgvtxtproductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductName.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "userName";
            this.Column5.HeaderText = "Done By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 109;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Total Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 108;
            // 
            // rejectionOutMasterId
            // 
            this.rejectionOutMasterId.DataPropertyName = "rejectionOutMasterId";
            this.rejectionOutMasterId.HeaderText = "RejectionOutMasterId";
            this.rejectionOutMasterId.Name = "rejectionOutMasterId";
            this.rejectionOutMasterId.ReadOnly = true;
            this.rejectionOutMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rejectionOutMasterId.Visible = false;
            // 
            // dgvtxtmaterialReceiptNo
            // 
            this.dgvtxtmaterialReceiptNo.DataPropertyName = "materialReceiptNo";
            this.dgvtxtmaterialReceiptNo.HeaderText = "MaterialReceiptNo";
            this.dgvtxtmaterialReceiptNo.Name = "dgvtxtmaterialReceiptNo";
            this.dgvtxtmaterialReceiptNo.ReadOnly = true;
            this.dgvtxtmaterialReceiptNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmaterialReceiptNo.Visible = false;
            // 
            // dgvtxtmaterialReceiptMasterId
            // 
            this.dgvtxtmaterialReceiptMasterId.DataPropertyName = "materialReceiptMasterId";
            this.dgvtxtmaterialReceiptMasterId.HeaderText = "MaterialReceiptMasterId";
            this.dgvtxtmaterialReceiptMasterId.Name = "dgvtxtmaterialReceiptMasterId";
            this.dgvtxtmaterialReceiptMasterId.ReadOnly = true;
            this.dgvtxtmaterialReceiptMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmaterialReceiptMasterId.Visible = false;
            // 
            // frmRejectionOutReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvRejectionOutReport);
            this.Controls.Add(this.cmbMaterialReceiptNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmRejectionOutReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejection Out Report";
            this.Load += new System.EventHandler(this.frmRejectionOutReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRejectionOutReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectionOutReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaterialReceiptNo;
        private System.Windows.Forms.DataGridView dgvRejectionOutReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectionOutMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmaterialReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmaterialReceiptMasterId;
    }
}