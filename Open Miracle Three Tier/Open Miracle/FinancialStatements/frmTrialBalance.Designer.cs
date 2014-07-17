namespace Open_Miracle
{
    partial class frmTrialBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrialBalance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.dgvTrailBalance = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpTrialFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtTodate = new System.Windows.Forms.TextBox();
            this.ddtpTrialToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1155;
            this.label2.Text = "From date";
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(689, 526);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(85, 27);
            this.btnprint.TabIndex = 1153;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dgvTrailBalance
            // 
            this.dgvTrailBalance.AllowUserToAddRows = false;
            this.dgvTrailBalance.AllowUserToDeleteRows = false;
            this.dgvTrailBalance.AllowUserToResizeColumns = false;
            this.dgvTrailBalance.AllowUserToResizeRows = false;
            this.dgvTrailBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrailBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrailBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrailBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrailBalance.ColumnHeadersHeight = 35;
            this.dgvTrailBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTrailBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtAccountGroupId,
            this.accountGroupName,
            this.openingBalance,
            this.Debit,
            this.Credit,
            this.dgvtxtBalance,
            this.dgvtxtLedgerId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrailBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrailBalance.EnableHeadersVisualStyles = false;
            this.dgvTrailBalance.GridColor = System.Drawing.Color.White;
            this.dgvTrailBalance.Location = new System.Drawing.Point(18, 74);
            this.dgvTrailBalance.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvTrailBalance.Name = "dgvTrailBalance";
            this.dgvTrailBalance.ReadOnly = true;
            this.dgvTrailBalance.RowHeadersVisible = false;
            this.dgvTrailBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrailBalance.Size = new System.Drawing.Size(756, 444);
            this.dgvTrailBalance.TabIndex = 1152;
            this.dgvTrailBalance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrailBalance_CellDoubleClick);
            this.dgvTrailBalance.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTrailBalance_RowsAdded);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Sl No";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAccountGroupId
            // 
            this.dgvtxtAccountGroupId.DataPropertyName = "accountGroupId";
            this.dgvtxtAccountGroupId.HeaderText = "AccoundGroupId";
            this.dgvtxtAccountGroupId.Name = "dgvtxtAccountGroupId";
            this.dgvtxtAccountGroupId.ReadOnly = true;
            this.dgvtxtAccountGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAccountGroupId.Visible = false;
            // 
            // accountGroupName
            // 
            this.accountGroupName.DataPropertyName = "name";
            this.accountGroupName.HeaderText = "Particulars";
            this.accountGroupName.Name = "accountGroupName";
            this.accountGroupName.ReadOnly = true;
            this.accountGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // openingBalance
            // 
            this.openingBalance.DataPropertyName = "OpeningBalance";
            this.openingBalance.HeaderText = "Opening";
            this.openingBalance.Name = "openingBalance";
            this.openingBalance.ReadOnly = true;
            this.openingBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Debit
            // 
            this.Debit.DataPropertyName = "debit";
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "credit";
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBalance
            // 
            this.dgvtxtBalance.DataPropertyName = "Balance";
            this.dgvtxtBalance.HeaderText = "Balance";
            this.dgvtxtBalance.Name = "dgvtxtBalance";
            this.dgvtxtBalance.ReadOnly = true;
            this.dgvtxtBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "ledgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1157;
            this.label3.Text = "To date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(574, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 1158;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(665, 41);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 27);
            this.btnclear.TabIndex = 1159;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(136, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(178, 20);
            this.txtFromDate.TabIndex = 1161;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpTrialFromDate
            // 
            this.dtpTrialFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTrialFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTrialFromDate.Location = new System.Drawing.Point(314, 15);
            this.dtpTrialFromDate.Name = "dtpTrialFromDate";
            this.dtpTrialFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpTrialFromDate.TabIndex = 1162;
            this.dtpTrialFromDate.ValueChanged += new System.EventHandler(this.dtpTrialFromDate_ValueChanged);
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(574, 15);
            this.txtTodate.Margin = new System.Windows.Forms.Padding(5);
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(178, 20);
            this.txtTodate.TabIndex = 1163;
            this.txtTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTodate_KeyDown);
            this.txtTodate.Leave += new System.EventHandler(this.txtTodate_Leave);
            // 
            // ddtpTrialToDate
            // 
            this.ddtpTrialToDate.CustomFormat = "dd-MMM-yyyy";
            this.ddtpTrialToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddtpTrialToDate.Location = new System.Drawing.Point(752, 15);
            this.ddtpTrialToDate.Name = "ddtpTrialToDate";
            this.ddtpTrialToDate.Size = new System.Drawing.Size(22, 20);
            this.ddtpTrialToDate.TabIndex = 1164;
            this.ddtpTrialToDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmTrialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.txtTodate);
            this.Controls.Add(this.ddtpTrialToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpTrialFromDate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dgvTrailBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTrialBalance";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trial Balance";
            this.Load += new System.EventHandler(this.frmTrialBalance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrialBalance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridView dgvTrailBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpTrialFromDate;
        private System.Windows.Forms.TextBox txtTodate;
        private System.Windows.Forms.DateTimePicker ddtpTrialToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
    }
}