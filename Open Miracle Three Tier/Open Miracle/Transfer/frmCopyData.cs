//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Open_Miracle
{
    public partial class frmCopyData : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        public static string strTable = string.Empty;
        string strSourceDbPath = string.Empty;
        string strDestinationDb = string.Empty;
        string strFailed = string.Empty;
        frmLoading f1;
        #endregion
        #region Functions
        /// <summary>
        /// Create instance of frmJournalVoucher
        /// </summary>
        public frmCopyData()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Source' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSource_Click(object sender, EventArgs e)
        {
            try
            {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtSourcePath.Text = openFileDialog1.FileName;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CData:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Destination' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestination_Click(object sender, EventArgs e)
        {
            try
            {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                txtDestinationPath.Text = openFileDialog1.FileName;
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CData:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Background worker running on Copy data from source to destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
            DataCopy dc = new DataCopy();
            strFailed = dc.CopyData(strSourceDbPath, strDestinationDb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CData:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Background worker process completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                f1.Close();
                if (strFailed == "")
                {
                    lblSuccess.Visible = true;
                    lblSuccess.Text = "Data copied succesffully";
                    lblSuccess.ForeColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Failed for the tables\n" + strFailed, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CData:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Copy' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
            strSourceDbPath = txtSourcePath.Text.Trim();
            strDestinationDb = txtDestinationPath.Text.Trim();
            if (strSourceDbPath == string.Empty)
            {
                MessageBox.Show("Select source path", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (strDestinationDb == string.Empty)
                {
                    MessageBox.Show("Select destination path", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblSuccess.Visible = false;
                    backgroundWorker1.RunWorkerAsync();
                    f1 = new frmLoading();
                    f1.ShowDialog();
                    
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CData:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
