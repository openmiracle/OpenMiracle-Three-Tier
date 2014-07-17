namespace Open_Miracle
{
    partial class frmDeliveryNoteRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryNoteRegister));
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewdetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDeliveryNoteRegister = new System.Windows.Forms.DataGridView();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeliveryNoteNo = new System.Windows.Forms.TextBox();
            this.siNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDeliveryNoteMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxOrderOrQuotationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNoteRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(580, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(163, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1162;
            this.label4.Text = "Cash / Party";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1160;
            this.label8.Text = "Delivery Note No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1157;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1155;
            this.label2.Text = "From Date";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(669, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(578, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnViewdetails
            // 
            this.btnViewdetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewdetails.FlatAppearance.BorderSize = 0;
            this.btnViewdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewdetails.ForeColor = System.Drawing.Color.White;
            this.btnViewdetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewdetails.Name = "btnViewdetails";
            this.btnViewdetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewdetails.TabIndex = 6;
            this.btnViewdetails.Text = "View Details";
            this.btnViewdetails.UseVisualStyleBackColor = true;
            this.btnViewdetails.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnViewdetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewdetails_KeyDown);
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
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // dgvDeliveryNoteRegister
            // 
            this.dgvDeliveryNoteRegister.AllowUserToAddRows = false;
            this.dgvDeliveryNoteRegister.AllowUserToDeleteRows = false;
            this.dgvDeliveryNoteRegister.AllowUserToResizeColumns = false;
            this.dgvDeliveryNoteRegister.AllowUserToResizeRows = false;
            this.dgvDeliveryNoteRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeliveryNoteRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryNoteRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveryNoteRegister.ColumnHeadersHeight = 45;
            this.dgvDeliveryNoteRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeliveryNoteRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siNo,
            this.Column1,
            this.Column2,
            this.dgvtxtDeliveryNoteMasterId,
            this.deliveryNoteNo,
            this.dgvtxtDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtAmount,
            this.dgvtxtCurrency,
            this.dgvtxOrderOrQuotationNo,
            this.dgvtxtNarration,
            this.dgvtxtDoneBy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveryNoteRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeliveryNoteRegister.EnableHeadersVisualStyles = false;
            this.dgvDeliveryNoteRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDeliveryNoteRegister.Location = new System.Drawing.Point(18, 97);
            this.dgvDeliveryNoteRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvDeliveryNoteRegister.Name = "dgvDeliveryNoteRegister";
            this.dgvDeliveryNoteRegister.ReadOnly = true;
            this.dgvDeliveryNoteRegister.RowHeadersVisible = false;
            this.dgvDeliveryNoteRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryNoteRegister.Size = new System.Drawing.Size(764, 455);
            this.dgvDeliveryNoteRegister.TabIndex = 1167;
            this.dgvDeliveryNoteRegister.TabStop = false;
            this.dgvDeliveryNoteRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryNoteRegister_CellDoubleClick);
            this.dgvDeliveryNoteRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDeliveryNoteRegister_KeyDown);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 14);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(163, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(721, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 0;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(141, 16);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(163, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(284, 16);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(20, 20);
            this.dtpFromDate.TabIndex = 0;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtDeliveryNoteNo
            // 
            this.txtDeliveryNoteNo.Location = new System.Drawing.Point(141, 42);
            this.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo";
            this.txtDeliveryNoteNo.Size = new System.Drawing.Size(163, 20);
            this.txtDeliveryNoteNo.TabIndex = 1168;
            this.txtDeliveryNoteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliveryNoteNo_KeyDown);
            // 
            // siNo
            // 
            this.siNo.DataPropertyName = "slNo";
            this.siNo.FillWeight = 70.9137F;
            this.siNo.HeaderText = "SINo";
            this.siNo.Name = "siNo";
            this.siNo.ReadOnly = true;
            this.siNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.siNo.Width = 66;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "invoiceNo";
            this.Column1.FillWeight = 70.9137F;
            this.Column1.HeaderText = "VoucherNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 71;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherTypeName";
            this.Column2.HeaderText = "VoucherType";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 94;
            // 
            // dgvtxtDeliveryNoteMasterId
            // 
            this.dgvtxtDeliveryNoteMasterId.DataPropertyName = "deliveryNoteMasterId";
            this.dgvtxtDeliveryNoteMasterId.HeaderText = "ID";
            this.dgvtxtDeliveryNoteMasterId.Name = "dgvtxtDeliveryNoteMasterId";
            this.dgvtxtDeliveryNoteMasterId.ReadOnly = true;
            this.dgvtxtDeliveryNoteMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDeliveryNoteMasterId.Visible = false;
            // 
            // deliveryNoteNo
            // 
            this.deliveryNoteNo.DataPropertyName = "invoiceNo";
            this.deliveryNoteNo.FillWeight = 70.9137F;
            this.deliveryNoteNo.HeaderText = "Delivery Note No";
            this.deliveryNoteNo.Name = "deliveryNoteNo";
            this.deliveryNoteNo.ReadOnly = true;
            this.deliveryNoteNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deliveryNoteNo.Width = 67;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.FillWeight = 70.9137F;
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDate.Width = 66;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "CashOrparty";
            this.dgvtxtCashOrParty.FillWeight = 70.9137F;
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCashOrParty.Width = 67;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.FillWeight = 70.9137F;
            this.dgvtxtAmount.HeaderText = "Bill Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 66;
            // 
            // dgvtxtCurrency
            // 
            this.dgvtxtCurrency.DataPropertyName = "currencyname";
            this.dgvtxtCurrency.FillWeight = 70.9137F;
            this.dgvtxtCurrency.HeaderText = "Currency";
            this.dgvtxtCurrency.Name = "dgvtxtCurrency";
            this.dgvtxtCurrency.ReadOnly = true;
            this.dgvtxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrency.Width = 67;
            // 
            // dgvtxOrderOrQuotationNo
            // 
            this.dgvtxOrderOrQuotationNo.DataPropertyName = "OrderNoOrQuotationNo";
            this.dgvtxOrderOrQuotationNo.FillWeight = 70.9137F;
            this.dgvtxOrderOrQuotationNo.HeaderText = "Quotation No / Order No";
            this.dgvtxOrderOrQuotationNo.Name = "dgvtxOrderOrQuotationNo";
            this.dgvtxOrderOrQuotationNo.ReadOnly = true;
            this.dgvtxOrderOrQuotationNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxOrderOrQuotationNo.Width = 66;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.FillWeight = 70.9137F;
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 68;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.FillWeight = 70.9137F;
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDoneBy.Width = 67;
            // 
            // frmDeliveryNoteRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtDeliveryNoteNo);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dgvDeliveryNoteRegister);
            this.Controls.Add(this.btnViewdetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDeliveryNoteRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Note Register";
            this.Load += new System.EventHandler(this.frmDeliveryNoteRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeliveryNoteRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNoteRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewdetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDeliveryNoteRegister;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtDeliveryNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn siNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDeliveryNoteMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxOrderOrQuotationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
    }
}