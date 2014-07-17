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
///<summary>    
///Summary description for LedgerPostingSP    
///</summary>    
namespace OpenMiracle.DAL
{
    public class LedgerPostingSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to LedgerPosting Table
        /// </summary>
        /// <param name="ledgerpostinginfo"></param>
        public void LedgerPostingAdd(LedgerPostingInfo ledgerpostinginfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Credit;
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.DetailsId;
                sprmparam = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.YearId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.ChequeDate;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra2;
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
        /// Function to Update values in LedgerPosting Table
       /// </summary>
       /// <param name="ledgerpostinginfo"></param>
        public void LedgerPostingEdit(LedgerPostingInfo ledgerpostinginfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.LedgerPostingId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Credit;
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.DetailsId;
                sprmparam = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.YearId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.ChequeDate;
               
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra2;
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
        /// Function to get all the values from LedgerPosting Table
        /// </summary>
        /// <returns></returns>
        public DataTable LedgerPostingViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingViewAll", sqlcon);
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
        /// Function to get particular values from LedgerPosting table based on the parameter
        /// </summary>
        /// <param name="ledgerPostingId"></param>
        /// <returns></returns>
        public LedgerPostingInfo LedgerPostingView(decimal ledgerPostingId)
        {
            LedgerPostingInfo ledgerpostinginfo = new LedgerPostingInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
                sprmparam.Value = ledgerPostingId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    ledgerpostinginfo.LedgerPostingId = decimal.Parse(sdrreader[0].ToString());
                    ledgerpostinginfo.Date = DateTime.Parse(sdrreader[1].ToString());
                    ledgerpostinginfo.VoucherTypeId = decimal.Parse(sdrreader[2].ToString());
                    ledgerpostinginfo.VoucherNo = sdrreader[3].ToString();
                    ledgerpostinginfo.LedgerId = decimal.Parse(sdrreader[4].ToString());
                    ledgerpostinginfo.Debit = decimal.Parse(sdrreader[5].ToString());
                    ledgerpostinginfo.Credit = decimal.Parse(sdrreader[6].ToString());
                    ledgerpostinginfo.DetailsId = decimal.Parse(sdrreader[8].ToString());
                    ledgerpostinginfo.YearId = decimal.Parse(sdrreader[9].ToString());
                    ledgerpostinginfo.InvoiceNo = sdrreader[10].ToString();
                    ledgerpostinginfo.ChequeNo = sdrreader[11].ToString();
                    ledgerpostinginfo.ChequeDate = DateTime.Parse(sdrreader[12].ToString());
                    ledgerpostinginfo.ExtraDate = DateTime.Parse(sdrreader[13].ToString());
                    ledgerpostinginfo.Extra1 = sdrreader[14].ToString();
                    ledgerpostinginfo.Extra2 = sdrreader[15].ToString();
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
            return ledgerpostinginfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="LedgerPostingId"></param>
        public void LedgerPostingDelete(decimal LedgerPostingId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
                sprmparam.Value = LedgerPostingId;
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
        /// Function to  get the next id for LedgerPosting table
        /// </summary>
        /// <returns></returns>
        public int LedgerPostingGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingMax", sqlcon);
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void LedgerPostDelete(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
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
        /// Function to get ledgerpostingIds
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetLedgerPostingIds(string voucherNo, decimal voucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("GetLedgerPostingIds", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = voucherTypeId;
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
        /// Function to Update values in LedgerPosting Table by voucherNo and voucherTypeId
        /// </summary>
        /// <param name="ledgerpostinginfo"></param>
        public void LedgerPostingEditByVoucherTypeAndVoucherNo(LedgerPostingInfo ledgerpostinginfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingEditByVoucherTypeAndVoucherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.Credit;
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.DetailsId;
                sprmparam = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
                sprmparam.Value = ledgerpostinginfo.YearId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = ledgerpostinginfo.ChequeDate;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = ledgerpostinginfo.Extra2;
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
        /// get ledgerposting id by detailsId
        /// </summary>
        /// <param name="decDetailsId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal LedgerPostingIdFromDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decLedgerPostingId = 0;
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingIdFromDetailsId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = decDetailsId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sqldr = sccmd.ExecuteReader();
                while (sqldr.Read())
                {
                    decLedgerPostingId = Convert.ToDecimal(sqldr["ledgerPostingId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPSP:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return decLedgerPostingId;
        }
       /// <summary>
       /// Function to delete ledgerPosting by detailsId
       /// </summary>
       /// <param name="decDetailsId"></param>
       /// <param name="strVoucherNo"></param>
       /// <param name="decVoucherTypeId"></param>
        public void LedgerPostDeleteByDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostDeleteByDetailsId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@DetailsId", SqlDbType.Decimal);
                sprmparam.Value = decDetailsId;
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
        /// Function to get ledgerPostingId by voucherNo and voucherTypeId
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal LedgerPostingIdForTotalAmount(string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decLedgerPostingId = 0;
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingIdForTotalAmount", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sqldr = sccmd.ExecuteReader();
                while (sqldr.Read())
                {
                    decLedgerPostingId = Convert.ToDecimal(sqldr["ledgerPostingId"].ToString());
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
            return decLedgerPostingId;
        }
        
        /// <summary>
        /// Ledgerposting and partybalance delete based on parameters
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <param name="voucherNo"></param>
        /// <param name="invoiceNo"></param>
        public void LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decimal voucherTypeId, string voucherNo, string invoiceNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = invoiceNo;
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
        /// ledgerPosting edit by vouchertype and voucherNo and ledgerId
        /// </summary>
        /// <param name="infoLedgerPosting"></param>
        public void LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(LedgerPostingInfo infoLedgerPosting)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = infoLedgerPosting.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = infoLedgerPosting.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.Credit;
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.DetailsId;
                sprmparam = sccmd.Parameters.Add("@yearId", SqlDbType.Decimal);
                sprmparam.Value = infoLedgerPosting.YearId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = infoLedgerPosting.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = infoLedgerPosting.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = infoLedgerPosting.ChequeDate;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = infoLedgerPosting.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = infoLedgerPosting.Extra2;
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
        /// ledgerPosting edit by vouchertype and voucherNo and ledgerId and extra
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strAddCash"></param>
        public void LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra(decimal voucherTypeId, decimal decLedgerId, string strVoucherNo, string strAddCash)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = strAddCash;
                
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
        /// Delete ledgerposting for stock journal edit
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void DeleteLedgerPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeleteLedgerPostingForStockJournalEdit", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                cmd.ExecuteNonQuery();
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
        /// Delete ledgerposting for Forex Currency conversion
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId(string strVoucherNo, decimal decVoucherTypeId, decimal decLedgerId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                cmd.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                cmd.ExecuteNonQuery();
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
