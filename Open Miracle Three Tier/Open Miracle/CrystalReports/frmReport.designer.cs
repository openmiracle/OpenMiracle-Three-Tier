namespace Open_Miracle
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.crptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // crptViewer
            // 
            this.crptViewer.ActiveViewIndex = -1;
            this.crptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewer.DisplayStatusBar = false;
            this.crptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptViewer.Location = new System.Drawing.Point(0, 0);
            this.crptViewer.Name = "crptViewer";
            this.crptViewer.ShowCloseButton = false;
            this.crptViewer.ShowGotoPageButton = false;
            this.crptViewer.ShowGroupTreeButton = false;
            this.crptViewer.ShowParameterPanelButton = false;
            this.crptViewer.ShowRefreshButton = false;
            this.crptViewer.ShowTextSearchButton = false;
            this.crptViewer.ShowZoomButton = false;
            this.crptViewer.Size = new System.Drawing.Size(950, 600);
            this.crptViewer.TabIndex = 8;
            this.crptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.BackgroundImage = global::Open_Miracle.Properties.Resources.sap_hide;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 28);
            this.panel2.TabIndex = 9;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReport_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewer;
        private System.Windows.Forms.Panel panel2;
    }
}