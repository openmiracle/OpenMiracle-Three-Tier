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
   public class BudgetBll
    {
       BudgetMasterSP SPBudgetMaster = new BudgetMasterSP();
       BudgetDetailsSP SPBudgetDetails = new BudgetDetailsSP();
        public void BudgetDetailsAdd(BudgetDetailsInfo budgetdetailsinfo)
        {
            try
            {

                SPBudgetDetails.BudgetDetailsAdd(budgetdetailsinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in BudgetDetails Table
        /// </summary>
        /// <param name="budgetdetailsinfo"></param>
        public void BudgetDetailsEdit(BudgetDetailsInfo budgetdetailsinfo)
        {
            try
            {

                SPBudgetDetails.BudgetDetailsEdit(budgetdetailsinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function toDelete the values from BudgetDetails Table
        /// </summary>
        /// <returns></returns>
        public void BudgetDetailsDelete(decimal BudgetDetailsId)
        {
            try
            {

                SPBudgetDetails.BudgetDetailsDelete(BudgetDetailsId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from BudgetDetails Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BudgetDetailsViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetDetails.BudgetDetailsViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from BudgetDetails table based on the parameter
        /// </summary>
        /// <param name="budgetDetailsId"></param>
        /// <returns></returns>
        public BudgetDetailsInfo BudgetDetailsView(decimal budgetDetailsId)
        {
            BudgetDetailsInfo budgetdetailsinfo = new BudgetDetailsInfo();
            try
            {
              budgetdetailsinfo = SPBudgetDetails.BudgetDetailsView(budgetDetailsId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return budgetdetailsinfo;
        }
        /// <summary>
        /// Function to get particular values from BudgetDetails table based on the parameter
        /// </summary>
        /// <param name="decBudgetMasterId"></param>
        /// <returns></returns>
        public List<DataTable> BudgetDetailsViewByMasterId(decimal decBudgetMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetDetails.BudgetDetailsViewByMasterId(decBudgetMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to  get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int BudgetDetailsGetMax()
        {
            int max = 0;
            try
            {
                max = SPBudgetDetails.BudgetDetailsGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        public decimal BudgetMasterAdd(BudgetMasterInfo budgetmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {

               decIdentity= SPBudgetMaster.BudgetMasterAdd(budgetmasterinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in BudgetMaster Table
        /// </summary>
        /// <param name="budgetmasterinfo"></param>
        public void BudgetMasterEdit(BudgetMasterInfo budgetmasterinfo)
        {
            try
            {

                SPBudgetMaster.BudgetMasterEdit(budgetmasterinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from BudgetMaster Table
        /// </summary>
        /// <param name="strStartText"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> BudgetMasterViewAll(string strStartText, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetMaster.BudgetMasterViewAll(strStartText, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from BudgetMaster table based on the parameter
        /// </summary>
        /// <param name="budgetMasterId"></param>
        /// <returns></returns>
        public BudgetMasterInfo BudgetMasterView(decimal budgetMasterId)
        {
            BudgetMasterInfo budgetmasterinfo = new BudgetMasterInfo();
            try
            {
                budgetmasterinfo = SPBudgetMaster.BudgetMasterView(budgetMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return budgetmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BudgetMasterId"></param>
        /// <returns></returns>
        public decimal BudgetMasterDelete(decimal BudgetMasterId)
        {
            decimal decReturnValue = 0;
            try
            {

               decReturnValue= SPBudgetMaster.BudgetMasterDelete(BudgetMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to  get the next id for BudgetMaster table
        /// </summary>
        /// <returns></returns>
        public int BudgetMasterGetMax()
        {
            int max = 0;
            try
            {
                max = SPBudgetMaster.BudgetMasterGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }

        /// <summary>
        /// Budget check existance of name
        /// </summary>
        /// <param name="strBudgetName"></param>
        /// <param name="decBudgetMasterId"></param>
        /// <returns></returns>
        public bool BudgetCheckExistanceOfName(string strBudgetName, decimal decBudgetMasterId)
        {
            bool isEdit = false;
            try
            {
                isEdit = SPBudgetMaster.BudgetCheckExistanceOfName(strBudgetName, decBudgetMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BGBll14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Budget search for grid fill
        /// </summary>
        /// <param name="strBudgetName"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> BudgetSearchGridFill(string strBudgetName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetMaster.BudgetSearchGridFill(strBudgetName, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        /// <summary>
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BudgetViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetMaster.BudgetViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Budget variance view by budgetId
        /// </summary>
        /// <param name="decbudgetId"></param>
        /// <returns></returns>
        public List<DataTable> BudgetVariance(decimal decbudgetId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBudgetMaster.BudgetVariance(decbudgetId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BGBll17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}
