namespace Open_Miracle
{
    partial class frmProfitAndLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfitAndLoss));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvProfitAndLoss = new System.Windows.Forms.DataGridView();
            this.dgvtxtGroupId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroupId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpContraVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfitAndLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(665, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(574, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(481, 19);
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
            this.label2.Location = new System.Drawing.Point(20, 19);
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
            this.btnPrint.Location = new System.Drawing.Point(691, 526);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 1162;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvProfitAndLoss
            // 
            this.dgvProfitAndLoss.AllowUserToAddRows = false;
            this.dgvProfitAndLoss.AllowUserToDeleteRows = false;
            this.dgvProfitAndLoss.AllowUserToResizeColumns = false;
            this.dgvProfitAndLoss.AllowUserToResizeRows = false;
            this.dgvProfitAndLoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfitAndLoss.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfitAndLoss.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfitAndLoss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfitAndLoss.ColumnHeadersHeight = 35;
            this.dgvProfitAndLoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProfitAndLoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtGroupId1,
            this.dgvtxtExpenses,
            this.dgvtxtAmount1,
            this.dgvtxtIncome,
            this.dgvtxtAmount2,
            this.dgvtxtGroupId2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfitAndLoss.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfitAndLoss.EnableHeadersVisualStyles = false;
            this.dgvProfitAndLoss.GridColor = System.Drawing.Color.White;
            this.dgvProfitAndLoss.Location = new System.Drawing.Point(18, 71);
            this.dgvProfitAndLoss.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvProfitAndLoss.MultiSelect = false;
            this.dgvProfitAndLoss.Name = "dgvProfitAndLoss";
            this.dgvProfitAndLoss.ReadOnly = true;
            this.dgvProfitAndLoss.RowHeadersVisible = false;
            this.dgvProfitAndLoss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProfitAndLoss.Size = new System.Drawing.Size(758, 447);
            this.dgvProfitAndLoss.TabIndex = 1161;
            this.dgvProfitAndLoss.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfitAndLoss_CellDoubleClick);
            // 
            // dgvtxtGroupId1
            // 
            this.dgvtxtGroupId1.HeaderText = "GroupId1";
            this.dgvtxtGroupId1.Name = "dgvtxtGroupId1";
            this.dgvtxtGroupId1.ReadOnly = true;
            this.dgvtxtGroupId1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtGroupId1.Visible = false;
            // 
            // dgvtxtExpenses
            // 
            this.dgvtxtExpenses.HeaderText = "Expenses";
            this.dgvtxtExpenses.Name = "dgvtxtExpenses";
            this.dgvtxtExpenses.ReadOnly = true;
            this.dgvtxtExpenses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount1
            // 
            this.dgvtxtAmount1.HeaderText = "Amount";
            this.dgvtxtAmount1.Name = "dgvtxtAmount1";
            this.dgvtxtAmount1.ReadOnly = true;
            this.dgvtxtAmount1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtIncome
            // 
            this.dgvtxtIncome.HeaderText = "Income";
            this.dgvtxtIncome.Name = "dgvtxtIncome";
            this.dgvtxtIncome.ReadOnly = true;
            this.dgvtxtIncome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount2
            // 
            this.dgvtxtAmount2.HeaderText = "Amount";
            this.dgvtxtAmount2.Name = "dgvtxtAmount2";
            this.dgvtxtAmount2.ReadOnly = true;
            this.dgvtxtAmount2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtGroupId2
            // 
            this.dgvtxtGroupId2.HeaderText = "GroupId2";
            this.dgvtxtGroupId2.Name = "dgvtxtGroupId2";
            this.dgvtxtGroupId2.ReadOnly = true;
            this.dgvtxtGroupId2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtGroupId2.Visible = false;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(144, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(178, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpContraVoucherDate
            // 
            this.dtpContraVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpContraVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContraVoucherDate.Location = new System.Drawing.Point(322, 15);
            this.dtpContraVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpContraVoucherDate.Name = "dtpContraVoucherDate";
            this.dtpContraVoucherDate.Size = new System.Drawing.Size(22, 20);
            this.dtpContraVoucherDate.TabIndex = 1171;
            this.dtpContraVoucherDate.ValueChanged += new System.EventHandler(this.dtpContraVoucherDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(574, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(178, 20);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(752, 15);
            this.dtpTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(22, 20);
            this.dtpTodate.TabIndex = 1173;
            this.dtpTodate.ValueChanged += new System.EventHandler(this.dtpTodate_ValueChanged);
            // 
            // frmProfitAndLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(794, 566);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpTodate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpContraVoucherDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvProfitAndLoss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProfitAndLoss";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit And Loss";
            this.Load += new System.EventHandler(this.frmProfitAndLoss_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProfitAndLoss_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfitAndLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvProfitAndLoss;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpContraVoucherDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroupId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroupId2;
    }
}