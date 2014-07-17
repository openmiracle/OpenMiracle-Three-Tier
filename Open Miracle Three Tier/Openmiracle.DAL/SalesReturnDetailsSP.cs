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
//Summary description for SalesReturnDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SalesReturnDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesReturnDetails Table
        /// </summary>
        /// <param name="salesreturndetailsinfo"></param>
        /// <returns></returns>
        public decimal SalesReturnDetailsAdd(SalesReturnDetailsInfo salesreturndetailsinfo)
        {
            decimal decSalesReturnDetailsId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.SalesReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesreturndetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.SalesDetailsId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturndetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturndetailsinfo.Extra2;
                decSalesReturnDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decSalesReturnDetailsId;
        }
        /// <summary>
        /// Function to Update values in SalesReturnDetails Table
        /// </summary>
        /// <param name="salesreturndetailsinfo"></param>
        public void SalesReturnDetailsEdit(SalesReturnDetailsInfo salesreturndetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.SalesReturnDetailsId;
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.SalesReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@salesDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.SalesDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesreturndetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesreturndetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturndetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturndetailsinfo.Extra2;
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
        /// Function to get all the values from SalesReturnDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesReturnDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnDetailsViewAll", sqlcon);
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
        /// Function to get particular values from SalesReturnDetails Table based on the parameter
        /// </summary>
        /// <param name="salesReturnDetailsId"></param>
        /// <returns></returns>
        public SalesReturnDetailsInfo SalesReturnDetailsView(decimal salesReturnDetailsId)
        {
            SalesReturnDetailsInfo salesreturndetailsinfo = new SalesReturnDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesReturnDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesreturndetailsinfo.SalesReturnDetailsId = decimal.Parse(sdrreader[0].ToString());
                    salesreturndetailsinfo.SalesReturnMasterId = decimal.Parse(sdrreader[1].ToString());
                    salesreturndetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    salesreturndetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    salesreturndetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    salesreturndetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    salesreturndetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    salesreturndetailsinfo.Discount = decimal.Parse(sdrreader[7].ToString());
                    salesreturndetailsinfo.TaxId = decimal.Parse(sdrreader[8].ToString());
                    salesreturndetailsinfo.BatchId = decimal.Parse(sdrreader[9].ToString());
                    salesreturndetailsinfo.GodownId = decimal.Parse(sdrreader[10].ToString());
                    salesreturndetailsinfo.RackId = decimal.Parse(sdrreader[11].ToString());
                    salesreturndetailsinfo.TaxAmount = decimal.Parse(sdrreader[12].ToString());
                    salesreturndetailsinfo.GrossAmount = decimal.Parse(sdrreader[13].ToString());
                    salesreturndetailsinfo.NetAmount = decimal.Parse(sdrreader[14].ToString());
                    salesreturndetailsinfo.Amount = decimal.Parse(sdrreader[15].ToString());
                    salesreturndetailsinfo.SlNo = int.Parse(sdrreader[16].ToString());
                    salesreturndetailsinfo.SalesDetailsId = decimal.Parse(sdrreader[17].ToString());
                    salesreturndetailsinfo.ExtraDate = DateTime.Parse(sdrreader[18].ToString());
                    salesreturndetailsinfo.Extra1 = sdrreader[19].ToString();
                    salesreturndetailsinfo.Extra2 = sdrreader[20].ToString();
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
            return salesreturndetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesReturnDetailsId"></param>
        public void SalesReturnDetailsDelete(decimal SalesReturnDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalesReturnDetailsId;
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
        /// Function to  get the next id for SalesReturnDetails Table
        /// </summary>
        /// <returns></returns>
        public int SalesReturnDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnDetailsMax", sqlcon);
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
        ///  Function to get particular values  based on the parameter
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesReturnDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesReturnDetailsViewBySalesReturnMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesReturnMasterId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OPen Tally", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// FnctionToGetProductDetaliesInBArcode
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <param name="vouchertypeId"></param>
        /// <returns></returns>
        public List<DataTable> productviewbybarcodeforSR(string strProductCode, decimal vouchertypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("productviewbybarcodeforSR", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
    }
}
