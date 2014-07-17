namespace Open_Miracle
{
    partial class frmChangeFinancialYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeFinancialYear));
            this.dgvChangeFinancialYear = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtfinancialYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeFinancialYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChangeFinancialYear
            // 
            this.dgvChangeFinancialYear.AllowUserToAddRows = false;
            this.dgvChangeFinancialYear.AllowUserToResizeColumns = false;
            this.dgvChangeFinancialYear.AllowUserToResizeRows = false;
            this.dgvChangeFinancialYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChangeFinancialYear.BackgroundColor = System.Drawing.Color.White;
            this.dgvChangeFinancialYear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChangeFinancialYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChangeFinancialYear.ColumnHeadersHeight = 35;
            this.dgvChangeFinancialYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChangeFinancialYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtfinancialYearId,
            this.dgvtxtFromDate,
            this.dgvtxtToDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChangeFinancialYear.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChangeFinancialYear.EnableHeadersVisualStyles = false;
            this.dgvChangeFinancialYear.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvChangeFinancialYear.Location = new System.Drawing.Point(18, 20);
            this.dgvChangeFinancialYear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvChangeFinancialYear.Name = "dgvChangeFinancialYear";
            this.dgvChangeFinancialYear.RowHeadersVisible = false;
            this.dgvChangeFinancialYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChangeFinancialYear.Size = new System.Drawing.Size(764, 533);
            this.dgvChangeFinancialYear.TabIndex = 1145;
            this.dgvChangeFinancialYear.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChangeFinancialYear_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtfinancialYearId
            // 
            this.dgvtxtfinancialYearId.DataPropertyName = "financialYearId";
            this.dgvtxtfinancialYearId.HeaderText = "Financial Year Id";
            this.dgvtxtfinancialYearId.Name = "dgvtxtfinancialYearId";
            this.dgvtxtfinancialYearId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtfinancialYearId.Visible = false;
            // 
            // dgvtxtFromDate
            // 
            this.dgvtxtFromDate.DataPropertyName = "fromDate";
            this.dgvtxtFromDate.HeaderText = "From Date";
            this.dgvtxtFromDate.Name = "dgvtxtFromDate";
            this.dgvtxtFromDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtToDate
            // 
            this.dgvtxtToDate.DataPropertyName = "toDate";
            this.dgvtxtToDate.HeaderText = "To Date";
            this.dgvtxtToDate.Name = "dgvtxtToDate";
            this.dgvtxtToDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.btnClose.TabIndex = 1146;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(606, 560);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 27);
            this.btnSelect.TabIndex = 1147;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmChangeFinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvChangeFinancialYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChangeFinancialYear";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Financial Year";
            this.Load += new System.EventHandler(this.frmChangeFinancialYear_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChangeFinancialYear_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeFinancialYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChangeFinancialYear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtfinancialYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtToDate;
    }
}