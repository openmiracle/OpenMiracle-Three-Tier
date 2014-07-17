namespace Open_Miracle
{
    partial class frmRejectionInRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRejectionInRegister));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCashorParty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRejectionInNo = new System.Windows.Forms.TextBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRejectionInRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRejectionInMaterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashorParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectionInRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To Date";
            // 
            // cmbCashorParty
            // 
            this.cmbCashorParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashorParty.Location = new System.Drawing.Point(129, 40);
            this.cmbCashorParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashorParty.Name = "cmbCashorParty";
            this.cmbCashorParty.Size = new System.Drawing.Size(198, 21);
            this.cmbCashorParty.TabIndex = 2;
            this.cmbCashorParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashorParty_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1154;
            this.label4.Text = "Cash / Party";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1155;
            this.label5.Text = "Rejection In No";
            // 
            // txtRejectionInNo
            // 
            this.txtRejectionInNo.Location = new System.Drawing.Point(583, 40);
            this.txtRejectionInNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRejectionInNo.Name = "txtRejectionInNo";
            this.txtRejectionInNo.Size = new System.Drawing.Size(197, 20);
            this.txtRejectionInNo.TabIndex = 3;
            this.txtRejectionInNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRejectionInNo_KeyDown);
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
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // dgvRejectionInRegister
            // 
            this.dgvRejectionInRegister.AllowUserToAddRows = false;
            this.dgvRejectionInRegister.AllowUserToDeleteRows = false;
            this.dgvRejectionInRegister.AllowUserToResizeColumns = false;
            this.dgvRejectionInRegister.AllowUserToResizeRows = false;
            this.dgvRejectionInRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRejectionInRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvRejectionInRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRejectionInRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRejectionInRegister.ColumnHeadersHeight = 35;
            this.dgvRejectionInRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRejectionInRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNO,
            this.dgvtxtRejectionInMaterId,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherDate,
            this.dgvtxtCashorParty,
            this.dgvtxtAmount,
            this.dgvtxtNarration,
            this.dgvtxtDoneby});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRejectionInRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRejectionInRegister.EnableHeadersVisualStyles = false;
            this.dgvRejectionInRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRejectionInRegister.Location = new System.Drawing.Point(18, 96);
            this.dgvRejectionInRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvRejectionInRegister.Name = "dgvRejectionInRegister";
            this.dgvRejectionInRegister.ReadOnly = true;
            this.dgvRejectionInRegister.RowHeadersVisible = false;
            this.dgvRejectionInRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRejectionInRegister.Size = new System.Drawing.Size(764, 456);
            this.dgvRejectionInRegister.TabIndex = 6;
            this.dgvRejectionInRegister.TabStop = false;
            this.dgvRejectionInRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRejectionInRegister_CellDoubleClick);
            this.dgvRejectionInRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRejectionInRegister_KeyDown);
            // 
            // dgvtxtSlNO
            // 
            this.dgvtxtSlNO.DataPropertyName = "slNo";
            this.dgvtxtSlNO.HeaderText = "Sl No";
            this.dgvtxtSlNO.Name = "dgvtxtSlNO";
            this.dgvtxtSlNO.ReadOnly = true;
            this.dgvtxtSlNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRejectionInMaterId
            // 
            this.dgvtxtRejectionInMaterId.DataPropertyName = "rejectionInMasterId";
            this.dgvtxtRejectionInMaterId.HeaderText = "RjctnInMstrId";
            this.dgvtxtRejectionInMaterId.Name = "dgvtxtRejectionInMaterId";
            this.dgvtxtRejectionInMaterId.ReadOnly = true;
            this.dgvtxtRejectionInMaterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRejectionInMaterId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // dgvtxtCashorParty
            // 
            this.dgvtxtCashorParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashorParty.HeaderText = "Cash / Party";
            this.dgvtxtCashorParty.Name = "dgvtxtCashorParty";
            this.dgvtxtCashorParty.ReadOnly = true;
            this.dgvtxtCashorParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDoneby
            // 
            this.dgvtxtDoneby.DataPropertyName = "userName";
            this.dgvtxtDoneby.HeaderText = "Done By";
            this.dgvtxtDoneby.Name = "dgvtxtDoneby";
            this.dgvtxtDoneby.ReadOnly = true;
            this.dgvtxtDoneby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(308, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1282;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(129, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(180, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(761, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(19, 20);
            this.dtpToDate.TabIndex = 1284;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(583, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(677, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(586, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.Location = new System.Drawing.Point(129, 67);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(198, 21);
            this.cmbVoucherType.TabIndex = 1285;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1286;
            this.label1.Text = "Voucher Type";
            // 
            // frmRejectionInRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvRejectionInRegister);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRejectionInNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCashorParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRejectionInRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejection In Register";
            this.Load += new System.EventHandler(this.frmRejectionInRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectionInRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCashorParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRejectionInNo;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRejectionInRegister;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRejectionInMaterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashorParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneby;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label1;
    }
}