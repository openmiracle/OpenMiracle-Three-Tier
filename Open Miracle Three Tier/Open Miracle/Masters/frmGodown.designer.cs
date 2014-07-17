namespace Open_Miracle
{
    partial class frmGodown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGodown));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGodownTypeValidator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtGodownName = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGodownName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGodown = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGodownId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGodownName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGodownTypeValidator);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.txtGodownName);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblGodownName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 146);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Godown";
            // 
            // lblGodownTypeValidator
            // 
            this.lblGodownTypeValidator.AutoSize = true;
            this.lblGodownTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblGodownTypeValidator.Location = new System.Drawing.Point(332, 25);
            this.lblGodownTypeValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodownTypeValidator.Name = "lblGodownTypeValidator";
            this.lblGodownTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblGodownTypeValidator.TabIndex = 139;
            this.lblGodownTypeValidator.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(403, 101);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(130, 46);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 1;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // txtGodownName
            // 
            this.txtGodownName.Location = new System.Drawing.Point(130, 21);
            this.txtGodownName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtGodownName.Name = "txtGodownName";
            this.txtGodownName.Size = new System.Drawing.Size(200, 20);
            this.txtGodownName.TabIndex = 0;
            this.txtGodownName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGodownName_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(15, 46);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 138;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(312, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // lblGodownName
            // 
            this.lblGodownName.AutoSize = true;
            this.lblGodownName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodownName.Location = new System.Drawing.Point(15, 25);
            this.lblGodownName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodownName.Name = "lblGodownName";
            this.lblGodownName.Size = new System.Drawing.Size(78, 13);
            this.lblGodownName.TabIndex = 137;
            this.lblGodownName.Text = "Godown Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(130, 101);
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
            this.btnClear.Location = new System.Drawing.Point(221, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGodown);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 275);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvGodown
            // 
            this.dgvGodown.AllowUserToAddRows = false;
            this.dgvGodown.AllowUserToDeleteRows = false;
            this.dgvGodown.AllowUserToResizeColumns = false;
            this.dgvGodown.AllowUserToResizeRows = false;
            this.dgvGodown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGodown.BackgroundColor = System.Drawing.Color.White;
            this.dgvGodown.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGodown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGodown.ColumnHeadersHeight = 25;
            this.dgvGodown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGodown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtGodownId,
            this.dgvtxtGodownName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGodown.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGodown.EnableHeadersVisualStyles = false;
            this.dgvGodown.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGodown.Location = new System.Drawing.Point(18, 24);
            this.dgvGodown.MultiSelect = false;
            this.dgvGodown.Name = "dgvGodown";
            this.dgvGodown.ReadOnly = true;
            this.dgvGodown.RowHeadersVisible = false;
            this.dgvGodown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGodown.Size = new System.Drawing.Size(728, 236);
            this.dgvGodown.TabIndex = 8;
            this.dgvGodown.TabStop = false;
            this.dgvGodown.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGodown_CellDoubleClick);
            this.dgvGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGodown_KeyDown);
            this.dgvGodown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvGodown_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtGodownId
            // 
            this.dgvtxtGodownId.DataPropertyName = "godownId";
            this.dgvtxtGodownId.HeaderText = "Godown ID";
            this.dgvtxtGodownId.Name = "dgvtxtGodownId";
            this.dgvtxtGodownId.ReadOnly = true;
            this.dgvtxtGodownId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtGodownId.Visible = false;
            // 
            // dgvtxtGodownName
            // 
            this.dgvtxtGodownName.DataPropertyName = "godownName";
            this.dgvtxtGodownName.HeaderText = "Godown Name";
            this.dgvtxtGodownName.Name = "dgvtxtGodownName";
            this.dgvtxtGodownName.ReadOnly = true;
            this.dgvtxtGodownName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmGodown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmGodown";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Godown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGodown_FormClosing);
            this.Load += new System.EventHandler(this.frmGodown_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGodown_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGodownTypeValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.TextBox txtGodownName;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGodownName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGodown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGodownId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGodownName;
    }
}