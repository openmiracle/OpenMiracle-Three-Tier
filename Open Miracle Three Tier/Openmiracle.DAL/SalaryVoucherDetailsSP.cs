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
//Summary description for SalaryVoucherDetailsSP    
//</summary>    
namespace OpenMiracle.DAL    
{
    public class SalaryVoucherDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalaryVoucher Table
        /// </summary>
        /// <param name="salaryvoucherdetailsinfo"></param>
        public void SalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.SalaryVoucherDetailsId;
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Bonus;
                sprmparam = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Deduction;
                sprmparam = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Advance;
                sprmparam = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Lop;
                sprmparam = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Salary;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salaryvoucherdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra2;
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
        /// Function to Update values in MonthlySalaryVoucherDetails Table
        /// </summary>
        /// <param name="salaryvoucherdetailsinfo"></param>
        public void SalaryVoucherDetailsEdit(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.SalaryVoucherDetailsId;
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Bonus;
                sprmparam = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Deduction;
                sprmparam = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Advance;
                sprmparam = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Lop;
                sprmparam = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Salary;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salaryvoucherdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra2;
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
        /// Function to get all the values from MonthlySalaryVoucherDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalaryVoucherDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryVoucherDetailsViewAll", sqlcon);
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
        /// Function to get particular values from MonthlySalaryVoucherDetails Table based on the parameter
        /// </summary>
        /// <param name="salaryVoucherDetailsId"></param>
        /// <returns></returns>
        public SalaryVoucherDetailsInfo SalaryVoucherDetailsView(decimal salaryVoucherDetailsId)
        {
            SalaryVoucherDetailsInfo salaryvoucherdetailsinfo = new SalaryVoucherDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salaryVoucherDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salaryvoucherdetailsinfo.SalaryVoucherDetailsId = decimal.Parse(sdrreader[0].ToString());
                    salaryvoucherdetailsinfo.SalaryVoucherMasterId = decimal.Parse(sdrreader[1].ToString());
                    salaryvoucherdetailsinfo.EmployeeId = decimal.Parse(sdrreader[2].ToString());
                    salaryvoucherdetailsinfo.Bonus = decimal.Parse(sdrreader[3].ToString());
                    salaryvoucherdetailsinfo.Deduction = decimal.Parse(sdrreader[4].ToString());
                    salaryvoucherdetailsinfo.Advance = decimal.Parse(sdrreader[5].ToString());
                    salaryvoucherdetailsinfo.Lop = decimal.Parse(sdrreader[6].ToString());
                    salaryvoucherdetailsinfo.Salary = decimal.Parse(sdrreader[7].ToString());
                    salaryvoucherdetailsinfo.Status = sdrreader[8].ToString();
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
            return salaryvoucherdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table MonthlySalaryVoucherDetails
        /// </summary>
        /// <param name="SalaryVoucherDetailsId"></param>
        public void SalaryVoucherDetailsDelete(decimal SalaryVoucherDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalaryVoucherDetailsId;
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
        /// Function to  get the next id for MonthlySalaryVoucherDetails Table
        /// </summary>
        /// <returns></returns>
        public int SalaryVoucherDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsMax", sqlcon);
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
        /// Function to view or get  Monthly Salary Voucher Details All
        /// </summary>
        /// <param name="strMonth"></param>
        /// <param name="Month"></param>
        /// <param name="monthYear"></param>
        /// <param name="isEditMode"></param>
        /// <param name="strVoucherNoforEdit"></param>
        /// <returns></returns>
        public List<DataTable> MonthlySalaryVoucherDetailsViewAll(string strMonth, string Month, string monthYear, bool isEditMode, string strVoucherNoforEdit)
        {
            decimal decEditMode = 0;
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (isEditMode == true)
                {
                    decEditMode = 1;
                }
                else
                {
                    decEditMode = 0;
                    strVoucherNoforEdit = "0";
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("SlNo", typeof(decimal));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryVoucherDetailsViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@strMonth", SqlDbType.VarChar).Value = strMonth;
                sdaadapter.SelectCommand.Parameters.Add("@Month", SqlDbType.VarChar).Value = Month;
                sdaadapter.SelectCommand.Parameters.Add("@monthYear", SqlDbType.VarChar).Value = monthYear;
                sdaadapter.SelectCommand.Parameters.Add("@isEditMode", SqlDbType.Decimal).Value = decEditMode;
                sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNoforEdit;
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
        /// Function to insert values to MonthlySalaryVoucherDetails Table
        /// </summary>
        /// <param name="salaryvoucherdetailsinfo"></param>
        public void MonthlySalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.SalaryVoucherMasterId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@bonus", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Bonus;
                sprmparam = sccmd.Parameters.Add("@deduction", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Deduction;
                sprmparam = sccmd.Parameters.Add("@advance", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Advance;
                sprmparam = sccmd.Parameters.Add("@lop", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Lop;
                sprmparam = sccmd.Parameters.Add("@salary", SqlDbType.Decimal);
                sprmparam.Value = salaryvoucherdetailsinfo.Salary;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Status;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salaryvoucherdetailsinfo.Extra2;
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
        /// Function to SalaryVoucherDetails Delete Using MasterId
        /// </summary>
        /// <param name="SalaryVoucherDetailsMasterId"></param>
        public void SalaryVoucherDetailsDeleteUsingMasterId(decimal SalaryVoucherDetailsMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsDeleteUsingMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalaryVoucherDetailsMasterId;
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
       /// Function to get count of salary's Voucher
       /// </summary>
       /// <param name="decMasterId"></param>
       /// <returns></returns>
        public int SalaryVoucherDetailsCount(decimal decMasterId)
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryVoucherDetailsCount", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryVoucherMasterId", SqlDbType.Decimal);
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
        /// Function to Check Wether Salary Already Paid
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public string CheckWhetherSalaryAlreadyPaid(decimal decEmployeeId, DateTime Month)
        {
            string strName = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckWhetherSalaryAlreadyPaid", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@month", SqlDbType.DateTime);
                sprmparam.Value = Month;
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
