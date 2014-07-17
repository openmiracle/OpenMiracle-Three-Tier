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
    public partial class frmMonthlySalarySettings : Form
    {
        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decMasterIdForEdit = 0;
        int inNarrationCount = 0;
        int inq = 0;
        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmMonthlySalarySettings class
        /// </summary>
        public frmMonthlySalarySettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to Update the Datagridview row colors
        /// </summary>
        public void UpdateDataGridViewRowColors()
        {
            try
            {
                int inRowCount = dgvMonthySalarySettings.RowCount;
                for (int i = 0; i < inRowCount; i++)
                {
                    string str = dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString();
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString() != string.Empty)
                    {

                        dgvMonthySalarySettings.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Package combobox in Datagridview
        /// </summary>
        public void SalaryPackageComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                SalaryPackageCreationBll bllSalaryPackage = new SalaryPackageCreationBll();
                ListObj = bllSalaryPackage.SalaryPackageViewAllForMonthlySalarySettings();
                DataRow dr = ListObj[0].NewRow();
                dr[0] = "0";
                dr[1] = "--Select--";
                ListObj[0].Rows.InsertAt(dr, 0);

                dgvcmbPackage.DataSource = ListObj[0];
                dgvcmbPackage.ValueMember = "salaryPackageId";
                dgvcmbPackage.DisplayMember = "salaryPackageName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Enable/Disable delete button
        /// </summary>
        public void DeleteButtonEnableDisableChoose()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                if (BllMonthlySalary.MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(Convert.ToDateTime(dtpSalaryMonth.Text)) > 0)
                {
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnSave.Text = "Save";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> ListMonthlySalaryDetails = new List<DataTable>();
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                MonthlySalaryInfo infoMonthlySalary = new MonthlySalaryInfo();
                MonthlySalaryVoucherBll BllMonthlySalaryDetails = new MonthlySalaryVoucherBll();
                MonthlySalaryDetailsInfo infoMonthlySalaryDetailsInfo = new MonthlySalaryDetailsInfo();
                ListMonthlySalaryDetails = BllMonthlySalary.MonthlySalarySettingsEmployeeViewAll(Convert.ToDateTime(dtpSalaryMonth.Text));
                dgvMonthySalarySettings.DataSource = ListMonthlySalaryDetails[0];
                int inRowCount = dgvMonthySalarySettings.RowCount;
                string strNarration = string.Empty;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtnarration"].Value.ToString() != string.Empty)
                    {
                        strNarration = dgvMonthySalarySettings.Rows[i].Cells["dgvtxtnarration"].Value.ToString();

                    }
                }
                for (int i = 0; i < inRowCount; i++)
                {
                    //select default package for employee
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtdefaultPackageId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtdefaultPackageId"].Value.ToString() != "")
                    {
                        dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value = dgvMonthySalarySettings.Rows[i].Cells["dgvtxtdefaultPackageId"].Value;
                    }
                }
                txtNarration.Text = strNarration;

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalaryDetails = new MonthlySalaryVoucherBll();
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                string strMonth = dtpSalaryMonth.Text;
                BllMonthlySalary.MonthlySalaryDeleteAll(BllMonthlySalary.MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(Convert.ToDateTime(dtpSalaryMonth.Text)));
                Messages.DeletedMessage();
                SalaryPackageComboFill();
                GridFill();
                UpdateDataGridViewRowColors();
                DeleteButtonEnableDisableChoose();
                dtpSalaryMonth.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call delete
        /// </summary>
        public void Delete()
        {
            try
            {
                decimal decRowCount = 0;
                decRowCount = dgvMonthySalarySettings.Rows.Count;
                if (decRowCount >= 1)
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage() == true)
                        {
                            DeleteFunction();
                        }
                    }
                    else
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    MessageBox.Show("Can't Delete Monthly salary settings without atleast one employee with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                MonthlySalaryInfo infoMonthlySalary = new MonthlySalaryInfo();
                MonthlySalaryVoucherBll BllMonthlySalaryDetails = new MonthlySalaryVoucherBll();
                MonthlySalaryDetailsInfo infoMonthlySalaryDetails = new MonthlySalaryDetailsInfo();
                infoMonthlySalary.SalaryMonth = Convert.ToDateTime(dtpSalaryMonth.Text);
                infoMonthlySalary.Narration = txtNarration.Text.Trim();
                infoMonthlySalary.Extra1 = string.Empty;
                infoMonthlySalary.Extra2 = string.Empty;
                decMasterIdForEdit = BllMonthlySalary.MonthlySalaryAddWithIdentity(infoMonthlySalary);
                infoMonthlySalaryDetails.MonthlySalaryId = decMasterIdForEdit;
                int RowCount = dgvMonthySalarySettings.RowCount;
                for (int i = 0; i < RowCount; i++)
                {
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString() != string.Empty)
                    {
                        infoMonthlySalaryDetails.EmployeeId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString());
                        if (dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString() != "0")
                        {
                            infoMonthlySalaryDetails.SalaryPackageId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString());
                            infoMonthlySalaryDetails.Extra1 = string.Empty;
                            infoMonthlySalaryDetails.Extra2 = string.Empty;
                            infoMonthlySalaryDetails.MonthlySalaryId = decMasterIdForEdit;
                            BllMonthlySalaryDetails.MonthlySalaryDetailsAddWithMonthlySalaryId(infoMonthlySalaryDetails);
                        }
                    }
                }
                Messages.SavedMessage();
                GridFill();
                dtpSalaryMonth.Focus();
                btnDelete.Enabled = true;
                DeleteButtonEnableDisableChoose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                MonthlySalaryInfo infoMonthlySalary = new MonthlySalaryInfo();
                MonthlySalaryVoucherBll BllMonthlySalaryDetails = new MonthlySalaryVoucherBll();
                MonthlySalaryDetailsInfo infoMonthlySalaryDetails = new MonthlySalaryDetailsInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                infoMonthlySalary.SalaryMonth = Convert.ToDateTime(dtpSalaryMonth.Text);
                infoMonthlySalary.Narration = txtNarration.Text.Trim();
                infoMonthlySalary.Extra1 = string.Empty;
                infoMonthlySalary.Extra2 = string.Empty;
                int RowCount = dgvMonthySalarySettings.RowCount;
                for (int i = 0; i <= RowCount - 1; i++)
                {
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryId"].Value.ToString() != string.Empty)
                    {
                        decMasterIdForEdit = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryId"].Value.ToString());
                    }
                }
                infoMonthlySalary.MonthlySalaryId = decMasterIdForEdit;
                BllMonthlySalary.MonthlySalarySettingsEdit(infoMonthlySalary);
                infoMonthlySalaryDetails.MonthlySalaryId = decMasterIdForEdit;
                for (int i = 0; i <= RowCount - 1; i++)
                {
                    if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString() != string.Empty)
                    {
                        string st = dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].FormattedValue.ToString();
                        if (dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].FormattedValue.ToString() != "--Select--")
                        {
                            if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString() != string.Empty)
                            {
                                infoMonthlySalaryDetails.EmployeeId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString());
                            }
                            if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString() != string.Empty)
                            {
                                infoMonthlySalaryDetails.MonthlySalaryDetailsId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString());
                            }
                            if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryId"].Value.ToString() != "0")
                            {
                                infoMonthlySalaryDetails.MonthlySalaryId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtMonthlySalaryId"].Value.ToString());
                            }
                            if (dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString() != "0")
                            {
                                infoMonthlySalaryDetails.SalaryPackageId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString());
                                infoMonthlySalaryDetails.Extra1 = string.Empty;
                                infoMonthlySalaryDetails.Extra2 = string.Empty;
                                BllEmployeeCreation.EmployeePackageEdit(infoMonthlySalaryDetails.EmployeeId, infoMonthlySalaryDetails.SalaryPackageId);
                                BllMonthlySalaryDetails.MonthlySalaryDetailsEditUsingMasterIdAndDetailsId(infoMonthlySalaryDetails);
                            }
                        }
                        else
                        {
                            decimal decMonthlySalaryDetailsId = 0;
                            for (int j = 0; j < RowCount; j++)
                            {
                                if (dgvMonthySalarySettings.Rows[j].Cells["dgvtxtMonthlySalaryDetailsId"].Value != null && dgvMonthySalarySettings.Rows[j].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString() != string.Empty)
                                {
                                    if (dgvMonthySalarySettings.Rows[j].Cells["dgvcmbPackage"].FormattedValue.ToString() == "--Select--")
                                    {
                                        decMonthlySalaryDetailsId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[j].Cells["dgvtxtMonthlySalaryDetailsId"].Value.ToString());
                                        BllMonthlySalaryDetails.MonthlySalarySettingsDetailsIdDelete(decMonthlySalaryDetailsId);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString() != string.Empty)
                        {
                            infoMonthlySalaryDetails.EmployeeId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString());

                            if (dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value != null && dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString() != "0")
                            {
                                infoMonthlySalaryDetails.SalaryPackageId = Convert.ToDecimal(dgvMonthySalarySettings.Rows[i].Cells["dgvcmbPackage"].Value.ToString());
                                infoMonthlySalaryDetails.Extra1 = string.Empty;
                                infoMonthlySalaryDetails.Extra2 = string.Empty;
                                infoMonthlySalaryDetails.MonthlySalaryId = decMasterIdForEdit;
                                BllMonthlySalaryDetails.MonthlySalaryDetailsAddWithMonthlySalaryId(infoMonthlySalaryDetails);
                            }
                        }
                    }
                }
                Messages.UpdatedMessage();
                GridFill();
                dtpSalaryMonth.Focus();
                btnDelete.Enabled = true;
                DeleteButtonEnableDisableChoose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    decimal decRowCount = 0;
                    decRowCount = dgvMonthySalarySettings.Rows.Count;
                    if (decRowCount >= 1)
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                SaveFunction();
                            }
                        }
                        else
                        {
                            SaveFunction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't save Monthly salary settings without atleast one employee with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    decimal decRowCount = 0;
                    decRowCount = dgvMonthySalarySettings.Rows.Count;
                    if (decRowCount >= 1)
                    {
                        if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                EditFunction();
                            }
                        }
                        else
                        {
                            EditFunction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't Update Monthly salary settings without atleast one employee with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// On 'Close' button click
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
                MessageBox.Show("MSS10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dtpSalaryMonth.MinDate = PublicVariables._dtFromDate;
                dtpSalaryMonth.MaxDate = PublicVariables._dtToDate;
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.Text = dtpSalaryMonth.Value.ToString("MMM-yyyy");
                dtpSalaryMonth.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save' button click
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
                MessageBox.Show("MSS12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalarySettings_Load(object sender, EventArgs e)
        {
            try
            {
                SalaryPackageComboFill();
                GridFill();
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.Focus();
                DeleteButtonEnableDisableChoose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                    if (BllMonthlySalary.MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(Convert.ToDateTime(dtpSalaryMonth.Text)) > 0)
                    {
                        Delete();
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on dtpSalaryMonth datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SalaryPackageComboFill();
                GridFill();
                DeleteButtonEnableDisableChoose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthySalarySettings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvMonthySalarySettings.ClearSelection();
                UpdateDataGridViewRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvMonthySalarySettings_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        #endregion

        #region Navigation
        /// <summary>
        /// Quick access on form keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalarySettings_KeyDown(object sender, KeyEventArgs e)
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

                //-------------------CTRL+S Save---------------------------------//
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave_Click(sender, e);
                }


                //-----------------------CTRL+D Delete-----------------------------//
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        btnSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        dgvMonthySalarySettings.Focus();
                        dgvMonthySalarySettings.ClearSelection();
                        dgvMonthySalarySettings.CurrentCell = dgvMonthySalarySettings.Rows[dgvMonthySalarySettings.Rows.Count - 1].Cells["dgvcmbPackage"];
                        dgvMonthySalarySettings.Rows[dgvMonthySalarySettings.Rows.Count - 1].Cells["dgvcmbPackage"].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter or Tab key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                txtNarration.Text = txtNarration.Text.Trim();
                if (txtNarration.Text == string.Empty)
                {
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                    txtNarration.Focus();
                }
                else
                {
                    txtNarration.SelectionStart = txtNarration.Text.Length;
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvMonthySalarySettings.Focus();
                    dgvMonthySalarySettings.ClearSelection();
                    if (dgvMonthySalarySettings.Rows.Count > 0)
                    {
                        dgvMonthySalarySettings.CurrentCell = dgvMonthySalarySettings.Rows[0].Cells[6];
                        dgvMonthySalarySettings.Rows[0].Cells[6].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthySalarySettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvMonthySalarySettings.CurrentCell == dgvMonthySalarySettings[dgvMonthySalarySettings.Columns["dgvcmbPackage"].Index, dgvMonthySalarySettings.Rows.Count - 1])
                    {
                        if (inq == 1)
                        {
                            inq = 0;
                            txtNarration.Focus();
                            dgvMonthySalarySettings.ClearSelection();
                            e.Handled = true;
                        }
                        else
                        {
                            inq++;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (dgvMonthySalarySettings.Rows.Count > 0)
                    {
                        if (dgvMonthySalarySettings.CurrentCell == dgvMonthySalarySettings[dgvMonthySalarySettings.Columns["dgvcmbPackage"].Index, 0])
                        {
                            dtpSalaryMonth.Focus();
                        }
                        else if (dgvMonthySalarySettings.CurrentCell == dgvMonthySalarySettings[dgvMonthySalarySettings.Columns["dgvtxtEmployee"].Index, 0])
                        {
                            dtpSalaryMonth.Focus();
                        }
                        else if (dgvMonthySalarySettings.CurrentCell == dgvMonthySalarySettings[dgvMonthySalarySettings.Columns["dgvtxtEmployeeCode"].Index, 0])
                        {
                            dtpSalaryMonth.Focus();
                        }
                        else
                        {
                            dgvMonthySalarySettings.CurrentCell = dgvMonthySalarySettings[dgvMonthySalarySettings.Columns["dgvcmbPackage"].Index, dgvMonthySalarySettings.CurrentRow.Index - 1];
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("MSS24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete.Focus();
                    }
                    else
                    {
                        btnClear.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSS25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("MSS26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}

