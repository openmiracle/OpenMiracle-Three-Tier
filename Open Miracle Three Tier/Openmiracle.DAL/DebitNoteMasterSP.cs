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
//Summary description for DebitNoteMasterSP    
//</summary>    
namespace OpenMiracle.DAL  
{
    public class DebitNoteMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DebitNoteMaster Table
        /// </summary>
        /// <param name="debitnotemasterinfo"></param>
        /// <returns></returns>
        public decimal DebitNoteMasterAdd(DebitNoteMasterInfo debitnotemasterinfo)
        {
            decimal decDebitNoteMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = debitnotemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.VoucherTypeId;
                decDebitNoteMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decDebitNoteMasterId;
        }
        /// <summary>
        /// Function to Update values in DebitNoteMaster Table
        /// </summary>
        /// <param name="debitnotemasterinfo"></param>
        /// <returns></returns>
        public decimal DebitNoteMasterEdit(DebitNoteMasterInfo debitnotemasterinfo)
        {
            decimal decEffectRow = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.DebitNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = debitnotemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = debitnotemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = debitnotemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = debitnotemasterinfo.Extra2;
                decEffectRow = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decEffectRow;
        }
        /// <summary>
        /// Function to get all the values from DebitNoteMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable DebitNoteMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteMasterViewAll", sqlcon);
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
        /// Function to get particular values from DebitNoteMaster table based on the parameter
        /// </summary>
        /// <param name="debitNoteMasterId"></param>
        /// <returns></returns>
        public DebitNoteMasterInfo DebitNoteMasterView(decimal debitNoteMasterId)
        {
            DebitNoteMasterInfo debitnotemasterinfo = new DebitNoteMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = debitNoteMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    debitnotemasterinfo.DebitNoteMasterId = decimal.Parse(sdrreader[0].ToString());
                    debitnotemasterinfo.VoucherNo = sdrreader[1].ToString();
                    debitnotemasterinfo.InvoiceNo = sdrreader[2].ToString();
                    debitnotemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    debitnotemasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    debitnotemasterinfo.VoucherTypeId = decimal.Parse(sdrreader[5].ToString());
                    debitnotemasterinfo.UserId = decimal.Parse(sdrreader[6].ToString());
                    debitnotemasterinfo.TotalAmount = decimal.Parse(sdrreader[7].ToString());
                    debitnotemasterinfo.Narration = sdrreader[8].ToString();
                    debitnotemasterinfo.FinancialYearId = decimal.Parse(sdrreader[9].ToString());
                    debitnotemasterinfo.ExtraDate = DateTime.Parse(sdrreader[10].ToString());
                    debitnotemasterinfo.Extra1 = sdrreader[11].ToString();
                    debitnotemasterinfo.Extra2 = sdrreader[12].ToString();
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
            return debitnotemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="DebitNoteMasterId"></param>
        public void DebitNoteMasterDelete(decimal DebitNoteMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = DebitNoteMasterId;
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
        /// Function to  get the next id for DebitNoteMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public int DebitNoteMasterGetMax(decimal decVoucherTypeId)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
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
        /// Function to  get the next id for DebitNoteMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal DebitNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
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
        /// Function to check the existance of debitnote voucher
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="VoucherTypeId"></param>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public bool DebitNoteVoucherCheckExistance(string strInvoiceNo, decimal VoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteVoucherCheckExistance", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@VoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@masterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
                trueOrfalse = Convert.ToBoolean(sccmd.ExecuteScalar());
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
        /// Function to get all the values from DebitNoteMaster Table with serialNo
        /// </summary>
        /// <returns></returns>
        public List<DataTable> DebitNoteMasterViewAllWithSlNo()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteMasterViewAll", sqlcon);
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
        /// Function to search the debitnote based on the parameters
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="strFromDate"></param>
        /// <param name="strToDate"></param>
        /// <returns></returns>
        public List<DataTable> DebitNoteRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteRegisterSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strFromDate.ToString());
                sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strToDate.ToString());
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
        /// Function to search the debitnote based on the parameters for report
        /// </summary>
        /// <param name="strFromDate"></param>
        /// <param name="strToDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> DebitNoteReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteReportSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strFromDate.ToString());
                sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Convert.ToDateTime(strToDate.ToString());
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
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
        /// Function to get the details dor debitnote printing
        /// </summary>
        /// <param name="decDebitNoteMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet DebitNotePrinting(decimal decDebitNoteMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDebitNoteMasterId;
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
        /// Function to get the details dor debitnote report printing
        /// </summary>
        /// <param name="strFromDate"></param>
        /// <param name="strToDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet DebitNoteReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
        {
            DataSet dst = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteReportPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = Convert.ToDateTime(strFromDate);
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = Convert.ToDateTime(strToDate);
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sdaadapter.Fill(dst);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNM:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return dst;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decDebitNoteMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void DebitNoteVoucherDelete(decimal decDebitNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteVoucherDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDebitNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNM:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get the debitnote masterId 
        /// </summary>
        /// <param name="decVouchertypeid"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal DebitNoteMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DebitNoteMasterIdView", sqlcon);
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
    }
}
