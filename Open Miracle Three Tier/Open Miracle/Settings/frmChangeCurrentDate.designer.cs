namespace Open_Miracle
{
    partial class frmChangeCurrentDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeCurrentDate));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.dtpCompanyCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyCurrentdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(335, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(244, 91);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(153, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDate.Location = new System.Drawing.Point(47, 67);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(100, 20);
            this.lblCurrentDate.TabIndex = 1150;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // dtpCompanyCurrentDate
            // 
            this.dtpCompanyCurrentDate.CustomFormat = "dd MMMM yyyy";
            this.dtpCompanyCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCompanyCurrentDate.Location = new System.Drawing.Point(333, 63);
            this.dtpCompanyCurrentDate.Name = "dtpCompanyCurrentDate";
            this.dtpCompanyCurrentDate.Size = new System.Drawing.Size(22, 20);
            this.dtpCompanyCurrentDate.TabIndex = 1155;
            this.dtpCompanyCurrentDate.TabStop = false;
            this.dtpCompanyCurrentDate.CloseUp += new System.EventHandler(this.dtpCompanyCurrentDate_CloseUp);
            // 
            // txtCompanyCurrentdate
            // 
            this.txtCompanyCurrentdate.Location = new System.Drawing.Point(155, 63);
            this.txtCompanyCurrentdate.Margin = new System.Windows.Forms.Padding(5);
            this.txtCompanyCurrentdate.Name = "txtCompanyCurrentdate";
            this.txtCompanyCurrentdate.Size = new System.Drawing.Size(200, 20);
            this.txtCompanyCurrentdate.TabIndex = 0;
            this.txtCompanyCurrentdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyCurrentdate_KeyDown);
            this.txtCompanyCurrentdate.Leave += new System.EventHandler(this.txtCompanyCurrentdate_Leave);
            // 
            // frmChangeCurrentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(470, 201);
            this.Controls.Add(this.dtpCompanyCurrentDate);
            this.Controls.Add(this.txtCompanyCurrentdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCurrentDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChangeCurrentDate";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Current Date";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangeCurrentDate_FormClosing);
            this.Load += new System.EventHandler(this.frmChangeCurrentDate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChangeCurrentDate_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.DateTimePicker dtpCompanyCurrentDate;
        private System.Windows.Forms.TextBox txtCompanyCurrentdate;
    }
}