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
    public class SalesInvoiceBll
    {
        SalesBillTaxInfo InfoSalesBillTax = new SalesBillTaxInfo();
        SalesBillTaxSP SPSalesBillTax = new SalesBillTaxSP();
        SalesDetailsInfo InfoSalesDetails = new SalesDetailsInfo();
        SalesDetailsSP SPSalesDetails = new SalesDetailsSP();
        SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
        SalesMasterSP SPSalesMaster = new SalesMasterSP();
        ProductInfo InfoProduct = new ProductInfo();

        public decimal SalesBillTaxAdd(SalesBillTaxInfo salesbilltaxinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesBillTax.SalesBillTaxAdd(salesbilltaxinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public void SalesBillTaxEditBySalesMasterIdAndTaxId(SalesBillTaxInfo salesbilltaxinfo)
        {
            try
            {
                SPSalesBillTax.SalesBillTaxEditBySalesMasterIdAndTaxId(salesbilltaxinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decimal dcSalesmasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesBillTax.SalesInvoiceSalesBillTaxViewAllBySalesMasterId(dcSalesmasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> VoucherTypeNameComboFillForSalesInvoiceRegister()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.VoucherTypeNameComboFillForSalesInvoiceRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> voucherNoViewAllByVoucherTypeIdForSi(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.voucherNoViewAllByVoucherTypeIdForSi(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesReturnGrideFillNewByProductId(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesReturnGrideFillNewByProductId(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public void SalesDetailsAdd(SalesDetailsInfo salesdetailsinfo)
        {
            try
            {
                SPSalesDetails.SalesDetailsAdd(salesdetailsinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SalesDetailsDelete(decimal SalesDetailsId)
        {
            try
            {
                SPSalesDetails.SalesDetailsDelete(SalesDetailsId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SalesDetailsEdit(SalesDetailsInfo salesdetailsinfo)
        {
            try
            {
                SPSalesDetails.SalesDetailsEdit(salesdetailsinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> SalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesDetailsViewBySalesMasterId(dcSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BankOrCashComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.BankOrCashComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.VoucherTypesBasedOnTypeOfVouchers(typeOfVouchers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesInvoiceDetailsViewByProductCodeForSI(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesInvoiceDetailsViewByProductCodeForSI(decVoucherTypeId, strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesInvoiceDetailsViewByProductNameForSI(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesInvoiceDetailsViewByProductNameForSI(decVoucherTypeId, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesInvoiceDetailsViewByBarcodeForSI(decimal decVoucherTypeId, string strBarcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesInvoiceDetailsViewByBarcodeForSI(decVoucherTypeId, strBarcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesInvoiceSalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesInvoiceSalesDetailsViewBySalesMasterId(dcSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal SalesInvoiceReciptVoucherDetailsAgainstSI(decimal decvoucherTypeId, string strvoucherNo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesDetails.SalesInvoiceReciptVoucherDetailsAgainstSI(decvoucherTypeId, strvoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public List<DataTable> SalesInvoiceRegisterGridfill(DateTime dtFrom, DateTime dtTo, decimal decVoucherType, decimal decLedgerId, string strVoucherNo, string strSalesMode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesInvoiceRegisterGridfill(dtFrom, dtTo, decVoucherType, decLedgerId, strVoucherNo, strSalesMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesInvoiceReportFill(DateTime dtfromDate, DateTime dttoDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decAreaId, string strSalesMode, decimal decEmployeeId, string strProductName, string strVoucherNo, string strstatus, decimal decRouteId, decimal decModelNoId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesInvoiceReportFill(dtfromDate,dttoDate,decVoucherTypeId,decLedgerId,decAreaId,strSalesMode,decEmployeeId,strProductName,strVoucherNo,strstatus,decRouteId,decModelNoId,strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> FreeSaleReportGridFill(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.FreeSaleReportGridFill(fromDate, toDate, voucherNo, voucherTypeId, groupId, productCode, ledgerId, decEmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DataSet salesInvoiceReportPrint(DateTime fromDate, DateTime toDate, decimal voucherTypeId, decimal ledgerId, decimal areaId, string salesMode, decimal employeeId, string productName, string voucherNo, string status, decimal routeId, decimal modelnoId, string productCode, decimal companyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPSalesMaster.salesInvoiceReportPrint(fromDate, toDate, voucherTypeId, ledgerId, areaId, salesMode, employeeId, productName, voucherNo, status, routeId, modelnoId, productCode, companyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public List<DataTable> SalesDetailsViewForSalesReturnGrideFill(decimal salesMasterId, decimal salesReturnMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesDetailsViewForSalesReturnGrideFill(salesMasterId, salesReturnMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> SalesDetailsViewForSalesReturnGrideFill1(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesDetails.SalesDetailsViewForSalesReturnGrideFill1(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public SalesMasterInfo SalesMasterViewBySalesMasterId(decimal salesMasterId)
        {
            try
            {
                InfoSalesMaster = SPSalesMaster.SalesMasterViewBySalesMasterId(salesMasterId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoSalesMaster;
        }
        public DataSet FreeSaleReportPrint(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPSalesMaster.FreeSaleReportPrint(fromDate, toDate, voucherNo, voucherTypeId, groupId, productCode, ledgerId, decEmployeeId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public List<DataTable> SalesMasterViewByInvoiceNoForComboSelection(decimal salesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesMasterViewByInvoiceNoForComboSelection(salesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal SalesMasterVoucherMax(decimal decVoucherTypeId)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesMasterVoucherMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public List<DataTable> SalesInvoiceSalesAccountModeComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesInvoiceSalesAccountModeComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public ProductInfo ProductViewByProductIdforSalesInvoice(string strproductCode)
        {
            try
            {
                InfoProduct = SPSalesMaster.ProductViewByProductIdforSalesInvoice(strproductCode);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public bool SalesInvoiceInvoiceNumberCheckExistence(string strvoucherNo, decimal decsalesMasterId, decimal decVoucherTypeId)
        {
            bool isResult = false;
            try
            {
                isResult = SPSalesMaster.SalesInvoiceInvoiceNumberCheckExistence(strvoucherNo, decsalesMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal SalesMasterAdd(SalesMasterInfo salesmasterinfo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesMasterAdd(salesmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public bool SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(decimal decPartyId)
        {
            bool isResult = false;
            try
            {
                isResult = SPSalesMaster.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(decPartyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public DataSet salesInvoicePrintAfterSave(decimal decsalesMasterId, decimal decCompanyId, decimal decOrderMasterId, decimal decDeliveryNoteMasterId, decimal decQuotationMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SPSalesMaster.salesInvoicePrintAfterSave(decsalesMasterId, decCompanyId, decOrderMasterId, decDeliveryNoteMasterId, decQuotationMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public void SalesMasterEdit(SalesMasterInfo salesmasterinfo)
        {
            try
            {
                SPSalesMaster.SalesMasterEdit(salesmasterinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal SalesInvoiceReferenceCheckForEdit(decimal decSalesMasterId)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesInvoiceReferenceCheckForEdit(decSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public List<DataTable> POSSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.POSSalesMasterViewBySalesMasterId(decSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public void SalesInvoiceDelete(decimal decSalesMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                SPSalesMaster.SalesInvoiceDelete(decSalesMasterId, decVoucherTypeId, strVoucherNo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> SalesInvoiceSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesInvoiceSalesMasterViewBySalesMasterId(decSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public SalesMasterInfo SalesMasterView(decimal salesMasterId)
        {
            try
            {
                InfoSalesMaster = SPSalesMaster.SalesMasterView(salesMasterId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoSalesMaster;
        }
        public decimal SalesInvoiceQuantityDetailsAgainstSalesReturn(decimal decvoucherTypeId, string strvoucherNo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesInvoiceQuantityDetailsAgainstSalesReturn(decvoucherTypeId, strvoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public int SalseMasterReferenceCheck(decimal decSalesMsterId, decimal decSalesDetailsId)
        {
            int inCount = 0;
            try
            {
                inCount = SPSalesMaster.SalseMasterReferenceCheck(decSalesMsterId, decSalesDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inCount;
        }
        public bool SalesReturnCheckReferenceForSIDelete(decimal decSalesMasterId)
        {
            bool isResult = false;
            try
            {
                isResult = SPSalesMaster.SalesReturnCheckReferenceForSIDelete(decSalesMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal SalesReturnDetailsQtyViewBySalesDetailsId(decimal decSalseDetailsId)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesReturnDetailsQtyViewBySalesDetailsId(decSalseDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public List<DataTable> SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType(decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> salesinvoiceAdditionalCostCheckdrOrCrforSiEdit(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPSalesMaster.salesinvoiceAdditionalCostCheckdrOrCrforSiEdit(decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool DayBookSalesInvoiceOrPOS(decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            bool isResult = false;
            try
            {
                isResult = SPSalesMaster.DayBookSalesInvoiceOrPOS(decSalesMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal SalesMasterIdViewByvoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo)
        {
            decimal decCompanyId = 0;
            try
            {
                decCompanyId = SPSalesMaster.SalesMasterIdViewByvoucherNoAndVoucherType(decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCompanyId;
        }
        public string SaleMasterGetPos(decimal saleMasterId, string voucherName)
        {
            string strmasterpos = "";
            try
            {
                strmasterpos = SPSalesMaster.SaleMasterGetPos(saleMasterId, voucherName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strmasterpos;
        }

    }
}
