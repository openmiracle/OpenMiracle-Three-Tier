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
using System.Collections;
using OpenMiracle.BLL;
using ENTITY;

namespace Open_Miracle
{
    public partial class frmCreditNote : Form
    {
        

        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decCreditNoteVoucherTypeId = 0;
        bool isAutomatic = false;
        decimal decCreditNoteSuffixPrefixId = 0;
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strVoucherNo = string.Empty;
        string strInvoiceNo = string.Empty;
        string strTableName = "CreditNoteMaster";
        bool isEditMode = false;
        bool isValueChanged = false;
        decimal decAmount = 0;
        decimal decConvertRate = 0;
        decimal decSelectedCurrencyRate = 0;
        DataTable dtblCreditNote = new DataTable();
        frmCurrencyDetails frmCurrencyObj = null;//to use in call from currency class
        ArrayList arrlstOfRemove = new ArrayList();
        ArrayList arrlstOfRemovedLedgerPostingId = new ArrayList();
        decimal decCreditNoteMasterIdForEdit = 0;
        int inNarrationCount = 0;

        decimal decLedgerIdForPopUp = 0;
        frmCreditNoteReport frmCreditNoteReportObj = null;
        frmCreditNoteRegister CreditNoteRegisterObj = null;//To use in call from JournalRegister 
        frmPartyBalance frmPartyBalanceObj = null;//To use in call from PartyBalance class
        DataTable dtblPartyBalance = new DataTable();//To store PartyBalance entries while clicking btn_Save in CreditNote
        ArrayList arrlstOfDeletedPartyBalanceRow;
        frmBillallocation frmBillallocationObj = null;
        frmVoucherSearch objVoucherSearch = null;
        public string strVocherNo;
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        frmAgeingReport frmAgeingObj = null;//To use in call from frmAgeing
        int inUpdatingRowIndexForPartyRemove = -1;
        decimal decUpdatingLedgerForPartyremove = 0;
        frmLedgerDetails frmLedgerDetailsObj;
        #endregion

        #region Functions

