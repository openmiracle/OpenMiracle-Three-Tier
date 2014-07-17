namespace Open_Miracle
{
    partial class frmShortExpiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShortExpiry));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModelno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvProductExpiry = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExpiry)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Group";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.Location = new System.Drawing.Point(103, 15);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 0;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Location = new System.Drawing.Point(103, 41);
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
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            // 
            // cmbModelno
            // 
            this.cmbModelno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelno.FormatString = "s";
            this.cmbModelno.Location = new System.Drawing.Point(103, 67);
            this.cmbModelno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelno.Name = "cmbModelno";
            this.cmbModelno.Size = new System.Drawing.Size(200, 21);
            this.cmbModelno.TabIndex = 4;
            this.cmbModelno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelno_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model No";
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.Location = new System.Drawing.Point(103, 93);
            this.cmbGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 6;
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Godown";
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.Location = new System.Drawing.Point(580, 93);
            this.cmbRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 7;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(490, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rack";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.Location = new System.Drawing.Point(580, 67);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 5;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(490, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tax";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Location = new System.Drawing.Point(580, 41);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 3;
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(490, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Size";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Location = new System.Drawing.Point(580, 15);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 21);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(490, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Product";
            // 
            // dgvProductExpiry
            // 
            this.dgvProductExpiry.AllowUserToAddRows = false;
            this.dgvProductExpiry.AllowUserToResizeRows = false;
            this.dgvProductExpiry.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductExpiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductExpiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductExpiry.ColumnHeadersHeight = 35;
            this.dgvProductExpiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductExpiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvProductExpiry.DataMember = "productId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductExpiry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductExpiry.EnableHeadersVisualStyles = false;
            this.dgvProductExpiry.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductExpiry.Location = new System.Drawing.Point(16, 162);
            this.dgvProductExpiry.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvProductExpiry.Name = "dgvProductExpiry";
            this.dgvProductExpiry.ReadOnly = true;
            this.dgvProductExpiry.RowHeadersVisible = false;
            this.dgvProductExpiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductExpiry.Size = new System.Drawing.Size(764, 390);
            this.dgvProductExpiry.TabIndex = 1144;
            this.dgvProductExpiry.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "slNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productCode";
            this.Column2.HeaderText = "Product Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 84;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "productName";
            this.Column3.HeaderText = "Product";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "batchNo";
            this.Column4.HeaderText = "Batch";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 84;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "manufacturingDate";
            this.Column5.HeaderText = "Mfg Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "expiryDate";
            this.Column6.HeaderText = "Expiry";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 84;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "currentStock";
            this.Column7.HeaderText = "Current Stock";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "brandName";
            this.Column8.HeaderText = "Brand";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 84;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "rackName";
            this.Column9.HeaderText = "Rack";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 85;
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(697, 560);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 27);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(695, 129);
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
            this.btnSearch.Location = new System.Drawing.Point(604, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // frmShortExpiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProductExpiry);
            this.Controls.Add(this.cmbRack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGodown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbModelno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmShortExpiry";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Expiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShortExpiry_FormClosing);
            this.Load += new System.EventHandler(this.frmShortExpiry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmShortExpiry_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExpiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModelno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvProductExpiry;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}