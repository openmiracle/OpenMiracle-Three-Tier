namespace Open_Miracle
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblModelNo = new System.Windows.Forms.Label();
            this.lblGodown = new System.Windows.Forms.Label();
            this.lblRack = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.rbtnNegativestock = new System.Windows.Forms.RadioButton();
            this.rbtnMin = new System.Windows.Forms.RadioButton();
            this.rbtnReorder = new System.Windows.Forms.RadioButton();
            this.rbtnMax = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbModelNo = new System.Windows.Forms.ComboBox();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(18, 45);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblProductGroup.ForeColor = System.Drawing.Color.White;
            this.lblProductGroup.Location = new System.Drawing.Point(18, 19);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 1;
            this.lblProductGroup.Text = "Product Group";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(124, 15);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroup_KeyDown);
            // 
            // lblModelNo
            // 
            this.lblModelNo.AutoSize = true;
            this.lblModelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelNo.ForeColor = System.Drawing.Color.White;
            this.lblModelNo.Location = new System.Drawing.Point(18, 71);
            this.lblModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Size = new System.Drawing.Size(53, 13);
            this.lblModelNo.TabIndex = 5;
            this.lblModelNo.Text = "Model No";
            // 
            // lblGodown
            // 
            this.lblGodown.AutoSize = true;
            this.lblGodown.BackColor = System.Drawing.Color.Transparent;
            this.lblGodown.ForeColor = System.Drawing.Color.White;
            this.lblGodown.Location = new System.Drawing.Point(18, 97);
            this.lblGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(47, 13);
            this.lblGodown.TabIndex = 7;
            this.lblGodown.Text = "Godown";
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.BackColor = System.Drawing.Color.Transparent;
            this.lblRack.ForeColor = System.Drawing.Color.White;
            this.lblRack.Location = new System.Drawing.Point(18, 123);
            this.lblRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(33, 13);
            this.lblRack.TabIndex = 15;
            this.lblRack.Text = "Rack";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(391, 75);
            this.lblTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(391, 49);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(391, 23);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Product Name";
            // 
            // rbtnNegativestock
            // 
            this.rbtnNegativestock.AutoSize = true;
            this.rbtnNegativestock.ForeColor = System.Drawing.Color.White;
            this.rbtnNegativestock.Location = new System.Drawing.Point(580, 90);
            this.rbtnNegativestock.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnNegativestock.Name = "rbtnNegativestock";
            this.rbtnNegativestock.Size = new System.Drawing.Size(99, 17);
            this.rbtnNegativestock.TabIndex = 8;
            this.rbtnNegativestock.TabStop = true;
            this.rbtnNegativestock.Text = "Negative Stock";
            this.rbtnNegativestock.UseVisualStyleBackColor = true;
            this.rbtnNegativestock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnNegativestock_KeyDown);
            // 
            // rbtnMin
            // 
            this.rbtnMin.AutoSize = true;
            this.rbtnMin.ForeColor = System.Drawing.Color.White;
            this.rbtnMin.Location = new System.Drawing.Point(686, 90);
            this.rbtnMin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnMin.Name = "rbtnMin";
            this.rbtnMin.Size = new System.Drawing.Size(98, 17);
            this.rbtnMin.TabIndex = 9;
            this.rbtnMin.TabStop = true;
            this.rbtnMin.Text = "Minimum  Level";
            this.rbtnMin.UseVisualStyleBackColor = true;
            this.rbtnMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnMin_KeyDown);
            // 
            // rbtnReorder
            // 
            this.rbtnReorder.AutoSize = true;
            this.rbtnReorder.ForeColor = System.Drawing.Color.White;
            this.rbtnReorder.Location = new System.Drawing.Point(536, 114);
            this.rbtnReorder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnReorder.Name = "rbtnReorder";
            this.rbtnReorder.Size = new System.Drawing.Size(92, 17);
            this.rbtnReorder.TabIndex = 10;
            this.rbtnReorder.TabStop = true;
            this.rbtnReorder.Text = "Reorder Level";
            this.rbtnReorder.UseVisualStyleBackColor = true;
            this.rbtnReorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnReorder_KeyDown);
            // 
            // rbtnMax
            // 
            this.rbtnMax.AutoSize = true;
            this.rbtnMax.ForeColor = System.Drawing.Color.White;
            this.rbtnMax.Location = new System.Drawing.Point(642, 114);
            this.rbtnMax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnMax.Name = "rbtnMax";
            this.rbtnMax.Size = new System.Drawing.Size(98, 17);
            this.rbtnMax.TabIndex = 11;
            this.rbtnMax.TabStop = true;
            this.rbtnMax.Text = "Maximum Level";
            this.rbtnMax.UseVisualStyleBackColor = true;
            this.rbtnMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnMax_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(536, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 13;
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
            this.btnReset.Location = new System.Drawing.Point(629, 137);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeight = 35;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStock.Location = new System.Drawing.Point(21, 170);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(759, 377);
            this.dgvStock.TabIndex = 15;
            this.dgvStock.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sl No";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productCode";
            this.Column2.HeaderText = "Product Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "productName";
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 108;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "brandName";
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 108;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CurrentStock";
            this.Column5.HeaderText = "Current Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 108;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "modelNo";
            this.Column6.HeaderText = "Stock Model No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 108;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "salesRate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Rate";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 108;
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
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(124, 41);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(200, 21);
            this.cmbBrand.TabIndex = 2;
            this.cmbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBrand_KeyDown);
            // 
            // cmbModelNo
            // 
            this.cmbModelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNo.FormattingEnabled = true;
            this.cmbModelNo.Location = new System.Drawing.Point(124, 67);
            this.cmbModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelNo.Name = "cmbModelNo";
            this.cmbModelNo.Size = new System.Drawing.Size(200, 21);
            this.cmbModelNo.TabIndex = 4;
            this.cmbModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelNo_KeyDown);
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.FormattingEnabled = true;
            this.cmbGodown.Location = new System.Drawing.Point(124, 93);
            this.cmbGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 6;
            this.cmbGodown.SelectedIndexChanged += new System.EventHandler(this.cmbGodown_SelectedIndexChanged);
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.FormattingEnabled = true;
            this.cmbRack.Location = new System.Drawing.Point(124, 119);
            this.cmbRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 12;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(536, 67);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(244, 21);
            this.cmbTax.TabIndex = 5;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(536, 41);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(244, 21);
            this.cmbSize.TabIndex = 3;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(536, 15);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(244, 21);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(536, 90);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 7;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnAll_KeyDown);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.cmbRack);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbGodown);
            this.Controls.Add(this.cmbModelNo);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbtnMax);
            this.Controls.Add(this.rbtnReorder);
            this.Controls.Add(this.rbtnMin);
            this.Controls.Add(this.rbtnNegativestock);
            this.Controls.Add(this.lblRack);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblGodown);
            this.Controls.Add(this.lblModelNo);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblProductGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStock";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStock_FormClosing);
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblModelNo;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.RadioButton rbtnNegativestock;
        private System.Windows.Forms.RadioButton rbtnMin;
        private System.Windows.Forms.RadioButton rbtnReorder;
        private System.Windows.Forms.RadioButton rbtnMax;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModelNo;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}