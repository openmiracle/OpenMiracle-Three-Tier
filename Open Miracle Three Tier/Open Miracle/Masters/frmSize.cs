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

    public partial class frmSize : Form
    {
        #region Public variables
        
        /// <summary>
        /// public variable declaration part
        /// </summary>
        decimal decSizeId;
        int inNarrationCount = 0;
        decimal decIdForOtherForms;
        decimal decIdentity;
        frmProductCreation frmProductCreationObj;
        frmMultipleProductCreation frmMultipleProductCreationObj;
        #endregion

        #region Function
        /// <summary>
        /// Create an Instance for frmSize Class
        /// </summary>
        public frmSize()
        {
            InitializeComponent();
        }
        /// <summary>
        /// GridFill function 
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                SizeBll BllSize = new SizeBll();
                listObj = BllSize.SizeViewAlling();
                dgvSize.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                SizeBll BllSize = new SizeBll();
                SizeInfo infoSize = new SizeInfo();
                infoSize.Size = txtSize.Text.Trim();
                infoSize.Narration = txtNarration.Text.Trim();
                infoSize.Extra1 = String.Empty;
                infoSize.Extra2 = String.Empty;
                if (BllSize.SizeNameCheckExistence(txtSize.Text.Trim().ToString(), 0) == false)
                {
                    decIdentity = BllSize.SizeAdding(infoSize);
                    if (decIdentity>0)
                    {
                        Messages.SavedMessage();
                        GridFill();
                        Clear();
                    }
                }
                else
                {
                    Messages.InformationMessage(" Size already exist");
                    txtSize.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                SizeBll BllSize = new SizeBll();
                SizeInfo infoSize = new SizeInfo();
                infoSize.Size = txtSize.Text.Trim();
                infoSize.Narration = txtNarration.Text.Trim();
                infoSize.Extra1 = String.Empty;
                infoSize.Extra2 = String.Empty;
                infoSize.SizeId = decSizeId;
                if (BllSize.SizeNameCheckExistence(txtSize.Text.Trim().ToString(), decSizeId) == false)
                {
                    if (BllSize.SizeEditing(infoSize))
                    {
                        Messages.UpdatedMessage();
                        GridFill();
                        Clear();
                    }
                }
                else
                {
                    Messages.InformationMessage("Size already exist");
                    txtSize.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking Invalid entries for Save Or Update
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (txtSize.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter Size");
                    txtSize.Focus();
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
                MessageBox.Show("SZ4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete Function
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                SizeBll BllSize= new SizeBll();
                if (BllSize.SizeDeleting(decSizeId) <= 0)
                {
                    Messages.ReferenceExistsMessage();
                }
                else
                {
                    Messages.DeletedMessage();
                    GridFill();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// checking confirmation for delete and calling the delete function
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
                MessageBox.Show("SZ6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset the form here
        /// </summary>
        public void Clear()
        {
            try
            {
                txtSize.Text = string.Empty;
                txtNarration.Text = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtSize.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its a call from product creation form to create a new size 
        /// </summary>
        /// <param name="frmProduct"></param>
        public void CallFromProdutCreation(frmProductCreation frmProduct)
        {
            try
            {
                frmProduct.Enabled = false;
                this.frmProductCreationObj = frmProduct;
                base.Show();
                dgvSize.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its a call from Multip[le product creation form to create a new size 
        /// </summary>
        /// <param name="frmMultipleProductCreation"></param>
        public void CallMultipleProductCreation(frmMultipleProductCreation frmMultipleProductCreation)
        {
            try
            {
                this.frmMultipleProductCreationObj = frmMultipleProductCreation;
                base.Show();
                dgvSize.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ9 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("SZ10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SZ11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid cell double click for update or delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSize_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvSize.CurrentRow.Cells["dgvtxtsizeId"].Value != null && dgvSize.CurrentRow.Cells["dgvtxtsizeId"].Value.ToString()!=string.Empty)
                    {
                        decSizeId = Convert.ToDecimal(dgvSize.CurrentRow.Cells["dgvtxtsizeId"].Value.ToString());
                        if (decSizeId != 1)
                        {
                            SizeBll BllSize = new SizeBll();
                            SizeInfo infoSize = new SizeInfo();
                            infoSize = BllSize.SizeViewing(decSizeId);
                            txtSize.Text = infoSize.Size;
                            txtNarration.Text = infoSize.Narration;
                            btnSave.Text = "Update";
                            btnDelete.Enabled = true;
                            txtSize.Focus();
                            

                        }
                        else
                        {
                            Messages.InformationMessage(" NA Size canot update or delete");
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When form loads clear all are the controlls here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSize_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click and user privilage check
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
                MessageBox.Show("SZ14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click and privilage check
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
                MessageBox.Show("SZ15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SZ16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When Form closing Checking the other forms objects and return the id of created Size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmProductCreationObj != null)
                {
                    frmProductCreationObj.ReturnFromSizeForm(decIdForOtherForms);
                    dgvSize.Enabled = false;
                    frmProductCreationObj.Enabled = true;
                }
                if (frmMultipleProductCreationObj != null)
                {
                    frmMultipleProductCreationObj.ReturnFromSizeForm(decIdForOtherForms);
                    dgvSize.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// For Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == String.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtSize.Focus();
                        txtSize.SelectionStart = 0;
                        txtSize.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get narration line count For EnterKey and Backspace navigation
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
                MessageBox.Show("SZ19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For EnterKey and Backspace navigation
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
                MessageBox.Show("SZ20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For EnterKey and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSize_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SZ21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For  Backspace navigation
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
                MessageBox.Show("SZ22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For EnterKey and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSize_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SZ23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For EnterKey and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSize_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ( e.KeyCode == Keys.Enter)
                {
                    if (dgvSize.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSize.CurrentCell.ColumnIndex, dgvSize.CurrentCell.RowIndex);
                        dgvSize_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For form keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSize_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                    {
                        
                        btnSave_Click(sender, e);
                    }
                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled == true)
                    {
                        if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                        {
                           
                            btnDelete_Click(sender, e);
                        }
                        else
                        {
                            Messages.NoPrivillageMessage();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
