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
//Summary description for CreditNoteDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class CreditNoteDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to CreditNoteDetails Table
        /// </summary>
        /// <param name="creditnotedetailsinfo"></param>
        /// <returns></returns>
        public decimal CreditNoteDetailsAdd(CreditNoteDetailsInfo creditnotedetailsinfo)
        {
            decimal decId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditNoteDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.CreditNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = creditnotedetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = creditnotedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.Extra2;
                decId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decId;
        }
        /// <summary>
        /// Function to Update values in CreditNoteDetails Table
        /// </summary>
        /// <param name="creditnotedetailsinfo"></param>
        /// <returns></returns>
        public decimal CreditNoteDetailsEdit(CreditNoteDetailsInfo creditnotedetailsinfo)
        {
            decimal decCreditNoteDetails = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditNoteDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@creditNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.CreditNoteDetailsId;
                sprmparam = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.CreditNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = creditnotedetailsinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = creditnotedetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = creditnotedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = creditnotedetailsinfo.Extra2;
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
            return decCreditNoteDetails;
        }
        /// <summary>
        /// Function to get all the values from CreditNoteDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable CreditNoteDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteDetailsViewAll", sqlcon);
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
        /// Function to get particular values from creditNoteDetails Table based on the parameter
        /// </summary>
        /// <param name="creditNoteDetailsId"></param>
        /// <returns></returns>
        public CreditNoteDetailsInfo CreditNoteDetailsView(decimal creditNoteDetailsId)
        {
            CreditNoteDetailsInfo infoCreditNoteDetails = new CreditNoteDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditNoteDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@creditNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = creditNoteDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    infoCreditNoteDetails.CreditNoteDetailsId = Convert.ToDecimal(sdrreader[0].ToString());
                    infoCreditNoteDetails.CreditNoteMasterId = Convert.ToDecimal(sdrreader[1].ToString());
                    infoCreditNoteDetails.LedgerId = Convert.ToDecimal(sdrreader[2].ToString());
                    infoCreditNoteDetails.Credit = Convert.ToDecimal(sdrreader[3].ToString());
                    infoCreditNoteDetails.Debit = Convert.ToDecimal(sdrreader[4].ToString());
                    infoCreditNoteDetails.ExchangeRateId = Convert.ToDecimal(sdrreader[5].ToString());
                    infoCreditNoteDetails.ChequeNo = sdrreader[6].ToString();
                    infoCreditNoteDetails.ChequeDate = Convert.ToDateTime(sdrreader[7].ToString());
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
            return infoCreditNoteDetails;
        }
        /// <summary>
        /// Function to get the CreditNote Details By MasterId
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public List<DataTable> CreditNoteDetailsViewByMasterId(decimal decMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CreditNoteDetailsViewByMasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal).Value = decMasterId;
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
        /// Function to delete particular details based on the parameter From Table CreditNoteDetails
        /// </summary>
        /// <param name="CreditNoteMasterId"></param>
        public void CreditNoteDetailsDelete(decimal CreditNoteMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditNoteDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@creditNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = CreditNoteMasterId;
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
        /// Function to  get the next id for CreditNoteDetails Table
        /// </summary>
        /// <returns></returns>
        public int CreditNoteDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditNoteDetailsMax", sqlcon);
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
    }
}
