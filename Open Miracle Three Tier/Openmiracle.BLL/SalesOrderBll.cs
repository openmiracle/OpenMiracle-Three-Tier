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
    public class SalesOrderBll
    {
        SalesOrderDetailsSP spSalesOrderDetails = new SalesOrderDetailsSP();
        SalesOrderMasterSP spSalesOrderMaster = new SalesOrderMasterSP();
        public List<DataTable> VoucherTypeCombofillforSalesOrderReport()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderDetails.VoucherTypeCombofillforSalesOrderReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show("SOBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesOrderDetailsViewByMasterId(decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderDetails.SalesOrderDetailsViewByMasterId(decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal SalesOrderDetailsDeletee(decimal decSalesOrderDetailsId)
        {
            decimal decResult = 0;
            try
            {
                decResult = spSalesOrderDetails.SalesOrderDetailsDeletee(decSalesOrderDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public List<DataTable> SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(decimal decSalesOrderMasterId, decimal decDeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderDetails.SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(decSalesOrderMasterId, decDeliveryNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails(decimal decSalesOrderMasterId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderDetails.SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails(decSalesOrderMasterId, decSalesMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public void SalesOrderDetailsAdd(SalesOrderDetailsInfo infoSalesorderdetails)
        {
            try
            {
                spSalesOrderDetails.SalesOrderDetailsAdd(infoSalesorderdetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SalesOrderDetailsEdit(SalesOrderDetailsInfo infoSalesorderdetails)
        {
            try
            {
                spSalesOrderDetails.SalesOrderDetailsEdit(infoSalesorderdetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         public bool SalesOrderRefererenceCheckForEditDetails(decimal decSalesOrderDetailsId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spSalesOrderDetails.SalesOrderRefererenceCheckForEditDetails(decSalesOrderDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
         public List<DataTable> SalesOrderRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesOrderMaster.SalesOrderRegisterSearch( strInvoiceNo,  decLedgerId,  FromDate,  ToDate,  strCondition);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("SOBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public void SalesOrderNoComboFillOfSalesOrderRegister(ComboBox cmbSalesOrderNo, bool isAll)
         {
             try
             {
                 spSalesOrderMaster.SalesOrderNoComboFillOfSalesOrderRegister(cmbSalesOrderNo, isAll);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("SOBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public List<DataTable> GetSalesOrderInvoiceNumberCorrespondingToLedgerId(decimal decLedgerId, decimal decVoucherTypeId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesOrderMaster.GetSalesOrderInvoiceNumberCorrespondingToLedgerId(decLedgerId, decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("SOBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string strTypeOfVouchers)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesOrderMaster.VoucherTypesBasedOnTypeOfVouchers(strTypeOfVouchers);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("SOBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
        public decimal DueDays(DateTime dtStartDate, DateTime dtEndDate)
        {
            decimal decDueDays = 0;
            try
            {
                decDueDays = spSalesOrderMaster.DueDays(dtStartDate, dtEndDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decDueDays;
        }
        public List<DataTable> SalesOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.SalesOrderOverDueReminder( FromDate,  ToDate,  strCondition,  dueOn,  decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decdeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN( decLedgerId,  decVoucherTypeId,  decdeliveryNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesOrderMasterViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.SalesOrderMasterViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public SalesOrderMasterInfo SalesOrderMasterView(decimal decSalesOrderMasterId)
        {
            SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
            try
            {
                infoSalesOrderMaster = spSalesOrderMaster.SalesOrderMasterView(decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoSalesOrderMaster;
        }
        public List<DataTable> SalesOrderMasterViewBySalesOrderMasterId(decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.SalesOrderMasterViewBySalesOrderMasterId(decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI( decLedgerId,  decSalesMasterId,  decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesInvoiceGridfillAgainestSalesOrder(decimal strOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.SalesInvoiceGridfillAgainestSalesOrder(strOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesOrderReportViewAll(string strInvoiceNo, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, decimal decEmployeeId, string strSalesQuotationNo, decimal decAreaId, decimal decGroupId, decimal decRouteId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesOrderMaster.SalesOrderReportViewAll( strInvoiceNo,  decLedgerId,  strProductCode,  decVouchertypeId,  FromDate,  ToDate,  strStatus,  decEmployeeId,  strSalesQuotationNo,  decAreaId,  decGroupId,  decRouteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public DataSet SalesOrderPrinting(decimal decSalesOrderMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spSalesOrderMaster.SalesOrderPrinting(decSalesOrderMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public decimal SalesOrderVoucherMasterMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                decMax = spSalesOrderMaster.SalesOrderVoucherMasterMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMax;
        }
        public string SalesOrderVoucherMasterMax(decimal decVoucherTypeId)
        {
            string strMax = string.Empty;
            try
            {
                strMax = spSalesOrderMaster.SalesOrderVoucherMasterMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strMax;
        }
        public string VoucherNoMax(decimal decVoucherTypeId)
        {
            string strMax = "0";
            try
            {
                strMax = spSalesOrderMaster.SalesOrderVoucherMasterMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strMax;
        }
        public decimal SalesOrderMasterAdd(SalesOrderMasterInfo infoSalesOrderMaster)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spSalesOrderMaster.SalesOrderMasterAdd(infoSalesOrderMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public bool SalesOrderRefererenceCheckForEditMaster(decimal decSalesOrderMasterId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spSalesOrderMaster.SalesOrderRefererenceCheckForEditMaster(decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public void SalesOrderMasterEdit(SalesOrderMasterInfo infoSalesOrderMaster)
        {
            try
            {
                spSalesOrderMaster.SalesOrderMasterEdit(infoSalesOrderMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool SalesOrderNumberCheckExistence(string strinvoiceNo, decimal decSalesorderMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spSalesOrderMaster.SalesOrderNumberCheckExistence(strinvoiceNo, decSalesorderMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public void SalesOrderCancel(decimal salesOrderMasterId)
        {
            try
            {
                spSalesOrderMaster.SalesOrderCancel(salesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool SalesOrderCancelCheckStatus(decimal decSalesOrderMasterId)
        {
            bool isTrue = false;
            try
            {
                isTrue = spSalesOrderMaster.SalesOrderCancelCheckStatus(decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isTrue;
        }
        public decimal SalesOrderMasterDelete(decimal SalesOrderMasterId)
        {
            decimal decResult = 0;
            try
            {
                decResult = spSalesOrderMaster.SalesOrderMasterDelete(SalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
    }
}
