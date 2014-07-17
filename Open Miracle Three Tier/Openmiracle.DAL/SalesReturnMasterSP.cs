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
//Summary description for SalesReturnMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SalesReturnMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesReturnMaster Table
        /// </summary>
        /// <param name="salesreturnmasterinfo"></param>
        /// <returns></returns>
        public decimal SalesReturnMasterAdd(SalesReturnMasterInfo salesreturnmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SalesAccount;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesreturnmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.grandTotal;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Extra2;
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
        /// Function to Update values in SalesReturnMaster Table
        /// </summary>
        /// <param name="salesreturnmasterinfo"></param>
        public void SalesReturnMasterEdit(SalesReturnMasterInfo salesreturnmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SalesReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@salesAccount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.SalesAccount;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salesreturnmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.grandTotal;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturnmasterinfo.Extra2;
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
        /// Function to get all the values from SalesReturnMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesReturnMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnMasterViewAll", sqlcon);
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
        /// Function to get particular values from SalesReturnMaster Table based on the parameter
        /// </summary>
        /// <param name="salesReturnMasterId"></param>
        /// <returns></returns>
        public SalesReturnMasterInfo SalesReturnMasterView(decimal salesReturnMasterId)
        {
            SalesReturnMasterInfo salesreturnmasterinfo = new SalesReturnMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesReturnMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesreturnmasterinfo.SalesReturnMasterId = decimal.Parse(sdrreader["salesReturnMasterId"].ToString());
                    salesreturnmasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    salesreturnmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    salesreturnmasterinfo.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
                    salesreturnmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader["suffixPrefixId"].ToString());
                    salesreturnmasterinfo.LedgerId = decimal.Parse(sdrreader["ledgerId"].ToString());
                    salesreturnmasterinfo.SalesAccount = decimal.Parse(sdrreader[6].ToString());
                    salesreturnmasterinfo.PricinglevelId = decimal.Parse(sdrreader["pricinglevelId"].ToString());
                    salesreturnmasterinfo.EmployeeId = decimal.Parse(sdrreader["employeeId"].ToString());
                    salesreturnmasterinfo.Narration = sdrreader[9].ToString();
                    salesreturnmasterinfo.ExchangeRateId = decimal.Parse(sdrreader["exchangeRateId"].ToString());
                    salesreturnmasterinfo.TaxAmount = decimal.Parse(sdrreader["taxAmount"].ToString());
                    salesreturnmasterinfo.UserId = decimal.Parse(sdrreader["userId"].ToString());
                    salesreturnmasterinfo.LrNo = sdrreader[13].ToString();
                    salesreturnmasterinfo.TransportationCompany = sdrreader[14].ToString();
                    salesreturnmasterinfo.Date = DateTime.Parse(sdrreader["date"].ToString());
                    salesreturnmasterinfo.TotalAmount = decimal.Parse(sdrreader["totalAmount"].ToString());
                    salesreturnmasterinfo.grandTotal = decimal.Parse(sdrreader["grandTotal"].ToString());
                    salesreturnmasterinfo.FinancialYearId = decimal.Parse(sdrreader["financialYearId"].ToString());
                    salesreturnmasterinfo.ExtraDate = DateTime.Parse(sdrreader["extraDate"].ToString());
                    salesreturnmasterinfo.Extra1 = sdrreader["extra1"].ToString();
                    salesreturnmasterinfo.Extra2 = sdrreader[20].ToString();
                    salesreturnmasterinfo.Discount = decimal.Parse(sdrreader["discount"].ToString());
                    salesreturnmasterinfo.SalesMasterId = decimal.Parse(sdrreader["salesMasterId"].ToString());
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
            return salesreturnmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesReturnMasterId"></param>
        public void SalesReturnMasterAndDetailsDelete(decimal SalesReturnMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDeleteOfMasterAndDetails", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalesReturnMasterId;
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
        /// Function to  get the next id for SalesReturnMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal SalesReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterMax", sqlcon);
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
        /// Function to  get the next id for SalesReturnMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string SalesReturnMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterMax", sqlcon);
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
        /// Function for SalesReturn Invoice No ComboFill based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="salesReturnMasterId"></param>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnInvoiceNoComboFill(decimal decVoucherTypeId, decimal salesReturnMasterId, decimal decledgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnInvoiceNoComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                SqlParameter sprmparam1 = new SqlParameter();
                sprmparam1 = sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam1.Value = salesReturnMasterId;
                SqlParameter sprmparam2 = new SqlParameter();
                sprmparam1 = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam1.Value = decledgerId;
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
        /// Function for SalesReturn VoucherType ComboFill based on parameter
        /// </summary>
        /// <param name="ledgerIdFromCashOrPartyCombo"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnVoucherTypeComboFill(decimal ledgerIdFromCashOrPartyCombo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeViewAllByLedgerId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerIdFromCashOrPartyCombo;
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
        /// Function to get id based on parameter
        /// </summary>
        /// <param name="salesMasterId"></param>
        /// <returns></returns>
        public string SalesReturnIdViewBysalesMasterId(decimal salesMasterId)
        {
            string salesReturnId = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnMasterIdViewBySalesMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesMasterId;
                salesReturnId = Convert.ToString(sccmd.ExecuteScalar());
                if (salesReturnId == string.Empty)
                {
                    salesReturnId = "0";
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
            return salesReturnId;
        }
        /// <summary>
        /// Function to get Tax Rate For TaxAmount Calculation By TaxId
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public string TaxRateFindForTaxAmmountCalByTaxId(decimal taxId)
        {
            string taxRate = string.Empty; ;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxRateFindBySalesdetailsId", sqlcon);
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
        /// Function to check existence of SalesReturn based on parameter
        /// </summary>
        /// <param name="strinvoiceNo"></param>
        /// <param name="decSalesReturnMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool SalesReturnNumberCheckExistence(string strinvoiceNo, decimal decSalesReturnMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesReturnNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesReturnMasterId;
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
        /// Function for Print 
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        /// <returns></returns>
        public DataSet SalesReturnPrinting(decimal decSalesReturnMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesReturnMasterId;
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
        /// Function for Printing  Report based on parameter
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decSalesMan"></param>
        /// <param name="decCashOrParty"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeName"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public DataSet SalesReturnReportPrinting(DateTime fromDate, DateTime toDate, decimal decSalesMan, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, string strProductCode)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = fromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = toDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.VarChar);
                sprmparam.Value = decSalesMan;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = decCashOrParty;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = decVoucherTypeName;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
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
        /// Function for Gridfill in Register based on parameter
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decAgainstInvoiceNo"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnRegisterGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decvouchertypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblReg = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnRegisterGrideFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblReg.Columns.Add("slNo", typeof(decimal));
                dtblReg.Columns["slNo"].AutoIncrement = true;
                dtblReg.Columns["slNo"].AutoIncrementSeed = 1;
                dtblReg.Columns["slNo"].AutoIncrementStep = 1;
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
                param.Value = decvouchertypeId;
                sqlda.Fill(dtblReg);
                ListObj.Add(dtblReg);
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
        /// Function for Gridfill in Report based on parameter
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnReportGrideFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decEmployeeId, string strProductCode, string strVoucherNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblReg = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnReportGrideFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblReg.Columns.Add("slNo", typeof(decimal));
                dtblReg.Columns["slNo"].AutoIncrement = true;
                dtblReg.Columns["slNo"].AutoIncrementSeed = 1;
                dtblReg.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                param.Value = decEmployeeId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                sqlda.Fill(dtblReg);
                ListObj.Add(dtblReg);
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
        /// Function for SalesReturnNo ComboFill Of SalesReturn Register based on parameter
        /// </summary>
        /// <param name="cmbSalesReturnNo"></param>
        /// <param name="isAll"></param>
        public void SalesReturnNoComboFillOfSalesReturnRegister(ComboBox cmbSalesReturnNo, bool isAll)
        {
            DataTable dtblSalesReturnno = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesReturnNoComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblSalesReturnno);
                if (isAll)
                {
                    DataRow dr = dtblSalesReturnno.NewRow();
                    dr["invoiceNo"] = "All";
                    dr["salesReturnMasterId"] = 0;
                    dtblSalesReturnno.Rows.InsertAt(dr, 0);
                }
                cmbSalesReturnNo.DataSource = dtblSalesReturnno;
                cmbSalesReturnNo.DisplayMember = "invoiceNo";
                cmbSalesReturnNo.ValueMember = "salesReturnMasterId";
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
        /// Function for InvoiceNo ComboFill Of SalesReturn Register based on parmeter
        /// </summary>
        /// <param name="cmbInvoiceNo"></param>
        /// <param name="isAll"></param>
        public void InvoiceNoComboFillOfSalesReturnRegister(ComboBox cmbInvoiceNo, bool isAll)
        {
            DataTable dtblInvoiceNo = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AgainstInvoiceNoComboFillInSalesReturnRegister", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblInvoiceNo);
                if (isAll)
                {
                    DataRow dr = dtblInvoiceNo.NewRow();
                    dr["invoiceNo"] = "All";
                    dr["salesMasterId"] = 0;
                    dtblInvoiceNo.Rows.InsertAt(dr, 0);
                }
                cmbInvoiceNo.DataSource = dtblInvoiceNo;
                cmbInvoiceNo.DisplayMember = "invoiceNo";
                cmbInvoiceNo.ValueMember = "salesMasterId";
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
        /// Function for VoucherType ComboFill Of SalesReturn Report based on parmeter
        /// </summary>
        /// <param name="cmbVoucherType"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="isAll"></param>
        public void VoucherTypeComboFillOfSalesReturnReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            DataTable dtblVoucherName = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeComboFillForSalesReturnReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
                sqlda.Fill(dtblVoucherName);
                if (isAll)
                {
                    DataRow dr = dtblVoucherName.NewRow();
                    dr["voucherTypeName"] = "All";
                    dr["voucherTypeId"] = 0;
                    dtblVoucherName.Rows.InsertAt(dr, 0);
                }
                cmbVoucherType.DataSource = dtblVoucherName;
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.ValueMember = "voucherTypeId";
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
        /// Function for SalesMan ComboFill Of SalesReturn Report based on parmeter
        /// </summary>
        /// <param name="cmbSalesMan"></param>
        /// <param name="isAll"></param>
        public void SalesManComboFillOfSalesReturnReport(ComboBox cmbSalesMan, bool isAll)
        {
            DataTable dtblSalesManName = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesManComboFillForSalesReturnReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblSalesManName);
                if (isAll)
                {
                    DataRow dr = dtblSalesManName.NewRow();
                    dr["employeeName"] = "All";
                    dr["employeeId"] = 0;
                    dtblSalesManName.Rows.InsertAt(dr, 0);
                }
                cmbSalesMan.DataSource = dtblSalesManName;
                cmbSalesMan.DisplayMember = "employeeName";
                cmbSalesMan.ValueMember = "employeeId";
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
        /// Function for view based on parameter
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnMasterViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnMasterViewBySalesReturnMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesReturnMasterId;
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
        /// Function for view based on parameter
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnMasterViewBySalesMasterId(decimal decSalesMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnMasterViewAllBySalesMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesMasterId;
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
        /// Function for delete based on parameter
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void SalesReturnDelete(decimal decSalesReturnMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesReturnMasterId;
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
        /// VoucherTypeFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> vouchertypecompofill()
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
                SqlCommand sqlcmd = new SqlCommand("vouchertypecompofill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                DataRow dr = ListObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "NA";
                ListObj[0].Rows.InsertAt(dr, 0);
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
        /// InvoiceFill
        /// </summary>
        /// <param name="vouchertypeId"></param>
        /// <returns></returns>
        public List<DataTable> invoicenumberviewallforvouchertypeIdforSR(decimal vouchertypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("invoicenumberviewallforvouchertypeIdforSR", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = vouchertypeId;
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

    }
}
