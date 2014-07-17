namespace Open_Miracle
{
    partial class frmServiceVoucherRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceVoucherRegister));
            this.dgvServiceVoucherRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServiceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceVoucherRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceVoucherRegister
            // 
            this.dgvServiceVoucherRegister.AllowUserToAddRows = false;
            this.dgvServiceVoucherRegister.AllowUserToResizeRows = false;
            this.dgvServiceVoucherRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceVoucherRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceVoucherRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceVoucherRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceVoucherRegister.ColumnHeadersHeight = 35;
            this.dgvServiceVoucherRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceVoucherRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSerialNo,
            this.dgvtxtServiceMasterId,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtTotalAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceVoucherRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceVoucherRegister.EnableHeadersVisualStyles = false;
            this.dgvServiceVoucherRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServiceVoucherRegister.Location = new System.Drawing.Point(18, 100);
            this.dgvServiceVoucherRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvServiceVoucherRegister.MultiSelect = false;
            this.dgvServiceVoucherRegister.Name = "dgvServiceVoucherRegister";
            this.dgvServiceVoucherRegister.ReadOnly = true;
            this.dgvServiceVoucherRegister.RowHeadersVisible = false;
            this.dgvServiceVoucherRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceVoucherRegister.Size = new System.Drawing.Size(764, 452);
            this.dgvServiceVoucherRegister.TabIndex = 6;
            this.dgvServiceVoucherRegister.TabStop = false;
            this.dgvServiceVoucherRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceVoucherRegister_CellDoubleClick);
            this.dgvServiceVoucherRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvServiceVoucherRegister_KeyDown);
            // 
            // dgvtxtSerialNo
            // 
            this.dgvtxtSerialNo.DataPropertyName = "SlNo";
            this.dgvtxtSerialNo.HeaderText = "Sl No";
            this.dgvtxtSerialNo.Name = "dgvtxtSerialNo";
            this.dgvtxtSerialNo.ReadOnly = true;
            this.dgvtxtSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtServiceMasterId
            // 
            this.dgvtxtServiceMasterId.DataPropertyName = "serviceMasterId";
            this.dgvtxtServiceMasterId.HeaderText = "ServiceMasterId";
            this.dgvtxtServiceMasterId.Name = "dgvtxtServiceMasterId";
            this.dgvtxtServiceMasterId.ReadOnly = true;
            this.dgvtxtServiceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtServiceMasterId.Visible = false;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "voucherNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherDate
            // 
            this.dgvtxtVoucherDate.DataPropertyName = "date";
            this.dgvtxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvtxtVoucherDate.Name = "dgvtxtVoucherDate";
            this.dgvtxtVoucherDate.ReadOnly = true;
            this.dgvtxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTotalAmount
            // 
            this.dgvtxtTotalAmount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtTotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtTotalAmount.HeaderText = "Total Amount";
            this.dgvtxtTotalAmount.Name = "dgvtxtTotalAmount";
            this.dgvtxtTotalAmount.ReadOnly = true;
            this.dgvtxtTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btnRefresh.Location = new System.Drawing.Point(580, 67);
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
            this.btnReset.Location = new System.Drawing.Point(671, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(126, 41);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(20, 45);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1269;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(580, 41);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(474, 45);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1267;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1265;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(474, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1263;
            this.lblToDate.Text = "To Date";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(126, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(179, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(304, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1277;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1279;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // frmServiceVoucherRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvServiceVoucherRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmServiceVoucherRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Voucher Register";
            this.Load += new System.EventHandler(this.frmServiceVoucherRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceVoucherRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceVoucherRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceVoucherRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalAmount;
    }
}