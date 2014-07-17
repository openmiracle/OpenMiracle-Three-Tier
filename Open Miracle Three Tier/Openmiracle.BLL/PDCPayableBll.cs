using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
    public class PDCPayableBll
    {
        PDCPayableMasterSP spPdcPayableMaster = new PDCPayableMasterSP();
        /// <summary>
        /// Function to view PDCPayable max id Under VoucherType Plus One
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PDCPayableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = spPdcPayableMaster.PDCPayableMaxUnderVoucherTypePlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }

        /// <summary>
        /// Function to fill bank combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BankAccountComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.BankAccountComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to insert values to PDCPayableMaster Table
        /// </summary>
        /// <param name="pdcpayablemasterinfo"></param>
        /// <returns></returns>
        public decimal PDCPayableMasterAdd(PDCPayableMasterInfo pdcpayablemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spPdcPayableMaster.PDCPayableMasterAdd(pdcpayablemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in PDCPayableMaster Table
        /// </summary>
        /// <param name="pdcpayablemasterinfo"></param>
        public void PDCPayableMasterEdit(PDCPayableMasterInfo pdcpayablemasterinfo)
        {
            try
            {
                spPdcPayableMaster.PDCPayableMasterEdit(pdcpayablemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the details for printing pdcpayable voucher printing
        /// </summary>
        /// <param name="decPDCpayableId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PDCpayableVoucherPrinting(decimal decPDCpayableId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = spPdcPayableMaster.PDCpayableVoucherPrinting(decPDCpayableId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
        /// <summary>
        /// Function to check existance of pdcpayable 
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="pdcPayableMasterId"></param>
        /// <returns></returns>
        public bool PDCpayableCheckExistence(string voucherNo, decimal voucherTypeId, decimal pdcPayableMasterId)
        {
            bool isSave = false;
            try
            {
                isSave=spPdcPayableMaster.PDCpayableCheckExistence(voucherNo, voucherTypeId, pdcPayableMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        /// <summary>
        /// Function to check reference of pdcpayablevoucher
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public bool PDCPayableVoucherCheckRreference(decimal decMasterId, decimal voucherTypeId)
        {
            bool isExist = false;
            try
            {
                isExist = spPdcPayableMaster.PDCPayableVoucherCheckRreference(decMasterId, voucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        /// <summary>
        /// Function to get ledgerposting Id by pdcpayableId
        /// </summary>
        /// <param name="pdcMasterId"></param>
        /// <returns></returns>
        public List<DataTable> LedgerPostingIdByPDCpayableId(decimal pdcMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.LedgerPostingIdByPDCpayableId(pdcMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from PDCPayableMaster table based on the parameter
        /// </summary>
        /// <param name="pdcPayableMasterId"></param>
        /// <returns></returns>
        public PDCPayableMasterInfo PDCPayableMasterView(decimal pdcPayableMasterId)
        {
            PDCPayableMasterInfo pdcpayablemasterinfo = new PDCPayableMasterInfo();           
            try
            {
                pdcpayablemasterinfo = spPdcPayableMaster.PDCPayableMasterView(pdcPayableMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return pdcpayablemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PdcpayableId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PDCPayableMasterDelete(decimal PdcpayableId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                spPdcPayableMaster.PDCPayableMasterDelete(PdcpayableId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check pdcpayable reference
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <returns></returns>
        public bool PDCPayableReferenceCheck(decimal decMasterId, decimal decvoucherTypeId)
        {
            bool isExist = false;
            try
            {
                isExist = spPdcPayableMaster.PDCPayableReferenceCheck(decMasterId, decvoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        public List<DataTable> PDCpayableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.PDCpayableRegisterSearch(dtFromdate, dtTodate, strVoucherNo,strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> AccountLedgerComboFill(bool Isall)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.AccountLedgerComboFill(Isall);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> ChequeReportGridFill(decimal decParty, string strChequeNo, DateTime dtFromDate, DateTime dtTodate, DateTime dtChequefromDate, DateTime dtChequetoDate, bool isIssued)    //, decimal decCurrencyId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.ChequeReportGridFill(decParty, strChequeNo, dtFromDate, dtTodate, dtChequefromDate, dtChequetoDate, isIssued);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> ChequeReportPartyComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.ChequeReportPartyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal PdcPayableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spPdcPayableMaster.PdcPayableMasterIdView(decVouchertypeid, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public List<DataTable> PdcPayableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcPayableMaster.PdcPayableReportSearch(dtFromdate, dtToDate, strVoucherType, strLedgerName, dtcheckfromdate, dtCheckdateto, strchequeNo, strvoucherNo, strstatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public DataSet PdcpayableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = spPdcPayableMaster.PdcpayableReportPrinting(dtFromdate, dtToDate, strVoucherType, strLedgerName, dtcheckfromdate, dtCheckdateto, strchequeNo, strvoucherNo, strstatus, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
    }
}