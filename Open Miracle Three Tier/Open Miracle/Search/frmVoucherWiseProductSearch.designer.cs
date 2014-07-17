namespace Open_Miracle
{
    partial class frmVoucherWiseProductSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherWiseProductSearch));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVoucherwiseProductSearch = new System.Windows.Forms.DataGridView();
            this.lblTotalInqty = new System.Windows.Forms.Label();
            this.lblTotalOutQty = new System.Windows.Forms.Label();
            this.lblBalanceQty = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblInward = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTypeOfVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtvoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtmasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInwardQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOutwardQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtledgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherwiseProductSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1150;
            this.label2.Text = "From Date";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.Location = new System.Drawing.Point(123, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.SelectedValueChanged += new System.EventHandler(this.cmbVoucherType_SelectedValueChanged);
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1152;
            this.label3.Text = "Voucher Type";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductGroup.Location = new System.Drawing.Point(578, 65);
            this.cmbProductGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(202, 21);
            this.cmbProductGroup.TabIndex = 5;
            this.cmbProductGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductGroup_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1156;
            this.label4.Text = "Product Group";
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(123, 66);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1154;
            this.label5.Text = "Cash / Party";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1164;
            this.label6.Text = "Product Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(472, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1160;
            this.label8.Text = "Voucher No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(472, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1158;
            this.label9.Text = "To Date";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(578, 40);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(202, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(669, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(578, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // dgvVoucherwiseProductSearch
            // 
            this.dgvVoucherwiseProductSearch.AllowUserToAddRows = false;
            this.dgvVoucherwiseProductSearch.AllowUserToDeleteRows = false;
            this.dgvVoucherwiseProductSearch.AllowUserToResizeRows = false;
            this.dgvVoucherwiseProductSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvVoucherwiseProductSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucherwiseProductSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoucherwiseProductSearch.ColumnHeadersHeight = 35;
            this.dgvVoucherwiseProductSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoucherwiseProductSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.dgvtxtvoucherType,
            this.dgvtxtTypeOfVoucher,
            this.dgvtxtvoucherTypeId,
            this.dgvtxtmasterId,
            this.dgvtxtVoucherNo,
            this.dgvtxtDate,
            this.dgvtxtProductCode,
            this.dgvtxtProduct,
            this.dgvtxtInwardQty,
            this.dgvtxtOutwardQty,
            this.dgvtxtrate,
            this.dgvtxtledgerId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucherwiseProductSearch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVoucherwiseProductSearch.EnableHeadersVisualStyles = false;
            this.dgvVoucherwiseProductSearch.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVoucherwiseProductSearch.Location = new System.Drawing.Point(18, 147);
            this.dgvVoucherwiseProductSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvVoucherwiseProductSearch.MultiSelect = false;
            this.dgvVoucherwiseProductSearch.Name = "dgvVoucherwiseProductSearch";
            this.dgvVoucherwiseProductSearch.ReadOnly = true;
            this.dgvVoucherwiseProductSearch.RowHeadersVisible = false;
            this.dgvVoucherwiseProductSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoucherwiseProductSearch.Size = new System.Drawing.Size(764, 355);
            this.dgvVoucherwiseProductSearch.TabIndex = 12;
            this.dgvVoucherwiseProductSearch.TabStop = false;
            this.dgvVoucherwiseProductSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucherwiseProductSearch_CellDoubleClick);
            this.dgvVoucherwiseProductSearch.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVoucherwiseProductSearch_RowsAdded);
            // 
            // lblTotalInqty
            // 
            this.lblTotalInqty.AutoSize = true;
            this.lblTotalInqty.ForeColor = System.Drawing.Color.White;
            this.lblTotalInqty.Location = new System.Drawing.Point(20, 512);
            this.lblTotalInqty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalInqty.Name = "lblTotalInqty";
            this.lblTotalInqty.Size = new System.Drawing.Size(85, 13);
            this.lblTotalInqty.TabIndex = 1169;
            this.lblTotalInqty.Text = "Total Inward Qty";
            // 
            // lblTotalOutQty
            // 
            this.lblTotalOutQty.AutoSize = true;
            this.lblTotalOutQty.ForeColor = System.Drawing.Color.White;
            this.lblTotalOutQty.Location = new System.Drawing.Point(20, 530);
            this.lblTotalOutQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotalOutQty.Name = "lblTotalOutQty";
            this.lblTotalOutQty.Size = new System.Drawing.Size(93, 13);
            this.lblTotalOutQty.TabIndex = 1171;
            this.lblTotalOutQty.Text = "Total Outward Qty";
            // 
            // lblBalanceQty
            // 
            this.lblBalanceQty.AutoSize = true;
            this.lblBalanceQty.ForeColor = System.Drawing.Color.White;
            this.lblBalanceQty.Location = new System.Drawing.Point(20, 548);
            this.lblBalanceQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBalanceQty.Name = "lblBalanceQty";
            this.lblBalanceQty.Size = new System.Drawing.Size(65, 13);
            this.lblBalanceQty.TabIndex = 1173;
            this.lblBalanceQty.Text = "Balance Qty";
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
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(606, 560);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(85, 27);
            this.btnViewDetails.TabIndex = 10;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(301, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1195;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(123, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(180, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(758, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1197;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(578, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(180, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1201;
            this.label7.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(123, 93);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 6;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(578, 91);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(202, 20);
            this.txtProductName.TabIndex = 7;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblInward
            // 
            this.lblInward.AutoSize = true;
            this.lblInward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInward.ForeColor = System.Drawing.Color.Yellow;
            this.lblInward.Location = new System.Drawing.Point(132, 512);
            this.lblInward.Name = "lblInward";
            this.lblInward.Size = new System.Drawing.Size(25, 13);
            this.lblInward.TabIndex = 1204;
            this.lblInward.Text = "0.0";
            this.lblInward.Visible = false;
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.Color.Yellow;
            this.lblout.Location = new System.Drawing.Point(132, 530);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(25, 13);
            this.lblout.TabIndex = 1205;
            this.lblout.Text = "0.0";
            this.lblout.Visible = false;
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.ForeColor = System.Drawing.Color.Yellow;
            this.lblbalance.Location = new System.Drawing.Point(132, 548);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(25, 13);
            this.lblbalance.TabIndex = 1206;
            this.lblbalance.Text = "0.0";
            this.lblbalance.Visible = false;
            // 
            // SlNo
            // 
            this.SlNo.FillWeight = 30F;
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNo.Width = 47;
            // 
            // dgvtxtvoucherType
            // 
            this.dgvtxtvoucherType.DataPropertyName = "VoucherTypeName";
            this.dgvtxtvoucherType.FillWeight = 57.39832F;
            this.dgvtxtvoucherType.HeaderText = "voucher Type";
            this.dgvtxtvoucherType.Name = "dgvtxtvoucherType";
            this.dgvtxtvoucherType.ReadOnly = true;
            this.dgvtxtvoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvoucherType.Width = 89;
            // 
            // dgvtxtTypeOfVoucher
            // 
            this.dgvtxtTypeOfVoucher.DataPropertyName = "typeOfVoucher";
            this.dgvtxtTypeOfVoucher.HeaderText = "TypeOfVoucher";
            this.dgvtxtTypeOfVoucher.Name = "dgvtxtTypeOfVoucher";
            this.dgvtxtTypeOfVoucher.ReadOnly = true;
            this.dgvtxtTypeOfVoucher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTypeOfVoucher.Visible = false;
            // 
            // dgvtxtvoucherTypeId
            // 
            this.dgvtxtvoucherTypeId.DataPropertyName = "voucherTypeId";
            this.dgvtxtvoucherTypeId.HeaderText = "voucherTypeId";
            this.dgvtxtvoucherTypeId.Name = "dgvtxtvoucherTypeId";
            this.dgvtxtvoucherTypeId.ReadOnly = true;
            this.dgvtxtvoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtvoucherTypeId.Visible = false;
            // 
            // dgvtxtmasterId
            // 
            this.dgvtxtmasterId.DataPropertyName = "masterId";
            this.dgvtxtmasterId.HeaderText = "masterId";
            this.dgvtxtmasterId.Name = "dgvtxtmasterId";
            this.dgvtxtmasterId.ReadOnly = true;
            this.dgvtxtmasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtmasterId.Visible = false;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "VoucherNo";
            this.dgvtxtVoucherNo.FillWeight = 57.39832F;
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Width = 90;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "Date";
            this.dgvtxtDate.FillWeight = 57.39832F;
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDate.Width = 89;
            // 
            // dgvtxtProductCode
            // 
            this.dgvtxtProductCode.DataPropertyName = "ProductCode";
            this.dgvtxtProductCode.FillWeight = 57.39832F;
            this.dgvtxtProductCode.HeaderText = "Product Code";
            this.dgvtxtProductCode.Name = "dgvtxtProductCode";
            this.dgvtxtProductCode.ReadOnly = true;
            this.dgvtxtProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProductCode.Width = 89;
            // 
            // dgvtxtProduct
            // 
            this.dgvtxtProduct.DataPropertyName = "ProductName";
            this.dgvtxtProduct.FillWeight = 57.39832F;
            this.dgvtxtProduct.HeaderText = "Product";
            this.dgvtxtProduct.Name = "dgvtxtProduct";
            this.dgvtxtProduct.ReadOnly = true;
            this.dgvtxtProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtProduct.Width = 89;
            // 
            // dgvtxtInwardQty
            // 
            this.dgvtxtInwardQty.DataPropertyName = "InwardQty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtInwardQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtInwardQty.FillWeight = 57.39832F;
            this.dgvtxtInwardQty.HeaderText = "Inward Qty";
            this.dgvtxtInwardQty.Name = "dgvtxtInwardQty";
            this.dgvtxtInwardQty.ReadOnly = true;
            this.dgvtxtInwardQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtInwardQty.Width = 90;
            // 
            // dgvtxtOutwardQty
            // 
            this.dgvtxtOutwardQty.DataPropertyName = "OutwardQty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtOutwardQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtOutwardQty.FillWeight = 57.39832F;
            this.dgvtxtOutwardQty.HeaderText = "Outward Qty";
            this.dgvtxtOutwardQty.Name = "dgvtxtOutwardQty";
            this.dgvtxtOutwardQty.ReadOnly = true;
            this.dgvtxtOutwardQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOutwardQty.Width = 89;
            // 
            // dgvtxtrate
            // 
            this.dgvtxtrate.DataPropertyName = "Rate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtrate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtrate.FillWeight = 57.39832F;
            this.dgvtxtrate.HeaderText = "Rate";
            this.dgvtxtrate.Name = "dgvtxtrate";
            this.dgvtxtrate.ReadOnly = true;
            this.dgvtxtrate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtrate.Width = 89;
            // 
            // dgvtxtledgerId
            // 
            this.dgvtxtledgerId.DataPropertyName = "ledgerId";
            this.dgvtxtledgerId.HeaderText = "ledgerId";
            this.dgvtxtledgerId.Name = "dgvtxtledgerId";
            this.dgvtxtledgerId.ReadOnly = true;
            this.dgvtxtledgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtledgerId.Visible = false;
            // 
            // frmVoucherWiseProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.lblInward);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBalanceQty);
            this.Controls.Add(this.lblTotalOutQty);
            this.Controls.Add(this.lblTotalInqty);
            this.Controls.Add(this.dgvVoucherwiseProductSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmVoucherWiseProductSearch";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Wise Product Search";
            this.Load += new System.EventHandler(this.frmVoucherWiseProductSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherWiseProductSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucherwiseProductSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVoucherwiseProductSearch;
        private System.Windows.Forms.Label lblTotalInqty;
        private System.Windows.Forms.Label lblTotalOutQty;
        private System.Windows.Forms.Label lblBalanceQty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblInward;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTypeOfVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtvoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInwardQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOutwardQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtledgerId;
    }
}