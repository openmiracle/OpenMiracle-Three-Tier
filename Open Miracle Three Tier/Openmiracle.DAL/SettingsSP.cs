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
//Summary description for SettingsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SettingsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Settings Table
        /// </summary>
        /// <param name="settingsinfo"></param>
        public void SettingsAdd(SettingsInfo settingsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SettingsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@settingsId", SqlDbType.Decimal);
                sprmparam.Value = settingsinfo.SettingsId;
                sprmparam = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.SettingsName;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.Extra2;
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
        /// Function to Update values in Settings Table
        /// </summary>
        /// <param name="settingsinfo"></param>
        public void SettingsEdit(SettingsInfo settingsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SettingsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@settingsId", SqlDbType.Decimal);
                sprmparam.Value = settingsinfo.SettingsId;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = settingsinfo.Status;
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
        /// Function to get all the values from Settings Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SettingsViewAll()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SettingsViewAll", sqlcon);
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
        /// Function to copy settings
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SettingsToCopyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SettingsToCopyViewAll", sqlcon);
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
        /// Function to check reference of settings
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SettinsCheckReference()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SettinsCheckReference", sqlcon);
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
        /// Function to view  settings based on parameter
        /// </summary>
        /// <param name="strsettingsName"></param>
        /// <returns></returns>
        public SettingsInfo SettingsView(string strsettingsName)
        {
            SettingsInfo settingsinfo = new SettingsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SettingsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
                sprmparam.Value = strsettingsName;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    settingsinfo.SettingsId = Convert.ToDecimal(sdrreader[0].ToString());
                    settingsinfo.SettingsName = sdrreader[1].ToString();
                    settingsinfo.Status = sdrreader[2].ToString();
                    settingsinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    settingsinfo.Extra1 = sdrreader[4].ToString();
                    settingsinfo.Extra2 = sdrreader[5].ToString();
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
            return settingsinfo;
        }
        /// <summary>
        /// Function to view settings based on parameter to copy
        /// </summary>
        /// <param name="strsettingsName"></param>
        /// <returns></returns>
        public SettingsInfo SettingsToCopyView(string strsettingsName)
        {
            SettingsInfo settingsinfo = new SettingsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SettingsToCopyView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@settingsName", SqlDbType.VarChar);
                sprmparam.Value = strsettingsName;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    settingsinfo.SettingsId = Convert.ToDecimal(sdrreader[0].ToString());
                    settingsinfo.SettingsName = sdrreader[1].ToString();
                    settingsinfo.Status = sdrreader[2].ToString();
                    settingsinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    settingsinfo.Extra1 = sdrreader[4].ToString();
                    settingsinfo.Extra2 = sdrreader[5].ToString();
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
            return settingsinfo;
        }
        /// <summary>
        /// Function to  get the next id for Settings Table
        /// </summary>
        /// <returns></returns>
        public int SettingsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SettingsMax", sqlcon);
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
        /// Function to check status of Automatic Product Code Generation and return status
        /// </summary>
        /// <returns></returns>
        public bool AutomaticProductCodeGeneration()
        {
            string strStatus = string.Empty;
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AutomaticProductCodeGeneration", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check status of  Product Code display status and return status
        /// </summary>
        /// <returns></returns>
        public bool ShowProductCode()
        {
            string strStatus = string.Empty;
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ShowProductCode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check status of  Product Code display status and return status
        /// </summary>
        /// <returns></returns>
        public bool ShowBarcode()
        {
            string strStatus = "";
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ShowBarcode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check status of  Product Code display status and return status
        /// </summary>
        /// <returns></returns>
        public bool ShowCurrencySymbol()
        {
            string strStatus = "";
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ShowCurrencySymbol", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to get id of settings based on parameter
        /// </summary>
        /// <param name="strsettingsName"></param>
        /// <returns></returns>
        public decimal SettingsGetId(string strsettingsName)
        {
            decimal decSettingsId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SettingsGetId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strsettingsName;
                decSettingsId = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decSettingsId;
        }
        /// <summary>
        /// Function to copy settings status check based on parameter and return status
        /// </summary>
        /// <param name="strSettingsName"></param>
        /// <returns></returns>
        public bool SettingsToCopyStatusCheck(string strSettingsName)
        {
            decimal decStatus = 0;
            bool blStatus = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SettingsToCopyStatusCheck", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strSettingsName;
                decStatus = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
                if (decStatus == 1)
                {
                    blStatus = true;
                }
                else
                {
                    blStatus = false;
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
            return blStatus;
        }
        /// <summary>
        /// Function to check settings status based on parameter
        /// </summary>
        /// <param name="strSettingsName"></param>
        /// <returns></returns>
        public string SettingsStatusCheck(string strSettingsName)
        {
            string strStatus = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SettingsStatusCheck", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@settingsName", SqlDbType.VarChar).Value = strSettingsName;
                strStatus = Convert.ToString(sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strStatus;
        }
    }
}
