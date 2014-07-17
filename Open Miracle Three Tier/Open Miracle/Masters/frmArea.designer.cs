namespace Open_Miracle
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAreaNameValidator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAreaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAreaNameValidator);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtAreaName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 145);
            this.groupBox1.TabIndex = 1147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area";
            // 
            // lblAreaNameValidator
            // 
            this.lblAreaNameValidator.AutoSize = true;
            this.lblAreaNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAreaNameValidator.Location = new System.Drawing.Point(334, 26);
            this.lblAreaNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAreaNameValidator.Name = "lblAreaNameValidator";
            this.lblAreaNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblAreaNameValidator.TabIndex = 369;
            this.lblAreaNameValidator.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(402, 104);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
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
            this.btnDelete.Location = new System.Drawing.Point(311, 104);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
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
            this.btnClear.Location = new System.Drawing.Point(220, 104);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(129, 21);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(200, 20);
            this.txtAreaName.TabIndex = 0;
            this.txtAreaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAreaName_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(129, 104);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(19, 46);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 368;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(129, 46);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 1;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(19, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 367;
            this.lblName.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvArea);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 423);
            this.groupBox2.TabIndex = 1148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AllowUserToResizeColumns = false;
            this.dgvArea.AllowUserToResizeRows = false;
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.BackgroundColor = System.Drawing.Color.White;
            this.dgvArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArea.ColumnHeadersHeight = 25;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtarea,
            this.dgvtxtAreaId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArea.EnableHeadersVisualStyles = false;
            this.dgvArea.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvArea.Location = new System.Drawing.Point(18, 26);
            this.dgvArea.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvArea.MultiSelect = false;
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersVisible = false;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(728, 377);
            this.dgvArea.TabIndex = 8;
            this.dgvArea.TabStop = false;
            this.dgvArea.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellDoubleClick);
            this.dgvArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvArea_KeyDown);
            this.dgvArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvArea_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "Sl.No";
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtarea
            // 
            this.dgvtxtarea.DataPropertyName = "areaName";
            this.dgvtxtarea.HeaderText = "Area";
            this.dgvtxtarea.Name = "dgvtxtarea";
            this.dgvtxtarea.ReadOnly = true;
            this.dgvtxtarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAreaId
            // 
            this.dgvtxtAreaId.DataPropertyName = "areaId";
            this.dgvtxtAreaId.HeaderText = "Area Id";
            this.dgvtxtAreaId.Name = "dgvtxtAreaId";
            this.dgvtxtAreaId.ReadOnly = true;
            this.dgvtxtAreaId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAreaId.Visible = false;
            // 
            // frmArea
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
            this.Name = "frmArea";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArea_FormClosing);
            this.Load += new System.EventHandler(this.frmArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArea_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAreaNameValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAreaId;
    }
}