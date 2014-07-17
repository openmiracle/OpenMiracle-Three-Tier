namespace Open_Miracle
{
    partial class frmBonusDeduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonusDeduction));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeductionAmount = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDeductionAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtBonusAmount = new System.Windows.Forms.TextBox();
            this.lblBonusAmount = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblDateMandatory = new System.Windows.Forms.Label();
            this.lblEmployeeCodeMandatory = new System.Windows.Forms.Label();
            this.lblDeductionAmountMandatory = new System.Windows.Forms.Label();
            this.lblBonusAmountMandatory = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            // 
            // txtDeductionAmount
            // 
            this.txtDeductionAmount.Location = new System.Drawing.Point(130, 65);
            this.txtDeductionAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDeductionAmount.MaxLength = 15;
            this.txtDeductionAmount.Name = "txtDeductionAmount";
            this.txtDeductionAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeductionAmount.Size = new System.Drawing.Size(200, 20);
            this.txtDeductionAmount.TabIndex = 4;
            this.txtDeductionAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeductionAmount_KeyDown);
            this.txtDeductionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeductionAmount_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(475, 66);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 48;
            this.lblNarration.Text = "Narration";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(20, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "Date";
            // 
            // lblDeductionAmount
            // 
            this.lblDeductionAmount.AutoSize = true;
            this.lblDeductionAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeductionAmount.Location = new System.Drawing.Point(20, 68);
            this.lblDeductionAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDeductionAmount.Name = "lblDeductionAmount";
            this.lblDeductionAmount.Size = new System.Drawing.Size(95, 13);
            this.lblDeductionAmount.TabIndex = 45;
            this.lblDeductionAmount.Text = "Deduction Amount";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(580, 66);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(580, 15);
            this.cmbEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeCode.TabIndex = 1;
            this.cmbEmployeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeCode_KeyDown);
           
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmployeeCode.Location = new System.Drawing.Point(475, 19);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeCode.TabIndex = 57;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.Location = new System.Drawing.Point(20, 44);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 59;
            this.lblMonth.Text = "Month";
            // 
            // txtBonusAmount
            // 
            this.txtBonusAmount.Location = new System.Drawing.Point(580, 41);
            this.txtBonusAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBonusAmount.MaxLength = 15;
            this.txtBonusAmount.Name = "txtBonusAmount";
            this.txtBonusAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBonusAmount.Size = new System.Drawing.Size(200, 20);
            this.txtBonusAmount.TabIndex = 3;
            this.txtBonusAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBonusAmount_KeyDown);
            this.txtBonusAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonusAmount_KeyPress);
            // 
            // lblBonusAmount
            // 
            this.lblBonusAmount.AutoSize = true;
            this.lblBonusAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBonusAmount.Location = new System.Drawing.Point(475, 45);
            this.lblBonusAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBonusAmount.Name = "lblBonusAmount";
            this.lblBonusAmount.Size = new System.Drawing.Size(76, 13);
            this.lblBonusAmount.TabIndex = 65;
            this.lblBonusAmount.Text = "Bonus Amount";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(307, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(23, 20);
            this.dtpDate.TabIndex = 1000;
            this.dtpDate.TabStop = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpMonth
            // 
            this.dtpMonth.Checked = false;
            this.dtpMonth.CustomFormat = "MMMMyyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(130, 40);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpMonth.TabIndex = 2;
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // lblDateMandatory
            // 
            this.lblDateMandatory.AutoSize = true;
            this.lblDateMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblDateMandatory.Location = new System.Drawing.Point(336, 19);
            this.lblDateMandatory.Name = "lblDateMandatory";
            this.lblDateMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblDateMandatory.TabIndex = 66;
            this.lblDateMandatory.Text = "*";
            // 
            // lblEmployeeCodeMandatory
            // 
            this.lblEmployeeCodeMandatory.AutoSize = true;
            this.lblEmployeeCodeMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeCodeMandatory.Location = new System.Drawing.Point(796, 59);
            this.lblEmployeeCodeMandatory.Name = "lblEmployeeCodeMandatory";
            this.lblEmployeeCodeMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblEmployeeCodeMandatory.TabIndex = 66;
            this.lblEmployeeCodeMandatory.Text = "*";
            // 
            // lblDeductionAmountMandatory
            // 
            this.lblDeductionAmountMandatory.AutoSize = true;
            this.lblDeductionAmountMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblDeductionAmountMandatory.Location = new System.Drawing.Point(338, 72);
            this.lblDeductionAmountMandatory.Name = "lblDeductionAmountMandatory";
            this.lblDeductionAmountMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblDeductionAmountMandatory.TabIndex = 66;
            this.lblDeductionAmountMandatory.Text = "*";
            // 
            // lblBonusAmountMandatory
            // 
            this.lblBonusAmountMandatory.AutoSize = true;
            this.lblBonusAmountMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblBonusAmountMandatory.Location = new System.Drawing.Point(796, 87);
            this.lblBonusAmountMandatory.Name = "lblBonusAmountMandatory";
            this.lblBonusAmountMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblBonusAmountMandatory.TabIndex = 66;
            this.lblBonusAmountMandatory.Text = "*";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(130, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.MaxLength = 15;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // frmBonusDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 165);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblBonusAmountMandatory);
            this.Controls.Add(this.lblDeductionAmountMandatory);
            this.Controls.Add(this.lblEmployeeCodeMandatory);
            this.Controls.Add(this.lblDateMandatory);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBonusAmount);
            this.Controls.Add(this.lblBonusAmount);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbEmployeeCode);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeductionAmount);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDeductionAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNarration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBonusDeduction";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus / Deduction ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBonusDeduction_FormClosing);
            this.Load += new System.EventHandler(this.frmBonusDeduction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBonusDeduction_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeductionAmount;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDeductionAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtBonusAmount;
        private System.Windows.Forms.Label lblBonusAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblDateMandatory;
        private System.Windows.Forms.Label lblEmployeeCodeMandatory;
        private System.Windows.Forms.Label lblDeductionAmountMandatory;
        private System.Windows.Forms.Label lblBonusAmountMandatory;
        private System.Windows.Forms.TextBox txtDate;
    }
}