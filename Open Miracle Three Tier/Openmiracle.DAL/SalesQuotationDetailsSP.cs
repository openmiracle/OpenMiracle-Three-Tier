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
//Summary description for SalesQuotationDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class SalesQuotationDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesQuotationDetails Table
        /// </summary>
        /// <param name="salesquotationdetailsinfo"></param>
        public void SalesQuotationDetailsAdd(SalesQuotationDetailsInfo salesquotationdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = salesquotationdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesquotationdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesquotationdetailsinfo.Extra2;
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
        /// Function to Update values in SalesQuotationDetails Table
        /// </summary>
        /// <param name="salesquotationdetailsinfo"></param>
        public void SalesQuotationDetailsEdit(SalesQuotationDetailsInfo salesquotationdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.QuotationDetailsId;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = salesquotationdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = salesquotationdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesquotationdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesquotationdetailsinfo.Extra2;
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
        /// Function to get all the values from SalesQuotationDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesQuotationDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationDetailsViewAll", sqlcon);
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
        /// Function for VoucherType Combofill for SalesQuotation Report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeCombofillforSalesQuotationReport()
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
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforSalesQuotationReport", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                DataRow dr = ListObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
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
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from SalesQuotationDetails Table based on the parameter
        /// </summary>
        /// <param name="quotationDetailsId"></param>
        /// <returns></returns>
        public SalesQuotationDetailsInfo SalesQuotationDetailsView(decimal quotationDetailsId)
        {
            SalesQuotationDetailsInfo salesquotationdetailsinfo = new SalesQuotationDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = quotationDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesquotationdetailsinfo.QuotationDetailsId = Convert.ToDecimal(sdrreader[0].ToString());
                    salesquotationdetailsinfo.QuotationMasterId = Convert.ToDecimal(sdrreader[1].ToString());
                    salesquotationdetailsinfo.ProductId = Convert.ToDecimal(sdrreader[2].ToString());
                    salesquotationdetailsinfo.UnitId = Convert.ToDecimal(sdrreader[3].ToString());
                    salesquotationdetailsinfo.UnitConversionId = Convert.ToDecimal(sdrreader[4].ToString());
                    salesquotationdetailsinfo.Qty = Convert.ToDecimal(sdrreader[5].ToString());
                    salesquotationdetailsinfo.Rate = Convert.ToDecimal(sdrreader[6].ToString());
                    salesquotationdetailsinfo.Amount = Convert.ToDecimal(sdrreader[7].ToString());
                    salesquotationdetailsinfo.Slno = int.Parse(sdrreader[8].ToString());
                    salesquotationdetailsinfo.Extra1 = sdrreader[11].ToString();
                    salesquotationdetailsinfo.Extra2 = sdrreader[12].ToString();
                    salesquotationdetailsinfo.BatchId = Convert.ToDecimal(sdrreader[13].ToString());
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
            return salesquotationdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="QuotationDetailsId"></param>
        /// <returns></returns>
        public decimal SalesQuotationDetailsDelete(decimal QuotationDetailsId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = QuotationDetailsId;
                int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
                if (ineffectedRow > 0)
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
        public bool SalesQuotationRefererenceCheckForEditDetails(decimal decSalesQuotationDetailsId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesQuotationRefererenceCheckForEditDetails", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@quotationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decSalesQuotationDetailsId;
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
        /// Function to get all details based on parameter
        /// </summary>
        /// <param name="decSalesQuotationMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationDetailsViewByMasterId(decimal decSalesQuotationMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesQuotationDetailsViewByMasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal).Value = decSalesQuotationMasterId;
                sdaadapter.Fill(dtbl);
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
        /// Function to  get the next id for SalesQuotationDetails table
        /// </summary>
        /// <returns></returns>
        public int SalesQuotationDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesQuotationDetailsMax", sqlcon);
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
        /// Function for  UnitconversionId view By UnitId And ProductId and return id
        /// </summary>
        /// <param name="unitId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public decimal UnitconversionIdViewByUnitIdAndProductId(decimal unitId, decimal productId)
        {
            decimal decValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("UnitconversionIdViewByUnitIdAndProductId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitId;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productId;
                decValue = Convert.ToDecimal(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decValue;
        }
        /// <summary>
        /// Function for SalesQuotation Details View By quotationMasterId With Remaining By SalesOrder
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <param name="decSalesOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO(decimal decQuotationMasterId, decimal decSalesOrderMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesOrderMasterId;
                sqldataadapter.Fill(dtbl);
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
        /// Function for SalesQuotation Details View By quotationMasterId With Remaining By Not In Current DeliveryNote
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <param name="decDeliveryNoteId"></param>
        /// <returns></returns>
        public List<DataTable> SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(decimal decQuotationMasterId, decimal decDeliveryNoteId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decDeliveryNoteId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function for SalesInvoice Gridfill Againest Quotation Using QuotationDetails
        /// </summary>
        /// <param name="decQuotationMasterId"></param>
        /// <param name="salesOrderMasterId"></param>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails(decimal decQuotationMasterId, decimal salesOrderMasterId, decimal voucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decQuotationMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = salesOrderMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqldataadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        public decimal SalesQuatationReferenceCheck(decimal decSalesQuotationDeatilsId)
        {
            decimal decQty = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalesQuatationReferenceCheck", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salesQuatationDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decSalesQuotationDeatilsId;
                decQty = Convert.ToDecimal(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return decQty;
        }
    }
}
