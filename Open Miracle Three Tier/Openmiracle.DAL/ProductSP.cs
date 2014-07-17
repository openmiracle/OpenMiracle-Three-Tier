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
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
//<summary>    
//Summary description for ProductSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ProductSP : DBConnection
    {
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productinfo.ProductCode;
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = productinfo.ProductName;
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.GroupId;
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.BrandId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.SizeId;
                sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ModelNoId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar);
                sprmparam.Value = productinfo.TaxapplicableOn;
                sprmparam = sccmd.Parameters.Add("@purchaseRate", SqlDbType.Decimal);
                sprmparam.Value = productinfo.PurchaseRate;
                sprmparam = sccmd.Parameters.Add("@salesRate", SqlDbType.Decimal);
                sprmparam.Value = productinfo.SalesRate;
                sprmparam = sccmd.Parameters.Add("@mrp", SqlDbType.Decimal);
                sprmparam.Value = productinfo.Mrp;
                sprmparam = sccmd.Parameters.Add("@minimumStock", SqlDbType.Decimal);
                sprmparam.Value = productinfo.MinimumStock;
                sprmparam = sccmd.Parameters.Add("@maximumStock", SqlDbType.Decimal);
                sprmparam.Value = productinfo.MaximumStock;
                sprmparam = sccmd.Parameters.Add("@reorderLevel", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ReorderLevel;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@isallowBatch", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsallowBatch;
                sprmparam = sccmd.Parameters.Add("@ismultipleunit", SqlDbType.Bit);
                sprmparam.Value = productinfo.Ismultipleunit;
                sprmparam = sccmd.Parameters.Add("@isBom", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsBom;
                sprmparam = sccmd.Parameters.Add("@isopeningstock", SqlDbType.Bit);
                sprmparam.Value = productinfo.Isopeningstock;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@isshowRemember", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsshowRemember;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = productinfo.ExtraDate;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in Product Table
        /// </summary>
        /// <param name="productinfo"></param>
        /// <returns></returns>
        public bool ProductEdit(ProductInfo productinfo)
        {
            decimal decCheck = 0;
            bool isResult = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productinfo.ProductCode;
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = productinfo.ProductName;
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.GroupId;
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.BrandId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.SizeId;
                sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ModelNoId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar);
                sprmparam.Value = productinfo.TaxapplicableOn;
                sprmparam = sccmd.Parameters.Add("@purchaseRate", SqlDbType.Decimal);
                sprmparam.Value = productinfo.PurchaseRate;
                sprmparam = sccmd.Parameters.Add("@salesRate", SqlDbType.Decimal);
                sprmparam.Value = productinfo.SalesRate;
                sprmparam = sccmd.Parameters.Add("@mrp", SqlDbType.Decimal);
                sprmparam.Value = productinfo.Mrp;
                sprmparam = sccmd.Parameters.Add("@minimumStock", SqlDbType.Decimal);
                sprmparam.Value = productinfo.MinimumStock;
                sprmparam = sccmd.Parameters.Add("@maximumStock", SqlDbType.Decimal);
                sprmparam.Value = productinfo.MaximumStock;
                sprmparam = sccmd.Parameters.Add("@reorderLevel", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ReorderLevel;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@isallowBatch", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsallowBatch;
                sprmparam = sccmd.Parameters.Add("@ismultipleunit", SqlDbType.Bit);
                sprmparam.Value = productinfo.Ismultipleunit;
                sprmparam = sccmd.Parameters.Add("@isBom", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsBom;
                sprmparam = sccmd.Parameters.Add("@isopeningstock", SqlDbType.Bit);
                sprmparam.Value = productinfo.Isopeningstock;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@isshowRemember", SqlDbType.Bit);
                sprmparam.Value = productinfo.IsshowRemember;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = productinfo.ExtraDate;
                decCheck = sccmd.ExecuteNonQuery();
                if (decCheck > 0)
                {
                    isResult = true;
                }
                else
                {
                    isResult = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isResult;
        }
        /// <summary>
        /// Function to get all the values from Product Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Product Table based on the parameter
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductInfo ProductView(decimal productId)
        {
            ProductInfo productinfo = new ProductInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    productinfo.ProductId = Convert.ToDecimal(sdrreader[0].ToString());
                    productinfo.ProductCode = sdrreader[1].ToString();
                    productinfo.ProductName = sdrreader[2].ToString();
                    productinfo.GroupId = Convert.ToDecimal(sdrreader[3].ToString());
                    productinfo.BrandId = Convert.ToDecimal(sdrreader[4].ToString());
                    productinfo.UnitId = Convert.ToDecimal(sdrreader[5].ToString());
                    productinfo.SizeId = Convert.ToDecimal(sdrreader[6].ToString());
                    productinfo.ModelNoId = Convert.ToDecimal(sdrreader[7].ToString());
                    productinfo.TaxId = Convert.ToDecimal(sdrreader[8].ToString());
                    productinfo.TaxapplicableOn = sdrreader[9].ToString();
                    productinfo.PurchaseRate = Convert.ToDecimal(sdrreader[10].ToString());
                    productinfo.SalesRate = Convert.ToDecimal(sdrreader[11].ToString());
                    productinfo.Mrp = Convert.ToDecimal(sdrreader[12].ToString());
                    productinfo.MinimumStock = Convert.ToDecimal(sdrreader[13].ToString());
                    productinfo.MaximumStock = Convert.ToDecimal(sdrreader[14].ToString());
                    productinfo.ReorderLevel = Convert.ToDecimal(sdrreader[15].ToString());
                    productinfo.GodownId = Convert.ToDecimal(sdrreader[16].ToString());
                    productinfo.RackId = Convert.ToDecimal(sdrreader[17].ToString());
                    productinfo.IsallowBatch = Convert.ToBoolean(sdrreader[18].ToString());
                    productinfo.Ismultipleunit = Convert.ToBoolean(sdrreader[19].ToString());
                    productinfo.IsBom = Convert.ToBoolean(sdrreader[20].ToString());
                    productinfo.Isopeningstock = Convert.ToBoolean(sdrreader[21].ToString());
                    productinfo.Narration = sdrreader[22].ToString();
                    productinfo.IsActive = Convert.ToBoolean(sdrreader[23].ToString());
                    productinfo.IsshowRemember = Convert.ToBoolean(sdrreader[24].ToString());
                    productinfo.Extra1 = sdrreader[25].ToString();
                    productinfo.Extra2 = sdrreader[26].ToString();
                    productinfo.ExtraDate = PublicVariables._dtCurrentDate;// DateTime.Parse(sdrreader[27].ToString());
                    productinfo.PartNo = sdrreader[28].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return productinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table Product
        /// </summary>
        /// <param name="ProductId"></param>
        public void ProductDelete(decimal ProductId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = ProductId;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to  get the next id for Product Table
        /// </summary>
        /// <returns></returns>
        public bool ProductGetMax()
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.ExecuteScalar().ToString();
            }
            catch
            {
                isExist = true;
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
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
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("ProductVsBatchReportGridFill", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.VarChar);
                sprmparam.Value = groupId;
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productCode;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = batchId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductNameView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    strCollection.Add(sdrreader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strCollection;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductCodeView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    strCollection.Add(sdrreader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strCollection;
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
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ChangeProductTaxSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = infoProduct.GroupId;
                sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = infoProduct.ProductCode;
                sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = infoProduct.ProductName;
                sdaadapter.SelectCommand.Parameters.Add("@taxID", SqlDbType.Decimal).Value = infoProduct.TaxId;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ProductCodeCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Get the ProductMax for next updation
        /// </summary>
        /// <returns></returns>
        public string ProductMax()
        {
            string str = "";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                str = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return str;
        }
        /// <summary>
        /// function to view the product details based on the product code
        /// </summary>
        /// <param name="strproductCode"></param>
        /// <returns></returns>
        public ProductInfo ProductViewByCode(string strproductCode)
        {
            ProductInfo productinfo = new ProductInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductViewByCode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strproductCode;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    productinfo.ProductId = Convert.ToDecimal(sdrreader[0].ToString());
                    productinfo.ProductCode = sdrreader[1].ToString();
                    productinfo.ProductName = sdrreader[2].ToString();
                    productinfo.GroupId = Convert.ToDecimal(sdrreader[3].ToString());
                    productinfo.BrandId = Convert.ToDecimal(sdrreader[4].ToString());
                    productinfo.UnitId = Convert.ToDecimal(sdrreader[5].ToString());
                    productinfo.SizeId = Convert.ToDecimal(sdrreader[6].ToString());
                    productinfo.ModelNoId = Convert.ToDecimal(sdrreader[7].ToString());
                    productinfo.TaxId = Convert.ToDecimal(sdrreader[8].ToString());
                    productinfo.TaxapplicableOn = sdrreader[9].ToString();
                    productinfo.PurchaseRate = Convert.ToDecimal(sdrreader[10].ToString());
                    productinfo.SalesRate = Convert.ToDecimal(sdrreader[11].ToString());
                    productinfo.Mrp = Convert.ToDecimal(sdrreader[12].ToString());
                    productinfo.MinimumStock = Convert.ToDecimal(sdrreader[13].ToString());
                    productinfo.MaximumStock = Convert.ToDecimal(sdrreader[14].ToString());
                    productinfo.ReorderLevel = Convert.ToDecimal(sdrreader[15].ToString());
                    productinfo.GodownId = Convert.ToDecimal(sdrreader[16].ToString());
                    productinfo.RackId = Convert.ToDecimal(sdrreader[17].ToString());
                    productinfo.IsallowBatch = Convert.ToBoolean(sdrreader[18].ToString());
                    productinfo.Ismultipleunit = Convert.ToBoolean(sdrreader[19].ToString());
                    productinfo.IsBom = Convert.ToBoolean(sdrreader[20].ToString());
                    productinfo.Isopeningstock = Convert.ToBoolean(sdrreader[21].ToString());
                    productinfo.Narration = sdrreader[22].ToString();
                    productinfo.IsActive = Convert.ToBoolean(sdrreader[23].ToString());
                    productinfo.IsshowRemember = Convert.ToBoolean(sdrreader[24].ToString());
                    productinfo.Extra1 = sdrreader[25].ToString();
                    productinfo.Extra2 = sdrreader[26].ToString();
                    productinfo.ExtraDate = PublicVariables._dtCurrentDate;
                    productinfo.PartNo = sdrreader[28].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return productinfo;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductViewByPartNoOrBarcode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = strpartNo;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strbarcode;
                decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBatchId;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeViewByBatchId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decbatchId;
                if (decbatchId == 0)
                {
                    return strBatchId;
                }
                else
                    strBatchId = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strBatchId;
        }
        /// <summary>
        /// Function to get the product code details
        /// </summary>
        /// <param name="cmbProductCode"></param>
        /// <param name="Isall"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewAll(ComboBox cmbProductCode, bool Isall)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductCodeViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
                if (Isall)
                {
                    DataRow dr = listObj[0].NewRow();
                    dr["productId"] = 0;
                    dr["productCode"] = "All";
                    listObj[0].Rows.InsertAt(dr, 0);
                }
                cmbProductCode.DataSource = listObj[0];
                cmbProductCode.DisplayMember = "productCode";
                cmbProductCode.ValueMember = "productId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// product details view by productname for fill other forms
        /// </summary>
        /// <param name="strproductName"></param>
        /// <returns></returns>
        public ProductInfo ProductViewByName(string strproductName)
        {
            ProductInfo productinfo = new ProductInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductViewByName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strproductName;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    productinfo.ProductId = Convert.ToDecimal(sdrreader[0].ToString());
                    productinfo.ProductCode = sdrreader[1].ToString();
                    productinfo.ProductName = sdrreader[2].ToString();
                    productinfo.GroupId = Convert.ToDecimal(sdrreader[3].ToString());
                    productinfo.BrandId = Convert.ToDecimal(sdrreader[4].ToString());
                    productinfo.UnitId = Convert.ToDecimal(sdrreader[5].ToString());
                    productinfo.SizeId = Convert.ToDecimal(sdrreader[6].ToString());
                    productinfo.ModelNoId = Convert.ToDecimal(sdrreader[7].ToString());
                    productinfo.TaxId = Convert.ToDecimal(sdrreader[8].ToString());
                    productinfo.TaxapplicableOn = sdrreader[9].ToString();
                    productinfo.PurchaseRate = Convert.ToDecimal(sdrreader[10].ToString());
                    productinfo.SalesRate = Convert.ToDecimal(sdrreader[11].ToString());
                    productinfo.Mrp = Convert.ToDecimal(sdrreader[12].ToString());
                    productinfo.MinimumStock = Convert.ToDecimal(sdrreader[13].ToString());
                    productinfo.MaximumStock = Convert.ToDecimal(sdrreader[14].ToString());
                    productinfo.ReorderLevel = Convert.ToDecimal(sdrreader[15].ToString());
                    productinfo.GodownId = Convert.ToDecimal(sdrreader[16].ToString());
                    productinfo.RackId = Convert.ToDecimal(sdrreader[17].ToString());
                    productinfo.IsallowBatch = bool.Parse(sdrreader[18].ToString());
                    productinfo.Ismultipleunit = bool.Parse(sdrreader[19].ToString());
                    productinfo.IsBom = bool.Parse(sdrreader[20].ToString());
                    productinfo.Isopeningstock = bool.Parse(sdrreader[21].ToString());
                    productinfo.Narration = sdrreader[22].ToString();
                    productinfo.IsActive = bool.Parse(sdrreader[23].ToString());
                    productinfo.IsshowRemember = bool.Parse(sdrreader[24].ToString());
                    productinfo.Extra1 = sdrreader[25].ToString();
                    productinfo.Extra2 = sdrreader[26].ToString();
                    productinfo.ExtraDate = PublicVariables._dtCurrentDate;// DateTime.Parse(sdrreader[27].ToString());
                    productinfo.PartNo = sdrreader[28].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return productinfo;
        }
        /// <summary>
        /// Product details view all for combobox fill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAllForComboBox()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllForComboBox", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Product details View For StandardRate form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public ProductInfo ProductViewForStandardRate(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ProductViewForStandardRate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoProduct.ProductId = Convert.ToDecimal(sqldr["productId"].ToString());
                    infoProduct.ProductName = (sqldr["productName"].ToString());
                    infoProduct.ProductCode = (sqldr["productCode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
                sqldr.Close();
            }
            return infoProduct;
        }
        /// <summary>
        /// PriceList PopUp View based on productId
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public ProductInfo PriceListPopUpView(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PriceListPopUpView", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoProduct.ProductId = Convert.ToDecimal(sqldr["productId"].ToString());
                    infoProduct.ProductName = (sqldr["productName"].ToString());
                    infoProduct.ProductCode = (sqldr["productCode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
                sqldr.Close();
            }
            return infoProduct;
        }
        /// <summary>
        /// Product ViewAll For Batch By AllowBatch for updation
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductViewAllForBatchByAllowBatch()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllForBatchByAllowBatch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Change Product Tax  to save
        /// </summary>
        /// <param name="productinfo"></param>
        public void ChangeProductTaxSave(ProductInfo productinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ChangeProductTaxSave", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.VarChar);
                sprmparam.Value = productinfo.TaxId;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
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
            List<DataTable> listObjProductRegister = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductRegisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
                sqlda.SelectCommand.Parameters.Add("@taxapplicableOn", SqlDbType.VarChar).Value = strTaxApplicabel;
                sqlda.SelectCommand.Parameters.Add("@salesRateFrom", SqlDbType.Decimal).Value = decSalseRateFrom;
                sqlda.SelectCommand.Parameters.Add("@salesRateTo", SqlDbType.Decimal).Value = decSalseRateTo;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strActive;
                sqlda.Fill(dtbl);
                listObjProductRegister.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjProductRegister;
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
            List<DataTable> listObjProductSearchPopup = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PopupViewAll", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupName", SqlDbType.VarChar).Value = strGroupName;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSize;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNo;
                sqlda.Fill(dtbl);
                listObjProductSearchPopup.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjProductSearchPopup;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductUnit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                strUnit = Convert.ToString(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strUnit;
        }
        /// <summary>
        /// Product View Grid Fill function From Batch form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProductViewGridFillFromBatch(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewGridFillFromBatch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("ProductViewGridFillFromStockPosting", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeleteProductWithReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = ProductId;
                decCheck = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decCheck;
        }
        /// <summary>
        /// ProductView All Without One Product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProductViewAllWithoutOneProduct(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAllWithoutOneProduct", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("ProductViewByProductId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = cmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sqlparam.Value = decproductId;
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoproduct.ProductCode = sqldr["productCode"].ToString();
                    infoproduct.ProductName = sqldr["productName"].ToString();
                    infoproduct.UnitId = Convert.ToDecimal(sqldr["unitId"].ToString());
                    infoproduct.GodownId = Convert.ToDecimal(sqldr["godownId"].ToString());
                    infoproduct.RackId = Convert.ToDecimal(sqldr["rackId"].ToString());
                    infoproduct.IsallowBatch = Convert.ToBoolean(sqldr["isallowBatch"].ToString());
                    infoproduct.GroupId = Convert.ToDecimal(sqldr["groupId"].ToString());
                    infoproduct.BrandId = Convert.ToDecimal(sqldr["brandId"].ToString());
                    infoproduct.Ismultipleunit = Convert.ToBoolean(sqldr["ismultipleunit"].ToString());
                    if (sqldr["extraDate"].ToString() != null)
                        infoproduct.ExtraDate = Convert.ToDateTime(sqldr["extraDate"].ToString());
                    infoproduct.Extra1 = sqldr["extra1"].ToString();
                    infoproduct.Extra2 = sqldr["extra2"].ToString();
                    infoproduct.PartNo = sqldr["partNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("productSp:" + ex.Message.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return infoproduct;
        }
        /// <summary>
        /// Function to view ProductName View By ProductCode
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public List<DataTable> ProductNameViewByProductCode(string productCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductNameViewByProductCode", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productCode;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// ProductCode And Barcode By BatchId
        /// </summary>
        /// <param name="decProductBatchId"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeAndBarcodeByBatchId(decimal decProductBatchId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductCodeAndBarcodeByBatchId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@BatchId", SqlDbType.VarChar);
                sprmparam.Value = decProductBatchId;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to use ProductDetails View By ProductCode
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public DataTable ProductDetailsViewByProductCode(string productCode)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductDetailsViewByProductCode", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productCode;
                sdaadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        /// <summary>
        /// here get the Product Details Coreesponding To Barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsCoreespondingToBarcode(string barcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductDetailsCoreespondingToBarcode", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = barcode;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductCodeViewByProductName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = productName;
                if (sccmd.ExecuteScalar() != null)
                {
                    productCode = sccmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return productCode;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesInvoiceProductRateForSales", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.VarChar);
                sprmparam.Value = decProductId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dtdate;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decPricingLevelId;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
                sprmparam.Value = decNoofDecplaces;
                decRate = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decRate;
        }
        /// <summary>
        /// Product details Views By ProductName for fill
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public DataTable ProductViewsByProductName(string productName)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductViewsByProductName", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = productName;
                sqlda.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductRateForSales", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = strProductId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = date;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
                sprmparam.Value = decNoofDecplaces;
                dcRate = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeViewByProductCode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strproductCode;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    infoProductBatch.Barcode = sdrreader["barcode"].ToString();
                    infoProductBatch.BatchId = Convert.ToDecimal(sdrreader["batchId"].ToString());
                    infoProductBatch.ProductId = Convert.ToDecimal(sdrreader["productId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return infoProductBatch;
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
        public List<DataTable> ProductStatisticsFill(decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId,/*decimal decUnitId,*/ string strcriteria, string strBatchName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductStatisticsFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
                sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
        public DataSet ProductStatisticsReport(decimal decCompanyId, decimal decBrandId, decimal decModelNoId, decimal decSizeId, decimal decGroupId, /*decimal decUnitId,*/ string strcriteria, string strBatchName)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductStatisticsReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
                sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
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
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductSearchForGriddFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodownId;
                sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decRackId;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
                sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
                sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDT:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductSearchReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroupId;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodownId;
                sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decRackId;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
                sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar).Value = strcriteria;
                sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDT:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Product Finished Goods for ComboFill under stock journal
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductFinishedGoodsComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductFinishedGoodsComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDT:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        ///  Product RawMaterialsFill goods for ComboFill under stock journal
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decQty"></param>
        /// <returns></returns>
        public List<DataTable> RawMaterialsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("RawMaterialsFillForStockJournal", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqlda.SelectCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = decQty;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDT:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Finished Goods Fill For StockJournal form
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decQty"></param>
        /// <returns></returns>
        public List<DataTable> FinishedGoodsFillForStockJournal(decimal decProductId, decimal decQty)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("FinishedGoodsFillForStockJournal", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqlda.SelectCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = decQty;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDT:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// ProductCode ViewAll For BarcodeCode Printing
        /// </summary>
        /// <param name="cmbProductCode"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewAllForBarcodeCodePrinting(ComboBox cmbProductCode, bool isAll)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("ProductCodeViewAllForBarcodeCodePrinting", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.Fill(dtbl);
                listObj.Add(dtbl);
                if (isAll)
                {
                    DataRow dr = listObj[0].NewRow();
                    dr["productCode"] = "All";
                    dr["productId"] = 0;
                    listObj[0].Rows.InsertAt(dr, 0);
                }
                cmbProductCode.DataSource = listObj[0];
                cmbProductCode.DisplayMember = "productCode";
                cmbProductCode.ValueMember = "productId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// function to use the Product Details For Product Search
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsForProductSearch(decimal productId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("ProductDetailsForProductSearch", sqlcon);
                sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = productId;
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            List<DataTable> listObjProduct = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherWiseProductSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherName;
                sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromdate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = todate;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedger;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decGroup;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProCode;
                sqlda.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar).Value = strProductName;
                sqlda.Fill(dtbl);
                listObjProduct.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjProduct;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductReferenceChek", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isReferenceExist;
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
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("productviewbyproductNameforSR", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = productName;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeId;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("productviewbyproductcodeforSR", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = productCode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decProductcode;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByCode", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByName", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchReferenceCheckForProductEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                decStatus = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStatus;
        }
        /// <summary>
        /// Here partNo CheckExistence for updation
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public bool PartNoCheckExistence(string strProductCode)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PartNoCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
    }
}
