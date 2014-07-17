namespace Open_Miracle
{
    partial class frmAccountLedgerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLedgerReport));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAccountLedgerReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClosing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedgerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(471, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1244;
            this.label6.Text = "Account Ledger";
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(144, 38);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountGroup.TabIndex = 2;
            this.cmbAccountGroup.SelectedValueChanged += new System.EventHandler(this.cmbAccountGroup_SelectedValueChanged);
            this.cmbAccountGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountGroup_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1241;
            this.label5.Text = "Account group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(471, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1239;
            this.label4.Text = "To Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(22, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1238;
            this.label8.Text = "From Date";
            // 
            // dgvAccountLedgerReport
            // 
            this.dgvAccountLedgerReport.AllowUserToAddRows = false;
            this.dgvAccountLedgerReport.AllowUserToDeleteRows = false;
            this.dgvAccountLedgerReport.AllowUserToResizeRows = false;
            this.dgvAccountLedgerReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountLedgerReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountLedgerReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountLedgerReport.ColumnHeadersHeight = 35;
            this.dgvAccountLedgerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountLedgerReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxLedgerId,
            this.dgvtxtAccountLedger,
            this.dgvtxtOpening,
            this.Column2,
            this.dgvtxtDebit,
            this.dgvtxtCredit,
            this.dgvtxtClosing,
            this.dgvtxtClosing1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountLedgerReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountLedgerReport.EnableHeadersVisualStyles = false;
            this.dgvAccountLedgerReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAccountLedgerReport.Location = new System.Drawing.Point(21, 98);
            this.dgvAccountLedgerReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvAccountLedgerReport.Name = "dgvAccountLedgerReport";
            this.dgvAccountLedgerReport.ReadOnly = true;
            this.dgvAccountLedgerReport.RowHeadersVisible = false;
            this.dgvAccountLedgerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountLedgerReport.Size = new System.Drawing.Size(761, 456);
            this.dgvAccountLedgerReport.TabIndex = 1245;
            this.dgvAccountLedgerReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountLedgerReport_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "slNo";
            this.dgvtxtSlNo.HeaderText = "Sl.No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 126;
            // 
            // dgvtxLedgerId
            // 
            this.dgvtxLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxLedgerId.HeaderText = "Ledger Id";
            this.dgvtxLedgerId.Name = "dgvtxLedgerId";
            this.dgvtxLedgerId.ReadOnly = true;
            this.dgvtxLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxLedgerId.Visible = false;
            // 
            // dgvtxtAccountLedger
            // 
            this.dgvtxtAccountLedger.DataPropertyName = "ledgerName";
            this.dgvtxtAccountLedger.HeaderText = "Account Ledger";
            this.dgvtxtAccountLedger.Name = "dgvtxtAccountLedger";
            this.dgvtxtAccountLedger.ReadOnly = true;
            this.dgvtxtAccountLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAccountLedger.Width = 127;
            // 
            // dgvtxtOpening
            // 
            this.dgvtxtOpening.DataPropertyName = "Opening";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtOpening.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtOpening.HeaderText = "Opening";
            this.dgvtxtOpening.Name = "dgvtxtOpening";
            this.dgvtxtOpening.ReadOnly = true;
            this.dgvtxtOpening.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOpening.Width = 126;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "op";
            this.Column2.HeaderText = "Opening Balance";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Visible = false;
            // 
            // dgvtxtDebit
            // 
            this.dgvtxtDebit.DataPropertyName = "Debit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtDebit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtDebit.HeaderText = "Debit";
            this.dgvtxtDebit.Name = "dgvtxtDebit";
            this.dgvtxtDebit.ReadOnly = true;
            this.dgvtxtDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDebit.Width = 126;
            // 
            // dgvtxtCredit
            // 
            this.dgvtxtCredit.DataPropertyName = "Credit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtCredit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtCredit.HeaderText = "Credit";
            this.dgvtxtCredit.Name = "dgvtxtCredit";
            this.dgvtxtCredit.ReadOnly = true;
            this.dgvtxtCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCredit.Width = 127;
            // 
            // dgvtxtClosing
            // 
            this.dgvtxtClosing.DataPropertyName = "Closing";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtClosing.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtClosing.HeaderText = "Closing";
            this.dgvtxtClosing.Name = "dgvtxtClosing";
            this.dgvtxtClosing.ReadOnly = true;
            this.dgvtxtClosing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtClosing.Width = 126;
            // 
            // dgvtxtClosing1
            // 
            this.dgvtxtClosing1.DataPropertyName = "Closing1";
            this.dgvtxtClosing1.HeaderText = "closing1";
            this.dgvtxtClosing1.Name = "dgvtxtClosing1";
            this.dgvtxtClosing1.ReadOnly = true;
            this.dgvtxtClosing1.Visible = false;
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
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(582, 38);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 3;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(144, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(237, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalAmount.Location = new System.Drawing.Point(694, 560);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(33, 16);
            this.lblTotalAmount.TabIndex = 1251;
            this.lblTotalAmount.Text = "0.00";
            this.lblTotalAmount.Visible = false;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(322, 13);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1303;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(144, 13);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(200, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(760, 13);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1305;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(582, 13);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(622, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1306;
            this.label1.Text = "Total : ";
            this.label1.Visible = false;
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
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAccountLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvAccountLedgerReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountLedgerReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Ledger Report";
            this.Load += new System.EventHandler(this.frmAccountLedgerReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountLedgerReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedgerReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAccountLedgerReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpening;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClosing1;
        private System.Windows.Forms.Button btnExport;
    }
}