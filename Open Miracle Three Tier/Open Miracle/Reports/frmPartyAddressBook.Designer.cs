namespace Open_Miracle
{
    partial class frmPartyAddressBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartyAddressBook));
            this.dvgPartyAddressBook = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPartyAddressBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPartyAddressBook
            // 
            this.dvgPartyAddressBook.AllowUserToAddRows = false;
            this.dvgPartyAddressBook.AllowUserToDeleteRows = false;
            this.dvgPartyAddressBook.AllowUserToResizeRows = false;
            this.dvgPartyAddressBook.BackgroundColor = System.Drawing.Color.White;
            this.dvgPartyAddressBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPartyAddressBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgPartyAddressBook.ColumnHeadersHeight = 35;
            this.dvgPartyAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgPartyAddressBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.numbr,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Email,
            this.ProductId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPartyAddressBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgPartyAddressBook.EnableHeadersVisualStyles = false;
            this.dvgPartyAddressBook.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgPartyAddressBook.Location = new System.Drawing.Point(21, 97);
            this.dvgPartyAddressBook.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dvgPartyAddressBook.Name = "dvgPartyAddressBook";
            this.dvgPartyAddressBook.ReadOnly = true;
            this.dvgPartyAddressBook.RowHeadersVisible = false;
            this.dvgPartyAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPartyAddressBook.Size = new System.Drawing.Size(753, 420);
            this.dvgPartyAddressBook.TabIndex = 8;
            this.dvgPartyAddressBook.TabStop = false;
            this.dvgPartyAddressBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dvgPartyAddressBook_KeyDown);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "Sl No";
            this.Col.HeaderText = "Sl.No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col.Width = 125;
            // 
            // numbr
            // 
            this.numbr.DataPropertyName = "ledgerName";
            this.numbr.HeaderText = "Party Name";
            this.numbr.Name = "numbr";
            this.numbr.ReadOnly = true;
            this.numbr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numbr.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "accountGroupName";
            this.Column1.HeaderText = "Accont Group";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "phone";
            this.Column2.HeaderText = "Phone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "mobile";
            this.Column3.HeaderText = "Mobile";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "address";
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ledgerId";
            this.ProductId.HeaderText = "LedgerId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductId.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(598, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 5;
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
            this.btnReset.Location = new System.Drawing.Point(687, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1289;
            this.label6.Text = "Mobile";
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Items.AddRange(new object[] {
            "All",
            "Sundry Creditors",
            "Sundry Deptors"});
            this.cmbAccountGroup.Location = new System.Drawing.Point(119, 15);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountGroup.TabIndex = 0;
            this.cmbAccountGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountGroup_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(470, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1286;
            this.label5.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1284;
            this.label8.Text = "Account Group";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(119, 41);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 20);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(572, 41);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(468, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1294;
            this.label1.Text = "Email";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(590, 526);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(572, 15);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(119, 66);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerName.TabIndex = 4;
            this.txtLedgerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1300;
            this.label2.Text = "Ledger Name";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(681, 526);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmPartyAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtLedgerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.dvgPartyAddressBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPartyAddressBook";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Address Book";
            this.Load += new System.EventHandler(this.frmPartyAddressBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPartyAddressBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPartyAddressBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPartyAddressBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.Button btnExport;
    }
}