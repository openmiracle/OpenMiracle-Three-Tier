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
    public partial class frmUserCreation : Form
    {
        public frmUserCreation()
        {
            InitializeComponent();
        }
        #region Public Variables
        /// <summary>
        /// Public variable Declaration Part
        /// </summary>
        int inNarrationcount=0;
        decimal decUserId;
        string strRole;

        #endregion

        #region Function
        /// <summary>
        /// Function to fill the Role ComboFill
        /// </summary>
        public void RoleComboFill()
        {
            try
            {
                RoleBll BllRole = new RoleBll();
                List<DataTable> listObjRoleCombo = new List<DataTable>();
                listObjRoleCombo = BllRole.RoleViewAll();
                cmbRole.DataSource = listObjRoleCombo[0];
                cmbRole.ValueMember = "roleId";
                cmbRole.DisplayMember = "role";
                cmbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to the search Role Combo box
        /// </summary>
        public void SearchRoleComboFill()
        {
            try
            {
                RoleBll BllRole = new RoleBll();
                List<DataTable> listObjSearchRoleCombo = new List<DataTable>();
                listObjSearchRoleCombo = BllRole.RoleViewAll();
                DataRow dr = listObjSearchRoleCombo[0].NewRow();
                dr[1] = "All";
                listObjSearchRoleCombo[0].Rows.InsertAt(dr, 0);
                cmbSearchRole.DataSource = listObjSearchRoleCombo[0];
                cmbSearchRole.ValueMember ="roleId";
                cmbSearchRole.DisplayMember = "role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        private void SaveFunction()
        {
            try
            {
                UserInfo infoUser = new UserInfo();
                UserBll bllUser = new UserBll();
                infoUser.UserName = txtUserName.Text.Trim();
                infoUser.Password = txtPassword.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoUser.Active = true;
                }
                else
                {
                    infoUser.Active = false;
                }
                infoUser.RoleId = Convert.ToDecimal(cmbRole.SelectedValue);
                infoUser.Narration = txtNarration.Text.Trim();
                infoUser.Extra1 = string.Empty;
                infoUser.Extra2 = string.Empty;
                string strUserName=txtUserName.Text.Trim();
                if (bllUser.UserCreationCheckExistence(decUserId, strUserName) == false)
                {
                    bllUser.UserAdd(infoUser);
                    Messages.SavedMessage();
                    ClearFunction();
                    GridFill();
                    txtUserName.Focus();
                }
                else
                {
                    Messages.InformationMessage("User name already exists");
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Update Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                UserInfo infoUser = new UserInfo();
                UserBll bllUser = new UserBll();
                infoUser.UserId = Convert.ToDecimal(dgvUserCreation.CurrentRow.Cells["dgvtxtUserId"].Value);
                infoUser.UserName = txtUserName.Text.Trim();
                infoUser.Password = txtPassword.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoUser.Active = true;
                }
                else
                {
                    infoUser.Active = false;
                }
                infoUser.RoleId = Convert.ToDecimal(cmbRole.SelectedValue);
                infoUser.Narration = txtNarration.Text.Trim();
                infoUser.Extra1 = string.Empty;
                infoUser.Extra2 = string.Empty;
                string strUserName = txtUserName.Text.Trim();
                if (bllUser.UserCreationCheckExistence(decUserId, strUserName) == false)
                {
                    bllUser.UserEdit(infoUser);
                    Messages.UpdatedMessage();
                    ClearFunction();
                    GridFill();
                    txtUserName.Focus();
                }
                else
                {
                    Messages.InformationMessage("User name already exists");
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Or Update Function
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtUserName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter username");
                    txtUserName.Focus();
                }
                else if (txtPassword.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter password");
                    txtPassword.Focus();
                }
                else if (txtPassword.Text != txtRetype.Text)
                {
                    Messages.InformationMessage("Password and confirm password should match");
                    txtRetype.Focus();
                    txtRetype.Clear();
                }
                else if (cmbRole.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select role");
                    cmbRole.Focus();
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
                                cmbRole.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            SaveFunction();
                            cmbRole.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                EditFunction();
                                cmbRole.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            EditFunction();
                            cmbRole.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the controls in form
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                txtUserName.Clear();
                cmbRole.SelectedIndex = -1;
                txtPassword.Clear();
                txtRetype.Clear();
                txtNarration.Clear();             
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// User Creation GridFill
        /// </summary>
        public void GridFill()
        {
            try
            {
                UserBll bllUser = new UserBll();
                List<DataTable> LIstObj = new List<DataTable>();
                string strSearchUserName = txtSearchUserName.Text.Trim();
                string strSearchRole = cmbSearchRole.Text;
                LIstObj = bllUser.UserCreationViewForGridFill(strSearchUserName, strSearchRole);
                dgvUserCreation.DataSource = LIstObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the values in curresponding controls for updation
        /// </summary>
        public void FillControls()
        {
            try
            {
                UserInfo infoUser = new UserInfo();
                UserBll bllUser = new UserBll();
                infoUser = bllUser.UserView(decUserId);
                txtUserName.Text = infoUser.UserName;
                txtPassword.Text = infoUser.Password;
                cmbRole.SelectedValue = infoUser.RoleId;
                txtNarration.Text = infoUser.Narration;
                if (infoUser.Active)
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }
                txtRetype.Text = txtPassword.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete Function
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        UserInfo infoUser = new UserInfo();
                        UserBll bllUser = new UserBll();
                        if ((bllUser.UserCreationReferenceDelete(decUserId) == -1))
                        {
                            Messages.ReferenceExistsMessage();
                        }
                        else
                        {
                            Messages.DeletedMessage();
                            btnSave.Text = "Save";
                            btnDelete.Enabled = false;
                            ClearFunction();
                            GridFill();
                        }
                    }
                }
                else
                {
                    UserInfo infoUser = new UserInfo();
                    UserBll bllUser = new UserBll();
                    if ((bllUser.UserCreationReferenceDelete(decUserId) == -1))
                    {
                        Messages.ReferenceExistsMessage();
                    }
                    else
                    {
                        Messages.DeletedMessage();
                        btnSave.Text = "Save";
                        btnDelete.Enabled = false;
                        ClearFunction();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search Clear
        /// </summary>
        public void SearchClear()
        {
            try
            {
                txtSearchUserName.Clear();
                cmbSearchRole.SelectedIndex = 0;
                GridFill();
                txtSearchUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Role combobox while return from Role creation when creating new Role 
        /// </summary>
        /// <param name="decRoleId"></param>
        public void ReturnFromRoleForm(decimal decRoleId)
        {
            try
            {
                RoleComboFill();
                if (decRoleId != 0)
                {
                    cmbRole.SelectedValue = decRoleId.ToString();
                }
                else if (strRole != string.Empty)
                {
                    cmbRole.SelectedValue = strRole;
                }
                else
                {
                    cmbRole.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbRole.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageClose == true)
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
                MessageBox.Show("UC:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId,this.Name,btnSave.Text))
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
                MessageBox.Show("UC:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load call basic functions to clear the form controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserCreation_Load(object sender, EventArgs e)
        {
            try
            {
                if (cbxActive.Checked == false)
                {
                    cbxActive.Checked = true;
                }
                btnDelete.Enabled = false;
                SearchRoleComboFill();
                GridFill();
                RoleComboFill();

            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for Updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserCreation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    decUserId = Convert.ToDecimal(dgvUserCreation.CurrentRow.Cells["dgvtxtUserId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmbRole.SelectedIndex = -1;
                ClearFunction();
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    DeleteFunction();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// SearchClear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            try
            {
                SearchClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// RoleAdd click to add a new role
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedValue != null)
                {
                    strRole = cmbRole.SelectedValue.ToString();
                }
                else
                {
                    strRole = string.Empty;
                }
                frmRole Roleobj = new frmRole();
                Roleobj.MdiParent = formMDI.MDIObj;
                Roleobj.CallFromUserCreation(this);
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// password text change based on settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == string.Empty)
                {
                    txtRetype.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the function Search Role ComboFill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserCreation_Activated(object sender, EventArgs e)
        {
            try
            {
                SearchRoleComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbRole.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbRole.Text == string.Empty || cmbRole.SelectionStart == 0)
                    {
                        txtUserName.SelectionStart = 0;
                        txtUserName.SelectionLength = 0;
                        txtUserName.Focus();
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnRoleAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserCreation_KeyDown(object sender, KeyEventArgs e)
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
                        btnClose_Click(sender, e);
                    }
                }
              
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) 
                {
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) 
                {
                    if (btnDelete.Enabled == true)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRetype.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPassword.Text == string.Empty || txtPassword.SelectionStart == 0)
                    {
                        cmbRole.SelectionStart = 0;
                        cmbRole.SelectionLength = 0;
                        cmbRole.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRetype_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxActive.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRetype.Text == string.Empty || txtRetype.SelectionStart == 0)
                    {
                        txtPassword.SelectionStart = 0;
                        txtPassword.SelectionLength = 0;
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                        txtRetype.SelectionStart = 0;
                        txtRetype.SelectionLength = 0;
                        txtRetype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        cbxActive.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationcount = 0;
                txtNarration.Text = txtNarration.Text.Trim();

                if (txtNarration.Text == String.Empty)
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
                MessageBox.Show("UC:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    inNarrationcount++;
                    if (inNarrationcount == 2)
                    {
                        inNarrationcount = 0;
                        btnSave.Focus();
                    }
                }
                else
                {
                    inNarrationcount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSearchRole.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSearchRole_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSearchRole.Text == string.Empty || cmbSearchRole.SelectionStart == 0)
                    {
                        txtSearchUserName.SelectionStart = 0;
                        txtSearchUserName.SelectionLength = 0;
                        txtSearchUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSearchRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmbSearchRole.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((sender as TextBox).SelectionStart == 0)
                {
                    e.Handled = (e.KeyChar == (char)Keys.Space);
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRetype_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((sender as TextBox).SelectionStart == 0)
                {
                    e.Handled = (e.KeyChar == (char)Keys.Space);
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                    txtNarration.SelectionLength = 0;
                    txtNarration.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserCreation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbSearchRole.Focus();
                    cmbSearchRole.SelectionLength = 0;
                    cmbSearchRole.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserCreation_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ( e.KeyCode == Keys.Enter)
                {
                    if (dgvUserCreation.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvUserCreation.CurrentCell.ColumnIndex, dgvUserCreation.CurrentCell.RowIndex);
                        dgvUserCreation_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbSearchRole.Focus();
                    cmbSearchRole.SelectionLength = 0;
                    cmbSearchRole.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("UC:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}