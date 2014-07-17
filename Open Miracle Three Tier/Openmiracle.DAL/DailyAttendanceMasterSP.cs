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
using OpenMiracle.DAL;
//<summary>    
//Summary description for DailyAttendanceMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class DailyAttendanceMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DailyAttendanceMaster Table
        /// </summary>
        /// <param name="dailyattendancemasterinfo"></param>
        public void DailyAttendanceMasterAdd(DailyAttendanceMasterInfo dailyattendancemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra2;
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
        /// Function to Update values in DailyAttendanceMaster Table
        /// </summary>
        /// <param name="dailyattendancemasterinfo"></param>
        public void DailyAttendanceMasterEdit(DailyAttendanceMasterInfo dailyattendancemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra2;
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
        /// Function to get all the values from DailyAttendanceMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable DailyAttendanceMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceMasterViewAll", sqlcon);
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
        /// Function to get particular values from DailyAttendanceMaster Table based on the parameter
        /// </summary>
        /// <param name="dailyAttendanceMasterId"></param>
        /// <returns></returns>
        public DailyAttendanceMasterInfo DailyAttendanceMasterView(decimal dailyAttendanceMasterId)
        {
            DailyAttendanceMasterInfo dailyattendancemasterinfo = new DailyAttendanceMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyAttendanceMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    dailyattendancemasterinfo.DailyAttendanceMasterId = decimal.Parse(sdrreader[0].ToString());
                    dailyattendancemasterinfo.Date = DateTime.Parse(sdrreader[1].ToString());
                    dailyattendancemasterinfo.Narration = sdrreader[2].ToString();
                    dailyattendancemasterinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    dailyattendancemasterinfo.Extra1 = sdrreader[4].ToString();
                    dailyattendancemasterinfo.Extra2 = sdrreader[5].ToString();
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
            return dailyattendancemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table DailyAttendanceMaster
        /// </summary>
        /// <param name="DailyAttendanceMasterId"></param>
        public void DailyAttendanceMasterDelete(decimal DailyAttendanceMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = DailyAttendanceMasterId;
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
        /// Function to  get the next id for DailyAttendanceMaster Table
        /// </summary>
        /// <returns></returns>
        public int DailyAttendanceMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceMasterMax", sqlcon);
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
        /// Function to add Daily Attendance Add To its Master table
        /// </summary>
        /// <param name="dailyattendancemasterinfo"></param>
        /// <returns></returns>
        public decimal DailyAttendanceAddToMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
        {
            decimal incount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceAddToMaster", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra2;
                Object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    incount = decimal.Parse(obj.ToString());
                }
                {
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
            return incount;
        }
        /// <summary>
        /// Function to update Daily Attendance Master
        /// </summary>
        /// <param name="dailyattendancemasterinfo"></param>
        public void DailyAttendanceEditMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceEditMaster", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancemasterinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancemasterinfo.Extra2;
                int ineffectedrow = sccmd.ExecuteNonQuery();
                if (ineffectedrow > 0)
                {
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
        }
        /// <summary>
        /// Function to Daily Attendance View For Daily Attendance Report
        /// </summary>
        /// <param name="strDate"></param>
        /// <param name="strStatus"></param>
        /// <param name="strEmployeeCode"></param>
        /// <param name="strDesignation"></param>
        /// <returns></returns>
        public List<DataTable> DailyAttendanceViewForDailyAttendanceReport(string strDate, string strStatus, string strEmployeeCode, string strDesignation)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter("DailyAttendanceViewForDailyAttendanceReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SlNo", typeof(decimal));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@workingDay", SqlDbType.VarChar).Value = strDate;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
                sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
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
        /// Function to Daily Attendance MasterMaster Id Search
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public bool DailyAttendanceMasterMasterIdSearch(string strDate)
        {
            decimal deccountMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DailyAttendanceMasterMasterIdSearch", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@date", SqlDbType.VarChar).Value = strDate;
                Object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    deccountMasterId = decimal.Parse(obj.ToString());
                }
                if (deccountMasterId > 0)
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return false;
        }
        /// <summary>
        /// Function to fill the report of Monthly Attendance Report 
        /// </summary>
        /// <param name="dtMonth"></param>
        /// <param name="decEmployeeId"></param>
        /// <returns></returns>
        public List<DataTable> MonthlyAttendanceReportFill(DateTime dtMonth, decimal decEmployeeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter("MonthlyAttendanceReportFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@month", SqlDbType.DateTime).Value = dtMonth;
                sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal).Value = decEmployeeId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
    }
}
