namespace Open_Miracle
{
    partial class frmChequeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeReport));
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.rbtnReceived = new System.Windows.Forms.RadioButton();
            this.rbtnPayed = new System.Windows.Forms.RadioButton();
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.lblparty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpIssueToDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueToDate = new System.Windows.Forms.TextBox();
            this.dtpIssueFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueFromDate = new System.Windows.Forms.TextBox();
            this.lblIssueToDate = new System.Windows.Forms.Label();
            this.lblIssueFromDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpChequeToDate = new System.Windows.Forms.DateTimePicker();
            this.txtChequeToDate = new System.Windows.Forms.TextBox();
            this.dtpChequeFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtChequeFromDate = new System.Windows.Forms.TextBox();
            this.lblChequeToDate = new System.Windows.Forms.Label();
            this.lblChequeFromDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvChequeReport = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.ForeColor = System.Drawing.Color.White;
            this.lblChequeNo.Location = new System.Drawing.Point(475, 41);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(61, 13);
            this.lblChequeNo.TabIndex = 1246;
            this.lblChequeNo.Text = "Cheque No";
            // 
            // rbtnReceived
            // 
            this.rbtnReceived.AutoSize = true;
            this.rbtnReceived.ForeColor = System.Drawing.Color.White;
            this.rbtnReceived.Location = new System.Drawing.Point(179, 15);
            this.rbtnReceived.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnReceived.Name = "rbtnReceived";
            this.rbtnReceived.Size = new System.Drawing.Size(71, 17);
            this.rbtnReceived.TabIndex = 1;
            this.rbtnReceived.TabStop = true;
            this.rbtnReceived.Text = "Received";
            this.rbtnReceived.UseVisualStyleBackColor = true;
            // 
            // rbtnPayed
            // 
            this.rbtnPayed.AutoSize = true;
            this.rbtnPayed.ForeColor = System.Drawing.Color.White;
            this.rbtnPayed.Location = new System.Drawing.Point(114, 15);
            this.rbtnPayed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.rbtnPayed.Name = "rbtnPayed";
            this.rbtnPayed.Size = new System.Drawing.Size(46, 17);
            this.rbtnPayed.TabIndex = 0;
            this.rbtnPayed.TabStop = true;
            this.rbtnPayed.Text = "Paid";
            this.rbtnPayed.UseVisualStyleBackColor = true;
            // 
            // cmbParty
            // 
            this.cmbParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(115, 37);
            this.cmbParty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(200, 21);
            this.cmbParty.TabIndex = 2;
            this.cmbParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbParty_KeyDown);
            // 
            // lblparty
            // 
            this.lblparty.AutoSize = true;
            this.lblparty.ForeColor = System.Drawing.Color.White;
            this.lblparty.Location = new System.Drawing.Point(20, 40);
            this.lblparty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblparty.Name = "lblparty";
            this.lblparty.Size = new System.Drawing.Size(31, 13);
            this.lblparty.TabIndex = 1252;
            this.lblparty.Text = "Party";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpIssueToDate);
            this.groupBox1.Controls.Add(this.txtIssueToDate);
            this.groupBox1.Controls.Add(this.dtpIssueFromDate);
            this.groupBox1.Controls.Add(this.txtIssueFromDate);
            this.groupBox1.Controls.Add(this.lblIssueToDate);
            this.groupBox1.Controls.Add(this.lblIssueFromDate);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(760, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Date";
            // 
            // dtpIssueToDate
            // 
            this.dtpIssueToDate.Location = new System.Drawing.Point(718, 22);
            this.dtpIssueToDate.Name = "dtpIssueToDate";
            this.dtpIssueToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpIssueToDate.TabIndex = 8678;
            this.dtpIssueToDate.ValueChanged += new System.EventHandler(this.dtpIssueToDate_ValueChanged);
            // 
            // txtIssueToDate
            // 
            this.txtIssueToDate.Location = new System.Drawing.Point(537, 22);
            this.txtIssueToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtIssueToDate.Name = "txtIssueToDate";
            this.txtIssueToDate.Size = new System.Drawing.Size(182, 20);
            this.txtIssueToDate.TabIndex = 1;
            this.txtIssueToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssueToDate_KeyDown);
            this.txtIssueToDate.Leave += new System.EventHandler(this.txtIssueToDate_Leave);
            // 
            // dtpIssueFromDate
            // 
            this.dtpIssueFromDate.Location = new System.Drawing.Point(274, 22);
            this.dtpIssueFromDate.Name = "dtpIssueFromDate";
            this.dtpIssueFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpIssueFromDate.TabIndex = 46457;
            this.dtpIssueFromDate.ValueChanged += new System.EventHandler(this.dtpIssueFromDate_ValueChanged);
            // 
            // txtIssueFromDate
            // 
            this.txtIssueFromDate.Location = new System.Drawing.Point(94, 22);
            this.txtIssueFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtIssueFromDate.Name = "txtIssueFromDate";
            this.txtIssueFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtIssueFromDate.TabIndex = 0;
            this.txtIssueFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssueFromDate_KeyDown);
            this.txtIssueFromDate.Leave += new System.EventHandler(this.txtIssueFromDate_Leave);
            // 
            // lblIssueToDate
            // 
            this.lblIssueToDate.AutoSize = true;
            this.lblIssueToDate.ForeColor = System.Drawing.Color.White;
            this.lblIssueToDate.Location = new System.Drawing.Point(455, 26);
            this.lblIssueToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblIssueToDate.Name = "lblIssueToDate";
            this.lblIssueToDate.Size = new System.Drawing.Size(46, 13);
            this.lblIssueToDate.TabIndex = 1258;
            this.lblIssueToDate.Text = "To Date";
            // 
            // lblIssueFromDate
            // 
            this.lblIssueFromDate.AutoSize = true;
            this.lblIssueFromDate.ForeColor = System.Drawing.Color.White;
            this.lblIssueFromDate.Location = new System.Drawing.Point(17, 26);
            this.lblIssueFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblIssueFromDate.Name = "lblIssueFromDate";
            this.lblIssueFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblIssueFromDate.TabIndex = 1256;
            this.lblIssueFromDate.Text = "From Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpChequeToDate);
            this.groupBox2.Controls.Add(this.txtChequeToDate);
            this.groupBox2.Controls.Add(this.dtpChequeFromDate);
            this.groupBox2.Controls.Add(this.txtChequeFromDate);
            this.groupBox2.Controls.Add(this.lblChequeToDate);
            this.groupBox2.Controls.Add(this.lblChequeFromDate);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(760, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheque Date";
            // 
            // dtpChequeToDate
            // 
            this.dtpChequeToDate.Location = new System.Drawing.Point(717, 26);
            this.dtpChequeToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpChequeToDate.Name = "dtpChequeToDate";
            this.dtpChequeToDate.Size = new System.Drawing.Size(21, 20);
            this.dtpChequeToDate.TabIndex = 67968;
            this.dtpChequeToDate.ValueChanged += new System.EventHandler(this.dtpChequeToDate_ValueChanged);
            // 
            // txtChequeToDate
            // 
            this.txtChequeToDate.Location = new System.Drawing.Point(537, 26);
            this.txtChequeToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeToDate.Name = "txtChequeToDate";
            this.txtChequeToDate.Size = new System.Drawing.Size(182, 20);
            this.txtChequeToDate.TabIndex = 1;
            this.txtChequeToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeToDate_KeyDown);
            this.txtChequeToDate.Leave += new System.EventHandler(this.txtChequeToDate_Leave);
            // 
            // dtpChequeFromDate
            // 
            this.dtpChequeFromDate.Location = new System.Drawing.Point(273, 26);
            this.dtpChequeFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpChequeFromDate.Name = "dtpChequeFromDate";
            this.dtpChequeFromDate.Size = new System.Drawing.Size(21, 20);
            this.dtpChequeFromDate.TabIndex = 5688;
            this.dtpChequeFromDate.ValueChanged += new System.EventHandler(this.dtpChequeFromDate_ValueChanged);
            // 
            // txtChequeFromDate
            // 
            this.txtChequeFromDate.Location = new System.Drawing.Point(93, 26);
            this.txtChequeFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeFromDate.Name = "txtChequeFromDate";
            this.txtChequeFromDate.Size = new System.Drawing.Size(182, 20);
            this.txtChequeFromDate.TabIndex = 0;
            this.txtChequeFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeFromDate_KeyDown);
            this.txtChequeFromDate.Leave += new System.EventHandler(this.txtChequeFromDate_Leave);
            // 
            // lblChequeToDate
            // 
            this.lblChequeToDate.AutoSize = true;
            this.lblChequeToDate.ForeColor = System.Drawing.Color.White;
            this.lblChequeToDate.Location = new System.Drawing.Point(460, 30);
            this.lblChequeToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblChequeToDate.Name = "lblChequeToDate";
            this.lblChequeToDate.Size = new System.Drawing.Size(46, 13);
            this.lblChequeToDate.TabIndex = 1258;
            this.lblChequeToDate.Text = "To Date";
            // 
            // lblChequeFromDate
            // 
            this.lblChequeFromDate.AutoSize = true;
            this.lblChequeFromDate.ForeColor = System.Drawing.Color.White;
            this.lblChequeFromDate.Location = new System.Drawing.Point(17, 30);
            this.lblChequeFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblChequeFromDate.Name = "lblChequeFromDate";
            this.lblChequeFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblChequeFromDate.TabIndex = 1256;
            this.lblChequeFromDate.Text = "From Date";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(697, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 7;
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
            this.btnSearch.Location = new System.Drawing.Point(606, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvChequeReport
            // 
            this.dgvChequeReport.AllowUserToAddRows = false;
            this.dgvChequeReport.AllowUserToDeleteRows = false;
            this.dgvChequeReport.AllowUserToResizeRows = false;
            this.dgvChequeReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvChequeReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChequeReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChequeReport.ColumnHeadersHeight = 25;
            this.dgvChequeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChequeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.VoucherType,
            this.VoucherNo,
            this.IssuedDate,
            this.Party,
            this.Amount,
            this.ChequeNo,
            this.ChequeDate,
            this.dgvtxtMasterId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChequeReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChequeReport.EnableHeadersVisualStyles = false;
            this.dgvChequeReport.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvChequeReport.Location = new System.Drawing.Point(20, 239);
            this.dgvChequeReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvChequeReport.Name = "dgvChequeReport";
            this.dgvChequeReport.ReadOnly = true;
            this.dgvChequeReport.RowHeadersVisible = false;
            this.dgvChequeReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequeReport.Size = new System.Drawing.Size(762, 318);
            this.dgvChequeReport.TabIndex = 20;
            this.dgvChequeReport.TabStop = false;
            this.dgvChequeReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequeReport_CellDoubleClick);
            // 
            // SlNo
            // 
            this.SlNo.DataPropertyName = "SlNo";
            this.SlNo.HeaderText = "Sl No";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SlNo.Width = 95;
            // 
            // VoucherType
            // 
            this.VoucherType.DataPropertyName = "Voucher Type";
            this.VoucherType.HeaderText = "Voucher Type";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.ReadOnly = true;
            this.VoucherType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherType.Width = 95;
            // 
            // VoucherNo
            // 
            this.VoucherNo.DataPropertyName = "Voucher No";
            this.VoucherNo.HeaderText = "Voucher No";
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.ReadOnly = true;
            this.VoucherNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VoucherNo.Width = 95;
            // 
            // IssuedDate
            // 
            this.IssuedDate.DataPropertyName = "Issued Date";
            this.IssuedDate.HeaderText = "Issue Date";
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            this.IssuedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IssuedDate.Width = 95;
            // 
            // Party
            // 
            this.Party.DataPropertyName = "Party";
            this.Party.HeaderText = "Party";
            this.Party.Name = "Party";
            this.Party.ReadOnly = true;
            this.Party.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Party.Width = 94;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 95;
            // 
            // ChequeNo
            // 
            this.ChequeNo.DataPropertyName = "Cheque No";
            this.ChequeNo.HeaderText = "Cheque No";
            this.ChequeNo.Name = "ChequeNo";
            this.ChequeNo.ReadOnly = true;
            this.ChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChequeNo.Width = 95;
            // 
            // ChequeDate
            // 
            this.ChequeDate.DataPropertyName = "Cheque Date";
            this.ChequeDate.HeaderText = "Cheque Date";
            this.ChequeDate.Name = "ChequeDate";
            this.ChequeDate.ReadOnly = true;
            this.ChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChequeDate.Width = 95;
            // 
            // dgvtxtMasterId
            // 
            this.dgvtxtMasterId.DataPropertyName = "masterId";
            this.dgvtxtMasterId.HeaderText = "Master Id";
            this.dgvtxtMasterId.Name = "dgvtxtMasterId";
            this.dgvtxtMasterId.ReadOnly = true;
            this.dgvtxtMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtMasterId.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(602, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(558, 37);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(222, 20);
            this.txtChequeNo.TabIndex = 3;
            this.txtChequeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChequeNo_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(693, 560);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmChequeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvChequeReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.lblparty);
            this.Controls.Add(this.rbtnReceived);
            this.Controls.Add(this.rbtnPayed);
            this.Controls.Add(this.lblChequeNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChequeReport";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Report";
            this.Load += new System.EventHandler(this.frmChequeReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChequeReport_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.RadioButton rbtnReceived;
        private System.Windows.Forms.RadioButton rbtnPayed;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.Label lblparty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIssueFromDate;
        private System.Windows.Forms.Label lblIssueToDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblChequeToDate;
        private System.Windows.Forms.Label lblChequeFromDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvChequeReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.DateTimePicker dtpIssueToDate;
        private System.Windows.Forms.TextBox txtIssueToDate;
        private System.Windows.Forms.DateTimePicker dtpIssueFromDate;
        private System.Windows.Forms.TextBox txtIssueFromDate;
        private System.Windows.Forms.DateTimePicker dtpChequeToDate;
        private System.Windows.Forms.TextBox txtChequeToDate;
        private System.Windows.Forms.DateTimePicker dtpChequeFromDate;
        private System.Windows.Forms.TextBox txtChequeFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMasterId;
        private System.Windows.Forms.Button btnExport;
    }
}