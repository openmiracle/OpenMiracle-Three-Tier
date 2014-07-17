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
//Summary description for PrivilegeSP    
//</summary>  
namespace OpenMiracle.DAL
{
    public class PrivilegeSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Privilege Table
        /// </summary>
        /// <param name="privilegeinfo"></param>
        public void PrivilegeAdd(PrivilegeInfo privilegeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@formName", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.FormName;
                sprmparam = sccmd.Parameters.Add("@action", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Action;
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = privilegeinfo.RoleId;
                sprmparam = sccmd.Parameters.Add("@exatra1", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Extra2;
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
        /// Function to Update values in Privilege Table
        /// </summary>
        /// <param name="privilegeinfo"></param>
        public void PrivilegeEdit(PrivilegeInfo privilegeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = privilegeinfo.PrivilegeId;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = privilegeinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@formName", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.FormName;
                sprmparam = sccmd.Parameters.Add("@action", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Action;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = privilegeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@exatra1", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = privilegeinfo.Extra2;
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
        /// Function to get all the values from Privilege Table
        /// </summary>
        /// <returns></returns>
        public DataTable PrivilegeViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeViewAll", sqlcon);
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
        /// Function to get particular values from Privilege Table based on the parameter
        /// </summary>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public PrivilegeInfo PrivilegeView(decimal decRoleId)
        {
            PrivilegeInfo privilegeinfo = new PrivilegeInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = decRoleId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    privilegeinfo.PrivilegeId = decimal.Parse(sdrreader[0].ToString());
                    privilegeinfo.FormName = sdrreader[1].ToString();
                    privilegeinfo.Action = sdrreader[2].ToString();
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
            return privilegeinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table Privilege
        /// </summary>
        /// <param name="PrivilegeId"></param>
        public void PrivilegeDelete(decimal PrivilegeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@privilegeId", SqlDbType.Decimal);
                sprmparam.Value = PrivilegeId;
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
        /// Function to  get the next id for Privilege Table
        /// </summary>
        /// <returns></returns>
        public int PrivilegeGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeMax", sqlcon);
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
        /// This function To use the PrivilegeCheck
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="formName"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PrivilegeCheck(decimal userId, string formName, string action)
        {
            bool isCheck = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("PrivilegeCheck", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@userId", SqlDbType.Decimal).Value = userId;
                sqlCmd.Parameters.Add("@formName", SqlDbType.VarChar).Value = formName;
                sqlCmd.Parameters.Add("@action", SqlDbType.VarChar).Value = action;
                object obj = sqlCmd.ExecuteScalar();
                if (obj != null)
                    isCheck = true;
                else
                    isCheck = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return isCheck;
        }
        /// <summary>
        /// Function to use the Privilege Settings Search
        /// </summary>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public List<DataTable> PrivilegeSettingsSearch(decimal decRoleId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeSettingsSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@roleId", SqlDbType.Decimal).Value = decRoleId;
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
        /// Function to use the Privilege Action Search
        /// </summary>
        /// <param name="strAction"></param>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public List<DataTable> PrivilegeActionSearch(string strAction, decimal decRoleId)
        {
            List<DataTable> listObjAction = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PrivilegeActionSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@formName", SqlDbType.VarChar).Value = strAction;
                sdaadapter.SelectCommand.Parameters.Add("@roleId", SqlDbType.VarChar).Value = decRoleId;
                sdaadapter.Fill(dtbl);
                listObjAction.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjAction;
        }
        /// <summary>
        /// Function to use the Privilege Delete a Tabel using role
        /// </summary>
        /// <param name="RoleId"></param>
        public void PrivilegeDeleteTabel(decimal RoleId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrivilegeDeleteTable", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = RoleId;
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
        /// function to use the RolePrivilege to add a new item CheckExistence
        /// </summary>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public bool RolePrivilegeSaveCheckExistence(decimal decRoleId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("RolePrivilegeSaveCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = decRoleId;
                object obj = sqlcmd.ExecuteScalar();
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
    }
}
