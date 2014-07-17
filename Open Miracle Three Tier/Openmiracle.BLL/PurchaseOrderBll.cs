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
    public class PurchaseOrderBll
    {
        public PurchaseOrderMasterInfo PurchaseOrderMasterView(decimal purchaseOrderMasterId)
        {
            PurchaseOrderMasterInfo purchaseordermasterinfo = new PurchaseOrderMasterInfo();
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            try
            {
                purchaseordermasterinfo = SPPurchaseOrderMaster.PurchaseOrderMasterView(purchaseOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return purchaseordermasterinfo;
        }
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI(decimal decPurchaseOrderMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI(decPurchaseOrderMasterId, decPurchaseMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> VoucherTypeCombofillforPurchaseOrderReport()
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.VoucherTypeCombofillforPurchaseOrderReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal PurchaseOrderDetailsDelete(decimal decVoucherTypeId)
        {
            PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            decimal decResult = 0;
            try
            {
                decResult = SPPurchaseOrderDetails.PurchaseOrderDetailsDelete(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public List<DataTable> PurchaseOrderDetailsViewWithRemaining(decimal decpurchaseOrderMasterId)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.PurchaseOrderDetailsViewWithRemaining(decpurchaseOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> PurchaseOrderDetailsViewByMasterId(decimal decpurchaseOrderMasterId)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.PurchaseOrderDetailsViewByMasterId(decpurchaseOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public void PurchaseOrderDetailsAdd(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            try
            {
                SPPurchaseOrderDetails.PurchaseOrderDetailsAdd(purchaseorderdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PurchaseOrderDetailsEdit(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            try
            {
                SPPurchaseOrderDetails.PurchaseOrderDetailsEdit(purchaseorderdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit(decimal decOrderMasterId, decimal decReceiptMasterId)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit(decOrderMasterId, decReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemaining(decimal decOrderMasterId, decimal decReceiptMasterId)
        {
            PurchaseOrderDetailsSP SPPurchaseOrderDetails = new PurchaseOrderDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderDetails.PurchaseOrderDetailsViewByOrderMasterIdWithRemaining(decOrderMasterId, decReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> PurchaseOrderMasterViewByOrderMasterId(decimal decOrderMasterId)
        {
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseOrderMaster.PurchaseOrderMasterViewByOrderMasterId(decOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
          public void PurchaseOrderCancel(decimal decOrderMasterId)
        {
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            
            try
            {
                SPPurchaseOrderMaster.PurchaseOrderCancel(decOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
          public bool PurchaseOrderCancelCheckStatus(decimal decVoucherTypeId)
        {
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            bool isTrue = false;
            try
            {
                isTrue = SPPurchaseOrderMaster.PurchaseOrderCancelCheckStatus(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
          public string PurchaseOrderVoucherMasterMax(decimal decVoucherTypeId)
          {
              PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
              string max = "0";
              try
              {
                  max = SPPurchaseOrderMaster.PurchaseOrderVoucherMasterMax(decVoucherTypeId);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("PoBll 14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              return max;
          }
          public decimal DueDays(DateTime dtStartDate, DateTime dtEndDate)
          {
              PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
              decimal decDueDays = 0;
              try
              {
                  decDueDays = SPPurchaseOrderMaster.DueDays(dtStartDate, dtEndDate);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("PoBll 15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              return decDueDays;
          }
          public DataSet PurchaseOrderPrinting(decimal decPurcahseOrderMasterId)
        {
            DataSet ds = new DataSet();
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            
            try
            {
                ds = SPPurchaseOrderMaster.PurchaseOrderPrinting(decPurcahseOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
          public decimal PurchaseOrderMasterDelete(decimal PurchaseOrderMasterId)
          {
              PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
              decimal decResult = 0;
              try
              {
                 decResult= SPPurchaseOrderMaster.PurchaseOrderMasterDelete( PurchaseOrderMasterId);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("PoBll 17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              return decResult;
          }
         public bool PurchaseOrderNumberCheckExistence(string strinvoiceNo, decimal decPurchaseorderMasterId, decimal decVoucherTypeId)
        {
            PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
            bool isEdit = false;
            try
            {
               isEdit= SPPurchaseOrderMaster.PurchaseOrderNumberCheckExistence(strinvoiceNo, decPurchaseorderMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PoBll 18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
         public void PurchaseOrderMasterEdit(PurchaseOrderMasterInfo purchaseordermasterinfo)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
           
             try
             {
                 SPPurchaseOrderMaster.PurchaseOrderMasterEdit(purchaseordermasterinfo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             
         }
         public string VoucherNoMax(decimal decVoucherTypeId)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             string max = "0";
             try
             {
                max= SPPurchaseOrderMaster.VoucherNoMax(decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return max;
         }
         public decimal PurchaseOrderMasterAdd(PurchaseOrderMasterInfo purchaseordermasterinfo)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             decimal decIdentity = 0;
             try
             {
                 decIdentity = SPPurchaseOrderMaster.PurchaseOrderMasterAdd(purchaseordermasterinfo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return decIdentity;
         }
         public List<DataTable> PurchaseOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = SPPurchaseOrderMaster.PurchaseOrderOverDueReminder(FromDate, ToDate, strCondition, dueOn, decLedgerId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public decimal ExchangeRateIdByCurrencyId(decimal decCurrencyId)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             decimal decCount = 0;
             try
             {
                 decCount = SPPurchaseOrderMaster.ExchangeRateIdByCurrencyId(decCurrencyId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return decCount;
         }
         public DataSet PurchaseOrderReportPrinting(decimal decCompanyId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
         {
             DataSet ds = new DataSet();
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             try
             {
                 ds = SPPurchaseOrderMaster.PurchaseOrderReportPrinting(decCompanyId,strInvoiceNo, decLedgerId, decVouchertypeId,FromDate, ToDate, strStatus);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ds;
         }
         public List<DataTable> PurchaseOrderMasterViewAll(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = SPPurchaseOrderMaster.PurchaseOrderMasterViewAll(strInvoiceNo, decLedgerId, FromDate, ToDate, strCondition);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public List<DataTable> PurchaseOrdeReportViewAll(string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
         {
             PurchaseOrderMasterSP SPPurchaseOrderMaster = new PurchaseOrderMasterSP();
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = SPPurchaseOrderMaster.PurchaseOrdeReportViewAll(strInvoiceNo, decLedgerId, decVouchertypeId, FromDate, ToDate, strStatus);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("PoBll 26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
    }
    }
   