namespace Open_Miracle
{
    partial class frmHolydaySettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolydaySettings));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvHolidayRegister = new System.Windows.Forms.DataGridView();
            this.dgvtxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dgvCalender = new System.Windows.Forms.DataGridView();
            this.Sun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Mon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wed = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Fri = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.ttpPopup = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolidayRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(697, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(606, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(515, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // dgvHolidayRegister
            // 
            this.dgvHolidayRegister.AllowUserToAddRows = false;
            this.dgvHolidayRegister.AllowUserToDeleteRows = false;
            this.dgvHolidayRegister.AllowUserToResizeColumns = false;
            this.dgvHolidayRegister.AllowUserToResizeRows = false;
            this.dgvHolidayRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHolidayRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvHolidayRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHolidayRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHolidayRegister.ColumnHeadersHeight = 25;
            this.dgvHolidayRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHolidayRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtDate,
            this.dgvtxtNarration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHolidayRegister.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHolidayRegister.EnableHeadersVisualStyles = false;
            this.dgvHolidayRegister.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHolidayRegister.Location = new System.Drawing.Point(406, 41);
            this.dgvHolidayRegister.MultiSelect = false;
            this.dgvHolidayRegister.Name = "dgvHolidayRegister";
            this.dgvHolidayRegister.RowHeadersVisible = false;
            this.dgvHolidayRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHolidayRegister.Size = new System.Drawing.Size(376, 281);
            this.dgvHolidayRegister.TabIndex = 3;
            this.dgvHolidayRegister.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvHolidayRegister_DataBindingComplete);
            // 
            // dgvtxtDate
            // 
            this.dgvtxtDate.DataPropertyName = "date";
            this.dgvtxtDate.HeaderText = "Date";
            this.dgvtxtDate.Name = "dgvtxtDate";
            this.dgvtxtDate.ReadOnly = true;
            this.dgvtxtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtNarration
            // 
            this.dgvtxtNarration.DataPropertyName = "narration";
            this.dgvtxtNarration.HeaderText = "Narration";
            this.dgvtxtNarration.Name = "dgvtxtNarration";
            this.dgvtxtNarration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(274, 19);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 35;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonth.Location = new System.Drawing.Point(20, 19);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 34;
            this.lblMonth.Text = "Month";
            // 
            // dgvCalender
            // 
            this.dgvCalender.AllowUserToAddRows = false;
            this.dgvCalender.AllowUserToDeleteRows = false;
            this.dgvCalender.AllowUserToResizeColumns = false;
            this.dgvCalender.AllowUserToResizeRows = false;
            this.dgvCalender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalender.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(98)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalender.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalender.ColumnHeadersVisible = false;
            this.dgvCalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sun,
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.Fri,
            this.Sat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalender.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCalender.EnableHeadersVisualStyles = false;
            this.dgvCalender.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCalender.Location = new System.Drawing.Point(18, 41);
            this.dgvCalender.Name = "dgvCalender";
            this.dgvCalender.ReadOnly = true;
            this.dgvCalender.RowHeadersVisible = false;
            this.dgvCalender.Size = new System.Drawing.Size(365, 281);
            this.dgvCalender.TabIndex = 2;
            this.dgvCalender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalender_CellClick);
            this.dgvCalender.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalender_CellMouseEnter);
            this.dgvCalender.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalender_CellMouseLeave);
            this.dgvCalender.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCalender_DataBindingComplete);
            // 
            // Sun
            // 
            this.Sun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sun.HeaderText = "Sun";
            this.Sun.Name = "Sun";
            this.Sun.ReadOnly = true;
            // 
            // Mon
            // 
            this.Mon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mon.HeaderText = "Mon";
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            // 
            // Tue
            // 
            this.Tue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tue.HeaderText = "Tue";
            this.Tue.Name = "Tue";
            this.Tue.ReadOnly = true;
            // 
            // Wed
            // 
            this.Wed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wed.HeaderText = "Wed";
            this.Wed.Name = "Wed";
            this.Wed.ReadOnly = true;
            // 
            // Thu
            // 
            this.Thu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thu.HeaderText = "Thu";
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            // 
            // Fri
            // 
            this.Fri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fri.HeaderText = "Fri";
            this.Fri.Name = "Fri";
            this.Fri.ReadOnly = true;
            // 
            // Sat
            // 
            this.Sat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sat.HeaderText = "Sat";
            this.Sat.Name = "Sat";
            this.Sat.ReadOnly = true;
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMM";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(67, 15);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(70, 20);
            this.dtpMonth.TabIndex = 0;
            this.dtpMonth.ValueChanged += new System.EventHandler(this.dtpMonth_ValueChanged);
            this.dtpMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpMonth_KeyDown);
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(313, 15);
            this.dtpYear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(70, 20);
            this.dtpYear.TabIndex = 1;
            this.dtpYear.ValueChanged += new System.EventHandler(this.dtpMonth_ValueChanged);
            this.dtpYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpYear_KeyDown);
            // 
            // ttpPopup
            // 
            this.ttpPopup.Active = false;
            this.ttpPopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            // 
            // frmHolydaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.dgvCalender);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvHolidayRegister);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmHolydaySettings";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday Settings";
            this.ttpPopup.SetToolTip(this, "\"\"");
            this.Load += new System.EventHandler(this.frmHolydaySettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHolydaySettings_KeyDown);
           ((System.ComponentModel.ISupportInitialize)(this.dgvHolidayRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvHolidayRegister;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView dgvCalender;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.DataGridViewButtonColumn Sun;
        private System.Windows.Forms.DataGridViewButtonColumn Mon;
        private System.Windows.Forms.DataGridViewButtonColumn Tue;
        private System.Windows.Forms.DataGridViewButtonColumn Wed;
        private System.Windows.Forms.DataGridViewButtonColumn Thu;
        private System.Windows.Forms.DataGridViewButtonColumn Fri;
        private System.Windows.Forms.DataGridViewButtonColumn Sat;
        private System.Windows.Forms.ToolTip ttpPopup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNarration;
    }
}