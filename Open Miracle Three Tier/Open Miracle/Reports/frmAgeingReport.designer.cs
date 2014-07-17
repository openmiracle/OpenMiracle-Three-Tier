namespace Open_Miracle
{
    partial class frmAgeingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgeingReport));
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLedger = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnReceivable = new System.Windows.Forms.RadioButton();
            this.rbtnPayable = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnLedgerWise = new System.Windows.Forms.RadioButton();
            this.rbtnVoucher = new System.Windows.Forms.RadioButton();
            this.lblTotOne = new System.Windows.Forms.Label();
            this.lblTotTwo = new System.Windows.Forms.Label();
            this.lblTotThree = new System.Windows.Forms.Label();
            this.lblTotFour = new System.Windows.Forms.Label();
            this.dtpAgeingDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1267;
            this.label8.Text = "Ageing Date";
            // 
            // cmbLedger
            // 
            this.cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLedger.FormattingEnabled = true;
            this.cmbLedger.Location = new System.Drawing.Point(124, 34);
            this.cmbLedger.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbLedger.Name = "cmbLedger";
            this.cmbLedger.Size = new System.Drawing.Size(200, 21);
            this.cmbLedger.TabIndex = 1;
            this.cmbLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLedger_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1270;
            this.label2.Text = "Account Ledger";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(129, 116);
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
            this.btnReset.Location = new System.Drawing.Point(220, 116);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReport.Location = new System.Drawing.Point(21, 153);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(761, 384);
            this.dgvReport.TabIndex = 1280;
            this.dgvReport.TabStop = false;
            this.dgvReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnReceivable);
            this.groupBox1.Controls.Add(this.rbtnPayable);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(124, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // rbtnReceivable
            // 
            this.rbtnReceivable.AutoSize = true;
            this.rbtnReceivable.ForeColor = System.Drawing.Color.White;
            this.rbtnReceivable.Location = new System.Drawing.Point(115, 19);
            this.rbtnReceivable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnReceivable.Name = "rbtnReceivable";
            this.rbtnReceivable.Size = new System.Drawing.Size(79, 17);
            this.rbtnReceivable.TabIndex = 1;
            this.rbtnReceivable.TabStop = true;
            this.rbtnReceivable.Text = "Receivable";
            this.rbtnReceivable.UseVisualStyleBackColor = true;
            this.rbtnReceivable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnReceivable_KeyDown);
            // 
            // rbtnPayable
            // 
            this.rbtnPayable.AutoSize = true;
            this.rbtnPayable.ForeColor = System.Drawing.Color.White;
            this.rbtnPayable.Location = new System.Drawing.Point(7, 20);
            this.rbtnPayable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnPayable.Name = "rbtnPayable";
            this.rbtnPayable.Size = new System.Drawing.Size(63, 17);
            this.rbtnPayable.TabIndex = 0;
            this.rbtnPayable.TabStop = true;
            this.rbtnPayable.Text = "Payable";
            this.rbtnPayable.UseVisualStyleBackColor = true;
            this.rbtnPayable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnPayable_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnLedgerWise);
            this.groupBox2.Controls.Add(this.rbtnVoucher);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(450, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // rbtnLedgerWise
            // 
            this.rbtnLedgerWise.AutoSize = true;
            this.rbtnLedgerWise.ForeColor = System.Drawing.Color.White;
            this.rbtnLedgerWise.Location = new System.Drawing.Point(115, 19);
            this.rbtnLedgerWise.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnLedgerWise.Name = "rbtnLedgerWise";
            this.rbtnLedgerWise.Size = new System.Drawing.Size(85, 17);
            this.rbtnLedgerWise.TabIndex = 1;
            this.rbtnLedgerWise.TabStop = true;
            this.rbtnLedgerWise.Text = "Ledger Wise";
            this.rbtnLedgerWise.UseVisualStyleBackColor = true;
            this.rbtnLedgerWise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnLedgerWise_KeyDown);
            // 
            // rbtnVoucher
            // 
            this.rbtnVoucher.AutoSize = true;
            this.rbtnVoucher.ForeColor = System.Drawing.Color.White;
            this.rbtnVoucher.Location = new System.Drawing.Point(7, 20);
            this.rbtnVoucher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnVoucher.Name = "rbtnVoucher";
            this.rbtnVoucher.Size = new System.Drawing.Size(92, 17);
            this.rbtnVoucher.TabIndex = 0;
            this.rbtnVoucher.TabStop = true;
            this.rbtnVoucher.Text = "Voucher Wise";
            this.rbtnVoucher.UseVisualStyleBackColor = true;
            // 
            // lblTotOne
            // 
            this.lblTotOne.AutoSize = true;
            this.lblTotOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotOne.Location = new System.Drawing.Point(49, 540);
            this.lblTotOne.Name = "lblTotOne";
            this.lblTotOne.Size = new System.Drawing.Size(28, 13);
            this.lblTotOne.TabIndex = 1288;
            this.lblTotOne.Text = "0.00";
            // 
            // lblTotTwo
            // 
            this.lblTotTwo.AutoSize = true;
            this.lblTotTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotTwo.Location = new System.Drawing.Point(256, 540);
            this.lblTotTwo.Name = "lblTotTwo";
            this.lblTotTwo.Size = new System.Drawing.Size(28, 13);
            this.lblTotTwo.TabIndex = 1289;
            this.lblTotTwo.Text = "0.00";
            // 
            // lblTotThree
            // 
            this.lblTotThree.AutoSize = true;
            this.lblTotThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotThree.Location = new System.Drawing.Point(465, 540);
            this.lblTotThree.Name = "lblTotThree";
            this.lblTotThree.Size = new System.Drawing.Size(28, 13);
            this.lblTotThree.TabIndex = 1290;
            this.lblTotThree.Text = "0.00";
            // 
            // lblTotFour
            // 
            this.lblTotFour.AutoSize = true;
            this.lblTotFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotFour.Location = new System.Drawing.Point(688, 540);
            this.lblTotFour.Name = "lblTotFour";
            this.lblTotFour.Size = new System.Drawing.Size(28, 13);
            this.lblTotFour.TabIndex = 1291;
            this.lblTotFour.Text = "0.00";
            // 
            // dtpAgeingDate
            // 
            this.dtpAgeingDate.Location = new System.Drawing.Point(302, 10);
            this.dtpAgeingDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpAgeingDate.Name = "dtpAgeingDate";
            this.dtpAgeingDate.Size = new System.Drawing.Size(22, 20);
            this.dtpAgeingDate.TabIndex = 4567;
            this.dtpAgeingDate.CloseUp += new System.EventHandler(this.dtpAgeingDate_CloseUp);
            this.dtpAgeingDate.ValueChanged += new System.EventHandler(this.dtpAgeingDate_ValueChanged);
            this.dtpAgeingDate.Leave += new System.EventHandler(this.dtpAgeingDate_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(590, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(124, 10);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 0;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(681, 561);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmAgeingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpAgeingDate);
            this.Controls.Add(this.lblTotFour);
            this.Controls.Add(this.lblTotThree);
            this.Controls.Add(this.lblTotTwo);
            this.Controls.Add(this.lblTotOne);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLedger);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAgeingReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ageing Report";
            this.Load += new System.EventHandler(this.frmAgeingReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgeingReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLedger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnReceivable;
        private System.Windows.Forms.RadioButton rbtnPayable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnLedgerWise;
        private System.Windows.Forms.RadioButton rbtnVoucher;
        private System.Windows.Forms.Label lblTotOne;
        private System.Windows.Forms.Label lblTotTwo;
        private System.Windows.Forms.Label lblTotThree;
        private System.Windows.Forms.Label lblTotFour;
        private System.Windows.Forms.DateTimePicker dtpAgeingDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Button btnExport;
    }
}