namespace Open_Miracle
{
    partial class frmCashFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashFlow));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvCashflow = new System.Windows.Forms.DataGridView();
            this.dgvtxtID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtinflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParticulars1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtoutflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txttoDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(676, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(585, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1166;
            this.label3.Text = "To date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1164;
            this.label2.Text = "From date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(697, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvCashflow
            // 
            this.dgvCashflow.AllowUserToAddRows = false;
            this.dgvCashflow.AllowUserToDeleteRows = false;
            this.dgvCashflow.AllowUserToResizeColumns = false;
            this.dgvCashflow.AllowUserToResizeRows = false;
            this.dgvCashflow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashflow.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvCashflow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashflow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashflow.ColumnHeadersHeight = 35;
            this.dgvCashflow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCashflow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtID1,
            this.dgvtxtParticulars,
            this.dgvtxtinflow,
            this.dgvtxtID2,
            this.dgvtxtParticulars1,
            this.dgvtxtoutflow});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashflow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashflow.EnableHeadersVisualStyles = false;
            this.dgvCashflow.GridColor = System.Drawing.Color.White;
            this.dgvCashflow.Location = new System.Drawing.Point(18, 71);
            this.dgvCashflow.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvCashflow.MultiSelect = false;
            this.dgvCashflow.Name = "dgvCashflow";
            this.dgvCashflow.ReadOnly = true;
            this.dgvCashflow.RowHeadersVisible = false;
            this.dgvCashflow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCashflow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCashflow.Size = new System.Drawing.Size(764, 481);
            this.dgvCashflow.TabIndex = 5;
            this.dgvCashflow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashflow_CellDoubleClick);
            // 
            // dgvtxtID1
            // 
            this.dgvtxtID1.HeaderText = "ID1";
            this.dgvtxtID1.Name = "dgvtxtID1";
            this.dgvtxtID1.ReadOnly = true;
            this.dgvtxtID1.Visible = false;
            // 
            // dgvtxtParticulars
            // 
            this.dgvtxtParticulars.HeaderText = "Particulars";
            this.dgvtxtParticulars.Name = "dgvtxtParticulars";
            this.dgvtxtParticulars.ReadOnly = true;
            this.dgvtxtParticulars.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtParticulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtinflow
            // 
            this.dgvtxtinflow.HeaderText = "In flow";
            this.dgvtxtinflow.Name = "dgvtxtinflow";
            this.dgvtxtinflow.ReadOnly = true;
            this.dgvtxtinflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtID2
            // 
            this.dgvtxtID2.HeaderText = "ID2";
            this.dgvtxtID2.Name = "dgvtxtID2";
            this.dgvtxtID2.ReadOnly = true;
            this.dgvtxtID2.Visible = false;
            // 
            // dgvtxtParticulars1
            // 
            this.dgvtxtParticulars1.HeaderText = "Particulars";
            this.dgvtxtParticulars1.Name = "dgvtxtParticulars1";
            this.dgvtxtParticulars1.ReadOnly = true;
            this.dgvtxtParticulars1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtoutflow
            // 
            this.dgvtxtoutflow.HeaderText = "Out flow";
            this.dgvtxtoutflow.Name = "dgvtxtoutflow";
            this.dgvtxtoutflow.ReadOnly = true;
            this.dgvtxtoutflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(136, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(178, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(314, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 11;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txttoDate
            // 
            this.txttoDate.Location = new System.Drawing.Point(582, 15);
            this.txttoDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txttoDate.Name = "txttoDate";
            this.txttoDate.Size = new System.Drawing.Size(178, 20);
            this.txttoDate.TabIndex = 1;
            this.txttoDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttoDate_KeyDown);
            this.txttoDate.Leave += new System.EventHandler(this.txttoDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 12;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // frmCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txttoDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvCashflow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCashFlow";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Flow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCashFlow_FormClosing);
            this.Load += new System.EventHandler(this.frmCashFlow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCashFlow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvCashflow;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txttoDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtinflow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParticulars1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtoutflow;
    }
}