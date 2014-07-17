namespace Open_Miracle
{
    partial class frmSalesOrderRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderRegister));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSalesOrderNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnOverdue = new System.Windows.Forms.RadioButton();
            this.rbtnPendingOrder = new System.Windows.Forms.RadioButton();
            this.rbtnCancelled = new System.Windows.Forms.RadioButton();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSalesOrderRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesQuotationVoucherTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesQuotationMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSalesOrderMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(583, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 27);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRefresh_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(674, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.Location = new System.Drawing.Point(581, 40);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 3;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1172;
            this.label4.Text = "Cash / Party";
            // 
            // cmbSalesOrderNo
            // 
            this.cmbSalesOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesOrderNo.Location = new System.Drawing.Point(125, 40);
            this.cmbSalesOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbSalesOrderNo.Name = "cmbSalesOrderNo";
            this.cmbSalesOrderNo.Size = new System.Drawing.Size(200, 21);
            this.cmbSalesOrderNo.TabIndex = 2;
            this.cmbSalesOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesOrderNo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1170;
            this.label8.Text = "Sales Order No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1167;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1165;
            this.label2.Text = "From Date";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(125, 67);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 4;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnAll_KeyDown);
            // 
            // rbtnOverdue
            // 
            this.rbtnOverdue.AutoSize = true;
            this.rbtnOverdue.ForeColor = System.Drawing.Color.White;
            this.rbtnOverdue.Location = new System.Drawing.Point(203, 89);
            this.rbtnOverdue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnOverdue.Name = "rbtnOverdue";
            this.rbtnOverdue.Size = new System.Drawing.Size(66, 17);
            this.rbtnOverdue.TabIndex = 7;
            this.rbtnOverdue.TabStop = true;
            this.rbtnOverdue.Text = "Overdue";
            this.rbtnOverdue.UseVisualStyleBackColor = true;
            this.rbtnOverdue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnOverdue_KeyDown);
            // 
            // rbtnPendingOrder
            // 
            this.rbtnPendingOrder.AutoSize = true;
            this.rbtnPendingOrder.ForeColor = System.Drawing.Color.White;
            this.rbtnPendingOrder.Location = new System.Drawing.Point(203, 67);
            this.rbtnPendingOrder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnPendingOrder.Name = "rbtnPendingOrder";
            this.rbtnPendingOrder.Size = new System.Drawing.Size(93, 17);
            this.rbtnPendingOrder.TabIndex = 5;
            this.rbtnPendingOrder.TabStop = true;
            this.rbtnPendingOrder.Text = "Pending Order";
            this.rbtnPendingOrder.UseVisualStyleBackColor = true;
            this.rbtnPendingOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnPendingOrder_KeyDown);
            // 
            // rbtnCancelled
            // 
            this.rbtnCancelled.AutoSize = true;
            this.rbtnCancelled.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelled.Location = new System.Drawing.Point(125, 89);
            this.rbtnCancelled.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnCancelled.Name = "rbtnCancelled";
            this.rbtnCancelled.Size = new System.Drawing.Size(72, 17);
            this.rbtnCancelled.TabIndex = 6;
            this.rbtnCancelled.TabStop = true;
            this.rbtnCancelled.Text = "Cancelled";
            this.rbtnCancelled.UseVisualStyleBackColor = true;
            this.rbtnCancelled.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnCancelled_KeyDown);
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
            // dgvSalesOrderRegister
            // 
            this.dgvSalesOrderRegister.AllowUserToAddRows = false;
            this.dgvSalesOrderRegister.AllowUserToDeleteRows = false;
            this.dgvSalesOrderRegister.AllowUserToResizeRows = false;
            this.dgvSalesOrderRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesOrderRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrderRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOrderRegister.ColumnHeadersHeight = 35;
            this.dgvSalesOrderRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesOrderRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.Column2,
            this.Column1,
            this.salesQuotationVoucherTypeId,
            this.dgvtxtOrderNo,
            this.dgvtxtDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtBillAmount,
            this.dgvtxtNarration,
            this.dgvtxtDueDate,
            this.dgvtxtCurrency,
            this.dgvtxtSalesQuotationMasterId,
            this.dgvtxtDoneBy,
            this.employeeId,
            this.dgvtxtSalesOrderMasterId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrderRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesOrderRegister.EnableHeadersVisualStyles = false;
            this.dgvSalesOrderRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSalesOrderRegister.Location = new System.Drawing.Point(18, 109);
            this.dgvSalesOrderRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvSalesOrderRegister.Name = "dgvSalesOrderRegister";
            this.dgvSalesOrderRegister.ReadOnly = true;
            this.dgvSalesOrderRegister.RowHeadersVisible = false;
            this.dgvSalesOrderRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrderRegister.Size = new System.Drawing.Size(764, 443);
            this.dgvSalesOrderRegister.TabIndex = 7;
            this.dgvSalesOrderRegister.TabStop = false;
            this.dgvSalesOrderRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderRegister_CellDoubleClick);
            this.dgvSalesOrderRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSalesOrderRegister_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceNo";
            this.Column2.HeaderText = "VoucherNo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "voucherTypeName";
            this.Column1.HeaderText = "VoucherTypeName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // salesQuotationVoucherTypeId
            // 
            this.salesQuotationVoucherTypeId.DataPropertyName = "salesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.HeaderText = "SalesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.Name = "salesQuotationVoucherTypeId";
            this.salesQuotationVoucherTypeId.ReadOnly = true;
            this.salesQuotationVoucherTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.salesQuotationVoucherTypeId.Visible = false;
            // 
            // dgvtxtOrderNo
            // 
            this.dgvtxtOrderNo.DataPropertyName = "QuotationNo";
            this.dgvtxtOrderNo.HeaderText = "Order No";
            this.dgvtxtOrderNo.Name = "dgvtxtOrderNo";
            this.dgvtxtOrderNo.ReadOnly = true;
            this.dgvtxtOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtOrderNo.Visible = false;
            this.dgvtxtOrderNo.Width = 95;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDate.Width = 95;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCashOrParty.Visible = false;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "totalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dgvtxtBillAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtBillAmount.Width = 96;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtNarration.Width = 95;
            // 
            // dgvtxtDueDate
            // 
            this.dgvtxtDueDate.DataPropertyName = "dueDate";
            this.dgvtxtDueDate.HeaderText = "Due Date";
            this.dgvtxtDueDate.Name = "dgvtxtDueDate";
            this.dgvtxtDueDate.ReadOnly = true;
            this.dgvtxtDueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDueDate.Width = 95;
            // 
            // dgvtxtCurrency
            // 
            this.dgvtxtCurrency.DataPropertyName = "currencyName";
            this.dgvtxtCurrency.HeaderText = "Currency";
            this.dgvtxtCurrency.Name = "dgvtxtCurrency";
            this.dgvtxtCurrency.ReadOnly = true;
            this.dgvtxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrency.Width = 95;
            // 
            // dgvtxtSalesQuotationMasterId
            // 
            this.dgvtxtSalesQuotationMasterId.DataPropertyName = "quotationMasterId";
            this.dgvtxtSalesQuotationMasterId.HeaderText = "QuotationNo";
            this.dgvtxtSalesQuotationMasterId.Name = "dgvtxtSalesQuotationMasterId";
            this.dgvtxtSalesQuotationMasterId.ReadOnly = true;
            this.dgvtxtSalesQuotationMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesQuotationMasterId.Visible = false;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDoneBy.Width = 95;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "EmployeeId";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.employeeId.Visible = false;
            // 
            // dgvtxtSalesOrderMasterId
            // 
            this.dgvtxtSalesOrderMasterId.DataPropertyName = "salesOrderMasterId";
            this.dgvtxtSalesOrderMasterId.HeaderText = "ID";
            this.dgvtxtSalesOrderMasterId.Name = "dgvtxtSalesOrderMasterId";
            this.dgvtxtSalesOrderMasterId.ReadOnly = true;
            this.dgvtxtSalesOrderMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSalesOrderMasterId.Visible = false;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(125, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(181, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Location = new System.Drawing.Point(303, 15);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(22, 20);
            this.dtpFromDate.TabIndex = 1289;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(581, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(181, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Location = new System.Drawing.Point(759, 15);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(22, 20);
            this.dtpToDate.TabIndex = 1291;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // frmSalesOrderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbtnCancelled);
            this.Controls.Add(this.rbtnPendingOrder);
            this.Controls.Add(this.rbtnOverdue);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSalesOrderNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalesOrderRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSalesOrderRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order Register";
            this.Load += new System.EventHandler(this.frmSalesOrderRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesOrderRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSalesOrderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnOverdue;
        private System.Windows.Forms.RadioButton rbtnPendingOrder;
        private System.Windows.Forms.RadioButton rbtnCancelled;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSalesOrderRegister;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesQuotationVoucherTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesQuotationMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSalesOrderMasterId;
    }
}