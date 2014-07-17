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
//Summary description for RejectionOutMasterSP    
//</summary>    
namespace OpenMiracle.DAL   
{
    public class RejectionOutMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to RejectionOutMaster Table
        /// </summary>
        /// <param name="rejectionoutmasterinfo"></param>
        public void RejectionOutMasterAdd(RejectionOutMasterInfo rejectionoutmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.RejectionOutMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra2;
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
        /// Function to insert values to RejectionOutMaster Table
        /// </summary>
        /// <param name="rejectionoutmasterinfo"></param>
        /// <returns></returns>
        public decimal RejectionOutMasterAddWithReturnIdentity(RejectionOutMasterInfo rejectionoutmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra2;
                Object obj = Convert.ToDecimal(sccmd.ExecuteScalar());
                if (obj != null)
                {
                    decIdentity = Convert.ToDecimal(obj);
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
            return decIdentity;
        }
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public List<DataTable> RejectionOutMasterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> list = new List<DataTable>();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decRejectionOutMasterId"></param>
        public void RejectionOutMasterAndDetailsDelete(decimal decRejectionOutMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionOutMasterAndDetailsDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                param.Value = decRejectionOutMasterId;
                cmd.ExecuteNonQuery();
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
        /// Function to get rejectionout voucherNo based on parameter
        /// </summary>
        /// <param name="decRejectionOutMasterId"></param>
        /// <returns></returns>
        public string GetRejectionOutVoucherNo(decimal decRejectionOutMasterId)
        {
            string strRejectionOutVoucherNo;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionOutVoucherNoViewByRejectionOutMasterId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                param.Value = decRejectionOutMasterId;
                strRejectionOutVoucherNo = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return strRejectionOutVoucherNo;
        }
        /// <summary>
        /// Function to Update values in RejectionOutMaster Table
        /// </summary>
        /// <param name="rejectionoutmasterinfo"></param>
        public void RejectionOutMasterEdit(RejectionOutMasterInfo rejectionoutmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.RejectionOutMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutmasterinfo.Extra2;
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
        /// Function to get all the values from RejectionOutMaster Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RejectionOutMasterViewAll()
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutMasterViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get particular values from RejectionOutMaster table based on the parameter
        /// </summary>
        /// <param name="rejectionOutMasterId"></param>
        /// <returns></returns>
        public RejectionOutMasterInfo RejectionOutMasterView(decimal rejectionOutMasterId)
        {
            RejectionOutMasterInfo rejectionoutmasterinfo = new RejectionOutMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionOutMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    rejectionoutmasterinfo.RejectionOutMasterId = decimal.Parse(sdrreader[0].ToString());
                    rejectionoutmasterinfo.VoucherNo = sdrreader[1].ToString();
                    rejectionoutmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    rejectionoutmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    rejectionoutmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[4].ToString());
                    rejectionoutmasterinfo.MaterialReceiptMasterId = decimal.Parse(sdrreader[5].ToString());
                    rejectionoutmasterinfo.Date = DateTime.Parse(sdrreader[6].ToString());
                    rejectionoutmasterinfo.LedgerId = decimal.Parse(sdrreader[7].ToString());
                    rejectionoutmasterinfo.Narration = sdrreader[8].ToString();
                    rejectionoutmasterinfo.ExchangeRateId = decimal.Parse(sdrreader[9].ToString());
                    rejectionoutmasterinfo.TotalAmount = decimal.Parse(sdrreader[10].ToString());
                    rejectionoutmasterinfo.UserId = decimal.Parse(sdrreader[11].ToString());
                    rejectionoutmasterinfo.LrNo = sdrreader[12].ToString();
                    rejectionoutmasterinfo.TransportationCompany = sdrreader[13].ToString();
                    rejectionoutmasterinfo.FinancialYearId = decimal.Parse(sdrreader[14].ToString());
                    rejectionoutmasterinfo.ExtraDate = DateTime.Parse(sdrreader[15].ToString());
                    rejectionoutmasterinfo.Extra1 = sdrreader[16].ToString();
                    rejectionoutmasterinfo.Extra2 = sdrreader[17].ToString();
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
            return rejectionoutmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="RejectionOutMasterId"></param>
        public void RejectionOutMasterDelete(decimal RejectionOutMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = RejectionOutMasterId;
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
        /// Function to  get the next id for RejectionOutMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal RejectionOutMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterMax", sqlcon);
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
        /// Function to  get the next id for RejectionOutMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string RejectionOutMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutMasterMax", sqlcon);
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
        /// Function to check existance of rejection out number
        /// </summary>
        /// <param name="strinvoiceNo"></param>
        /// <param name="decRejectionOutMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool RejectionOutNumberCheckExistence(string strinvoiceNo, decimal decRejectionOutMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("RejectionOutNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = decRejectionOutMasterId;
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
        /// <summary>
        /// Function to get details for RejectionOut printing
        /// </summary>
        /// <param name="decRejectionOutMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet RejectionOutPrinting(decimal decRejectionOutMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionOutPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = decRejectionOutMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
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
        /// Function to get details for RejectionOut Report
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="decReceiptMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> RejectionOutReportFill(string strinvoiceNo, string strProductCode, string strProductName, decimal decLedgerId, DateTime FromDate, DateTime ToDate, decimal decReceiptMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> list = new List<DataTable>();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("RejectionOutReportFill", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get details for RejectionOut Report printing
        /// </summary>
        /// <param name="decmaterialReceiptMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public DataSet RejectionOutReportPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, string strProductCode, string strProductName)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionOutReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                param.Value = decmaterialReceiptMasterId;
                param = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                param.Value = decCompanyId;
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                param = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                param.Value = strProductName;
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
    }
}
