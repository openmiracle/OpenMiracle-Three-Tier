namespace Open_Miracle
{
	partial class frmSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.lblPurchaseAccount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtMailId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjest = new System.Windows.Forms.TextBox();
            this.lstbxAttach = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bwrk1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblPurchaseAccount
            // 
            this.lblPurchaseAccount.AutoSize = true;
            this.lblPurchaseAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPurchaseAccount.Location = new System.Drawing.Point(12, 17);
            this.lblPurchaseAccount.Margin = new System.Windows.Forms.Padding(5);
            this.lblPurchaseAccount.Name = "lblPurchaseAccount";
            this.lblPurchaseAccount.Size = new System.Drawing.Size(63, 13);
            this.lblPurchaseAccount.TabIndex = 1057;
            this.lblPurchaseAccount.Text = "User E- mail";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(523, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(613, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtMailId
            // 
            this.txtMailId.Location = new System.Drawing.Point(100, 13);
            this.txtMailId.Margin = new System.Windows.Forms.Padding(5);
            this.txtMailId.Name = "txtMailId";
            this.txtMailId.Size = new System.Drawing.Size(600, 20);
            this.txtMailId.TabIndex = 0;
            this.txtMailId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMailId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1059;
            this.label1.Text = "Subject";
            // 
            // txtSubjest
            // 
            this.txtSubjest.Location = new System.Drawing.Point(100, 41);
            this.txtSubjest.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubjest.Name = "txtSubjest";
            this.txtSubjest.Size = new System.Drawing.Size(600, 20);
            this.txtSubjest.TabIndex = 1;
            this.txtSubjest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubjest_KeyDown);
            // 
            // lstbxAttach
            // 
            this.lstbxAttach.FormattingEnabled = true;
            this.lstbxAttach.Location = new System.Drawing.Point(100, 69);
            this.lstbxAttach.Name = "lstbxAttach";
            this.lstbxAttach.Size = new System.Drawing.Size(507, 30);
            this.lstbxAttach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1063;
            this.label3.Text = "Attachment";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(100, 103);
            this.txtBody.Margin = new System.Windows.Forms.Padding(5);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(600, 218);
            this.txtBody.TabIndex = 4;
            this.txtBody.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBody_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(614, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(432, 329);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 27);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(702, 19);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(11, 13);
            this.lblSalaryTypeValidator.TabIndex = 1067;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(702, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 1068;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(702, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 1069;
            this.label4.Text = "*";
            // 
            // bwrk1
            // 
            this.bwrk1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrk1_DoWork);
            this.bwrk1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrk1_RunWorkerCompleted);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(724, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbxAttach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjest);
            this.Controls.Add(this.lblPurchaseAccount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtMailId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label lblPurchaseAccount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtMailId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjest;
        private System.Windows.Forms.ListBox lstbxAttach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bwrk1;
	}
}