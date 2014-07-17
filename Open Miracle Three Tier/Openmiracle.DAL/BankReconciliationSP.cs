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
//Summary description for BankReconciliationSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class BankReconciliationSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to BankReconciliation Table
        /// </summary>
        /// <param name="bankreconciliationinfo"></param>
        public void BankReconciliationAdd(BankReconciliationInfo bankreconciliationinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BankReconciliationAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
                sprmparam.Value = bankreconciliationinfo.LedgerPostingId;
                sprmparam = sccmd.Parameters.Add("@statementDate", SqlDbType.DateTime);
                sprmparam.Value = bankreconciliationinfo.StatementDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = bankreconciliationinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = bankreconciliationinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = bankreconciliationinfo.Extra2;
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
        /// Function to Update values in BankReconciliation Table
        /// </summary>
        /// <param name="bankreconciliationinfo"></param>
        public void BankReconciliationEdit(BankReconciliationInfo bankreconciliationinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BankReconciliationEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
                sprmparam.Value = bankreconciliationinfo.ReconcileId;
                sprmparam = sccmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal);
                sprmparam.Value = bankreconciliationinfo.LedgerPostingId;
                sprmparam = sccmd.Parameters.Add("@statementDate", SqlDbType.DateTime);
                sprmparam.Value = bankreconciliationinfo.StatementDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = bankreconciliationinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = bankreconciliationinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = bankreconciliationinfo.Extra2;
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
        /// Function to get all the values from BankReconciliation Table
        /// </summary>
        /// <returns></returns>
        public DataTable BankReconciliationViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BankReconciliationViewAll", sqlcon);
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
        /// Function to get particular values from account BankReconciliation based on the parameter
        /// </summary>
        /// <param name="reconcileId"></param>
        /// <returns></returns>
        public BankReconciliationInfo BankReconciliationView(decimal reconcileId)
        {
            BankReconciliationInfo bankreconciliationinfo = new BankReconciliationInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BankReconciliationView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
                sprmparam.Value = reconcileId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    bankreconciliationinfo.ReconcileId = decimal.Parse(sdrreader[0].ToString());
                    bankreconciliationinfo.LedgerPostingId = decimal.Parse(sdrreader[1].ToString());
                    bankreconciliationinfo.StatementDate = DateTime.Parse(sdrreader[2].ToString());
                    bankreconciliationinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    bankreconciliationinfo.Extra1 = sdrreader[4].ToString();
                    bankreconciliationinfo.Extra2 = sdrreader[5].ToString();
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
            return bankreconciliationinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table BankReconciliation
        /// </summary>
        /// <param name="ReconcileId"></param>
        public void BankReconciliationDelete(decimal ReconcileId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BankReconciliationDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reconcileId", SqlDbType.Decimal);
                sprmparam.Value = ReconcileId;
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
        /// Function to  get the next id for BankReconciliation Table
        /// </summary>
        /// <returns></returns>
        public int BankReconciliationGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BankReconciliationMax", sqlcon);
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
        /// Function to BankReconciliation Fill for Reconcile
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <returns></returns>
        public List<DataTable> BankReconciliationFillReconcile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            List<DataTable> listBank = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(int));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("BankReconciliationFillreconcile", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sqlda.Fill(dtbl);
                listBank.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listBank;
        }
        /// <summary>
        /// Function to get details using BankReconciliation LedgerPosting Id
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public decimal BankReconciliationLedgerPostingId(decimal decLedgerId)
        {
            decimal decReconcileId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BankReconciliationLedgerPostingId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@ledgerPostingId", SqlDbType.Decimal).Value = decLedgerId;
                decReconcileId = decimal.Parse(sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReconcileId;
        }
        /// <summary>
        /// Function to get BankReconciliation for Unrecocile details
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <returns></returns>
        public List<DataTable> BankReconciliationUnrecocile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("Sl No", typeof(int));
                dtbl.Columns["Sl No"].AutoIncrement = true;
                dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl No"].AutoIncrementStep = 1;
                SqlDataAdapter sqlda = new SqlDataAdapter("BankReconciliationFillUnrecon", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
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
    }
}
