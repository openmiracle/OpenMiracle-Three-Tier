namespace Open_Miracle
{
    partial class frmPartyBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartyBalance));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPartyBalance = new Open_Miracle.dgv.DataGridViewEnter();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbReference = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbVoucherType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtCrDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPartyBalanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOldExchangeRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartyBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(673, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(582, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // dgvPartyBalance
            // 
            this.dgvPartyBalance.AllowUserToOrderColumns = true;
            this.dgvPartyBalance.AllowUserToResizeColumns = false;
            this.dgvPartyBalance.AllowUserToResizeRows = false;
            this.dgvPartyBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartyBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartyBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartyBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartyBalance.ColumnHeadersHeight = 35;
            this.dgvPartyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPartyBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvcmbReference,
            this.dgvtxtInvoiceNo,
            this.dgvcmbVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtPending,
            this.dgvtxtAmount,
            this.dgvcmbCurrency,
            this.dgvtxtCrDr,
            this.dgvtxtPartyBalanceId,
            this.dgvtxtOldExchangeRateId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartyBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPartyBalance.EnableHeadersVisualStyles = false;
            this.dgvPartyBalance.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPartyBalance.Location = new System.Drawing.Point(18, 13);
            this.dgvPartyBalance.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvPartyBalance.Name = "dgvPartyBalance";
            this.dgvPartyBalance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartyBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPartyBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPartyBalance.Size = new System.Drawing.Size(764, 492);
            this.dgvPartyBalance.TabIndex = 0;
            this.dgvPartyBalance.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPartyBalance_CellBeginEdit);
            this.dgvPartyBalance.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartyBalance_CellEnter);
            this.dgvPartyBalance.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartyBalance_CellLeave);
            this.dgvPartyBalance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartyBalance_CellValueChanged);
            this.dgvPartyBalance.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPartyBalance_CurrentCellDirtyStateChanged);
            this.dgvPartyBalance.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPartyBalance_DataError);
            this.dgvPartyBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPartyBalance_EditingControlShowing);
            this.dgvPartyBalance.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPartyBalance_RowsAdded);
            this.dgvPartyBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPartyBalance_KeyDown);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(582, 532);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 45674;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(472, 536);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 1096;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(733, 512);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 3;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "dgvtxtSlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbReference
            // 
            this.dgvcmbReference.DataPropertyName = "dgvcmbReference";
            this.dgvcmbReference.HeaderText = "Reference";
            this.dgvcmbReference.Name = "dgvcmbReference";
            this.dgvcmbReference.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtInvoiceNo
            // 
            this.dgvtxtInvoiceNo.DataPropertyName = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.HeaderText = "InvoiceNo";
            this.dgvtxtInvoiceNo.Name = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceNo.Visible = false;
            // 
            // dgvcmbVoucherType
            // 
            this.dgvcmbVoucherType.DataPropertyName = "dgvcmbVoucherType";
            this.dgvcmbVoucherType.HeaderText = "Voucher Type";
            this.dgvcmbVoucherType.Name = "dgvcmbVoucherType";
            this.dgvcmbVoucherType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No.";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPending
            // 
            this.dgvtxtPending.DataPropertyName = "dgvtxtPending";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtPending.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtPending.HeaderText = "Pending";
            this.dgvtxtPending.Name = "dgvtxtPending";
            this.dgvtxtPending.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtPending.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "dgvtxtAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 13;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.DataPropertyName = "dgvtxtCurrency";
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtCrDr
            // 
            this.dgvtxtCrDr.DataPropertyName = "dgvtxtCrDr";
            this.dgvtxtCrDr.HeaderText = "Cr/dr";
            this.dgvtxtCrDr.Name = "dgvtxtCrDr";
            this.dgvtxtCrDr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtCrDr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPartyBalanceId
            // 
            dataGridViewCellStyle4.NullValue = "0";
            this.dgvtxtPartyBalanceId.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtPartyBalanceId.HeaderText = "PartyBalanceId";
            this.dgvtxtPartyBalanceId.Name = "dgvtxtPartyBalanceId";
            this.dgvtxtPartyBalanceId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtPartyBalanceId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPartyBalanceId.Visible = false;
            // 
            // dgvtxtOldExchangeRateId
            // 
            this.dgvtxtOldExchangeRateId.HeaderText = "OldExchangeRateId";
            this.dgvtxtOldExchangeRateId.Name = "dgvtxtOldExchangeRateId";
            this.dgvtxtOldExchangeRateId.Visible = false;
            // 
            // frmPartyBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPartyBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPartyBalance";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartyBalance_FormClosing);
            this.Load += new System.EventHandler(this.frmPartyBalance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPartyBalance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartyBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        //private System.Windows.Forms.DataGridView dgvPartyBalance;
        private dgv.DataGridViewEnter dgvPartyBalance;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCrDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPartyBalanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOldExchangeRateId;
    }
}