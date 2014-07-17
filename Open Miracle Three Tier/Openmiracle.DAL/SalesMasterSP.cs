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
//Summary description for SalesMasterSP    
//</summary>    
namespace OpenMiracle.DAL    
{
   public class SalesMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesMaster Table
        /// </summary>
        /// <param name="salesmasterinfo"></param>
        /// <returns></returns>
        public decimal SalesMasterAdd(SalesMasterInfo salesmasterinfo)
        {
            decimal decSalesMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = salesmasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.SalesAccount;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@customerName", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.CustomerName;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.BillDiscount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@POS", SqlDbType.Bit);
                sprmparam.Value = salesmasterinfo.POS;
                sprmparam = sccmd.Parameters.Add("@counterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.CounterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Extra2;
                decSalesMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decSalesMasterId;
        }
        /// <summary>
        /// Function to Update values in SalesMaster Table
        /// </summary>
        /// <param name="salesmasterinfo"></param>
        public void SalesMasterEdit(SalesMasterInfo salesmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = salesmasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.SalesAccount;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@customerName", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.CustomerName;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.BillDiscount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@POS", SqlDbType.Bit);
                sprmparam.Value = salesmasterinfo.POS;
                sprmparam = sccmd.Parameters.Add("@counterId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.CounterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesmasterinfo.Extra2;
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
        /// Function to get all the values from SalesMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesMasterViewAll", sqlcon);
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
        /// Function to get particular values from SalesMaster Table based on the parameter
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <returns></returns>
        public SalesMasterInfo SalesMasterView(decimal salesMasterId)
        {
            SalesMasterInfo salesmasterinfo = new SalesMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesmasterinfo.SalesMasterId = decimal.Parse(sdrreader[0].ToString());
                    salesmasterinfo.VoucherNo = sdrreader[1].ToString();
                    salesmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    salesmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[3].ToString());
                    salesmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[4].ToString());
                    salesmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    salesmasterinfo.CreditPeriod = int.Parse(sdrreader[6].ToString());
                    salesmasterinfo.LedgerId = decimal.Parse(sdrreader[7].ToString());
                    salesmasterinfo.PricinglevelId = decimal.Parse(sdrreader[8].ToString());
                    salesmasterinfo.EmployeeId = decimal.Parse(sdrreader[9].ToString());
                    salesmasterinfo.SalesAccount = decimal.Parse(sdrreader[10].ToString());
                    salesmasterinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader[11].ToString());
                    salesmasterinfo.OrderMasterId = decimal.Parse(sdrreader[12].ToString());
                    salesmasterinfo.Narration = sdrreader[13].ToString();
                    salesmasterinfo.CustomerName = sdrreader[14].ToString();
                    salesmasterinfo.ExchangeRateId = decimal.Parse(sdrreader[15].ToString());
                    salesmasterinfo.TaxAmount = decimal.Parse(sdrreader[16].ToString());
                    salesmasterinfo.AdditionalCost = decimal.Parse(sdrreader[17].ToString());
                    salesmasterinfo.BillDiscount = decimal.Parse(sdrreader[18].ToString());
                    salesmasterinfo.GrandTotal = decimal.Parse(sdrreader[19].ToString());
                    salesmasterinfo.TotalAmount = decimal.Parse(sdrreader[20].ToString());
                    salesmasterinfo.UserId = decimal.Parse(sdrreader[21].ToString());
                    salesmasterinfo.LrNo = sdrreader[22].ToString();
                    salesmasterinfo.TransportationCompany = sdrreader[23].ToString();
                    salesmasterinfo.QuotationMasterId = decimal.Parse(sdrreader[24].ToString());
                    salesmasterinfo.POS = bool.Parse(sdrreader[25].ToString());
                    salesmasterinfo.CounterId = decimal.Parse(sdrreader[26].ToString());
                    salesmasterinfo.FinancialYearId = decimal.Parse(sdrreader[27].ToString());
                    salesmasterinfo.ExtraDate = DateTime.Parse(sdrreader[28].ToString());
                    salesmasterinfo.Extra1 = sdrreader[29].ToString();
                    salesmasterinfo.Extra2 = sdrreader[30].ToString();
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
            return salesmasterinfo;
        }
        /// <summary>
        /// Function to get particular values from SalesMaster Table based on the parameter
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <returns></returns>
        public SalesMasterInfo SalesMasterView(string salesMasterId)
        {
            SalesMasterInfo salesmasterinfo = new SalesMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesmasterinfo.SalesMasterId = decimal.Parse(sdrreader[0].ToString());
                    salesmasterinfo.VoucherNo = sdrreader[1].ToString();
                    salesmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    salesmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[3].ToString());
                    salesmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[4].ToString());
                    salesmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    salesmasterinfo.CreditPeriod = int.Parse(sdrreader[6].ToString());
                    salesmasterinfo.LedgerId = decimal.Parse(sdrreader[7].ToString());
                    salesmasterinfo.PricinglevelId = decimal.Parse(sdrreader[8].ToString());
                    salesmasterinfo.EmployeeId = decimal.Parse(sdrreader[9].ToString());
                    salesmasterinfo.SalesAccount = decimal.Parse(sdrreader[10].ToString());
                    salesmasterinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader[11].ToString());
                    salesmasterinfo.OrderMasterId = decimal.Parse(sdrreader[12].ToString());
                    salesmasterinfo.Narration = sdrreader[13].ToString();
                    salesmasterinfo.CustomerName = sdrreader[14].ToString();
                    salesmasterinfo.ExchangeRateId = decimal.Parse(sdrreader[15].ToString());
                    salesmasterinfo.TaxAmount = decimal.Parse(sdrreader[16].ToString());
                    salesmasterinfo.AdditionalCost = decimal.Parse(sdrreader[17].ToString());
                    salesmasterinfo.BillDiscount = decimal.Parse(sdrreader[18].ToString());
                    salesmasterinfo.GrandTotal = decimal.Parse(sdrreader[19].ToString());
                    salesmasterinfo.TotalAmount = decimal.Parse(sdrreader[20].ToString());
                    salesmasterinfo.UserId = decimal.Parse(sdrreader[21].ToString());
                    salesmasterinfo.LrNo = sdrreader[22].ToString();
                    salesmasterinfo.TransportationCompany = sdrreader[23].ToString();
                    salesmasterinfo.QuotationMasterId = decimal.Parse(sdrreader[24].ToString());
                    salesmasterinfo.POS = bool.Parse(sdrreader[25].ToString());
                    salesmasterinfo.CounterId = decimal.Parse(sdrreader[26].ToString());
                    salesmasterinfo.FinancialYearId = decimal.Parse(sdrreader[27].ToString());
                    salesmasterinfo.ExtraDate = DateTime.Parse(sdrreader[28].ToString());
                    salesmasterinfo.Extra1 = sdrreader[29].ToString();
                    salesmasterinfo.Extra2 = sdrreader[30].ToString();
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
            return salesmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesMasterId"></param>
        public void SalesMasterDelete(decimal SalesMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalesMasterId;
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
        /// Function to  get the next id for SalesMaster table
        /// </summary>
        /// <returns></returns>
        public int SalesMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterMax", sqlcon);
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
        /// Function for SalesInvoice SalesAccountMode ComboFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceSalesAccountModeComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceSalesAccountModeComboFill", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.Fill(dtbl);
            listObj.Add(dtbl);
            return listObj;
        }
        /// <summary>
        /// Function to get next id for SalesMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal SalesMasterVoucherMax(decimal decVoucherTypeId)
        {
            decimal decVoucherNoMax = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterVoucherMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                decVoucherNoMax = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decVoucherNoMax;
        }
        /// <summary>
        /// Function for SalesMaster View By InvoiceNo For ComboSelection based on parameter
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesMasterViewByInvoiceNoForComboSelection(decimal salesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesMasterViewForComboFillSelection", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
                sqlparameter.Value = salesMasterId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Suit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function for SalesMaster View By SalesMasterId
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <returns></returns>
        public SalesMasterInfo SalesMasterViewBySalesMasterId(decimal salesMasterId)
        {
            SalesMasterInfo infoSalesMaster = new SalesMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterViewBySalesMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    infoSalesMaster.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    infoSalesMaster.VoucherNo = sdrreader["voucherNo"].ToString();
                    infoSalesMaster.VoucherTypeId = Convert.ToDecimal(sdrreader["voucherTypeId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return infoSalesMaster;
        }
        /// <summary>
        /// Function for Product View By ProductId for SalesInvoice
        /// </summary>
        /// <param name="strproductCode"></param>
        /// <returns></returns>
        public ProductInfo ProductViewByProductIdforSalesInvoice(string strproductCode)
        {
            ProductInfo productinfo = new ProductInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductViewByProductIdforSalesInvoice", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
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
                    productinfo.IsallowBatch = bool.Parse(sdrreader[18].ToString());
                    productinfo.Ismultipleunit = bool.Parse(sdrreader[19].ToString());
                    productinfo.IsBom = bool.Parse(sdrreader[20].ToString());
                    productinfo.Isopeningstock = bool.Parse(sdrreader[21].ToString());
                    productinfo.Narration = sdrreader[22].ToString();
                    productinfo.IsActive = bool.Parse(sdrreader[23].ToString());
                    productinfo.IsshowRemember = bool.Parse(sdrreader[24].ToString());
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
        /// Function to check existence of invoice number
        /// </summary>
        /// <param name="strvoucherNo"></param>
        /// <param name="decsalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool SalesInvoiceInvoiceNumberCheckExistence(string strvoucherNo, decimal decsalesMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesInvoiceInvoiceNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                sprmparam = sqlcmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decsalesMasterId;
                sprmparam = sqlcmd.Parameters.Add("@vouchertypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
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
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to get values for print after save 
        /// </summary>
        /// <param name="decsalesMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decOrderMasterId"></param>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <param name="decQuotationMasterId"></param>
        /// <returns></returns>
        public DataSet salesInvoicePrintAfterSave(decimal decsalesMasterId, decimal decCompanyId, decimal decOrderMasterId, decimal decDeliveryNoteMasterId, decimal decQuotationMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("salesInvoicePrintAfterSave", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decsalesMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDeliveryNoteMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = decQuotationMasterId;
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
        /// Function to check party's bill by bill and return status
        /// </summary>
        /// <param name="decPartyId"></param>
        /// <returns></returns>
        public bool SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(decimal decPartyId)
        {
            bool isBillByBill = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decPartyId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isBillByBill = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isBillByBill;
        }
        /// <summary>
        /// Function for SalesInvoice Register Gridfill
        /// </summary>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <param name="decVoucherType"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strSalesMode"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceRegisterGridfill(DateTime dtFrom, DateTime dtTo, decimal decVoucherType, decimal decLedgerId, string strVoucherNo, string strSalesMode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("dgvTxtSlno", typeof(decimal));
            dtbl.Columns["dgvTxtSlno"].AutoIncrement = true;
            dtbl.Columns["dgvTxtSlno"].AutoIncrementSeed = 1;
            dtbl.Columns["dgvTxtSlno"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceRegisterGridfill", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = dtFrom;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = dtTo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherType;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sqlparameter.Value = strVoucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
                sqlparameter.Value = strSalesMode;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view sales details based on parameter
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceSalesMasterViewBySalesMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
                sqlparameter.Value = decSalesMasterId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view SalesInvoice AdditionalCost By VoucherNo Under VoucherType
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = strVoucherNo;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to Check AdditionalCost wheteher dr Or Cr for SalesInvoice Edit
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> salesinvoiceAdditionalCostCheckdrOrCrforSiEdit(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("salesinvoiceAdditionalCostCheckdrOrCrforSiEdit", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = strVoucherNo;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public decimal SalesInvoiceReferenceCheckForEdit(decimal decSalesMasterId)
        {
            decimal decStatus = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesInvoiceReferenceCheckForEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesMasterId;
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
        /// Function to get SalesInvoice Quantity Details Against SalesReturn
        /// </summary>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="strvoucherNo"></param>
        /// <returns></returns>
        public decimal SalesInvoiceQuantityDetailsAgainstSalesReturn(decimal decvoucherTypeId, string strvoucherNo)
        {
            decimal decQty = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesInvoiceQuantityDetailsAgainstSalesReturn", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                decQty = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decQty;
        }
        /// <summary>
        /// Funcrtion to delete based on parameter
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void SalesInvoiceDelete(decimal decSalesMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesInvoiceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
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
        /// Function to check refernce for delete
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <returns></returns>
        public bool SalesReturnCheckReferenceForSIDelete(decimal decSalesMasterId)
        {
            bool isReferenceExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnCheckReferenceForSIDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesMasterId;
                isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SMSP:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isReferenceExist;
        }
        /// <summary>
        /// Function to SalesInvoice Report GridFill
        /// </summary>
        /// <param name="dtfromDate"></param>
        /// <param name="dttoDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decAreaId"></param>
        /// <param name="strSalesMode"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="strProductName"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strstatus"></param>
        /// <param name="decRouteId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceReportFill(DateTime dtfromDate, DateTime dttoDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decAreaId, string strSalesMode, decimal decEmployeeId, string strProductName, string strVoucherNo, string strstatus, decimal decRouteId, decimal decModelNoId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceReportFill", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = dtfromDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = dttoDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal);
                sqlparameter.Value = decAreaId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
                sqlparameter.Value = strSalesMode;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlparameter.Value = decEmployeeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sqlparameter.Value = strProductName;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = strVoucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
                sqlparameter.Value = strstatus;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal);
                sqlparameter.Value = decRouteId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@modelnoId", SqlDbType.Decimal);
                sqlparameter.Value = decModelNoId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sqlparameter.Value = strProductCode;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view SalesMaster View By SalesMasterId for POS
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> POSSalesMasterViewBySalesMasterId(decimal decSalesMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("POSSalesMasterViewBySalesMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.VarChar);
                sqlparameter.Value = decSalesMasterId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function for SalesInvoice report printing
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="ledgerId"></param>
        /// <param name="areaId"></param>
        /// <param name="salesMode"></param>
        /// <param name="employeeId"></param>
        /// <param name="productName"></param>
        /// <param name="voucherNo"></param>
        /// <param name="status"></param>
        /// <param name="routeId"></param>
        /// <param name="modelnoId"></param>
        /// <param name="productCode"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public DataSet salesInvoiceReportPrint(DateTime fromDate, DateTime toDate, decimal voucherTypeId, decimal ledgerId, decimal areaId, string salesMode, decimal employeeId, string productName, string voucherNo, string status, decimal routeId, decimal modelnoId, string productCode, decimal companyId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("salesInvoiceReportPrint", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = ledgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal);
                sqlparameter.Value = areaId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMode", SqlDbType.VarChar);
                sqlparameter.Value = salesMode;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlparameter.Value = employeeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sqlparameter.Value = productName;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = voucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
                sqlparameter.Value = status;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal);
                sqlparameter.Value = routeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@modelnoId", SqlDbType.Decimal);
                sqlparameter.Value = modelnoId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sqlparameter.Value = productCode;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sqlparameter.Value = companyId;
                sqldataadapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Function for daybook to show details of sales 
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool DayBookSalesInvoiceOrPOS(decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            bool isPos = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DayBookSalesInvoiceOrPOS", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal).Value = decSalesMasterId;
                sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                isPos = Convert.ToBoolean(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isPos;
        }
        /// <summary>
        /// Function for FreeSale Report GridFill
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="groupId"></param>
        /// <param name="productCode"></param>
        /// <param name="ledgerId"></param>
        /// <param name="decEmployeeId"></param>
        /// <returns></returns>
        public List<DataTable> FreeSaleReportGridFill(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("FreeSaleReportGridFill", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = ledgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlparameter.Value = decEmployeeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = voucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                sqlparameter.Value = groupId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sqlparameter.Value = productCode;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function for Free Sale Report Printing
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="groupId"></param>
        /// <param name="productCode"></param>
        /// <param name="ledgerId"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet FreeSaleReportPrint(DateTime fromDate, DateTime toDate, string voucherNo, decimal voucherTypeId, decimal groupId, string productCode, decimal ledgerId, decimal decEmployeeId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("FreeSaleReportPrint", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = ledgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlparameter.Value = decEmployeeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlparameter.Value = voucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                sqlparameter.Value = groupId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sqlparameter.Value = productCode;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sqlparameter.Value = decCompanyId;
                sqldataadapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SM:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Function to check wheteher it is pos 
        /// </summary>
        /// <param name="saleMasterId"></param>
        /// <param name="voucherName"></param>
        /// <returns></returns>
        public string SaleMasterGetPos(decimal saleMasterId, string voucherName)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SaleMasterGetPos", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@salemasterId", SqlDbType.Decimal).Value = saleMasterId;
                sccmd.Parameters.Add("@voucherName", SqlDbType.VarChar).Value = voucherName;
                string pos = sccmd.ExecuteScalar().ToString();
                return pos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get SalesMasterId View By voucherNo And VoucherType
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal SalesMasterIdViewByvoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo)
        {
            decimal decStock = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesMasterIdViewByvoucherNoAndVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStock;
        }
        /// <summary>
        /// Function to check reference in purchasemaster
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decPurchaseDetailsId"></param>
        /// <returns></returns>
        public int SalseMasterReferenceCheck(decimal decSalesMsterId, decimal decSalesDetailsId)
        {
            int inQty = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalseMasterReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesMsterId;
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decSalesDetailsId;
                inQty = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inQty;
        }
        /// <summary>
        /// Function to use the PurchaseReturn Details Qty View By PurchaseDetailsId for Purchase Invoice
        /// </summary>
        /// <param name="decPurchaseDetailsId"></param>
        /// <returns></returns>
        public decimal SalesReturnDetailsQtyViewBySalesDetailsId(decimal decSalseDetailsId)
        {
            decimal decQty = 0;
            object objQty = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsQtyViewBySalesDetailsId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decSalseDetailsId;
                objQty = sccmd.ExecuteScalar();
                if (objQty != null)
                {
                    decQty = Convert.ToDecimal(objQty.ToString());
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
            return decQty;
        }
    }
}
