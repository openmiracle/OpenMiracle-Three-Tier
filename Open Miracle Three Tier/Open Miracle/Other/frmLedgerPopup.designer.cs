namespace Open_Miracle
{
    partial class frmLedgerPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgerPopup));
            this.lblGroup = new System.Windows.Forms.Label();
            this.dgvLedgerPopup = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGroup.Location = new System.Drawing.Point(20, 43);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 25;
            this.lblGroup.Text = "Group";
            // 
            // dgvLedgerPopup
            // 
            this.dgvLedgerPopup.AllowUserToAddRows = false;
            this.dgvLedgerPopup.AllowUserToDeleteRows = false;
            this.dgvLedgerPopup.AllowUserToResizeRows = false;
            this.dgvLedgerPopup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLedgerPopup.BackgroundColor = System.Drawing.Color.White;
            this.dgvLedgerPopup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgerPopup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLedgerPopup.ColumnHeadersHeight = 25;
            this.dgvLedgerPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLedgerPopup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.dgvtxtLedgerId,
            this.dgvtxtAccountGroupId,
            this.dgvtxtLedgerName,
            this.dgvtxtOpeningBalance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLedgerPopup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLedgerPopup.EnableHeadersVisualStyles = false;
            this.dgvLedgerPopup.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLedgerPopup.Location = new System.Drawing.Point(18, 103);
            this.dgvLedgerPopup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvLedgerPopup.MultiSelect = false;
            this.dgvLedgerPopup.Name = "dgvLedgerPopup";
            this.dgvLedgerPopup.RowHeadersVisible = false;
            this.dgvLedgerPopup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedgerPopup.Size = new System.Drawing.Size(619, 201);
            this.dgvLedgerPopup.TabIndex = 5;
            this.dgvLedgerPopup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLedgerPopup_CellDoubleClick);
            this.dgvLedgerPopup.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLedgerPopup_DataBindingComplete);
            this.dgvLedgerPopup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLedgerPopup_KeyDown);
            this.dgvLedgerPopup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvLedgerPopup_KeyUp);
            // 
            // Col
            // 
            this.Col.DataPropertyName = "Sl No";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "LedgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtAccountGroupId
            // 
            this.dgvtxtAccountGroupId.DataPropertyName = "accountGroupId";
            this.dgvtxtAccountGroupId.HeaderText = "AccountGroupId";
            this.dgvtxtAccountGroupId.Name = "dgvtxtAccountGroupId";
            this.dgvtxtAccountGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAccountGroupId.Visible = false;
            // 
            // dgvtxtLedgerName
            // 
            this.dgvtxtLedgerName.DataPropertyName = "ledgerName";
            this.dgvtxtLedgerName.HeaderText = "Name";
            this.dgvtxtLedgerName.Name = "dgvtxtLedgerName";
            this.dgvtxtLedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOpeningBalance
            // 
            this.dgvtxtOpeningBalance.DataPropertyName = "Balance";
            this.dgvtxtOpeningBalance.HeaderText = "Balance";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(107, 15);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerName.TabIndex = 1;
            this.txtLedgerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(107, 40);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbAccountGroup.TabIndex = 2;
            this.cmbAccountGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAccountGroup_KeyDown);
            // 
            // frmLedgerPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(655, 324);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.dgvLedgerPopup);
            this.Controls.Add(this.txtLedgerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLedgerPopup";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLedgerPopup_FormClosing);
            this.Load += new System.EventHandler(this.frmLedgerPopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLedgerPopup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerPopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DataGridView dgvLedgerPopup;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
    }
}