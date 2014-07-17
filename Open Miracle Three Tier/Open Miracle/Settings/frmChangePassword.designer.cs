namespace Open_Miracle
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.lblRetype = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(50, 69);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 1181;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 65);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 1182;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(156, 90);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(200, 20);
            this.txtOldPassword.TabIndex = 1184;
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOldPassword_KeyDown);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(50, 94);
            this.lblOldPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(72, 13);
            this.lblOldPassword.TabIndex = 1183;
            this.lblOldPassword.Text = "Old Password";
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(156, 140);
            this.txtRetype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(200, 20);
            this.txtRetype.TabIndex = 1188;
            this.txtRetype.UseSystemPasswordChar = true;
            this.txtRetype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRetype_KeyDown);
            // 
            // lblRetype
            // 
            this.lblRetype.AutoSize = true;
            this.lblRetype.ForeColor = System.Drawing.Color.White;
            this.lblRetype.Location = new System.Drawing.Point(50, 144);
            this.lblRetype.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRetype.Name = "lblRetype";
            this.lblRetype.Size = new System.Drawing.Size(93, 13);
            this.lblRetype.TabIndex = 1187;
            this.lblRetype.Text = "Re-type Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(156, 115);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 20);
            this.txtNewPassword.TabIndex = 1186;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(50, 119);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 1185;
            this.lblNewPassword.Text = "New Password";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(156, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1199;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(247, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 27);
            this.btnReset.TabIndex = 1200;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(338, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 1201;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(366, 68);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 1203;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(366, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1204;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(366, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 1205;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(366, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 1206;
            this.label3.Text = "*";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(470, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRetype);
            this.Controls.Add(this.lblRetype);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChangePassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label lblRetype;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}