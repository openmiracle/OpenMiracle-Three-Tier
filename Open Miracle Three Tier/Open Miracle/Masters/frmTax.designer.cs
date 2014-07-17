namespace Open_Miracle
{
    partial class frmTax
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTax));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRateMandatory = new System.Windows.Forms.Label();
            this.lblApplicableForMandatory = new System.Windows.Forms.Label();
            this.lblTaxNameMandatory = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.dgvTaxSelection = new System.Windows.Forms.DataGridView();
            this.dgvcbxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtTaxDetaildId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxNameInTaxSelection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCalculationMode = new System.Windows.Forms.ComboBox();
            this.lblCalculationMode = new System.Windows.Forms.Label();
            this.cmbApplicableFor = new System.Windows.Forms.ComboBox();
            this.lblApplicableFor = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtTaxName = new System.Windows.Forms.TextBox();
            this.lblTaxName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbActiveSearch = new System.Windows.Forms.ComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.cmbCalculationModeSearch = new System.Windows.Forms.ComboBox();
            this.txtCalculationModeSearch = new System.Windows.Forms.Label();
            this.cmbApplicableForSearch = new System.Windows.Forms.ComboBox();
            this.txtApplicableForSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtTaxNameSearch = new System.Windows.Forms.TextBox();
            this.lblTaxNameSearch = new System.Windows.Forms.Label();
            this.dgvTaxSearch = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxIdSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtApplicableFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCalculationMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxSelection)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRateMandatory);
            this.groupBox1.Controls.Add(this.lblApplicableForMandatory);
            this.groupBox1.Controls.Add(this.lblTaxNameMandatory);
            this.groupBox1.Controls.Add(this.cbxActive);
            this.groupBox1.Controls.Add(this.dgvTaxSelection);
            this.groupBox1.Controls.Add(this.cmbCalculationMode);
            this.groupBox1.Controls.Add(this.lblCalculationMode);
            this.groupBox1.Controls.Add(this.cmbApplicableFor);
            this.groupBox1.Controls.Add(this.lblApplicableFor);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.txtTaxName);
            this.groupBox1.Controls.Add(this.lblTaxName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 220);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax";
            // 
            // lblRateMandatory
            // 
            this.lblRateMandatory.AutoSize = true;
            this.lblRateMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblRateMandatory.Location = new System.Drawing.Point(741, 28);
            this.lblRateMandatory.Name = "lblRateMandatory";
            this.lblRateMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblRateMandatory.TabIndex = 237;
            this.lblRateMandatory.Text = "*";
            // 
            // lblApplicableForMandatory
            // 
            this.lblApplicableForMandatory.AutoSize = true;
            this.lblApplicableForMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblApplicableForMandatory.Location = new System.Drawing.Point(316, 52);
            this.lblApplicableForMandatory.Name = "lblApplicableForMandatory";
            this.lblApplicableForMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblApplicableForMandatory.TabIndex = 235;
            this.lblApplicableForMandatory.Text = "*";
            // 
            // lblTaxNameMandatory
            // 
            this.lblTaxNameMandatory.AutoSize = true;
            this.lblTaxNameMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblTaxNameMandatory.Location = new System.Drawing.Point(316, 28);
            this.lblTaxNameMandatory.Name = "lblTaxNameMandatory";
            this.lblTaxNameMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblTaxNameMandatory.TabIndex = 236;
            this.lblTaxNameMandatory.Text = "*";
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.BackColor = System.Drawing.Color.Transparent;
            this.cbxActive.Checked = true;
            this.cbxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActive.ForeColor = System.Drawing.Color.White;
            this.cbxActive.Location = new System.Drawing.Point(537, 127);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(56, 17);
            this.cbxActive.TabIndex = 5;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = false;
            this.cbxActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxActive_KeyDown);
            // 
            // dgvTaxSelection
            // 
            this.dgvTaxSelection.AllowUserToAddRows = false;
            this.dgvTaxSelection.AllowUserToDeleteRows = false;
            this.dgvTaxSelection.AllowUserToResizeColumns = false;
            this.dgvTaxSelection.AllowUserToResizeRows = false;
            this.dgvTaxSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaxSelection.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaxSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaxSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaxSelection.ColumnHeadersHeight = 25;
            this.dgvTaxSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaxSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbxSelect,
            this.dgvtxtTaxDetaildId,
            this.dgvtxtTaxId,
            this.dgvtxtTaxNameInTaxSelection});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaxSelection.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaxSelection.EnableHeadersVisualStyles = false;
            this.dgvTaxSelection.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTaxSelection.Location = new System.Drawing.Point(108, 76);
            this.dgvTaxSelection.MultiSelect = false;
            this.dgvTaxSelection.Name = "dgvTaxSelection";
            this.dgvTaxSelection.RowHeadersVisible = false;
            this.dgvTaxSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaxSelection.Size = new System.Drawing.Size(257, 111);
            this.dgvTaxSelection.TabIndex = 223;
            // 
            // dgvcbxSelect
            // 
            this.dgvcbxSelect.HeaderText = "Select";
            this.dgvcbxSelect.Name = "dgvcbxSelect";
            this.dgvcbxSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtTaxDetaildId
            // 
            this.dgvtxtTaxDetaildId.DataPropertyName = "taxDetailsId";
            this.dgvtxtTaxDetaildId.HeaderText = "TaxDetails Id";
            this.dgvtxtTaxDetaildId.Name = "dgvtxtTaxDetaildId";
            this.dgvtxtTaxDetaildId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxDetaildId.Visible = false;
            // 
            // dgvtxtTaxId
            // 
            this.dgvtxtTaxId.DataPropertyName = "taxId";
            this.dgvtxtTaxId.HeaderText = "TaxId";
            this.dgvtxtTaxId.Name = "dgvtxtTaxId";
            this.dgvtxtTaxId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxId.Visible = false;
            // 
            // dgvtxtTaxNameInTaxSelection
            // 
            this.dgvtxtTaxNameInTaxSelection.DataPropertyName = "taxName";
            this.dgvtxtTaxNameInTaxSelection.HeaderText = "Tax Name";
            this.dgvtxtTaxNameInTaxSelection.Name = "dgvtxtTaxNameInTaxSelection";
            this.dgvtxtTaxNameInTaxSelection.ReadOnly = true;
            this.dgvtxtTaxNameInTaxSelection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbCalculationMode
            // 
            this.cmbCalculationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalculationMode.FormattingEnabled = true;
            this.cmbCalculationMode.Items.AddRange(new object[] {
            "Bill Amount",
            "Tax Amount"});
            this.cmbCalculationMode.Location = new System.Drawing.Point(537, 48);
            this.cmbCalculationMode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbCalculationMode.Name = "cmbCalculationMode";
            this.cmbCalculationMode.Size = new System.Drawing.Size(200, 21);
            this.cmbCalculationMode.TabIndex = 3;
            this.cmbCalculationMode.SelectedIndexChanged += new System.EventHandler(this.cmbCalculationMode_SelectedIndexChanged);
            this.cmbCalculationMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCalculationMode_KeyDown);
            // 
            // lblCalculationMode
            // 
            this.lblCalculationMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalculationMode.Location = new System.Drawing.Point(427, 48);
            this.lblCalculationMode.Margin = new System.Windows.Forms.Padding(5);
            this.lblCalculationMode.Name = "lblCalculationMode";
            this.lblCalculationMode.Size = new System.Drawing.Size(100, 20);
            this.lblCalculationMode.TabIndex = 234;
            this.lblCalculationMode.Text = "Calculation Mode";
            // 
            // cmbApplicableFor
            // 
            this.cmbApplicableFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicableFor.FormattingEnabled = true;
            this.cmbApplicableFor.Items.AddRange(new object[] {
            "Bill",
            "Product"});
            this.cmbApplicableFor.Location = new System.Drawing.Point(108, 48);
            this.cmbApplicableFor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbApplicableFor.Name = "cmbApplicableFor";
            this.cmbApplicableFor.Size = new System.Drawing.Size(200, 21);
            this.cmbApplicableFor.TabIndex = 2;
            this.cmbApplicableFor.SelectedIndexChanged += new System.EventHandler(this.cmbApplicableFor_SelectedIndexChanged);
            this.cmbApplicableFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbApplicableFor_KeyDown);
            // 
            // lblApplicableFor
            // 
            this.lblApplicableFor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApplicableFor.Location = new System.Drawing.Point(12, 48);
            this.lblApplicableFor.Margin = new System.Windows.Forms.Padding(5);
            this.lblApplicableFor.Name = "lblApplicableFor";
            this.lblApplicableFor.Size = new System.Drawing.Size(100, 20);
            this.lblApplicableFor.TabIndex = 233;
            this.lblApplicableFor.Text = "Applicable For";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(537, 24);
            this.txtRate.Margin = new System.Windows.Forms.Padding(5);
            this.txtRate.MaxLength = 10;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 20);
            this.txtRate.TabIndex = 1;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // lblRate
            // 
            this.lblRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRate.Location = new System.Drawing.Point(427, 24);
            this.lblRate.Margin = new System.Windows.Forms.Padding(5);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 20);
            this.lblRate.TabIndex = 232;
            this.lblRate.Text = "Rate";
            // 
            // txtTaxName
            // 
            this.txtTaxName.Location = new System.Drawing.Point(108, 24);
            this.txtTaxName.Margin = new System.Windows.Forms.Padding(5);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(200, 20);
            this.txtTaxName.TabIndex = 0;
            this.txtTaxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaxName_KeyDown);
            // 
            // lblTaxName
            // 
            this.lblTaxName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaxName.Location = new System.Drawing.Point(12, 24);
            this.lblTaxName.Margin = new System.Windows.Forms.Padding(5);
            this.lblTaxName.Name = "lblTaxName";
            this.lblTaxName.Size = new System.Drawing.Size(100, 20);
            this.lblTaxName.TabIndex = 231;
            this.lblTaxName.Text = "Tax Name";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(652, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(537, 73);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(427, 73);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 230;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(561, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(379, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 6;
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
            this.btnClear.Location = new System.Drawing.Point(470, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbActiveSearch);
            this.groupBox2.Controls.Add(this.lblActive);
            this.groupBox2.Controls.Add(this.cmbCalculationModeSearch);
            this.groupBox2.Controls.Add(this.txtCalculationModeSearch);
            this.groupBox2.Controls.Add(this.cmbApplicableForSearch);
            this.groupBox2.Controls.Add(this.txtApplicableForSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnClearSearch);
            this.groupBox2.Controls.Add(this.txtTaxNameSearch);
            this.groupBox2.Controls.Add(this.lblTaxNameSearch);
            this.groupBox2.Controls.Add(this.dgvTaxSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 350);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbActiveSearch
            // 
            this.cmbActiveSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveSearch.FormattingEnabled = true;
            this.cmbActiveSearch.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbActiveSearch.Location = new System.Drawing.Point(379, 48);
            this.cmbActiveSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbActiveSearch.Name = "cmbActiveSearch";
            this.cmbActiveSearch.Size = new System.Drawing.Size(157, 21);
            this.cmbActiveSearch.TabIndex = 3;
            this.cmbActiveSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbActiveSearch_KeyDown);
            // 
            // lblActive
            // 
            this.lblActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActive.Location = new System.Drawing.Point(281, 48);
            this.lblActive.Margin = new System.Windows.Forms.Padding(5);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(72, 20);
            this.lblActive.TabIndex = 228;
            this.lblActive.Text = "Active";
            // 
            // cmbCalculationModeSearch
            // 
            this.cmbCalculationModeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalculationModeSearch.FormattingEnabled = true;
            this.cmbCalculationModeSearch.Items.AddRange(new object[] {
            "All",
            "Bill Amount",
            "Tax Amount"});
            this.cmbCalculationModeSearch.Location = new System.Drawing.Point(121, 48);
            this.cmbCalculationModeSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbCalculationModeSearch.Name = "cmbCalculationModeSearch";
            this.cmbCalculationModeSearch.Size = new System.Drawing.Size(152, 21);
            this.cmbCalculationModeSearch.TabIndex = 2;
            this.cmbCalculationModeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCalculationModeSearch_KeyDown);
            // 
            // txtCalculationModeSearch
            // 
            this.txtCalculationModeSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCalculationModeSearch.Location = new System.Drawing.Point(11, 48);
            this.txtCalculationModeSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtCalculationModeSearch.Name = "txtCalculationModeSearch";
            this.txtCalculationModeSearch.Size = new System.Drawing.Size(100, 20);
            this.txtCalculationModeSearch.TabIndex = 227;
            this.txtCalculationModeSearch.Text = "Calculation Mode";
            // 
            // cmbApplicableForSearch
            // 
            this.cmbApplicableForSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicableForSearch.FormattingEnabled = true;
            this.cmbApplicableForSearch.Items.AddRange(new object[] {
            "All",
            "Bill",
            "Product"});
            this.cmbApplicableForSearch.Location = new System.Drawing.Point(379, 23);
            this.cmbApplicableForSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbApplicableForSearch.Name = "cmbApplicableForSearch";
            this.cmbApplicableForSearch.Size = new System.Drawing.Size(157, 21);
            this.cmbApplicableForSearch.TabIndex = 1;
            this.cmbApplicableForSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbApplicableForSearch_KeyDown);
            // 
            // txtApplicableForSearch
            // 
            this.txtApplicableForSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtApplicableForSearch.Location = new System.Drawing.Point(281, 23);
            this.txtApplicableForSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtApplicableForSearch.Name = "txtApplicableForSearch";
            this.txtApplicableForSearch.Size = new System.Drawing.Size(100, 20);
            this.txtApplicableForSearch.TabIndex = 226;
            this.txtApplicableForSearch.Text = "Applicable For";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(565, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.BackgroundImage")));
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(656, 44);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(85, 27);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            this.btnClearSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClearSearch_KeyDown);
            // 
            // txtTaxNameSearch
            // 
            this.txtTaxNameSearch.Location = new System.Drawing.Point(121, 23);
            this.txtTaxNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtTaxNameSearch.Name = "txtTaxNameSearch";
            this.txtTaxNameSearch.Size = new System.Drawing.Size(152, 20);
            this.txtTaxNameSearch.TabIndex = 0;
            this.txtTaxNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaxNameSearch_KeyDown);
            // 
            // lblTaxNameSearch
            // 
            this.lblTaxNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaxNameSearch.Location = new System.Drawing.Point(11, 23);
            this.lblTaxNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.lblTaxNameSearch.Name = "lblTaxNameSearch";
            this.lblTaxNameSearch.Size = new System.Drawing.Size(100, 20);
            this.lblTaxNameSearch.TabIndex = 225;
            this.lblTaxNameSearch.Text = "Tax Name";
            // 
            // dgvTaxSearch
            // 
            this.dgvTaxSearch.AllowUserToAddRows = false;
            this.dgvTaxSearch.AllowUserToDeleteRows = false;
            this.dgvTaxSearch.AllowUserToResizeColumns = false;
            this.dgvTaxSearch.AllowUserToResizeRows = false;
            this.dgvTaxSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaxSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaxSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaxSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaxSearch.ColumnHeadersHeight = 25;
            this.dgvTaxSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaxSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.dgvtxtTaxIdSearch,
            this.dgvtxtTaxName,
            this.dgvtxtApplicableFor,
            this.dgvtxtCalculationMode,
            this.dgvtxtActive});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaxSearch.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTaxSearch.EnableHeadersVisualStyles = false;
            this.dgvTaxSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTaxSearch.Location = new System.Drawing.Point(15, 77);
            this.dgvTaxSearch.MultiSelect = false;
            this.dgvTaxSearch.Name = "dgvTaxSearch";
            this.dgvTaxSearch.ReadOnly = true;
            this.dgvTaxSearch.RowHeadersVisible = false;
            this.dgvTaxSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaxSearch.Size = new System.Drawing.Size(730, 256);
            this.dgvTaxSearch.TabIndex = 224;
            this.dgvTaxSearch.TabStop = false;
            this.dgvTaxSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaxSearch_CellDoubleClick);
            this.dgvTaxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTaxSearch_KeyDown);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.DataPropertyName = "Sl No";
            this.dgvtxtSlno.HeaderText = "Sl No";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.ReadOnly = true;
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTaxIdSearch
            // 
            this.dgvtxtTaxIdSearch.DataPropertyName = "taxId";
            this.dgvtxtTaxIdSearch.HeaderText = "TaxId";
            this.dgvtxtTaxIdSearch.Name = "dgvtxtTaxIdSearch";
            this.dgvtxtTaxIdSearch.ReadOnly = true;
            this.dgvtxtTaxIdSearch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTaxIdSearch.Visible = false;
            // 
            // dgvtxtTaxName
            // 
            this.dgvtxtTaxName.DataPropertyName = "taxName";
            this.dgvtxtTaxName.HeaderText = "Tax Name";
            this.dgvtxtTaxName.Name = "dgvtxtTaxName";
            this.dgvtxtTaxName.ReadOnly = true;
            this.dgvtxtTaxName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtApplicableFor
            // 
            this.dgvtxtApplicableFor.DataPropertyName = "applicableOn";
            this.dgvtxtApplicableFor.HeaderText = "Applicable For";
            this.dgvtxtApplicableFor.Name = "dgvtxtApplicableFor";
            this.dgvtxtApplicableFor.ReadOnly = true;
            this.dgvtxtApplicableFor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCalculationMode
            // 
            this.dgvtxtCalculationMode.DataPropertyName = "calculatingMode";
            this.dgvtxtCalculationMode.HeaderText = "Calculation Mode";
            this.dgvtxtCalculationMode.Name = "dgvtxtCalculationMode";
            this.dgvtxtCalculationMode.ReadOnly = true;
            this.dgvtxtCalculationMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtActive
            // 
            this.dgvtxtActive.DataPropertyName = "IsActive";
            this.dgvtxtActive.HeaderText = "Active";
            this.dgvtxtActive.Name = "dgvtxtActive";
            this.dgvtxtActive.ReadOnly = true;
            this.dgvtxtActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTax";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTax_FormClosing);
            this.Load += new System.EventHandler(this.frmTax_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTax_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxSelection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRateMandatory;
        private System.Windows.Forms.Label lblApplicableForMandatory;
        private System.Windows.Forms.Label lblTaxNameMandatory;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.DataGridView dgvTaxSelection;
        private System.Windows.Forms.ComboBox cmbCalculationMode;
        private System.Windows.Forms.Label lblCalculationMode;
        private System.Windows.Forms.ComboBox cmbApplicableFor;
        private System.Windows.Forms.Label lblApplicableFor;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtTaxName;
        private System.Windows.Forms.Label lblTaxName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbActiveSearch;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.ComboBox cmbCalculationModeSearch;
        private System.Windows.Forms.Label txtCalculationModeSearch;
        private System.Windows.Forms.ComboBox cmbApplicableForSearch;
        private System.Windows.Forms.Label txtApplicableForSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox txtTaxNameSearch;
        private System.Windows.Forms.Label lblTaxNameSearch;
        private System.Windows.Forms.DataGridView dgvTaxSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxDetaildId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxNameInTaxSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxIdSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtApplicableFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCalculationMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtActive;
    }
}