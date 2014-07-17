namespace Open_Miracle
{
    partial class frmDeliveryNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryNote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmnt = new System.Windows.Forms.TextBox();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCashOrParty = new System.Windows.Forms.Button();
            this.txtTraspotationCompany = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDeliveryMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPricingLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLRNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkRemove = new System.Windows.Forms.LinkLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryNoteNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProduct = new Open_Miracle.dgv.DataGridViewEnter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalesMan = new System.Windows.Forms.Button();
            this.cbxPrint = new System.Windows.Forms.CheckBox();
            this.btnPricingLevel = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOrderNo = new System.Windows.Forms.ComboBox();
            this.lblOrderOrQuotation = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inRowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOrderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbGodown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbRack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(571, 544);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 833;
            this.label11.Text = "Total Amount";
            // 
            // txtTotalAmnt
            // 
            this.txtTotalAmnt.Location = new System.Drawing.Point(655, 541);
            this.txtTotalAmnt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotalAmnt.Name = "txtTotalAmnt";
            this.txtTotalAmnt.ReadOnly = true;
            this.txtTotalAmnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmnt.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmnt.TabIndex = 1555;
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(116, 118);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 10;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 830;
            this.label6.Text = "Sales Man";
            // 
            // btnCashOrParty
            // 
            this.btnCashOrParty.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnCashOrParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashOrParty.FlatAppearance.BorderSize = 0;
            this.btnCashOrParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOrParty.ForeColor = System.Drawing.Color.White;
            this.btnCashOrParty.Location = new System.Drawing.Point(321, 40);
            this.btnCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnCashOrParty.Name = "btnCashOrParty";
            this.btnCashOrParty.Size = new System.Drawing.Size(21, 20);
            this.btnCashOrParty.TabIndex = 3;
            this.btnCashOrParty.UseVisualStyleBackColor = true;
            this.btnCashOrParty.Click += new System.EventHandler(this.btnCashOrParty_Click);
            // 
            // txtTraspotationCompany
            // 
            this.txtTraspotationCompany.Location = new System.Drawing.Point(142, 472);
            this.txtTraspotationCompany.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTraspotationCompany.Name = "txtTraspotationCompany";
            this.txtTraspotationCompany.Size = new System.Drawing.Size(200, 20);
            this.txtTraspotationCompany.TabIndex = 13;
            this.txtTraspotationCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTraspotationCompany_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(15, 501);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 827;
            this.label12.Text = "LR No.";
            // 
            // cmbDeliveryMode
            // 
            this.cmbDeliveryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMode.FormattingEnabled = true;
            this.cmbDeliveryMode.Items.AddRange(new object[] {
            "NA",
            "Against Order",
            "Against Quotation"});
            this.cmbDeliveryMode.Location = new System.Drawing.Point(653, 41);
            this.cmbDeliveryMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbDeliveryMode.Name = "cmbDeliveryMode";
            this.cmbDeliveryMode.Size = new System.Drawing.Size(202, 21);
            this.cmbDeliveryMode.TabIndex = 4;
            this.cmbDeliveryMode.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryMode_SelectedIndexChanged);
            this.cmbDeliveryMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDeliveryMode_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(542, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 825;
            this.label10.Text = "Delivery Mode";
            // 
            // cmbPricingLevel
            // 
            this.cmbPricingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPricingLevel.FormattingEnabled = true;
            this.cmbPricingLevel.Location = new System.Drawing.Point(116, 92);
            this.cmbPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbPricingLevel.Name = "cmbPricingLevel";
            this.cmbPricingLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbPricingLevel.TabIndex = 7;
            this.cmbPricingLevel.SelectedIndexChanged += new System.EventHandler(this.cmbPricingLevel_SelectedIndexChanged);
            this.cmbPricingLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPricingLevel_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 821;
            this.label8.Text = "Pricing Level";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(116, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 2;
            this.cmbCashOrParty.SelectedIndexChanged += new System.EventHandler(this.cmbCashOrParty_SelectedIndexChanged);
            this.cmbCashOrParty.Enter += new System.EventHandler(this.cmbCashOrParty_Enter);
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 819;
            this.label5.Text = "Cash / Party";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(772, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 20;
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
            this.btnDelete.Location = new System.Drawing.Point(681, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(499, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(590, 568);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // txtLRNo
            // 
            this.txtLRNo.Location = new System.Drawing.Point(142, 497);
            this.txtLRNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtLRNo.Name = "txtLRNo";
            this.txtLRNo.Size = new System.Drawing.Size(200, 20);
            this.txtLRNo.TabIndex = 15;
            this.txtLRNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLRNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 813;
            this.label4.Text = "Transportation Company";
            // 
            // lnkRemove
            // 
            this.lnkRemove.AutoSize = true;
            this.lnkRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnkRemove.Location = new System.Drawing.Point(810, 463);
            this.lnkRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnkRemove.Name = "lnkRemove";
            this.lnkRemove.Size = new System.Drawing.Size(47, 13);
            this.lnkRemove.TabIndex = 6877;
            this.lnkRemove.TabStop = true;
            this.lnkRemove.Text = "Remove";
            this.lnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemove_LinkClicked);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(655, 486);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 14;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(570, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 810;
            this.label1.Text = "Narration";
            // 
            // txtDeliveryNoteNo
            // 
            this.txtDeliveryNoteNo.Location = new System.Drawing.Point(116, 15);
            this.txtDeliveryNoteNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo";
            this.txtDeliveryNoteNo.Size = new System.Drawing.Size(200, 20);
            this.txtDeliveryNoteNo.TabIndex = 0;
            this.txtDeliveryNoteNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliveryNoteNo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 808;
            this.label7.Text = "Delivery Note No.";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Col,
            this.dgvtxtConversionRate,
            this.dgvtxtVoucherNo,
            this.dgvtxtInvoiceNo,
            this.dgvtxtVoucherTypeId,
            this.dgvtxtUnitConversionId,
            this.inRowIndex,
            this.dgvtxtOrderDetailsId,
            this.dgvtxtBarcode,
            this.dgvtxtDetailsId,
            this.dgvtxtProductId,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvtxtQty,
            this.dgvcmbUnit,
            this.dgvcmbGodown,
            this.dgvcmbRack,
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
            this.dgvProduct.Location = new System.Drawing.Point(18, 148);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProduct.Size = new System.Drawing.Size(837, 311);
            this.dgvProduct.TabIndex = 12;
            this.dgvProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEndEdit);
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            this.dgvProduct.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellLeave);
            this.dgvProduct.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProduct_CurrentCellDirtyStateChanged);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            this.dgvProduct.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProduct_DefaultValuesNeeded);
            this.dgvProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProduct_EditingControlShowing);
            this.dgvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(542, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 805;
            this.label3.Text = "Date";
            // 
            // btnSalesMan
            // 
            this.btnSalesMan.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnSalesMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesMan.FlatAppearance.BorderSize = 0;
            this.btnSalesMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesMan.ForeColor = System.Drawing.Color.White;
            this.btnSalesMan.Location = new System.Drawing.Point(321, 118);
            this.btnSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSalesMan.Name = "btnSalesMan";
            this.btnSalesMan.Size = new System.Drawing.Size(21, 20);
            this.btnSalesMan.TabIndex = 11;
            this.btnSalesMan.UseVisualStyleBackColor = true;
            this.btnSalesMan.Click += new System.EventHandler(this.btnSalesMan_Click);
            this.btnSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSalesMan_KeyDown);
            // 
            // cbxPrint
            // 
            this.cbxPrint.AutoSize = true;
            this.cbxPrint.ForeColor = System.Drawing.Color.White;
            this.cbxPrint.Location = new System.Drawing.Point(18, 574);
            this.cbxPrint.Name = "cbxPrint";
            this.cbxPrint.Size = new System.Drawing.Size(97, 17);
            this.cbxPrint.TabIndex = 16;
            this.cbxPrint.Text = "Print after save";
            this.cbxPrint.UseVisualStyleBackColor = true;
            this.cbxPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrint_KeyDown);
            // 
            // btnPricingLevel
            // 
            this.btnPricingLevel.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnPricingLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPricingLevel.FlatAppearance.BorderSize = 0;
            this.btnPricingLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricingLevel.ForeColor = System.Drawing.Color.White;
            this.btnPricingLevel.Location = new System.Drawing.Point(321, 92);
            this.btnPricingLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnPricingLevel.Name = "btnPricingLevel";
            this.btnPricingLevel.Size = new System.Drawing.Size(21, 20);
            this.btnPricingLevel.TabIndex = 8;
            this.btnPricingLevel.UseVisualStyleBackColor = true;
            this.btnPricingLevel.Click += new System.EventHandler(this.btnPricingLevel_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(653, 15);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Location = new System.Drawing.Point(832, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(23, 20);
            this.dtpDate.TabIndex = 789;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cmbOrderNo
            // 
            this.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderNo.FormattingEnabled = true;
            this.cmbOrderNo.Location = new System.Drawing.Point(653, 67);
            this.cmbOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbOrderNo.Name = "cmbOrderNo";
            this.cmbOrderNo.Size = new System.Drawing.Size(202, 21);
            this.cmbOrderNo.TabIndex = 6;
            this.cmbOrderNo.SelectedIndexChanged += new System.EventHandler(this.cmbOrderNo_SelectedIndexChanged);
            this.cmbOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrderNo_KeyDown);
            // 
            // lblOrderOrQuotation
            // 
            this.lblOrderOrQuotation.AutoSize = true;
            this.lblOrderOrQuotation.ForeColor = System.Drawing.Color.White;
            this.lblOrderOrQuotation.Location = new System.Drawing.Point(542, 71);
            this.lblOrderOrQuotation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblOrderOrQuotation.Name = "lblOrderOrQuotation";
            this.lblOrderOrQuotation.Size = new System.Drawing.Size(50, 13);
            this.lblOrderOrQuotation.TabIndex = 840;
            this.lblOrderOrQuotation.Text = "Order No";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(653, 119);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 1147;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(542, 93);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 1148;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(653, 93);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(202, 21);
            this.cmbCurrency.TabIndex = 9;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(15, 70);
            this.lblType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1149;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(116, 66);
            this.cmbType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 21);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbType_KeyDown);
            // 
            // Col
            // 
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConversionRate
            // 
            this.dgvtxtConversionRate.HeaderText = "conversionRate";
            this.dgvtxtConversionRate.Name = "dgvtxtConversionRate";
            this.dgvtxtConversionRate.Visible = false;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Visible = false;
            // 
            // dgvtxtInvoiceNo
            // 
            this.dgvtxtInvoiceNo.HeaderText = "Invoice No";
            this.dgvtxtInvoiceNo.Name = "dgvtxtInvoiceNo";
            this.dgvtxtInvoiceNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInvoiceNo.Visible = false;
            // 
            // dgvtxtVoucherTypeId
            // 
            this.dgvtxtVoucherTypeId.HeaderText = "VoucherType";
            this.dgvtxtVoucherTypeId.Name = "dgvtxtVoucherTypeId";
            this.dgvtxtVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherTypeId.Visible = false;
            // 
            // dgvtxtUnitConversionId
            // 
            this.dgvtxtUnitConversionId.HeaderText = "UnitConversion";
            this.dgvtxtUnitConversionId.Name = "dgvtxtUnitConversionId";
            this.dgvtxtUnitConversionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitConversionId.Visible = false;
            // 
            // inRowIndex
            // 
            this.inRowIndex.HeaderText = "RowIndex";
            this.inRowIndex.Name = "inRowIndex";
            this.inRowIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inRowIndex.Visible = false;
            // 
            // dgvtxtOrderDetailsId
            // 
            this.dgvtxtOrderDetailsId.HeaderText = "OrderDetailsID";
            this.dgvtxtOrderDetailsId.Name = "dgvtxtOrderDetailsId";
            this.dgvtxtOrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOrderDetailsId.Visible = false;
            // 
            // dgvtxtBarcode
            // 
            this.dgvtxtBarcode.HeaderText = "Barcode";
            this.dgvtxtBarcode.Name = "dgvtxtBarcode";
            this.dgvtxtBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDetailsId
            // 
            this.dgvtxtDetailsId.HeaderText = "DetailsID";
            this.dgvtxtDetailsId.Name = "dgvtxtDetailsId";
            this.dgvtxtDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDetailsId.Visible = false;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.HeaderText = "Product ID";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.HeaderText = "Product Name";
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtQty.HeaderText = "Qty";
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
            // dgvcmbGodown
            // 
            this.dgvcmbGodown.HeaderText = "Godown";
            this.dgvcmbGodown.Name = "dgvcmbGodown";
            // 
            // dgvcmbRack
            // 
            this.dgvcmbRack.HeaderText = "Rack";
            this.dgvcmbRack.Name = "dgvcmbRack";
            // 
            // dgvcmbBatch
            // 
            this.dgvcmbBatch.HeaderText = "Batch";
            this.dgvcmbBatch.Name = "dgvcmbBatch";
            // 
            // dgvtxtRate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.MaxInputLength = 9;
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.ReadOnly = true;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(875, 608);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmbOrderNo);
            this.Controls.Add(this.lblOrderOrQuotation);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnPricingLevel);
            this.Controls.Add(this.cbxPrint);
            this.Controls.Add(this.btnSalesMan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalAmnt);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCashOrParty);
            this.Controls.Add(this.txtTraspotationCompany);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbDeliveryMode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPricingLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLRNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkRemove);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeliveryNoteNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDeliveryNote";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeliveryNote_FormClosing);
            this.Load += new System.EventHandler(this.frmDeliveryNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeliveryNote_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmnt;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCashOrParty;
        private System.Windows.Forms.TextBox txtTraspotationCompany;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDeliveryMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPricingLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLRNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkRemove;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryNoteNo;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.DataGridView dgvProduct;
        private dgv.DataGridViewEnter dgvProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalesMan;
        private System.Windows.Forms.CheckBox cbxPrint;
        private System.Windows.Forms.Button btnPricingLevel;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbOrderNo;
        private System.Windows.Forms.Label lblOrderOrQuotation;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitConversionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOrderDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbGodown;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbRack;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
    }
}