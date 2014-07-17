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
    public partial class frmPdcClearance : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strVoucherNo = string.Empty;
        decimal decPDCclearanceVoucherTypeId = 0;
        bool isAutomatic = false;       //To checking vocher no generation auto or not
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strInvoiceNo = string.Empty;
        decimal decSufixprefixPdcpayableID = 0;
        bool isDontExecuteVoucherType = false;//To keep voucher Type Execute
        string strtableName = "PdcClearanceMaster";
        bool isInEditMode = false; // Tp decide whether is edit mode of not
        bool isInvoicefill = false;
        DataTable dtblPartyBalance = new DataTable(); // To pass values to party balance
        string strVoucherType = string.Empty;
        decimal decmasterId = 0;// To keep the masterId either PDcpayable or PDCreceivable.
        string strledgerId;
        decimal decPDCClearanceEditId = 0;
        frmPdcClearanceRegister pdcClearanceRegObj = null;//To use in call from   frmPdcClearanceRegister
        frmPDCClearanceReport pdcClearanceReportObj = null;//To use in call from   frmPDCClearanceReport
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        List<DataTable> listObjDetails = new List<DataTable>();
        frmVoucherSearch objVoucherSearch = null;
        decimal decMasterIdEdit = 0;
        int inKeyPrsCount = 0;
        frmLedgerDetails frmLedgerDetailsObj;
        #endregion

        #region Functions
        /// <summary>
        /// VoucherType Combofill
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                isDontExecuteVoucherType = true;
                List<DataTable> listObj = new List<DataTable>();
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                cmbvouchertype.DataSource = null;
                listObj = BllPdcClearance.VouchertypeComboFill();
                cmbvouchertype.DataSource = listObj[0];
                cmbvouchertype.ValueMember = "voucherTypeId";
                cmbvouchertype.DisplayMember = "voucherTypeName";
                cmbvouchertype.SelectedIndex = -1;
                isDontExecuteVoucherType = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Invoice no Combo fill function
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <param name="masterId"></param>
        public void InvoiceNumberCombofill(string strVoucherType, decimal masterId)
        {
            try
            {
                if (cmbvouchertype.Text != string.Empty)
                {
                    if (cmbvouchertype.SelectedValue.ToString() != "System.Data.DataRowView" && cmbvouchertype.Text != "System.Data.DataRowView")
                    {
                        isInvoicefill = true;
                        if (isInEditMode)
                        {
                            masterId = decMasterIdEdit;
                        }
                        List<DataTable> listObjInvoice = new List<DataTable>();
                        PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                        listObjInvoice = BllPdcClearance.InvoiceNumberCombofillUnderVoucherType(strVoucherType, masterId);
                        cmbInvoiceNo.DataSource = listObjInvoice[0];
                        if (cmbInvoiceNo.DataSource != null)
                        {
                            cmbInvoiceNo.DisplayMember = "invoiceNo";
                            cmbInvoiceNo.ValueMember = "MasterId";
                            cmbInvoiceNo.SelectedIndex = -1;
                        }
                        isInvoicefill = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Details fill function when user changed the invoice no. here fill thje curresponding invoice no
        /// </summary>
        public void filldetailsfunction()
        {
            try
            {
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                decmasterId = Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString());
                listObjDetails = BllPdcClearance.pdcclearancedetailsFill(cmbvouchertype.Text.ToString(), decmasterId);
                string strchequeNo = listObjDetails[0].Rows[0]["chequeNo"].ToString();
                decimal decAmount = Convert.ToDecimal(listObjDetails[0].Rows[0]["amount"].ToString());
                string straccountledger = listObjDetails[0].Rows[0]["ledgerName"].ToString();
                DateTime dtcheckdate = Convert.ToDateTime(listObjDetails[0].Rows[0]["checkDate"].ToString());
                string strBank = listObjDetails[0].Rows[0]["Bank"].ToString();
                strledgerId = listObjDetails[0].Rows[0]["ledgerId"].ToString();
                txtcheckNo.Text = strchequeNo;
                txtAmount.Text = decAmount.ToString();
                txtAccountLedger.Text = straccountledger;
                txtcheckdate.Text = Convert.ToString(listObjDetails[0].Rows[0]["checkDate"].ToString());
                txtBank.Text = strBank;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decPDCClearanceEditId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// The form will be reset here
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                VoucherNumberGeneration();
                VoucherTypeComboFill();
                FinancialYearDate();
                txtVoucherDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                cmbInvoiceNo.DataSource = null;
                detailsclear();
                cmbStatus.SelectedIndex = -1;
                txtNarration.Clear();
                PrintCheck();
                decmasterId = 0;
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cleare the details here
        /// </summary>
        public void detailsclear()
        {
            try
            {
                txtAccountLedger.Clear();
                txtcheckNo.Clear();
                txtAmount.Clear();
                txtBank.Clear();
                txtcheckdate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {

                decPDCclearanceVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVOucherType = new VoucherTypeBll();
                isAutomatic = BllVOucherType.CheckMethodOfVoucherNumbering(decPDCclearanceVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                //SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPDCclearanceVoucherTypeId, dtpVoucherDate.Value);
                decSufixprefixPdcpayableID = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtVoucherDate.Focus();
                }
                else
                {
                    txtvoucherNo.Focus();
                }
                ClearFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Voucher no automatic generation, it considered the settings also
        /// </summary>
        public void VoucherNumberGeneration()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();

                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();

                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPDCclearanceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strtableName);
                if (Convert.ToDecimal(strVoucherNo) != BllPdcClearance.PDCClearanceMaxUnderVoucherTypePlusOne(decPDCclearanceVoucherTypeId))
                {
                    strVoucherNo = BllPdcClearance.PDCClearanceMaxUnderVoucherType(decPDCclearanceVoucherTypeId).ToString();
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPDCclearanceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strtableName);
                    if (BllPdcClearance.PDCClearanceMaxUnderVoucherType(decPDCclearanceVoucherTypeId).ToString() == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPDCclearanceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, strtableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPDCclearanceVoucherTypeId, dtpVoucherDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decSufixprefixPdcpayableID = infoSuffixPrefix.SuffixprefixId;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtvoucherNo.Text = strInvoiceNo;
                    lblVoucherNoManualValidator.Visible = false;
                    txtvoucherNo.ReadOnly = true;
                    txtvoucherNo.Enabled = false;
                }
                else
                {
                    txtvoucherNo.ReadOnly = false;
                    txtvoucherNo.Text = string.Empty;
                    lblVoucherNoManualValidator.Visible = true;
                    strInvoiceNo = txtvoucherNo.Text.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Getting the financial year date
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
                dtpVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpVoucherDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();               
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtVoucherDate = infoComapany.CurrentDate;
                dtpVoucherDate.Value = dtVoucherDate;
                txtVoucherDate.Text = dtVoucherDate.ToString("dd-MMM-yyyy");
                dtpVoucherDate.Value = Convert.ToDateTime(txtVoucherDate.Text);
                txtVoucherDate.Focus();
                txtVoucherDate.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Or edit function, here checking the invalid entries
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                bool isOk = true;
                if (isOk)
                    if (txtvoucherNo.Text == string.Empty)
                    {
                        Messages.InformationMessage("Enter voucher no");
                        txtvoucherNo.Focus();
                    }
                    else if (txtVoucherDate.Text == string.Empty)
                    {
                        Messages.InformationMessage("Select date");
                        txtVoucherDate.Focus();
                    }
                    else if (cmbvouchertype.SelectedValue == null)
                    {
                        Messages.InformationMessage("Select voucher type");
                        cmbvouchertype.Focus();
                    }
                    else if (cmbInvoiceNo.SelectedValue == null)
                    {
                        Messages.InformationMessage("Select against invoice no");
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbStatus.Text == string.Empty)
                    {
                        Messages.InformationMessage("Select status");
                        cmbStatus.Focus();
                    }
                    else
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            isOk = false;
                            PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                            if (!isInEditMode)
                            {
                                if (Messages.SaveMessage())
                                    if (!BllPdcClearance.PDCclearanceCheckExistence(txtvoucherNo.Text.Trim(), decPDCclearanceVoucherTypeId, 0))
                                    {
                                        SaveFunction();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Voucher number already exist");
                                    }
                            }
                            else if (isInEditMode)
                            {
                                if (Messages.UpdateMessage())
                                {
                                    SaveFunction();
                                }
                            }
                        }
                        if (isOk)
                        {
                            if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                            {
                                PDCPayableBll BllPDCPayable = new PDCPayableBll();

                                if (isInEditMode)
                                {
                                    SaveFunction();
                                }
                                else
                                {
                                    SaveFunction();
                                }
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
                MessageBox.Show("PC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                DateValidation Objdatevalidation = new DateValidation();
                OtherDateValidationFunction ObjotherdateValidation = new OtherDateValidationFunction();
                Objdatevalidation.DateValidationFunction(txtVoucherDate);
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                SettingsBll BllSettings = new SettingsBll();
                txtVoucherDate.Text = txtVoucherDate.Text.Trim();
                cmbvouchertype.Text = cmbvouchertype.Text.Trim();
                txtAmount.Text = txtAmount.Text.Trim();
                txtBank.Text = txtBank.Text.Trim();
                txtcheckdate.Text = txtcheckdate.Text.Trim();
                txtcheckNo.Text = txtcheckNo.Text.Trim();
                txtNarration.Text = txtNarration.Text.Trim();
                DataTable dtblMaster = new DataTable();
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                PDCClearanceMasterInfo infoPdcclearance = new PDCClearanceMasterInfo();
                infoPdcclearance.SuffixPrefixId = decSufixprefixPdcpayableID;
                infoPdcclearance.FinancialYearId = Convert.ToDecimal(PublicVariables._decCurrentFinancialYearId.ToString());
                infoPdcclearance.VoucherNo = strVoucherNo;
                infoPdcclearance.InvoiceNo = txtvoucherNo.Text;
                if (txtVoucherDate.Text != string.Empty)
                    infoPdcclearance.Date = Convert.ToDateTime(txtVoucherDate.Text);
                else
                    infoPdcclearance.Date = DateTime.Now;
                infoPdcclearance.LedgerId = decimal.Parse(strledgerId.ToString());
                infoPdcclearance.AgainstId = decmasterId;
                infoPdcclearance.UserId = PublicVariables._decCurrentUserId;
                infoPdcclearance.VoucherTypeId = decPDCclearanceVoucherTypeId;
                infoPdcclearance.Status = cmbStatus.Text.ToString();
                infoPdcclearance.Type = cmbvouchertype.Text.ToString();
                infoPdcclearance.ExtraDate = DateTime.Now;
                infoPdcclearance.Narration = txtNarration.Text;
                infoPdcclearance.Extra1 = string.Empty;
                infoPdcclearance.Extra2 = string.Empty;
                if (!isInEditMode)
                {
                    decimal decIdentity = BllPdcClearance.PDCClearanceMasterAdd(infoPdcclearance);
                    LedgerPostingAdd();
                    if (cmbStatus.Text.ToString() == "Bounced")
                    {
                        if (bllAccountLedger.AccountGroupIdCheck(txtAccountLedger.Text.ToString()))
                        {
                            PartyBalanceAddOrEdit();
                        }
                    }
                    Messages.SavedMessage();
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decIdentity);
                        }
                        else
                        {
                            Print(decIdentity);
                        }
                    }
                    ClearFunction();
                }
                else
                {
                    decimal decIdentity = decPDCClearanceEditId;
                    infoPdcclearance.PDCClearanceMasterId = decPDCClearanceEditId;
                    BllPdcClearance.PDCClearanceMasterEdit(infoPdcclearance);
                    bllAccountLedger.LedgerPostingDeleteByVoucherTypeAndVoucherNo(strVoucherNo, decPDCclearanceVoucherTypeId);
                    LedgerPostingAdd();
                    bllAccountLedger.PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(strVoucherNo, decPDCclearanceVoucherTypeId);
                    if (cmbStatus.Text.ToString() == "Bounced")
                    {
                        if (bllAccountLedger.AccountGroupIdCheck(txtAccountLedger.Text.ToString()))
                        {
                            PartyBalanceAddOrEdit();
                        }
                    }
                    Messages.UpdatedMessage();
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decIdentity);
                        }
                        else
                        {
                            Print(decIdentity);
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger Posting Function, here saving the curresponding details into the ledger
        /// </summary>
        public void LedgerPostingAdd()
        {
            try
            {
                string strstatus = cmbStatus.Text.ToString();
                LedgerPostingInfo InfoPosting = new LedgerPostingInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                PDCPayableMasterInfo infoPDCPayable = new PDCPayableMasterInfo();
                PDCPayableBll BllPDCPayable = new PDCPayableBll();
                PDCReceivableMasterInfo infoPDCReceivable = new PDCReceivableMasterInfo();
                PDCRecivebleBll BllPDCReciveble = new PDCRecivebleBll();
                strVoucherType = BllPdcClearance.TypeOfVoucherReturnUnderVoucherName(cmbvouchertype.Text.ToString());
                if (strVoucherType == "PDC Payable")
                {
                    infoPDCPayable = BllPDCPayable.PDCPayableMasterView(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()));
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtvoucherNo.Text.Trim();
                    infoLedgerPosting.Date = Convert.ToDateTime(txtVoucherDate.Text.ToString());
                    infoLedgerPosting.VoucherTypeId = decPDCclearanceVoucherTypeId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.ChequeDate = Convert.ToDateTime(txtcheckdate.Text.ToString());
                    infoLedgerPosting.ChequeNo = txtcheckNo.Text.Trim();
                    infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    if (strstatus == "Cleared")
                    {

                        infoLedgerPosting.LedgerId = infoPDCPayable.BankId;
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = Convert.ToDecimal(txtAmount.Text.ToString());
                    }
                    else if (strstatus == "Bounced")
                    {
                        infoLedgerPosting.LedgerId = infoPDCPayable.LedgerId;
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = Convert.ToDecimal(txtAmount.Text.ToString());
                    }
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    infoLedgerPosting.VoucherTypeId = decPDCclearanceVoucherTypeId;
                    infoLedgerPosting.VoucherNo = txtvoucherNo.Text.Trim();
                    infoLedgerPosting.Date = Convert.ToDateTime(txtVoucherDate.Text.ToString());
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.ChequeDate = Convert.ToDateTime(txtcheckdate.Text);
                    infoLedgerPosting.ChequeNo = txtcheckNo.Text.Trim();
                    infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtvoucherNo.Text.Trim();
                    infoLedgerPosting.LedgerId = 6;
                    infoLedgerPosting.Debit = Convert.ToDecimal(txtAmount.Text.ToString());
                    infoLedgerPosting.Credit = 0;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
                else if (strVoucherType == "PDC Receivable")
                {
                    infoPDCReceivable = BllPDCReciveble.PDCReceivableMasterView(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()));
                    infoLedgerPosting.VoucherTypeId = decPDCclearanceVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtvoucherNo.Text.Trim();
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.LedgerId = 7;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = Convert.ToDecimal(txtAmount.Text.ToString());
                    infoLedgerPosting.ChequeDate = Convert.ToDateTime(txtcheckdate.Text.ToString());
                    infoLedgerPosting.ChequeNo = txtcheckNo.Text.Trim();
                    infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    infoLedgerPosting.VoucherTypeId = decPDCclearanceVoucherTypeId;
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    if (strstatus == "Cleared")
                    {
                        infoLedgerPosting.LedgerId = infoPDCReceivable.BankId;
                    }
                    else if (strstatus == "Bounced")
                    {
                        infoLedgerPosting.LedgerId = infoPDCReceivable.LedgerId;
                    }
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtvoucherNo.Text.Trim();
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.Debit = Convert.ToDecimal(txtAmount.Text.ToString());
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.ChequeDate = Convert.ToDateTime(txtcheckdate.Text);
                    infoLedgerPosting.ChequeNo = txtcheckNo.Text.Trim();
                    infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Party balance Add function, here adding the balance amount into the party balance table
        /// </summary>
        public void PartyBalanceAddOrEdit()
        {
            int inTableRowCount = dtblPartyBalance.Rows.Count;
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            PartyBalanceInfo InfopartyBalance = new PartyBalanceInfo();
            try
            {
                InfopartyBalance.CreditPeriod = 0;
                InfopartyBalance.Date = dtpVoucherDate.Value;
                InfopartyBalance.LedgerId = Convert.ToDecimal(strledgerId);
                InfopartyBalance.ReferenceType = "New";
                InfopartyBalance.VoucherTypeId = decPDCclearanceVoucherTypeId;
                InfopartyBalance.InvoiceNo = txtvoucherNo.Text.ToString();
                InfopartyBalance.VoucherNo = strVoucherNo;
                InfopartyBalance.AgainstInvoiceNo = "0";
                InfopartyBalance.AgainstVoucherNo = "0";
                InfopartyBalance.AgainstVoucherTypeId = 0;
                InfopartyBalance.Extra1 = string.Empty;
                InfopartyBalance.Extra2 = string.Empty;
                InfopartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfopartyBalance.ExchangeRateId = 1;
                if (strVoucherType == "PDC Payable")
                {
                    InfopartyBalance.Debit = 0;
                    InfopartyBalance.Credit = Convert.ToDecimal(txtAmount.Text.ToString());
                    BllPartyBalance.PartyBalanceAdd(InfopartyBalance);
                }
                else if (strVoucherType == "PDC Receivable")
                {
                    InfopartyBalance.Debit = Convert.ToDecimal(txtAmount.Text.ToString());
                    InfopartyBalance.Credit = 0;
                    BllPartyBalance.PartyBalanceAdd(InfopartyBalance);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its the fill function to update or delete
        /// </summary>
        public void FillFunction()
        {
            try
            {
                PDCClearanceMasterInfo infoPDCClearance = new PDCClearanceMasterInfo();
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                infoPDCClearance = BllPdcClearance.PDCClearanceMasterView(decPDCClearanceEditId);
                VoucherTypeComboFill();
                strVoucherNo = infoPDCClearance.VoucherNo;
                strInvoiceNo = infoPDCClearance.InvoiceNo;
                txtvoucherNo.Text = strInvoiceNo;
                decSufixprefixPdcpayableID = infoPDCClearance.SuffixPrefixId;
                decPDCclearanceVoucherTypeId = infoPDCClearance.VoucherTypeId;
                VoucherTypeBll BllVOucherType = new VoucherTypeBll();
                isAutomatic = BllVOucherType.CheckMethodOfVoucherNumbering(decPDCclearanceVoucherTypeId);
                if (isAutomatic)
                {
                    txtvoucherNo.ReadOnly = true;
                }
                else
                {
                    txtvoucherNo.ReadOnly = false;
                }
                if (infoPDCClearance.PDCClearanceMasterId != 0)
                {                    
                    txtvoucherNo.Text = infoPDCClearance.VoucherNo;
                    dtpVoucherDate.Value = infoPDCClearance.Date;
                    txtVoucherDate.Text = dtpVoucherDate.Value.ToString("dd-MMM-yyyy");
                    txtNarration.Text = infoPDCClearance.Narration;
                    cmbvouchertype.Text = infoPDCClearance.Type;
                    InvoiceNumberCombofill(cmbvouchertype.Text.ToString(), decMasterIdEdit);
                    cmbStatus.Text = infoPDCClearance.Status;
                    cmbInvoiceNo.SelectedValue = decMasterIdEdit;
                    btnSave.Text = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerDetails to view details and for updation
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId)
        {
            try
            {

                base.Show();
                frmLedgerDetailsObj = frmLedgerDetails;
                frmLedgerDetailsObj.Enabled = false;
                isInEditMode = true;
                btnDelete.Enabled = true;
                decPDCClearanceEditId = decMasterId;
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                decMasterIdEdit = BllPdcClearance.PDCClearanceAgainstIdUnderClearanceId(decPDCClearanceEditId);
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPdcClearanceRegister to view details and for updation
        /// </summary>
        /// <param name="PDCClearanceReg"></param>
        /// <param name="decMasterId"></param>
        public void CallFromPDCClearanceRegister(frmPdcClearanceRegister PDCClearanceReg, decimal decMasterId)
        {
            try
            {
                PDCClearanceReg.Enabled = false;
                base.Show();
                isInEditMode = true;
                btnDelete.Enabled = true;
                pdcClearanceRegObj = PDCClearanceReg;
                decPDCClearanceEditId = decMasterId;
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                decMasterIdEdit = BllPdcClearance.PDCClearanceAgainstIdUnderClearanceId(decPDCClearanceEditId);
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPDCClearanceReport to view details and for updation
        /// </summary>
        /// <param name="PDCClearanceReport"></param>
        /// <param name="decMasterId"></param>
        public void CallFromPDCClearanceReport(frmPDCClearanceReport PDCClearanceReport, decimal decMasterId)
        {
            try
            {
                PDCClearanceReport.Enabled = false;
                base.Show();
                isInEditMode = true;
                btnDelete.Enabled = true;
                pdcClearanceReportObj = PDCClearanceReport;
                decPDCClearanceEditId = decMasterId;
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                decMasterIdEdit = BllPdcClearance.PDCClearanceAgainstIdUnderClearanceId(decPDCClearanceEditId);
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its the function for print function
        /// </summary>
        /// <param name="decMasterId"></param>
        public void Print(decimal decMasterId)
        {
            try
            {
                DataSet dsPdcClearance = new DataSet();
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                dsPdcClearance = BllPdcClearance.PDCClearanceVoucherPrinting(decMasterId, 1);
                frmReport frmreport = new frmReport();
                frmreport.MdiParent = formMDI.MDIObj;
                frmreport.PDCClearancevoucherPrinting(dsPdcClearance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Its the function to print the curresponding details to the Dotmatrix printer
        /// </summary>
        /// <param name="decMasterId"></param>
        public void PrintForDotMatrix(decimal decMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreation.CompanyViewForDotMatrix();
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("BankAccount");
                dtblGridDetails.Columns.Add("ChequeNo");
                dtblGridDetails.Columns.Add("ChequeDate");
                dtblGridDetails.Columns.Add("Amount");
                dtblGridDetails.Columns.Add("AccountLedger");
                dtblGridDetails.Columns.Add("voucherNo");
                dtblGridDetails.Columns.Add("voucherDate");
                dtblGridDetails.Columns.Add("voucherType");
                dtblGridDetails.Columns.Add("Narration");
                dtblGridDetails.Columns.Add("againstInvoiceNo");
                dtblGridDetails.Columns.Add("Status");
                DataRow dr = dtblGridDetails.NewRow();
                dr["SlNo"] = 1;
                dr["ChequeNo"] = txtcheckNo.Text;
                dr["BankAccount"] = txtBank.Text;
                dr["ChequeDate"] = txtcheckdate.Text;
                dr["Amount"] = txtAmount.Text;
                dr["AccountLedger"] = txtAccountLedger.Text;
                dr["voucherNo"] = txtvoucherNo.Text;
                dr["voucherDate"] = txtVoucherDate.Text;
                dr["voucherType"] = cmbvouchertype.Text;
                dr["Narration"] = txtNarration.Text;
                dr["againstInvoiceNo"] = cmbInvoiceNo.Text;
                dr["Status"] = cmbStatus.Text;
                dtblGridDetails.Rows.Add(dr);
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtAmount.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decPDCclearanceVoucherTypeId);
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
                MessageBox.Show("PC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// checking the print checkbox settings 
        /// </summary>
        public void PrintCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();

                if (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes")
                {
                    cbxPrint.Checked = true;
                }
                else
                {
                    cbxPrint.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// delete function
        /// </summary>
        /// <param name="decpdcMasterId"></param>
        public void DeleteFunction(decimal decpdcMasterId)
        {
            try
            {
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                BllPdcClearance.PDCClearanceDelete(decpdcMasterId, decPDCclearanceVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (pdcClearanceRegObj != null)
                {
                    this.Close();
                    pdcClearanceRegObj.Show();
                }
                else if (pdcClearanceReportObj != null)
                {
                    this.Close();
                    pdcClearanceReportObj.Show();
                }
                else if (objVoucherSearch != null)
                {
                    this.Close();
                    objVoucherSearch.GridFill();
                }
                else if (frmLedgerDetailsObj != null)
                {
                    this.Close();
                }
                else if (frmDayBookObj != null)
                {
                    this.Close();
                }
                else
                {
                    ClearFunction();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                frmDayBook.Enabled = false;
                base.Show();
                isInEditMode = true;
                btnDelete.Enabled = true;
                frmDayBookObj = frmDayBook;
                decPDCClearanceEditId = decMasterId;
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                decMasterIdEdit = BllPdcClearance.PDCClearanceAgainstIdUnderClearanceId(decPDCClearanceEditId);
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Create an instance for frmPdcClearance class
        /// </summary>
        public frmPdcClearance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPdcClearance_Load(object sender, EventArgs e)
        {
            try
            {
                ClearFunction();
                isInvoicefill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click.call the clear function
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
                MessageBox.Show("PC24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Invoice no combobox index changed, here call the fill function curresponding to the Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                detailsclear();
                if (!isInvoicefill)
                {

                    if ((cmbInvoiceNo.SelectedValue == null ? string.Empty : cmbInvoiceNo.SelectedValue.ToString()) != string.Empty)
                    {
                        if (cmbInvoiceNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbInvoiceNo.Text != "System.Data.DataRowView")
                        {
                            filldetailsfunction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calling the Invoice no combofill in vouchertype combobox index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbvouchertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                detailsclear();
                if (!isDontExecuteVoucherType)
                {
                    if (cmbvouchertype.SelectedValue != null)
                    {
                        if (cmbvouchertype.SelectedValue.ToString() != "System.Data.DataRowView" && cmbvouchertype.Text != "System.Data.DataRowView")
                        {
                            InvoiceNumberCombofill(cmbvouchertype.Text.ToString(), decmasterId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click, checking the user privilage and Calling the Save or edit function
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
                MessageBox.Show("PC27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (Messages.CloseConfirmation())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// PDC Clearence form closing, checking the other forms are opend or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPdcClearance_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (pdcClearanceRegObj != null)
                {
                    pdcClearanceRegObj.Enabled = true;
                    pdcClearanceRegObj.Search();
                }
                if (pdcClearanceReportObj != null)
                {
                    pdcClearanceReportObj.Enabled = true;
                    pdcClearanceReportObj.ReportSearch();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Enabled = true;
                    frmLedgerDetailsObj.Activate();
                    frmLedgerDetailsObj.LedgerDetailsView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click, checking the user role PrivilegeCheck and call the delete function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                PDCClearanceBll BllPdcClearance = new PDCClearanceBll();
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            if (isInEditMode)
                            {
                                DeleteFunction(decPDCClearanceEditId);
                                txtvoucherNo.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (isInEditMode)
                        {
                            DeleteFunction(decPDCClearanceEditId);
                            txtvoucherNo.Focus();
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
                MessageBox.Show("PC30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbvouchertype.Focus();
                }
                if (txtVoucherDate.Text == string.Empty || txtVoucherDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (!txtvoucherNo.ReadOnly)
                        {
                            txtvoucherNo.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtvoucherNo_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionStart = 0;
                    txtVoucherDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbvouchertype_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    cmbInvoiceNo.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionStart = 0;
                    txtVoucherDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbvouchertype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbInvoiceNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inKeyPrsCount++;
                    if (inKeyPrsCount == 2)
                    {
                        inKeyPrsCount = 0;
                        btnSave.Focus();
                    }
                }
                else
                {
                    inKeyPrsCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtNarration.Text == "" || txtNarration.SelectionStart == 0)
                    {
                        cmbStatus.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPdcClearance_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    btnSave_Click(sender, e);
                }
                else if (e.Control && e.KeyCode == Keys.D)
                {
                    if (btnDelete.Enabled)

                        btnDelete_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Voucherdate leave to set the current date into the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtVoucherDate);
                if (!isInvalid)
                {
                    txtVoucherDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtVoucherDate.Text;
                dtpVoucherDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datetimepicker value changed for setting the dtp valu as textbox's new value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpVoucherDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpVoucherDate.Value;
                this.txtVoucherDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
