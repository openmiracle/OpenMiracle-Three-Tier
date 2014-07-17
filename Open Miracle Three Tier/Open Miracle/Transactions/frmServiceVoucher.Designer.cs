namespace Open_Miracle
{
    partial class frmServiceVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceVoucher));
            this.lklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvServiceVoucher = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbParticulars = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServiceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCashParty = new System.Windows.Forms.ComboBox();
            this.lblCashParty = new System.Windows.Forms.Label();
            this.cmbServiceAC = new System.Windows.Forms.ComboBox();
            this.lblServiceAC = new System.Windows.Forms.Label();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.lblSalesman = new System.Windows.Forms.Label();
            this.lblVoucherDate = new System.Windows.Forms.Label();
            this.lblCreditPeriod = new System.Windows.Forms.Label();
            this.txtCreditPeriod = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtVoucherDate = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSalesman = new System.Windows.Forms.Button();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // lklblRemove
            // 
            this.lklblRemove.AutoSize = true;
            this.lklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lklblRemove.Location = new System.Drawing.Point(735, 423);
            this.lklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lklblRemove.Name = "lklblRemove";
            this.lklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lklblRemove.TabIndex = 68678;
            this.lklblRemove.TabStop = true;
            this.lklblRemove.Text = "Remove";
            this.lklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRemove_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(694, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(603, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(512, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(421, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 418;
            this.label7.Text = "Invoice No.";
            // 
            // dgvServiceVoucher
            // 
            this.dgvServiceVoucher.AllowUserToResizeRows = false;
            this.dgvServiceVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceVoucher.ColumnHeadersHeight = 25;
            this.dgvServiceVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvcmbParticulars,
            this.dgvtxtMeasure,
            this.dgvtxtLedgerPostingId,
            this.dgvtxtCheck,
            this.dgvtxtDetailsId,
            this.dgvtxtServiceMasterId,
            this.dgvtxtAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceVoucher.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServiceVoucher.EnableHeadersVisualStyles = false;
            this.dgvServiceVoucher.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServiceVoucher.Location = new System.Drawing.Point(18, 119);
            this.dgvServiceVoucher.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvServiceVoucher.Name = "dgvServiceVoucher";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServiceVoucher.Size = new System.Drawing.Size(764, 298);
            this.dgvServiceVoucher.TabIndex = 10;
            this.dgvServiceVoucher.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceVoucher_CellEnter);
            this.dgvServiceVoucher.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceVoucher_CellValueChanged);
            this.dgvServiceVoucher.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvServiceVoucher_DataError);
            this.dgvServiceVoucher.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvServiceVoucher_EditingControlShowing);
            this.dgvServiceVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvServiceVoucher_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Slno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtSlNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 180;
            // 
            // dgvcmbParticulars
            // 
            this.dgvcmbParticulars.HeaderText = "Particulars";
            this.dgvcmbParticulars.Name = "dgvcmbParticulars";
            this.dgvcmbParticulars.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbParticulars.Width = 181;
            // 
            // dgvtxtMeasure
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtMeasure.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtMeasure.HeaderText = "Measure";
            this.dgvtxtMeasure.MaxInputLength = 10;
            this.dgvtxtMeasure.Name = "dgvtxtMeasure";
            this.dgvtxtMeasure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMeasure.Width = 180;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.HeaderText = "Ledger Posting ID";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerPostingId.Visible = false;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.HeaderText = "Check";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // dgvtxtDetailsId
            // 
            this.dgvtxtDetailsId.DataPropertyName = "serviceDetailsId";
            this.dgvtxtDetailsId.HeaderText = "Service Details ID";
            this.dgvtxtDetailsId.Name = "dgvtxtDetailsId";
            this.dgvtxtDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDetailsId.Visible = false;
            // 
            // dgvtxtServiceMasterId
            // 
            this.dgvtxtServiceMasterId.DataPropertyName = "serviceMasterId";
            this.dgvtxtServiceMasterId.HeaderText = "Service Master ID";
            this.dgvtxtServiceMasterId.Name = "dgvtxtServiceMasterId";
            this.dgvtxtServiceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtServiceMasterId.Visible = false;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 13;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 180;
            // 
            // cmbCashParty
            // 
            this.cmbCashParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCashParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashParty.FormattingEnabled = true;
            this.cmbCashParty.Location = new System.Drawing.Point(130, 37);
            this.cmbCashParty.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCashParty.Name = "cmbCashParty";
            this.cmbCashParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashParty.TabIndex = 2;
            this.cmbCashParty.SelectedIndexChanged += new System.EventHandler(this.cmbCashParty_SelectedIndexChanged);
            this.cmbCashParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashParty_KeyDown);
            // 
            // lblCashParty
            // 
            this.lblCashParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashParty.Location = new System.Drawing.Point(20, 37);
            this.lblCashParty.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashParty.Name = "lblCashParty";
            this.lblCashParty.Size = new System.Drawing.Size(100, 20);
            this.lblCashParty.TabIndex = 424;
            this.lblCashParty.Text = "Cash/party";
            // 
            // cmbServiceAC
            // 
            this.cmbServiceAC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServiceAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceAC.FormattingEnabled = true;
            this.cmbServiceAC.Location = new System.Drawing.Point(130, 64);
            this.cmbServiceAC.Margin = new System.Windows.Forms.Padding(5);
            this.cmbServiceAC.Name = "cmbServiceAC";
            this.cmbServiceAC.Size = new System.Drawing.Size(200, 21);
            this.cmbServiceAC.TabIndex = 5;
            this.cmbServiceAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbServiceAC_KeyDown);
            // 
            // lblServiceAC
            // 
            this.lblServiceAC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceAC.Location = new System.Drawing.Point(20, 64);
            this.lblServiceAC.Margin = new System.Windows.Forms.Padding(5);
            this.lblServiceAC.Name = "lblServiceAC";
            this.lblServiceAC.Size = new System.Drawing.Size(100, 20);
            this.lblServiceAC.TabIndex = 426;
            this.lblServiceAC.Text = "Service a/c";
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(130, 91);
            this.cmbSalesman.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesman.TabIndex = 7;
            this.cmbSalesman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesman_KeyDown);
            // 
            // lblSalesman
            // 
            this.lblSalesman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesman.Location = new System.Drawing.Point(20, 91);
            this.lblSalesman.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalesman.Name = "lblSalesman";
            this.lblSalesman.Size = new System.Drawing.Size(100, 20);
            this.lblSalesman.TabIndex = 428;
            this.lblSalesman.Text = "Salesman";
            // 
            // lblVoucherDate
            // 
            this.lblVoucherDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherDate.Location = new System.Drawing.Point(467, 13);
            this.lblVoucherDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblVoucherDate.Name = "lblVoucherDate";
            this.lblVoucherDate.Size = new System.Drawing.Size(100, 20);
            this.lblVoucherDate.TabIndex = 430;
            this.lblVoucherDate.Text = "Voucher Date";
            // 
            // lblCreditPeriod
            // 
            this.lblCreditPeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreditPeriod.Location = new System.Drawing.Point(467, 39);
            this.lblCreditPeriod.Margin = new System.Windows.Forms.Padding(5);
            this.lblCreditPeriod.Name = "lblCreditPeriod";
            this.lblCreditPeriod.Size = new System.Drawing.Size(100, 20);
            this.lblCreditPeriod.TabIndex = 433;
            this.lblCreditPeriod.Text = "Credit Period";
            // 
            // txtCreditPeriod
            // 
            this.txtCreditPeriod.Location = new System.Drawing.Point(577, 39);
            this.txtCreditPeriod.Margin = new System.Windows.Forms.Padding(5);
            this.txtCreditPeriod.MaxLength = 3;
            this.txtCreditPeriod.Name = "txtCreditPeriod";
            this.txtCreditPeriod.Size = new System.Drawing.Size(159, 20);
            this.txtCreditPeriod.TabIndex = 4;
            this.txtCreditPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditPeriod.Enter += new System.EventHandler(this.txtCreditPeriod_Enter);
            this.txtCreditPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditPeriod_KeyDown);
            this.txtCreditPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditPeriod_KeyPress);
            this.txtCreditPeriod.Leave += new System.EventHandler(this.txtCreditPeriod_Leave);
            // 
            // lblCustomer
            // 
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomer.Location = new System.Drawing.Point(467, 90);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(100, 20);
            this.lblCustomer.TabIndex = 437;
            this.lblCustomer.Text = "Customer Name";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(577, 90);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtCustomer.TabIndex = 9;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(354, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(20, 441);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 440;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(130, 441);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 11;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(130, 494);
            this.cbxPrintAfterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 13;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(467, 441);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.lblTotalAmount.TabIndex = 443;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscount.Location = new System.Drawing.Point(467, 466);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 20);
            this.lblDiscount.TabIndex = 445;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.Location = new System.Drawing.Point(577, 466);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiscount.MaxLength = 13;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGrandTotal.Location = new System.Drawing.Point(467, 491);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(100, 20);
            this.lblGrandTotal.TabIndex = 447;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.Location = new System.Drawing.Point(577, 13);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherDate.TabIndex = 1;
            this.txtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherDate_KeyDown);
            this.txtVoucherDate.Leave += new System.EventHandler(this.txtVoucherDate_Leave);
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(757, 13);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(20, 20);
            this.dtpVoucherDate.TabIndex = 449;
            this.dtpVoucherDate.ValueChanged += new System.EventHandler(this.dtpVoucherDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(745, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 450;
            this.label1.Text = "Days";
            // 
            // btnAddSalesman
            // 
            this.btnAddSalesman.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAddSalesman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSalesman.FlatAppearance.BorderSize = 0;
            this.btnAddSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalesman.ForeColor = System.Drawing.Color.White;
            this.btnAddSalesman.Location = new System.Drawing.Point(354, 90);
            this.btnAddSalesman.Name = "btnAddSalesman";
            this.btnAddSalesman.Size = new System.Drawing.Size(21, 20);
            this.btnAddSalesman.TabIndex = 8;
            this.btnAddSalesman.UseVisualStyleBackColor = true;
            this.btnAddSalesman.Click += new System.EventHandler(this.btnAddSalesman_Click);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(335, 22);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 1147;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(335, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 1148;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(335, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 1149;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(782, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 1150;
            this.label4.Text = "*";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(130, 12);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceNumber.TabIndex = 0;
            this.txtInvoiceNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceNumber_KeyDown);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(577, 441);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 436567;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtTotalAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyDown);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(577, 491);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(200, 20);
            this.txtGrandTotal.TabIndex = 574574;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrandTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrandTotal_KeyDown);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(577, 64);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrency.TabIndex = 6;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // lblCurrency
            // 
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(467, 65);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(100, 20);
            this.lblCurrency.TabIndex = 1154;
            this.lblCurrency.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(335, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 325325;
            this.label5.Text = "*";
            // 
            // frmServiceVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.btnAddSalesman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpVoucherDate);
            this.Controls.Add(this.txtVoucherDate);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCreditPeriod);
            this.Controls.Add(this.txtCreditPeriod);
            this.Controls.Add(this.lblVoucherDate);
            this.Controls.Add(this.cmbSalesman);
            this.Controls.Add(this.lblSalesman);
            this.Controls.Add(this.cmbServiceAC);
            this.Controls.Add(this.lblServiceAC);
            this.Controls.Add(this.cmbCashParty);
            this.Controls.Add(this.lblCashParty);
            this.Controls.Add(this.lklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvServiceVoucher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmServiceVoucher";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServiceVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmServiceVoucher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCashParty;
        private System.Windows.Forms.Label lblCashParty;
        private System.Windows.Forms.ComboBox cmbServiceAC;
        private System.Windows.Forms.Label lblServiceAC;
        private System.Windows.Forms.ComboBox cmbSalesman;
        private System.Windows.Forms.Label lblSalesman;
        private System.Windows.Forms.Label lblVoucherDate;
        private System.Windows.Forms.Label lblCreditPeriod;
        private System.Windows.Forms.TextBox txtCreditPeriod;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblGrandTotal;
        private dgv.DataGridViewEnter dgvServiceVoucher;
        private System.Windows.Forms.TextBox txtVoucherDate;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSalesman;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}