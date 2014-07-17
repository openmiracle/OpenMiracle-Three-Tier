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
    public partial class frmPayHead : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration parts
        /// </summary>
        string strPayHeadName = string.Empty;
        string strPayheadType = string.Empty;
        decimal decUserId = PublicVariables._decCurrentUserId;
        string strFormName = "frmPayHead";
        int inNarrationCount = 0;
        decimal decPayHeadId;

        #endregion

        #region Functions
        /// <summary>
        /// creates an instance of frmPayHead class
        /// </summary>
        public frmPayHead()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function for save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                PayHeadInfo infoPayhead = new PayHeadInfo();
                infoPayhead.PayHeadName = txtPayheadName.Text.Trim();
                infoPayhead.Type = cmbPayheadType.SelectedItem.ToString();
                infoPayhead.Narration = txtPayheadNarration.Text.Trim();
                infoPayhead.ExtraDate = DateTime.Parse(DateTime.Now.ToString());
                infoPayhead.Extra1 = string.Empty;
                infoPayhead.Extra2 = string.Empty;
                if (btnPayheadSave.Text == "Save")
                {
                    if (BllPayHead.PayheadCheckExistence(txtPayheadName.Text.Trim(), 0) == false)
                    {
                        Messages.SavedMessage();
                        BllPayHead.PayHeadAdd(infoPayhead);
                        GridFill();
                        Clear();
                    }
                    else
                    {
                        Messages.InformationMessage("Payhead name already exist");
                        txtPayheadName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                PayHeadInfo infoPayhead = new PayHeadInfo();
                infoPayhead.PayHeadId = decPayHeadId;
                infoPayhead.PayHeadName = txtPayheadName.Text.Trim();
                infoPayhead.Type = cmbPayheadType.Text;
                infoPayhead.Narration = txtPayheadNarration.Text.Trim();
                if (BllPayHead.PayheadCheckExistence(txtPayheadName.Text.Trim(), infoPayhead.PayHeadId) == false)
                {
                    BllPayHead.PayHeadEdit(infoPayhead);
                    GridFill();
                    Messages.UpdatedMessage();
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Payhead name already exist");
                    txtPayheadName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveorEdit()
        {
            try
            {
                if (txtPayheadName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter payhead name");
                    txtPayheadName.Focus();
                }
                else if (cmbPayheadType.Text == string.Empty)
                {
                    Messages.InformationMessage("Select type");
                    cmbPayheadType.Focus();
                }
                else
                {
                    if (btnPayheadSave.Text == "Save")
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
                MessageBox.Show("PH3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                PayHeadBll BllPayHead = new PayHeadBll();
                List<DataTable> listPayhead = new List<DataTable>();
                listPayhead = BllPayHead.PayHeadSearch(txtPayheadSearch.Text.Trim());
                dgvPayhead.DataSource = listPayhead[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtPayheadName.Focus();
                txtPayheadName.Clear();
                cmbPayheadType.SelectedIndex = -1;
                txtPayheadNarration.Clear();
                btnPayheadSave.Text = "Save";
                btnPayheadDelete.Enabled = false;
                txtPayheadSearch.Clear();
                dgvPayhead.ClearSelection();
                cmbPayheadType.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                PayHeadInfo infoPayhead = new PayHeadInfo();
                PayHeadBll BllPayHead = new PayHeadBll();
                if (BllPayHead.PayHeadDeleteVoucherTypeCheckReference(decPayHeadId))
                {
                    Messages.ReferenceExistsMessage();
                    txtPayheadName.Focus();
                }
                else
                {
                    Messages.DeletedMessage();
                    Clear();
                }
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// ON 'Save' buton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayheadSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(decUserId, strFormName, btnPayheadSave.Text))
                {
                    SaveorEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPayHead_Load(object sender, EventArgs e)
        {
            try
            {
                GridFill();
                btnPayheadDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayheadClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("PH9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills datagridview on Search textbox text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayheadDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(decUserId, strFormName, btnPayheadDelete.Text))
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
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayheadClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection on databind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dgvPayhead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvPayhead.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills controls for updation on cell double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPayhead_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    PayHeadInfo infoPayhead = new PayHeadInfo();
                    PayHeadBll BllPayHead = new PayHeadBll();
                    infoPayhead = BllPayHead.PayHeadView(Convert.ToDecimal(dgvPayhead.CurrentRow.Cells["dgvtxtPayheadId"].Value.ToString()));
                    txtPayheadName.Text = infoPayhead.PayHeadName;
                    cmbPayheadType.Text = infoPayhead.Type;
                    strPayheadType = cmbPayheadType.Text;
                    txtPayheadNarration.Text = infoPayhead.Narration;
                    btnPayheadSave.Text = "Update";
                    btnPayheadDelete.Enabled = true;
                    strPayHeadName = infoPayhead.PayHeadName;
                    decPayHeadId = Convert.ToDecimal(dgvPayhead.CurrentRow.Cells["dgvtxtPayheadId"].Value.ToString());
                    if (BllPayHead.payheadTypeCheckeferences(infoPayhead.PayHeadId, txtPayheadName.Text, cmbPayheadType.Text, txtPayheadNarration.Text))
                    {
                        if (e.RowIndex != -1)
                        {
                            cmbPayheadType.Enabled = true;
                        }
                    }
                    else
                    {
                        cmbPayheadType.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Navigation
        /// <summary>
        /// Escape key navigation and quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPayHead_KeyDown(object sender, KeyEventArgs e)
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

                    btnPayheadSave_Click(sender, e);
                }
                if (btnPayheadDelete.Enabled == true)
                {
                    if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                    {

                        btnPayheadDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPayheadType.Enabled == true)
                    {
                        cmbPayheadType.Focus();
                    }
                    else
                    {
                        txtPayheadNarration.Focus();
                        txtPayheadNarration.SelectionStart = 0;
                        txtPayheadNarration.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPayheadType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPayheadNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPayheadType.Text == string.Empty || cmbPayheadType.SelectionStart == 0)
                    {
                        txtPayheadName.Focus();
                        txtPayheadName.SelectionStart = 0;
                        txtPayheadName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtPayheadNarration.Text = txtPayheadNarration.Text.Trim();
                if (txtPayheadNarration.Text == string.Empty)
                {
                    txtPayheadNarration.SelectionStart = 0;
                    txtPayheadNarration.SelectionLength = 0;
                    txtPayheadNarration.Focus();
                }
                else
                {
                    txtPayheadNarration.SelectionStart = txtPayheadNarration.Text.Trim().Length;
                    txtPayheadNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        btnPayheadSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPayheadType.Enabled == true)
                    {
                        if (txtPayheadNarration.Text == string.Empty || txtPayheadNarration.SelectionStart == 0)
                        {
                            cmbPayheadType.Focus();
                            cmbPayheadType.SelectionStart = 0;
                            cmbPayheadType.SelectionLength = 0;
                        }
                    }
                    else
                    {
                        if (txtPayheadNarration.Text == string.Empty || txtPayheadNarration.SelectionStart == 0)
                        {
                            txtPayheadName.Focus();
                            txtPayheadName.SelectionStart = 0;
                            txtPayheadName.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill controls for updation on Enter key in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPayhead_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ( e.KeyCode == Keys.Enter)
                {
                    if (dgvPayhead.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs PayheadObj = new DataGridViewCellEventArgs(dgvPayhead.CurrentCell.ColumnIndex, dgvPayhead.CurrentCell.RowIndex);
                        dgvPayhead_CellDoubleClick(sender, PayheadObj);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayheadSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvPayhead.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPayhead_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPayheadSearch.Focus();
                    txtPayheadSearch.SelectionStart = 0;
                    txtPayheadSearch.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PH23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayheadSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPayheadNarration.Focus();
                    txtPayheadNarration.SelectionStart = 0;
                    txtPayheadNarration.SelectionLength = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PH24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion


    }
}


