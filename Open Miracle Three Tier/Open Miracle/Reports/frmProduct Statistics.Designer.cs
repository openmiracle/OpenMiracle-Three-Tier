namespace Open_Miracle
{
    partial class frmProductStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductStatistics));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvProductStatistics = new System.Windows.Forms.DataGridView();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.cmbModelNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxProductList = new System.Windows.Forms.GroupBox();
            this.rbtnUnused = new System.Windows.Forms.RadioButton();
            this.rbtnReorderLevel = new System.Windows.Forms.RadioButton();
            this.rbtnSlowMovings = new System.Windows.Forms.RadioButton();
            this.rbtnMinimumLevel = new System.Windows.Forms.RadioButton();
            this.rbtnFastMovings = new System.Windows.Forms.RadioButton();
            this.rbtnMaximumLevel = new System.Windows.Forms.RadioButton();
            this.rbtnNegativeStock = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatistics)).BeginInit();
            this.gbxProductList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            this.btnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyUp);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(612, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyUp);
            // 
            // dgvProductStatistics
            // 
            this.dgvProductStatistics.AllowUserToAddRows = false;
            this.dgvProductStatistics.AllowUserToDeleteRows = false;
            this.dgvProductStatistics.AllowUserToResizeRows = false;
            this.dgvProductStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductStatistics.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvProductStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductStatistics.ColumnHeadersHeight = 35;
            this.dgvProductStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.numbr,
            this.Column1,
            this.dgvtxtBatchNo,
            this.Column2,
            this.unitName,
            this.Column4,
            this.Column5,
            this.Column3,
            this.stockLevel,
            this.rowId,
            this.dgvtxtproductId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductStatistics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductStatistics.EnableHeadersVisualStyles = false;
            this.dgvProductStatistics.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductStatistics.Location = new System.Drawing.Point(23, 214);
            this.dgvProductStatistics.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvProductStatistics.Name = "dgvProductStatistics";
            this.dgvProductStatistics.ReadOnly = true;
            this.dgvProductStatistics.RowHeadersVisible = false;
            this.dgvProductStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductStatistics.Size = new System.Drawing.Size(759, 340);
            this.dgvProductStatistics.TabIndex = 10;
            this.dgvProductStatistics.TabStop = false;
            this.dgvProductStatistics.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductStatistics_RowsAdded);
            this.dgvProductStatistics.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductStatistics_KeyDown);
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(580, 157);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 4;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1258;
            this.label6.Text = "Model No";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(134, 131);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 1;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // cmbModelNo
            // 
            this.cmbModelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNo.FormattingEnabled = true;
            this.cmbModelNo.Location = new System.Drawing.Point(134, 157);
            this.cmbModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelNo.Name = "cmbModelNo";
            this.cmbModelNo.Size = new System.Drawing.Size(200, 21);
            this.cmbModelNo.TabIndex = 3;
            this.cmbModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(472, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1253;
            this.label5.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(580, 131);
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
            this.label4.Location = new System.Drawing.Point(472, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1251;
            this.label4.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1250;
            this.label8.Text = "Product Group";
            // 
            // gbxProductList
            // 
            this.gbxProductList.Controls.Add(this.rbtnUnused);
            this.gbxProductList.Controls.Add(this.rbtnReorderLevel);
            this.gbxProductList.Controls.Add(this.rbtnSlowMovings);
            this.gbxProductList.Controls.Add(this.rbtnMinimumLevel);
            this.gbxProductList.Controls.Add(this.rbtnFastMovings);
            this.gbxProductList.Controls.Add(this.rbtnMaximumLevel);
            this.gbxProductList.Controls.Add(this.rbtnNegativeStock);
            this.gbxProductList.ForeColor = System.Drawing.Color.White;
            this.gbxProductList.Location = new System.Drawing.Point(18, 19);
            this.gbxProductList.Name = "gbxProductList";
            this.gbxProductList.Size = new System.Drawing.Size(764, 104);
            this.gbxProductList.TabIndex = 0;
            this.gbxProductList.TabStop = false;
            this.gbxProductList.Text = "Product List";
            // 
            // rbtnUnused
            // 
            this.rbtnUnused.AutoSize = true;
            this.rbtnUnused.Location = new System.Drawing.Point(263, 48);
            this.rbtnUnused.Name = "rbtnUnused";
            this.rbtnUnused.Size = new System.Drawing.Size(62, 17);
            this.rbtnUnused.TabIndex = 4;
            this.rbtnUnused.TabStop = true;
            this.rbtnUnused.Text = "Unused";
            this.rbtnUnused.UseVisualStyleBackColor = true;
            // 
            // rbtnReorderLevel
            // 
            this.rbtnReorderLevel.AutoSize = true;
            this.rbtnReorderLevel.Location = new System.Drawing.Point(512, 22);
            this.rbtnReorderLevel.Name = "rbtnReorderLevel";
            this.rbtnReorderLevel.Size = new System.Drawing.Size(92, 17);
            this.rbtnReorderLevel.TabIndex = 2;
            this.rbtnReorderLevel.TabStop = true;
            this.rbtnReorderLevel.Text = "Reorder Level";
            this.rbtnReorderLevel.UseVisualStyleBackColor = true;
            // 
            // rbtnSlowMovings
            // 
            this.rbtnSlowMovings.AutoSize = true;
            this.rbtnSlowMovings.Location = new System.Drawing.Point(10, 71);
            this.rbtnSlowMovings.Name = "rbtnSlowMovings";
            this.rbtnSlowMovings.Size = new System.Drawing.Size(91, 17);
            this.rbtnSlowMovings.TabIndex = 6;
            this.rbtnSlowMovings.TabStop = true;
            this.rbtnSlowMovings.Text = "Slow Movings";
            this.rbtnSlowMovings.UseVisualStyleBackColor = true;
            // 
            // rbtnMinimumLevel
            // 
            this.rbtnMinimumLevel.AutoSize = true;
            this.rbtnMinimumLevel.Location = new System.Drawing.Point(263, 22);
            this.rbtnMinimumLevel.Name = "rbtnMinimumLevel";
            this.rbtnMinimumLevel.Size = new System.Drawing.Size(95, 17);
            this.rbtnMinimumLevel.TabIndex = 1;
            this.rbtnMinimumLevel.TabStop = true;
            this.rbtnMinimumLevel.Text = "Minimum Level";
            this.rbtnMinimumLevel.UseVisualStyleBackColor = true;
            // 
            // rbtnFastMovings
            // 
            this.rbtnFastMovings.AutoSize = true;
            this.rbtnFastMovings.Location = new System.Drawing.Point(512, 48);
            this.rbtnFastMovings.Name = "rbtnFastMovings";
            this.rbtnFastMovings.Size = new System.Drawing.Size(88, 17);
            this.rbtnFastMovings.TabIndex = 5;
            this.rbtnFastMovings.TabStop = true;
            this.rbtnFastMovings.Text = "Fast Movings";
            this.rbtnFastMovings.UseVisualStyleBackColor = true;
            // 
            // rbtnMaximumLevel
            // 
            this.rbtnMaximumLevel.AutoSize = true;
            this.rbtnMaximumLevel.Location = new System.Drawing.Point(10, 48);
            this.rbtnMaximumLevel.Name = "rbtnMaximumLevel";
            this.rbtnMaximumLevel.Size = new System.Drawing.Size(98, 17);
            this.rbtnMaximumLevel.TabIndex = 3;
            this.rbtnMaximumLevel.TabStop = true;
            this.rbtnMaximumLevel.Text = "Maximum Level";
            this.rbtnMaximumLevel.UseVisualStyleBackColor = true;
            // 
            // rbtnNegativeStock
            // 
            this.rbtnNegativeStock.AutoSize = true;
            this.rbtnNegativeStock.Location = new System.Drawing.Point(10, 22);
            this.rbtnNegativeStock.Name = "rbtnNegativeStock";
            this.rbtnNegativeStock.Size = new System.Drawing.Size(99, 17);
            this.rbtnNegativeStock.TabIndex = 0;
            this.rbtnNegativeStock.TabStop = true;
            this.rbtnNegativeStock.Text = "Negative Stock";
            this.rbtnNegativeStock.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(703, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1259;
            this.label1.Text = "BatchNo";
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(134, 187);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(200, 20);
            this.txtBatchName.TabIndex = 5;
            this.txtBatchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchName_KeyDown);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.DataPropertyName = "SL.NO";
            this.dgvtxtSlno.HeaderText = "Sl.No";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.ReadOnly = true;
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlno.Width = 40;
            // 
            // numbr
            // 
            this.numbr.DataPropertyName = "productCode";
            this.numbr.HeaderText = "Product Code";
            this.numbr.Name = "numbr";
            this.numbr.ReadOnly = true;
            this.numbr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numbr.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "productName";
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 95;
            // 
            // dgvtxtBatchNo
            // 
            this.dgvtxtBatchNo.DataPropertyName = "batchNo";
            this.dgvtxtBatchNo.HeaderText = "BatchNo";
            this.dgvtxtBatchNo.Name = "dgvtxtBatchNo";
            this.dgvtxtBatchNo.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "brandName";
            this.Column2.HeaderText = "Brand";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 94;
            // 
            // unitName
            // 
            this.unitName.DataPropertyName = "unitName";
            this.unitName.HeaderText = "Unit";
            this.unitName.Name = "unitName";
            this.unitName.ReadOnly = true;
            this.unitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitName.Width = 94;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "salesRate";
            this.Column4.HeaderText = " Rate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 94;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "rate";
            this.Column5.HeaderText = "Last Sales Rate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 95;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CurrentStock";
            this.Column3.HeaderText = "Current Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 75;
            // 
            // stockLevel
            // 
            this.stockLevel.DataPropertyName = "stockLevel";
            this.stockLevel.HeaderText = "stockLevel";
            this.stockLevel.Name = "stockLevel";
            this.stockLevel.ReadOnly = true;
            this.stockLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stockLevel.Visible = false;
            // 
            // rowId
            // 
            this.rowId.HeaderText = "rowId";
            this.rowId.Name = "rowId";
            this.rowId.ReadOnly = true;
            this.rowId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rowId.Visible = false;
            // 
            // dgvtxtproductId
            // 
            this.dgvtxtproductId.DataPropertyName = "productId";
            this.dgvtxtproductId.HeaderText = "productId";
            this.dgvtxtproductId.Name = "dgvtxtproductId";
            this.dgvtxtproductId.ReadOnly = true;
            this.dgvtxtproductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductId.Visible = false;
            // 
            // frmProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbxProductList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvProductStatistics);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.cmbModelNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductStatistics";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Statistics";
            this.Load += new System.EventHandler(this.frmProductStatistics_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductStatistics_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatistics)).EndInit();
            this.gbxProductList.ResumeLayout(false);
            this.gbxProductList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvProductStatistics;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.ComboBox cmbModelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxProductList;
        private System.Windows.Forms.RadioButton rbtnUnused;
        private System.Windows.Forms.RadioButton rbtnReorderLevel;
        private System.Windows.Forms.RadioButton rbtnSlowMovings;
        private System.Windows.Forms.RadioButton rbtnMinimumLevel;
        private System.Windows.Forms.RadioButton rbtnFastMovings;
        private System.Windows.Forms.RadioButton rbtnMaximumLevel;
        private System.Windows.Forms.RadioButton rbtnNegativeStock;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductId;

    }
}