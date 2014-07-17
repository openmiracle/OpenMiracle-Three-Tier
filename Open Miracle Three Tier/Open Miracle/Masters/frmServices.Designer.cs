namespace Open_Miracle
{
    partial class frmServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpServiecesSave = new System.Windows.Forms.GroupBox();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.lblCategoryMandatory = new System.Windows.Forms.Label();
            this.lblRateValidator = new System.Windows.Forms.Label();
            this.lblServiceNameValidator = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpServiecesSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.txtServiceNameSearch = new System.Windows.Forms.TextBox();
            this.lblServiceNameSearch = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.dgvtxtServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpServiecesSave.SuspendLayout();
            this.grpServiecesSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // grpServiecesSave
            // 
            this.grpServiecesSave.Controls.Add(this.btnGroupAdd);
            this.grpServiecesSave.Controls.Add(this.lblCategoryMandatory);
            this.grpServiecesSave.Controls.Add(this.lblRateValidator);
            this.grpServiecesSave.Controls.Add(this.lblServiceNameValidator);
            this.grpServiecesSave.Controls.Add(this.cmbCategory);
            this.grpServiecesSave.Controls.Add(this.lblCategory);
            this.grpServiecesSave.Controls.Add(this.txtRate);
            this.grpServiecesSave.Controls.Add(this.lblRate);
            this.grpServiecesSave.Controls.Add(this.txtServiceName);
            this.grpServiecesSave.Controls.Add(this.lblServiceName);
            this.grpServiecesSave.Controls.Add(this.btnClose);
            this.grpServiecesSave.Controls.Add(this.txtNarration);
            this.grpServiecesSave.Controls.Add(this.lblNarration);
            this.grpServiecesSave.Controls.Add(this.btnDelete);
            this.grpServiecesSave.Controls.Add(this.btnSave);
            this.grpServiecesSave.Controls.Add(this.btnClear);
            this.grpServiecesSave.ForeColor = System.Drawing.Color.White;
            this.grpServiecesSave.Location = new System.Drawing.Point(18, 13);
            this.grpServiecesSave.Name = "grpServiecesSave";
            this.grpServiecesSave.Size = new System.Drawing.Size(760, 144);
            this.grpServiecesSave.TabIndex = 0;
            this.grpServiecesSave.TabStop = false;
            this.grpServiecesSave.Text = "Service";
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupAdd.ForeColor = System.Drawing.Color.White;
            this.btnGroupAdd.Location = new System.Drawing.Point(732, 21);
            this.btnGroupAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(21, 20);
            this.btnGroupAdd.TabIndex = 2;
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // lblCategoryMandatory
            // 
            this.lblCategoryMandatory.AutoSize = true;
            this.lblCategoryMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryMandatory.Location = new System.Drawing.Point(716, 25);
            this.lblCategoryMandatory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCategoryMandatory.Name = "lblCategoryMandatory";
            this.lblCategoryMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblCategoryMandatory.TabIndex = 204;
            this.lblCategoryMandatory.Text = "*";
            // 
            // lblRateValidator
            // 
            this.lblRateValidator.AutoSize = true;
            this.lblRateValidator.ForeColor = System.Drawing.Color.Red;
            this.lblRateValidator.Location = new System.Drawing.Point(325, 50);
            this.lblRateValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRateValidator.Name = "lblRateValidator";
            this.lblRateValidator.Size = new System.Drawing.Size(11, 13);
            this.lblRateValidator.TabIndex = 202;
            this.lblRateValidator.Text = "*";
            // 
            // lblServiceNameValidator
            // 
            this.lblServiceNameValidator.AutoSize = true;
            this.lblServiceNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblServiceNameValidator.Location = new System.Drawing.Point(325, 25);
            this.lblServiceNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblServiceNameValidator.Name = "lblServiceNameValidator";
            this.lblServiceNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblServiceNameValidator.TabIndex = 203;
            this.lblServiceNameValidator.Text = "*";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(511, 21);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCategory_KeyDown);
            this.cmbCategory.Leave += new System.EventHandler(this.cmbCategory_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategory.Location = new System.Drawing.Point(401, 25);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 201;
            this.lblCategory.Text = "Category";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(124, 46);
            this.txtRate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRate.MaxLength = 13;
            this.txtRate.Name = "txtRate";
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRate.Size = new System.Drawing.Size(200, 20);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyDown);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRate.Location = new System.Drawing.Point(14, 50);
            this.lblRate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 200;
            this.lblRate.Text = "Rate";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(124, 21);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(200, 20);
            this.txtServiceName.TabIndex = 0;
            this.txtServiceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceName_KeyDown);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceName.Location = new System.Drawing.Point(14, 25);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 199;
            this.lblServiceName.Text = "Service Name";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(651, 102);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(511, 47);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
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
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(401, 47);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 198;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(560, 102);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(378, 102);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
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
            this.btnClear.Location = new System.Drawing.Point(469, 102);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpServiecesSearch
            // 
            this.grpServiecesSearch.Controls.Add(this.btnSearch);
            this.grpServiecesSearch.Controls.Add(this.btnSearchClear);
            this.grpServiecesSearch.Controls.Add(this.cmbCategorySearch);
            this.grpServiecesSearch.Controls.Add(this.lblCategorySearch);
            this.grpServiecesSearch.Controls.Add(this.txtServiceNameSearch);
            this.grpServiecesSearch.Controls.Add(this.lblServiceNameSearch);
            this.grpServiecesSearch.Controls.Add(this.dgvService);
            this.grpServiecesSearch.ForeColor = System.Drawing.Color.White;
            this.grpServiecesSearch.Location = new System.Drawing.Point(18, 163);
            this.grpServiecesSearch.Name = "grpServiecesSearch";
            this.grpServiecesSearch.Size = new System.Drawing.Size(764, 424);
            this.grpServiecesSearch.TabIndex = 1147;
            this.grpServiecesSearch.TabStop = false;
            this.grpServiecesSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(544, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchClear.BackgroundImage")));
            this.btnSearchClear.FlatAppearance.BorderSize = 0;
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(635, 47);
            this.btnSearchClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(85, 27);
            this.btnSearchClear.TabIndex = 3;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Location = new System.Drawing.Point(544, 21);
            this.cmbCategorySearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(200, 21);
            this.cmbCategorySearch.TabIndex = 1;
            this.cmbCategorySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCategorySearch_KeyDown);
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategorySearch.Location = new System.Drawing.Point(434, 25);
            this.lblCategorySearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(49, 13);
            this.lblCategorySearch.TabIndex = 2;
            this.lblCategorySearch.Text = "Category";
            // 
            // txtServiceNameSearch
            // 
            this.txtServiceNameSearch.Location = new System.Drawing.Point(132, 21);
            this.txtServiceNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtServiceNameSearch.Name = "txtServiceNameSearch";
            this.txtServiceNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtServiceNameSearch.TabIndex = 0;
            this.txtServiceNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceNameSearch_KeyDown);
            // 
            // lblServiceNameSearch
            // 
            this.lblServiceNameSearch.AutoSize = true;
            this.lblServiceNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceNameSearch.Location = new System.Drawing.Point(14, 25);
            this.lblServiceNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblServiceNameSearch.Name = "lblServiceNameSearch";
            this.lblServiceNameSearch.Size = new System.Drawing.Size(74, 13);
            this.lblServiceNameSearch.TabIndex = 191;
            this.lblServiceNameSearch.Text = "Service Name";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToResizeColumns = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.BackgroundColor = System.Drawing.Color.White;
            this.dgvService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvService.ColumnHeadersHeight = 25;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtServiceId,
            this.Col,
            this.dgvtxtServiceName,
            this.dgvcmbCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.EnableHeadersVisualStyles = false;
            this.dgvService.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvService.Location = new System.Drawing.Point(17, 83);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(727, 323);
            this.dgvService.TabIndex = 190;
            this.dgvService.TabStop = false;
            this.dgvService.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellDoubleClick);
            this.dgvService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            this.dgvService.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvService_KeyUp);
            // 
            // dgvtxtServiceId
            // 
            this.dgvtxtServiceId.DataPropertyName = "serviceId";
            this.dgvtxtServiceId.HeaderText = "ServiceId";
            this.dgvtxtServiceId.Name = "dgvtxtServiceId";
            this.dgvtxtServiceId.ReadOnly = true;
            this.dgvtxtServiceId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtServiceId.Visible = false;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SLNO";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtServiceName
            // 
            this.dgvtxtServiceName.DataPropertyName = "serviceName";
            this.dgvtxtServiceName.HeaderText = "Service Name";
            this.dgvtxtServiceName.Name = "dgvtxtServiceName";
            this.dgvtxtServiceName.ReadOnly = true;
            this.dgvtxtServiceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbCategory
            // 
            this.dgvcmbCategory.DataPropertyName = "categoryName";
            this.dgvcmbCategory.HeaderText = "Category";
            this.dgvcmbCategory.Name = "dgvcmbCategory";
            this.dgvcmbCategory.ReadOnly = true;
            this.dgvcmbCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpServiecesSearch);
            this.Controls.Add(this.grpServiecesSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmServices";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServices_FormClosing);
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServices_KeyDown);
            this.grpServiecesSave.ResumeLayout(false);
            this.grpServiecesSave.PerformLayout();
            this.grpServiecesSearch.ResumeLayout(false);
            this.grpServiecesSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServiecesSave;
        private System.Windows.Forms.Label lblCategoryMandatory;
        private System.Windows.Forms.Label lblRateValidator;
        private System.Windows.Forms.Label lblServiceNameValidator;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpServiecesSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.ComboBox cmbCategorySearch;
        private System.Windows.Forms.Label lblCategorySearch;
        private System.Windows.Forms.TextBox txtServiceNameSearch;
        private System.Windows.Forms.Label lblServiceNameSearch;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcmbCategory;
        private System.Windows.Forms.Button btnGroupAdd;
    }
}