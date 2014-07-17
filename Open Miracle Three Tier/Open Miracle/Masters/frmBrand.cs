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
//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
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
    public partial class frmBrand : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decBrandId = 0;
        int inNarrationCount = 0;
        string strBrandName=string.Empty;
        string strMan = string.Empty;
        decimal decIdForOtherForms;
        decimal decIdentity;
        frmProductCreation frmProductCreationObj;
        frmMultipleProductCreation frmMultipleProductCreationObj;
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmBrand class
        /// </summary>
        public frmBrand()
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
                txtBrandNameSearch.Text = string.Empty;
                txtBrandName.Clear();
                txtManufacturer.Clear();
                txtNarration.Clear();
                btnSave.Text = "Save";
                GridFill();
                btnDelete.Enabled = false;
                txtBrandName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                BrandBll BllBrand = new BrandBll();
                BrandInfo infoBrand = new BrandInfo();
                infoBrand.BrandName = txtBrandName.Text.Trim();
                infoBrand.Narration = txtNarration.Text.Trim(); ;
                infoBrand.Manufacturer = txtManufacturer.Text.Trim();
                infoBrand.ExtraDate = DateTime.Now;
                infoBrand.Extra1 = string.Empty;
                infoBrand.Extra2 = string.Empty;
                if (BllBrand.BrandCheckIfExist(txtBrandName.Text.Trim(), 0) == false)
                {
                    decIdentity = BllBrand.BrandAdd(infoBrand);
                    Messages.SavedMessage();
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Brand name already exist");
                    txtBrandName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                BrandBll BllBrand = new BrandBll();
                BrandInfo infoBrand = new BrandInfo();
                infoBrand.BrandName = txtBrandName.Text.Trim();
                infoBrand.Narration = txtNarration.Text.Trim();
                infoBrand.Manufacturer = txtManufacturer.Text.Trim();
                infoBrand.Extra1 = string.Empty;
                infoBrand.Extra2 = string.Empty;
                infoBrand.ExtraDate = DateTime.Now;
                infoBrand.BrandId = decBrandId;
                if (txtBrandName.Text != strBrandName)
                {
                    if (CheckExistenceOfBrandName() == false)
                    {
                        if (BllBrand.BrandEdit(infoBrand))
                        {
                            Messages.UpdatedMessage();
                            Clear();
                            txtBrandName.Focus();
                        }
                        else if (infoBrand.BrandId == 1)
                        {
                            Messages.InformationMessage("Cannot update");
                            Clear();
                            txtBrandName.Focus();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Brand name already exists");
                        txtBrandName.Focus();
                    }
                }
                else if (infoBrand.BrandId == 1)
                {
                    Messages.InformationMessage("Cannot update");
                    Clear();
                    txtBrandName.Focus();
                }
                else
                {
                    if (BllBrand.BrandEdit(infoBrand))
                    {
                        Messages.UpdatedMessage();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtBrandName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter brand name ");
                    txtBrandName.Focus();
                }
                else if (txtManufacturer.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter manufacturer");
                    txtManufacturer.Focus();
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
                        decIdForOtherForms = decIdentity;
                        if (frmProductCreationObj != null)
                        {
                            this.Close();
                        }
                        if (frmMultipleProductCreationObj != null)
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
                MessageBox.Show("BR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call delete
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
                MessageBox.Show("BR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                BrandBll BllBrand = new BrandBll();
                if (BllBrand.BrandDeleteCheckExistence(decBrandId) <= 0)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    Clear();
                    btnSave.Text = "Save";
                    Messages.DeletedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                BrandBll BllBrand = new BrandBll();
                List<DataTable> listBrand = new List<DataTable>();
                listBrand = BllBrand.BrandSearch(txtBrandNameSearch.Text.Trim());
                dgvBrand.DataSource = listBrand[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check existence of brand name
        /// </summary>
        /// <returns></returns>
        public bool CheckExistenceOfBrandName()
        {
            bool isExist = false;
            try
            {
                BrandBll BllBrand = new BrandBll();
                isExist = BllBrand.BrandCheckIfExist(txtBrandName.Text.Trim(), 0);
                if (isExist)
                {
                    string strBrandNames = txtBrandName.Text.Trim();
                    if (strBrandNames.ToLower() == strBrandName.ToLower())
                    {
                        isExist = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        /// <summary>
        /// Function to call this form from product creation
        /// </summary>
        /// <param name="frmProduct"></param>
        public void CallFromProdutCreation(frmProductCreation frmProduct)
        {
            try
            {
                frmProduct.Enabled = false;
                this.frmProductCreationObj = frmProduct;
                base.Show();
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from multiple product creation
        /// </summary>
        /// <param name="frmMultipleProductCreation"></param>
        public void CallFromMultipleProdutCreation(frmMultipleProductCreation frmMultipleProductCreation)
        {
            try
            {
                this.frmMultipleProductCreationObj = frmMultipleProductCreation;
                base.Show();
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrand_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Delete();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("BR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrand_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave_Click(sender, e);
                }
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
                MessageBox.Show("BR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("BR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("BR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmClose_Click(object sender, EventArgs e)
        {
            try
            {
                btnClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Brandname' textbox textchanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBrandNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
                txtBrandNameSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill controls on datagridview cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    BrandInfo infoBrand = new BrandInfo();
                    BrandBll BllBrand = new BrandBll();
                    strBrandName = dgvBrand.CurrentRow.Cells["Column1"].Value.ToString();
                    if (strBrandName != "NA")
                    {
                        decBrandId = Convert.ToDecimal(dgvBrand.Rows[e.RowIndex].Cells["dgvtxtBrandid"].Value.ToString());
                        infoBrand = BllBrand.BrandView(decBrandId);
                        txtBrandName.Text = infoBrand.BrandName;
                        txtManufacturer.Text = infoBrand.Manufacturer;
                        txtNarration.Text = infoBrand.Narration;
                        btnSave.Text = "Update";
                        txtBrandName.Focus();
                        btnDelete.Enabled = true;
                        strBrandName = infoBrand.BrandName;
                    }
                    else
                    {
                        Messages.WarningMessage("NA Brand cannot update or delete");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBrand_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvBrand.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrand_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmProductCreationObj != null)
                {
                    frmProductCreationObj.ReturnFromBrandForm(decIdForOtherForms);
                    groupBox2.Enabled = true;
                    frmProductCreationObj.Enabled = true;
                }
                if (frmMultipleProductCreationObj != null)
                {
                    frmMultipleProductCreationObj.ReturnFromBrandForm(decIdForOtherForms);
                    groupBox2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// datagridview key up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBrand_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (dgvBrand.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvBrand.CurrentCell.ColumnIndex, dgvBrand.CurrentCell.RowIndex);
                        dgvBrand_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Narartion' textbox key enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtNarration.Text = txtNarration.Text.Trim();
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
                MessageBox.Show("BR23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Narartion' textbox key press
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
                MessageBox.Show("BR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Narartion' textbox key down
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
                        txtManufacturer.Focus();
                        txtManufacturer.SelectionStart = 0;
                        txtManufacturer.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Brandname' textbox keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBrandName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtManufacturer.Focus();
                    txtManufacturer.SelectionStart = txtManufacturer.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Manufacturer' textbox keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtManufacturer.Text == string.Empty || txtManufacturer.SelectionStart == 0)
                    {
                        txtBrandName.Focus();
                        txtBrandName.SelectionStart = 0;
                        txtBrandName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save' button keydown
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
                MessageBox.Show("BR28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Brandname' textbox keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBrandNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvBrand.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On datagridview keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBrand_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtBrandNameSearch.Focus();
                    txtBrandNameSearch.SelectionStart = 0;
                    txtBrandNameSearch.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
