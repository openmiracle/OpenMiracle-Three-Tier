namespace Open_Miracle
{
    partial class frmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrency));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDecimalValidator = new System.Windows.Forms.Label();
            this.lblSymbolValidator = new System.Windows.Forms.Label();
            this.lblNameValidator = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDecimalPlaces = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtSubUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtSymbolSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.dgvtxtCurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtdecimalplaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDecimalValidator);
            this.groupBox1.Controls.Add(this.lblSymbolValidator);
            this.groupBox1.Controls.Add(this.lblNameValidator);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtDecimalPlaces);
            this.groupBox1.Controls.Add(this.txtSymbol);
            this.groupBox1.Controls.Add(this.txtSubUnit);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 168);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency";
            // 
            // lblDecimalValidator
            // 
            this.lblDecimalValidator.AutoSize = true;
            this.lblDecimalValidator.ForeColor = System.Drawing.Color.Red;
            this.lblDecimalValidator.Location = new System.Drawing.Point(738, 53);
            this.lblDecimalValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDecimalValidator.Name = "lblDecimalValidator";
            this.lblDecimalValidator.Size = new System.Drawing.Size(11, 13);
            this.lblDecimalValidator.TabIndex = 1163;
            this.lblDecimalValidator.Text = "*";
            // 
            // lblSymbolValidator
            // 
            this.lblSymbolValidator.AutoSize = true;
            this.lblSymbolValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSymbolValidator.Location = new System.Drawing.Point(738, 29);
            this.lblSymbolValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSymbolValidator.Name = "lblSymbolValidator";
            this.lblSymbolValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSymbolValidator.TabIndex = 1162;
            this.lblSymbolValidator.Text = "*";
            // 
            // lblNameValidator
            // 
            this.lblNameValidator.AutoSize = true;
            this.lblNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblNameValidator.Location = new System.Drawing.Point(330, 26);
            this.lblNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNameValidator.Name = "lblNameValidator";
            this.lblNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblNameValidator.TabIndex = 1161;
            this.lblNameValidator.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(295, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 7;
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
            this.btnClose.Location = new System.Drawing.Point(386, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDecimalPlaces
            // 
            this.txtDecimalPlaces.Location = new System.Drawing.Point(539, 46);
            this.txtDecimalPlaces.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDecimalPlaces.MaxLength = 1;
            this.txtDecimalPlaces.Name = "txtDecimalPlaces";
            this.txtDecimalPlaces.Size = new System.Drawing.Size(200, 20);
            this.txtDecimalPlaces.TabIndex = 3;
            this.txtDecimalPlaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDecimalPlaces_KeyDown);
            this.txtDecimalPlaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalPlaces_KeyPress);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(539, 21);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(200, 20);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymbol_KeyDown);
            // 
            // txtSubUnit
            // 
            this.txtSubUnit.Location = new System.Drawing.Point(129, 46);
            this.txtSubUnit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSubUnit.Name = "txtSubUnit";
            this.txtSubUnit.Size = new System.Drawing.Size(200, 20);
            this.txtSubUnit.TabIndex = 2;
            this.txtSubUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubUnit_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1160;
            this.label6.Text = "Narration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(418, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 1159;
            this.label5.Text = "No. of Decimal Places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1158;
            this.label4.Text = "Sub Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(418, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1157;
            this.label1.Text = "Symbol";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(129, 71);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 4;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(113, 124);
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
            this.btnClear.Location = new System.Drawing.Point(204, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1156;
            this.label3.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnClearSearch);
            this.groupBox2.Controls.Add(this.txtSymbolSearch);
            this.groupBox2.Controls.Add(this.txtNameSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvCurrency);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 390);
            this.groupBox2.TabIndex = 1165;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(540, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
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
            this.btnClearSearch.Location = new System.Drawing.Point(631, 37);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(85, 27);
            this.btnClearSearch.TabIndex = 3;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            this.btnClearSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClearSearch_KeyDown);
            // 
            // txtSymbolSearch
            // 
            this.txtSymbolSearch.Location = new System.Drawing.Point(539, 14);
            this.txtSymbolSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSymbolSearch.Name = "txtSymbolSearch";
            this.txtSymbolSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSymbolSearch.TabIndex = 1;
            this.txtSymbolSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymbolSearch_KeyDown);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(129, 14);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtNameSearch.TabIndex = 0;
            this.txtNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameSearch_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(429, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 143;
            this.label7.Text = "Symbol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(19, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 142;
            this.label8.Text = "Name";
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AllowUserToDeleteRows = false;
            this.dgvCurrency.AllowUserToResizeColumns = false;
            this.dgvCurrency.AllowUserToResizeRows = false;
            this.dgvCurrency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrency.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrency.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrency.ColumnHeadersHeight = 25;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtCurrencyId,
            this.SlNo,
            this.dgvtxtName,
            this.dgvtxtSymbol,
            this.dgvtxtdecimalplaces});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(231)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrency.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrency.EnableHeadersVisualStyles = false;
            this.dgvCurrency.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCurrency.Location = new System.Drawing.Point(22, 70);
            this.dgvCurrency.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCurrency.MultiSelect = false;
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.RowHeadersVisible = false;
            this.dgvCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrency.Size = new System.Drawing.Size(720, 299);
            this.dgvCurrency.TabIndex = 141;
            this.dgvCurrency.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_CellDoubleClick);
            // 
            // dgvtxtCurrencyId
            // 
            this.dgvtxtCurrencyId.DataPropertyName = "currencyId";
            this.dgvtxtCurrencyId.HeaderText = "CurrencyId";
            this.dgvtxtCurrencyId.Name = "dgvtxtCurrencyId";
            this.dgvtxtCurrencyId.ReadOnly = true;
            this.dgvtxtCurrencyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrencyId.Visible = false;
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SL.NO";
            this.SlNo.HeaderText = "Sl No";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.DataPropertyName = "currencyName";
            this.dgvtxtName.HeaderText = "Name";
            this.dgvtxtName.Name = "dgvtxtName";
            this.dgvtxtName.ReadOnly = true;
            this.dgvtxtName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSymbol
            // 
            this.dgvtxtSymbol.DataPropertyName = "currencySymbol";
            this.dgvtxtSymbol.HeaderText = "Symbol";
            this.dgvtxtSymbol.Name = "dgvtxtSymbol";
            this.dgvtxtSymbol.ReadOnly = true;
            this.dgvtxtSymbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtdecimalplaces
            // 
            this.dgvtxtdecimalplaces.DataPropertyName = "noofDecimalPlaces";
            this.dgvtxtdecimalplaces.HeaderText = "No. of Decimal Places";
            this.dgvtxtdecimalplaces.Name = "dgvtxtdecimalplaces";
            this.dgvtxtdecimalplaces.ReadOnly = true;
            this.dgvtxtdecimalplaces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCurrency";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCurrency_FormClosing);
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCurrency_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDecimalValidator;
        private System.Windows.Forms.Label lblSymbolValidator;
        private System.Windows.Forms.Label lblNameValidator;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDecimalPlaces;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtSubUnit;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox txtSymbolSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtdecimalplaces;

    }
}