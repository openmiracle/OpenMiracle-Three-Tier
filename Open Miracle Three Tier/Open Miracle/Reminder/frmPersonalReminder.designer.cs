namespace Open_Miracle
{
    partial class frmPersonalReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonalReminder));
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblRemindAbout = new System.Windows.Forms.Label();
            this.txtRemindAbout = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.txtToDateSearch = new System.Windows.Forms.TextBox();
            this.txtFromDateSearch = new System.Windows.Forms.TextBox();
            this.dtpToDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDateSeach = new System.Windows.Forms.DateTimePicker();
            this.dgvRemainder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemindAbout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblToDateSearch = new System.Windows.Forms.Label();
            this.lblFromDateSearch = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(22, 19);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 1179;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(22, 44);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(49, 13);
            this.lblToDate.TabIndex = 1181;
            this.lblToDate.Text = "To  Date";
            // 
            // lblRemindAbout
            // 
            this.lblRemindAbout.AutoSize = true;
            this.lblRemindAbout.ForeColor = System.Drawing.Color.White;
            this.lblRemindAbout.Location = new System.Drawing.Point(22, 65);
            this.lblRemindAbout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRemindAbout.Name = "lblRemindAbout";
            this.lblRemindAbout.Size = new System.Drawing.Size(74, 13);
            this.lblRemindAbout.TabIndex = 1183;
            this.lblRemindAbout.Text = "Remind About";
            // 
            // txtRemindAbout
            // 
            this.txtRemindAbout.Location = new System.Drawing.Point(128, 65);
            this.txtRemindAbout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRemindAbout.Multiline = true;
            this.txtRemindAbout.Name = "txtRemindAbout";
            this.txtRemindAbout.Size = new System.Drawing.Size(200, 50);
            this.txtRemindAbout.TabIndex = 2;
            this.txtRemindAbout.Enter += new System.EventHandler(this.txtRemindAbout_Enter);
            this.txtRemindAbout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemindAbout_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(128, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(219, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(401, 121);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.txtToDateSearch);
            this.gbxDetails.Controls.Add(this.txtFromDateSearch);
            this.gbxDetails.Controls.Add(this.dtpToDateSearch);
            this.gbxDetails.Controls.Add(this.dtpFromDateSeach);
            this.gbxDetails.Controls.Add(this.dgvRemainder);
            this.gbxDetails.Controls.Add(this.btnSearch);
            this.gbxDetails.Controls.Add(this.lblToDateSearch);
            this.gbxDetails.Controls.Add(this.lblFromDateSearch);
            this.gbxDetails.ForeColor = System.Drawing.Color.White;
            this.gbxDetails.Location = new System.Drawing.Point(18, 154);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(764, 423);
            this.gbxDetails.TabIndex = 1202;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // txtToDateSearch
            // 
            this.txtToDateSearch.Location = new System.Drawing.Point(530, 19);
            this.txtToDateSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDateSearch.Name = "txtToDateSearch";
            this.txtToDateSearch.Size = new System.Drawing.Size(184, 20);
            this.txtToDateSearch.TabIndex = 1;
            this.txtToDateSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDateSearch_KeyDown);
            this.txtToDateSearch.Leave += new System.EventHandler(this.txtToDateSearch_Leave);
            // 
            // txtFromDateSearch
            // 
            this.txtFromDateSearch.Location = new System.Drawing.Point(110, 19);
            this.txtFromDateSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDateSearch.Name = "txtFromDateSearch";
            this.txtFromDateSearch.Size = new System.Drawing.Size(184, 20);
            this.txtFromDateSearch.TabIndex = 0;
            this.txtFromDateSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDateSearch_KeyDown);
            this.txtFromDateSearch.Leave += new System.EventHandler(this.txtFromDateSearch_Leave);
            // 
            // dtpToDateSearch
            // 
            this.dtpToDateSearch.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpToDateSearch.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDateSearch.Location = new System.Drawing.Point(713, 19);
            this.dtpToDateSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDateSearch.Name = "dtpToDateSearch";
            this.dtpToDateSearch.Size = new System.Drawing.Size(17, 20);
            this.dtpToDateSearch.TabIndex = 1209;
            this.dtpToDateSearch.ValueChanged += new System.EventHandler(this.dtpToDateSearch_ValueChanged);
            // 
            // dtpFromDateSeach
            // 
            this.dtpFromDateSeach.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpFromDateSeach.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDateSeach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDateSeach.Location = new System.Drawing.Point(292, 19);
            this.dtpFromDateSeach.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDateSeach.Name = "dtpFromDateSeach";
            this.dtpFromDateSeach.Size = new System.Drawing.Size(18, 20);
            this.dtpFromDateSeach.TabIndex = 1208;
            this.dtpFromDateSeach.ValueChanged += new System.EventHandler(this.dtpFromDateSeach_ValueChanged);
            // 
            // dgvRemainder
            // 
            this.dgvRemainder.AllowUserToAddRows = false;
            this.dgvRemainder.AllowUserToResizeRows = false;
            this.dgvRemainder.BackgroundColor = System.Drawing.Color.White;
            this.dgvRemainder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemainder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemainder.ColumnHeadersHeight = 35;
            this.dgvRemainder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRemainder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.RemindAbout,
            this.reminderId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemainder.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRemainder.EnableHeadersVisualStyles = false;
            this.dgvRemainder.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRemainder.Location = new System.Drawing.Point(16, 77);
            this.dgvRemainder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvRemainder.Name = "dgvRemainder";
            this.dgvRemainder.ReadOnly = true;
            this.dgvRemainder.RowHeadersVisible = false;
            this.dgvRemainder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemainder.Size = new System.Drawing.Size(730, 333);
            this.dgvRemainder.TabIndex = 1207;
            this.dgvRemainder.TabStop = false;
            this.dgvRemainder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemainder_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SlNo";
            this.Column1.HeaderText = "Sl No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 182;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fromDate";
            dataGridViewCellStyle2.Format = "dd-MMM-yyyy";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "From";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 182;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "toDate";
            dataGridViewCellStyle3.Format = "dd-MMM-yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 181;
            // 
            // RemindAbout
            // 
            this.RemindAbout.DataPropertyName = "remindAbout";
            this.RemindAbout.HeaderText = "Remind About";
            this.RemindAbout.Name = "RemindAbout";
            this.RemindAbout.ReadOnly = true;
            this.RemindAbout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RemindAbout.Width = 182;
            // 
            // reminderId
            // 
            this.reminderId.DataPropertyName = "reminderId";
            this.reminderId.HeaderText = "ReminderId";
            this.reminderId.Name = "reminderId";
            this.reminderId.ReadOnly = true;
            this.reminderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reminderId.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(530, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // lblToDateSearch
            // 
            this.lblToDateSearch.AutoSize = true;
            this.lblToDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblToDateSearch.Location = new System.Drawing.Point(454, 23);
            this.lblToDateSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblToDateSearch.Name = "lblToDateSearch";
            this.lblToDateSearch.Size = new System.Drawing.Size(46, 13);
            this.lblToDateSearch.TabIndex = 1206;
            this.lblToDateSearch.Text = "To Date";
            // 
            // lblFromDateSearch
            // 
            this.lblFromDateSearch.AutoSize = true;
            this.lblFromDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblFromDateSearch.Location = new System.Drawing.Point(13, 23);
            this.lblFromDateSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblFromDateSearch.Name = "lblFromDateSearch";
            this.lblFromDateSearch.Size = new System.Drawing.Size(56, 13);
            this.lblFromDateSearch.TabIndex = 1204;
            this.lblFromDateSearch.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(310, 16);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(18, 20);
            this.dtpFromDate.TabIndex = 1203;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(310, 40);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(18, 20);
            this.dtpToDate.TabIndex = 1204;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(127, 16);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(184, 20);
            this.txtFromDate.TabIndex = 0;
            this.txtFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFromDate_KeyDown);
            this.txtFromDate.Leave += new System.EventHandler(this.txtFromDate_Leave);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(127, 40);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(184, 20);
            this.txtToDate.TabIndex = 1;
            this.txtToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDate_KeyDown);
            this.txtToDate.Leave += new System.EventHandler(this.txtToDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(337, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1208;
            this.label1.Text = "*";
            // 
            // frmPersonalReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemindAbout);
            this.Controls.Add(this.lblRemindAbout);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPersonalReminder";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonalReminder_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonalReminder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPersonalReminder_KeyDown);
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblRemindAbout;
        private System.Windows.Forms.TextBox txtRemindAbout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblFromDateSearch;
        private System.Windows.Forms.Label lblToDateSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRemainder;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpToDateSearch;
        private System.Windows.Forms.DateTimePicker dtpFromDateSeach;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtToDateSearch;
        private System.Windows.Forms.TextBox txtFromDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemindAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderId;
        private System.Windows.Forms.Label label1;
    }
}