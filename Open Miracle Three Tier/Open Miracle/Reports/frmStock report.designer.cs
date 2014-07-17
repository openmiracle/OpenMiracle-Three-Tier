namespace Open_Miracle
{
    partial class frmStockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockReport));
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductgroup = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStockReport = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(572, 19);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 1;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1266;
            this.label6.Text = "Brand";
            // 
            // cmbProductgroup
            // 
            this.cmbProductgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductgroup.FormattingEnabled = true;
            this.cmbProductgroup.Location = new System.Drawing.Point(135, 15);
            this.cmbProductgroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductgroup.Name = "cmbProductgroup";
            this.cmbProductgroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductgroup.TabIndex = 0;
            this.cmbProductgroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductgroup_KeyDown);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(135, 41);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(200, 21);
            this.cmbBrand.TabIndex = 2;
            this.cmbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBrand_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(469, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1261;
            this.label4.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1260;
            this.label8.Text = "Product Group";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(572, 45);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 3;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1269;
            this.label2.Text = "Model No";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(135, 93);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(200, 21);
            this.cmbModel.TabIndex = 6;
            this.cmbModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModel_KeyDown);
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.FormattingEnabled = true;
            this.cmbRack.Location = new System.Drawing.Point(572, 71);
            this.cmbRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 5;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1272;
            this.label3.Text = "Go down";
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.FormattingEnabled = true;
            this.cmbGodown.Location = new System.Drawing.Point(135, 67);
            this.cmbGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 4;
            this.cmbGodown.SelectedIndexChanged += new System.EventHandler(this.cmbGodown_SelectedIndexChanged);
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1275;
            this.label7.Text = "Product Code";
            // 
            // dgvStockReport
            // 
            this.dgvStockReport.AllowUserToAddRows = false;
            this.dgvStockReport.AllowUserToDeleteRows = false;
            this.dgvStockReport.AllowUserToResizeRows = false;
            this.dgvStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockReport.CausesValidation = false;
            this.dgvStockReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockReport.ColumnHeadersHeight = 35;
            this.dgvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.productCode,
            this.productName,
            this.dgvtxtBatchNo,
            this.brandName,
            this.unitName,
            this.rate,
            this.salesRate,
            this.Stock,
            this.stockvalue,
            this.productId});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockReport.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStockReport.EnableHeadersVisualStyles = false;
            this.dgvStockReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStockReport.Location = new System.Drawing.Point(21, 179);
            this.dgvStockReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvStockReport.Name = "dgvStockReport";
            this.dgvStockReport.ReadOnly = true;
            this.dgvStockReport.RowHeadersVisible = false;
            this.dgvStockReport.Size = new System.Drawing.Size(753, 341);
            this.dgvStockReport.TabIndex = 1277;
            this.dgvStockReport.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(573, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(664, 146);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 27);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(18, 526);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(469, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 1282;
            this.label9.Text = "Tax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(469, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 1283;
            this.label10.Text = "Rack";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(469, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 1284;
            this.label11.Text = "Product Name";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(553, 537);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(39, 16);
            this.lbltotal.TabIndex = 1285;
            this.lbltotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(617, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(157, 20);
            this.txtTotal.TabIndex = 1287;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(572, 96);
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(200, 20);
            this.txtproductName.TabIndex = 7;
            this.txtproductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproductName_KeyDown);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(135, 118);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 8;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(109, 526);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(468, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1288;
            this.label1.Text = "Batch";
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(572, 120);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(200, 20);
            this.txtBatchName.TabIndex = 9;
            this.txtBatchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchName_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SL.NO";
            this.Col.HeaderText = "Sl.No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 40;
            // 
            // productCode
            // 
            this.productCode.DataPropertyName = "productCode";
            this.productCode.HeaderText = "Product Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productCode.Width = 60;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productName.DefaultCellStyle = dataGridViewCellStyle2;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productName.Width = 83;
            // 
            // dgvtxtBatchNo
            // 
            this.dgvtxtBatchNo.DataPropertyName = "batchNo";
            this.dgvtxtBatchNo.HeaderText = "BatchNo";
            this.dgvtxtBatchNo.Name = "dgvtxtBatchNo";
            this.dgvtxtBatchNo.ReadOnly = true;
            this.dgvtxtBatchNo.Width = 70;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "brandName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.brandName.DefaultCellStyle = dataGridViewCellStyle3;
            this.brandName.HeaderText = "Brand";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            this.brandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.brandName.Width = 83;
            // 
            // unitName
            // 
            this.unitName.DataPropertyName = "unitName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unitName.DefaultCellStyle = dataGridViewCellStyle4;
            this.unitName.HeaderText = "Unit";
            this.unitName.Name = "unitName";
            this.unitName.ReadOnly = true;
            this.unitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitName.Width = 84;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "rate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.rate.DefaultCellStyle = dataGridViewCellStyle5;
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rate.Width = 83;
            // 
            // salesRate
            // 
            this.salesRate.DataPropertyName = "salesRate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.salesRate.DefaultCellStyle = dataGridViewCellStyle6;
            this.salesRate.HeaderText = "Sales Rate";
            this.salesRate.Name = "salesRate";
            this.salesRate.ReadOnly = true;
            this.salesRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.salesRate.Width = 83;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle7;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Stock.Width = 84;
            // 
            // stockvalue
            // 
            this.stockvalue.DataPropertyName = "stockvalue";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.stockvalue.DefaultCellStyle = dataGridViewCellStyle8;
            this.stockvalue.HeaderText = "Stock value";
            this.stockvalue.Name = "stockvalue";
            this.stockvalue.ReadOnly = true;
            this.stockvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stockvalue.Width = 83;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "productId";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Visible = false;
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtproductName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dgvStockReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGodown);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProductgroup);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStockReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.frmStockReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductgroup;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStockReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;

    }
}