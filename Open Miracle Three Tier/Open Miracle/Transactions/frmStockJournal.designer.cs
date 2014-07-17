namespace Open_Miracle
{
    partial class frmStockJournal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockJournal));
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.dgvConsumption = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtConsumptionSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionStockJournalDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbConsumptionunitId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtConsumptionConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionunitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbConsumptionGodown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbConsumptionRack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbConsumptionBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtConsumptionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtConsumptionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProduction = new System.Windows.Forms.Label();
            this.dgvAdditionalCost = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtAdditionalCostSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAdditionalCostAdditionalCostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbAdditionalCostLedger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtAdditionalCostAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdditionalCostTotal = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAdditionalCost = new System.Windows.Forms.Label();
            this.dgvProduction = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtProductionSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionStockJournalDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbProductionunitId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtProductionunitConversionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbProductionGodown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbProductionRack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbProductionBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtProductionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.gbxManufacturing = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cmbFinishedGoods = new System.Windows.Forms.ComboBox();
            this.lblFinishedGoods = new System.Windows.Forms.Label();
            this.lblAdditionalCostAmount = new System.Windows.Forms.Label();
            this.lblProductionAmount = new System.Windows.Forms.Label();
            this.lblProductionTotal = new System.Windows.Forms.Label();
            this.lblConsumptionAmount = new System.Windows.Forms.Label();
            this.lblConsumptionTotal = new System.Windows.Forms.Label();
            this.rbtnManufacturing = new System.Windows.Forms.RadioButton();
            this.rbtnTransfer = new System.Windows.Forms.RadioButton();
            this.rbtnStockOut = new System.Windows.Forms.RadioButton();
            this.cmbCashOrBank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblConsumptionRemove = new System.Windows.Forms.LinkLabel();
            this.lnklblProductionRemove = new System.Windows.Forms.LinkLabel();
            this.lnklblAdditionalCostRemove = new System.Windows.Forms.LinkLabel();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.gbxTransactionType = new System.Windows.Forms.GroupBox();
            this.cbxPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.gbxManufacturing.SuspendLayout();
            this.gbxTransactionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.Color.White;
            this.lblVoucherNo.Location = new System.Drawing.Point(17, 9);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 503;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(89, 7);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(316, 10);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 504;
            this.lblDate.Text = "Date";
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumption.ForeColor = System.Drawing.Color.Yellow;
            this.lblConsumption.Location = new System.Drawing.Point(14, 116);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(217, 16);
            this.lblConsumption.TabIndex = 502;
            this.lblConsumption.Text = "Raw Materials ( Consumption )";
            // 
            // dgvConsumption
            // 
            this.dgvConsumption.AllowUserToResizeColumns = false;
            this.dgvConsumption.AllowUserToResizeRows = false;
            this.dgvConsumption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumption.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsumption.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumption.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumption.ColumnHeadersHeight = 35;
            this.dgvConsumption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsumption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtConsumptionSlNo,
            this.dgvtxtConsumptionBarcode,
            this.dgvtxtConsumptionStockJournalDetailsId,
            this.dgvtxtConsumptionProductCode,
            this.dgvtxtConsumptionProductId,
            this.dgvtxtConsumptionProductName,
            this.dgvtxtConsumptionQty,
            this.dgvcmbConsumptionunitId,
            this.dgvtxtConsumptionConversionRate,
            this.dgvtxtConsumptionunitConversionId,
            this.dgvcmbConsumptionGodown,
            this.dgvcmbConsumptionRack,
            this.dgvcmbConsumptionBatch,
            this.dgvtxtConsumptionRate,
            this.dgvtxtConsumptionAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumption.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsumption.EnableHeadersVisualStyles = false;
            this.dgvConsumption.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvConsumption.Location = new System.Drawing.Point(15, 135);
            this.dgvConsumption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvConsumption.Name = "dgvConsumption";
            this.dgvConsumption.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumption.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsumption.Size = new System.Drawing.Size(770, 113);
            this.dgvConsumption.TabIndex = 5;
            this.dgvConsumption.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellClick);
            this.dgvConsumption.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellEndEdit);
            this.dgvConsumption.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellEnter);
            this.dgvConsumption.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellValueChanged);
            this.dgvConsumption.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvConsumption_CurrentCellDirtyStateChanged);
            this.dgvConsumption.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvConsumption_DataError);
            this.dgvConsumption.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvConsumption_EditingControlShowing);
            this.dgvConsumption.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvConsumption_RowsAdded);
            this.dgvConsumption.Enter += new System.EventHandler(this.dgvConsumption_Enter);
            this.dgvConsumption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvConsumption_KeyDown);
            // 
            // dgvtxtConsumptionSlNo
            // 
            this.dgvtxtConsumptionSlNo.HeaderText = "Sl No";
            this.dgvtxtConsumptionSlNo.Name = "dgvtxtConsumptionSlNo";
            this.dgvtxtConsumptionSlNo.ReadOnly = true;
            this.dgvtxtConsumptionSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConsumptionBarcode
            // 
            this.dgvtxtConsumptionBarcode.DataPropertyName = "barcode";
            this.dgvtxtConsumptionBarcode.HeaderText = "Barcode";
            this.dgvtxtConsumptionBarcode.Name = "dgvtxtConsumptionBarcode";
            this.dgvtxtConsumptionBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConsumptionStockJournalDetailsId
            // 
            this.dgvtxtConsumptionStockJournalDetailsId.HeaderText = "StockJournalDetailsId";
            this.dgvtxtConsumptionStockJournalDetailsId.Name = "dgvtxtConsumptionStockJournalDetailsId";
            this.dgvtxtConsumptionStockJournalDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtConsumptionStockJournalDetailsId.Visible = false;
            // 
            // dgvtxtConsumptionProductCode
            // 
            this.dgvtxtConsumptionProductCode.DataPropertyName = "productCode";
            this.dgvtxtConsumptionProductCode.HeaderText = "Product Code";
            this.dgvtxtConsumptionProductCode.Name = "dgvtxtConsumptionProductCode";
            this.dgvtxtConsumptionProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConsumptionProductId
            // 
            this.dgvtxtConsumptionProductId.HeaderText = "Product ID";
            this.dgvtxtConsumptionProductId.Name = "dgvtxtConsumptionProductId";
            this.dgvtxtConsumptionProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtConsumptionProductId.Visible = false;
            // 
            // dgvtxtConsumptionProductName
            // 
            this.dgvtxtConsumptionProductName.DataPropertyName = "productName";
            this.dgvtxtConsumptionProductName.HeaderText = "Product Name";
            this.dgvtxtConsumptionProductName.Name = "dgvtxtConsumptionProductName";
            this.dgvtxtConsumptionProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConsumptionQty
            // 
            this.dgvtxtConsumptionQty.DataPropertyName = "Qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtConsumptionQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtConsumptionQty.HeaderText = "Qty";
            this.dgvtxtConsumptionQty.MaxInputLength = 8;
            this.dgvtxtConsumptionQty.Name = "dgvtxtConsumptionQty";
            this.dgvtxtConsumptionQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbConsumptionunitId
            // 
            this.dgvcmbConsumptionunitId.HeaderText = "Unit";
            this.dgvcmbConsumptionunitId.Name = "dgvcmbConsumptionunitId";
            // 
            // dgvtxtConsumptionConversionRate
            // 
            this.dgvtxtConsumptionConversionRate.HeaderText = "ConsumptionConversionRate";
            this.dgvtxtConsumptionConversionRate.Name = "dgvtxtConsumptionConversionRate";
            this.dgvtxtConsumptionConversionRate.Visible = false;
            // 
            // dgvtxtConsumptionunitConversionId
            // 
            this.dgvtxtConsumptionunitConversionId.HeaderText = "unitConversionId";
            this.dgvtxtConsumptionunitConversionId.Name = "dgvtxtConsumptionunitConversionId";
            this.dgvtxtConsumptionunitConversionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtConsumptionunitConversionId.Visible = false;
            // 
            // dgvcmbConsumptionGodown
            // 
            this.dgvcmbConsumptionGodown.DataPropertyName = "godownId";
            this.dgvcmbConsumptionGodown.HeaderText = "Godown";
            this.dgvcmbConsumptionGodown.Name = "dgvcmbConsumptionGodown";
            // 
            // dgvcmbConsumptionRack
            // 
            this.dgvcmbConsumptionRack.DataPropertyName = "rackId";
            this.dgvcmbConsumptionRack.HeaderText = "Rack";
            this.dgvcmbConsumptionRack.Name = "dgvcmbConsumptionRack";
            // 
            // dgvcmbConsumptionBatch
            // 
            this.dgvcmbConsumptionBatch.DataPropertyName = "batchId";
            this.dgvcmbConsumptionBatch.HeaderText = "Batch";
            this.dgvcmbConsumptionBatch.Name = "dgvcmbConsumptionBatch";
            // 
            // dgvtxtConsumptionRate
            // 
            this.dgvtxtConsumptionRate.DataPropertyName = "salesRate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtConsumptionRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtConsumptionRate.HeaderText = "Rate";
            this.dgvtxtConsumptionRate.MaxInputLength = 9;
            this.dgvtxtConsumptionRate.Name = "dgvtxtConsumptionRate";
            this.dgvtxtConsumptionRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtConsumptionAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtConsumptionAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtConsumptionAmount.HeaderText = "Amount";
            this.dgvtxtConsumptionAmount.MaxInputLength = 11;
            this.dgvtxtConsumptionAmount.Name = "dgvtxtConsumptionAmount";
            this.dgvtxtConsumptionAmount.ReadOnly = true;
            this.dgvtxtConsumptionAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduction.ForeColor = System.Drawing.Color.Yellow;
            this.lblProduction.Location = new System.Drawing.Point(18, 252);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(213, 16);
            this.lblProduction.TabIndex = 1146;
            this.lblProduction.Text = "Finished Goods ( Production )";
            // 
            // dgvAdditionalCost
            // 
            this.dgvAdditionalCost.AllowUserToResizeColumns = false;
            this.dgvAdditionalCost.AllowUserToResizeRows = false;
            this.dgvAdditionalCost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdditionalCost.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdditionalCost.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdditionalCost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAdditionalCost.ColumnHeadersHeight = 35;
            this.dgvAdditionalCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdditionalCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtAdditionalCostSlNo,
            this.dgvtxtAdditionalCostAdditionalCostId,
            this.dgvcmbAdditionalCostLedger,
            this.dgvtxtAdditionalCostAmount});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdditionalCost.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAdditionalCost.EnableHeadersVisualStyles = false;
            this.dgvAdditionalCost.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAdditionalCost.Location = new System.Drawing.Point(18, 430);
            this.dgvAdditionalCost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvAdditionalCost.Name = "dgvAdditionalCost";
            this.dgvAdditionalCost.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdditionalCost.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAdditionalCost.Size = new System.Drawing.Size(541, 101);
            this.dgvAdditionalCost.TabIndex = 8;
            this.dgvAdditionalCost.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAdditionalCost_CellBeginEdit);
            this.dgvAdditionalCost.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdditionalCost_CellEnter);
            this.dgvAdditionalCost.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAdditionalCost_CurrentCellDirtyStateChanged);
            this.dgvAdditionalCost.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAdditionalCost_DataError);
            this.dgvAdditionalCost.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvAdditionalCost_EditingControlShowing);
            this.dgvAdditionalCost.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAdditionalCost_RowsAdded);
            this.dgvAdditionalCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAdditionalCost_KeyDown);
            // 
            // dgvtxtAdditionalCostSlNo
            // 
            this.dgvtxtAdditionalCostSlNo.HeaderText = "Sl No";
            this.dgvtxtAdditionalCostSlNo.Name = "dgvtxtAdditionalCostSlNo";
            this.dgvtxtAdditionalCostSlNo.ReadOnly = true;
            this.dgvtxtAdditionalCostSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAdditionalCostAdditionalCostId
            // 
            this.dgvtxtAdditionalCostAdditionalCostId.HeaderText = "AdditionalCostId";
            this.dgvtxtAdditionalCostAdditionalCostId.Name = "dgvtxtAdditionalCostAdditionalCostId";
            this.dgvtxtAdditionalCostAdditionalCostId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAdditionalCostAdditionalCostId.Visible = false;
            // 
            // dgvcmbAdditionalCostLedger
            // 
            this.dgvcmbAdditionalCostLedger.HeaderText = "Account Ledger";
            this.dgvcmbAdditionalCostLedger.Name = "dgvcmbAdditionalCostLedger";
            this.dgvcmbAdditionalCostLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtAdditionalCostAmount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtAdditionalCostAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtxtAdditionalCostAmount.HeaderText = "Amount";
            this.dgvtxtAdditionalCostAmount.MaxInputLength = 9;
            this.dgvtxtAdditionalCostAmount.Name = "dgvtxtAdditionalCostAmount";
            this.dgvtxtAdditionalCostAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblAdditionalCostTotal
            // 
            this.lblAdditionalCostTotal.ForeColor = System.Drawing.Color.White;
            this.lblAdditionalCostTotal.Location = new System.Drawing.Point(288, 535);
            this.lblAdditionalCostTotal.Name = "lblAdditionalCostTotal";
            this.lblAdditionalCostTotal.Size = new System.Drawing.Size(67, 20);
            this.lblAdditionalCostTotal.TabIndex = 1150;
            this.lblAdditionalCostTotal.Text = "Total";
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.Color.White;
            this.lblNarration.Location = new System.Drawing.Point(564, 454);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 1152;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(564, 480);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(218, 50);
            this.txtNarration.TabIndex = 9;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
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
            this.btnClose.TabIndex = 14;
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
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 13;
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
            this.btnSave.Location = new System.Drawing.Point(424, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAdditionalCost
            // 
            this.lblAdditionalCost.AutoSize = true;
            this.lblAdditionalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalCost.ForeColor = System.Drawing.Color.Yellow;
            this.lblAdditionalCost.Location = new System.Drawing.Point(18, 413);
            this.lblAdditionalCost.Name = "lblAdditionalCost";
            this.lblAdditionalCost.Size = new System.Drawing.Size(113, 16);
            this.lblAdditionalCost.TabIndex = 1161;
            this.lblAdditionalCost.Text = "Additional Cost";
            // 
            // dgvProduction
            // 
            this.dgvProduction.AllowUserToResizeColumns = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            this.dgvProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduction.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduction.ColumnHeadersHeight = 35;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtProductionSlNo,
            this.dgvtxtProductionBarcode,
            this.dgvtxtProductionStockJournalDetailsId,
            this.dgvtxtProductionProductCode,
            this.dgvtxtProductionProductId,
            this.dgvtxtProductionProductName,
            this.dgvtxtProductionConversionRate,
            this.dgvtxtProductionQty,
            this.dgvcmbProductionunitId,
            this.dgvtxtProductionunitConversionId,
            this.dgvcmbProductionGodown,
            this.dgvcmbProductionRack,
            this.dgvcmbProductionBatch,
            this.dgvtxtProductionRate,
            this.dgvtxtProductionAmount});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduction.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProduction.EnableHeadersVisualStyles = false;
            this.dgvProduction.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProduction.Location = new System.Drawing.Point(15, 274);
            this.dgvProduction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduction.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProduction.Size = new System.Drawing.Size(770, 113);
            this.dgvProduction.TabIndex = 6;
            this.dgvProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellClick);
            this.dgvProduction.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellEndEdit);
            this.dgvProduction.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellEnter);
           // this.dgvProduction.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellLeave);
            this.dgvProduction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellValueChanged);
            this.dgvProduction.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProduction_CurrentCellDirtyStateChanged);
            this.dgvProduction.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduction_DataError);
            this.dgvProduction.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProduction_EditingControlShowing);
            this.dgvProduction.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProduction_RowsAdded);
            this.dgvProduction.Enter += new System.EventHandler(this.dgvProduction_Enter);
            this.dgvProduction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduction_KeyDown);
            // 
            // dgvtxtProductionSlNo
            // 
            this.dgvtxtProductionSlNo.HeaderText = "Sl No";
            this.dgvtxtProductionSlNo.Name = "dgvtxtProductionSlNo";
            this.dgvtxtProductionSlNo.ReadOnly = true;
            this.dgvtxtProductionSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductionBarcode
            // 
            this.dgvtxtProductionBarcode.HeaderText = "Barcode";
            this.dgvtxtProductionBarcode.Name = "dgvtxtProductionBarcode";
            this.dgvtxtProductionBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductionStockJournalDetailsId
            // 
            this.dgvtxtProductionStockJournalDetailsId.HeaderText = "StockJournalDetailsId";
            this.dgvtxtProductionStockJournalDetailsId.Name = "dgvtxtProductionStockJournalDetailsId";
            this.dgvtxtProductionStockJournalDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductionStockJournalDetailsId.Visible = false;
            // 
            // dgvtxtProductionProductCode
            // 
            this.dgvtxtProductionProductCode.HeaderText = "Product Code";
            this.dgvtxtProductionProductCode.Name = "dgvtxtProductionProductCode";
            this.dgvtxtProductionProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductionProductId
            // 
            this.dgvtxtProductionProductId.HeaderText = "Product ID";
            this.dgvtxtProductionProductId.Name = "dgvtxtProductionProductId";
            this.dgvtxtProductionProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductionProductId.Visible = false;
            // 
            // dgvtxtProductionProductName
            // 
            this.dgvtxtProductionProductName.HeaderText = "Product Name";
            this.dgvtxtProductionProductName.Name = "dgvtxtProductionProductName";
            this.dgvtxtProductionProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductionConversionRate
            // 
            this.dgvtxtProductionConversionRate.HeaderText = "ConversionRate";
            this.dgvtxtProductionConversionRate.Name = "dgvtxtProductionConversionRate";
            this.dgvtxtProductionConversionRate.Visible = false;
            // 
            // dgvtxtProductionQty
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtProductionQty.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtxtProductionQty.HeaderText = "Qty";
            this.dgvtxtProductionQty.MaxInputLength = 8;
            this.dgvtxtProductionQty.Name = "dgvtxtProductionQty";
            this.dgvtxtProductionQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbProductionunitId
            // 
            this.dgvcmbProductionunitId.HeaderText = "Unit";
            this.dgvcmbProductionunitId.Name = "dgvcmbProductionunitId";
            // 
            // dgvtxtProductionunitConversionId
            // 
            this.dgvtxtProductionunitConversionId.HeaderText = "unitConversionId";
            this.dgvtxtProductionunitConversionId.Name = "dgvtxtProductionunitConversionId";
            this.dgvtxtProductionunitConversionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductionunitConversionId.Visible = false;
            // 
            // dgvcmbProductionGodown
            // 
            this.dgvcmbProductionGodown.HeaderText = "Godown";
            this.dgvcmbProductionGodown.Name = "dgvcmbProductionGodown";
            // 
            // dgvcmbProductionRack
            // 
            this.dgvcmbProductionRack.HeaderText = "Rack";
            this.dgvcmbProductionRack.Name = "dgvcmbProductionRack";
            // 
            // dgvcmbProductionBatch
            // 
            this.dgvcmbProductionBatch.HeaderText = "Batch";
            this.dgvcmbProductionBatch.Name = "dgvcmbProductionBatch";
            // 
            // dgvtxtProductionRate
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtProductionRate.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvtxtProductionRate.HeaderText = "Rate";
            this.dgvtxtProductionRate.MaxInputLength = 9;
            this.dgvtxtProductionRate.Name = "dgvtxtProductionRate";
            this.dgvtxtProductionRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProductionAmount
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtProductionAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvtxtProductionAmount.HeaderText = "Amount";
            this.dgvtxtProductionAmount.MaxInputLength = 11;
            this.dgvtxtProductionAmount.Name = "dgvtxtProductionAmount";
            this.dgvtxtProductionAmount.ReadOnly = true;
            this.dgvtxtProductionAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(499, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(21, 20);
            this.dtpDate.TabIndex = 1163;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(352, 6);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(149, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // gbxManufacturing
            // 
            this.gbxManufacturing.Controls.Add(this.btnAdd);
            this.gbxManufacturing.Controls.Add(this.txtQty);
            this.gbxManufacturing.Controls.Add(this.lblQty);
            this.gbxManufacturing.Controls.Add(this.cmbFinishedGoods);
            this.gbxManufacturing.Controls.Add(this.lblFinishedGoods);
            this.gbxManufacturing.ForeColor = System.Drawing.Color.White;
            this.gbxManufacturing.Location = new System.Drawing.Point(21, 64);
            this.gbxManufacturing.Name = "gbxManufacturing";
            this.gbxManufacturing.Size = new System.Drawing.Size(761, 48);
            this.gbxManufacturing.TabIndex = 4;
            this.gbxManufacturing.TabStop = false;
            this.gbxManufacturing.Text = "Manufacturing";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(646, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdd_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(438, 20);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtQty.MaxLength = 5;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 20);
            this.txtQty.TabIndex = 1;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(391, 23);
            this.lblQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 11;
            this.lblQty.Text = "Qty";
            // 
            // cmbFinishedGoods
            // 
            this.cmbFinishedGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishedGoods.Location = new System.Drawing.Point(134, 20);
            this.cmbFinishedGoods.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbFinishedGoods.Name = "cmbFinishedGoods";
            this.cmbFinishedGoods.Size = new System.Drawing.Size(200, 21);
            this.cmbFinishedGoods.TabIndex = 0;
            this.cmbFinishedGoods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFinishedGoods_KeyDown);
            // 
            // lblFinishedGoods
            // 
            this.lblFinishedGoods.AutoSize = true;
            this.lblFinishedGoods.ForeColor = System.Drawing.Color.White;
            this.lblFinishedGoods.Location = new System.Drawing.Point(28, 24);
            this.lblFinishedGoods.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFinishedGoods.Name = "lblFinishedGoods";
            this.lblFinishedGoods.Size = new System.Drawing.Size(75, 13);
            this.lblFinishedGoods.TabIndex = 56858;
            this.lblFinishedGoods.Text = "Finished Good";
            // 
            // lblAdditionalCostAmount
            // 
            this.lblAdditionalCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalCostAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblAdditionalCostAmount.Location = new System.Drawing.Point(360, 536);
            this.lblAdditionalCostAmount.Name = "lblAdditionalCostAmount";
            this.lblAdditionalCostAmount.Size = new System.Drawing.Size(141, 16);
            this.lblAdditionalCostAmount.TabIndex = 1166;
            this.lblAdditionalCostAmount.Text = "0.00";
            this.lblAdditionalCostAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductionAmount
            // 
            this.lblProductionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblProductionAmount.Location = new System.Drawing.Point(588, 395);
            this.lblProductionAmount.Name = "lblProductionAmount";
            this.lblProductionAmount.Size = new System.Drawing.Size(141, 16);
            this.lblProductionAmount.TabIndex = 1168;
            this.lblProductionAmount.Text = "0.00";
            this.lblProductionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductionTotal
            // 
            this.lblProductionTotal.ForeColor = System.Drawing.Color.White;
            this.lblProductionTotal.Location = new System.Drawing.Point(494, 394);
            this.lblProductionTotal.Name = "lblProductionTotal";
            this.lblProductionTotal.Size = new System.Drawing.Size(65, 18);
            this.lblProductionTotal.TabIndex = 1167;
            this.lblProductionTotal.Text = "Total";
            // 
            // lblConsumptionAmount
            // 
            this.lblConsumptionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumptionAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblConsumptionAmount.Location = new System.Drawing.Point(589, 252);
            this.lblConsumptionAmount.Name = "lblConsumptionAmount";
            this.lblConsumptionAmount.Size = new System.Drawing.Size(141, 16);
            this.lblConsumptionAmount.TabIndex = 509;
            this.lblConsumptionAmount.Text = "0.00";
            this.lblConsumptionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConsumptionTotal
            // 
            this.lblConsumptionTotal.ForeColor = System.Drawing.Color.White;
            this.lblConsumptionTotal.Location = new System.Drawing.Point(494, 250);
            this.lblConsumptionTotal.Name = "lblConsumptionTotal";
            this.lblConsumptionTotal.Size = new System.Drawing.Size(78, 21);
            this.lblConsumptionTotal.TabIndex = 506;
            this.lblConsumptionTotal.Text = "Total";
            // 
            // rbtnManufacturing
            // 
            this.rbtnManufacturing.AutoSize = true;
            this.rbtnManufacturing.ForeColor = System.Drawing.Color.White;
            this.rbtnManufacturing.Location = new System.Drawing.Point(18, 15);
            this.rbtnManufacturing.Name = "rbtnManufacturing";
            this.rbtnManufacturing.Size = new System.Drawing.Size(93, 17);
            this.rbtnManufacturing.TabIndex = 0;
            this.rbtnManufacturing.TabStop = true;
            this.rbtnManufacturing.Text = "Manufacturing";
            this.rbtnManufacturing.UseVisualStyleBackColor = true;
            this.rbtnManufacturing.CheckedChanged += new System.EventHandler(this.rbtnManufacturing_CheckedChanged);
            // 
            // rbtnTransfer
            // 
            this.rbtnTransfer.AutoSize = true;
            this.rbtnTransfer.ForeColor = System.Drawing.Color.White;
            this.rbtnTransfer.Location = new System.Drawing.Point(116, 15);
            this.rbtnTransfer.Name = "rbtnTransfer";
            this.rbtnTransfer.Size = new System.Drawing.Size(64, 17);
            this.rbtnTransfer.TabIndex = 1;
            this.rbtnTransfer.TabStop = true;
            this.rbtnTransfer.Text = "Transfer";
            this.rbtnTransfer.UseVisualStyleBackColor = true;
            this.rbtnTransfer.CheckedChanged += new System.EventHandler(this.rbtnTransfer_CheckedChanged);
            // 
            // rbtnStockOut
            // 
            this.rbtnStockOut.AutoSize = true;
            this.rbtnStockOut.ForeColor = System.Drawing.Color.White;
            this.rbtnStockOut.Location = new System.Drawing.Point(189, 15);
            this.rbtnStockOut.Name = "rbtnStockOut";
            this.rbtnStockOut.Size = new System.Drawing.Size(73, 17);
            this.rbtnStockOut.TabIndex = 2;
            this.rbtnStockOut.TabStop = true;
            this.rbtnStockOut.Text = "Stock Out";
            this.rbtnStockOut.UseVisualStyleBackColor = true;
            this.rbtnStockOut.CheckedChanged += new System.EventHandler(this.rbtnStockOut_CheckedChanged);
            // 
            // cmbCashOrBank
            // 
            this.cmbCashOrBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrBank.FormattingEnabled = true;
            this.cmbCashOrBank.Location = new System.Drawing.Point(96, 391);
            this.cmbCashOrBank.Name = "cmbCashOrBank";
            this.cmbCashOrBank.Size = new System.Drawing.Size(181, 21);
            this.cmbCashOrBank.TabIndex = 7;
            this.cmbCashOrBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrBank_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1173;
            this.label1.Text = "Cash/Bank";
            // 
            // lnklblConsumptionRemove
            // 
            this.lnklblConsumptionRemove.AutoSize = true;
            this.lnklblConsumptionRemove.ForeColor = System.Drawing.Color.Yellow;
            this.lnklblConsumptionRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblConsumptionRemove.Location = new System.Drawing.Point(738, 253);
            this.lnklblConsumptionRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblConsumptionRemove.Name = "lnklblConsumptionRemove";
            this.lnklblConsumptionRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblConsumptionRemove.TabIndex = 100;
            this.lnklblConsumptionRemove.TabStop = true;
            this.lnklblConsumptionRemove.Text = "Remove";
            this.lnklblConsumptionRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblConsumptionRemove_LinkClicked);
            // 
            // lnklblProductionRemove
            // 
            this.lnklblProductionRemove.AutoSize = true;
            this.lnklblProductionRemove.ForeColor = System.Drawing.Color.Yellow;
            this.lnklblProductionRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblProductionRemove.Location = new System.Drawing.Point(739, 395);
            this.lnklblProductionRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblProductionRemove.Name = "lnklblProductionRemove";
            this.lnklblProductionRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblProductionRemove.TabIndex = 101;
            this.lnklblProductionRemove.TabStop = true;
            this.lnklblProductionRemove.Text = "Remove";
            this.lnklblProductionRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblProductionRemove_LinkClicked);
            // 
            // lnklblAdditionalCostRemove
            // 
            this.lnklblAdditionalCostRemove.AutoSize = true;
            this.lnklblAdditionalCostRemove.ForeColor = System.Drawing.Color.Yellow;
            this.lnklblAdditionalCostRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblAdditionalCostRemove.Location = new System.Drawing.Point(512, 536);
            this.lnklblAdditionalCostRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblAdditionalCostRemove.Name = "lnklblAdditionalCostRemove";
            this.lnklblAdditionalCostRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblAdditionalCostRemove.TabIndex = 103;
            this.lnklblAdditionalCostRemove.TabStop = true;
            this.lnklblAdditionalCostRemove.Text = "Remove";
            this.lnklblAdditionalCostRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAdditionalCostRemove_LinkClicked);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(616, 7);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(166, 21);
            this.cmbCurrency.TabIndex = 2;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(557, 9);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 505;
            this.lblCurrency.Text = "Currency";
            // 
            // gbxTransactionType
            // 
            this.gbxTransactionType.Controls.Add(this.rbtnManufacturing);
            this.gbxTransactionType.Controls.Add(this.rbtnTransfer);
            this.gbxTransactionType.Controls.Add(this.rbtnStockOut);
            this.gbxTransactionType.ForeColor = System.Drawing.Color.White;
            this.gbxTransactionType.Location = new System.Drawing.Point(263, 30);
            this.gbxTransactionType.Name = "gbxTransactionType";
            this.gbxTransactionType.Size = new System.Drawing.Size(283, 37);
            this.gbxTransactionType.TabIndex = 3;
            this.gbxTransactionType.TabStop = false;
            this.gbxTransactionType.Text = "Transaction";
            // 
            // cbxPrintAfterSave
            // 
            this.cbxPrintAfterSave.AutoSize = true;
            this.cbxPrintAfterSave.ForeColor = System.Drawing.Color.White;
            this.cbxPrintAfterSave.Location = new System.Drawing.Point(20, 535);
            this.cbxPrintAfterSave.Name = "cbxPrintAfterSave";
            this.cbxPrintAfterSave.Size = new System.Drawing.Size(97, 17);
            this.cbxPrintAfterSave.TabIndex = 10;
            this.cbxPrintAfterSave.Text = "Print after save";
            this.cbxPrintAfterSave.UseVisualStyleBackColor = true;
            this.cbxPrintAfterSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPrintAfterSave_KeyDown);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(341, 246);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 27);
            this.btnTransfer.TabIndex = 1174;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            this.btnTransfer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTransfer_KeyDown);
            // 
            // frmStockJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.cbxPrintAfterSave);
            this.Controls.Add(this.gbxTransactionType);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lnklblAdditionalCostRemove);
            this.Controls.Add(this.lnklblProductionRemove);
            this.Controls.Add(this.lnklblConsumptionRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCashOrBank);
            this.Controls.Add(this.lblConsumptionAmount);
            this.Controls.Add(this.lblConsumptionTotal);
            this.Controls.Add(this.lblProductionAmount);
            this.Controls.Add(this.lblProductionTotal);
            this.Controls.Add(this.lblAdditionalCostAmount);
            this.Controls.Add(this.gbxManufacturing);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblAdditionalCost);
            this.Controls.Add(this.dgvProduction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblAdditionalCostTotal);
            this.Controls.Add(this.dgvAdditionalCost);
            this.Controls.Add(this.lblProduction);
            this.Controls.Add(this.dgvConsumption);
            this.Controls.Add(this.lblConsumption);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblVoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStockJournal";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Journal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockJournal_FormClosing);
            this.Load += new System.EventHandler(this.frmStockJournal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockJournal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.gbxManufacturing.ResumeLayout(false);
            this.gbxManufacturing.PerformLayout();
            this.gbxTransactionType.ResumeLayout(false);
            this.gbxTransactionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.Label lblAdditionalCostTotal;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAdditionalCost;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox gbxManufacturing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cmbFinishedGoods;
        private System.Windows.Forms.Label lblFinishedGoods;
        private System.Windows.Forms.Label lblAdditionalCostAmount;
        private System.Windows.Forms.Label lblProductionAmount;
        private System.Windows.Forms.Label lblProductionTotal;
        private System.Windows.Forms.Label lblConsumptionAmount;
        private System.Windows.Forms.Label lblConsumptionTotal;
        private System.Windows.Forms.RadioButton rbtnManufacturing;
        private System.Windows.Forms.RadioButton rbtnTransfer;
        private System.Windows.Forms.RadioButton rbtnStockOut;
        private System.Windows.Forms.ComboBox cmbCashOrBank;
        private System.Windows.Forms.Label label1;
        private dgv.DataGridViewEnter dgvConsumption;
        private dgv.DataGridViewEnter dgvAdditionalCost;
        private dgv.DataGridViewEnter dgvProduction;
        private System.Windows.Forms.LinkLabel lnklblConsumptionRemove;
        private System.Windows.Forms.LinkLabel lnklblProductionRemove;
        private System.Windows.Forms.LinkLabel lnklblAdditionalCostRemove;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.GroupBox gbxTransactionType;
        private System.Windows.Forms.CheckBox cbxPrintAfterSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAdditionalCostSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAdditionalCostAdditionalCostId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbAdditionalCostLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAdditionalCostAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionStockJournalDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbConsumptionunitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionunitConversionId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbConsumptionGodown;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbConsumptionRack;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbConsumptionBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtConsumptionAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionStockJournalDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbProductionunitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionunitConversionId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbProductionGodown;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbProductionRack;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbProductionBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductionAmount;
    }
}