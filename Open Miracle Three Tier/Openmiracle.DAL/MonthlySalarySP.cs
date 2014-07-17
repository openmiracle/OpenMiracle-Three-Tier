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
//Summary description for MonthlySalarySP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class MonthlySalarySP : DBConnection
    {
        /// <summary>
        /// Function to insert values to MonthlySalary Table
        /// </summary>
        /// <param name="monthlysalaryinfo"></param>
        public void MonthlySalaryAdd(MonthlySalaryInfo monthlysalaryinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = monthlysalaryinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra2;
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
        /// Function to Update values in MonthlySalary Table
        /// </summary>
        /// <param name="monthlysalaryinfo"></param>
        public void MonthlySalaryEdit(MonthlySalaryInfo monthlysalaryinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
                sprmparam.Value = monthlysalaryinfo.MonthlySalaryId;
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = monthlysalaryinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra2;
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
        /// Function to get all the values from MonthlySalary Table
        /// </summary>
        /// <returns></returns>
        public DataTable MonthlySalaryViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryViewAll", sqlcon);
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
        /// Function to get particular values from MonthlySalary Table based on the parameter
        /// </summary>
        /// <param name="monthlySalaryId"></param>
        /// <returns></returns>
        public MonthlySalaryInfo MonthlySalaryView(decimal monthlySalaryId)
        {
            MonthlySalaryInfo monthlysalaryinfo = new MonthlySalaryInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
                sprmparam.Value = monthlySalaryId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    monthlysalaryinfo.MonthlySalaryId = Convert.ToDecimal(sdrreader[0].ToString());
                    monthlysalaryinfo.SalaryMonth = Convert.ToDateTime(sdrreader[1].ToString());
                    monthlysalaryinfo.Narration = sdrreader[2].ToString();
                    monthlysalaryinfo.ExtraDate = Convert.ToDateTime(sdrreader[3].ToString());
                    monthlysalaryinfo.Extra1 = sdrreader[4].ToString();
                    monthlysalaryinfo.Extra2 = sdrreader[5].ToString();
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
            return monthlysalaryinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table MonthlySalary
        /// </summary>
        /// <param name="MonthlySalaryId"></param>
        public void MonthlySalaryDelete(decimal MonthlySalaryId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
                sprmparam.Value = MonthlySalaryId;
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
        /// Function to  get the next id for MonthlySalary Table
        /// </summary>
        /// <returns></returns>
        public int MonthlySalaryGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryMax", sqlcon);
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
        /// Function to CheckSalary Status For AdvancePayment
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool CheckSalaryStatusForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isStatus = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckSalaryStatusForAdvancePayment", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.Date);
                sprmparam.Value = date;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isStatus = true;
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
            return isStatus;
        }
        /// <summary>
        /// Function to insert values to MonthlySalary Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="monthlysalaryinfo"></param>
        /// <returns></returns>
        public decimal MonthlySalaryAddWithIdentity(MonthlySalaryInfo monthlysalaryinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = monthlysalaryinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra2;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decIdentity = Convert.ToDecimal(obj.ToString());
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
            return decIdentity;
        }     
        /// <summary>
        /// Function to Delete all are the  MonthlySalary's
        /// </summary>
        /// <param name="decMonthlySalaryId"></param>
        public void MonthlySalaryDeleteAll(decimal decMonthlySalaryId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalaryDeleteAll", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
                sprmparam.Value = decMonthlySalaryId;
                int inWorked = sccmd.ExecuteNonQuery();
                if (inWorked > 0)
                {}
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
        /// Function to get the all are the details about the all employees
       /// </summary>
       /// <param name="dtSalaryMonth"></param>
       /// <returns></returns>
        public List<DataTable> MonthlySalarySettingsEmployeeViewAll(DateTime dtSalaryMonth)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalarySettingsEmployeeViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtSalaryMonth;
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
        /// Function for MonthlySalary Settings Id Search Using Salary Month
        /// </summary>
        /// <param name="dtSalaryMonth"></param>
        /// <returns></returns>
        public decimal MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(DateTime dtSalaryMonth)
        {
            decimal i = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = dtSalaryMonth;
                Object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    i = Convert.ToDecimal(obj.ToString());
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
            return i;
        }
        /// <summary>
        /// Function to update the monthly salary settings
        /// </summary>
        /// <param name="monthlysalaryinfo"></param>
        public void MonthlySalarySettingsEdit(MonthlySalaryInfo monthlysalaryinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
                sprmparam.Value = monthlysalaryinfo.MonthlySalaryId;
                sprmparam = sccmd.Parameters.Add("@salaryMonth", SqlDbType.DateTime);
                sprmparam.Value = monthlysalaryinfo.SalaryMonth;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = monthlysalaryinfo.Extra2;
                int ineffectedrow = sccmd.ExecuteNonQuery();
                if (ineffectedrow > 0)
                {     }
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
        /// Function to get the all are the details about the monthly salary for report
        /// </summary>
        /// <param name="dtpFromDate"></param>
        /// <param name="dtpToDate"></param>
        /// <param name="strDesignation"></param>
        /// <param name="strEmployeeCode"></param>
        /// <param name="dtpSalaryMonth"></param>
        /// <returns></returns>
        public List<DataTable> MonthlySalryViewAllForMonthlySalaryReports(DateTime dtpFromDate,DateTime dtpToDate,string strDesignation,string strEmployeeCode,DateTime dtpSalaryMonth)//Coded By Swafiyy
        {
            List<DataTable> listMonthlySalry = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("MonthlySalryViewAllForMonthlySalaryReports", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtpFromDate;
                sqlda.SelectCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtpToDate;
                sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@salaryMonth", SqlDbType.DateTime).Value = dtpSalaryMonth;
                sqlda.Fill(dtbl);
                listMonthlySalry.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listMonthlySalry;
        }
        /// <summary>
        /// Check the advance payment status for salary payment
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool CheckSalaryAlreadyPaidOrNotForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isPaid = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckSalaryAlreadyPaidOrNotForAdvancePayment", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.Date);
                sprmparam.Value = date;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isPaid = true;
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
            return isPaid;
        }
    }
}
