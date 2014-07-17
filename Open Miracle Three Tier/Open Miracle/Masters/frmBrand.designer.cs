namespace Open_Miracle
{
    partial class frmBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrand));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblManufacturerValidator = new System.Windows.Forms.Label();
            this.lblBrandNameValidator = new System.Windows.Forms.Label();
            this.lblManufacturerMandatory = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrandNameSearch = new System.Windows.Forms.TextBox();
            this.lblBrandNameSearch = new System.Windows.Forms.Label();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.dgvtxtBrandid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblManufacturerValidator);
            this.groupBox1.Controls.Add(this.lblBrandNameValidator);
            this.groupBox1.Controls.Add(this.lblManufacturerMandatory);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.lblManufacturer);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.lblBrandName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master";
            // 
            // lblManufacturerValidator
            // 
            this.lblManufacturerValidator.AutoSize = true;
            this.lblManufacturerValidator.ForeColor = System.Drawing.Color.Red;
            this.lblManufacturerValidator.Location = new System.Drawing.Point(332, 50);
            this.lblManufacturerValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblManufacturerValidator.Name = "lblManufacturerValidator";
            this.lblManufacturerValidator.Size = new System.Drawing.Size(11, 13);
            this.lblManufacturerValidator.TabIndex = 128;
            this.lblManufacturerValidator.Text = "*";
            // 
            // lblBrandNameValidator
            // 
            this.lblBrandNameValidator.AutoSize = true;
            this.lblBrandNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblBrandNameValidator.Location = new System.Drawing.Point(332, 25);
            this.lblBrandNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBrandNameValidator.Name = "lblBrandNameValidator";
            this.lblBrandNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblBrandNameValidator.TabIndex = 127;
            this.lblBrandNameValidator.Text = "*";
            // 
            // lblManufacturerMandatory
            // 
            this.lblManufacturerMandatory.AutoSize = true;
            this.lblManufacturerMandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblManufacturerMandatory.Location = new System.Drawing.Point(332, 55);
            this.lblManufacturerMandatory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblManufacturerMandatory.Name = "lblManufacturerMandatory";
            this.lblManufacturerMandatory.Size = new System.Drawing.Size(0, 15);
            this.lblManufacturerMandatory.TabIndex = 126;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(127, 46);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(200, 20);
            this.txtManufacturer.TabIndex = 1;
            this.txtManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManufacturer_KeyDown);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManufacturer.Location = new System.Drawing.Point(17, 50);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 125;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
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
            this.btnDelete.Location = new System.Drawing.Point(309, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(127, 21);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(200, 20);
            this.txtBrandName.TabIndex = 0;
            this.txtBrandName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandName_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(17, 71);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 124;
            this.lblNarration.Text = "Narration";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrandName.Location = new System.Drawing.Point(17, 25);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(35, 13);
            this.lblBrandName.TabIndex = 123;
            this.lblBrandName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(218, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(127, 71);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 85);
            this.txtNarration.TabIndex = 2;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBrandNameSearch);
            this.groupBox2.Controls.Add(this.lblBrandNameSearch);
            this.groupBox2.Controls.Add(this.dgvBrand);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 331);
            this.groupBox2.TabIndex = 1148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtBrandNameSearch
            // 
            this.txtBrandNameSearch.Location = new System.Drawing.Point(127, 21);
            this.txtBrandNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtBrandNameSearch.Name = "txtBrandNameSearch";
            this.txtBrandNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtBrandNameSearch.TabIndex = 7;
            this.txtBrandNameSearch.TextChanged += new System.EventHandler(this.txtBrandNameSearch_TextChanged);
            this.txtBrandNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandNameSearch_KeyDown);
            // 
            // lblBrandNameSearch
            // 
            this.lblBrandNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrandNameSearch.Location = new System.Drawing.Point(17, 21);
            this.lblBrandNameSearch.Margin = new System.Windows.Forms.Padding(5);
            this.lblBrandNameSearch.Name = "lblBrandNameSearch";
            this.lblBrandNameSearch.Size = new System.Drawing.Size(100, 20);
            this.lblBrandNameSearch.TabIndex = 71;
            this.lblBrandNameSearch.Text = "Name";
            // 
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToAddRows = false;
            this.dgvBrand.AllowUserToDeleteRows = false;
            this.dgvBrand.AllowUserToResizeColumns = false;
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.White;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.ColumnHeadersHeight = 25;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtBrandid,
            this.Col,
            this.Column1,
            this.Column2,
            this.Narration});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBrand.Location = new System.Drawing.Point(20, 49);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersVisible = false;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.Size = new System.Drawing.Size(722, 266);
            this.dgvBrand.TabIndex = 50;
            this.dgvBrand.TabStop = false;
            this.dgvBrand.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellDoubleClick);
            this.dgvBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBrand_KeyDown);
            this.dgvBrand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvBrand_KeyUp);
            // 
            // dgvtxtBrandid
            // 
            this.dgvtxtBrandid.DataPropertyName = "brandId";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtBrandid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBrandid.HeaderText = "BrandId";
            this.dgvtxtBrandid.Name = "dgvtxtBrandid";
            this.dgvtxtBrandid.ReadOnly = true;
            this.dgvtxtBrandid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBrandid.Visible = false;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "SLNO";
            this.Col.HeaderText = "Sl No";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "brandName";
            this.Column1.HeaderText = "Brand Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "manufacturer";
            this.Column2.HeaderText = "Manufacturer";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Narration
            // 
            this.Narration.DataPropertyName = "narration";
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.ReadOnly = true;
            this.Narration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Narration.Visible = false;
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(796, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBrand";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrand_FormClosing);
            this.Load += new System.EventHandler(this.frmBrand_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBrand_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblManufacturerValidator;
        private System.Windows.Forms.Label lblBrandNameValidator;
        private System.Windows.Forms.Label lblManufacturerMandatory;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrandNameSearch;
        private System.Windows.Forms.Label lblBrandNameSearch;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBrandid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narration;
    }
}