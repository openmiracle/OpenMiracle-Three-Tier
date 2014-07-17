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
    public partial class frmServiceVoucher : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        int inNarrationCount = 0;                                       //  Number of lines in txtNarration
        int inGridRowCount = 0;                                         //  Number of rows in grid
        int inArrOfRemoveIndex = 0;                                     //  Index to remove row from tbl_ServiceDetails 
        bool isAutomatic = false;                                       //  Set true when automatic invoice number generation is activated
        bool isValueChanged = false;                                    //  To check grid details values incomplete or not        
        bool isEditMode = false;                                        //  Set true when this form called from frmServiceVoucherRegister form       
        string strInvoiceNo = string.Empty;                             //  To save invoice no into tbl_Service master
        string strPrefix = string.Empty;                                //  Store prefix of voucher number if suffix-prefix is set
        string strSuffix = string.Empty;                                //  Store sufix of voucher number if suffix-prefix is set     
        string strCashOrPartyName;                                      //  To get the selected value in cmbCashOrParty at the time of ledger popup          
        string strSalesman = string.Empty;                              //  To get the selected value in cmbSalesman at the time of ledger popup
        string tableName = "ServiceMaster";                             //  Argument to automatic Voucher number generation
        string strVoucherNo = string.Empty;                             //  To save voucher no into tbl_ServiceMaster   
        string strParticular = string.Empty;                            //  To get the selected value in cmbParticular in grid at the time of ledger popup  
        decimal decSelectedCurrencyRate = 0;                            //  To select current currency rate
        decimal decAmount = 0;                                          //  Amount to be convert            
        decimal decMasterId = 0;                                        //  An alternate of decServiceMasterId
        decimal decConvertRate = 0;                                     //  Converted amount            
        decimal decCredit = 0;                                          //  Credited amount    
        decimal decDebit = 0;                                           //  Debited amount    
        decimal decLedgerId = 0;                                        //  Ledger id selected from cmbCashOrParty
        decimal DecServicetVoucherTypeId = 0;                           //  To store the selected voucher type id from frmVoucherTypeSelection
        decimal decServiceSuffixPrefixId = 0;                           //  To store the selected voucher type's suffixpreffixid 
        decimal decServiceDetailsId = 0;                                //  ServiceDetailsId to edit,delete and print
        decimal decServiceMasterId = 0;                                 //  ServiceMasterId to edit,delete and print
        decimal decPartyBalanceId = 0;                                      //  Party balance id
        ArrayList strArrOfRemove = new ArrayList();                     //  Array of Index to remove row from tbl_ServiceDetails
        ArrayList strArrayOfRemovedLedgerPostingId = new ArrayList();   //  Array of Index to remove row from tbl_LedgerPosting
        frmEmployeePopup frmEmployeePopupObj;                           //  To use in call from emoloyee popup function    
        frmLedgerPopup frmLedgerPopupObj;                               //  To use in call from ledger popup function          
        frmServiceVoucherRegister frmServiceVoucherRegisterObj;         //  To use in call from service register function
        frmServiceReport frmServiceReportObj;                           //  To use in call from service report function
        frmServices frmServicesObj = new frmServices();                 //  To use in call from service ledger pop function
        SettingsBll BllSettings = new SettingsBll();                   //  To select data from settings table
        frmDayBook frmDayBookObj = null;                                 //  To use in call from frmDayBook 
        frmAgeingReport frmAgeingObj = null;                                 //  To use in call from frmAgeing
        frmVoucherSearch objVoucherSearch = null;                               //To use in call from VoucherSearch
        frmLedgerDetails frmLedgerDetailsObj = null;
        #endregion
        #region Function
        /// <summary>
        /// Create instance of frmServiceVoucher
        /// </summary>
        public frmServiceVoucher()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Salesman combobox while return from frmSalesman when creating new Salesman 
        /// </summary>
        /// <param name="decSalesmanId"></param>
        public void ReturnFromSalesman(decimal decSalesmanId)//Select newly created Salesman in  cmbSalesman on Plus button
        {
            try
            {
                this.Enabled = true;
                SalesmanComboFill();
                if (decSalesmanId.ToString() != "0")
                {
                    cmbSalesman.SelectedValue = decSalesmanId;
                }
                else
                {
                    cmbSalesman.SelectedValue = -1;
                }
                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 01: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serialnumber generation
        /// </summary>
        public void SerialNo()//  Putting serial number on grid
        {
            try
            {
                foreach (DataGridViewRow row in dgvServiceVoucher.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = row.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 02: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit the ledger posting
        /// </summary>
        /// <param name="decLedgerPostingId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decCredit"></param>
        /// <param name="decDebit"></param>
        public void LedgerPostingEdit(decimal decLedgerPostingId, decimal decLedgerId, decimal decCredit, decimal decDebit) //  Function to  edit LedgerPosting table
        {
            try
            {
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                infoLedgerPosting.VoucherTypeId = DecServicetVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                if (isAutomatic)  //  Checking voucher number generation is automatic or not
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtInvoiceNumber.Text; //For Manual mode
                }
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                infoLedgerPosting.LedgerId = decLedgerId;
                infoLedgerPosting.Credit = decCredit;
                infoLedgerPosting.Debit = decDebit;
                BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 03: " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form to make new service voucher
        /// </summary>
        public void Clear()
        {
            try
            {
                /*Automatic invoice number generation*/
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                VoucherDate();
                if (isAutomatic)    //  Checking voucher number generation is automatic or not
                {
                    ServicesBll BllService = new ServicesBll();
                    ContraVoucherDetailsBll bllContraVoucherDetails = new ContraVoucherDetailsBll();
                    if (strVoucherNo == string.Empty)
                    {
                        strVoucherNo = "0";
                    }
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(DecServicetVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                    if (Convert.ToDecimal(strVoucherNo) != (BllService.ServiceMasterGetMax(DecServicetVoucherTypeId)) + 1)
                    {
                        strVoucherNo = BllService.ServiceMasterGetMax(DecServicetVoucherTypeId).ToString();
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(DecServicetVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                        if (BllService.ServiceMasterGetMax(DecServicetVoucherTypeId) == 0)
                        {
                            strVoucherNo = "0";
                            strVoucherNo = obj.VoucherNumberAutomaicGeneration(DecServicetVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                        }
                    }
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecServicetVoucherTypeId, dtpVoucherDate.Value);   //  Getting suffix-prefix settings
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decServiceSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;    // Generating invoice number with suffix and prefix
                    txtInvoiceNumber.Text = strInvoiceNo;
                    txtInvoiceNumber.ReadOnly = true;
                    txtVoucherDate.Select();
                }
                else
                {
                    txtInvoiceNumber.Text = string.Empty;
                    txtInvoiceNumber.ReadOnly = false;
                }
                ServiceAcoountComboFill();
                GridParticularComboFill();
                SalesmanComboFill();
                CashOrPartyComboFill();
                isEditMode = false;
                txtDiscount.Text = "0";
                txtTotalAmount.Text = "0";
                txtGrandTotal.Text = "0";
                txtCreditPeriod.Text = "0";
                txtCustomer.Text = string.Empty;
                txtNarration.Text = string.Empty;
                PrintCheck();
                int inCount = dgvServiceVoucher.RowCount;
                for (int i = 0; i < inCount; i++)
                {
                    dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value = null;
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value = null;
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value = null;
                }
                dgvServiceVoucher.ClearSelection();
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                dgvServiceVoucher.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 04 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to set the voucherdate
        /// </summary>
        public void VoucherDate()
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
                MessageBox.Show("SV 05 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the salesman combobox
        /// </summary>
        public void SalesmanComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                TransactionsGeneralFillBll TransactiongeneralFillObj = new TransactionsGeneralFillBll();
                listObj = TransactiongeneralFillObj.SalesmanViewAllForComboFill(cmbSalesman, false);
                cmbSalesman.DataSource = listObj[0];
                cmbSalesman.DisplayMember = "employeeName";
                cmbSalesman.ValueMember = "employeeId";
                cmbSalesman.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 06 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the service account combo box
        /// </summary>
        public void ServiceAcoountComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                ListObj = bllAccountLedger.AccountLedgerSearchForServiceAccountUnderIncome();
                cmbServiceAC.DataSource = ListObj[0];
                cmbServiceAC.DisplayMember = "ledgerName";
                cmbServiceAC.ValueMember = "ledgerId";
                cmbServiceAC.SelectedText = "Service Account";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 07 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the CashOrParty combo box
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashParty, false);
                cmbCashParty.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 08 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerForm(decimal decId)
        {
            try
            {
                CashOrPartyComboFill();
                if (decId.ToString() != "0")
                {
                    cmbCashParty.SelectedValue = decId;
                }
                else if (strCashOrPartyName != string.Empty)
                {
                    cmbCashParty.SelectedValue = strCashOrPartyName;
                }
                else
                {
                    cmbCashParty.SelectedIndex = -1;
                }
                this.Enabled = true;
                this.BringToFront();
                cmbCashParty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 09 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the perticular combobox in grid
        /// </summary>
        public void GridParticularComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ServicesBll BllService = new ServicesBll();
                listObj = BllService.ServiceViewAll();
                dgvcmbParticulars.DataSource = listObj[0];
                dgvcmbParticulars.DisplayMember = "serviceName";
                dgvcmbParticulars.ValueMember = "serviceId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 10 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                List<DataTable> listObjCurrency = new List<DataTable>();
                DateTime dtDate = Convert.ToDateTime(dtpVoucherDate.Value);
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                listObjCurrency = TransactionGeneralFillObj.CurrencyComboByDate(dtDate);
                cmbCurrency.DataSource = listObjCurrency[0];
                cmbCurrency.DisplayMember = "currencyName";
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.SelectedValue = 1m;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 11 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking "TickPrintAfterSave" is set TRUE or FALSE
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
                MessageBox.Show("SV 12 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decServiceVoucherTypeId"></param>
        /// <param name="strServiceVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decServiceVoucherTypeId, string strServiceVoucherTypeName) //  Invoked from frmVoucherTypeSelection form
        {
            try
            {
                DecServicetVoucherTypeId = decServiceVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(DecServicetVoucherTypeId);    //  Checking voucher number is automatic or not
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecServicetVoucherTypeId, dtpVoucherDate.Value);
                decServiceSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strServiceVoucherTypeName;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 13 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSerach(frmVoucherSearch frm, decimal decId)
        {
            try
            {

                base.Show();
                objVoucherSearch = frm;
                decMasterId = decId;
                btnDelete.Enabled = true;
                FillFunction();
                btnSave.Text = "Update";
                isEditMode = true;
                if (!txtVoucherDate.ReadOnly)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 14 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmLedgerPopup form to select and view Ledger
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId, string strComboType) //   Ledger pop up
        {
            try
            {
                this.frmLedgerPopupObj = frmLedgerPopup;
                if (strComboType == "ServiceAccount")
                {
                    ServiceAcoountComboFill();
                    cmbServiceAC.SelectedValue = decId;
                    cmbServiceAC.Focus();
                }
                else if (strComboType == "CashOrSundryCreditors")
                {
                    CashOrPartyComboFill();
                    cmbCashParty.SelectedValue = decId;
                    cmbCashParty.Focus();
                }
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 15 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to select and view Employee
        /// </summary>
        /// <param name="frmEmployeePopup"></param>
        /// <param name="decId"></param>
        public void CallEmployeePopup(frmEmployeePopup frmEmployeePopup, decimal decId) //  Employee pop up form
        {
            try
            {
                this.Enabled = true;
                this.frmEmployeePopupObj = frmEmployeePopup;
                SalesmanComboFill();
                cmbSalesman.SelectedValue = decId;
                cmbSalesman.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 16 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate grand total
        /// </summary>
        public void AmountCalculation()
        {
            try
            {
                decimal decTotalAmount = 0;
                decimal decGrandTotal = 0;
                decimal decDiscount = 0;
                foreach (DataGridViewRow dgvrow in dgvServiceVoucher.Rows)
                {
                    if (dgvrow.Cells["dgvtxtAmount"].Value != null)
                    {
                        if (dgvrow.Cells["dgvtxtAmount"].Value.ToString() != "")
                        {
                            decTotalAmount = decTotalAmount + decimal.Parse(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                        }
                    }
                }
                decTotalAmount = Math.Round(decTotalAmount, PublicVariables._inNoOfDecimalPlaces);
                txtTotalAmount.Text = decTotalAmount.ToString();
                if (txtDiscount.Text != string.Empty)
                {
                    decDiscount = Convert.ToDecimal(txtDiscount.Text.ToString());
                }
                decGrandTotal = decTotalAmount - decDiscount;
                txtGrandTotal.Text = decGrandTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 17 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for ledgerposting
        /// </summary>
        /// <param name="decid"></param>
        /// <param name="decCredit"></param>
        /// <param name="decDebit"></param>
        /// <param name="decDetailsId"></param>
        /// <param name="strVoucherNos"></param>
        public void LedgerPosting(decimal decid, decimal decCredit, decimal decDebit, decimal decDetailsId, string strVoucherNos)
        {
            try
            {
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.VoucherTypeId = DecServicetVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = strVoucherNos;
                }
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                infoLedgerPosting.LedgerId = decid;
                infoLedgerPosting.DetailsId = decDetailsId;
                infoLedgerPosting.Debit = Convert.ToDecimal(txtGrandTotal.Text.ToString());
                infoLedgerPosting.Credit = 0;
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtInvoiceNumber.Text;       //For Manual mode
                }
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;  // get credit the net amount  to tally both cr and dr
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.VoucherTypeId = DecServicetVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = strVoucherNos;
                }
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtInvoiceNumber.Text;       //For Manual mode
                }
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbServiceAC.SelectedValue.ToString());
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = Convert.ToDecimal(txtTotalAmount.Text.ToString());
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = decDetailsId; ;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(txtDiscount.Text.Trim().ToString());
                if (decBillDis > 0)
                {
                    infoLedgerPosting.Debit = decBillDis;   // here get debit the bill discount to tally both cr and dr
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                    infoLedgerPosting.VoucherTypeId = DecServicetVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                    infoLedgerPosting.LedgerId = 8;  //  here want to get discount ledgerId (now not available) so temp 'm using
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.DetailsId = decDetailsId;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 18 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save the service voucher
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                ServiceMasterInfo infoServiceMaster = new ServiceMasterInfo();
                ServiceDetailsInfo infoServiceDetails = new ServiceDetailsInfo();
                ServicesBll BllService = new ServicesBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                int inRowCount = dgvServiceVoucher.RowCount;
                int inValue = 0;
                for (int ini = 0; ini < inRowCount - 1; ini++)
                {
                    if (dgvServiceVoucher.Rows[ini].Cells["dgvcmbParticulars"].Value != null && dgvServiceVoucher.Rows[ini].Cells["dgvcmbParticulars"].Value.ToString() != string.Empty)
                    {
                        inValue++;
                    }
                }
                if (inValue > 0)
                {
                    txtDiscount.Enabled = true;
                    infoServiceMaster.InvoiceNo = txtInvoiceNumber.Text;
                    if (isAutomatic)
                    {
                        infoServiceMaster.VoucherNo = strVoucherNo;
                    }
                    else
                    {
                        infoServiceMaster.VoucherNo = Convert.ToString(BllService.ServiceMasterGetMax(DecServicetVoucherTypeId) + 1);
                    }
                    infoServiceMaster.SuffixPrefixId = decServiceSuffixPrefixId;
                    infoServiceMaster.Date = Convert.ToDateTime(txtVoucherDate.Text);
                    infoServiceMaster.LedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                    infoServiceMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    infoServiceMaster.Narration = txtNarration.Text.Trim();
                    infoServiceMaster.UserId = PublicVariables._decCurrentUserId;
                    infoServiceMaster.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text);
                    infoServiceMaster.ServiceAccount = Convert.ToDecimal(cmbServiceAC.SelectedValue.ToString());
                    decimal decExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());//spExchangeRate.GetExchangeRateByCurrencyId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    infoServiceMaster.ExchangeRateId = decExchangeRateId;
                    infoServiceMaster.EmployeeId = Convert.ToDecimal(cmbSalesman.SelectedValue.ToString());
                    infoServiceMaster.Customer = txtCustomer.Text.Trim();
                    infoServiceMaster.Discount = Convert.ToDecimal(txtDiscount.Text.Trim());
                    infoServiceMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                    infoServiceMaster.VoucherTypeId = DecServicetVoucherTypeId;
                    infoServiceMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoServiceMaster.ExtraDate = PublicVariables._dtCurrentDate;
                    infoServiceMaster.Extra1 = string.Empty;
                    infoServiceMaster.Extra2 = string.Empty;
                    decServiceMasterId = BllService.ServiceMasterAddReturnWithIdentity(infoServiceMaster);
                    infoServiceDetails.ServiceMasterId = decServiceMasterId;
                    infoServiceDetails.Extra1 = string.Empty;
                    infoServiceDetails.Extra2 = string.Empty;
                    infoServiceDetails.ExtraDate = PublicVariables._dtCurrentDate;
                    for (int i = 0; i < inRowCount - 1; i++)
                    {
                        if (dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.ServiceId = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value.ToString());
                        }
                        if (dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.Measure = dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value.ToString();
                        }
                        if (dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.Amount = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value.ToString());
                            decAmount += Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value);
                        }
                        decServiceDetailsId = BllService.ServiceDetailsAddReturnWithIdentity(infoServiceDetails);
                    }
                    decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(infoServiceMaster.ExchangeRateId);
                    decConvertRate = decAmount * decSelectedCurrencyRate;
                    decCredit = 0;
                    decDebit = decConvertRate;
                    decLedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                    LedgerPosting(decLedgerId, decCredit, decDebit, decServiceDetailsId, infoServiceMaster.VoucherNo);
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    decimal decI = Convert.ToDecimal(bllAccountLedger.AccountGroupIdCheck(cmbCashParty.Text));
                    if (decI > 0)
                    {
                        PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                        PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                        infoPartyBalance.Date = Convert.ToDateTime(txtVoucherDate.Text);
                        infoPartyBalance.LedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                        infoPartyBalance.VoucherTypeId = DecServicetVoucherTypeId;
                        infoPartyBalance.VoucherNo = strVoucherNo;
                        infoPartyBalance.AgainstVoucherTypeId = 0;
                        infoPartyBalance.AgainstVoucherNo = "0";
                        infoPartyBalance.InvoiceNo = strInvoiceNo;
                        infoPartyBalance.AgainstInvoiceNo = "0";
                        infoPartyBalance.ReferenceType = "New";
                        infoPartyBalance.Debit = decAmount;
                        infoPartyBalance.Credit = 0;
                        infoPartyBalance.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text);
                        infoPartyBalance.ExchangeRateId = decExchangeRateId;
                        infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoPartyBalance.Extra1 = string.Empty;
                        infoPartyBalance.Extra2 = string.Empty;
                        BllPartyBalance.PartyBalanceAdd(infoPartyBalance);
                    }
                    Messages.SavedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decServiceMasterId);
                        }
                        else
                        {
                            Print(decServiceMasterId, infoServiceMaster.ExchangeRateId);
                        }
                    }
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Can't save Service Voucher without atleast one ledger with complete details");
                    dgvServiceVoucher.ClearSelection();
                    dgvServiceVoucher.CurrentCell = dgvServiceVoucher.Rows[0].Cells["dgvcmbParticulars"];
                    dgvServiceVoucher.Rows[0].Cells["dgvcmbParticulars"].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 19 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save or edit function  
        /// </summary>
        public void SaveOrEditFuction()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                if (txtDiscount.Text.Trim() == string.Empty)
                {
                    txtDiscount.Text = "0";
                }
                if (txtInvoiceNumber.Text == string.Empty)
                {
                    Messages.InformationMessage("Enter invoice number");
                    txtInvoiceNumber.Focus();
                }
                else if (cmbCashParty.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select cash or party's account");
                    cmbCashParty.Focus();
                }
                else if (cmbServiceAC.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select service");
                    cmbServiceAC.Focus();
                }
                else if (cmbSalesman.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select salesman");
                    cmbSalesman.Focus();
                }
                else if (cmbCurrency.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select currency");
                    cmbCurrency.Focus();
                }
                else if (Convert.ToDecimal(txtDiscount.Text.Trim()) > Convert.ToDecimal(txtTotalAmount.Text.Trim()))
                {
                    Messages.InformationMessage("Discount is greater than total amount");
                    txtDiscount.Focus();
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (dtpVoucherDate.Value.ToString() != string.Empty)
                        {
                            if (!isEditMode)
                            {
                                if (PublicVariables.isMessageAdd)
                                {
                                    if (Messages.SaveMessage())
                                    {
                                        if (!isAutomatic)
                                        {
                                            strInvoiceNo = txtInvoiceNumber.Text;
                                            if (!BllService.ServiceVoucherCheckExistence(strInvoiceNo, DecServicetVoucherTypeId, 0))
                                            {
                                                SaveFunction();
                                            }
                                            else
                                            {
                                                Messages.InformationMessage("Invoice number already exist");
                                            }
                                        }
                                        else
                                        {
                                            SaveFunction();
                                        }
                                    }
                                }
                                else
                                {
                                    if (!isAutomatic)
                                    {
                                        if (!BllService.ServiceVoucherCheckExistence(strVoucherNo, DecServicetVoucherTypeId, 0))
                                        {
                                            SaveFunction();
                                        }
                                        else
                                        {
                                            Messages.InformationMessage("Invoice number already exist");
                                        }
                                    }
                                    else
                                    {
                                        SaveFunction();
                                    }
                                }
                            }
                            else if (isEditMode)
                            {
                                if (PublicVariables.isMessageEdit)
                                {
                                    if (Messages.UpdateMessage())
                                    {
                                        if (!isAutomatic)
                                        {
                                            if (!BllService.ServiceVoucherCheckExistence(strVoucherNo, DecServicetVoucherTypeId, decServiceMasterId))
                                            {
                                                EditFunction(decServiceMasterId);
                                            }
                                            else
                                            {
                                                Messages.InformationMessage("Invoice number already exist");
                                            }
                                        }
                                        else
                                        {
                                            EditFunction(decServiceMasterId);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!isAutomatic)
                                    {
                                        if (!BllService.ServiceVoucherCheckExistence(strVoucherNo, DecServicetVoucherTypeId, decServiceMasterId))
                                        {
                                            EditFunction(decServiceMasterId);
                                        }
                                        else
                                        {
                                            Messages.InformationMessage("Invoice number already exist");
                                        }
                                    }
                                    else
                                    {
                                        EditFunction(decServiceMasterId);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 20 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove incomplete row from grid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvServiceVoucher.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvServiceVoucher.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgvtxtCheck"].Value != null && dgvrowCur.Cells["dgvtxtCheck"].Value.ToString() == "x")
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
                    if (MessageBox.Show(strMessage, "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvServiceVoucher.Rows.Count; inK++)
                        {
                            if (dgvServiceVoucher.Rows[inK].Cells["dgvtxtCheck"].Value != null && dgvServiceVoucher.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "x")
                            {
                                if (!dgvServiceVoucher.Rows[inK].IsNewRow)
                                {
                                    dgvServiceVoucher.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                            AmountCalculation();
                            SerialNo();
                        }
                    }
                    else
                    {
                        dgvServiceVoucher.Rows[inForFirst].Cells["dgvcmbParticulars"].Selected = true;
                        dgvServiceVoucher.CurrentCell = dgvServiceVoucher.Rows[inForFirst].Cells["dgvcmbParticulars"];
                        dgvServiceVoucher.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 21 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to check column missing
        /// </summary>
        /// <param name="e"></param>
        public void CheckColumnMissing(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvServiceVoucher.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].FormattedValue == null || dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].FormattedValue.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.HeaderCell.Value = "X";
                            dgvServiceVoucher.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvServiceVoucher["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (dgvServiceVoucher.CurrentRow.Cells["dgvtxtMeasure"].Value == null || dgvServiceVoucher.CurrentRow.Cells["dgvtxtMeasure"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.HeaderCell.Value = "X";
                            dgvServiceVoucher.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvServiceVoucher["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (dgvServiceVoucher.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvServiceVoucher.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.HeaderCell.Value = "X";
                            dgvServiceVoucher.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvServiceVoucher["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.HeaderCell.Value = "";
                            isValueChanged = true;
                            dgvServiceVoucher.CurrentRow.Cells["dgvtxtCheck"].Value = null;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 22 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to delete service voucher
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        public void DeleteFunction(decimal decServiceMasterId)
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                BllService.ServiceVoucherDelete(decPartyBalanceId, DecServicetVoucherTypeId, strVoucherNo, decServiceMasterId);
                Messages.DeletedMessage();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 23 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit the service voucher
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        public void EditFunction(decimal decServiceMasterId)
        {
            try
            {
                ServiceMasterInfo infoServiceMaster = new ServiceMasterInfo();
                ServiceDetailsInfo infoServiceDetails = new ServiceDetailsInfo();
                ServicesBll BllService = new ServicesBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                int inRowCount = dgvServiceVoucher.RowCount;
                int inValue = 0;
                decimal decLedgerPostingId1 = 0;
                decimal decLedgerPostingId2 = 0;
                List<DataTable> listObjLedgerPostingId = new List<DataTable>();
                listObjLedgerPostingId = BllService.LedgerPostingIdByServiceMaasterId(decServiceMasterId);
                decLedgerPostingId1 = Convert.ToDecimal(listObjLedgerPostingId[0].Rows[0]["ledgerPostingId"].ToString());
                decLedgerPostingId2 = Convert.ToDecimal(listObjLedgerPostingId[0].Rows[1]["ledgerPostingId"].ToString());
                for (int ini = 0; ini < inRowCount - 1; ini++)
                {
                    if (dgvServiceVoucher.Rows[ini].Cells["dgvcmbParticulars"].Value != null && dgvServiceVoucher.Rows[ini].Cells["dgvcmbParticulars"].Value.ToString() != string.Empty)
                    {
                        inValue++;
                    }
                }
                if (inValue > 0)
                {
                    infoServiceMaster.ServiceMasterId = decServiceMasterId;
                    infoServiceMaster.SuffixPrefixId = decServiceSuffixPrefixId;
                    infoServiceMaster.Date = Convert.ToDateTime(txtVoucherDate.Text);
                    infoServiceMaster.LedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                    infoServiceMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    infoServiceMaster.Narration = txtNarration.Text.Trim();
                    infoServiceMaster.UserId = PublicVariables._decCurrentUserId;
                    infoServiceMaster.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text);
                    infoServiceMaster.ServiceAccount = Convert.ToDecimal(cmbServiceAC.SelectedValue.ToString());
                    decimal decExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());//spExchangeRate.GetExchangeRateByCurrencyId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    infoServiceMaster.ExchangeRateId = decExchangeRateId;
                    infoServiceMaster.EmployeeId = Convert.ToDecimal(cmbSalesman.SelectedValue.ToString());
                    infoServiceMaster.Customer = txtCustomer.Text.Trim();
                    infoServiceMaster.Discount = Convert.ToDecimal(txtDiscount.Text);
                    infoServiceMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                    infoServiceMaster.VoucherTypeId = DecServicetVoucherTypeId;
                    infoServiceMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoServiceMaster.ExtraDate = PublicVariables._dtCurrentDate;
                    infoServiceMaster.Extra1 = string.Empty;
                    infoServiceMaster.Extra2 = string.Empty;
                    //------------------deleting removed rows----------------------------------------//
                    BankReconciliationBll BllBankReconciliation = new BankReconciliationBll();
                    foreach (object obj in strArrOfRemove)
                    {
                        string str = Convert.ToString(obj);
                        BllService.ServiceDetailsDelete(Convert.ToDecimal(str));
                    }
                    BllService.ServiceMasterEdit(infoServiceMaster);
                    infoServiceDetails.ServiceMasterId = decServiceMasterId;
                    infoServiceDetails.Extra1 = string.Empty;
                    infoServiceDetails.Extra2 = string.Empty;
                    infoServiceDetails.ExtraDate = PublicVariables._dtCurrentDate;
                    for (int i = 0; i < inRowCount - 1; i++)
                    {
                        if (dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.ServiceId = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value.ToString());
                        }
                        if (dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.Measure = dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value.ToString();
                        }
                        if (dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            infoServiceDetails.Amount = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value.ToString());
                            if (dgvServiceVoucher.Rows[i].Cells["dgvtxtDetailsId"].Value != null && dgvServiceVoucher.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                            {
                                infoServiceDetails.ServiceDetailsId = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString());
                                infoServiceDetails.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                                BllService.ServiceDetailsEdit(infoServiceDetails);
                            }
                            else
                            {
                                infoServiceDetails.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                                decServiceDetailsId = BllService.ServiceDetailsAddReturnWithIdentity(infoServiceDetails);
                            }
                            decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decAmount = Convert.ToDecimal(dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value);
                            decConvertRate += decAmount * decSelectedCurrencyRate;
                        }
                    }
                    decCredit = 0;
                    decDebit = decConvertRate;
                    decLedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                    LedgerPostingEdit(decLedgerPostingId1, decLedgerId, decCredit, decDebit);
                    decCredit = decConvertRate;
                    decDebit = 0;
                    decLedgerId = Convert.ToDecimal(cmbServiceAC.SelectedValue.ToString());
                    LedgerPostingEdit(decLedgerPostingId2, decLedgerId, decCredit, decDebit);
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    decimal decI = Convert.ToDecimal(bllAccountLedger.AccountGroupIdCheck(cmbCashParty.Text));
                    if (decI > 0)
                    {
                        PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                        PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                        infoPartyBalance.PartyBalanceId = decPartyBalanceId;
                        infoPartyBalance.Date = Convert.ToDateTime(txtVoucherDate.Text);
                        infoPartyBalance.LedgerId = Convert.ToDecimal(cmbCashParty.SelectedValue.ToString());
                        infoPartyBalance.VoucherTypeId = DecServicetVoucherTypeId;
                        infoPartyBalance.VoucherNo = strVoucherNo;
                        infoPartyBalance.AgainstVoucherTypeId = 0;
                        infoPartyBalance.AgainstVoucherNo = "0";
                        infoPartyBalance.InvoiceNo = strInvoiceNo;
                        infoPartyBalance.AgainstInvoiceNo = "0";
                        infoPartyBalance.ReferenceType = "New";
                        infoPartyBalance.Debit = decAmount;
                        infoPartyBalance.Credit = 0;
                        infoPartyBalance.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text);
                        infoPartyBalance.ExchangeRateId = decExchangeRateId;
                        infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoPartyBalance.Extra1 = string.Empty;
                        infoPartyBalance.Extra2 = string.Empty;
                        BllPartyBalance.PartyBalanceEdit(infoPartyBalance);
                    }
                    Messages.UpdatedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decServiceMasterId);
                        }
                        else
                        {
                            Print(decServiceMasterId, infoServiceMaster.ExchangeRateId);
                        }
                    }
                    this.Close();
                    if (frmServiceVoucherRegisterObj != null)
                    {
                        frmServiceVoucherRegisterObj.Show();
                        frmServiceVoucherRegisterObj.GridFill();
                    }
                    else if (frmServiceReportObj != null)
                    {
                        frmServiceReportObj.Show();
                        frmServiceReportObj.GridFill();
                    }
                }
                else
                {
                    Messages.InformationMessage("Can't save Service Voucher without atleast one ledger with complete details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 24 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Print(decimal decServiceMasterId, decimal decExchangeRateId)
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                DataSet dsServiceVoucher = BllService.ServiceVoucherPrinting(decServiceMasterId, 1, decExchangeRateId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.ServiceVoucherPrinting(dsServiceVoucher);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 25 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PrintForDotMatrix(decimal decServiceMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreation.CompanyViewForDotMatrix();
                //-------------Grid Details-------------------\\
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("Particulars");
                dtblGridDetails.Columns.Add("Measure");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvServiceVoucher.Rows)
                {
                    if (dRow.HeaderCell.Value != null && dRow.HeaderCell.Value.ToString() != "X")
                    {
                        if (!dRow.IsNewRow)
                        {
                            DataRow dr = dtblGridDetails.NewRow();
                            dr["SlNo"] = ++inRowCount;
                            dr["Particulars"] = dRow.Cells["dgvcmbParticulars"].FormattedValue.ToString();
                            dr["Amount"] = dRow.Cells["dgvtxtAmount"].Value.ToString();
                            dr["Measure"] = dRow.Cells["dgvtxtMeasure"].FormattedValue.ToString();
                            dtblGridDetails.Rows.Add(dr);
                        }
                    }
                }
                //-------------Other Details-------------------\\
                dtblOtherDetails.Columns.Add("InvoiceNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("CashOrParty");
                dtblOtherDetails.Columns.Add("CreditPeriod");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("CustomerName");
                dtblOtherDetails.Columns.Add("totalAmount");
                dtblOtherDetails.Columns.Add("DiscountAmount");
                dtblOtherDetails.Columns.Add("GrandTotal");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["InvoiceNo"] = txtInvoiceNumber.Text;
                dRowOther["date"] = txtVoucherDate.Text;
                dRowOther["CashOrParty"] = cmbCashParty.Text;
                dRowOther["CreditPeriod"] = txtCreditPeriod.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["SalesMan"] = cmbSalesman.Text;
                dRowOther["CustomerName"] = txtCustomer.Text;
                dRowOther["totalAmount"] = txtTotalAmount.Text;
                dRowOther["DiscountAmount"] = txtDiscount.Text;
                dRowOther["GrandTotal"] = txtGrandTotal.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtGrandTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(DecServicetVoucherTypeId);
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
                MessageBox.Show("SV 26 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to close the form
        /// </summary>
        public void FormClose()
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
                MessageBox.Show("SV 27 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="txt"></param>
        ///// <param name="dtp"></param>
        //public void dtpCloseUpEventFunction(TextBox txt, DateTimePicker dtp)
        //{
        //    try
        //    {
        //        txt.Text = dtp.Value.ToString("dd-MMM-yyyy");
        //        txt.Focus();
        //        txt.SelectionStart = 0;
        //        txt.SelectionLength = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("SV 31 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        /// <summary>
        /// date validation function
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="dtp"></param>
        public void DateValidation(TextBox txt, DateTimePicker dtp)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txt);
                if (txt.Text == String.Empty)
                {
                    txt.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtp.Value = DateTime.Parse(txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 28 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the ServiceVoucher register
        /// </summary>
        /// <param name="frmServiceVoucherRegister"></param>
        /// <param name="decId"></param>
        /// <param name="decVoucherNoFromRegister"></param>
        public void CallFromServiceVoucherRegister(frmServiceVoucherRegister frmServiceVoucherRegister, decimal decId, decimal decVoucherNoFromRegister)
        {
            try
            {
                base.Show();
                txtVoucherDate.Select();
                this.frmServiceVoucherRegisterObj = frmServiceVoucherRegister;
                frmServiceVoucherRegister.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                decimal decVoucherNos = 0;
                decVoucherNos = decVoucherNoFromRegister;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 29 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the ServiceVoucher report
        /// </summary>
        /// <param name="frmServiceReport"></param>
        /// <param name="decId"></param>
        /// <param name="decVoucherNoFromReport"></param>
        public void CallFromServiceReport(frmServiceReport frmServiceReport, decimal decId, decimal decVoucherNoFromReport)
        {
            try
            {
                base.Show();
                txtVoucherDate.Select();
                this.frmServiceReportObj = frmServiceReport;
                frmServiceReportObj.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 30 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the fields for edit or delete
        /// </summary>
        public void FillFunction()
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                //ServiceMasterSP spServiceMaster = new ServiceMasterSP();
                ServiceMasterInfo infoServiceMaster = new ServiceMasterInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                decServiceMasterId = decMasterId;
                infoServiceMaster = BllService.ServiceMasterView(decServiceMasterId);
                infoVoucherType = BllVoucherType.VoucherTypeView(infoServiceMaster.VoucherTypeId);
                this.Text = infoVoucherType.VoucherTypeName;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(infoServiceMaster.VoucherTypeId);
                txtInvoiceNumber.ReadOnly = true;
                strVoucherNo = infoServiceMaster.VoucherNo.ToString();
                txtInvoiceNumber.Text = infoServiceMaster.InvoiceNo;
                txtCreditPeriod.Text = infoServiceMaster.CreditPeriod.ToString();
                strInvoiceNo = infoServiceMaster.InvoiceNo.ToString();
                decServiceSuffixPrefixId = Convert.ToDecimal(infoServiceMaster.SuffixPrefixId.ToString());
                DecServicetVoucherTypeId = Convert.ToDecimal(infoServiceMaster.VoucherTypeId.ToString());
                int inDecimalPlace = PublicVariables._inNoOfDecimalPlaces;
                txtVoucherDate.Text = infoServiceMaster.Date.ToString("dd-MMM-yyyy");
                dtpVoucherDate.Value = Convert.ToDateTime(infoServiceMaster.Date);
                cmbCashParty.SelectedValue = infoServiceMaster.LedgerId;
                cmbServiceAC.SelectedValue = infoServiceMaster.ServiceAccount;
                cmbSalesman.SelectedValue = infoServiceMaster.EmployeeId;
                txtCustomer.Text = infoServiceMaster.Customer;
                txtNarration.Text = infoServiceMaster.Narration;
                List<DataTable> listObjServiceDetails = new List<DataTable>();
                listObjServiceDetails = BllService.ServiceDetailsViewWithMasterId(decServiceMasterId);
                for (int i = 0; i < listObjServiceDetails[0].Rows.Count; i++)
                {
                    dgvServiceVoucher.Rows.Add();
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtDetailsId"].Value = Convert.ToDecimal(listObjServiceDetails[0].Rows[i]["serviceDetailsId"].ToString());
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtServiceMasterId"].Value = Convert.ToDecimal(listObjServiceDetails[0].Rows[i]["serviceMasterId"].ToString());
                    dgvServiceVoucher.Rows[i].Cells["dgvcmbParticulars"].Value = Convert.ToDecimal(listObjServiceDetails[0].Rows[i]["serviceId"].ToString());
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtMeasure"].Value = listObjServiceDetails[0].Rows[i]["measure"].ToString();
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtAmount"].Value = listObjServiceDetails[0].Rows[i]["amount"].ToString();
                    decimal decDetailsId1 = Convert.ToDecimal(listObjServiceDetails[0].Rows[i]["serviceDetailsId"].ToString());
                    decimal decLedgerPostingId = BllLedgerPosting.LedgerPostingIdFromDetailsId(decDetailsId1, strVoucherNo, DecServicetVoucherTypeId);
                    dgvServiceVoucher.Rows[i].Cells["dgvtxtLedgerPostingId"].Value = decLedgerPostingId.ToString();
                }
                cmbCurrency.SelectedValue = infoServiceMaster.ExchangeRateId;
                txtTotalAmount.Text = infoServiceMaster.TotalAmount.ToString();
                txtDiscount.Text = infoServiceMaster.Discount.ToString();
                txtGrandTotal.Text = infoServiceMaster.GrandTotal.ToString();
                infoPartyBalance = BllPartyBalance.PartyBalanceViewByVoucherNoAndVoucherTypeId(DecServicetVoucherTypeId, strVoucherNo, infoServiceMaster.Date);
                decPartyBalanceId = infoPartyBalance.PartyBalanceId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 32 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromServiceFormForGridCombo(decimal decId)
        {
            try
            {
                GridParticularComboFill();
                if (decId.ToString() != "0")
                {
                    dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].Value = decId;
                }
                else if (strParticular != string.Empty)
                {
                    dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].Value = strParticular;
                }
                this.Enabled = true;
                GridParticularComboFill();
                dgvServiceVoucher.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 33 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from DayBook
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decId)
        {
            try
            {
                base.Show();
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                txtVoucherDate.Select();
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV34 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the form while calling from Ageing report
        /// </summary>
        /// <param name="frmAgeing"></param>
        /// <param name="decId"></param>
        public void callFromAgeing(frmAgeingReport frmAgeing, decimal decId)
        {
            try
            {
                base.Show();
                frmAgeing.Enabled = false;
                this.frmAgeingObj = frmAgeing;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                txtVoucherDate.Select();
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV35 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerDetails to view details and for updation
        /// </summary>
        /// <param name="ledgerDetailsObj"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails ledgerDetailsObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmLedgerDetailsObj = ledgerDetailsObj;
                frmLedgerDetailsObj.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isEditMode = true;
                txtVoucherDate.Select();
                this.decMasterId = decMasterId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV36 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On remove linkbutton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int inRowCount = dgvServiceVoucher.RowCount;
                if (inRowCount > 1 && !dgvServiceVoucher.CurrentRow.IsNewRow)
                {
                    if (dgvServiceVoucher.CurrentRow.Cells["dgvtxtDetailsId"].Value != null && dgvServiceVoucher.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                    {
                        strArrOfRemove.Add(dgvServiceVoucher.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString());
                        strArrayOfRemovedLedgerPostingId.Add(dgvServiceVoucher.CurrentRow.Cells["dgvtxtLedgerPostingId"].Value.ToString());
                        inArrOfRemoveIndex++;
                        dgvServiceVoucher.Rows.RemoveAt(dgvServiceVoucher.CurrentRow.Index);
                    }
                    else if (dgvServiceVoucher.RowCount > 1)
                    {
                        if (!dgvServiceVoucher.CurrentRow.IsNewRow)
                        {
                            if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dgvServiceVoucher.Rows.RemoveAt(dgvServiceVoucher.CurrentRow.Index);
                            }
                        }
                    }
                    SerialNo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 37 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SV 38 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut keys
        /// Esc for form close
        /// ctrl+s for save
        /// ctrl+d for delete
        /// Alt+c for ledger creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FormClose();
                }
                else if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save Ctrl + S
                {
                    if (cmbCashParty.Focused || cmbServiceAC.Focused || cmbSalesman.Focused)
                    {
                        cmbCashParty.DropDownStyle = ComboBoxStyle.DropDown;
                        cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDown;
                        cmbSalesman.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbCashParty.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    cmbCashParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
                    if (dgvServiceVoucher.Columns["dgvcmbParticulars"].Selected)
                    {
                        btnSave.Focus();
                        dgvServiceVoucher.Focus();
                    }
                    btnSave.Focus();
                    btnSave_Click(sender, e);
                }
                if (dgvServiceVoucher.CurrentRow != null)
                {
                    if (dgvServiceVoucher.CurrentCell.ColumnIndex == dgvServiceVoucher.Columns["dgvcmbParticulars"].Index)
                    {
                        if (dgvServiceVoucher.CurrentCell == dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"])
                        {
                            if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)//Ledger creation
                            {
                                //SendKeys.Send("{F10}");
                                if (dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].Value != null)
                                {
                                    strParticular = dgvServiceVoucher.CurrentRow.Cells["dgvcmbParticulars"].Value.ToString();
                                }
                                else
                                {
                                    strParticular = string.Empty;
                                }
                                frmServices frmServicesObj = new frmServices();
                                frmServicesObj.MdiParent = formMDI.MDIObj;
                                frmServicesObj.CallFromServiceVoucher(this);
                            }
                        }
                    }
                }
                //-----------------------CTRL+D Delete-----------------------------//
                if (btnDelete.Enabled)
                {
                    if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                    {
                        if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                        {
                            if (cmbCashParty.Focused || cmbServiceAC.Focused || cmbSalesman.Focused)
                            {
                                cmbCashParty.DropDownStyle = ComboBoxStyle.DropDown;
                                cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDown;
                                cmbSalesman.DropDownStyle = ComboBoxStyle.DropDown;
                            }
                            else
                            {
                                cmbCashParty.DropDownStyle = ComboBoxStyle.DropDownList;
                                cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDownList;
                                cmbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
                            }
                            cmbCashParty.DropDownStyle = ComboBoxStyle.DropDownList;
                            cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDownList;
                            cmbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
                            if (dgvServiceVoucher.Columns["dgvcmbParticulars"].Selected)
                            {
                                btnSave.Focus();
                                dgvServiceVoucher.Focus();
                            }
                            if (btnDelete.Enabled)
                            {
                                btnDelete_Click(sender, e);
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
                MessageBox.Show("SV 39 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 40: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtVoucherDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation(txtVoucherDate, dtpVoucherDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 41 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Creditperiod validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Allows to enter numbers only 
                Common CommonlObj = new Common();
                Common.NumberOnly(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 42 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To add new ledger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) //Open Account Ledger form
        {
            try
            {
                if (cmbCashParty.SelectedValue != null)
                {
                    strCashOrPartyName = cmbCashParty.SelectedValue.ToString();
                }
                else
                {
                    strCashOrPartyName = string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmAccountLedgerObj.CallFromServiceVoucher(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromServiceVoucher(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 43 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (frmServiceVoucherRegisterObj != null)
                {
                    frmServiceVoucherRegisterObj.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 44 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cellvaluechange of dgvServiceVoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucher_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ServicesBll BllService = new ServicesBll();
                ServiceInfo infoService = new ServiceInfo();
                decimal decRate = 0;
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    SerialNo();
                    if (e.ColumnIndex == dgvServiceVoucher.Columns["dgvcmbParticulars"].Index)
                    {
                        if (dgvServiceVoucher.Rows[e.RowIndex].Cells["dgvcmbParticulars"].Value != null && dgvServiceVoucher.Rows[e.RowIndex].Cells["dgvcmbParticulars"].Value.ToString() != string.Empty)
                        {
                            infoService = BllService.ServiceViewForRate(Convert.ToDecimal(dgvServiceVoucher.Rows[e.RowIndex].Cells["dgvcmbParticulars"].Value.ToString()));
                            decRate = infoService.Rate;
                            string strAmount = decRate.ToString();
                            if (strAmount != string.Empty)
                            {
                                dgvServiceVoucher.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = strAmount;
                            }
                        }
                    }
                    AmountCalculation();
                }
                CheckColumnMissing(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 45 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// validation of txtdiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 46 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On enter of txtDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtDiscount.Text) == 0)
                {
                    txtDiscount.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 47 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text == string.Empty)
                {
                    txtDiscount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 48 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveOrEditFuction();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 49 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Allows to enter numbers only in cells of grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucher_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvtxtAmount = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvtxtAmount != null)
                {
                    dgvtxtAmount.KeyPress += dgvtxtAmount_KeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 50 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (isEditMode)
                    {
                        if (PublicVariables.isMessageDelete)
                        {
                            if (Messages.DeleteMessage())
                            {
                                DeleteFunction(decMasterId);
                            }
                        }
                        else
                        {
                            DeleteFunction(decMasterId);
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
                MessageBox.Show("SV 51 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new Salesman using btnAddSalesman click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalesman.SelectedValue != null)
                {
                    strSalesman = cmbSalesman.SelectedValue.ToString();
                }
                else
                {
                    strSalesman = string.Empty;
                }
                frmSalesman frmSalesmanObj = new frmSalesman();
                frmSalesmanObj.MdiParent = formMDI.MDIObj;
                frmSalesman open = Application.OpenForms["frmSalesman"] as frmSalesman;
                if (open == null)
                {
                    frmSalesmanObj.WindowState = FormWindowState.Normal;
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmSalesmanObj.CallFromServiceVoucher(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromServiceVoucher(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 52 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpVoucherDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpVoucherDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();      
                DateTime date = this.dtpVoucherDate.Value;
                txtVoucherDate.Text = date.ToString("dd-MMM-yyyy");
                txtVoucherDate.Focus();
                CurrencyComboFill();
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    cmbCurrency.Enabled = true;
                }
                else
                {
                    cmbCurrency.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 53 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Handling dataerror
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucher_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 54 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On text change of txttotalAmount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtTotalAmount.Text) > 0)
                {
                    txtDiscount.Enabled = true;
                }
                else
                {
                    txtDiscount.Enabled = false;
                    if (Convert.ToDecimal(txtTotalAmount.Text) == 0)
                    {
                        txtDiscount.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 55 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On enter of txtCreditPeriod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtCreditPeriod.Text) == 0)
                {
                    txtCreditPeriod.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 56 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leav from txtCreditPeriod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCreditPeriod.Text == string.Empty)
                {
                    txtCreditPeriod.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 57 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On textchange of txtDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 58 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cellenter of dgvServicevoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucher_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvServiceVoucher.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvServiceVoucher.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvServiceVoucher.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 59 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmServiceReportObj != null)
                {
                    frmServiceReportObj.Enabled = true;
                    frmServiceReportObj.GridFill();
                }
                if (frmServiceVoucherRegisterObj != null)
                {
                    frmServiceVoucherRegisterObj.Enabled = true;
                    frmServiceVoucherRegisterObj.GridFill();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 60 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Amount column validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvServiceVoucher.CurrentCell != null)
                {
                    if (dgvServiceVoucher.Columns[dgvServiceVoucher.CurrentCell.ColumnIndex].Name == "dgvtxtAmount")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 61 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// measure column validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtMeasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvServiceVoucher.CurrentCell != null)
                {
                    if (dgvServiceVoucher.Columns[dgvServiceVoucher.CurrentCell.ColumnIndex].Name == "dgvtxtMeasure")
                    {
                        Common.NumberOnly(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 62 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbCashParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AccountLedgerInfo InfoAccountLedger = new AccountLedgerInfo();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                if (cmbCashParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashParty.Text != "System.Data.DataRowView")
                {
                    InfoAccountLedger = bllAccountLedger.accountLedgerviewbyId(Convert.ToDecimal(cmbCashParty.SelectedValue.ToString()));
                    txtCustomer.Text = InfoAccountLedger.LedgerName;
                    txtCreditPeriod.Text = InfoAccountLedger.CreditPeriod.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 63 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enterkey and backspace navigation of txtVoucherDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashParty.Focus();
                    cmbCashParty.SelectionLength = 0;
                    cmbCashParty.SelectionStart = cmbCashParty.Text.Length;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (!isAutomatic)
                    {
                        if (txtVoucherDate.Text == string.Empty || txtVoucherDate.SelectionStart == 0)
                        {
                            txtInvoiceNumber.SelectionStart = 0;
                            txtInvoiceNumber.SelectionLength = 0;
                            txtInvoiceNumber.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 63 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of txtInvoiceNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionLength = 0;
                    txtVoucherDate.SelectionStart = txtVoucherDate.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 64 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of cmbVoucherDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 65 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCashOrParty
        /// For shortcut keys
        /// ctrl+f for ledger popup
        /// Alt+c for ledger creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCreditPeriod.Focus();
                    txtCreditPeriod.SelectionLength = 0;
                    txtCreditPeriod.SelectionStart = txtCreditPeriod.Text.Length;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashParty.Text == string.Empty || cmbCashParty.SelectionStart == 0)
                    {
                        txtVoucherDate.Focus();
                        txtVoucherDate.SelectionStart = 0;
                        txtVoucherDate.SelectionLength = 0;
                    }
                }
                /*-------------------------------------------------Ledger pop up when Ctrl+F----------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Ledger pop up
                {
                    if (cmbCashParty.Focused)
                    {
                        cmbCashParty.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbCashParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbCashParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromServiceVoucher(this, Convert.ToDecimal(cmbCashParty.SelectedValue.ToString()), "CashOrSundryCreditors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)//Ledger creation            
                {
                    SendKeys.Send("{F10}");
                    btnAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 66 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtCreditPeriod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbServiceAC.Focus();
                    cmbServiceAC.SelectionLength = 0;
                    cmbServiceAC.SelectionStart = cmbServiceAC.Text.Length;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCreditPeriod.Text == string.Empty || txtCreditPeriod.SelectionStart == 0)
                    {
                        cmbCashParty.Focus();
                        cmbCashParty.SelectionStart = 0;
                        cmbCashParty.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 67 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbServiceAC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbServiceAC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCurrency.Focus();
                    cmbCurrency.SelectionLength = 0;
                    cmbCurrency.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbServiceAC.Text == string.Empty || cmbServiceAC.SelectionStart == 0)
                    {
                        txtCreditPeriod.Focus();
                        txtCreditPeriod.SelectionStart = 0;
                        txtCreditPeriod.SelectionLength = 0;
                    }
                }
                /*-------------------------------------------------Ledger pop up when Ctrl+F----------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbServiceAC.Focused)
                    {
                        cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbServiceAC.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbServiceAC.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromServiceVoucher(this, Convert.ToDecimal(cmbServiceAC.SelectedValue.ToString()), "ServiceAccount");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any service Account");
                    }
                }
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 68 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbSalesman
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesman_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvServiceVoucher.RowCount > 0)
                    {
                        txtCustomer.Focus();
                        txtCustomer.SelectionLength = 0;
                        txtCustomer.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesman.Text == string.Empty || cmbSalesman.SelectionStart == 0)
                    {
                        cmbCurrency.Focus();
                        cmbCurrency.SelectionStart = 0;
                        cmbCurrency.SelectionLength = 0;
                    }
                }
                /*-------------------------------------------------Ledger pop up when Ctrl+F----------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbSalesman.Focused)
                    {
                        cmbSalesman.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesman.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbSalesman.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.CallFromServiceVoucher(this, Convert.ToDecimal(cmbSalesman.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select salesman");
                        cmbSalesman.Focus();
                    }
                }
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)//Ledger creation            
                {
                    SendKeys.Send("{F10}");
                    btnAddSalesman_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 69 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtCustomer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvServiceVoucher.Focus();
                    dgvServiceVoucher.CurrentCell = dgvServiceVoucher.Rows[0].Cells["dgvcmbParticulars"];
                    dgvServiceVoucher.Rows[0].Cells["dgvcmbParticulars"].Selected = true;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCustomer.Text == string.Empty || txtCustomer.SelectionStart == 0)
                    {
                        cmbSalesman.Focus();
                        cmbSalesman.SelectionStart = 0;
                        cmbSalesman.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 70 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvServiceVoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvServiceVoucher.Rows.Count > 0)
                    {
                        if (dgvServiceVoucher.CurrentRow.Index == dgvServiceVoucher.RowCount - 1)
                        {
                            if (inGridRowCount == 1)
                            {
                                inGridRowCount = 0;
                                txtNarration.Focus();
                                dgvServiceVoucher.ClearSelection();
                                e.Handled = true;
                            }
                            else
                            {
                                inGridRowCount = 1;
                            }
                        }
                    }
                    else
                    {
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvServiceVoucher.CurrentCell == dgvServiceVoucher.Rows[0].Cells["dgvtxtSlNo "])
                    {
                        txtCustomer.SelectionStart = 0;
                        txtCustomer.SelectionLength = 0;
                        txtCustomer.Focus();
                    }
                    else
                    {
                        dgvServiceVoucher.CurrentCell = dgvServiceVoucher[dgvServiceVoucher.Columns["dgvtxtSlNo"].Index, dgvServiceVoucher.CurrentRow.Index - 1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 71 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvServiceVoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        if (txtDiscount.Enabled)
                        {
                            inNarrationCount = 0;
                            txtDiscount.Focus();
                        }
                        else
                        {
                            inNarrationCount = 0;
                            btnSave.Focus();
                        }
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        dgvServiceVoucher.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 72 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvServiceVoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AmountCalculation();
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDiscount.Text == string.Empty || txtDiscount.SelectionStart == 0)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionLength = 0;
                        txtNarration.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 73 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtDiscount.Focus();
                    txtDiscount.SelectionStart = 0;
                    txtDiscount.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 74 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtGrandTotal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGrandTotal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtDiscount.Focus();
                    txtDiscount.SelectionStart = 0;
                    txtDiscount.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 75 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtTotalAmount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDiscount.Focus();
                    txtDiscount.SelectionStart = 0;
                    txtDiscount.SelectionLength = 0;
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
                MessageBox.Show("SV 76 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enterkey and backspace navigation of cmbCurrency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesman.Focus();
                    cmbSalesman.SelectionLength = 0;
                    cmbSalesman.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesman.Text == string.Empty || cmbSalesman.SelectionStart == 0)
                    {
                        cmbServiceAC.Focus();
                        cmbServiceAC.SelectionStart = 0;
                        cmbServiceAC.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SV 77 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

       

    }
}