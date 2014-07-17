namespace Open_Miracle
{
    partial class frmDayBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayBook));
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvDayBook = new Open_Miracle.dgv.DataGridViewEnter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.cmbLedger = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnCondensed = new System.Windows.Forms.RadioButton();
            this.rbtnDetailed = new System.Windows.Forms.RadioButton();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(600, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvDayBook
            // 
            this.dgvDayBook.AllowUserToAddRows = false;
            this.dgvDayBook.AllowUserToDeleteRows = false;
            this.dgvDayBook.AllowUserToResizeRows = false;
            this.dgvDayBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvDayBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDayBook.ColumnHeadersHeight = 35;
            this.dgvDayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDayBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDayBook.EnableHeadersVisualStyles = false;
            this.dgvDayBook.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDayBook.Location = new System.Drawing.Point(21, 113);
            this.dgvDayBook.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dgvDayBook.Name = "dgvDayBook";
            this.dgvDayBook.ReadOnly = true;
            this.dgvDayBook.RowHeadersVisible = false;
            this.dgvDayBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDayBook.Size = new System.Drawing.Size(761, 441);
            this.dgvDayBook.TabIndex = 9;
            this.dgvDayBook.TabStop = false;
            this.dgvDayBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDayBook_CellDoubleClick);
            this.dgvDayBook.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDataBook_DataBindingComplete);
            this.dgvDayBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDayBook_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(129, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
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
            this.btnReset.Location = new System.Drawing.Point(222, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(492, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1313;
            this.label5.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(14, 14);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1311;
            this.lblFromDate.Text = "From Date";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(131, 35);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // cmbLedger
            // 
            this.cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLedger.FormattingEnabled = true;
            this.cmbLedger.Location = new System.Drawing.Point(588, 35);
            this.cmbLedger.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbLedger.Name = "cmbLedger";
            this.cmbLedger.Size = new System.Drawing.Size(194, 21);
            this.cmbLedger.TabIndex = 3;
            this.cmbLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLedger_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(492, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1323;
            this.label3.Text = "Ledger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1321;
            this.label6.Text = "Voucher Type";
            // 
            // rbtnCondensed
            // 
            this.rbtnCondensed.AutoSize = true;
            this.rbtnCondensed.ForeColor = System.Drawing.Color.White;
            this.rbtnCondensed.Location = new System.Drawing.Point(131, 61);
            this.rbtnCondensed.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rbtnCondensed.Name = "rbtnCondensed";
            this.rbtnCondensed.Size = new System.Drawing.Size(79, 17);
            this.rbtnCondensed.TabIndex = 4;
            this.rbtnCondensed.TabStop = true;
            this.rbtnCondensed.Text = "Condensed";
            this.rbtnCondensed.UseVisualStyleBackColor = true;
            this.rbtnCondensed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnCondensed_KeyDown);
            // 
            // rbtnDetailed
            // 
            this.rbtnDetailed.AutoSize = true;
            this.rbtnDetailed.ForeColor = System.Drawing.Color.White;
            this.rbtnDetailed.Location = new System.Drawing.Point(224, 61);
            this.rbtnDetailed.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rbtnDetailed.Name = "rbtnDetailed";
            this.rbtnDetailed.Size = new System.Drawing.Size(64, 17);
            this.rbtnDetailed.TabIndex = 5;
            this.rbtnDetailed.TabStop = true;
            this.rbtnDetailed.Text = "Detailed";
            this.rbtnDetailed.UseVisualStyleBackColor = true;
            this.rbtnDetailed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnDetailed_KeyDown);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(588, 10);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(186, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(763, 10);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(18, 20);
            this.dtpToDate.TabIndex = 1329;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(131, 10);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(185, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(313, 10);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(19, 20);
            this.dtpFromDate.TabIndex = 1331;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(691, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDayBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.rbtnDetailed);
            this.Controls.Add(this.rbtnCondensed);
            this.Controls.Add(this.cmbLedger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDayBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDayBook";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Book";
            this.Load += new System.EventHandler(this.frmDayBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDayBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.ComboBox cmbLedger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnCondensed;
        private System.Windows.Forms.RadioButton rbtnDetailed;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private dgv.DataGridViewEnter dgvDayBook;
        private System.Windows.Forms.Button btnExport;
    }
}