namespace Open_Miracle
{
    partial class frmBarcodePrinting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodePrinting));
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblPurchaseInvoiceNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvBarcodePrinting = new System.Windows.Forms.DataGridView();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalCountValue = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.cmbPurchaseInvoiceNo = new System.Windows.Forms.ComboBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.dgvSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcodePrinting)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCode.Location = new System.Drawing.Point(140, 15);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(200, 21);
            this.cmbProductCode.TabIndex = 0;
            this.cmbProductCode.SelectedValueChanged += new System.EventHandler(this.cmbProductCode_SelectedValueChanged);
            this.cmbProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductCode_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.Color.White;
            this.lblProductCode.Location = new System.Drawing.Point(17, 19);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1154;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblPurchaseInvoiceNo
            // 
            this.lblPurchaseInvoiceNo.AutoSize = true;
            this.lblPurchaseInvoiceNo.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseInvoiceNo.Location = new System.Drawing.Point(17, 45);
            this.lblPurchaseInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPurchaseInvoiceNo.Name = "lblPurchaseInvoiceNo";
            this.lblPurchaseInvoiceNo.Size = new System.Drawing.Size(107, 13);
            this.lblPurchaseInvoiceNo.TabIndex = 1166;
            this.lblPurchaseInvoiceNo.Text = "Purchase Invoice No";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 40);
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
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(671, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // dgvBarcodePrinting
            // 
            this.dgvBarcodePrinting.AllowUserToAddRows = false;
            this.dgvBarcodePrinting.AllowUserToResizeColumns = false;
            this.dgvBarcodePrinting.AllowUserToResizeRows = false;
            this.dgvBarcodePrinting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarcodePrinting.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarcodePrinting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarcodePrinting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarcodePrinting.ColumnHeadersHeight = 35;
            this.dgvBarcodePrinting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarcodePrinting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSNo,
            this.dgvProductCode,
            this.dgvproductName,
            this.dgvBatch,
            this.dgvBarcode,
            this.dgvCurrentStock,
            this.dgvMRP,
            this.dgvCopies,
            this.dgvPurchaseRate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarcodePrinting.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBarcodePrinting.EnableHeadersVisualStyles = false;
            this.dgvBarcodePrinting.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBarcodePrinting.Location = new System.Drawing.Point(18, 73);
            this.dgvBarcodePrinting.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvBarcodePrinting.Name = "dgvBarcodePrinting";
            this.dgvBarcodePrinting.RowHeadersVisible = false;
            this.dgvBarcodePrinting.Size = new System.Drawing.Size(764, 452);
            this.dgvBarcodePrinting.TabIndex = 5;
            this.dgvBarcodePrinting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarcodePrinting_CellClick);
            this.dgvBarcodePrinting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarcodePrinting_CellValueChanged);
            this.dgvBarcodePrinting.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBarcodePrinting_CurrentCellDirtyStateChanged);
            this.dgvBarcodePrinting.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBarcodePrinting_EditingControlShowing);
            this.dgvBarcodePrinting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBarcodePrinting_KeyDown);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExportToPdf.FlatAppearance.BorderSize = 0;
            this.btnExportToPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportToPdf.Location = new System.Drawing.Point(605, 561);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(85, 27);
            this.btnExportToPdf.TabIndex = 7;
            this.btnExportToPdf.Text = "Export To PDF";
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(696, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(20, 535);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(62, 13);
            this.lblTotalCount.TabIndex = 1179;
            this.lblTotalCount.Text = "Total Count";
            // 
            // lblTotalCountValue
            // 
            this.lblTotalCountValue.AutoSize = true;
            this.lblTotalCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCountValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalCountValue.Location = new System.Drawing.Point(140, 535);
            this.lblTotalCountValue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalCountValue.Name = "lblTotalCountValue";
            this.lblTotalCountValue.Size = new System.Drawing.Size(16, 16);
            this.lblTotalCountValue.TabIndex = 1180;
            this.lblTotalCountValue.Text = "0";
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.Location = new System.Drawing.Point(580, 15);
            this.cmbBatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(200, 21);
            this.cmbBatch.TabIndex = 1;
            this.cmbBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatch_KeyDown);
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.ForeColor = System.Drawing.Color.White;
            this.lblBatch.Location = new System.Drawing.Point(474, 19);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(35, 13);
            this.lblBatch.TabIndex = 1182;
            this.lblBatch.Text = "Batch";
            // 
            // cmbPurchaseInvoiceNo
            // 
            this.cmbPurchaseInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseInvoiceNo.Location = new System.Drawing.Point(140, 41);
            this.cmbPurchaseInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPurchaseInvoiceNo.Name = "cmbPurchaseInvoiceNo";
            this.cmbPurchaseInvoiceNo.Size = new System.Drawing.Size(200, 21);
            this.cmbPurchaseInvoiceNo.TabIndex = 2;
            this.cmbPurchaseInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPurchaseInvoiceNo_KeyDown);
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.Items.AddRange(new object[] {
            "A4",
            "Thermal Printer"});
            this.cmbFormat.Location = new System.Drawing.Point(653, 532);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(129, 21);
            this.cmbFormat.TabIndex = 6;
            this.cmbFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFormat_KeyDown);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.ForeColor = System.Drawing.Color.White;
            this.lblFormat.Location = new System.Drawing.Point(530, 535);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(39, 13);
            this.lblFormat.TabIndex = 1185;
            this.lblFormat.Text = "Format";
            // 
            // dgvSNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvSNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSNo.HeaderText = "Sl No";
            this.dgvSNo.Name = "dgvSNo";
            this.dgvSNo.ReadOnly = true;
            this.dgvSNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvProductCode
            // 
            this.dgvProductCode.HeaderText = "Product Code";
            this.dgvProductCode.Name = "dgvProductCode";
            this.dgvProductCode.ReadOnly = true;
            this.dgvProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvproductName
            // 
            this.dgvproductName.HeaderText = "Product Name";
            this.dgvproductName.Name = "dgvproductName";
            this.dgvproductName.ReadOnly = true;
            this.dgvproductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvBatch
            // 
            this.dgvBatch.HeaderText = "Batch";
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.ReadOnly = true;
            this.dgvBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvBarcode
            // 
            this.dgvBarcode.HeaderText = "Barcode";
            this.dgvBarcode.Name = "dgvBarcode";
            this.dgvBarcode.ReadOnly = true;
            this.dgvBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCurrentStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCurrentStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrentStock.HeaderText = "Current Stock";
            this.dgvCurrentStock.Name = "dgvCurrentStock";
            this.dgvCurrentStock.ReadOnly = true;
            this.dgvCurrentStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvMRP
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvMRP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMRP.HeaderText = "MRP";
            this.dgvMRP.Name = "dgvMRP";
            this.dgvMRP.ReadOnly = true;
            this.dgvMRP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCopies
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCopies.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCopies.HeaderText = "Copies";
            this.dgvCopies.MaxInputLength = 3;
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPurchaseRate
            // 
            this.dgvPurchaseRate.HeaderText = "PurchaseRate";
            this.dgvPurchaseRate.Name = "dgvPurchaseRate";
            this.dgvPurchaseRate.ReadOnly = true;
            this.dgvPurchaseRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvPurchaseRate.Visible = false;
            // 
            // frmBarcodePrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.cmbPurchaseInvoiceNo);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblTotalCountValue);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBarcodePrinting);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPurchaseInvoiceNo);
            this.Controls.Add(this.cmbProductCode);
            this.Controls.Add(this.lblProductCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBarcodePrinting";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Printing";
            this.Load += new System.EventHandler(this.frmBarcodePrinting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBarcodePrinting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcodePrinting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblPurchaseInvoiceNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvBarcodePrinting;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalCountValue;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.ComboBox cmbPurchaseInvoiceNo;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPurchaseRate;
    }
}