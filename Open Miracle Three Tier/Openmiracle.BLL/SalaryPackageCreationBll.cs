using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
   public class SalaryPackageCreationBll
    {
       SalaryPackageSP spSalaryPackage = new SalaryPackageSP();
       SalaryPackageSP SalaryPackage=new SalaryPackageSP();
       SalaryPackageDetailsSP spSalaryPackageDetails = new SalaryPackageDetailsSP();
       /// <summary>
       /// Function to get particular values from SalaryPackage table based on the parameter
       /// </summary>
       /// <param name="salaryPackageId"></param>
       /// <returns></returns>
       public SalaryPackageInfo SalaryPackageView(decimal salaryPackageId)
       {
           SalaryPackageInfo salarypackageinfo = new SalaryPackageInfo();
           try
           {
               salarypackageinfo = spSalaryPackage.SalaryPackageView(salaryPackageId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return salarypackageinfo;
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="SalaryPackageId"></param>
       public void SalaryPackageDeleteAll(decimal SalaryPackageId)
       {
         
           try
           {
               spSalaryPackage.SalaryPackageDeleteAll(SalaryPackageId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to insert values to SalaryPackage Table
       /// </summary>
       /// <param name="salarypackageinfo"></param>
       /// <returns></returns>
       public decimal SalaryPackageAdd(SalaryPackageInfo salarypackageinfo)
       {
           decimal decIdentity = -1;
           try
           {
               decIdentity = spSalaryPackage.SalaryPackageAdd(salarypackageinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;
       }
       /// <summary>
       /// Function to check existance of salarypackagename
       /// </summary>
       /// <param name="strSalaryPackageName"></param>
       /// <returns></returns>
       public bool SalaryPackageNameCheckExistance(string strSalaryPackageName)
       {
           bool isExists = false;
           try
           {
               isExists = spSalaryPackage.SalaryPackageNameCheckExistance(strSalaryPackageName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExists;
       }
       /// <summary>
       /// Function to Update values in SalaryPackage Table
       /// </summary>
       /// <param name="salarypackageinfo"></param>
       public void SalaryPackageEdit(SalaryPackageInfo salarypackageinfo)
       {          
           try
           {
              spSalaryPackage.SalaryPackageEdit(salarypackageinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }           
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="SalaryPackageId"></param>
       public void SalaryPackageDelete(decimal SalaryPackageId)
       {
           try
           {
               spSalaryPackage.SalaryPackageDelete(SalaryPackageId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
          
       }
   /// <summary>
        /// Function to get particular values from SalaryPackageDetails table based on the parameter
        /// </summary>
        /// <param name="decSalaryPackageId"></param>
        /// <returns></returns>
        public List<DataTable> SalaryPackageDetailsViewWithSalaryPackageId(decimal decSalaryPackageId)
        {
            List<DataTable> listObjSalaryPackageDetails = new List<DataTable>();
       
           try
           {
               listObjSalaryPackageDetails = spSalaryPackageDetails.SalaryPackageDetailsViewWithSalaryPackageId(decSalaryPackageId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObjSalaryPackageDetails;
       }
        /// <summary>
        /// Function to insert values to SalaryPackageDetails Table
        /// </summary>
        /// <param name="salarypackagedetailsinfo"></param>
        /// <returns></returns>
        public bool SalaryPackageDetailsAdd(SalaryPackageDetailsInfo salarypackagedetailsinfo)
        {
            bool isSave = false;
            try
            {
                isSave = spSalaryPackageDetails.SalaryPackageDetailsAdd(salarypackagedetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalaryPackageId"></param>
        public void SalaryPackageDetailsDeleteWithSalaryPackageId(decimal SalaryPackageId)
        {          
            try
            {
                spSalaryPackageDetails.SalaryPackageDetailsDeleteWithSalaryPackageId(SalaryPackageId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        /// <summary>
        /// Function to get payhead type
        /// </summary>
        /// <param name="payHeadId"></param>
        /// <returns></returns>
        public string PayHeadTypeView(decimal payHeadId)
        {
            string price = null;        
            try
            {
                price = spSalaryPackageDetails.PayHeadTypeView(payHeadId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return price;
        }
        public List<DataTable> SalaryPackageregisterSearch(string strSalaryPackageName, string strStatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SalaryPackage.SalaryPackageregisterSearch(strSalaryPackageName, strStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalaryPackageViewAllForMonthlySalarySettings()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SalaryPackage.SalaryPackageViewAllForMonthlySalarySettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalaryPackageViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SalaryPackage.SalaryPackageViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalaryPackageViewAllForSalaryPackageReport(string strPackageName, string strStatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SalaryPackage.SalaryPackageViewAllForSalaryPackageReport(strPackageName, strStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
       public List<DataTable> SalaryPackageViewAllForActive()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SalaryPackage.SalaryPackageViewAllForActive();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> SalaryPackageDetailsForSalaryPackageDetailsReport(string strPackageName)//Coded By Swafiyy
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSalaryPackageDetails.SalaryPackageDetailsForSalaryPackageDetailsReport(strPackageName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
    }
}
