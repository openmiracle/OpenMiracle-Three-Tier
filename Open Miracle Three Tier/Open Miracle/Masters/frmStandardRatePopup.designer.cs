namespace Open_Miracle
{
    partial class frmStandardRatePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardRatePopup));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblRateValidator = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvStandardRate = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStandardRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.gbxDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardRate)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(-51, 247);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 345;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Select All";
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.lblUnitName);
            this.gbxDetails.Controls.Add(this.txtUnitName);
            this.gbxDetails.Controls.Add(this.lblProductName);
            this.gbxDetails.Controls.Add(this.txtProductName);
            this.gbxDetails.Controls.Add(this.lblProductCode);
            this.gbxDetails.Controls.Add(this.txtProductCode);
            this.gbxDetails.ForeColor = System.Drawing.Color.White;
            this.gbxDetails.Location = new System.Drawing.Point(18, 13);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(767, 80);
            this.gbxDetails.TabIndex = 350;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Standard Rate";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitName.Location = new System.Drawing.Point(19, 50);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(5);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(57, 13);
            this.lblUnitName.TabIndex = 344;
            this.lblUnitName.Text = "Unit Name";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(120, 46);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(200, 20);
            this.txtUnitName.TabIndex = 2;
            this.txtUnitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitName_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(435, 25);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 342;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(545, 21);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(19, 25);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 340;
            this.lblProductCode.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(120, 21);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBatch);
            this.groupBox1.Controls.Add(this.lblBatch);
            this.groupBox1.Controls.Add(this.lblRateValidator);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.dgvStandardRate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 498);
            this.groupBox1.TabIndex = 351;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 509;
            this.label1.Text = "*";
            // 
            // cmbBatch
            // 
            this.cmbBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(120, 71);
            this.cmbBatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(200, 21);
            this.cmbBatch.TabIndex = 2;
            this.cmbBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatch_KeyDown);
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatch.Location = new System.Drawing.Point(19, 74);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(5);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(35, 13);
            this.lblBatch.TabIndex = 507;
            this.lblBatch.Text = "Batch";
            // 
            // lblRateValidator
            // 
            this.lblRateValidator.AutoSize = true;
            this.lblRateValidator.ForeColor = System.Drawing.Color.Red;
            this.lblRateValidator.Location = new System.Drawing.Point(330, 104);
            this.lblRateValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblRateValidator.Name = "lblRateValidator";
            this.lblRateValidator.Size = new System.Drawing.Size(11, 13);
            this.lblRateValidator.TabIndex = 506;
            this.lblRateValidator.Text = "*";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(120, 46);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(179, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(297, 46);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(23, 20);
            this.dtpToDate.TabIndex = 505;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 21);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(179, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(297, 21);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(23, 20);
            this.dtpFromDate.TabIndex = 504;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dgvStandardRate
            // 
            this.dgvStandardRate.AllowUserToAddRows = false;
            this.dgvStandardRate.AllowUserToDeleteRows = false;
            this.dgvStandardRate.AllowUserToResizeColumns = false;
            this.dgvStandardRate.AllowUserToResizeRows = false;
            this.dgvStandardRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStandardRate.BackgroundColor = System.Drawing.Color.White;
            this.dgvStandardRate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStandardRate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStandardRate.ColumnHeadersHeight = 25;
            this.dgvStandardRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStandardRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtStandardRateId,
            this.dgvtxtProductId,
            this.dgvtxtUnitId,
            this.dgvtxtFromDate,
            this.dgvtxtToDate,
            this.dgvtxtRate,
            this.dgvtxtBatchId,
            this.dgvtxtBatchNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStandardRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStandardRate.EnableHeadersVisualStyles = false;
            this.dgvStandardRate.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStandardRate.Location = new System.Drawing.Point(18, 155);
            this.dgvStandardRate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvStandardRate.MultiSelect = false;
            this.dgvStandardRate.Name = "dgvStandardRate";
            this.dgvStandardRate.ReadOnly = true;
            this.dgvStandardRate.RowHeadersVisible = false;
            this.dgvStandardRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandardRate.Size = new System.Drawing.Size(730, 326);
            this.dgvStandardRate.TabIndex = 500;
            this.dgvStandardRate.TabStop = false;
            this.dgvStandardRate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStandardRate_CellDoubleClick);
            this.dgvStandardRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvStandardRate_KeyUp);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStandardRateId
            // 
            this.dgvtxtStandardRateId.DataPropertyName = "standardRateId";
            this.dgvtxtStandardRateId.HeaderText = "StandardRateId";
            this.dgvtxtStandardRateId.Name = "dgvtxtStandardRateId";
            this.dgvtxtStandardRateId.ReadOnly = true;
            this.dgvtxtStandardRateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtStandardRateId.Visible = false;
            // 
            // dgvtxtProductId
            // 
            this.dgvtxtProductId.DataPropertyName = "productId";
            this.dgvtxtProductId.HeaderText = "ProductId";
            this.dgvtxtProductId.Name = "dgvtxtProductId";
            this.dgvtxtProductId.ReadOnly = true;
            this.dgvtxtProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductId.Visible = false;
            // 
            // dgvtxtUnitId
            // 
            this.dgvtxtUnitId.DataPropertyName = "unitId";
            this.dgvtxtUnitId.HeaderText = "UnitId";
            this.dgvtxtUnitId.Name = "dgvtxtUnitId";
            this.dgvtxtUnitId.ReadOnly = true;
            this.dgvtxtUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitId.Visible = false;
            // 
            // dgvtxtFromDate
            // 
            this.dgvtxtFromDate.DataPropertyName = "applicableFrom";
            this.dgvtxtFromDate.HeaderText = "From Date";
            this.dgvtxtFromDate.Name = "dgvtxtFromDate";
            this.dgvtxtFromDate.ReadOnly = true;
            this.dgvtxtFromDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtToDate
            // 
            this.dgvtxtToDate.DataPropertyName = "applicableTo";
            this.dgvtxtToDate.HeaderText = "To Date";
            this.dgvtxtToDate.Name = "dgvtxtToDate";
            this.dgvtxtToDate.ReadOnly = true;
            this.dgvtxtToDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRate
            // 
            this.dgvtxtRate.DataPropertyName = "rate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtRate.HeaderText = "Rate";
            this.dgvtxtRate.Name = "dgvtxtRate";
            this.dgvtxtRate.ReadOnly = true;
            this.dgvtxtRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBatchId
            // 
            this.dgvtxtBatchId.DataPropertyName = "batchId";
            this.dgvtxtBatchId.HeaderText = "BatchId";
            this.dgvtxtBatchId.Name = "dgvtxtBatchId";
            this.dgvtxtBatchId.ReadOnly = true;
            this.dgvtxtBatchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBatchId.Visible = false;
            // 
            // dgvtxtBatchNo
            // 
            this.dgvtxtBatchNo.DataPropertyName = "batchNo";
            this.dgvtxtBatchNo.HeaderText = "Batch";
            this.dgvtxtBatchNo.Name = "dgvtxtBatchNo";
            this.dgvtxtBatchNo.ReadOnly = true;
            this.dgvtxtBatchNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(302, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(393, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(19, 46);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 503;
            this.lblToDate.Text = "To Date";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(120, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(211, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRate.Location = new System.Drawing.Point(19, 100);
            this.lblRate.Margin = new System.Windows.Forms.Padding(5);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 502;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(120, 97);
            this.txtRate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRate.MaxLength = 13;
            this.txtRate.Name = "txtRate";
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRate.Size = new System.Drawing.Size(200, 20);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(19, 21);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 501;
            this.lblFromDate.Text = "From Date";
            // 
            // frmStandardRatePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(803, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStandardRatePopup";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Rate PopUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStandardRatePopup_FormClosing);
            this.Load += new System.EventHandler(this.frmStandardRatePopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStandardRatePopup_KeyDown);
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblRateValidator;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView dgvStandardRate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStandardRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchNo;
    }
}