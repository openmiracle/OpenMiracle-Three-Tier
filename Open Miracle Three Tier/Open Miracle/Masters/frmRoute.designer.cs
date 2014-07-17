namespace Open_Miracle
{
    partial class frmRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoute));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAreaAdd = new System.Windows.Forms.Button();
            this.lblAreaValidator = new System.Windows.Forms.Label();
            this.lbRouteNameValidator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRouteNameSearch = new System.Windows.Forms.TextBox();
            this.lblAreaSearch = new System.Windows.Forms.Label();
            this.cmbAreaSearch = new System.Windows.Forms.ComboBox();
            this.lblRouteNameSearch = new System.Windows.Forms.Label();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRouteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAreaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAreaAdd);
            this.groupBox1.Controls.Add(this.lblAreaValidator);
            this.groupBox1.Controls.Add(this.lbRouteNameValidator);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtRouteName);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.cmbArea);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.lblRouteName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 171);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Route";
            // 
            // btnAreaAdd
            // 
            this.btnAreaAdd.BackgroundImage = global::Open_Miracle.Properties.Resources.button_add;
            this.btnAreaAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAreaAdd.FlatAppearance.BorderSize = 0;
            this.btnAreaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaAdd.Location = new System.Drawing.Point(344, 46);
            this.btnAreaAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnAreaAdd.Name = "btnAreaAdd";
            this.btnAreaAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAreaAdd.TabIndex = 2;
            this.btnAreaAdd.UseVisualStyleBackColor = true;
            this.btnAreaAdd.Click += new System.EventHandler(this.btnAreaAdd_Click);
            // 
            // lblAreaValidator
            // 
            this.lblAreaValidator.AutoSize = true;
            this.lblAreaValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAreaValidator.Location = new System.Drawing.Point(329, 53);
            this.lblAreaValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAreaValidator.Name = "lblAreaValidator";
            this.lblAreaValidator.Size = new System.Drawing.Size(11, 13);
            this.lblAreaValidator.TabIndex = 369;
            this.lblAreaValidator.Text = "*";
            // 
            // lbRouteNameValidator
            // 
            this.lbRouteNameValidator.AutoSize = true;
            this.lbRouteNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lbRouteNameValidator.Location = new System.Drawing.Point(329, 28);
            this.lbRouteNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lbRouteNameValidator.Name = "lbRouteNameValidator";
            this.lbRouteNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lbRouteNameValidator.TabIndex = 368;
            this.lbRouteNameValidator.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 127);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
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
            this.btnDelete.Location = new System.Drawing.Point(309, 127);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(218, 127);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(127, 21);
            this.txtRouteName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(200, 20);
            this.txtRouteName.TabIndex = 0;
            this.txtRouteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRouteName_KeyDown);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(17, 50);
            this.lblArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 367;
            this.lblArea.Text = "Area";
            // 
            // cmbArea
            // 
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(127, 46);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(200, 21);
            this.cmbArea.TabIndex = 1;
            this.cmbArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArea_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 127);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(17, 72);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 366;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(127, 72);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 3;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRouteName.Location = new System.Drawing.Point(17, 25);
            this.lblRouteName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(67, 13);
            this.lblRouteName.TabIndex = 365;
            this.lblRouteName.Text = "Route Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtRouteNameSearch);
            this.groupBox2.Controls.Add(this.lblAreaSearch);
            this.groupBox2.Controls.Add(this.cmbAreaSearch);
            this.groupBox2.Controls.Add(this.lblRouteNameSearch);
            this.groupBox2.Controls.Add(this.dgvRoute);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 397);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.BackgroundImage")));
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(218, 47);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(85, 27);
            this.btnClearSearch.TabIndex = 3;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            this.btnClearSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClearSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(127, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // txtRouteNameSearch
            // 
            this.txtRouteNameSearch.Location = new System.Drawing.Point(127, 21);
            this.txtRouteNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRouteNameSearch.Name = "txtRouteNameSearch";
            this.txtRouteNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtRouteNameSearch.TabIndex = 0;
            this.txtRouteNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRouteNameSearch_KeyDown);
            // 
            // lblAreaSearch
            // 
            this.lblAreaSearch.AutoSize = true;
            this.lblAreaSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAreaSearch.Location = new System.Drawing.Point(433, 23);
            this.lblAreaSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAreaSearch.Name = "lblAreaSearch";
            this.lblAreaSearch.Size = new System.Drawing.Size(29, 13);
            this.lblAreaSearch.TabIndex = 358;
            this.lblAreaSearch.Text = "Area";
            // 
            // cmbAreaSearch
            // 
            this.cmbAreaSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAreaSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaSearch.FormattingEnabled = true;
            this.cmbAreaSearch.Location = new System.Drawing.Point(543, 20);
            this.cmbAreaSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAreaSearch.Name = "cmbAreaSearch";
            this.cmbAreaSearch.Size = new System.Drawing.Size(200, 21);
            this.cmbAreaSearch.TabIndex = 1;
            this.cmbAreaSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAreaSearch_KeyDown);
            // 
            // lblRouteNameSearch
            // 
            this.lblRouteNameSearch.AutoSize = true;
            this.lblRouteNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRouteNameSearch.Location = new System.Drawing.Point(17, 25);
            this.lblRouteNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRouteNameSearch.Name = "lblRouteNameSearch";
            this.lblRouteNameSearch.Size = new System.Drawing.Size(67, 13);
            this.lblRouteNameSearch.TabIndex = 357;
            this.lblRouteNameSearch.Text = "Route Name";
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.AllowUserToResizeColumns = false;
            this.dgvRoute.AllowUserToResizeRows = false;
            this.dgvRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoute.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoute.ColumnHeadersHeight = 25;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtRouteId,
            this.dgvtxtRouteName,
            this.dgvtxtAreaName,
            this.dgvtxtAreaId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoute.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoute.EnableHeadersVisualStyles = false;
            this.dgvRoute.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRoute.Location = new System.Drawing.Point(20, 77);
            this.dgvRoute.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvRoute.MultiSelect = false;
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.ReadOnly = true;
            this.dgvRoute.RowHeadersVisible = false;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.Size = new System.Drawing.Size(723, 302);
            this.dgvRoute.TabIndex = 356;
            this.dgvRoute.TabStop = false;
            this.dgvRoute.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoute_CellDoubleClick);
            this.dgvRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRoute_KeyDown);
            this.dgvRoute.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvRoute_KeyUp);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Sl No";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRouteId
            // 
            this.dgvtxtRouteId.DataPropertyName = "routeId";
            this.dgvtxtRouteId.HeaderText = "RouteId";
            this.dgvtxtRouteId.Name = "dgvtxtRouteId";
            this.dgvtxtRouteId.ReadOnly = true;
            this.dgvtxtRouteId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRouteId.Visible = false;
            // 
            // dgvtxtRouteName
            // 
            this.dgvtxtRouteName.DataPropertyName = "routeName";
            this.dgvtxtRouteName.HeaderText = "Route Name";
            this.dgvtxtRouteName.Name = "dgvtxtRouteName";
            this.dgvtxtRouteName.ReadOnly = true;
            this.dgvtxtRouteName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAreaName
            // 
            this.dgvtxtAreaName.DataPropertyName = "areaName";
            this.dgvtxtAreaName.HeaderText = "Area";
            this.dgvtxtAreaName.Name = "dgvtxtAreaName";
            this.dgvtxtAreaName.ReadOnly = true;
            this.dgvtxtAreaName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAreaId
            // 
            this.dgvtxtAreaId.DataPropertyName = "areaId";
            this.dgvtxtAreaId.HeaderText = "AreaId";
            this.dgvtxtAreaId.Name = "dgvtxtAreaId";
            this.dgvtxtAreaId.ReadOnly = true;
            this.dgvtxtAreaId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAreaId.Visible = false;
            // 
            // frmRoute
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
            this.Name = "frmRoute";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoute_FormClosing);
            this.Load += new System.EventHandler(this.frmRoute_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoute_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAreaAdd;
        private System.Windows.Forms.Label lblAreaValidator;
        private System.Windows.Forms.Label lbRouteNameValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRouteNameSearch;
        private System.Windows.Forms.Label lblAreaSearch;
        private System.Windows.Forms.ComboBox cmbAreaSearch;
        private System.Windows.Forms.Label lblRouteNameSearch;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRouteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAreaId;
    }
}