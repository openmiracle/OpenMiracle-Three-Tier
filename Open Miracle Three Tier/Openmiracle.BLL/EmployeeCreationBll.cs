using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;

namespace OpenMiracle.BLL
{
   public class EmployeeCreationBll
    {
       EmployeeSP SPEmployee = new EmployeeSP();
        public void EmployeeAdd(EmployeeInfo employeeinfo)
        {
            try
            {

                SPEmployee.EmployeeAdd(employeeinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from Employee Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> EmployeeViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPEmployee.EmployeeViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                SPEmployee.EmployeeDelete(EmployeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                max = SPEmployee.EmployeeGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                isSave = SPEmployee.EmployeeAddIfNotExistsEmployeeCode(employeeinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                SPEmployee.EmployeeDeleteCheck(EmployeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeSearch(infoEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {

                infoemployee = SPEmployee.EmployeeView(employeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool isResult = false;
            try
            {
                isResult = SPEmployee.EmployeeCodeCheckExistance(strEmployeeCode, decEmployeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
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
                isEdit = SPEmployee.EmployeeEdit(employeeinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decEmployee = SPEmployee.EmployeeAddWithReturnIdentity(employeeinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                strdesignationId = SPEmployee.SalesmanGetDesignationId();
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.SalesmanViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {

                infoemployee = SPEmployee.SalesmanViewSpecificFeilds(employeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.SalesmanSearch(strEmployeeCode, strEmployeeName, strPhoneNumber, strMobileNumber, strIsActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                isEdit = SPEmployee.SalesmanEdit(employeeinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decReturnValue = SPEmployee.SalesmanCheckReferenceAndDelete(decEmployeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeViewForPaySlip();
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decReturnValue = SPEmployee.EmployeeCheckReferences(decEmployeeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeViewSalesman();
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeViewAllForEmployeeAddressBook(strEmployeeCode, strMobile, strPhone, strEmail);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeViewAllForDailySalaryReport(strEmployeeCode, strDesignation, dtFromDate, dtToDate, strStatus);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
             try
             {
                 listObj = SPEmployee.EmployeeViewAllEmployeeReport(strDesignation, strEmployeeCode,strStatus);
             }
             catch (Exception ex)
             {

                 MessageBox.Show("EC23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                listObj = SPEmployee.EmployeeViewByDesignationAndStatus(strDesignationName,strStatus);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SPEmployee.EmployeePackageEdit(decEmployeeId, decPackageId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("EC25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
