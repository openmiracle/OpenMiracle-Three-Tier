namespace Open_Miracle
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNarration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.dgvtxtColumnSLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDailyAttendanceDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtdailyAttendanceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtColumnEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtColumnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbcolumnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtColumnnarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNarrationInMaster = new System.Windows.Forms.TextBox();
            this.txtCompanyCurrentdate = new System.Windows.Forms.TextBox();
            this.dtpCompanyCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblHolidayChecking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(702, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Open_Miracle.Properties.Resources.button_delete;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(611, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNarration.Location = new System.Drawing.Point(427, 467);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(50, 13);
            this.lblNarration.TabIndex = 48;
            this.lblNarration.Text = "Narration";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(492, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(429, 560);
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
            this.btnClear.Location = new System.Drawing.Point(520, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeColumns = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeight = 25;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtColumnSLNO,
            this.dgvtxtDailyAttendanceDetailsId,
            this.dgvtxtdailyAttendanceMasterId,
            this.dgvtxtColumnEmployeeCode,
            this.dgvtxtEmployeeName,
            this.dgvtxtColumnEmployeeId,
            this.dgvcmbcolumnStatus,
            this.dgvtxtColumnnarration,
            this.MasterNarration});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAttendance.Location = new System.Drawing.Point(18, 41);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(770, 418);
            this.dgvAttendance.TabIndex = 1;
            this.dgvAttendance.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAttendance_CurrentCellDirtyStateChanged);
            this.dgvAttendance.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAttendance_DataBindingComplete);
            this.dgvAttendance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAttendance_KeyDown);
            // 
            // dgvtxtColumnSLNO
            // 
            this.dgvtxtColumnSLNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvtxtColumnSLNO.DataPropertyName = "Sl NO";
            this.dgvtxtColumnSLNO.HeaderText = "Sl No";
            this.dgvtxtColumnSLNO.Name = "dgvtxtColumnSLNO";
            this.dgvtxtColumnSLNO.ReadOnly = true;
            this.dgvtxtColumnSLNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtColumnSLNO.Width = 153;
            // 
            // dgvtxtDailyAttendanceDetailsId
            // 
            this.dgvtxtDailyAttendanceDetailsId.DataPropertyName = "dailyAttendanceDetailsId";
            this.dgvtxtDailyAttendanceDetailsId.HeaderText = "DailyAttendanceDetailsId";
            this.dgvtxtDailyAttendanceDetailsId.Name = "dgvtxtDailyAttendanceDetailsId";
            this.dgvtxtDailyAttendanceDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDailyAttendanceDetailsId.Visible = false;
            // 
            // dgvtxtdailyAttendanceMasterId
            // 
            this.dgvtxtdailyAttendanceMasterId.DataPropertyName = "dailyAttendanceMasterId";
            this.dgvtxtdailyAttendanceMasterId.HeaderText = "DailyAttendanceMasterId";
            this.dgvtxtdailyAttendanceMasterId.Name = "dgvtxtdailyAttendanceMasterId";
            this.dgvtxtdailyAttendanceMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtdailyAttendanceMasterId.Visible = false;
            // 
            // dgvtxtColumnEmployeeCode
            // 
            this.dgvtxtColumnEmployeeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvtxtColumnEmployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtColumnEmployeeCode.HeaderText = "Employee Code";
            this.dgvtxtColumnEmployeeCode.Name = "dgvtxtColumnEmployeeCode";
            this.dgvtxtColumnEmployeeCode.ReadOnly = true;
            this.dgvtxtColumnEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtColumnEmployeeCode.Width = 154;
            // 
            // dgvtxtEmployeeName
            // 
            this.dgvtxtEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvtxtEmployeeName.DataPropertyName = "employeeName";
            this.dgvtxtEmployeeName.HeaderText = "Employee Name";
            this.dgvtxtEmployeeName.Name = "dgvtxtEmployeeName";
            this.dgvtxtEmployeeName.ReadOnly = true;
            this.dgvtxtEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtEmployeeName.Width = 153;
            // 
            // dgvtxtColumnEmployeeId
            // 
            this.dgvtxtColumnEmployeeId.DataPropertyName = "employeeId";
            this.dgvtxtColumnEmployeeId.HeaderText = "Employee Id";
            this.dgvtxtColumnEmployeeId.Name = "dgvtxtColumnEmployeeId";
            this.dgvtxtColumnEmployeeId.ReadOnly = true;
            this.dgvtxtColumnEmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtColumnEmployeeId.Visible = false;
            // 
            // dgvcmbcolumnStatus
            // 
            this.dgvcmbcolumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcmbcolumnStatus.DataPropertyName = "status";
            dataGridViewCellStyle2.NullValue = "Present";
            this.dgvcmbcolumnStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcmbcolumnStatus.HeaderText = "Status";
            this.dgvcmbcolumnStatus.Items.AddRange(new object[] {
            "Present",
            "Half Day",
            "Absent"});
            this.dgvcmbcolumnStatus.Name = "dgvcmbcolumnStatus";
            this.dgvcmbcolumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbcolumnStatus.Width = 154;
            // 
            // dgvtxtColumnnarration
            // 
            this.dgvtxtColumnnarration.DataPropertyName = "narration";
            this.dgvtxtColumnnarration.HeaderText = "Narration";
            this.dgvtxtColumnnarration.Name = "dgvtxtColumnnarration";
            this.dgvtxtColumnnarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MasterNarration
            // 
            this.MasterNarration.DataPropertyName = "MasterNarration";
            this.MasterNarration.HeaderText = "MasterNarration";
            this.MasterNarration.Name = "MasterNarration";
            this.MasterNarration.Visible = false;
            // 
            // txtNarrationInMaster
            // 
            this.txtNarrationInMaster.Location = new System.Drawing.Point(538, 467);
            this.txtNarrationInMaster.Margin = new System.Windows.Forms.Padding(5);
            this.txtNarrationInMaster.Multiline = true;
            this.txtNarrationInMaster.Name = "txtNarrationInMaster";
            this.txtNarrationInMaster.Size = new System.Drawing.Size(250, 85);
            this.txtNarrationInMaster.TabIndex = 2;
            this.txtNarrationInMaster.Enter += new System.EventHandler(this.txtNarrationInMaster_Enter);
            this.txtNarrationInMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarrationInMaster_KeyDown);
            this.txtNarrationInMaster.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNarrationInMaster_KeyPress);
            // 
            // txtCompanyCurrentdate
            // 
            this.txtCompanyCurrentdate.Location = new System.Drawing.Point(587, 13);
            this.txtCompanyCurrentdate.Margin = new System.Windows.Forms.Padding(5);
            this.txtCompanyCurrentdate.Name = "txtCompanyCurrentdate";
            this.txtCompanyCurrentdate.Size = new System.Drawing.Size(179, 20);
            this.txtCompanyCurrentdate.TabIndex = 0;
            this.txtCompanyCurrentdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyCurrentdate_KeyDown);
            this.txtCompanyCurrentdate.Leave += new System.EventHandler(this.txtCompanyCurrentdate_Leave);
            // 
            // dtpCompanyCurrentDate
            // 
            this.dtpCompanyCurrentDate.CustomFormat = "dd MMMM yyyy";
            this.dtpCompanyCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCompanyCurrentDate.Location = new System.Drawing.Point(765, 13);
            this.dtpCompanyCurrentDate.Name = "dtpCompanyCurrentDate";
            this.dtpCompanyCurrentDate.Size = new System.Drawing.Size(22, 20);
            this.dtpCompanyCurrentDate.TabIndex = 22;
            this.dtpCompanyCurrentDate.TabStop = false;
            this.dtpCompanyCurrentDate.ValueChanged += new System.EventHandler(this.dtpCompanyCurrentDate_ValueChanged);
            this.dtpCompanyCurrentDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpCompanyCurrenttime_KeyDown);
            // 
            // lblHolidayChecking
            // 
            this.lblHolidayChecking.AutoSize = true;
            this.lblHolidayChecking.ForeColor = System.Drawing.Color.Red;
            this.lblHolidayChecking.Location = new System.Drawing.Point(27, 13);
            this.lblHolidayChecking.Name = "lblHolidayChecking";
            this.lblHolidayChecking.Size = new System.Drawing.Size(0, 13);
            this.lblHolidayChecking.TabIndex = 49;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.lblHolidayChecking);
            this.Controls.Add(this.dtpCompanyCurrentDate);
            this.Controls.Add(this.txtCompanyCurrentdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.txtNarrationInMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAttendance";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAttendance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TextBox txtNarrationInMaster;
        private System.Windows.Forms.TextBox txtCompanyCurrentdate;
        private System.Windows.Forms.DateTimePicker dtpCompanyCurrentDate;
        private System.Windows.Forms.Label lblHolidayChecking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtColumnSLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDailyAttendanceDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtdailyAttendanceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtColumnEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtColumnEmployeeId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbcolumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtColumnnarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterNarration;
    }
}