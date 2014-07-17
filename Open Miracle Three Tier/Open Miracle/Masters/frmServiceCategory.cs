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
    public partial class frmServiceCategory : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strCategoryName;
        decimal decCategoryName;
        int inNarrationCount = 0;
        int q = 0;
        decimal decId = 0;
        frmServices frmServicesObj;
        #endregion

        #region Methods

        /// <summary>
        /// Create instance of frmServiceCategory
        /// </summary>
        public frmServiceCategory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                txtServiceCategory.Text = string.Empty;
                txtNarration.Text = string.Empty;
                txtServiceCategory.Focus();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill saved servicecategories in the grid
        /// </summary>
        public void Gridfill()
        {
            try
            {
                List<DataTable> listObjServiceCategory = new List<DataTable>();
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                listObjServiceCategory = BllServiceCatogory.ServiceCategoryParticularFieldsViewAll();
                dgvServiceCategory.DataSource = listObjServiceCategory[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to save service category
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                ServiceCategoryInfo infoServiceCategory = new ServiceCategoryInfo();
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                infoServiceCategory.CategoryName = txtServiceCategory.Text.Trim();
                infoServiceCategory.Narration = txtNarration.Text.Trim();
                infoServiceCategory.Extra1 = string.Empty;
                infoServiceCategory.Extra2 = string.Empty;
                if (BllServiceCatogory.ServiceCategoryCheckIfExist(txtServiceCategory.Text.Trim().ToString(), 0) == false)
                {
                    decId = BllServiceCatogory.ServiceCategoryAddSpecificFields1(infoServiceCategory);
                    Messages.SavedMessage();
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Service category name already exist");
                    txtServiceCategory.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to edit a service category
        /// </summary>
        public void EditFunction()
        {
            try
            {
                ServiceCategoryInfo infoServiceCategory = new ServiceCategoryInfo();
                ServiceCategoryBll BllServiceCatogry = new ServiceCategoryBll();
                infoServiceCategory.CategoryName = txtServiceCategory.Text.Trim();
                infoServiceCategory.Narration = txtNarration.Text.Trim();
                infoServiceCategory.Extra1 = string.Empty;
                infoServiceCategory.Extra2 = string.Empty;
                infoServiceCategory.ServicecategoryId = Convert.ToDecimal(dgvServiceCategory.CurrentRow.Cells["dgvtxtservicecategoryId"].Value.ToString());
                if (txtServiceCategory.Text.ToString() != strCategoryName)
                {
                    if (BllServiceCatogry.ServiceCategoryCheckIfExist(txtServiceCategory.Text.Trim().ToString(), 0) == false)
                    {
                        if (BllServiceCatogry.ServiceCategoryEditParticularFeilds(infoServiceCategory))
                        {
                            Messages.UpdatedMessage();
                            Clear();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Service category name already exist");
                        txtServiceCategory.Focus();
                    }
                }
                else
                {
                    BllServiceCatogry.ServiceCategoryEditParticularFeilds(infoServiceCategory);
                    Messages.UpdatedMessage();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call save or edit function after user confirmation and also checks invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtServiceCategory.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter service category name");
                    txtServiceCategory.Focus();
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
                        if (frmServicesObj != null)
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
                MessageBox.Show("SC5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to delete a servicecategory
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                if (BllServiceCatogory.ServiceCategoryCheckReferenceAndDelete(decCategoryName) == -1)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    BllServiceCatogory.ServiceCategoryDelete(Convert.ToDecimal(dgvServiceCategory.CurrentRow.Cells[1].Value.ToString()));
                    Messages.DeletedMessage();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call delete function after user confirmation
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
                MessageBox.Show("SC7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill controlls to edit or delete
        /// </summary>
        public void FillControls()
        {
            try
            {
                ServiceCategoryInfo infoServiceCategory = new ServiceCategoryInfo();
                ServiceCategoryBll BllServiceCatogory = new ServiceCategoryBll();
                infoServiceCategory = BllServiceCatogory.ServiceCategoryWithNarrationView(Convert.ToDecimal(dgvServiceCategory.CurrentRow.Cells[1].Value.ToString()));
                txtServiceCategory.Text = infoServiceCategory.CategoryName;
                txtNarration.Text = infoServiceCategory.Narration;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                strCategoryName = infoServiceCategory.CategoryName;
                decCategoryName = infoServiceCategory.ServicecategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Funtion to load the form while calling from service form to add new service category
        /// </summary>
        /// <param name="frmServices"></param>
        public void callFromServices(frmServices frmServices)
        {
            try
            {
                this.frmServicesObj = frmServices;
                grpServieceCatDetails.Enabled = false;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events

        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmServicesObj != null)
                {
                    frmServicesObj.ReturnFromServiceCategoryForm(decId);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       /// <summary>
       /// On Save button click
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
                    Clear();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On clear button click
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
                MessageBox.Show("SC11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, "Delete"))
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
                MessageBox.Show("SC12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceCategory_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On close button click
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
                MessageBox.Show("SC14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On double clicking in the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    FillControls();
                    txtServiceCategory.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation

        /// <summary>
        /// On short cut keys
        /// ctrl+s for save
        /// ctrl+d for delete
        /// Esc for form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceCategory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
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
                MessageBox.Show("SC17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enter key navigation of txtNarration
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
                MessageBox.Show("SC18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Backspace navigation of txtNarration
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
                        txtServiceCategory.Focus();
                        txtServiceCategory.SelectionStart = 0;
                        txtServiceCategory.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On Save button click
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
                MessageBox.Show("SC21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On enter key from the grid, cell double click works
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceCategory_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvServiceCategory.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvServiceCategory.CurrentCell.ColumnIndex, dgvServiceCategory.CurrentCell.RowIndex);
                        dgvServiceCategory_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SC26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enter key navigation of txtServiceCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServiceCategory_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SC27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
