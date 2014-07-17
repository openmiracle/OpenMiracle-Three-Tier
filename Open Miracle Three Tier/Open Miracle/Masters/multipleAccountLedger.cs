
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
    public partial class frmmultipleAccountLedger : Form
    {
        #region Public Variables

        /// <summary>
        /// public variable declaration part
        /// </summary>
        bool isLoad = false;
        bool isValueChanged = false;

        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of a frmmultipleAccountLedger class.
        /// </summary>
        public frmmultipleAccountLedger()
        {
            InitializeComponent();
        }
        /// <summary>
        /// account group combo fill function
        /// </summary>
        public void cmbComboFill()
        {
            try
            {
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountLedger.MultipleAccountLedgerComboFill();
                cmbAccountGroup.DataSource = ListObj[0];
                cmbAccountGroup.ValueMember = "accountGroupId";
                cmbAccountGroup.DisplayMember = "accountGroupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Function to generate serial no automatically in the grid
        /// </summary>
        public void SlNo()
        {
            try
            {
                int inRowNo = 1;
                foreach (DataGridViewRow dr in dgvMultipleAccountLedger.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvMultipleAccountLedger.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check whether the values of grid is valid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleAccountLedger.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtLedgerName"].Value == null || dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtLedgerName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvMultipleAccountLedger.CurrentRow.HeaderCell.Value = "X";
                            isValueChanged = true;
                            dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvMultipleAccountLedger.CurrentRow.HeaderCell.Value = string.Empty;
                            isValueChanged = true;
                            dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtCheck"].Value = string.Empty;
                        }
                        if (dgvMultipleAccountLedger.Rows[e.RowIndex].Cells["dgvtxtLedgerName"].Value != null)
                        {
                            isValueChanged = true;
                            dgvMultipleAccountLedger.Rows[e.RowIndex].Cells["dgvtxtLedgerName"].Value = dgvMultipleAccountLedger.Rows[e.RowIndex].Cells["dgvtxtLedgerName"].Value.ToString().Trim();
                            foreach (DataGridViewRow rw in dgvMultipleAccountLedger.Rows)
                            {
                                if ((rw.Cells["dgvtxtLedgerName"].Value != null) && (rw.Index != e.RowIndex))
                                {
                                    if (rw.Cells["dgvtxtLedgerName"].Value.ToString() == dgvMultipleAccountLedger.Rows[e.RowIndex].Cells["dgvtxtLedgerName"].Value.ToString())
                                    {
                                        isValueChanged = true;
                                        dgvMultipleAccountLedger.Rows[e.RowIndex].HeaderCell.Value = string.Empty;
                                        isValueChanged = true;
                                        dgvMultipleAccountLedger.Rows[e.RowIndex].Cells["dgvtxtCheck"].Value = string.Empty;
                                        isValueChanged = true;
                                        rw.HeaderCell.Value = "X";
                                        isValueChanged = true;
                                        rw.Cells["dgvtxtCheck"].Value = "x";
                                        rw.Cells["dgvtxtCheck"].Style.ForeColor = Color.Red;
                                        rw.HeaderCell.Style.ForeColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// remove a row from grid if the data is incomplete in the purticular row
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvMultipleAccountLedger.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvMultipleAccountLedger.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgvtxtCheck"].Value.ToString() == "x" || dgvrowCur.Cells["dgvtxtLedgerName"].Value == null)
                        {
                            isOk = false;
                            if (inC == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvrowCur.Index + 1);
                                inForFirst = dgvrowCur.Index;
                                inC++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvrowCur.Index + 1);
                            }
                        }
                    }
                    inLastRow++;
                }
                inLastRow = 1;
                if (!isOk)
                {
                    strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvMultipleAccountLedger.Rows.Count; inK++)
                        {
                            if (dgvMultipleAccountLedger.Rows[inK].Cells["dgvtxtCheck"].Value != null && dgvMultipleAccountLedger.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "x")
                            {
                                if (!dgvMultipleAccountLedger.Rows[inK].IsNewRow)
                                {
                                    dgvMultipleAccountLedger.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvMultipleAccountLedger.Rows[inForFirst].Cells["dgvtxtLedgerName"].Selected = true;
                        dgvMultipleAccountLedger.CurrentCell = dgvMultipleAccountLedger.Rows[inForFirst].Cells["dgvtxtLedgerName"];
                        dgvMultipleAccountLedger.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return isOk;
        }
        /// <summary>
        /// check if data present in database
        /// </summary>
        /// <returns></returns>
        public bool CheckAlreadyExist()
        {
            bool isOk = true;
            try
            {
                AccountLedgerBll bllAccountledger = new AccountLedgerBll();
                int inCompleteRow = 0;
                int inCurrentindex = 0;
                string strMessage = "Row";
                foreach (DataGridViewRow dgvRow in dgvMultipleAccountLedger.Rows)
                {
                    if (dgvRow.Cells["dgvtxtLedgerName"].Value != null)
                    {
                        string LedgerName = dgvRow.Cells["dgvtxtLedgerName"].Value.ToString();
                        if (bllAccountledger.AccountLedgerCheckExistence(LedgerName, 0) == true)
                        {
                            isOk = false;
                            if (inCompleteRow == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvRow.Index + 1);
                                inCurrentindex = dgvRow.Index;
                                inCompleteRow++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvRow.Index + 1);
                            }
                        }
                    }
                }
                if (!isOk)
                {
                    strMessage = strMessage + " contains already exisitng ledgers. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvMultipleAccountLedger.Rows.Count; inK++)
                        {
                            if (dgvMultipleAccountLedger.Rows[inK].Cells["dgvtxtLedgerName"].Value != null)
                            {
                                string strLedgerName = dgvMultipleAccountLedger.Rows[inK].Cells["dgvtxtLedgerName"].Value.ToString().Trim();
                                if (bllAccountledger.AccountLedgerCheckExistence(strLedgerName, 0) == true)
                                {
                                    if (!dgvMultipleAccountLedger.Rows[inK].IsNewRow)
                                    {
                                        dgvMultipleAccountLedger.Rows.RemoveAt(inK);
                                        inK--;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvMultipleAccountLedger.Rows[inCurrentindex].Cells["dgvtxtLedgerName"].Selected = true;
                        dgvMultipleAccountLedger.CurrentCell = dgvMultipleAccountLedger.Rows[inCurrentindex].Cells["dgvtxtLedgerName"];
                        dgvMultipleAccountLedger.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return isOk;
        }
        /// <summary>
        /// Save data to the database
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                int inRowcount = dgvMultipleAccountLedger.RowCount;//edited by Runali
                int inRowcountDec = (dgvMultipleAccountLedger.RowCount) - 1;
                decimal decOpeningBalance = 0;
                decimal decLedgerId = 0;
                bool isSave = false;
                AccountLedgerInfo infoAccountledger = new AccountLedgerInfo();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                FinancialYearBll BllFinancialYear = new FinancialYearBll();
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();

                for (int i = 0; i < inRowcount - 1; i++)
                {
                    infoAccountledger.AccountGroupId = Convert.ToDecimal(cmbAccountGroup.SelectedValue.ToString());

                    infoAccountledger.LedgerName = dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtLedgerName"].Value.ToString();
                    if (dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value != null)
                    {
                        infoAccountledger.OpeningBalance = Convert.ToDecimal(dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value.ToString());
                    }
                    else
                    {
                        infoAccountledger.OpeningBalance = 0;
                    }
                    infoAccountledger.CrOrDr = dgvMultipleAccountLedger.Rows[i].Cells["dgvcmbDebitOrCredit"].Value.ToString();

                    if (dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtNarration"].Value != null)
                    {
                        infoAccountledger.Narration = dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtNarration"].Value.ToString();
                    }
                    else
                    {
                        infoAccountledger.Narration = string.Empty;
                    }
                    infoAccountledger.MailingName = string.Empty;
                    infoAccountledger.Address = string.Empty;
                    infoAccountledger.State = string.Empty;
                    infoAccountledger.Phone = string.Empty;
                    infoAccountledger.Mobile = string.Empty;
                    infoAccountledger.Email = string.Empty;
                    infoAccountledger.CreditPeriod = 0;
                    infoAccountledger.CreditLimit = 0;
                    infoAccountledger.PricinglevelId = 0;
                    infoAccountledger.BillByBill = false;
                    infoAccountledger.Tin = string.Empty;
                    infoAccountledger.Cst = string.Empty;
                    infoAccountledger.Pan = string.Empty;
                    infoAccountledger.RouteId = 0;
                    infoAccountledger.BankAccountNumber = string.Empty;
                    infoAccountledger.BranchName = string.Empty;
                    infoAccountledger.BranchCode = string.Empty;
                    infoAccountledger.Extra1 = string.Empty;
                    infoAccountledger.Extra2 = string.Empty;
                    infoAccountledger.AreaId = 0;
                    infoAccountledger.IsDefault = false;
                    infoAccountledger.ExtraDate = PublicVariables._dtCurrentDate;
                    decLedgerId = bllAccountLedger.AccountLedgerAddWithIdentity(infoAccountledger);

                    if (dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value != null && dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value.ToString() != "0")
                    {
                        if (dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value.ToString() != string.Empty)
                        {
                            string strfinancialId;
                            decOpeningBalance = Convert.ToDecimal(dgvMultipleAccountLedger.Rows[i].Cells["dgvtxtOpeningBalance"].Value.ToString());
                            infoFinancialYear = BllFinancialYear.FinancialYearViewForAccountLedger(1);
                            strfinancialId = infoFinancialYear.FromDate.ToString("dd-MMM-yyyy");
                            infoLedgerPosting.VoucherTypeId = 1;
                            infoLedgerPosting.Date = Convert.ToDateTime(strfinancialId.ToString());
                            infoLedgerPosting.LedgerId = decLedgerId;
                            infoLedgerPosting.VoucherNo = decLedgerId.ToString();
                            if (dgvMultipleAccountLedger.Rows[i].Cells["dgvcmbDebitOrCredit"].Value.ToString() == "Dr")
                            {
                                infoLedgerPosting.Debit = decOpeningBalance;
                            }
                            else
                            {
                                infoLedgerPosting.Credit = decOpeningBalance;
                            }
                            infoLedgerPosting.DetailsId = 0;
                            infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                            infoLedgerPosting.InvoiceNo = decLedgerId.ToString();

                            infoLedgerPosting.ChequeNo = string.Empty;
                            infoLedgerPosting.ChequeDate = DateTime.Now;

                            infoLedgerPosting.Extra1 = string.Empty;
                            infoLedgerPosting.Extra2 = string.Empty;
                            BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);

                        }

                    }
                    isSave = true;
                }
                if (isSave)
                {
                    Messages.SavedMessage();
                    cmbAccountGroup.Focus();
                    cmbAccountGroup.SelectedIndex = -1;
                    dgvMultipleAccountLedger.Rows.Clear();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// checking invalid entry,s and user role privilage to save or update
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    dgvMultipleAccountLedger.ClearSelection();
                    if (cmbAccountGroup.SelectedIndex == -1)
                    {
                        Messages.InformationMessage("Select account group");
                        cmbAccountGroup.Focus();
                    }

                    else
                    {
                        if (RemoveIncompleteRowsFromGrid())
                        {
                            //if (dgvMultipleAccountLedger.Rows[0].Cells["dgvtxtLedgerName"].Value == null)
                            //{
                            //    MessageBox.Show("Can't save without  account ledger with complete entry", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //    dgvMultipleAccountLedger.ClearSelection();
                            //    cmbAccountGroup.Focus();
                            //}
                            //else
                            //{
                            if (btnSave.Text == "Save")
                            {
                                if (CheckAlreadyExist())
                                {
                                    if (dgvMultipleAccountLedger.Rows[0].Cells["dgvtxtLedgerName"].Value == null)
                                    {
                                        MessageBox.Show("Can't save without  account ledger with complete entry", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvMultipleAccountLedger.ClearSelection();
                                        cmbAccountGroup.Focus();
                                    }
                                    else
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
                                }
                            }
                            //}
                        }
                        else
                        {
                            if (MessageBox.Show("Ledger details are incomplete for multiple account ledger.Do you want to continue?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //RemoveIncompleteRowsFromGrid();
                                int inRowCount = dgvMultipleAccountLedger.RowCount;
                                if (inRowCount > 1)
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
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to check if same name in any row if row not equal to x
        /// </summary>
        /// <returns></returns>
        public bool ledgerSameOccourance()
        {
            bool isSame = false;
            try
            {
                int index = dgvMultipleAccountLedger.CurrentRow.Index;
                string strName = dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtLedgerName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvMultipleAccountLedger.Rows[inI].Cells["dgvtxtLedgerName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvMultipleAccountLedger.Rows[inI].Cells["dgvtxtLedgerName"].RowIndex;
                    }
                }
                dgvMultipleAccountLedger.Rows[inCurrentIndex].Cells["dgvtxtCheck"].Value = string.Empty;
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isSame;
        }
        /// <summary>
        /// To remove rows from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {


                int inRowCount = dgvMultipleAccountLedger.RowCount;
                int index = dgvMultipleAccountLedger.CurrentRow.Index;
                int inC = 0;
                if (inRowCount >= 2)
                {
                    if (MessageBox.Show("Do you want to remove current row?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtCheck"].Value.ToString() == string.Empty)
                        {
                            string strName = dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtLedgerName"].Value.ToString();
                            int inIndex = dgvMultipleAccountLedger.CurrentRow.Cells["dgvtxtLedgerName"].RowIndex;
                            string strOther;
                            for (int inI = 0; inI < inRowCount - 1; inI++)
                            {
                                inC++;
                                strOther = dgvMultipleAccountLedger.Rows[inI].Cells["dgvtxtLedgerName"].Value.ToString();
                                if (inIndex != dgvMultipleAccountLedger.Rows[inI].Cells["dgvtxtLedgerName"].RowIndex)
                                {
                                    if (ledgerSameOccourance())
                                    {
                                        dgvMultipleAccountLedger.Rows.RemoveAt(index);
                                        return;
                                    }
                                    else
                                    {
                                        if (inC == inRowCount - 1)
                                        {
                                            dgvMultipleAccountLedger.Rows.RemoveAt(index);
                                            inC = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    dgvMultipleAccountLedger.Rows.RemoveAt(index);
                                }
                            }
                        }
                        else
                        {
                            dgvMultipleAccountLedger.Rows.RemoveAt(index);
                        }
                        SlNo();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("MAL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmmultipleAccountLedger_Load(object sender, EventArgs e)
        {
            try
            {
                cmbComboFill();
                this.dgvMultipleAccountLedger.Columns["dgvtxtOpeningBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                cmbAccountGroup.SelectedIndex = -1;
                dgvMultipleAccountLedger.Columns["dgvtxtSlNo"].ReadOnly = true;
                isLoad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvMultipleAccountLedger.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = row.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// on combobox account group text changing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isLoad)
                {
                    int index = cmbAccountGroup.SelectedIndex;
                    string strinr = cmbAccountGroup.Text.ToString();
                    int dec = cmbAccountGroup.SelectedIndex;
                    int inRowcount = dgvMultipleAccountLedger.RowCount;
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    string strNature;
                    strNature = bllAccountGroup.MultipleAccountLedgerCrOrDr(cmbAccountGroup.Text);
                    for (int i = 0; i < inRowcount; i++)
                    {
                        if (strNature == "Assets" || strNature == "Income")
                        {
                            dgvMultipleAccountLedger.Rows[i].Cells["dgvcmbDebitOrCredit"].Value = "Cr";
                        }
                        else if (strNature == "Expenses" || strNature == "Liabilities")
                        {
                            dgvMultipleAccountLedger.Rows[i].Cells["dgvcmbDebitOrCredit"].Value = "Dr";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// button clear click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMultipleAccountLedger.ClearSelection();
                dgvMultipleAccountLedger.Rows.Clear();
                dgvMultipleAccountLedger.Rows[0].Cells["dgvtxtSlNo"].Value = string.Empty;
                cmbAccountGroup.Focus();
                cmbAccountGroup.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MAL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SaveOrEdit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// while entering on grid here checking the inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvtxtOpeningBalance = e.Control as DataGridViewTextBoxEditingControl;

                if (dgvtxtOpeningBalance != null)
                {
                    dgvtxtOpeningBalance.KeyPress += dgvtxtOpeningBalance_KeyPress;
                }
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                    tb.KeyDown -= dgvMultipleAccountLedger_KeyDown;
                    tb.KeyDown += new KeyEventHandler(dgvMultipleAccountLedger_KeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// on grid opening balance textbox keypress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            AccountGroupBll bllAccountGroup = new AccountGroupBll();
            try
            {
                if (dgvMultipleAccountLedger.CurrentCell != null)
                {
                    if (dgvMultipleAccountLedger.Columns[dgvMultipleAccountLedger.CurrentCell.ColumnIndex].Name == "dgvtxtOpeningBalance")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }

                    if (dgvMultipleAccountLedger.Columns[dgvMultipleAccountLedger.CurrentCell.ColumnIndex].Name == "dgvtxtLedgerName")
                    {
                        if (dgvMultipleAccountLedger.Columns["dgvtxtLedgerName"].Index == 1)
                        {
                            string strNature;
                            strNature = bllAccountGroup.MultipleAccountLedgerCrOrDr(cmbAccountGroup.Text);
                            if (strNature == "Assets" || strNature == "Income")
                            {
                                dgvMultipleAccountLedger.Rows[dgvMultipleAccountLedger.CurrentRow.Index].Cells["dgvcmbDebitOrCredit"].Value = "Cr";
                            }
                            else if (strNature == "Expenses" || strNature == "Liabilities")
                            {
                                dgvMultipleAccountLedger.Rows[dgvMultipleAccountLedger.CurrentRow.Index].Cells["dgvcmbDebitOrCredit"].Value = "Dr";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvMultipleAccountLedger.SelectedCells.Count > 0 && dgvMultipleAccountLedger.CurrentRow != null)
                {
                    if (!dgvMultipleAccountLedger.Rows[dgvMultipleAccountLedger.CurrentRow.Index].IsNewRow)
                    {
                        RemoveFunction();
                        SlNo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid value changing time checking invalid entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// in grid rows adding time calling serial no function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SlNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// while entering datas on the gid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleAccountLedger.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvMultipleAccountLedger.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvMultipleAccountLedger.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// in the from keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmmultipleAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S) //Save
                {
                    if (cmbAccountGroup.Focused)
                    {
                        cmbAccountGroup.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbAccountGroup.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// save button keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dgvMultipleAccountLedger.Focus();
                    dgvMultipleAccountLedger.CurrentCell = dgvMultipleAccountLedger.Rows[dgvMultipleAccountLedger.Rows.Count - 1].Cells["dgvtxtNarration"];
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{tab}");
                    dgvMultipleAccountLedger.Columns["dgvtxtCheck"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// combobox accountgroup keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvMultipleAccountLedger.Focus();
                    dgvMultipleAccountLedger.CurrentCell = dgvMultipleAccountLedger.Rows[dgvMultipleAccountLedger.Rows.Count - 1].Cells["dgvtxtSlNo"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// combobox account group leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountGroup_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountGroup.SelectedIndex == -1)
                {
                    cmbAccountGroup.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MAL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
