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
//Summary description for SalesDetailsSP    
//</summary>    
namespace OpenMiracle.DAL    
{
   public  class SalesDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesDetails Table
        /// </summary>
        /// <param name="salesdetailsinfo"></param>
        public void SalesDetailsAdd(SalesDetailsInfo salesdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.DeliveryNoteDetailsId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.QuotationDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesdetailsinfo.Extra2;
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
        /// Function to Update values in SalesDetails Table
        /// </summary>
        /// <param name="salesdetailsinfo"></param>
        public void SalesDetailsEdit(SalesDetailsInfo salesdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.SalesDetailsId;
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.DeliveryNoteDetailsId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.QuotationDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesdetailsinfo.Extra2;
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
        /// Function to get all the values from SalesDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesDetailsViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Function to get particular values from SalesDetails Table based on the parameter
        /// </summary>
        /// <param name="salesDetailsId"></param>
        /// <returns></returns>
        public SalesDetailsInfo SalesDetailsView(decimal salesDetailsId)
        {
            SalesDetailsInfo salesdetailsinfo = new SalesDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesdetailsinfo.SalesDetailsId = decimal.Parse(sdrreader[0].ToString());
                    salesdetailsinfo.SalesMasterId = decimal.Parse(sdrreader[1].ToString());
                    salesdetailsinfo.DeliveryNoteDetailsId = decimal.Parse(sdrreader[2].ToString());
                    salesdetailsinfo.OrderDetailsId = decimal.Parse(sdrreader[3].ToString());
                    salesdetailsinfo.QuotationDetailsId = decimal.Parse(sdrreader[4].ToString());
                    salesdetailsinfo.ProductId = decimal.Parse(sdrreader[5].ToString());
                    salesdetailsinfo.Qty = decimal.Parse(sdrreader[6].ToString());
                    salesdetailsinfo.Rate = decimal.Parse(sdrreader[7].ToString());
                    salesdetailsinfo.UnitId = decimal.Parse(sdrreader[8].ToString());
                    salesdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[9].ToString());
                    salesdetailsinfo.Discount = decimal.Parse(sdrreader[10].ToString());
                    salesdetailsinfo.TaxId = decimal.Parse(sdrreader[11].ToString());
                    salesdetailsinfo.BatchId = decimal.Parse(sdrreader[12].ToString());
                    salesdetailsinfo.GodownId = decimal.Parse(sdrreader[13].ToString());
                    salesdetailsinfo.RackId = decimal.Parse(sdrreader[14].ToString());
                    salesdetailsinfo.TaxAmount = decimal.Parse(sdrreader[15].ToString());
                    salesdetailsinfo.GrossAmount = decimal.Parse(sdrreader[16].ToString());
                    salesdetailsinfo.NetAmount = decimal.Parse(sdrreader[17].ToString());
                    salesdetailsinfo.Amount = decimal.Parse(sdrreader[18].ToString());
                    salesdetailsinfo.SlNo = int.Parse(sdrreader[19].ToString());
                    salesdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[20].ToString());
                    salesdetailsinfo.Extra1 = sdrreader[21].ToString();
                    salesdetailsinfo.Extra2 = sdrreader[22].ToString();
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
            return salesdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table SalesDetails
        /// </summary>
        /// <param name="SalesDetailsId"></param>
        public void SalesDetailsDelete(decimal SalesDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalesDetailsId;
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
        /// Function to  get the next id for SalesDetails Table
        /// </summary>
        /// <returns></returns>
        public int SalesDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesDetailsMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return max;
        }
        /// <summary>
        /// Function to use SalesDetails For SalesReturn GrideFill
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <param name="salesReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesDetailsViewForSalesReturnGrideFill(decimal salesMasterId, decimal salesReturnMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblSalesReturnGrideFill = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtblSalesReturnGrideFill.Columns.Add("S.No", typeof(int));
                dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrement = true;
                dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrementSeed = 1;
                dtblSalesReturnGrideFill.Columns["S.No"].AutoIncrementStep = 1;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNew", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesMasterId;
                SqlParameter sprmparam1 = new SqlParameter();
                sprmparam1 = sdaadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam1.Value = salesReturnMasterId;
                sdaadapter.Fill(dtblSalesReturnGrideFill);
                listObj.Add(dtblSalesReturnGrideFill);
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
        /// Function to use SalesDetails View For SalesReturnGrideFill based on product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> SalesDetailsViewForSalesReturnGrideFill1(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblSalesReturnGrideFill1 = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNew2", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sdaadapter.Fill(dtblSalesReturnGrideFill1);
                listObj.Add(dtblSalesReturnGrideFill1);
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
        /// Function to use SalesReturnGrideFill New By ProductId
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnGrideFillNewByProductId(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblSalesReturnGrideFill1 = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnGrideFillNewByProductId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sdaadapter.Fill(dtblSalesReturnGrideFill1);
                listObj.Add(dtblSalesReturnGrideFill1);
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
        /// Function to use Bank Or Cash ComboFill in sales invoice
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BankOrCashComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
        /// Function VoucherType Name ComboFill For SalesInvoice Register
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeNameComboFillForSalesInvoiceRegister()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblVoucherType = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeNameComboFillForSalesInvoiceRegister", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblVoucherType);
                listObj.Add(dtblVoucherType);
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
        /// Function to voucherNo ViewAll By VoucherTypeId For Sales Invoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> voucherNoViewAllByVoucherTypeIdForSi(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblVoucherNo = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("voucherNoViewAllByVoucherTypeIdForSi", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = decVoucherTypeId;
                sqlda.Fill(dtblVoucherNo);
                listObj.Add(dtblVoucherNo);
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
        /// Function to get the SalesDetails By SalesMasterId
        /// </summary>
        /// <param name="dcSalesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblSI = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesDetailsViewBySalesMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = dcSalesMasterId;
                sqlda.Fill(dtblSI);
                listObj.Add(dtblSI);
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
        /// Function to get the SalesDetails By SalesMasterId for POS
        /// </summary>
        /// <param name="dcSalesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceSalesDetailsViewBySalesMasterId(decimal dcSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblSidtl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceSalesDetailsViewBySalesMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = dcSalesMasterId;
                sqlda.Fill(dtblSidtl);
                listObj.Add(dtblSidtl);
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
        /// Function to get SalesInvoice Recipt Voucher Details Against Sales Invoice
        /// </summary>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="strvoucherNo"></param>
        /// <returns></returns>
        public decimal SalesInvoiceReciptVoucherDetailsAgainstSI(decimal decvoucherTypeId, string strvoucherNo)
        {
            decimal decBalAmount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesInvoiceReciptVoucherDetailsAgainstSI", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                decBalAmount = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBalAmount;
        }
        /// <summary>
        /// Function to use the Voucher Types Based On Type Of Vouchers
        /// </summary>
        /// <param name="typeOfVouchers"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
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
        /// Function to fill the product details based on the product code in sales invoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceDetailsViewByProductCodeForSI(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByProductCodeForSI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
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
        /// Function to fill the product details based on the product Name in sales invoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceDetailsViewByProductNameForSI(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByProductNameForSI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
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
        /// Function to fill the product details based on the Barcode in sales invoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceDetailsViewByBarcodeForSI(decimal decVoucherTypeId, string strBarcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceDetailsViewByBarcodeForSI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strBarcode;
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
        
    }
}
