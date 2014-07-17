namespace Open_Miracle
{
    partial class frmDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignation));
            this.lblDesignationName = new System.Windows.Forms.Label();
            this.lblClInMonth = new System.Windows.Forms.Label();
            this.lblAdvanceAmount = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtDesignationName = new System.Windows.Forms.TextBox();
            this.txtCLInMonth = new System.Windows.Forms.TextBox();
            this.txtAdvanceAmount = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesignationName
            // 
            this.lblDesignationName.AutoSize = true;
            this.lblDesignationName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesignationName.Location = new System.Drawing.Point(12, 19);
            this.lblDesignationName.Margin = new System.Windows.Forms.Padding(5);
            this.lblDesignationName.Name = "lblDesignationName";
            this.lblDesignationName.Size = new System.Drawing.Size(35, 13);
            this.lblDesignationName.TabIndex = 0;
            this.lblDesignationName.Text = "Name";
            // 
            // lblClInMonth
            // 
            this.lblClInMonth.AutoSize = true;
            this.lblClInMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClInMonth.Location = new System.Drawing.Point(12, 44);
            this.lblClInMonth.Margin = new System.Windows.Forms.Padding(5);
            this.lblClInMonth.Name = "lblClInMonth";
            this.lblClInMonth.Size = new System.Drawing.Size(73, 13);
            this.lblClInMonth.TabIndex = 2;
            this.lblClInMonth.Text = "CL In a month";
            // 
            // lblAdvanceAmount
            // 
            this.lblAdvanceAmount.AutoSize = true;
            this.lblAdvanceAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdvanceAmount.Location = new System.Drawing.Point(12, 69);
            this.lblAdvanceAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblAdvanceAmount.Name = "lblAdvanceAmount";
            this.lblAdvanceAmount.Size = new System.Drawing.Size(88, 13);
            this.lblAdvanceAmount.TabIndex = 3;
            this.lblAdvanceAmount.Text = "Advance amount";
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(11, 90);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 4;
            this.lblNarration.Text = "Narration";
            // 
            // txtDesignationName
            // 
            this.txtDesignationName.Location = new System.Drawing.Point(122, 15);
            this.txtDesignationName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDesignationName.Name = "txtDesignationName";
            this.txtDesignationName.Size = new System.Drawing.Size(200, 20);
            this.txtDesignationName.TabIndex = 0;
            this.txtDesignationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesignationName_KeyDown);
            // 
            // txtCLInMonth
            // 
            this.txtCLInMonth.Location = new System.Drawing.Point(122, 40);
            this.txtCLInMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCLInMonth.MaxLength = 3;
            this.txtCLInMonth.Multiline = true;
            this.txtCLInMonth.Name = "txtCLInMonth";
            this.txtCLInMonth.Size = new System.Drawing.Size(200, 20);
            this.txtCLInMonth.TabIndex = 1;
            this.txtCLInMonth.Text = "0";
            this.txtCLInMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCLInMonth_KeyDown);
            this.txtCLInMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCLInMonth_KeyPress);
           
            // 
            // txtAdvanceAmount
            // 
            this.txtAdvanceAmount.Location = new System.Drawing.Point(122, 65);
            this.txtAdvanceAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAdvanceAmount.MaxLength = 9;
            this.txtAdvanceAmount.Name = "txtAdvanceAmount";
            this.txtAdvanceAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAdvanceAmount.TabIndex = 2;
            this.txtAdvanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdvanceAmount.Enter += new System.EventHandler(this.txtAdvanceAmount_Enter);
            this.txtAdvanceAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdvanceAmount_KeyDown);
            this.txtAdvanceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceAmount_KeyPress);
            this.txtAdvanceAmount.Leave += new System.EventHandler(this.txtAdvanceAmount_Leave);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(121, 90);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 50);
            this.txtNarration.TabIndex = 3;
            this.txtNarration.Enter += new System.EventHandler(this.txtNarration_Enter);
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // dgvDesignation
            // 
            this.dgvDesignation.AllowUserToAddRows = false;
            this.dgvDesignation.AllowUserToResizeColumns = false;
            this.dgvDesignation.AllowUserToResizeRows = false;
            this.dgvDesignation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesignation.BackgroundColor = System.Drawing.Color.White;
            this.dgvDesignation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesignation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesignation.ColumnHeadersHeight = 25;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo,
            this.dgvtxtDesignationName,
            this.dgvtxtDesignationId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesignation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesignation.EnableHeadersVisualStyles = false;
            this.dgvDesignation.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDesignation.Location = new System.Drawing.Point(18, 204);
            this.dgvDesignation.MultiSelect = false;
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.ReadOnly = true;
            this.dgvDesignation.RowHeadersVisible = false;
            this.dgvDesignation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDesignation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesignation.Size = new System.Drawing.Size(764, 373);
            this.dgvDesignation.TabIndex = 9;
            this.dgvDesignation.TabStop = false;
            this.dgvDesignation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesignation_CellDoubleClick);
            this.dgvDesignation.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDesignation_DataBindingComplete);
            this.dgvDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDesignation_KeyDown);
            this.dgvDesignation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDesignation_KeyUp);
            // 
            // slNo
            // 
            this.slNo.DataPropertyName = "slNo";
            this.slNo.HeaderText = "Sl No";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            this.slNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDesignationName
            // 
            this.dgvtxtDesignationName.DataPropertyName = "designationName";
            this.dgvtxtDesignationName.HeaderText = "Designation";
            this.dgvtxtDesignationName.Name = "dgvtxtDesignationName";
            this.dgvtxtDesignationName.ReadOnly = true;
            this.dgvtxtDesignationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDesignationId
            // 
            this.dgvtxtDesignationId.DataPropertyName = "designationId";
            this.dgvtxtDesignationId.HeaderText = "DesignationId";
            this.dgvtxtDesignationId.Name = "dgvtxtDesignationId";
            this.dgvtxtDesignationId.ReadOnly = true;
            this.dgvtxtDesignationId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDesignationId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 179);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(122, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
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
            this.btnClear.Location = new System.Drawing.Point(213, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(304, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(395, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.ForeColor = System.Drawing.Color.Red;
            this.lblStar.Location = new System.Drawing.Point(330, 19);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(11, 13);
            this.lblStar.TabIndex = 16;
            this.lblStar.Text = "*";
            // 
            // frmDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDesignation);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.txtAdvanceAmount);
            this.Controls.Add(this.txtCLInMonth);
            this.Controls.Add(this.txtDesignationName);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblAdvanceAmount);
            this.Controls.Add(this.lblClInMonth);
            this.Controls.Add(this.lblDesignationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDesignation";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDesignation_FormClosing);
            this.Load += new System.EventHandler(this.frmDesignation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDesignation_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDesignation_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesignationName;
        private System.Windows.Forms.Label lblClInMonth;
        private System.Windows.Forms.Label lblAdvanceAmount;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtDesignationName;
        private System.Windows.Forms.TextBox txtCLInMonth;
        private System.Windows.Forms.TextBox txtAdvanceAmount;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignationId;
    }
}