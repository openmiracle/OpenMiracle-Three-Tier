namespace Open_Miracle
{
    partial class frmmultipleAccountLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmultipleAccountLedger));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.lblMultipleAccountledgerValidator = new System.Windows.Forms.Label();
            this.dgvMultipleAccountLedger = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbDebitOrCredit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAccountGroup = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleAccountLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklblRemove);
            this.groupBox1.Controls.Add(this.lblMultipleAccountledgerValidator);
            this.groupBox1.Controls.Add(this.dgvMultipleAccountLedger);
            this.groupBox1.Controls.Add(this.cmbAccountGroup);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblAccountGroup);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiple Account ledger";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(696, 522);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 466;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // lblMultipleAccountledgerValidator
            // 
            this.lblMultipleAccountledgerValidator.AutoSize = true;
            this.lblMultipleAccountledgerValidator.ForeColor = System.Drawing.Color.Red;
            this.lblMultipleAccountledgerValidator.Location = new System.Drawing.Point(326, 25);
            this.lblMultipleAccountledgerValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblMultipleAccountledgerValidator.Name = "lblMultipleAccountledgerValidator";
            this.lblMultipleAccountledgerValidator.Size = new System.Drawing.Size(11, 13);
            this.lblMultipleAccountledgerValidator.TabIndex = 465;
            this.lblMultipleAccountledgerValidator.Text = "*";
            // 
            // dgvMultipleAccountLedger
            // 
            this.dgvMultipleAccountLedger.AllowUserToDeleteRows = false;
            this.dgvMultipleAccountLedger.AllowUserToResizeColumns = false;
            this.dgvMultipleAccountLedger.AllowUserToResizeRows = false;
            this.dgvMultipleAccountLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultipleAccountLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvMultipleAccountLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleAccountLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMultipleAccountLedger.ColumnHeadersHeight = 25;
            this.dgvMultipleAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMultipleAccountLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtLedgerName,
            this.dgvtxtOpeningBalance,
            this.dgvcmbDebitOrCredit,
            this.dgvtxtNarration,
            this.dgvtxtCheck});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleAccountLedger.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMultipleAccountLedger.EnableHeadersVisualStyles = false;
            this.dgvMultipleAccountLedger.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMultipleAccountLedger.Location = new System.Drawing.Point(19, 55);
            this.dgvMultipleAccountLedger.MultiSelect = false;
            this.dgvMultipleAccountLedger.Name = "dgvMultipleAccountLedger";
            this.dgvMultipleAccountLedger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMultipleAccountLedger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleAccountLedger.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMultipleAccountLedger.RowHeadersWidth = 40;
            this.dgvMultipleAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMultipleAccountLedger.Size = new System.Drawing.Size(724, 462);
            this.dgvMultipleAccountLedger.TabIndex = 2;
            this.dgvMultipleAccountLedger.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleAccountLedger_CellEnter);
            this.dgvMultipleAccountLedger.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleAccountLedger_CellValueChanged);
            this.dgvMultipleAccountLedger.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMultipleAccountLedger_EditingControlShowing);
            this.dgvMultipleAccountLedger.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMultipleAccountLedger_RowsAdded);
            this.dgvMultipleAccountLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMultipleAccountLedger_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtSlNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedgerName
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtLedgerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtLedgerName.HeaderText = "Ledger Name";
            this.dgvtxtLedgerName.Name = "dgvtxtLedgerName";
            this.dgvtxtLedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOpeningBalance
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtOpeningBalance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtOpeningBalance.HeaderText = "Opening Balance";
            this.dgvtxtOpeningBalance.MaxInputLength = 13;
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbDebitOrCredit
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvcmbDebitOrCredit.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcmbDebitOrCredit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcmbDebitOrCredit.HeaderText = "Dr / Cr";
            this.dgvcmbDebitOrCredit.Items.AddRange(new object[] {
            "Dr",
            "Cr"});
            this.dgvcmbDebitOrCredit.Name = "dgvcmbDebitOrCredit";
            this.dgvcmbDebitOrCredit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtNarration
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtNarration.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.FillWeight = 10F;
            this.dgvtxtCheck.HeaderText = "";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.ReadOnly = true;
            this.dgvtxtCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(126, 21);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(5);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountGroup.TabIndex = 0;
            this.cmbAccountGroup.TextChanged += new System.EventHandler(this.cmbAccountGroup_TextChanged);
            this.cmbAccountGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountGroup_KeyDown);
            this.cmbAccountGroup.Leave += new System.EventHandler(this.cmbAccountGroup_Leave);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(658, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(567, 543);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(476, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblAccountGroup
            // 
            this.lblAccountGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountGroup.Location = new System.Drawing.Point(16, 21);
            this.lblAccountGroup.Margin = new System.Windows.Forms.Padding(5);
            this.lblAccountGroup.Name = "lblAccountGroup";
            this.lblAccountGroup.Size = new System.Drawing.Size(100, 20);
            this.lblAccountGroup.TabIndex = 464;
            this.lblAccountGroup.Text = "Account Group";
            // 
            // frmmultipleAccountLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmmultipleAccountLedger";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Account Ledger";
            this.Load += new System.EventHandler(this.frmmultipleAccountLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmultipleAccountLedger_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleAccountLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Label lblMultipleAccountledgerValidator;
        private dgv.DataGridViewEnter dgvMultipleAccountLedger;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAccountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbDebitOrCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
    }
}