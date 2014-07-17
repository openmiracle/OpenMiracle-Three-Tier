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
//Summary description for StockPostingSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class StockPostingSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to StockPosting Table
        /// </summary>
        /// <param name="stockpostinginfo"></param>
        /// <returns></returns>
        public decimal StockPostingAdd(StockPostingInfo stockpostinginfo)
        {
            decimal decProductId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = stockpostinginfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.RackId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.AgainstVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.AgainstInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.AgainstVoucherNo;
                sprmparam = sccmd.Parameters.Add("@inwardQty", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.InwardQty;
                sprmparam = sccmd.Parameters.Add("@outwardQty", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.OutwardQty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.Rate;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.Extra2;
                decProductId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decProductId;
        }
        /// <summary>
        /// Function to Update values in StockPosting Table
        /// </summary>
        /// <param name="stockpostinginfo"></param>
        /// <returns></returns>
        public bool StockPostingEdit(StockPostingInfo stockpostinginfo)
        {
            decimal decresult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.StockPostingId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = stockpostinginfo.Date;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.RackId;
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.AgainstVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.AgainstInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.AgainstVoucherNo;
                sprmparam = sccmd.Parameters.Add("@inwardQty", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.InwardQty;
                sprmparam = sccmd.Parameters.Add("@outwardQty", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.OutwardQty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.Rate;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = stockpostinginfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = stockpostinginfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = stockpostinginfo.Extra2;
                decresult = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            if (decresult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Function to get all the values from StockPosting Table
        /// </summary>
        /// <returns></returns>
        public DataTable StockPostingViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("StockPostingViewAll", sqlcon);
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
        /// Function to get particular values from StockPosting Table based on the parameter
        /// </summary>
        /// <param name="stockPostingId"></param>
        /// <returns></returns>
        public StockPostingInfo StockPostingView(decimal stockPostingId)
        {
            StockPostingInfo stockpostinginfo = new StockPostingInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
                sprmparam.Value = stockPostingId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    stockpostinginfo.StockPostingId = decimal.Parse(sdrreader[0].ToString());
                    stockpostinginfo.Date = DateTime.Parse(sdrreader[1].ToString());
                    stockpostinginfo.VoucherTypeId = decimal.Parse(sdrreader[2].ToString());
                    stockpostinginfo.VoucherNo = sdrreader[3].ToString();
                    stockpostinginfo.InvoiceNo = sdrreader[4].ToString();
                    stockpostinginfo.ProductId = decimal.Parse(sdrreader[5].ToString());
                    stockpostinginfo.BatchId = decimal.Parse(sdrreader[6].ToString());
                    stockpostinginfo.UnitId = decimal.Parse(sdrreader[7].ToString());
                    stockpostinginfo.GodownId = decimal.Parse(sdrreader[8].ToString());
                    stockpostinginfo.RackId = decimal.Parse(sdrreader[9].ToString());
                    stockpostinginfo.AgainstVoucherTypeId = decimal.Parse(sdrreader[10].ToString());
                    stockpostinginfo.AgainstInvoiceNo = sdrreader[11].ToString();
                    stockpostinginfo.AgainstVoucherNo = sdrreader[12].ToString();
                    stockpostinginfo.InwardQty = decimal.Parse(sdrreader[13].ToString());
                    stockpostinginfo.OutwardQty = decimal.Parse(sdrreader[14].ToString());
                    stockpostinginfo.Rate = decimal.Parse(sdrreader[15].ToString());
                    stockpostinginfo.FinancialYearId = decimal.Parse(sdrreader[16].ToString());
                    stockpostinginfo.ExtraDate = DateTime.Parse(sdrreader[17].ToString());
                    stockpostinginfo.Extra1 = sdrreader[18].ToString();
                    stockpostinginfo.Extra2 = sdrreader[19].ToString();
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
            return stockpostinginfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="StockPostingId"></param>
        public void StockPostingDelete(decimal StockPostingId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
                sprmparam.Value = StockPostingId;
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
        /// Function to  get the next id for StockPosting Table
        /// </summary>
        /// <returns></returns>
        public int StockPostingGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingMax", sqlcon);
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
        /// Function to Delete stock posting for updation based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        public void StpDeleteForProductUpdation(decimal decProductId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StpDeleteForProductUpdation", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
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
        /// Function to Delete stock posting on row remove based on parameter
        /// </summary>
        /// <param name="decStpId"></param>
        /// <returns></returns>
        public bool StpDeleteForRowRemove(decimal decStpId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StpDeleteForRowRemove", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@stockPostingId", SqlDbType.Decimal);
                sprmparam.Value = decStpId;
                decResult = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            if (decResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Function to get BatchId From StockPosting based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public int ReturnBatchIdFromStockPosting(decimal decProductId)
        {
            int inResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReturnBatchIdFromStockPosting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                inResult = Convert.ToInt32(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inResult;
        }
        /// <summary>
        /// Function to Delete StockPosting based on parameter
        /// </summary>
        /// <param name="decAgnstVouTypeId"></param>
        /// <param name="strAgnstVouNo"></param>
        public void DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decimal decAgnstVouTypeId, string strAgnstVouNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgnstVouTypeId;
                cmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgnstVouNo;
                cmd.ExecuteNonQuery();
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
        /// Function to Delete StockPosting For StockJournal Edit based on parameter
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void DeleteStockPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeleteStockPostingForStockJournalEdit", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                cmd.ExecuteNonQuery();
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
        /// Function to Delete StockPosting against VoucherTypeId And VoucherNo And InvoiceNo based on parameter
        /// </summary>
        /// <param name="decAgainstVoucherTypeId"></param>
        /// <param name="strAgainstVoucherNo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgainstVoucherTypeId;
                sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgainstVoucherNo;
                sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    decResult = 1;
                }
                else
                {
                    decResult = 0;
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
            return decResult;
        }
        /// <summary>
        /// Function to Delete StockPosting By VoucherTypeId And VoucherNo And InvoiceNo based on parameter
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <param name="voucherNo"></param>
        /// <param name="invoiceNo"></param>
        /// <param name="productId"></param>
        public void StockPostingDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo(decimal voucherTypeId, string voucherNo, string invoiceNo, decimal productId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingDeleteByVoucherTypeIdAndVoucherNoAndInvoiceNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = invoiceNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productId;
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
        /// Function to get Product CurrentStock based on parameter 
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decGodownId"></param>
        /// <param name="decBatchId"></param>
        /// <param name="decRackId"></param>
        /// <returns></returns>
        public decimal ProductGetCurrentStock(decimal decProductId, decimal decGodownId, decimal decBatchId, decimal decRackId)
        {
            decimal decStock = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGetCurrentStock", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = decGodownId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = decRackId;
                decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStock;
        }
        /// <summary>
        /// Function to view StockReport for Gridfill based on parameter
        /// </summary>
        /// <param name="strProductName"></param>
        /// <param name="decBrandid"></param>
        /// <param name="decmodelNoId"></param>
        /// <param name="strproductCode"></param>
        /// <param name="decgodownId"></param>
        /// <param name="decrackId"></param>
        /// <param name="decsizeId"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decgrpId"></param>
        /// <returns></returns>
        public List<DataTable> StockReportGridFill1(String strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId,string strBatchName)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("StockReportGridFill1", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal).Value = decBrandid;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decmodelNoId;
                sqlda.SelectCommand.Parameters.Add("@productCode ", SqlDbType.VarChar).Value = strproductCode;
                sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decgodownId;
                sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal).Value = decrackId;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = dectaxId;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgrpId;
                sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar).Value = strBatchName;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPSP:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function for stock report printing based on parameter
        /// </summary>
        /// <param name="strProductName"></param>
        /// <param name="decBrandid"></param>
        /// <param name="decmodelNoId"></param>
        /// <param name="strproductCode"></param>
        /// <param name="decgodownId"></param>
        /// <param name="decrackId"></param>
        /// <param name="decsizeId"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decgrpId"></param>
        /// <returns></returns>
        public DataSet StockReportPrint(string strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId,string strBatchName)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("StockReportCrystalReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlprm = new SqlParameter();
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                sqlprm.Value = decBrandid;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                sqlprm.Value = decmodelNoId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@productCode ", SqlDbType.VarChar);
                sqlprm.Value = strproductCode;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                sqlprm.Value = decgodownId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                sqlprm.Value = decrackId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sqlprm.Value = decsizeId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sqlprm.Value = dectaxId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                sqlprm.Value = decgrpId;
                sqlprm = sqlda.SelectCommand.Parameters.Add("@batchName", SqlDbType.VarChar);
                sqlprm.Value = strBatchName;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPSP:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Function to check Stock For Product Sale based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        /// <returns></returns>
        public decimal StockCheckForProductSale(decimal decProductId, decimal decBatchId)
        {
            decimal decStock = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StocKCheckForProductSale", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStock;
        }
        /// <summary>
        /// Function for Batch View By ProductId
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public decimal BatchViewByProductId(decimal decProductId)
        {
            decimal decStock = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchViewByProductId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStock;
        }
        /// <summary>
        /// Function to delete Stockposting for SalesInvoice Against DeliveryNote based on parameter
        /// </summary>
        /// <param name="decAgainstVoucherTypeId"></param>
        /// <param name="strAgainstVoucherNo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal StockPostingDeleteForSalesInvoiceAgainstDeliveryNote(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingDeleteForSalesInvoiceAgainstDeliveryNote", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decAgainstVoucherTypeId;
                sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strAgainstVoucherNo;
                sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    decResult = 1;
                }
                else
                {
                    decResult = 0;
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
            return decResult;
        }
        /// <summary>
        /// Function to delete stock based on parameter
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void StockPostingDeleteByVoucherTypeAndVoucherNo(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostingDeleteByVoucherTypeAndVoucherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
    }
}