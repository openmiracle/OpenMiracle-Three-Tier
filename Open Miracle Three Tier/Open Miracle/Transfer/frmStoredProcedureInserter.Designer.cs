namespace Open_Miracle
{
    partial class frmStoredProcedureInserter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoredProcedureInserter));
            this.btnCopyData = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.cbUpdation = new System.Windows.Forms.CheckedListBox();
            this.btnCopyPrinterData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopyData
            // 
            this.btnCopyData.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnCopyData.FlatAppearance.BorderSize = 0;
            this.btnCopyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyData.ForeColor = System.Drawing.Color.White;
            this.btnCopyData.Location = new System.Drawing.Point(32, 44);
            this.btnCopyData.Name = "btnCopyData";
            this.btnCopyData.Size = new System.Drawing.Size(85, 27);
            this.btnCopyData.TabIndex = 9;
            this.btnCopyData.Text = "Copy Data";
            this.btnCopyData.UseVisualStyleBackColor = true;
            this.btnCopyData.Click += new System.EventHandler(this.btnCopyData_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(32, 157);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(815, 210);
            this.txtNarration.TabIndex = 10;
            this.txtNarration.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(762, 392);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(85, 27);
            this.btnExecute.TabIndex = 11;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(82, 192);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(35, 13);
            this.lblFail.TabIndex = 12;
            this.lblFail.Text = "label1";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(82, 310);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(35, 13);
            this.lblSuccess.TabIndex = 13;
            this.lblSuccess.Text = "label2";
            // 
            // cbUpdation
            // 
            this.cbUpdation.FormattingEnabled = true;
            this.cbUpdation.Location = new System.Drawing.Point(475, 44);
            this.cbUpdation.Name = "cbUpdation";
            this.cbUpdation.Size = new System.Drawing.Size(372, 94);
            this.cbUpdation.TabIndex = 14;
            // 
            // btnCopyPrinterData
            // 
            this.btnCopyPrinterData.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnCopyPrinterData.FlatAppearance.BorderSize = 0;
            this.btnCopyPrinterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPrinterData.ForeColor = System.Drawing.Color.White;
            this.btnCopyPrinterData.Location = new System.Drawing.Point(123, 44);
            this.btnCopyPrinterData.Name = "btnCopyPrinterData";
            this.btnCopyPrinterData.Size = new System.Drawing.Size(85, 27);
            this.btnCopyPrinterData.TabIndex = 15;
            this.btnCopyPrinterData.Text = "Copy PrintData";
            this.btnCopyPrinterData.UseVisualStyleBackColor = true;
            this.btnCopyPrinterData.Click += new System.EventHandler(this.btnCopyPrinterData_Click);
            // 
            // frmStoredProcedureInserter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(878, 456);
            this.Controls.Add(this.btnCopyPrinterData);
            this.Controls.Add(this.cbUpdation);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblFail);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.btnCopyData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStoredProcedureInserter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoredProcedure Inserter";
            this.Load += new System.EventHandler(this.frmStoredProcedureInserter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyData;
        private System.Windows.Forms.RichTextBox txtNarration;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.CheckedListBox cbUpdation;
        private System.Windows.Forms.Button btnCopyPrinterData;
    }
}