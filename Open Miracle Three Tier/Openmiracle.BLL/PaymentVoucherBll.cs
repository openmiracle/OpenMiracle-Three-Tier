using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;
namespace OpenMiracle.BLL
{
    public class PaymentVoucherBll
    {
        PaymentDetailsInfo InfoPaymentDetails = new PaymentDetailsInfo();
        PaymentDetailsSP SPPaymentDetails = new PaymentDetailsSP();
        PaymentMasterInfo InfoPaymentMaster = new PaymentMasterInfo();
        PaymentMasterSP SPPaymentMaster = new PaymentMasterSP();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentdetailsinfo"></param>
        /// <returns></returns>
        public decimal PaymentDetailsAdd(PaymentDetailsInfo paymentdetailsinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPaymentDetails.PaymentDetailsAdd(paymentdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PaymentDetailsId"></param>
        public void PaymentDetailsDelete(decimal PaymentDetailsId)
        {
            try
            {
                SPPaymentDetails.PaymentDetailsDelete(PaymentDetailsId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentdetailsinfo"></param>
        /// <returns></returns>
        public decimal PaymentDetailsEdit(PaymentDetailsInfo paymentdetailsinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPaymentDetails.PaymentDetailsEdit(paymentdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentMastertId"></param>
        /// <returns></returns>
        public List<DataTable> PaymentDetailsViewByMasterId(decimal paymentMastertId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPaymentDetails.PaymentDetailsViewByMasterId(paymentMastertId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public int PaymentMasterMax(decimal decVoucherTypeId)
        {
            int inCount = 0;
            try
            {
                inCount = SPPaymentMaster.PaymentMasterMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inCount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decPaymentMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PaymentVoucherPrinting(decimal decPaymentMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPPaymentMaster.PaymentVoucherPrinting(decPaymentMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool isResult = false;
            try
            {
                isResult = SPPaymentMaster.PaymentVoucherCheckExistence(strvoucherNo, decvoucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentmasterinfo"></param>
        /// <returns></returns>
        public decimal PaymentMasterAdd(PaymentMasterInfo paymentmasterinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPaymentMaster.PaymentMasterAdd(paymentmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentmasterinfo"></param>
        /// <returns></returns>
        public decimal PaymentMasterEdit(PaymentMasterInfo paymentmasterinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPaymentMaster.PaymentMasterEdit(paymentmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
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
                SPPaymentMaster.PaymentVoucherDelete(decPaymentMasterId, decVoucherTypeId, strVoucherNo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentMastertId"></param>
        /// <returns></returns>
        public PaymentMasterInfo PaymentMasterViewByMasterId(decimal paymentMastertId)
        {
            try
            {
                InfoPaymentMaster = SPPaymentMaster.PaymentMasterViewByMasterId(paymentMastertId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoPaymentMaster;
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
                listObj = SPPaymentMaster.PaymentMasterSearch(dtpFromDate, dtpToDate, decledgerId, strvoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ds = SPPaymentMaster.PaymentReportPrinting(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                listObj = SPPaymentMaster.PaymentReportSearch(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPPaymentMaster.paymentMasterIdView(decVouchertypeid, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PVBLL:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }



    }
}
