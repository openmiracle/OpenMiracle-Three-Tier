namespace Open_Miracle
{
    partial class frmProductSearchPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSearchPopup));
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.dgvProductSearchPopup = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtModelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbModelNo = new System.Windows.Forms.ComboBox();
            this.lblModelNo = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(123, 40);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 3;
            this.cmbProductGroup.SelectedIndexChanged += new System.EventHandler(this.cmbProductGroup_SelectedIndexChanged);
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // dgvProductSearchPopup
            // 
            this.dgvProductSearchPopup.AllowUserToAddRows = false;
            this.dgvProductSearchPopup.AllowUserToDeleteRows = false;
            this.dgvProductSearchPopup.AllowUserToResizeColumns = false;
            this.dgvProductSearchPopup.AllowUserToResizeRows = false;
            this.dgvProductSearchPopup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductSearchPopup.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductSearchPopup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSearchPopup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSearchPopup.ColumnHeadersHeight = 25;
            this.dgvProductSearchPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductSearchPopup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtProductId,
            this.dgvtxtProductCode,
            this.dgvProductName,
            this.dgvtxtGroup,
            this.dgvtxtSize,
            this.dgvtxtModelNo,
            this.dgvtxtRate,
            this.dgvtxtSalesRate,
            this.dgvtxtMRP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSearchPopup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductSearchPopup.EnableHeadersVisualStyles = false;
            this.dgvProductSearchPopup.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductSearchPopup.Location = new System.Drawing.Point(18, 96);
            this.dgvProductSearchPopup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvProductSearchPopup.Name = "dgvProductSearchPopup";
            this.dgvProductSearchPopup.RowHeadersVisible = false;
            this.dgvProductSearchPopup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSearchPopup.Size = new System.Drawing.Size(619, 284);
            this.dgvProductSearchPopup.TabIndex = 6;
            this.dgvProductSearchPopup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSearchPopup_CellDoubleClick);
            this.dgvProductSearchPopup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductSearchPopup_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.DataPropertyName = "productId";
            this.dgvtxtProductId.HeaderText = "ProductID";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            this.dgvtxtProductCode.HeaderText = "Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvProductName
            // 
            this.dgvProductName.DataPropertyName = "productName";
            this.dgvProductName.HeaderText = "Name";
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtGroup
            // 
            this.dgvtxtGroup.DataPropertyName = "groupName";
            this.dgvtxtGroup.HeaderText = "Group";
            this.dgvtxtGroup.Name = "dgvtxtGroup";
            this.dgvtxtGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSize
            // 
            this.dgvtxtSize.DataPropertyName = "size";
            this.dgvtxtSize.HeaderText = "Size";
            this.dgvtxtSize.Name = "dgvtxtSize";
            this.dgvtxtSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtModelNo
            // 
            this.dgvtxtModelNo.DataPropertyName = "modelNo";
            this.dgvtxtModelNo.HeaderText = "Modal No.";
            this.dgvtxtModelNo.Name = "dgvtxtModelNo";
            this.dgvtxtModelNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRate
            // 
            this.dgvtxtRate.DataPropertyName = "salesRate";
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSalesRate
            // 
            this.dgvtxtSalesRate.DataPropertyName = "purchaseRate";
            this.dgvtxtSalesRate.HeaderText = "PurchaseRate";
            this.dgvtxtSalesRate.Name = "dgvtxtSalesRate";
            this.dgvtxtSalesRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesRate.Visible = false;
            // 
            // dgvtxtMRP
            // 
            this.dgvtxtMRP.DataPropertyName = "MRP";
            this.dgvtxtMRP.HeaderText = "MRP";
            this.dgvtxtMRP.Name = "dgvtxtMRP";
            this.dgvtxtMRP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(123, 15);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(14, 19);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 29;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(435, 15);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 2;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(344, 19);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 34;
            this.lblProductCode.Text = "Product Code";
            // 
            // cmbModelNo
            // 
            this.cmbModelNo.FormattingEnabled = true;
            this.cmbModelNo.Location = new System.Drawing.Point(123, 66);
            this.cmbModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelNo.Name = "cmbModelNo";
            this.cmbModelNo.Size = new System.Drawing.Size(200, 21);
            this.cmbModelNo.TabIndex = 5;
            this.cmbModelNo.SelectedIndexChanged += new System.EventHandler(this.cmbModelNo_SelectedIndexChanged);
            this.cmbModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelNo_KeyDown);
            // 
            // lblModelNo
            // 
            this.lblModelNo.AutoSize = true;
            this.lblModelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModelNo.Location = new System.Drawing.Point(14, 70);
            this.lblModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Size = new System.Drawing.Size(56, 13);
            this.lblModelNo.TabIndex = 36;
            this.lblModelNo.Text = "Modal No.";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(14, 44);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 32;
            this.lblProductGroup.Text = "Product Group";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(435, 40);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 21);
            this.cmbSize.TabIndex = 4;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            this.cmbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSize_KeyDown);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSize.Location = new System.Drawing.Point(343, 44);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 38;
            this.lblSize.Text = "Size";
            // 
            // frmProductSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(655, 400);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cmbModelNo);
            this.Controls.Add(this.lblModelNo);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.dgvProductSearchPopup);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductSearchPopup";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search Popup";
            this.Load += new System.EventHandler(this.frmProductSearchPopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductSearchPopup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearchPopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.DataGridView dgvProductSearchPopup;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbModelNo;
        private System.Windows.Forms.Label lblModelNo;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtModelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMRP;
    }
}