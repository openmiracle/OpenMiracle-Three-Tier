namespace Open_Miracle
{
    partial class frmAgainstBillDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgainstBillDetails));
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.dgvAgainstBillDetails = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVoucherTypeName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgainstBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(20, 19);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 168;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // dgvAgainstBillDetails
            // 
            this.dgvAgainstBillDetails.AllowUserToResizeRows = false;
            this.dgvAgainstBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgainstBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgainstBillDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgainstBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgainstBillDetails.ColumnHeadersHeight = 25;
            this.dgvAgainstBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAgainstBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.dgvtxtvoucherTypeId,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtPendingAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgainstBillDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgainstBillDetails.EnableHeadersVisualStyles = false;
            this.dgvAgainstBillDetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAgainstBillDetails.Location = new System.Drawing.Point(18, 49);
            this.dgvAgainstBillDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvAgainstBillDetails.Name = "dgvAgainstBillDetails";
            this.dgvAgainstBillDetails.RowHeadersVisible = false;
            this.dgvAgainstBillDetails.Size = new System.Drawing.Size(764, 531);
            this.dgvAgainstBillDetails.TabIndex = 166;
            this.dgvAgainstBillDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgainstBillDetails_CellDoubleClick);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.DataPropertyName = "Sl.No";
            this.dgvtxtSlno.HeaderText = "SlNo";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtvoucherTypeId
            // 
            this.dgvtxtvoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvtxtvoucherTypeId.HeaderText = "voucherTypeId";
            this.dgvtxtvoucherTypeId.Name = "dgvtxtvoucherTypeId";
            this.dgvtxtvoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvoucherTypeId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "VoucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "voucherNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No.";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPendingAmount
            // 
            this.dgvtxtPendingAmount.DataPropertyName = "balance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtPendingAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtPendingAmount.HeaderText = "Pending Amount";
            this.dgvtxtPendingAmount.Name = "dgvtxtPendingAmount";
            this.dgvtxtPendingAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(130, 15);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.MaxDropDownItems = 20;
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 169;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(435, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1147;
            this.label1.Text = "VoucherType Name";
            // 
            // cmbVoucherTypeName
            // 
            this.cmbVoucherTypeName.FormattingEnabled = true;
            this.cmbVoucherTypeName.Location = new System.Drawing.Point(547, 12);
            this.cmbVoucherTypeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherTypeName.Name = "cmbVoucherTypeName";
            this.cmbVoucherTypeName.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherTypeName.TabIndex = 1148;
            // 
            // frmAgainstBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbVoucherTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.dgvAgainstBillDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAgainstBillDetails";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Against Bill Details";
            this.Load += new System.EventHandler(this.frmAgainstBillDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgainstBillDetails_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgainstBillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private dgv.DataGridViewEnter dgvAgainstBillDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVoucherTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPendingAmount;
    }
}