namespace Open_Miracle
{
    partial class frmAccountLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLedger));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLedgerNameSearch = new System.Windows.Forms.TextBox();
            this.lblLedgerNameSearch = new System.Windows.Forms.Label();
            this.cmbGroupSearch = new System.Windows.Forms.ComboBox();
            this.lblGroupSearch = new System.Windows.Forms.Label();
            this.tbSecondaryDetails = new System.Windows.Forms.TabPage();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtCst = new System.Windows.Forms.TextBox();
            this.txtCreditPeriod = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtMailingName = new System.Windows.Forms.TextBox();
            this.lblCst = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPan = new System.Windows.Forms.Label();
            this.lblTin = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbBillByBill = new System.Windows.Forms.ComboBox();
            this.lblBillbyBill = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.cmbPricingLevel = new System.Windows.Forms.ComboBox();
            this.lblPricingLevel = new System.Windows.Forms.Label();
            this.lblMailingName = new System.Windows.Forms.Label();
            this.tbMainDetails = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.btnAccountGroupAdd = new System.Windows.Forms.Button();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.lblBranchCode = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.lblACNo = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.cmbOpeningBalanceCrOrDr = new System.Windows.Forms.ComboBox();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbctrlLedger = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCreditOrDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).BeginInit();
            this.tbSecondaryDetails.SuspendLayout();
            this.tbMainDetails.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.tbctrlLedger.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(659, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvAccountLedger
            // 
            this.dgvAccountLedger.AllowUserToAddRows = false;
            this.dgvAccountLedger.AllowUserToDeleteRows = false;
            this.dgvAccountLedger.AllowUserToResizeColumns = false;
            this.dgvAccountLedger.AllowUserToResizeRows = false;
            this.dgvAccountLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountLedger.ColumnHeadersHeight = 25;
            this.dgvAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtLedgerId,
            this.dgvtxtSlNo,
            this.dgvtxtLedger,
            this.dgvtxtGroup,
            this.dgvtxtOpeningBalance,
            this.dgvtxtCreditOrDebit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountLedger.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccountLedger.EnableHeadersVisualStyles = false;
            this.dgvAccountLedger.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAccountLedger.Location = new System.Drawing.Point(38, 415);
            this.dgvAccountLedger.MultiSelect = false;
            this.dgvAccountLedger.Name = "dgvAccountLedger";
            this.dgvAccountLedger.ReadOnly = true;
            this.dgvAccountLedger.RowHeadersVisible = false;
            this.dgvAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountLedger.Size = new System.Drawing.Size(724, 153);
            this.dgvAccountLedger.TabIndex = 39;
            this.dgvAccountLedger.TabStop = false;
            this.dgvAccountLedger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountLedger_CellDoubleClick);
            this.dgvAccountLedger.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAccountLedger_DataBindingComplete);
            this.dgvAccountLedger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAccountLedger_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(568, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(659, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(386, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 0;
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
            this.btnClear.Location = new System.Drawing.Point(477, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLedgerNameSearch
            // 
            this.txtLedgerNameSearch.Location = new System.Drawing.Point(131, 23);
            this.txtLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerNameSearch.Name = "txtLedgerNameSearch";
            this.txtLedgerNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerNameSearch.TabIndex = 0;
            this.txtLedgerNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerNameSearch_KeyDown);
            // 
            // lblLedgerNameSearch
            // 
            this.lblLedgerNameSearch.AutoSize = true;
            this.lblLedgerNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLedgerNameSearch.Location = new System.Drawing.Point(21, 27);
            this.lblLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLedgerNameSearch.Name = "lblLedgerNameSearch";
            this.lblLedgerNameSearch.Size = new System.Drawing.Size(35, 13);
            this.lblLedgerNameSearch.TabIndex = 171;
            this.lblLedgerNameSearch.Text = "Name";
            // 
            // cmbGroupSearch
            // 
            this.cmbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupSearch.FormattingEnabled = true;
            this.cmbGroupSearch.Location = new System.Drawing.Point(453, 23);
            this.cmbGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroupSearch.Name = "cmbGroupSearch";
            this.cmbGroupSearch.Size = new System.Drawing.Size(200, 21);
            this.cmbGroupSearch.TabIndex = 1;
            this.cmbGroupSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroupSearch_KeyDown);
            // 
            // lblGroupSearch
            // 
            this.lblGroupSearch.AutoSize = true;
            this.lblGroupSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGroupSearch.Location = new System.Drawing.Point(343, 27);
            this.lblGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroupSearch.Name = "lblGroupSearch";
            this.lblGroupSearch.Size = new System.Drawing.Size(36, 13);
            this.lblGroupSearch.TabIndex = 169;
            this.lblGroupSearch.Text = "Group";
            // 
            // tbSecondaryDetails
            // 
            this.tbSecondaryDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.tbSecondaryDetails.Controls.Add(this.cmbRoute);
            this.tbSecondaryDetails.Controls.Add(this.lblRoute);
            this.tbSecondaryDetails.Controls.Add(this.cmbArea);
            this.tbSecondaryDetails.Controls.Add(this.lblArea);
            this.tbSecondaryDetails.Controls.Add(this.txtCst);
            this.tbSecondaryDetails.Controls.Add(this.txtCreditPeriod);
            this.tbSecondaryDetails.Controls.Add(this.txtEmail);
            this.tbSecondaryDetails.Controls.Add(this.txtPhone);
            this.tbSecondaryDetails.Controls.Add(this.txtPan);
            this.tbSecondaryDetails.Controls.Add(this.txtTin);
            this.tbSecondaryDetails.Controls.Add(this.txtCreditLimit);
            this.tbSecondaryDetails.Controls.Add(this.txtAccountNo);
            this.tbSecondaryDetails.Controls.Add(this.txtAddress);
            this.tbSecondaryDetails.Controls.Add(this.txtMobile);
            this.tbSecondaryDetails.Controls.Add(this.txtMailingName);
            this.tbSecondaryDetails.Controls.Add(this.lblCst);
            this.tbSecondaryDetails.Controls.Add(this.label21);
            this.tbSecondaryDetails.Controls.Add(this.lblEmail);
            this.tbSecondaryDetails.Controls.Add(this.lblPhone);
            this.tbSecondaryDetails.Controls.Add(this.lblPan);
            this.tbSecondaryDetails.Controls.Add(this.lblTin);
            this.tbSecondaryDetails.Controls.Add(this.label16);
            this.tbSecondaryDetails.Controls.Add(this.lblAccountNo);
            this.tbSecondaryDetails.Controls.Add(this.lblAddress);
            this.tbSecondaryDetails.Controls.Add(this.cmbBillByBill);
            this.tbSecondaryDetails.Controls.Add(this.lblBillbyBill);
            this.tbSecondaryDetails.Controls.Add(this.lblMobile);
            this.tbSecondaryDetails.Controls.Add(this.cmbPricingLevel);
            this.tbSecondaryDetails.Controls.Add(this.lblPricingLevel);
            this.tbSecondaryDetails.Controls.Add(this.lblMailingName);
            this.tbSecondaryDetails.Location = new System.Drawing.Point(4, 22);
            this.tbSecondaryDetails.Name = "tbSecondaryDetails";
            this.tbSecondaryDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbSecondaryDetails.Size = new System.Drawing.Size(716, 236);
            this.tbSecondaryDetails.TabIndex = 1;
            this.tbSecondaryDetails.Text = "Secondary Details";
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(498, 191);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(199, 21);
            this.cmbRoute.TabIndex = 25;
            this.cmbRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRoute_KeyDown);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoute.Location = new System.Drawing.Point(389, 195);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(36, 13);
            this.lblRoute.TabIndex = 192;
            this.lblRoute.Text = "Route";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(498, 165);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(199, 21);
            this.cmbArea.TabIndex = 24;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            this.cmbArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArea_KeyDown);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(389, 169);
            this.lblArea.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 190;
            this.lblArea.Text = "Area";
            // 
            // txtCst
            // 
            this.txtCst.Location = new System.Drawing.Point(498, 140);
            this.txtCst.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtCst.MaxLength = 20;
            this.txtCst.Name = "txtCst";
            this.txtCst.Size = new System.Drawing.Size(199, 20);
            this.txtCst.TabIndex = 23;
            this.txtCst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCst_KeyDown);
            // 
            // txtCreditPeriod
            // 
            this.txtCreditPeriod.Location = new System.Drawing.Point(498, 115);
            this.txtCreditPeriod.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtCreditPeriod.MaxLength = 3;
            this.txtCreditPeriod.Name = "txtCreditPeriod";
            this.txtCreditPeriod.Size = new System.Drawing.Size(199, 20);
            this.txtCreditPeriod.TabIndex = 22;
            this.txtCreditPeriod.Enter += new System.EventHandler(this.txtCreditPeriod_Enter);
            this.txtCreditPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditPeriod_KeyDown);
            this.txtCreditPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditPeriod_KeyPress);
            this.txtCreditPeriod.Leave += new System.EventHandler(this.txtCreditPeriod_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(498, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(498, 39);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 20);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(125, 194);
            this.txtPan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPan.MaxLength = 20;
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(200, 20);
            this.txtPan.TabIndex = 17;
            this.txtPan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPan_KeyDown);
            // 
            // txtTin
            // 
            this.txtTin.Location = new System.Drawing.Point(125, 169);
            this.txtTin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTin.MaxLength = 20;
            this.txtTin.Name = "txtTin";
            this.txtTin.Size = new System.Drawing.Size(200, 20);
            this.txtTin.TabIndex = 16;
            this.txtTin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTin_KeyDown);
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(125, 144);
            this.txtCreditLimit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtCreditLimit.MaxLength = 13;
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(200, 20);
            this.txtCreditLimit.TabIndex = 15;
            this.txtCreditLimit.Enter += new System.EventHandler(this.txtCreditLimit_Enter);
            this.txtCreditLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditLimit_KeyDown);
            this.txtCreditLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditLimit_KeyPress);
            this.txtCreditLimit.Leave += new System.EventHandler(this.txtCreditLimit_Leave);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(498, 14);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAccountNo.MaxLength = 18;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(199, 20);
            this.txtAccountNo.TabIndex = 18;
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNo_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 38);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 50);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(125, 93);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtMobile.MaxLength = 15;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 20);
            this.txtMobile.TabIndex = 13;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtMailingName
            // 
            this.txtMailingName.Location = new System.Drawing.Point(125, 13);
            this.txtMailingName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtMailingName.Name = "txtMailingName";
            this.txtMailingName.Size = new System.Drawing.Size(200, 20);
            this.txtMailingName.TabIndex = 11;
            this.txtMailingName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailingName_KeyDown);
            // 
            // lblCst
            // 
            this.lblCst.AutoSize = true;
            this.lblCst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCst.Location = new System.Drawing.Point(389, 144);
            this.lblCst.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCst.Name = "lblCst";
            this.lblCst.Size = new System.Drawing.Size(28, 13);
            this.lblCst.TabIndex = 188;
            this.lblCst.Text = "CST";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(389, 119);
            this.label21.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 186;
            this.label21.Text = "Credit Period";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(389, 68);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 184;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhone.Location = new System.Drawing.Point(389, 43);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 182;
            this.lblPhone.Text = "Phone";
            // 
            // lblPan
            // 
            this.lblPan.AutoSize = true;
            this.lblPan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPan.Location = new System.Drawing.Point(16, 198);
            this.lblPan.Margin = new System.Windows.Forms.Padding(5);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(29, 13);
            this.lblPan.TabIndex = 180;
            this.lblPan.Text = "PAN";
            // 
            // lblTin
            // 
            this.lblTin.AutoSize = true;
            this.lblTin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTin.Location = new System.Drawing.Point(16, 173);
            this.lblTin.Margin = new System.Windows.Forms.Padding(5);
            this.lblTin.Name = "lblTin";
            this.lblTin.Size = new System.Drawing.Size(25, 13);
            this.lblTin.TabIndex = 178;
            this.lblTin.Text = "TIN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(16, 148);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 176;
            this.label16.Text = "Credit Limit";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountNo.Location = new System.Drawing.Point(389, 18);
            this.lblAccountNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 174;
            this.lblAccountNo.Text = "Account No.";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(16, 38);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 172;
            this.lblAddress.Text = "Address";
            // 
            // cmbBillByBill
            // 
            this.cmbBillByBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillByBill.FormattingEnabled = true;
            this.cmbBillByBill.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbBillByBill.Location = new System.Drawing.Point(498, 89);
            this.cmbBillByBill.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbBillByBill.Name = "cmbBillByBill";
            this.cmbBillByBill.Size = new System.Drawing.Size(199, 21);
            this.cmbBillByBill.TabIndex = 21;
            this.cmbBillByBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBillByBill_KeyDown);
            // 
            // lblBillbyBill
            // 
            this.lblBillbyBill.AutoSize = true;
            this.lblBillbyBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBillbyBill.Location = new System.Drawing.Point(389, 93);
            this.lblBillbyBill.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBillbyBill.Name = "lblBillbyBill";
            this.lblBillbyBill.Size = new System.Drawing.Size(50, 13);
            this.lblBillbyBill.TabIndex = 169;
            this.lblBillbyBill.Text = "Bill by Bill";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMobile.Location = new System.Drawing.Point(16, 97);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 167;
            this.lblMobile.Text = "Mobile";
            // 
            // cmbPricingLevel
            // 
            this.cmbPricingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingLevel.FormattingEnabled = true;
            this.cmbPricingLevel.Location = new System.Drawing.Point(125, 118);
            this.cmbPricingLevel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbPricingLevel.Name = "cmbPricingLevel";
            this.cmbPricingLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricingLevel.TabIndex = 14;
            this.cmbPricingLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPricingLevel_KeyDown);
            // 
            // lblPricingLevel
            // 
            this.lblPricingLevel.AutoSize = true;
            this.lblPricingLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricingLevel.Location = new System.Drawing.Point(16, 122);
            this.lblPricingLevel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPricingLevel.Name = "lblPricingLevel";
            this.lblPricingLevel.Size = new System.Drawing.Size(68, 13);
            this.lblPricingLevel.TabIndex = 164;
            this.lblPricingLevel.Text = "Pricing Level";
            // 
            // lblMailingName
            // 
            this.lblMailingName.AutoSize = true;
            this.lblMailingName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMailingName.Location = new System.Drawing.Point(16, 17);
            this.lblMailingName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMailingName.Name = "lblMailingName";
            this.lblMailingName.Size = new System.Drawing.Size(71, 13);
            this.lblMailingName.TabIndex = 163;
            this.lblMailingName.Text = "Mailing Name";
            // 
            // tbMainDetails
            // 
            this.tbMainDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.tbMainDetails.Controls.Add(this.label1);
            this.tbMainDetails.Controls.Add(this.lblSalaryTypeValidator);
            this.tbMainDetails.Controls.Add(this.btnAccountGroupAdd);
            this.tbMainDetails.Controls.Add(this.txtOpeningBalance);
            this.tbMainDetails.Controls.Add(this.txtNarration);
            this.tbMainDetails.Controls.Add(this.txtLedgerName);
            this.tbMainDetails.Controls.Add(this.gbxDetails);
            this.tbMainDetails.Controls.Add(this.lblNarration);
            this.tbMainDetails.Controls.Add(this.cmbOpeningBalanceCrOrDr);
            this.tbMainDetails.Controls.Add(this.lblOpeningBalance);
            this.tbMainDetails.Controls.Add(this.cmbGroup);
            this.tbMainDetails.Controls.Add(this.lblGroup);
            this.tbMainDetails.Controls.Add(this.lblName);
            this.tbMainDetails.Location = new System.Drawing.Point(4, 22);
            this.tbMainDetails.Margin = new System.Windows.Forms.Padding(5);
            this.tbMainDetails.Name = "tbMainDetails";
            this.tbMainDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbMainDetails.Size = new System.Drawing.Size(716, 236);
            this.tbMainDetails.TabIndex = 0;
            this.tbMainDetails.Text = "Main Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(328, 20);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 175;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // btnAccountGroupAdd
            // 
            this.btnAccountGroupAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAccountGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnAccountGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountGroupAdd.Location = new System.Drawing.Point(344, 40);
            this.btnAccountGroupAdd.Name = "btnAccountGroupAdd";
            this.btnAccountGroupAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAccountGroupAdd.TabIndex = 4;
            this.btnAccountGroupAdd.UseVisualStyleBackColor = true;
            this.btnAccountGroupAdd.Click += new System.EventHandler(this.btnAccountGroupAdd_Click);
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(120, 67);
            this.txtOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtOpeningBalance.MaxLength = 13;
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(146, 20);
            this.txtOpeningBalance.TabIndex = 2;
            this.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpeningBalance.Enter += new System.EventHandler(this.txtOpeningBalance_Enter);
            this.txtOpeningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpeningBalance_KeyDown);
            this.txtOpeningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningBalance_KeyPress);
            this.txtOpeningBalance.Leave += new System.EventHandler(this.txtOpeningBalance_Leave);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(120, 92);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 70);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(120, 16);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(200, 20);
            this.txtLedgerName.TabIndex = 0;
            this.txtLedgerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLedgerName_KeyDown);
            this.txtLedgerName.Leave += new System.EventHandler(this.txtLedgerName_Leave);
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.txtBranchCode);
            this.gbxDetails.Controls.Add(this.lblBranchCode);
            this.gbxDetails.Controls.Add(this.txtBranchName);
            this.gbxDetails.Controls.Add(this.lblBranchName);
            this.gbxDetails.Controls.Add(this.txtAcNo);
            this.gbxDetails.Controls.Add(this.lblACNo);
            this.gbxDetails.ForeColor = System.Drawing.Color.White;
            this.gbxDetails.Location = new System.Drawing.Point(374, 16);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(324, 146);
            this.gbxDetails.TabIndex = 6;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(105, 92);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchCode.MaxLength = 18;
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(200, 20);
            this.txtBranchCode.TabIndex = 2;
            this.txtBranchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBranchCode_KeyDown);
            // 
            // lblBranchCode
            // 
            this.lblBranchCode.AutoSize = true;
            this.lblBranchCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBranchCode.Location = new System.Drawing.Point(17, 95);
            this.lblBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchCode.Name = "lblBranchCode";
            this.lblBranchCode.Size = new System.Drawing.Size(69, 13);
            this.lblBranchCode.TabIndex = 149;
            this.lblBranchCode.Text = "Branch Code";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(105, 67);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(200, 20);
            this.txtBranchName.TabIndex = 1;
            this.txtBranchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBranchName_KeyDown);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBranchName.Location = new System.Drawing.Point(17, 71);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(72, 13);
            this.lblBranchName.TabIndex = 147;
            this.lblBranchName.Text = "Branch Name";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(105, 42);
            this.txtAcNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAcNo.MaxLength = 18;
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(200, 20);
            this.txtAcNo.TabIndex = 0;
            this.txtAcNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcNo_KeyDown);
            // 
            // lblACNo
            // 
            this.lblACNo.AutoSize = true;
            this.lblACNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblACNo.Location = new System.Drawing.Point(17, 45);
            this.lblACNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblACNo.Name = "lblACNo";
            this.lblACNo.Size = new System.Drawing.Size(48, 13);
            this.lblACNo.TabIndex = 145;
            this.lblACNo.Text = "Ac / No.";
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(10, 92);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 161;
            this.lblNarration.Text = "Narration";
            // 
            // cmbOpeningBalanceCrOrDr
            // 
            this.cmbOpeningBalanceCrOrDr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpeningBalanceCrOrDr.FormattingEnabled = true;
            this.cmbOpeningBalanceCrOrDr.Items.AddRange(new object[] {
            "Dr",
            "Cr"});
            this.cmbOpeningBalanceCrOrDr.Location = new System.Drawing.Point(270, 67);
            this.cmbOpeningBalanceCrOrDr.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbOpeningBalanceCrOrDr.Name = "cmbOpeningBalanceCrOrDr";
            this.cmbOpeningBalanceCrOrDr.Size = new System.Drawing.Size(51, 21);
            this.cmbOpeningBalanceCrOrDr.TabIndex = 3;
            this.cmbOpeningBalanceCrOrDr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOpeningBalanceCrOrDr_KeyDown);
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOpeningBalance.Location = new System.Drawing.Point(11, 71);
            this.lblOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(89, 13);
            this.lblOpeningBalance.TabIndex = 145;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(120, 41);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.SelectedValueChanged += new System.EventHandler(this.cmbGroup_SelectedValueChanged);
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroup_KeyDown);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGroup.Location = new System.Drawing.Point(11, 45);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 139;
            this.lblGroup.Text = "Group";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(11, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 136;
            this.lblName.Text = "Name";
            // 
            // tbctrlLedger
            // 
            this.tbctrlLedger.Controls.Add(this.tbMainDetails);
            this.tbctrlLedger.Controls.Add(this.tbSecondaryDetails);
            this.tbctrlLedger.Location = new System.Drawing.Point(38, 39);
            this.tbctrlLedger.Name = "tbctrlLedger";
            this.tbctrlLedger.SelectedIndex = 0;
            this.tbctrlLedger.Size = new System.Drawing.Size(724, 262);
            this.tbctrlLedger.TabIndex = 0;
            this.tbctrlLedger.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbctrlLedger_Selecting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Ledger";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLedgerNameSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblLedgerNameSearch);
            this.groupBox2.Controls.Add(this.cmbGroupSearch);
            this.groupBox2.Controls.Add(this.lblGroupSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "LedgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedger
            // 
            this.dgvtxtLedger.DataPropertyName = "ledgerName";
            this.dgvtxtLedger.HeaderText = "Ledger";
            this.dgvtxtLedger.Name = "dgvtxtLedger";
            this.dgvtxtLedger.ReadOnly = true;
            this.dgvtxtLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtGroup
            // 
            this.dgvtxtGroup.DataPropertyName = "accountGroupName";
            this.dgvtxtGroup.HeaderText = "Group";
            this.dgvtxtGroup.Name = "dgvtxtGroup";
            this.dgvtxtGroup.ReadOnly = true;
            this.dgvtxtGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOpeningBalance
            // 
            this.dgvtxtOpeningBalance.DataPropertyName = "openingBalance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtOpeningBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtOpeningBalance.HeaderText = "Opening Balance";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.ReadOnly = true;
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCreditOrDebit
            // 
            this.dgvtxtCreditOrDebit.DataPropertyName = "crOrDr";
            this.dgvtxtCreditOrDebit.HeaderText = "Cr/Dr";
            this.dgvtxtCreditOrDebit.Name = "dgvtxtCreditOrDebit";
            this.dgvtxtCreditOrDebit.ReadOnly = true;
            this.dgvtxtCreditOrDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmAccountLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tbctrlLedger);
            this.Controls.Add(this.dgvAccountLedger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountLedger";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Ledger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountLedger_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountLedger_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
            this.tbSecondaryDetails.ResumeLayout(false);
            this.tbSecondaryDetails.PerformLayout();
            this.tbMainDetails.ResumeLayout(false);
            this.tbMainDetails.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.tbctrlLedger.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAccountLedger;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLedgerNameSearch;
        private System.Windows.Forms.Label lblLedgerNameSearch;
        private System.Windows.Forms.ComboBox cmbGroupSearch;
        private System.Windows.Forms.Label lblGroupSearch;
        private System.Windows.Forms.TabPage tbSecondaryDetails;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtCst;
        private System.Windows.Forms.TextBox txtCreditPeriod;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtMailingName;
        private System.Windows.Forms.Label lblCst;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblTin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbBillByBill;
        private System.Windows.Forms.Label lblBillbyBill;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.ComboBox cmbPricingLevel;
        private System.Windows.Forms.Label lblPricingLevel;
        private System.Windows.Forms.Label lblMailingName;
        private System.Windows.Forms.TabPage tbMainDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Button btnAccountGroupAdd;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Label lblBranchCode;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Label lblACNo;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.ComboBox cmbOpeningBalanceCrOrDr;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tbctrlLedger;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCreditOrDebit;
    }
}