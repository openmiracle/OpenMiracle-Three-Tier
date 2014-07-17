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
//Summary description for BudgetMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class BudgetMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to budgetMaster Table
        /// </summary>
        /// <param name="budgetmasterinfo"></param>
        /// <returns></returns>
        public decimal BudgetMasterAdd(BudgetMasterInfo budgetmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.BudgetName;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@totalDr", SqlDbType.Decimal);
                sprmparam.Value = budgetmasterinfo.TotalDr;
                sprmparam = sccmd.Parameters.Add("@totalCr", SqlDbType.Decimal);
                sprmparam.Value = budgetmasterinfo.TotalCr;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = budgetmasterinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = budgetmasterinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
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
        /// Function to Update values in BudgetMaster Table
        /// </summary>
        /// <param name="budgetmasterinfo"></param>
        public void BudgetMasterEdit(BudgetMasterInfo budgetmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = budgetmasterinfo.BudgetMasterId;
                sprmparam = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.BudgetName;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@totalDr", SqlDbType.Decimal);
                sprmparam.Value = budgetmasterinfo.TotalDr;
                sprmparam = sccmd.Parameters.Add("@totalCr", SqlDbType.Decimal);
                sprmparam.Value = budgetmasterinfo.TotalCr;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = budgetmasterinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = budgetmasterinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = budgetmasterinfo.Extra2;
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
        /// Function to get all the values from BudgetMaster Table
        /// </summary>
        /// <param name="strStartText"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> BudgetMasterViewAll(string strStartText, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetMasterViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@startText", SqlDbType.VarChar);
                sprmparam.Value = strStartText;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = strType;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
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
        /// Function to get particular values from BudgetMaster table based on the parameter
        /// </summary>
        /// <param name="budgetMasterId"></param>
        /// <returns></returns>
        public BudgetMasterInfo BudgetMasterView(decimal budgetMasterId)
        {
            BudgetMasterInfo budgetmasterinfo = new BudgetMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = budgetMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    budgetmasterinfo.BudgetMasterId = Convert.ToDecimal(sdrreader["budgetMasterId"].ToString());
                    budgetmasterinfo.BudgetName = sdrreader["budgetName"].ToString();
                    budgetmasterinfo.Type = sdrreader["type"].ToString();
                    budgetmasterinfo.TotalDr = Convert.ToDecimal(sdrreader["totalDr"].ToString());
                    budgetmasterinfo.TotalCr = Convert.ToDecimal(sdrreader["totalCr"].ToString());
                    budgetmasterinfo.FromDate = DateTime.Parse(sdrreader["fromDate"].ToString());
                    budgetmasterinfo.ToDate = DateTime.Parse(sdrreader["toDate"].ToString());
                    budgetmasterinfo.Narration = sdrreader["narration"].ToString();
                    budgetmasterinfo.Extra1 = sdrreader["extra1"].ToString();
                    budgetmasterinfo.Extra2 = sdrreader["extra2"].ToString();
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
            return budgetmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BudgetMasterId"></param>
        /// <returns></returns>
        public decimal BudgetMasterDelete(decimal BudgetMasterId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetDetailsDeleteWithMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = BudgetMasterId;
                decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to  get the next id for BudgetMaster table
        /// </summary>
        /// <returns></returns>
        public int BudgetMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetMasterMax", sqlcon);
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
        /// Budget check existance of name
        /// </summary>
        /// <param name="strBudgetName"></param>
        /// <param name="decBudgetMasterId"></param>
        /// <returns></returns>
        public bool BudgetCheckExistanceOfName(string strBudgetName, decimal decBudgetMasterId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BudgetCheckExistanceOfName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@budgetName", SqlDbType.VarChar);
                sprmparam.Value = strBudgetName;
                sprmparam = sccmd.Parameters.Add("@budgetMasterId", SqlDbType.Decimal);
                sprmparam.Value = decBudgetMasterId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
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
            return isEdit;
        }
        /// <summary>
        /// Budget search for grid fill
        /// </summary>
        /// <param name="strBudgetName"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> BudgetSearchGridFill(string strBudgetName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BudgetSearchGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@budgetName", SqlDbType.VarChar).Value = strBudgetName;
                sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BudgetViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BudgetViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
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
        /// Budget variance view by budgetId
        /// </summary>
        /// <param name="decbudgetId"></param>
        /// <returns></returns>
        public List<DataTable> BudgetVariance(decimal decbudgetId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblBudget = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("BudgetVariance", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@budgetMasterId", SqlDbType.Decimal).Value = decbudgetId;
                sqlda.Fill(dtblBudget);
                listObj.Add(dtblBudget);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
    }
}
