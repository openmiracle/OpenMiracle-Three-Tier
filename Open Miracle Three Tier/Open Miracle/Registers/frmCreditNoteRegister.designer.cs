namespace Open_Miracle
{
    partial class frmCreditNoteRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditNoteRegister));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dgvCreditNoteRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtcreditNoteMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSuffixPrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCreditNoteVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFinancialyearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtraDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExtra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditNoteRegister)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 6;
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
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(581, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 3;
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
            this.btnReset.Location = new System.Drawing.Point(672, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(124, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 2;
             this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(18, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1226;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(18, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1224;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(469, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1222;
            this.lblToDate.Text = "To Date";
            // 
            // dgvCreditNoteRegister
            // 
            this.dgvCreditNoteRegister.AllowUserToAddRows = false;
            this.dgvCreditNoteRegister.AllowUserToDeleteRows = false;
            this.dgvCreditNoteRegister.AllowUserToResizeColumns = false;
            this.dgvCreditNoteRegister.AllowUserToResizeRows = false;
            this.dgvCreditNoteRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditNoteRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvCreditNoteRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditNoteRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditNoteRegister.ColumnHeadersHeight = 35;
            this.dgvCreditNoteRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCreditNoteRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtVoucherNo,
            this.dgvtxtvoucherTypeName,
            this.dgvtxtDate,
            this.dgvtxtAmount,
            this.dgvtxtNarration,
            this.dgvtxtcreditNoteMasterId,
            this.dgvtxtSuffixPrefixId,
            this.dgvtxtUserId,
            this.dgvtxtCreditNoteVoucherTypeId,
            this.dgvtxtParty,
            this.dgvtxtExchangeRateId,
            this.dgvtxtFinancialyearId,
            this.dgvtxtExtraDate,
            this.dgvtxtExtra1,
            this.dgvtxtExtra2,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditNoteRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreditNoteRegister.EnableHeadersVisualStyles = false;
            this.dgvCreditNoteRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCreditNoteRegister.Location = new System.Drawing.Point(18, 99);
            this.dgvCreditNoteRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvCreditNoteRegister.Name = "dgvCreditNoteRegister";
            this.dgvCreditNoteRegister.RowHeadersVisible = false;
            this.dgvCreditNoteRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditNoteRegister.Size = new System.Drawing.Size(764, 453);
            this.dgvCreditNoteRegister.TabIndex = 5;
            this.dgvCreditNoteRegister.TabStop = false;
            this.dgvCreditNoteRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditNoteRegister_CellDoubleClick);
            this.dgvCreditNoteRegister.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCreditNoteRegister_CurrentCellDirtyStateChanged);
            this.dgvCreditNoteRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCreditNoteRegister_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtvoucherTypeName
            // 
            this.dgvtxtvoucherTypeName.DataPropertyName = "voucherTypeName";
            this.dgvtxtvoucherTypeName.HeaderText = "Voucher Name";
            this.dgvtxtvoucherTypeName.Name = "dgvtxtvoucherTypeName";
            this.dgvtxtvoucherTypeName.ReadOnly = true;
            this.dgvtxtvoucherTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtcreditNoteMasterId
            // 
            this.dgvtxtcreditNoteMasterId.DataPropertyName = "creditNoteMasterId";
            this.dgvtxtcreditNoteMasterId.HeaderText = "CreditNoteMasterId";
            this.dgvtxtcreditNoteMasterId.Name = "dgvtxtcreditNoteMasterId";
            this.dgvtxtcreditNoteMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtcreditNoteMasterId.Visible = false;
            // 
            // dgvtxtSuffixPrefixId
            // 
            this.dgvtxtSuffixPrefixId.DataPropertyName = "suffixprefixId";
            this.dgvtxtSuffixPrefixId.HeaderText = "SuffixPrefix Id";
            this.dgvtxtSuffixPrefixId.Name = "dgvtxtSuffixPrefixId";
            this.dgvtxtSuffixPrefixId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSuffixPrefixId.Visible = false;
            // 
            // dgvtxtUserId
            // 
            this.dgvtxtUserId.DataPropertyName = "userId";
            this.dgvtxtUserId.HeaderText = "User Id";
            this.dgvtxtUserId.Name = "dgvtxtUserId";
            this.dgvtxtUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUserId.Visible = false;
            // 
            // dgvtxtCreditNoteVoucherTypeId
            // 
            this.dgvtxtCreditNoteVoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvtxtCreditNoteVoucherTypeId.HeaderText = "VoucherTypeId";
            this.dgvtxtCreditNoteVoucherTypeId.Name = "dgvtxtCreditNoteVoucherTypeId";
            this.dgvtxtCreditNoteVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCreditNoteVoucherTypeId.Visible = false;
            // 
            // dgvtxtParty
            // 
            this.dgvtxtParty.DataPropertyName = "ledgerName";
            this.dgvtxtParty.HeaderText = "Party";
            this.dgvtxtParty.Name = "dgvtxtParty";
            this.dgvtxtParty.ReadOnly = true;
            this.dgvtxtParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtParty.Visible = false;
            // 
            // dgvtxtExchangeRateId
            // 
            this.dgvtxtExchangeRateId.DataPropertyName = "ExchangeRateId";
            this.dgvtxtExchangeRateId.HeaderText = "ExchangeRate Id";
            this.dgvtxtExchangeRateId.Name = "dgvtxtExchangeRateId";
            this.dgvtxtExchangeRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExchangeRateId.Visible = false;
            // 
            // dgvtxtFinancialyearId
            // 
            this.dgvtxtFinancialyearId.DataPropertyName = "financialYearId";
            this.dgvtxtFinancialyearId.HeaderText = "Financialyear Id";
            this.dgvtxtFinancialyearId.Name = "dgvtxtFinancialyearId";
            this.dgvtxtFinancialyearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtFinancialyearId.Visible = false;
            // 
            // dgvtxtExtraDate
            // 
            this.dgvtxtExtraDate.DataPropertyName = "extraDate";
            this.dgvtxtExtraDate.HeaderText = "Extra Date";
            this.dgvtxtExtraDate.Name = "dgvtxtExtraDate";
            this.dgvtxtExtraDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtraDate.Visible = false;
            // 
            // dgvtxtExtra1
            // 
            this.dgvtxtExtra1.DataPropertyName = "extra1";
            this.dgvtxtExtra1.HeaderText = "Extra1";
            this.dgvtxtExtra1.Name = "dgvtxtExtra1";
            this.dgvtxtExtra1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtra1.Visible = false;
            // 
            // dgvtxtExtra2
            // 
            this.dgvtxtExtra2.DataPropertyName = "extra2";
            this.dgvtxtExtra2.HeaderText = "Extra2";
            this.dgvtxtExtra2.Name = "dgvtxtExtra2";
            this.dgvtxtExtra2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExtra2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherNo";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(124, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(304, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1287;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(184, -113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 1288;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, -113);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(22, 20);
            this.dateTimePicker1.TabIndex = 1289;
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
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1290;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // frmCreditNoteRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dgvCreditNoteRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCreditNoteRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Note Register";
            this.Load += new System.EventHandler(this.frmCreditNoteRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreditNoteRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditNoteRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DataGridView dgvCreditNoteRegister;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtcreditNoteMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSuffixPrefixId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCreditNoteVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFinancialyearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtraDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExtra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}