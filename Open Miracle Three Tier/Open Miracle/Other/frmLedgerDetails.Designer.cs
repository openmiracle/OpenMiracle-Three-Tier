namespace Open_Miracle
{
    partial class frmLedgerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgerDetails));
            this.dgvLedgerDetails = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTypeOfVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLedgerDetails
            // 
            this.dgvLedgerDetails.AllowUserToAddRows = false;
            this.dgvLedgerDetails.AllowUserToDeleteRows = false;
            this.dgvLedgerDetails.AllowUserToResizeRows = false;
            this.dgvLedgerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLedgerDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvLedgerDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLedgerDetails.ColumnHeadersHeight = 35;
            this.dgvLedgerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLedgerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtMasterId,
            this.dgvtxtVoucherTypeId,
            this.dgvtxtpos,
            this.dgvtxtTypeOfVoucher,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtLedgerId,
            this.dgvtxtDate,
            this.dgvtxtDebit,
            this.dgvtxtCredit,
            this.dgvtxtBalance});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLedgerDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLedgerDetails.EnableHeadersVisualStyles = false;
            this.dgvLedgerDetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLedgerDetails.Location = new System.Drawing.Point(21, 40);
            this.dgvLedgerDetails.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvLedgerDetails.Name = "dgvLedgerDetails";
            this.dgvLedgerDetails.ReadOnly = true;
            this.dgvLedgerDetails.RowHeadersVisible = false;
            this.dgvLedgerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedgerDetails.Size = new System.Drawing.Size(801, 430);
            this.dgvLedgerDetails.TabIndex = 1246;
            this.dgvLedgerDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLedgerDetails_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "slNo";
            this.dgvtxtSlNo.HeaderText = "Sl.No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtMasterId
            // 
            this.dgvtxtMasterId.HeaderText = "MasterId";
            this.dgvtxtMasterId.Name = "dgvtxtMasterId";
            this.dgvtxtMasterId.ReadOnly = true;
            this.dgvtxtMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMasterId.Visible = false;
            // 
            // dgvtxtVoucherTypeId
            // 
            this.dgvtxtVoucherTypeId.HeaderText = "VoucherTypeId";
            this.dgvtxtVoucherTypeId.Name = "dgvtxtVoucherTypeId";
            this.dgvtxtVoucherTypeId.ReadOnly = true;
            this.dgvtxtVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherTypeId.Visible = false;
            // 
            // dgvtxtpos
            // 
            this.dgvtxtpos.HeaderText = "pos";
            this.dgvtxtpos.Name = "dgvtxtpos";
            this.dgvtxtpos.ReadOnly = true;
            this.dgvtxtpos.Visible = false;
            // 
            // dgvtxtTypeOfVoucher
            // 
            this.dgvtxtTypeOfVoucher.HeaderText = "TypeofVoucher";
            this.dgvtxtTypeOfVoucher.Name = "dgvtxtTypeOfVoucher";
            this.dgvtxtTypeOfVoucher.ReadOnly = true;
            this.dgvtxtTypeOfVoucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTypeOfVoucher.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.HeaderText = "VoucherType";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.HeaderText = "VoucherNo";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Visible = false;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "Ledger Id";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDebit
            // 
            this.dgvtxtDebit.DataPropertyName = "Debit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtDebit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtDebit.HeaderText = "Debit";
            this.dgvtxtDebit.Name = "dgvtxtDebit";
            this.dgvtxtDebit.ReadOnly = true;
            this.dgvtxtDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCredit
            // 
            this.dgvtxtCredit.DataPropertyName = "Credit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtCredit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtCredit.HeaderText = "Credit";
            this.dgvtxtCredit.Name = "dgvtxtCredit";
            this.dgvtxtCredit.ReadOnly = true;
            this.dgvtxtCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBalance
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBalance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtBalance.HeaderText = "Balance";
            this.dgvtxtBalance.Name = "dgvtxtBalance";
            this.dgvtxtBalance.ReadOnly = true;
            this.dgvtxtBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(798, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1312;
            this.dtpToDate.Visible = false;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(620, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.ReadOnly = true;
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1311;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(306, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1310;
            this.dtpFromDate.Visible = false;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(128, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.ReadOnly = true;
            this.txtFromDate.Size = new System.Drawing.Size(200, 20);
            this.txtFromDate.TabIndex = 1309;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(21, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1306;
            this.label8.Text = "From Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(524, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1307;
            this.label4.Text = "To Date";
            // 
            // frmLedgerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(840, 483);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLedgerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLedgerDetails";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLedgerDetails_FormClosing);
            //this.Load += new System.EventHandler(this.frmLedgerDetails_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLedgerDetails_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLedgerDetails;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTypeOfVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBalance;
    }
}