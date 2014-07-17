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
//Summary description for RouteSP    
//</summary>    
namespace OpenMiracle.DAL   
{
   public  class RouteSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Route Table
        /// </summary>
        /// <param name="routeinfo"></param>
        public void RouteAdd(RouteInfo routeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.RouteName;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = routeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra2;
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
        /// Function to Update values in Route Table
        /// </summary>
        /// <param name="routeinfo"></param>
        public void RouteEdit(RouteInfo routeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.RouteName;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = routeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra2;
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
        /// Function to get all the values from Route Table
        /// </summary>
        /// <returns></returns>
        public DataTable RouteViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RouteViewAll", sqlcon);
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
        /// Function to get particular values from Route table based on the parameter
        /// </summary>
        /// <param name="routeId"></param>
        /// <returns></returns>
        public RouteInfo RouteView(decimal routeId)
        {
            RouteInfo routeinfo = new RouteInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = routeId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    routeinfo.RouteId = decimal.Parse(sdrreader[0].ToString());
                    routeinfo.RouteName = sdrreader[1].ToString();
                    routeinfo.AreaId = decimal.Parse(sdrreader[2].ToString());
                    routeinfo.Narration = sdrreader[3].ToString();
                    routeinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    routeinfo.Extra1 = sdrreader[5].ToString();
                    routeinfo.Extra2 = sdrreader[6].ToString();
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
            return routeinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="RouteId"></param>
        public void RouteDelete(decimal RouteId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = RouteId;
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
        /// Function to  get the next id for Route table
        /// </summary>
        /// <returns></returns>
        public int RouteGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteMax", sqlcon);
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
        /// Function to get all area
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AreafillInRoute()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AreafillInRoute", sqlcon);
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
        /// Function to check existance of route
        /// </summary>
        /// <param name="strRouteName"></param>
        /// <param name="decRouteId"></param>
        /// <param name="decAreaId"></param>
        /// <returns></returns>
        public bool RouteCheckExistence(String strRouteName, decimal decRouteId, decimal decAreaId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("RouteCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@routeName", SqlDbType.VarChar);
                sprmparam.Value = strRouteName;
                sprmparam = sqlcmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = decRouteId;
                sprmparam = sqlcmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = decAreaId;
                object obj = sqlcmd.ExecuteScalar();
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
                    return false;
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
        /// Function to insert values to Route Table
        /// </summary>
        /// <param name="routeinfo"></param>
        /// <returns></returns>
        public decimal RouteAddParticularFields(RouteInfo routeinfo)
        {
            decimal decAreaId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteAddParticularFields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.RouteName;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra2;
                object objRouteId = sccmd.ExecuteScalar();
                if (objRouteId != null)
                {
                    decAreaId = decimal.Parse(objRouteId.ToString());
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
        /// Function to Update values in Route Table
        /// </summary>
        /// <param name="routeinfo"></param>
        /// <returns></returns>
        public bool RouteEditing(RouteInfo routeinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteEditing", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@routeName", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.RouteName;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = routeinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = routeinfo.Extra2;
                int ina = sccmd.ExecuteNonQuery();
                if (ina > 0)
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
        /// Function to get details based on parameters
        /// </summary>
        /// <param name="strRouteName"></param>
        /// <param name="strAreaName"></param>
        /// <returns></returns>
        public List<DataTable> RouteSearch(String strRouteName, String strAreaName)
        {
            List<DataTable> listObjRoute = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(decimal));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("RouteSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@routeName", SqlDbType.VarChar).Value = strRouteName;
                sqlda.SelectCommand.Parameters.Add("@areaName", SqlDbType.VarChar).Value = strAreaName;
                sqlda.Fill(dtbl);
                listObjRoute.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObjRoute;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="RouteId"></param>
        /// <returns></returns>
        public decimal RouteDeleting(decimal RouteId)
        {
            decimal decId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RouteDeleting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@routeId", SqlDbType.Decimal);
                sprmparam.Value = RouteId;
                decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
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
        /// Function to get all route
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RouteViewForComboFill()
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
                SqlCommand sqlcmd = new SqlCommand("RouteViewForComboFill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
                DataRow dr = listObj[0].NewRow();
                dr["routeId"] = 0;
                dr["routeName"] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
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
        /// Function to get route based on area
        /// </summary>
        /// <param name="decAreaId"></param>
        /// <returns></returns>
        public List<DataTable> RouteViewByArea(decimal decAreaId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RouteViewByArea", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = decAreaId;
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
