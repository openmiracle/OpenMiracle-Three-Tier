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
    public partial class frmServices : Form
    {

        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decIdForOtherForms = 0;
        decimal decServiceId = 0;
        decimal inNarrationCount = 0;
        string strServiceName = string.Empty;
        string strCategory;
        frmServiceVoucher frmServiceVoucherObj;

        #endregion

        #region Functions
        /// <summary>
        /// Create an instance for frmServices Class
        /// </summary>
        public frmServices()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Category ComboFill Function
        /// </summary>
        public void CategoryComboFill()
        {
            try
            {
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                List<DataTable> listObjServiceCatogery = new List<DataTable>();
                listObjServiceCatogery = BllServiceCatogory.ServiceCategoryViewAll();
                cmbCategory.DataSource = listObjServiceCatogery[0];
                cmbCategory.ValueMember = "serviceCategoryId";
                cmbCategory.DisplayMember = "categoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its a call from Serviece voucher to create a new service
        /// </summary>
        /// <param name="frmServiceVoucher"></param>
        public void CallFromServiceVoucher(frmServiceVoucher frmServiceVoucher)
        {
            try
            {
                this.frmServiceVoucherObj = frmServiceVoucher;
                frmServiceVoucherObj.Enabled = false;
                base.Show();
                grpServiecesSearch.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser2 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Category Search combo fill
        /// </summary>
        public void CategorySearchFill()
        {
            try
            {
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                List<DataTable> listObjServiceCatogery = new List<DataTable>();
                listObjServiceCatogery = BllServiceCatogory.ServiceCategoryViewAll();
                DataRow dr = listObjServiceCatogery[0].NewRow();
                dr[1] = "All";
                listObjServiceCatogery[0].Rows.InsertAt(dr, 0);
                cmbCategorySearch.DataSource = listObjServiceCatogery[0];
                cmbCategorySearch.ValueMember = "serviceCategoryId";
                cmbCategorySearch.DisplayMember = "categoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Gridfill function
        /// </summary>
        public void GridFill()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                List<DataTable> listObjService = new List<DataTable>();
                listObjService = BllService.ServiceGridFill();
                dgvService.DataSource = listObjService[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To reset the form here
        /// </summary>
        public void Clear()
        {
            try
            {
                CategoryComboFill();
                CategorySearchFill();
                txtServiceName.Clear();
                cmbCategory.SelectedIndex = -1;
                txtRate.Clear();
                txtNarration.Clear();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtServiceName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear the grid controlls here
        /// </summary>
        public void GridClear()
        {
            try
            {
                txtServiceNameSearch.Clear();
                cmbCategorySearch.SelectedIndex = 0;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Delete function and checking conformation
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    DeleteFunction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete function and reference exists checking
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                if (BllService.ServiceDeleteReferenceCheck(decServiceId) == -1)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    Clear();
                    btnSave.Text = "Save";
                    Messages.DeletedMessage();
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Service Search function
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <param name="strCategoryname"></param>
        public void ServiceSearch(string strBrandName, string strCategoryname)
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                ServiceInfo infoService = new ServiceInfo();
                List<DataTable> listObjService = new List<DataTable>();
                listObjService = BllService.ServiceSearch(strBrandName, strCategoryname);
                dgvService.DataSource = listObjService[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ServiceName Checking Existance
        /// </summary>
        /// <returns></returns>
        public bool CheckExistenceOfServiceName()
        {
            bool isExist = false;

            try
            {
                ServicesBll BllService = new ServicesBll();
                isExist = BllService.ServiceCheckExistence(txtServiceName.Text.Trim(), 0);
                if (isExist)
                {
                    string strServiceNames = txtServiceName.Text.Trim();
                    if (strServiceNames.ToLower() == strServiceName.ToLower())
                    {
                        isExist = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                ServiceInfo infoService = new ServiceInfo();
                infoService.ServiceName = txtServiceName.Text.Trim();
                infoService.ServiceCategoryId = Convert.ToDecimal(cmbCategory.SelectedValue.ToString());
                infoService.Rate = Convert.ToDecimal(txtRate.Text.ToString());
                infoService.Narration = txtNarration.Text.Trim();
                infoService.ExtraDate = PublicVariables._dtCurrentDate;
                infoService.Extra1 = string.Empty;
                infoService.Extra2 = string.Empty;
                if (BllService.ServiceCheckExistence(txtServiceName.Text.Trim(), 0) == false)
                {
                    decIdForOtherForms = BllService.ServiceAddWithReturnIdentity(infoService);
                    Messages.SavedMessage();
                    Clear();
                    GridFill();
                }
                else
                {
                    Messages.InformationMessage("Service name already exist");
                    txtServiceName.Focus();
                }
                if (frmServiceVoucherObj != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser11 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                ServiceInfo infoService = new ServiceInfo();
                infoService.ServiceId = Convert.ToDecimal(dgvService.CurrentRow.Cells["dgvtxtServiceId"].Value.ToString());
                infoService.ServiceName = txtServiceName.Text.Trim();
                infoService.ServiceCategoryId = Convert.ToDecimal(cmbCategory.SelectedValue.ToString());
                infoService.Rate = Convert.ToDecimal(txtRate.Text.ToString());
                infoService.Narration = txtNarration.Text.Trim();
                infoService.Extra1 = string.Empty;
                infoService.Extra2 = string.Empty;
                if (CheckExistenceOfServiceName() == false)
                {
                    if (BllService.ServiceEdit(infoService))
                    {
                        Messages.UpdatedMessage();
                        Clear();
                        txtServiceName.Focus();
                    }
                }
                else
                {
                    Messages.InformationMessage("Already exists");
                    txtServiceName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking invalid entries For save or Update function
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtServiceName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter service name");
                    txtServiceName.Focus();
                }
                else if (cmbCategory.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select category name");
                    cmbCategory.Focus();
                }
                else if (txtRate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter rate");
                    txtRate.Focus();
                }
                else
                {

                    if (btnSave.Text == "Save")
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Return function from serviece category form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromServiceCategoryForm(decimal decId)
        {
            try
            {
                CategoryComboFill();
                if (decId!=0)
                {
                    cmbCategory.SelectedValue = decId;
                }
                else if (strCategory != string.Empty)
                {
                    cmbCategory.SelectedValue = strCategory;
                }
                else
                {
                    cmbCategory.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbCategory.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region Events
        /// <summary>
        /// When form loads Clear the grid function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServices_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                GridClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SaveOrEdit();
                    GridClear();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill controls for Update or delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    ServicesBll BllService = new ServicesBll();
                    ServiceInfo infoService = new ServiceInfo();
                    decServiceId = Convert.ToDecimal(dgvService.Rows[e.RowIndex].Cells["dgvtxtServiceId"].Value.ToString());
                    infoService = BllService.ServiceView(decServiceId);
                    txtServiceName.Text = infoService.ServiceName;
                    cmbCategory.SelectedValue = infoService.ServiceCategoryId.ToString();
                    txtRate.Text = infoService.Rate.ToString();
                    txtNarration.Text = infoService.Narration;
                    txtServiceNameSearch.Text = string.Empty;
                    cmbCategorySearch.SelectedIndex = 0;
                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
                    strServiceName = infoService.ServiceName;
                    txtServiceName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click
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
                MessageBox.Show("Ser18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ser19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear the grid function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            try
            {
                GridClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Button delete click , call delete function and user privilage check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    Delete();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceSearch(txtServiceNameSearch.Text.Trim(), cmbCategorySearch.Text);
                txtServiceNameSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serviece grid KeyUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvService_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvService.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvService.CurrentCell.ColumnIndex, dgvService.CurrentCell.RowIndex);
                        dgvService_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Category leave function for set the textbox as clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategory_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1)
                {
                    cmbCategory.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Form closing event . checking for other forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmServiceVoucherObj != null)
                {
                    frmServiceVoucherObj.ReturnFromServiceFormForGridCombo(decIdForOtherForms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser25 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Add new serviece from here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedValue != null)
                {
                    strCategory = cmbCategory.SelectedValue.ToString();
                }
                else
                {
                    strCategory = string.Empty;
                }
                frmServiceCategory frmServiceCategory = new frmServiceCategory();
                frmServiceCategory.MdiParent = formMDI.MDIObj;
                frmServiceCategory open = Application.OpenForms["frmServiceCategory"] as frmServiceCategory;
                if (open == null)
                {
                    frmServiceCategory.WindowState = FormWindowState.Normal;
                    frmServiceCategory.MdiParent = formMDI.MDIObj;
                    frmServiceCategory.callFromServices(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.callFromServices(this);
                    open.BringToFront();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        #region Navigation
        /// <summary>
        /// For enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCategory.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = txtNarration.TextLength;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRate.Text == string.Empty || txtRate.SelectionStart == 0)
                    {
                        cmbCategory.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRate.Focus();
                    txtRate.SelectionStart = txtRate.SelectionLength;
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtServiceName.Focus();
                    txtServiceName.SelectionStart = 0;
                    txtServiceName.SelectionLength = 0;
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnGroupAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtRate.Focus();
                        txtRate.SelectionStart = 0;
                        txtRate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
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
                MessageBox.Show("Ser31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServiceNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCategorySearch.Focus();
                    cmbCategorySearch.SelectionStart = cmbCategorySearch.SelectionLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategorySearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtServiceNameSearch.Focus();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Form keydown for Quick access save and delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServices_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) 
                {
                    if (cmbCategory.Focused)
                    {
                        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else
                    {
                        cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;

                    }
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To get count For enter key  and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtNarration.Text = txtNarration.Text;
                if (txtNarration.Text == string.Empty)
                {
                    txtNarration.SelectionStart = 0;
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
                MessageBox.Show("Ser35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                MessageBox.Show("Ser36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call decimal validation class here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvService_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbCategorySearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbCategorySearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ser39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion




    }
}
