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
//Summary description for SalesOrderDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SalesOrderDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesOrderDetails Table
        /// </summary>
        /// <param name="salesorderdetailsinfo"></param>
        public void SalesOrderDetailsAdd(SalesOrderDetailsInfo salesorderdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.SalesOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.QuotationDetailsId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesorderdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesorderdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesorderdetailsinfo.Extra2;
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
        /// Function to Update values in SalesOrderDetails Table
        /// </summary>
        /// <param name="salesorderdetailsinfo"></param>
        public void SalesOrderDetailsEdit(SalesOrderDetailsInfo salesorderdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.SalesOrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.SalesOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.QuotationDetailsId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesorderdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = salesorderdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesorderdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesorderdetailsinfo.Extra2;
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
        /// Function to get all the values from SalesOrderDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesOrderDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesOrderDetailsViewAll", sqlcon);
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
        /// Function to get particular values from SalesOrderDetails Table based on the parameter
        /// </summary>
        /// <param name="salesOrderDetailsId"></param>
        /// <returns></returns>
        public SalesOrderDetailsInfo SalesOrderDetailsView(decimal salesOrderDetailsId)
        {
            SalesOrderDetailsInfo salesorderdetailsinfo = new SalesOrderDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesOrderDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesorderdetailsinfo.SalesOrderDetailsId = decimal.Parse(sdrreader[0].ToString());
                    salesorderdetailsinfo.SalesOrderMasterId = decimal.Parse(sdrreader[1].ToString());
                    salesorderdetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    salesorderdetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    salesorderdetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    salesorderdetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    salesorderdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    salesorderdetailsinfo.Amount = decimal.Parse(sdrreader[7].ToString());
                    salesorderdetailsinfo.QuotationDetailsId = decimal.Parse(sdrreader[8].ToString());
                    salesorderdetailsinfo.SlNo = int.Parse(sdrreader[9].ToString());
                    salesorderdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[10].ToString());
                    salesorderdetailsinfo.Extra1 = sdrreader[11].ToString();
                    salesorderdetailsinfo.Extra2 = sdrreader[12].ToString();
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
            return salesorderdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesOrderDetailsId"></param>
        public void SalesOrderDetailsDelete(decimal SalesOrderDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalesOrderDetailsId;
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
        /// Function to delete particular details based on the parameter and return status
        /// </summary>
        /// <param name="SalesOrderDetailsId"></param>
        /// <returns></returns>
        public decimal SalesOrderDetailsDeletee(decimal SalesOrderDetailsId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsDeletee", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalesOrderDetailsId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
                if (ineffeftedRow > 0)
                {
                    decResult = 1;
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
        /// Function to  get the next id for SalesOrderDetails Table
        /// </summary>
        /// <returns></returns>
        public int SalesOrderDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesOrderDetailsMax", sqlcon);
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
        /// Function for SalesInvoice Gridfill Againest SalesOrder Using SalesDetails
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <param name="salesMasterId"></param>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails(decimal decSalesOrderMasterId, decimal salesMasterId, decimal voucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesOrderMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = salesMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check reference of salesorder for edit
        /// </summary>
        /// <param name="decSalesOrderDetailsId"></param>
        /// <returns></returns>
        public bool SalesOrderRefererenceCheckForEditDetails(decimal decSalesOrderDetailsId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesOrderRefererenceCheckForEditDetails", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salesOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decSalesOrderDetailsId;
                isEdit = Convert.ToBoolean(sqlcmd.ExecuteScalar());
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
        /// Function for SalesOrder Details View By SalesOrder MasterId With Remaining 
        /// </summary>
        /// <param name="decsalesOrderMasterId"></param>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(decimal decsalesOrderMasterId, decimal decDeliveryNoteMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decsalesOrderMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decDeliveryNoteMasterId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNOrder" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function for SalesOrder Details View By MasterId
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesOrderDetailsViewByMasterId(decimal decSalesOrderMasterId)
        {
            List<DataTable> ListOb = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("SalesOrderDetailsViewByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal).Value = decSalesOrderMasterId;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListOb.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListOb;
        }
        public DataTable VoucherNoCombofillforSalesOrderReport()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("VoucherNoCombofillforSalesOrderReport", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                DataRow dr = dtbl.NewRow();
                dr["salesOrderMasterId"] = 0;
                dr["invoiceNo"] = "All";
                dtbl.Rows.InsertAt(dr, 0);
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
        public SalesOrderDetailsInfo QuantityEditingAfterCheckingSalesQuotationForSalesOrder(decimal decSalesOrderId, decimal decProductId)
        {
            SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
            SqlDataReader sdrReader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("QuantityEditingAfterCheckingSalesQuotationForSalesOrder", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decSalesOrderId;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sdrReader = sqlcmd.ExecuteReader();
                while (sdrReader.Read())
                {
                    infoSalesOrderDetails.Qty = Convert.ToDecimal(sdrReader["Qty"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrReader.Close();
                sqlcon.Close();
            }
            return infoSalesOrderDetails;
        }
        /// <summary>
        /// Function for VoucherType Combofill for SalesOrder Report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeCombofillforSalesOrderReport()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforSalesOrderReport", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                DataRow dr = ListObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
    }
}
