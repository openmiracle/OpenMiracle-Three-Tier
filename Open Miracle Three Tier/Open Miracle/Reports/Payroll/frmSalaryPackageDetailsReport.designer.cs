namespace Open_Miracle
{
    partial class frmSalaryPackageDetailsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryPackageDetailsReport));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSalaryPackage = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvSalaryPackageDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotalAddition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalReduction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackageDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Package Name";
            // 
            // cmbSalaryPackage
            // 
            this.cmbSalaryPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaryPackage.FormattingEnabled = true;
            this.cmbSalaryPackage.Location = new System.Drawing.Point(157, 15);
            this.cmbSalaryPackage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbSalaryPackage.Name = "cmbSalaryPackage";
            this.cmbSalaryPackage.Size = new System.Drawing.Size(200, 21);
            this.cmbSalaryPackage.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(157, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(248, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvSalaryPackageDetails
            // 
            this.dgvSalaryPackageDetails.AllowUserToAddRows = false;
            this.dgvSalaryPackageDetails.AllowUserToDeleteRows = false;
            this.dgvSalaryPackageDetails.AllowUserToResizeRows = false;
            this.dgvSalaryPackageDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaryPackageDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryPackageDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryPackageDetails.ColumnHeadersHeight = 35;
            this.dgvSalaryPackageDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalaryPackageDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.dgvtxttype,
            this.txtAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryPackageDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryPackageDetails.EnableHeadersVisualStyles = false;
            this.dgvSalaryPackageDetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalaryPackageDetails.Location = new System.Drawing.Point(18, 77);
            this.dgvSalaryPackageDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSalaryPackageDetails.Name = "dgvSalaryPackageDetails";
            this.dgvSalaryPackageDetails.ReadOnly = true;
            this.dgvSalaryPackageDetails.RowHeadersVisible = false;
            this.dgvSalaryPackageDetails.Size = new System.Drawing.Size(764, 424);
            this.dgvSalaryPackageDetails.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SlNo";
            this.Column1.HeaderText = "SlNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 190;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "payHeadName";
            this.Column2.HeaderText = "Payhead";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 190;
            // 
            // dgvtxttype
            // 
            this.dgvtxttype.DataPropertyName = "type";
            this.dgvtxttype.HeaderText = "Type";
            this.dgvtxttype.Name = "dgvtxttype";
            this.dgvtxttype.ReadOnly = true;
            this.dgvtxttype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxttype.Width = 189;
            // 
            // txtAmount
            // 
            this.txtAmount.DataPropertyName = "amount";
            this.txtAmount.HeaderText = "Amount";
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtAmount.Width = 190;
            // 
            // txttotalAddition
            // 
            this.txttotalAddition.BackColor = System.Drawing.Color.White;
            this.txttotalAddition.Location = new System.Drawing.Point(581, 506);
            this.txttotalAddition.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txttotalAddition.Name = "txttotalAddition";
            this.txttotalAddition.ReadOnly = true;
            this.txttotalAddition.Size = new System.Drawing.Size(200, 20);
            this.txttotalAddition.TabIndex = 1184;
            this.txttotalAddition.Text = resources.GetString("txttotalAddition.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(471, 510);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1183;
            this.label7.Text = "Total Addition";
            // 
            // txttotalReduction
            // 
            this.txttotalReduction.BackColor = System.Drawing.Color.White;
            this.txttotalReduction.Location = new System.Drawing.Point(581, 531);
            this.txttotalReduction.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txttotalReduction.Name = "txttotalReduction";
            this.txttotalReduction.ReadOnly = true;
            this.txttotalReduction.Size = new System.Drawing.Size(200, 20);
            this.txttotalReduction.TabIndex = 1186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(471, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1185;
            this.label3.Text = "Total Deduction";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(581, 556);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 1188;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(471, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1187;
            this.label4.Text = "Total Amount";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(18, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(109, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmSalaryPackageDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotalReduction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalAddition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSalaryPackageDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbSalaryPackage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalaryPackageDetailsReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Package Details Report";
            this.Load += new System.EventHandler(this.frmSalaryPackageDetailsReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalaryPackageDetailsReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackageDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSalaryPackage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvSalaryPackageDetails;
        private System.Windows.Forms.TextBox txttotalAddition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotalReduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
        private System.Windows.Forms.Button btnExport;
    }
}