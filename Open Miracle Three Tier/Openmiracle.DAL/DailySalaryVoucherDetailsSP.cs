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
//Summary description for DailySalaryVoucherDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class DailySalaryVoucherDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DailySalaryVoucherDetails Table
        /// </summary>
        /// <param name="dailysalaryvoucherdetailsinfo"></param>
        public void DailySalaryVoucherDetailsAdd(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@wage", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Wage;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Status;
               
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Extra2;
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
        /// Function to Update values in DailySalaryVoucherDetails Table
        /// </summary>
        /// <param name="dailysalaryvoucherdetailsinfo"></param>
        public void DailySalaryVoucherDetailsEdit(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.DailySalaryVoucherDetailsId;
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@wage", SqlDbType.Decimal);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Wage;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = dailysalaryvoucherdetailsinfo.Extra2;
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
        /// Function to get all the values from DailySalaryVoucherDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable DailySalaryVoucherDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherDetailsViewAll", sqlcon);
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
        /// Function to get particular values from DailySalaryVoucherDetails table based on the parameter
        /// </summary>
        /// <param name="dailySalaryVoucherDetailsId"></param>
        /// <returns></returns>
        public DailySalaryVoucherDetailsInfo DailySalaryVoucherDetailsView(decimal dailySalaryVoucherDetailsId)
        {
            DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo = new DailySalaryVoucherDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = dailySalaryVoucherDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    dailysalaryvoucherdetailsinfo.DailySalaryVoucherDetailsId = decimal.Parse(sdrreader[0].ToString());
                    dailysalaryvoucherdetailsinfo.DailySalaryVocherMasterId = decimal.Parse(sdrreader[1].ToString());
                    dailysalaryvoucherdetailsinfo.EmployeeId = decimal.Parse(sdrreader[2].ToString());
                    dailysalaryvoucherdetailsinfo.Wage = decimal.Parse(sdrreader[3].ToString());
                    dailysalaryvoucherdetailsinfo.Status = sdrreader[4].ToString();
                    dailysalaryvoucherdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    dailysalaryvoucherdetailsinfo.Extra1 = sdrreader[6].ToString();
                    dailysalaryvoucherdetailsinfo.Extra2 = sdrreader[7].ToString();
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
            return dailysalaryvoucherdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="DailySalaryVoucherDetailsId"></param>
        public void DailySalaryVoucherDetailsDelete(decimal DailySalaryVoucherDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = DailySalaryVoucherDetailsId;
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
        /// Function to  get the next id for DailySalaryVoucherDetails table
        /// </summary>
        /// <returns></returns>
        public int DailySalaryVoucherDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsMax", sqlcon);
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
        /// Function to get all the values from DailySalaryVoucherDetails Table based on the parameters 
        /// </summary>
        /// <param name="strSalaryDate"></param>
        /// <param name="isEditMode"></param>
        /// <param name="strVoucherNumber"></param>
        /// <returns></returns>
        public List<DataTable> DailySalaryVoucherDetailsGridViewAll(string strSalaryDate, bool isEditMode, string strVoucherNumber)
        {
            int invalue = 0;
            List<DataTable> listDailySalaryVoucherDetailsGridViewAll = new List<DataTable>();
           
            try
            {
                if (isEditMode == true)
                {
                    invalue = 1;
                }
                else
                {
                    invalue = 0;
                    strVoucherNumber = "0";
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DailySalaryVoucherDetailsGridViewall", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("Sl.No", typeof(decimal));
                dtbl.Columns["Sl.No"].AutoIncrement = true;
                dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
                sdaadapter.SelectCommand.Parameters.Add("@salaryDate", SqlDbType.DateTime).Value = DateTime.Parse(strSalaryDate);
                sdaadapter.SelectCommand.Parameters.Add("@VOucherNoforEdit", SqlDbType.Decimal).Value = decimal.Parse(invalue.ToString());
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNumber;
                sdaadapter.Fill(dtbl);
                listDailySalaryVoucherDetailsGridViewAll.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listDailySalaryVoucherDetailsGridViewAll;
        }
        /// <summary>
        /// Function to get the count of DailySalaryVoucherDetails based on parameter
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public int DailySalaryVoucherDetailsCount(decimal decMasterId)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsCount", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="DailySalaryVoucherDetailsMasterId"></param>
        public void DailySalaryVoucherDetailsDeleteUsingMasterId(decimal DailySalaryVoucherDetailsMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DailySalaryVoucherDetailsDeleteUsingMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dailySalaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = DailySalaryVoucherDetailsMasterId;
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
        /// Function to check whether dialy salary already paid
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="SalaryDate"></param>
        /// <returns></returns>
        public string CheckWhetherDailySalaryAlreadyPaid(decimal decEmployeeId, DateTime SalaryDate)
        {
            string strName = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckWhetherDailySalaryAlreadyPaid", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@salaryDate", SqlDbType.DateTime);
                sprmparam.Value = SalaryDate;
                strName = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strName;
        }
    }
}
