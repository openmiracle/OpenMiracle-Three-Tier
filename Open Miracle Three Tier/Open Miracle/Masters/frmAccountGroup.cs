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
    public partial class frmAccountGroup : Form
    {
        #region Public Variables
        /// <summary>
        ///  public variable declaration part
        /// </summary>
        string strAccountGroupName;
        int inNarrationCount;
        decimal decAccountGroupId;
        frmAccountLedger frmAccountLedgerobj;
        decimal decIdForOtherForms = 0;
        decimal decAccountGroupIdForEdit;
        int inId;
        bool isDefault;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of a frmLogin class.
        /// </summary>
        public frmAccountGroup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill master grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                if (cmbGroupUnderSearch.Text.Trim() == string.Empty)
                {
                    cmbGroupUnderSearch.Text = "All";
                }
                ListObj = bllAccountGroup.AccountGroupSearch(txtAccountGroupNameSearch.Text.Trim(), cmbGroupUnderSearch.Text);
                dgvAccountGroup.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill account group combo
        /// </summary>
        public void GroupUnderComboFill()
        {
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupViewAllComboFill();
                cmbGroupUnder.DataSource = ListObj[0];
                cmbGroupUnder.ValueMember = "accountGroupId";
                cmbGroupUnder.DisplayMember = "accountGroupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill account group combo for Search
        /// </summary>
        public void GroupUnderSearchComboFill()
        {
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupViewAllComboFill();
                DataRow dr = ListObj[0].NewRow();
                dr[1] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbGroupUnderSearch.DataSource = ListObj[0];
                cmbGroupUnderSearch.ValueMember = "accountGroupId";
                cmbGroupUnderSearch.DisplayMember = "accountGroupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// resetting the Account group page
        /// </summary>
        public void Clear()
        {
            try
            {
                txtAccountGroupName.Clear();
                cmbAffectGrossProfit.SelectedIndex = -1;
                cmbGroupUnderSearch.SelectedIndex = -1;
                txtAccountGroupNameSearch.Clear();
                cmbNature.SelectedIndex = -1;
                txtNarration.Clear();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                txtAccountGroupName.Enabled = true;
                cmbAffectGrossProfit.Enabled = true;
                cmbGroupUnder.Enabled = true;
                cmbNature.Enabled = true;
                GridFill();
                txtAccountGroupName.Select();
                GroupUnderComboFill();
                cmbGroupUnder.SelectedIndex = -1;
                GroupUnderSearchComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check existance of account group in DataBase
        /// </summary>
        /// <returns></returns>
        public bool CheckExistanceOfGroupName()
        {
            bool isExist = false;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                isExist = bllAccountGroup.AccountGroupCheckExistence(txtAccountGroupName.Text.Trim(), 0);
                if (isExist)
                {
                    if (txtAccountGroupName.Text.ToLower() == strAccountGroupName.ToLower())
                    {
                        isExist = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        /// <summary>
        /// Function to save and edit account group
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                strAccountGroupName = btnSave.Text == "Save" ? string.Empty : strAccountGroupName;
                if (CheckExistanceOfGroupName() == false)
                {
                    if (txtAccountGroupName.Text.Trim() == string.Empty)
                    {
                        Messages.InformationMessage("Enter account group name");
                        txtAccountGroupName.Focus();
                    }
                    else if (cmbGroupUnder.SelectedIndex == -1)
                    {
                        Messages.InformationMessage("Select under");
                        cmbGroupUnder.Focus();
                    }
                    else if (cmbNature.SelectedIndex == -1)
                    {
                        Messages.InformationMessage("Select nature");
                        cmbNature.Focus();
                    }
                    else
                    {
                        AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
                        AccountGroupBll bllAccountGroup = new AccountGroupBll();
                        infoAccountGroup.AccountGroupName = txtAccountGroupName.Text.Trim();
                        infoAccountGroup.GroupUnder = Convert.ToDecimal(cmbGroupUnder.SelectedValue.ToString());
                        infoAccountGroup.Nature = cmbNature.SelectedItem.ToString();
                        if (cmbAffectGrossProfit.SelectedIndex == -1)
                        {
                            infoAccountGroup.AffectGrossProfit = "No";
                        }
                        else
                        {
                            infoAccountGroup.AffectGrossProfit = cmbAffectGrossProfit.SelectedItem.ToString();
                        }
                        infoAccountGroup.IsDefault = false;
                        infoAccountGroup.Narration = txtNarration.Text.Trim();
                        infoAccountGroup.Extra1 = string.Empty;
                        infoAccountGroup.Extra2 = string.Empty;
                        if (btnSave.Text == "Save")
                        {
                            if (Messages.SaveConfirmation())
                            {
                                decAccountGroupId = bllAccountGroup.AccountGroupAddWithIdentity(infoAccountGroup);
                                Messages.SavedMessage();
                                decIdForOtherForms = decAccountGroupId;
                                if (frmAccountLedgerobj != null)
                                {
                                    this.Close();
                                }
                                GridFill();
                                Clear();
                            }
                        }
                        else
                        {
                            if (isDefault == true)
                            {
                                Messages.InformationMessage("Can't update build in account group");
                            }
                            else if (txtAccountGroupName.Text.Trim().ToLower() != cmbGroupUnder.Text.ToLower())
                            {
                                if (Messages.UpdateConfirmation())
                                {
                                    infoAccountGroup.AccountGroupId = decAccountGroupIdForEdit;
                                    if (bllAccountGroup.AccountGroupUpdate(infoAccountGroup))
                                    {
                                        Messages.UpdatedMessage();
                                    }
                                    GridFill();
                                    Clear();
                                }
                            }
                            else
                            {
                                Messages.InformationMessage(" Can't save under same group");
                            }
                        }
                    }
                }
                else
                {
                    Messages.InformationMessage(" Account group already exist");
                    txtAccountGroupName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete account group
        /// </summary>
        public void Delete()
        {
            try
            {
                if (isDefault == true)
                {
                    Messages.InformationMessage("Can't delete build in account group");
                }
                //else if (PublicVariables.isMessageDelete)
                //{
                else if (Messages.DeleteConfirmation())
                {
                    AccountGroupInfo InfoAccountGroup = new AccountGroupInfo();
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    if ((bllAccountGroup.AccountGroupReferenceDelete(decAccountGroupIdForEdit) == -1))
                    {
                        Messages.ReferenceExistsMessage();
                    }
                    else
                    {
                        Messages.DeletedMessage();
                        btnSave.Text = "Save";
                        btnDelete.Enabled = false;
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from account group register
        /// </summary>
        /// <param name="frmAccountledger"></param>
        public void CallFromAccountLedger(frmAccountLedger frmAccountledger)
        {
            try
            {
                gbxAccountGroupSearch.Enabled = false;
                this.frmAccountLedgerobj = frmAccountledger;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// To close this form 
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
                MessageBox.Show("AG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To close this form on 'Close' button click
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
                MessageBox.Show("AG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape ,Save,Delete on Form keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    if (cmbGroupUnder.Focused)
                    {
                        cmbGroupUnder.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbGroupUnder.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
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
                MessageBox.Show("AG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills to control on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    AccountGroupInfo InfoAccountGroup = new AccountGroupInfo();
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    InfoAccountGroup = bllAccountGroup.AccountGroupViewForUpdate(Convert.ToDecimal(dgvAccountGroup.CurrentRow.Cells["dgvtxtAccountGroupId"].Value.ToString()));
                    bool Isdefault=InfoAccountGroup.IsDefault;
                    txtAccountGroupName.Text = InfoAccountGroup.AccountGroupName;
                    cmbGroupUnder.SelectedValue = InfoAccountGroup.GroupUnder.ToString();
                    decimal decAccountGroupId =Convert.ToDecimal(cmbGroupUnder.SelectedValue.ToString());
                    string strNature = bllAccountGroup.AccountGroupNatureUnderGroup(decAccountGroupId);
                    if (strNature != "NA")
                    {
                        cmbNature.Text = InfoAccountGroup.Nature;
                        cmbNature.Enabled = false;
                    }
                    else
                    {
                        cmbNature.Text = InfoAccountGroup.Nature;
                        cmbNature.Enabled = true;
                    }
                    if (Isdefault)
                    {
                        decimal decAffectGrossProfit = Convert.ToDecimal(InfoAccountGroup.AffectGrossProfit);
                        if (decAffectGrossProfit == 0)
                        {
                            cmbAffectGrossProfit.Text = "No";

                        }
                        else
                        {
                            cmbAffectGrossProfit.Text = "Yes";
                        }
                    }
                    else
                    {
                        cmbAffectGrossProfit.Text = InfoAccountGroup.AffectGrossProfit;
                    }
                    txtNarration.Text = InfoAccountGroup.Narration;
                    btnSave.Text = "Update";
                    txtAccountGroupName.Focus();
                    btnDelete.Enabled = true;
                    strAccountGroupName = InfoAccountGroup.AccountGroupName;
                    decAccountGroupIdForEdit = Convert.ToDecimal(dgvAccountGroup.CurrentRow.Cells["dgvtxtAccountGroupId"].Value.ToString());
                    inId = Convert.ToInt32(InfoAccountGroup.AccountGroupId.ToString());
                    isDefault = Convert.ToBoolean(InfoAccountGroup.IsDefault);

                    if (isDefault == true  && strNature!="NA")
                    {
                        txtAccountGroupName.Enabled = false;
                        cmbAffectGrossProfit.Enabled = false;
                        cmbGroupUnder.Enabled = false;
                        cmbNature.Enabled = false;
                    }
                    else
                    {
                        if (strNature == "NA")
                        {
                            txtAccountGroupName.Enabled = true;
                            cmbAffectGrossProfit.Enabled = true;
                            cmbGroupUnder.Enabled = true;
                            cmbNature.Enabled = true;
                        }
                        
                     }
                    if (isDefault == false)
                    {
                        if (bllAccountGroup.AccountGroupCheckExistenceOfUnderGroup(Convert.ToDecimal(inId.ToString())) == false)
                        {
                            cmbAffectGrossProfit.Enabled = false;
                            cmbGroupUnder.Enabled = false;
                            cmbNature.Enabled = false;
                        }
                        else
                        {
                            if (strNature == "NA")
                            {
                                cmbAffectGrossProfit.Enabled = true;
                                cmbGroupUnder.Enabled = true;
                                cmbNature.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill Datagridview on Search Button click
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
                MessageBox.Show("AG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears datagridview selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroup_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvAccountGroup.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset GroupUnder combo on leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGroupUnderSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroupUnderSearch.SelectedIndex == -1)
                {
                    cmbGroupUnderSearch.Text = "All";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On Nature combo keypress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNature_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmbNature.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On AffectGrossProfit combo keypress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAffectGrossProfit_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmbAffectGrossProfit.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //On GroupUnder combo keypress
        private void cmbGroupUnderSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                cmbGroupUnderSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmAccountLedgerobj != null)
                {
                    frmAccountLedgerobj.ReturnFromAccountGroupForm(decIdForOtherForms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbGroupUnder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroupUnder.SelectedValue != null && cmbGroupUnder.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    decimal decAccountGroupId = Convert.ToDecimal(cmbGroupUnder.SelectedValue.ToString());
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
                    infoAccountGroup = bllAccountGroup.AccountGroupView(decAccountGroupId);
                    string strNature = infoAccountGroup.Nature;
                    string strIsAffectGrossProfit = infoAccountGroup.AffectGrossProfit;
                    if (strNature != "NA")
                    {
                        cmbNature.Text = strNature;
                        if (infoAccountGroup.AffectGrossProfit == "1")
                        {
                            cmbAffectGrossProfit.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbAffectGrossProfit.SelectedIndex = 1;
                        }
                        cmbNature.Enabled = false;
                        cmbAffectGrossProfit.Enabled = false;
                       
                    }
                    else
                    {
                        cmbNature.Enabled = true;
                        cmbAffectGrossProfit.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {                
            }           
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enter key navigation on txtAccountGroupName textbox KeyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAccountGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbGroupUnder.Enabled)
                    {
                        cmbGroupUnder.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation on cmbGroupUnder KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGroupUnder_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbNature.Enabled)
                    {
                        cmbNature.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbGroupUnder.Text == string.Empty || cmbGroupUnder.SelectionStart == 0)
                    {
                        txtAccountGroupName.SelectionStart = 0;
                        txtAccountGroupName.SelectionLength = 0;
                        txtAccountGroupName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation on cmbNature KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNature_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbAffectGrossProfit.Enabled)
                    {
                        cmbAffectGrossProfit.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbNature.SelectionStart == 0 || cmbNature.Text == string.Empty)
                    {
                        cmbGroupUnder.SelectionStart = 0;
                        cmbGroupUnder.SelectionLength = 0;
                        cmbGroupUnder.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation on cmbAffectGrossProfit KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAffectGrossProfit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbAffectGrossProfit.SelectionStart == 0 || cmbAffectGrossProfit.Text == string.Empty)
                    {
                        cmbNature.SelectionStart = 0;
                        cmbNature.SelectionLength = 0;
                        cmbNature.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation on txtNarration KeyDown 
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
                        cmbAffectGrossProfit.Focus();
                        cmbAffectGrossProfit.SelectionStart = 0;
                        cmbAffectGrossProfit.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key  navigation on txtNarration Enter
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
                MessageBox.Show("AG32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key  navigation on txtNarration textbox KeyPress
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
                MessageBox.Show("AG33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Backspace navigation on btnSave button KeyDown 
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
                MessageBox.Show("AG34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation on btnSearch button KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbGroupUnderSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation on txtAccountGroupNameSearch textbox KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAccountGroupNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbGroupUnderSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation on cmbGroupUnderSearch combobox KeyDown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGroupUnderSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbGroupUnderSearch.SelectionStart == 0 || cmbGroupUnderSearch.Text == string.Empty)
                    {
                        txtAccountGroupNameSearch.SelectionStart = 0;
                        txtAccountGroupNameSearch.SelectionLength = 0;
                        txtAccountGroupNameSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation on dgvAccountGroup datagridview KeyUp 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroup_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    if (dgvAccountGroup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvAccountGroup.CurrentCell.ColumnIndex, dgvAccountGroup.CurrentCell.RowIndex);
                        dgvAccountGroup_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation on dgvAccountGroup datagridview KeyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbGroupUnderSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        
    }
}
