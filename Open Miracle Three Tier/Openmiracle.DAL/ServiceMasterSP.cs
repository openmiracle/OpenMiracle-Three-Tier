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
//Summary description for ServiceMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ServiceMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ServiceMaster Table
        /// </summary>
        /// <param name="servicemasterinfo"></param>
        /// <returns></returns>
        public decimal ServiceMasterAdd(ServiceMasterInfo servicemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = servicemasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ServiceAccount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Customer;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra2;
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
        /// Function to insert values to ServiceMaster Table and return corresponding row's id
        /// </summary>
        /// <param name="servicemasterinfo"></param>
        /// <returns></returns>
        public decimal ServiceMasterAddReturnWithIdentity(ServiceMasterInfo servicemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMasterAddReturnWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = servicemasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ServiceAccount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Customer;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra2;
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
        /// Function to Update values in ServiceMaster Table
        /// </summary>
        /// <param name="servicemasterinfo"></param>
        public void ServiceMasterEdit(ServiceMasterInfo servicemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = servicemasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@serviceAccount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ServiceAccount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@customer", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Customer;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = servicemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicemasterinfo.Extra2;
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
        /// Function to get all the values from ServiceMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable ServiceMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceMasterViewAll", sqlcon);
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
        ///  Function to get particular values from ServiceMaster Table based on the parameter
        /// </summary>
        /// <param name="serviceMasterId"></param>
        /// <returns></returns>
        public ServiceMasterInfo ServiceMasterView(decimal serviceMasterId)
        {
            ServiceMasterInfo servicemasterinfo = new ServiceMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = serviceMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    servicemasterinfo.ServiceMasterId = decimal.Parse(sdrreader["serviceMasterId"].ToString());
                    servicemasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    servicemasterinfo.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    servicemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader["suffixPrefixId"].ToString());
                    servicemasterinfo.Date = DateTime.Parse(sdrreader["date"].ToString());
                    servicemasterinfo.LedgerId = decimal.Parse(sdrreader["ledgerId"].ToString());
                    servicemasterinfo.TotalAmount = decimal.Parse(sdrreader["totalAmount"].ToString());
                    servicemasterinfo.Narration = sdrreader["narration"].ToString();
                    servicemasterinfo.UserId = decimal.Parse(sdrreader["userId"].ToString());
                    servicemasterinfo.CreditPeriod = int.Parse(sdrreader["creditPeriod"].ToString());
                    servicemasterinfo.ServiceAccount = decimal.Parse(sdrreader["serviceAccount"].ToString());
                    servicemasterinfo.ExchangeRateId = decimal.Parse(sdrreader["exchangeRateId"].ToString());
                    servicemasterinfo.EmployeeId = Convert.ToDecimal(sdrreader["employeeId"].ToString());
                    servicemasterinfo.Customer = sdrreader["customer"].ToString();
                    servicemasterinfo.Discount = decimal.Parse(sdrreader["discount"].ToString());
                    servicemasterinfo.GrandTotal = decimal.Parse(sdrreader["grandTotal"].ToString());
                    servicemasterinfo.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
                    servicemasterinfo.FinancialYearId = decimal.Parse(sdrreader["financialYearId"].ToString());
                    servicemasterinfo.ExtraDate = DateTime.Parse(sdrreader["extraDate"].ToString());
                    servicemasterinfo.Extra1 = sdrreader["extra1"].ToString();
                    servicemasterinfo.Extra2 = sdrreader["extra2"].ToString();
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
            return servicemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ServiceMasterId"></param>
        public void ServiceMasterDelete(decimal ServiceMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = ServiceMasterId;
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
        /// Function to  get the next id for ServiceMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public int ServiceMasterGetMax(decimal decVoucherTypeId)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceVoucherMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function to check existence of service and return status based on parameter
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="masterId"></param>
        /// <returns></returns>
        public bool ServiceVoucherCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = masterId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        trueOrfalse = true;
                    }
                    else
                    {
                        trueOrfalse = false;
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
            return trueOrfalse;
        }
        /// <summary>
        /// Function to view details for search based on parameter
        /// </summary>
        /// <param name="dtdateFrom"></param>
        /// <param name="dtdateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceVoucherRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherNo, string strLedgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblSM = new DataTable();
            dtblSM.Columns.Add("SlNo", typeof(decimal));
            dtblSM.Columns["SlNo"].AutoIncrement = true;
            dtblSM.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblSM.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ServiceRegisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
                sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlda.Fill(dtblSM);
                ListObj.Add(dtblSM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to view details for search in report based on parameter
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherTypeName"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strEmployeeName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceReportSearch(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ServiceReportSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to view details for Print based on parameter
        /// </summary>
        /// <param name="decserviceMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public DataSet ServiceVoucherPrinting(decimal decserviceMasterId, decimal decCompanyId, decimal decExchangeRateId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decserviceMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                sdaadapter.Fill(dSt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dSt;
        }
        /// <summary>
        /// Function to get LedgerPosting id based on parameter
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        /// <returns></returns>
        public List<DataTable> LedgerPostingIdByServiceMaasterId(decimal decServiceMasterId)
        {
            List<DataTable> listObjServiceMasterId = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByServiceMaasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decServiceMasterId;
                sdaadapter.Fill(dtbl);
                listObjServiceMasterId.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjServiceMasterId;
        }
        /// <summary>
        /// Function to get values for report based on parameter
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherTypeName"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strEmployeeName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceReport(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ServiceReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to get values for Service VoucherTypeId By ServiceMasterId And VocherNo 
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        /// <param name="decVoucherNo"></param>
        /// <returns></returns>
        public ServiceMasterInfo GetServiceVoucherTypeIdByServiceMasterIdAndVocherNo(decimal decServiceMasterId, decimal decVoucherNo)
        {
            ServiceMasterInfo servicemasterinfo = new ServiceMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GetServiceVoucherTypeIdByServiceMasterIdAndVocherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.Decimal);
                sprmparam.Value = decVoucherNo;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    servicemasterinfo.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
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
            return servicemasterinfo;
        }
        /// <summary>
        /// Function to delete service based on parameter
        /// </summary>
        /// <param name="decPartyBalanceId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decServiceMasterId"></param>
        public void ServiceVoucherDelete(decimal decPartyBalanceId, decimal decVoucherTypeId, string strVoucherNo, decimal decServiceMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceVoucherDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
                sprmparam.Value = decPartyBalanceId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decServiceMasterId;
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
    }
}
