//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    public class ProductBll
    {
        ProductInfo InfoProduct = new ProductInfo();
        ProductSP SPProduct = new ProductSP();
        public List<DataTable> ProductViewGridFillFromStockPosting(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductViewGridFillFromStockPosting(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductViewGridFillFromBatch(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductViewGridFillFromBatch(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal ProductAdd(ProductInfo productinfo)
        {
            decimal decId = 0;
            try
            {
                decId = SPProduct.ProductAdd(productinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public bool ProductEdit(ProductInfo productinfo)
        {
            bool isResult = false;
            try
            {
                isResult = SPProduct.ProductEdit(productinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal BatchReferenceCheckForProductEdit(decimal decProductId)
        {
            decimal decId = 0;
            try
            {
                decId = SPProduct.BatchReferenceCheckForProductEdit(decProductId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public bool ProductCodeCheckExistence(string strProductCode, decimal decProductId)
        {
            bool isResult = false;
            try
            {
                isResult = SPProduct.ProductCodeCheckExistence(strProductCode, decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public ProductInfo ProductView(decimal productId)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.ProductView(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public bool ProductReferenceCheck(decimal decProductId)
        {
            bool isResult = false;
            try
            {
                isResult = SPProduct.ProductReferenceCheck(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal DeleteProductWithReferenceCheck(decimal ProductId)
        {
            decimal decId = 0;
            try
            {
                decId = SPProduct.DeleteProductWithReferenceCheck(ProductId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public List<DataTable> ProductStatisticsFill(decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId,/*decimal decUnitId,*/ string strcriteria, string strBatchName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductStatisticsFill(decBrandId, decModelNoId, decSizeId, decGroupId, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DataSet ProductStatisticsReport(decimal decCompanyId, decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, /*decimal decUnitId,*/ string strcriteria, string strBatchName)
        {
            DataSet listObj = new DataSet();
            try
            {
                listObj = SPProduct.ProductStatisticsReport(decCompanyId,decBrandId,decModelNoId,decSizeId,decGroupId,strcriteria,strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductFinishedGoodsComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductFinishedGoodsComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> FinishedGoodsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.FinishedGoodsFillForStockJournal(decProductId, decQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> RawMaterialsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.RawMaterialsFillForStockJournal(decProductId, decQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductSearchForGriddFill(decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductSearchForGriddFill(decGodownId,decBrandId,decModelNoId,decRackId,decSizeId,decTaxId,decGroupId,strIsActive,strProductCode,strProductName, strcriteria,strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DataSet ProductSearchReport(decimal decCompanyId, decimal decGodownId, decimal decBrandId, decimal decModelNoId, decimal decRackId, decimal decSizeId, decimal decTaxId, decimal decGroupId, string strIsActive, string strProductCode, string strProductName, string strcriteria, string strBatchName)
        {
            DataSet listObj = new DataSet();
            try
            {
                listObj = SPProduct.ProductSearchReport(decCompanyId, decGodownId, decBrandId, decModelNoId, decRackId, decSizeId, decTaxId, decGroupId, strIsActive, strProductCode, strProductName, strcriteria, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductVsBatchReportGridFill(decimal voucherTypeId, string voucherNo, decimal groupId, string productCode, decimal batchId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductVsBatchReportGridFill(voucherTypeId, voucherNo, groupId, productCode, batchId, FromDate, ToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductCodeViewAll(ComboBox cmbProductCode, bool Isall)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductCodeViewAll(cmbProductCode, Isall);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductCodeViewAllForBarcodeCodePrinting(ComboBox cmbProductCode, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductCodeViewAllForBarcodeCodePrinting(cmbProductCode, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductSearchPopupViewAll(string strGroupName, string strProductCode, string strProductName, decimal decSize, decimal decModelNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductSearchPopupViewAll(strGroupName, strProductCode, strProductName, decSize, decModelNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal SalesInvoiceProductRateForSales(decimal decProductId, DateTime dtdate, decimal decBatchId, decimal decPricingLevelId, decimal decNoofDecplaces)
        {
            decimal decId = 0;
            try
            {
                decId = SPProduct.SalesInvoiceProductRateForSales(decProductId, dtdate, decBatchId, decPricingLevelId, decNoofDecplaces);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public List<DataTable> ProductCodeViewByProductName(string productName, decimal vouchertypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductCodeViewByProductName(productName, vouchertypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductNameViewByProductCode(string productCode, decimal decProductcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductNameViewByProductCode(productCode, decProductcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public ProductInfo ProductViewByCode(string strproductCode)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.ProductViewByCode(strproductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public List<DataTable> ProductRegisterSearch(decimal decGroupId, string strProductName, string strProductCode, decimal decSizeId, decimal decModelNoId,
            decimal decBrandId, decimal decTaxId, string strTaxApplicabel, decimal decSalseRateFrom, decimal decSalseRateTo, string strActive)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductRegisterSearch(decGroupId, strProductName, strProductCode, decSizeId, decModelNoId, decBrandId, decTaxId, strTaxApplicabel, decSalseRateFrom, decSalseRateTo, strActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public ProductInfo ProductViewForStandardRate(decimal decProductId)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.ProductViewForStandardRate(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public ProductInfo PriceListPopUpView(decimal decProductId)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.PriceListPopUpView(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public string ProductMax()
        {
            string strmx="";
            try
            {
                strmx = SPProduct.ProductMax();
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strmx;
        }
        public AutoCompleteStringCollection ProudctNameViewAllForAutoComplete()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                strCollection = SPProduct.ProudctNameViewAllForAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCollection;
        }
        public AutoCompleteStringCollection ProudctCodesViewAllForAutoComplete()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                strCollection = SPProduct.ProudctCodesViewAllForAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCollection;
        }
        public ProductInfo ProductViewByName(string strproductName)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.ProductViewByName(strproductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public List<DataTable> ProductDetailsCoreespondingToBarcode(string barcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductDetailsCoreespondingToBarcode(barcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public ProductInfo productViewByProductId(decimal decproductId)
        {
            ProductInfo InfoProduct = new ProductInfo();
            try
            {
                InfoProduct = SPProduct.productViewByProductId(decproductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoProduct;
        }
        public string BarcodeViewByBatchId(decimal decbatchId)
        {
            string strmx = "";
            try
            {
                strmx = SPProduct.BarcodeViewByBatchId(decbatchId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strmx;
        }
        public decimal BatchIdByPartNoOrBarcode(string strpartNo, string strbarcode)
        {
            decimal decId = 0;
            try
            {
                decId = SPProduct.BatchIdByPartNoOrBarcode(strpartNo, strbarcode);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public List<DataTable> ProductCodeAndBarcodeByBatchId(decimal decProductBatchId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductCodeAndBarcodeByBatchId(decProductBatchId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductDetailsCoreespondingToProductCode(string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductDetailsCoreespondingToProductCode(strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductDetailsCoreespondingToProductName(string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductDetailsCoreespondingToProductName(strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> VoucherWiseProductSearch(decimal decVoucherName, string strVoucherNo, DateTime fromdate, DateTime todate, decimal decGroup, string strProCode, decimal decLedger, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.VoucherWiseProductSearch(decVoucherName, strVoucherNo, fromdate, todate, decGroup, strProCode, decLedger, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ProductViewAllForComboBox()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPProduct.ProductViewAllForComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}
