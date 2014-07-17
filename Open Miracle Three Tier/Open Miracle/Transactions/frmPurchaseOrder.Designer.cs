namespace Open_Miracle
{
    partial class frmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.dgvPurchaseOrder = new Open_Miracle.dgv.DataGridViewEnter();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCashOrPartyAdd = new System.Windows.Forms.Button();
            this.txtDueDays = new System.Windows.Forms.TextBox();
            this.lblDueDays = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPurchaseAccount = new System.Windows.Forms.Label();
            this.lblCurrencysymbol = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCancel = new System.Windows.Forms.CheckBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseOrderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(458, 489);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(89, 20);
            this.lblTotalAmount.TabIndex = 1042;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(553, 487);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 1041;
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(17, 563);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 14;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // lblDueDate
            // 
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDueDate.Location = new System.Drawing.Point(469, 69);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(107, 20);
            this.lblDueDate.TabIndex = 1038;
            this.lblDueDate.Text = "Due Date";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(127, 69);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrParty.Location = new System.Drawing.Point(17, 69);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(100, 20);
            this.lblCashOrParty.TabIndex = 1036;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(694, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(605, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(425, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(516, 555);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.ForeColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(732, 464);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 123;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(127, 474);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 8;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(20, 474);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 1029;
            this.lblNarration.Text = "Narration";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderNo.Location = new System.Drawing.Point(17, 44);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(100, 20);
            this.lblOrderNo.TabIndex = 1027;
            this.lblOrderNo.Text = "Order No.";
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToResizeRows = false;
            this.dgvPurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrder.ColumnHeadersHeight = 35;
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtBarcode,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtQty,
            this.dgvcmbUnit,
            this.dgvtxtRate,
            this.dgvtxtPurchaseOrderDetailsId,
            this.dgvtxtUnitConversionId,
            this.dgvtxtUnitConversionRate,
            this.dgvtxtProductId,
            this.dgvtxtAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseOrder.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrder.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(20, 123);
            this.dgvPurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvPurchaseOrder.MultiSelect = false;
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(759, 336);
            this.dgvPurchaseOrder.TabIndex = 7;
            this.dgvPurchaseOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellEndEdit);
            this.dgvPurchaseOrder.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellEnter);
            this.dgvPurchaseOrder.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellLeave);
            this.dgvPurchaseOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPurchaseOrder_CurrentCellDirtyStateChanged);
            this.dgvPurchaseOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPurchaseOrder_DataError);
            this.dgvPurchaseOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPurchaseOrder_EditingControlShowing);
            this.dgvPurchaseOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPurchaseOrder_RowsAdded);
            this.dgvPurchaseOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseOrder_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(469, 44);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 1024;
            this.lblDate.Text = "Date";
            // 
            // btnCashOrPartyAdd
            // 
            this.btnCashOrPartyAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnCashOrPartyAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashOrPartyAdd.FlatAppearance.BorderSize = 0;
            this.btnCashOrPartyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOrPartyAdd.ForeColor = System.Drawing.Color.White;
            this.btnCashOrPartyAdd.Location = new System.Drawing.Point(339, 69);
            this.btnCashOrPartyAdd.Name = "btnCashOrPartyAdd";
            this.btnCashOrPartyAdd.Size = new System.Drawing.Size(21, 20);
            this.btnCashOrPartyAdd.TabIndex = 3;
            this.btnCashOrPartyAdd.UseVisualStyleBackColor = true;
            this.btnCashOrPartyAdd.Click += new System.EventHandler(this.btnCashOrPartyAdd_Click);
            // 
            // txtDueDays
            // 
            this.txtDueDays.BackColor = System.Drawing.Color.White;
            this.txtDueDays.Location = new System.Drawing.Point(579, 95);
            this.txtDueDays.Margin = new System.Windows.Forms.Padding(5);
            this.txtDueDays.Name = "txtDueDays";
            this.txtDueDays.ReadOnly = true;
            this.txtDueDays.Size = new System.Drawing.Size(200, 20);
            this.txtDueDays.TabIndex = 6;
            this.txtDueDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueDays_KeyDown);
            // 
            // lblDueDays
            // 
            this.lblDueDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDueDays.Location = new System.Drawing.Point(469, 95);
            this.lblDueDays.Margin = new System.Windows.Forms.Padding(5);
            this.lblDueDays.Name = "lblDueDays";
            this.lblDueDays.Size = new System.Drawing.Size(100, 20);
            this.lblDueDays.TabIndex = 1051;
            this.lblDueDays.Text = "Due Days";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(579, 44);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(579, 69);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(178, 20);
            this.txtDueDate.TabIndex = 4;
            this.txtDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueDate_KeyDown);
            this.txtDueDate.Leave += new System.EventHandler(this.txtDueDate_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(758, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(19, 20);
            this.dtpDate.TabIndex = 1055;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(758, 69);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(19, 20);
            this.dtpDueDate.TabIndex = 1056;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            this.dtpDueDate.Leave += new System.EventHandler(this.dtpDueDate_Leave);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(777, 48);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 1057;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(777, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1058;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 1059;
            this.label3.Text = "*";
            // 
            // lblPurchaseAccount
            // 
            this.lblPurchaseAccount.AutoSize = true;
            this.lblPurchaseAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchaseAccount.Location = new System.Drawing.Point(592, 517);
            this.lblPurchaseAccount.Margin = new System.Windows.Forms.Padding(5);
            this.lblPurchaseAccount.Name = "lblPurchaseAccount";
            this.lblPurchaseAccount.Size = new System.Drawing.Size(0, 13);
            this.lblPurchaseAccount.TabIndex = 1147;
            // 
            // lblCurrencysymbol
            // 
            this.lblCurrencysymbol.AutoSize = true;
            this.lblCurrencysymbol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrencysymbol.Location = new System.Drawing.Point(755, 491);
            this.lblCurrencysymbol.Margin = new System.Windows.Forms.Padding(5);
            this.lblCurrencysymbol.Name = "lblCurrencysymbol";
            this.lblCurrencysymbol.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencysymbol.TabIndex = 1148;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(127, 96);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrency.TabIndex = 5;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1150;
            this.label2.Text = "Currency";
            // 
            // cbxCancel
            // 
            this.cbxCancel.AutoSize = true;
            this.cbxCancel.ForeColor = System.Drawing.Color.White;
            this.cbxCancel.Location = new System.Drawing.Point(18, 538);
            this.cbxCancel.Name = "cbxCancel";
            this.cbxCancel.Size = new System.Drawing.Size(59, 17);
            this.cbxCancel.TabIndex = 13;
            this.cbxCancel.Text = "Cancel";
            this.cbxCancel.UseVisualStyleBackColor = true;
            this.cbxCancel.CheckedChanged += new System.EventHandler(this.cbxCancel_CheckedChanged);
            this.cbxCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxCancel_KeyDown);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(127, 41);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(200, 20);
            this.txtOrderNo.TabIndex = 0;
            this.txtOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNo_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "slNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBarcode
            // 
            this.dgvtxtBarcode.DataPropertyName = "productCode";
            this.dgvtxtBarcode.HeaderText = "Barcode";
            this.dgvtxtBarcode.Name = "dgvtxtBarcode";
            this.dgvtxtBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtQty.HeaderText = "Quantity";
            this.dgvtxtQty.MaxInputLength = 8;
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbUnit
            // 
            this.dgvcmbUnit.HeaderText = "Unit";
            this.dgvcmbUnit.Name = "dgvcmbUnit";
            this.dgvcmbUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtRate
            // 
            this.dgvtxtRate.DataPropertyName = "rate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.MaxInputLength = 9;
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPurchaseOrderDetailsId
            // 
            this.dgvtxtPurchaseOrderDetailsId.DataPropertyName = "purchaseOrderDetailsId";
            this.dgvtxtPurchaseOrderDetailsId.HeaderText = "PurchaseOrderDetailsId";
            this.dgvtxtPurchaseOrderDetailsId.Name = "dgvtxtPurchaseOrderDetailsId";
            this.dgvtxtPurchaseOrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseOrderDetailsId.Visible = false;
            // 
            // dgvtxtUnitConversionId
            // 
            this.dgvtxtUnitConversionId.HeaderText = "unitConversionId";
            this.dgvtxtUnitConversionId.Name = "dgvtxtUnitConversionId";
            this.dgvtxtUnitConversionId.Visible = false;
            // 
            // dgvtxtUnitConversionRate
            // 
            this.dgvtxtUnitConversionRate.HeaderText = "unitconversionRate";
            this.dgvtxtUnitConversionRate.Name = "dgvtxtUnitConversionRate";
            this.dgvtxtUnitConversionRate.Visible = false;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.HeaderText = "productId";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.cbxCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrencysymbol);
            this.Controls.Add(this.lblPurchaseAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDueDays);
            this.Controls.Add(this.lblDueDays);
            this.Controls.Add(this.btnCashOrPartyAdd);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.dgvPurchaseOrder);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseOrder";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPurchaseOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCashOrPartyAdd;
        private System.Windows.Forms.TextBox txtDueDays;
        private System.Windows.Forms.Label lblDueDays;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private dgv.DataGridViewEnter dgvPurchaseOrder;
        private System.Windows.Forms.Label lblPurchaseAccount;
        private System.Windows.Forms.Label lblCurrencysymbol;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxCancel;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseOrderDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}