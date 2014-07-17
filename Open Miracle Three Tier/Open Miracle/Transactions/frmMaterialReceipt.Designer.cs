namespace Open_Miracle
{
    partial class frmMaterialReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialReceipt));
            this.lblLRLNo = new System.Windows.Forms.Label();
            this.txtLRNo = new System.Windows.Forms.TextBox();
            this.lblTransportationCompany = new System.Windows.Forms.Label();
            this.txtTransportation = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.lblReceiptNo = new System.Windows.Forms.Label();
            this.dgvProduct = new Open_Miracle.dgv.DataGridViewEnter();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNewLedger = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbcurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMaterialReceiptdetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvouchertypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtinvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdCodeToKeep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseOrderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbGodown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvCmbRack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inRowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLRLNo
            // 
            this.lblLRLNo.AutoSize = true;
            this.lblLRLNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLRLNo.Location = new System.Drawing.Point(15, 518);
            this.lblLRLNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblLRLNo.Name = "lblLRLNo";
            this.lblLRLNo.Size = new System.Drawing.Size(41, 13);
            this.lblLRLNo.TabIndex = 1048;
            this.lblLRLNo.Text = "LR No.";
            // 
            // txtLRNo
            // 
            this.txtLRNo.Location = new System.Drawing.Point(142, 515);
            this.txtLRNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtLRNo.Name = "txtLRNo";
            this.txtLRNo.Size = new System.Drawing.Size(200, 20);
            this.txtLRNo.TabIndex = 10;
            this.txtLRNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLRNo_KeyDown);
            // 
            // lblTransportationCompany
            // 
            this.lblTransportationCompany.AutoSize = true;
            this.lblTransportationCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransportationCompany.Location = new System.Drawing.Point(15, 493);
            this.lblTransportationCompany.Margin = new System.Windows.Forms.Padding(5);
            this.lblTransportationCompany.Name = "lblTransportationCompany";
            this.lblTransportationCompany.Size = new System.Drawing.Size(122, 13);
            this.lblTransportationCompany.TabIndex = 1046;
            this.lblTransportationCompany.Text = "Transportation Company";
            // 
            // txtTransportation
            // 
            this.txtTransportation.Location = new System.Drawing.Point(142, 486);
            this.txtTransportation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(200, 20);
            this.txtTransportation.TabIndex = 8;
            this.txtTransportation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransportation_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(480, 558);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 1042;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(580, 548);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(13, 586);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 11;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(584, 64);
            this.cmbOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(196, 21);
            this.cmbOrderNo.TabIndex = 6;
            this.cmbOrderNo.SelectedValueChanged += new System.EventHandler(this.cmbOrderNo_SelectedValueChanged);
            this.cmbOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrderNo_KeyDown);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderNo.Location = new System.Drawing.Point(484, 72);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(53, 13);
            this.lblOrderNo.TabIndex = 1038;
            this.lblOrderNo.Text = "Order No.";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(115, 36);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.SelectedValueChanged += new System.EventHandler(this.cmbCashOrParty_SelectedValueChanged);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            this.cmbCashOrParty.Leave += new System.EventHandler(this.cmbCashOrParty_Leave);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashOrParty.Location = new System.Drawing.Point(15, 40);
            this.lblCashOrParty.Margin = new System.Windows.Forms.Padding(5);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1036;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            this.btnClose.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            this.btnDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            this.btnClear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyUp);
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(735, 470);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 1031;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(580, 493);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 9;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(480, 493);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 1029;
            this.lblNarration.Text = "Narration";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(115, 11);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(200, 20);
            this.txtReceiptNo.TabIndex = 0;
            this.txtReceiptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiptNo_KeyDown);
            // 
            // lblReceiptNo
            // 
            this.lblReceiptNo.AutoSize = true;
            this.lblReceiptNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReceiptNo.Location = new System.Drawing.Point(15, 15);
            this.lblReceiptNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(64, 13);
            this.lblReceiptNo.TabIndex = 1027;
            this.lblReceiptNo.Text = "Receipt No.";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 35;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtConversionRate,
            this.dgvtxtMaterialReceiptdetailsId,
            this.dgvtxtUnitConversionId,
            this.dgvtxtvoucherNo,
            this.dgvtxtvouchertypeId,
            this.dgvtxtinvoiceNo,
            this.dgvtxtExchangeRate,
            this.productId,
            this.prdCodeToKeep,
            this.refer,
            this.dgvtxtBarcode,
            this.dgvtxtProductCode,
            this.dgvtxtPurchaseOrderDetailsId,
            this.dgvtxtProductName,
            this.dgvtxtQty,
            this.dgvcmbUnit,
            this.dgvcmbGodown,
            this.dgvCmbRack,
            this.dgvcmbBatch,
            this.inRowIndex,
            this.dgvtxtRate,
            this.dgvCmbCurrency,
            this.dgvtxtAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProduct.Location = new System.Drawing.Point(13, 94);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.Size = new System.Drawing.Size(769, 368);
            this.dgvProduct.TabIndex = 7;
            this.dgvProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEndEdit);
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            this.dgvProduct.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellLeave);
            this.dgvProduct.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProduct_CurrentCellDirtyStateChanged);
            this.dgvProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProduct_DataBindingComplete);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            this.dgvProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProduct_EditingControlShowing);
            this.dgvProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProduct_RowsAdded);
            this.dgvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(484, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1024;
            this.lblDate.Text = "Date";
            // 
            // btnNewLedger
            // 
            this.btnNewLedger.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnNewLedger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewLedger.FlatAppearance.BorderSize = 0;
            this.btnNewLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLedger.ForeColor = System.Drawing.Color.White;
            this.btnNewLedger.Location = new System.Drawing.Point(319, 36);
            this.btnNewLedger.Name = "btnNewLedger";
            this.btnNewLedger.Size = new System.Drawing.Size(21, 20);
            this.btnNewLedger.TabIndex = 3;
            this.btnNewLedger.UseVisualStyleBackColor = true;
            this.btnNewLedger.Click += new System.EventHandler(this.btnNewLedger_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(761, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(19, 20);
            this.dtpDate.TabIndex = 1092;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(584, 13);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // cmbcurrency
            // 
            this.cmbcurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcurrency.FormattingEnabled = true;
            this.cmbcurrency.Location = new System.Drawing.Point(584, 38);
            this.cmbcurrency.Name = "cmbcurrency";
            this.cmbcurrency.Size = new System.Drawing.Size(196, 21);
            this.cmbcurrency.TabIndex = 4;
            this.cmbcurrency.SelectedValueChanged += new System.EventHandler(this.cmbcurrency_SelectedValueChanged);
            this.cmbcurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcurrency_KeyDown);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(484, 44);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 1149;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(115, 63);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 5;
            this.cmbVoucherType.SelectedValueChanged += new System.EventHandler(this.cmbVoucherType_SelectedValueChanged);
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(18, 67);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 1151;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherNo.Location = new System.Drawing.Point(323, 18);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(11, 13);
            this.lblVoucherNo.TabIndex = 1152;
            this.lblVoucherNo.Text = "*";
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "rackId";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 66;
            // 
            // dgvtxtConversionRate
            // 
            this.dgvtxtConversionRate.HeaderText = "conversionRate";
            this.dgvtxtConversionRate.Name = "dgvtxtConversionRate";
            this.dgvtxtConversionRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtConversionRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtConversionRate.Visible = false;
            // 
            // dgvtxtMaterialReceiptdetailsId
            // 
            this.dgvtxtMaterialReceiptdetailsId.HeaderText = "MaterialReceiptDetailsId";
            this.dgvtxtMaterialReceiptdetailsId.Name = "dgvtxtMaterialReceiptdetailsId";
            this.dgvtxtMaterialReceiptdetailsId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtMaterialReceiptdetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMaterialReceiptdetailsId.Visible = false;
            // 
            // dgvtxtUnitConversionId
            // 
            this.dgvtxtUnitConversionId.HeaderText = "unitConversionId";
            this.dgvtxtUnitConversionId.Name = "dgvtxtUnitConversionId";
            this.dgvtxtUnitConversionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitConversionId.Visible = false;
            // 
            // dgvtxtvoucherNo
            // 
            this.dgvtxtvoucherNo.HeaderText = "voucherNo";
            this.dgvtxtvoucherNo.Name = "dgvtxtvoucherNo";
            this.dgvtxtvoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvoucherNo.Visible = false;
            // 
            // dgvtxtvouchertypeId
            // 
            this.dgvtxtvouchertypeId.HeaderText = "voucherTypeId";
            this.dgvtxtvouchertypeId.Name = "dgvtxtvouchertypeId";
            this.dgvtxtvouchertypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvouchertypeId.Visible = false;
            // 
            // dgvtxtinvoiceNo
            // 
            this.dgvtxtinvoiceNo.HeaderText = "invoiceNo";
            this.dgvtxtinvoiceNo.Name = "dgvtxtinvoiceNo";
            this.dgvtxtinvoiceNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtinvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtinvoiceNo.Visible = false;
            // 
            // dgvtxtExchangeRate
            // 
            this.dgvtxtExchangeRate.HeaderText = "ExchangeRate";
            this.dgvtxtExchangeRate.Name = "dgvtxtExchangeRate";
            this.dgvtxtExchangeRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExchangeRate.Visible = false;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "productId";
            this.productId.Name = "productId";
            this.productId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productId.Visible = false;
            // 
            // prdCodeToKeep
            // 
            this.prdCodeToKeep.HeaderText = "prdCodeToKeep";
            this.prdCodeToKeep.Name = "prdCodeToKeep";
            this.prdCodeToKeep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prdCodeToKeep.Visible = false;
            // 
            // refer
            // 
            this.refer.HeaderText = "refer";
            this.refer.Name = "refer";
            this.refer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.refer.Visible = false;
            // 
            // dgvtxtBarcode
            // 
            this.dgvtxtBarcode.HeaderText = "Barcode";
            this.dgvtxtBarcode.Name = "dgvtxtBarcode";
            this.dgvtxtBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPurchaseOrderDetailsId
            // 
            this.dgvtxtPurchaseOrderDetailsId.HeaderText = "purchaseOrderDetailsId";
            this.dgvtxtPurchaseOrderDetailsId.Name = "dgvtxtPurchaseOrderDetailsId";
            this.dgvtxtPurchaseOrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseOrderDetailsId.Visible = false;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductName.Width = 200;
            // 
            // dgvtxtQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtQty.HeaderText = "Qty";
            this.dgvtxtQty.MaxInputLength = 10;
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQty.Width = 160;
            // 
            // dgvcmbUnit
            // 
            this.dgvcmbUnit.HeaderText = "Unit";
            this.dgvcmbUnit.Name = "dgvcmbUnit";
            // 
            // dgvcmbGodown
            // 
            this.dgvcmbGodown.HeaderText = "Godown";
            this.dgvcmbGodown.Name = "dgvcmbGodown";
            this.dgvcmbGodown.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvCmbRack
            // 
            this.dgvCmbRack.HeaderText = "Rack";
            this.dgvCmbRack.Name = "dgvCmbRack";
            // 
            // dgvcmbBatch
            // 
            this.dgvcmbBatch.HeaderText = "Batch";
            this.dgvcmbBatch.Name = "dgvcmbBatch";
            // 
            // inRowIndex
            // 
            this.inRowIndex.HeaderText = "inRowIndex";
            this.inRowIndex.Name = "inRowIndex";
            this.inRowIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inRowIndex.Visible = false;
            // 
            // dgvtxtRate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.MaxInputLength = 9;
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRate.Width = 160;
            // 
            // dgvCmbCurrency
            // 
            this.dgvCmbCurrency.DataPropertyName = "exchangeRateId";
            this.dgvCmbCurrency.HeaderText = "Currency";
            this.dgvCmbCurrency.Name = "dgvCmbCurrency";
            this.dgvCmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmbCurrency.Visible = false;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 125;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 160;
            // 
            // frmMaterialReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(805, 610);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbcurrency);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnNewLedger);
            this.Controls.Add(this.lblLRLNo);
            this.Controls.Add(this.txtLRNo);
            this.Controls.Add(this.lblTransportationCompany);
            this.Controls.Add(this.txtTransportation);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtReceiptNo);
            this.Controls.Add(this.lblReceiptNo);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMaterialReceipt";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(10, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaterialReceipt_FormClosing);
            this.Load += new System.EventHandler(this.frmMaterialReceipt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMaterialReceipt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLRLNo;
        private System.Windows.Forms.TextBox txtLRNo;
        private System.Windows.Forms.Label lblTransportationCompany;
        private System.Windows.Forms.TextBox txtTransportation;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label lblReceiptNo;
       // private System.Windows.Forms.DataGridView dgvProduct;
        private dgv.DataGridViewEnter dgvProduct;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNewLedger;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbcurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMaterialReceiptdetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvouchertypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtinvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdCodeToKeep;
        private System.Windows.Forms.DataGridViewTextBoxColumn refer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseOrderDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbGodown;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCmbRack;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}