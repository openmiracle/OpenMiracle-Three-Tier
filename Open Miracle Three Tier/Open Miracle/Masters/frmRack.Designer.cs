namespace Open_Miracle
{
    partial class frmRack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRack));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRackNameValidator = new System.Windows.Forms.Label();
            this.lblGodownMandatory = new System.Windows.Forms.Label();
            this.cmbGodown = new System.Windows.Forms.ComboBox();
            this.lblGodown = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtRackName = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRackName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGodownSearch = new System.Windows.Forms.ComboBox();
            this.lblGodownSearch = new System.Windows.Forms.Label();
            this.txtRackNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.lblRackNameSearch = new System.Windows.Forms.Label();
            this.dgvRack = new System.Windows.Forms.DataGridView();
            this.dgvtxtRackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtRackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRackNameValidator);
            this.groupBox1.Controls.Add(this.lblGodownMandatory);
            this.groupBox1.Controls.Add(this.cmbGodown);
            this.groupBox1.Controls.Add(this.lblGodown);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.txtRackName);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblRackName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 170);
            this.groupBox1.TabIndex = 1146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rack";
            // 
            // lblRackNameValidator
            // 
            this.lblRackNameValidator.AutoSize = true;
            this.lblRackNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblRackNameValidator.Location = new System.Drawing.Point(337, 28);
            this.lblRackNameValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblRackNameValidator.Name = "lblRackNameValidator";
            this.lblRackNameValidator.Size = new System.Drawing.Size(11, 13);
            this.lblRackNameValidator.TabIndex = 159;
            this.lblRackNameValidator.Text = "*";
            // 
            // lblGodownMandatory
            // 
            this.lblGodownMandatory.AutoSize = true;
            this.lblGodownMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblGodownMandatory.Location = new System.Drawing.Point(337, 54);
            this.lblGodownMandatory.Margin = new System.Windows.Forms.Padding(5);
            this.lblGodownMandatory.Name = "lblGodownMandatory";
            this.lblGodownMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblGodownMandatory.TabIndex = 160;
            this.lblGodownMandatory.Text = "*";
            // 
            // cmbGodown
            // 
            this.cmbGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodown.FormattingEnabled = true;
            this.cmbGodown.Location = new System.Drawing.Point(132, 46);
            this.cmbGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodown.Name = "cmbGodown";
            this.cmbGodown.Size = new System.Drawing.Size(200, 21);
            this.cmbGodown.TabIndex = 1;
            this.cmbGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodown_KeyDown);
            // 
            // lblGodown
            // 
            this.lblGodown.AutoSize = true;
            this.lblGodown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodown.Location = new System.Drawing.Point(22, 50);
            this.lblGodown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(47, 13);
            this.lblGodown.TabIndex = 158;
            this.lblGodown.Text = "Godown";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(405, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(132, 72);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 2;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // txtRackName
            // 
            this.txtRackName.Location = new System.Drawing.Point(132, 21);
            this.txtRackName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRackName.Name = "txtRackName";
            this.txtRackName.Size = new System.Drawing.Size(200, 20);
            this.txtRackName.TabIndex = 0;
            this.txtRackName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRackName_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(22, 72);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 157;
            this.lblNarration.Text = "Narration";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(314, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRackName
            // 
            this.lblRackName.AutoSize = true;
            this.lblRackName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRackName.Location = new System.Drawing.Point(22, 25);
            this.lblRackName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRackName.Name = "lblRackName";
            this.lblRackName.Size = new System.Drawing.Size(64, 13);
            this.lblRackName.TabIndex = 156;
            this.lblRackName.Text = "Rack Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(132, 125);
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
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(223, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGodownSearch);
            this.groupBox2.Controls.Add(this.lblGodownSearch);
            this.groupBox2.Controls.Add(this.txtRackNameSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnSearchClear);
            this.groupBox2.Controls.Add(this.lblRackNameSearch);
            this.groupBox2.Controls.Add(this.dgvRack);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 391);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbGodownSearch
            // 
            this.cmbGodownSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodownSearch.FormattingEnabled = true;
            this.cmbGodownSearch.Location = new System.Drawing.Point(123, 44);
            this.cmbGodownSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGodownSearch.Name = "cmbGodownSearch";
            this.cmbGodownSearch.Size = new System.Drawing.Size(200, 21);
            this.cmbGodownSearch.TabIndex = 1;
            this.cmbGodownSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGodownSearch_KeyDown);
            // 
            // lblGodownSearch
            // 
            this.lblGodownSearch.AutoSize = true;
            this.lblGodownSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGodownSearch.Location = new System.Drawing.Point(15, 48);
            this.lblGodownSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGodownSearch.Name = "lblGodownSearch";
            this.lblGodownSearch.Size = new System.Drawing.Size(47, 13);
            this.lblGodownSearch.TabIndex = 153;
            this.lblGodownSearch.Text = "Godown";
            // 
            // txtRackNameSearch
            // 
            this.txtRackNameSearch.Location = new System.Drawing.Point(123, 19);
            this.txtRackNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRackNameSearch.Name = "txtRackNameSearch";
            this.txtRackNameSearch.Size = new System.Drawing.Size(200, 20);
            this.txtRackNameSearch.TabIndex = 0;
            this.txtRackNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRackNameSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(331, 38);
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
            this.btnSearchClear.Location = new System.Drawing.Point(422, 38);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(85, 27);
            this.btnSearchClear.TabIndex = 3;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // lblRackNameSearch
            // 
            this.lblRackNameSearch.AutoSize = true;
            this.lblRackNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRackNameSearch.Location = new System.Drawing.Point(13, 23);
            this.lblRackNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRackNameSearch.Name = "lblRackNameSearch";
            this.lblRackNameSearch.Size = new System.Drawing.Size(64, 13);
            this.lblRackNameSearch.TabIndex = 152;
            this.lblRackNameSearch.Text = "Rack Name";
            // 
            // dgvRack
            // 
            this.dgvRack.AllowUserToAddRows = false;
            this.dgvRack.AllowUserToDeleteRows = false;
            this.dgvRack.AllowUserToResizeColumns = false;
            this.dgvRack.AllowUserToResizeRows = false;
            this.dgvRack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRack.BackgroundColor = System.Drawing.Color.White;
            this.dgvRack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRack.ColumnHeadersHeight = 25;
            this.dgvRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtRackId,
            this.dgvtxtSlNo,
            this.dgvtxtRackName,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRack.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRack.EnableHeadersVisualStyles = false;
            this.dgvRack.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRack.Location = new System.Drawing.Point(17, 68);
            this.dgvRack.MultiSelect = false;
            this.dgvRack.Name = "dgvRack";
            this.dgvRack.ReadOnly = true;
            this.dgvRack.RowHeadersVisible = false;
            this.dgvRack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRack.Size = new System.Drawing.Size(728, 305);
            this.dgvRack.TabIndex = 151;
            this.dgvRack.TabStop = false;
            this.dgvRack.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRack_CellDoubleClick);
            this.dgvRack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRack_KeyDown);
            this.dgvRack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvRack_KeyUp);
            // 
            // dgvtxtRackId
            // 
            this.dgvtxtRackId.DataPropertyName = "rackId";
            this.dgvtxtRackId.HeaderText = "Rack Id";
            this.dgvtxtRackId.Name = "dgvtxtRackId";
            this.dgvtxtRackId.ReadOnly = true;
            this.dgvtxtRackId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtRackId.Visible = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SLNO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtRackName
            // 
            this.dgvtxtRackName.DataPropertyName = "rackName";
            this.dgvtxtRackName.HeaderText = "Rack Name";
            this.dgvtxtRackName.Name = "dgvtxtRackName";
            this.dgvtxtRackName.ReadOnly = true;
            this.dgvtxtRackName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "godownName";
            this.Column2.HeaderText = "Godown Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmRack
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
            this.Name = "frmRack";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRack_FormClosing);
            this.Load += new System.EventHandler(this.frmRack_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRack_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRackNameValidator;
        private System.Windows.Forms.Label lblGodownMandatory;
        private System.Windows.Forms.ComboBox cmbGodown;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.TextBox txtRackName;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRackName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGodownSearch;
        private System.Windows.Forms.Label lblGodownSearch;
        private System.Windows.Forms.TextBox txtRackNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label lblRackNameSearch;
        private System.Windows.Forms.DataGridView dgvRack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtRackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}