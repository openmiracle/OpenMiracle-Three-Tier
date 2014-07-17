namespace Open_Miracle
{
    partial class frmProductMultipleUnit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductMultipleUnit));
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvMultipleUnit = new Open_Miracle.dgv.DataGridViewEnter();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtqtymultipleunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbmultipleunit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtequal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnitconvertionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtunitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lblRemove.Location = new System.Drawing.Point(735, 537);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(47, 13);
            this.lblRemove.TabIndex = 414;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove";
            this.lblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemove_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 560);
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
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(515, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 409;
            this.label7.Text = "Product";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(129, 15);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // dgvMultipleUnit
            // 
            this.dgvMultipleUnit.AllowUserToResizeColumns = false;
            this.dgvMultipleUnit.AllowUserToResizeRows = false;
            this.dgvMultipleUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultipleUnit.BackgroundColor = System.Drawing.Color.White;
            this.dgvMultipleUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMultipleUnit.ColumnHeadersHeight = 25;
            this.dgvMultipleUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMultipleUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtqtymultipleunit,
            this.dgvcmbmultipleunit,
            this.dgvtxtequal,
            this.dgvtxtqty,
            this.dgvtxtunit,
            this.dgvtxtUnitconvertionId,
            this.dgvtxtCheck,
            this.dgvtxtunitname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMultipleUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMultipleUnit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMultipleUnit.EnableHeadersVisualStyles = false;
            this.dgvMultipleUnit.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMultipleUnit.Location = new System.Drawing.Point(18, 43);
            this.dgvMultipleUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvMultipleUnit.Name = "dgvMultipleUnit";
            this.dgvMultipleUnit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultipleUnit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMultipleUnit.Size = new System.Drawing.Size(764, 487);
            this.dgvMultipleUnit.TabIndex = 1;
            this.dgvMultipleUnit.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMultipleUnit_CellBeginEdit);
            this.dgvMultipleUnit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleUnit_CellEndEdit);
            this.dgvMultipleUnit.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultipleUnit_CellValueChanged);
            this.dgvMultipleUnit.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMultipleUnit_DataError);
            this.dgvMultipleUnit.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMultipleUnit_EditingControlShowing);
            this.dgvMultipleUnit.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMultipleUnit_RowsAdded);
            this.dgvMultipleUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMultipleUnit_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtqtymultipleunit
            // 
            this.dgvtxtqtymultipleunit.HeaderText = "Quantity";
            this.dgvtxtqtymultipleunit.MaxInputLength = 5;
            this.dgvtxtqtymultipleunit.Name = "dgvtxtqtymultipleunit";
            this.dgvtxtqtymultipleunit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbmultipleunit
            // 
            this.dgvcmbmultipleunit.HeaderText = "Unit";
            this.dgvcmbmultipleunit.Name = "dgvcmbmultipleunit";
            this.dgvcmbmultipleunit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtequal
            // 
            this.dgvtxtequal.HeaderText = "";
            this.dgvtxtequal.Name = "dgvtxtequal";
            this.dgvtxtequal.ReadOnly = true;
            this.dgvtxtequal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtequal.ToolTipText = "=";
            // 
            // dgvtxtqty
            // 
            this.dgvtxtqty.HeaderText = "Quantity";
            this.dgvtxtqty.MaxInputLength = 13;
            this.dgvtxtqty.Name = "dgvtxtqty";
            this.dgvtxtqty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtunit
            // 
            this.dgvtxtunit.HeaderText = "Unit";
            this.dgvtxtunit.Name = "dgvtxtunit";
            this.dgvtxtunit.ReadOnly = true;
            this.dgvtxtunit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtxtunit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnitconvertionId
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvtxtUnitconvertionId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtUnitconvertionId.HeaderText = "UnitConvertionId";
            this.dgvtxtUnitconvertionId.Name = "dgvtxtUnitconvertionId";
            this.dgvtxtUnitconvertionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitconvertionId.Visible = false;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.HeaderText = "";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // dgvtxtunitname
            // 
            this.dgvtxtunitname.HeaderText = "UnitName";
            this.dgvtxtunitname.Name = "dgvtxtunitname";
            this.dgvtxtunitname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtunitname.Visible = false;
            // 
            // frmProductMultipleUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvMultipleUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductMultipleUnit";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Multiple Unit";
            this.Load += new System.EventHandler(this.frmProductMultipleUnit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductMultipleUnit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnSave;
        private dgv.DataGridViewEnter dgvMultipleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtqtymultipleunit;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbmultipleunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtequal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitconvertionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtunitname;//Grid navigation
    }
}