namespace Open_Miracle
{
    partial class frmPayHeadReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayHeadReport));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPayHead = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvPayHead = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpayHeadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpayheadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(584, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(675, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "All",
            "Addition",
            "Deduction"});
            this.cmbType.Location = new System.Drawing.Point(584, 13);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 21);
            this.cmbType.TabIndex = 1;
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbType_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(468, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1202;
            this.label4.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1201;
            this.label1.Text = "Pay Head Name";
            // 
            // cmbPayHead
            // 
            this.cmbPayHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayHead.FormattingEnabled = true;
            this.cmbPayHead.Location = new System.Drawing.Point(136, 13);
            this.cmbPayHead.Name = "cmbPayHead";
            this.cmbPayHead.Size = new System.Drawing.Size(200, 21);
            this.cmbPayHead.TabIndex = 0;
            this.cmbPayHead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPayHead_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(606, 553);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvPayHead
            // 
            this.dgvPayHead.AllowUserToAddRows = false;
            this.dgvPayHead.AllowUserToDeleteRows = false;
            this.dgvPayHead.AllowUserToResizeRows = false;
            this.dgvPayHead.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayHead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayHead.ColumnHeadersHeight = 25;
            this.dgvPayHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtpayHeadId,
            this.dgvtxtpayheadName,
            this.dgvtxtType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayHead.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayHead.EnableHeadersVisualStyles = false;
            this.dgvPayHead.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPayHead.Location = new System.Drawing.Point(18, 73);
            this.dgvPayHead.Name = "dgvPayHead";
            this.dgvPayHead.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayHead.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayHead.RowHeadersVisible = false;
            this.dgvPayHead.Size = new System.Drawing.Size(764, 474);
            this.dgvPayHead.TabIndex = 5;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 254;
            // 
            // dgvtxtpayHeadId
            // 
            this.dgvtxtpayHeadId.DataPropertyName = "payHeadId";
            this.dgvtxtpayHeadId.HeaderText = "payHeadId";
            this.dgvtxtpayHeadId.Name = "dgvtxtpayHeadId";
            this.dgvtxtpayHeadId.ReadOnly = true;
            this.dgvtxtpayHeadId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpayHeadId.Visible = false;
            // 
            // dgvtxtpayheadName
            // 
            this.dgvtxtpayheadName.DataPropertyName = "payheadName";
            this.dgvtxtpayheadName.HeaderText = "Payhead Name";
            this.dgvtxtpayheadName.Name = "dgvtxtpayheadName";
            this.dgvtxtpayheadName.ReadOnly = true;
            this.dgvtxtpayheadName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpayheadName.Width = 253;
            // 
            // dgvtxtType
            // 
            this.dgvtxtType.DataPropertyName = "type";
            this.dgvtxtType.HeaderText = "Type";
            this.dgvtxtType.Name = "dgvtxtType";
            this.dgvtxtType.ReadOnly = true;
            this.dgvtxtType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtType.Width = 254;
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(696, 553);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPayHeadReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvPayHead);
            this.Controls.Add(this.cmbPayHead);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPayHeadReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Head  Report";
            this.Load += new System.EventHandler(this.frmPayHeadReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPayHeadReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPayHead;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvPayHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpayHeadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpayheadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtType;
        private System.Windows.Forms.Button btnExport;
    }
}