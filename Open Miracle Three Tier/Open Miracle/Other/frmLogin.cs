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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmLogin : Form
    {
        #region PublicVariables
        formMDI formMdiObj = null;
        frmSelectCompany frmSelectCompanyObj = null;
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of a frmLogin class.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Start a login
        /// </summary>
        public void Login()
        
        {
            try
            {
                UserBll bllUser = new UserBll();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                CompanyInfo infoCompany = new CompanyInfo();
                string strUserName = txtUserName.Text.Trim();
                string strPassword = bllUser.LoginCheck(strUserName);
                if (strPassword == txtPassword.Text.Trim() && strPassword != string.Empty)
                {
                    int inUserId = bllUser.GetUserIdAfterLogin(strUserName, strPassword);
                    PublicVariables._decCurrentUserId = inUserId;
                    infoCompany = bllCompanyCreation.CompanyView(1);
                    PublicVariables._decCurrencyId = infoCompany.CurrencyId;
                    formMDI.MDIObj.CallFromLogin();
                    SettingsCheck();
                    //for Quock Launch menu
                    formMDI.MDIObj.ShowQuickLaunchMenu();
                    formMDI.MDIObj.CurrentSettings();
                    //Display ChangeCurrentDate form//
                    frmChangeCurrentDate frmCurrentDateChangeObj = new frmChangeCurrentDate();
                    frmCurrentDateChangeObj.MdiParent = formMDI.MDIObj;
                    frmCurrentDateChangeObj.CallFromLogin(this);
                    formMDI.MDIObj.Text = "OpenMiracle " + infoCompany.CompanyName + " [ " + PublicVariables._dtFromDate.ToString("dd-MMM-yyyy") + " To " + PublicVariables._dtToDate.ToString("dd-MMM-yyyy") + " ]";
                    // For showing the OpenMiracle message from the website
                    formMDI.MDIObj.logoutToolStripMenuItem.Enabled = true;
                    if (PublicVariables.MessageToShow != string.Empty)
                    {
                        frmMessage frmMsg = new frmMessage();
                        frmMsg.lblHeading.Text = PublicVariables.MessageHeadear;
                        frmMsg.lblMessage.Text = PublicVariables.MessageToShow;
                        frmMsg.MdiParent = formMDI.MDIObj;
                        frmMsg.Show();
                        frmMsg.Location = new Point(0, formMDI.MDIObj.Height - 270);
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(frmChangeCurrentDate))
                            {
                                form.Focus();
                            }
                        }
                    }
                }
                else
                {
                    Messages.InformationMessage("Invalid username or password");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN02:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from MDI form to show Login form and passing the MDI form Object
        /// </summary>
        /// <param name="frmMdiObj"></param>
        public void CallFromFormMdi(formMDI frmMdiObj)
        {
            try
            {
                formMdiObj = frmMdiObj;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN03:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from 'Select Company' form, To show Login form and close Select Company form
        /// </summary>
        /// <param name="frmSelectCompanyObj"></param>
        public void CallFromSelectCompany(frmSelectCompany frmSelectCompanyObj)
        {
            try
            {
                base.Show();
                this.frmSelectCompanyObj = frmSelectCompanyObj;
                frmSelectCompanyObj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN04:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the general settings before loading the MDI page.
        /// This either enables or disables the controls on the form depending on the current settings
        /// </summary>
        public void SettingsCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    formMDI.MDIObj.taxToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.taxToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("Budget") == "Yes")
                {
                    formMDI.MDIObj.budgetToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.budgetToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                {
                    formMDI.MDIObj.payrollToolStripMenuItem.Enabled = true;
                    formMDI.MDIObj.payrollToolStripMenuItem1.Enabled = true;
                    foreach (ToolStripMenuItem toolItem in formMDI.MDIObj.payrollToolStripMenuItem1.DropDownItems)
                    {
                        toolItem.Enabled = true;
                    }
                }
                else
                {
                    formMDI.MDIObj.payrollToolStripMenuItem.Enabled = false;
                    formMDI.MDIObj.payrollToolStripMenuItem1.Enabled = false;
                    foreach (ToolStripMenuItem toolItem in formMDI.MDIObj.payrollToolStripMenuItem1.DropDownItems)
                    {
                        toolItem.Enabled = false;
                    }
                }
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    formMDI.MDIObj.currencyToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.currencyToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    formMDI.MDIObj.batchToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.batchToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowSize") == "Yes")
                {
                    formMDI.MDIObj.sizeToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.sizeToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    formMDI.MDIObj.godownToolStripMenuItem.Enabled = true;
                    if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                    {
                        formMDI.MDIObj.rackToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        formMDI.MDIObj.rackToolStripMenuItem.Enabled = false;
                    }
                }
                else
                {
                    formMDI.MDIObj.godownToolStripMenuItem.Enabled = false;
                    formMDI.MDIObj.rackToolStripMenuItem.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowModelNo") == "Yes")
                {
                    formMDI.MDIObj.modelNumberToolStripMenuItem.Enabled = true;
                }
                else
                {
                    formMDI.MDIObj.modelNumberToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reseting the login page
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
                MessageBox.Show("LOGIN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Login' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// On Keydown, For navigating to Password textbox using Enter key
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
                MessageBox.Show("LOGIN21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On Keydown, For navigating to Login button/Username textbox using Enter/Backspace keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPassword.Text == string.Empty || txtPassword.SelectionStart == 0)
                    {
                        txtUserName.SelectionStart = 0;
                        txtUserName.SelectionLength = 0;
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of btnLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOGIN23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
