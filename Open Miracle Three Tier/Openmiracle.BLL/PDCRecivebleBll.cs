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
   public class PDCRecivebleBll
    {
       PDCReceivableMasterSP spPdcRecievebleMaster = new PDCReceivableMasterSP();
       /// <summary>
       /// Function to PDCReceivable Check Existence for voucherNo
       /// </summary>
       /// <param name="voucherNo"></param>
       /// <param name="voucherTypeId"></param>
       /// <param name="decpdcReceivableId"></param>
       /// <returns></returns>
       public bool PDCReceivableCheckExistence(string voucherNo, decimal voucherTypeId, decimal decpdcReceivableId)
       {
           bool isSave = false;
           try
           {
              isSave= spPdcRecievebleMaster.PDCReceivableCheckExistence(voucherNo, voucherTypeId, decpdcReceivableId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isSave;
       }
       /// <summary>
       /// Function to PDCReceivable Voucher CheckRreference Updating
       /// </summary>
       /// <param name="decMasterId"></param>
       /// <param name="voucherTypeId"></param>
       /// <returns></returns>
       public bool PDCReceivableVoucherCheckRreferenceUpdating(decimal decMasterId, decimal voucherTypeId)
       {

           bool isExist = false;
           try
           {
               isExist = spPdcRecievebleMaster.PDCReceivableVoucherCheckRreferenceUpdating(decMasterId, voucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       /// <summary>
       /// Function to insert values to PDCReceivableMaster Table
       /// </summary>
       /// <param name="pdcreceivablemasterinfo"></param>
       /// <returns></returns>
       public decimal PDCReceivableMasterAdd(PDCReceivableMasterInfo pdcreceivablemasterinfo)
       {
           decimal decIdentity = 0;
           try
           {
               decIdentity = spPdcRecievebleMaster.PDCReceivableMasterAdd(pdcreceivablemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;
       }
       /// <summary>
       /// Function to Update values in PDCReceivableMaster Table
       /// </summary>
       /// <param name="pdcreceivablemasterinfo"></param>
       public void PDCReceivableMasterEdit(PDCReceivableMasterInfo pdcreceivablemasterinfo)
       {
           try
           {
               spPdcRecievebleMaster.PDCReceivableMasterEdit(pdcreceivablemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Ledger posting id get by using pdc id for updation 
       /// </summary>
       /// <param name="pdcMasterId"></param>
       /// <returns></returns>
       public List<DataTable> LedgerPostingIdByPDCReceivableId(decimal pdcMasterId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPdcRecievebleMaster.LedgerPostingIdByPDCReceivableId(pdcMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to  get PDCReceivable Max UnderVoucherType PlusOne
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public decimal PDCReceivableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
       {
           decimal max = 0;
           try
           {
               max = spPdcRecievebleMaster.PDCReceivableMaxUnderVoucherTypePlusOne(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       /// <summary>
       /// Function to PDCReceivable Max Under VoucherType
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public string PDCReceivableMaxUnderVoucherType(decimal decVoucherTypeId)
       {
           string max = "0";
           try
           {
               max = spPdcRecievebleMaster.PDCReceivableMaxUnderVoucherType(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       /// <summary>
       /// Function to PDCReceivableDelete Master based on the parameter
       /// </summary>
       /// <param name="PdcReceivableId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strVoucherNo"></param>
       public void PDCReceivableDeleteMaster(decimal PdcReceivableId, decimal decVoucherTypeId, string strVoucherNo)
       {
           try
           {
               spPdcRecievebleMaster.PDCReceivableDeleteMaster(PdcReceivableId, decVoucherTypeId, strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to print the PDCReceivable Voucher 
       /// </summary>
       /// <param name="decPDCReceivableId"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       public DataSet PDCReceivableVoucherPrinting(decimal decPDCReceivableId, decimal decCompanyId)
       {
           DataSet dSt = new DataSet();
           try
           {
               dSt = spPdcRecievebleMaster.PDCReceivableVoucherPrinting(decPDCReceivableId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dSt;
       }
       /// <summary>
       /// Function to get particular values from PDCReceivableMaster Table based on the parameter
       /// </summary>
       /// <param name="pdcReceivableMasterId"></param>
       /// <returns></returns>
       public PDCReceivableMasterInfo PDCReceivableMasterView(decimal pdcReceivableMasterId)
       {
           PDCReceivableMasterInfo pdcreceivablemasterinfo = new PDCReceivableMasterInfo();
           try
           {
               pdcreceivablemasterinfo = spPdcRecievebleMaster.PDCReceivableMasterView(pdcReceivableMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return pdcreceivablemasterinfo;
       }
       /// <summary>
       /// Function to get ReferenceCheck for updation
       /// </summary>
       /// <param name="decPDCReceivableMasterId"></param>
       /// <returns></returns>
       public bool PDCReceivableReferenceCheck(decimal decPDCReceivableMasterId)
       {
           bool isExist = false;
           try
           {
               isExist = spPdcRecievebleMaster.PDCReceivableReferenceCheck(decPDCReceivableMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       /// <summary>
       ///
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtToDate"></param>
       /// <param name="strVoucherType"></param>
       /// <param name="strLedgerName"></param>
       /// <param name="dtcheckfromdate"></param>
       /// <param name="dtCheckdateto"></param>
       /// <param name="strchequeNo"></param>
       /// <param name="strvoucherNo"></param>
       /// <param name="strstatus"></param>
       /// <returns></returns>
       public List<DataTable> PdcReceivableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPdcRecievebleMaster.PdcReceivableReportSearch(dtFromdate, dtToDate, strVoucherType, strLedgerName, dtcheckfromdate, dtCheckdateto, strchequeNo, strvoucherNo, strstatus);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtToDate"></param>
       /// <param name="strVoucherType"></param>
       /// <param name="strLedgerName"></param>
       /// <param name="dtcheckfromdate"></param>
       /// <param name="dtCheckdateto"></param>
       /// <param name="strchequeNo"></param>
       /// <param name="strvoucherNo"></param>
       /// <param name="strstatus"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       public DataSet PdcreceivableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
       {
           DataSet dSt = new DataSet();
           try
           {
               dSt = spPdcRecievebleMaster.PdcreceivableReportPrinting(dtFromdate, dtToDate, strVoucherType, strLedgerName, dtcheckfromdate, dtCheckdateto, strchequeNo, strvoucherNo, strstatus, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dSt;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decVouchertypeid"></param>
       /// <param name="strVoucherNo"></param>
       /// <returns></returns>
       public decimal PdcReceivableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
       {
           decimal max = 0;
           try
           {
               max = spPdcRecievebleMaster.PdcReceivableMasterIdView(decVouchertypeid, strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtTodate"></param>
       /// <param name="strVoucherNo"></param>
       /// <param name="strLedgerName"></param>
       /// <returns></returns>
       public List<DataTable> PDCReceivableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPdcRecievebleMaster.PDCReceivableRegisterSearch(dtFromdate, dtTodate, strVoucherNo, strLedgerName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PDCR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }

    }
}
