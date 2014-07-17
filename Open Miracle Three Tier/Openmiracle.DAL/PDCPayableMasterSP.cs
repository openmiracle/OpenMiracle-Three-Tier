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
//Summary description for PDCPayableMasterSP    
//</summary>    
namespace OpenMiracle.DAL   
{
    public class PDCPayableMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PDCPayableMaster Table
        /// </summary>
        /// <param name="pdcpayablemasterinfo"></param>
        /// <returns></returns>
        public decimal PDCPayableMasterAdd(PDCPayableMasterInfo pdcpayablemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = pdcpayablemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = pdcpayablemasterinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.BankId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Extra2;
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
        /// Function to Update values in PDCPayableMaster Table
        /// </summary>
        /// <param name="pdcpayablemasterinfo"></param>
        public void PDCPayableMasterEdit(PDCPayableMasterInfo pdcpayablemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.PdcPayableMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = pdcpayablemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = pdcpayablemasterinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.BankId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = pdcpayablemasterinfo.FinancialYearId;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pdcpayablemasterinfo.Extra2;
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
        /// Function to get all the values from PDCPayableMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PDCPayableMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCPayableMasterViewAll", sqlcon);
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
        /// Function to get particular values from PDCPayableMaster table based on the parameter
        /// </summary>
        /// <param name="pdcPayableMasterId"></param>
        /// <returns></returns>
        public PDCPayableMasterInfo PDCPayableMasterView(decimal pdcPayableMasterId)
        {
            PDCPayableMasterInfo pdcpayablemasterinfo = new PDCPayableMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = pdcPayableMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    pdcpayablemasterinfo.PdcPayableMasterId = decimal.Parse(sdrreader[0].ToString());
                    pdcpayablemasterinfo.VoucherNo = sdrreader[1].ToString();
                    pdcpayablemasterinfo.InvoiceNo = sdrreader[2].ToString();
                    pdcpayablemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    pdcpayablemasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    pdcpayablemasterinfo.LedgerId = decimal.Parse(sdrreader[5].ToString());
                    pdcpayablemasterinfo.Amount = decimal.Parse(sdrreader[6].ToString());
                    pdcpayablemasterinfo.ChequeNo = sdrreader[7].ToString();
                    pdcpayablemasterinfo.ChequeDate = DateTime.Parse(sdrreader[8].ToString());
                    pdcpayablemasterinfo.Narration = sdrreader[9].ToString();
                    pdcpayablemasterinfo.UserId = decimal.Parse(sdrreader[10].ToString());
                    pdcpayablemasterinfo.BankId = decimal.Parse(sdrreader[11].ToString());
                    pdcpayablemasterinfo.VoucherTypeId = decimal.Parse(sdrreader[12].ToString());
                    pdcpayablemasterinfo.FinancialYearId = decimal.Parse(sdrreader[13].ToString());
                    pdcpayablemasterinfo.ExtraDate = DateTime.Parse(sdrreader[14].ToString());
                    pdcpayablemasterinfo.Extra1 = sdrreader[15].ToString();
                    pdcpayablemasterinfo.Extra2 = sdrreader[16].ToString();
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
            return pdcpayablemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter 
        /// </summary>
        /// <param name="PdcPayableMasterId"></param>
        public void PDCPayableMasterDelete(decimal PdcPayableMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = PdcPayableMasterId;
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
        /// Function to  get the next id for PDCPayableMaster table
        /// </summary>
        /// <returns></returns>
        public int PDCPayableMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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
        /// Function to view PDCPayable max id Under VoucherType Plus One
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PDCPayableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMaxUnderVoucherType", sqlcon);
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
        /// Function to fill bank combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BankAccountComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BankAccountComboFill", sqlcon);
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
        /// Function to check existance of pdcpayable 
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="pdcPayableMasterId"></param>
        /// <returns></returns>
        public bool PDCpayableCheckExistence(string voucherNo, decimal voucherTypeId, decimal pdcPayableMasterId)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCpayableCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = pdcPayableMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sccmd.ExecuteNonQuery();
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    
                    if (Convert.ToDecimal(obj.ToString()) == 0)
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
       
        /// <summary>
        /// Function to get the details for printing pdcpayable voucher printing
        /// </summary>
        /// <param name="decPDCpayableId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PDCpayableVoucherPrinting(decimal decPDCpayableId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCpayableVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPDCpayableId;
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
        /// Function to view the details for pdcpayable register search
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtTodate"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public List<DataTable> PDCpayableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlCommand sqlcmd = new SqlCommand("PDCpayableRegisterSearch", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcmd;
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
        /// Function to fill the account ledger combobox
        /// </summary>
        /// <param name="Isall"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerComboFill(bool Isall)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAll", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
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
       /// Function to check reference of pdcpayablevoucher
       /// </summary>
       /// <param name="decMasterId"></param>
       /// <param name="voucherTypeId"></param>
       /// <returns></returns>
        public bool PDCPayableVoucherCheckRreference(decimal decMasterId, decimal voucherTypeId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableVoucherCheckRreference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.VarChar);
                sprmparam.Value = decMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        
        /// <summary>
        /// Function to get ledgerposting Id by pdcpayableId
        /// </summary>
        /// <param name="pdcMasterId"></param>
        /// <returns></returns>
        public List<DataTable> LedgerPostingIdByPDCpayableId(decimal pdcMasterId)
        {
            List<DataTable> listObjpdcPayableId = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByPDCpayableId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = pdcMasterId;
                sdaadapter.Fill(dtbl);
                listObjpdcPayableId.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjpdcPayableId;
        }
        /// <summary>
        /// Function to get details for search in report
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="dtcheckfromdate"></param>
        /// <param name="dtCheckdateto"></param>
        /// <param name="strchequeNo"></param>
        /// <param name="strvoucherNo"></param>
        /// <param name="strstatus"></param>
        /// <returns></returns>
        public List<DataTable> PdcPayableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcPayableReportSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
                sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
                sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
                sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
                sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
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
        /// Function to get details for report printing
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="dtcheckfromdate"></param>
        /// <param name="dtCheckdateto"></param>
        /// <param name="strchequeNo"></param>
        /// <param name="strvoucherNo"></param>
        /// <param name="strstatus"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PdcpayableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
        {
            DataSet dst = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcpayableReportPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
                sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
                sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
                sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
                sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
                sdaadapter.Fill(dst);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dst;
        }
        /// <summary>
        /// Function to check pdcpayable reference
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <returns></returns>
        public bool PDCPayableReferenceCheck(decimal decMasterId, decimal decvoucherTypeId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pdcPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = decvoucherTypeId;
                isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PdcpayableId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PDCPayableMasterDelete(decimal PdcpayableId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCPayableMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PDCPayableMasterId", SqlDbType.Decimal);
                sprmparam.Value = PdcpayableId;
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
        /// Function to get the pdcpayablemasterid
        /// </summary>
        /// <param name="decVouchertypeid"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal PdcPayableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PdcPayableMasterIdView", sqlcon);
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
        /// Function to get the details for cheque report
        /// </summary>
        /// <param name="decParty"></param>
        /// <param name="strChequeNo"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtTodate"></param>
        /// <param name="dtChequefromDate"></param>
        /// <param name="dtChequetoDate"></param>
        /// <param name="isIssued"></param>
        /// <returns></returns>
        public List<DataTable> ChequeReportGridFill(decimal decParty, string strChequeNo, DateTime dtFromDate, DateTime dtTodate, DateTime dtChequefromDate, DateTime dtChequetoDate, bool isIssued)    //, decimal decCurrencyId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ChequeReportGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sdaadapter.SelectCommand.Parameters.Add("@chequefromDate", SqlDbType.DateTime).Value = dtChequefromDate;
                sdaadapter.SelectCommand.Parameters.Add("@chequetoDate", SqlDbType.DateTime).Value = dtChequetoDate;
                sdaadapter.SelectCommand.Parameters.Add("@issued", SqlDbType.Bit).Value = isIssued;
                sdaadapter.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar).Value = "";
                sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar).Value = decParty;
                sdaadapter.SelectCommand.Parameters.Add("@startNo", SqlDbType.VarChar).Value = strChequeNo;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get the details for cheque report party combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ChequeReportPartyComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ChequeReportPartyComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
    }
}
