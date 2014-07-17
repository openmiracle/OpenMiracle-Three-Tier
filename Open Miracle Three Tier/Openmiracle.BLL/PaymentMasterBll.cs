using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
   public  class PaymentMasterBll
    {
       PaymentMasterInfo infoPaymentMaster=new PaymentMasterInfo();
       PaymentMasterSP SpPaymentMaster = new PaymentMasterSP();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public int PaymentMasterMax(decimal decVoucherTypeId)
       {
        int decId = 0;
           try
           {
               decId = SpPaymentMaster.PaymentMasterMax(decVoucherTypeId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PM1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decPaymentMasterId"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       internal DataSet PaymentVoucherPrinting(decimal decPaymentMasterId, decimal decCompanyId)
       {
           DataSet ds = new DataSet();
           try
           {
               ds = SpPaymentMaster.PaymentVoucherPrinting(decPaymentMasterId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="strvoucherNo"></param>
       /// <param name="decvoucherTypeId"></param>
       /// <param name="decMasterId"></param>
       /// <returns></returns>
       public bool PaymentVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
       {
           bool trueOrfalse = false;
           try
           {
               trueOrfalse = SpPaymentMaster.PaymentVoucherCheckExistence(strvoucherNo, decvoucherTypeId, decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return trueOrfalse;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentmasterinfo"></param>
       /// <returns></returns>
       public decimal PaymentMasterAdd(PaymentMasterInfo paymentmasterinfo)
       {
           decimal decId = 0;
           try
           {
               decId = SpPaymentMaster.PaymentMasterAdd(paymentmasterinfo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PM4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentmasterinfo"></param>
       /// <returns></returns>
       public decimal PaymentMasterEdit(PaymentMasterInfo paymentmasterinfo)
       {
           decimal decId = 0;
           try
           {
               decId = SpPaymentMaster.PaymentMasterEdit(paymentmasterinfo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PM5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decPaymentMasterId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strVoucherNo"></param>
       public void PaymentVoucherDelete(decimal decPaymentMasterId, decimal decVoucherTypeId, string strVoucherNo)
       {

           try
           {
               SpPaymentMaster.PaymentVoucherDelete(decPaymentMasterId, decVoucherTypeId, strVoucherNo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentMastertId"></param>
       /// <returns></returns>
       public PaymentMasterInfo PaymentMasterViewByMasterId(decimal paymentMastertId)
       {
           PaymentMasterInfo infoPaymentMaster = new PaymentMasterInfo();
           try
           {
               infoPaymentMaster = SpPaymentMaster.PaymentMasterViewByMasterId(paymentMastertId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoPaymentMaster;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtpFromDate"></param>
       /// <param name="dtpToDate"></param>
       /// <param name="decledgerId"></param>
       /// <param name="strvoucherNo"></param>
       /// <returns></returns>
       public List<DataTable> PaymentMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpPaymentMaster.PaymentMasterSearch(dtpFromDate, dtpToDate, decledgerId, strvoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtpFromDate"></param>
       /// <param name="dtpToDate"></param>
       /// <param name="decLedgerId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="decCashOrBankId"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       public DataSet PaymentReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
       {
         
           DataSet ds = new DataSet();
           try
           {
               ds = SpPaymentMaster.PaymentReportPrinting(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtpFromDate"></param>
       /// <param name="dtpToDate"></param>
       /// <param name="decLedgerId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="decCashOrBankId"></param>
       /// <returns></returns>
       public List<DataTable> PaymentReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpPaymentMaster.PaymentReportSearch(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PM10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decVouchertypeid"></param>
       /// <param name="strVoucherNo"></param>
       /// <returns></returns>
       public decimal paymentMasterIdView(decimal decVouchertypeid, string strVoucherNo)
       {
          
           decimal decId = 0;
           try
           {
               decId = SpPaymentMaster.paymentMasterIdView(decVouchertypeid, strVoucherNo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PM11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }

     
    }
}
