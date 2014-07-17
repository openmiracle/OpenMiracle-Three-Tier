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
//Summary description for StockJournalDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class StockJournalDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to StockJournal Table
        /// </summary>
        /// <param name="stockjournaldetailsinfo"></param>
        public void StockJournalDetailsAdd(StockJournalDetailsInfo stockjournaldetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.StockJournalMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@consumptionOrProduction", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.ConsumptionOrProduction;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = stockjournaldetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = stockjournaldetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.Extra2;
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
        /// Function to Update values in StockJournal Table
        /// </summary>
        /// <param name="stockjournaldetailsinfo"></param>
        public void StockJournalDetailsEdit(StockJournalDetailsInfo stockjournaldetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.StockJournalDetailsId;
                sprmparam = sccmd.Parameters.Add("@stockJournalMasterId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.StockJournalMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = stockjournaldetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@consumptionOrProduction", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.ConsumptionOrProduction;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = stockjournaldetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = stockjournaldetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockjournaldetailsinfo.Extra2;
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
        public DataTable StockJournalDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("StockJournalDetailsViewAll", sqlcon);
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
        /// Function to get particular values from StockJournal Table based on parameter
        /// </summary>
        /// <param name="stockJournalDetailsId"></param>
        /// <returns></returns>
        public StockJournalDetailsInfo StockJournalDetailsView(decimal stockJournalDetailsId)
        {
            StockJournalDetailsInfo stockjournaldetailsinfo = new StockJournalDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
                sprmparam.Value = stockJournalDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    stockjournaldetailsinfo.StockJournalDetailsId = decimal.Parse(sdrreader[0].ToString());
                    stockjournaldetailsinfo.StockJournalMasterId = decimal.Parse(sdrreader[1].ToString());
                    stockjournaldetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    stockjournaldetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    stockjournaldetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    stockjournaldetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    stockjournaldetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    stockjournaldetailsinfo.BatchId = decimal.Parse(sdrreader[7].ToString());
                    stockjournaldetailsinfo.GodownId = decimal.Parse(sdrreader[8].ToString());
                    stockjournaldetailsinfo.RackId = decimal.Parse(sdrreader[9].ToString());
                    stockjournaldetailsinfo.Amount = decimal.Parse(sdrreader[10].ToString());
                    stockjournaldetailsinfo.ConsumptionOrProduction = sdrreader[11].ToString();
                    stockjournaldetailsinfo.Slno = int.Parse(sdrreader[12].ToString());
                    stockjournaldetailsinfo.ExtraDate = DateTime.Parse(sdrreader[13].ToString());
                    stockjournaldetailsinfo.Extra1 = sdrreader[14].ToString();
                    stockjournaldetailsinfo.Extra2 = sdrreader[15].ToString();
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
            return stockjournaldetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="StockJournalDetailsId"></param>
        public void StockJournalDetailsDelete(decimal StockJournalDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockJournalDetailsId", SqlDbType.Decimal);
                sprmparam.Value = StockJournalDetailsId;
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
        /// Function to  get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int StockJournalDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockJournalDetailsMax", sqlcon);
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
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsByProductCode(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsByProductCode", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
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
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsByProductName(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsByProductName", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
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
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public List<DataTable> StockJournalDetailsViewByBarcode(decimal decVoucherTypeId, string strBarcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsViewByBarcode", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strBarcode;
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
        /// Function to get values based on parameter
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public DataSet StockJournalDetailsForRegisterOrReport(decimal decMasterId)
        {
            DataSet dsData = new DataSet();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalDetailsForRegisterOrReport", sqlcon);
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
