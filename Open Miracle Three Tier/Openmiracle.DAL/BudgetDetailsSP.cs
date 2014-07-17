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
//Summary description for BudgetDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class BudgetDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to BudgetDetails Table
        /// </summary>
        /// <param name="budgetdetailsinfo"></param>
        public void BudgetDetailsAdd(BudgetDetailsInfo budgetdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.BudgetMasterId;
                sprmparam = sccmd.Parameters.Add("@particular", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Particular;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Extra2;
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
        /// Function to Update values in BudgetDetails Table
        /// </summary>
        /// <param name="budgetdetailsinfo"></param>
        public void BudgetDetailsEdit(BudgetDetailsInfo budgetdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.BudgetDetailsId;
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.BudgetMasterId;
                sprmparam = sccmd.Parameters.Add("@particular", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Particular;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = budgetdetailsinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = budgetdetailsinfo.Extra2;
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
        /// Function to get all the values from BudgetDetails Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BudgetDetailsViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetDetailsViewAll", sqlcon);
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
        /// Function to get particular values from BudgetDetails table based on the parameter
        /// </summary>
        /// <param name="budgetDetailsId"></param>
        /// <returns></returns>
        public BudgetDetailsInfo BudgetDetailsView(decimal budgetDetailsId)
        {
            BudgetDetailsInfo budgetdetailsinfo = new BudgetDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
                sprmparam.Value = budgetDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    budgetdetailsinfo.BudgetDetailsId = decimal.Parse(sdrreader[0].ToString());
                    budgetdetailsinfo.BudgetMasterId = decimal.Parse(sdrreader[1].ToString());
                    budgetdetailsinfo.Particular = sdrreader[2].ToString();
                    budgetdetailsinfo.Credit = decimal.Parse(sdrreader[3].ToString());
                    budgetdetailsinfo.Debit = decimal.Parse(sdrreader[4].ToString());
                    budgetdetailsinfo.Extra1 = sdrreader[5].ToString();
                    budgetdetailsinfo.Extra2 = sdrreader[6].ToString();
                    budgetdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
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
            return budgetdetailsinfo;
        }
        /// <summary>
        /// Function to get particular values from BudgetDetails table based on the parameter
        /// </summary>
        /// <param name="decBudgetMasterId"></param>
        /// <returns></returns>
        public List<DataTable> BudgetDetailsViewByMasterId(decimal decBudgetMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("BudgetDetailsViewByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal).Value = decBudgetMasterId;
                sdaadapter.SelectCommand = sqlcmd;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BudgetDetailsId"></param>
        public void BudgetDetailsDelete(decimal BudgetDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetDetailsId", SqlDbType.Decimal);
                sprmparam.Value = BudgetDetailsId;
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
        /// Function to  get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int BudgetDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsMax", sqlcon);
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
