namespace Open_Miracle
{
    partial class frmCopyDataPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopyDataPrinter));
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(86, 58);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 517;
            this.lblDate.Text = "Source Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(67, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 518;
            this.label1.Text = "Destination Path";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(173, 55);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(355, 20);
            this.txtSourcePath.TabIndex = 0;
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(173, 96);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(355, 20);
            this.txtDestinationPath.TabIndex = 1;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(179, 140);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(35, 13);
            this.lblSuccess.TabIndex = 524;
            this.lblSuccess.Text = "label1";
            this.lblSuccess.Visible = false;
            // 
            // btnSource
            // 
            this.btnSource.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSource.FlatAppearance.BorderSize = 0;
            this.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSource.ForeColor = System.Drawing.Color.White;
            this.btnSource.Location = new System.Drawing.Point(173, 175);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(85, 27);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnDestination.FlatAppearance.BorderSize = 0;
            this.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestination.ForeColor = System.Drawing.Color.White;
            this.btnDestination.Location = new System.Drawing.Point(276, 175);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(85, 27);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "Destination";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(380, 175);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 27);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmCopyDataPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(635, 266);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCopyDataPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Printer Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}