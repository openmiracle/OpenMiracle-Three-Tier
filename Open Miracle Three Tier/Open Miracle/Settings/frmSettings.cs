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
using OpenMiracle.BLL;
using ENTITY;

namespace Open_Miracle
{
    public partial class frmSettings : Form
    {
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        #region Public Variables
        string strTrue = "Yes";
        string strFalse = "No";
        string strStatus;
        string strControlls = string.Empty;
        frmCompanyCreation frmCompanyCreationObj = null;

        #endregion

        #region Functions
        /// <summary>
        /// Function to check the references in each one
        /// </summary>
        public void Checkreference()
        {
            try
            {


                SettingsBll BllSettings = new SettingsBll();
                List<DataTable> listObj = new List<DataTable>();
                DataTable dtblReferences = new DataTable();
                listObj = BllSettings.SettinsCheckReference();

                if (bool.Parse(listObj[0].Rows[0]["CurrencyExist"].ToString()) == true)
                {
                    cbxMultiCurrency.Enabled = false;
                }
                else
                {
                    cbxMultiCurrency.Enabled = true;
                }
                if (bool.Parse(listObj[0].Rows[0]["Godown"].ToString()) == true)
                {
                    cbxAllowGodown.Enabled = false;
                }
                else
                {
                    cbxAllowGodown.Enabled = true;
                }
                if (bool.Parse(listObj[0].Rows[0]["Rack"].ToString()) == true)
                {
                    cbxAllowRack.Enabled = false;
                }
                else
                {
                    cbxAllowRack.Enabled = true;
                }
                if (bool.Parse(listObj[0].Rows[0]["BillByBillExist"].ToString()) == true)
                {
                    cbxBillByBill.Enabled = false;
                }
                else
                {
                    cbxBillByBill.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST1: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Create an instance for frmSettings class
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to Add Confirmation For State status
        /// </summary>
        public void AddConfirmationForState()
        {
            try
            {


                if (cbxAdd.Checked == false && cbxEdit.Checked == false && cbxDelete.Checked == false && cbxClose.Checked == false)
                {
                    cbxAddConfirmationFor.Checked = false;

                }
                else
                {
                    cbxAddConfirmationFor.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST2: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or edit function,checking the invalid entries here
        /// </summary>

        public void SaveOrEdit()
        {
            SettingsBll BllSettings = new SettingsBll();
            SettingsInfo infoSettings = new SettingsInfo();
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)ctrl;
                        strControlls = cb.Text.Replace(" ", string.Empty);
                        if (cb.Checked)
                        {
                            infoSettings.Status = strTrue;
                            infoSettings.SettingsId = BllSettings.SettingsGetId(strControlls);
                            if (cb.Text == "Tax")
                            {
                                formMDI.MDIObj.taxToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Budget")
                            {
                                formMDI.MDIObj.budgetToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Payroll")
                            {
                                formMDI.MDIObj.payrollToolStripMenuItem.Enabled = true;
                                formMDI.MDIObj.payrollToolStripMenuItem1.Enabled = true;
                                foreach (ToolStripMenuItem toolItem in formMDI.MDIObj.payrollToolStripMenuItem1.DropDownItems)
                                {
                                    toolItem.Enabled = true;
                                }
                            }
                            if (cb.Text == "Multi Currency")
                            {
                                formMDI.MDIObj.currencyToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Allow Batch")
                            {
                                formMDI.MDIObj.batchToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Allow Size")
                            {
                                formMDI.MDIObj.sizeToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Allow Godown")
                            {
                                formMDI.MDIObj.godownToolStripMenuItem.Enabled = true;
                                if (cbxAllowRack.Checked)
                                {
                                    formMDI.MDIObj.rackToolStripMenuItem.Enabled = true;
                                }

                            }
                            if (cb.Text == "Allow Rack")
                            {
                                formMDI.MDIObj.rackToolStripMenuItem.Enabled = true;
                            }
                            if (cb.Text == "Allow Model No")
                            {
                                formMDI.MDIObj.modelNumberToolStripMenuItem.Enabled = true;
                            }


                        }
                        else
                        {
                            infoSettings.Status = strFalse;
                            infoSettings.SettingsId = BllSettings.SettingsGetId(strControlls);
                            if (cb.Text == "Tax")
                            {
                                formMDI.MDIObj.taxToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Budget")
                            {
                                formMDI.MDIObj.budgetToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Payroll")
                            {
                                formMDI.MDIObj.payrollToolStripMenuItem.Enabled = false;
                                formMDI.MDIObj.payrollToolStripMenuItem1.Enabled = false;
                                foreach (ToolStripMenuItem toolItem in formMDI.MDIObj.payrollToolStripMenuItem1.DropDownItems)
                                {
                                    toolItem.Enabled = false;
                                }
                            }
                            if (cb.Text == "MultiCurrency")
                            {
                                formMDI.MDIObj.currencyToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Allow Batch")
                            {
                                formMDI.MDIObj.batchToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Allow Size")
                            {
                                formMDI.MDIObj.sizeToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Allow Godown")
                            {
                                formMDI.MDIObj.godownToolStripMenuItem.Enabled = false;

                                if (cbxAllowRack.Checked == false)
                                {
                                    formMDI.MDIObj.rackToolStripMenuItem.Enabled = false;
                                }
                            }
                            if (cb.Text == "Allow Rack")
                            {
                                formMDI.MDIObj.rackToolStripMenuItem.Enabled = false;
                            }
                            if (cb.Text == "Allow Model No")
                            {
                                formMDI.MDIObj.modelNumberToolStripMenuItem.Enabled = false;
                            }
                        }
                        BllSettings.SettingsEdit(infoSettings);



                    }
                    if (ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)ctrl;
                        strControlls = ctrl.Name.Replace("cmb", string.Empty);
                        if (cmb.SelectedIndex > -1)
                        {
                            infoSettings.Status = cmb.SelectedItem.ToString();
                            infoSettings.SettingsId = BllSettings.SettingsGetId(strControlls);
                        }
                        BllSettings.SettingsEdit(infoSettings);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to view the Settings
        /// </summary>
        /// <param name="decSettingsName"></param>
        /// <returns></returns>
        public string SettingsStatusView(string decSettingsName)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                SettingsInfo infoSettings = new SettingsInfo();
                infoSettings = BllSettings.SettingsView(decSettingsName);
                strStatus = infoSettings.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strStatus;

        }
        /// <summary>
        /// Function to invoke the Settings to copy
        /// </summary>
        /// <param name="strSettingsName"></param>
        /// <returns></returns>
        public string SettingsToCopyStatusView(string strSettingsName)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                SettingsInfo infoSettings = new SettingsInfo();
                infoSettings = BllSettings.SettingsToCopyView(strSettingsName);
                strStatus = infoSettings.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strStatus;

        }
        /// <summary>
        /// Function to Fill the Settings Of Currenct Company
        /// </summary>
        public void FillSettingsOfCurrenctBranch()
        {
            SettingsBll BllSettings = new SettingsBll();
            List<DataTable> listObj = new   List<DataTable>();
            try
            {
                listObj = BllSettings.SettingsViewAll();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)ctrl;

                        strControlls = cb.Text.Replace(" ", string.Empty);

                        foreach (DataRow dr in listObj[0].Rows)
                        {
                            if (dr["settingsName"].ToString() == strControlls)
                            {
                                if (strControlls == "AllowGoDown")
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                        if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                                        {
                                            cbxAllowRack.Checked = true;
                                        }
                                        else
                                        {
                                            cbxAllowRack.Checked = false;
                                        }

                                    }
                                    else if (dr["status"].ToString() == "No")
                                    {
                                        cb.Checked = false;
                                        cbxAllowRack.Visible = false;
                                        cbxAllowRack.Checked = false;
                                    }
                                }
                                else if (strControlls == "AddConfirmationFor")
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                        foreach (Control c in this.Controls)
                                        {
                                            if (c is CheckBox)
                                            {
                                                CheckBox cbx = (CheckBox)c;
                                                string str = cbx.Text.Replace(" ", string.Empty);
                                                if (str == "Add" || str == "Edit" || str == "Delete" || str == "Close")
                                                {
                                                    foreach (DataRow dr1 in listObj[0].Rows)
                                                    {
                                                        if (dr1["settingsName"].ToString() == str)
                                                        {
                                                            if (dr1["status"].ToString() == "Yes")
                                                            {
                                                                cbx.Checked = true;
                                                            }
                                                            else if (dr1["status"].ToString() == "No")
                                                            {
                                                                cbx.Checked = false;

                                                            }
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        cb.Checked = false;
                                        cbxAdd.Visible = false;
                                        cbxDelete.Visible = false;
                                        cbxEdit.Visible = false;
                                        cbxClose.Visible = false;
                                    }
                                }
                                else
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                    }
                                    else if (dr["status"].ToString() == "No")
                                    {
                                        cb.Checked = false;
                                    }
                                }
                            }

                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)ctrl;
                        strControlls = ctrl.Name.Replace("cmb", string.Empty);
                        foreach (DataRow dr in listObj[0].Rows)
                        {
                            if (dr["settingsName"].ToString() == strControlls)
                            {
                                cmb.SelectedItem = dr["status"].ToString();
                            }
                        }

                    }
                }
                Checkreference();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ST6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        /// <summary>
        /// RESET DATA FROM TABLE SETTINGSCOPY
        /// </summary>
        public void FillDefaultSettings()
        {
            SettingsBll BllSettings = new SettingsBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = BllSettings.SettingsToCopyViewAll();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox cb = (CheckBox)ctrl;

                        strControlls = cb.Text.Replace(" ", string.Empty);

                        foreach (DataRow dr in listObj[0].Rows)
                        {
                            if (dr["settingsName"].ToString() == strControlls)
                            {
                                if (strControlls == "AllowGoDown")
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                        if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                                        {
                                            cbxAllowRack.Checked = true;
                                        }
                                        else
                                        {
                                            cbxAllowRack.Checked = false;
                                        }

                                    }
                                    else if (dr["status"].ToString() == "No")
                                    {
                                        cb.Checked = false;
                                        cbxAllowRack.Visible = false;
                                        cbxAllowRack.Checked = false;
                                    }
                                }
                                else if (strControlls == "AddConfirmationFor")
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                        foreach (Control c in this.Controls)
                                        {
                                            if (c is CheckBox)
                                            {
                                                CheckBox cbx = (CheckBox)c;
                                                string str = cbx.Text.Replace(" ", string.Empty);
                                                if (str == "Add" || str == "Edit" || str == "Delete" || str == "Close")
                                                {
                                                    foreach (DataRow dr1 in listObj[0].Rows)
                                                    {
                                                        if (dr1["settingsName"].ToString() == str)
                                                        {
                                                            if (dr1["status"].ToString() == "Yes")
                                                            {
                                                                cbx.Checked = true;
                                                            }
                                                            else if (dr1["status"].ToString() == "No")
                                                            {
                                                                cbx.Checked = false;

                                                            }
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        cb.Checked = false;
                                        cbxAdd.Visible = false;
                                        cbxDelete.Visible = false;
                                        cbxEdit.Visible = false;
                                        cbxClose.Visible = false;
                                    }
                                }
                                else
                                {
                                    if (dr["status"].ToString() == "Yes")
                                    {
                                        cb.Checked = true;
                                    }
                                    else if (dr["status"].ToString() == "No")
                                    {
                                        cb.Checked = false;
                                    }
                                }
                            }

                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)ctrl;
                        strControlls = ctrl.Name.Replace("cmb", string.Empty);
                        foreach (DataRow dr in listObj[0].Rows)
                        {
                            if (dr["settingsName"].ToString() == strControlls)
                            {
                                cmb.SelectedItem = dr["status"].ToString();
                            }
                        }

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ST7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        /// <summary>
        /// Function to call this form from frmCompanyCreation to view details and for updation
        /// </summary>
        /// <param name="frmCompanyCreation"></param>
        public void CallFromChangeCurrentDate(frmCompanyCreation frmCompanyCreation)
        {
            try
            {
                frmCompanyCreationObj = frmCompanyCreation;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Reset button click,call the default settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (MessageBox.Show("Do you want to reset ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FillDefaultSettings();
                        SaveOrEdit();
                        Messages.InformationMessage("Saved successfully");
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click
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
                MessageBox.Show("ST10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {

                    if (Messages.SaveMessage())
                    {
                        SaveOrEdit();
                        Messages.SavedMessage();
                        foreach (Form child in this.MdiParent.MdiChildren)
                        {
                            if (this != child)
                            {
                                child.Close();
                            }

                        }
                        formMDI.MDIObj.CurrentSettings();
                        formMDI.MDIObj.ShowQuickLaunchMenu();
                        this.Close();

                    }

                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Printer combo selected index change make the Girect print checkbox status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrinter.SelectedIndex == 0)
            {
                cbxDirectPrint.Checked = true;
                cbxDirectPrint.Enabled = false;
            }
            else
            {
                cbxDirectPrint.Checked = false;
                cbxDirectPrint.Enabled = true;
            }
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                cbxPayroll.Focus();
                cbxAllowRack.Visible = false;
                FillSettingsOfCurrenctBranch();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ST12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// arrange the rack based on the godown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowGodown_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxAllowGodown.Checked == true)
                {
                    cbxAllowRack.Visible = true;

                }
                else
                {
                    cbxAllowRack.Visible = false;
                    cbxAllowRack.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Settings to make visible the confirmation message status based on settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAddConfirmationFor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxAddConfirmationFor.Checked == true)
                {
                    cbxAdd.Visible = true;
                    cbxDelete.Visible = true;
                    cbxEdit.Visible = true;
                    cbxClose.Visible = true;
                }
                else
                {
                    cbxAdd.Checked = false;
                    cbxAdd.Visible = false;
                    cbxEdit.Checked = false;
                    cbxDelete.Visible = false;
                    cbxDelete.Checked = false;
                    cbxEdit.Visible = false;
                    cbxClose.Checked = false;
                    cbxClose.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the Add Confirmation For Add checkbox confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAdd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AddConfirmationForState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the Add Confirmation For Edit checkbox confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AddConfirmationForState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the Add Confirmation For Delete checkbox confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDelete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AddConfirmationForState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the Add Confirmation For Close checkbox confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AddConfirmationForState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region Navigations
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
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
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{tab}");
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)//ctrl+s
                {
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                    {

                        if (cmbPrinter.Focused)
                        {
                            cmbPrinter.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else
                        {
                            cmbPrinter.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        if (cmbNegativeStockStatus.Focused)
                        {
                            cmbNegativeStockStatus.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else
                        {
                            cmbNegativeStockStatus.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        if (cmbStockValueCalculationMethod.Focused)
                        {
                            cmbStockValueCalculationMethod.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else
                        {
                            cmbStockValueCalculationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        if (cmbNegativeCashTransaction.Focused)
                        {
                            cmbNegativeCashTransaction.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else
                        {
                            cmbNegativeCashTransaction.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        btnSave_Click(sender, e);

                    }

                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPayroll_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxBudget.Enabled == true)
                    {
                        cbxBudget.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ST20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxBudget_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxTax.Enabled == true)
                    {
                        cbxTax.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxMultiCurrency.Enabled == true)
                    {
                        cbxMultiCurrency.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMultiCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxBillByBill.Enabled == true)
                    {
                        cbxBillByBill.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxBillByBill_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowZeroValueEntry.Enabled == true)
                    {
                        cbxAllowZeroValueEntry.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowZeroValueEntry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowCurrencySymbol.Enabled == true)
                    {
                        cbxShowCurrencySymbol.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowCurrencySymbol_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxTickPrintAfterSave.Enabled == true)
                    {
                        cbxTickPrintAfterSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTickPrintAfterSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAutomaticProductCodeGeneration.Enabled == true)
                    {
                        cbxAutomaticProductCodeGeneration.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAutomaticProductCodeGeneration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxBarcode.Enabled == true)
                    {
                        cbxBarcode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowBatch.Enabled == true)
                    {
                        cbxAllowBatch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowBatch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowSize.Enabled == true)
                    {
                        cbxAllowSize.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowSize_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowModelNo.Enabled == true)
                    {
                        cbxAllowModelNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowGodown.Enabled == true)
                    {
                        cbxAllowGodown.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ST32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowGodown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxAllowRack.Enabled == true)
                    {
                        cbxAllowRack.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAllowRack_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowSalesRate.Enabled == true)
                    {
                        cbxShowSalesRate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowCurrentRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowMRP.Enabled == true)
                    {
                        cbxShowMRP.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowMRP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowUnit.Enabled == true)
                    {
                        cbxShowUnit.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowSize.Enabled == true)
                    {
                        cbxShowSize.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowSize_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowModelNo.Enabled == true)
                    {
                        cbxShowModelNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowDiscountAmount.Enabled == true)
                    {
                        cbxShowDiscountAmount.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowProductCode.Enabled == true)
                    {
                        cbxShowProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowBrand.Enabled == true)
                    {
                        cbxShowBrand.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowBrand_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxShowDiscountPercentage.Enabled == true)
                    {
                        cbxShowDiscountPercentage.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowDiscountInPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPrinter.Enabled == true)
                    {
                        cmbPrinter.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPrinter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxDirectPrint.Enabled == true)
                    {
                        cbxDirectPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cbxClose.Enabled == true)
                    {
                        cbxClose.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDirectPrint_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbNegativeCashTransaction.Enabled == true)
                    {
                        cmbNegativeCashTransaction.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNegativeCashTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbStockValueCalculationMethod.Enabled == true)
                    {
                        cmbStockValueCalculationMethod.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPrinter.Enabled == true)
                    {
                        cmbPrinter.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ST46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmblblStockValueCalculationMethod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbNegativeStockStatus.Enabled == true)
                    {
                        cmbNegativeStockStatus.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbNegativeCashTransaction.Enabled == true)
                    {
                        cmbNegativeCashTransaction.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNegativeStockStatus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSave.Enabled == true)
                    {
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbStockValueCalculationMethod.Enabled == true)
                    {
                        cmbStockValueCalculationMethod.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnReset.Enabled == true)
                    {
                        btnReset.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbNegativeStockStatus.Enabled == true)
                    {
                        cmbNegativeStockStatus.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnClose.Enabled == true)
                    {
                        btnClose.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnSave.Enabled == true)
                    {
                        btnSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (btnReset.Enabled == true)
                    {
                        btnReset.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

    }
}
