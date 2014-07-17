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
using System.Collections;
using ENTITY;
//<summary>    
//Summary description for PartyBalanceSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PartyBalanceSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PartyBalance Table
        /// </summary>
        /// <param name="partybalanceinfo"></param>
        public void PartyBalanceAdd(PartyBalanceInfo partybalanceinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = partybalanceinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.AgainstVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.AgainstVoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.AgainstInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.ReferenceType;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = partybalanceinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.Extra2;
                int inEffect = sccmd.ExecuteNonQuery();
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
        /// Function to Update values in PartyBalance Table
        /// </summary>
        /// <param name="partybalanceinfo"></param>
        public void PartyBalanceEdit(PartyBalanceInfo partybalanceinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.PartyBalanceId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = partybalanceinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.AgainstVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.AgainstVoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.AgainstInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.ReferenceType;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = partybalanceinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = partybalanceinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = partybalanceinfo.Extra2;
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
        /// Function to get all the values from PartyBalance Table
        /// </summary>
        /// <returns></returns>
        public DataTable PartyBalanceViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PartyBalanceViewAll", sqlcon);
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
        /// Function to get particular values from PartyBalance table based on the parameter
        /// </summary>
        /// <param name="partyBalanceId"></param>
        /// <returns></returns>
        public PartyBalanceInfo PartyBalanceView(decimal partyBalanceId)
        {
            PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
                sprmparam.Value = partyBalanceId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    partybalanceinfo.PartyBalanceId = decimal.Parse(sdrreader[0].ToString());
                    partybalanceinfo.Date = DateTime.Parse(sdrreader[1].ToString());
                    partybalanceinfo.LedgerId = decimal.Parse(sdrreader[2].ToString());
                    partybalanceinfo.VoucherTypeId = decimal.Parse(sdrreader[3].ToString());
                    partybalanceinfo.VoucherNo = sdrreader[4].ToString();
                    partybalanceinfo.AgainstVoucherTypeId = decimal.Parse(sdrreader[5].ToString());
                    partybalanceinfo.AgainstVoucherNo = sdrreader[6].ToString();
                    partybalanceinfo.InvoiceNo = sdrreader[7].ToString();
                    partybalanceinfo.AgainstInvoiceNo = sdrreader[8].ToString();
                    partybalanceinfo.ReferenceType = sdrreader[9].ToString();
                    partybalanceinfo.Debit = decimal.Parse(sdrreader[10].ToString());
                    partybalanceinfo.Credit = decimal.Parse(sdrreader[11].ToString());
                    partybalanceinfo.CreditPeriod = int.Parse(sdrreader[12].ToString());
                    partybalanceinfo.ExchangeRateId = decimal.Parse(sdrreader[13].ToString());
                    partybalanceinfo.FinancialYearId = decimal.Parse(sdrreader[14].ToString());
                    partybalanceinfo.ExtraDate = DateTime.Parse(sdrreader[15].ToString());
                    partybalanceinfo.Extra1 = sdrreader[16].ToString();
                    partybalanceinfo.Extra2 = sdrreader[17].ToString();
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
            return partybalanceinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PartyBalanceId"></param>
        public void PartyBalanceDelete(decimal PartyBalanceId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@partyBalanceId", SqlDbType.Decimal);
                sprmparam.Value = PartyBalanceId;
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
        /// Function to  get the next id for PartyBalance table
        /// </summary>
        /// <returns></returns>
        public int PartyBalanceGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceMax", sqlcon);
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
        /// Function to fill Party balance vouchertype combobox
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="strCrDr"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PartyBalanceComboViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceComboViewByLedgerId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = strCrDr;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
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
        /// Function to get particular values from PartyBalance table based on vouchertype and voucherno
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PartyBalanceViewByVoucherNoAndVoucherType(decimal decVoucherTypeId, string strVoucherNo, DateTime dtDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceViewByVoucherNoAndVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dtDate;
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
        /// Function to delete particular details based on vouchertype and voucherno
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public int PartyBalanceDeleteByVoucherTypeAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
        {
            int inEffect = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceDeleteByVoucherTypeAndVoucherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                inEffect = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inEffect;
        }
        /// <summary>
        /// Function to fill againstbill details by ledgerId
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="strCrDr"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decVoucherTypeNameId"></param>
        /// <returns></returns>
        public List<DataTable> AgainstBillDetailsGridViewByLedgerId(decimal decLedgerId, string strCrDr, decimal decVoucherTypeId, decimal decVoucherTypeNameId)
        {
            PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
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
                SqlCommand sccmd = new SqlCommand("AgainstBillDetailsGridViewByLedgerId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = strCrDr;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeNameId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeNameId;
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
        /// Function to get particular values from PartyBalance table based on vouchertype and voucherno
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public PartyBalanceInfo PartyBalanceViewByVoucherNoAndVoucherTypeId(decimal decVoucherTypeId, string strVoucherNo,DateTime dtDate)
        {
            PartyBalanceInfo partybalanceinfo = new PartyBalanceInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceViewByVoucherNoAndVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dtDate;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    partybalanceinfo.PartyBalanceId = decimal.Parse(sdrreader[0].ToString());
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
            return partybalanceinfo;
        }
       
       
        
        /// <summary>
        /// Party balance reference check
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public bool PartyBalanceCheckReference(decimal decVoucherTypeId, string strVoucherNo)
        {
            bool isReferenceExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceCheckReference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                isReferenceExist = Convert.ToBoolean(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBSP:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isReferenceExist;
        }
        
       /// <summary>
       /// Function for billallocation search from partybalance table
       /// </summary>
       /// <param name="dtfromdate"></param>
       /// <param name="dttodate"></param>
       /// <param name="straccountgroup"></param>
       /// <param name="strledgername"></param>
       /// <returns></returns>
        public List<DataTable> BillAllocationSearch(DateTime dtfromdate, DateTime dttodate, string straccountgroup, string strledgername)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
              try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("BillAllocationSearch", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtfromdate;
            sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dttodate;
            sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroup;
            sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
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
        /// Function to view all party's balance for outstanding report
        /// </summary>
        /// <param name="decledgerId"></param>
        /// <param name="strAccountGroup"></param>
        /// <param name="dtfromdate"></param>
        /// <param name="dttodate"></param>
        /// <returns></returns>
        public DataSet OutstandingViewAll(decimal decledgerId, string strAccountGroup,DateTime dtfromdate,DateTime dttodate)
        {
            DataSet dtbl = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("OutstandingViewAll", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decledgerId;
                sprmparam = sccmd.Parameters.Add("@AccountGroup", SqlDbType.VarChar);
                sprmparam.Value = strAccountGroup;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtfromdate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dttodate;        
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                sdaadapter.SelectCommand = sccmd;
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
        /// Function to view all party's balance for outstanding report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> OutstandingPartyView()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("OutstandingPartyFillView", sqlcon);
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
        /// Funtion to view details for outstanding report print
        /// </summary>
        /// <param name="decledgerId"></param>
        /// <param name="strAccountGroup"></param>
        /// <param name="dtfromdate"></param>
        /// <param name="dttodate"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet OutstandingPrint(decimal decledgerId, string strAccountGroup,DateTime dtfromdate,DateTime dttodate, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("OutstandingPrint", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtfromdate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dttodate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = decledgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.VarChar);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@AccountGroup", SqlDbType.VarChar);
                sprmparam.Value = strAccountGroup;
              
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
        /// Function to get accountledger by debtor or creditor with balance
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerGetByDebtorAndCreditorWithBalance()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerGetByDebtorAndCreditorWithBalance", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter prm = new SqlParameter();
                sdaadapter.Fill(dtblAccountLedger);
                listObj.Add(dtblAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        
        
        /// <summary>
        /// Function to edit partybalance based on VoucherNo, VoucherTypeId And ReferenceType
        /// </summary>
        /// <param name="infoPartyBalance"></param>
        public void PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType(PartyBalanceInfo infoPartyBalance)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = infoPartyBalance.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.LedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.AgainstVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.AgainstVoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.AgainstInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.ReferenceType;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.Credit;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = infoPartyBalance.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = infoPartyBalance.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = infoPartyBalance.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = infoPartyBalance.Extra2;
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
        /// Function to view the partybalance amount by VoucherNo, VoucherTypeId And ReferenceType
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strReferenceType"></param>
        /// <returns></returns>
        public decimal PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
        {
            decimal decAmount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceAmountViewByVoucherNoVoucherTypeIdAndReferenceType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
                sprmparam.Value = strReferenceType;
                decAmount = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decAmount;
        }
        /// <summary>
        /// Function to check the partybalance amount for edit
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strDrOrCr"></param>
        /// <returns></returns>
        public decimal PartyBalanceAmountCheckForEdit(decimal decLedgerId, decimal decVoucherTypeId, string strVoucherNo, string strDrOrCr)
        {
            decimal decAmountToCheck = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceAmountCheckForEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@CrorDr", SqlDbType.VarChar);
                sprmparam.Value = strDrOrCr;
                decAmountToCheck = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decAmountToCheck;
        }
        /// <summary>
        /// Function to view the details for ageing report voucher payable 
        /// </summary>
        /// <param name="ageingDate"></param>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public List<DataTable> AgeingReportVoucherPayable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter();
                sqldataadapter = new SqlDataAdapter("AgeingReportVoucherPayable", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
                sqlparameter.Value = ageingDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decledgerId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRSP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view the details for ageing report voucher receivable
        /// </summary>
        /// <param name="ageingDate"></param>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public List<DataTable> AgeingReportVoucherReceivable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter();
                sqldataadapter = new SqlDataAdapter("AgeingReportVoucherReceivable", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
                sqlparameter.Value = ageingDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decledgerId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRSP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view the details for ageing report ledger payable
        /// </summary>
        /// <param name="ageingDate"></param>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public List<DataTable> AgeingReportLedgerPayable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter();
                sqldataadapter = new SqlDataAdapter("AgeingReportLedgerPayable", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
                sqlparameter.Value = ageingDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decledgerId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRSP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view the details for ageing report ledger receivable
        /// </summary>
        /// <param name="ageingDate"></param>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public List<DataTable> AgeingReportLedgerReceivable(DateTime ageingDate, decimal decledgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter();
                sqldataadapter = new SqlDataAdapter("AgeingReportLedgerReceivable", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ageingDate", SqlDbType.DateTime);
                sqlparameter.Value = ageingDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decledgerId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRSP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        public decimal PartyBalanceAmountViewForSalesInvoice(string strVoucherNo, decimal decVoucherTypeId, string strReferenceType)
        {
            decimal decAmount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceAmountViewForSalesInvoice", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@referenceType", SqlDbType.VarChar);
                sprmparam.Value = strReferenceType;
                decAmount = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decAmount;
        }
    }
}
