namespace Open_Miracle
{
    partial class frmServiceCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSe3rvieceCatSave = new System.Windows.Forms.GroupBox();
            this.lblServiceCategoryTypeValidator = new System.Windows.Forms.Label();
            this.txtServiceCategory = new System.Windows.Forms.TextBox();
            this.lblServiceCategory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpServieceCatDetails = new System.Windows.Forms.GroupBox();
            this.dgvServiceCategory = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtservicecategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSe3rvieceCatSave.SuspendLayout();
            this.grpServieceCatDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSe3rvieceCatSave
            // 
            this.grpSe3rvieceCatSave.Controls.Add(this.lblServiceCategoryTypeValidator);
            this.grpSe3rvieceCatSave.Controls.Add(this.txtServiceCategory);
            this.grpSe3rvieceCatSave.Controls.Add(this.lblServiceCategory);
            this.grpSe3rvieceCatSave.Controls.Add(this.btnClose);
            this.grpSe3rvieceCatSave.Controls.Add(this.txtNarration);
            this.grpSe3rvieceCatSave.Controls.Add(this.lblNarration);
            this.grpSe3rvieceCatSave.Controls.Add(this.btnDelete);
            this.grpSe3rvieceCatSave.Controls.Add(this.btnSave);
            this.grpSe3rvieceCatSave.Controls.Add(this.btnClear);
            this.grpSe3rvieceCatSave.ForeColor = System.Drawing.Color.White;
            this.grpSe3rvieceCatSave.Location = new System.Drawing.Point(18, 13);
            this.grpSe3rvieceCatSave.Name = "grpSe3rvieceCatSave";
            this.grpSe3rvieceCatSave.Size = new System.Drawing.Size(764, 142);
            this.grpSe3rvieceCatSave.TabIndex = 1146;
            this.grpSe3rvieceCatSave.TabStop = false;
            this.grpSe3rvieceCatSave.Text = "Service Category";
            // 
            // lblServiceCategoryTypeValidator
            // 
            this.lblServiceCategoryTypeValidator.AutoSize = true;
            this.lblServiceCategoryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblServiceCategoryTypeValidator.Location = new System.Drawing.Point(330, 27);
            this.lblServiceCategoryTypeValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblServiceCategoryTypeValidator.Name = "lblServiceCategoryTypeValidator";
            this.lblServiceCategoryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblServiceCategoryTypeValidator.TabIndex = 207;
            this.lblServiceCategoryTypeValidator.Text = "*";
            // 
            // txtServiceCategory
            // 
            this.txtServiceCategory.Location = new System.Drawing.Point(128, 21);
            this.txtServiceCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtServiceCategory.Name = "txtServiceCategory";
            this.txtServiceCategory.Size = new System.Drawing.Size(200, 20);
            this.txtServiceCategory.TabIndex = 0;
            this.txtServiceCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceCategory_KeyDown);
            // 
            // lblServiceCategory
            // 
            this.lblServiceCategory.AutoSize = true;
            this.lblServiceCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceCategory.Location = new System.Drawing.Point(18, 21);
            this.lblServiceCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblServiceCategory.Name = "lblServiceCategory";
            this.lblServiceCategory.Size = new System.Drawing.Size(88, 13);
            this.lblServiceCategory.TabIndex = 206;
            this.lblServiceCategory.Text = "Service Category";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(401, 101);
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
            this.txtNarration.Location = new System.Drawing.Point(128, 46);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 1;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(18, 46);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 205;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(128, 101);
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
            this.btnClear.Location = new System.Drawing.Point(219, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpServieceCatDetails
            // 
            this.grpServieceCatDetails.Controls.Add(this.dgvServiceCategory);
            this.grpServieceCatDetails.ForeColor = System.Drawing.Color.White;
            this.grpServieceCatDetails.Location = new System.Drawing.Point(18, 161);
            this.grpServieceCatDetails.Name = "grpServieceCatDetails";
            this.grpServieceCatDetails.Size = new System.Drawing.Size(764, 426);
            this.grpServieceCatDetails.TabIndex = 1147;
            this.grpServieceCatDetails.TabStop = false;
            this.grpServieceCatDetails.Text = "Details";
            // 
            // dgvServiceCategory
            // 
            this.dgvServiceCategory.AllowUserToAddRows = false;
            this.dgvServiceCategory.AllowUserToDeleteRows = false;
            this.dgvServiceCategory.AllowUserToResizeColumns = false;
            this.dgvServiceCategory.AllowUserToResizeRows = false;
            this.dgvServiceCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceCategory.ColumnHeadersHeight = 25;
            this.dgvServiceCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServiceCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtservicecategoryId,
            this.dgvtxtCategoryName,
            this.dgvtxtNarration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiceCategory.EnableHeadersVisualStyles = false;
            this.dgvServiceCategory.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvServiceCategory.Location = new System.Drawing.Point(21, 31);
            this.dgvServiceCategory.MultiSelect = false;
            this.dgvServiceCategory.Name = "dgvServiceCategory";
            this.dgvServiceCategory.ReadOnly = true;
            this.dgvServiceCategory.RowHeadersVisible = false;
            this.dgvServiceCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceCategory.Size = new System.Drawing.Size(722, 374);
            this.dgvServiceCategory.TabIndex = 8;
            this.dgvServiceCategory.TabStop = false;
            this.dgvServiceCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceCategory_CellDoubleClick);
            this.dgvServiceCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvServiceCategory_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtservicecategoryId
            // 
            this.dgvtxtservicecategoryId.DataPropertyName = "serviceCategoryId";
            this.dgvtxtservicecategoryId.HeaderText = "Service Category Id";
            this.dgvtxtservicecategoryId.Name = "dgvtxtservicecategoryId";
            this.dgvtxtservicecategoryId.ReadOnly = true;
            this.dgvtxtservicecategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtservicecategoryId.Visible = false;
            // 
            // dgvtxtCategoryName
            // 
            this.dgvtxtCategoryName.DataPropertyName = "categoryName";
            this.dgvtxtCategoryName.HeaderText = "Category Name";
            this.dgvtxtCategoryName.Name = "dgvtxtCategoryName";
            this.dgvtxtCategoryName.ReadOnly = true;
            this.dgvtxtCategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmServiceCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpServieceCatDetails);
            this.Controls.Add(this.grpSe3rvieceCatSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmServiceCategory";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServiceCategory_FormClosing);
            this.Load += new System.EventHandler(this.frmServiceCategory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServiceCategory_KeyDown);
            this.grpSe3rvieceCatSave.ResumeLayout(false);
            this.grpSe3rvieceCatSave.PerformLayout();
            this.grpServieceCatDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSe3rvieceCatSave;
        private System.Windows.Forms.Label lblServiceCategoryTypeValidator;
        private System.Windows.Forms.TextBox txtServiceCategory;
        private System.Windows.Forms.Label lblServiceCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpServieceCatDetails;
        private System.Windows.Forms.DataGridView dgvServiceCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtservicecategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
    }
}