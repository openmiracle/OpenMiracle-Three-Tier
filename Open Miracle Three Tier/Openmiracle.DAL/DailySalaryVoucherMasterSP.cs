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
//Summary description for DailySalaryVoucherMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class DailySalaryVoucherMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DailySalaryVoucherMaster Table
        /// </summary>
        /// <param name="dailysalaryvouchermasterinfo"></param>
        public void DailySalaryVoucherMasterAdd(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNumber", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNumber", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.SalaryDate;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.FinancialYearId;
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
        /// Function to Update values in DailySalaryVoucherMaster Table
        /// </summary>
        /// <param name="dailysalaryvouchermasterinfo"></param>
        public void DailySalaryVoucherMasterEdit(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.SalaryDate;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.FinancialYearId;
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
        /// Function to get all the values from DailySalaryVoucherMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable DailySalaryVoucherMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherMasterViewAll", sqlcon);
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
        /// Function to get particular values from DailySalaryVoucherMaster Table based on the parameter
        /// </summary>
        /// <param name="dailySalaryVoucehrMasterId"></param>
        /// <returns></returns>
        public DailySalaryVoucherMasterInfo DailySalaryVoucherMasterView(decimal dailySalaryVoucehrMasterId)
        {
            DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo = new DailySalaryVoucherMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailySalaryVoucehrMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    dailysalaryvouchermasterinfo.DailySalaryVoucehrMasterId = decimal.Parse(sdrreader[0].ToString());
                    dailysalaryvouchermasterinfo.LedgerId = decimal.Parse(sdrreader[1].ToString());
                    dailysalaryvouchermasterinfo.VoucherNo = sdrreader[2].ToString();
                    dailysalaryvouchermasterinfo.InvoiceNo = sdrreader[3].ToString();
                    dailysalaryvouchermasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    dailysalaryvouchermasterinfo.SalaryDate = DateTime.Parse(sdrreader[5].ToString());
                    dailysalaryvouchermasterinfo.TotalAmount = decimal.Parse(sdrreader[6].ToString());
                    dailysalaryvouchermasterinfo.Narration = sdrreader[7].ToString();
                    dailysalaryvouchermasterinfo.ExtraDate = DateTime.Parse(sdrreader[8].ToString());
                    dailysalaryvouchermasterinfo.Extra1 = sdrreader[9].ToString();
                    dailysalaryvouchermasterinfo.Extra2 = sdrreader[10].ToString();
                    dailysalaryvouchermasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[11].ToString());
                    dailysalaryvouchermasterinfo.VoucherTypeId = decimal.Parse(sdrreader[12].ToString());
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
            return dailysalaryvouchermasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table DailySalaryVoucherMaster
        /// </summary>
        /// <param name="DailySalaryVoucehrMasterId"></param>
        public void DailySalaryVoucherMasterDelete(decimal DailySalaryVoucehrMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = DailySalaryVoucehrMasterId;
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
        /// Function to  get the next id for DailySalaryVoucherMaster Table
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public string DailySalaryVoucherMasterGetMax(decimal voucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
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
        /// Function to  get the next id for DailySalaryVoucherMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherMasterMax", sqlcon);
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
        /// Function to insert values to DailySalaryVoucherMaster Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="dailysalaryvouchermasterinfo"></param>
        /// <param name="IsAutomatic"></param>
        /// <returns></returns>
        public List<DataTable> DailySalaryVoucherMasterAddWithIdentity(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo, bool IsAutomatic)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter("DailySalaryVoucherMasterAddWithIdentity", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.LedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.InvoiceNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.Date;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salaryDate", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvouchermasterinfo.SalaryDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.TotalAmount;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Narration;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra1;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvouchermasterinfo.Extra2;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@isAutomatic", SqlDbType.Bit);
                sprmparam.Value = IsAutomatic;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvouchermasterinfo.FinancialYearId;
                sqlda.Fill(dtbl);
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
        /// Function to DailySalaryVoucher Cash Or Bank Account Ledgers ComboFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> DailySalaryVoucherCashOrBankLedgersComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Function to Daily Salary Register Search
        /// </summary>
        /// <param name="dtVoucherDateFrom"></param>
        /// <param name="dtVoucherDateTo"></param>
        /// <param name="dtSalaryDateFrom"></param>
        /// <param name="dtSalaryDateTo"></param>
        /// <param name="strInvoiceNo"></param>
        /// <returns></returns>
        public List<DataTable> DailySalaryRegisterSearch(DateTime dtVoucherDateFrom, DateTime dtVoucherDateTo, DateTime dtSalaryDateFrom, DateTime dtSalaryDateTo, string strInvoiceNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter("DailySalaryRegisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(decimal));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@voucherDateFrom", SqlDbType.DateTime).Value = dtVoucherDateFrom;
                sqlda.SelectCommand.Parameters.Add("@voucherDateTo", SqlDbType.DateTime).Value = dtVoucherDateTo;
                sqlda.SelectCommand.Parameters.Add("@salaryDateFrom", SqlDbType.DateTime).Value = dtSalaryDateFrom;
                sqlda.SelectCommand.Parameters.Add("@salaryDateTo", SqlDbType.DateTime).Value = dtSalaryDateTo;
                sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = strInvoiceNo;
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
        /// Function to Daily Salary Voucher View From Register
        /// </summary>
        /// <param name="decDailySalaryVoucehrMasterId"></param>
        /// <returns></returns>
        public DailySalaryVoucherMasterInfo DailySalaryVoucherViewFromRegister(decimal decDailySalaryVoucehrMasterId)
        {
            DailySalaryVoucherMasterInfo infoDailySalaryVoucherMaster = new DailySalaryVoucherMasterInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DailySalaryVoucherViewFromRegister", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal).Value = decDailySalaryVoucehrMasterId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoDailySalaryVoucherMaster.Date = Convert.ToDateTime(sqldr["date"].ToString());
                    infoDailySalaryVoucherMaster.VoucherNo = sqldr["voucherNo"].ToString();
                    infoDailySalaryVoucherMaster.InvoiceNo = sqldr["invoiceNo"].ToString();
                    infoDailySalaryVoucherMaster.SalaryDate = Convert.ToDateTime(sqldr["salaryDate"].ToString());
                    infoDailySalaryVoucherMaster.LedgerId = Convert.ToDecimal(sqldr["ledgerId"].ToString());
                    infoDailySalaryVoucherMaster.TotalAmount = Convert.ToDecimal(sqldr["totalAmount"].ToString());
                    infoDailySalaryVoucherMaster.Narration = sqldr["narration"].ToString();
                    infoDailySalaryVoucherMaster.VoucherTypeId = Convert.ToDecimal(sqldr["voucherTypeId"].ToString());
                    infoDailySalaryVoucherMaster.SuffixPrefixId = Convert.ToDecimal(sqldr["suffixPrefixId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return infoDailySalaryVoucherMaster;
        }
        /// <summary>
        /// Function to Daily Salary Voucher Check Existence
        /// </summary>
        /// <param name="voucherNumber"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="masterId"></param>
        /// <returns></returns>
        public bool DailySalaryVoucherCheckExistence(string voucherNumber, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNumber;
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = masterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
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
    }
}
