using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using System.Data;
using System.Windows.Forms;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
    public class PartyBalanceBll
    {
        PartyBalanceSP SPPartyBalance = new PartyBalanceSP();
        PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();

        public List<DataTable> OutstandingPartyView()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.OutstandingPartyView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DataSet OutstandingViewAll(decimal decledgerId, string strAccountGroup, DateTime dtfromdate, DateTime dttodate)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPPartyBalance.OutstandingViewAll(decledgerId, strAccountGroup, dtfromdate, dttodate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public DataSet OutstandingPrint(decimal decledgerId, string strAccountGroup, DateTime dtfromdate, DateTime dttodate, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPPartyBalance.OutstandingPrint(decledgerId, strAccountGroup, dtfromdate, dttodate, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public void PartyBalanceAdd(PartyBalanceInfo infopartybalance)
        {
            try
            {
                SPPartyBalance.PartyBalanceAdd(infopartybalance);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void PartyBalanceEdit(PartyBalanceInfo infopartybalance)
        {
            try
            {
                SPPartyBalance.PartyBalanceEdit(infopartybalance);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public List<DataTable> PartyBalanceComboViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strCrDr, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal PartyBalanceAmountCheckForEdit(decimal decLedgerId, decimal decVoucherTypeId, string strVoucherNo, string strDrOrCr)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPartyBalance.PartyBalanceAmountCheckForEdit(decLedgerId, decVoucherTypeId, strVoucherNo, strDrOrCr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public List<DataTable> AccountLedgerGetByDebtorAndCreditorWithBalance()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AccountLedgerGetByDebtorAndCreditorWithBalance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AgeingReportLedgerReceivable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AgeingReportLedgerReceivable(ageingDate, decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AgeingReportVoucherReceivable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AgeingReportVoucherReceivable(ageingDate, decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AgeingReportLedgerPayable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AgeingReportLedgerPayable(ageingDate, decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AgeingReportVoucherPayable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AgeingReportVoucherPayable(ageingDate, decledgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AgainstBillDetailsGridViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, decimal decVoucherTypeNameId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.AgainstBillDetailsGridViewByLedgerId(decLedgerId, strCrDr, decVoucherTypeId, decVoucherTypeNameId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BillAllocationSearch(DateTime dtfromdate, DateTime dttodate, string straccountgroup, string strledgername)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.BillAllocationSearch(dtfromdate, dttodate, straccountgroup, strledgername);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool PartyBalanceCheckReference(decimal decVoucherTypeId, string strVoucherNo)
        {
            bool isResult = false;
            try
            {
                isResult = SPPartyBalance.PartyBalanceCheckReference(decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public void PartyBalanceDelete(decimal PartyBalanceId)
        {
            try
            {
                SPPartyBalance.PartyBalanceDelete(PartyBalanceId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> PartyBalanceViewByVoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo, DateTime dtDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPartyBalance.PartyBalanceViewByVoucherNoAndVoucherType(decVoucherTypeId, strVoucherNo, dtDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public int PartyBalanceDeleteByVoucherTypeAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
        {
            int inCount = 0;
            try
            {
                inCount = SPPartyBalance.PartyBalanceDeleteByVoucherTypeAndVoucherNo(decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inCount;
        }
        public PartyBalanceInfo PartyBalanceViewByVoucherNoAndVoucherTypeId(decimal decVoucherTypeId, string strVoucherNo, DateTime dtDate)
        {
            try
            {
                InfoPartyBalance = SPPartyBalance.PartyBalanceViewByVoucherNoAndVoucherTypeId(decVoucherTypeId, strVoucherNo, dtDate);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoPartyBalance;
        }
        public decimal PartyBalanceAmountViewForSalesInvoice(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPartyBalance.PartyBalanceAmountViewForSalesInvoice(strVoucherNo, decVoucherTypeId, strReferenceType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public void PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType(PartyBalanceInfo infoPartyBalance)
        {
            try
            {
                SPPartyBalance.PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType(infoPartyBalance);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPartyBalance.PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType(strVoucherNo, decVoucherTypeId, strReferenceType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
    }
}
