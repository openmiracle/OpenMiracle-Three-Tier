namespace Open_Miracle
{
    partial class frmSalaryPackageCreation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryPackageCreation));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblnarration = new System.Windows.Forms.Label();
            this.lblactive = new System.Windows.Forms.Label();
            this.lblpackageName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSalaryPackage = new Open_Miracle.dgv.DataGridViewEnter();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblSalaryAmount = new System.Windows.Forms.Label();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbPayHead = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(125, 15);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(200, 20);
            this.txtPackageName.TabIndex = 0;
            this.txtPackageName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPackageName_KeyDown);
            // 
            // lblnarration
            // 
            this.lblnarration.AutoSize = true;
            this.lblnarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnarration.Location = new System.Drawing.Point(15, 66);
            this.lblnarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblnarration.Name = "lblnarration";
            this.lblnarration.Size = new System.Drawing.Size(50, 13);
            this.lblnarration.TabIndex = 20;
            this.lblnarration.Text = "Narration";
            // 
            // lblactive
            // 
            this.lblactive.AutoSize = true;
            this.lblactive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblactive.Location = new System.Drawing.Point(15, 44);
            this.lblactive.Margin = new System.Windows.Forms.Padding(5);
            this.lblactive.Name = "lblactive";
            this.lblactive.Size = new System.Drawing.Size(37, 13);
            this.lblactive.TabIndex = 18;
            this.lblactive.Text = "Active";
            // 
            // lblpackageName
            // 
            this.lblpackageName.AutoSize = true;
            this.lblpackageName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpackageName.Location = new System.Drawing.Point(15, 19);
            this.lblpackageName.Margin = new System.Windows.Forms.Padding(5);
            this.lblpackageName.Name = "lblpackageName";
            this.lblpackageName.Size = new System.Drawing.Size(81, 13);
            this.lblpackageName.TabIndex = 16;
            this.lblpackageName.Text = "Package Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnclear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // dgvSalaryPackage
            // 
            this.dgvSalaryPackage.AllowUserToResizeColumns = false;
            this.dgvSalaryPackage.AllowUserToResizeRows = false;
            this.dgvSalaryPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryPackage.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaryPackage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryPackage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryPackage.ColumnHeadersHeight = 25;
            this.dgvSalaryPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalaryPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvcmbPayHead,
            this.dgvtxtStatus,
            this.dgvtxtType,
            this.dgvtxtAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryPackage.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaryPackage.EnableHeadersVisualStyles = false;
            this.dgvSalaryPackage.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalaryPackage.Location = new System.Drawing.Point(18, 124);
            this.dgvSalaryPackage.Name = "dgvSalaryPackage";
            this.dgvSalaryPackage.RowHeadersVisible = false;
            this.dgvSalaryPackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalaryPackage.Size = new System.Drawing.Size(764, 384);
            this.dgvSalaryPackage.TabIndex = 3;
            this.dgvSalaryPackage.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSalaryPackage_CellBeginEdit);
             this.dgvSalaryPackage.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryPackage_CellEnter);
            this.dgvSalaryPackage.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryPackage_CellValueChanged);
            this.dgvSalaryPackage.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSalaryPackage_CurrentCellDirtyStateChanged);
            this.dgvSalaryPackage.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSalaryPackage_DataBindingComplete);
             this.dgvSalaryPackage.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSalaryPackage_EditingControlShowing);
            this.dgvSalaryPackage.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSalaryPackage_RowsAdded);
            this.dgvSalaryPackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalaryPackage_KeyDown);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(125, 66);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 2;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // cmbActive
            // 
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbActive.Location = new System.Drawing.Point(125, 40);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(200, 21);
            this.cmbActive.TabIndex = 1;
            this.cmbActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbActive_KeyDown);
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalary.Location = new System.Drawing.Point(594, 533);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 101;
            this.lblSalary.Text = "Salary:";
            // 
            // lblSalaryAmount
            // 
            this.lblSalaryAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblSalaryAmount.Location = new System.Drawing.Point(639, 533);
            this.lblSalaryAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryAmount.Name = "lblSalaryAmount";
            this.lblSalaryAmount.Size = new System.Drawing.Size(143, 20);
            this.lblSalaryAmount.TabIndex = 101;
            this.lblSalaryAmount.Text = "0.00";
            this.lblSalaryAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.ForeColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(735, 515);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 102;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(331, 22);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 114;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbPayHead
            // 
            this.dgvcmbPayHead.DataPropertyName = "payHeadId";
            this.dgvcmbPayHead.HeaderText = "Payhead";
            this.dgvcmbPayHead.Name = "dgvcmbPayHead";
            this.dgvcmbPayHead.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtStatus
            // 
            this.dgvtxtStatus.HeaderText = "Status";
            this.dgvtxtStatus.Name = "dgvtxtStatus";
            this.dgvtxtStatus.ReadOnly = true;
            this.dgvtxtStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtStatus.Visible = false;
            // 
            // dgvtxtType
            // 
            this.dgvtxtType.DataPropertyName = "type";
            this.dgvtxtType.HeaderText = "Type";
            this.dgvtxtType.Name = "dgvtxtType";
            this.dgvtxtType.ReadOnly = true;
            this.dgvtxtType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 10;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSalaryPackageCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.lblSalaryAmount);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cmbActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.lblnarration);
            this.Controls.Add(this.lblactive);
            this.Controls.Add(this.lblpackageName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSalaryPackage);
            this.Controls.Add(this.txtNarration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalaryPackageCreation";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Package";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalaryPackageCreation_FormClosing);
            this.Load += new System.EventHandler(this.frmSalaryPackageCreation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalaryPackageCreation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label lblnarration;
        private System.Windows.Forms.Label lblactive;
        private System.Windows.Forms.Label lblpackageName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblSalaryAmount;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private dgv.DataGridViewEnter dgvSalaryPackage;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbPayHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}