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
namespace OpenMiracle.DAL  
{
    public class PaymentMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PaymentMaster Table
        /// </summary>
        /// <param name="paymentmasterinfo"></param>
        /// <returns></returns>
        public decimal PaymentMasterAdd(PaymentMasterInfo paymentmasterinfo)
        {
            decimal decPaymentMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = paymentmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra2;
                decPaymentMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decPaymentMasterId;
        }
        /// <summary>
        /// Function to Update values in PaymentMaster Table
        /// </summary>
        /// <param name="paymentmasterinfo"></param>
        /// <returns></returns>
        public decimal PaymentMasterEdit(PaymentMasterInfo paymentmasterinfo)
        {
            decimal decPaymentMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.PaymentMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = paymentmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra2;
                decPaymentMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decPaymentMasterId;
        }
        /// <summary>
        /// Function to get all the values from PaymentMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PaymentMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentMasterViewAll", sqlcon);
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
        /// Function to get particular values from PaymentMaster table based on the parameter
        /// </summary>
        /// <param name="paymentMastertId"></param>
        /// <returns></returns>
        public PaymentMasterInfo PaymentMasterView(decimal paymentMastertId)
        {
            PaymentMasterInfo paymentmasterinfo = new PaymentMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = paymentMastertId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    paymentmasterinfo.PaymentMasterId = decimal.Parse(sdrreader[0].ToString());
                    paymentmasterinfo.VoucherNo = sdrreader[1].ToString();
                    paymentmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    paymentmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    paymentmasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    paymentmasterinfo.LedgerId = decimal.Parse(sdrreader[5].ToString());
                    paymentmasterinfo.TotalAmount = decimal.Parse(sdrreader[6].ToString());
                    paymentmasterinfo.Narration = sdrreader[7].ToString();
                    paymentmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[8].ToString());
                    paymentmasterinfo.UserId = decimal.Parse(sdrreader[10].ToString());
                    paymentmasterinfo.FinancialYearId = decimal.Parse(sdrreader[11].ToString());
                    paymentmasterinfo.ExtraDate = DateTime.Parse(sdrreader[12].ToString());
                    paymentmasterinfo.Extra1 = sdrreader[13].ToString();
                    paymentmasterinfo.Extra2 = sdrreader[14].ToString();
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
            return paymentmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PaymentMastertId"></param>
        public void PaymentMasterDelete(decimal PaymentMastertId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = PaymentMastertId;
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
        /// Function to  get the next id for PaymentMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public int PaymentMasterMax(decimal decVoucherTypeId)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PaymentMastertId"></param>
        /// <returns></returns>
        public int PaymentMasterDeleteByReturnValue(decimal PaymentMastertId)
        {
            int inReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = PaymentMastertId;
                inReturnValue = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inReturnValue;
        }
        /// <summary>
        /// Function to get the payment details for register search
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decledgerId"></param>
        /// <param name="strvoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PaymentMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
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
                SqlCommand sccmd = new SqlCommand("PaymentMasterSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                sprmparam.Value = dtpFromDate;
                sprmparam = sccmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                sprmparam.Value = dtpToDate;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decledgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
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
        /// Function to get the payment details for report search
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decCashOrBankId"></param>
        /// <returns></returns>
        public List<DataTable> PaymentReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
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
                SqlCommand sccmd = new SqlCommand("PaymentReportSearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                sprmparam.Value = dtpFromDate;
                sprmparam = sccmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                sprmparam.Value = dtpToDate;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@cashOrBankId", SqlDbType.Decimal);
                sprmparam.Value = decCashOrBankId;
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
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
        /// Function to get particular values from PaymentMaster table based on the parameter
        /// </summary>
        /// <param name="paymentMastertId"></param>
        /// <returns></returns>
        public PaymentMasterInfo PaymentMasterViewByMasterId(decimal paymentMastertId)
        {
            PaymentMasterInfo paymentmasterinfo = new PaymentMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterViewByMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = paymentMastertId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    paymentmasterinfo.VoucherNo = sdrreader["voucherNo"].ToString();
                    paymentmasterinfo.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    paymentmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader["suffixprefixId"].ToString());
                    paymentmasterinfo.Date = DateTime.Parse(sdrreader["date"].ToString());
                    paymentmasterinfo.LedgerId = decimal.Parse(sdrreader["ledgerId"].ToString());
                    paymentmasterinfo.TotalAmount = decimal.Parse(sdrreader["totalAmount"].ToString());
                    paymentmasterinfo.Narration = sdrreader["narration"].ToString();
                    paymentmasterinfo.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
                    paymentmasterinfo.UserId = decimal.Parse(sdrreader["userId"].ToString());
                    paymentmasterinfo.FinancialYearId = decimal.Parse(sdrreader["financialYearId"].ToString());
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
            return paymentmasterinfo;
        }
        /// <summary>
        /// Payment voucher check existance
        /// </summary>
        /// <param name="strvoucherNo"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public bool PaymentVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        trueOrfalse = true;
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
        /// Function to count the payment master
        /// </summary>
        /// <returns></returns>
        public int PaymentMasterCount()
        {
            int inReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentMasterCount", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                inReturnValue = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inReturnValue;
        }
        /// <summary>
        /// Function to get the details for voucher printing
        /// </summary>
        /// <param name="decPaymentMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PaymentVoucherPrinting(decimal decPaymentMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPaymentMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
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
        /// Function to get the details for voucher report printing
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decCashOrBankId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PaymentReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentReportPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime);
                sprmparam.Value = dtpFromDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime);
                sprmparam.Value = dtpToDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@cashOrBankId", SqlDbType.Decimal);
                sprmparam.Value = decCashOrBankId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
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
        /// Function to get the paymentmasterId
        /// </summary>
        /// <param name="decVouchertypeid"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal paymentMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("paymentMasterIdView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeid;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                decid = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decid;
        }
        /// <summary>
        /// Function to delete Payment voucher
        /// </summary>
        /// <param name="decPaymentMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PaymentVoucherDelete(decimal decPaymentMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PaymentVoucherDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPaymentMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PMSP :5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
