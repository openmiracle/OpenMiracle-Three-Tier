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
    public partial class frmRole : Form
    {
        #region PublicVeriable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decRoleId;
        int inNarrationCount = 0;
        frmUserCreation frmUserCreationobj;
        #endregion
        #region Function
        /// <summary>
        /// Create an instance for frmRole class
        /// </summary>
        public frmRole()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void Gridfill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RoleBll BllRole = new RoleBll();
                listObj = BllRole.RoleViewGridFill();
                dgvRole.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Clear the controls in form
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                txtRole.Clear();
                txtNarration.Clear();
                Gridfill();
                txtRole.Focus();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                RoleInfo infoRole = new RoleInfo();
                RoleBll BllRole = new RoleBll();
                infoRole.Role = txtRole.Text.Trim();
                infoRole.Narration = txtNarration.Text.Trim();
                infoRole.Extra1 = string.Empty;
                infoRole.Extra2 = string.Empty;
                string strRole = txtRole.Text.Trim();
                if (BllRole.RoleCheckExistence(decRoleId, strRole) == false)
                {
                    decRoleId = BllRole.RoleAdd(infoRole);
                    Messages.SavedMessage();
                    ClearFunction();
                }
                else
                {
                    Messages.InformationMessage("Role already exists");
                    txtRole.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update the items
        /// </summary>
        public void EditFunction()
        {
            try
            {
                RoleInfo infoRole = new RoleInfo();
                RoleBll BllRole = new RoleBll();
                infoRole.RoleId = Convert.ToDecimal(dgvRole.CurrentRow.Cells["dgvtxtRoleId"].Value);
                infoRole.Role = txtRole.Text.Trim();
                infoRole.Narration = txtNarration.Text.Trim();
                infoRole.Extra1 = string.Empty;
                infoRole.Extra2 = string.Empty;
                string strRole = txtRole.Text.Trim();
                if (BllRole.RoleCheckExistence(decRoleId, strRole) == false)
                {
                    BllRole.RoleEdit(infoRole);
                    Messages.UpdatedMessage();
                    ClearFunction();
                }
                else
                {
                    Messages.InformationMessage("Role already exists");
                    txtRole.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Or Update Function, to checking invalid entries
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                if (txtRole.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter role");
                    txtRole.Focus();
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
                        if (frmUserCreationobj != null)
                        {
                            this.Close();
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
                MessageBox.Show("RL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Controls for updation
        /// </summary>
        public void FillControls()
        {
            try
            {
                RoleInfo infoRole = new RoleInfo();
                RoleBll BllRole = new RoleBll();
                infoRole = BllRole.RoleView(decRoleId);
                txtRole.Text = infoRole.Role;
                txtNarration.Text = infoRole.Narration;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        RoleInfo infoRole = new RoleInfo();
                        RoleBll BllRole = new RoleBll();
                        if ((BllRole.RoleReferenceDelete(decRoleId) == -1))
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
                else
                {
                    RoleInfo infoRole = new RoleInfo();
                    RoleBll BllRole = new RoleBll();
                    if (BllRole.RoleReferenceDelete(decRoleId) == -1)
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
                MessageBox.Show("RL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmUserCreation to view details and for updation
        /// </summary>
        /// <param name="frmUserCreation"></param>
        public void CallFromUserCreation(frmUserCreation frmUserCreation)
        {
            try
            {
                dgvRole.Enabled = false;
                this.frmUserCreationobj = frmUserCreation;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form load call the clear function and fill grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRole_Load(object sender, EventArgs e)
        {
            try
            {
                Gridfill();
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click, check the user privilage and call save or edit function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveOrEditFunction();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("RL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click, call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    decRoleId = Convert.ToDecimal(dgvRole.CurrentRow.Cells["dgvtxtRoleId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click
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
                MessageBox.Show("RL:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing, checking the other form status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmUserCreationobj != null)
                {
                    frmUserCreationobj.ReturnFromRoleForm(decRoleId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRole_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtRole.Focus();
                        txtRole.SelectionStart = 0;
                        txtRole.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("RL:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                inNarrationCount = 0;
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
                MessageBox.Show("RL:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRole_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ( e.KeyCode == Keys.Enter)
                {
                    if (dgvRole.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvRole.CurrentCell.ColumnIndex, dgvRole.CurrentCell.RowIndex);
                        dgvRole_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRole_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("RL:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRole_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose == true)
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
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
