namespace Open_Miracle
{
    partial class frmOverduePurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverduePurchaseOrder));
            this.dgvOverduePurchaseOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbAccountLedger = new System.Windows.Forms.ComboBox();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverduePurchaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOverduePurchaseOrder
            // 
            this.dgvOverduePurchaseOrder.AllowUserToAddRows = false;
            this.dgvOverduePurchaseOrder.AllowUserToDeleteRows = false;
            this.dgvOverduePurchaseOrder.AllowUserToResizeRows = false;
            this.dgvOverduePurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOverduePurchaseOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverduePurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverduePurchaseOrder.ColumnHeadersHeight = 35;
            this.dgvOverduePurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOverduePurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverduePurchaseOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverduePurchaseOrder.Enabled = false;
            this.dgvOverduePurchaseOrder.EnableHeadersVisualStyles = false;
            this.dgvOverduePurchaseOrder.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvOverduePurchaseOrder.Location = new System.Drawing.Point(18, 48);
            this.dgvOverduePurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvOverduePurchaseOrder.Name = "dgvOverduePurchaseOrder";
            this.dgvOverduePurchaseOrder.RowHeadersVisible = false;
            this.dgvOverduePurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverduePurchaseOrder.Size = new System.Drawing.Size(764, 504);
            this.dgvOverduePurchaseOrder.TabIndex = 2;
            this.dgvOverduePurchaseOrder.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SlNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 127;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderNO";
            this.Column2.HeaderText = "Order No";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 127;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 127;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Cash \\ Party";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 126;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dueDate";
            this.Column6.HeaderText = "Due Date";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 127;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 127;
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
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbAccountLedger
            // 
            this.cmbAccountLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLedger.Location = new System.Drawing.Point(126, 15);
            this.cmbAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLedger.Name = "cmbAccountLedger";
            this.cmbAccountLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLedger.TabIndex = 0;
            this.cmbAccountLedger.SelectedIndexChanged += new System.EventHandler(this.cmbAccountLedger_SelectedIndexChanged);
            this.cmbAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLedger_KeyDown);
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.ForeColor = System.Drawing.Color.White;
            this.lblAccountLedger.Location = new System.Drawing.Point(20, 19);
            this.lblAccountLedger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(83, 13);
            this.lblAccountLedger.TabIndex = 1150;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // frmOverduePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbAccountLedger);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOverduePurchaseOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmOverduePurchaseOrder";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdue Purchase Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOverduePurchaseOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOverduePurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverduePurchaseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOverduePurchaseOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbAccountLedger;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}