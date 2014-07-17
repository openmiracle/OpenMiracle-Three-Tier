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
//Summary description for ReceiptMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ReceiptMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ReceiptMaster Table
        /// </summary>
        /// <param name="receiptmasterinfo"></param>
        /// <returns></returns>
        public decimal ReceiptMasterAdd(ReceiptMasterInfo receiptmasterinfo)
        {
            decimal decRecieptMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = receiptmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Extra2;
                decRecieptMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decRecieptMasterId;
        }
        /// <summary>
        /// Function to Update values in ReceiptMaster Table
        /// </summary>
        /// <param name="receiptmasterinfo"></param>
        /// <returns></returns>
        public decimal ReceiptMasterEdit(ReceiptMasterInfo receiptmasterinfo)
        {
            decimal decRecieptMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.ReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = receiptmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = receiptmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = receiptmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = receiptmasterinfo.Extra2;
                decRecieptMasterId = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decRecieptMasterId;
        }
        /// <summary>
        /// Function to get all the values from ReceiptMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable ReceiptMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptMasterViewAll", sqlcon);
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
        /// Function to get particular values from ReceiptMaster table based on the parameter
        /// </summary>
        /// <param name="receiptMasterId"></param>
        /// <returns></returns>
        public ReceiptMasterInfo ReceiptMasterView(decimal receiptMasterId)
        {
            ReceiptMasterInfo receiptmasterinfo = new ReceiptMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = receiptMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    receiptmasterinfo.ReceiptMasterId = decimal.Parse(sdrreader[0].ToString());
                    receiptmasterinfo.VoucherNo = sdrreader[1].ToString();
                    receiptmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    receiptmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    receiptmasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    receiptmasterinfo.LedgerId = decimal.Parse(sdrreader[5].ToString());
                    receiptmasterinfo.TotalAmount = decimal.Parse(sdrreader[6].ToString());
                    receiptmasterinfo.Narration = sdrreader[7].ToString();
                    receiptmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[8].ToString());
                    receiptmasterinfo.UserId = decimal.Parse(sdrreader[9].ToString());
                    receiptmasterinfo.FinancialYearId = decimal.Parse(sdrreader[10].ToString());
                    receiptmasterinfo.ExtraDate = DateTime.Parse(sdrreader[11].ToString());
                    receiptmasterinfo.Extra1 = sdrreader[12].ToString();
                    receiptmasterinfo.Extra2 = sdrreader[13].ToString();
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
            return receiptmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ReceiptMasterId"></param>
        public void ReceiptMasterDelete(decimal ReceiptMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = ReceiptMasterId;
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
        /// Function to  get the next id for ReceiptMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal ReceiptMasterGetMax(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RecieptMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                decMax = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decMax;
        }
        /// <summary>
        /// Function to get details based on the parameter
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decledgerId"></param>
        /// <param name="strvoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> ReceiptMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
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
                SqlCommand sccmd = new SqlCommand("ReceiptMasterSearch", sqlcon);
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
        /// Function to get particular values from eceiptMaster table based on the parameter
        /// </summary>
        /// <param name="decReceiptMastertId"></param>
        /// <returns></returns>
        public ReceiptMasterInfo ReceiptMasterViewByMasterId(decimal decReceiptMastertId)
        {
            ReceiptMasterInfo InfoReceiptMaster = new ReceiptMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterViewByMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decReceiptMastertId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    InfoReceiptMaster.VoucherNo = sdrreader["voucherNo"].ToString();
                    InfoReceiptMaster.InvoiceNo = sdrreader["invoiceNo"].ToString();
                    InfoReceiptMaster.SuffixPrefixId = decimal.Parse(sdrreader["suffixprefixId"].ToString());
                    InfoReceiptMaster.Date = DateTime.Parse(sdrreader["date"].ToString());
                    InfoReceiptMaster.LedgerId = decimal.Parse(sdrreader["ledgerId"].ToString());
                    InfoReceiptMaster.TotalAmount = decimal.Parse(sdrreader["totalAmount"].ToString());
                    InfoReceiptMaster.Narration = sdrreader["narration"].ToString();
                    InfoReceiptMaster.VoucherTypeId = decimal.Parse(sdrreader["voucherTypeId"].ToString());
                    InfoReceiptMaster.UserId = decimal.Parse(sdrreader["userId"].ToString());
                    InfoReceiptMaster.FinancialYearId = decimal.Parse(sdrreader["financialYearId"].ToString());
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
            return InfoReceiptMaster;
        }
        /// <summary>
        /// Function to get details based on the parameter
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decCashOrBankId"></param>
        /// <returns></returns>
        public List<DataTable> ReceiptReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
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
                SqlCommand sccmd = new SqlCommand("ReceiptReportSearch", sqlcon);
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
        /// Function to check existance of receipt voucher
        /// </summary>
        /// <param name="strvoucherNo"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public bool ReceiptVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
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
        /// Function to get details for printing
        /// </summary>
        /// <param name="decPaymentMasterId"></param>
        /// <returns></returns>
        public DataSet ReceiptVoucherPrinting(decimal decPaymentMasterId)/* decimal decCompanyId*/
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPaymentMasterId;
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
        /// Function to get details for receipt report printing
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decCashOrBankId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet ReceiptReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptReportPrinting", sqlcon);
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
        /// Function to get the masterid 
        /// </summary>
        /// <param name="decVouchertypeid"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal ReceiptMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptMasterIdView", sqlcon);
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decReceiptMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void ReceiptVoucherDelete(decimal decReceiptMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptVoucherDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RMSP :5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
