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
//Summary description for EmployeeSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class EmployeeSP : DBConnection
    {   
        /// <summary>
        /// Function to insert values to Employee Table
        /// </summary>
        /// <param name="employeeinfo"></param>
        public void EmployeeAdd(EmployeeInfo employeeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.Dob;
                sprmparam = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MaritalStatus;
                sprmparam = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Gender;
                sprmparam = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Qualification;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MobileNumber;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.JoiningDate;
                sprmparam = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.TerminationDate;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BloodGroup;
                sprmparam = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PassportNo;
                sprmparam = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.PassportExpiryDate;
                sprmparam = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.LabourCardNumber;
                sprmparam = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.LabourCardExpiryDate;
                sprmparam = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.VisaNumber;
                sprmparam = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.VisaExpiryDate;
                sprmparam = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.SalaryType;
                sprmparam = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DailyWage;
                sprmparam = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankName;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PanNumber;
                sprmparam = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PfNumber;
                sprmparam = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EsiNumber;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DefaultPackageId;
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
        /// Function to get all the values from Employee Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> EmployeeViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewAll", sqlcon);
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="EmployeeId"></param>
        public void EmployeeDelete(decimal EmployeeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = EmployeeId;
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
        /// Function to  get the next id for Employee table
        /// </summary>
        /// <returns></returns>
        public int EmployeeGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeMax", sqlcon);
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
        /// Function to insert values to Employee Table if not exist employee code
       /// </summary>
       /// <param name="employeeinfo"></param>
       /// <returns></returns>
        public bool EmployeeAddIfNotExistsEmployeeCode(EmployeeInfo employeeinfo)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeAddWithDifferentEmployeeCode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.Dob;
                sprmparam = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MaritalStatus;
                sprmparam = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Gender;
                sprmparam = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Qualification;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MobileNumber;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.JoiningDate;
                sprmparam = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.TerminationDate;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BloodGroup;
                sprmparam = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PassportNo;
                sprmparam = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.PassportExpiryDate;
                sprmparam = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.LabourCardNumber;
                sprmparam = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.LabourCardExpiryDate;
                sprmparam = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.VisaNumber;
                sprmparam = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.VisaExpiryDate;
                sprmparam = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.SalaryType;
                sprmparam = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DailyWage;
                sprmparam = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankName;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@micrCodeNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PanNumber;
                sprmparam = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PfNumber;
                sprmparam = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EsiNumber;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DefaultPackageId;
                int inWorked = sccmd.ExecuteNonQuery();
                if (inWorked > 0)
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
        /// Function to delete employee by checking reference
        /// </summary>
        /// <param name="EmployeeId"></param>
        public void EmployeeDeleteCheck(decimal EmployeeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = EmployeeId;
                int inWorked = sccmd.ExecuteNonQuery();
                if (inWorked > 0)
                {
                   // Messages.DeletedMessage();
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
        /// Function to search the employee
        /// </summary>
        /// <param name="infoEmployee"></param>
        /// <returns></returns>
        public List<DataTable> EmployeeSearch(EmployeeInfo infoEmployee)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblEmployee = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblEmployee.Columns.Add("SlNo", typeof(decimal));
                dtblEmployee.Columns["SlNo"].AutoIncrement = true;
                dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1;
                dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = infoEmployee.EmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = infoEmployee.EmployeeName;
                sqlda.SelectCommand.Parameters.Add("@designationId", SqlDbType.Decimal).Value = infoEmployee.DesignationId;
                sqlda.SelectCommand.Parameters.Add("@salaryType", SqlDbType.VarChar).Value = infoEmployee.SalaryType;
                sqlda.SelectCommand.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar).Value = infoEmployee.BankAccountNumber;
                sqlda.SelectCommand.Parameters.Add("@passportNumber", SqlDbType.VarChar).Value = infoEmployee.PassportNo;
                sqlda.SelectCommand.Parameters.Add("@labourCardNumber", SqlDbType.VarChar).Value = infoEmployee.LabourCardNumber;
                sqlda.SelectCommand.Parameters.Add("@visaNumber", SqlDbType.VarChar).Value = infoEmployee.VisaNumber;
                sqlda.Fill(dtblEmployee);
                listObj.Add(dtblEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Employee table based on the parameter
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public EmployeeInfo EmployeeView(decimal employeeId)
        {
            EmployeeInfo infoemployee = new EmployeeInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("EmployeeView", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = employeeId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoemployee.EmployeeId = Convert.ToDecimal(sqldr["employeeId"].ToString());
                    infoemployee.DesignationId = Convert.ToDecimal(sqldr["designationId"].ToString());
                    infoemployee.EmployeeName = sqldr["employeeName"].ToString();
                    infoemployee.EmployeeCode = sqldr["employeeCode"].ToString();
                    infoemployee.Dob = Convert.ToDateTime(sqldr["dob"].ToString());
                    infoemployee.MaritalStatus = sqldr["maritalStatus"].ToString();
                    infoemployee.Gender = sqldr["gender"].ToString();
                    infoemployee.Qualification = sqldr["qualification"].ToString();
                    infoemployee.Address = sqldr["address"].ToString();
                    infoemployee.PhoneNumber = sqldr["phoneNumber"].ToString();
                    infoemployee.MobileNumber = sqldr["mobileNumber"].ToString();
                    infoemployee.Email = sqldr["email"].ToString();
                    infoemployee.JoiningDate = Convert.ToDateTime(sqldr["joiningDate"].ToString());
                    infoemployee.TerminationDate = Convert.ToDateTime(sqldr["terminationDate"].ToString());
                    infoemployee.IsActive = bool.Parse(sqldr["isActive"].ToString());
                    infoemployee.Narration = sqldr["narration"].ToString();
                    infoemployee.BloodGroup = sqldr["bloodGroup"].ToString();
                    infoemployee.PassportNo = sqldr["passportNo"].ToString();
                    infoemployee.PassportExpiryDate = Convert.ToDateTime(sqldr["passportExpiryDate"].ToString());
                    infoemployee.LabourCardNumber = sqldr["labourCardNumber"].ToString();
                    infoemployee.LabourCardExpiryDate = Convert.ToDateTime(sqldr["labourCardExpiryDate"].ToString());
                    infoemployee.VisaNumber = sqldr["visaNumber"].ToString();
                    infoemployee.VisaExpiryDate = Convert.ToDateTime(sqldr["visaExpiryDate"].ToString());
                    infoemployee.SalaryType = sqldr["salaryType"].ToString();
                    infoemployee.DailyWage = Convert.ToDecimal(sqldr["dailyWage"].ToString());
                    infoemployee.BankName = sqldr["bankName"].ToString();
                    infoemployee.BranchName = sqldr["branchName"].ToString();
                    infoemployee.BankAccountNumber = sqldr["bankAccountNumber"].ToString();
                    infoemployee.BranchCode = sqldr["branchCode"].ToString();
                    infoemployee.PanNumber = sqldr["panNumber"].ToString();
                    infoemployee.PfNumber = sqldr["pfNumber"].ToString();
                    infoemployee.EsiNumber = sqldr["esiNumber"].ToString();
                    
                    infoemployee.DefaultPackageId = Convert.ToDecimal(sqldr["defaultPackageId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return infoemployee;
        }
       /// <summary>
       /// Function to check the existance of employee code
       /// </summary>
       /// <param name="strEmployeeCode"></param>
       /// <param name="decEmployeeId"></param>
       /// <returns></returns>
        public bool EmployeeCodeCheckExistance(String strEmployeeCode, decimal decEmployeeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("EmployeeCodeCheckExistance", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = strEmployeeCode;
                sprmparam = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
        /// Function to Update values in Employee Table
        /// </summary>
        /// <param name="employeeinfo"></param>
        /// <returns></returns>
        public bool EmployeeEdit(EmployeeInfo employeeinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.Dob;
                sprmparam = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MaritalStatus;
                sprmparam = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Gender;
                sprmparam = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Qualification;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MobileNumber;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.JoiningDate;
                sprmparam = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.TerminationDate;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BloodGroup;
                sprmparam = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PassportNo;
                sprmparam = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.PassportExpiryDate;
                sprmparam = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.LabourCardNumber;
                sprmparam = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.LabourCardExpiryDate;
                sprmparam = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.VisaNumber;
                sprmparam = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.VisaExpiryDate;
                sprmparam = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.SalaryType;
                sprmparam = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DailyWage;
                sprmparam = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankName;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PanNumber;
                sprmparam = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PfNumber;
                sprmparam = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EsiNumber;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DefaultPackageId;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
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
        /// Function to insert values to Employee Table and returns last identity
        /// </summary>
        /// <param name="employeeinfo"></param>
        /// <returns></returns>
        public decimal EmployeeAddWithReturnIdentity(EmployeeInfo employeeinfo)
        {
            decimal decEmployee = -1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeeForTakingEmployeeId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sccmd.Parameters.Add("@designationId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("@dob", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.Dob;
                sprmparam = sccmd.Parameters.Add("@maritalStatus", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MaritalStatus;
                sprmparam = sccmd.Parameters.Add("@gender", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Gender;
                sprmparam = sccmd.Parameters.Add("@qualification", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Qualification;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MobileNumber;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("@joiningDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.JoiningDate;
                sprmparam = sccmd.Parameters.Add("@terminationDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.TerminationDate;
                sprmparam = sccmd.Parameters.Add("@active", SqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@bloodGroup", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BloodGroup;
                sprmparam = sccmd.Parameters.Add("@passportNo", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PassportNo;
                sprmparam = sccmd.Parameters.Add("@passportExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.PassportExpiryDate;
                sprmparam = sccmd.Parameters.Add("@labourCardNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.LabourCardNumber;
                sprmparam = sccmd.Parameters.Add("@labourCardExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.LabourCardExpiryDate;
                sprmparam = sccmd.Parameters.Add("@visaNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.VisaNumber;
                sprmparam = sccmd.Parameters.Add("@visaExpiryDate", SqlDbType.DateTime);
                sprmparam.Value = employeeinfo.VisaExpiryDate;
                sprmparam = sccmd.Parameters.Add("@salaryType", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.SalaryType;
                sprmparam = sccmd.Parameters.Add("@dailyWage", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DailyWage;
                sprmparam = sccmd.Parameters.Add("@bankName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankName;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@panNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PanNumber;
                sprmparam = sccmd.Parameters.Add("@pfNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PfNumber;
                sprmparam = sccmd.Parameters.Add("@esiNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EsiNumber;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DefaultPackageId;
                object AdvancePaymentId = sccmd.ExecuteScalar();
                if (AdvancePaymentId != null)
                {
                    decEmployee = Convert.ToDecimal(AdvancePaymentId.ToString());
                }
                else
                {
                    decEmployee = -1;
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
            return decEmployee;
        }
        
        /// <summary>
        /// Function to get designationid of salesman
        /// </summary>
        /// <returns></returns>
        public string SalesmanGetDesignationId()
        {
            string strdesignationId = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesManGetDesignationId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                strdesignationId = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strdesignationId;
        }
       /// <summary>
        /// Function to get all the values from employee Table for salesman
       /// </summary>
       /// <returns></returns>
        public List<DataTable> SalesmanViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl.No", typeof(decimal));
            dtbl.Columns["Sl.No"].AutoIncrement = true;
            dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesmanViewAll", sqlcon);
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
        /// Function to get particular values from employee table based on the parameter
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public EmployeeInfo SalesmanViewSpecificFeilds(decimal employeeId)
        {
            EmployeeInfo infoemployee = new EmployeeInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesmanViewSpecificFeilds", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = employeeId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoemployee.EmployeeId = Convert.ToDecimal(sqldr["employeeId"].ToString());
                    infoemployee.EmployeeName = sqldr["employeeName"].ToString();
                    infoemployee.EmployeeCode = sqldr["employeeCode"].ToString();
                    infoemployee.Email = sqldr["email"].ToString();
                    infoemployee.PhoneNumber = sqldr["phoneNumber"].ToString();
                    infoemployee.MobileNumber = sqldr["mobileNumber"].ToString();
                    infoemployee.Address = sqldr["address"].ToString();
                    infoemployee.Narration = sqldr["narration"].ToString();
                    infoemployee.IsActive = Convert.ToBoolean(sqldr["isActive"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return infoemployee;
        }
        
        /// <summary>
        /// Function to search salesman
        /// </summary>
        /// <param name="strEmployeeCode"></param>
        /// <param name="strEmployeeName"></param>
        /// <param name="strPhoneNumber"></param>
        /// <param name="strMobileNumber"></param>
        /// <param name="strIsActive"></param>
        /// <returns></returns>
        public  List<DataTable> SalesmanSearch(String strEmployeeCode, String strEmployeeName,String strPhoneNumber, String strMobileNumber, String strIsActive)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl.No", typeof(decimal));
            dtbl.Columns["Sl.No"].AutoIncrement = true;
            dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesmanSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@employeeName", SqlDbType.VarChar).Value = strEmployeeName;
                sqlda.SelectCommand.Parameters.Add("@mobileNumber", SqlDbType.VarChar).Value = strMobileNumber;
                sqlda.SelectCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = strPhoneNumber;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strIsActive;
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
        /// Function to Update values in employee Table for salesman
        /// </summary>
        /// <param name="employeeinfo"></param>
        /// <returns></returns>
        public bool SalesmanEdit(EmployeeInfo employeeinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesmanEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = employeeinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@employeeName", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("@employeeCode", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("@mobileNumber", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MobileNumber;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Narration;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
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
       /// Function to delete salesman by checking the reference
       /// </summary>
       /// <param name="decEmployeeId"></param>
       /// <returns></returns>
        public decimal SalesmanCheckReferenceAndDelete(decimal decEmployeeId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesmanCheckReferenceAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        
        /// <summary>
        /// Function to get particular values from employee table for payslip
        /// </summary>
        /// <returns></returns>
        public  List<DataTable> EmployeeViewForPaySlip()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewForPaySlip", sqlcon);
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
        /// Function to check the reference
        /// </summary>
        /// <param name="decEmployeeId"></param>
        /// <returns></returns>
        public decimal EmployeeCheckReferences(decimal decEmployeeId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("EmployeeCheckReferences", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to view all salesman
        /// </summary>
        /// <returns></returns>
        public List<DataTable> EmployeeViewSalesman()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("EmployeeViewSalesman", sqlcon);
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
       /// Function to view all employees for addressbook 
       /// </summary>
       /// <param name="strEmployeeCode"></param>
       /// <param name="strMobile"></param>
       /// <param name="strPhone"></param>
       /// <param name="strEmail"></param>
       /// <returns></returns>
        public List<DataTable> EmployeeViewAllForEmployeeAddressBook(string strEmployeeCode,string strMobile,string strPhone,string strEmail)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblEmployee = new DataTable();
            dtblEmployee.Columns.Add("SlNo", typeof(int));
            dtblEmployee.Columns["SlNo"].AutoIncrement = true;
            dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllForEmployeeAddressBook", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = strMobile;
                sqlda.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = strPhone;
                sqlda.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = strEmail;
                sqlda.Fill(dtblEmployee);
                listObj.Add(dtblEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to view all employees for DailySalaryReport 
        /// </summary>
        /// <param name="strEmployeeCode"></param>
        /// <param name="strDesignation"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> EmployeeViewAllForDailySalaryReport(string strEmployeeCode,string strDesignation,DateTime dtFromDate,DateTime dtToDate,string strStatus)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblEmployee = new DataTable();
            dtblEmployee.Columns.Add("SlNo", typeof(int));
            dtblEmployee.Columns["SlNo"].AutoIncrement = true;
            dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllForDailySalaryReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@designation", SqlDbType.VarChar).Value = strDesignation;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
                sqlda.Fill(dtblEmployee);
                listObj.Add(dtblEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view all employees for EmployeeReport 
        /// </summary>
        /// <param name="strDesignation"></param>
        /// <param name="strEmployeeCode"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> EmployeeViewAllEmployeeReport(string strDesignation,string strEmployeeCode, string strStatus)
        {
             List<DataTable> listObj = new List<DataTable>();
            DataTable dtblEmployee = new DataTable();
            dtblEmployee.Columns.Add("SlNo", typeof(int));
            dtblEmployee.Columns["SlNo"].AutoIncrement = true;
            dtblEmployee.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblEmployee.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewAllEmployeeReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@designationName", SqlDbType.VarChar).Value = strDesignation;
                sqlda.SelectCommand.Parameters.Add("@employeeCode", SqlDbType.VarChar).Value = strEmployeeCode;
                sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
                sqlda.Fill(dtblEmployee);
                listObj.Add(dtblEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
       /// <summary>
        /// Function to view all employees based on designation and status
       /// </summary>
       /// <param name="strDesignationName"></param>
       /// <param name="strStatus"></param>
       /// <returns></returns>
        public List<DataTable> EmployeeViewByDesignationAndStatus(string strDesignationName,string strStatus)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("EmployeeViewByDesignationAndStatus", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@designationName", SqlDbType.VarChar).Value = strDesignationName;
                sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
      /// <summary>
        /// Function to Update values in Employee Table
      /// </summary>
      /// <param name="decEmployeeId"></param>
      /// <param name="decPackageId"></param>
        public void EmployeePackageEdit(decimal decEmployeeId, decimal decPackageId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("EmployeePackageEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = decEmployeeId;
                sprmparam = sccmd.Parameters.Add("@defaultPackageId", SqlDbType.Decimal);
                sprmparam.Value = decPackageId;
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
