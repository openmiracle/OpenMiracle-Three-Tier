namespace Open_Miracle
{
    partial class frmSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSize));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblProductSize = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
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
            this.btnDelete.Location = new System.Drawing.Point(309, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(127, 15);
            this.txtSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 0;
            this.txtSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSize_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(16, 40);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 48;
            this.lblNarration.Text = "Narration";
            // 
            // lblProductSize
            // 
            this.lblProductSize.AutoSize = true;
            this.lblProductSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductSize.Location = new System.Drawing.Point(17, 19);
            this.lblProductSize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductSize.Name = "lblProductSize";
            this.lblProductSize.Size = new System.Drawing.Size(27, 13);
            this.lblProductSize.TabIndex = 45;
            this.lblProductSize.Text = "Size";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 120);
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
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(218, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AllowUserToDeleteRows = false;
            this.dgvSize.AllowUserToResizeColumns = false;
            this.dgvSize.AllowUserToResizeRows = false;
            this.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSize.BackgroundColor = System.Drawing.Color.White;
            this.dgvSize.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSize.ColumnHeadersHeight = 25;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtsizeId,
            this.dgvtxtsize});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSize.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSize.EnableHeadersVisualStyles = false;
            this.dgvSize.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSize.Location = new System.Drawing.Point(18, 153);
            this.dgvSize.MultiSelect = false;
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.RowHeadersVisible = false;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(764, 434);
            this.dgvSize.TabIndex = 7;
            this.dgvSize.TabStop = false;
            this.dgvSize.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSize_CellDoubleClick);
            this.dgvSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSize_KeyDown);
            this.dgvSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvSize_KeyUp);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(127, 40);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 77);
            this.txtNarration.TabIndex = 1;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(332, 19);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 114;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "Sl.No";
            this.dgvtxtslno.HeaderText = "Sl No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtsizeId
            // 
            this.dgvtxtsizeId.DataPropertyName = "sizeId";
            this.dgvtxtsizeId.HeaderText = "Size Id";
            this.dgvtxtsizeId.Name = "dgvtxtsizeId";
            this.dgvtxtsizeId.ReadOnly = true;
            this.dgvtxtsizeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtsizeId.Visible = false;
            // 
            // dgvtxtsize
            // 
            this.dgvtxtsize.DataPropertyName = "size";
            this.dgvtxtsize.HeaderText = "Size";
            this.dgvtxtsize.Name = "dgvtxtsize";
            this.dgvtxtsize.ReadOnly = true;
            this.dgvtxtsize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblProductSize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSize);
            this.Controls.Add(this.txtNarration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSize";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSize_FormClosing);
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSize_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblProductSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsizeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtsize;
    }
}