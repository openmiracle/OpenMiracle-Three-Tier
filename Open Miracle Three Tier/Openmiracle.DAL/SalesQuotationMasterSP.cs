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
//Summary description for SalesQuotationMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class SalesQuotationMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesQuotationMaster Table
        /// </summary>
        /// <param name="salesquotationmasterinfo"></param>
        /// <returns></returns>
        public decimal SalesQuotationMasterAdd(SalesQuotationMasterInfo salesquotationmasterinfo)
        {
            decimal decSalesQuotationmasterIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesquotationmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.userId;
                sprmparam = sccmd.Parameters.Add("@approved", SqlDbType.Bit);
                sprmparam.Value = salesquotationmasterinfo.Approved;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Extra2;
                decSalesQuotationmasterIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decSalesQuotationmasterIdentity;
        }
        /// <summary>
        /// Function to Update values in SalesQuotationMaster Table
        /// </summary>
        /// <param name="salesquotationmasterinfo"></param>
        public void SalesQuotationMasterEdit(SalesQuotationMasterInfo salesquotationmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesquotationmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@approved", SqlDbType.Bit);
                sprmparam.Value = salesquotationmasterinfo.Approved;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesquotationmasterinfo.Extra2;
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
        /// Function to get all the values from SalesQuotationMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesQuotationMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationMasterViewAll", sqlcon);
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
        /// Function for SalesQuotation Register Search
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationRegisterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            dtbl.Columns.Add("SL.NO", typeof(int));
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
                SqlCommand sccmd = new SqlCommand("SalesQuotationRegisterSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = strCondition;
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
        /// Function for SalesQuotation Report Search
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <param name="EmployeeId"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationReportSearch(string strVoucherNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition, decimal EmployeeId, decimal voucherTypeId, string ProductCode)
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
                SqlCommand sccmd = new SqlCommand("SalesQuotationReportSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = strCondition;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = EmployeeId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@ProductCode", SqlDbType.VarChar);
                sprmparam.Value = ProductCode;
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
        /// Function to get particular values from SalesQuotationMaster table based on the parameter
        /// </summary>
        /// <param name="quotationMasterId"></param>
        /// <returns></returns>
        public SalesQuotationMasterInfo SalesQuotationMasterView(decimal quotationMasterId)
        {
            SalesQuotationMasterInfo salesquotationmasterinfo = new SalesQuotationMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = quotationMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesquotationmasterinfo.QuotationMasterId = Convert.ToDecimal(sdrreader[0].ToString());
                    salesquotationmasterinfo.VoucherNo = sdrreader[1].ToString();
                    salesquotationmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    salesquotationmasterinfo.VoucherTypeId = Convert.ToDecimal(sdrreader[3].ToString());
                    salesquotationmasterinfo.SuffixPrefixId = Convert.ToDecimal(sdrreader[4].ToString());
                    salesquotationmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    salesquotationmasterinfo.PricinglevelId = Convert.ToDecimal(sdrreader[6].ToString());
                    salesquotationmasterinfo.LedgerId = Convert.ToDecimal(sdrreader[7].ToString());
                    salesquotationmasterinfo.EmployeeId = Convert.ToDecimal(sdrreader[8].ToString());
                    salesquotationmasterinfo.Approved = bool.Parse(sdrreader[9].ToString());
                    salesquotationmasterinfo.TotalAmount = Convert.ToDecimal(sdrreader[10].ToString());
                    salesquotationmasterinfo.Narration = sdrreader[11].ToString();
                    salesquotationmasterinfo.FinancialYearId = Convert.ToDecimal(sdrreader[12].ToString());
                    salesquotationmasterinfo.ExchangeRateId = Convert.ToDecimal(sdrreader[13].ToString());
                    salesquotationmasterinfo.Extra1 = sdrreader[14].ToString();
                    salesquotationmasterinfo.Extra2 = sdrreader[15].ToString();
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
            return salesquotationmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="quotationMasterId"></param>
        /// <returns></returns>
        public decimal SalesQuotationMasterDelete(decimal quotationMasterId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = quotationMasterId;
                int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffectedRow > 0)
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
        /// Function to  get the next id for SalesQuotationMaster table
        /// </summary>
        /// <returns></returns>
        public int SalesQuotationMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterMax", sqlcon);
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
        /// Function to  get the next id for SalesQuotationMaster table
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public decimal SalesQuotationMaxGetPlusOne(decimal voucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterGetMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
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
        /// Function to  get the next id for SalesQuotationMaster table
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public string SalesQuotationMasterGetMax(decimal voucherTypeId)
        {
            string max = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationMasterGetMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
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
        /// Function for Checking Stastus For SalesQuotation and return id
        /// </summary>
        /// <param name="decSaleQuotationMasterId"></param>
        /// <returns></returns>
        public decimal CheckingStastusForSalesQuotation(decimal decSaleQuotationMasterId)
        {
            decimal decCount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckingStastusForSalesQuotation", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSaleQuotationMasterId;
                decCount = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decCount;
        }
        /// <summary>
        /// Function  for SalesQuotation Printing
        /// </summary>
        /// <param name="decSalesQuotationMasterId"></param>
        /// <returns></returns>
        public DataSet SalesQuotationPrinting(decimal decSalesQuotationMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesQuotationMasterId;
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
        /// Function to get next VoucherNo 
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
        /// Function to check existence of SalesQuotation Number
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decSalesQuotationVoucherTypeId"></param>
        /// <returns></returns>
        public bool CheckSalesQuotationNumberExistance(string strInvoiceNo, decimal decSalesQuotationVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CheckSalesQuotationNumberExistance", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decSalesQuotationVoucherTypeId;
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
        /// Function to check refernce for update
        /// </summary>
        /// <param name="decSalesQuotationMasterId"></param>
        /// <returns></returns>
        public bool SalesQuotationRefererenceCheckForEditMaster(decimal decSalesQuotationMasterId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesQuotationRefererenceCheckForEditMaster", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesQuotationMasterId;
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
        /// Function for QuotationMaster View By QuotationMasterId
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <returns></returns>
        public List<DataTable> QuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("QuotationMasterViewByQuotationMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
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
        /// Function to Get QuotationNo Corresponding to Ledger For SalesOrder Report
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
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
        /// Function to Get SalesQuotation Number Corresponding To Ledger For DeliveryNote
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedgerForDN(decimal decLedgerId, decimal decVoucherTypeId, decimal decDeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedgerForDN", sqlcon);
                sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlParameter.Value = decLedgerId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decVoucherTypeId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decDeliveryNoteMasterId;
                sqldataadapeter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Get SalesQuotation Number Corresponding To Ledger
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedger(decimal decLedgerId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedger", sqlcon);
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
        /// Function for SalesQuotation Master BatchFill
        /// </summary>
        /// <param name="dgvproduct"></param>
        /// <param name="DecProductId"></param>
        /// <param name="InRowIndex"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationMasterBatchFill(DataGridView dgvproduct, decimal DecProductId, int InRowIndex)
        {
            DataTable dtblBatchViewAll = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationMasterBatchFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sqlparameter.Value = DecProductId;
                sdaadapter.Fill(dtblBatchViewAll);
                ListObj.Add(dtblBatchViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            try
            {
                DataGridViewComboBoxCell dgvcmbBatch = (DataGridViewComboBoxCell)dgvproduct[dgvproduct.Columns["dgvcmbBatch"].Index, InRowIndex];
                if (dtblBatchViewAll.Rows.Count > 0)
                {
                    dgvcmbBatch.DataSource = ListObj[0];
                    dgvcmbBatch.DisplayMember = "batchNo";
                    dgvcmbBatch.ValueMember = "batchId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function for SalesQuotation Master View By QuotationMasterId
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationMasterViewByQuotationMasterId(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationMasterViewByQuotationMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
                sqlda.Fill(dtbl);
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
        /// Function for SalesInvoice Gridfill Againest Quotation
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestQuotation(decimal decQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestQuotation", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
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
        /// Function to Get SalesQuotation Including Pending Correspondingto Ledger For SalesInvoice
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decSalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            DataTable dtbLQuotation = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI", sqlcon);
                sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlParameter.Value = decLedgerId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decSalesMasterId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decVoucherTypeId;
                sqldataadapeter.Fill(dtbLQuotation);
                ListObj.Add(dtbLQuotation);
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
        /// Function to Get SalesQuotation Number Corresponding To Ledger For SalesOrder 
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> GetSalesQuotationNumberCorrespondingToLedgerForSO(decimal decLedgerId, decimal decVoucherTypeId, decimal decSalesOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapeter = new SqlDataAdapter("GetSalesQuotationNumberCorrespondingToLedgerForSO", sqlcon);
                sqldataadapeter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlParameter.Value = decLedgerId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decVoucherTypeId;
                sqlParameter = sqldataadapeter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decSalesOrderMasterId;
                sqldataadapeter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
    }
}
