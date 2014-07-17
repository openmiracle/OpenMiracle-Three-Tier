namespace Open_Miracle
{
    partial class frmSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrder));
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.btnSalesMan = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbQuotationNo = new System.Windows.Forms.ComboBox();
            this.lblQuotationNo = new System.Windows.Forms.Label();
            this.btnCashOrParty = new System.Windows.Forms.Button();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPricingLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSalesOrder = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesQuotationDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdCodeToKeep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtUnitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inRowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesOrderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxCancelled = new System.Windows.Forms.CheckBox();
            this.txtDueDays = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(13, 560);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 15;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // btnSalesMan
            // 
            this.btnSalesMan.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnSalesMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesMan.FlatAppearance.BorderSize = 0;
            this.btnSalesMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesMan.ForeColor = System.Drawing.Color.White;
            this.btnSalesMan.Location = new System.Drawing.Point(333, 67);
            this.btnSalesMan.Name = "btnSalesMan";
            this.btnSalesMan.Size = new System.Drawing.Size(21, 20);
            this.btnSalesMan.TabIndex = 866;
            this.btnSalesMan.UseVisualStyleBackColor = true;
            this.btnSalesMan.Click += new System.EventHandler(this.btnSalesMan_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAmount.Location = new System.Drawing.Point(410, 529);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.lblTotalAmount.TabIndex = 865;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(520, 529);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 13;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbQuotationNo
            // 
            this.cmbQuotationNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuotationNo.FormattingEnabled = true;
            this.cmbQuotationNo.Location = new System.Drawing.Point(585, 91);
            this.cmbQuotationNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbQuotationNo.Name = "cmbQuotationNo";
            this.cmbQuotationNo.Size = new System.Drawing.Size(200, 21);
            this.cmbQuotationNo.TabIndex = 8;
            this.cmbQuotationNo.SelectedIndexChanged += new System.EventHandler(this.cmbQuotationNo_SelectedIndexChanged);
            this.cmbQuotationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbQuotationNo_KeyDown);
            // 
            // lblQuotationNo
            // 
            this.lblQuotationNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuotationNo.Location = new System.Drawing.Point(475, 93);
            this.lblQuotationNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblQuotationNo.Name = "lblQuotationNo";
            this.lblQuotationNo.Size = new System.Drawing.Size(75, 20);
            this.lblQuotationNo.TabIndex = 862;
            this.lblQuotationNo.Text = "Quotation No.";
            // 
            // btnCashOrParty
            // 
            this.btnCashOrParty.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnCashOrParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashOrParty.FlatAppearance.BorderSize = 0;
            this.btnCashOrParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOrParty.ForeColor = System.Drawing.Color.White;
            this.btnCashOrParty.Location = new System.Drawing.Point(333, 40);
            this.btnCashOrParty.Name = "btnCashOrParty";
            this.btnCashOrParty.Size = new System.Drawing.Size(21, 20);
            this.btnCashOrParty.TabIndex = 861;
            this.btnCashOrParty.UseVisualStyleBackColor = true;
            this.btnCashOrParty.Click += new System.EventHandler(this.btnCashOrParty_Click);
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(125, 68);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 5;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 857;
            this.label10.Text = "Sales Man";
            // 
            // cmbPricingLevel
            // 
            this.cmbPricingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingLevel.FormattingEnabled = true;
            this.cmbPricingLevel.Location = new System.Drawing.Point(125, 115);
            this.cmbPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPricingLevel.Name = "cmbPricingLevel";
            this.cmbPricingLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricingLevel.TabIndex = 9;
            this.cmbPricingLevel.SelectedIndexChanged += new System.EventHandler(this.cmbPricingLevel_SelectedIndexChanged);
            this.cmbPricingLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPricingLevel_KeyDown);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(15, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 853;
            this.label8.Text = "Pricing Level";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(125, 44);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.SelectedIndexChanged += new System.EventHandler(this.cmbCashOrParty_SelectedIndexChanged);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 851;
            this.label5.Text = "Cash / Party";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(702, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 19;
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
            this.btnDelete.Location = new System.Drawing.Point(611, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 18;
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
            this.btnSave.Location = new System.Drawing.Point(429, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 16;
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
            this.btnClear.Location = new System.Drawing.Point(520, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(738, 458);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 844;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(520, 475);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 12;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(410, 478);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 842;
            this.lblNarration.Text = "Narration";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(125, 19);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(200, 20);
            this.txtOrderNo.TabIndex = 1;
            this.txtOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNo_KeyDown);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 840;
            this.label7.Text = "Order No.";
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToResizeColumns = false;
            this.dgvSalesOrder.AllowUserToResizeRows = false;
            this.dgvSalesOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOrder.ColumnHeadersHeight = 35;
            this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtBarcode,
            this.dgvtxtProductCode,
            this.detailsId,
            this.dgvtxtSalesQuotationDetailsId,
            this.refer,
            this.dgvtxtProductName,
            this.dgvtxtProductId,
            this.dgvtxtQty,
            this.dgvtxtConversionRate,
            this.dgvtxtExchangeRate,
            this.prdCodeToKeep,
            this.dgvcmbUnit,
            this.dgvtxtUnitConversionId,
            this.dgvcmbBatch,
            this.inRowIndex,
            this.dgvtxtRate,
            this.dgvtxtAmount,
            this.dgvtxtSalesOrderDetailsId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesOrder.EnableHeadersVisualStyles = false;
            this.dgvSalesOrder.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesOrder.Location = new System.Drawing.Point(13, 154);
            this.dgvSalesOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesOrder.Size = new System.Drawing.Size(774, 294);
            this.dgvSalesOrder.TabIndex = 11;
            this.dgvSalesOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellEndEdit);
            this.dgvSalesOrder.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellEnter);
            this.dgvSalesOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellValueChanged);
            this.dgvSalesOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSalesOrder_CurrentCellDirtyStateChanged);
            this.dgvSalesOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSalesOrder_DataBindingComplete);
            this.dgvSalesOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSalesOrder_DataError);
            this.dgvSalesOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSalesOrder_EditingControlShowing);
            this.dgvSalesOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSalesOrder_RowsAdded);
            this.dgvSalesOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesOrder_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "slNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBarcode
            // 
            this.dgvtxtBarcode.HeaderText = "Barcode";
            this.dgvtxtBarcode.Name = "dgvtxtBarcode";
            this.dgvtxtBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // detailsId
            // 
            this.detailsId.HeaderText = "DetailsId";
            this.detailsId.Name = "detailsId";
            this.detailsId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.detailsId.Visible = false;
            // 
            // dgvtxtSalesQuotationDetailsId
            // 
            this.dgvtxtSalesQuotationDetailsId.DataPropertyName = "quotationDetailsId";
            this.dgvtxtSalesQuotationDetailsId.HeaderText = "salesQuotationDetailsId";
            this.dgvtxtSalesQuotationDetailsId.Name = "dgvtxtSalesQuotationDetailsId";
            this.dgvtxtSalesQuotationDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesQuotationDetailsId.Visible = false;
            // 
            // refer
            // 
            this.refer.HeaderText = "refer";
            this.refer.Name = "refer";
            this.refer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.refer.Visible = false;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.HeaderText = "Product Id";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtQty
            // 
            this.dgvtxtQty.DataPropertyName = "qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtQty.HeaderText = "Qty";
            this.dgvtxtQty.MaxInputLength = 8;
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConversionRate
            // 
            this.dgvtxtConversionRate.HeaderText = "conversionRate";
            this.dgvtxtConversionRate.Name = "dgvtxtConversionRate";
            this.dgvtxtConversionRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtConversionRate.Visible = false;
            // 
            // dgvtxtExchangeRate
            // 
            this.dgvtxtExchangeRate.HeaderText = "ExchangeRate";
            this.dgvtxtExchangeRate.Name = "dgvtxtExchangeRate";
            this.dgvtxtExchangeRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtExchangeRate.Visible = false;
            // 
            // prdCodeToKeep
            // 
            this.prdCodeToKeep.HeaderText = "prdCodeToKeep";
            this.prdCodeToKeep.Name = "prdCodeToKeep";
            this.prdCodeToKeep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prdCodeToKeep.Visible = false;
            // 
            // dgvcmbUnit
            // 
            this.dgvcmbUnit.HeaderText = "Unit";
            this.dgvcmbUnit.Name = "dgvcmbUnit";
            this.dgvcmbUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvtxtUnitConversionId
            // 
            this.dgvtxtUnitConversionId.HeaderText = "unitConversionId";
            this.dgvtxtUnitConversionId.Name = "dgvtxtUnitConversionId";
            this.dgvtxtUnitConversionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitConversionId.Visible = false;
            // 
            // dgvcmbBatch
            // 
            this.dgvcmbBatch.DataPropertyName = "batchId";
            this.dgvcmbBatch.HeaderText = "Batch";
            this.dgvcmbBatch.Name = "dgvcmbBatch";
            this.dgvcmbBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dgvtxtRate.DataPropertyName = "rate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.MaxInputLength = 9;
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSalesOrderDetailsId
            // 
            this.dgvtxtSalesOrderDetailsId.DataPropertyName = "salesOrderDetailsId";
            this.dgvtxtSalesOrderDetailsId.HeaderText = "SalesOrderDetailsId";
            this.dgvtxtSalesOrderDetailsId.Name = "dgvtxtSalesOrderDetailsId";
            this.dgvtxtSalesOrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesOrderDetailsId.Visible = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(475, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 837;
            this.label3.Text = "Date";
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(475, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 868;
            this.label13.Text = "Due Date";
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(475, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 870;
            this.label14.Text = "Due Days";
            // 
            // cbxCancelled
            // 
            this.cbxCancelled.AutoSize = true;
            this.cbxCancelled.ForeColor = System.Drawing.Color.Yellow;
            this.cbxCancelled.Location = new System.Drawing.Point(13, 537);
            this.cbxCancelled.Name = "cbxCancelled";
            this.cbxCancelled.Size = new System.Drawing.Size(73, 17);
            this.cbxCancelled.TabIndex = 14;
            this.cbxCancelled.Text = "Cancelled";
            this.cbxCancelled.UseVisualStyleBackColor = true;
            this.cbxCancelled.CheckedChanged += new System.EventHandler(this.cbxCancelled_CheckedChanged);
            this.cbxCancelled.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxCancelled_KeyDown);
            // 
            // txtDueDays
            // 
            this.txtDueDays.Enabled = false;
            this.txtDueDays.Location = new System.Drawing.Point(585, 67);
            this.txtDueDays.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDueDays.Name = "txtDueDays";
            this.txtDueDays.Size = new System.Drawing.Size(200, 20);
            this.txtDueDays.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(585, 17);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(183, 20);
            this.txtDate.TabIndex = 2;
          
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Location = new System.Drawing.Point(767, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(20, 20);
            this.dtpDate.TabIndex = 876;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(585, 43);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(183, 20);
            this.txtDueDate.TabIndex = 4;
           
            this.txtDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueDate_KeyDown);
            this.txtDueDate.Leave += new System.EventHandler(this.txtDueDate_Leave);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDueDate.Location = new System.Drawing.Point(767, 43);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(21, 20);
            this.dtpDueDate.TabIndex = 878;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(475, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1147;
            this.label1.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(585, 115);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrency.TabIndex = 10;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(15, 95);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1150;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(125, 92);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 21);
            this.cmbType.TabIndex = 7;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbType_KeyDown);
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(808, 600);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDueDays);
            this.Controls.Add(this.cbxCancelled);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.btnSalesMan);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cmbQuotationNo);
            this.Controls.Add(this.lblQuotationNo);
            this.Controls.Add(this.btnCashOrParty);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPricingLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSalesOrder);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesOrder";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.Activated += new System.EventHandler(this.frmSalesOrder_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.Button btnSalesMan;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cmbQuotationNo;
        private System.Windows.Forms.Label lblQuotationNo;
        private System.Windows.Forms.Button btnCashOrParty;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPricingLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbxCancelled;
        private System.Windows.Forms.TextBox txtDueDays;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private dgv.DataGridViewEnter dgvSalesOrder;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesQuotationDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn refer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdCodeToKeep;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesOrderDetailsId;
    }
}