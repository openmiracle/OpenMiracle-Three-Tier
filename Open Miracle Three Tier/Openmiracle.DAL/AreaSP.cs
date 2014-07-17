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
//Summary description for AreaSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class AreaSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Area Table
        /// </summary>
        /// <param name="areainfo"></param>
        public void AreaAdd(AreaInfo areainfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = areainfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@areaName", SqlDbType.VarChar);
                sprmparam.Value = areainfo.AreaName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = areainfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra2;
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
        /// Function to Update values in Area Table
        /// </summary>
        /// <param name="areainfo"></param>
        public void AreaEdit(AreaInfo areainfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = areainfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@areaName", SqlDbType.VarChar);
                sprmparam.Value = areainfo.AreaName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = areainfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra2;
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
        /// Function to get all the values from Area Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AreaViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AreaViewAll", sqlcon);
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
        /// Function to get particular values from Area table based on the parameter
        /// </summary>
        /// <param name="areaId"></param>
        /// <returns></returns>
        public AreaInfo AreaView(decimal areaId)
        {
            AreaInfo areainfo = new AreaInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = areaId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    areainfo.AreaId = decimal.Parse(sdrreader[0].ToString());
                    areainfo.AreaName = sdrreader[1].ToString();
                    areainfo.Narration = sdrreader[2].ToString();
                    areainfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    areainfo.Extra1 = sdrreader[4].ToString();
                    areainfo.Extra2 = sdrreader[5].ToString();
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
            return areainfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter from Area Table
        /// </summary>
        /// <param name="AreaId"></param>
        public void AreaDelete(decimal AreaId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = AreaId;
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
        /// Function to  get the next id for Area table
        /// </summary>
        /// <returns></returns>
        public int AreaGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaMax", sqlcon);
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
        /// Function to Area Name Check Existence
        /// </summary>
        /// <param name="strAreaName"></param>
        /// <param name="strAreaId"></param>
        /// <returns></returns>
        public bool AreaNameCheckExistence(String strAreaName, decimal strAreaId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AreaCheckIfExist", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@areaName", SqlDbType.VarChar);
                sprmparam.Value = strAreaName;
                sprmparam = sqlcmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = strAreaId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
            }
            finally
            {
                sqlcon.Close();
            }
            return false;
        }
        /// <summary>
        /// Function to Function to insert values to Area Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="areainfo"></param>
        /// <returns></returns>
        public decimal AreaAddWithIdentity(AreaInfo areainfo)
        {
            decimal decAreaId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaName", SqlDbType.VarChar);
                sprmparam.Value = areainfo.AreaName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Extra2;
                object objAreaId = sccmd.ExecuteScalar();
                if (objAreaId != null)
                {
                    decAreaId = decimal.Parse(objAreaId.ToString());
                }
                else
                {
                    decAreaId = 0;
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
            return decAreaId;
        }
        /// <summary> 
        /// Function to get Area Only View All
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AreaOnlyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AreaOnlyViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("Sl.No", typeof(decimal));
                dtbl.Columns["Sl.No"].AutoIncrement = true;
                dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
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
        /// Function to Update the area
        /// </summary>
        /// <param name="areainfo"></param>
        /// <returns></returns>
        public bool AreaUpdate(AreaInfo areainfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaEditParticularField", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = areainfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@areaName", SqlDbType.VarChar);
                sprmparam.Value = areainfo.AreaName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = areainfo.Narration;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
                {
                    isEdit = true;
                }
                else
                {
                    isEdit = false;
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
        /// Fuinction to get fill area
        /// </summary>
        /// <param name="decAreaId"></param>
        /// <returns></returns>
        public AreaInfo AreaFill(decimal decAreaId)
        {
            AreaInfo infoArea = new AreaInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaWithNarrationView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = decAreaId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    infoArea.AreaId = Convert.ToDecimal(sdrreader[0].ToString());
                    infoArea.AreaName = sdrreader[1].ToString();
                    infoArea.Narration = sdrreader[2].ToString();
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
            return infoArea;
        }
        /// <summary>
        /// Function to check references to delete a area
        /// </summary>
        /// <param name="AreaId"></param>
        /// <returns></returns>
        public decimal AreaDeleteReference(decimal AreaId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AreaDeleteReference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = AreaId;
                decReturnValue = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
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
        /// Function to Area View For Combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AreaViewFOrCombofill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("AreaViewFOrCombofill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                DataRow dr = dtbl.NewRow();
                dr["areaId"] = 0;
                dr["areaName"] = "All";
                dtbl.Rows.InsertAt(dr, 0);
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
