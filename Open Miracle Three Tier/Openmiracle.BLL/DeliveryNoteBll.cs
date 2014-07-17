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
   public class DeliveryNoteBll
    {
       DeliveryNoteDetailsInfo infoDeliveryNoteDetails = new DeliveryNoteDetailsInfo();
       DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
       DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
       DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
       public List<DataTable> DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(decimal decDeliveryNoteMasterId, decimal decRejectionInMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteDetails.DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(decDeliveryNoteMasterId, decRejectionInMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> DeliveryNoteDetailsViewByDeliveryNoteMasterId(decimal decDeliveryNoteMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteDetails.DeliveryNoteDetailsViewByDeliveryNoteMasterId(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public void DeliveryNoteDetailsAdd(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
       {
           try
           {
              spDeliveryNoteDetails.DeliveryNoteDetailsAdd(deliverynotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public void DeliveryNoteDetailsEdit(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
       {
           try
           {
               spDeliveryNoteDetails.DeliveryNoteDetailsEdit(deliverynotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public decimal DeliveryNoteDetailsDelete(decimal DeliveryNoteDetailsId)
       {
           decimal decResult = 0;
           try
           {
              decResult= spDeliveryNoteDetails.DeliveryNoteDetailsDelete(DeliveryNoteDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decResult;
       }
       public List<DataTable> SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails(decimal decDeliveryNoteMasterId, decimal SIMasterId, decimal voucherTypeId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteDetails.SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails(decDeliveryNoteMasterId, SIMasterId, voucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> DeliveryNoteReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decSalesMan, string strProdCod, string strVoucherNo, decimal decVoucherTypeId, string strStatus, int inDecimalPlaces, string strDeliveryMode, string strInvoiceNo, decimal decAgainstVoucherTypeId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.DeliveryNoteReportGridFill(fromDate, toDate, decLedgerId, decSalesMan, strProdCod, strVoucherNo, decVoucherTypeId, strStatus, inDecimalPlaces, strDeliveryMode, strInvoiceNo, decAgainstVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation();
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public DataSet DeliveryNoteReportPrinting(decimal decCompanyId, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, string strDeliveryMode, string strInvoiceNo)
       {
           DataSet ds = new DataSet();
           try
           {
               ds = spDeliveryNoteMaster.DeliveryNoteReportPrinting(decCompanyId, decLedgerId, decVouchertypeId, FromDate, ToDate, strStatus, strDeliveryMode, strInvoiceNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
       public List<DataTable> DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger(string strInvoiceNo, decimal decLdger, DateTime fromDate, DateTime toDate, int inDecimalPlaces)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger(strInvoiceNo, decLdger, fromDate, toDate, inDecimalPlaces);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public decimal DeliveryNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
       {
           decimal max = 0;
           try
           {
               max = spDeliveryNoteMaster.DeliveryNoteMasterGetMaxPlusOne(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public string DeliveryNoteMasterMax1(decimal decVoucherTypeId)
       {
           string max = "0";
           try
           {
               max = spDeliveryNoteMaster.DeliveryNoteMasterMax1(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public DeliveryNoteMasterInfo DeliveryNoteMasterViewAllByMasterId(decimal decDeliveryNoteMasterId)
       {
           DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
           try
           {
               infoDeliveryNoteMaster = spDeliveryNoteMaster.DeliveryNoteMasterViewAllByMasterId(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoDeliveryNoteMaster;
       }
       public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.VoucherTypesBasedOnTypeOfVouchers(typeOfVouchers);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public decimal DeliveryNoteMasterAdd(DeliveryNoteMasterInfo deliverynotemasterinfo)
       {
           decimal decDeliveryNoteMasterId = 0;
           try
           {
               decDeliveryNoteMasterId = spDeliveryNoteMaster.DeliveryNoteMasterAdd(deliverynotemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decDeliveryNoteMasterId;
       }
       public void DeliveryNoteMasterEdit(DeliveryNoteMasterInfo deliverynotemasterinfo)
       {
           try
           {
                spDeliveryNoteMaster.DeliveryNoteMasterEdit(deliverynotemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public decimal StockPostDeletingForDeliveryNote(decimal decVoucherTypeId, string strVoucherNo, string strInvoiceNo)
       {
           decimal deliveryNoteId = 0;
           try
           {
               deliveryNoteId = spDeliveryNoteMaster.StockPostDeletingForDeliveryNote(decVoucherTypeId, strVoucherNo, strInvoiceNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return deliveryNoteId;
       }
       public bool DeliveryNotNumberCheckExistence(string strInvoiceNo, decimal decDeliveryNoteMasterId, decimal decVoucherTypeId)
       {
           bool isEdit = false;
           try
           {
               isEdit = spDeliveryNoteMaster.DeliveryNotNumberCheckExistence(strInvoiceNo, decDeliveryNoteMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isEdit;
       }
       public DataSet DeliveryNotePrinting(decimal decDeliveryNoteMasterId, decimal decCompanyId, decimal decOrderId, decimal decQuotationId)
       {
           DataSet ds = new DataSet();
           try
           {
               ds = spDeliveryNoteMaster.DeliveryNotePrinting(decDeliveryNoteMasterId, decCompanyId, decOrderId, decQuotationId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
       public bool DeliveryNoteCheckReferenceInSalesInvoice(decimal decDeliveryNoteMasterId)
       {
           bool isExist = false;
           try
           {
               isExist = spDeliveryNoteMaster.DeliveryNoteCheckReferenceInSalesInvoice(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       public decimal DeliveryNoteMasterDelete(decimal DeliveryNoteMasterId)
       {
           decimal deliveryNoteId = 0;
           try
           {
               deliveryNoteId = spDeliveryNoteMaster.DeliveryNoteMasterDelete(DeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return deliveryNoteId;
       }
       public List<DataTable> DeliveryNoteNoCorrespondingToLedger(decimal decledgerid, decimal decrejectioninmasterid, decimal decVoucherTypeId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.DeliveryNoteNoCorrespondingToLedger(decledgerid, decrejectioninmasterid, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public DeliveryNoteMasterInfo DeliveryNoteMasterView(decimal deliveryNoteMasterId)
       {
           DeliveryNoteMasterInfo deliverynotemasterinfo = new DeliveryNoteMasterInfo();
           try
           {
               deliverynotemasterinfo = spDeliveryNoteMaster.DeliveryNoteMasterView(deliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return deliverynotemasterinfo;
       }
       public List<DataTable> GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI(decLedgerId, decSalesMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> SalesInvoiceGridfillAgainestDeliveryNote(decimal DecDeliveryNoteMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.SalesInvoiceGridfillAgainestDeliveryNote(DecDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public bool DeliveryNoteMasterReferenceCheckRejectionIn(decimal decDeliveryNoteMasterId)
       {
           bool isExist = false;
           try
           {
               isExist = spDeliveryNoteMaster.DeliveryNoteMasterReferenceCheckRejectionIn(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       public List<DataTable> DeliveryNoteMasterReferenceCheckRejectionInQty(decimal decDeliveryNoteMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.DeliveryNoteMasterReferenceCheckRejectionInQty(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;

       }
       public List<DataTable> DeliveryNoteMasterReferenceCheckSalesInvoiceQty(decimal decDeliveryNoteMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDeliveryNoteMaster.DeliveryNoteMasterReferenceCheckSalesInvoiceQty(decDeliveryNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
    }
}
