namespace Open_Miracle
{
    partial class frmFundFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFundFlow));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvFundFlow = new System.Windows.Forms.DataGridView();
            this.dgvtxtgroupId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtgroupId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtApplication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFundFlowFromDate = new System.Windows.Forms.TextBox();
            this.dtpFundFlowFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFundflowToDate = new System.Windows.Forms.TextBox();
            this.dtpFundFlowToDate = new System.Windows.Forms.DateTimePicker();
            this.dgvFundFlow2 = new System.Windows.Forms.DataGridView();
            this.dgvtxtgroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtParticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtWorkingCapitalIncrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundFlow2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(668, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(577, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1166;
            this.label3.Text = "To date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1164;
            this.label2.Text = "From date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(692, 508);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 1162;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvFundFlow
            // 
            this.dgvFundFlow.AllowUserToAddRows = false;
            this.dgvFundFlow.AllowUserToDeleteRows = false;
            this.dgvFundFlow.AllowUserToResizeColumns = false;
            this.dgvFundFlow.AllowUserToResizeRows = false;
            this.dgvFundFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundFlow.BackgroundColor = System.Drawing.Color.White;
            this.dgvFundFlow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFundFlow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundFlow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFundFlow.ColumnHeadersHeight = 35;
            this.dgvFundFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFundFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtgroupId1,
            this.dgvtxtSource,
            this.dgvtxtAmount1,
            this.dgvtxtgroupId2,
            this.dgvtxtApplication,
            this.dgvtxtAmount2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFundFlow.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFundFlow.EnableHeadersVisualStyles = false;
            this.dgvFundFlow.GridColor = System.Drawing.Color.White;
            this.dgvFundFlow.Location = new System.Drawing.Point(18, 71);
            this.dgvFundFlow.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvFundFlow.Name = "dgvFundFlow";
            this.dgvFundFlow.ReadOnly = true;
            this.dgvFundFlow.RowHeadersVisible = false;
            this.dgvFundFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFundFlow.Size = new System.Drawing.Size(759, 313);
            this.dgvFundFlow.TabIndex = 5;
            this.dgvFundFlow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFundFlow_CellDoubleClick);
            this.dgvFundFlow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFundFlow_KeyDown);
            // 
            // dgvtxtgroupId1
            // 
            this.dgvtxtgroupId1.HeaderText = "groupId1";
            this.dgvtxtgroupId1.Name = "dgvtxtgroupId1";
            this.dgvtxtgroupId1.ReadOnly = true;
            this.dgvtxtgroupId1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtgroupId1.Visible = false;
            // 
            // dgvtxtSource
            // 
            this.dgvtxtSource.HeaderText = "Source";
            this.dgvtxtSource.Name = "dgvtxtSource";
            this.dgvtxtSource.ReadOnly = true;
            this.dgvtxtSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtAmount1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtAmount1.HeaderText = "Amount";
            this.dgvtxtAmount1.Name = "dgvtxtAmount1";
            this.dgvtxtAmount1.ReadOnly = true;
            this.dgvtxtAmount1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtgroupId2
            // 
            this.dgvtxtgroupId2.HeaderText = "groupId2";
            this.dgvtxtgroupId2.Name = "dgvtxtgroupId2";
            this.dgvtxtgroupId2.ReadOnly = true;
            this.dgvtxtgroupId2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtgroupId2.Visible = false;
            // 
            // dgvtxtApplication
            // 
            this.dgvtxtApplication.HeaderText = "Application";
            this.dgvtxtApplication.Name = "dgvtxtApplication";
            this.dgvtxtApplication.ReadOnly = true;
            this.dgvtxtApplication.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAmount2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtAmount2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtAmount2.HeaderText = "Amount";
            this.dgvtxtAmount2.Name = "dgvtxtAmount2";
            this.dgvtxtAmount2.ReadOnly = true;
            this.dgvtxtAmount2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtFundFlowFromDate
            // 
            this.txtFundFlowFromDate.Location = new System.Drawing.Point(140, 15);
            this.txtFundFlowFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFundFlowFromDate.Name = "txtFundFlowFromDate";
            this.txtFundFlowFromDate.Size = new System.Drawing.Size(178, 20);
            this.txtFundFlowFromDate.TabIndex = 1;
            this.txtFundFlowFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFundFlowFromDate_KeyDown);
            this.txtFundFlowFromDate.Leave += new System.EventHandler(this.txtFundFlowFromDate_Leave);
            // 
            // dtpFundFlowFromDate
            // 
            this.dtpFundFlowFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFundFlowFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFundFlowFromDate.Location = new System.Drawing.Point(318, 15);
            this.dtpFundFlowFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFundFlowFromDate.Name = "dtpFundFlowFromDate";
            this.dtpFundFlowFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFundFlowFromDate.TabIndex = 1171;
            this.dtpFundFlowFromDate.ValueChanged += new System.EventHandler(this.dtpFundFlowFromDate_ValueChanged);
            // 
            // txtFundflowToDate
            // 
            this.txtFundflowToDate.Location = new System.Drawing.Point(577, 15);
            this.txtFundflowToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFundflowToDate.Name = "txtFundflowToDate";
            this.txtFundflowToDate.Size = new System.Drawing.Size(178, 20);
            this.txtFundflowToDate.TabIndex = 2;
            this.txtFundflowToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFundflowToDate_KeyDown);
            this.txtFundflowToDate.Leave += new System.EventHandler(this.txtFundflowToDate_Leave);
            // 
            // dtpFundFlowToDate
            // 
            this.dtpFundFlowToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFundFlowToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFundFlowToDate.Location = new System.Drawing.Point(753, 15);
            this.dtpFundFlowToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFundFlowToDate.Name = "dtpFundFlowToDate";
            this.dtpFundFlowToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFundFlowToDate.TabIndex = 1173;
            this.dtpFundFlowToDate.ValueChanged += new System.EventHandler(this.dtpFundFlowToDate_ValueChanged);
            // 
            // dgvFundFlow2
            // 
            this.dgvFundFlow2.AllowUserToAddRows = false;
            this.dgvFundFlow2.AllowUserToDeleteRows = false;
            this.dgvFundFlow2.AllowUserToResizeColumns = false;
            this.dgvFundFlow2.AllowUserToResizeRows = false;
            this.dgvFundFlow2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundFlow2.BackgroundColor = System.Drawing.Color.White;
            this.dgvFundFlow2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundFlow2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFundFlow2.ColumnHeadersHeight = 35;
            this.dgvFundFlow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFundFlow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtgroupId,
            this.dgvtxtParticulars,
            this.dgvtxtOpeningBalance,
            this.dgvtxtop,
            this.dgvtxtClosingBalance,
            this.dgvtxtcb,
            this.dgvtxtWorkingCapitalIncrease});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFundFlow2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFundFlow2.EnableHeadersVisualStyles = false;
            this.dgvFundFlow2.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFundFlow2.Location = new System.Drawing.Point(18, 394);
            this.dgvFundFlow2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvFundFlow2.Name = "dgvFundFlow2";
            this.dgvFundFlow2.ReadOnly = true;
            this.dgvFundFlow2.RowHeadersVisible = false;
            this.dgvFundFlow2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFundFlow2.Size = new System.Drawing.Size(759, 105);
            this.dgvFundFlow2.TabIndex = 6;
            this.dgvFundFlow2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFundFlow2_CellDoubleClick);
            this.dgvFundFlow2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFundFlow2_KeyDown);
            // 
            // dgvtxtgroupId
            // 
            this.dgvtxtgroupId.HeaderText = "groupId";
            this.dgvtxtgroupId.Name = "dgvtxtgroupId";
            this.dgvtxtgroupId.ReadOnly = true;
            this.dgvtxtgroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtgroupId.Visible = false;
            // 
            // dgvtxtParticulars
            // 
            this.dgvtxtParticulars.FillWeight = 131.9797F;
            this.dgvtxtParticulars.HeaderText = "Particulars";
            this.dgvtxtParticulars.Name = "dgvtxtParticulars";
            this.dgvtxtParticulars.ReadOnly = true;
            this.dgvtxtParticulars.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOpeningBalance
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtOpeningBalance.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtxtOpeningBalance.FillWeight = 89.3401F;
            this.dgvtxtOpeningBalance.HeaderText = "Opening Balance";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.ReadOnly = true;
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtop
            // 
            this.dgvtxtop.HeaderText = "op";
            this.dgvtxtop.Name = "dgvtxtop";
            this.dgvtxtop.ReadOnly = true;
            this.dgvtxtop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtop.Visible = false;
            // 
            // dgvtxtClosingBalance
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtClosingBalance.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtxtClosingBalance.FillWeight = 89.3401F;
            this.dgvtxtClosingBalance.HeaderText = "Closing Balance";
            this.dgvtxtClosingBalance.Name = "dgvtxtClosingBalance";
            this.dgvtxtClosingBalance.ReadOnly = true;
            this.dgvtxtClosingBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtcb
            // 
            this.dgvtxtcb.HeaderText = "cb";
            this.dgvtxtcb.Name = "dgvtxtcb";
            this.dgvtxtcb.ReadOnly = true;
            this.dgvtxtcb.Visible = false;
            // 
            // dgvtxtWorkingCapitalIncrease
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtWorkingCapitalIncrease.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtxtWorkingCapitalIncrease.FillWeight = 89.3401F;
            this.dgvtxtWorkingCapitalIncrease.HeaderText = "Working Capital Increase";
            this.dgvtxtWorkingCapitalIncrease.Name = "dgvtxtWorkingCapitalIncrease";
            this.dgvtxtWorkingCapitalIncrease.ReadOnly = true;
            this.dgvtxtWorkingCapitalIncrease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(397, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 311);
            this.panel1.TabIndex = 1174;
            // 
            // frmFundFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(795, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFundFlow2);
            this.Controls.Add(this.txtFundflowToDate);
            this.Controls.Add(this.dtpFundFlowToDate);
            this.Controls.Add(this.txtFundFlowFromDate);
            this.Controls.Add(this.dtpFundFlowFromDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvFundFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFundFlow";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund Flow";
            this.Load += new System.EventHandler(this.frmFundFlow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFundFlow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundFlow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvFundFlow;
        private System.Windows.Forms.TextBox txtFundFlowFromDate;
        private System.Windows.Forms.DateTimePicker dtpFundFlowFromDate;
        private System.Windows.Forms.TextBox txtFundflowToDate;
        private System.Windows.Forms.DateTimePicker dtpFundFlowToDate;
        private System.Windows.Forms.DataGridView dgvFundFlow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtgroupId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtgroupId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtgroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtWorkingCapitalIncrease;
        private System.Windows.Forms.Panel panel1;
    }
}