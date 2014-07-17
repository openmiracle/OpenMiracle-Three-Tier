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
    public class ProductCreationBll
    {
        ProductSP spProduct = new ProductSP();
        /// <summary>
        /// Function to use the Product Search For GriddFill for updation
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <param name="decBrandId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decRackId"></param>
        /// <param name="decSizeId"></param>
        /// <param name="decTaxId"></param>
        /// <param name="decGroupId"></param>
        /// <param name="strIsActive"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <param name="strcriteria"></param>
        /// <returns></returns>
        public List<DataTable> ProductSearchForGriddFill(decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductSearchForGriddFill(decGodownId, decBrandId, decModelNoId, decRackId, decSizeId, decTaxId, decGroupId, strIsActive, strProductCode, strProductName, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Product Search Report to use the gridfill based on the search
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="decGodownId"></param>
        /// <param name="decBrandId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decRackId"></param>
        /// <param name="decSizeId"></param>
        /// <param name="decTaxId"></param>
        /// <param name="decGroupId"></param>
        /// <param name="strIsActive"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <param name="strcriteria"></param>
        /// <returns></returns>
        public DataSet ProductSearchReport(decimal decCompanyId, decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = spProduct.ProductSearchReport(decCompanyId, decGodownId, decBrandId, decModelNoId, decRackId, decSizeId, decTaxId, decGroupId, strIsActive, strProductCode, strProductName, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
        /// <summary>
        /// Product Finished Goods for ComboFill under stock journal
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductFinishedGoodsComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductFinishedGoodsComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        ///  Product RawMaterialsFill goods for ComboFill under stock journal
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decQty"></param>
        /// <returns></returns>
        public List<DataTable> RawMaterialsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.RawMaterialsFillForStockJournal(decProductId, decQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Finished Goods Fill For StockJournal form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decQty"></param>
        /// <returns></returns>
        public List<DataTable> FinishedGoodsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.RawMaterialsFillForStockJournal(decProductId, decQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get all the values from Product Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get the product code details
        /// </summary>
        /// <param name="cmbProductCode"></param>
        /// <param name="Isall"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewAll(ComboBox cmbProductCode, bool Isall)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductCodeViewAll(cmbProductCode, Isall);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Product Vs Batch for ReportGridFill
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <param name="voucherNo"></param>
        /// <param name="groupId"></param>
        /// <param name="productCode"></param>
        /// <param name="batchId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public List<DataTable> ProductVsBatchReportGridFill(decimal voucherTypeId, string voucherNo, decimal groupId, string productCode, decimal batchId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductVsBatchReportGridFill(voucherTypeId, voucherNo, groupId, productCode, batchId, FromDate, ToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from Product Table based on the parameter
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductInfo ProductView(decimal productId)
        {
            ProductInfo productinfo = new ProductInfo();
            try
            {
                productinfo = spProduct.ProductView(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return productinfo;
        }
        /// <summary>
        /// Function to use the product search details based on the parameter
        /// </summary>
        /// <param name="strGroupName"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <param name="decSize"></param>
        /// <param name="decModelNo"></param>
        /// <returns></returns>
        public List<DataTable> ProductSearchPopupViewAll(string strGroupName, string strProductCode, string strProductName, decimal decSize, decimal decModelNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductSearchPopupViewAll(strGroupName, strProductCode, strProductName, decSize, decModelNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Get the sles rate of the product for salesInvoice based on product and batch
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="dtdate"></param>
        /// <param name="decBatchId"></param>
        /// <param name="decPricingLevelId"></param>
        /// <param name="decNoofDecplaces"></param>
        /// <returns></returns>
        public decimal SalesInvoiceProductRateForSales(decimal decProductId, DateTime dtdate, decimal decBatchId, decimal decPricingLevelId, decimal decNoofDecplaces)
        {
            decimal decRate = 0;
            try
            {
                decRate = spProduct.SalesInvoiceProductRateForSales(decProductId, dtdate, decBatchId, decPricingLevelId, decNoofDecplaces);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decRate;
        }
        /// <summary>
        /// function to view the product details based on the product code
        /// </summary>
        /// <param name="strproductCode"></param>
        /// <returns></returns>
        public ProductInfo ProductViewByCode(string strproductCode)
        {
            ProductInfo productinfo = new ProductInfo();
            try
            {
                productinfo = spProduct.ProductViewByCode(strproductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return productinfo;
        }
        /// <summary>
        /// Here get the ProductCode  details By ProductName
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public string ProductCodeViewByProductName(string productName)
        {
            string productCode = string.Empty;
            try
            {
                productCode = spProduct.ProductCodeViewByProductName(productName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return productCode;
        }
        /// <summary>
        /// ProductViewByProductname
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="vouchertypeId"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewByProductName(string productName, decimal vouchertypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductCodeViewByProductName(productName, vouchertypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// productviewByProductcode
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="decProductcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductNameViewByProductCode(string productCode, decimal decProductcode)
        {

            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductNameViewByProductCode(productCode, decProductcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to fill the ProductStatistics form grid Fill
        /// </summary>
        /// <param name="decBrandId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decSizeId"></param>
        /// <param name="decGroupId"></param>
        /// <param name="strcriteria"></param>
        /// <returns></returns>
        public List<DataTable> ProductStatisticsFill(decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, string strcriteria, string strBatchName)
        {

            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductStatisticsFill(decBrandId, decModelNoId, decSizeId, decGroupId, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to print the ProductStatistics Report details based on the search
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="decBrandId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decSizeId"></param>
        /// <param name="decGroupId"></param>
        /// <param name="strcriteria"></param>
        /// <returns></returns>
        public DataSet ProductStatisticsReport(decimal decCompanyId, decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, string strcriteria, string strBatchName)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spProduct.ProductStatisticsReport(decCompanyId, decBrandId, decModelNoId, decSizeId, decGroupId, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        /// <summary>
        /// ProductCode ViewAll For BarcodeCode Printing
        /// </summary>
        /// <param name="cmbProductCode"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewAllForBarcodeCodePrinting(ComboBox cmbProductCode, bool isAll)
        {

            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductCodeViewAllForBarcodeCodePrinting(cmbProductCode, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Get the sles rate of the product for POS based on product and batch
        /// </summary>
        /// <param name="strProductId"></param>
        /// <param name="date"></param>
        /// <param name="decBatchId"></param>
        /// <param name="decNoofDecplaces"></param>
        /// <returns></returns>
        public decimal ProductRateForSales(decimal strProductId, DateTime date, decimal decBatchId, decimal decNoofDecplaces)
        {
            decimal dcRate = 0;
            try
            {
                dcRate = spProduct.ProductRateForSales(strProductId, date, decBatchId, decNoofDecplaces);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dcRate;
        }
        /// <summary>
        /// Here get the Barcode ViewBy ProductCode
        /// </summary>
        /// <param name="strproductCode"></param>
        /// <returns></returns>
        public ProductBatchInfo BarcodeViewByProductCode(string strproductCode)
        {
            ProductBatchInfo infoProductBatch = new ProductBatchInfo();
            try
            {
                infoProductBatch = spProduct.BarcodeViewByProductCode(strproductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoProductBatch;
        }
        /// <summary>
        /// PriceList PopUp View based on productId
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public ProductInfo PriceListPopUpView(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            try
            {
                infoProduct = spProduct.PriceListPopUpView(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoProduct;
        }
        /// <summary>
        /// Product details view all for combobox fill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAllForComboBox()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductViewAllForComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Change Product Tax  to save
        /// </summary>
        /// <param name="productinfo"></param>
        public void ChangeProductTaxSave(ProductInfo productinfo)
        {
            try
            {
                spProduct.ChangeProductTaxSave(productinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ProductView All Without One Product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProductViewAllWithoutOneProduct(decimal decProductId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductViewAllWithoutOneProduct(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Product details View For StandardRate form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public ProductInfo ProductViewForStandardRate(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            try
            {
                infoProduct = spProduct.ProductViewForStandardRate(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoProduct;
        }
        /// <summary>
        /// function to use the product register search based on the partameter
        /// </summary>
        /// <param name="decGroupId"></param>
        /// <param name="strProductName"></param>
        /// <param name="strProductCode"></param>
        /// <param name="decSizeId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decBrandId"></param>
        /// <param name="decTaxId"></param>
        /// <param name="strTaxApplicabel"></param>
        /// <param name="decSalseRateFrom"></param>
        /// <param name="decSalseRateTo"></param>
        /// <param name="strActive"></param>
        /// <returns></returns>
        public List<DataTable> ProductRegisterSearch(decimal decGroupId, string strProductName, string strProductCode, decimal decSizeId, decimal decModelNoId,
            decimal decBrandId, decimal decTaxId, string strTaxApplicabel, decimal decSalseRateFrom, decimal decSalseRateTo, string strActive)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductRegisterSearch(decGroupId, strProductName, strProductCode, decSizeId, decModelNoId, decBrandId, decTaxId, strTaxApplicabel, decSalseRateFrom, decSalseRateTo, strActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to ProudctCodes ViewAll For AutoCompletion
        /// </summary>
        /// <returns></returns>
        public AutoCompleteStringCollection ProudctCodesViewAllForAutoComplete()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                strCollection = spProduct.ProudctCodesViewAllForAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCollection;
        }
        /// <summary>
        /// Function to ProudctName View All For AutoCompletion
        /// </summary>
        /// <returns></returns>
        public AutoCompleteStringCollection ProudctNameViewAllForAutoComplete()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                strCollection = spProduct.ProudctCodesViewAllForAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCollection;
        }
        /// <summary>
        /// Product ViewAll For Batch By AllowBatch for updation
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAllForBatchByAllowBatch()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProduct.ProductViewAllForBatchByAllowBatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to insert values to Product Table
        /// </summary>
        /// <param name="productinfo"></param>
        /// <returns></returns>
        public decimal ProductAdd(ProductInfo productinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spProduct.ProductAdd(productinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Here ProductCode CheckExistence for updation
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public bool ProductCodeCheckExistence(string strProductCode, decimal decProductId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spProduct.ProductCodeCheckExistence(strProductCode, decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Get the ProductMax for next updation
        /// </summary>
        /// <returns></returns>
        public string ProductMax()
        {
            string str = string.Empty;
            try
            {
                str = spProduct.ProductMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return str;
        }
        /// <summary>
        /// here get the Product Details Coreesponding To Barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsCoreespondingToBarcode(string barcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductDetailsCoreespondingToBarcode(barcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// here get the Product Details Coreesponding To Barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsCoreespondingToProductCode(string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductDetailsCoreespondingToProductCode(strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// here get the Product Details Coreesponding To Barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsCoreespondingToProductName(string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductDetailsCoreespondingToProductName(strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Product View GridFill From StockPosting
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProductViewGridFillFromStockPosting(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductViewGridFillFromStockPosting(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Product View Grid Fill function From Batch form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProductViewGridFillFromBatch(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductViewGridFillFromBatch(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to Update values in Product Table
        /// </summary>
        /// <param name="productinfo"></param>
        /// <returns></returns>
        public bool ProductEdit(ProductInfo productinfo)
        {
            bool isResult = false;
            try
            {
                isResult = spProduct.ProductEdit(productinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        /// <summary>
        /// Function to check reference for edit
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <returns></returns>
        public decimal BatchReferenceCheckForProductEdit(decimal decProductId)
        {
            decimal decStatus = 0;
            try
            {
                decStatus = spProduct.BatchReferenceCheckForProductEdit(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decStatus;
        }
        /// <summary>
        /// Product ReferenceCheck for updation
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public bool ProductReferenceCheck(decimal decProductId)
        {
            bool isReferenceExist = false;
            try
            {
                isReferenceExist = spProduct.ProductReferenceCheck(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isReferenceExist;
        }
        /// <summary>
        /// Delete Product With Reference Check
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public decimal DeleteProductWithReferenceCheck(decimal ProductId)
        {
            decimal decCheck = 0;
            try
            {
                decCheck = spProduct.DeleteProductWithReferenceCheck(ProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCheck;
        }
        /// <summary>
        /// product details view by productname for fill other forms
        /// </summary>
        /// <param name="strproductName"></param>
        /// <returns></returns>
        public ProductInfo ProductViewByName(string strproductName)
        {
            ProductInfo productinfo = new ProductInfo();
            try
            {
                productinfo = spProduct.ProductViewByName(strproductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return productinfo;
        }
        /// <summary>
        /// Function to get the barcode using batchId
        /// </summary>
        /// <param name="decbatchId"></param>
        /// <returns></returns>
        public string BarcodeViewByBatchId(decimal decbatchId)
        {
            string strBatchId = string.Empty;
            try
            {
                strBatchId = spProduct.BarcodeViewByBatchId(decbatchId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strBatchId;
        }
        /// <summary>
        /// function to get the batch id by using part no or barcode
        /// </summary>
        /// <param name="strpartNo"></param>
        /// <param name="strbarcode"></param>
        /// <returns></returns>
        public decimal BatchIdByPartNoOrBarcode(string strpartNo, string strbarcode)
        {
            decimal decBatchId = 0;
            try
            {
                decBatchId = spProduct.BatchIdByPartNoOrBarcode(strpartNo, strbarcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decBatchId;
        }
        /// <summary>
        /// ProductCode And Barcode By BatchId
        /// </summary>
        /// <param name="decProductBatchId"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeAndBarcodeByBatchId(decimal decProductBatchId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductCodeAndBarcodeByBatchId(decProductBatchId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to use the VoucherWise Product Search form gridfill
        /// </summary>
        /// <param name="decVoucherName"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="decGroup"></param>
        /// <param name="strProCode"></param>
        /// <param name="decLedger"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> VoucherWiseProductSearch(decimal decVoucherName, string strVoucherNo, DateTime fromdate, DateTime todate, decimal decGroup, string strProCode, decimal decLedger, string strProductName)
        {

            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.VoucherWiseProductSearch(decVoucherName, strVoucherNo, fromdate, todate, decGroup, strProCode, decLedger, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get Product Tax for Search
        /// </summary>
        /// <param name="infoProduct"></param>
        /// <param name="inSelect"></param>
        /// <returns></returns>
        public List<DataTable> ChangeProductTaxSearch(ProductInfo infoProduct, int inSelect)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ChangeProductTaxSearch(infoProduct, inSelect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// product View By ProductId
        /// </summary>
        /// <param name="decproductId"></param>
        /// <returns></returns>
        public ProductInfo productViewByProductId(decimal decproductId)
        {
            ProductInfo infoproduct = new ProductInfo();
            try
            {
                infoproduct = spProduct.productViewByProductId(decproductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoproduct;
        }
        /// <summary>
        /// function to use the Product Details For Product Search
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsForProductSearch(decimal productId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProduct.ProductDetailsForProductSearch(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Get the unit of the product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public string ProductUnit(decimal decProductId)
        {
            string strUnit = string.Empty; 
            try
            {
                strUnit = spProduct.ProductUnit(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PC48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strUnit;
        }
    }
} 

