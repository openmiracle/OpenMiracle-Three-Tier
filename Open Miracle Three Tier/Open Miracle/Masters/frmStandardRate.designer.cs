namespace Open_Miracle
{
    partial class frmStandardRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardRate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStandardRate = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtstandardRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbtnStandardRate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbProductGroup);
            this.groupBox1.Controls.Add(this.lblProductGroup);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 137);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Rate";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(18, 51);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 136;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(18, 76);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 135;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(128, 47);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(128, 72);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(310, 97);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(128, 97);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(219, 97);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(128, 21);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 0;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(18, 25);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 134;
            this.lblProductGroup.Text = "Product Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStandardRate);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 431);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvStandardRate
            // 
            this.dgvStandardRate.AllowUserToAddRows = false;
            this.dgvStandardRate.AllowUserToDeleteRows = false;
            this.dgvStandardRate.AllowUserToResizeColumns = false;
            this.dgvStandardRate.AllowUserToResizeRows = false;
            this.dgvStandardRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStandardRate.BackgroundColor = System.Drawing.Color.White;
            this.dgvStandardRate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStandardRate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStandardRate.ColumnHeadersHeight = 25;
            this.dgvStandardRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStandardRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtstandardRateId,
            this.dgvtxtProductId,
            this.dgvtxtProductcode,
            this.dgvtxtProductName,
            this.dgvtxtUnitName,
            this.dgvtxtUnitId,
            this.dgvbtnStandardRate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStandardRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStandardRate.EnableHeadersVisualStyles = false;
            this.dgvStandardRate.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStandardRate.Location = new System.Drawing.Point(21, 25);
            this.dgvStandardRate.MultiSelect = false;
            this.dgvStandardRate.Name = "dgvStandardRate";
            this.dgvStandardRate.ReadOnly = true;
            this.dgvStandardRate.RowHeadersVisible = false;
            this.dgvStandardRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStandardRate.Size = new System.Drawing.Size(721, 390);
            this.dgvStandardRate.TabIndex = 6;
            this.dgvStandardRate.TabStop = false;
            this.dgvStandardRate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStandardRate_CellContentClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtSlNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtstandardRateId
            // 
            this.dgvtxtstandardRateId.DataPropertyName = "standardRateId";
            this.dgvtxtstandardRateId.HeaderText = "standardRateId";
            this.dgvtxtstandardRateId.Name = "dgvtxtstandardRateId";
            this.dgvtxtstandardRateId.ReadOnly = true;
            this.dgvtxtstandardRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtstandardRateId.Visible = false;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.DataPropertyName = "productId";
            this.dgvtxtProductId.HeaderText = "ProductId";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.ReadOnly = true;
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtProductcode
            // 
            this.dgvtxtProductcode.DataPropertyName = "productCode";
            this.dgvtxtProductcode.HeaderText = "Product Code";
            this.dgvtxtProductcode.Name = "dgvtxtProductcode";
            this.dgvtxtProductcode.ReadOnly = true;
            this.dgvtxtProductcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            this.dgvtxtProductName.HeaderText = "Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.ReadOnly = true;
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnitName
            // 
            this.dgvtxtUnitName.DataPropertyName = "unitName";
            this.dgvtxtUnitName.HeaderText = "Unit";
            this.dgvtxtUnitName.Name = "dgvtxtUnitName";
            this.dgvtxtUnitName.ReadOnly = true;
            this.dgvtxtUnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnitId
            // 
            this.dgvtxtUnitId.DataPropertyName = "unitId";
            this.dgvtxtUnitId.HeaderText = "UnitId";
            this.dgvtxtUnitId.Name = "dgvtxtUnitId";
            this.dgvtxtUnitId.ReadOnly = true;
            this.dgvtxtUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitId.Visible = false;
            // 
            // dgvbtnStandardRate
            // 
            this.dgvbtnStandardRate.HeaderText = "";
            this.dgvbtnStandardRate.Name = "dgvbtnStandardRate";
            this.dgvbtnStandardRate.ReadOnly = true;
            this.dgvbtnStandardRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvbtnStandardRate.Text = "Standard Rate";
            this.dgvbtnStandardRate.UseColumnTextForButtonValue = true;
            // 
            // frmStandardRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStandardRate";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Rate";
            this.Load += new System.EventHandler(this.frmStandardRate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStandardRate_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStandardRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtstandardRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitId;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnStandardRate;
    }
}