        /// <summary>
        /// Create instance of frmCreditNote
        /// </summary>
        public frmCreditNote()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// It is a function for vouchertypeselection form to select perticular voucher and open the form under the vouchertype
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                decCreditNoteVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decCreditNoteVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                //SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();

                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decCreditNoteVoucherTypeId, dtpVoucherDate.Value);
                decCreditNoteSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strVoucherTypeName;
                base.Show();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Load the form while calling from the voucherSearch in editmode
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallThisFormFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            // Function to call form voucher Search
            try
            {
                this.objVoucherSearch = frm;
                decCreditNoteMasterIdForEdit = decId;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                FillFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void clear()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();

                //-----------------------------------VoucherNo automatic generation-------------------------------------------//

                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0"; //strMax;
                }
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decCreditNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strTableName);

                if (Convert.ToDecimal(strVoucherNo) != BllCreditNoteMaster.CreditNoteMasterGetMaxPlusOne(decCreditNoteVoucherTypeId))
                {
                    strVoucherNo = BllCreditNoteMaster.CreditNoteMasterGetMax(decCreditNoteVoucherTypeId).ToString();
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decCreditNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strTableName);
                    if (BllCreditNoteMaster.CreditNoteMasterGetMax(decCreditNoteVoucherTypeId).ToString() == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decCreditNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strTableName);
                    }
                }

                //===================================================================================================================//
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();

                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decCreditNoteVoucherTypeId, dtpVoucherDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.Text = strInvoiceNo;
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                    txtVoucherNo.Text = string.Empty;
                    strInvoiceNo = txtVoucherNo.Text.Trim();
                }


                dgvCreditNote.Rows.Clear();
                VoucherDate();
                dtpVoucherDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtDebitTotal.Text = string.Empty;
                txtCreditTotal.Text = string.Empty;
                txtNarration.Text = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                isEditMode = false;
                dtblPartyBalance.Clear();//to clear party balance entries to clear the dgvpatybalance
                PrintCheck();
                if (txtVoucherNo.ReadOnly != true)
                {
                    txtVoucherNo.Focus();
                }
                else
                {
                    txtDate.Select();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to check the settings for printaftersave
        /// </summary>
        public void PrintCheck()
        {
            try
            {

                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes")
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to keep the datatable containing party balance details while calling from the partybalance form
        /// </summary>
        /// <param name="frmPartyBalance"></param>
        /// <param name="decAmount"></param>
        /// <param name="dtbl"></param>
        /// <param name="arrlstOfRemovedRow"></param>
        public void CallFromPartyBalance(frmPartyBalance frmPartyBalance, decimal decAmount, DataTable dtbl, ArrayList arrlstOfRemovedRow)
        {
            try
            {
                dgvCreditNote.CurrentRow.Cells["dgvtxtAmount"].Value = decAmount.ToString();
                dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(1);
                dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].ReadOnly = true;
                this.frmPartyBalanceObj = frmPartyBalance;
                frmPartyBalance.Close();
                frmPartyBalanceObj = null;
                dtblPartyBalance = dtbl;
                arrlstOfDeletedPartyBalanceRow = arrlstOfRemovedRow;

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill the currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                List<DataTable> listobj = new List<DataTable>();
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                listobj = TransactionGeneralFillObj.CurrencyComboByDate(Convert.ToDateTime(txtDate.Text));
                DataRow dr = listobj[0].NewRow();
                dr[0] = string.Empty;
                dr[1] = 0;
                listobj[0].Rows.InsertAt(dr, 0);
                dgvcmbCurrency.DataSource = listobj[0];
                dgvcmbCurrency.DisplayMember = "currencyName";
                dgvcmbCurrency.ValueMember = "exchangeRateId";

                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    dgvcmbCurrency.ReadOnly = false;
                }
                else
                {
                    dgvcmbCurrency.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill the accountledger combobox
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                ListObj = bllAccountLedger.AccountLedgerViewAll();
                DataRow dr = ListObj[0].NewRow();
                dr[0] = 0;
                dr[2] = string.Empty;
                ListObj[0].Rows.InsertAt(dr, 0);
                dgvcmbAccountLedger.DataSource = ListObj[0];
                dgvcmbAccountLedger.ValueMember = "ledgerId";
                dgvcmbAccountLedger.DisplayMember = "ledgerName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill the debit/credit combobox in grid
        /// </summary>
        public void DrOrCrComboFill()
        {
            try
            {
                dgvcmbDrOrCr.Items.AddRange("Dr", "Cr");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// To change the currency from currency popup
        /// </summary>
        /// <param name="frmCurrencyDetails"></param>
        /// <param name="decId"></param>
        public void CallFromCurrenCyDetails(frmCurrencyDetails frmCurrencyDetails, decimal decId) //PopUp
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                frmCurrencyObj.Close();
                CurrencyComboFill();
                decId = BllExchangeRate.GetExchangeRateId(decId, Convert.ToDateTime(txtDate.Text));
                dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value = decId;
                dgvCreditNote.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// To select the ledger from ledger popup
        /// </summary>
        /// <param name="decId"></param>
        /// <param name="frmLedgerPopUp"></param>
        public void CallFromLedgerPopup(decimal decId, frmLedgerPopup frmLedgerPopUp) //PopUp
        {
            try
            {
                frmLedgerPopUp.Close();
                dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value = decId;
                dgvCreditNote.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the creditnote register 
        /// </summary>
        /// <param name="frmCreditNoteObj"></param>
        /// <param name="decMasterId"></param>
        public void CallFromCreditNoteRegister(frmCreditNoteRegister frmCreditNoteObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                isEditMode = true;
                btnDelete.Enabled = true;
                CreditNoteRegisterObj = frmCreditNoteObj;
                CreditNoteRegisterObj.Enabled = false;
                decCreditNoteMasterIdForEdit = decMasterId;

                FillFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to generate serial number
        /// </summary>
        public void SlNo()
        {
            try
            {
                int inRowNo = 1;
                foreach (DataGridViewRow dr in dgvCreditNote.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvCreditNote.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /// <summary>
        /// Function to calculate total debit and credit
        /// </summary>
        public void DebitAndCreditTotal()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            int inRowCount = dgvCreditNote.RowCount;
            decimal decTxtTotalDebit = 0;
            decimal decTxtTotalCredit = 0;
            try
            {
                for (int inI = 0; inI < inRowCount; inI++)
                {
                    if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() != string.Empty)
                    {
                        if (dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            if (dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString() != string.Empty)
                            {
                                if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() == "Dr")
                                {
                                    //--------Currency conversion--------------//
                                    decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString()));
                                    decAmount = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                    decConvertRate = decAmount * decSelectedCurrencyRate;
                                    //===========================================//
                                    decTxtTotalDebit = decTxtTotalDebit + decConvertRate;

                                }
                                else
                                {
                                    //--------Currency conversion--------------//
                                    decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString()));
                                    decAmount = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                    decConvertRate = decAmount * decSelectedCurrencyRate;
                                    //===========================================//
                                    decTxtTotalCredit = decTxtTotalCredit + decConvertRate;
                                }
                            }
                        }
                    }
                    txtDebitTotal.Text = Math.Round(decTxtTotalDebit, PublicVariables._inNoOfDecimalPlaces).ToString();
                    txtCreditTotal.Text = Math.Round(decTxtTotalCredit, PublicVariables._inNoOfDecimalPlaces).ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to call the SaveOrEditFunction by checking the negative balance
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    //===================================
                    SettingsBll BllSettings = new SettingsBll();
                    string strStatus = BllSettings.SettingsStatusCheck("NegativeCashTransaction");
                    decimal decBalance = 0;
                    decimal decCalcAmount = 0;
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    bool isNegativeLedger = false;
                    int inRowCount = dgvCreditNote.RowCount;
                    for (int i = 0; i < inRowCount - 1; i++)
                    {
                        decimal decledgerId = 0;
                        if (dgvCreditNote.Rows[i].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[i].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                        {
                            decledgerId = Convert.ToDecimal(dgvCreditNote.Rows[i].Cells["dgvcmbAccountLedger"].Value.ToString());
                        }
                        decBalance = bllAccountLedger.CheckLedgerBalance(decledgerId);
                        if (dgvCreditNote.Rows[i].Cells["dgvtxtAmount"].Value != null && dgvCreditNote.Rows[i].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            decCalcAmount = decBalance - Convert.ToDecimal(dgvCreditNote.Rows[i].Cells["dgvtxtAmount"].Value.ToString());
                        }
                        if (decCalcAmount < 0)
                        {
                            isNegativeLedger = true;
                            break;
                        }
                    }
                    //===================================
                    if (isNegativeLedger)
                    {
                        if (strStatus == "Warn")
                        {
                            if (MessageBox.Show("Negative balance exists,Do you want to Continue", "Open miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                SaveOrEditFunction();
                            }
                        }
                        else if (strStatus == "Block")
                        {
                            MessageBox.Show("Cannot continue ,due to negative balance", "Open miracle", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            SaveOrEditFunction();
                        }
                    }
                    else
                    {
                        SaveOrEditFunction();
                    }

                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to determine whether to call savefunction or edit function
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
               
                    if (!isEditMode)
                    {
                        if (txtVoucherNo.Text.Trim() != string.Empty)
                        {

                            if (!isAutomatic)
                            {
                                strInvoiceNo = txtVoucherNo.Text.Trim();
                                if (BllCreditNoteMaster.CreditNoteCheckExistence(strInvoiceNo, decCreditNoteVoucherTypeId, 0) == false)
                                {
                                    SaveFunction();
                                }
                                else
                                {
                                    Messages.InformationMessage("Voucher number already exist");
                                }
                            }
                            else
                            {
                                SaveFunction();
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Enter voucherNo");
                            txtVoucherNo.Focus();
                        }
                    }
                    else
                    {
                        if (txtVoucherNo.Text.Trim() != string.Empty)
                        {
                            if (!isAutomatic)
                            {
                                strInvoiceNo = txtVoucherNo.Text.Trim();

                                if (BllCreditNoteMaster.CreditNoteCheckExistence(strInvoiceNo, decCreditNoteVoucherTypeId, decCreditNoteMasterIdForEdit) == false)
                                {
                                    EditFunction(decCreditNoteMasterIdForEdit);
                                }
                                else
                                {
                                    Messages.InformationMessage("Voucher number already exist");
                                }
                            }
                            else
                            {
                                EditFunction(decCreditNoteMasterIdForEdit);
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Enter voucherNo");
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call the Save by checking invalid entries
        /// </summary>
        public void SaveFunction()
        {

            ArrayList arrlstOfRowToRemove = new ArrayList();

            int inReadyForSave = 0;
            int inIsRowToRemove = 0;
            int inIfGridColumnMissing = 0;

            try
            {
                if (txtVoucherNo.Text.Trim() != string.Empty)
                {
                    if (!isEditMode)
                    {
                        decimal decTotalDebit = 0;
                        decimal decTotalCredit = 0;

                        int inRowCount = dgvCreditNote.RowCount;
                        for (int inI = 0; inI < inRowCount - 1; inI++)
                        {
                            if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString().Trim() == string.Empty)
                            {
                                arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                                inIfGridColumnMissing = 1;
                                continue;
                            }
                            else if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString().Trim() == string.Empty)
                            {
                                arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                                inIfGridColumnMissing = 1;
                                continue;
                            }

                            else if (dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                            {
                                arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                                inIfGridColumnMissing = 1;
                                continue;
                            }
                            else if (dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].FormattedValue.ToString().Trim() == string.Empty)
                            {
                                arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                                inIfGridColumnMissing = 1;
                                continue;
                            }
                            
                        }

                        //----------------------------------------------------------------------//
                        if (inIfGridColumnMissing == 0)
                        {
                            inReadyForSave = 1;
                            inIsRowToRemove = 0;

                        }
                        else
                        {
                            string strMsg = string.Empty;
                            int inK = 0;
                            foreach (object obj in arrlstOfRowToRemove)
                            {
                                if (inK != 0)
                                {
                                    strMsg = strMsg + ", ";
                                }
                                string str = Convert.ToString(obj);
                                strMsg = strMsg + str;
                                inK++;
                            }
                            if (MessageBox.Show("Row " + strMsg + " Contains invalid entries.\n Do you want to continue ? ", "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                inReadyForSave = 1;
                                inIsRowToRemove = 1;
                            }
                            else
                                return;
                        }
                        //=====================================================================//

                        //-------------------------------------------------------------------//
                        if (inReadyForSave == 1)
                        {

                            int inTableRowCount = dtblPartyBalance.Rows.Count;
                            //-----------------If there are rows to remove---------------//
                            if (inIsRowToRemove == 1)
                            {
                                int inDgvJournalRowCount = dgvCreditNote.RowCount;
                                int inK = 0;
                                for (int inI = 0; inI < inDgvJournalRowCount; inI++)
                                {
                                    if (inK == arrlstOfRowToRemove.Count)
                                    {
                                        break;
                                    }
                                    if (inDgvJournalRowCount > 0)
                                    {

                                        if (Convert.ToInt32(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString()) == Convert.ToInt32(arrlstOfRowToRemove[inK]))
                                        {
                                            inK++;
                                            if (dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                                            {
                                                arrlstOfRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString());
                                                arrlstOfRemovedLedgerPostingId.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtLedgerPostingId"].Value.ToString());
                                            }

                                            inTableRowCount = dtblPartyBalance.Rows.Count;
                                            for (int inJ = 0; inJ < inTableRowCount; inJ++)
                                            {
                                                if (dtblPartyBalance.Rows.Count == inJ)
                                                {
                                                    break;
                                                }
                                                if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                                                {
                                                    if (Convert.ToInt32(dtblPartyBalance.Rows[inJ]["LedgerId"].ToString()) == Convert.ToInt32(dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString()))
                                                    {
                                                        if (dtblPartyBalance.Rows[inI]["PartyBalanceId"].ToString() != "0")
                                                        {
                                                            arrlstOfDeletedPartyBalanceRow.Add(dtblPartyBalance.Rows[inI]["PartyBalanceId"]);
                                                        }
                                                        dtblPartyBalance.Rows.RemoveAt(inJ);
                                                        inJ--;
                                                    }
                                                }
                                            }
                                            if (inUpdatingRowIndexForPartyRemove == inI)
                                            {
                                                inUpdatingRowIndexForPartyRemove = -1;
                                                decUpdatingLedgerForPartyremove = 0;
                                            }
                                            dgvCreditNote.Rows.Remove(dgvCreditNote.Rows[inI]);
                                            inDgvJournalRowCount = dgvCreditNote.RowCount;
                                            inI--;

                                        }
                                    }
                                }
                                SlNo();

                            }
                            //============================================================//
                            int RowCount = dgvCreditNote.RowCount;
                            if (RowCount > 1)
                            {
                                decTotalDebit = Convert.ToDecimal(txtDebitTotal.Text.Trim());
                                decTotalCredit = Convert.ToDecimal(txtCreditTotal.Text.Trim());
                                if (decTotalCredit != 0 || decTotalDebit != 0)
                                {
                                    if (decTotalDebit == decTotalCredit)
                                    {
                                        if (PublicVariables.isMessageAdd)
                                        {
                                            if (Messages.SaveMessage())
                                            {
                                                Save();
                                                clear();
                                            }
                                            else
                                            {
                                                dgvCreditNote.Focus();
                                            }
                                        }
                                        else
                                        {

                                            Save();
                                            clear();

                                        }
                                    }

                                    else
                                    {
                                        Messages.InformationMessage("Total debit and total credit should be equal");
                                        dgvCreditNote.Focus();
                                    }
                                }
                                else
                                {
                                    Messages.InformationMessage("Cannot save total debit and credit as 0");

                                }
                            }
                            else
                            {
                                Messages.InformationMessage("Can't save credit not without atleast one row with complete details");
                            }
                            

                        }
                        

                    }

                }
                else
                {
                    Messages.InformationMessage("Enter voucherno.");
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to call the Edit by checking invalid entries
        /// </summary>
        /// <param name="decCreditNoteMasterId"></param>
        public void EditFunction(decimal decCreditNoteMasterId)
        {
            try
            {
                ArrayList arrlstOfRowToRemove = new ArrayList();
                int inReadyForSave = 0;
                int inIsRowToRemove = 0;
                int inIfGridColumnMissing = 0;

                decimal decTotalDebit = 0;
                decimal decTotalCredit = 0;



                int inRowCount = dgvCreditNote.RowCount;
                for (int inI = 0; inI < inRowCount - 1; inI++)
                {
                    if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString().Trim() == string.Empty)
                    {
                        arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        inIfGridColumnMissing = 1;
                        continue;
                    }
                    else if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString().Trim() == string.Empty)
                    {
                        arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        inIfGridColumnMissing = 1;
                        continue;
                    }

                    else if (dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                    {
                        arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        inIfGridColumnMissing = 1;
                        continue;
                    }
                    else if (dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value == null || dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].FormattedValue.ToString().Trim() == string.Empty)
                    {
                        arrlstOfRowToRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        inIfGridColumnMissing = 1;
                        continue;
                    }

                }
                //----------------------------------------------------------------------//
                if (inIfGridColumnMissing == 0)
                {
                    inReadyForSave = 1;
                    inIsRowToRemove = 0;

                }
                else
                {
                    string strMsg = string.Empty;
                    int inK = 0;
                    foreach (object obj in arrlstOfRowToRemove)
                    {
                        if (inK != 0)
                        {
                            strMsg = strMsg + ", ";
                        }
                        string str = Convert.ToString(obj);
                        strMsg = strMsg + str;
                        inK++;
                    }
                    if (MessageBox.Show("Row " + strMsg + " Contains invalid entries.\n Do you want to continue ? ", "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        inReadyForSave = 1;
                        inIsRowToRemove = 1;
                    }
                    else
                        inReadyForSave = 0;
                }
                //=====================================================================//

                if (inReadyForSave == 1)
                {
                    int inTableRowCount = dtblPartyBalance.Rows.Count;
                    //-----------------If there are rows to remove---------------//
                    if (inIsRowToRemove == 1)
                    {
                        int inDgvJournalRowCount = dgvCreditNote.RowCount;
                        int inK = 0;
                        for (int inI = 0; inI < inDgvJournalRowCount; inI++)
                        {
                            if (inK == arrlstOfRowToRemove.Count)
                            {
                                break;
                            }
                            if (inDgvJournalRowCount > 0)
                            {

                                if (Convert.ToInt32(dgvCreditNote.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString()) == Convert.ToInt32(arrlstOfRowToRemove[inK]))
                                {
                                    inK++;
                                    if (dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                                    {
                                        arrlstOfRemove.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString());
                                        arrlstOfRemovedLedgerPostingId.Add(dgvCreditNote.Rows[inI].Cells["dgvtxtLedgerPostingId"].Value.ToString());
                                    }

                                    inTableRowCount = dtblPartyBalance.Rows.Count;
                                    for (int inJ = 0; inJ < inTableRowCount; inJ++)
                                    {
                                        if (dtblPartyBalance.Rows.Count == inJ)
                                        {
                                            break;
                                        }
                                        if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                                        {
                                            if (dtblPartyBalance.Rows[inJ]["LedgerId"].ToString() == dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString())
                                            {
                                                if (dtblPartyBalance.Rows[inI]["PartyBalanceId"].ToString() != "0")
                                                {
                                                    arrlstOfDeletedPartyBalanceRow.Add(dtblPartyBalance.Rows[inI]["PartyBalanceId"]);
                                                }
                                                dtblPartyBalance.Rows.RemoveAt(inJ);
                                                inJ--;
                                            }
                                        }
                                    }
                                    if (inUpdatingRowIndexForPartyRemove == inI)
                                    {
                                        inUpdatingRowIndexForPartyRemove = -1;
                                        decUpdatingLedgerForPartyremove = 0;
                                    }
                                    dgvCreditNote.Rows.RemoveAt(dgvCreditNote.Rows[inI].Index);
                                    inDgvJournalRowCount = dgvCreditNote.RowCount;
                                    inI--;
                                }
                            }
                        }
                        SlNo();
                    }
                    //============================================================//
                    inRowCount = dgvCreditNote.RowCount;
                    if (inRowCount > 1)
                    {
                        decTotalDebit = Convert.ToDecimal(txtDebitTotal.Text.Trim());
                        decTotalCredit = Convert.ToDecimal(txtCreditTotal.Text.Trim());
                        if (decTotalDebit == decTotalCredit)
                        {
                            if (PublicVariables.isMessageEdit)
                            {
                                if (Messages.UpdateMessage())
                                {
                                    DeletePartyBalanceOfRemovedRow();
                                    Edit(decCreditNoteMasterIdForEdit);
                                }
                                else
                                {
                                    dgvCreditNote.Focus();
                                }
                            }
                            else
                            {
                                DeletePartyBalanceOfRemovedRow();
                                Edit(decCreditNoteMasterIdForEdit);
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Total debit and total credit should be equal");
                            dgvCreditNote.Focus();
                            return;
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Can't save credit not without atleast one row with complete details");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function for ledger posting
        /// </summary>
        /// <param name="decId"></param>
        /// <param name="decCredit"></param>
        /// <param name="decDebit"></param>
        /// <param name="decDetailsId"></param>
        /// <param name="inA"></param>
        public void LedgerPosting(decimal decId, decimal decCredit, decimal decDebit, decimal decDetailsId, int inA)
        {
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            decimal decOldExchange = 0;
            decimal decNewExchangeRate = 0;
            decimal decNewExchangeRateId = 0;
            decimal decOldExchangeId = 0;
            try
            {


                if (!dgvCreditNote.Rows[inA].Cells["dgvtxtAmount"].ReadOnly)
                {
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.VoucherTypeId = decCreditNoteVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.DetailsId = decDetailsId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();

                    if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        infoLedgerPosting.ChequeNo = dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            infoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            infoLedgerPosting.ChequeDate = DateTime.Now;

                    }
                    else
                    {
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                    }

                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;

                    infoLedgerPosting.LedgerId = decId;
                    infoLedgerPosting.Credit = decCredit;
                    infoLedgerPosting.Debit = decDebit;

                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
                else
                {
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.VoucherTypeId = decCreditNoteVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.DetailsId = decDetailsId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();

                    if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        infoLedgerPosting.ChequeNo = dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            infoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            infoLedgerPosting.ChequeDate = DateTime.Now;

                    }
                    else
                    {
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                    }


                    infoLedgerPosting.ExtraDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.LedgerId = decId;

                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (infoLedgerPosting.LedgerId == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            decOldExchange = Convert.ToDecimal(dr["OldExchangeRate"].ToString());
                            decNewExchangeRateId = Convert.ToDecimal(dr["CurrencyId"].ToString());
                            decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(decOldExchange);
                            decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                            decConvertRate = decConvertRate + (decAmount * decSelectedCurrencyRate);

                        }
                    }

                    if (decCredit == 0)
                    {
                        infoLedgerPosting.Credit = 0;
                        infoLedgerPosting.Debit = decConvertRate;
                    }
                    else
                    {
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decConvertRate;
                    }


                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);

                    infoLedgerPosting.LedgerId = 12;
                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (Convert.ToDecimal(dgvCreditNote.Rows[inA].Cells["dgvcmbAccountLedger"].Value.ToString()) == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            if (dr["ReferenceType"].ToString() == "Against")
                            {
                                decNewExchangeRateId = Convert.ToDecimal(dr["CurrencyId"].ToString());
                                decNewExchangeRate = BllExchangeRate.GetExchangeRateByExchangeRateId(decNewExchangeRateId);
                                decOldExchangeId = Convert.ToDecimal(dr["OldExchangeRate"].ToString());
                                decOldExchange = BllExchangeRate.GetExchangeRateByExchangeRateId(decOldExchangeId);
                                decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                                decimal decForexAmount = (decAmount * decNewExchangeRate) - (decAmount * decOldExchange);
                                if (dr["DebitOrCredit"].ToString() == "Dr")
                                {
                                    if (decForexAmount >= 0)
                                    {

                                        infoLedgerPosting.Debit = decForexAmount;
                                        infoLedgerPosting.Credit = 0;
                                    }
                                    else
                                    {
                                        infoLedgerPosting.Credit = -1 * decForexAmount;
                                        infoLedgerPosting.Debit = 0;
                                    }
                                }
                                else
                                {
                                    if (decForexAmount >= 0)
                                    {

                                        infoLedgerPosting.Credit = decForexAmount;
                                        infoLedgerPosting.Debit = 0;
                                    }
                                    else
                                    {
                                        infoLedgerPosting.Debit = -1 * decForexAmount;
                                        infoLedgerPosting.Credit = 0;
                                    }
                                }
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function for ledgerposting edit
        /// </summary>
        /// <param name="decLedgerPostingId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decCredit"></param>
        /// <param name="decDebit"></param>
        /// <param name="decDetailsId"></param>
        /// <param name="inA"></param>
        public void LedgerPostingEdit(decimal decLedgerPostingId, decimal decLedgerId, decimal decCredit, decimal decDebit, decimal decDetailsId, int inA)
        {
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            decimal decOldExchange = 0;
            decimal decNewExchangeRate = 0;
            decimal decNewExchangeRateId = 0; 
            decimal decOldExchangeId = 0;
            try
            {


                if (!dgvCreditNote.Rows[inA].Cells["dgvtxtAmount"].ReadOnly)
                {
                    infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.VoucherTypeId = decCreditNoteVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.DetailsId = decDetailsId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();

                    if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        infoLedgerPosting.ChequeNo = dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            infoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            infoLedgerPosting.ChequeDate = DateTime.Now;

                    }
                    else
                    {
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                    }

                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;

                    infoLedgerPosting.LedgerId = decLedgerId;
                    infoLedgerPosting.Credit = decCredit;
                    infoLedgerPosting.Debit = decDebit;

                    BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);
                }
                else
                {
                    infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.VoucherTypeId = decCreditNoteVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.DetailsId = decDetailsId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();

                    if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        infoLedgerPosting.ChequeNo = dgvCreditNote.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            infoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            infoLedgerPosting.ChequeDate = DateTime.Now;

                    }
                    else
                    {
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                    }


                    infoLedgerPosting.ExtraDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.LedgerId = decLedgerId;

                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (infoLedgerPosting.LedgerId == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            decOldExchange = Convert.ToDecimal(dr["OldExchangeRate"].ToString());
                            decNewExchangeRateId = Convert.ToDecimal(dr["CurrencyId"].ToString());
                            decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(decOldExchange);
                            decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                            decConvertRate = decConvertRate + (decAmount * decSelectedCurrencyRate);

                        }
                    }

                    if (decCredit == 0)
                    {
                        infoLedgerPosting.Credit = 0;
                        infoLedgerPosting.Debit = decConvertRate;
                    }
                    else
                    {
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decConvertRate;
                    }


                    BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);

                    infoLedgerPosting.LedgerId = 12;
                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (Convert.ToDecimal(dgvCreditNote.Rows[inA].Cells["dgvcmbAccountLedger"].Value.ToString()) == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            if (dr["ReferenceType"].ToString() == "Against")
                            {
                                decNewExchangeRateId = Convert.ToDecimal(dr["CurrencyId"].ToString());
                                decNewExchangeRate = BllExchangeRate.GetExchangeRateByExchangeRateId(decNewExchangeRateId);
                                decOldExchangeId = Convert.ToDecimal(dr["OldExchangeRate"].ToString());
                                decOldExchange = BllExchangeRate.GetExchangeRateByExchangeRateId(decOldExchangeId);
                                decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                                decimal decForexAmount = (decAmount * decNewExchangeRate) - (decAmount * decOldExchange);
                                if (dr["DebitOrCredit"].ToString() == "Dr")
                                {
                                    if (decForexAmount >= 0)
                                    {

                                        infoLedgerPosting.Debit = decForexAmount;
                                        infoLedgerPosting.Credit = 0;
                                    }
                                    else
                                    {
                                        infoLedgerPosting.Credit = -1 * decForexAmount;
                                        infoLedgerPosting.Debit = 0;
                                    }
                                }
                                else
                                {
                                    if (decForexAmount >= 0)
                                    {

                                        infoLedgerPosting.Credit = decForexAmount;
                                        infoLedgerPosting.Debit = 0;
                                    }
                                    else
                                    {
                                        infoLedgerPosting.Debit = -1 * decForexAmount;
                                        infoLedgerPosting.Credit = 0;
                                    }
                                }
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }

                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to save party balance details
        /// </summary>
        /// <param name="inRowIndex"></param>
        /// <param name="inJ"></param>
        public void PartyBalanceAdd(int inRowIndex, int inJ)
        {
            int inTableRowCount = dtblPartyBalance.Rows.Count;
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            PartyBalanceInfo InfopartyBalance = new PartyBalanceInfo();
            try
            {
                InfopartyBalance.CreditPeriod = 0;//
                InfopartyBalance.Date = dtpVoucherDate.Value;
                InfopartyBalance.LedgerId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["LedgerId"].ToString());
                InfopartyBalance.ReferenceType = dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString();
                if (dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString() == "New" || dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString() == "OnAccount")
                {
                    InfopartyBalance.AgainstInvoiceNo = "0";// dtblPartyBalance.Rows[inJ]["AgainstInvoiceNo"].ToString();
                    InfopartyBalance.AgainstVoucherNo = "0";// dtblPartyBalance.Rows[inJ]["AgainstVoucherNo"].ToString();
                    InfopartyBalance.AgainstVoucherTypeId = 0;// Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["AgainstVoucherTypeId"].ToString());//decPaymentVoucherTypeId;
                    InfopartyBalance.VoucherTypeId = decCreditNoteVoucherTypeId;
                    InfopartyBalance.InvoiceNo = strInvoiceNo;
                    InfopartyBalance.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfopartyBalance.ExchangeRateId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["OldExchangeRate"].ToString());
                    InfopartyBalance.AgainstInvoiceNo = strInvoiceNo;
                    InfopartyBalance.AgainstVoucherNo = strVoucherNo;
                    InfopartyBalance.AgainstVoucherTypeId = decCreditNoteVoucherTypeId;
                    InfopartyBalance.VoucherTypeId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["AgainstVoucherTypeId"].ToString());
                    InfopartyBalance.VoucherNo = dtblPartyBalance.Rows[inJ]["AgainstVoucherNo"].ToString();
                    InfopartyBalance.InvoiceNo = dtblPartyBalance.Rows[inJ]["AgainstInvoiceNo"].ToString();
                }
                if (dgvCreditNote.Rows[inRowIndex].Cells["dgvcmbDrOrCr"].Value.ToString() == "Dr")
                {
                    InfopartyBalance.Debit = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["Amount"].ToString());
                    InfopartyBalance.Credit = 0;
                }
                else
                {
                    InfopartyBalance.Credit = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["Amount"].ToString());
                    InfopartyBalance.Debit = 0;
                }
                InfopartyBalance.ExchangeRateId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["CurrencyId"].ToString());
                InfopartyBalance.Extra1 = string.Empty;
                InfopartyBalance.Extra2 = string.Empty;
                InfopartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                BllPartyBalance.PartyBalanceAdd(InfopartyBalance);


            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to print the voucher
        /// </summary>
        /// <param name="decMasterId"></param>
        public void Print(decimal decMasterId)
        {
            try
            {
                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
                DataSet dsCreditNote = BllCreditNoteMaster.CreditNotePrinting(decMasterId, 1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.CreditNotePrinting(dsCreditNote);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to print the voucher in dotmatrix printer
        /// </summary>
        /// <param name="decMasterId"></param>
        public void PrintForDotMatrix(decimal decMasterId)
        {
            try
            {

                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreation.CompanyViewForDotMatrix();
                //-------------Grid Details-------------------\\
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("Account Ledger");
                dtblGridDetails.Columns.Add("CrOrDr");
                dtblGridDetails.Columns.Add("Amount");
                dtblGridDetails.Columns.Add("Currency");
                dtblGridDetails.Columns.Add("Cheque No");
                dtblGridDetails.Columns.Add("Cheque Date");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvCreditNote.Rows)
                {
                    if (dRow.HeaderCell.Value != null && dRow.HeaderCell.Value.ToString() != "X")
                    {
                        if (!dRow.IsNewRow)
                        {
                            DataRow dr = dtblGridDetails.NewRow();
                            dr["SlNo"] = ++inRowCount;
                            dr["Account Ledger"] = dRow.Cells["dgvcmbAccountLedger"].FormattedValue as string;
                            dr["CrOrDr"] = dRow.Cells["dgvcmbDrOrCr"].Value as string;
                            dr["Amount"] = dRow.Cells["dgvtxtAmount"].Value as string;
                            dr["Currency"] = dRow.Cells["dgvcmbCurrency"].FormattedValue as string;
                            dr["Cheque No"] = (dRow.Cells["dgvtxtChequeNo"].Value == null ? "" : dRow.Cells["dgvtxtChequeNo"].Value as string);
                            dr["Cheque Date"] = (dRow.Cells["dgvtxtChequeDate"].Value == null ? "" : dRow.Cells["dgvtxtChequeDate"].Value as string);
                            dtblGridDetails.Rows.Add(dr);
                        }
                    }
                }


                //-------------Other Details-------------------\\

                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("DebitTotal");
                dtblOtherDetails.Columns.Add("CreditTotal");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("DebitAmountInWords");
                dtblOtherDetails.Columns.Add("CreditAmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtVoucherNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["DebitTotal"] = txtDebitTotal.Text;
                dRowOther["CreditTotal"] = txtCreditTotal.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["DebitAmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtDebitTotal.Text), PublicVariables._decCurrencyId);
                dRowOther["CreditAmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtCreditTotal.Text), PublicVariables._decCurrencyId);
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decCreditNoteVoucherTypeId);
                dRowOther["Declaration"] = dtblDeclaration.Rows[0]["Declaration"].ToString();
                dRowOther["Heading1"] = dtblDeclaration.Rows[0]["Heading1"].ToString();
                dRowOther["Heading2"] = dtblDeclaration.Rows[0]["Heading2"].ToString();
                dRowOther["Heading3"] = dtblDeclaration.Rows[0]["Heading3"].ToString();
                dRowOther["Heading4"] = dtblDeclaration.Rows[0]["Heading4"].ToString();
                int inFormId = BllVoucherType.FormIdGetForPrinterSettings(Convert.ToInt32(dtblDeclaration.Rows[0]["masterId"].ToString()));
                PrintWorks.DotMatrixPrint.PrintDesign(inFormId, dtblOtherDetails, dtblGridDetails, dtblOtherDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to check invalid entries
        /// </summary>
        /// <param name="e"></param>
        public void CheckColumnMissing(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCreditNote.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value == null || dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvCreditNote.CurrentRow.HeaderCell.Value = "X";
                            dgvCreditNote.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvCreditNote.CurrentRow.Cells["dgvcmbDrOrCr"].Value == null || dgvCreditNote.CurrentRow.Cells["dgvcmbDrOrCr"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvCreditNote.CurrentRow.HeaderCell.Value = "X";
                            dgvCreditNote.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvCreditNote.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvCreditNote.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvCreditNote.CurrentRow.HeaderCell.Value = "X";
                            dgvCreditNote.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;

                        }
                        else if (dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value == null || dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].FormattedValue.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvCreditNote.CurrentRow.HeaderCell.Value = "X";
                            dgvCreditNote.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;

                        }

                        else
                        {
                            isValueChanged = true;
                            dgvCreditNote.CurrentRow.HeaderCell.Value = string.Empty;
                        }

                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to delete a voucher
        /// </summary>
        /// <param name="decCreditNoteMasterId"></param>
        public void DeleteFunction(decimal decCreditNoteMasterId)
        {
            try
            {
                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                if (!BllPartyBalance.PartyBalanceCheckReference(decCreditNoteVoucherTypeId, strVoucherNo))
                {
                    BllCreditNoteMaster.CreditNoteVoucherDelete(decCreditNoteMasterId, decCreditNoteVoucherTypeId, strVoucherNo);
                    Messages.DeletedMessage();
                    if (CreditNoteRegisterObj != null)
                    {
                        this.Close();
                        CreditNoteRegisterObj.Enabled = true;
                    }
                    else if (frmCreditNoteReportObj != null)
                    {
                        this.Close();
                        frmCreditNoteReportObj.Enabled = true;
                    }
                    else  if (objVoucherSearch != null)
                    {
                        this.Close();
                        objVoucherSearch.GridFill();
                    }
                    else if (frmDayBookObj != null)
                    {
                        this.Close();
                    }
                    else if (frmBillallocationObj != null)
                    {
                        this.Close();
                    }
                    else if (frmLedgerDetailsObj != null)
                    {
                        this.Close();
                    }
                    else
                    {
                        clear();
                    }
                }
                else
                {
                    Messages.InformationMessage("Reference exist. Cannot delete");
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function for decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keypressevent(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to add the new accountledger from accountLedger form
        /// </summary>
        /// <param name="decLedgerId"></param>
        public void CallFromAccountLedger(decimal decLedgerId)
        {
            try
            {
                if (decLedgerId != 0)
                {
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = bllAccountLedger.AccountLedgerViewAll();
                    DataGridViewComboBoxCell dgvccAccountLedger = (DataGridViewComboBoxCell)dgvCreditNote[dgvCreditNote.Columns["dgvcmbAccountLedger"].Index, dgvCreditNote.CurrentRow.Index];
                    dgvccAccountLedger.DataSource = ListObj;
                    dgvccAccountLedger.ValueMember = "ledgerId";
                    dgvccAccountLedger.DisplayMember = "ledgerName";
                    dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value = decLedgerId;
                }
                this.Enabled = true;
                dgvCreditNote.Focus();
                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to set the voucher date
        /// </summary>
        public void VoucherDate()
        {
            try
            {
                dtpVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpVoucherDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtVoucherDate = infoComapany.CurrentDate;
                dtpVoucherDate.Value = dtVoucherDate;
                txtDate.Text = dtVoucherDate.ToString("dd-MMM-yyyy");
                dtpVoucherDate.Value = Convert.ToDateTime(txtDate.Text);
                txtDate.Focus();
                txtDate.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:27" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the creditnote report
        /// </summary>
        /// <param name="frmCreditNoteReport"></param>
        /// <param name="decCreditNoteMasterId"></param>
        public void CallFromCreditNoteReport(frmCreditNoteReport frmCreditNoteReport, decimal decCreditNoteMasterId)
        {
            try
            {
                base.Show();

                isEditMode = true;
                btnDelete.Enabled = true;
                frmCreditNoteReportObj = frmCreditNoteReport;
                frmCreditNoteReportObj.Enabled = false;
                decCreditNoteMasterIdForEdit = decCreditNoteMasterId;
                FillFunction();


            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to remove a row
        /// </summary>
        public void RemoveRow()
        {
            try
            {
                int inRowCount = dgvCreditNote.RowCount;
                if (inRowCount > 1)
                {
                    if (int.Parse(dgvCreditNote.CurrentRow.Cells["dgvtxtSlNo"].Value.ToString()) < inRowCount)
                    {
                        if (dgvCreditNote.CurrentRow.Cells["dgvtxtDetailsId"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                        {
                            arrlstOfRemove.Add(dgvCreditNote.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString());
                            arrlstOfRemovedLedgerPostingId.Add(dgvCreditNote.CurrentRow.Cells["dgvtxtLedgerPostingId"].Value.ToString());
                        }


                        int inTableRowCount = dtblPartyBalance.Rows.Count;
                        for (int inI = 0; inI < inTableRowCount; inI++)
                        {
                            if (dtblPartyBalance.Rows.Count == inI)
                            {
                                break;
                            }
                            if (dtblPartyBalance.Rows[inI]["LedgerId"].ToString() == dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString())
                            {
                                if (dtblPartyBalance.Rows[inI]["PartyBalanceId"].ToString() != "0")
                                {
                                    arrlstOfDeletedPartyBalanceRow.Add(dtblPartyBalance.Rows[inI]["PartyBalanceId"]);
                                }
                                dtblPartyBalance.Rows.RemoveAt(inI);
                                inI--;
                            }
                        }
                        if (inUpdatingRowIndexForPartyRemove == dgvCreditNote.CurrentRow.Index)
                        {
                            inUpdatingRowIndexForPartyRemove = -1;
                            decUpdatingLedgerForPartyremove = 0;
                        }
                        dgvCreditNote.Rows.RemoveAt(dgvCreditNote.CurrentRow.Index);
                        SlNo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to to enable keypress in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keypresseventEnable(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to save the voucher
        /// </summary>
        public void Save()
        {
            try
            {
                decimal decTotalDebit = 0;
                decimal decTotalCredit = 0;

                decTotalDebit = Convert.ToDecimal(txtDebitTotal.Text.Trim());
                decTotalCredit = Convert.ToDecimal(txtCreditTotal.Text.Trim());

                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
                CreditNoteBll BllCreditNoteDetails = new CreditNoteBll();
                CreditNoteMasterInfo infoCreditNoteMaster = new CreditNoteMasterInfo();
                CreditNoteDetailsInfo infoCreditNoteDetails = new CreditNoteDetailsInfo();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfopartyBalance = new PartyBalanceInfo();
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();

                infoCreditNoteMaster.VoucherNo = strVoucherNo;
                infoCreditNoteMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                infoCreditNoteMaster.SuffixPrefixId = decCreditNoteSuffixPrefixId;
                infoCreditNoteMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoCreditNoteMaster.Narration = txtNarration.Text.Trim();
                infoCreditNoteMaster.UserId = PublicVariables._decCurrentUserId;
                infoCreditNoteMaster.VoucherTypeId = decCreditNoteVoucherTypeId;
                infoCreditNoteMaster.FinancialYearId = Convert.ToDecimal(PublicVariables._decCurrentFinancialYearId.ToString());
                infoCreditNoteMaster.Extra1 = string.Empty;
                infoCreditNoteMaster.Extra2 = string.Empty;


                infoCreditNoteMaster.TotalAmount = decTotalDebit;
                decimal decCreditNoteMasterId = BllCreditNoteMaster.CreditNoteMasterAdd(infoCreditNoteMaster);

                /*******************CreditNote Details Add and LedgerPosting*************************/
                infoCreditNoteDetails.CreditNoteMasterId = decCreditNoteMasterId;
                infoCreditNoteDetails.ExtraDate = DateTime.Now;
                infoCreditNoteDetails.Extra1 = string.Empty;
                infoCreditNoteDetails.Extra2 = string.Empty;

                decimal decLedgerId = 0;
                decimal decDebit = 0;
                decimal decCredit = 0;
                int inRowCount = dgvCreditNote.RowCount;
                for (int inI = 0; inI < inRowCount - 1; inI++)
                {
                    if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                    {
                        infoCreditNoteDetails.LedgerId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString());
                        decLedgerId = infoCreditNoteDetails.LedgerId;
                    }
                    if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() != string.Empty)
                    {
                        if (dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            //--------Currency conversion--------------//
                            decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString()));
                            decAmount = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                            decConvertRate = decAmount * decSelectedCurrencyRate;
                            //===========================================//
                            if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() == "Dr")
                            {
                                infoCreditNoteDetails.Debit = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                infoCreditNoteDetails.Credit = 0;
                                decDebit = decConvertRate;
                                decCredit = infoCreditNoteDetails.Credit;
                            }
                            else
                            {
                                infoCreditNoteDetails.Credit = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                infoCreditNoteDetails.Debit = 0;
                                decDebit = infoCreditNoteDetails.Debit;
                                decCredit = decConvertRate;
                            }
                        }
                        infoCreditNoteDetails.ExchangeRateId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString());
                        if (dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                        {
                            infoCreditNoteDetails.ChequeNo = dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString();
                            if (dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                            {
                                infoCreditNoteDetails.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value);
                            }
                            else
                            {
                                infoCreditNoteDetails.ChequeDate = DateTime.Now;
                            }
                        }
                        else
                        {
                            infoCreditNoteDetails.ChequeNo = string.Empty;
                            infoCreditNoteDetails.ChequeDate = DateTime.Now;
                        }
                        decimal decDetailsId = BllCreditNoteDetails.CreditNoteDetailsAdd(infoCreditNoteDetails);

                        if (decDetailsId != 0)
                        {
                            PartyBalanceAddOrEdit(inI);
                            LedgerPosting(decLedgerId, decCredit, decDebit, decDetailsId, inI);
                        }
                    }

                }

                Messages.SavedMessage();


                //----------------If print after save is enable-----------------------//
                SettingsBll BllSettings = new SettingsBll();
                if (cbxPrintAfterSave.Checked)
                {
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decCreditNoteMasterId);
                    }
                    else
                    {
                        Print(decCreditNoteMasterId);
                    }
                }

                //===================================================================//
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to call the partybalance add or edit
        /// </summary>
        /// <param name="inRowIndex"></param>
        public void PartyBalanceAddOrEdit(int inRowIndex)
        {
            int inTableRowCount = dtblPartyBalance.Rows.Count;

            try
            {
                for (int inJ = 0; inJ < inTableRowCount; inJ++)
                {
                    if (dgvCreditNote.Rows[inRowIndex].Cells["dgvcmbAccountLedger"].Value.ToString() == dtblPartyBalance.Rows[inJ]["LedgerId"].ToString())
                    {
                        if (dtblPartyBalance.Rows[inJ]["PartyBalanceId"].ToString() == "0")
                        {
                            PartyBalanceAdd(inRowIndex, inJ);
                        }
                        else
                        {
                            decimal decPartyBalanceId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["partyBalanceId"]);
                            PartyBalanceEdit(decPartyBalanceId, inRowIndex, inJ);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to edit partybalance entries
        /// </summary>
        /// <param name="decPartyBalanceId"></param>
        /// <param name="inRowIndex"></param>
        /// <param name="inJ"></param>
        public void PartyBalanceEdit(decimal decPartyBalanceId, int inRowIndex, int inJ)
        {
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            PartyBalanceInfo InfopartyBalance = new PartyBalanceInfo();
            try
            {
                InfopartyBalance.PartyBalanceId = decPartyBalanceId;
                InfopartyBalance.CreditPeriod = 0;//
                InfopartyBalance.Date = dtpVoucherDate.Value;
                InfopartyBalance.LedgerId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["LedgerId"].ToString());
                InfopartyBalance.ReferenceType = dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString();
                if (dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString() == "New" || dtblPartyBalance.Rows[inJ]["ReferenceType"].ToString() == "OnAccount")
                {
                    InfopartyBalance.AgainstInvoiceNo = "0";// dtblPartyBalance.Rows[inJ]["AgainstInvoiceNo"].ToString();
                    InfopartyBalance.AgainstVoucherNo = "0";// dtblPartyBalance.Rows[inJ]["AgainstVoucherNo"].ToString();
                    InfopartyBalance.AgainstVoucherTypeId = 0; // Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["AgainstVoucherTypeId"].ToString());//decPaymentVoucherTypeId;
                    InfopartyBalance.VoucherTypeId = decCreditNoteVoucherTypeId;
                    InfopartyBalance.InvoiceNo = strInvoiceNo;
                    InfopartyBalance.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfopartyBalance.ExchangeRateId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["OldExchangeRate"].ToString());
                    InfopartyBalance.AgainstInvoiceNo = strInvoiceNo;
                    InfopartyBalance.AgainstVoucherNo = strVoucherNo;
                    InfopartyBalance.AgainstVoucherTypeId = decCreditNoteVoucherTypeId;
                    InfopartyBalance.VoucherTypeId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["AgainstVoucherTypeId"].ToString());
                    InfopartyBalance.VoucherNo = dtblPartyBalance.Rows[inJ]["AgainstVoucherNo"].ToString();
                    InfopartyBalance.InvoiceNo = dtblPartyBalance.Rows[inJ]["AgainstInvoiceNo"].ToString();
                }
                if (dgvCreditNote.Rows[inRowIndex].Cells["dgvcmbDrOrCr"].Value.ToString() == "Dr")
                {
                    InfopartyBalance.Debit = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["Amount"].ToString());
                    InfopartyBalance.Credit = 0;
                }
                else
                {
                    InfopartyBalance.Credit = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["Amount"].ToString());
                    InfopartyBalance.Debit = 0;
                }
                InfopartyBalance.ExchangeRateId = Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["CurrencyId"].ToString());
                InfopartyBalance.Extra1 = string.Empty;
                InfopartyBalance.Extra2 = string.Empty;
                InfopartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                BllPartyBalance.PartyBalanceEdit(InfopartyBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to delete partybalance of removed row
        /// </summary>
        public void DeletePartyBalanceOfRemovedRow()
        {
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            try
            {
                foreach (object obj in arrlstOfDeletedPartyBalanceRow)
                {
                    string str = Convert.ToString(obj);
                    BllPartyBalance.PartyBalanceDelete(Convert.ToDecimal(str));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Function to edit the voucher
        /// </summary>
        /// <param name="decCreditNoteMasterId"></param>
        public void Edit(decimal decCreditNoteMasterId)
        {
            try
            {
                CreditNoteBll BllCreditnoteMaster = new CreditNoteBll();
                CreditNoteMasterInfo infoCreditNoteMaster = new CreditNoteMasterInfo();
                CreditNoteBll BllCreditNoteDetails = new CreditNoteBll();
                CreditNoteDetailsInfo infoCreditNoteDetails = new CreditNoteDetailsInfo();
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();

                /*****************Update in CreditNoteMaster table *************/
                decimal decTotalDebit = 0;
                decimal decTotalCredit = 0;

                infoCreditNoteMaster.CreditNoteMasterId = decCreditNoteMasterId;
                infoCreditNoteMaster.VoucherNo = strVoucherNo;
                infoCreditNoteMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                infoCreditNoteMaster.SuffixPrefixId = decCreditNoteSuffixPrefixId;
                infoCreditNoteMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoCreditNoteMaster.Narration = txtNarration.Text.Trim();
                infoCreditNoteMaster.UserId = PublicVariables._decCurrentUserId;
                infoCreditNoteMaster.VoucherTypeId = decCreditNoteVoucherTypeId;
                infoCreditNoteMaster.FinancialYearId = Convert.ToDecimal(PublicVariables._decCurrentFinancialYearId.ToString());
                infoCreditNoteMaster.ExtraDate = DateTime.Now;
                infoCreditNoteMaster.Extra1 = string.Empty;
                infoCreditNoteMaster.Extra2 = string.Empty;

                decTotalDebit = Convert.ToDecimal(txtDebitTotal.Text.Trim());
                decTotalCredit = Convert.ToDecimal(txtCreditTotal.Text.Trim());

                infoCreditNoteMaster.TotalAmount = decTotalDebit;
                decimal decEffectRow = BllCreditnoteMaster.CreditNoteMasterEdit(infoCreditNoteMaster);

                /**********************CreditNote Details Edit********************/
                if (decEffectRow > 0)
                {
                    infoCreditNoteDetails.CreditNoteMasterId = decCreditNoteMasterId;
                    infoCreditNoteDetails.ExtraDate = DateTime.Now;
                    infoCreditNoteDetails.Extra1 = string.Empty;
                    infoCreditNoteDetails.Extra2 = string.Empty;

                    //-----------to delete details, LedgerPosting and bankReconciliation of removed rows--------------// 
                    LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();

                    foreach (object obj in arrlstOfRemove)
                    {
                        string str = Convert.ToString(obj);
                        BllCreditNoteDetails.CreditNoteDetailsDelete(Convert.ToDecimal(str));
                        BllLedgerPosting.LedgerPostDeleteByDetailsId(Convert.ToDecimal(str), strVoucherNo, decCreditNoteVoucherTypeId);
                    }
                    BllLedgerPosting.LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId(strVoucherNo, decCreditNoteVoucherTypeId, 12);
                    //=============================================================================================//

                    decimal decLedgerId = 0;
                    decimal decDebit = 0;
                    decimal decCredit = 0;
                    decimal decCreditNoteDetailsId = 0;
                    int inRowCount = dgvCreditNote.RowCount;
                    for (int inI = 0; inI < inRowCount; inI++)
                    {
                        if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                        {
                            infoCreditNoteDetails.LedgerId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString());
                            decLedgerId = infoCreditNoteDetails.LedgerId;
                        }
                        if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() != string.Empty)
                        {
                            //------------------Currency conversion------------------//
                            decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value));
                            decAmount = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                            decConvertRate = decAmount * decSelectedCurrencyRate;
                            //======================================================//

                            if (dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value.ToString() == "Dr")
                            {
                                infoCreditNoteDetails.Debit = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                infoCreditNoteDetails.Credit = 0;

                                decDebit = decConvertRate;
                                decCredit = infoCreditNoteDetails.Credit;
                            }
                            else
                            {
                                infoCreditNoteDetails.Credit = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                                infoCreditNoteDetails.Debit = 0;
                                decDebit = infoCreditNoteDetails.Debit;
                                decCredit = decConvertRate;
                            }
                            infoCreditNoteDetails.ExchangeRateId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString());
                            if (dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                            {
                                infoCreditNoteDetails.ChequeNo = dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString();
                            }
                            else
                            {
                                infoCreditNoteDetails.ChequeNo = string.Empty;
                            }
                            if (dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                            {
                                infoCreditNoteDetails.ChequeDate = Convert.ToDateTime(dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value);
                            }
                            else
                            {
                                infoCreditNoteDetails.ChequeDate = DateTime.Now;
                            }
                            if (dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                            {
                                infoCreditNoteDetails.CreditNoteDetailsId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString());
                                BllCreditNoteDetails.CreditNoteDetailsEdit(infoCreditNoteDetails);
                                PartyBalanceAddOrEdit(inI);
                                decCreditNoteDetailsId = infoCreditNoteDetails.CreditNoteDetailsId;
                                decimal decLedgerPostId = Convert.ToDecimal(dgvCreditNote.Rows[inI].Cells["dgvtxtLedgerPostingId"].Value.ToString());
                                LedgerPostingEdit(decLedgerPostId, decLedgerId, decCredit, decDebit, decCreditNoteDetailsId, inI);

                            }
                            else
                            {
                                decCreditNoteDetailsId = BllCreditNoteDetails.CreditNoteDetailsAdd(infoCreditNoteDetails);
                                PartyBalanceAddOrEdit(inI);
                                LedgerPosting(decLedgerId, decCredit, decDebit, decCreditNoteDetailsId, inI);
                            }

                        }

                    }
                    DeletePartyBalanceOfRemovedRow();
                    Messages.UpdatedMessage();
                    

                }
                //----------------If print after save is enable-----------------------//
                SettingsBll BllSettings = new SettingsBll();
                if (cbxPrintAfterSave.Checked)
                {
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(infoCreditNoteMaster.CreditNoteMasterId);
                    }
                    else
                    {
                        Print(infoCreditNoteMaster.CreditNoteMasterId);
                    }
                }

                //===================================================================//
                if (CreditNoteRegisterObj != null)
                {
                    this.Close();
                    CreditNoteRegisterObj.Enabled = true;

                }
                else if (frmCreditNoteReportObj != null)
                {
                    this.Close();
                    frmCreditNoteReportObj.Enabled = true;

                }
                else
                {
                    clear();
                }
                if (frmBillallocationObj != null)
                {
                    this.Close();
                }
                if (frmDayBookObj != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        /// <summary>
        /// Function to load the form while calling from BillAllocation form
        /// </summary>
        /// <param name="frmBillallocation"></param>
        /// <param name="deccreditMasterId"></param>
        public void CallFromBillAllocation(frmBillallocation frmBillallocation, decimal deccreditMasterId)
        {
            try
            {
                frmBillallocation.Enabled = false;
                base.Show();
                isEditMode = true;
                btnDelete.Enabled = true;
                frmBillallocationObj = frmBillallocation;
                decCreditNoteMasterIdForEdit = deccreditMasterId;
                FillFunction();
            }
            catch(Exception ex)
            {
                MessageBox.Show("CRNT:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill the controlls
        /// </summary>
        public void FillFunction()
        {
            try
            {
                CreditNoteMasterInfo infoCreditNoteMaster = new CreditNoteMasterInfo();
                CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
                infoCreditNoteMaster = BllCreditNoteMaster.CreditNoteMasterView(decCreditNoteMasterIdForEdit);

                txtVoucherNo.ReadOnly = false;
                strVoucherNo = infoCreditNoteMaster.VoucherNo;
                strInvoiceNo = infoCreditNoteMaster.InvoiceNo;
                txtVoucherNo.Text = strInvoiceNo;
                decCreditNoteSuffixPrefixId = infoCreditNoteMaster.SuffixPrefixId;
                decCreditNoteVoucherTypeId = infoCreditNoteMaster.VoucherTypeId;
                dtpVoucherDate.Value = infoCreditNoteMaster.Date;

                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decCreditNoteVoucherTypeId);
                if (isAutomatic)
                {
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                }

                txtNarration.Text = infoCreditNoteMaster.Narration;
                //GridFill
                List<DataTable> listObj = new List<DataTable>();
                CreditNoteBll BllCreditNoteDetailsSp = new CreditNoteBll();
                listObj = BllCreditNoteDetailsSp.CreditNoteDetailsViewByMasterId(decCreditNoteMasterIdForEdit);

                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                for (int inI = 0; inI < listObj[0].Rows.Count; inI++)
                {
                    dgvCreditNote.Rows.Add();
                    dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value = Convert.ToDecimal(listObj[0].Rows[inI]["ledgerId"].ToString());

                    if (Convert.ToDecimal(listObj[0].Rows[inI]["debit"].ToString()) == 0)
                    {
                        dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value = "Cr";
                        dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value = Convert.ToDecimal(listObj[0].Rows[inI]["credit"].ToString());
                    }
                    else
                    {
                        dgvCreditNote.Rows[inI].Cells["dgvcmbDrOrCr"].Value = "Dr";
                        dgvCreditNote.Rows[inI].Cells["dgvtxtAmount"].Value = Convert.ToDecimal(listObj[0].Rows[inI]["debit"].ToString());
                    }
                    dgvCreditNote.Rows[inI].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(listObj[0].Rows[inI]["exchangeRateId"].ToString());
                    if (listObj[0].Rows[inI]["chequeNo"].ToString() != string.Empty)
                    {
                        dgvCreditNote.Rows[inI].Cells["dgvtxtChequeNo"].Value = listObj[0].Rows[inI]["chequeNo"].ToString();
                        dgvCreditNote.Rows[inI].Cells["dgvtxtChequeDate"].Value = (Convert.ToDateTime(listObj[0].Rows[inI]["chequeDate"].ToString())).ToString();
                    }
                    dgvCreditNote.Rows[inI].Cells["dgvtxtDetailsId"].Value = listObj[0].Rows[inI]["CreditNoteDetailsId"].ToString();

                    decimal decDetailsId1 = Convert.ToDecimal(listObj[0].Rows[inI]["CreditNoteDetailsId"].ToString());
                    decimal decLedgerPostingId = BllLedgerPosting.LedgerPostingIdFromDetailsId(decDetailsId1, strVoucherNo, decCreditNoteVoucherTypeId);
                    dgvCreditNote.Rows[inI].Cells["dgvtxtLedgerPostingId"].Value = decLedgerPostingId.ToString();
                    btnSave.Text = "Update";

                }

                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                List<DataTable> listObj1 = new List<DataTable>();
                listObj1 = BllPartyBalance.PartyBalanceViewByVoucherNoAndVoucherType(decCreditNoteVoucherTypeId, strVoucherNo, infoCreditNoteMaster.Date);

                dtblPartyBalance = listObj1[0];
                dgvCreditNote.ClearSelection();
                txtDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        /// <summary>
        /// Function to load the form while calling from DayBook form
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                this.frmDayBookObj = frmDayBook;
                frmDayBook.Enabled = false;
                isEditMode = true;
                btnDelete.Enabled = true;
                decCreditNoteMasterIdForEdit = decMasterId;
                FillFunction();
            }
            catch (Exception ex)
            {

                MessageBox.Show("CRNT:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to load the form while calling from Ageing report form
        /// </summary>
        /// <param name="frmAgeing"></param>
        /// <param name="decMasterId"></param>
        public void callFromAgeing(frmAgeingReport frmAgeing, decimal decMasterId)
        {
            try
            {
                base.Show();
                this.frmAgeingObj = frmAgeing;
                frmAgeing.Enabled = false;
                isEditMode = true;
                btnDelete.Enabled = true;
                decCreditNoteMasterIdForEdit = decMasterId;
                FillFunction();
            }
            catch (Exception ex)
            {

                MessageBox.Show("CRNT:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Function to select the ledger while from ledgerpopup
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId)
        {
            try
            {
                base.Show();
                isEditMode = true;
                btnDelete.Enabled = true;
                frmLedgerDetailsObj = frmLedgerDetails;
                frmLedgerDetailsObj.Enabled = false;
                decCreditNoteMasterIdForEdit = decMasterId;
                FillFunction();

                            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Navigation

        /// <summary>
        /// Enter key navigation of txtVoucherNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDate.Focus();
                    txtDate.SelectionStart = txtDate.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enter key and backspace navigation of txtDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvCreditNote.Focus();
                }
                if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (!txtVoucherNo.ReadOnly)
                        {
                            txtVoucherNo.Focus();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enter key and backspace navigation of dgvCreditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvCreditNoteRowCount = dgvCreditNote.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {

                    if (dgvCreditNote.CurrentCell == dgvCreditNote.Rows[inDgvCreditNoteRowCount - 1].Cells["dgvtxtChequeDate"])
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = txtNarration.TextLength;
                        dgvCreditNote.ClearSelection();
                    }

                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvCreditNote.CurrentCell == dgvCreditNote.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        dgvCreditNote.ClearSelection();
                        txtDate.Focus();
                        txtDate.SelectionStart = txtDate.TextLength;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        if (dgvCreditNote.RowCount > 0)
                        {
                            dgvCreditNote.Focus();
                        }
                        else
                        {
                            txtDate.Focus();
                            txtDate.SelectionStart = txtDate.TextLength;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cbxPrintAfterSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Backspace navigation of btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxPrintAfterSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Backspace navigation of btnClear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Backspace navigation of btnDelete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (btnDelete.Enabled == true)
                    {
                        btnDelete.Focus();
                    }
                    else
                    {
                        btnClear.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enter key and backspace navigation of cbxPrintafterSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrintAfterSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreditNote_Load(object sender, EventArgs e)
        {
            try
            {
                AccountLedgerComboFill();
                DrOrCrComboFill();
                clear();
                CurrencyComboFill();
                DebitAndCreditTotal();

                /************For PartyBalance***********************/
                dtblPartyBalance.Columns.Add("LedgerId", typeof(decimal));
                dtblPartyBalance.Columns.Add("AgainstVoucherTypeId", typeof(decimal));
                dtblPartyBalance.Columns.Add("AgainstVoucherNo", typeof(string));
                dtblPartyBalance.Columns.Add("ReferenceType", typeof(string));
                dtblPartyBalance.Columns.Add("Amount", typeof(decimal));
                dtblPartyBalance.Columns.Add("AgainstInvoiceNo", typeof(string));
                dtblPartyBalance.Columns.Add("CurrencyId", typeof(decimal));
                dtblPartyBalance.Columns.Add("DebitOrCredit", typeof(string));
                dtblPartyBalance.Columns.Add("PendingAmount", typeof(decimal));
                dtblPartyBalance.Columns.Add("PartyBalanceId", typeof(decimal));
                dtblPartyBalance.Columns.Add("VoucherTypeId", typeof(decimal));
                dtblPartyBalance.Columns.Add("VoucherNo", typeof(string));
                dtblPartyBalance.Columns.Add("InvoiceNo", typeof(string));
                dtblPartyBalance.Columns.Add("OldExchangeRate", typeof(decimal));
                //ArrayList of deleted partybalance row in update mode
                arrlstOfDeletedPartyBalanceRow = new ArrayList();
                /***********************************************************/
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On Clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Close();
                    frmAgeingObj = null;
                }
                if (frmBillallocationObj != null)
                {
                    frmBillallocationObj.Close();
                    frmBillallocationObj = null;
                }
                if (frmCurrencyObj != null)
                {
                    frmCurrencyObj.Close();
                    frmCurrencyObj = null;
                }
                if (frmCreditNoteReportObj != null)
                {
                    frmCreditNoteReportObj.Close();
                    frmCreditNoteReportObj = null;
                }
                if (CreditNoteRegisterObj != null)
                {
                    CreditNoteRegisterObj.Close();
                    CreditNoteRegisterObj = null;
                }

                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Close();
                    frmLedgerDetailsObj = null;
                }

                if (frmPartyBalanceObj != null)
                {
                    frmPartyBalanceObj.Close();
                    frmPartyBalanceObj = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (Messages.CloseConfirmation())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On CellEnter of dgvCreditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvCreditNote.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvCreditNote.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On changing the date from dtpVoucherDate, sets the txtDate with the new date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpVoucherDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpVoucherDate.Value;
                this.txtDate.Text = date.ToString("dd-MMM-yyyy");
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Date validation while leaving txtDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtDate);
                if (!isInvalid)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtDate.Text;
                dtpVoucherDate.Value = Convert.ToDateTime(date);
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On cellvalueChanged of dgvCreditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DebitAndCreditTotal();

                    if (dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                    {
                        if (dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value == null || dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty)
                        {
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(1);//decExchangeRateId;
                        }
                    }


                    
                    //==========================================================================================//

                    //-----------To make amount readonly when party is selected as ledger------------------------------//
                    if (dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbAccountLedger")
                    {

                        /*************Remove partybalance while changing the ledger ************/
                        if (inUpdatingRowIndexForPartyRemove != -1)
                        {
                            int inTableRowCount = dtblPartyBalance.Rows.Count;
                            for (int inJ = 0; inJ < inTableRowCount; inJ++)
                            {
                                if (dtblPartyBalance.Rows.Count == inJ)
                                {
                                    break;
                                }

                                if (Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["ledgerId"].ToString()) == decUpdatingLedgerForPartyremove)
                                {
                                    if (dtblPartyBalance.Rows[inJ]["PartyBalanceId"].ToString() != "0")
                                    {
                                        arrlstOfDeletedPartyBalanceRow.Add(dtblPartyBalance.Rows[inJ]["PartyBalanceId"]);
                                    }
                                    dtblPartyBalance.Rows.RemoveAt(inJ);
                                    inJ--;
                                }
                            }

                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;

                            //reset
                            decUpdatingLedgerForPartyremove = 0;
                            inUpdatingRowIndexForPartyRemove = -1;
                        }
                        /*************************************************************************/

                        //-----------To make amount readonly when party is selected as ledger------------------------------//
                        AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                        if (bllAccountLedger.AccountGroupIdCheck(dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].FormattedValue.ToString()))
                        {
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].ReadOnly = true;

                        }
                        else
                        {
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].ReadOnly = false;
                            SettingsBll BllSettings = new SettingsBll();
                            if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                            {
                                dgvcmbCurrency.ReadOnly = false;
                            }
                            else
                            {
                                dgvcmbCurrency.ReadOnly = true;

                            }
                        }
                    }

                    //========================================================================================//

                    if (dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbDrOrCr")
                    {
                        /*************Remove partybalance while changing the Dr/Cr ************/
                        if (inUpdatingRowIndexForPartyRemove != -1)
                        {
                            int inTableRowCount = dtblPartyBalance.Rows.Count;
                            for (int inJ = 0; inJ < inTableRowCount; inJ++)
                            {
                                if (dtblPartyBalance.Rows.Count == inJ)
                                {
                                    break;
                                }

                                if (Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["ledgerId"].ToString()) == decUpdatingLedgerForPartyremove)
                                {
                                    if (dtblPartyBalance.Rows[inJ]["PartyBalanceId"].ToString() != "0")
                                    {
                                        arrlstOfDeletedPartyBalanceRow.Add(dtblPartyBalance.Rows[inJ]["PartyBalanceId"]);
                                    }
                                    dtblPartyBalance.Rows.RemoveAt(inJ);
                                    inJ--;
                                }
                            }
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;

                            //reset
                            decUpdatingLedgerForPartyremove = 0;
                            inUpdatingRowIndexForPartyRemove = -1;
                        }
                        /*************************************************************************/
                    }

                    //-----------------------------------Chequedate validation----------------------------------//
                    if (dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtChequeDate"].Value != null && dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                    {
                        DateValidation obj = new DateValidation();
                        TextBox txtDate1 = new TextBox();

                        txtDate1.Text = dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtChequeDate"].Value.ToString();
                        bool isInvalid = obj.DateValidationFunction(txtDate1);
                        if (!isInvalid)
                        {
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtChequeDate"].Value = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        }
                        else
                        {
                            dgvCreditNote.Rows[e.RowIndex].Cells["dgvtxtChequeDate"].Value = txtDate1.Text;
                        }
                    }
                    //=========================================================================================//
                    //---------------------check column missing---------------------------------//

                    CheckColumnMissing(e);

                    //==========================================================================//

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On cellBeginEdit of dgvCreditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                inUpdatingRowIndexForPartyRemove = -1;
                decUpdatingLedgerForPartyremove = 0;

                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();

                if (dgvCreditNote.CurrentCell.ColumnIndex == dgvCreditNote.Columns["dgvcmbAccountLedger"].Index)
                {
                    ListObj = bllAccountLedger.AccountLedgerViewAll();
                    DataRow dr = ListObj[0].NewRow();
                    dr[0] = 0;
                    dr[2] = string.Empty;
                    ListObj[0].Rows.InsertAt(dr, 0);

                    if (ListObj[0].Rows.Count > 0)
                    {
                        if (dgvCreditNote.RowCount > 1)
                        {
                            int inGridRowCount = dgvCreditNote.RowCount;
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                if (inI != e.RowIndex)
                                {
                                    int inTableRowcount = ListObj[0].Rows.Count;
                                    for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                    {
                                        if (dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                                        {
                                            if (ListObj[0].Rows[inJ]["ledgerId"].ToString() == dgvCreditNote.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString())
                                            {
                                                ListObj[0].Rows.RemoveAt(inJ);
                                                break;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                        DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvCreditNote[dgvCreditNote.Columns["dgvcmbAccountLedger"].Index, e.RowIndex];
                        dgvccVoucherType.DataSource = ListObj[0];
                        dgvccVoucherType.ValueMember = "ledgerId";
                        dgvccVoucherType.DisplayMember = "ledgerName";
                    }
                }

                if (dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbAccountLedger")
                {
                    if (dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                    {
                       // AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                        if (bllAccountLedger.AccountGroupIdCheck(dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].FormattedValue.ToString()))
                        {
                            inUpdatingRowIndexForPartyRemove = e.RowIndex;
                            decUpdatingLedgerForPartyremove = Convert.ToDecimal(dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value.ToString());
                        }
                    }
                }
                if (dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbDrOrCr")
                {
                    if (dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                    {
                        //AccountLedgerSP spAccountLedger = new AccountLedgerSP();
                        if (bllAccountLedger.AccountGroupIdCheck(dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].FormattedValue.ToString()))
                        {
                            inUpdatingRowIndexForPartyRemove = e.RowIndex;
                            decUpdatingLedgerForPartyremove = Convert.ToDecimal(dgvCreditNote.Rows[e.RowIndex].Cells["dgvcmbAccountLedger"].Value.ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For committing the edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCreditNote.IsCurrentCellDirty)
                {
                    dgvCreditNote.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handling dataerror
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvCreditNote.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvCreditNote.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Calling the keypress event for validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvCreditNote.CurrentCell.ColumnIndex == dgvCreditNote.Columns["dgvtxtAmount"].Index)
                {
                    txt.KeyPress += keypressevent;
                }
                else if (dgvCreditNote.CurrentCell.ColumnIndex == dgvCreditNote.Columns["dgvtxtChequeNo"].Index)
                {
                    txt.KeyPress += keypresseventEnable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// While adding new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SlNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For against button click in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCreditNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex>=0)
                {
                    if (dgvCreditNote.CurrentCell.ColumnIndex == dgvCreditNote.Columns["dgvbtnAgainst"].Index)
                    {
                        AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                        if (dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                        {
                            if (dgvCreditNote.CurrentRow.Cells["dgvcmbDrOrCr"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvcmbDrOrCr"].Value.ToString() != string.Empty)
                            {

                                if (bllAccountLedger.AccountGroupIdCheck(dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].FormattedValue.ToString()))
                                {
                                    frmPartyBalanceObj = new frmPartyBalance();
                                    frmPartyBalanceObj.MdiParent = formMDI.MDIObj;
                                    decimal decLedgerId = Convert.ToDecimal(dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString());

                                    string strDebitOrCredit = dgvCreditNote.CurrentRow.Cells["dgvcmbDrOrCr"].Value.ToString();
                                    if (!isAutomatic)
                                    {
                                        frmPartyBalanceObj.CallFromCreditNote(this, decLedgerId, dtblPartyBalance, strDebitOrCredit, decCreditNoteVoucherTypeId, txtVoucherNo.Text, Convert.ToDateTime(txtDate.Text), arrlstOfDeletedPartyBalanceRow);
                                    }
                                    else
                                    {
                                        frmPartyBalanceObj.CallFromCreditNote(this, decLedgerId, dtblPartyBalance, strDebitOrCredit, decCreditNoteVoucherTypeId, strVoucherNo, Convert.ToDateTime(txtDate.Text), arrlstOfDeletedPartyBalanceRow);
                                    }

                                }

                            }
                            else
                            {
                                Messages.InformationMessage("Select debit or credit");
                            }
                        }
                        else
                        {
                            Messages.InformationMessage("Select any ledger");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On remove linkbutton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvCreditNote.RowCount > 1)
                {
                    if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RemoveRow();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SaveOrEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On Delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction(decCreditNoteMasterIdForEdit);
                        }
                        dgvCreditNote.Focus();
                    }
                    else
                    {
                        DeleteFunction(decCreditNoteMasterIdForEdit);
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreditNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (CreditNoteRegisterObj != null)
                {
                    CreditNoteRegisterObj.Enabled = true;
                    CreditNoteRegisterObj.SearchRegister();
                }
                else if (frmCreditNoteReportObj != null)
                {
                    frmCreditNoteReportObj.Enabled = true;
                    frmCreditNoteReportObj.Search();
                }
                if (frmBillallocationObj != null)
                {
                    frmBillallocationObj.Enabled = true;
                    frmBillallocationObj.BillAllocationGridFill();
                    frmBillallocationObj.Activate();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.FillGrid();
                    frmAgeingObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Enabled = true;
                    frmLedgerDetailsObj.LedgerDetailsView();
                    frmLedgerDetailsObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For the shortcut keys
        /// Esc for form closing
        /// ctrl+s for save
        /// ctrl+d for delete
        /// alt+c for ledger creation
        /// ctrl+f for ledger popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreditNote_KeyDown(object sender, KeyEventArgs e)
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
                if (dgvCreditNote.RowCount > 0)
                {
                    if (dgvCreditNote.CurrentCell == dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"])
                    {
                        //-----------------------for ledger creation----------------------------------//
                        if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)//Ledger creation
                        {
                            frmAccountLedger accounLedgerObj = new frmAccountLedger();
                            accounLedgerObj.MdiParent = formMDI.MDIObj;
                            if (dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                            {
                                string strLedgerName = dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].FormattedValue.ToString();
                                accounLedgerObj.CallFromCreditNote(this, strLedgerName);
                            }
                            else
                            {
                                string strLedgerName = string.Empty;
                                accounLedgerObj.CallFromCreditNote(this, strLedgerName);
                            }

                        }
                        //========================================================================//

                        //--------------------For ledger Popup------------------------------------//

                        if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)//Ledger popup
                        {
                            frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                            frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                            btnSave.Focus();
                            dgvCreditNote.Focus();
                            if (dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                            {
                                btnSave.Focus();
                                dgvCreditNote.Focus();
                                decLedgerIdForPopUp = Convert.ToDecimal(dgvCreditNote.CurrentRow.Cells["dgvcmbAccountLedger"].Value.ToString());
                                frmLedgerPopupObj.CallFromCreditNote(this, decLedgerIdForPopUp, string.Empty);

                            }

                        }
                        //========================================================================// 
                    }
                    if (dgvCreditNote.CurrentCell == dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"])
                    {
                        if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                        {
                            frmCurrencyObj = new frmCurrencyDetails();
                            frmCurrencyObj.MdiParent = formMDI.MDIObj;
                            if (dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value != null && dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString() != string.Empty)
                            {
                                frmCurrencyObj.CallFromCreditNote(this, Convert.ToDecimal(dgvCreditNote.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString()));
                            }
                        }
                    }
                }


                //-----------------------CTRL+S Save-----------------------------//
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave_Click(sender, e);
                }
                //===============================================================//

                //-----------------------CTRL+D Delete-----------------------------//
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
                //=====================================================================//
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

   
    }
}
