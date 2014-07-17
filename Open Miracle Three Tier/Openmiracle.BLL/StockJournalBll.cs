using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
    public class StockJournalBll
    {
        StockJournalDetailsSP spStockJournalDetails = new StockJournalDetailsSP();
        StockJournalMasterSP spStockJournalMaster = new StockJournalMasterSP();
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="StockJournalDetailsId"></param>
        public void StockJournalDetailsDelete(decimal StockJournalDetailsId)
        {
            try
            {
                spStockJournalDetails.StockJournalDetailsDelete(StockJournalDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsByProductCode(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalDetails.StockJournalDetailsByProductCode(decVoucherTypeId, strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsByProductName(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalDetails.StockJournalDetailsByProductName(decVoucherTypeId, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsViewByBarcode(decimal decVoucherTypeId, string strBarcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalDetails.StockJournalDetailsViewByBarcode(decVoucherTypeId, strBarcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        /// <summary>
        /// Function to insert values to StockJournal Table
        /// </summary>
        /// <param name="stockjournaldetailsinfo"></param>
        public void StockJournalDetailsAdd(StockJournalDetailsInfo stockjournaldetailsinfo)
        {
            try
            {
                spStockJournalDetails.StockJournalDetailsAdd(stockjournaldetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in StockJournal Table
        /// </summary>
        /// <param name="stockjournaldetailsinfo"></param>
        public void StockJournalDetailsEdit(StockJournalDetailsInfo stockjournaldetailsinfo)
        {
            try
            {
                spStockJournalDetails.StockJournalDetailsEdit(stockjournaldetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public DataSet StockJournalDetailsForRegisterOrReport(decimal decMasterId)
        {
            DataSet dsData = new DataSet();
            try
            {
                dsData = spStockJournalDetails.StockJournalDetailsForRegisterOrReport(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsData;
        }
        /// <summary>
        /// Function to get values from StockJournal Table based on parameter for register
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherNo"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalRegisterGrideFill(DateTime fromDate, DateTime toDate, string invoiceNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalMaster.StockJournalRegisterGrideFill(fromDate, toDate, invoiceNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get values from StockJournal Table based on parameter for Report
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalReportGrideFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strinvoiceNo, string strProductCode, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalMaster.StockJournalReportGrideFill(fromDate, toDate, decVoucherTypeId, strinvoiceNo, strProductCode, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function for VoucherType ComboFill For StockJournal Report
        /// </summary>
        /// <param name="cmbVoucherType"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="isAll"></param>
        public void VoucherTypeComboFillForStockJournalReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            try
            {
                spStockJournalMaster.VoucherTypeComboFillForStockJournalReport(cmbVoucherType, strVoucherType, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to  get the next id from StockJournal Table based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal StockJournalMasterMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = spStockJournalMaster.StockJournalMasterMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to  get the next id from StockJournal Table based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal StockJournalMasterMax(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = spStockJournalMaster.StockJournalMasterMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function for delete stockjournal table values based on parameter
        /// </summary>
        /// <param name="decStockJournalMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void StockJournalDeleteAllTables(decimal decStockJournalMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                spStockJournalMaster.StockJournalDeleteAllTables(decStockJournalMasterId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to insert values to StockJournal Table
        /// </summary>
        /// <param name="stockjournalmasterinfo"></param>
        /// <returns></returns>
        public decimal StockJournalMasterAdd(StockJournalMasterInfo stockjournalmasterinfo)
        {
            decimal decStockJournalMasterId = 0;
            try
            {
                decStockJournalMasterId = spStockJournalMaster.StockJournalMasterAdd(stockjournalmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decStockJournalMasterId;
        }
        /// <summary>
        /// Function to Update values in StockJournal Table
        /// </summary>
        /// <param name="stockjournalmasterinfo"></param>
        public void StockJournalMasterEdit(StockJournalMasterInfo stockjournalmasterinfo)
        {
            try
            {
                spStockJournalMaster.StockJournalMasterEdit(stockjournalmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check existence of StockJournal InvoiceNumber based on parameters
        /// </summary>
        /// <param name="strvoucherNo"></param>
        /// <param name="decStockMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool StockJournalInvoiceNumberCheckExistence(string strinvoiceNo, decimal decStockMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spStockJournalMaster.StockJournalInvoiceNumberCheckExistence(strinvoiceNo, decStockMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to fill StockJournalMaster details For Register Or Report based on parameters
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalMasterFillForRegisterOrReport(decimal decMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spStockJournalMaster.StockJournalMasterFillForRegisterOrReport(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function for StockJournal Printing based on parameter
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public DataSet StockJournalPrinting(decimal decMasterId)
        {
            DataSet dsData = new DataSet();
            try
            {
                dsData = spStockJournalMaster.StockJournalPrinting(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsData;
        }
    }
}
