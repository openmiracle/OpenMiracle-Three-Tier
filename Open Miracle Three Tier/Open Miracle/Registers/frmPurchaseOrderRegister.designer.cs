namespace Open_Miracle
{
    partial class frmPurchaseOrderRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrderRegister));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnOverdue = new System.Windows.Forms.RadioButton();
            this.rbtnPendingOrder = new System.Windows.Forms.RadioButton();
            this.rbtnCancelled = new System.Windows.Forms.RadioButton();
            this.cmbCashOrParty = new System.Windows.Forms.ComboBox();
            this.lblCashOrParty = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvPurchaseOrderRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCashOrParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPurchaseOrderMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(23, 19);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1203;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(474, 19);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 1201;
            this.lblToDate.Text = "To Date";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(131, 43);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rbtnAll.Size = new System.Drawing.Size(36, 22);
            this.rbtnAll.TabIndex = 2;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnAll_KeyDown);
            // 
            // rbtnOverdue
            // 
            this.rbtnOverdue.AutoSize = true;
            this.rbtnOverdue.ForeColor = System.Drawing.Color.White;
            this.rbtnOverdue.Location = new System.Drawing.Point(131, 65);
            this.rbtnOverdue.Name = "rbtnOverdue";
            this.rbtnOverdue.Size = new System.Drawing.Size(66, 17);
            this.rbtnOverdue.TabIndex = 4;
            this.rbtnOverdue.TabStop = true;
            this.rbtnOverdue.Text = "Overdue";
            this.rbtnOverdue.UseVisualStyleBackColor = true;
            this.rbtnOverdue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnOverdue_KeyDown);
            // 
            // rbtnPendingOrder
            // 
            this.rbtnPendingOrder.AutoSize = true;
            this.rbtnPendingOrder.ForeColor = System.Drawing.Color.White;
            this.rbtnPendingOrder.Location = new System.Drawing.Point(203, 43);
            this.rbtnPendingOrder.Name = "rbtnPendingOrder";
            this.rbtnPendingOrder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rbtnPendingOrder.Size = new System.Drawing.Size(93, 22);
            this.rbtnPendingOrder.TabIndex = 3;
            this.rbtnPendingOrder.TabStop = true;
            this.rbtnPendingOrder.Text = "Pending Order";
            this.rbtnPendingOrder.UseVisualStyleBackColor = true;
            this.rbtnPendingOrder.CheckedChanged += new System.EventHandler(this.rbtnPendingOrder_CheckedChanged);
            this.rbtnPendingOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnPendingOrder_KeyDown);
            // 
            // rbtnCancelled
            // 
            this.rbtnCancelled.AutoSize = true;
            this.rbtnCancelled.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelled.Location = new System.Drawing.Point(203, 65);
            this.rbtnCancelled.Name = "rbtnCancelled";
            this.rbtnCancelled.Size = new System.Drawing.Size(72, 17);
            this.rbtnCancelled.TabIndex = 5;
            this.rbtnCancelled.TabStop = true;
            this.rbtnCancelled.Text = "Cancelled";
            this.rbtnCancelled.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtnCancelled_KeyDown);
            // 
            // cmbCashOrParty
            // 
            this.cmbCashOrParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashOrParty.FormattingEnabled = true;
            this.cmbCashOrParty.Location = new System.Drawing.Point(580, 65);
            this.cmbCashOrParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbCashOrParty.Name = "cmbCashOrParty";
            this.cmbCashOrParty.Size = new System.Drawing.Size(200, 21);
            this.cmbCashOrParty.TabIndex = 7;
            this.cmbCashOrParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCashOrParty_KeyDown);
            // 
            // lblCashOrParty
            // 
            this.lblCashOrParty.AutoSize = true;
            this.lblCashOrParty.ForeColor = System.Drawing.Color.White;
            this.lblCashOrParty.Location = new System.Drawing.Point(474, 69);
            this.lblCashOrParty.Name = "lblCashOrParty";
            this.lblCashOrParty.Size = new System.Drawing.Size(66, 13);
            this.lblCashOrParty.TabIndex = 1209;
            this.lblCashOrParty.Text = "Cash / Party";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(580, 40);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(201, 20);
            this.txtOrderNo.TabIndex = 6;
            this.txtOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNo_KeyDown);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.ForeColor = System.Drawing.Color.White;
            this.lblOrderNo.Location = new System.Drawing.Point(474, 44);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNo.TabIndex = 1211;
            this.lblOrderNo.Text = "Order No";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(580, 89);
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
            this.btnReset.Location = new System.Drawing.Point(671, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // dgvPurchaseOrderRegister
            // 
            this.dgvPurchaseOrderRegister.AllowUserToAddRows = false;
            this.dgvPurchaseOrderRegister.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderRegister.AllowUserToResizeRows = false;
            this.dgvPurchaseOrderRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrderRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseOrderRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrderRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrderRegister.ColumnHeadersHeight = 35;
            this.dgvPurchaseOrderRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseOrderRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtOrderNo,
            this.Column2,
            this.dgvtxtDate,
            this.dgvtxtDueDate,
            this.dgvtxtCashOrParty,
            this.dgvtxtCurrency,
            this.dgvtxtBillAmount,
            this.dgvtxtDoneBy,
            this.dgvtxtNarration,
            this.dgvtxtPurchaseOrderMasterId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrderRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseOrderRegister.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrderRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPurchaseOrderRegister.Location = new System.Drawing.Point(18, 122);
            this.dgvPurchaseOrderRegister.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dgvPurchaseOrderRegister.Name = "dgvPurchaseOrderRegister";
            this.dgvPurchaseOrderRegister.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrderRegister.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseOrderRegister.RowHeadersVisible = false;
            this.dgvPurchaseOrderRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrderRegister.Size = new System.Drawing.Size(764, 430);
            this.dgvPurchaseOrderRegister.TabIndex = 9;
            this.dgvPurchaseOrderRegister.TabStop = false;
            this.dgvPurchaseOrderRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrderRegister_CellDoubleClick);
            this.dgvPurchaseOrderRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseOrderRegister_KeyDown);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOrderNo
            // 
            this.dgvtxtOrderNo.DataPropertyName = "invoiceNo";
            this.dgvtxtOrderNo.HeaderText = "Order No";
            this.dgvtxtOrderNo.Name = "dgvtxtOrderNo";
            this.dgvtxtOrderNo.ReadOnly = true;
            this.dgvtxtOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "voucherTypeName";
            this.Column2.HeaderText = "Voucher Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDueDate
            // 
            this.dgvtxtDueDate.DataPropertyName = "dueDate";
            this.dgvtxtDueDate.HeaderText = "Due Date";
            this.dgvtxtDueDate.Name = "dgvtxtDueDate";
            this.dgvtxtDueDate.ReadOnly = true;
            this.dgvtxtDueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCashOrParty
            // 
            this.dgvtxtCashOrParty.DataPropertyName = "ledgerName";
            this.dgvtxtCashOrParty.HeaderText = "Cash / Party";
            this.dgvtxtCashOrParty.Name = "dgvtxtCashOrParty";
            this.dgvtxtCashOrParty.ReadOnly = true;
            this.dgvtxtCashOrParty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCurrency
            // 
            this.dgvtxtCurrency.DataPropertyName = "currencyName";
            this.dgvtxtCurrency.HeaderText = "Currency";
            this.dgvtxtCurrency.Name = "dgvtxtCurrency";
            this.dgvtxtCurrency.ReadOnly = true;
            this.dgvtxtCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtCurrency.Visible = false;
            // 
            // dgvtxtBillAmount
            // 
            this.dgvtxtBillAmount.DataPropertyName = "totalAmount";
            this.dgvtxtBillAmount.HeaderText = "Bill Amount";
            this.dgvtxtBillAmount.Name = "dgvtxtBillAmount";
            this.dgvtxtBillAmount.ReadOnly = true;
            this.dgvtxtBillAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDoneBy
            // 
            this.dgvtxtDoneBy.DataPropertyName = "userName";
            this.dgvtxtDoneBy.HeaderText = "Done By";
            this.dgvtxtDoneBy.Name = "dgvtxtDoneBy";
            this.dgvtxtDoneBy.ReadOnly = true;
            this.dgvtxtDoneBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.ReadOnly = true;
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtPurchaseOrderMasterId
            // 
            this.dgvtxtPurchaseOrderMasterId.DataPropertyName = "purchaseOrderMasterId";
            this.dgvtxtPurchaseOrderMasterId.HeaderText = "ID";
            this.dgvtxtPurchaseOrderMasterId.Name = "dgvtxtPurchaseOrderMasterId";
            this.dgvtxtPurchaseOrderMasterId.ReadOnly = true;
            this.dgvtxtPurchaseOrderMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtPurchaseOrderMasterId.Visible = false;
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
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(131, 15);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(171, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(580, 15);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(760, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(20, 20);
            this.dtpToDate.TabIndex = 1220;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(301, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(18, 20);
            this.dtpFromDate.TabIndex = 1221;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // frmPurchaseOrderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dgvPurchaseOrderRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.cmbCashOrParty);
            this.Controls.Add(this.lblCashOrParty);
            this.Controls.Add(this.rbtnCancelled);
            this.Controls.Add(this.rbtnPendingOrder);
            this.Controls.Add(this.rbtnOverdue);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblToDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseOrderRegister";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Register";
            this.Load += new System.EventHandler(this.frmPurchaseOrderRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseOrderRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnOverdue;
        private System.Windows.Forms.RadioButton rbtnPendingOrder;
        private System.Windows.Forms.RadioButton rbtnCancelled;
        private System.Windows.Forms.ComboBox cmbCashOrParty;
        private System.Windows.Forms.Label lblCashOrParty;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCashOrParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoneBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPurchaseOrderMasterId;
    }
}