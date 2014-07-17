namespace Open_Miracle
{
    partial class frmProductBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductBatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblMfdDate = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtBatchNoSearch = new System.Windows.Forms.TextBox();
            this.lblBatchNoSearch = new System.Windows.Forms.Label();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.lblProductNameSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductCodeSearch = new System.Windows.Forms.TextBox();
            this.lblProductCodeSearch = new System.Windows.Forms.Label();
            this.dgvProductBatch = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.cmbProductCode);
            this.groupBox1.Controls.Add(this.lblMfdDate);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.lblExpDate);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtBatchNo);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblBatchNo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 143);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Batch";
            // 
            // lblProductCode
            // 
            this.lblProductCode.Enabled = false;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(15, 25);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(100, 20);
            this.lblProductCode.TabIndex = 390;
            this.lblProductCode.Text = "Product Code";
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.Enabled = false;
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(125, 25);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(5);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(200, 21);
            this.cmbProductCode.TabIndex = 0;
            // 
            // lblMfdDate
            // 
            this.lblMfdDate.Enabled = false;
            this.lblMfdDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMfdDate.Location = new System.Drawing.Point(422, 50);
            this.lblMfdDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblMfdDate.Name = "lblMfdDate";
            this.lblMfdDate.Size = new System.Drawing.Size(100, 20);
            this.lblMfdDate.TabIndex = 388;
            this.lblMfdDate.Text = "Mfg. Date";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(532, 50);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // lblExpDate
            // 
            this.lblExpDate.Enabled = false;
            this.lblExpDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpDate.Location = new System.Drawing.Point(15, 74);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(100, 20);
            this.lblExpDate.TabIndex = 386;
            this.lblExpDate.Text = "Exp. Date";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 74);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Enabled = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(398, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(307, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(216, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Enabled = false;
            this.txtBatchNo.Location = new System.Drawing.Point(125, 50);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(200, 20);
            this.txtBatchNo.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.Enabled = false;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(422, 25);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 20);
            this.lblProductName.TabIndex = 380;
            this.lblProductName.Text = "Product Name";
            // 
            // cmbProductName
            // 
            this.cmbProductName.Enabled = false;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(532, 25);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(5);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(200, 21);
            this.cmbProductName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(125, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Enabled = false;
            this.lblBatchNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatchNo.Location = new System.Drawing.Point(15, 50);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(100, 20);
            this.lblBatchNo.TabIndex = 377;
            this.lblBatchNo.Text = "Batch No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearSearch);
            this.groupBox2.Controls.Add(this.txtBatchNoSearch);
            this.groupBox2.Controls.Add(this.lblBatchNoSearch);
            this.groupBox2.Controls.Add(this.txtProductNameSearch);
            this.groupBox2.Controls.Add(this.lblProductNameSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtProductCodeSearch);
            this.groupBox2.Controls.Add(this.lblProductCodeSearch);
            this.groupBox2.Controls.Add(this.dgvProductBatch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 405);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.BackgroundImage")));
            this.btnClearSearch.Enabled = false;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(630, 49);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(85, 27);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // txtBatchNoSearch
            // 
            this.txtBatchNoSearch.Enabled = false;
            this.txtBatchNoSearch.Location = new System.Drawing.Point(539, 21);
            this.txtBatchNoSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtBatchNoSearch.Name = "txtBatchNoSearch";
            this.txtBatchNoSearch.Size = new System.Drawing.Size(200, 20);
            this.txtBatchNoSearch.TabIndex = 1;
            // 
            // lblBatchNoSearch
            // 
            this.lblBatchNoSearch.Enabled = false;
            this.lblBatchNoSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatchNoSearch.Location = new System.Drawing.Point(429, 21);
            this.lblBatchNoSearch.Margin = new System.Windows.Forms.Padding(5);
            this.lblBatchNoSearch.Name = "lblBatchNoSearch";
            this.lblBatchNoSearch.Size = new System.Drawing.Size(100, 20);
            this.lblBatchNoSearch.TabIndex = 388;
            this.lblBatchNoSearch.Text = "Batch No.";
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.Enabled = false;
            this.txtProductNameSearch.Location = new System.Drawing.Point(125, 51);
            this.txtProductNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtProductNameSearch.TabIndex = 2;
            // 
            // lblProductNameSearch
            // 
            this.lblProductNameSearch.Enabled = false;
            this.lblProductNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductNameSearch.Location = new System.Drawing.Point(15, 51);
            this.lblProductNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductNameSearch.Name = "lblProductNameSearch";
            this.lblProductNameSearch.Size = new System.Drawing.Size(100, 20);
            this.lblProductNameSearch.TabIndex = 386;
            this.lblProductNameSearch.Text = "Product Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(539, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtProductCodeSearch
            // 
            this.txtProductCodeSearch.Enabled = false;
            this.txtProductCodeSearch.Location = new System.Drawing.Point(125, 21);
            this.txtProductCodeSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductCodeSearch.Name = "txtProductCodeSearch";
            this.txtProductCodeSearch.Size = new System.Drawing.Size(200, 20);
            this.txtProductCodeSearch.TabIndex = 0;
            // 
            // lblProductCodeSearch
            // 
            this.lblProductCodeSearch.Enabled = false;
            this.lblProductCodeSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCodeSearch.Location = new System.Drawing.Point(15, 21);
            this.lblProductCodeSearch.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductCodeSearch.Name = "lblProductCodeSearch";
            this.lblProductCodeSearch.Size = new System.Drawing.Size(100, 20);
            this.lblProductCodeSearch.TabIndex = 383;
            this.lblProductCodeSearch.Text = "Product Code";
            // 
            // dgvProductBatch
            // 
            this.dgvProductBatch.AllowUserToResizeColumns = false;
            this.dgvProductBatch.AllowUserToResizeRows = false;
            this.dgvProductBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductBatch.ColumnHeadersHeight = 25;
            this.dgvProductBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtBatchNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductBatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductBatch.Enabled = false;
            this.dgvProductBatch.EnableHeadersVisualStyles = false;
            this.dgvProductBatch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductBatch.Location = new System.Drawing.Point(18, 82);
            this.dgvProductBatch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvProductBatch.Name = "dgvProductBatch";
            this.dgvProductBatch.RowHeadersVisible = false;
            this.dgvProductBatch.Size = new System.Drawing.Size(721, 309);
            this.dgvProductBatch.TabIndex = 382;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBatchNo
            // 
            this.dgvtxtBatchNo.HeaderText = "Batch No.";
            this.dgvtxtBatchNo.Name = "dgvtxtBatchNo";
            this.dgvtxtBatchNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmProductBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductBatch";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Batch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblMfdDate;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox txtBatchNoSearch;
        private System.Windows.Forms.Label lblBatchNoSearch;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label lblProductNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProductCodeSearch;
        private System.Windows.Forms.Label lblProductCodeSearch;
        private System.Windows.Forms.DataGridView dgvProductBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchNo;
    }
}