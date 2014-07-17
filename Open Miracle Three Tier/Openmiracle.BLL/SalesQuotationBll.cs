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
    public class SalesQuotationBll
    {
        SalesQuotationDetailsSP spSalesQuotationDetails = new SalesQuotationDetailsSP();
        SalesQuotationMasterSP spSalesQuotationMaster = new SalesQuotationMasterSP();
        public List<DataTable> VoucherTypeCombofillforSalesQuotationReport()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationDetails.VoucherTypeCombofillforSalesQuotationReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal SalesQuotationDetailsDelete(decimal decQuotationDetailsId)
        {
            decimal decResult = 0;
            try
            {
                decResult = spSalesQuotationDetails.SalesQuotationDetailsDelete(decQuotationDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public decimal UnitconversionIdViewByUnitIdAndProductId(decimal decunitId, decimal decproductId)
        {
            decimal decValue = 0;
            try
            {
                decValue = spSalesQuotationDetails.UnitconversionIdViewByUnitIdAndProductId(decunitId, decproductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decValue;
        }
        public void SalesQuotationDetailsEdit(SalesQuotationDetailsInfo infoSalesQuotationDetails)
        {
            try
            {
                spSalesQuotationDetails.SalesQuotationDetailsEdit(infoSalesQuotationDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SalesQuotationDetailsAdd(SalesQuotationDetailsInfo infoSalesQuotationDetails)
        {
            try
            {
                spSalesQuotationDetails.SalesQuotationDetailsAdd(infoSalesQuotationDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool SalesQuotationRefererenceCheckForEditDetails(decimal decSalesQuotationDetailsId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spSalesQuotationDetails.SalesQuotationRefererenceCheckForEditDetails(decSalesQuotationDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public List<DataTable> SalesQuotationDetailsViewByMasterId(decimal decSalesQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationDetails.SalesQuotationDetailsViewByMasterId(decSalesQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal SalesQuatationReferenceCheck(decimal decSalesQuotationDeatilsId)
        {
            decimal decQty = 0;
            try
            {
                decQty = spSalesQuotationDetails.SalesQuatationReferenceCheck(decSalesQuotationDeatilsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decQty;
        }
        public List<DataTable> GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesQuotationReportSearch(string strVoucherNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition, decimal EmployeeId, decimal voucherTypeId, string ProductCode)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.SalesQuotationReportSearch(strVoucherNo, decLedgerId, FromDate, ToDate, strCondition, EmployeeId, voucherTypeId, ProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedgerForDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decDeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.GetSalesQuotationNumberCorrespondingToLedgerForDN(decLedgerId, decVoucherTypeId, decDeliveryNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedger(decimal decLedgerId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.GetSalesQuotationNumberCorrespondingToLedger(decLedgerId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public DataSet SalesQuotationPrinting(decimal decSalesQuotationMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spSalesQuotationMaster.SalesQuotationPrinting(decSalesQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public decimal SalesQuotationMasterGetMax(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                decMax = spSalesQuotationMaster.SalesQuotationMaxGetPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMax;
        }
        public decimal SalesQuotationMaxGetPlusOne(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                decMax = spSalesQuotationMaster.SalesQuotationMaxGetPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMax;
        }
        public List<DataTable> SalesQuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.SalesQuotationMasterViewByQuotationMasterId(decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(decimal decQuotationMasterId, decimal decDeliveryNoteId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationDetails.SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(decQuotationMasterId, decDeliveryNoteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesInvoiceGridfillAgainestQuotation(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.SalesInvoiceGridfillAgainestQuotation(decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public string VoucherNoMax(decimal decVoucherTypeId)
        {
            string strMax = "0";
            try
            {
                strMax = spSalesQuotationMaster.VoucherNoMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strMax;
        }
        public decimal SalesQuotationMasterAdd(SalesQuotationMasterInfo infoSalesQuotationMaster)
        {
            decimal decSalesQuotationmasterIdentity = 0;
            try
            {
                decSalesQuotationmasterIdentity = spSalesQuotationMaster.SalesQuotationMasterAdd(infoSalesQuotationMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decSalesQuotationmasterIdentity;
        }
        public bool SalesQuotationRefererenceCheckForEditMaster(decimal decSalesQuotationMasterId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spSalesQuotationMaster.SalesQuotationRefererenceCheckForEditMaster(decSalesQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public void SalesQuotationMasterEdit(SalesQuotationMasterInfo infoSalesQuotationMaster)
        {
            try
            {
                spSalesQuotationMaster.SalesQuotationMasterEdit(infoSalesQuotationMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal SalesQuotationMasterDelete(decimal decQuotationMasterId)
        {
            decimal decResult = 0;
            try
            {
                decResult = spSalesQuotationMaster.SalesQuotationMasterDelete(decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public bool CheckSalesQuotationNumberExistance(string strInvoiceNo, decimal decSalesQuotationVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                isEdit=spSalesQuotationMaster.CheckSalesQuotationNumberExistance( strInvoiceNo,  decSalesQuotationVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public SalesQuotationMasterInfo SalesQuotationMasterView(decimal decQuotationMasterId)
        {
            SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
            try
            {
                infoSalesQuotationMaster = spSalesQuotationMaster.SalesQuotationMasterView(decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoSalesQuotationMaster;
        }
        public decimal CheckingStastusForSalesQuotation(decimal decSaleQuotationMasterId)
        {
            decimal decCount = 0;
            try
            {
                decCount = spSalesQuotationMaster.CheckingStastusForSalesQuotation(decSaleQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCount;
        }
        public List<DataTable> SalesQuotationMasterBatchFill(DataGridView dgvproduct, decimal DecProductId, int InRowIndex)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.SalesQuotationMasterBatchFill(dgvproduct, DecProductId, InRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> QuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.QuotationMasterViewByQuotationMasterId(decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedgerForSO(decimal decLedgerId, decimal decVoucherTypeId, decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.GetSalesQuotationNumberCorrespondingToLedgerForSO(  decLedgerId,   decVoucherTypeId,   decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj=spSalesQuotationMaster.GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI( decLedgerId,  decSalesMasterId,  decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails(decimal decQuotationMasterId, decimal salesOrderMasterId, decimal voucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationDetails.SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails( decQuotationMasterId,  salesOrderMasterId,  voucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO(decimal decQuotationMasterId, decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationDetails.SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO(decQuotationMasterId, decSalesOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalesQuotationRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalesQuotationMaster.SalesQuotationRegisterSearch( strInvoiceNo,  decLedgerId,  FromDate,  ToDate,  strCondition);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQBLL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
    }
}
 
