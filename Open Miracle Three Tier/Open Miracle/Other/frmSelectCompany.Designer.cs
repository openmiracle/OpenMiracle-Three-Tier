namespace Open_Miracle
{
    partial class frmSelectCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCompany));
            this.dgvSelectCompany = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectCompany
            // 
            this.dgvSelectCompany.AllowUserToAddRows = false;
            this.dgvSelectCompany.AllowUserToDeleteRows = false;
            this.dgvSelectCompany.AllowUserToResizeRows = false;
            this.dgvSelectCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectCompany.ColumnHeadersHeight = 35;
            this.dgvSelectCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelectCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtCompanyName,
            this.dgvtxtCompanyId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectCompany.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectCompany.EnableHeadersVisualStyles = false;
            this.dgvSelectCompany.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSelectCompany.Location = new System.Drawing.Point(18, 13);
            this.dgvSelectCompany.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvSelectCompany.Name = "dgvSelectCompany";
            this.dgvSelectCompany.ReadOnly = true;
            this.dgvSelectCompany.RowHeadersVisible = false;
            this.dgvSelectCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCompany.Size = new System.Drawing.Size(729, 319);
            this.dgvSelectCompany.TabIndex = 5;
            this.dgvSelectCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectCompany_CellDoubleClick);
            this.dgvSelectCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSelectCompany_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.FillWeight = 20F;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 70;
            // 
            // dgvtxtCompanyName
            // 
            this.dgvtxtCompanyName.DataPropertyName = "companyName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvtxtCompanyName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtCompanyName.HeaderText = "Company Name";
            this.dgvtxtCompanyName.Name = "dgvtxtCompanyName";
            this.dgvtxtCompanyName.ReadOnly = true;
            this.dgvtxtCompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCompanyId
            // 
            this.dgvtxtCompanyId.DataPropertyName = "companyId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtCompanyId.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtCompanyId.HeaderText = "Company Id";
            this.dgvtxtCompanyId.Name = "dgvtxtCompanyId";
            this.dgvtxtCompanyId.ReadOnly = true;
            this.dgvtxtCompanyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCompanyId.Visible = false;
            // 
            // frmSelectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(765, 352);
            this.Controls.Add(this.dgvSelectCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSelectCompany";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Company";
            this.Load += new System.EventHandler(this.frmSelectCompany_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSelectCompany_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCompanyId;

    }
}