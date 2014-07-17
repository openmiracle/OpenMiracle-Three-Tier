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
    public partial class frmTax : Form
    {
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        bool isDefault = false;
        decimal decTaxId;
        int inNarrationCount;
        string strTaxName;
        decimal decTaxIdForEdit;
        decimal decIdForOtherForms;
        frmProductCreation frmProductCreationObj;
        decimal decLedgerId = 0;

        #endregion

        #region Functions
        /// <summary>
        /// creating an instance for frmTax Class
        /// </summary>
        public frmTax()
        {
            InitializeComponent();
        }
        /// <summary>
        /// its a call function from product creation from to create a new tax
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
            catch(Exception ex)
            {
                MessageBox.Show("TC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// reset the form here
        /// </summary>
        public void Clear()
        {
            try
            {
                txtTaxName.Clear();
                txtRate.Clear();
                txtNarration.Clear();
                dgvTaxSelection.Enabled = false;
                cmbApplicableFor.SelectedIndex = -1;
                cmbCalculationMode.SelectedIndex = -1;
                cmbCalculationMode.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                cbxActive.Checked = true;
                dgvTaxSearch.ClearSelection();
                TaxSelectionGridFill();
                decLedgerId = 0;
                txtTaxName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  search function clear function
        /// </summary>
        public void SearchClear()
        {
            try
            {
                txtTaxNameSearch.Clear();
                cmbActiveSearch.SelectedIndex = 0;
                cmbApplicableForSearch.SelectedIndex = 0;
                cmbCalculationModeSearch.SelectedIndex = 0;
                txtTaxNameSearch.Focus();
                TaxSearchGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// save function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                TaxInfo infoTax = new TaxInfo();              
                TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
                TaxBll bllTax = new TaxBll();
                infoTax.TaxName = txtTaxName.Text.Trim();
                infoTax.Rate = Convert.ToDecimal(txtRate.Text.ToString());
                infoTax.ApplicableOn = cmbApplicableFor.SelectedItem.ToString();
                if (cmbCalculationMode.Enabled != true)
                {
                    infoTax.CalculatingMode = string.Empty;
                }
                else
                {
                    infoTax.CalculatingMode = cmbCalculationMode.SelectedItem.ToString();
                }
                infoTax.Narration = txtNarration.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoTax.IsActive = true;
                }
                else
                {
                    infoTax.IsActive = false;
                }
                infoTax.Extra1 = string.Empty;
                infoTax.Extra2 = string.Empty;
                if (bllTax.TaxCheckExistence(0, txtTaxName.Text.Trim()) == false)
                {
                    decTaxId = bllTax.TaxAddWithIdentity(infoTax);
                    decIdForOtherForms = decTaxId;
                    if (dgvTaxSelection.RowCount > 0)
                    {
                        bool isOk = false;
                        foreach (DataGridViewRow dgvRow in dgvTaxSelection.Rows)
                        {
                            isOk = Convert.ToBoolean(dgvRow.Cells["dgvcbxSelect"].Value);
                            if (isOk)
                            {
                                infoTaxDetails.TaxId = decTaxId;
                                infoTaxDetails.SelectedtaxId = Convert.ToDecimal(dgvRow.Cells["dgvtxtTaxId"].Value.ToString());//dgvRow.Cells[0].Value.ToString();
                                infoTaxDetails.ExtraDate = DateTime.Now;
                                infoTaxDetails.Extra1 = string.Empty;
                                infoTaxDetails.Extra2 = string.Empty;
                                bllTax.TaxDetailsAddWithoutId(infoTaxDetails);
                            }
                        }
                    }
                    CreateLedger();
                    Messages.SavedMessage();
                    Clear();
                    SearchClear();
                }
                else
                {
                    Messages.InformationMessage(" Tax or ledger already exist");
                    txtTaxName.Focus();
                }
                if (frmProductCreationObj != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// update function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                TaxInfo infoTax = new TaxInfo();              
                TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
                TaxBll bllTax = new TaxBll();
                infoTax.TaxName = txtTaxName.Text.Trim();
                infoTax.Rate = Convert.ToDecimal(txtRate.Text.ToString());
                infoTax.ApplicableOn = cmbApplicableFor.SelectedItem.ToString();
                if (cmbCalculationMode.Enabled != true)
                {
                    infoTax.CalculatingMode = string.Empty;
                }
                else
                {
                    infoTax.CalculatingMode = cmbCalculationMode.SelectedItem.ToString();
                }
                infoTax.Narration = txtNarration.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoTax.IsActive = true;
                }
                else
                {
                    infoTax.IsActive = false;
                }
                infoTax.Extra1 = string.Empty;
                infoTax.Extra2 = string.Empty;
                if (txtTaxName.Text.ToString() != strTaxName)
                {
                    if (bllTax.TaxCheckExistence(decTaxIdForEdit, txtTaxName.Text.Trim()) == false)
                    {
                        infoTax.TaxId = decTaxId;
                        bllTax.TaxEdit(infoTax);
                        //-- Delete And Add Tax details --//
                        bllTax.TaxDetailsDeleteWithTaxId(decTaxId);
                        if (dgvTaxSelection.RowCount > 0)
                        {
                            bool isOk = false;
                            foreach (DataGridViewRow dgvRow in dgvTaxSelection.Rows)
                            {
                                isOk = Convert.ToBoolean(dgvRow.Cells["dgvcbxSelect"].Value);
                                if (isOk)
                                {
                                    infoTaxDetails.TaxId = decTaxId;
                                    infoTaxDetails.SelectedtaxId = Convert.ToDecimal(dgvRow.Cells["dgvtxtTaxId"].Value.ToString());//dgvRow.Cells[0].Value.ToString();
                                    infoTaxDetails.ExtraDate = DateTime.Now;
                                    infoTaxDetails.Extra1 = string.Empty;
                                    infoTaxDetails.Extra2 = string.Empty;
                                    bllTax.TaxDetailsAddWithoutId(infoTaxDetails);
                                }
                            }
                        }
                        LedgerEdit();
                        Messages.UpdatedMessage();
                        Clear();
                    }
                    else
                    {
                        Messages.InformationMessage(" Tax or ledger already exist");
                        txtTaxName.Focus();
                    }
                }
                else
                {
                    infoTax.TaxId = decTaxId;
                    bllTax.TaxEdit(infoTax);
                    bllTax.TaxDetailsDeleteWithTaxId(decTaxId);
                    if (dgvTaxSelection.RowCount > 0)
                    {
                        bool isOk = false;
                        foreach (DataGridViewRow dgvRow in dgvTaxSelection.Rows)
                        {
                            isOk = Convert.ToBoolean(dgvRow.Cells["dgvcbxSelect"].Value);
                            if (isOk)
                            {
                                infoTaxDetails.TaxId = decTaxId;
                                infoTaxDetails.SelectedtaxId = Convert.ToDecimal(dgvRow.Cells["dgvtxtTaxId"].Value.ToString());//dgvRow.Cells[0].Value.ToString();
                                infoTaxDetails.ExtraDate = DateTime.Now;
                                infoTaxDetails.Extra1 = string.Empty;
                                infoTaxDetails.Extra2 = string.Empty;
                                bllTax.TaxDetailsAddWithoutId(infoTaxDetails);
                            }
                        }
                    }
                    LedgerEdit();
                    Messages.UpdatedMessage();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// checking checking existance entries for save or edit function
        /// </summary>
        public void SaveOrEditMessage()
        {
            try
            {               
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                string strTaxNameForLedger = string.Empty;
                strTaxNameForLedger = txtTaxName.Text;

                
                    if (btnSave.Text == "Save")
                    {
                        if (!bllAccountLedger.AccountLedgerCheckExistence(strTaxNameForLedger, 0))
                        {
                            if (PublicVariables.isMessageAdd)
                            {
                                if (Messages.SaveMessage())
                                {

                                    SaveFunction();
                                    TaxSelectionGridFill();
                                    TaxSearchGridFill();
                                }
                            }
                            else
                            {
                                SaveFunction();
                                TaxSelectionGridFill();
                                TaxSearchGridFill();
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Cannot save. Ledger already exists");
                        }
                    }
                    else
                    {
                        if (!bllAccountLedger.AccountLedgerCheckExistence(strTaxNameForLedger, decLedgerId))
                        {
                            if (PublicVariables.isMessageEdit)
                            {
                                if (Messages.UpdateMessage())
                                {
                                    EditFunction();
                                    TaxSelectionGridFill();
                                    TaxSearchGridFill();
                                }
                            }
                            else
                            {
                                EditFunction();
                                TaxSelectionGridFill();
                                TaxSearchGridFill();
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Cannot save. Ledger already exists");
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// check invalid entries for save or update function
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                isDefault = false;
                if (txtTaxName.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter tax name");
                    txtTaxName.Focus();
                }
                else if (txtRate.Text.Trim() == string.Empty||(Convert.ToDecimal(txtRate.Text.ToString())<=0))
                {
                    Messages.InformationMessage("Enter rate");
                    txtRate.Focus();
                }
                else if (cmbApplicableFor.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select applicable for");
                    cmbApplicableFor.Focus();
                }
                else if (cmbCalculationMode.Enabled)
                {
                    if (cmbCalculationMode.SelectedIndex == -1)
                    {
                        Messages.InformationMessage("Select calculation mode");
                        cmbCalculationMode.Focus();
                    }
                    else if (dgvTaxSelection.Enabled)
                    {
                        int inRowCount = dgvTaxSelection.RowCount;
                        for (int i = 0; i <= inRowCount - 1; i++)
                        {
                            if (dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value != null && dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value.ToString() != "False")
                            {
                                isDefault = Convert.ToBoolean(dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value.ToString());
                            }
                        }
                        if (isDefault == false)
                        {
                            Messages.InformationMessage("Select tax items");
                            dgvTaxSelection.Focus();
                        }
                        else
                        {

                            SaveOrEditMessage();
                        }
                    }
                    else
                    {
                        SaveOrEditMessage();
                    }
                }
                else
                {
                    SaveOrEditMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// tax Selection grid fill function
        /// </summary>
        public void TaxSelectionGridFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllForTaxSelection();
                dgvTaxSelection.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// tax search grid fill
        /// </summary>
        public void TaxSearchGridFill()
        {
            string strCmbActiveSearchText = string.Empty;
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                if (cmbActiveSearch.Text == "Yes")
                {
                    strCmbActiveSearchText = "True";
                }
                else if (cmbActiveSearch.Text == "No")
                {
                    strCmbActiveSearchText = "False";
                }
                else
                {
                    strCmbActiveSearchText = "All";
                }
                ListObj = bllTax.TaxSearch(txtTaxNameSearch.Text.Trim(), cmbApplicableForSearch.Text, cmbCalculationModeSearch.Text, strCmbActiveSearchText);
                dgvTaxSearch.DataSource = ListObj[0];
                int inRowCount = dgvTaxSearch.RowCount;
                for (int i = 0; i <= inRowCount - 1; i++)
                {
                    if (dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value != null && dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value.ToString()!=string.Empty)
                    {
                        if (dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value.ToString() == "1")
                        {
                            dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value = "Yes";
                        }
                        if (dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value.ToString() == "0")
                        {
                            dgvTaxSearch.Rows[i].Cells["dgvtxtActive"].Value = "No";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// fill the curresponding details for update
        /// </summary>
        public void TaxSelectionFillForUpdate()
        {
            try
            {
                int inRowCount = dgvTaxSelection.RowCount;
                for (int i = 0; i < inRowCount; i++)
                {
                    dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value = false;
                }
                decTaxId = Convert.ToDecimal(dgvTaxSearch.CurrentRow.Cells["dgvtxtTaxIdSearch"].Value.ToString());
                TaxInfo infoTax = new TaxInfo();               
                TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
                TaxBll bllTax = new TaxBll();
                infoTax = bllTax.TaxView(decTaxId);
                txtTaxName.Text = infoTax.TaxName;
                txtRate.Text = infoTax.Rate.ToString();
                cmbApplicableFor.Text = infoTax.ApplicableOn;
                cmbCalculationMode.Text = infoTax.CalculatingMode;
                txtNarration.Text = infoTax.Narration;
                if (infoTax.IsActive.ToString() == "True")
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }
                strTaxName = infoTax.TaxName;
                decTaxIdForEdit = infoTax.TaxId;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxIdForTaxSelectionUpdate(decTaxId);
                foreach (DataRow dr in ListObj[0].Rows)
                {
                    string strTaxId = dr["selectedtaxId"].ToString();
                    for (int i = 0; i < inRowCount; i++)
                    {
                        if (dgvTaxSelection.Rows[i].Cells["dgvtxtTaxId"].Value.ToString() == strTaxId)
                        {
                            dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value = true;
                        }
                    }
                }

                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                decLedgerId = bllAccountLedger.AccountLedgerIdGetByName(txtTaxName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// delete function
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        TaxInfo infoTax = new TaxInfo();
                        TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
                        TaxBll bllTax = new TaxBll();
                        AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                        bool isExist = bllTax.TaxReferenceCheck(decTaxId);
                        if (!isExist)
                        {
                            if ((bllTax.TaxReferenceDelete(decTaxId,decLedgerId)) == -1)
                            {
                                Messages.ReferenceExistsMessage();
                            }
                            else
                            {
                                bllTax.TaxDetailsDeleteWithTaxId(decTaxId);
                                bllAccountLedger.AccountLedgerDelete(decLedgerId);
                                Messages.DeletedMessage();
                                TaxSearchGridFill();
                                TaxSelectionGridFill();
                                Clear();
                                SearchClear();
                            }
                        }
                        else
                        {
                            Messages.ReferenceExistsMessage();
                        }
                    }
                }
                else
                {
                    TaxInfo infoTax = new TaxInfo();                  
                    TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
                    TaxBll bllTax = new TaxBll();
                    bool isExist = bllTax.TaxReferenceCheck(decTaxId);
                    if (!isExist)
                    {
                        if ((bllTax.TaxReferenceDelete(decTaxId,decLedgerId)) == -1)
                        {
                            Messages.ReferenceExistsMessage();
                        }
                        else
                        {
                            bllTax.TaxDetailsDeleteWithTaxId(decTaxId);
                            Messages.DeletedMessage();
                            TaxSearchGridFill();
                            TaxSelectionGridFill();
                            Clear();
                            SearchClear();
                        }
                    }
                    else
                    {
                        Messages.ReferenceExistsMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Creating one ledger for the purticular tax
        /// </summary>
        public void CreateLedger()
        {
            try
            {
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                infoAccountLedger.AccountGroupId = 20;
                infoAccountLedger.LedgerName = txtTaxName.Text;
                infoAccountLedger.OpeningBalance = 0;
                infoAccountLedger.IsDefault = false;
                infoAccountLedger.CrOrDr = "Cr";
                infoAccountLedger.Narration = string.Empty;
                infoAccountLedger.MailingName = txtTaxName.Text;
                infoAccountLedger.Address = string.Empty;
                infoAccountLedger.Phone = string.Empty;
                infoAccountLedger.Mobile = string.Empty;
                infoAccountLedger.Email = string.Empty;
                infoAccountLedger.CreditPeriod = 0;
                infoAccountLedger.CreditLimit = 0;
                infoAccountLedger.PricinglevelId = 0;
                infoAccountLedger.BillByBill = false;
                infoAccountLedger.Tin = string.Empty;
                infoAccountLedger.Cst = string.Empty;
                infoAccountLedger.Pan = string.Empty;
                infoAccountLedger.RouteId = 1;
                infoAccountLedger.BankAccountNumber = string.Empty;
                infoAccountLedger.BranchName = string.Empty;
                infoAccountLedger.BranchCode = string.Empty;
                infoAccountLedger.ExtraDate = DateTime.Now;
                infoAccountLedger.Extra1 = string.Empty;
                infoAccountLedger.Extra2 = string.Empty;
                infoAccountLedger.AreaId = 1;
                bllAccountLedger.AccountLedgerAddWithIdentity(infoAccountLedger);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("TAX:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// editing the ledger on update
        /// </summary>
        public void LedgerEdit()
        {
            try
            {
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                infoAccountLedger.LedgerId = decLedgerId;
                infoAccountLedger.AccountGroupId = 20;
                infoAccountLedger.LedgerName = txtTaxName.Text;
                infoAccountLedger.OpeningBalance = 0;
                infoAccountLedger.IsDefault = false;
                infoAccountLedger.CrOrDr = "Cr";
                infoAccountLedger.Narration = string.Empty;
                infoAccountLedger.MailingName = txtTaxName.Text;
                infoAccountLedger.Address = string.Empty;
                infoAccountLedger.Phone = string.Empty;
                infoAccountLedger.Mobile = string.Empty;
                infoAccountLedger.Email = string.Empty;
                infoAccountLedger.CreditPeriod = 0;
                infoAccountLedger.CreditLimit = 0;
                infoAccountLedger.PricinglevelId = 0;
                infoAccountLedger.BillByBill = false;
                infoAccountLedger.Tin = string.Empty;
                infoAccountLedger.Cst = string.Empty;
                infoAccountLedger.Pan = string.Empty;
                infoAccountLedger.RouteId = 1;
                infoAccountLedger.BankAccountNumber = string.Empty;
                infoAccountLedger.BranchCode = string.Empty;
                infoAccountLedger.BranchName = string.Empty;
                infoAccountLedger.ExtraDate = DateTime.Now;
                infoAccountLedger.Extra1 = string.Empty;
                infoAccountLedger.Extra2 = string.Empty;
                infoAccountLedger.AreaId = 1;
                bllAccountLedger.AccountLedgerEdit(infoAccountLedger);
            }
            catch(Exception ex)
            {
                MessageBox.Show("TAX:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTax_Load(object sender, EventArgs e)
        {
            try
            {
                TaxSelectionGridFill();
                Clear();
                cmbActiveSearch.SelectedIndex = 0;
                cmbApplicableForSearch.SelectedIndex = 0;
                cmbCalculationModeSearch.SelectedIndex = 0;
                TaxSearchGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// form keydown for save,update and delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    if (dgvTaxSelection.Focused)
                    {
                        txtNarration.Focus();
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
                MessageBox.Show("TC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// save button click
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
                   txtRate.Focus();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// clear button click
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
                MessageBox.Show("TC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TaxSearchGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// close button click
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
                MessageBox.Show("TC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// search clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// combobox tax applicable index changed for calculating mode selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbApplicableFor_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbApplicableFor.Text == "Bill")
                {
                    cmbCalculationMode.Enabled = true;
                }
                else
                {
                    cmbCalculationMode.Enabled = false;
                    cmbCalculationMode.SelectedIndex = -1;
                    int inRowCount = dgvTaxSelection.RowCount;
                    for (int i = 0; i <= inRowCount - 1; i++)
                    {
                        dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to make enable the selection tax grid if the condition is satisfied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCalculationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCalculationMode.Text == "Tax Amount")
                {
                    dgvTaxSelection.Enabled = true;
                }
                else
                {
                    dgvTaxSelection.Enabled = false;
                    int inRowCount = dgvTaxSelection.RowCount;
                    for (int i = 0; i <= inRowCount - 1; i++)
                    {
                        dgvTaxSelection.Rows[i].Cells["dgvcbxSelect"].Value = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// rate keypress for decimal validation
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
                MessageBox.Show("TC23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Delete();
                    txtTaxName.Focus();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid binding complete event for clear the selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTaxSelection_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvTaxSelection.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// cell doublr click for update the items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTaxSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    TaxSelectionFillForUpdate();
                    txtTaxName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTax_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmProductCreationObj != null)
                {
                    frmProductCreationObj.ReturnFromTaxForm(decIdForOtherForms);
                    groupBox2.Enabled = true;
                    frmProductCreationObj.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// for enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTaxName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbApplicableFor.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtRate.Text == string.Empty || txtRate.SelectionStart == 0)
                    {
                        txtTaxName.SelectionStart = 0;
                        txtTaxName.SelectionLength = 0;
                        txtTaxName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter key and backspace for navigation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbApplicableFor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCalculationMode.Enabled)
                    {
                        cmbCalculationMode.Focus();
                    }
                    else if (dgvTaxSelection.Enabled)
                    {
                        dgvTaxSelection.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbApplicableFor.Text == string.Empty || cmbApplicableFor.SelectionStart == 0)
                    {
                        txtRate.SelectionStart = 0;
                        txtRate.SelectionLength = 0;
                        txtRate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCalculationMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvTaxSelection.Enabled)
                    {
                        dgvTaxSelection.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCalculationMode.Text == string.Empty || cmbCalculationMode.SelectionStart == 0)
                    {
                        cmbApplicableFor.SelectionStart = 0;
                        cmbApplicableFor.SelectionLength = 0;
                        cmbApplicableFor.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTaxSelection_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCalculationMode.Enabled)
                    {
                        cmbCalculationMode.SelectionStart = 0;
                        cmbCalculationMode.SelectionLength = 0;
                        cmbCalculationMode.Focus();
                    }
                    else
                    {
                        cmbApplicableFor.SelectionStart = 0;
                        cmbApplicableFor.SelectionLength = 0;
                        cmbApplicableFor.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
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
                        if (dgvTaxSelection.Enabled)
                        {
                            dgvTaxSelection.Focus();
                        }
                        else if (cmbCalculationMode.Enabled)
                        {
                            cmbCalculationMode.SelectionStart = 0;
                            cmbCalculationMode.SelectionLength = 0;
                            cmbCalculationMode.Focus();
                        }
                        else
                        {
                            cmbApplicableFor.SelectionStart = 0;
                            cmbApplicableFor.SelectionLength = 0;
                            cmbApplicableFor.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
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
                MessageBox.Show("TC34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// get count of textbox narration
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
                        cbxActive.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxActive.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter  navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTaxNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbApplicableForSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbApplicableForSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCalculationModeSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbApplicableForSearch.Text == string.Empty || cmbApplicableForSearch.SelectionStart == 0)
                    {
                        txtTaxNameSearch.SelectionStart = 0;
                        txtTaxNameSearch.SelectionLength = 0;
                        txtTaxNameSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCalculationModeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbActiveSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCalculationModeSearch.Text == string.Empty || cmbCalculationModeSearch.SelectionStart == 0)
                    {
                        cmbApplicableForSearch.SelectionStart = 0;
                        cmbApplicableForSearch.SelectionLength = 0;
                        cmbApplicableForSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbActiveSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbActiveSearch.Text == string.Empty || cmbActiveSearch.SelectionStart == 0)
                    {
                        cmbCalculationModeSearch.SelectionStart = 0;
                        cmbCalculationModeSearch.SelectionLength = 0;
                        cmbCalculationModeSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClearSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbActiveSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvTaxSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTaxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbActiveSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TC44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        

        
    }
}
