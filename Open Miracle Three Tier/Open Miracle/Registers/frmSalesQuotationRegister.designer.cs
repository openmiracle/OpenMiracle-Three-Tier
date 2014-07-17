namespace Open_Miracle
{
    partial class frmSalesQuotationRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesQuotationRegister));
            this.rbtnApproved = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rbtnPending = new System.Windows.Forms.RadioButton();
            this.lblQuotationNo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvSalesQuotationRegister = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerIdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtquotationMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuotationNo = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesQuotationRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnApproved
            // 
            this.rbtnApproved.AutoSize = true;
            this.rbtnApproved.ForeColor = System.Drawing.Color.White;
            this.rbtnApproved.Location = new System.Drawing.Point(172, 38);
            this.rbtnApproved.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnApproved.Name = "rbtnApproved";
            this.rbtnApproved.Size = new System.Drawing.Size(74, 17);
            this.rbtnApproved.TabIndex = 3;
            this.rbtnApproved.TabStop = true;
            this.rbtnApproved.Text = "Approved ";
            this.rbtnApproved.UseVisualStyleBackColor = true;
             this.rbtnApproved.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnApproved_KeyDown);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(130, 38);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 2;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnAll_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(582, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 7;
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
            this.btnReset.Location = new System.Drawing.Point(673, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(582, 38);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 5;
           this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(476, 42);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1186;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(476, 19);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1181;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(18, 19);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1179;
            this.lblFromDate.Text = "From Date";
            // 
            // rbtnPending
            // 
            this.rbtnPending.AutoSize = true;
            this.rbtnPending.ForeColor = System.Drawing.Color.White;
            this.rbtnPending.Location = new System.Drawing.Point(247, 38);
            this.rbtnPending.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.rbtnPending.Name = "rbtnPending";
            this.rbtnPending.Size = new System.Drawing.Size(64, 17);
            this.rbtnPending.TabIndex = 4;
            this.rbtnPending.TabStop = true;
            this.rbtnPending.Text = "Pending";
            this.rbtnPending.UseVisualStyleBackColor = true;
             this.rbtnPending.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnPending_KeyDown);
            // 
            // lblQuotationNo
            // 
            this.lblQuotationNo.AutoSize = true;
            this.lblQuotationNo.ForeColor = System.Drawing.Color.White;
            this.lblQuotationNo.Location = new System.Drawing.Point(18, 57);
            this.lblQuotationNo.Name = "lblQuotationNo";
            this.lblQuotationNo.Size = new System.Drawing.Size(70, 13);
            this.lblQuotationNo.TabIndex = 1194;
            this.lblQuotationNo.Text = "Quotation No";
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
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnViewDetails.TabIndex = 9;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvSalesQuotationRegister
            // 
            this.dgvSalesQuotationRegister.AllowUserToAddRows = false;
            this.dgvSalesQuotationRegister.AllowUserToResizeRows = false;
            this.dgvSalesQuotationRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesQuotationRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesQuotationRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesQuotationRegister.ColumnHeadersHeight = 35;
            this.dgvSalesQuotationRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesQuotationRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.LedgerIdone,
            this.dgvtxtquotationMasterId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesQuotationRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesQuotationRegister.EnableHeadersVisualStyles = false;
            this.dgvSalesQuotationRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesQuotationRegister.Location = new System.Drawing.Point(18, 105);
            this.dgvSalesQuotationRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSalesQuotationRegister.Name = "dgvSalesQuotationRegister";
            this.dgvSalesQuotationRegister.ReadOnly = true;
            this.dgvSalesQuotationRegister.RowHeadersVisible = false;
            this.dgvSalesQuotationRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesQuotationRegister.Size = new System.Drawing.Size(764, 447);
            this.dgvSalesQuotationRegister.TabIndex = 14;
            this.dgvSalesQuotationRegister.TabStop = false;
            this.dgvSalesQuotationRegister.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvSalesQuotationRegister_CellContextMenuStripNeeded);
            this.dgvSalesQuotationRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesQuotationRegister_CellDoubleClick);
            this.dgvSalesQuotationRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesQuotationRegister_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SL.NO";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 76;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "invoiceNo";
            this.Column9.HeaderText = "VoucherNo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 76;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "voucherTypeName";
            this.Column10.HeaderText = "VoucherTypeName";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 76;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.HeaderText = "Quotation No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Cash / Party";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 77;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Bill Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 76;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "narration";
            this.Column6.HeaderText = "Narration";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 76;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "approved";
            this.Column7.HeaderText = "Approved";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 76;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "userName";
            this.Column8.HeaderText = "Done By";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 76;
            // 
            // LedgerIdone
            // 
            this.LedgerIdone.DataPropertyName = "ledgerId";
            this.LedgerIdone.HeaderText = "LedgerId";
            this.LedgerIdone.Name = "LedgerIdone";
            this.LedgerIdone.ReadOnly = true;
            this.LedgerIdone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LedgerIdone.Visible = false;
            // 
            // dgvtxtquotationMasterId
            // 
            this.dgvtxtquotationMasterId.DataPropertyName = "quotationMasterId";
            this.dgvtxtquotationMasterId.HeaderText = "quotationMasterId";
            this.dgvtxtquotationMasterId.Name = "dgvtxtquotationMasterId";
            this.dgvtxtquotationMasterId.ReadOnly = true;
            this.dgvtxtquotationMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtquotationMasterId.Visible = false;
            // 
            // txtQuotationNo
            // 
            this.txtQuotationNo.Location = new System.Drawing.Point(130, 57);
            this.txtQuotationNo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtQuotationNo.Name = "txtQuotationNo";
            this.txtQuotationNo.Size = new System.Drawing.Size(200, 20);
            this.txtQuotationNo.TabIndex = 6;
             this.txtQuotationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuotationNo_KeyDown);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(130, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Location = new System.Drawing.Point(308, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(582, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 4;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // frmSalesQuotationRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtQuotationNo);
            this.Controls.Add(this.dgvSalesQuotationRegister);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblQuotationNo);
            this.Controls.Add(this.rbtnPending);
            this.Controls.Add(this.rbtnApproved);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesQuotationRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Quotation Register";
            this.Load += new System.EventHandler(this.frmSalesQuotationRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesQuotationRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesQuotationRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnApproved;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RadioButton rbtnPending;
        private System.Windows.Forms.Label lblQuotationNo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DataGridView dgvSalesQuotationRegister;
        private System.Windows.Forms.TextBox txtQuotationNo;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerIdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtquotationMasterId;
    }
}