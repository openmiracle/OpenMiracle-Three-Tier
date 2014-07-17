namespace Open_Miracle
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNooFDecimalPlacesMandatory = new System.Windows.Forms.Label();
            this.lblFormalNameMandatory = new System.Windows.Forms.Label();
            this.lblUnitNameMandatory = new System.Windows.Forms.Label();
            this.txtDecimalPlaces = new System.Windows.Forms.TextBox();
            this.lblDecimalPlace = new System.Windows.Forms.Label();
            this.txtFormalName = new System.Windows.Forms.TextBox();
            this.lblFormalName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUnitname = new System.Windows.Forms.TextBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblUnitname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnitSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUnitSearch = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNoOfDecimalPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtformalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNooFDecimalPlacesMandatory);
            this.groupBox1.Controls.Add(this.lblFormalNameMandatory);
            this.groupBox1.Controls.Add(this.lblUnitNameMandatory);
            this.groupBox1.Controls.Add(this.txtDecimalPlaces);
            this.groupBox1.Controls.Add(this.lblDecimalPlace);
            this.groupBox1.Controls.Add(this.txtFormalName);
            this.groupBox1.Controls.Add(this.lblFormalName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtUnitname);
            this.groupBox1.Controls.Add(this.lblNarration);
            this.groupBox1.Controls.Add(this.lblUnitname);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // lblNooFDecimalPlacesMandatory
            // 
            this.lblNooFDecimalPlacesMandatory.AutoSize = true;
            this.lblNooFDecimalPlacesMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblNooFDecimalPlacesMandatory.Location = new System.Drawing.Point(340, 78);
            this.lblNooFDecimalPlacesMandatory.Margin = new System.Windows.Forms.Padding(5);
            this.lblNooFDecimalPlacesMandatory.Name = "lblNooFDecimalPlacesMandatory";
            this.lblNooFDecimalPlacesMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblNooFDecimalPlacesMandatory.TabIndex = 127;
            this.lblNooFDecimalPlacesMandatory.Text = "*";
            // 
            // lblFormalNameMandatory
            // 
            this.lblFormalNameMandatory.AutoSize = true;
            this.lblFormalNameMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblFormalNameMandatory.Location = new System.Drawing.Point(340, 51);
            this.lblFormalNameMandatory.Margin = new System.Windows.Forms.Padding(5);
            this.lblFormalNameMandatory.Name = "lblFormalNameMandatory";
            this.lblFormalNameMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblFormalNameMandatory.TabIndex = 128;
            this.lblFormalNameMandatory.Text = "*";
            // 
            // lblUnitNameMandatory
            // 
            this.lblUnitNameMandatory.AutoSize = true;
            this.lblUnitNameMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblUnitNameMandatory.Location = new System.Drawing.Point(340, 28);
            this.lblUnitNameMandatory.Margin = new System.Windows.Forms.Padding(5);
            this.lblUnitNameMandatory.Name = "lblUnitNameMandatory";
            this.lblUnitNameMandatory.Size = new System.Drawing.Size(11, 13);
            this.lblUnitNameMandatory.TabIndex = 129;
            this.lblUnitNameMandatory.Text = "*";
            // 
            // txtDecimalPlaces
            // 
            this.txtDecimalPlaces.Location = new System.Drawing.Point(130, 71);
            this.txtDecimalPlaces.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDecimalPlaces.MaxLength = 1;
            this.txtDecimalPlaces.Name = "txtDecimalPlaces";
            this.txtDecimalPlaces.ShortcutsEnabled = false;
            this.txtDecimalPlaces.Size = new System.Drawing.Size(200, 20);
            this.txtDecimalPlaces.TabIndex = 2;
            this.txtDecimalPlaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDecimalPlaces_KeyDown);
            this.txtDecimalPlaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalPlaces_KeyPress);
            // 
            // lblDecimalPlace
            // 
            this.lblDecimalPlace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDecimalPlace.Location = new System.Drawing.Point(20, 71);
            this.lblDecimalPlace.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDecimalPlace.Name = "lblDecimalPlace";
            this.lblDecimalPlace.Size = new System.Drawing.Size(111, 20);
            this.lblDecimalPlace.TabIndex = 126;
            this.lblDecimalPlace.Text = "No. of Decimal Place";
            // 
            // txtFormalName
            // 
            this.txtFormalName.Location = new System.Drawing.Point(130, 46);
            this.txtFormalName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFormalName.Name = "txtFormalName";
            this.txtFormalName.Size = new System.Drawing.Size(200, 20);
            this.txtFormalName.TabIndex = 1;
            this.txtFormalName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormalName_KeyDown);
            // 
            // lblFormalName
            // 
            this.lblFormalName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFormalName.Location = new System.Drawing.Point(20, 46);
            this.lblFormalName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFormalName.Name = "lblFormalName";
            this.lblFormalName.Size = new System.Drawing.Size(100, 20);
            this.lblFormalName.TabIndex = 125;
            this.lblFormalName.Text = "Formal Name";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(403, 184);
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
            this.btnDelete.Location = new System.Drawing.Point(312, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUnitname
            // 
            this.txtUnitname.Location = new System.Drawing.Point(130, 21);
            this.txtUnitname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtUnitname.Name = "txtUnitname";
            this.txtUnitname.Size = new System.Drawing.Size(200, 20);
            this.txtUnitname.TabIndex = 0;
            this.txtUnitname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitname_KeyDown);
            // 
            // lblNarration
            // 
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(19, 96);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(100, 20);
            this.lblNarration.TabIndex = 124;
            this.lblNarration.Text = "Narration";
            // 
            // lblUnitname
            // 
            this.lblUnitname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitname.Location = new System.Drawing.Point(20, 21);
            this.lblUnitname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblUnitname.Name = "lblUnitname";
            this.lblUnitname.Size = new System.Drawing.Size(100, 20);
            this.lblUnitname.TabIndex = 123;
            this.lblUnitname.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(130, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(221, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(130, 96);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(250, 85);
            this.txtNarration.TabIndex = 3;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            this.txtNarration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarration_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnitSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvUnitSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 323);
            this.groupBox2.TabIndex = 1147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtUnitSearch
            // 
            this.txtUnitSearch.Location = new System.Drawing.Point(130, 21);
            this.txtUnitSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnitSearch.Name = "txtUnitSearch";
            this.txtUnitSearch.Size = new System.Drawing.Size(200, 20);
            this.txtUnitSearch.TabIndex = 0;
            this.txtUnitSearch.TextChanged += new System.EventHandler(this.txtUnitSearch_TextChanged);
            this.txtUnitSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitSearch_KeyDown);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Name";
            // 
            // dgvUnitSearch
            // 
            this.dgvUnitSearch.AllowUserToAddRows = false;
            this.dgvUnitSearch.AllowUserToDeleteRows = false;
            this.dgvUnitSearch.AllowUserToResizeColumns = false;
            this.dgvUnitSearch.AllowUserToResizeRows = false;
            this.dgvUnitSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnitSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvUnitSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnitSearch.ColumnHeadersHeight = 25;
            this.dgvUnitSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnitSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlno,
            this.dgvtxtUnitId,
            this.dgvtxtName,
            this.dgvtxtNoOfDecimalPlaces,
            this.dgvTxtNarration,
            this.dgvTxtformalName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnitSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnitSearch.EnableHeadersVisualStyles = false;
            this.dgvUnitSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUnitSearch.Location = new System.Drawing.Point(23, 49);
            this.dgvUnitSearch.MultiSelect = false;
            this.dgvUnitSearch.Name = "dgvUnitSearch";
            this.dgvUnitSearch.ReadOnly = true;
            this.dgvUnitSearch.RowHeadersVisible = false;
            this.dgvUnitSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnitSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitSearch.Size = new System.Drawing.Size(723, 257);
            this.dgvUnitSearch.TabIndex = 72;
            this.dgvUnitSearch.TabStop = false;
            this.dgvUnitSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitSearch_CellDoubleClick);
            this.dgvUnitSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitSearch_CellDoubleClick);
            this.dgvUnitSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUnitSearch_KeyDown);
            this.dgvUnitSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvUnitSearch_KeyUp);
            // 
            // dgvtxtSlno
            // 
            this.dgvtxtSlno.DataPropertyName = "SLNO";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtSlno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSlno.HeaderText = "Sl No";
            this.dgvtxtSlno.Name = "dgvtxtSlno";
            this.dgvtxtSlno.ReadOnly = true;
            this.dgvtxtSlno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnitId
            // 
            this.dgvtxtUnitId.DataPropertyName = "unitId";
            this.dgvtxtUnitId.HeaderText = "UnitId";
            this.dgvtxtUnitId.Name = "dgvtxtUnitId";
            this.dgvtxtUnitId.ReadOnly = true;
            this.dgvtxtUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitId.Visible = false;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.DataPropertyName = "unitName";
            this.dgvtxtName.HeaderText = "Name";
            this.dgvtxtName.Name = "dgvtxtName";
            this.dgvtxtName.ReadOnly = true;
            this.dgvtxtName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNoOfDecimalPlaces
            // 
            this.dgvtxtNoOfDecimalPlaces.DataPropertyName = "noOfDecimalplaces";
            this.dgvtxtNoOfDecimalPlaces.HeaderText = "No. of Decimal Place";
            this.dgvtxtNoOfDecimalPlaces.Name = "dgvtxtNoOfDecimalPlaces";
            this.dgvtxtNoOfDecimalPlaces.ReadOnly = true;
            this.dgvtxtNoOfDecimalPlaces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTxtNarration
            // 
            this.dgvTxtNarration.DataPropertyName = "narration";
            this.dgvTxtNarration.HeaderText = "Narration";
            this.dgvTxtNarration.Name = "dgvTxtNarration";
            this.dgvTxtNarration.ReadOnly = true;
            this.dgvTxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTxtNarration.Visible = false;
            // 
            // dgvTxtformalName
            // 
            this.dgvTxtformalName.HeaderText = "Formal Name";
            this.dgvTxtformalName.Name = "dgvTxtformalName";
            this.dgvTxtformalName.ReadOnly = true;
            this.dgvTxtformalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTxtformalName.Visible = false;
            // 
            // frmUnit
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
            this.Name = "frmUnit";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnit_FormClosing);
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUnit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNooFDecimalPlacesMandatory;
        private System.Windows.Forms.Label lblFormalNameMandatory;
        private System.Windows.Forms.Label lblUnitNameMandatory;
        private System.Windows.Forms.TextBox txtDecimalPlaces;
        private System.Windows.Forms.Label lblDecimalPlace;
        private System.Windows.Forms.TextBox txtFormalName;
        private System.Windows.Forms.Label lblFormalName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUnitname;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblUnitname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnitSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUnitSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNoOfDecimalPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtformalName;
    }
}