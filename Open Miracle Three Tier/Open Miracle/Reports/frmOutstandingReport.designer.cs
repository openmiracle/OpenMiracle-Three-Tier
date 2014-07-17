namespace Open_Miracle
{
    partial class frmOutstandingReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutstandingReport));
            this.lblParty = new System.Windows.Forms.Label();
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvOutstanding = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbldebit = new System.Windows.Forms.Label();
            this.lblcreditTotal = new System.Windows.Forms.Label();
            this.txtfromdate = new System.Windows.Forms.TextBox();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.txttodate = new System.Windows.Forms.TextBox();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.lbldebitTotal = new System.Windows.Forms.Label();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutstanding)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblParty.Location = new System.Drawing.Point(21, 41);
            this.lblParty.Margin = new System.Windows.Forms.Padding(5);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(31, 13);
            this.lblParty.TabIndex = 1272;
            this.lblParty.Text = "Party";
            // 
            // cmbParty
            // 
            this.cmbParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParty.Enabled = false;
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(137, 37);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(200, 21);
            this.cmbParty.TabIndex = 2;
            this.cmbParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbParty_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(467, 17);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1269;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(20, 17);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1267;
            this.lblFromDate.Text = "From Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(137, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
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
            this.btnReset.Location = new System.Drawing.Point(230, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvOutstanding
            // 
            this.dgvOutstanding.AllowUserToAddRows = false;
            this.dgvOutstanding.AllowUserToDeleteRows = false;
            this.dgvOutstanding.AllowUserToResizeRows = false;
            this.dgvOutstanding.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutstanding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutstanding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutstanding.ColumnHeadersHeight = 35;
            this.dgvOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutstanding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtParty,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtDebit,
            this.dgvtxtCredit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutstanding.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOutstanding.EnableHeadersVisualStyles = false;
            this.dgvOutstanding.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvOutstanding.Location = new System.Drawing.Point(21, 97);
            this.dgvOutstanding.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvOutstanding.Name = "dgvOutstanding";
            this.dgvOutstanding.ReadOnly = true;
            this.dgvOutstanding.RowHeadersVisible = false;
            this.dgvOutstanding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutstanding.Size = new System.Drawing.Size(761, 438);
            this.dgvOutstanding.TabIndex = 7;
            this.dgvOutstanding.TabStop = false;
            this.dgvOutstanding.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOutstanding_RowsAdded);
            // 
            // dgvtxtslno
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtslno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtslno.Width = 152;
            // 
            // dgvtxtParty
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtParty.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtParty.HeaderText = "Party";
            this.dgvtxtParty.Name = "dgvtxtParty";
            this.dgvtxtParty.ReadOnly = true;
            this.dgvtxtParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtParty.Width = 151;
            // 
            // dgvtxtVoucherType
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtVoucherType.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherType.Width = 152;
            // 
            // dgvtxtVoucherNo
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtVoucherNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Visible = false;
            this.dgvtxtVoucherNo.Width = 126;
            // 
            // dgvtxtDebit
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtDebit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtDebit.HeaderText = "Debit";
            this.dgvtxtDebit.Name = "dgvtxtDebit";
            this.dgvtxtDebit.ReadOnly = true;
            this.dgvtxtDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDebit.Width = 151;
            // 
            // dgvtxtCredit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtCredit.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtxtCredit.HeaderText = "Credit";
            this.dgvtxtCredit.Name = "dgvtxtCredit";
            this.dgvtxtCredit.ReadOnly = true;
            this.dgvtxtCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCredit.Width = 152;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(21, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbldebit
            // 
            this.lbldebit.AutoSize = true;
            this.lbldebit.Enabled = false;
            this.lbldebit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldebit.Location = new System.Drawing.Point(574, 561);
            this.lbldebit.Margin = new System.Windows.Forms.Padding(5);
            this.lbldebit.Name = "lbldebit";
            this.lbldebit.Size = new System.Drawing.Size(0, 13);
            this.lbldebit.TabIndex = 1285;
            // 
            // lblcreditTotal
            // 
            this.lblcreditTotal.AutoSize = true;
            this.lblcreditTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreditTotal.ForeColor = System.Drawing.Color.White;
            this.lblcreditTotal.Location = new System.Drawing.Point(553, 543);
            this.lblcreditTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblcreditTotal.Name = "lblcreditTotal";
            this.lblcreditTotal.Size = new System.Drawing.Size(73, 16);
            this.lblcreditTotal.TabIndex = 1288;
            this.lblcreditTotal.Text = "Total Credit";
            this.lblcreditTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfromdate
            // 
            this.txtfromdate.Location = new System.Drawing.Point(137, 13);
            this.txtfromdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtfromdate.Name = "txtfromdate";
            this.txtfromdate.Size = new System.Drawing.Size(183, 20);
            this.txtfromdate.TabIndex = 0;
            this.txtfromdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfromdate_KeyDown);
            this.txtfromdate.Leave += new System.EventHandler(this.txtfromdate_Leave);
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.CustomFormat = "dd-MMM-YYYY";
            this.dtpfromdate.Location = new System.Drawing.Point(319, 13);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(20, 20);
            this.dtpfromdate.TabIndex = 1485;
            this.dtpfromdate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtpfromdate.ValueChanged += new System.EventHandler(this.dtpfromdate_ValueChanged);
            // 
            // txttodate
            // 
            this.txttodate.Location = new System.Drawing.Point(580, 13);
            this.txttodate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txttodate.Name = "txttodate";
            this.txttodate.Size = new System.Drawing.Size(183, 20);
            this.txttodate.TabIndex = 1;
            this.txttodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttodate_KeyDown);
            this.txttodate.Leave += new System.EventHandler(this.txttodate_Leave);
            // 
            // dtptodate
            // 
            this.dtptodate.CustomFormat = "dd-MMM-YYYY";
            this.dtptodate.Location = new System.Drawing.Point(762, 13);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(20, 20);
            this.dtptodate.TabIndex = 1487;
            this.dtptodate.Value = new System.DateTime(2013, 5, 22, 10, 44, 0, 0);
            this.dtptodate.ValueChanged += new System.EventHandler(this.dtptodate_ValueChanged);
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Location = new System.Drawing.Point(682, 541);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.ReadOnly = true;
            this.txtTotalCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCredit.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCredit.TabIndex = 1489;
            // 
            // lbldebitTotal
            // 
            this.lbldebitTotal.AutoSize = true;
            this.lbldebitTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebitTotal.ForeColor = System.Drawing.Color.White;
            this.lbldebitTotal.Location = new System.Drawing.Point(553, 569);
            this.lbldebitTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lbldebitTotal.Name = "lbldebitTotal";
            this.lbldebitTotal.Size = new System.Drawing.Size(69, 16);
            this.lbldebitTotal.TabIndex = 1490;
            this.lbldebitTotal.Text = "Total Debit";
            this.lbldebitTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.Location = new System.Drawing.Point(682, 567);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalDebit.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDebit.TabIndex = 1491;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(112, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmOutstandingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.lbldebitTotal);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.txttodate);
            this.Controls.Add(this.dtptodate);
            this.Controls.Add(this.txtfromdate);
            this.Controls.Add(this.dtpfromdate);
            this.Controls.Add(this.lblcreditTotal);
            this.Controls.Add(this.lbldebit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvOutstanding);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmOutstandingReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outstanding Report";
            this.Load += new System.EventHandler(this.frmOutstandingReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOutstandingReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutstanding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvOutstanding;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbldebit;
        private System.Windows.Forms.Label lblcreditTotal;
        private System.Windows.Forms.TextBox txtfromdate;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.TextBox txttodate;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.Label lbldebitTotal;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCredit;
        private System.Windows.Forms.Button btnExport;
    }
}