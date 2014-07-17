namespace Open_Miracle
{
    partial class frmBudgetVariance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgetVariance));
            this.cmbBudget = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBudgetVariance = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBudgetDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtActualDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVarianceDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBudgetCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtActualCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVarianceCr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetVariance)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBudget
            // 
            this.cmbBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBudget.FormattingEnabled = true;
            this.cmbBudget.Location = new System.Drawing.Point(126, 10);
            this.cmbBudget.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbBudget.Name = "cmbBudget";
            this.cmbBudget.Size = new System.Drawing.Size(200, 21);
            this.cmbBudget.TabIndex = 0;
            this.cmbBudget.SelectedIndexChanged += new System.EventHandler(this.cmbBudget_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(697, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Budget";
            // 
            // dgvBudgetVariance
            // 
            this.dgvBudgetVariance.AllowUserToAddRows = false;
            this.dgvBudgetVariance.AllowUserToDeleteRows = false;
            this.dgvBudgetVariance.AllowUserToResizeColumns = false;
            this.dgvBudgetVariance.AllowUserToResizeRows = false;
            this.dgvBudgetVariance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgetVariance.BackgroundColor = System.Drawing.Color.White;
            this.dgvBudgetVariance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBudgetVariance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBudgetVariance.ColumnHeadersHeight = 25;
            this.dgvBudgetVariance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBudgetVariance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtParticulars,
            this.dgvtxtBudgetDr,
            this.dgvtxtActualDr,
            this.dgvtxtVarianceDr,
            this.dgvtxtBudgetCr,
            this.dgvtxtActualCr,
            this.dgvtxtVarianceCr});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBudgetVariance.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBudgetVariance.EnableHeadersVisualStyles = false;
            this.dgvBudgetVariance.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvBudgetVariance.Location = new System.Drawing.Point(18, 54);
            this.dgvBudgetVariance.Name = "dgvBudgetVariance";
            this.dgvBudgetVariance.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBudgetVariance.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBudgetVariance.RowHeadersVisible = false;
            this.dgvBudgetVariance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBudgetVariance.Size = new System.Drawing.Size(764, 500);
            this.dgvBudgetVariance.TabIndex = 3;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtParticulars
            // 
            this.dgvtxtParticulars.HeaderText = "Particulars";
            this.dgvtxtParticulars.Name = "dgvtxtParticulars";
            this.dgvtxtParticulars.ReadOnly = true;
            this.dgvtxtParticulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBudgetDr
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBudgetDr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBudgetDr.HeaderText = "Budget Dr.";
            this.dgvtxtBudgetDr.Name = "dgvtxtBudgetDr";
            this.dgvtxtBudgetDr.ReadOnly = true;
            this.dgvtxtBudgetDr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtActualDr
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtActualDr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtActualDr.HeaderText = "Actual Dr.";
            this.dgvtxtActualDr.Name = "dgvtxtActualDr";
            this.dgvtxtActualDr.ReadOnly = true;
            this.dgvtxtActualDr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVarianceDr
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtVarianceDr.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtVarianceDr.HeaderText = "Variance Dr.";
            this.dgvtxtVarianceDr.Name = "dgvtxtVarianceDr";
            this.dgvtxtVarianceDr.ReadOnly = true;
            this.dgvtxtVarianceDr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtBudgetCr
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtBudgetCr.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtBudgetCr.HeaderText = "Budget Cr.";
            this.dgvtxtBudgetCr.Name = "dgvtxtBudgetCr";
            this.dgvtxtBudgetCr.ReadOnly = true;
            this.dgvtxtBudgetCr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtActualCr
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtActualCr.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtActualCr.HeaderText = "Actual Cr.";
            this.dgvtxtActualCr.Name = "dgvtxtActualCr";
            this.dgvtxtActualCr.ReadOnly = true;
            this.dgvtxtActualCr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtVarianceCr
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvtxtVarianceCr.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtxtVarianceCr.HeaderText = "Variance Cr.";
            this.dgvtxtVarianceCr.Name = "dgvtxtVarianceCr";
            this.dgvtxtVarianceCr.ReadOnly = true;
            this.dgvtxtVarianceCr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmBudgetVariance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmbBudget);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBudgetVariance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmBudgetVariance";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Variance";
            this.Load += new System.EventHandler(this.frmBudgetVariance_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBudgetVariance_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetVariance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBudget;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBudgetVariance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBudgetDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtActualDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVarianceDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBudgetCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtActualCr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVarianceCr;
    }
}