namespace Open_Miracle
{
    partial class frmServiceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceReport));
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.lblSalesman = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.dgvServiceReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgttxtNarrartion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServiceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToDate = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrParty.Location = new System.Drawing.Point(485, 44);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1163;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1160;
            this.lblFromDate.Text = "From Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(112, 66);
            this.cmbSalesman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesman.TabIndex = 4;
            this.cmbSalesman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesman_KeyDown);
            // 
            // lblSalesman
            // 
            this.lblSalesman.AutoSize = true;
            this.lblSalesman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesman.Location = new System.Drawing.Point(20, 70);
            this.lblSalesman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesman.Name = "lblSalesman";
            this.lblSalesman.Size = new System.Drawing.Size(53, 13);
            this.lblSalesman.TabIndex = 1151;
            this.lblSalesman.Text = "Salesman";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(112, 40);
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
            this.btnPrint.Location = new System.Drawing.Point(596, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(671, 66);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 44);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1145;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // dgvServiceReport
            // 
            this.dgvServiceReport.AllowUserToAddRows = false;
            this.dgvServiceReport.AllowUserToDeleteRows = false;
            this.dgvServiceReport.AllowUserToResizeRows = false;
            this.dgvServiceReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceReport.ColumnHeadersHeight = 35;
            this.dgvServiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSerialNo,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtDate,
            this.dgvtxAmount,
            this.dgvtxtSalesman,
            this.dgvtxtDoneBy,
            this.dgttxtNarrartion,
            this.dgvtxtServiceMasterId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceReport.EnableHeadersVisualStyles = false;
            this.dgvServiceReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServiceReport.Location = new System.Drawing.Point(18, 96);
            this.dgvServiceReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvServiceReport.MultiSelect = false;
            this.dgvServiceReport.Name = "dgvServiceReport";
            this.dgvServiceReport.ReadOnly = true;
            this.dgvServiceReport.RowHeadersVisible = false;
            this.dgvServiceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceReport.Size = new System.Drawing.Size(764, 456);
            this.dgvServiceReport.TabIndex = 8;
            this.dgvServiceReport.TabStop = false;
            this.dgvServiceReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceReport_CellDoubleClick);
            this.dgvServiceReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvServiceReport_KeyDown);
            // 
            // dgvtxtSerialNo
            // 
            this.dgvtxtSerialNo.DataPropertyName = "SlNo";
            this.dgvtxtSerialNo.HeaderText = "Sl No";
            this.dgvtxtSerialNo.Name = "dgvtxtSerialNo";
            this.dgvtxtSerialNo.ReadOnly = true;
            this.dgvtxtSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSerialNo.Width = 95;
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
            // dgvtxAmount
            // 
            this.dgvtxAmount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxAmount.HeaderText = "Amount";
            this.dgvtxAmount.Name = "dgvtxAmount";
            this.dgvtxAmount.ReadOnly = true;
            this.dgvtxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxAmount.Width = 95;
            // 
            // dgvtxtSalesman
            // 
            this.dgvtxtSalesman.DataPropertyName = "employeeName";
            this.dgvtxtSalesman.HeaderText = "Salesman";
            this.dgvtxtSalesman.Name = "dgvtxtSalesman";
            this.dgvtxtSalesman.ReadOnly = true;
            this.dgvtxtSalesman.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesman.Width = 95;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDoneBy.Width = 95;
            // 
            // dgttxtNarrartion
            // 
            this.dgttxtNarrartion.DataPropertyName = "narration";
            this.dgttxtNarrartion.HeaderText = "Narration";
            this.dgttxtNarrartion.Name = "dgttxtNarrartion";
            this.dgttxtNarrartion.ReadOnly = true;
            this.dgttxtNarrartion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgttxtNarrartion.Width = 95;
            // 
            // dgvtxtServiceMasterId
            // 
            this.dgvtxtServiceMasterId.DataPropertyName = "serviceMasterId";
            this.dgvtxtServiceMasterId.HeaderText = "Service Master Id";
            this.dgvtxtServiceMasterId.Name = "dgvtxtServiceMasterId";
            this.dgvtxtServiceMasterId.ReadOnly = true;
            this.dgvtxtServiceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtServiceMasterId.Visible = false;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(485, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1142;
            this.lblToDate.Text = "To Date";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(580, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1169;
            this.dtpToDate.CloseUp += new System.EventHandler(this.dtpToDate_CloseUp);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(112, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(200, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(292, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1171;
            this.dtpFromDate.CloseUp += new System.EventHandler(this.dtpFromDate_CloseUp);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(695, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSalesman);
            this.Controls.Add(this.lblSalesman);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.dgvServiceReport);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmServiceReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Report";
            this.Load += new System.EventHandler(this.frmServiceReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSalesman;
        private System.Windows.Forms.Label lblSalesman;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.DataGridView dgvServiceReport;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesman;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgttxtNarrartion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceMasterId;
        private System.Windows.Forms.Button btnExport;
    }
}