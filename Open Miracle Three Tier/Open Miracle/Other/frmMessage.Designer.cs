namespace Open_Miracle
{
    partial class frmMessage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.btn_close_msg;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(322, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 60;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(3, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(338, 111);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "M";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(5);
            this.lblHeading.Size = new System.Drawing.Size(344, 23);
            this.lblHeading.TabIndex = 3;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.Label lblMessage;

    }
}