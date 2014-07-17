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
//Summary description for PurchaseReturnMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PurchaseReturnMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseReturnMaster Table
        /// </summary>
        /// <param name="purchasereturnmasterinfo"></param>
        public void PurchaseReturnMasterAdd(PurchaseReturnMasterInfo purchasereturnmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseAccount;
                sprmparam = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalTax;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra2;
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
        /// Function to Update values in PurchaseReturnMaster Table
        /// </summary>
        /// <param name="purchasereturnmasterinfo"></param>
        public void PurchaseReturnMasterEdit(PurchaseReturnMasterInfo purchasereturnmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseAccount;
                sprmparam = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalTax;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra2;
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
        /// Function to get all the values from PurchaseReturnMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseReturnMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnMasterViewAll", sqlcon);
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
        /// Function to get particular values from PurchaseReturnMaster table based on the parameter
        /// </summary>
        /// <param name="purchaseReturnMasterId"></param>
        /// <returns></returns>
        public PurchaseReturnMasterInfo PurchaseReturnMasterView(decimal purchaseReturnMasterId)
        {
            PurchaseReturnMasterInfo purchasereturnmasterinfo = new PurchaseReturnMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseReturnMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchasereturnmasterinfo.PurchaseReturnMasterId = Convert.ToDecimal(sdrreader["purchaseReturnMasterId"].ToString());
                    purchasereturnmasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    purchasereturnmasterinfo.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    purchasereturnmasterinfo.SuffixPrefixId = Convert.ToDecimal(sdrreader["suffixPrefixId"].ToString());
                    purchasereturnmasterinfo.VoucherTypeId = Convert.ToDecimal(sdrreader["voucherTypeId"].ToString());
                    purchasereturnmasterinfo.Date = Convert.ToDateTime(sdrreader["date"].ToString());
                    purchasereturnmasterinfo.LedgerId = Convert.ToDecimal(sdrreader["ledgerId"].ToString());
                    purchasereturnmasterinfo.Discount = Convert.ToDecimal(sdrreader["discount"].ToString());
                    purchasereturnmasterinfo.Narration = sdrreader["narration"].ToString();
                    purchasereturnmasterinfo.PurchaseAccount = Convert.ToDecimal(sdrreader["purchaseAccount"].ToString());
                    purchasereturnmasterinfo.TotalTax = Convert.ToDecimal(sdrreader["totalTax"].ToString());
                    purchasereturnmasterinfo.TotalAmount = Convert.ToDecimal(sdrreader["totalAmount"].ToString());
                    purchasereturnmasterinfo.GrandTotal = Convert.ToDecimal(sdrreader["grandTotal"].ToString());
                    purchasereturnmasterinfo.UserId = Convert.ToDecimal(sdrreader["userId"].ToString());
                    purchasereturnmasterinfo.LrNo = sdrreader["lrNo"].ToString();
                    purchasereturnmasterinfo.TransportationCompany = sdrreader["transportationCompany"].ToString();
                    purchasereturnmasterinfo.FinancialYearId = Convert.ToDecimal(sdrreader["financialYearId"].ToString());
                    purchasereturnmasterinfo.PurchaseMasterId = Convert.ToDecimal(sdrreader["purchaseMasterId"].ToString());
                    purchasereturnmasterinfo.ExchangeRateId = Convert.ToDecimal(sdrreader["exchangeRateId"].ToString());
                    purchasereturnmasterinfo.ExtraDate = Convert.ToDateTime(sdrreader["extraDate"].ToString());
                    purchasereturnmasterinfo.Extra1 = sdrreader["extra1"].ToString();
                    purchasereturnmasterinfo.Extra2 = sdrreader["extra2"].ToString();
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
            return purchasereturnmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PurchaseReturnMasterId"></param>
        public void PurchaseReturnMasterDelete(decimal PurchaseReturnMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseReturnMasterId;
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
        /// Function to  get the next id for PurchaseReturnMaster table
        /// </summary>
        /// <returns></returns>
        public int PurchaseReturnMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", sqlcon);
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
        /// Function to  get the next id for PurchaseReturnMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PurchaseReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
        /// Function to  get the next id for PurchaseReturnMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string PurchaseReturnMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = sccmd.ExecuteScalar().ToString();
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
        /// Function to get tax rate from purchase details
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public string TaxRateFromPurchaseDetails(decimal taxId)
        {
            string taxRate = string.Empty; ;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxRateFromPurchaseDetails", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxId;
                taxRate = Convert.ToString(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return taxRate; ;
        }
        /// <summary>
        /// Function to insert values to PurchaseReturnMaster Table
        /// </summary>
        /// <param name="purchasereturnmasterinfo"></param>
        /// <returns></returns>
        public decimal PurchaseReturnMasterAddWithReturnIdentity(PurchaseReturnMasterInfo purchasereturnmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@ExchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.PurchaseAccount;
                sprmparam = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalTax;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturnmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturnmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturnmasterinfo.Extra2;
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
        /// Function to get details for printing purchase return 
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public DataSet PurchaseReturnPrinting(decimal decPurchaseReturnMasterId, decimal decCompanyId, decimal decPurchaseMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseReturnMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        public void PurchaseReturnMasterAndDetailsDelete(decimal decPurchaseReturnMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnMasterAndDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseReturnMasterId;
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
        /// Function to get details for PurchaseReturn Register
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decAgainstInvoiceNo"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decVoucherType)
        {
            List<DataTable> ListObjReg = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnRegisterFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                param.Value = strInvoiceNo;
                param = sqlda.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.Decimal);
                param.Value = decAgainstInvoiceNo;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherType;
                sqlda.Fill(dtbl);
                ListObjReg.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObjReg;
        }
        /// <summary>
        /// Function to get particular values from PurchaseReturnMaster table based on the parameter
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnMasterViewByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseReturnMasterViewAllByPurchaseMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseMasterId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from PurchaseReturnMaster table based on the parameter
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnViewByPurchaseReturnMasterId(decimal decPurchaseReturnMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseReturnViewByPurchaseReturnMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseReturnMasterId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get the details of PurchaseReturn Report
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decInvoiceNo"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decInvoiceNo, string strProductCode, string strVoucherNo)
        {
            List<DataTable> ListObjReg = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnReportGridfill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.Decimal);
                param.Value = decInvoiceNo;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                sqlda.Fill(dtbl);
                ListObjReg.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObjReg;
        }
        /// <summary>
        /// Function to get details for PurchaseReturn Report Printing
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decCashOrParty"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeName"></param>
        /// <param name="decProductCode"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decInvoiceNo"></param>
        /// <returns></returns>
        public DataSet PurchaseReturnReportPrinting(DateTime fromDate, DateTime toDate, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, decimal decProductCode, decimal decCompanyId, decimal decInvoiceNo)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseReturnReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = fromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = toDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decCashOrParty;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeName;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductCode;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.Decimal);
                sprmparam.Value = decInvoiceNo;
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
        /// Get InvoiceNo Corresponding to Ledger For PurchaseReturn Register
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport(decimal decLedgerId, decimal decVoucherId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existance of purchase return number 
        /// </summary>
        /// <param name="strinvoiceNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool PurchaseReturnNumberCheckExistence(string strinvoiceNo, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PurchaseReturnNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
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
