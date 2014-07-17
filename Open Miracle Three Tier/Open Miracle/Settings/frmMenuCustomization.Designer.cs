namespace Open_Miracle
{
    partial class frmMenuCustomization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCustomization));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbxNonSelected = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbxSelected = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbxNonSelected);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 507);
            this.groupBox1.TabIndex = 1204;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu List";
            // 
            // lstbxNonSelected
            // 
            this.lstbxNonSelected.FormattingEnabled = true;
            this.lstbxNonSelected.Location = new System.Drawing.Point(6, 23);
            this.lstbxNonSelected.Name = "lstbxNonSelected";
            this.lstbxNonSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxNonSelected.Size = new System.Drawing.Size(300, 472);
            this.lstbxNonSelected.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbxSelected);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(462, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 507);
            this.groupBox2.TabIndex = 1205;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Menu";
            // 
            // lstbxSelected
            // 
            this.lstbxSelected.FormattingEnabled = true;
            this.lstbxSelected.Location = new System.Drawing.Point(6, 23);
            this.lstbxSelected.Name = "lstbxSelected";
            this.lstbxSelected.Size = new System.Drawing.Size(300, 472);
            this.lstbxSelected.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(689, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 1207;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(505, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1206;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(597, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1208;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(353, 233);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(85, 27);
            this.btnForward.TabIndex = 1209;
            this.btnForward.Text = "» »";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackgroundImage = global::Open_Miracle.Properties.Resources.button;
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.ForeColor = System.Drawing.Color.White;
            this.btnBackward.Location = new System.Drawing.Point(353, 266);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(85, 27);
            this.btnBackward.TabIndex = 1210;
            this.btnBackward.Text = "« «";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // frmMenuCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMenuCustomization";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Customization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuCustomization_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuCustomization_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenuCustomization_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.ListBox lstbxNonSelected;
        private System.Windows.Forms.ListBox lstbxSelected;
    }
}