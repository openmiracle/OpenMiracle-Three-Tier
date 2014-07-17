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
    public partial class frmBarcodeSettings : Form
    {
        #region Functions
        /// <summary>
        /// Create an Instance for frmBarcodeSettings Class
        /// </summary>
        public frmBarcodeSettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clear Grop box Items
        /// </summary>
        public void ClearGroupBox()
        {
            try
            {
                txtZero.Clear();
                txtOne.Clear();
                txtTwo.Clear();
                txtThree.Clear();
                txtFour.Clear();
                txtFive.Clear();
                txtSix.Clear();
                txtSeven.Clear();
                txtEight.Clear();
                txtNine.Clear();
                txtPoint.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Clear the form here
        /// </summary>
        public void Clear()
        {
            try
            {
                cbxShowMrp.Checked = false;
                cbxShowCompanyNAmeAs.Checked = false;
                txtShowCompanyName.Clear();
                txtShowCompanyName.Clear();
                ClearGroupBox();
                cbxShowPurchaseRate.Checked = false;
                cbxShowMrp.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Display the company name in text box
        /// </summary>
        public void txtcompanynamefill()
        {
            try
            {
                //CompanySP spcompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                CompanyInfo infoCompany = new CompanyInfo();
                infoCompany = bllCompanyCreation.CompanyView(1);
                string strCompanyName = infoCompany.CompanyName;
                txtShowCompanyName.Text = strCompanyName;
                txtShowCompanyName.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Setting the check box Status
        /// </summary>
        public void FillSettings()
        {
            try
            {
                BarcodeSettingsInfo Info = new BarcodeSettingsBll().BarcodeSettingsView(1);
                if (Info.ShowMRP == true)
                {
                    cbxShowMrp.Checked = true;
                }
                else
                {
                    cbxShowMrp.Checked = false;
                }
                if (Info.ShowProductCode == true)
                {
                    rbtnShowProductCode.Checked = true;
                }
                else
                {
                    rbtnShowProductName.Checked = true;
                }
                if (Info.ShowCompanyName == true)
                {
                    cbxShowCompanyNAmeAs.Checked = true;
                }
                else
                {
                    cbxShowCompanyNAmeAs.Checked = false;
                }
                if (Info.ShowPurchaseRate == true)
                {
                    cbxShowPurchaseRate.Checked = true;
                }
                else
                {
                    cbxShowPurchaseRate.Checked = false;
                }
                txtShowCompanyName.Text = Info.CompanyName;
                if (txtShowCompanyName.Text == string.Empty)
                {
                    CompanyInfo InfoCompany = new CompanyInfo();
                    //CompanySP Sp = new CompanySP();
                    CompanyCreationBll Bll = new CompanyCreationBll();
                    InfoCompany = Bll.CompanyView(1);
                    txtShowCompanyName.Text = InfoCompany.CompanyName;
                }
                txtZero.Text = Info.Zero;
                txtOne.Text = Info.One;
                txtTwo.Text = Info.Two;
                txtThree.Text = Info.Three;
                txtFour.Text = Info.Four;
                txtFive.Text = Info.Five;
                txtSix.Text = Info.Six;
                txtSeven.Text = Info.Seven;
                txtEight.Text = Info.Eight;
                txtNine.Text = Info.Nine;
                txtPoint.Text = Info.Point;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Or Edit Function
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                bool isOk = true;
                if (cbxShowCompanyNAmeAs.Checked && txtShowCompanyName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter company code", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtShowCompanyName.Focus();
                    isOk = false;
                }
                else if ((cbxShowPurchaseRate.Checked && CheckGroupBox()) || (!cbxShowPurchaseRate.Checked))
                {
                    if (PublicVariables.isMessageAdd)
                    {
                        if (Messages.SaveMessage())
                        {
                            isOk = true;
                        }
                        else
                        {
                            isOk = false;
                        }
                    }
                    if (isOk)
                    {
                        BarcodeSettingsInfo InfoSettings = new BarcodeSettingsInfo();
                        InfoSettings.ShowMRP = cbxShowMrp.Checked;
                        InfoSettings.ShowProductCode = rbtnShowProductCode.Checked;
                        InfoSettings.ShowCompanyName = cbxShowCompanyNAmeAs.Checked;
                        InfoSettings.ShowPurchaseRate = cbxShowPurchaseRate.Checked;
                        InfoSettings.CompanyName = txtShowCompanyName.Text.Trim();
                        InfoSettings.Zero = txtZero.Text.Trim();
                        InfoSettings.One = txtOne.Text.Trim();
                        InfoSettings.Two = txtTwo.Text.Trim();
                        InfoSettings.Three = txtThree.Text.Trim();
                        InfoSettings.Four = txtFour.Text.Trim();
                        InfoSettings.Five = txtFive.Text.Trim();
                        InfoSettings.Six = txtSix.Text.Trim();
                        InfoSettings.Seven = txtSeven.Text.Trim();
                        InfoSettings.Eight = txtEight.Text.Trim();
                        InfoSettings.Nine = txtNine.Text.Trim();
                        InfoSettings.Point = txtPoint.Text.Trim();
                        InfoSettings.Extra1 = string.Empty;
                        InfoSettings.Extra2 = string.Empty;
                        BarcodeSettingsBll Bllbarcodesetting = new BarcodeSettingsBll();
                        Bllbarcodesetting.BarcodeSettingsAdd(InfoSettings);
                        Messages.SavedMessage();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the Barcode settings
        /// </summary>
        public void BarcodeSettingsViewAll()
        {
            try
            {
                BarcodeSettingsBll Bllbarcodesetting = new BarcodeSettingsBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = Bllbarcodesetting.BarcodeSettingsViewAll();
                foreach (DataRow dr in listObj[0].Rows)
                {
                    if (dr["showMRP"].ToString() == "True")
                    {
                        cbxShowMrp.Checked = true;
                    }
                    else
                    {
                        cbxShowMrp.Checked = false;
                    }
                    if (dr["showPurchaseRate"].ToString() == "True")
                    {
                        cbxShowPurchaseRate.Checked = true;
                    }
                    else
                    {
                        cbxShowPurchaseRate.Checked = false;
                    }
                    if (dr["showCompanyName"].ToString() == "True")
                    {
                        cbxShowCompanyNAmeAs.Checked = true;
                    }
                    else
                    {
                        cbxShowCompanyNAmeAs.Checked = false;
                    }
                    if (dr["showProductCode"].ToString() == "True")
                    {
                        rbtnShowProductCode.Checked = true;
                    }
                    else
                    {
                        rbtnShowProductName.Checked = true;
                    }
                    txtShowCompanyName.Text = dr["companyName"].ToString();
                    if (cbxShowPurchaseRate.Checked == true)
                    {
                        txtEight.Text = dr["eight"].ToString();
                        txtFive.Text = dr["five"].ToString();
                        txtFour.Text = dr["four"].ToString();
                        txtNine.Text = dr["nine"].ToString();
                        txtOne.Text = dr["one"].ToString();
                        txtPoint.Text = dr["point"].ToString();
                        txtSeven.Text = dr["seven"].ToString();
                        txtSix.Text = dr["six"].ToString();
                        txtThree.Text = dr["three"].ToString();
                        txtTwo.Text = dr["two"].ToString();
                        txtZero.Text = dr["zero"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the TextBox value here
        /// </summary>
        /// <returns></returns>
        public bool CheckGroupBox()
        {
            bool isOk = true;
            try
            {
                if (txtZero.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for zero", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtZero.Focus();
                    isOk = false;
                }
                else if (txtOne.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for one", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOne.Focus();
                    isOk = false;
                }
                else if (txtTwo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for two", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTwo.Focus();
                    isOk = false;
                }
                else if (txtThree.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for three", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThree.Focus();
                    isOk = false;
                }
                else if (txtFour.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for four", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFour.Focus();
                    isOk = false;
                }
                else if (txtFive.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for five", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFive.Focus();
                    isOk = false;
                }
                else if (txtSix.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for six", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSix.Focus();
                    isOk = false;
                }
                else if (txtSeven.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for seven", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSeven.Focus();
                    isOk = false;
                }
                else if (txtEight.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for eight", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEight.Focus();
                    isOk = false;
                }
                else if (txtNine.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for nine", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNine.Focus();
                    isOk = false;
                }
                else if (txtPoint.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter code for point", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPoint.Focus();
                    isOk = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Keypress Event for 
        /// </summary>
        /// <param name="e"></param>
        public void KeyPressFunction(KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 40 || e.KeyChar == 41)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Clear Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearGroupBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset Button Click
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
                MessageBox.Show("BS11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageClose)
                {
                    Messages.CloseMessage(this);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS12:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
       /// <summary>
       /// When Load The form , Call the clear function and check settings
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmBarcodeSettings_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnShowProductCode.Checked = true;
                gbxRate.Enabled = false;
                Clear();
                BarcodeSettingsViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checkbox Company name checked changed to fill company name 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowCompanyNAmeAs_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxShowCompanyNAmeAs.Checked)
                {
                    txtcompanynamefill();
                }
                else
                {
                    txtShowCompanyName.ReadOnly = false;
                    txtShowCompanyName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// checkbox ShowPurchaseRate CheckedChanged for Group box rate make enable or desable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowPurchaseRate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxShowPurchaseRate.Checked)
                {
                    gbxRate.Enabled = true;
                }
                else
                {
                    gbxRate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtZero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Keypress Event for Blocking Opening and Closing Brackets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFour_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFive_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSix_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSeven_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEight_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNine_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call KeyPressFunction to check the Input Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPressFunction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form Key down for Quick Access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBarcodeSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.Control && e.KeyCode == Keys.S)
                {
                    SaveOrEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowMrp_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        rbtnShowProductName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BS28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnShowProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnShowProductCode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cbxShowMrp.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnShowProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxShowCompanyNAmeAs.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    rbtnShowProductName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowCompanyNAmeAs_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!txtShowCompanyName.ReadOnly)
                    {
                        txtShowCompanyName.Focus();
                        txtShowCompanyName.SelectionStart = 0;
                        txtShowCompanyName.SelectionLength = 0;
                    }
                    else
                    {
                        cbxShowPurchaseRate.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    rbtnShowProductName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtShowCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxShowPurchaseRate.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtShowCompanyName.Text.Trim() == string.Empty || txtShowCompanyName.SelectionStart == 0)
                    {
                        cbxShowCompanyNAmeAs.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!cbxShowPurchaseRate.Checked)
                    {
                        btnSave.Focus();
                    }
                    else
                    {
                        txtZero.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cbxShowCompanyNAmeAs.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtZero_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtOne.Focus();
                    txtOne.SelectionStart = 0;
                    txtOne.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtZero.Text.Trim() == string.Empty || txtZero.SelectionStart == 0)
                    {
                        cbxShowPurchaseRate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOne_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtTwo.Focus();
                    txtTwo.SelectionStart = 0;
                    txtTwo.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtOne.Text.Trim() == string.Empty || txtOne.SelectionStart == 0)
                    {
                        txtZero.Focus();
                        txtZero.SelectionStart = 0;
                        txtZero.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTwo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtThree.Focus();
                    txtThree.SelectionStart = 0;
                    txtThree.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtTwo.Text.Trim() == string.Empty || txtTwo.SelectionStart == 0)
                    {
                        txtOne.Focus();
                        txtOne.SelectionStart = 0;
                        txtOne.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtThree_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFour.Focus();
                    txtFour.SelectionStart = 0;
                    txtFour.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtThree.Text.Trim() == string.Empty || txtThree.SelectionStart == 0)
                    {
                        txtTwo.Focus();
                        txtTwo.SelectionStart = 0;
                        txtTwo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFour_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFive.Focus();
                    txtFive.SelectionStart = 0;
                    txtFive.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtFour.Text.Trim() == string.Empty || txtFour.SelectionStart == 0)
                    {
                        txtThree.Focus();
                        txtThree.SelectionStart = 0;
                        txtThree.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSix.Focus();
                    txtSix.SelectionStart = 0;
                    txtSix.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtFive.Text.Trim() == string.Empty || txtFive.SelectionStart == 0)
                    {
                        txtFour.Focus();
                        txtFour.SelectionStart = 0;
                        txtFour.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSix_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSeven.Focus();
                    txtSeven.SelectionStart = 0;
                    txtSeven.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtSix.Text.Trim() == string.Empty || txtSix.SelectionStart == 0)
                    {
                        txtFive.Focus();
                        txtFive.SelectionStart = 0;
                        txtFive.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSeven_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEight.Focus();
                    txtEight.SelectionStart = 0;
                    txtEight.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtSeven.Text.Trim() == string.Empty || txtSeven.SelectionStart == 0)
                    {
                        txtSix.Focus();
                        txtSix.SelectionStart = 0;
                        txtSix.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEight_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNine.Focus();
                    txtNine.SelectionStart = 0;
                    txtNine.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtEight.Text.Trim() == string.Empty || txtEight.SelectionStart == 0)
                    {
                        txtSeven.Focus();
                        txtSeven.SelectionStart = 0;
                        txtSeven.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNine_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPoint.Focus();
                    txtPoint.SelectionStart = 0;
                    txtPoint.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtNine.Text.Trim() == string.Empty || txtNine.SelectionStart == 0)
                    {
                        txtEight.Focus();
                        txtEight.SelectionStart = 0;
                        txtEight.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPoint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtPoint.Text.Trim() == string.Empty || txtPoint.SelectionStart == 0)
                    {
                        txtNine.Focus();
                        txtNine.SelectionStart = 0;
                        txtNine.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPoint.Focus();
                    txtPoint.SelectionStart = 0;
                    txtPoint.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        #endregion
    }
}
