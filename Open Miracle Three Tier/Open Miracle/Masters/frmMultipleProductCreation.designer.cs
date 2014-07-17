namespace Open_Miracle
{
    partial class frmMultipleProductCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleProductCreation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnRackAdd = new System.Windows.Forms.Button();
            this.btnGodownAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRack = new System.Windows.Forms.Label();
            this.lblGodown = new System.Windows.Forms.Label();
            this.cmbRack = new System.Windows.Forms.ComboBox();
            this.cmbGoDown = new System.Windows.Forms.ComboBox();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.btnProductGroupAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbTaxApplication = new System.Windows.Forms.ComboBox();
            this.lblTaxApplication = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.dgvMultipleProductCreation = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbBrand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbSize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcmbModel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtPurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleProductCreation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklblRemove);
            this.groupBox1.Controls.Add(this.btnRackAdd);
            this.groupBox1.Controls.Add(this.btnGodownAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRack);
            this.groupBox1.Controls.Add(this.lblGodown);
            this.groupBox1.Controls.Add(this.cmbRack);
            this.groupBox1.Controls.Add(this.cmbGoDown);
            this.groupBox1.Controls.Add(this.btnUnitAdd);
            this.groupBox1.Controls.Add(this.btnProductGroupAdd);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbTaxApplication);
            this.groupBox1.Controls.Add(this.lblTaxApplication);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.cmbTax);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.cmbProductGroup);
            this.groupBox1.Controls.Add(this.lblProductGroup);
            this.groupBox1.Controls.Add(this.dgvMultipleProductCreation);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiple Product Creation";
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblRemove.Location = new System.Drawing.Point(703, 564);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(47, 13);
            this.lnklblRemove.TabIndex = 21;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRemove_LinkClicked);
            // 
            // btnRackAdd
            // 
            this.btnRackAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnRackAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRackAdd.FlatAppearance.BorderSize = 0;
            this.btnRackAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRackAdd.Location = new System.Drawing.Point(727, 73);
            this.btnRackAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnRackAdd.Name = "btnRackAdd";
            this.btnRackAdd.Size = new System.Drawing.Size(20, 20);
            this.btnRackAdd.TabIndex = 9;
            this.btnRackAdd.UseVisualStyleBackColor = true;
            this.btnRackAdd.Click += new System.EventHandler(this.btnRackAdd_Click);
            // 
            // btnGodownAdd
            // 
            this.btnGodownAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnGodownAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGodownAdd.FlatAppearance.BorderSize = 0;
            this.btnGodownAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGodownAdd.Location = new System.Drawing.Point(332, 73);
            this.btnGodownAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnGodownAdd.Name = "btnGodownAdd";
            this.btnGodownAdd.Size = new System.Drawing.Size(20, 20);
            this.btnGodownAdd.TabIndex = 7;
            this.btnGodownAdd.UseVisualStyleBackColor = true;
            this.btnGodownAdd.Click += new System.EventHandler(this.btnGodownAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(714, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRack.Location = new System.Drawing.Point(413, 77);
            this.lblRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(33, 13);
            this.lblRack.TabIndex = 476;
            this.lblRack.Text = "Rack";
            // 
            // lblGodown
            // 
            this.lblGodown.AutoSize = true;
            this.lblGodown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodown.Location = new System.Drawing.Point(15, 77);
            this.lblGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(47, 13);
            this.lblGodown.TabIndex = 475;
            this.lblGodown.Text = "Godown";
            // 
            // cmbRack
            // 
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.FormattingEnabled = true;
            this.cmbRack.Location = new System.Drawing.Point(511, 73);
            this.cmbRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.Size = new System.Drawing.Size(200, 21);
            this.cmbRack.TabIndex = 8;
            this.cmbRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRack_KeyDown);
            // 
            // cmbGoDown
            // 
            this.cmbGoDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoDown.FormattingEnabled = true;
            this.cmbGoDown.Location = new System.Drawing.Point(126, 73);
            this.cmbGoDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGoDown.Name = "cmbGoDown";
            this.cmbGoDown.Size = new System.Drawing.Size(200, 21);
            this.cmbGoDown.TabIndex = 6;
            this.cmbGoDown.SelectedIndexChanged += new System.EventHandler(this.cmbGoDown_SelectedIndexChanged);
            this.cmbGoDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGoDown_KeyDown);
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnUnitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUnitAdd.FlatAppearance.BorderSize = 0;
            this.btnUnitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitAdd.Location = new System.Drawing.Point(727, 19);
            this.btnUnitAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(20, 25);
            this.btnUnitAdd.TabIndex = 3;
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // btnProductGroupAdd
            // 
            this.btnProductGroupAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnProductGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnProductGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductGroupAdd.Location = new System.Drawing.Point(332, 21);
            this.btnProductGroupAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnProductGroupAdd.Name = "btnProductGroupAdd";
            this.btnProductGroupAdd.Size = new System.Drawing.Size(20, 20);
            this.btnProductGroupAdd.TabIndex = 1;
            this.btnProductGroupAdd.UseVisualStyleBackColor = true;
            this.btnProductGroupAdd.Click += new System.EventHandler(this.btnProductGroupAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(665, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(483, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 11;
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
            this.btnClear.Location = new System.Drawing.Point(574, 585);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbTaxApplication
            // 
            this.cmbTaxApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxApplication.FormattingEnabled = true;
            this.cmbTaxApplication.Items.AddRange(new object[] {
            "NA",
            "Rate",
            "MRP"});
            this.cmbTaxApplication.Location = new System.Drawing.Point(511, 47);
            this.cmbTaxApplication.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTaxApplication.Name = "cmbTaxApplication";
            this.cmbTaxApplication.Size = new System.Drawing.Size(200, 21);
            this.cmbTaxApplication.TabIndex = 5;
            this.cmbTaxApplication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTaxApplication_KeyDown);
            // 
            // lblTaxApplication
            // 
            this.lblTaxApplication.AutoSize = true;
            this.lblTaxApplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaxApplication.Location = new System.Drawing.Point(413, 51);
            this.lblTaxApplication.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTaxApplication.Name = "lblTaxApplication";
            this.lblTaxApplication.Size = new System.Drawing.Size(92, 13);
            this.lblTaxApplication.TabIndex = 472;
            this.lblTaxApplication.Text = "Tax Applicable on";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(511, 21);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(200, 21);
            this.cmbUnit.TabIndex = 2;
            this.cmbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUnit_KeyDown);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnit.Location = new System.Drawing.Point(413, 25);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 471;
            this.lblUnit.Text = "Unit";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(126, 47);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(200, 21);
            this.cmbTax.TabIndex = 4;
            this.cmbTax.SelectedValueChanged += new System.EventHandler(this.cmbTax_SelectedValueChanged);
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTax.Location = new System.Drawing.Point(16, 51);
            this.lblTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 470;
            this.lblTax.Text = "Tax";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(126, 21);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbProductGroup.TabIndex = 0;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown_1);
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductGroup.Location = new System.Drawing.Point(16, 25);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 13);
            this.lblProductGroup.TabIndex = 469;
            this.lblProductGroup.Text = "Product Group";
            // 
            // dgvMultipleProductCreation
            // 
            this.dgvMultipleProductCreation.AllowUserToResizeRows = false;
            this.dgvMultipleProductCreation.BackgroundColor = System.Drawing.Color.White;
            this.dgvMultipleProductCreation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleProductCreation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMultipleProductCreation.ColumnHeadersHeight = 35;
            this.dgvMultipleProductCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMultipleProductCreation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtProductCode,
            this.dgvtxtProductName,
            this.dgvcmbBrand,
            this.dgvcmbSize,
            this.dgvcmbModel,
            this.dgvtxtPurchaseRate,
            this.dgvtxtsalesRate,
            this.dgvtxtMRP,
            this.dgvtxtCheck});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleProductCreation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMultipleProductCreation.EnableHeadersVisualStyles = false;
            this.dgvMultipleProductCreation.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMultipleProductCreation.Location = new System.Drawing.Point(19, 111);
            this.dgvMultipleProductCreation.Name = "dgvMultipleProductCreation";
            this.dgvMultipleProductCreation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleProductCreation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMultipleProductCreation.RowHeadersWidth = 40;
            this.dgvMultipleProductCreation.Size = new System.Drawing.Size(731, 449);
            this.dgvMultipleProductCreation.TabIndex = 10;
            this.dgvMultipleProductCreation.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleProductCreation_CellEndEdit);
            this.dgvMultipleProductCreation.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleProductCreation_CellEnter);
            this.dgvMultipleProductCreation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleProductCreation_CellValueChanged);
            this.dgvMultipleProductCreation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMultipleProductCreation_DataError);
            this.dgvMultipleProductCreation.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMultipleProductCreation_DefaultValuesNeeded);
            this.dgvMultipleProductCreation.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMultipleProductCreation_EditingControlShowing);
            this.dgvMultipleProductCreation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMultipleProductCreation_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.FillWeight = 50.52285F;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.MinimumWidth = 34;
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 34;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "productCode";
            this.dgvtxtProductCode.FillWeight = 99.64315F;
            this.dgvtxtProductCode.HeaderText = "Code";
            this.dgvtxtProductCode.MinimumWidth = 81;
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductCode.Width = 81;
            // 
            // dgvtxtProductName
            // 
            this.dgvtxtProductName.DataPropertyName = "productName";
            this.dgvtxtProductName.FillWeight = 99.64315F;
            this.dgvtxtProductName.HeaderText = "Name";
            this.dgvtxtProductName.MinimumWidth = 82;
            this.dgvtxtProductName.Name = "dgvtxtProductName";
            this.dgvtxtProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductName.Width = 82;
            // 
            // dgvcmbBrand
            // 
            this.dgvcmbBrand.DataPropertyName = "brandId";
            this.dgvcmbBrand.FillWeight = 99.64315F;
            this.dgvcmbBrand.HeaderText = "Brand";
            this.dgvcmbBrand.MinimumWidth = 81;
            this.dgvcmbBrand.Name = "dgvcmbBrand";
            this.dgvcmbBrand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbBrand.Width = 81;
            // 
            // dgvcmbSize
            // 
            this.dgvcmbSize.DataPropertyName = "sizeId";
            this.dgvcmbSize.FillWeight = 99.64315F;
            this.dgvcmbSize.HeaderText = "Size";
            this.dgvcmbSize.MinimumWidth = 82;
            this.dgvcmbSize.Name = "dgvcmbSize";
            this.dgvcmbSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbSize.Width = 82;
            // 
            // dgvcmbModel
            // 
            this.dgvcmbModel.DataPropertyName = "modelId";
            this.dgvcmbModel.FillWeight = 99.64315F;
            this.dgvcmbModel.HeaderText = "Model No.";
            this.dgvcmbModel.MinimumWidth = 81;
            this.dgvcmbModel.Name = "dgvcmbModel";
            this.dgvcmbModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbModel.Width = 81;
            // 
            // dgvtxtPurchaseRate
            // 
            this.dgvtxtPurchaseRate.DataPropertyName = "purchaseRate";
            this.dgvtxtPurchaseRate.FillWeight = 99.64315F;
            this.dgvtxtPurchaseRate.HeaderText = "Purchase Rate";
            this.dgvtxtPurchaseRate.MaxInputLength = 12;
            this.dgvtxtPurchaseRate.MinimumWidth = 81;
            this.dgvtxtPurchaseRate.Name = "dgvtxtPurchaseRate";
            this.dgvtxtPurchaseRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseRate.Width = 81;
            // 
            // dgvtxtsalesRate
            // 
            this.dgvtxtsalesRate.DataPropertyName = "salesRate";
            this.dgvtxtsalesRate.FillWeight = 99.64315F;
            this.dgvtxtsalesRate.HeaderText = "Sales Rate";
            this.dgvtxtsalesRate.MaxInputLength = 12;
            this.dgvtxtsalesRate.MinimumWidth = 82;
            this.dgvtxtsalesRate.Name = "dgvtxtsalesRate";
            this.dgvtxtsalesRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsalesRate.Width = 82;
            // 
            // dgvtxtMRP
            // 
            this.dgvtxtMRP.DataPropertyName = "mrp";
            this.dgvtxtMRP.FillWeight = 99.64315F;
            this.dgvtxtMRP.HeaderText = "MRP";
            this.dgvtxtMRP.MaxInputLength = 12;
            this.dgvtxtMRP.MinimumWidth = 85;
            this.dgvtxtMRP.Name = "dgvtxtMRP";
            this.dgvtxtMRP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMRP.Width = 85;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.FillWeight = 21.33207F;
            this.dgvtxtCheck.HeaderText = "";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.ReadOnly = true;
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // frmMultipleProductCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(804, 655);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMultipleProductCreation";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Product Creation";
            this.Load += new System.EventHandler(this.frmMultipleProductCreation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMultipleProductCreation_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleProductCreation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnRackAdd;
        private System.Windows.Forms.Button btnGodownAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.ComboBox cmbRack;
        private System.Windows.Forms.ComboBox cmbGoDown;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Button btnProductGroupAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbTaxApplication;
        private System.Windows.Forms.Label lblTaxApplication;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.Label lblTax;
        protected internal System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private dgv.DataGridViewEnter dgvMultipleProductCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbBrand;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbSize;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
    }
}