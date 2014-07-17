namespace Open_Miracle
{
    partial class frmReceiptReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptReport));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblvoucherType = new System.Windows.Forms.Label();
            this.dgvReceiptReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtReceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCashOrBank = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblCashOrBank = new System.Windows.Forms.Label();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.cmbLedger = new System.Windows.Forms.ComboBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(17, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1189;
            this.lblFromDate.Text = "From Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(127, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(127, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(603, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(218, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblvoucherType
            // 
            this.lblvoucherType.AutoSize = true;
            this.lblvoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvoucherType.Location = new System.Drawing.Point(17, 44);
            this.lblvoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblvoucherType.Name = "lblvoucherType";
            this.lblvoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblvoucherType.TabIndex = 1184;
            this.lblvoucherType.Text = "Voucher Type";
            // 
            // dgvReceiptReport
            // 
            this.dgvReceiptReport.AllowUserToAddRows = false;
            this.dgvReceiptReport.AllowUserToResizeRows = false;
            this.dgvReceiptReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptReport.ColumnHeadersHeight = 35;
            this.dgvReceiptReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtReceiptMasterId,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtDate,
            this.dgvtxtLedgerName,
            this.dgvtxtAmount,
            this.dgvtxtUserId,
            this.dgvtxtNarration,
            this.userId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiptReport.EnableHeadersVisualStyles = false;
            this.dgvReceiptReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReceiptReport.Location = new System.Drawing.Point(18, 123);
            this.dgvReceiptReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvReceiptReport.Name = "dgvReceiptReport";
            this.dgvReceiptReport.ReadOnly = true;
            this.dgvReceiptReport.RowHeadersVisible = false;
            this.dgvReceiptReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptReport.Size = new System.Drawing.Size(764, 428);
            this.dgvReceiptReport.TabIndex = 1183;
            this.dgvReceiptReport.TabStop = false;
            this.dgvReceiptReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptReport_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Sl.No";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 95;
            // 
            // dgvtxtReceiptMasterId
            // 
            this.dgvtxtReceiptMasterId.DataPropertyName = "receiptMasterId";
            this.dgvtxtReceiptMasterId.HeaderText = "receiptMasterId";
            this.dgvtxtReceiptMasterId.Name = "dgvtxtReceiptMasterId";
            this.dgvtxtReceiptMasterId.ReadOnly = true;
            this.dgvtxtReceiptMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtReceiptMasterId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherType.Width = 95;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "voucherNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Width = 95;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDate.Width = 96;
            // 
            // dgvtxtLedgerName
            // 
            this.dgvtxtLedgerName.DataPropertyName = "ledgerName";
            this.dgvtxtLedgerName.HeaderText = "Cash/Bank";
            this.dgvtxtLedgerName.Name = "dgvtxtLedgerName";
            this.dgvtxtLedgerName.ReadOnly = true;
            this.dgvtxtLedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerName.Width = 95;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 95;
            // 
            // dgvtxtUserId
            // 
            this.dgvtxtUserId.DataPropertyName = "userName";
            this.dgvtxtUserId.HeaderText = "Done By";
            this.dgvtxtUserId.Name = "dgvtxtUserId";
            this.dgvtxtUserId.ReadOnly = true;
            this.dgvtxtUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUserId.Width = 95;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 95;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "userId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userId.Visible = false;
            // 
            // cmbCashOrBank
            // 
            this.cmbCashOrBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBank.FormattingEnabled = true;
            this.cmbCashOrBank.Location = new System.Drawing.Point(580, 40);
            this.cmbCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrBank.Name = "cmbCashOrBank";
            this.cmbCashOrBank.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrBank.TabIndex = 3;
            this.cmbCashOrBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBank_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(460, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1181;
            this.lblToDate.Text = "To Date";
            // 
            // lblCashOrBank
            // 
            this.lblCashOrBank.AutoSize = true;
            this.lblCashOrBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrBank.Location = new System.Drawing.Point(460, 44);
            this.lblCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrBank.Name = "lblCashOrBank";
            this.lblCashOrBank.Size = new System.Drawing.Size(61, 13);
            this.lblCashOrBank.TabIndex = 1195;
            this.lblCashOrBank.Text = "Cash/Bank";
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountLedger.Location = new System.Drawing.Point(17, 70);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountLedger.TabIndex = 1197;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // cmbLedger
            // 
            this.cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLedger.FormattingEnabled = true;
            this.cmbLedger.Location = new System.Drawing.Point(127, 66);
            this.cmbLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbLedger.Name = "cmbLedger";
            this.cmbLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbLedger.TabIndex = 4;
            this.cmbLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLedger_KeyDown);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(183, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpFromDate.Location = new System.Drawing.Point(307, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1215;
            this.dtpFromDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
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
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1217;
            this.dtpToDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(697, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmReceiptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.cmbLedger);
            this.Controls.Add(this.lblCashOrBank);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblvoucherType);
            this.Controls.Add(this.dgvReceiptReport);
            this.Controls.Add(this.cmbCashOrBank);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmReceiptReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Report";
            this.Load += new System.EventHandler(this.frmReceptReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReceiptReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblvoucherType;
        private System.Windows.Forms.DataGridView dgvReceiptReport;
        private System.Windows.Forms.ComboBox cmbCashOrBank;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblCashOrBank;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.ComboBox cmbLedger;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtReceiptMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.Button btnExport;
    }
}