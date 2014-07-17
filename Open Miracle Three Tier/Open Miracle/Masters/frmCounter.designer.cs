namespace Open_Miracle
{
    partial class frmCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCounter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCounterTypeValidator = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtCounterName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblCounterName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCounter = new System.Windows.Forms.DataGridView();
            this.dgvtxtslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtcounterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCounterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCounterTypeValidator);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.txtCounterName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.lblCounterName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 145);
            this.groupBox1.TabIndex = 1147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counter";
            // 
            // lblCounterTypeValidator
            // 
            this.lblCounterTypeValidator.AutoSize = true;
            this.lblCounterTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblCounterTypeValidator.Location = new System.Drawing.Point(330, 27);
            this.lblCounterTypeValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCounterTypeValidator.Name = "lblCounterTypeValidator";
            this.lblCounterTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblCounterTypeValidator.TabIndex = 359;
            this.lblCounterTypeValidator.Text = "*";
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
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(18, 46);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 358;
            this.lblNarration.Text = "Narration";
            // 
            // txtCounterName
            // 
            this.txtCounterName.Location = new System.Drawing.Point(128, 21);
            this.txtCounterName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCounterName.Name = "txtCounterName";
            this.txtCounterName.Size = new System.Drawing.Size(200, 20);
            this.txtCounterName.TabIndex = 0;
            this.txtCounterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCounterName_KeyDown);
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
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
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
            // lblCounterName
            // 
            this.lblCounterName.AutoSize = true;
            this.lblCounterName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCounterName.Location = new System.Drawing.Point(18, 21);
            this.lblCounterName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCounterName.Name = "lblCounterName";
            this.lblCounterName.Size = new System.Drawing.Size(75, 13);
            this.lblCounterName.TabIndex = 357;
            this.lblCounterName.Text = "Counter Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCounter);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 423);
            this.groupBox2.TabIndex = 1148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvCounter
            // 
            this.dgvCounter.AllowUserToAddRows = false;
            this.dgvCounter.AllowUserToDeleteRows = false;
            this.dgvCounter.AllowUserToResizeColumns = false;
            this.dgvCounter.AllowUserToResizeRows = false;
            this.dgvCounter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCounter.BackgroundColor = System.Drawing.Color.White;
            this.dgvCounter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCounter.ColumnHeadersHeight = 25;
            this.dgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtslno,
            this.dgvtxtcounterId,
            this.dgvtxtCounterName});
            this.dgvCounter.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCounter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCounter.EnableHeadersVisualStyles = false;
            this.dgvCounter.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCounter.Location = new System.Drawing.Point(16, 24);
            this.dgvCounter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvCounter.MultiSelect = false;
            this.dgvCounter.Name = "dgvCounter";
            this.dgvCounter.ReadOnly = true;
            this.dgvCounter.RowHeadersVisible = false;
            this.dgvCounter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCounter.ShowCellErrors = false;
            this.dgvCounter.Size = new System.Drawing.Size(732, 383);
            this.dgvCounter.TabIndex = 8;
            this.dgvCounter.TabStop = false;
            this.dgvCounter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCounter_CellDoubleClick);
            this.dgvCounter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCounter_KeyDown);
            this.dgvCounter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCounter_KeyUp);
            // 
            // dgvtxtslno
            // 
            this.dgvtxtslno.DataPropertyName = "sl.no";
            this.dgvtxtslno.HeaderText = "Sl.No";
            this.dgvtxtslno.Name = "dgvtxtslno";
            this.dgvtxtslno.ReadOnly = true;
            this.dgvtxtslno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtcounterId
            // 
            this.dgvtxtcounterId.DataPropertyName = "counterId";
            this.dgvtxtcounterId.HeaderText = "CounterId";
            this.dgvtxtcounterId.Name = "dgvtxtcounterId";
            this.dgvtxtcounterId.ReadOnly = true;
            this.dgvtxtcounterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtcounterId.Visible = false;
            // 
            // dgvtxtCounterName
            // 
            this.dgvtxtCounterName.DataPropertyName = "counterName";
            this.dgvtxtCounterName.HeaderText = "Counter Name";
            this.dgvtxtCounterName.Name = "dgvtxtCounterName";
            this.dgvtxtCounterName.ReadOnly = true;
            this.dgvtxtCounterName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmCounter
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
            this.Name = "frmCounter";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCounter_FormClosing);
            this.Load += new System.EventHandler(this.frmCounter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCounter_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCounterTypeValidator;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtCounterName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label lblCounterName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtcounterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCounterName;
    }
}