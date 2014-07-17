namespace Open_Miracle
{
    partial class frmSalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.lblTodate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSalesMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSalesMan = new System.Windows.Forms.ComboBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblModelNo = new System.Windows.Forms.Label();
            this.cmbModelNo = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSIReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFrmDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtTodate = new System.Windows.Forms.TextBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtVoucherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtQONno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCreditAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTodate
            // 
            this.lblTodate.AutoSize = true;
            this.lblTodate.ForeColor = System.Drawing.Color.White;
            this.lblTodate.Location = new System.Drawing.Point(488, 19);
            this.lblTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTodate.Name = "lblTodate";
            this.lblTodate.Size = new System.Drawing.Size(46, 13);
            this.lblTodate.TabIndex = 1380;
            this.lblTodate.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1382;
            this.label7.Text = "From Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1400;
            this.label9.Text = "Area ";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(110, 92);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(200, 21);
            this.cmbArea.TabIndex = 6;
            this.cmbArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArea_KeyDown);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(110, 66);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 4;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1397;
            this.label1.Text = "Cash / Party";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1396;
            this.label6.Text = "Voucher Type";
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(110, 40);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 2;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1402;
            this.label3.Text = "Sales Mode";
            // 
            // cmbSalesMode
            // 
            this.cmbSalesMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMode.FormattingEnabled = true;
            this.cmbSalesMode.Items.AddRange(new object[] {
            "All",
            "NA",
            "Against SalesOrder",
            "Against SalesQuotation",
            "Against DeliveryNote"});
            this.cmbSalesMode.Location = new System.Drawing.Point(110, 118);
            this.cmbSalesMode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMode.Name = "cmbSalesMode";
            this.cmbSalesMode.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMode.TabIndex = 8;
            this.cmbSalesMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1404;
            this.label5.Text = "Sales Man";
            // 
            // cmbSalesMan
            // 
            this.cmbSalesMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesMan.FormattingEnabled = true;
            this.cmbSalesMan.Location = new System.Drawing.Point(110, 144);
            this.cmbSalesMan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesMan.Name = "cmbSalesMan";
            this.cmbSalesMan.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesMan.TabIndex = 10;
            this.cmbSalesMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesMan_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductCode.Location = new System.Drawing.Point(488, 148);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 1414;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblModelNo
            // 
            this.lblModelNo.AutoSize = true;
            this.lblModelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModelNo.Location = new System.Drawing.Point(488, 122);
            this.lblModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Size = new System.Drawing.Size(53, 13);
            this.lblModelNo.TabIndex = 1412;
            this.lblModelNo.Text = "Model No";
            // 
            // cmbModelNo
            // 
            this.cmbModelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNo.FormattingEnabled = true;
            this.cmbModelNo.Location = new System.Drawing.Point(579, 118);
            this.cmbModelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbModelNo.Name = "cmbModelNo";
            this.cmbModelNo.Size = new System.Drawing.Size(200, 21);
            this.cmbModelNo.TabIndex = 9;
            this.cmbModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbModelNo_KeyDown);
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoute.Location = new System.Drawing.Point(488, 96);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(36, 13);
            this.lblRoute.TabIndex = 1410;
            this.lblRoute.Text = "Route";
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(579, 92);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(200, 21);
            this.cmbRoute.TabIndex = 7;
            this.cmbRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRoute_KeyDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Full",
            "Partial",
            "Unpaid",
            "Due"});
            this.cmbStatus.Location = new System.Drawing.Point(579, 66);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(488, 70);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1407;
            this.lblStatus.Text = "Status";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherNo.Location = new System.Drawing.Point(488, 44);
            this.lblVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherNo.TabIndex = 1406;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(670, 170);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(579, 170);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSIReport
            // 
            this.dgvSIReport.AllowUserToAddRows = false;
            this.dgvSIReport.AllowUserToResizeRows = false;
            this.dgvSIReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSIReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSIReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSIReport.ColumnHeadersHeight = 35;
            this.dgvSIReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSIReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtSalesMasterId,
            this.dgvtxtVoucherType,
            this.dgvtxtVoucherNo,
            this.dgvtxtVoucherDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtBillAmount,
            this.dgvtxtNarration,
            this.dgvtxtCurrency,
            this.dgvtxtQONno,
            this.dgvtxtDoneBy,
            this.dgvtxtPOS,
            this.creditPeriod,
            this.ledgerId,
            this.totalCreditAmt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSIReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSIReport.EnableHeadersVisualStyles = false;
            this.dgvSIReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSIReport.Location = new System.Drawing.Point(18, 200);
            this.dgvSIReport.MultiSelect = false;
            this.dgvSIReport.Name = "dgvSIReport";
            this.dgvSIReport.ReadOnly = true;
            this.dgvSIReport.RowHeadersVisible = false;
            this.dgvSIReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSIReport.Size = new System.Drawing.Size(764, 354);
            this.dgvSIReport.TabIndex = 1417;
            this.dgvSIReport.TabStop = false;
            this.dgvSIReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSIReport_CellDoubleClick);
            this.dgvSIReport.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSIReport_RowsAdded);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(599, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyUp);
            // 
            // dtpFrmDate
            // 
            this.dtpFrmDate.Location = new System.Drawing.Point(290, 15);
            this.dtpFrmDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFrmDate.Name = "dtpFrmDate";
            this.dtpFrmDate.Size = new System.Drawing.Size(21, 20);
            this.dtpFrmDate.TabIndex = 1466;
            this.dtpFrmDate.ValueChanged += new System.EventHandler(this.dtpFrmDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(110, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(758, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpToDate.TabIndex = 1468;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(579, 15);
            this.txtTodate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(182, 20);
            this.txtTodate.TabIndex = 1;
            this.txtTodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTodate_KeyDown);
            this.txtTodate.Leave += new System.EventHandler(this.txtTodate_Leave);
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(579, 41);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 20);
            this.txtVoucherNo.TabIndex = 3;
            this.txtVoucherNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVoucherNo_KeyDown);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(579, 143);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(200, 20);
            this.txtProductCode.TabIndex = 11;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(110, 170);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 12;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(20, 170);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1472;
            this.lblProductName.Text = "Product Name";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(690, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.HeaderText = "SlNo";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 76;
            // 
            // dgvtxtSalesMasterId
            // 
            this.dgvtxtSalesMasterId.DataPropertyName = "salesMasterId";
            this.dgvtxtSalesMasterId.HeaderText = "SalesMasterId";
            this.dgvtxtSalesMasterId.Name = "dgvtxtSalesMasterId";
            this.dgvtxtSalesMasterId.ReadOnly = true;
            this.dgvtxtSalesMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesMasterId.Visible = false;
            // 
            // dgvtxtVoucherType
            // 
            this.dgvtxtVoucherType.DataPropertyName = "voucherTypeName";
            this.dgvtxtVoucherType.HeaderText = "Voucher Type";
            this.dgvtxtVoucherType.Name = "dgvtxtVoucherType";
            this.dgvtxtVoucherType.ReadOnly = true;
            this.dgvtxtVoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherType.Width = 76;
            // 
            // dgvtxtVoucherNo
            // 
            this.dgvtxtVoucherNo.DataPropertyName = "invoiceNo";
            this.dgvtxtVoucherNo.HeaderText = "Voucher No";
            this.dgvtxtVoucherNo.Name = "dgvtxtVoucherNo";
            this.dgvtxtVoucherNo.ReadOnly = true;
            this.dgvtxtVoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherNo.Width = 76;
            // 
            // dgvtxtVoucherDate
            // 
            this.dgvtxtVoucherDate.DataPropertyName = "date";
            this.dgvtxtVoucherDate.HeaderText = "Voucher Date";
            this.dgvtxtVoucherDate.Name = "dgvtxtVoucherDate";
            this.dgvtxtVoucherDate.ReadOnly = true;
            this.dgvtxtVoucherDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtVoucherDate.Width = 76;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "CashOrParty";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCashOrParty.Width = 76;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "grandTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBillAmount.Width = 77;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 76;
            // 
            // dgvtxtCurrency
            // 
            this.dgvtxtCurrency.DataPropertyName = "currencyName";
            this.dgvtxtCurrency.HeaderText = "Currency";
            this.dgvtxtCurrency.Name = "dgvtxtCurrency";
            this.dgvtxtCurrency.ReadOnly = true;
            this.dgvtxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrency.Width = 76;
            // 
            // dgvtxtQONno
            // 
            this.dgvtxtQONno.DataPropertyName = "invoiceRefNo";
            this.dgvtxtQONno.HeaderText = "Quotation/Order/NoteNo";
            this.dgvtxtQONno.Name = "dgvtxtQONno";
            this.dgvtxtQONno.ReadOnly = true;
            this.dgvtxtQONno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtQONno.Width = 76;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDoneBy.Width = 76;
            // 
            // dgvtxtPOS
            // 
            this.dgvtxtPOS.DataPropertyName = "POS";
            this.dgvtxtPOS.HeaderText = "POS";
            this.dgvtxtPOS.Name = "dgvtxtPOS";
            this.dgvtxtPOS.ReadOnly = true;
            this.dgvtxtPOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPOS.Visible = false;
            // 
            // creditPeriod
            // 
            this.creditPeriod.DataPropertyName = "creditPeriod";
            this.creditPeriod.HeaderText = "creditPeriod";
            this.creditPeriod.Name = "creditPeriod";
            this.creditPeriod.ReadOnly = true;
            this.creditPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.creditPeriod.Visible = false;
            // 
            // ledgerId
            // 
            this.ledgerId.DataPropertyName = "ledgerId";
            this.ledgerId.HeaderText = "ledgerId";
            this.ledgerId.Name = "ledgerId";
            this.ledgerId.ReadOnly = true;
            this.ledgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ledgerId.Visible = false;
            // 
            // totalCreditAmt
            // 
            this.totalCreditAmt.DataPropertyName = "totalCreditAmt";
            this.totalCreditAmt.HeaderText = "totalCreditAmt";
            this.totalCreditAmt.Name = "totalCreditAmt";
            this.totalCreditAmt.ReadOnly = true;
            this.totalCreditAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.totalCreditAmt.Visible = false;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtTodate);
            this.Controls.Add(this.dtpFrmDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvSIReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblModelNo);
            this.Controls.Add(this.cmbModelNo);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSalesMan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSalesMode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblTodate);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesReport";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSalesMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSalesMan;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblModelNo;
        private System.Windows.Forms.ComboBox cmbModelNo;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSIReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFrmDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtTodate;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtVoucherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtQONno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ledgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCreditAmt;
    }
}