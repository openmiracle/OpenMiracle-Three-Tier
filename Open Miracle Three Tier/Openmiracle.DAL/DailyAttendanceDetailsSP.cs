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
//Summary description for DailyAttendanceDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
  public class DailyAttendanceDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DailyAttendanceDetails Table
        /// </summary>
        /// <param name="dailyattendancedetailsinfo"></param>
        public void DailyAttendanceDetailsAdd(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra2;
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
        /// Function to Update values in DailyAttendanceDetails Table
        /// </summary>
        /// <param name="dailyattendancedetailsinfo"></param>
        public void DailyAttendanceDetailsEdit(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailyattendancedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra2;
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
        /// Function to get all the values from DailyAttendanceDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable DailyAttendanceDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceDetailsViewAll", sqlcon);
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
        /// Function to get particular values from DailyAttendanceDetails Table based on the parameter
        /// </summary>
        /// <param name="dailyAttendanceDetailsId"></param>
        /// <returns></returns>
        public DailyAttendanceDetailsInfo DailyAttendanceDetailsView(decimal dailyAttendanceDetailsId)
        {
            DailyAttendanceDetailsInfo dailyattendancedetailsinfo = new DailyAttendanceDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailyAttendanceDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    dailyattendancedetailsinfo.DailyAttendanceDetailsId = decimal.Parse(sdrreader[0].ToString());
                    dailyattendancedetailsinfo.DailyAttendanceMasterId = decimal.Parse(sdrreader[1].ToString());
                    dailyattendancedetailsinfo.EmployeeId = decimal.Parse(sdrreader[2].ToString());
                    dailyattendancedetailsinfo.Status = sdrreader[3].ToString();
                    dailyattendancedetailsinfo.Narration = sdrreader[4].ToString();
                    dailyattendancedetailsinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    dailyattendancedetailsinfo.Extra1 = sdrreader[6].ToString();
                    dailyattendancedetailsinfo.Extra2 = sdrreader[7].ToString();
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
            return dailyattendancedetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table DailyAttendanceDetails
        /// </summary>
        /// <param name="DailyAttendanceDetailsId"></param>
        public void DailyAttendanceDetailsDelete(decimal DailyAttendanceDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = DailyAttendanceDetailsId;
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
        /// Function to  get the next id for DailyAttendanceDetails Table
        /// </summary>
        /// <returns></returns>
        public int DailyAttendanceDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsMax", sqlcon);
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
        /// Function to Daily Attendance Details Search GridFill
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public List<DataTable> DailyAttendanceDetailsSearchGridFill(string strDate) 
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailyAttendanceDetailsSearchGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Parse(strDate);
                dtbl.Columns.Add("Sl NO", typeof(decimal));
                dtbl.Columns["Sl NO"].AutoIncrement = true;
                dtbl.Columns["Sl NO"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl NO"].AutoIncrementStep = 1;
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
        /// Function to Daily Attendance Details Add Using MasterId
        /// </summary>
        /// <param name="dailyattendancedetailsinfo"></param>
        public void DailyAttendanceDetailsAddUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsAddUsingMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra2;
                int ineffectedrow = sccmd.ExecuteNonQuery();
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
        /// Function to Daily Attendance Details Delete All
       /// </summary>
       /// <param name="decdailyAttendanceMasterId"></param>
        public void DailyAttendanceDetailsDeleteAll(decimal decdailyAttendanceMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsDeleteAll", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decdailyAttendanceMasterId;
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
        /// Function to Daily Attendance Details Edit Using MasterId
        /// </summary>
        /// <param name="dailyattendancedetailsinfo"></param>
        public void DailyAttendanceDetailsEditUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailyAttendanceDetailsEditUsingMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceDetailsId;
                sprmparam = sccmd.Parameters.Add("@dailyAttendanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.DailyAttendanceMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailyattendancedetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailyattendancedetailsinfo.Extra2;
                int ina = sccmd.ExecuteNonQuery();
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
