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
//Summary description for ReceiptDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ReceiptDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ReceiptDetails Table
        /// </summary>
        /// <param name="receiptdetailsinfo"></param>
        /// <returns></returns>
        public decimal ReceiptDetailsAdd(ReceiptDetailsInfo receiptdetailsinfo)
        {
            decimal decReceiptDetailsId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.ReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = receiptdetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.Extra2;
                decReceiptDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReceiptDetailsId;
        }
        /// <summary>
        /// Function to Update values in ReceiptDetails Table
        /// </summary>
        /// <param name="receiptdetailsinfo"></param>
        /// <returns></returns>
        public decimal ReceiptDetailsEdit(ReceiptDetailsInfo receiptdetailsinfo)
        {
            decimal decReceiptDetailsId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.ReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.ReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = receiptdetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = receiptdetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = receiptdetailsinfo.Extra2;
                decReceiptDetailsId = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReceiptDetailsId;
        }
        /// <summary>
        /// Function to get all the values from ReceiptDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable ReceiptDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ReceiptDetailsViewAll", sqlcon);
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
        /// Function to get particular values from ReceiptDetails Table based on the parameter
        /// </summary>
        /// <param name="receiptDetailsId"></param>
        /// <returns></returns>
        public ReceiptDetailsInfo ReceiptDetailsView(decimal receiptDetailsId)
        {
            ReceiptDetailsInfo receiptdetailsinfo = new ReceiptDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = receiptDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    receiptdetailsinfo.ReceiptDetailsId = decimal.Parse(sdrreader[0].ToString());
                    receiptdetailsinfo.ReceiptMasterId = decimal.Parse(sdrreader[1].ToString());
                    receiptdetailsinfo.LedgerId = decimal.Parse(sdrreader[2].ToString());
                    receiptdetailsinfo.Amount = decimal.Parse(sdrreader[3].ToString());
                    receiptdetailsinfo.ChequeNo = sdrreader[4].ToString();
                    receiptdetailsinfo.ChequeDate = DateTime.Parse(sdrreader[5].ToString());
                    receiptdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[6].ToString());
                    receiptdetailsinfo.Extra1 = sdrreader[7].ToString();
                    receiptdetailsinfo.Extra2 = sdrreader[8].ToString();
                    receiptdetailsinfo.ExchangeRateId = decimal.Parse(sdrreader[9].ToString());
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
            return receiptdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table ReceiptDetails
        /// </summary>
        /// <param name="ReceiptDetailsId"></param>
        public void ReceiptDetailsDelete(decimal ReceiptDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = ReceiptDetailsId;
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
        /// Function to  get the next id for ReceiptDetails Table
        /// </summary>
        /// <returns></returns>
        public int ReceiptDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsMax", sqlcon);
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
        /// Function to view the reciept details by the masterId
        /// </summary>
        /// <param name="decreceiptMastertId"></param>
        /// <returns></returns>
        public List< DataTable> ReceiptDetailsViewByMasterId(decimal decreceiptMastertId)
        {
            List<DataTable> listobj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReceiptDetailsViewByMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decreceiptMastertId;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sccmd;
                sqlda.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listobj;
        }
    }
}
