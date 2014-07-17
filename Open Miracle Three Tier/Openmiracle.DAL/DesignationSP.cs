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
//Summary description for DesignationSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class DesignationSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Designation Table
        /// </summary>
        /// <param name="designationinfo"></param>
        /// <returns></returns>
        public bool DesignationAdd(DesignationInfo designationinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationAddIfNotExistsDesignation", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.DesignationName;
                sprmparam = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.LeaveDays;
                sprmparam = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.AdvanceAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra2;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in Designation Table
        /// </summary>
        /// <param name="designationinfo"></param>
        /// <returns></returns>
        public bool DesignationEdit(DesignationInfo designationinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.DesignationName;
                sprmparam = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.LeaveDays;
                sprmparam = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.AdvanceAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = designationinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra2;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get all the values from Designation Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> DesignationViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DataTable dtbl = new DataTable();
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationViewAll", sqlcon);
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
        /// Function to view designations for GridFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> DesignationViewForGridFill()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            dtbl.Columns.Add("slNo", typeof(int));
            dtbl.Columns["slNo"].AutoIncrement = true;
            dtbl.Columns["slNo"].AutoIncrementSeed = 1;
            dtbl.Columns["slNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationGridFill", sqlcon);
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
        /// Function to get particular values from Designation Table based on the parameter
        /// </summary>
        /// <param name="designationId"></param>
        /// <returns></returns>
        public DesignationInfo DesignationView(decimal designationId)
        {
            DesignationInfo designationinfo = new DesignationInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = designationId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    designationinfo.DesignationId = decimal.Parse(sdrreader[0].ToString());
                    designationinfo.DesignationName = sdrreader[1].ToString();
                    designationinfo.LeaveDays = decimal.Parse(sdrreader[2].ToString());
                    designationinfo.AdvanceAmount = decimal.Parse(sdrreader[3].ToString());
                    designationinfo.Narration = sdrreader[4].ToString();
                    designationinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    designationinfo.Extra1 = sdrreader[6].ToString();
                    designationinfo.Extra2 = sdrreader[7].ToString();
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
            return designationinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="DesignationId"></param>
        /// <returns></returns>
        public bool DesignationDelete(decimal DesignationId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = DesignationId;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to  get the next id for Designation Table
        /// </summary>
        /// <returns></returns>
        public int DesignationGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationMax", sqlcon);
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
        /// Function to view for search based on parameter
        /// </summary>
        /// <param name="strDesignation"></param>
        /// <returns></returns>
        public List<DataTable> DesignationSearch(string strDesignation)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("slNo", typeof(int));
            dtbl.Columns["slNo"].AutoIncrement = true;
            dtbl.Columns["slNo"].AutoIncrementSeed = 1;
            dtbl.Columns["slNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DesignationSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation + "%";
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
        /// Function to insert values and return id
        /// </summary>
        /// <param name="designationinfo"></param>
        /// <returns></returns>
        public decimal DesignationAddWithReturnIdentity(DesignationInfo designationinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.DesignationName;
                sprmparam = sccmd.Parameters.Add("@leaveDays", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.LeaveDays;
                sprmparam = sccmd.Parameters.Add("@advanceAmount", SqlDbType.Decimal);
                sprmparam.Value = designationinfo.AdvanceAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = designationinfo.Extra2;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decIdentity = Convert.ToDecimal(obj.ToString());
                }
                return decIdentity;
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
        /// Function to check existence based on parameters
        /// </summary>
        /// <param name="strDesignation"></param>
        /// <param name="decDesignationId"></param>
        /// <returns></returns>
        public bool DesignationCheckExistanceOfName(string strDesignation, decimal decDesignationId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DesignationCheckExistanceOfName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationName", SqlDbType.VarChar);
                sprmparam.Value = strDesignation;
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.VarChar);
                sprmparam.Value = decDesignationId;
                object obj = sccmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = decimal.Parse(obj.ToString());
                }
                if (decCount > 0)
                {
                    return true;
                }
                else
                {
                    return false; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
