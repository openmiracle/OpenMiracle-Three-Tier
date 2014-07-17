using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;

namespace OpenMiracle.BLL
{
    public class AccountLedgerBll
    {
        AccountLedgerSP spAccountLedger = new AccountLedgerSP();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckExistence(String strLedgerName, decimal decLedgerId)
        {
            bool isStatus = false;
            try
            {
               isStatus= spAccountLedger.AccountLedgerCheckExistence(strLedgerName, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isStatus;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoAccountLedger"></param>
        /// <returns></returns>
        public decimal AccountLedgerAddWithIdentity(AccountLedgerInfo infoAccountLedger)
        {
            decimal decLedgerId = 0;
            try
            {
                decLedgerId = spAccountLedger.AccountLedgerAddWithIdentity(infoAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerId;
        }
        public void AccountLedgerEdit(AccountLedgerInfo infoAccountLedger)
        {
            try
            {
                spAccountLedger.AccountLedgerEdit(infoAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(string strVocuherNumber, decimal decVoucherTypeId)
        {
            try
            {
                spAccountLedger.PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(strVocuherNumber, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LedgerPostingDeleteByVoucherTypeAndVoucherNo(string strVocuherNumber, decimal decvoucherTypeId)
        {
            try
            {
                spAccountLedger.LedgerPostingDeleteByVoucherTypeAndVoucherNo(strVocuherNumber, decvoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> AccountLedgerSearch(String strAccountGroupname, String strLedgername)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerSearch(strAccountGroupname, strLedgername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal AccountLedgerCheckReferences(decimal decLedgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spAccountLedger.AccountLedgerCheckReferences(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public AccountLedgerInfo AccountLedgerViewForEdit(decimal decLedgerId)
        {
            AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
            try
            {
                infoAccountLedger = spAccountLedger.AccountLedgerViewForEdit(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoAccountLedger;
        }
        public bool PartyBalanceAgainstReferenceCheck(string strVoucherNo, decimal decVoucherTypeId)
        {
            bool isExist = false;
            try
            {
                isExist = spAccountLedger.PartyBalanceAgainstReferenceCheck(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        public List<DataTable> AccountLedgerForSecondaryDetails()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerForSecondaryDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> AccountLedgerForBankDetails()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerForBankDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public String CreditOrDebitChecking(decimal decLedgerId)
        {
            string strNature=string.Empty;
            try
            {
                strNature = spAccountLedger.CreditOrDebitChecking(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strNature;
        }
        public DataSet LedgerDetailsFillCorrespondingToledgerId(DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId)
        {
            DataSet dsLedgerDetails = new DataSet();
            try
            {
                dsLedgerDetails = spAccountLedger.LedgerDetailsFillCorrespondingToledgerId(dtFromDate, dtToDate, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsLedgerDetails;
        }
        public AccountLedgerInfo AccountLedgerViewForSupplier(decimal decLedgerId)
        {
            AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
            try
            {
                infoAccountLedger = spAccountLedger.AccountLedgerViewForSupplier(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoAccountLedger;
        }
        public bool AccountLedgerCheckExistenceForCustomer(String strLedgerName, decimal decLedgerId)
        {
            try
            {
                spAccountLedger.AccountLedgerCheckExistenceForCustomer(strLedgerName, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public decimal AccountLedgerAddForCustomer(AccountLedgerInfo infoAccountLedger)
        {
            decimal decLedgerId = 0;
            try
            {
                decLedgerId = spAccountLedger.AccountLedgerAddForCustomer(infoAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerId;
        }
        public AccountLedgerInfo AccountLedgerView(decimal decLedgerId)
        {
            AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
            try
            {
                infoAccountLedger = spAccountLedger.AccountLedgerView(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoAccountLedger;
        }
        public AccountLedgerInfo AccountLedgerViewForCustomer(decimal decLedgerId)
        {
            AccountLedgerInfo infoAccountledger = new AccountLedgerInfo();
            try
            {
                infoAccountledger = spAccountLedger.AccountLedgerViewForCustomer(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoAccountledger;
        }
        public bool AccountGroupIdCheckSundryCreditorOnly(string strLedgerName)
        {
            bool isSundryCredit = false;
            try
            {
                isSundryCredit = spAccountLedger.AccountGroupIdCheckSundryCreditorOnly(strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSundryCredit;
        }
        public List<DataTable> AccountLedgerViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> cmbAreafillInCustomer()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.cmbAreafillInCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal AccountLedgerIdGetByName(string strLedgerName)
        {
            decimal decLedgerId = 0;
            try
            {
                decLedgerId = spAccountLedger.AccountLedgerIdGetByName(strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerId;
        }
        public List<DataTable> AccountLedgerSearchforCustomer(decimal decAreaId, decimal decRouteId, string strledgername)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerSearchforCustomer(decAreaId, decRouteId, strledgername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL119:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public bool AccountGroupIdCheckSundryDeptor(string strLedgerName)
        {
            bool isSundryDebit = false;
            try
            {
                isSundryDebit = spAccountLedger.AccountGroupIdCheckSundryDeptor(strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSundryDebit;
        }
        public void AccountLedgerEditForCustomer(AccountLedgerInfo accountledgerinfo)
        {
            try
            {
                spAccountLedger.AccountLedgerEditForCustomer(accountledgerinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool AccountGroupIdCheck(string strLedgerName)
        {
            bool isSundryCreditOrDebit = false;
            try
            {
                isSundryCreditOrDebit = spAccountLedger.AccountGroupIdCheck(strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSundryCreditOrDebit;
        }
        public List<DataTable> cmbPricingLevelInCustomer()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spAccountLedger.cmbPricingLevelInCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> MultipleAccountLedgerComboFill()
        {

            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.MultipleAccountLedgerComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> LedgerPopupSearch(String strledgername, String straccountgroupname, decimal decId1, decimal decId2)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.LedgerPopupSearch(strledgername, straccountgroupname, decId1, decId2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> LedgerPopupSearchForServiceAccountsUnderIncome()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.LedgerPopupSearchForServiceAccountsUnderIncome();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> cmbRoutInCustomer(decimal decAreaId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.cmbRoutInCustomer(decAreaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> AccountLedgerViewAllForComboBox()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerViewAllForComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal CheckLedgerBalance(decimal decledgerId)
        {
            decimal inBalance = 0;
            try
            {
                inBalance = spAccountLedger.CheckLedgerBalance(decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inBalance;
        }
        public List<DataTable> BillAllocationLedgerFill(ComboBox cmbAccountLedger, string strAccountGroup, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.BillAllocationLedgerFill(cmbAccountLedger, strAccountGroup, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;

        }
        public List<DataTable> PartyAddressBookSearch(string strType, string strmobile, string strphone, string stremail, string strledgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.PartyAddressBookSearch(strType, strmobile, strphone, stremail, strledgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> PartyAddressBookPrint(string strType, string strmobile, string strphone, string stremail, string strledgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.PartyAddressBookPrint(strType, strmobile, strphone, stremail, strledgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
         public List<DataTable> AccountLedgerViewAllByLedgerName(decimal decaccountGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerViewAllByLedgerName(decaccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
         public List<DataTable> SupplierSearchAll(decimal deecAreaId, decimal decRouteId, string strledgername)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spAccountLedger.SupplierSearchAll(deecAreaId, decRouteId, strledgername);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public bool AccountLedgerCheckExistenceForSalesman(String strLedgerName, decimal decLedgerId)
         {
             bool inChek = false;
             try
             {
                 inChek=spAccountLedger.AccountLedgerCheckExistenceForSalesman(strLedgerName, decLedgerId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return inChek;
         }
        public void AccountLedgerEditForSalesman(AccountLedgerInfo infoAccountLedger)
        {
            try
            {
                spAccountLedger.AccountLedgerEditForSalesman(infoAccountLedger);
            }
            catch(Exception ex)
            {
                MessageBox.Show("AL32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal SupplierCheckreferenceAndDelete(decimal decledgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spAccountLedger.SupplierCheckreferenceAndDelete(decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public void AccountLedgerDelete(decimal LedgerId)
        {
            try
            {
                spAccountLedger.AccountLedgerDelete(LedgerId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("AL34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> AccountLedgerViewByAccountGroup(decimal decAccounGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerViewByAccountGroup(decAccounGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> AccountLedgerSearchForServiceAccountUnderIncome()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerSearchForServiceAccountUnderIncome();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
         public List<DataTable> AdditionalCostGet()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AdditionalCostGet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
         public List<DataTable> AccountLedgerReportFill(DateTime dtFromDate, DateTime dtToDate,decimal decAccountGroupId,decimal decLedgerId )
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountLedger.AccountLedgerReportFill(  dtFromDate,   dtToDate,  decAccountGroupId,  decLedgerId );
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
         }
         public DataSet AccountLedgerReportPrinting(decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decAccountGroupId, decimal decLedgerId)
         {
             DataSet dSt = new DataSet();
             try
             {
                 dSt = spAccountLedger.AccountLedgerReportPrinting(decCompanyId, fromDate, toDate, decAccountGroupId, decLedgerId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return dSt;
         }
         public AccountLedgerInfo accountLedgerviewbyId(decimal decledgerId)
         {
             AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
             try
             {
                 infoAccountLedger = spAccountLedger.accountLedgerviewbyId(decledgerId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return infoAccountLedger;
         }
         public List<DataTable> AccountLedgerViewForAdditionalCost()
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spAccountLedger.AccountLedgerViewForAdditionalCost();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public bool AccountLedgerCheckExistenceForTax(string strTaxname)
         {
             bool isStatus = false;
             try
             {
                 isStatus = spAccountLedger.AccountLedgerCheckExistenceForTax(strTaxname);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return isStatus;
         }
       
    }
}
