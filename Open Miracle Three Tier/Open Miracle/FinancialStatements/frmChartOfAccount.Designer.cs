namespace Open_Miracle
{
    partial class frmChartOfAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChartOfAccount));
            this.pnlAccountLedger = new System.Windows.Forms.Panel();
            this.pnlAccountGroup = new System.Windows.Forms.Panel();
            this.lblAccountLedger = new System.Windows.Forms.Label();
            this.tvChartOfAccount = new System.Windows.Forms.TreeView();
            this.lblAccountGroup = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAccountLedger
            // 
            this.pnlAccountLedger.BackColor = System.Drawing.Color.Blue;
            this.pnlAccountLedger.Enabled = false;
            this.pnlAccountLedger.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAccountLedger.ForeColor = System.Drawing.Color.Blue;
            this.pnlAccountLedger.Location = new System.Drawing.Point(18, 528);
            this.pnlAccountLedger.Name = "pnlAccountLedger";
            this.pnlAccountLedger.Size = new System.Drawing.Size(18, 15);
            this.pnlAccountLedger.TabIndex = 1176;
            // 
            // pnlAccountGroup
            // 
            this.pnlAccountGroup.BackColor = System.Drawing.Color.Red;
            this.pnlAccountGroup.Enabled = false;
            this.pnlAccountGroup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAccountGroup.ForeColor = System.Drawing.Color.Red;
            this.pnlAccountGroup.Location = new System.Drawing.Point(18, 505);
            this.pnlAccountGroup.Name = "pnlAccountGroup";
            this.pnlAccountGroup.Size = new System.Drawing.Size(18, 15);
            this.pnlAccountGroup.TabIndex = 1175;
            // 
            // lblAccountLedger
            // 
            this.lblAccountLedger.AutoSize = true;
            this.lblAccountLedger.Enabled = false;
            this.lblAccountLedger.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountLedger.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountLedger.Location = new System.Drawing.Point(42, 527);
            this.lblAccountLedger.Name = "lblAccountLedger";
            this.lblAccountLedger.Size = new System.Drawing.Size(99, 16);
            this.lblAccountLedger.TabIndex = 1174;
            this.lblAccountLedger.Text = "Account Ledger";
            // 
            // tvChartOfAccount
            // 
            this.tvChartOfAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvChartOfAccount.ForeColor = System.Drawing.Color.Red;
            this.tvChartOfAccount.Location = new System.Drawing.Point(18, 13);
            this.tvChartOfAccount.Name = "tvChartOfAccount";
            this.tvChartOfAccount.Size = new System.Drawing.Size(760, 489);
            this.tvChartOfAccount.TabIndex = 1172;
            // 
            // lblAccountGroup
            // 
            this.lblAccountGroup.AutoSize = true;
            this.lblAccountGroup.Enabled = false;
            this.lblAccountGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountGroup.ForeColor = System.Drawing.Color.Red;
            this.lblAccountGroup.Location = new System.Drawing.Point(42, 504);
            this.lblAccountGroup.Name = "lblAccountGroup";
            this.lblAccountGroup.Size = new System.Drawing.Size(95, 16);
            this.lblAccountGroup.TabIndex = 1173;
            this.lblAccountGroup.Text = "Account Group";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(690, 528);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 27);
            this.btnPrint.TabIndex = 1171;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmChartOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(793, 568);
            this.Controls.Add(this.pnlAccountLedger);
            this.Controls.Add(this.pnlAccountGroup);
            this.Controls.Add(this.lblAccountLedger);
            this.Controls.Add(this.tvChartOfAccount);
            this.Controls.Add(this.lblAccountGroup);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChartOfAccount";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Of Account";
            this.Load += new System.EventHandler(this.frmChartOfAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChartOfAccount_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvChartOfAccount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlAccountLedger;
        private System.Windows.Forms.Panel pnlAccountGroup;
        private System.Windows.Forms.Label lblAccountLedger;
        private System.Windows.Forms.Label lblAccountGroup;
    }
}