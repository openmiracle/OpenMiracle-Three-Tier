namespace Open_Miracle
{
    partial class frmProductSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSearch));
            this.cmbModelNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnNegStock = new System.Windows.Forms.RadioButton();
            this.rbtnMinLevel = new System.Windows.Forms.RadioButton();
            this.rbtnRecordLevel = new System.Windows.Forms.RadioButton();
            this.rbtnMaxLevel = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvProductSearch = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModelNo
            // 
            this.cmbModelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNo.Location = new System.Drawing.Point(582, 41);
            this.cmbModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelNo.Name = "cmbModelNo";
            this.cmbModelNo.Size = new System.Drawing.Size(200, 21);
            this.cmbModelNo.TabIndex = 3;
            this.cmbModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1179;
            this.label5.Text = "Model No";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Location = new System.Drawing.Point(127, 41);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(200, 21);
            this.cmbBrand.TabIndex = 2;
            this.cmbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBrand_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1177;
            this.label3.Text = "Brand";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.Location = new System.Drawing.Point(127, 15);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 0;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1175;
            this.label2.Text = "Product Group";
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.Location = new System.Drawing.Point(127, 67);
            this.cmbGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 4;
            this.cmbGodown.SelectedValueChanged += new System.EventHandler(this.cmbGodown_SelectedValueChanged);
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1181;
            this.label4.Text = "Godown";
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.Location = new System.Drawing.Point(582, 67);
            this.cmbRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 5;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(474, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1189;
            this.label6.Text = "Rack";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.Location = new System.Drawing.Point(582, 15);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 1;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(474, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 1187;
            this.label7.Text = "Tax";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Location = new System.Drawing.Point(127, 93);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 6;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1185;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(474, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1183;
            this.label9.Text = "Product Code";
            // 
            // rbtnNegStock
            // 
            this.rbtnNegStock.AutoSize = true;
            this.rbtnNegStock.ForeColor = System.Drawing.Color.White;
            this.rbtnNegStock.Location = new System.Drawing.Point(488, 172);
            this.rbtnNegStock.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnNegStock.Name = "rbtnNegStock";
            this.rbtnNegStock.Size = new System.Drawing.Size(99, 17);
            this.rbtnNegStock.TabIndex = 15;
            this.rbtnNegStock.TabStop = true;
            this.rbtnNegStock.Text = "Negative Stock";
            this.rbtnNegStock.UseVisualStyleBackColor = true;
            this.rbtnNegStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnNegStock_KeyDown);
            // 
            // rbtnMinLevel
            // 
            this.rbtnMinLevel.AutoSize = true;
            this.rbtnMinLevel.ForeColor = System.Drawing.Color.White;
            this.rbtnMinLevel.Location = new System.Drawing.Point(173, 172);
            this.rbtnMinLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnMinLevel.Name = "rbtnMinLevel";
            this.rbtnMinLevel.Size = new System.Drawing.Size(95, 17);
            this.rbtnMinLevel.TabIndex = 12;
            this.rbtnMinLevel.TabStop = true;
            this.rbtnMinLevel.Text = "Minimum Level";
            this.rbtnMinLevel.UseVisualStyleBackColor = true;
            this.rbtnMinLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnMinLevel_KeyDown);
            // 
            // rbtnRecordLevel
            // 
            this.rbtnRecordLevel.AutoSize = true;
            this.rbtnRecordLevel.ForeColor = System.Drawing.Color.White;
            this.rbtnRecordLevel.Location = new System.Drawing.Point(278, 172);
            this.rbtnRecordLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnRecordLevel.Name = "rbtnRecordLevel";
            this.rbtnRecordLevel.Size = new System.Drawing.Size(92, 17);
            this.rbtnRecordLevel.TabIndex = 13;
            this.rbtnRecordLevel.TabStop = true;
            this.rbtnRecordLevel.Text = "Reorder Level";
            this.rbtnRecordLevel.UseVisualStyleBackColor = true;
            this.rbtnRecordLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnRecordLevel_KeyDown);
            // 
            // rbtnMaxLevel
            // 
            this.rbtnMaxLevel.AutoSize = true;
            this.rbtnMaxLevel.ForeColor = System.Drawing.Color.White;
            this.rbtnMaxLevel.Location = new System.Drawing.Point(380, 172);
            this.rbtnMaxLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnMaxLevel.Name = "rbtnMaxLevel";
            this.rbtnMaxLevel.Size = new System.Drawing.Size(98, 17);
            this.rbtnMaxLevel.TabIndex = 14;
            this.rbtnMaxLevel.TabStop = true;
            this.rbtnMaxLevel.Text = "Maximum Level";
            this.rbtnMaxLevel.UseVisualStyleBackColor = true;
            this.rbtnMaxLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnMaxLevel_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(606, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 16;
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
            this.btnReset.Location = new System.Drawing.Point(697, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 17;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // dgvProductSearch
            // 
            this.dgvProductSearch.AllowUserToAddRows = false;
            this.dgvProductSearch.AllowUserToDeleteRows = false;
            this.dgvProductSearch.AllowUserToResizeColumns = false;
            this.dgvProductSearch.AllowUserToResizeRows = false;
            this.dgvProductSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductSearch.CausesValidation = false;
            this.dgvProductSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSearch.ColumnHeadersHeight = 35;
            this.dgvProductSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.productId,
            this.Column2,
            this.isActive,
            this.Column3,
            this.dgvtxtBatch,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSearch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductSearch.EnableHeadersVisualStyles = false;
            this.dgvProductSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductSearch.Location = new System.Drawing.Point(18, 205);
            this.dgvProductSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvProductSearch.Name = "dgvProductSearch";
            this.dgvProductSearch.ReadOnly = true;
            this.dgvProductSearch.RowHeadersVisible = false;
            this.dgvProductSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSearch.Size = new System.Drawing.Size(764, 350);
            this.dgvProductSearch.TabIndex = 20;
            this.dgvProductSearch.TabStop = false;
            this.dgvProductSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSearch_CellDoubleClick);
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SL.NO";
            this.SlNo.HeaderText = "SL.NO";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "productId";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productId.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "productCode";
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isActive.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "productName";
            this.Column3.HeaderText = "Product";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 105;
            // 
            // dgvtxtBatch
            // 
            this.dgvtxtBatch.DataPropertyName = "batchNo";
            this.dgvtxtBatch.HeaderText = "BatchNo";
            this.dgvtxtBatch.Name = "dgvtxtBatch";
            this.dgvtxtBatch.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "brandName";
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Currentstock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Current Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "salesRate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Sales Rate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mrp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "MRP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 18;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(18, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(582, 119);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.MaxLength = 13;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 9;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(127, 119);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.MaxLength = 13;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 8;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1206;
            this.label1.Text = "Product Name";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(127, 172);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 11;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnAll_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(474, 97);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1208;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.cmbStatus.Location = new System.Drawing.Point(582, 93);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1209;
            this.label10.Text = "BatchNo";
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(127, 147);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBatchName.MaxLength = 13;
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBatchName.Size = new System.Drawing.Size(200, 20);
            this.txtBatchName.TabIndex = 10;
            this.txtBatchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchName_KeyDown);
            // 
            // frmProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvProductSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbtnMaxLevel);
            this.Controls.Add(this.rbtnRecordLevel);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.rbtnMinLevel);
            this.Controls.Add(this.rbtnNegStock);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbRack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGodown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModelNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductSearch";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.frmProductSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnNegStock;
        private System.Windows.Forms.RadioButton rbtnMinLevel;
        private System.Windows.Forms.RadioButton rbtnRecordLevel;
        private System.Windows.Forms.RadioButton rbtnMaxLevel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvProductSearch;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}