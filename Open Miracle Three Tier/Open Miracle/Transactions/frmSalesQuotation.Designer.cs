namespace Open_Miracle
{
    partial class frmSalesQuotation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesQuotation));
            this.cmbPricinglevel = new System.Windows.Forms.ComboBox();
            this.lblPricingLevel = new System.Windows.Forms.Label();
            this.cbxApproved = new System.Windows.Forms.CheckBox();
            this.btnAddSalesman = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNewledger = new System.Windows.Forms.Button();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.lblSalesMan = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashParty = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuotationNo = new System.Windows.Forms.TextBox();
            this.lblSalesQuotationNo = new System.Windows.Forms.Label();
            this.dgvProduct = new Open_Miracle.dgv.DataGridViewEnter();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.dtpSalesQuotationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.txtSalesQuotationDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQuotationDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPricinglevel
            // 
            this.cmbPricinglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricinglevel.FormattingEnabled = true;
            this.cmbPricinglevel.Location = new System.Drawing.Point(580, 40);
            this.cmbPricinglevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPricinglevel.Name = "cmbPricinglevel";
            this.cmbPricinglevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricinglevel.TabIndex = 4;
            this.cmbPricinglevel.SelectedIndexChanged += new System.EventHandler(this.cmbPricinglevel_SelectedIndexChanged);
            this.cmbPricinglevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPricinglevel_KeyDown);
            // 
            // lblPricingLevel
            // 
            this.lblPricingLevel.AutoSize = true;
            this.lblPricingLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricingLevel.Location = new System.Drawing.Point(488, 44);
            this.lblPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPricingLevel.Name = "lblPricingLevel";
            this.lblPricingLevel.Size = new System.Drawing.Size(68, 13);
            this.lblPricingLevel.TabIndex = 900;
            this.lblPricingLevel.Text = "Pricing Level";
            // 
            // cbxApproved
            // 
            this.cbxApproved.AutoSize = true;
            this.cbxApproved.ForeColor = System.Drawing.Color.Yellow;
            this.cbxApproved.Location = new System.Drawing.Point(18, 544);
            this.cbxApproved.Name = "cbxApproved";
            this.cbxApproved.Size = new System.Drawing.Size(72, 17);
            this.cbxApproved.TabIndex = 899;
            this.cbxApproved.Text = "Approved";
            this.cbxApproved.UseVisualStyleBackColor = true;
            this.cbxApproved.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxApproved_KeyDown);
            // 
            // btnAddSalesman
            // 
            this.btnAddSalesman.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAddSalesman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSalesman.FlatAppearance.BorderSize = 0;
            this.btnAddSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalesman.ForeColor = System.Drawing.Color.White;
            this.btnAddSalesman.Location = new System.Drawing.Point(319, 66);
            this.btnAddSalesman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnAddSalesman.Name = "btnAddSalesman";
            this.btnAddSalesman.Size = new System.Drawing.Size(21, 20);
            this.btnAddSalesman.TabIndex = 898;
            this.btnAddSalesman.UseVisualStyleBackColor = true;
            this.btnAddSalesman.Click += new System.EventHandler(this.btnAddSalesman_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(485, 535);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 897;
            this.label11.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(580, 531);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewledger
            // 
            this.btnNewledger.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnNewledger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewledger.FlatAppearance.BorderSize = 0;
            this.btnNewledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewledger.ForeColor = System.Drawing.Color.White;
            this.btnNewledger.Location = new System.Drawing.Point(319, 40);
            this.btnNewledger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnNewledger.Name = "btnNewledger";
            this.btnNewledger.Size = new System.Drawing.Size(21, 20);
            this.btnNewledger.TabIndex = 893;
            this.btnNewledger.UseVisualStyleBackColor = true;
            this.btnNewledger.Click += new System.EventHandler(this.btnNewledger_Click);
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(115, 66);
            this.cmbSalesman.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesman.TabIndex = 5;
            this.cmbSalesman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesman_KeyDown);
            // 
            // lblSalesMan
            // 
            this.lblSalesMan.AutoSize = true;
            this.lblSalesMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesMan.Location = new System.Drawing.Point(20, 70);
            this.lblSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesMan.Name = "lblSalesMan";
            this.lblSalesMan.Size = new System.Drawing.Size(57, 13);
            this.lblSalesMan.TabIndex = 891;
            this.lblSalesMan.Text = "Sales Man";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(115, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashParty
            // 
            this.lblCashParty.AutoSize = true;
            this.lblCashParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCashParty.Location = new System.Drawing.Point(20, 44);
            this.lblCashParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCashParty.Name = "lblCashParty";
            this.lblCashParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashParty.TabIndex = 885;
            this.lblCashParty.Text = "Cash / Party";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 12;
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
            this.btnDelete.Location = new System.Drawing.Point(606, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 556);
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
            this.btnClear.Location = new System.Drawing.Point(515, 556);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(736, 458);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 16;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(580, 476);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 8;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(487, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 878;
            this.label1.Text = "Narration";
            // 
            // txtQuotationNo
            // 
            this.txtQuotationNo.Location = new System.Drawing.Point(115, 15);
            this.txtQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtQuotationNo.Name = "txtQuotationNo";
            this.txtQuotationNo.Size = new System.Drawing.Size(200, 20);
            this.txtQuotationNo.TabIndex = 1;
            this.txtQuotationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuotationNo_KeyDown);
            // 
            // lblSalesQuotationNo
            // 
            this.lblSalesQuotationNo.AutoSize = true;
            this.lblSalesQuotationNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesQuotationNo.Location = new System.Drawing.Point(20, 19);
            this.lblSalesQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalesQuotationNo.Name = "lblSalesQuotationNo";
            this.lblSalesQuotationNo.Size = new System.Drawing.Size(73, 13);
            this.lblSalesQuotationNo.TabIndex = 876;
            this.lblSalesQuotationNo.Text = "Quotation No.";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
            this.dgvtxtUnitConversionId,
            this.dgvtxtQuotationDetailsId,
            this.dgvtxtExchangeRate,
            this.dgvtxtConversionRate,
            this.ProductId,
            this.dgvtxtBarcode,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtQty,
            this.dgvcmbUnit,
            this.dgvcmbBatch,
            this.dgvtxtRate,
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
            this.dgvProduct.Location = new System.Drawing.Point(18, 93);
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
            this.dgvProduct.Size = new System.Drawing.Size(764, 363);
            this.dgvProduct.TabIndex = 7;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEndEdit);
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            this.dgvProduct.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellLeave);
            this.dgvProduct.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProduct_CurrentCellDirtyStateChanged);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            this.dgvProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProduct_EditingControlShowing);
            this.dgvProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProduct_RowsAdded);
            this.dgvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(488, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 873;
            this.lblDate.Text = "Date";
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(18, 562);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 902;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // dtpSalesQuotationDate
            // 
            this.dtpSalesQuotationDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSalesQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalesQuotationDate.Location = new System.Drawing.Point(761, 15);
            this.dtpSalesQuotationDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpSalesQuotationDate.Name = "dtpSalesQuotationDate";
            this.dtpSalesQuotationDate.Size = new System.Drawing.Size(19, 20);
            this.dtpSalesQuotationDate.TabIndex = 1094;
            this.dtpSalesQuotationDate.ValueChanged += new System.EventHandler(this.dtpSalesQuotationDate_ValueChanged);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(488, 70);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 1147;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(580, 66);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrency.TabIndex = 6;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // txtSalesQuotationDate
            // 
            this.txtSalesQuotationDate.Location = new System.Drawing.Point(580, 15);
            this.txtSalesQuotationDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSalesQuotationDate.Name = "txtSalesQuotationDate";
            this.txtSalesQuotationDate.Size = new System.Drawing.Size(181, 20);
            this.txtSalesQuotationDate.TabIndex = 2;
            this.txtSalesQuotationDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalesQuotationDate_KeyDown);
            this.txtSalesQuotationDate.Leave += new System.EventHandler(this.txtSalesQuotationDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(351, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 1148;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(351, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 1148;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(796, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 1148;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(796, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 1148;
            this.label8.Text = "*";
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 80;
            // 
            // dgvtxtUnitConversionId
            // 
            this.dgvtxtUnitConversionId.HeaderText = "UnitConversionId";
            this.dgvtxtUnitConversionId.Name = "dgvtxtUnitConversionId";
            this.dgvtxtUnitConversionId.Visible = false;
            // 
            // dgvtxtQuotationDetailsId
            // 
            this.dgvtxtQuotationDetailsId.DataPropertyName = "quotationDetailsId";
            this.dgvtxtQuotationDetailsId.HeaderText = "QuotationDetailsId";
            this.dgvtxtQuotationDetailsId.Name = "dgvtxtQuotationDetailsId";
            this.dgvtxtQuotationDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQuotationDetailsId.Visible = false;
            // 
            // dgvtxtExchangeRate
            // 
            this.dgvtxtExchangeRate.HeaderText = "ExchangeRate";
            this.dgvtxtExchangeRate.Name = "dgvtxtExchangeRate";
            this.dgvtxtExchangeRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExchangeRate.Visible = false;
            // 
            // dgvtxtConversionRate
            // 
            this.dgvtxtConversionRate.HeaderText = "ConversionRate";
            this.dgvtxtConversionRate.Name = "dgvtxtConversionRate";
            this.dgvtxtConversionRate.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "productid";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
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
            this.dgvtxtProductName.Width = 180;
            // 
            // dgvtxtQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtQty.HeaderText = "Qty";
            this.dgvtxtQty.MaxInputLength = 8;
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQty.Width = 140;
            // 
            // dgvcmbUnit
            // 
            this.dgvcmbUnit.DataPropertyName = "unitId";
            this.dgvcmbUnit.HeaderText = "Unit";
            this.dgvcmbUnit.Name = "dgvcmbUnit";
            // 
            // dgvcmbBatch
            // 
            this.dgvcmbBatch.DataPropertyName = "batchId";
            this.dgvcmbBatch.HeaderText = "Batch";
            this.dgvcmbBatch.Name = "dgvcmbBatch";
            // 
            // dgvtxtRate
            // 
            this.dgvtxtRate.DataPropertyName = "rate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.MaxInputLength = 7;
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRate.Width = 160;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 15;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 160;
            // 
            // frmSalesQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.dtpSalesQuotationDate);
            this.Controls.Add(this.txtSalesQuotationDate);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.cmbPricinglevel);
            this.Controls.Add(this.lblPricingLevel);
            this.Controls.Add(this.cbxApproved);
            this.Controls.Add(this.btnAddSalesman);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnNewledger);
            this.Controls.Add(this.cmbSalesman);
            this.Controls.Add(this.lblSalesMan);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashParty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuotationNo);
            this.Controls.Add(this.lblSalesQuotationNo);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesQuotation";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Quotation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesQuotation_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesQuotation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesQuotation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPricinglevel;
        private System.Windows.Forms.Label lblPricingLevel;
        private System.Windows.Forms.CheckBox cbxApproved;
        private System.Windows.Forms.Button btnAddSalesman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNewledger;
        private System.Windows.Forms.ComboBox cmbSalesman;
        private System.Windows.Forms.Label lblSalesMan;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashParty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuotationNo;
        private System.Windows.Forms.Label lblSalesQuotationNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.DateTimePicker dtpSalesQuotationDate;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private dgv.DataGridViewEnter dgvProduct;
        private System.Windows.Forms.TextBox txtSalesQuotationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQuotationDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}