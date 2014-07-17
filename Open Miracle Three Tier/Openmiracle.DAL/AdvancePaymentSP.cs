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
//Summary description for AdvancePaymentSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class AdvancePaymentSP : DBConnection
    {
        public void AdvancePaymentAdd(AdvancePaymentInfo advancepaymentinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                //sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                //sprmparam.Value = advancepaymentinfo.AdvancePaymentId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.Date;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@chequenumber", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Chequenumber;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.FinancialYearId;
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
        public void AdvancePaymentEdit(AdvancePaymentInfo advancepaymentinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.AdvancePaymentId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.Date;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@chequenumber", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Chequenumber;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Narration;
                //sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                //sprmparam.Value = advancepaymentinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.FinancialYearId;
                //sccmd.ExecuteScalar();
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
        public DataTable AdvancePaymentViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentViewAll", sqlcon);
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
        public AdvancePaymentInfo AdvancePaymentView(decimal advancePaymentId)
        {
            AdvancePaymentInfo advancepaymentinfo = new AdvancePaymentInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                sprmparam.Value = advancePaymentId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    advancepaymentinfo.AdvancePaymentId = Convert.ToDecimal(sdrreader[0].ToString());
                    advancepaymentinfo.EmployeeId = Convert.ToDecimal(sdrreader[1].ToString());
                    advancepaymentinfo.LedgerId = Convert.ToDecimal(sdrreader[2].ToString());
                    advancepaymentinfo.VoucherNo = sdrreader[3].ToString();
                    advancepaymentinfo.InvoiceNo = (sdrreader[4].ToString());
                    advancepaymentinfo.Date = Convert.ToDateTime(sdrreader[5].ToString());
                    advancepaymentinfo.Amount = Convert.ToDecimal(sdrreader[6].ToString());
                    advancepaymentinfo.SalaryMonth = Convert.ToDateTime(sdrreader[7].ToString());
                    advancepaymentinfo.Chequenumber = sdrreader[8].ToString();
                    advancepaymentinfo.ChequeDate = Convert.ToDateTime(sdrreader[9].ToString());
                    advancepaymentinfo.Narration = sdrreader[10].ToString();
                    advancepaymentinfo.ExtraDate = Convert.ToDateTime(sdrreader[11].ToString());
                    advancepaymentinfo.Extra1 = sdrreader[12].ToString();
                    advancepaymentinfo.Extra2 = sdrreader[13].ToString();
                    advancepaymentinfo.SuffixPrefixId = Convert.ToDecimal(sdrreader[14].ToString());
                    advancepaymentinfo.VoucherTypeId = Convert.ToDecimal(sdrreader[15].ToString());
                    advancepaymentinfo.FinancialYearId = Convert.ToDecimal(sdrreader[16].ToString());
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
            return advancepaymentinfo;
        }
        public void AdvancePaymentDelete(decimal AdvancePaymentId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                sprmparam.Value = AdvancePaymentId;
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
        public string AdvancePaymentGetMax(decimal decVoucherTypeId)
        {
            string Max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancPaymentVoucherNoGetMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                Max = (sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return Max;
        }
        public decimal AdvancePaymentGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal Max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancPaymentVoucherNoGetMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                Max =Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return Max+1;
        }
        public List<DataTable> AdvancePaymentAddWithIdentity(AdvancePaymentInfo advancepaymentinfo, bool IsAutomatic)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AdvancePaymentAddWithIdentity", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.EmployeeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.LedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.VoucherNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.InvoiceNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.Date;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.Amount;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.SalaryMonth;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@chequenumber", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Chequenumber;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = advancepaymentinfo.ChequeDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Narration;
                //sprmparam = sqlda.SelectCommand.Parameters.Add("@extraDate", SqlDbType.DateTime);
                //sprmparam.Value = advancepaymentinfo.ExtraDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra1;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = advancepaymentinfo.Extra2;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.SuffixPrefixId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.VoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = advancepaymentinfo.FinancialYearId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@IsAutomatic", SqlDbType.Bit);
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
        public DataTable CashOrBankComboFill()
        {
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
        public List<DataTable> AdvancePaymentEmployeeComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentEmployeeComboFill", sqlcon);
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
        public DataTable AdvancePaymentSalaryMonthComboFill()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AdvancePaymentSalaryMonthComboFill", sqlcon);
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
        public decimal AdvancePaymentAmountchecking(decimal EmployeeId)
        {
            decimal decadvanceAmount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentAmountchecking", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@EmployeeId", SqlDbType.Decimal);
                sprmparam.Value = EmployeeId;
                object advanceAmount = sccmd.ExecuteScalar();
                if (advanceAmount != null)
                {
                    decadvanceAmount = Convert.ToDecimal(advanceAmount.ToString());
                }
                else
                {
                    decadvanceAmount = 0;
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
            return decadvanceAmount;
        }
        public void AdvancePaymentVoucherTypecheckReference(decimal PayHeadId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                sprmparam.Value = PayHeadId;
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
        public List<DataTable> AdvanceRegisterSearch(string strAdvanceVoucher, string strEmployeeCode, string strEmployeeName, string dtpDate,string strVouchertypeName)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AdvanceRegisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strAdvanceVoucher;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
                sqlda.SelectCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dtpDate;
                sqlda.SelectCommand.Parameters.Add("@VoucherTypeName", SqlDbType.VarChar).Value = strVouchertypeName;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        public bool AdvancePaymentCheckExistence(string voucherNo, decimal voucherTypeId, decimal advancePaymentId)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdvancePaymentCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@advancePaymentId", SqlDbType.Decimal);
                sprmparam.Value = advancePaymentId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sccmd.ExecuteNonQuery();
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isSave = true;
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
            return isSave;
        }
        public bool CheckSalaryAlreadyPaidOrNot(decimal decEmployeeId, DateTime date)
        {
            bool isPaid = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckSalaryAlreadyPaidOrNot", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.Date);
                sprmparam.Value = date;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isPaid = true;
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
            return isPaid;
        }
        public List<DataTable> VoucherTypeNameComboFillAdvanceRegister()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlDa = new SqlDataAdapter("VoucherTypeNameComboFillAdvanceRegister",sqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        public List<DataTable> AdvancePaymentViewAllForAdvancePaymentReport(DateTime dtpFromDate, DateTime dtpToDate, string strEmployeeCode, DateTime dtpSalaryMonth)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AdvancePaymentViewAllForAdvancePaymentReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtpFromDate;
                sqlda.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtpToDate;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtpSalaryMonth;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ListObj;
        }
    }
}
