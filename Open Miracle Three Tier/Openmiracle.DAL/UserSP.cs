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
//Summary description for UserSP    
//</summary> 
namespace OpenMiracle.DAL
{
    public class UserSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to account group Table
        /// </summary>
        /// <param name="userinfo"></param>
        public void UserAdd(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = userinfo.Active;
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = userinfo.RoleId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra2;
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
        /// Function to Update values in account group Table
        /// </summary>
        /// <param name="userinfo"></param>
        public void UserEdit(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = userinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = userinfo.Active;
                sprmparam = sccmd.Parameters.Add("@roleId", SqlDbType.Decimal);
                sprmparam.Value = userinfo.RoleId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Extra2;
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
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> UserViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UserViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from account group table based on the parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfo UserView(decimal userId)
        {
            UserInfo userinfo = new UserInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = userId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    userinfo.UserId = decimal.Parse(sdrreader[0].ToString());
                    userinfo.UserName = sdrreader[1].ToString();
                    userinfo.Password = sdrreader[2].ToString();
                    userinfo.Active = bool.Parse(sdrreader[3].ToString());
                    userinfo.RoleId = decimal.Parse(sdrreader[4].ToString());
                    userinfo.Narration = sdrreader[5].ToString();
                    userinfo.ExtraDate = DateTime.Parse(sdrreader[6].ToString());
                    userinfo.Extra1 = sdrreader[7].ToString();
                    userinfo.Extra2 = sdrreader[8].ToString();
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
            return userinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="UserId"></param>
        public void UserDelete(decimal UserId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = UserId;
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
        public int UserGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserMax", sqlcon);
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
        /// Function to view all from User table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> UserCreationViewAll()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UserCreationViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existence of User based on parameter
        /// </summary>
        /// <param name="decUserId"></param>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public bool UserCreationCheckExistence(decimal decUserId, string strUserName)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("UserCreationCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = decUserId;
                sprmparam = sqlcmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = strUserName;
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
        /// <summary>
        /// Function to view all details from user Table based on parameter
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strRole"></param>
        /// <returns></returns>
        public List<DataTable> UserCreationViewForGridFill(string strUserName, string strRole)
        {
            DataTable dtbluser = new DataTable();
            List<DataTable> LIstObj = new List<DataTable>();
            dtbluser.Columns.Add("SL.NO", typeof(decimal));
            dtbluser.Columns["SL.NO"].AutoIncrement = true;
            dtbluser.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbluser.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("UserCreationViewForGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@userName", SqlDbType.VarChar).Value = strUserName;
                sqlda.SelectCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = strRole;
                sqlda.Fill(dtbluser);
                LIstObj.Add(dtbluser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return LIstObj;
        }
        /// <summary>
        /// Function for check refernce and delete based on parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public decimal UserCreationReferenceDelete(decimal userId)
        {
            decimal decUser = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UserCreationReferenceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = userId;
                decUser = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decUser;
        }
        /// <summary>
        /// Function to check Password on Login 
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public string LoginCheck(string strUserName)
        {
            string strPsw = string.Empty;
            object obj = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LoginCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = strUserName;
                obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    strPsw = sccmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("USP:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return strPsw;
        }
        /// <summary>
        /// Function to Get UserId After Login based on parameter
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public int GetUserIdAfterLogin(string strUserName, string strPassword)
        {
            int inUserId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GetUserIdAfterLogin", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = strUserName;
                sprmparam = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
                sprmparam.Value = strPassword;
                inUserId = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("USP:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return inUserId;
        }
        /// <summary>
        /// Function to Update password
        /// </summary>
        /// <param name="userinfo"></param>
        public void ChangePasswordEdit(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ChangePasswordEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = userinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@userName", SqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("@password", SqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
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
    }
}
