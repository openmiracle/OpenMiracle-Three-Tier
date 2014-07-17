namespace Open_Miracle
{
    partial class frmMaterialReceiptRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialReceiptRegister));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMaterialReceiptNo = new System.Windows.Forms.TextBox();
            this.lblMaterialReceiptNo = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMaterialReceiptRegister = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPOVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMaterialReceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialReceiptRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1199;
            this.label2.Text = "From Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1197;
            this.label4.Text = "To Date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(580, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // txtMaterialReceiptNo
            // 
            this.txtMaterialReceiptNo.Location = new System.Drawing.Point(580, 40);
            this.txtMaterialReceiptNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtMaterialReceiptNo.Name = "txtMaterialReceiptNo";
            this.txtMaterialReceiptNo.Size = new System.Drawing.Size(200, 20);
            this.txtMaterialReceiptNo.TabIndex = 3;
            this.txtMaterialReceiptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaterialReceiptNo_KeyDown);
            // 
            // lblMaterialReceiptNo
            // 
            this.lblMaterialReceiptNo.AutoSize = true;
            this.lblMaterialReceiptNo.ForeColor = System.Drawing.Color.White;
            this.lblMaterialReceiptNo.Location = new System.Drawing.Point(474, 44);
            this.lblMaterialReceiptNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMaterialReceiptNo.Name = "lblMaterialReceiptNo";
            this.lblMaterialReceiptNo.Size = new System.Drawing.Size(95, 13);
            this.lblMaterialReceiptNo.TabIndex = 1206;
            this.lblMaterialReceiptNo.Text = "MaterialReceiptNo";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(121, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1204;
            this.label3.Text = "Cash / Party";
            // 
            // dgvMaterialReceiptRegister
            // 
            this.dgvMaterialReceiptRegister.AllowUserToAddRows = false;
            this.dgvMaterialReceiptRegister.AllowUserToResizeRows = false;
            this.dgvMaterialReceiptRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialReceiptRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterialReceiptRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterialReceiptRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterialReceiptRegister.ColumnHeadersHeight = 35;
            this.dgvMaterialReceiptRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterialReceiptRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.voucherTypeName,
            this.dgvtxtPOVoucherTypeId,
            this.exchangeRateId,
            this.dgvtxtMaterialReceiptMasterId,
            this.Column3,
            this.Column4,
            this.dgvtxtBillAmount,
            this.Column7,
            this.Column6,
            this.currencyId,
            this.Column8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialReceiptRegister.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterialReceiptRegister.EnableHeadersVisualStyles = false;
            this.dgvMaterialReceiptRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMaterialReceiptRegister.Location = new System.Drawing.Point(18, 96);
            this.dgvMaterialReceiptRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvMaterialReceiptRegister.Name = "dgvMaterialReceiptRegister";
            this.dgvMaterialReceiptRegister.ReadOnly = true;
            this.dgvMaterialReceiptRegister.RowHeadersVisible = false;
            this.dgvMaterialReceiptRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialReceiptRegister.Size = new System.Drawing.Size(764, 456);
            this.dgvMaterialReceiptRegister.TabIndex = 8;
            this.dgvMaterialReceiptRegister.TabStop = false;
            this.dgvMaterialReceiptRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialReceiptRegister_CellDoubleClick);
            this.dgvMaterialReceiptRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMaterialReceiptRegister_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SL.NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 66.55386F;
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.FillWeight = 66.55386F;
            this.Column2.HeaderText = "Material Receipt No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // voucherTypeName
            // 
            this.voucherTypeName.DataPropertyName = "voucherTypeName";
            this.voucherTypeName.HeaderText = "Voucher Type";
            this.voucherTypeName.Name = "voucherTypeName";
            this.voucherTypeName.ReadOnly = true;
            this.voucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPOVoucherTypeId
            // 
            this.dgvtxtPOVoucherTypeId.DataPropertyName = "purchaseOrderVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.HeaderText = "purcahseOrderVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.Name = "dgvtxtPOVoucherTypeId";
            this.dgvtxtPOVoucherTypeId.ReadOnly = true;
            this.dgvtxtPOVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPOVoucherTypeId.Visible = false;
            // 
            // exchangeRateId
            // 
            this.exchangeRateId.DataPropertyName = "exchangeRateId";
            this.exchangeRateId.HeaderText = "exchangerateId";
            this.exchangeRateId.Name = "exchangeRateId";
            this.exchangeRateId.ReadOnly = true;
            this.exchangeRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exchangeRateId.Visible = false;
            // 
            // dgvtxtMaterialReceiptMasterId
            // 
            this.dgvtxtMaterialReceiptMasterId.DataPropertyName = "materialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.HeaderText = "MaterialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.Name = "dgvtxtMaterialReceiptMasterId";
            this.dgvtxtMaterialReceiptMasterId.ReadOnly = true;
            this.dgvtxtMaterialReceiptMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMaterialReceiptMasterId.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.FillWeight = 66.55386F;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.FillWeight = 66.55386F;
            this.Column4.HeaderText = "Cash / Party";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtBillAmount.FillWeight = 66.55386F;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "currencyName";
            this.Column7.FillWeight = 66.55386F;
            this.Column7.HeaderText = "Currency";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "narration";
            this.Column6.FillWeight = 66.55386F;
            this.Column6.HeaderText = "Narration";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // currencyId
            // 
            this.currencyId.DataPropertyName = "currencyId";
            this.currencyId.HeaderText = "currencyId";
            this.currencyId.Name = "currencyId";
            this.currencyId.ReadOnly = true;
            this.currencyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.currencyId.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "userName";
            this.Column8.FillWeight = 66.55386F;
            this.Column8.HeaderText = "Done By";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
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
            this.btnViewDetails.TabIndex = 6;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewDetails_KeyDown);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(303, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1278;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(121, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(183, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(762, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1280;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(183, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // frmMaterialReceiptRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvMaterialReceiptRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMaterialReceiptNo);
            this.Controls.Add(this.lblMaterialReceiptNo);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMaterialReceiptRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Receipt Register";
            this.Load += new System.EventHandler(this.frmMaterialReceiptRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMaterialReceiptRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialReceiptRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMaterialReceiptNo;
        private System.Windows.Forms.Label lblMaterialReceiptNo;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMaterialReceiptRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPOVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMaterialReceiptMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}