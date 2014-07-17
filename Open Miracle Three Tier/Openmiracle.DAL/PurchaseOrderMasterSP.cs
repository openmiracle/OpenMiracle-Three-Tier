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
//Summary description for PurchaseOrderMasterSP    
//</summary>    
namespace OpenMiracle.DAL    
{
   public class PurchaseOrderMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseOrderMaster Table
        /// </summary>
        /// <param name="purchaseordermasterinfo"></param>
        /// <returns></returns>
        public decimal PurchaseOrderMasterAdd(PurchaseOrderMasterInfo purchaseordermasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchaseordermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                sprmparam.Value = purchaseordermasterinfo.DueDate;
                sprmparam = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
                sprmparam.Value = purchaseordermasterinfo.Cancelled;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.exchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Extra2;
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
        /// Function to Update values in PurchaseOrderMaster Table
        /// </summary>
        /// <param name="purchaseordermasterinfo"></param>
        public void PurchaseOrderMasterEdit(PurchaseOrderMasterInfo purchaseordermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.PurchaseOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchaseordermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.exchangeRateId;
                sprmparam = sccmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                sprmparam.Value = purchaseordermasterinfo.DueDate;
                sprmparam = sccmd.Parameters.Add("@cancelled", SqlDbType.Bit);
                sprmparam.Value = purchaseordermasterinfo.Cancelled;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchaseordermasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchaseordermasterinfo.Extra2;
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
        /// Function to cancel the purchaseorder
        /// </summary>
        /// <param name="purchaseOrderMasterId"></param>
        public void PurchaseOrderCancel(decimal purchaseOrderMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderCancel", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseOrderMasterId;
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
        /// Function to view all purchase order
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderMasterViewAll(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate, string strCondition)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlCommand sccmd = new SqlCommand("PurchaseOrderRgistersearch", sqlcon);
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
                sprmparam = sccmd.Parameters.Add("@conditon", SqlDbType.VarChar);
                sprmparam.Value = strCondition;
                sprmparam = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
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
        /// Function for purchaseorder overdue reminder
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strCondition"></param>
        /// <param name="dueOn"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderOverDueReminder(DateTime FromDate, DateTime ToDate, string strCondition, DateTime dueOn, string decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlCommand sccmd = new SqlCommand("PurchaseOrderOverDueReminder", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
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
        /// Function to view all details for purchaseorder report
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrdeReportViewAll(string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
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
                SqlCommand sccmd = new SqlCommand("PurchaseOrderReportsearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@Status", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
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
        /// Function to get particular values from PurchaseOrderMaster table based on the parameter
        /// </summary>
        /// <param name="purchaseOrderMasterId"></param>
        /// <returns></returns>
        public PurchaseOrderMasterInfo PurchaseOrderMasterView(decimal purchaseOrderMasterId)
        {
            PurchaseOrderMasterInfo purchaseordermasterinfo = new PurchaseOrderMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseOrderMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchaseordermasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    purchaseordermasterinfo.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    purchaseordermasterinfo.SuffixPrefixId = decimal.Parse(sdrreader["suffixPrefixId"].ToString());
                    purchaseordermasterinfo.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
                    purchaseordermasterinfo.Date = DateTime.Parse(sdrreader["date"].ToString());
                    purchaseordermasterinfo.LedgerId = decimal.Parse(sdrreader["ledgerId"].ToString());
                    purchaseordermasterinfo.DueDate = DateTime.Parse(sdrreader["dueDate"].ToString());
                    purchaseordermasterinfo.Narration = sdrreader["narration"].ToString();
                    purchaseordermasterinfo.TotalAmount = decimal.Parse(sdrreader["totalAmount"].ToString());
                    purchaseordermasterinfo.exchangeRateId = decimal.Parse(sdrreader["exchangeRateId"].ToString());
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
            return purchaseordermasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PurchaseOrderMasterId"></param>
        /// <returns></returns>
        public decimal PurchaseOrderMasterDelete(decimal PurchaseOrderMasterId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseOrderMasterId;
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
        /// Function to  get the next id for PurchaseOrderMaster table
        /// </summary>
        /// <returns></returns>
        public int PurchaseOrderMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderMasterMax", sqlcon);
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
        /// Function to  get the next id for PurchaseOrderMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string PurchaseOrderVoucherMasterMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderVoucherMasterMax", sqlcon);
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
        /// Function to  get the next id for PurchaseOrderMaster table
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
        /// Function to check the existance of purchase order number
        /// </summary>
        /// <param name="strinvoiceNo"></param>
        /// <param name="decPurchaseorderMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool PurchaseOrderNumberCheckExistence(string strinvoiceNo, decimal decPurchaseorderMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PurchaseOrderNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseorderMasterId;
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
        /// Function to find the due days of purchase order
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
        /// Function to get the exchangerateid by currencyid
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public decimal ExchangeRateIdByCurrencyId(decimal decCurrencyId)
        {
            decimal decCount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ExchangeRateIdByCurrencyId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
                Object obj = sqlcmd.ExecuteScalar();
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
            return decCount;
        }
        /// <summary>
        /// Purchase order status check wheter cancelled or not
        /// </summary>
        /// <param name="decPurchaseorderMasterId"></param>
        /// <returns></returns>
        public bool PurchaseOrderCancelCheckStatus(decimal decPurchaseorderMasterId)
        {
            string str = String.Empty;
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderCancelCheckStatus", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseorderMasterId;
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
        /// Function to print the purchase order
        /// </summary>
        /// <param name="decPurcahseOrderMasterId"></param>
        /// <returns></returns>
        public DataSet PurchaseOrderPrinting(decimal decPurcahseOrderMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurcahseOrderMasterId;
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
        /// Function to print purchase order printing
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public DataSet PurchaseOrderReportPrinting(decimal decCompanyId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@Status", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@currentDate", SqlDbType.DateTime);
                sprmparam.Value = PublicVariables._dtCurrentDate;
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
        /// Purchase order master view by ordermasterid
        /// </summary>
        /// <param name="decOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderMasterViewByOrderMasterId(decimal decOrderMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseOrderMasterViewByOrderMasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderMasterId;
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
    }
}
