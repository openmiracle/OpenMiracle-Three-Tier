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
//Summary description for StockJournalMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class StockJournalMasterSP : DBConnection
    {
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = stockjournalmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Extra2;
                decStockJournalMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.StockJournalMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = stockjournalmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = stockjournalmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = stockjournalmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockjournalmasterinfo.Extra2;
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
        /// Function to get all the values from StockJournal Table
        /// </summary>
        /// <returns></returns>
        public DataTable StockJournalMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("StockJournalMasterViewAll", sqlcon);
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
        /// Function to get particular values from StockJournal Table based on the parameter
        /// </summary>
        /// <param name="stockJournalMasterId"></param>
        /// <returns></returns>
        public StockJournalMasterInfo StockJournalMasterView(decimal stockJournalMasterId)
        {
            StockJournalMasterInfo stockjournalmasterinfo = new StockJournalMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = stockJournalMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    stockjournalmasterinfo.StockJournalMasterId = decimal.Parse(sdrreader[0].ToString());
                    stockjournalmasterinfo.VoucherNo = sdrreader[1].ToString();
                    stockjournalmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    stockjournalmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    stockjournalmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[4].ToString());
                    stockjournalmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    stockjournalmasterinfo.Narration = sdrreader[6].ToString();
                    stockjournalmasterinfo.AdditionalCost = decimal.Parse(sdrreader[7].ToString());
                    stockjournalmasterinfo.FinancialYearId = decimal.Parse(sdrreader[8].ToString());
                    stockjournalmasterinfo.ExtraDate = DateTime.Parse(sdrreader[9].ToString());
                    stockjournalmasterinfo.Extra1 = sdrreader[10].ToString();
                    stockjournalmasterinfo.Extra2 = sdrreader[11].ToString();
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
            return stockjournalmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="StockJournalMasterId"></param>
        public void StockJournalMasterDelete(decimal StockJournalMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = StockJournalMasterId;
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
        /// Function to  get the next id from StockJournal Table
        /// </summary>
        /// <returns></returns>
        public int StockJournalMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalMasterMax", sqlcon);
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
        /// Function to  get the next id from StockJournal Table based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal StockJournalMasterMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return max + 1;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
        /// Function to get values from StockJournal Table based on parameter for register
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherNo"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalRegisterGrideFill(DateTime fromDate, DateTime toDate, string invoiceNo)
        {
            List<DataTable> listObjReg = new List<DataTable>();
            DataTable dtblSJRegister = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalRegisterGrideFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblSJRegister.Columns.Add("slNo", typeof(decimal));
                dtblSJRegister.Columns["slNo"].AutoIncrement = true;
                dtblSJRegister.Columns["slNo"].AutoIncrementSeed = 1;
                dtblSJRegister.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                param.Value = invoiceNo;
                sqlda.Fill(dtblSJRegister);
                listObjReg.Add(dtblSJRegister);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjReg;
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
            List<DataTable> listObjReg = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("slNo", typeof(int));
            dtbl.Columns["slNo"].AutoIncrement = true;
            dtbl.Columns["slNo"].AutoIncrementSeed = 1;
            dtbl.Columns["slNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalReportGrideFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                param.Value = strinvoiceNo;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                param = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                param.Value = strProductName;
                sqlda.Fill(dtbl);
                listObjReg.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjReg;
        }
        /// <summary>
        /// Function for VoucherType ComboFill For StockJournal Report
        /// </summary>
        /// <param name="cmbVoucherType"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="isAll"></param>
        public void VoucherTypeComboFillForStockJournalReport(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            List<DataTable> listObjVoucherName = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeComboFillForStockJournalReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
                sqlda.Fill(dtbl);
                listObjVoucherName.Add(dtbl);
                if (isAll)
                {
                    DataRow dr = listObjVoucherName[0].NewRow();
                    dr["voucherTypeName"] = "All";
                    dr["voucherTypeId"] = 0;
                    listObjVoucherName[0].Rows.InsertAt(dr, 0);
                }
                cmbVoucherType.DataSource = listObjVoucherName[0];
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.ValueMember = "voucherTypeId";
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("StockJournalInvoiceNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = decStockMasterId;
                sprmparam = sqlcmd.Parameters.Add("@vouchertypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
                    }
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
        /// Function to fill StockJournalMaster details For Register Or Report based on parameters
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalMasterFillForRegisterOrReport(decimal decMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalMasterFillForRegisterOrReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal).Value = decMasterId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            return listObj;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDeleteAllTables", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = decStockJournalMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
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
        /// Function for StockJournal Printing based on parameter
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public DataSet StockJournalPrinting(decimal decMasterId)
        {
            DataSet dsData = new DataSet();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal).Value = decMasterId;
                sqlda.Fill(dsData);
            }
            catch (Exception)
            {
                throw;
            }
            return dsData;
        }
    }
}
