namespace Open_Miracle
{
    partial class frmPricingLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPricingLevel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPricicnglevelValidator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtPricingLevelName = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPricingLevelName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPricingLevel = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPricingLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPricingLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricingLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPricicnglevelValidator);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.txtPricingLevelName);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblPricingLevelName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 144);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing Level";
            // 
            // lblPricicnglevelValidator
            // 
            this.lblPricicnglevelValidator.AutoSize = true;
            this.lblPricicnglevelValidator.ForeColor = System.Drawing.Color.Red;
            this.lblPricicnglevelValidator.Location = new System.Drawing.Point(330, 26);
            this.lblPricicnglevelValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPricicnglevelValidator.Name = "lblPricicnglevelValidator";
            this.lblPricicnglevelValidator.Size = new System.Drawing.Size(11, 13);
            this.lblPricicnglevelValidator.TabIndex = 123;
            this.lblPricicnglevelValidator.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 101);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(127, 46);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 1;
            
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // txtPricingLevelName
            // 
            this.txtPricingLevelName.Location = new System.Drawing.Point(127, 21);
            this.txtPricingLevelName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPricingLevelName.Name = "txtPricingLevelName";
            this.txtPricingLevelName.Size = new System.Drawing.Size(200, 20);
            this.txtPricingLevelName.TabIndex = 0;
            this.txtPricingLevelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPricingLevelName_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(17, 46);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 122;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(309, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            // 
            // lblPricingLevelName
            // 
            this.lblPricingLevelName.AutoSize = true;
            this.lblPricingLevelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricingLevelName.Location = new System.Drawing.Point(17, 25);
            this.lblPricingLevelName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPricingLevelName.Name = "lblPricingLevelName";
            this.lblPricingLevelName.Size = new System.Drawing.Size(35, 13);
            this.lblPricingLevelName.TabIndex = 121;
            this.lblPricingLevelName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 101);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 2;
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
            this.btnClear.Location = new System.Drawing.Point(218, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPricingLevel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 416);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvPricingLevel
            // 
            this.dgvPricingLevel.AllowUserToAddRows = false;
            this.dgvPricingLevel.AllowUserToDeleteRows = false;
            this.dgvPricingLevel.AllowUserToResizeColumns = false;
            this.dgvPricingLevel.AllowUserToResizeRows = false;
            this.dgvPricingLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPricingLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvPricingLevel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPricingLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPricingLevel.ColumnHeadersHeight = 25;
            this.dgvPricingLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPricingLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtPricingLevel,
            this.dgvtxtPricingLevelId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPricingLevel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPricingLevel.EnableHeadersVisualStyles = false;
            this.dgvPricingLevel.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPricingLevel.Location = new System.Drawing.Point(20, 33);
            this.dgvPricingLevel.MultiSelect = false;
            this.dgvPricingLevel.Name = "dgvPricingLevel";
            this.dgvPricingLevel.ReadOnly = true;
            this.dgvPricingLevel.RowHeadersVisible = false;
            this.dgvPricingLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPricingLevel.Size = new System.Drawing.Size(725, 366);
            this.dgvPricingLevel.TabIndex = 8;
            this.dgvPricingLevel.TabStop = false;
            this.dgvPricingLevel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPricingLevel_CellDoubleClick);
            this.dgvPricingLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPricingLevel_KeyDown);
            this.dgvPricingLevel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvPricingLevel_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPricingLevel
            // 
            this.dgvtxtPricingLevel.DataPropertyName = "pricinglevelName";
            this.dgvtxtPricingLevel.HeaderText = "Pricing Level";
            this.dgvtxtPricingLevel.Name = "dgvtxtPricingLevel";
            this.dgvtxtPricingLevel.ReadOnly = true;
            this.dgvtxtPricingLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPricingLevelId
            // 
            this.dgvtxtPricingLevelId.DataPropertyName = "pricinglevelId";
            this.dgvtxtPricingLevelId.HeaderText = "PricingLevelId";
            this.dgvtxtPricingLevelId.Name = "dgvtxtPricingLevelId";
            this.dgvtxtPricingLevelId.ReadOnly = true;
            this.dgvtxtPricingLevelId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPricingLevelId.Visible = false;
            // 
            // frmPricingLevel
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
            this.Name = "frmPricingLevel";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pricing Level";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPricingLevel_FormClosing);
            this.Load += new System.EventHandler(this.frmPricingLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPricingLevel_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricingLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPricicnglevelValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.TextBox txtPricingLevelName;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPricingLevelName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPricingLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPricingLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPricingLevelId;
    }
}