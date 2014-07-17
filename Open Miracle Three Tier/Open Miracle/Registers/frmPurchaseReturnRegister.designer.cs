namespace Open_Miracle
{
    partial class frmPurchaseReturnRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReturnRegister));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReturnNo = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPurchaseReturnRegister = new System.Windows.Forms.DataGridView();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblVoucherTypeRegister = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseReturnMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturnRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(585, 86);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(676, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(126, 66);
            this.cmbInvoiceNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(200, 21);
            this.cmbInvoiceNo.TabIndex = 4;
            this.cmbInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInvoiceNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1186;
            this.label4.Text = "Invoice No";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(126, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.SelectedValueChanged += new System.EventHandler(this.cmbCashOrParty_SelectedValueChanged);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1184;
            this.label8.Text = "Cash / Party";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1181;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1179;
            this.label2.Text = "From Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1190;
            this.label5.Text = "Return No";
            // 
            // txtReturnNo
            // 
            this.txtReturnNo.Location = new System.Drawing.Point(126, 93);
            this.txtReturnNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtReturnNo.Name = "txtReturnNo";
            this.txtReturnNo.Size = new System.Drawing.Size(200, 20);
            this.txtReturnNo.TabIndex = 5;
            this.txtReturnNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReturnNo_KeyDown);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(606, 560);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(85, 27);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPurchaseReturnRegister
            // 
            this.dgvPurchaseReturnRegister.AllowUserToAddRows = false;
            this.dgvPurchaseReturnRegister.AllowUserToResizeRows = false;
            this.dgvPurchaseReturnRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseReturnRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReturnRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseReturnRegister.ColumnHeadersHeight = 35;
            this.dgvPurchaseReturnRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseReturnRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvtxtPurchaseReturnMasterId,
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.dgvtxtGrandTotal,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.ExchangeRateId,
            this.CurrencyId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReturnRegister.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseReturnRegister.EnableHeadersVisualStyles = false;
            this.dgvPurchaseReturnRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseReturnRegister.Location = new System.Drawing.Point(18, 136);
            this.dgvPurchaseReturnRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvPurchaseReturnRegister.Name = "dgvPurchaseReturnRegister";
            this.dgvPurchaseReturnRegister.RowHeadersVisible = false;
            this.dgvPurchaseReturnRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseReturnRegister.Size = new System.Drawing.Size(764, 416);
            this.dgvPurchaseReturnRegister.TabIndex = 17;
            this.dgvPurchaseReturnRegister.TabStop = false;
            this.dgvPurchaseReturnRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseReturnRegister_CellDoubleClick);
            this.dgvPurchaseReturnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseReturnRegister_KeyDown);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(126, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "DD-MMM-YYYY";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(304, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 15;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(758, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 16;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // lblVoucherTypeRegister
            // 
            this.lblVoucherTypeRegister.AutoSize = true;
            this.lblVoucherTypeRegister.ForeColor = System.Drawing.Color.White;
            this.lblVoucherTypeRegister.Location = new System.Drawing.Point(474, 40);
            this.lblVoucherTypeRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherTypeRegister.Name = "lblVoucherTypeRegister";
            this.lblVoucherTypeRegister.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherTypeRegister.TabIndex = 1194;
            this.lblVoucherTypeRegister.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.Location = new System.Drawing.Point(580, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(202, 21);
            this.cmbVoucherType.TabIndex = 3;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "slNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 76;
            // 
            // dgvtxtPurchaseReturnMasterId
            // 
            this.dgvtxtPurchaseReturnMasterId.DataPropertyName = "purchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.HeaderText = "PurchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.Name = "dgvtxtPurchaseReturnMasterId";
            this.dgvtxtPurchaseReturnMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseReturnMasterId.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ReturnNo";
            this.Column2.HeaderText = "Return No";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "invoiceNo";
            this.Column10.HeaderText = "VoucherNo";
            this.Column10.Name = "Column10";
            this.Column10.Width = 76;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "voucherTypeName";
            this.Column11.HeaderText = "VoucherTypeName";
            this.Column11.Name = "Column11";
            this.Column11.Width = 76;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Cash / Party";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 76;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Bill Amount";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            this.Column5.Width = 77;
            // 
            // dgvtxtGrandTotal
            // 
            this.dgvtxtGrandTotal.DataPropertyName = "GrandTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtGrandTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtGrandTotal.HeaderText = "Grand Total";
            this.dgvtxtGrandTotal.MaxInputLength = 19;
            this.dgvtxtGrandTotal.Name = "dgvtxtGrandTotal";
            this.dgvtxtGrandTotal.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "currencyName";
            this.Column6.HeaderText = "Currency";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 76;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "AgainstInvoiceNo";
            this.Column7.HeaderText = "Invoice No";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 76;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "narration";
            this.Column8.HeaderText = "Narration";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 76;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "userName";
            this.Column9.HeaderText = "Done By";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 76;
            // 
            // ExchangeRateId
            // 
            this.ExchangeRateId.DataPropertyName = "exchangeRateId";
            this.ExchangeRateId.HeaderText = "ExchangeRateId";
            this.ExchangeRateId.Name = "ExchangeRateId";
            this.ExchangeRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExchangeRateId.Visible = false;
            // 
            // CurrencyId
            // 
            this.CurrencyId.DataPropertyName = "currencyId";
            this.CurrencyId.HeaderText = "CurrencyId";
            this.CurrencyId.Name = "CurrencyId";
            this.CurrencyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CurrencyId.Visible = false;
            // 
            // frmPurchaseReturnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblVoucherTypeRegister);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dgvPurchaseReturnRegister);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtReturnNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbInvoiceNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseReturnRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Return Register";
            this.Load += new System.EventHandler(this.frmPurchaseReturnRegister_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPurchaseReturnRegister_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturnRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReturnNo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPurchaseReturnRegister;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblVoucherTypeRegister;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseReturnMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyId;
    }
}