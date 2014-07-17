using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;
namespace OpenMiracle.BLL
{
   public class BonusDeductionBll
    {
       BonusDedutionSP SPBonusDedution = new BonusDedutionSP();
        public void BonusDedutionAdd(BonusDedutionInfo bonusdedutioninfo)
        {
            try
            {

                SPBonusDedution.BonusDedutionAdd(bonusdedutioninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in BonusDeduction  Table
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        public void BonusDedutionEdit(BonusDedutionInfo bonusdedutioninfo)
        {
            try
            {

                SPBonusDedution.BonusDedutionEdit(bonusdedutioninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
        /// <summary>
        /// Function to get all the values from BonusDeduction Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BonusDedutionViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBonusDedution.BonusDedutionViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from BonusDeduction table based on the parameter
        /// </summary>
        /// <param name="bonusDeductionId"></param>
        /// <returns></returns>
        public BonusDedutionInfo BonusDedutionView(decimal bonusDeductionId)
        {
            BonusDedutionInfo bonusdedutioninfo = new BonusDedutionInfo();
            try
            {
                bonusdedutioninfo=SPBonusDedution.BonusDedutionView(bonusDeductionId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return bonusdedutioninfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BonusDeductionId"></param>
        public void BonusDedutionDelete(decimal BonusDeductionId)
        {
            try
            {
              SPBonusDedution.BonusDedutionDelete(BonusDeductionId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
        /// <summary>
        /// Function to  get the next id for BonusDeduction table
        /// </summary>
        /// <returns></returns>
        public int BonusDedutionGetMax()
        {
            int max = 0;
            try
            {
                max=SPBonusDedution.BonusDedutionGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to get values for search based on parameters
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="dtMonth"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionSearch(String strName, DateTime dtMonth)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBonusDedution.BonusDeductionSearch(strName, dtMonth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular value based on parameter
        /// </summary>
        /// <param name="decBonusDedutionId"></param>
        /// <returns></returns>
        public List<DataTable> BonusDedutionFill(decimal decBonusDedutionId)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = SPBonusDedution.BonusDedutionFill(decBonusDedutionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        /// <summary>
        /// Function to view details for update based on parameter
        /// </summary>
        /// <param name="decBonusDeductionId"></param>
        /// <returns></returns>
        public BonusDedutionInfo BonusDeductionViewForUpdate(decimal decBonusDeductionId)
        {
            BonusDedutionInfo bonusdedutioninfo = new BonusDedutionInfo();
            try
            {
               bonusdedutioninfo= SPBonusDedution.BonusDeductionViewForUpdate(decBonusDeductionId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return bonusdedutioninfo;
        }
        /// <summary>
        /// Function to insert values if not exists and return id
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        /// <returns></returns>
        public bool BonusDeductionAddIfNotExist(BonusDedutionInfo bonusdedutioninfo)
        {
            bool isSave = false;
            
            try
            {

                isSave= SPBonusDedution.BonusDeductionAddIfNotExist(bonusdedutioninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return isSave;
        }
        /// <summary>
        /// Function to check existence of month and return value
        /// </summary>
        /// <param name="bonusdedutioninfo"></param>
        /// <returns></returns>
        public bool BonusDeductionMonthCheckExistance(BonusDedutionInfo bonusdedutioninfo)
        {
            bool isEdit = false;
            try
            {

                isEdit = SPBonusDedution.BonusDeductionMonthCheckExistance(bonusdedutioninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return isEdit;
        }
        /// <summary>
        /// Function to get all values based on the parameters for search
        /// </summary>
        /// <param name="strCode"></param>
        /// <param name="strName"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionSearchForPopUp(String strCode, String strName)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = SPBonusDedution.BonusDeductionSearchForPopUp(strCode, strName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        /// <summary>
        /// Function to check reference and delete based on parameters
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public decimal BonusDeductionReferenceDelete(decimal EmployeeId, DateTime month)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SPBonusDedution.BonusDeductionReferenceDelete(EmployeeId, month);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BDBll13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to get all the values for Report based on parameters
        /// </summary>
        /// <param name="strFromdate"></param>
        /// <param name="strTodate"></param>
        /// <param name="strSalaryMonth"></param>
        /// <param name="strDesignation"></param>
        /// <param name="strEmployee"></param>
        /// <param name="strBonusOrDeduction"></param>
        /// <returns></returns>
        public List<DataTable> BonusDeductionReportGridFill(string strFromdate, string strTodate, string strSalaryMonth, string strDesignation, string strEmployee, string strBonusOrDeduction)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = SPBonusDedution.BonusDeductionReportGridFill(strFromdate, strTodate, strSalaryMonth, strDesignation, strEmployee, strBonusOrDeduction);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BDBll14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
    }
}
