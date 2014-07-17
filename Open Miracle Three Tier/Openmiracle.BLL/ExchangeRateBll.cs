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
    public class ExchangeRateBll
    {
        ExchangeRateSP SPExchangeRate = new ExchangeRateSP();
        public void ExchangeRateAdd(ExchangeRateInfo exchangerateinfo)
        {
            try
            {

                SPExchangeRate.ExchangeRateAdd(exchangerateinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
        /// <summary>
        /// Function to Update values in ExchangeRate Table
        /// </summary>
        /// <param name="exchangerateinfo"></param>
        public void ExchangeRateEdit(ExchangeRateInfo exchangerateinfo)
        {
            try
            {

                SPExchangeRate.ExchangeRateEdit(exchangerateinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        /// <summary>
        /// Function to get all the values from ExchangeRate Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ExchangeRateViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {

                listObj = SPExchangeRate.ExchangeRateViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from ExchangeRate Table based on the parameter
        /// </summary>
        /// <param name="exchangeRateId"></param>
        /// <returns></returns>
        public ExchangeRateInfo ExchangeRateView(decimal exchangeRateId)
        {
            ExchangeRateInfo exchangerateinfo = new ExchangeRateInfo();
            try
            {

                exchangerateinfo = SPExchangeRate.ExchangeRateView(exchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            return exchangerateinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ExchangeRateId"></param>
        public void ExchangeRateDelete(decimal ExchangeRateId)
        {
            try
            {

                SPExchangeRate.ExchangeRateDelete(ExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        /// <summary>
        /// Function to  get the next id for ExchangeRate table
        /// </summary>
        /// <returns></returns>
        public int ExchangeRateGetMax()
        {
            int max = 0;
            try
            {

               max= SPExchangeRate.ExchangeRateGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            return max;
        }
        /// <summary>
        /// Function to insert particular values to ExchangeRate Table
        /// </summary>
        /// <param name="exchangerateinfo"></param>
        public void ExchangeRateAddParticularFields(ExchangeRateInfo exchangerateinfo)
        {
            try
            {

                SPExchangeRate.ExchangeRateAddParticularFields(exchangerateinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        /// <summary>
        /// Function to get values for search based on parameters
        /// </summary>
        /// <param name="strCurrencyname"></param>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <returns></returns>
        public List<DataTable> ExchangeRateSearch(String strCurrencyname, DateTime dtDateFrom, DateTime dtDateTo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {

                listObj = SPExchangeRate.ExchangeRateSearch(strCurrencyname, dtDateFrom, dtDateTo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            return listObj;
        }
        /// <summary>
        /// Function to check existence based on parameters and return status
        /// </summary>
        /// <param name="dtDate"></param>
        /// <param name="decCurrencyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public bool ExchangeRateCheckExistence(DateTime dtDate, decimal decCurrencyId, decimal decExchangeRateId)
        {
            bool isResult = false;
            try
            {
                isResult = SPExchangeRate.ExchangeRateCheckExistence(dtDate, decCurrencyId, decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        /// <summary>
        /// Function to get id based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public decimal GetExchangeRateId(decimal decCurrencyId, DateTime dtDate)
        {
            decimal decCount = 0;
            try
            {
                decCount = SPExchangeRate.GetExchangeRateId(decCurrencyId, dtDate);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCount;
        }
        /// <summary>
        /// Function to check refernce bassed on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal ExchangeRateCheckReferences(decimal decExchangeRateId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SPExchangeRate.ExchangeRateCheckReferences(decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to get rate based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal GetExchangeRateByExchangeRateId(decimal decExchangeRateId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SPExchangeRate.GetExchangeRateByExchangeRateId(decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to view rate based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal ExchangeRateViewByExchangeRateId(decimal decExchangeRateId)
        {
            decimal exchangeRate = 0;
            try
            {
                exchangeRate = SPExchangeRate.ExchangeRateViewByExchangeRateId(decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return exchangeRate;
        }
        /// <summary>
        /// Function to get decimal places based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public int NoOfDecimalNumberViewByExchangeRateId(decimal decExchangeRateId)
        {
            int NoOfDecimalNumber = 0;
            try
            {
                NoOfDecimalNumber = SPExchangeRate.NoOfDecimalNumberViewByExchangeRateId(decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return NoOfDecimalNumber;
        }
        /// <summary>
        /// Function to get decimal places based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public int NoOfDecimalNumberViewByCurrencyId(decimal decCurrencyId)
        {
            int NoOfDecimalNumber = 0;
            try
            {
                NoOfDecimalNumber = SPExchangeRate.NoOfDecimalNumberViewByCurrencyId(decCurrencyId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return NoOfDecimalNumber;
        }
        /// <summary>
        /// Function to get value based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public decimal ExchangerateViewByCurrencyId(decimal decCurrencyId)
        {
            decimal decExchangerateId = 0;
            try
            {
                decExchangerateId = SPExchangeRate.ExchangerateViewByCurrencyId(decCurrencyId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decExchangerateId;
        }


        /// <summary>
        /// Function to check existence based on parameters and return status
        /// </summary>
        /// <param name="dtDate"></param>
        /// <param name="decCurrencyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public bool ExchangeRateCheckExistanceForUpdationAndDelete(DateTime dtDate, decimal decExchangeRateId)
        {
            bool isResult = false;
            try
            {
                isResult = SPExchangeRate.ExchangeRateCheckExistanceForUpdationAndDelete(dtDate, decExchangeRateId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERBll17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;    
        }
    }
}
