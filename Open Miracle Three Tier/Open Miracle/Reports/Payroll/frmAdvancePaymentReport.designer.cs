namespace Open_Miracle
{
    partial class frmAdvancePaymentReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvancePaymentReport));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvAdvancePayment = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalaryMonth = new System.Windows.Forms.TextBox();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(582, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
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
            this.btnReset.Location = new System.Drawing.Point(673, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(127, 35);
            this.cmbEmployeeCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeCode.TabIndex = 2;
            this.cmbEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeCode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(474, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1217;
            this.label3.Text = "Salary Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1216;
            this.label5.Text = "Employee Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(474, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1215;
            this.label4.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1214;
            this.label1.Text = "From Date";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(582, 552);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 456;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(474, 552);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1227;
            this.label7.Text = "Total Amount";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(20, 552);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 26);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvAdvancePayment
            // 
            this.dgvAdvancePayment.AllowUserToAddRows = false;
            this.dgvAdvancePayment.AllowUserToResizeRows = false;
            this.dgvAdvancePayment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvancePayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvancePayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvancePayment.ColumnHeadersHeight = 25;
            this.dgvAdvancePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdvancePayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.Column1,
            this.employeeCode,
            this.Column2,
            this.amount,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdvancePayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdvancePayment.EnableHeadersVisualStyles = false;
            this.dgvAdvancePayment.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAdvancePayment.Location = new System.Drawing.Point(18, 96);
            this.dgvAdvancePayment.MultiSelect = false;
            this.dgvAdvancePayment.Name = "dgvAdvancePayment";
            this.dgvAdvancePayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvancePayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdvancePayment.RowHeadersVisible = false;
            this.dgvAdvancePayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvancePayment.Size = new System.Drawing.Size(764, 450);
            this.dgvAdvancePayment.TabIndex = 7;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SlNo";
            this.Col.HeaderText = "SlNo";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 127;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date";
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 126;
            // 
            // employeeCode
            // 
            this.employeeCode.DataPropertyName = "employeeCode";
            this.employeeCode.HeaderText = "Employee Code";
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.ReadOnly = true;
            this.employeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeCode.Width = 127;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "employeeName";
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 126;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 127;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "narration";
            this.Column4.HeaderText = "Narration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 126;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(581, 10);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(186, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(761, 10);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1231;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 10);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFrmDate
            // 
            this.dtpFrmDate.Location = new System.Drawing.Point(307, 10);
            this.dtpFrmDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFrmDate.Name = "dtpFrmDate";
            this.dtpFrmDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFrmDate.TabIndex = 1233;
            this.dtpFrmDate.ValueChanged += new System.EventHandler(this.dtpFrmDate_ValueChanged);
            // 
            // txtSalaryMonth
            // 
            this.txtSalaryMonth.Location = new System.Drawing.Point(581, 35);
            this.txtSalaryMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtSalaryMonth.Name = "txtSalaryMonth";
            this.txtSalaryMonth.Size = new System.Drawing.Size(186, 20);
            this.txtSalaryMonth.TabIndex = 3;
            this.txtSalaryMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryMonth_KeyDown);
            this.txtSalaryMonth.Leave += new System.EventHandler(this.txtSalaryMonth_Leave);
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.Location = new System.Drawing.Point(760, 35);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(22, 20);
            this.dtpSalaryMonth.TabIndex = 1235;
            this.dtpSalaryMonth.ValueChanged += new System.EventHandler(this.dtpSalaryMonth_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(111, 552);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAdvancePaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.txtSalaryMonth);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvAdvancePayment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbEmployeeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAdvancePaymentReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Payment Report";
            this.Load += new System.EventHandler(this.frmAdvancePaymentReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdvancePaymentReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvAdvancePayment;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtSalaryMonth;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnExport;
    }
}