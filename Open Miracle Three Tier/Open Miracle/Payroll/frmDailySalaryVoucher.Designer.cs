namespace Open_Miracle
{
    partial class frmDailySalaryVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailySalaryVoucher));
            this.cmbCashorBankAccount = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblCashorBankAccount = new System.Windows.Forms.Label();
            this.lblSalaryDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDailySalaryVoucher = new System.Windows.Forms.DataGridView();
            this.txtSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtdailySalaryVoucherDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDailySalaryVocherMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotelAmount = new System.Windows.Forms.Label();
            this.lblShowTotelamount = new System.Windows.Forms.Label();
            this.lblVoucherNoValidator = new System.Windows.Forms.Label();
            this.lblSalaryDateValidator = new System.Windows.Forms.Label();
            this.lblDateValidator = new System.Windows.Forms.Label();
            this.lblCashorBankLedgerValidator = new System.Windows.Forms.Label();
            this.btnAccountLedgerAdd = new System.Windows.Forms.Button();
            this.txtSalaryDate = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalaryVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCashorBankAccount
            // 
            this.cmbCashorBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashorBankAccount.FormattingEnabled = true;
            this.cmbCashorBankAccount.Location = new System.Drawing.Point(548, 40);
            this.cmbCashorBankAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashorBankAccount.Name = "cmbCashorBankAccount";
            this.cmbCashorBankAccount.Size = new System.Drawing.Size(200, 21);
            this.cmbCashorBankAccount.TabIndex = 3;
            this.cmbCashorBankAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashorBankAccount_KeyDown);
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
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(422, 470);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 48;
            this.lblNarration.Text = "Narration";
            // 
            // lblCashorBankAccount
            // 
            this.lblCashorBankAccount.AutoSize = true;
            this.lblCashorBankAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashorBankAccount.Location = new System.Drawing.Point(451, 44);
            this.lblCashorBankAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashorBankAccount.Name = "lblCashorBankAccount";
            this.lblCashorBankAccount.Size = new System.Drawing.Size(87, 13);
            this.lblCashorBankAccount.TabIndex = 47;
            this.lblCashorBankAccount.Text = "Cash / Bank a/c";
            // 
            // lblSalaryDate
            // 
            this.lblSalaryDate.AutoSize = true;
            this.lblSalaryDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalaryDate.Location = new System.Drawing.Point(17, 44);
            this.lblSalaryDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryDate.Name = "lblSalaryDate";
            this.lblSalaryDate.Size = new System.Drawing.Size(62, 13);
            this.lblSalaryDate.TabIndex = 45;
            this.lblSalaryDate.Text = "Salary Date";
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
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
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
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvDailySalaryVoucher
            // 
            this.dgvDailySalaryVoucher.AllowUserToAddRows = false;
            this.dgvDailySalaryVoucher.AllowUserToDeleteRows = false;
            this.dgvDailySalaryVoucher.AllowUserToResizeColumns = false;
            this.dgvDailySalaryVoucher.AllowUserToResizeRows = false;
            this.dgvDailySalaryVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailySalaryVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvDailySalaryVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailySalaryVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailySalaryVoucher.ColumnHeadersHeight = 25;
            this.dgvDailySalaryVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDailySalaryVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSerialNo,
            this.txtEmployeeId,
            this.dgvtxtdailySalaryVoucherDetailsId,
            this.dgvtxtDailySalaryVocherMasterId,
            this.txtEmployeeCode,
            this.txtEmployee,
            this.txtAttendanceStatus,
            this.txtWage,
            this.cmbStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailySalaryVoucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDailySalaryVoucher.EnableHeadersVisualStyles = false;
            this.dgvDailySalaryVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDailySalaryVoucher.Location = new System.Drawing.Point(18, 69);
            this.dgvDailySalaryVoucher.Name = "dgvDailySalaryVoucher";
            this.dgvDailySalaryVoucher.RowHeadersVisible = false;
            this.dgvDailySalaryVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDailySalaryVoucher.Size = new System.Drawing.Size(764, 375);
            this.dgvDailySalaryVoucher.TabIndex = 4;
            this.dgvDailySalaryVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailySalaryVoucher_CellValueChanged);
            this.dgvDailySalaryVoucher.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDailySalaryVoucher_CurrentCellDirtyStateChanged);
            this.dgvDailySalaryVoucher.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDailySalaryVoucher_DataBindingComplete);
            this.dgvDailySalaryVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDailySalaryVoucher_EditingControlShowing);
            this.dgvDailySalaryVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDailySalaryVoucher_KeyDown);
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.DataPropertyName = "Sl.No";
            this.txtSerialNo.HeaderText = "Sl No";
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.DataPropertyName = "employeeId";
            this.txtEmployeeId.HeaderText = "EmployeeId";
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtEmployeeId.Visible = false;
            // 
            // dgvtxtdailySalaryVoucherDetailsId
            // 
            this.dgvtxtdailySalaryVoucherDetailsId.DataPropertyName = "DetailsId";
            this.dgvtxtdailySalaryVoucherDetailsId.HeaderText = "DailySalaryVoucherDetailsId";
            this.dgvtxtdailySalaryVoucherDetailsId.Name = "dgvtxtdailySalaryVoucherDetailsId";
            this.dgvtxtdailySalaryVoucherDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtdailySalaryVoucherDetailsId.Visible = false;
            // 
            // dgvtxtDailySalaryVocherMasterId
            // 
            this.dgvtxtDailySalaryVocherMasterId.DataPropertyName = "MasterId";
            this.dgvtxtDailySalaryVocherMasterId.HeaderText = "dailySalaryVoucherMasterId";
            this.dgvtxtDailySalaryVocherMasterId.Name = "dgvtxtDailySalaryVocherMasterId";
            this.dgvtxtDailySalaryVocherMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDailySalaryVocherMasterId.Visible = false;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.DataPropertyName = "employeeCode";
            this.txtEmployeeCode.HeaderText = "Employee Code";
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.ReadOnly = true;
            this.txtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEmployee
            // 
            this.txtEmployee.DataPropertyName = "employeeName";
            this.txtEmployee.HeaderText = "Employee";
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtAttendanceStatus
            // 
            this.txtAttendanceStatus.DataPropertyName = "attendance";
            this.txtAttendanceStatus.HeaderText = "Attendance";
            this.txtAttendanceStatus.Name = "txtAttendanceStatus";
            this.txtAttendanceStatus.ReadOnly = true;
            this.txtAttendanceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtWage
            // 
            this.txtWage.DataPropertyName = "dailyWage";
            this.txtWage.HeaderText = "Wage";
            this.txtWage.Name = "txtWage";
            this.txtWage.ReadOnly = true;
            this.txtWage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataPropertyName = "status";
            dataGridViewCellStyle2.NullValue = "pending";
            this.cmbStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.cmbStatus.HeaderText = "Status";
            this.cmbStatus.Items.AddRange(new object[] {
            "paid",
            "pending"});
            this.cmbStatus.Name = "cmbStatus";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(532, 470);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 85);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(127, 15);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(17, 19);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 57;
            this.lblVoucherNo.Text = "Voucher No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(451, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 59;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(723, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(25, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpSalaryDate
            // 
            this.dtpSalaryDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryDate.Location = new System.Drawing.Point(302, 40);
            this.dtpSalaryDate.Name = "dtpSalaryDate";
            this.dtpSalaryDate.Size = new System.Drawing.Size(25, 20);
            this.dtpSalaryDate.TabIndex = 2;
            this.dtpSalaryDate.ValueChanged += new System.EventHandler(this.dtpSalaryDate_ValueChanged);
            // 
            // lblTotelAmount
            // 
            this.lblTotelAmount.AutoSize = true;
            this.lblTotelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotelAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotelAmount.Location = new System.Drawing.Point(602, 452);
            this.lblTotelAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotelAmount.Name = "lblTotelAmount";
            this.lblTotelAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotelAmount.TabIndex = 60;
            this.lblTotelAmount.Text = "Total Amount";
            // 
            // lblShowTotelamount
            // 
            this.lblShowTotelamount.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTotelamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotelamount.ForeColor = System.Drawing.Color.Yellow;
            this.lblShowTotelamount.Location = new System.Drawing.Point(680, 450);
            this.lblShowTotelamount.Name = "lblShowTotelamount";
            this.lblShowTotelamount.Size = new System.Drawing.Size(106, 13);
            this.lblShowTotelamount.TabIndex = 61;
            this.lblShowTotelamount.Text = "0.00";
            this.lblShowTotelamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVoucherNoValidator
            // 
            this.lblVoucherNoValidator.AutoSize = true;
            this.lblVoucherNoValidator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNoValidator.Location = new System.Drawing.Point(328, 22);
            this.lblVoucherNoValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherNoValidator.Name = "lblVoucherNoValidator";
            this.lblVoucherNoValidator.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherNoValidator.TabIndex = 114;
            this.lblVoucherNoValidator.Text = "*";
            // 
            // lblSalaryDateValidator
            // 
            this.lblSalaryDateValidator.AutoSize = true;
            this.lblSalaryDateValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryDateValidator.Location = new System.Drawing.Point(328, 47);
            this.lblSalaryDateValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryDateValidator.Name = "lblSalaryDateValidator";
            this.lblSalaryDateValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryDateValidator.TabIndex = 115;
            this.lblSalaryDateValidator.Text = "*";
            // 
            // lblDateValidator
            // 
            this.lblDateValidator.AutoSize = true;
            this.lblDateValidator.ForeColor = System.Drawing.Color.Red;
            this.lblDateValidator.Location = new System.Drawing.Point(748, 19);
            this.lblDateValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblDateValidator.Name = "lblDateValidator";
            this.lblDateValidator.Size = new System.Drawing.Size(11, 13);
            this.lblDateValidator.TabIndex = 116;
            this.lblDateValidator.Text = "*";
            // 
            // lblCashorBankLedgerValidator
            // 
            this.lblCashorBankLedgerValidator.AutoSize = true;
            this.lblCashorBankLedgerValidator.ForeColor = System.Drawing.Color.Red;
            this.lblCashorBankLedgerValidator.Location = new System.Drawing.Point(748, 51);
            this.lblCashorBankLedgerValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashorBankLedgerValidator.Name = "lblCashorBankLedgerValidator";
            this.lblCashorBankLedgerValidator.Size = new System.Drawing.Size(11, 13);
            this.lblCashorBankLedgerValidator.TabIndex = 117;
            this.lblCashorBankLedgerValidator.Text = "*";
            // 
            // btnAccountLedgerAdd
            // 
            this.btnAccountLedgerAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAccountLedgerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountLedgerAdd.FlatAppearance.BorderSize = 0;
            this.btnAccountLedgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountLedgerAdd.Location = new System.Drawing.Point(762, 41);
            this.btnAccountLedgerAdd.Name = "btnAccountLedgerAdd";
            this.btnAccountLedgerAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAccountLedgerAdd.TabIndex = 118;
            this.btnAccountLedgerAdd.UseVisualStyleBackColor = true;
            this.btnAccountLedgerAdd.Click += new System.EventHandler(this.btnAccountLedgerAdd_Click);
            // 
            // txtSalaryDate
            // 
            this.txtSalaryDate.Location = new System.Drawing.Point(127, 40);
            this.txtSalaryDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSalaryDate.Name = "txtSalaryDate";
            this.txtSalaryDate.Size = new System.Drawing.Size(180, 20);
            this.txtSalaryDate.TabIndex = 2;
            this.txtSalaryDate.TextChanged += new System.EventHandler(this.txtSalaryDate_TextChanged);
            this.txtSalaryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryDate_KeyDown);
            this.txtSalaryDate.Leave += new System.EventHandler(this.txtSalaryDate_Leave);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(548, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);
            this.txtDate.TabIndex = 1;
           
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // frmDailySalaryVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSalaryDate);
            this.Controls.Add(this.btnAccountLedgerAdd);
            this.Controls.Add(this.lblCashorBankLedgerValidator);
            this.Controls.Add(this.lblDateValidator);
            this.Controls.Add(this.lblSalaryDateValidator);
            this.Controls.Add(this.lblVoucherNoValidator);
            this.Controls.Add(this.lblShowTotelamount);
            this.Controls.Add(this.lblTotelAmount);
            this.Controls.Add(this.dtpSalaryDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.cmbCashorBankAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblCashorBankAccount);
            this.Controls.Add(this.lblSalaryDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvDailySalaryVoucher);
            this.Controls.Add(this.txtNarration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDailySalaryVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Daily Salary Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDailySalaryVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmDailySalaryVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDailySalaryVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalaryVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblCashorBankAccount;
        private System.Windows.Forms.Label lblSalaryDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDailySalaryVoucher;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpSalaryDate;
        private System.Windows.Forms.Label lblTotelAmount;
        private System.Windows.Forms.Label lblShowTotelamount;
        private System.Windows.Forms.Label lblVoucherNoValidator;
        private System.Windows.Forms.Label lblSalaryDateValidator;
        private System.Windows.Forms.Label lblDateValidator;
        private System.Windows.Forms.Label lblCashorBankLedgerValidator;
        private System.Windows.Forms.Button btnAccountLedgerAdd;
        private System.Windows.Forms.TextBox txtSalaryDate;
        private System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.ComboBox cmbCashorBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtdailySalaryVoucherDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDailySalaryVocherMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAttendanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtWage;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbStatus;
    }
}