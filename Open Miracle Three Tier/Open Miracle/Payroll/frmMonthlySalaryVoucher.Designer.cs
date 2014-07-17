namespace Open_Miracle
{
    partial class frmMonthlySalaryVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlySalaryVoucher));
            this.dgvMonthlySalary = new System.Windows.Forms.DataGridView();
            this.txtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblVoucherDate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblCashOrBank = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cmbCashOrBankAcc = new System.Windows.Forms.ComboBox();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.lblVoucherNoIndicator = new System.Windows.Forms.Label();
            this.lblCashOrBankIndicator = new System.Windows.Forms.Label();
            this.lblVoucherDateIndicator = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnAccountLedgerAdd = new System.Windows.Forms.Button();
            this.txtVoucherDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalary)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonthlySalary
            // 
            this.dgvMonthlySalary.AllowUserToAddRows = false;
            this.dgvMonthlySalary.AllowUserToDeleteRows = false;
            this.dgvMonthlySalary.AllowUserToResizeColumns = false;
            this.dgvMonthlySalary.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMonthlySalary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlySalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlySalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthlySalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0.00";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlySalary.ColumnHeadersHeight = 32;
            this.dgvMonthlySalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonthlySalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSlNo,
            this.txtEmployeeId,
            this.txtMasterId,
            this.txtDetailsId,
            this.txtEmployeeCode,
            this.txtEmployee,
            this.txtBonus,
            this.txtDeduction,
            this.txtAdvance,
            this.txtLop,
            this.txtSalary,
            this.txtStatus,
            this.cmbStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = "0.00";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlySalary.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMonthlySalary.EnableHeadersVisualStyles = false;
            this.dgvMonthlySalary.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMonthlySalary.Location = new System.Drawing.Point(19, 24);
            this.dgvMonthlySalary.MultiSelect = false;
            this.dgvMonthlySalary.Name = "dgvMonthlySalary";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMonthlySalary.RowHeadersVisible = false;
            this.dgvMonthlySalary.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMonthlySalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlySalary.Size = new System.Drawing.Size(726, 323);
            this.dgvMonthlySalary.TabIndex = 0;
            this.dgvMonthlySalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonthlySalary_CellValueChanged);
            this.dgvMonthlySalary.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonthlySalary_CellValueChanged);
            this.dgvMonthlySalary.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMonthlySalary_CurrentCellDirtyStateChanged);
            this.dgvMonthlySalary.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMonthlySalary_DataBindingComplete);
            this.dgvMonthlySalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMonthlySalary_KeyDown);
            // 
            // txtSlNo
            // 
            this.txtSlNo.DataPropertyName = "SlNo";
            this.txtSlNo.HeaderText = "Sl No.";
            this.txtSlNo.Name = "txtSlNo";
            this.txtSlNo.ReadOnly = true;
            this.txtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.DataPropertyName = "employeeId";
            this.txtEmployeeId.HeaderText = "Employee Id";
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtEmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtEmployeeId.Visible = false;
            // 
            // txtMasterId
            // 
            this.txtMasterId.DataPropertyName = "masterId";
            this.txtMasterId.HeaderText = "MasterId";
            this.txtMasterId.Name = "txtMasterId";
            this.txtMasterId.ReadOnly = true;
            this.txtMasterId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtMasterId.Visible = false;
            // 
            // txtDetailsId
            // 
            this.txtDetailsId.DataPropertyName = "detailsId";
            this.txtDetailsId.HeaderText = "DetailsId";
            this.txtDetailsId.Name = "txtDetailsId";
            this.txtDetailsId.ReadOnly = true;
            this.txtDetailsId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtDetailsId.Visible = false;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.DataPropertyName = "employeeCode";
            this.txtEmployeeCode.FillWeight = 110F;
            this.txtEmployeeCode.HeaderText = "Employee Code";
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.ReadOnly = true;
            this.txtEmployeeCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEmployee
            // 
            this.txtEmployee.DataPropertyName = "employeeName";
            this.txtEmployee.HeaderText = "Employee";
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtBonus
            // 
            this.txtBonus.DataPropertyName = "bonusAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0.00";
            this.txtBonus.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtBonus.HeaderText = "Bonus";
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtBonus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtDeduction
            // 
            this.txtDeduction.DataPropertyName = "deductionAmount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "0.00";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.txtDeduction.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtDeduction.HeaderText = "Deduction";
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.ReadOnly = true;
            this.txtDeduction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtDeduction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtAdvance
            // 
            this.txtAdvance.DataPropertyName = "amount";
            this.txtAdvance.HeaderText = "Advance";
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtAdvance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtLop
            // 
            this.txtLop.DataPropertyName = "lop";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = "0.00";
            this.txtLop.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtLop.HeaderText = "LOP";
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtLop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSalary
            // 
            this.txtSalary.DataPropertyName = "salary";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.txtSalary.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtSalary.HeaderText = "Salary";
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtSalary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "status";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtStatus.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataPropertyName = "status";
            dataGridViewCellStyle7.NullValue = "Pending";
            this.cmbStatus.DefaultCellStyle = dataGridViewCellStyle7;
            this.cmbStatus.HeaderText = "Status";
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // txtVoucherNo
            // 
            this.txtVoucherNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVoucherNo.Location = new System.Drawing.Point(125, 15);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(431, 468);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 48;
            this.lblNarration.Text = "Narration";
            // 
            // lblVoucherDate
            // 
            this.lblVoucherDate.AutoSize = true;
            this.lblVoucherDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDate.Location = new System.Drawing.Point(477, 19);
            this.lblVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherDate.Name = "lblVoucherDate";
            this.lblVoucherDate.Size = new System.Drawing.Size(73, 13);
            this.lblVoucherDate.TabIndex = 47;
            this.lblVoucherDate.Text = "Voucher Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(15, 19);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(67, 13);
            this.lblVoucherNo.TabIndex = 45;
            this.lblVoucherNo.Text = "Voucher No.";
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
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(530, 468);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 85);
            this.txtNarration.TabIndex = 5;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblCashOrBank
            // 
            this.lblCashOrBank.AutoSize = true;
            this.lblCashOrBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrBank.Location = new System.Drawing.Point(477, 44);
            this.lblCashOrBank.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashOrBank.Name = "lblCashOrBank";
            this.lblCashOrBank.Size = new System.Drawing.Size(90, 13);
            this.lblCashOrBank.TabIndex = 58;
            this.lblCashOrBank.Text = "Cash / Bank a/c ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.Location = new System.Drawing.Point(15, 40);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 57;
            this.lblMonth.Text = "Month";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgvMonthlySalary);
            this.gbDetails.ForeColor = System.Drawing.Color.White;
            this.gbDetails.Location = new System.Drawing.Point(18, 66);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(764, 362);
            this.gbDetails.TabIndex = 5;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // cmbCashOrBankAcc
            // 
            this.cmbCashOrBankAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBankAcc.FormattingEnabled = true;
            this.cmbCashOrBankAcc.Location = new System.Drawing.Point(585, 40);
            this.cmbCashOrBankAcc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrBankAcc.Name = "cmbCashOrBankAcc";
            this.cmbCashOrBankAcc.Size = new System.Drawing.Size(160, 21);
            this.cmbCashOrBankAcc.TabIndex = 3;
            this.cmbCashOrBankAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBankAcc_KeyDown);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMMMyyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(125, 40);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpMonth.TabIndex = 2;
            this.dtpMonth.ValueChanged += new System.EventHandler(this.dtpMonth_ValueChanged);
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(759, 15);
            this.dtpVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(21, 20);
            this.dtpVoucherDate.TabIndex = 10;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // lblVoucherNoIndicator
            // 
            this.lblVoucherNoIndicator.AutoSize = true;
            this.lblVoucherNoIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNoIndicator.Location = new System.Drawing.Point(328, 21);
            this.lblVoucherNoIndicator.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherNoIndicator.Name = "lblVoucherNoIndicator";
            this.lblVoucherNoIndicator.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherNoIndicator.TabIndex = 114;
            this.lblVoucherNoIndicator.Text = "*";
            // 
            // lblCashOrBankIndicator
            // 
            this.lblCashOrBankIndicator.AutoSize = true;
            this.lblCashOrBankIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblCashOrBankIndicator.Location = new System.Drawing.Point(746, 45);
            this.lblCashOrBankIndicator.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashOrBankIndicator.Name = "lblCashOrBankIndicator";
            this.lblCashOrBankIndicator.Size = new System.Drawing.Size(11, 13);
            this.lblCashOrBankIndicator.TabIndex = 115;
            this.lblCashOrBankIndicator.Text = "*";
            // 
            // lblVoucherDateIndicator
            // 
            this.lblVoucherDateIndicator.AutoSize = true;
            this.lblVoucherDateIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherDateIndicator.Location = new System.Drawing.Point(796, 56);
            this.lblVoucherDateIndicator.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherDateIndicator.Name = "lblVoucherDateIndicator";
            this.lblVoucherDateIndicator.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherDateIndicator.TabIndex = 114;
            this.lblVoucherDateIndicator.Text = "*";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(578, 449);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 13);
            this.lblTotal.TabIndex = 116;
            this.lblTotal.Text = "Total Amount :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalAmount.Location = new System.Drawing.Point(664, 447);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 13);
            this.lblTotalAmount.TabIndex = 117;
            this.lblTotalAmount.Text = "0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAccountLedgerAdd
            // 
            this.btnAccountLedgerAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAccountLedgerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountLedgerAdd.FlatAppearance.BorderSize = 0;
            this.btnAccountLedgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountLedgerAdd.Location = new System.Drawing.Point(760, 40);
            this.btnAccountLedgerAdd.Name = "btnAccountLedgerAdd";
            this.btnAccountLedgerAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAccountLedgerAdd.TabIndex = 4;
            this.btnAccountLedgerAdd.UseVisualStyleBackColor = true;
            this.btnAccountLedgerAdd.Click += new System.EventHandler(this.btnAccountLedgerAdd_Click);
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.Location = new System.Drawing.Point(585, 15);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(176, 20);
            this.txtVoucherDate.TabIndex = 1;
             this.txtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDate_KeyDown);
            this.txtVoucherDate.Leave += new System.EventHandler(this.txtVoucherDate_Leave);
            // 
            // frmMonthlySalaryVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.btnAccountLedgerAdd);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVoucherDateIndicator);
            this.Controls.Add(this.lblCashOrBankIndicator);
            this.Controls.Add(this.lblVoucherNoIndicator);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.cmbCashOrBankAcc);
            this.Controls.Add(this.lblCashOrBank);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblVoucherDate);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.gbDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMonthlySalaryVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Salary Voucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonthlySalaryVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmMonthlySalaryVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonthlySalaryVoucher_KeyDown);
             ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalary)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblVoucherDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblCashOrBank;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.Label lblVoucherNoIndicator;
        private System.Windows.Forms.Label lblCashOrBankIndicator;
        private System.Windows.Forms.Label lblVoucherDateIndicator;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnAccountLedgerAdd;
        private System.Windows.Forms.TextBox txtVoucherDate;
        private System.Windows.Forms.DataGridView dgvMonthlySalary;
        private System.Windows.Forms.ComboBox cmbCashOrBankAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbStatus;
    }
}