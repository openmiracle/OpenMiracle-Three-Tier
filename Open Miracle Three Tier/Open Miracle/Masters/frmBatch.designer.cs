namespace Open_Miracle
{
    partial class frmBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProductValidator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMfgDate = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.lblBatchnameValidator = new System.Windows.Forms.Label();
            this.dtpMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearsearch = new System.Windows.Forms.Button();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.dgvtxtBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductValidator
            // 
            this.lblProductValidator.AutoSize = true;
            this.lblProductValidator.Enabled = false;
            this.lblProductValidator.ForeColor = System.Drawing.Color.Red;
            this.lblProductValidator.Location = new System.Drawing.Point(804, 57);
            this.lblProductValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductValidator.Name = "lblProductValidator";
            this.lblProductValidator.Size = new System.Drawing.Size(11, 13);
            this.lblProductValidator.TabIndex = 116;
            this.lblProductValidator.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMfgDate);
            this.groupBox1.Controls.Add(this.txtExpiryDate);
            this.groupBox1.Controls.Add(this.lblBatchnameValidator);
            this.groupBox1.Controls.Add(this.dtpMfgDate);
            this.groupBox1.Controls.Add(this.dtpExpiryDate);
            this.groupBox1.Controls.Add(this.lblExpiryDate);
            this.groupBox1.Controls.Add(this.lblMfgDate);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtBatchName);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblBatchName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(746, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "*";
            // 
            // txtMfgDate
            // 
            this.txtMfgDate.Location = new System.Drawing.Point(122, 45);
            this.txtMfgDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtMfgDate.Name = "txtMfgDate";
            this.txtMfgDate.Size = new System.Drawing.Size(179, 20);
            this.txtMfgDate.TabIndex = 2;
            this.txtMfgDate.TextChanged += new System.EventHandler(this.txtMfgDate_TextChanged);
            this.txtMfgDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMfgDate_KeyDown);
            this.txtMfgDate.Leave += new System.EventHandler(this.txtMfgDate_Leave);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(545, 44);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(181, 20);
            this.txtExpiryDate.TabIndex = 3;
            this.txtExpiryDate.TextChanged += new System.EventHandler(this.txtExpiryDate_TextChanged);
            this.txtExpiryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpiryDate_KeyDown);
            this.txtExpiryDate.Leave += new System.EventHandler(this.txtExpiryDate_Leave);
            // 
            // lblBatchnameValidator
            // 
            this.lblBatchnameValidator.AutoSize = true;
            this.lblBatchnameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblBatchnameValidator.Location = new System.Drawing.Point(328, 25);
            this.lblBatchnameValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblBatchnameValidator.Name = "lblBatchnameValidator";
            this.lblBatchnameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblBatchnameValidator.TabIndex = 131;
            this.lblBatchnameValidator.Text = "*";
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMfgDate.Location = new System.Drawing.Point(299, 45);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(23, 20);
            this.dtpMfgDate.TabIndex = 118;
            this.dtpMfgDate.ValueChanged += new System.EventHandler(this.dtpMfgDate_ValueChanged);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(725, 44);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(20, 20);
            this.dtpExpiryDate.TabIndex = 120;
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dtpExpiryDate_ValueChanged);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpiryDate.Location = new System.Drawing.Point(473, 48);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(61, 13);
            this.lblExpiryDate.TabIndex = 130;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMfgDate.Location = new System.Drawing.Point(12, 49);
            this.lblMfgDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(54, 13);
            this.lblMfgDate.TabIndex = 129;
            this.lblMfgDate.Text = "Mfg. Date";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(545, 19);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 21);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(395, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
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
            this.btnDelete.Location = new System.Drawing.Point(304, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(122, 21);
            this.txtBatchName.Margin = new System.Windows.Forms.Padding(5);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(200, 20);
            this.txtBatchName.TabIndex = 0;
            this.txtBatchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchName_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(12, 69);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 128;
            this.lblNarration.Text = "Narration";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(473, 23);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 127;
            this.lblProduct.Text = "Product";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatchName.Location = new System.Drawing.Point(12, 25);
            this.lblBatchName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(66, 13);
            this.lblBatchName.TabIndex = 126;
            this.lblBatchName.Text = "Batch Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(122, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 5;
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
            this.btnClear.Location = new System.Drawing.Point(213, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(122, 69);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 85);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnClearsearch);
            this.groupBox2.Controls.Add(this.cmbProductName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.txtBatch);
            this.groupBox2.Controls.Add(this.lblBatch);
            this.groupBox2.Controls.Add(this.dgvBatch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(546, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClearsearch
            // 
            this.btnClearsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearsearch.BackgroundImage")));
            this.btnClearsearch.FlatAppearance.BorderSize = 0;
            this.btnClearsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearsearch.ForeColor = System.Drawing.Color.White;
            this.btnClearsearch.Location = new System.Drawing.Point(637, 46);
            this.btnClearsearch.Name = "btnClearsearch";
            this.btnClearsearch.Size = new System.Drawing.Size(85, 27);
            this.btnClearsearch.TabIndex = 3;
            this.btnClearsearch.Text = "Clear";
            this.btnClearsearch.UseVisualStyleBackColor = true;
            this.btnClearsearch.Click += new System.EventHandler(this.btnClearsearch_Click);
            this.btnClearsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClearsearch_KeyDown);
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(546, 18);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(200, 21);
            this.cmbProductName.TabIndex = 1;
            this.cmbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductName_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(474, 22);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 13);
            this.lblProductName.TabIndex = 70;
            this.lblProductName.Text = "Product";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(135, 18);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(5);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(200, 20);
            this.txtBatch.TabIndex = 0;
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBatch.Location = new System.Drawing.Point(13, 22);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(5);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(66, 13);
            this.lblBatch.TabIndex = 69;
            this.lblBatch.Text = "Batch Name";
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.AllowUserToDeleteRows = false;
            this.dgvBatch.AllowUserToResizeColumns = false;
            this.dgvBatch.AllowUserToResizeRows = false;
            this.dgvBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatch.ColumnHeadersHeight = 25;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtBatchId,
            this.dgvtxtSlNo,
            this.dgvtxtBatchName,
            this.dgvtxtProduct,
            this.dgvtxtMfgDate,
            this.dgvtxtExpiryDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBatch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBatch.EnableHeadersVisualStyles = false;
            this.dgvBatch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBatch.Location = new System.Drawing.Point(17, 79);
            this.dgvBatch.MultiSelect = false;
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.ReadOnly = true;
            this.dgvBatch.RowHeadersVisible = false;
            this.dgvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatch.Size = new System.Drawing.Size(729, 267);
            this.dgvBatch.TabIndex = 68;
            this.dgvBatch.TabStop = false;
            this.dgvBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellDoubleClick);
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
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBatchName
            // 
            this.dgvtxtBatchName.DataPropertyName = "batchNo";
            this.dgvtxtBatchName.HeaderText = "Batch Name";
            this.dgvtxtBatchName.Name = "dgvtxtBatchName";
            this.dgvtxtBatchName.ReadOnly = true;
            this.dgvtxtBatchName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtProduct
            // 
            this.dgvtxtProduct.DataPropertyName = "productName";
            this.dgvtxtProduct.HeaderText = "Product";
            this.dgvtxtProduct.Name = "dgvtxtProduct";
            this.dgvtxtProduct.ReadOnly = true;
            this.dgvtxtProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtMfgDate
            // 
            this.dgvtxtMfgDate.DataPropertyName = "manufacturingDate";
            dataGridViewCellStyle2.NullValue = "dd-mm-yyyy";
            this.dgvtxtMfgDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtMfgDate.HeaderText = "Mfg.Date";
            this.dgvtxtMfgDate.Name = "dgvtxtMfgDate";
            this.dgvtxtMfgDate.ReadOnly = true;
            this.dgvtxtMfgDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtExpiryDate
            // 
            this.dgvtxtExpiryDate.DataPropertyName = "expiryDate";
            this.dgvtxtExpiryDate.HeaderText = "Expiry Date";
            this.dgvtxtExpiryDate.Name = "dgvtxtExpiryDate";
            this.dgvtxtExpiryDate.ReadOnly = true;
            this.dgvtxtExpiryDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProductValidator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBatch";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch";
            this.Load += new System.EventHandler(this.frmBatch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBatch_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductValidator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMfgDate;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblBatchnameValidator;
        private System.Windows.Forms.DateTimePicker dtpMfgDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearsearch;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtExpiryDate;
        private System.Windows.Forms.Label label1;
    }
}