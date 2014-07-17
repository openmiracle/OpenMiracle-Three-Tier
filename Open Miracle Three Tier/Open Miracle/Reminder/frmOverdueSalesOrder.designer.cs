namespace Open_Miracle
{
    partial class frmOverdueSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverdueSalesOrder));
            this.btnclose = new System.Windows.Forms.Button();
            this.dgvOverdueSalesOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountLeadger = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueSalesOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(697, 560);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 27);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgvOverdueSalesOrder
            // 
            this.dgvOverdueSalesOrder.AllowUserToAddRows = false;
            this.dgvOverdueSalesOrder.AllowUserToDeleteRows = false;
            this.dgvOverdueSalesOrder.AllowUserToResizeRows = false;
            this.dgvOverdueSalesOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOverdueSalesOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverdueSalesOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverdueSalesOrder.ColumnHeadersHeight = 35;
            this.dgvOverdueSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOverdueSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverdueSalesOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverdueSalesOrder.EnableHeadersVisualStyles = false;
            this.dgvOverdueSalesOrder.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvOverdueSalesOrder.Location = new System.Drawing.Point(18, 41);
            this.dgvOverdueSalesOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvOverdueSalesOrder.Name = "dgvOverdueSalesOrder";
            this.dgvOverdueSalesOrder.ReadOnly = true;
            this.dgvOverdueSalesOrder.RowHeadersVisible = false;
            this.dgvOverdueSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdueSalesOrder.Size = new System.Drawing.Size(764, 514);
            this.dgvOverdueSalesOrder.TabIndex = 2;
            this.dgvOverdueSalesOrder.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SlNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 109;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "orderNo";
            this.Column2.HeaderText = "Order No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 109;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ledgerName";
            this.Column4.HeaderText = "Cash \\ Party";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 109;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "totallAmount";
            this.Column5.HeaderText = "Bill Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DueDate";
            this.Column6.HeaderText = "Due Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 109;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "QuotationNo";
            this.Column7.HeaderText = "Quotation No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 108;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1148;
            this.label2.Text = "Account Leadger";
            // 
            // cmbAccountLeadger
            // 
            this.cmbAccountLeadger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountLeadger.Location = new System.Drawing.Point(126, 15);
            this.cmbAccountLeadger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountLeadger.Name = "cmbAccountLeadger";
            this.cmbAccountLeadger.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountLeadger.TabIndex = 0;
            this.cmbAccountLeadger.SelectedIndexChanged += new System.EventHandler(this.cmbAccountLeadger_SelectedIndexChanged);
            this.cmbAccountLeadger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountLeadger_KeyDown);
            // 
            // frmOverdueSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgvOverdueSalesOrder);
            this.Controls.Add(this.cmbAccountLeadger);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmOverdueSalesOrder";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdue Sales Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOverdueSalesOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOverdueSalesOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOverdueSalesOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueSalesOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvOverdueSalesOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountLeadger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}