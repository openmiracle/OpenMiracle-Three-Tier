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
//Summary description for HolidaySP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class HolidaySP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Holiday Table
        /// </summary>
        /// <param name="holidayinfo"></param>
        public void HolidayAdd(HolidayInfo holidayinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
                sprmparam.Value = holidayinfo.HolidayId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = holidayinfo.Date;
                sprmparam = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.HolidayName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = holidayinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra2;
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
        /// Function to Update values in Holiday Table
        /// </summary>
        /// <param name="holidayinfo"></param>
        public void HolidayEdit(HolidayInfo holidayinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
                sprmparam.Value = holidayinfo.HolidayId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = holidayinfo.Date;
                sprmparam = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.HolidayName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = holidayinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra2;
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
        /// Function to get all the values from Holiday Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> HolidayViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("HolidayViewAll", sqlcon);
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
        /// Function to get particular values from Holiday table based on the parameter
        /// </summary>
        /// <param name="holidayId"></param>
        /// <returns></returns>
        public HolidayInfo HolidayView(decimal holidayId)
        {
            HolidayInfo holidayinfo = new HolidayInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
                sprmparam.Value = holidayId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    holidayinfo.HolidayId = decimal.Parse(sdrreader[0].ToString());
                    holidayinfo.Date = DateTime.Parse(sdrreader[1].ToString());
                    holidayinfo.HolidayName = sdrreader[2].ToString();
                    holidayinfo.Narration = sdrreader[3].ToString();
                    holidayinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    holidayinfo.Extra1 = sdrreader[5].ToString();
                    holidayinfo.Extra2 = sdrreader[6].ToString();
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
            return holidayinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="HolidayId"></param>
        public void HolidayDelete(decimal HolidayId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@holidayId", SqlDbType.Decimal);
                sprmparam.Value = HolidayId;
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
        /// Function to  get the next id for Holiday table
        /// </summary>
        /// <returns></returns>
        public int HolidayGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayMax", sqlcon);
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
        /// Function to view HoildaySettings based on parameters
        /// </summary>
        /// <param name="strMonth"></param>
        /// <param name="strYear"></param>
        /// <returns></returns>
        public List<DataTable> HoildaySettingsViewAllLimited(string strMonth, string strYear)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblHolidaySettings = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("HoildaySettingsViewAllLimited", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@Month", SqlDbType.VarChar).Value = strMonth;
                sqlda.SelectCommand.Parameters.Add("@Year", SqlDbType.VarChar).Value = strYear;
                sqlda.Fill(dtblHolidaySettings);
                listObj.Add(dtblHolidaySettings);
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
        /// Function to insert values to Holiday table and return Id
        /// </summary>
        /// <param name="holidayinfo"></param>
        /// <returns></returns>
        public bool HolidayAddWithIdentity(HolidayInfo holidayinfo)
        {
            bool isSave = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolidayAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = holidayinfo.Date;
                sprmparam = sccmd.Parameters.Add("@holidayName", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.HolidayName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = holidayinfo.Extra2;
                int inAffected = sccmd.ExecuteNonQuery();
                if (inAffected > 0)
                {
                    isSave = true;
                }
                else
                {
                    isSave = false;
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
            return isSave;
        }
        /// <summary>
        /// Function to delete HolidaySettings by month based on parameters
        /// </summary>
        /// <param name="strMonth"></param>
        /// <param name="strYear"></param>
        public void HolidaySettingsDeleteByMonth(string strMonth, string strYear)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("HolidaySettingsDeleteByMonth", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@Month", SqlDbType.VarChar).Value = strMonth;
                sqlcmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = strYear;
                sqlcmd.ExecuteNonQuery();
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
        /// Function to check Holidays based on parameter and return value
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public decimal HolliDayChecking(DateTime date)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("HolliDayChecking", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = date;
                decResult = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decResult;
        }
    }
}
