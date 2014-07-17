namespace Open_Miracle{
    partial class frmBalanceSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalanceSheet));
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lbltodate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLiability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lblliability = new System.Windows.Forms.Label();
            this.lblasset = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(669, 32);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 27);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            this.btnclear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnclear_KeyDown);
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(578, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(85, 27);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            this.btnsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsearch_KeyDown);
            // 
            // lbltodate
            // 
            this.lbltodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltodate.ForeColor = System.Drawing.Color.White;
            this.lbltodate.Location = new System.Drawing.Point(86, 34);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(75, 20);
            this.lbltodate.TabIndex = 1175;
            this.lbltodate.Text = "To date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(706, 583);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 27);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.ColumnHeadersVisible = false;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.GroupId2,
            this.dgvtxtLiability,
            this.Amount2,
            this.dgvtxtAsset,
            this.Amount1,
            this.ID1,
            this.GroupId1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            this.dgvReport.Location = new System.Drawing.Point(34, 114);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReport.Size = new System.Drawing.Size(761, 449);
            this.dgvReport.TabIndex = 4;
            this.dgvReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellDoubleClick);
            this.dgvReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvReport_KeyDown);
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID2";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // GroupId2
            // 
            this.GroupId2.HeaderText = "GroupId2";
            this.GroupId2.Name = "GroupId2";
            this.GroupId2.ReadOnly = true;
            this.GroupId2.Visible = false;
            // 
            // dgvtxtLiability
            // 
            this.dgvtxtLiability.HeaderText = "Liability";
            this.dgvtxtLiability.Name = "dgvtxtLiability";
            this.dgvtxtLiability.ReadOnly = true;
            // 
            // Amount2
            // 
            this.Amount2.HeaderText = "Amount2";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAsset
            // 
            this.dgvtxtAsset.HeaderText = "Asset";
            this.dgvtxtAsset.Name = "dgvtxtAsset";
            this.dgvtxtAsset.ReadOnly = true;
            // 
            // Amount1
            // 
            this.Amount1.HeaderText = "Amount1";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID1";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // GroupId1
            // 
            this.GroupId1.HeaderText = "GroupId1";
            this.GroupId1.Name = "GroupId1";
            this.GroupId1.ReadOnly = true;
            this.GroupId1.Visible = false;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(158, 32);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(139, 20);
            this.txtToDate.TabIndex = 0;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(296, 32);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(22, 20);
            this.dtpdate.TabIndex = 3;
            this.dtpdate.ValueChanged += new System.EventHandler(this.dtpdate_ValueChanged);
            this.dtpdate.Leave += new System.EventHandler(this.dtpdate_Leave);
            // 
            // lblliability
            // 
            this.lblliability.AutoSize = true;
            this.lblliability.BackColor = System.Drawing.Color.Transparent;
            this.lblliability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliability.ForeColor = System.Drawing.Color.White;
            this.lblliability.Location = new System.Drawing.Point(154, 5);
            this.lblliability.Name = "lblliability";
            this.lblliability.Size = new System.Drawing.Size(79, 24);
            this.lblliability.TabIndex = 1183;
            this.lblliability.Text = "Liability";
            // 
            // lblasset
            // 
            this.lblasset.AutoSize = true;
            this.lblasset.BackColor = System.Drawing.Color.Transparent;
            this.lblasset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasset.ForeColor = System.Drawing.Color.White;
            this.lblasset.Location = new System.Drawing.Point(162, 5);
            this.lblasset.Name = "lblasset";
            this.lblasset.Size = new System.Drawing.Size(61, 24);
            this.lblasset.TabIndex = 1184;
            this.lblasset.Text = "Asset";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.lblliability);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(34, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 32);
            this.panel1.TabIndex = 1185;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.lblasset);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(415, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 32);
            this.panel2.TabIndex = 1186;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.Honeydew;
            this.panel3.Location = new System.Drawing.Point(415, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 480);
            this.panel3.TabIndex = 1188;
            // 
            // frmBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(835, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbltodate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBalanceSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBalanceSheet_FormClosing);
            this.Load += new System.EventHandler(this.frmBalanceSheet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBalanceSheet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbltodate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label lblliability;
        private System.Windows.Forms.Label lblasset;
       // private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLiability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
       // private DBOpenMiracleDataSet dBOpenMiracleDataSet;
     //   private DBOpenMiracleDataSetTableAdapters.BalanceSheetTableAdapter balanceSheetTableAdapter;
    }
}