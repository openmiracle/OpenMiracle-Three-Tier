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
     public class SalesReturnBll
    {
         SalesReturnBillTaxSP spSalesReturnBillTax = new SalesReturnBillTaxSP();
         SalesReturnDetailsSP spSalesReturnDetails = new SalesReturnDetailsSP();
         SalesReturnMasterSP spSalesReturnMaster = new SalesReturnMasterSP();
         public List<DataTable> TaxDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesReturnBillTax.TaxDetailsViewBySalesReturnMasterId(decSalesReturnMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return ListObj;
        }
         public void SalesReturnBillTaxDeleteBySalesReturnMasterId(decimal decSalesReturnMasterId)
         {
             try
             {
                 spSalesReturnBillTax.SalesReturnBillTaxDeleteBySalesReturnMasterId(decSalesReturnMasterId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }
         public void SalesReturnBillTaxAdd(SalesReturnBillTaxInfo infoSalesReturnBiill)
         {
             try
             {
                 spSalesReturnBillTax.SalesReturnBillTaxAdd(infoSalesReturnBiill);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }
         public List<DataTable> SalesReturnDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnDetails.SalesReturnDetailsViewBySalesReturnMasterId(decSalesReturnMasterId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public void SalesReturnDetailsDelete(decimal decimalSalesReturnDetailsId)
         {
             try
             {
                 spSalesReturnDetails.SalesReturnDetailsDelete(decimalSalesReturnDetailsId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }
         public List<DataTable> productviewbybarcodeforSR(string strProductCode, decimal decVoucherTypeId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnDetails.productviewbybarcodeforSR(strProductCode, decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public void SalesReturnDetailsEdit(SalesReturnDetailsInfo infoSalesReturnDetails)
         {
             try
             {
                 spSalesReturnDetails.SalesReturnDetailsEdit(infoSalesReturnDetails);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }
         public decimal SalesReturnDetailsAdd(SalesReturnDetailsInfo infoSalesReturnDetails)
         {
             decimal decSalesReturnDetailsId = 0;
             try
             {
                 decSalesReturnDetailsId = spSalesReturnDetails.SalesReturnDetailsAdd(infoSalesReturnDetails);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return decSalesReturnDetailsId;
         }
         public List<DataTable> SalesReturnMasterViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.SalesReturnMasterViewBySalesReturnMasterId(decSalesReturnMasterId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public List<DataTable> SalesReturnMasterViewBySalesMasterId(decimal decSalesMasterId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.SalesReturnMasterViewBySalesMasterId(decSalesMasterId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public void SalesReturnDelete(decimal decSalesReturnMasterId, decimal decVoucherTypeId, string strVoucherNo)
         {
             try
             {
                 spSalesReturnMaster.SalesReturnDelete(decSalesReturnMasterId, decVoucherTypeId, strVoucherNo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }

         }
         public DataSet SalesReturnPrinting(decimal decSalesReturnMasterId)
         {
             DataSet ds = new DataSet();
             try
             {
                 ds = spSalesReturnMaster.SalesReturnPrinting(decSalesReturnMasterId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ds;
         }
         public bool SalesReturnNumberCheckExistence(string strinvoiceNo, decimal decSalesReturnMasterId, decimal decVoucherTypeId)
         {
             bool isEdit = false;
             try
             {
                 isEdit = spSalesReturnMaster.SalesReturnNumberCheckExistence(strinvoiceNo, decSalesReturnMasterId, decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return isEdit;
         }
         public string TaxRateFindForTaxAmmountCalByTaxId(decimal dectaxId)
         {
             string strTaxRate = string.Empty; ;
             try
             {
                 strTaxRate = spSalesReturnMaster.TaxRateFindForTaxAmmountCalByTaxId(dectaxId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return strTaxRate;
         }
         public List<DataTable> SalesReturnInvoiceNoComboFill(decimal decVoucherTypeId, decimal salesReturnMasterId, decimal decledgerId)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.SalesReturnInvoiceNoComboFill(decVoucherTypeId, salesReturnMasterId, decledgerId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public List<DataTable> SalesReturnVoucherTypeComboFill(decimal ledgerIdFromCashOrPartyCombo)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.SalesReturnVoucherTypeComboFill(ledgerIdFromCashOrPartyCombo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public List<DataTable> vouchertypecompofill()
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.vouchertypecompofill();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return ListObj;
         }
         public decimal SalesReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
         {
             decimal decMax = 0;
             try
             {
                 decMax = spSalesReturnMaster.SalesReturnMasterGetMaxPlusOne(decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             return decMax;
         }
         public void SalesReturnMasterEdit(SalesReturnMasterInfo infoSalesReturnMaster)
         {
             try
             {
                 spSalesReturnMaster.SalesReturnMasterEdit(infoSalesReturnMaster);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }
         public decimal SalesReturnMasterAdd(SalesReturnMasterInfo infoSalesReturnMaster)
         {
             decimal decIdentity = 0;
             try
             {
                 decIdentity = spSalesReturnMaster.SalesReturnMasterAdd(infoSalesReturnMaster);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return decIdentity;
         }
         //public decimal SalesReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
         //{
         //    decimal decMax = 0;
         //    try
         //    {
         //        decMax = spSalesReturnMaster.SalesReturnMasterGetMaxPlusOne(decVoucherTypeId);
         //    }
         //    catch (Exception ex)
         //    {
         //        MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
         //    }
         //    return decMax;
         //}
         public string SalesReturnMasterGetMax(decimal decVoucherTypeId)
         {
             string strMax = "0";
             try
             {
                 strMax = spSalesReturnMaster.SalesReturnMasterGetMax(decVoucherTypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return strMax;
         }
         public void VoucherTypeComboFillOfSalesReturnReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
         {
             try
             {
                 spSalesReturnMaster.VoucherTypeComboFillOfSalesReturnReport(cmbVoucherType, strVoucherType, isAll);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public List<DataTable> invoicenumberviewallforvouchertypeIdforSR(decimal decVouchertypeId)
         {

             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.invoicenumberviewallforvouchertypeIdforSR(decVouchertypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public List<DataTable> SalesReturnRegisterGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decvouchertypeId)
         {

             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj = spSalesReturnMaster.SalesReturnRegisterGrideFill( fromDate,  toDate,  decLedgerId,  strInvoiceNo,  decAgainstInvoiceNo,  decvouchertypeId);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public void SalesReturnNoComboFillOfSalesReturnRegister(ComboBox cmbSalesReturnNo, bool isAll)
         {
             try
             {
                 spSalesReturnMaster.SalesReturnNoComboFillOfSalesReturnRegister(cmbSalesReturnNo, isAll);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public void InvoiceNoComboFillOfSalesReturnRegister(ComboBox cmbInvoiceNo, bool isAll)
         {
             try
             {
                 spSalesReturnMaster.InvoiceNoComboFillOfSalesReturnRegister(cmbInvoiceNo, isAll);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public void SalesManComboFillOfSalesReturnReport(ComboBox cmbSalesMan, bool isAll)
         {
             try
             {
                 spSalesReturnMaster.InvoiceNoComboFillOfSalesReturnRegister(cmbSalesMan, isAll);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }
         public List<DataTable> SalesReturnReportGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decEmployeeId, string strProductCode, string strVoucherNo)
         {
             List<DataTable> ListObj = new List<DataTable>();
             try
             {
                 ListObj=spSalesReturnMaster.SalesReturnReportGrideFill(fromDate, toDate, decLedgerId, decVoucherTypeId, decEmployeeId, strProductCode, strVoucherNo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ListObj;
         }
         public DataSet SalesReturnReportPrinting(DateTime fromDate, DateTime toDate, decimal decSalesMan, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, string strProductCode)
         {
             DataSet ds = new DataSet();
             try
             {
                 ds = spSalesReturnMaster.SalesReturnReportPrinting( fromDate,  toDate,  decSalesMan,  decCashOrParty,  strVoucherNo,  decVoucherTypeName,  strProductCode);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             return ds;
         }
    }
}
