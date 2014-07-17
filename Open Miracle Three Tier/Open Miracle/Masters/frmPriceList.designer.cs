namespace Open_Miracle
{
    partial class frmPriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPriceList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.cmbPricingLevel = new System.Windows.Forms.ComboBox();
            this.lblPricingLevel = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPricingList = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtunitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtunitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpurchaserate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalesrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpricelistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtgroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpricinglevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbtnpricelist = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricingList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.cmbPricingLevel);
            this.groupBox1.Controls.Add(this.lblPricingLevel);
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.cmbProductGroup);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblProductGroup);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dgvPricingList);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 546);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price List";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(19, 102);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 126;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(132, 98);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(132, 73);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 2;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // cmbPricingLevel
            // 
            this.cmbPricingLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPricingLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPricingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingLevel.FormattingEnabled = true;
            this.cmbPricingLevel.Location = new System.Drawing.Point(132, 47);
            this.cmbPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPricingLevel.Name = "cmbPricingLevel";
            this.cmbPricingLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricingLevel.TabIndex = 1;
            this.cmbPricingLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPricingLevel_KeyDown);
            // 
            // lblPricingLevel
            // 
            this.lblPricingLevel.AutoSize = true;
            this.lblPricingLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricingLevel.Location = new System.Drawing.Point(19, 51);
            this.lblPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPricingLevel.Name = "lblPricingLevel";
            this.lblPricingLevel.Size = new System.Drawing.Size(68, 13);
            this.lblPricingLevel.TabIndex = 123;
            this.lblPricingLevel.Text = "Pricing Level";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(19, 77);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 122;
            this.lblProductCode.Text = "Product Code";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(132, 21);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 0;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(314, 123);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(19, 25);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 121;
            this.lblProductGroup.Text = "Product Group";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(132, 123);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            this.btnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(223, 123);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvPricingList
            // 
            this.dgvPricingList.AllowUserToAddRows = false;
            this.dgvPricingList.AllowUserToDeleteRows = false;
            this.dgvPricingList.AllowUserToResizeColumns = false;
            this.dgvPricingList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPricingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPricingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPricingList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPricingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPricingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPricingList.ColumnHeadersHeight = 35;
            this.dgvPricingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPricingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtproductId,
            this.dgvtxtproductcode,
            this.dgvtxtproductname,
            this.dgvtxtunitid,
            this.dgvtxtunitName,
            this.dgvtxtpurchaserate,
            this.dgvtxtsalesrate,
            this.dgvtxtmrp,
            this.dgvtxtrate,
            this.dgvtxtpricelistId,
            this.dgvtxtgroupId,
            this.dgvtxtpricinglevelId,
            this.dgvbtnpricelist});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPricingList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPricingList.EnableHeadersVisualStyles = false;
            this.dgvPricingList.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPricingList.Location = new System.Drawing.Point(22, 163);
            this.dgvPricingList.MultiSelect = false;
            this.dgvPricingList.Name = "dgvPricingList";
            this.dgvPricingList.ReadOnly = true;
            this.dgvPricingList.RowHeadersVisible = false;
            this.dgvPricingList.Size = new System.Drawing.Size(721, 361);
            this.dgvPricingList.TabIndex = 8;
            this.dgvPricingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricingList_CellContentClick);
            this.dgvPricingList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricingList_CellContentClick);
           // this.dgvPricingList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvPricingList_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtproductId
            // 
            this.dgvtxtproductId.DataPropertyName = "productId";
            this.dgvtxtproductId.HeaderText = "Product Id";
            this.dgvtxtproductId.Name = "dgvtxtproductId";
            this.dgvtxtproductId.ReadOnly = true;
            this.dgvtxtproductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtproductId.Visible = false;
            // 
            // dgvtxtproductcode
            // 
            this.dgvtxtproductcode.DataPropertyName = "productCode";
            this.dgvtxtproductcode.HeaderText = "Product Code";
            this.dgvtxtproductcode.Name = "dgvtxtproductcode";
            this.dgvtxtproductcode.ReadOnly = true;
            this.dgvtxtproductcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtproductname
            // 
            this.dgvtxtproductname.DataPropertyName = "productName";
            this.dgvtxtproductname.HeaderText = "Name";
            this.dgvtxtproductname.Name = "dgvtxtproductname";
            this.dgvtxtproductname.ReadOnly = true;
            this.dgvtxtproductname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtunitid
            // 
            this.dgvtxtunitid.DataPropertyName = "unitId";
            this.dgvtxtunitid.HeaderText = "Unit ID";
            this.dgvtxtunitid.Name = "dgvtxtunitid";
            this.dgvtxtunitid.ReadOnly = true;
            this.dgvtxtunitid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtunitid.Visible = false;
            // 
            // dgvtxtunitName
            // 
            this.dgvtxtunitName.DataPropertyName = "unitName";
            this.dgvtxtunitName.HeaderText = "Unit Name";
            this.dgvtxtunitName.Name = "dgvtxtunitName";
            this.dgvtxtunitName.ReadOnly = true;
            this.dgvtxtunitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtpurchaserate
            // 
            this.dgvtxtpurchaserate.DataPropertyName = "purchaseRate";
            this.dgvtxtpurchaserate.HeaderText = "Purchase Rate";
            this.dgvtxtpurchaserate.Name = "dgvtxtpurchaserate";
            this.dgvtxtpurchaserate.ReadOnly = true;
            this.dgvtxtpurchaserate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtsalesrate
            // 
            this.dgvtxtsalesrate.DataPropertyName = "salesRate";
            this.dgvtxtsalesrate.HeaderText = "Sales Rate";
            this.dgvtxtsalesrate.Name = "dgvtxtsalesrate";
            this.dgvtxtsalesrate.ReadOnly = true;
            this.dgvtxtsalesrate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtmrp
            // 
            this.dgvtxtmrp.DataPropertyName = "mrp";
            this.dgvtxtmrp.HeaderText = "MRP";
            this.dgvtxtmrp.Name = "dgvtxtmrp";
            this.dgvtxtmrp.ReadOnly = true;
            this.dgvtxtmrp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtrate
            // 
            this.dgvtxtrate.DataPropertyName = "rate";
            this.dgvtxtrate.HeaderText = "Rate";
            this.dgvtxtrate.Name = "dgvtxtrate";
            this.dgvtxtrate.ReadOnly = true;
            this.dgvtxtrate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtrate.Visible = false;
            // 
            // dgvtxtpricelistId
            // 
            this.dgvtxtpricelistId.DataPropertyName = "pricelistId";
            this.dgvtxtpricelistId.HeaderText = "PriceListId";
            this.dgvtxtpricelistId.Name = "dgvtxtpricelistId";
            this.dgvtxtpricelistId.ReadOnly = true;
            this.dgvtxtpricelistId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpricelistId.Visible = false;
            // 
            // dgvtxtgroupId
            // 
            this.dgvtxtgroupId.DataPropertyName = "groupId";
            this.dgvtxtgroupId.HeaderText = "GroupId";
            this.dgvtxtgroupId.Name = "dgvtxtgroupId";
            this.dgvtxtgroupId.ReadOnly = true;
            this.dgvtxtgroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtgroupId.Visible = false;
            // 
            // dgvtxtpricinglevelId
            // 
            this.dgvtxtpricinglevelId.DataPropertyName = "pricinglevelId";
            this.dgvtxtpricinglevelId.HeaderText = "PricinglevelId";
            this.dgvtxtpricinglevelId.Name = "dgvtxtpricinglevelId";
            this.dgvtxtpricinglevelId.ReadOnly = true;
            this.dgvtxtpricinglevelId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpricinglevelId.Visible = false;
            // 
            // dgvbtnpricelist
            // 
            this.dgvbtnpricelist.HeaderText = "";
            this.dgvbtnpricelist.Name = "dgvbtnpricelist";
            this.dgvbtnpricelist.ReadOnly = true;
            this.dgvbtnpricelist.Text = "PriceList";
            this.dgvbtnpricelist.UseColumnTextForButtonValue = true;
            // 
            // frmPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPriceList";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price List";
            this.Load += new System.EventHandler(this.frmPriceList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPriceList_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.ComboBox cmbPricingLevel;
        private System.Windows.Forms.Label lblPricingLevel;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private dgv.DataGridViewEnter dgvPricingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtunitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtunitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpurchaserate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalesrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpricelistId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtgroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpricinglevelId;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnpricelist;
    }
}