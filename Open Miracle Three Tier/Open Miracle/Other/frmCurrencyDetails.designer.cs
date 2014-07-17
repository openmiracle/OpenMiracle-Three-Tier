namespace Open_Miracle
{
    partial class frmCurrencyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyDetails));
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.dgvCurrency = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDecimalPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrencySymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrencyName.Location = new System.Drawing.Point(20, 19);
            this.lblCurrencyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(80, 13);
            this.lblCurrencyName.TabIndex = 158;
            this.lblCurrencyName.Text = "Currency Name";
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(115, 15);
            this.txtCurrencyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(200, 20);
            this.txtCurrencyName.TabIndex = 1;
            this.txtCurrencyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrencyName_KeyDown);
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AllowUserToDeleteRows = false;
            this.dgvCurrency.AllowUserToResizeRows = false;
            this.dgvCurrency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrency.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrency.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrency.ColumnHeadersHeight = 25;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtDecimalPlaces,
            this.dgvtxtCurrencyId,
            this.dgvtxtCurrencyName,
            this.dgvtxtCurrencySymbol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrency.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrency.EnableHeadersVisualStyles = false;
            this.dgvCurrency.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCurrency.Location = new System.Drawing.Point(18, 70);
            this.dgvCurrency.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvCurrency.MultiSelect = false;
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.RowHeadersVisible = false;
            this.dgvCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrency.Size = new System.Drawing.Size(764, 520);
            this.dgvCurrency.TabIndex = 4;
            this.dgvCurrency.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_CellDoubleClick);
            this.dgvCurrency.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCurrency_DataBindingComplete);
            this.dgvCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCurrency_KeyDown);
            this.dgvCurrency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCurrency_KeyUp);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDecimalPlaces
            // 
            this.dgvtxtDecimalPlaces.DataPropertyName = "noOfDecimalPlaces";
            this.dgvtxtDecimalPlaces.HeaderText = "DecimalPlaces";
            this.dgvtxtDecimalPlaces.Name = "dgvtxtDecimalPlaces";
            this.dgvtxtDecimalPlaces.ReadOnly = true;
            this.dgvtxtDecimalPlaces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDecimalPlaces.Visible = false;
            // 
            // dgvtxtCurrencyId
            // 
            this.dgvtxtCurrencyId.DataPropertyName = "currencyId";
            this.dgvtxtCurrencyId.HeaderText = "dgvtxtCurrencyId";
            this.dgvtxtCurrencyId.Name = "dgvtxtCurrencyId";
            this.dgvtxtCurrencyId.ReadOnly = true;
            this.dgvtxtCurrencyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrencyId.Visible = false;
            // 
            // dgvtxtCurrencyName
            // 
            this.dgvtxtCurrencyName.DataPropertyName = "currencyName";
            this.dgvtxtCurrencyName.HeaderText = "Currency Name";
            this.dgvtxtCurrencyName.Name = "dgvtxtCurrencyName";
            this.dgvtxtCurrencyName.ReadOnly = true;
            this.dgvtxtCurrencyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCurrencySymbol
            // 
            this.dgvtxtCurrencySymbol.DataPropertyName = "currencySymbol";
            this.dgvtxtCurrencySymbol.HeaderText = "Currency Symbol";
            this.dgvtxtCurrencySymbol.Name = "dgvtxtCurrencySymbol";
            this.dgvtxtCurrencySymbol.ReadOnly = true;
            this.dgvtxtCurrencySymbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(452, 19);
            this.lblCurrencySymbol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(86, 13);
            this.lblCurrencySymbol.TabIndex = 160;
            this.lblCurrencySymbol.Text = "Currency Symbol";
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.Location = new System.Drawing.Point(580, 15);
            this.txtCurrencySymbol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(200, 20);
            this.txtCurrencySymbol.TabIndex = 2;
            this.txtCurrencySymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrencySymbol_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(580, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // frmCurrencyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCurrencySymbol);
            this.Controls.Add(this.txtCurrencySymbol);
            this.Controls.Add(this.lblCurrencyName);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.dgvCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCurrencyDetails";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCurrencyDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmCurrencyDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCurrencyDetails_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.DataGridView dgvCurrency;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.TextBox txtCurrencySymbol;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDecimalPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrencySymbol;
    }
}