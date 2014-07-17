namespace Open_Miracle
{
    partial class frmShortExpiryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShortExpiryReport));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.lblGodown = new System.Windows.Forms.Label();
            this.cmbModelno = new System.Windows.Forms.ComboBox();
            this.lblModelNo6 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblProductExpire = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvShortExpiryReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEXPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRack = new System.Windows.Forms.Label();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.txtProductExpire = new System.Windows.Forms.TextBox();
            this.cmbProductExpire = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortExpiryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-227, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price List";
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.FormattingEnabled = true;
            this.cmbGodown.Location = new System.Drawing.Point(582, 67);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 6;
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // lblGodown
            // 
            this.lblGodown.AutoSize = true;
            this.lblGodown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodown.Location = new System.Drawing.Point(485, 71);
            this.lblGodown.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(47, 13);
            this.lblGodown.TabIndex = 2007;
            this.lblGodown.Text = "Godown";
            // 
            // cmbModelno
            // 
            this.cmbModelno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelno.FormattingEnabled = true;
            this.cmbModelno.Location = new System.Drawing.Point(582, 40);
            this.cmbModelno.Name = "cmbModelno";
            this.cmbModelno.Size = new System.Drawing.Size(200, 21);
            this.cmbModelno.TabIndex = 4;
            this.cmbModelno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelno_KeyDown);
            // 
            // lblModelNo6
            // 
            this.lblModelNo6.AutoSize = true;
            this.lblModelNo6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModelNo6.Location = new System.Drawing.Point(485, 44);
            this.lblModelNo6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblModelNo6.Name = "lblModelNo6";
            this.lblModelNo6.Size = new System.Drawing.Size(53, 13);
            this.lblModelNo6.TabIndex = 2006;
            this.lblModelNo6.Text = "Model No";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(176, 94);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 7;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSize.Location = new System.Drawing.Point(15, 98);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 2003;
            this.lblSize.Text = "Size";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(176, 40);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 3;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown_1);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(176, 67);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(200, 21);
            this.cmbBrand.TabIndex = 5;
            this.cmbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBrand_KeyDown);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrand.Location = new System.Drawing.Point(15, 71);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 2002;
            this.lblBrand.Text = "Brand";
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(582, 13);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(200, 21);
            this.cmbProductName.TabIndex = 2;
            this.cmbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductName_KeyDown_1);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(485, 17);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 2005;
            this.lblProduct.Text = "Product";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(15, 43);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 2001;
            this.lblProductGroup.Text = "Product Group";
            // 
            // lblProductExpire
            // 
            this.lblProductExpire.AutoSize = true;
            this.lblProductExpire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductExpire.Location = new System.Drawing.Point(15, 17);
            this.lblProductExpire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblProductExpire.Name = "lblProductExpire";
            this.lblProductExpire.Size = new System.Drawing.Size(149, 13);
            this.lblProductExpire.TabIndex = 2000;
            this.lblProductExpire.Text = "Product that will expire with in ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(598, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dgvShortExpiryReport
            // 
            this.dgvShortExpiryReport.AllowUserToAddRows = false;
            this.dgvShortExpiryReport.AllowUserToDeleteRows = false;
            this.dgvShortExpiryReport.AllowUserToResizeRows = false;
            this.dgvShortExpiryReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvShortExpiryReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShortExpiryReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShortExpiryReport.ColumnHeadersHeight = 35;
            this.dgvShortExpiryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShortExpiryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtBatch,
            this.dgvtxtMFD,
            this.dgvtxtEXPD,
            this.dgvtxtUnit,
            this.dgvtxtBrand,
            this.dgvtxtCurrentStock});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShortExpiryReport.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShortExpiryReport.EnableHeadersVisualStyles = false;
            this.dgvShortExpiryReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvShortExpiryReport.Location = new System.Drawing.Point(21, 148);
            this.dgvShortExpiryReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvShortExpiryReport.Name = "dgvShortExpiryReport";
            this.dgvShortExpiryReport.ReadOnly = true;
            this.dgvShortExpiryReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShortExpiryReport.RowHeadersVisible = false;
            this.dgvShortExpiryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShortExpiryReport.Size = new System.Drawing.Size(761, 406);
            this.dgvShortExpiryReport.TabIndex = 1242;
            this.dgvShortExpiryReport.TabStop = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "slNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtSlNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 84;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtProductCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.ReadOnly = true;
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductCode.Width = 84;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtProductName.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.ReadOnly = true;
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductName.Width = 85;
            // 
            // dgvtxtBatch
            // 
            this.dgvtxtBatch.DataPropertyName = "batchNo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtBatch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtBatch.HeaderText = "Batch";
            this.dgvtxtBatch.Name = "dgvtxtBatch";
            this.dgvtxtBatch.ReadOnly = true;
            this.dgvtxtBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBatch.Width = 84;
            // 
            // dgvtxtMFD
            // 
            this.dgvtxtMFD.DataPropertyName = "manufacturingDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtMFD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtMFD.HeaderText = "MFD";
            this.dgvtxtMFD.Name = "dgvtxtMFD";
            this.dgvtxtMFD.ReadOnly = true;
            this.dgvtxtMFD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMFD.Width = 84;
            // 
            // dgvtxtEXPD
            // 
            this.dgvtxtEXPD.DataPropertyName = "expiryDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtEXPD.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtxtEXPD.HeaderText = "EXPD";
            this.dgvtxtEXPD.Name = "dgvtxtEXPD";
            this.dgvtxtEXPD.ReadOnly = true;
            this.dgvtxtEXPD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEXPD.Width = 84;
            // 
            // dgvtxtUnit
            // 
            this.dgvtxtUnit.DataPropertyName = "unitName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtUnit.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtxtUnit.HeaderText = "Unit";
            this.dgvtxtUnit.Name = "dgvtxtUnit";
            this.dgvtxtUnit.ReadOnly = true;
            this.dgvtxtUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnit.Width = 85;
            // 
            // dgvtxtBrand
            // 
            this.dgvtxtBrand.DataPropertyName = "brandName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtBrand.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvtxtBrand.HeaderText = "Brand ";
            this.dgvtxtBrand.Name = "dgvtxtBrand";
            this.dgvtxtBrand.ReadOnly = true;
            this.dgvtxtBrand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBrand.Width = 84;
            // 
            // dgvtxtCurrentStock
            // 
            this.dgvtxtCurrentStock.DataPropertyName = "currentStock";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtCurrentStock.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtxtCurrentStock.HeaderText = "Current Stock";
            this.dgvtxtCurrentStock.Name = "dgvtxtCurrentStock";
            this.dgvtxtCurrentStock.ReadOnly = true;
            this.dgvtxtCurrentStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrentStock.Width = 84;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(582, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 9;
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
            this.btnReset.Location = new System.Drawing.Point(675, 94);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRack.Location = new System.Drawing.Point(15, 125);
            this.lblRack.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(33, 13);
            this.lblRack.TabIndex = 2004;
            this.lblRack.Text = "Rack";
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.FormattingEnabled = true;
            this.cmbRack.Location = new System.Drawing.Point(176, 121);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 8;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // txtProductExpire
            // 
            this.txtProductExpire.Location = new System.Drawing.Point(176, 13);
            this.txtProductExpire.MaxLength = 4;
            this.txtProductExpire.Name = "txtProductExpire";
            this.txtProductExpire.Size = new System.Drawing.Size(67, 20);
            this.txtProductExpire.TabIndex = 0;
            this.txtProductExpire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductExpire_KeyDown);
            this.txtProductExpire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductExpire_KeyPress);
            // 
            // cmbProductExpire
            // 
            this.cmbProductExpire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductExpire.FormattingEnabled = true;
            this.cmbProductExpire.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.cmbProductExpire.Location = new System.Drawing.Point(249, 13);
            this.cmbProductExpire.Name = "cmbProductExpire";
            this.cmbProductExpire.Size = new System.Drawing.Size(127, 21);
            this.cmbProductExpire.TabIndex = 1;
            this.cmbProductExpire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductExpire_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(689, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmShortExpiryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbProductExpire);
            this.Controls.Add(this.txtProductExpire);
            this.Controls.Add(this.cmbRack);
            this.Controls.Add(this.lblRack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvShortExpiryReport);
            this.Controls.Add(this.lblProductExpire);
            this.Controls.Add(this.cmbGodown);
            this.Controls.Add(this.lblGodown);
            this.Controls.Add(this.cmbModelno);
            this.Controls.Add(this.lblModelNo6);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmShortExpiryReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Expiry Report";
            this.Load += new System.EventHandler(this.Short_Expiry_Report_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmShortExpiryReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortExpiryReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.ComboBox cmbModelno;
        private System.Windows.Forms.Label lblModelNo6;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblProductExpire;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvShortExpiryReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.TextBox txtProductExpire;
        private System.Windows.Forms.ComboBox cmbProductExpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEXPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrentStock;
        private System.Windows.Forms.Button btnExport;
    }
}