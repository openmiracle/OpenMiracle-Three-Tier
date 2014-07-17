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
    public class FinancialYearBll
    {
        FinancialYearSP SPFinancialYear = new FinancialYearSP();
        public void FinancialYearAdd(FinancialYearInfo financialyearinfo)
        {
            try
            {
                SPFinancialYear.FinancialYearAdd(financialyearinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in FinancialYear Table
        /// </summary>
        /// <param name="financialyearinfo"></param>
        public void FinancialYearEdit(FinancialYearInfo financialyearinfo)
        {
            try
            {
                SPFinancialYear.FinancialYearEdit(financialyearinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from FinancialYear Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> FinancialYearViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPFinancialYear.FinancialYearViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from FinancialYear  table based on the parameter
        /// </summary>
        /// <param name="financialYearId"></param>
        /// <returns></returns>
        public FinancialYearInfo FinancialYearView(decimal financialYearId)
        {
            FinancialYearInfo financialyearinfo = new FinancialYearInfo();
            try
            {
                financialyearinfo = SPFinancialYear.FinancialYearView(financialYearId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return financialyearinfo;
        }
        /// <summary>
        /// Function to get particular values from FinancialYear table For AccountLedger based on the parameter
        /// </summary>
        /// <param name="financialYearId"></param>
        /// <returns></returns>
        public FinancialYearInfo FinancialYearViewForAccountLedger(decimal financialYearId)
        {
            FinancialYearInfo financialyearinfo = new FinancialYearInfo();
            try
            {
                financialyearinfo = SPFinancialYear.FinancialYearViewForAccountLedger(financialYearId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return financialyearinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="FinancialYearId"></param>
        public void FinancialYearDelete(decimal FinancialYearId)
        {
            try
            {
                SPFinancialYear.FinancialYearDelete(FinancialYearId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to  get the next id for FinancialYear table
        /// </summary>
        /// <returns></returns>
        public string FinancialYearGetMax()
        {
            string strMax = string.Empty;
            try
            {
                strMax = SPFinancialYear.FinancialYearGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strMax;
        }
        /// <summary>
        /// Function to insert values and return id 
        /// </summary>
        /// <param name="financialyearinfo"></param>
        /// <returns></returns>
        public decimal FinancialYearAddWithReturnIdentity(FinancialYearInfo financialyearinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = SPFinancialYear.FinancialYearAddWithReturnIdentity(financialyearinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to check existence based on parameter and return status
        /// </summary>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <returns></returns>
        public bool FinancialYearExistenceCheck(DateTime dtFromDate, DateTime dtToDate)
        {
            bool trueOrfalse = true;
            try
            {
                trueOrfalse = SPFinancialYear.FinancialYearExistenceCheck(dtFromDate, dtToDate);
            }
            catch (Exception ex)
            {

                MessageBox.Show("FY9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
    }
}
