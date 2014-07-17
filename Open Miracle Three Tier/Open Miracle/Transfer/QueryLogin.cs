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
    public partial class frmQueryLogin : Form
    {
        #region Function
        /// <summary>
        /// Create instance of frmJournalVoucher
        /// </summary>
        public frmQueryLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to clear controls
        /// </summary>
        public void Clear()
        {
            try
            {
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Login' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = txtUserName.Text.Trim();
                txtPassword.Text = txtPassword.Text.Trim();
                if (txtUserName.Text.ToLower() == "admin" && txtPassword.Text == "cybro")
                {
                    this.Close();
                    frmStoredProcedureInserter frmStoredProcedureInserter = new frmStoredProcedureInserter();
                    frmStoredProcedureInserter _isOpen = Application.OpenForms["frmStoredProcedureInserter"] as frmStoredProcedureInserter;
                    if (_isOpen == null)
                    {
                        frmStoredProcedureInserter.WindowState = FormWindowState.Normal;
                        frmStoredProcedureInserter.MdiParent = formMDI.MDIObj;//formMDI.frmMDI;
                        frmStoredProcedureInserter.Show();
                    }
                    else
                    {
                        _isOpen.MdiParent = formMDI.MDIObj;
                        if (_isOpen.WindowState == FormWindowState.Minimized)
                        {
                            _isOpen.WindowState = FormWindowState.Normal;
                        }
                        if (_isOpen.Enabled)
                        {
                            _isOpen.Activate();
                            _isOpen.BringToFront();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// key navigation for textbox control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// key navigation for textbox control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                txtUserName.Focus();
                txtUserName.SelectionStart = 0;
            }
        }
        /// <summary>
        /// key navigation for button control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPassword.Focus();
                    txtPassword.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On frmQueryLogin form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QRYL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
