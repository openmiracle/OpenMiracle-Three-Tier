namespace Open_Miracle
{
    partial class frmContraReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContraReport));
            this.lblCashOrBank = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.dgvContraReport = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.rbtnWithdrawal = new System.Windows.Forms.RadioButton();
            this.cmbCashOrBank = new System.Windows.Forms.ComboBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCashOrBank
            // 
            this.lblCashOrBank.AutoSize = true;
            this.lblCashOrBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrBank.Location = new System.Drawing.Point(470, 41);
            this.lblCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrBank.Name = "lblCashOrBank";
            this.lblCashOrBank.Size = new System.Drawing.Size(61, 13);
            this.lblCashOrBank.TabIndex = 1224;
            this.lblCashOrBank.Text = "Cash/Bank";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(115, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(115, 37);
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
            this.btnPrint.Location = new System.Drawing.Point(604, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
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
            this.btnReset.Location = new System.Drawing.Point(206, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 41);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1216;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // dgvContraReport
            // 
            this.dgvContraReport.AllowUserToAddRows = false;
            this.dgvContraReport.AllowUserToResizeColumns = false;
            this.dgvContraReport.AllowUserToResizeRows = false;
            this.dgvContraReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContraReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvContraReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContraReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContraReport.ColumnHeadersHeight = 35;
            this.dgvContraReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContraReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.dgvtxtMasterId,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContraReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContraReport.EnableHeadersVisualStyles = false;
            this.dgvContraReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvContraReport.Location = new System.Drawing.Point(18, 119);
            this.dgvContraReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvContraReport.Name = "dgvContraReport";
            this.dgvContraReport.ReadOnly = true;
            this.dgvContraReport.RowHeadersVisible = false;
            this.dgvContraReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContraReport.Size = new System.Drawing.Size(764, 437);
            this.dgvContraReport.TabIndex = 9;
            this.dgvContraReport.TabStop = false;
            this.dgvContraReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContraReport_CellDoubleClick);
            this.dgvContraReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvContraReport_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtMasterId
            // 
            this.dgvtxtMasterId.DataPropertyName = "contraMasterId";
            this.dgvtxtMasterId.HeaderText = "masterId";
            this.dgvtxtMasterId.Name = "dgvtxtMasterId";
            this.dgvtxtMasterId.ReadOnly = true;
            this.dgvtxtMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMasterId.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherTypeName";
            this.Column2.HeaderText = "Voucher Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "invoiceNo";
            this.Column4.HeaderText = "Invoice No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "date";
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "userName";
            this.Column3.HeaderText = "Done By";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "narration";
            this.Column1.HeaderText = "Narration";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(470, 67);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1213;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(20, 67);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1221;
            this.lblFromDate.Text = "From Date";
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.ForeColor = System.Drawing.Color.White;
            this.rbtnDeposit.Location = new System.Drawing.Point(580, 16);
            this.rbtnDeposit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbtnDeposit.TabIndex = 0;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "Deposit";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            this.rbtnDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnDeposit_KeyDown);
            // 
            // rbtnWithdrawal
            // 
            this.rbtnWithdrawal.AutoSize = true;
            this.rbtnWithdrawal.ForeColor = System.Drawing.Color.White;
            this.rbtnWithdrawal.Location = new System.Drawing.Point(647, 16);
            this.rbtnWithdrawal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnWithdrawal.Name = "rbtnWithdrawal";
            this.rbtnWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.rbtnWithdrawal.TabIndex = 1;
            this.rbtnWithdrawal.TabStop = true;
            this.rbtnWithdrawal.Text = "Withdrawal";
            this.rbtnWithdrawal.UseVisualStyleBackColor = true;
            this.rbtnWithdrawal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnWithdrawal_KeyDown);
            // 
            // cmbCashOrBank
            // 
            this.cmbCashOrBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBank.FormattingEnabled = true;
            this.cmbCashOrBank.Location = new System.Drawing.Point(580, 37);
            this.cmbCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrBank.Name = "cmbCashOrBank";
            this.cmbCashOrBank.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrBank.TabIndex = 3;
            this.cmbCashOrBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBank_KeyDown);
            // 
            // txtFromDate
            // 
            this.txtFromDate.ForeColor = System.Drawing.Color.Red;
            this.txtFromDate.Location = new System.Drawing.Point(115, 63);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(183, 20);
            this.txtFromDate.TabIndex = 4;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpFromDate.Location = new System.Drawing.Point(295, 63);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1233;
            this.dtpFromDate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.ForeColor = System.Drawing.Color.Red;
            this.txtToDate.Location = new System.Drawing.Point(580, 63);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 5;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-YYYY";
            this.dtpToDate.Location = new System.Drawing.Point(760, 63);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1235;
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
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmContraReport
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
            this.Controls.Add(this.cmbCashOrBank);
            this.Controls.Add(this.rbtnWithdrawal);
            this.Controls.Add(this.rbtnDeposit);
            this.Controls.Add(this.lblCashOrBank);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.dgvContraReport);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmContraReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contra Report";
            this.Load += new System.EventHandler(this.frmContraReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContraReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCashOrBank;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.DataGridView dgvContraReport;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.RadioButton rbtnWithdrawal;
        private System.Windows.Forms.ComboBox cmbCashOrBank;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnExport;
    }
}