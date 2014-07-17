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
//Summary description for SalaryVoucherMasterSP    
//</summary>    
namespace OpenMiracle.DAL    
{
   public  class SalaryVoucherMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalaryVoucherMaster Table
        /// </summary>
        /// <param name="salaryvouchermasterinfo"></param>
        public void SalaryVoucherMasterAdd(SalaryVoucherMasterInfo salaryvouchermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.SalaryVoucherMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Month;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.FinancialYearId;
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
        /// Function to Update values in SalaryVoucherMaster Table
        /// </summary>
        /// <param name="salaryvouchermasterinfo"></param>
        public void SalaryVoucherMasterEdit(SalaryVoucherMasterInfo salaryvouchermasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.SalaryVoucherMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Month;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.FinancialYearId;
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
        /// Function to get all the values from SalaryVoucherMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalaryVoucherMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryVoucherMasterViewAll", sqlcon);
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
        /// Function to get particular values from SalaryVoucherMaster Table based on the parameter
        /// </summary>
        /// <param name="salaryVoucherMasterId"></param>
        /// <returns></returns>
        public SalaryVoucherMasterInfo SalaryVoucherMasterView(decimal salaryVoucherMasterId)
        {
            SalaryVoucherMasterInfo salaryvouchermasterinfo = new SalaryVoucherMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryVoucherMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salaryvouchermasterinfo.SalaryVoucherMasterId = decimal.Parse(sdrreader[0].ToString());
                    salaryvouchermasterinfo.LedgerId = decimal.Parse(sdrreader[1].ToString());
                    salaryvouchermasterinfo.VoucherNo = sdrreader[2].ToString();
                    salaryvouchermasterinfo.InvoiceNo = sdrreader[3].ToString();
                    salaryvouchermasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    salaryvouchermasterinfo.Month = DateTime.Parse(sdrreader[5].ToString());
                    salaryvouchermasterinfo.TotalAmount = decimal.Parse(sdrreader[6].ToString());
                    salaryvouchermasterinfo.Narration = sdrreader[7].ToString();
                    salaryvouchermasterinfo.ExtraDate = DateTime.Parse(sdrreader[8].ToString());
                    salaryvouchermasterinfo.Extra1 = sdrreader[9].ToString();
                    salaryvouchermasterinfo.Extra2 = sdrreader[10].ToString();
                    salaryvouchermasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[11].ToString());
                    salaryvouchermasterinfo.VoucherTypeId = decimal.Parse(sdrreader[12].ToString());
                    salaryvouchermasterinfo.FinancialYearId = decimal.Parse(sdrreader[13].ToString());
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
            return salaryvouchermasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table SalaryVoucherMaster
        /// </summary>
        /// <param name="SalaryVoucherMasterId"></param>
        public void SalaryVoucherMasterDelete(decimal SalaryVoucherMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalaryVoucherMasterId;
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
        /// Function to  get the next id for SalaryVoucherMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string SalaryVoucherMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterMax", sqlcon);
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
        /// Function to  get the next id for SalaryVoucherMaster Table
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
                SqlCommand sccmd = new SqlCommand("SalaryVoucherMasterMax", sqlcon);
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
            return max + 1;
        }
        /// <summary>
        /// Function to insert values to MonthlySalaryVoucherMaster Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="salaryvouchermasterinfo"></param>
        /// <param name="IsAutomatic"></param>
        /// <returns></returns>
        public List<DataTable> MonthlySalaryVoucherMasterAddWithIdentity(SalaryVoucherMasterInfo salaryvouchermasterinfo, bool IsAutomatic)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalaryVoucherMasterAddWithIdentity", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.LedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.VoucherNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.InvoiceNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Date;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = salaryvouchermasterinfo.Month;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.TotalAmount;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Narration;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra1;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvouchermasterinfo.Extra2;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.SuffixPrefixId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.VoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = salaryvouchermasterinfo.FinancialYearId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@isAutomatic", SqlDbType.Bit);
                sprmparam.Value = IsAutomatic;
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
        /// Function to Check Existence of MonthlySalary Voucher 
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="masterId"></param>
        /// <returns></returns>
        public bool MonthlySalaryVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = masterId;
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
        /// Function to search the Monthly Salary Register based on the condition
        /// </summary>
        /// <param name="dtdateFrom"></param>
        /// <param name="dtdateTo"></param>
        /// <param name="dtMonth"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strVoucherTypeName"></param>
        /// <returns></returns>
        public List<DataTable> MonthlySalaryRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, DateTime dtMonth, string strVoucherNo, string strLedgerName, string strVoucherTypeName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(decimal));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalaryRegisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
                sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
                sqlda.SelectCommand.Parameters.Add("@VoucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
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
        /// Function to PaySlip Printing
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="dsSalaryMonth"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PaySlipPrinting(decimal decEmployeeId, DateTime dsSalaryMonth, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PaySlipPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = dsSalaryMonth;
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
    }
}
