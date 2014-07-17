namespace Open_Miracle
{
    partial class frmPDCClearanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDCClearanceReport));
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVClraranceReport = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDCClearanceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.againstId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClraranceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(472, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1279;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1277;
            this.label6.Text = "Voucher Type";
            // 
            // DGVClraranceReport
            // 
            this.DGVClraranceReport.AllowUserToAddRows = false;
            this.DGVClraranceReport.AllowUserToDeleteRows = false;
            this.DGVClraranceReport.AllowUserToResizeRows = false;
            this.DGVClraranceReport.BackgroundColor = System.Drawing.Color.White;
            this.DGVClraranceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVClraranceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVClraranceReport.ColumnHeadersHeight = 30;
            this.DGVClraranceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVClraranceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column6,
            this.PDCClearanceMasterId,
            this.voucherNo,
            this.voucherTypeId,
            this.userId,
            this.againstId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVClraranceReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVClraranceReport.EnableHeadersVisualStyles = false;
            this.DGVClraranceReport.GridColor = System.Drawing.Color.SteelBlue;
            this.DGVClraranceReport.Location = new System.Drawing.Point(18, 96);
            this.DGVClraranceReport.Name = "DGVClraranceReport";
            this.DGVClraranceReport.ReadOnly = true;
            this.DGVClraranceReport.RowHeadersVisible = false;
            this.DGVClraranceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClraranceReport.Size = new System.Drawing.Size(764, 459);
            this.DGVClraranceReport.TabIndex = 1275;
            this.DGVClraranceReport.TabStop = false;
            this.DGVClraranceReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClraranceReport_CellDoubleClick);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "slNo";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 95;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "type";
            this.Column1.HeaderText = "Voucher Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherNo";
            this.Column2.HeaderText = "Voucher No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 95;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Account Ledger";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 95;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 95;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 96;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "narration";
            this.Column7.HeaderText = "Narration";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 95;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "status";
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 95;
            // 
            // PDCClearanceMasterId
            // 
            this.PDCClearanceMasterId.DataPropertyName = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.HeaderText = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.Name = "PDCClearanceMasterId";
            this.PDCClearanceMasterId.ReadOnly = true;
            this.PDCClearanceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PDCClearanceMasterId.Visible = false;
            // 
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            this.voucherNo.HeaderText = "voucherNo";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            this.voucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherNo.Visible = false;
            // 
            // voucherTypeId
            // 
            this.voucherTypeId.DataPropertyName = "voucherTypeId";
            this.voucherTypeId.HeaderText = "voucherTypeId";
            this.voucherTypeId.Name = "voucherTypeId";
            this.voucherTypeId.ReadOnly = true;
            this.voucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.voucherTypeId.Visible = false;
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
            // againstId
            // 
            this.againstId.DataPropertyName = "againstId";
            this.againstId.HeaderText = "AgainstId";
            this.againstId.Name = "againstId";
            this.againstId.ReadOnly = true;
            this.againstId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.againstId.Visible = false;
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
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(579, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
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
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(127, 66);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 4;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountLedger.Location = new System.Drawing.Point(20, 70);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountLedger.TabIndex = 1266;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(472, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1281;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1283;
            this.lblFromDate.Text = "From Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(611, 561);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 26);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dtpFrmDate
            // 
            this.dtpFrmDate.Location = new System.Drawing.Point(306, 15);
            this.dtpFrmDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFrmDate.Name = "dtpFrmDate";
            this.dtpFrmDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFrmDate.TabIndex = 1466;
            this.dtpFrmDate.ValueChanged += new System.EventHandler(this.dtpFrmDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(579, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(182, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(579, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(702, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPDCClearanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGVClraranceReport);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPDCClearanceReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDC Clearance Report";
            this.Load += new System.EventHandler(this.frmPDCClearanceReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDCClearanceReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClraranceReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVClraranceReport;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDCClearanceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn againstId;
        private System.Windows.Forms.Button btnExport;
    }
}