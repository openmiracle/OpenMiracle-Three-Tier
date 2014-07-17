namespace Open_Miracle
{
    partial class frmChangeProductTax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeProductTax));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnklblClearAll = new System.Windows.Forms.LinkLabel();
            this.lnklblSelectAll = new System.Windows.Forms.LinkLabel();
            this.lblNewTaxType = new System.Windows.Forms.Label();
            this.cmbNewTaxType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbProductGroupTax = new System.Windows.Forms.ComboBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductGroupTax = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dgvChangeProductTax = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrentTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeProductTax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lnklblClearAll);
            this.groupBox1.Controls.Add(this.lnklblSelectAll);
            this.groupBox1.Controls.Add(this.lblNewTaxType);
            this.groupBox1.Controls.Add(this.cmbNewTaxType);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbProductGroupTax);
            this.groupBox1.Controls.Add(this.cmbSearchBy);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.lblProductGroupTax);
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.lblSearchBy);
            this.groupBox1.Controls.Add(this.dgvChangeProductTax);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 611);
            this.groupBox1.TabIndex = 1147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Tax";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(662, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(480, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(571, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // lnklblClearAll
            // 
            this.lnklblClearAll.AutoSize = true;
            this.lnklblClearAll.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblClearAll.Location = new System.Drawing.Point(75, 115);
            this.lnklblClearAll.Name = "lnklblClearAll";
            this.lnklblClearAll.Size = new System.Drawing.Size(45, 13);
            this.lnklblClearAll.TabIndex = 1;
            this.lnklblClearAll.TabStop = true;
            this.lnklblClearAll.Text = "Clear All";
            this.lnklblClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearAll_LinkClicked);
            // 
            // lnklblSelectAll
            // 
            this.lnklblSelectAll.AutoSize = true;
            this.lnklblSelectAll.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblSelectAll.Location = new System.Drawing.Point(19, 115);
            this.lnklblSelectAll.Name = "lnklblSelectAll";
            this.lnklblSelectAll.Size = new System.Drawing.Size(51, 13);
            this.lnklblSelectAll.TabIndex = 0;
            this.lnklblSelectAll.TabStop = true;
            this.lnklblSelectAll.Text = "Select All";
            this.lnklblSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSelectAll_LinkClicked);
            this.lnklblSelectAll.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lnklblSelectAll_PreviewKeyDown);
            // 
            // lblNewTaxType
            // 
            this.lblNewTaxType.AutoSize = true;
            this.lblNewTaxType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewTaxType.Location = new System.Drawing.Point(20, 76);
            this.lblNewTaxType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNewTaxType.Name = "lblNewTaxType";
            this.lblNewTaxType.Size = new System.Drawing.Size(77, 13);
            this.lblNewTaxType.TabIndex = 346;
            this.lblNewTaxType.Text = "New Tax Type";
            // 
            // cmbNewTaxType
            // 
            this.cmbNewTaxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNewTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTaxType.FormattingEnabled = true;
            this.cmbNewTaxType.Location = new System.Drawing.Point(130, 72);
            this.cmbNewTaxType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbNewTaxType.Name = "cmbNewTaxType";
            this.cmbNewTaxType.Size = new System.Drawing.Size(200, 21);
            this.cmbNewTaxType.TabIndex = 4;
            this.cmbNewTaxType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNewTaxType_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(547, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // cmbProductGroupTax
            // 
            this.cmbProductGroupTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductGroupTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroupTax.FormattingEnabled = true;
            this.cmbProductGroupTax.Location = new System.Drawing.Point(547, 21);
            this.cmbProductGroupTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroupTax.Name = "cmbProductGroupTax";
            this.cmbProductGroupTax.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroupTax.TabIndex = 1;
            this.cmbProductGroupTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroupTax_KeyDown);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Product Group",
            "Tax"});
            this.cmbSearchBy.Location = new System.Drawing.Point(130, 21);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(200, 21);
            this.cmbSearchBy.TabIndex = 0;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            this.cmbSearchBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSearchBy_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(437, 51);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 345;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(547, 47);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblProductGroupTax
            // 
            this.lblProductGroupTax.AutoSize = true;
            this.lblProductGroupTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroupTax.Location = new System.Drawing.Point(437, 25);
            this.lblProductGroupTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroupTax.Name = "lblProductGroupTax";
            this.lblProductGroupTax.Size = new System.Drawing.Size(99, 13);
            this.lblProductGroupTax.TabIndex = 344;
            this.lblProductGroupTax.Text = "Product Group/Tax";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(20, 51);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 343;
            this.lblProductCode.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(130, 47);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 2;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearchBy.Location = new System.Drawing.Point(20, 25);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(56, 13);
            this.lblSearchBy.TabIndex = 342;
            this.lblSearchBy.Text = "Search By";
            // 
            // dgvChangeProductTax
            // 
            this.dgvChangeProductTax.AllowUserToAddRows = false;
            this.dgvChangeProductTax.AllowUserToDeleteRows = false;
            this.dgvChangeProductTax.AllowUserToResizeColumns = false;
            this.dgvChangeProductTax.AllowUserToResizeRows = false;
            this.dgvChangeProductTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChangeProductTax.BackgroundColor = System.Drawing.Color.White;
            this.dgvChangeProductTax.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChangeProductTax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChangeProductTax.ColumnHeadersHeight = 25;
            this.dgvChangeProductTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChangeProductTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtSelect,
            this.dgvtxtProductId,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtCurrentTax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChangeProductTax.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChangeProductTax.EnableHeadersVisualStyles = false;
            this.dgvChangeProductTax.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvChangeProductTax.Location = new System.Drawing.Point(17, 131);
            this.dgvChangeProductTax.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvChangeProductTax.MultiSelect = false;
            this.dgvChangeProductTax.Name = "dgvChangeProductTax";
            this.dgvChangeProductTax.RowHeadersVisible = false;
            this.dgvChangeProductTax.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChangeProductTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvChangeProductTax.Size = new System.Drawing.Size(730, 428);
            this.dgvChangeProductTax.TabIndex = 9;
            this.dgvChangeProductTax.TabStop = false;
            this.dgvChangeProductTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvChangeProductTax_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSelect
            // 
            this.dgvtxtSelect.HeaderText = "Select";
            this.dgvtxtSelect.Name = "dgvtxtSelect";
            this.dgvtxtSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.DataPropertyName = "productId";
            this.dgvtxtProductId.HeaderText = "Product ID";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.ReadOnly = true;
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.ReadOnly = true;
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.ReadOnly = true;
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCurrentTax
            // 
            this.dgvtxtCurrentTax.DataPropertyName = "taxName";
            this.dgvtxtCurrentTax.HeaderText = "Current Tax";
            this.dgvtxtCurrentTax.Name = "dgvtxtCurrentTax";
            this.dgvtxtCurrentTax.ReadOnly = true;
            this.dgvtxtCurrentTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmChangeProductTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChangeProductTax";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Product Tax";
            this.Load += new System.EventHandler(this.frmChangeProductTax_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChangeProductTax_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeProductTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnklblClearAll;
        private System.Windows.Forms.LinkLabel lnklblSelectAll;
        private System.Windows.Forms.Label lblNewTaxType;
        private System.Windows.Forms.ComboBox cmbNewTaxType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbProductGroupTax;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductGroupTax;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dgvChangeProductTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvtxtSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrentTax;
    }
}