namespace Open_Miracle
{
    partial class frmProductBom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductBom));
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.dgvProductBOM = new Open_Miracle.dgv.DataGridViewEnter();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbRawMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkbtnRemove = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBOM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(18, 19);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 400;
            this.lblProduct.Text = "Product";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(122, 15);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(5);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(200, 20);
            this.txtProduct.TabIndex = 388;
            // 
            // dgvProductBOM
            // 
            this.dgvProductBOM.AllowUserToResizeColumns = false;
            this.dgvProductBOM.AllowUserToResizeRows = false;
            this.dgvProductBOM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductBOM.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductBOM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductBOM.ColumnHeadersHeight = 25;
            this.dgvProductBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductBOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvcmbRawMaterial,
            this.dgvtxtQty,
            this.dgvtxtUnit,
            this.dgvcmbUnit,
            this.dgvtxtUnitId,
            this.dgvtxtCheck,
            this.dgvtxtBomId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductBOM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductBOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductBOM.EnableHeadersVisualStyles = false;
            this.dgvProductBOM.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductBOM.Location = new System.Drawing.Point(18, 43);
            this.dgvProductBOM.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvProductBOM.Name = "dgvProductBOM";
            this.dgvProductBOM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBOM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductBOM.Size = new System.Drawing.Size(764, 489);
            this.dgvProductBOM.TabIndex = 0;
            this.dgvProductBOM.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProductBOM_CellBeginEdit);
            //this.dgvProductBOM.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductBOM_CellLeave);
            this.dgvProductBOM.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductBOM_CellValueChanged);
            this.dgvProductBOM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProductBOM_DataError);
            this.dgvProductBOM.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductBOM_EditingControlShowing);
            this.dgvProductBOM.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductBOM_RowsAdded);
            this.dgvProductBOM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductBOM_KeyDown);
            this.dgvProductBOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProductBOM_KeyPress);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbRawMaterial
            // 
            this.dgvcmbRawMaterial.HeaderText = "Raw Material";
            this.dgvcmbRawMaterial.Name = "dgvcmbRawMaterial";
            this.dgvcmbRawMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtQty
            // 
            this.dgvtxtQty.DataPropertyName = "quantity";
            this.dgvtxtQty.HeaderText = "Qty.";
            this.dgvtxtQty.MaxInputLength = 5;
            this.dgvtxtQty.Name = "dgvtxtQty";
            this.dgvtxtQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnit
            // 
            this.dgvtxtUnit.HeaderText = "Unit";
            this.dgvtxtUnit.Name = "dgvtxtUnit";
            this.dgvtxtUnit.ReadOnly = true;
            this.dgvtxtUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnit.Visible = false;
            // 
            // dgvcmbUnit
            // 
            this.dgvcmbUnit.HeaderText = "Unit";
            this.dgvcmbUnit.Name = "dgvcmbUnit";
            this.dgvcmbUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvtxtUnitId
            // 
            this.dgvtxtUnitId.HeaderText = "UnitId";
            this.dgvtxtUnitId.Name = "dgvtxtUnitId";
            this.dgvtxtUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtUnitId.Visible = false;
            // 
            // dgvtxtCheck
            // 
            this.dgvtxtCheck.HeaderText = "";
            this.dgvtxtCheck.Name = "dgvtxtCheck";
            this.dgvtxtCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCheck.Visible = false;
            // 
            // dgvtxtBomId
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvtxtBomId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBomId.HeaderText = "BomId";
            this.dgvtxtBomId.Name = "dgvtxtBomId";
            this.dgvtxtBomId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBomId.Visible = false;
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
            this.btnClose.TabIndex = 4;
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
            this.btnDelete.TabIndex = 3;
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
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lnkbtnRemove
            // 
            this.lnkbtnRemove.AutoSize = true;
            this.lnkbtnRemove.LinkColor = System.Drawing.Color.Yellow;
            this.lnkbtnRemove.Location = new System.Drawing.Point(735, 539);
            this.lnkbtnRemove.Name = "lnkbtnRemove";
            this.lnkbtnRemove.Size = new System.Drawing.Size(47, 13);
            this.lnkbtnRemove.TabIndex = 5;
            this.lnkbtnRemove.TabStop = true;
            this.lnkbtnRemove.Text = "Remove";
            this.lnkbtnRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbtnRemove_LinkClicked);
            // 
            // frmProductBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lnkbtnRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.dgvProductBOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProductBom";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product BOM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductBom_FormClosing);
            this.Load += new System.EventHandler(this.frmProductBom_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductBom_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkbtnRemove;
        private dgv.DataGridViewEnter dgvProductBOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBomId;
    }
}