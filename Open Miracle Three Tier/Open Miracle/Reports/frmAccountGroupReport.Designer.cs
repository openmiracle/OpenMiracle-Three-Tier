namespace Open_Miracle
{
    partial class frmAccountGroupReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountGroupReport));
            this.dgvAccountGroupReport = new System.Windows.Forms.DataGridView();
            this.dgvtxtAccountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBalance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalanceTotal = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroupReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccountGroupReport
            // 
            this.dgvAccountGroupReport.AllowUserToAddRows = false;
            this.dgvAccountGroupReport.AllowUserToDeleteRows = false;
            this.dgvAccountGroupReport.AllowUserToResizeRows = false;
            this.dgvAccountGroupReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountGroupReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountGroupReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountGroupReport.ColumnHeadersHeight = 35;
            this.dgvAccountGroupReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountGroupReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtAccountGroupId,
            this.dgvtxtGroupname,
            this.dgvtxtOpeningBalance,
            this.dgvtxtDebit,
            this.dgvtxtCredit,
            this.dgvtxtBalance,
            this.dgvtxtBalance1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountGroupReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountGroupReport.EnableHeadersVisualStyles = false;
            this.dgvAccountGroupReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAccountGroupReport.Location = new System.Drawing.Point(18, 40);
            this.dgvAccountGroupReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvAccountGroupReport.Name = "dgvAccountGroupReport";
            this.dgvAccountGroupReport.ReadOnly = true;
            this.dgvAccountGroupReport.RowHeadersVisible = false;
            this.dgvAccountGroupReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountGroupReport.Size = new System.Drawing.Size(797, 425);
            this.dgvAccountGroupReport.TabIndex = 3;
            this.dgvAccountGroupReport.TabStop = false;
            this.dgvAccountGroupReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountGroupReport_CellDoubleClick);
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
            // dgvtxtGroupname
            // 
            this.dgvtxtGroupname.DataPropertyName = "accountGroupName";
            this.dgvtxtGroupname.HeaderText = "Group Name";
            this.dgvtxtGroupname.Name = "dgvtxtGroupname";
            this.dgvtxtGroupname.ReadOnly = true;
            this.dgvtxtGroupname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtGroupname.Width = 159;
            // 
            // dgvtxtOpeningBalance
            // 
            this.dgvtxtOpeningBalance.DataPropertyName = "OpeningBalance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtOpeningBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtOpeningBalance.HeaderText = "Opening Balance";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.ReadOnly = true;
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOpeningBalance.Width = 159;
            // 
            // dgvtxtDebit
            // 
            this.dgvtxtDebit.DataPropertyName = "debit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtDebit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtDebit.HeaderText = "Debit";
            this.dgvtxtDebit.Name = "dgvtxtDebit";
            this.dgvtxtDebit.ReadOnly = true;
            this.dgvtxtDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDebit.Width = 158;
            // 
            // dgvtxtCredit
            // 
            this.dgvtxtCredit.DataPropertyName = "credit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtCredit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtCredit.HeaderText = "Credit";
            this.dgvtxtCredit.Name = "dgvtxtCredit";
            this.dgvtxtCredit.ReadOnly = true;
            this.dgvtxtCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCredit.Width = 159;
            // 
            // dgvtxtBalance
            // 
            this.dgvtxtBalance.DataPropertyName = "balance";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtBalance.HeaderText = "Balance";
            this.dgvtxtBalance.Name = "dgvtxtBalance";
            this.dgvtxtBalance.ReadOnly = true;
            this.dgvtxtBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBalance.Width = 159;
            // 
            // dgvtxtBalance1
            // 
            this.dgvtxtBalance1.DataPropertyName = "balance1";
            this.dgvtxtBalance1.HeaderText = "balance1";
            this.dgvtxtBalance1.Name = "dgvtxtBalance1";
            this.dgvtxtBalance1.ReadOnly = true;
            this.dgvtxtBalance1.Visible = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(793, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 678;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(298, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 655;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(615, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(200, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1186;
            this.label4.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(517, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1185;
            this.label3.Text = "To Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(18, 475);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(610, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1188;
            this.label1.Text = "Total :";
            this.label1.Visible = false;
            // 
            // lblBalanceTotal
            // 
            this.lblBalanceTotal.AutoSize = true;
            this.lblBalanceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblBalanceTotal.Location = new System.Drawing.Point(688, 475);
            this.lblBalanceTotal.Name = "lblBalanceTotal";
            this.lblBalanceTotal.Size = new System.Drawing.Size(43, 16);
            this.lblBalanceTotal.TabIndex = 1189;
            this.lblBalanceTotal.Text = "label";
            this.lblBalanceTotal.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(109, 475);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAccountGroupReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(833, 515);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblBalanceTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAccountGroupReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountGroupReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Group Report";
            this.Load += new System.EventHandler(this.frmAccountGroupReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountGroupReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroupReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccountGroupReport;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalanceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBalance1;
        private System.Windows.Forms.Button btnExport;
    }
}