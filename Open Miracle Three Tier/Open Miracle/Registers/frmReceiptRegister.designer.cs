namespace Open_Miracle
{
    partial class frmReceiptRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptRegister));
            this.dgvReceiptRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtledgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxttotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtReceiptMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvouchertypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblAccountledger = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceiptRegister
            // 
            this.dgvReceiptRegister.AllowUserToAddRows = false;
            this.dgvReceiptRegister.AllowUserToResizeColumns = false;
            this.dgvReceiptRegister.AllowUserToResizeRows = false;
            this.dgvReceiptRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptRegister.ColumnHeadersHeight = 35;
            this.dgvReceiptRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtVoucherNo,
            this.Column1,
            this.dgvtxtDate,
            this.dgvtxtledgerId,
            this.dgvtxttotalAmount,
            this.dgvtxtNarration,
            this.dgvtxtReceiptMasterId,
            this.dgvtxtvouchertypeId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiptRegister.EnableHeadersVisualStyles = false;
            this.dgvReceiptRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReceiptRegister.Location = new System.Drawing.Point(18, 96);
            this.dgvReceiptRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvReceiptRegister.Name = "dgvReceiptRegister";
            this.dgvReceiptRegister.ReadOnly = true;
            this.dgvReceiptRegister.RowHeadersVisible = false;
            this.dgvReceiptRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptRegister.Size = new System.Drawing.Size(764, 456);
            this.dgvReceiptRegister.TabIndex = 1275;
            this.dgvReceiptRegister.TabStop = false;
            this.dgvReceiptRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptRegister_CellDoubleClick);
            this.dgvReceiptRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvReceiptRegister_KeyDown);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "Sl.No";
            this.dgvtxtslno.HeaderText = "Sl No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "VoucherTypeName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = " Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtledgerId
            // 
            this.dgvtxtledgerId.DataPropertyName = "ledgerName";
            this.dgvtxtledgerId.HeaderText = "Cash/Bank";
            this.dgvtxtledgerId.Name = "dgvtxtledgerId";
            this.dgvtxtledgerId.ReadOnly = true;
            this.dgvtxtledgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxttotalAmount
            // 
            this.dgvtxttotalAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxttotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxttotalAmount.HeaderText = "Amount ";
            this.dgvtxttotalAmount.Name = "dgvtxttotalAmount";
            this.dgvtxttotalAmount.ReadOnly = true;
            this.dgvtxttotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtReceiptMasterId
            // 
            this.dgvtxtReceiptMasterId.DataPropertyName = "receiptMasterId";
            this.dgvtxtReceiptMasterId.HeaderText = "ReceiptMasterId";
            this.dgvtxtReceiptMasterId.Name = "dgvtxtReceiptMasterId";
            this.dgvtxtReceiptMasterId.ReadOnly = true;
            this.dgvtxtReceiptMasterId.Visible = false;
            // 
            // dgvtxtvouchertypeId
            // 
            this.dgvtxtvouchertypeId.DataPropertyName = "vouchertypeId";
            this.dgvtxtvouchertypeId.HeaderText = "vouchertypeId";
            this.dgvtxtvouchertypeId.Name = "dgvtxtvouchertypeId";
            this.dgvtxtvouchertypeId.ReadOnly = true;
            this.dgvtxtvouchertypeId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 6;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(583, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(674, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.FormattingEnabled = true;
            this.cmbAccountLedger.Location = new System.Drawing.Point(129, 40);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 2;
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblAccountledger
            // 
            this.lblAccountledger.AutoSize = true;
            this.lblAccountledger.ForeColor = System.Drawing.Color.White;
            this.lblAccountledger.Location = new System.Drawing.Point(23, 40);
            this.lblAccountledger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountledger.Name = "lblAccountledger";
            this.lblAccountledger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountledger.TabIndex = 1269;
            this.lblAccountledger.Text = "Account Ledger";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(581, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(476, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1267;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(475, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1263;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(23, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1294;
            this.lblFromDate.Text = "From Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(129, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(308, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1296;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(581, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1298;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // frmReceiptRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dgvReceiptRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountledger);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmReceiptRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Register";
            this.Load += new System.EventHandler(this.frmReceiptRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReceiptRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceiptRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblAccountledger;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtledgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxttotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtReceiptMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvouchertypeId;

    }
}