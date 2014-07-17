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
//Summary description for SalesOrderMasterSP    
//</summary>    
namespace OpenMiracle.DAL    
{
   public class SalesOrderMasterSP : DBConnection
    {
        /// <summary>
        ///  Function to insert values to SalesOrderMaster Table
        /// </summary>
        /// <param name="salesordermasterinfo"></param>
        /// <returns></returns>
        public decimal SalesOrderMasterAdd(SalesOrderMasterInfo salesordermasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesordermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                sprmparam.Value = salesordermasterinfo.DueDate;
                sprmparam = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
                sprmparam.Value = salesordermasterinfo.Cancelled;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
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
        /// Function to Update values in SalesOrderMaster Table
        /// </summary>
        /// <param name="salesordermasterinfo"></param>
        public void SalesOrderMasterEdit(SalesOrderMasterInfo salesordermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.SalesOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesordermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                sprmparam.Value = salesordermasterinfo.DueDate;
                sprmparam = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
                sprmparam.Value = salesordermasterinfo.Cancelled;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesordermasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesordermasterinfo.Extra2;
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
        /// Function to get all the values from SalesOrderMaster Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SalesOrderMasterViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from SalesOrderMaster Table based on the parameter
        /// </summary>
        /// <param name="salesOrderMasterId"></param>
        /// <returns></returns>
        public SalesOrderMasterInfo SalesOrderMasterView(decimal salesOrderMasterId)
        {
            SalesOrderMasterInfo salesordermasterinfo = new SalesOrderMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesOrderMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesordermasterinfo.SalesOrderMasterId = Convert.ToDecimal(sdrreader["salesOrderMasterId"].ToString());
                    salesordermasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    salesordermasterinfo.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    salesordermasterinfo.VoucherTypeId = Convert.ToDecimal(sdrreader["voucherTypeId"].ToString());
                    salesordermasterinfo.SuffixPrefixId = Convert.ToDecimal(sdrreader["suffixPrefixId"].ToString());
                    salesordermasterinfo.Date = DateTime.Parse(sdrreader["date"].ToString());
                    salesordermasterinfo.DueDate = DateTime.Parse(sdrreader["dueDate"].ToString());
                    salesordermasterinfo.Cancelled = Convert.ToBoolean(sdrreader["cancelled"].ToString());
                    salesordermasterinfo.LedgerId = Convert.ToDecimal(sdrreader["ledgerId"].ToString());
                    salesordermasterinfo.PricinglevelId = Convert.ToDecimal(sdrreader["pricinglevelId"].ToString());
                    salesordermasterinfo.EmployeeId = Convert.ToDecimal(sdrreader["employeeId"].ToString());
                    salesordermasterinfo.Narration = sdrreader["narration"].ToString();
                    salesordermasterinfo.TotalAmount = Convert.ToDecimal(sdrreader["totalAmount"].ToString());
                    salesordermasterinfo.ExchangeRateId = Convert.ToDecimal(sdrreader["exchangeRateId"].ToString());
                    salesordermasterinfo.QuotationMasterId = Convert.ToDecimal(sdrreader["quotationMasterId"].ToString());
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
            return salesordermasterinfo;
        }
        /// <summary>
        ///  Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesOrderMasterId"></param>
        public void SalesOrderMasterDeletee(decimal SalesOrderMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalesOrderMasterId;
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
        ///  Function to delete particular details based on the parameter and returns status
        /// </summary>
        /// <param name="SalesOrderMasterId"></param>
        /// <returns></returns>
        public decimal SalesOrderMasterDelete(decimal SalesOrderMasterId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalesOrderMasterId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    decResult = 1;
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
            return decResult;
        }
        /// <summary>
        /// Function to  get the next id for SalesOrderMaster table
        /// </summary>
        /// <returns></returns>
        public int SalesOrderMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax", sqlcon);
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
        /// Function to  get the next id for SalesOrderMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal SalesOrderMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax1", sqlcon);
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
        /// Function to  get the next id for SalesOrderMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string SalesOrderMasterGetMax1(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderMasterMax1", sqlcon);
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
        /// Function to get DueDays based on parameter
        /// </summary>
        /// <param name="dtStartDate"></param>
        /// <param name="dtEndDate"></param>
        /// <returns></returns>
        public decimal DueDays(DateTime dtStartDate, DateTime dtEndDate)
        {
            decimal decDueDays = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DueDays", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtStartDate;
                sqlcmd.Parameters.Add("@duedate", SqlDbType.DateTime).Value = dtEndDate;
                decDueDays = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decDueDays;
        }
        /// <summary>
        /// Function for SalesInvoice Gridfill Againest SalesOrder based on parameter
        /// </summary>
        /// <param name="strOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestSalesOrder(decimal strOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestSalesOrder", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.VarChar);
                sqlparameter.Value = strOrderMasterId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get values from SalesOrderMaster Table based on the parameter
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderMasterViewBySalesOrderMasterId(decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderMasterViewBySalesOrderMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesOrderMasterId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNOrder" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existence of SalesOrder Number based on parameter
        /// </summary>
        /// <param name="strinvoiceNo"></param>
        /// <param name="decSalesorderMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool SalesOrderNumberCheckExistence(string strinvoiceNo, decimal decSalesorderMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesOrderNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesorderMasterId;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
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
        /// Function to  get the next Voucherno based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string SalesOrderVoucherMasterMax(decimal decVoucherTypeId)
        {
            string max = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderVoucherMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = Convert.ToString(sccmd.ExecuteScalar());
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
        /// Function for SalesOrderPrinting based on parameter
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet SalesOrderPrinting(decimal decSalesOrderMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesOrderMasterId;
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
        /// Function to  get the next Voucherno based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string VoucherNoMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherNoMax", sqlcon);
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
        /// Function to  get the next id based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal SalesOrderVoucherMasterMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderVoucherMasterMax", sqlcon);
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
        /// Function for SalesOrder Register Search based on parameter
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("SalesOrderRegisterSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(decimal));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
                sprmparam.Value = strCondition;
                sprmparam = sccmd.Parameters.Add("@CurrentDate", SqlDbType.DateTime);
                sprmparam.Value = PublicVariables._dtCurrentDate;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function for SalesOrder Over Due Reminder based on parameter
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <param name="dueOn"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("SalesOrderOverDueReminder", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(decimal));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@conditon", SqlDbType.VarChar);
                sprmparam.Value = strCondition;
                sprmparam = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                sprmparam.Value = dueOn;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = decLedgerId;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function for SalesOrder No ComboFill Of SalesOrder Register based on parameter
        /// </summary>
        /// <param name="cmbSalesOrderNo"></param>
        /// <param name="isAll"></param>
        public void SalesOrderNoComboFillOfSalesOrderRegister(ComboBox cmbSalesOrderNo, bool isAll)
        {
            DataTable dtblSalesOrderNo = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderNoComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblSalesOrderNo);
                if (isAll)
                {
                    DataRow dr = dtblSalesOrderNo.NewRow();
                    dr["invoiceNo"] = "All";
                    dr["salesOrderMasterId"] = 0;
                    dtblSalesOrderNo.Rows.InsertAt(dr, 0);
                }
                cmbSalesOrderNo.DataSource = dtblSalesOrderNo;
                cmbSalesOrderNo.DisplayMember = "invoiceNo";
                cmbSalesOrderNo.ValueMember = "salesOrderMasterId";
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
        /// Function to view SalesOrder for Report  based on parameter
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strStatus"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="strSalesQuotationNo"></param>
        /// <param name="decAreaId"></param>
        /// <param name="decGroupId"></param>
        /// <param name="decRouteId"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderReportViewAll(string strInvoiceNo, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, decimal decEmployeeId, string strSalesQuotationNo, decimal decAreaId, decimal decGroupId, decimal decRouteId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("SalesOrderReportSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(int));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.VarChar);
                sprmparam.Value = strSalesQuotationNo;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = decAreaId;
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = decGroupId;
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = decRouteId;
                sdaadapter.SelectCommand = sccmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check status of salesorder based on parameter
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public bool SalesOrderCancelCheckStatus(decimal decSalesOrderMasterId)
        {
            string str = String.Empty;
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderCancelCheckStatus", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesOrderMasterId;
                str = sccmd.ExecuteScalar().ToString();
                if (str == "True")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check reference for edit  based on parameter
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public bool SalesOrderRefererenceCheckForEditMaster(decimal decSalesOrderMasterId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesOrderRefererenceCheckForEditMaster", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesOrderMasterId;
                isEdit = Convert.ToBoolean(sqlcmd.ExecuteScalar());
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
        /// Function to SalesOrder Cancel based on parameter
        /// </summary>
        /// <param name="salesOrderMasterId"></param>
        public void SalesOrderCancel(decimal salesOrderMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderCancel", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesOrderMasterId;
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
        /// Function to Get SalesOrderNo Including Pending Corresponding to Ledger for SalesInvoice based on parameter
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decSalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to GetSalesOrderNo Including Pending Corresponding to Ledger for DeliveryNote based on parameter
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decdeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decdeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decdeliveryNoteMasterId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Get SalesOrder Invoice Number Corresponding To LedgerId based on parameter
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesOrderInvoiceNumberCorrespondingToLedgerId(decimal decLedgerId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesOrderInvoiceNumberCorrespondingToLedgerId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
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
        /// Function to get all VoucherTypes Based On TypeOfVouchers
        /// </summary>
        /// <param name="typeOfVouchers"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
            sqlda.Fill(dtbl);
            ListObj.Add(dtbl);
            return ListObj;
        }
        public DataTable SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty1(decimal decSalesOrderMasterId)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty1", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sdaadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                param.Value = decSalesOrderMasterId;
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
        public DataTable SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty(decimal decSalesOrderMasterId)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderMasterReferenceCheckDeliveryNoteSalesInvoiceQty", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sdaadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                param.Value = decSalesOrderMasterId;
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
    }
}
