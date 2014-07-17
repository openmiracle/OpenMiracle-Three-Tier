namespace Open_Miracle
{
    partial class frmStockJournalRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockJournalRegister));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefersh = new System.Windows.Forms.Button();
            this.dgvStockJournalRegister = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDeatils = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStockJournalMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockJournalRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "From Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(20, 40);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 9;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(120, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(475, 19);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 11;
            this.lblToDate.Text = "To Date";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(672, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefersh
            // 
            this.btnRefersh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefersh.FlatAppearance.BorderSize = 0;
            this.btnRefersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefersh.ForeColor = System.Drawing.Color.White;
            this.btnRefersh.Location = new System.Drawing.Point(581, 40);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(85, 27);
            this.btnRefersh.TabIndex = 3;
            this.btnRefersh.Text = "Search";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            this.btnRefersh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefersh_KeyDown);
            // 
            // dgvStockJournalRegister
            // 
            this.dgvStockJournalRegister.AllowUserToAddRows = false;
            this.dgvStockJournalRegister.AllowUserToDeleteRows = false;
            this.dgvStockJournalRegister.AllowUserToResizeRows = false;
            this.dgvStockJournalRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockJournalRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockJournalRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockJournalRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockJournalRegister.ColumnHeadersHeight = 35;
            this.dgvStockJournalRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockJournalRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSNo,
            this.dgvtxtStockJournalMasterId,
            this.dgvVoucherNo,
            this.dgvTxtVoucherType,
            this.dgvTxtNarration,
            this.dgvTxtVoucherDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockJournalRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockJournalRegister.EnableHeadersVisualStyles = false;
            this.dgvStockJournalRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStockJournalRegister.Location = new System.Drawing.Point(18, 73);
            this.dgvStockJournalRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvStockJournalRegister.Name = "dgvStockJournalRegister";
            this.dgvStockJournalRegister.ReadOnly = true;
            this.dgvStockJournalRegister.RowHeadersVisible = false;
            this.dgvStockJournalRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockJournalRegister.Size = new System.Drawing.Size(764, 479);
            this.dgvStockJournalRegister.TabIndex = 5;
            this.dgvStockJournalRegister.TabStop = false;
            this.dgvStockJournalRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockJournalRegister_CellDoubleClick);
            this.dgvStockJournalRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStockJournalRegister_KeyDown);
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
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDeatils
            // 
            this.btnViewDeatils.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDeatils.FlatAppearance.BorderSize = 0;
            this.btnViewDeatils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDeatils.ForeColor = System.Drawing.Color.White;
            this.btnViewDeatils.Location = new System.Drawing.Point(606, 560);
            this.btnViewDeatils.Name = "btnViewDeatils";
            this.btnViewDeatils.Size = new System.Drawing.Size(85, 27);
            this.btnViewDeatils.TabIndex = 5;
            this.btnViewDeatils.Text = "View Details";
            this.btnViewDeatils.UseVisualStyleBackColor = true;
            this.btnViewDeatils.Click += new System.EventHandler(this.btnViewDeatils_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(581, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(300, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 1288;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1291;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dgvSNo
            // 
            this.dgvSNo.DataPropertyName = "slNo";
            this.dgvSNo.HeaderText = "Sl No";
            this.dgvSNo.Name = "dgvSNo";
            this.dgvSNo.ReadOnly = true;
            this.dgvSNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStockJournalMasterId
            // 
            this.dgvtxtStockJournalMasterId.DataPropertyName = "stockJournalMasterId";
            this.dgvtxtStockJournalMasterId.HeaderText = "StockJournalMasterId";
            this.dgvtxtStockJournalMasterId.Name = "dgvtxtStockJournalMasterId";
            this.dgvtxtStockJournalMasterId.ReadOnly = true;
            this.dgvtxtStockJournalMasterId.Visible = false;
            // 
            // dgvVoucherNo
            // 
            this.dgvVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvVoucherNo.HeaderText = "Voucher No";
            this.dgvVoucherNo.Name = "dgvVoucherNo";
            this.dgvVoucherNo.ReadOnly = true;
            this.dgvVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtVoucherType
            // 
            this.dgvTxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvTxtVoucherType.HeaderText = "VoucherType";
            this.dgvTxtVoucherType.Name = "dgvTxtVoucherType";
            this.dgvTxtVoucherType.ReadOnly = true;
            this.dgvTxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtNarration
            // 
            this.dgvTxtNarration.DataPropertyName = "narration";
            this.dgvTxtNarration.HeaderText = "Narration";
            this.dgvTxtNarration.Name = "dgvTxtNarration";
            this.dgvTxtNarration.ReadOnly = true;
            this.dgvTxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtVoucherDate
            // 
            this.dgvTxtVoucherDate.DataPropertyName = "date";
            this.dgvTxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvTxtVoucherDate.Name = "dgvTxtVoucherDate";
            this.dgvTxtVoucherDate.ReadOnly = true;
            this.dgvTxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmStockJournalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnViewDeatils);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStockJournalRegister);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStockJournalRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Journal Register";
            this.Load += new System.EventHandler(this.frmStockJournalRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockJournalRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockJournalRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.DataGridView dgvStockJournalRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDeatils;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStockJournalMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtVoucherDate;
    }
}