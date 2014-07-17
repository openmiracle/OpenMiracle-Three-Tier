namespace Open_Miracle
{
    partial class frmVoucherTypeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherTypeSelection));
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(209, 61);
            this.cmbVoucherType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(200, 21);
            this.cmbVoucherType.TabIndex = 0;
            this.cmbVoucherType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVoucherType_KeyDown);
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVoucherType.Location = new System.Drawing.Point(99, 65);
            this.lblVoucherType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(74, 13);
            this.lblVoucherType.TabIndex = 88;
            this.lblVoucherType.Text = "Voucher Type";
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(209, 90);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 27);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            this.btnGo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGo_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(300, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmVoucherTypeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(534, 180);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.lblVoucherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmVoucherTypeSelection";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Type Selection";
            this.Load += new System.EventHandler(this.frmVoucherTypeSelection_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherTypeSelection_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
    }
}