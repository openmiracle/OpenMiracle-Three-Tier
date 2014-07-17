namespace Open_Miracle
{
    partial class frmAccountGroupwiseReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountGroupwiseReport));
            this.dgvAccountGroupWiseReport = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalanceTotal = new System.Windows.Forms.Label();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPerticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroupWiseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccountGroupWiseReport
            // 
            this.dgvAccountGroupWiseReport.AllowUserToAddRows = false;
            this.dgvAccountGroupWiseReport.AllowUserToDeleteRows = false;
            this.dgvAccountGroupWiseReport.AllowUserToResizeRows = false;
            this.dgvAccountGroupWiseReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountGroupWiseReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountGroupWiseReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountGroupWiseReport.ColumnHeadersHeight = 35;
            this.dgvAccountGroupWiseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountGroupWiseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.balance1,
            this.dgvtxtAccountGroupId,
            this.dgvtxtLedgerId,
            this.dgvtxtPerticulars,
            this.dgvtxtOpening,
            this.dgvtxtDebit,
            this.dgvtxtCredit,
            this.dgvtxtClosing});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountGroupWiseReport.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAccountGroupWiseReport.EnableHeadersVisualStyles = false;
            this.dgvAccountGroupWiseReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAccountGroupWiseReport.Location = new System.Drawing.Point(21, 41);
            this.dgvAccountGroupWiseReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvAccountGroupWiseReport.Name = "dgvAccountGroupWiseReport";
            this.dgvAccountGroupWiseReport.ReadOnly = true;
            this.dgvAccountGroupWiseReport.RowHeadersVisible = false;
            this.dgvAccountGroupWiseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountGroupWiseReport.Size = new System.Drawing.Size(761, 525);
            this.dgvAccountGroupWiseReport.TabIndex = 1294;
            this.dgvAccountGroupWiseReport.TabStop = false;
            this.dgvAccountGroupWiseReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountGroupWiseReport_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(515, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1288;
            this.label5.Text = "To Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1286;
            this.label8.Text = "From Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(147, 13);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.ReadOnly = true;
            this.txtFromDate.Size = new System.Drawing.Size(200, 20);
            this.txtFromDate.TabIndex = 0;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(328, 13);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1302;
            this.dtpFromDate.Visible = false;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(760, 13);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1304;
            this.dtpToDate.Visible = false;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(582, 13);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.ReadOnly = true;
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.White;
            this.lblGroupName.Location = new System.Drawing.Point(312, 78);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(0, 19);
            this.lblGroupName.TabIndex = 1305;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(589, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1306;
            this.label1.Text = "Total : ";
            // 
            // lblBalanceTotal
            // 
            this.lblBalanceTotal.AutoSize = true;
            this.lblBalanceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblBalanceTotal.Location = new System.Drawing.Point(667, 574);
            this.lblBalanceTotal.Name = "lblBalanceTotal";
            this.lblBalanceTotal.Size = new System.Drawing.Size(51, 16);
            this.lblBalanceTotal.TabIndex = 1307;
            this.lblBalanceTotal.Text = "label1";
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 126;
            // 
            // balance1
            // 
            this.balance1.DataPropertyName = "balance1";
            this.balance1.HeaderText = "balance1";
            this.balance1.Name = "balance1";
            this.balance1.ReadOnly = true;
            this.balance1.Visible = false;
            // 
            // dgvtxtAccountGroupId
            // 
            this.dgvtxtAccountGroupId.DataPropertyName = "accountGroupId";
            this.dgvtxtAccountGroupId.HeaderText = "AccountGroupId";
            this.dgvtxtAccountGroupId.Name = "dgvtxtAccountGroupId";
            this.dgvtxtAccountGroupId.ReadOnly = true;
            this.dgvtxtAccountGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAccountGroupId.Visible = false;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "ledgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtPerticulars
            // 
            this.dgvtxtPerticulars.DataPropertyName = "name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtPerticulars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtPerticulars.HeaderText = "Particulars";
            this.dgvtxtPerticulars.Name = "dgvtxtPerticulars";
            this.dgvtxtPerticulars.ReadOnly = true;
            this.dgvtxtPerticulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPerticulars.Width = 127;
            // 
            // dgvtxtOpening
            // 
            this.dgvtxtOpening.DataPropertyName = "OpeningBalance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtOpening.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtOpening.HeaderText = "Opening";
            this.dgvtxtOpening.Name = "dgvtxtOpening";
            this.dgvtxtOpening.ReadOnly = true;
            this.dgvtxtOpening.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOpening.Width = 126;
            // 
            // dgvtxtDebit
            // 
            this.dgvtxtDebit.DataPropertyName = "debit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtDebit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtDebit.HeaderText = "Debit";
            this.dgvtxtDebit.Name = "dgvtxtDebit";
            this.dgvtxtDebit.ReadOnly = true;
            this.dgvtxtDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDebit.Width = 126;
            // 
            // dgvtxtCredit
            // 
            this.dgvtxtCredit.DataPropertyName = "credit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtCredit.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtCredit.HeaderText = "Credit";
            this.dgvtxtCredit.Name = "dgvtxtCredit";
            this.dgvtxtCredit.ReadOnly = true;
            this.dgvtxtCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCredit.Width = 127;
            // 
            // dgvtxtClosing
            // 
            this.dgvtxtClosing.DataPropertyName = "Balance";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtClosing.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtClosing.HeaderText = "Closing";
            this.dgvtxtClosing.Name = "dgvtxtClosing";
            this.dgvtxtClosing.ReadOnly = true;
            this.dgvtxtClosing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtClosing.Width = 126;
            // 
            // frmAccountGroupwiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblBalanceTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvAccountGroupWiseReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountGroupwiseReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Groupwise Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountGroupwiseReport_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountGroupwiseReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountGroupwiseReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroupWiseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountGroupWiseReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalanceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPerticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpening;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClosing;
    }
}