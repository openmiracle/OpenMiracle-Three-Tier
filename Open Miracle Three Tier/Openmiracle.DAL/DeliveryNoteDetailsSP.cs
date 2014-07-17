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
//Summary description for DeliveryNoteDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class DeliveryNoteDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DeliveryNoteDetails Table
        /// </summary>
        /// <param name="deliverynotedetailsinfo"></param>
        public void DeliveryNoteDetailsAdd(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@orderDetails1Id", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.OrderDetails1Id;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@quotationDetails1Id", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.QuotationDetails1Id;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = deliverynotedetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = deliverynotedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = deliverynotedetailsinfo.Extra2;
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
        /// Function to Update values in DeliveryNoteDetails Table
        /// </summary>
        /// <param name="deliverynotedetailsinfo"></param>
        public void DeliveryNoteDetailsEdit(DeliveryNoteDetailsInfo deliverynotedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.DeliveryNoteDetails1Id;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@orderDetails1Id", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.OrderDetails1Id;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@quotationDetails1Id", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.QuotationDetails1Id;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotedetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = deliverynotedetailsinfo.SlNo;
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
        /// Function to get all the values from DeliveryNoteDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable DeliveryNoteDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteDetailsViewAll", sqlcon);
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
        /// Function to get particular values from DeliveryNoteDetails table based on the parameter
        /// </summary>
        /// <param name="deliveryNoteDetails1Id"></param>
        /// <returns></returns>
        public DeliveryNoteDetailsInfo DeliveryNoteDetailsView(decimal deliveryNoteDetails1Id)
        {
            DeliveryNoteDetailsInfo deliverynotedetailsinfo = new DeliveryNoteDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetails1Id", SqlDbType.Decimal);
                sprmparam.Value = deliveryNoteDetails1Id;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    deliverynotedetailsinfo.DeliveryNoteDetails1Id = decimal.Parse(sdrreader[0].ToString());
                    deliverynotedetailsinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader[1].ToString());
                    deliverynotedetailsinfo.OrderDetails1Id = decimal.Parse(sdrreader[2].ToString());
                    deliverynotedetailsinfo.ProductId = decimal.Parse(sdrreader[3].ToString());
                    deliverynotedetailsinfo.Qty = decimal.Parse(sdrreader[4].ToString());
                    deliverynotedetailsinfo.Rate = decimal.Parse(sdrreader[5].ToString());
                    deliverynotedetailsinfo.UnitId = decimal.Parse(sdrreader[6].ToString());
                    deliverynotedetailsinfo.UnitConversionId = decimal.Parse(sdrreader[7].ToString());
                    deliverynotedetailsinfo.Amount = decimal.Parse(sdrreader[8].ToString());
                    deliverynotedetailsinfo.QuotationDetails1Id = decimal.Parse(sdrreader[9].ToString());
                    deliverynotedetailsinfo.BatchId = decimal.Parse(sdrreader[10].ToString());
                    deliverynotedetailsinfo.GodownId = decimal.Parse(sdrreader[11].ToString());
                    deliverynotedetailsinfo.RackId = decimal.Parse(sdrreader[12].ToString());
                    deliverynotedetailsinfo.SlNo = int.Parse(sdrreader[13].ToString());
                    deliverynotedetailsinfo.ExtraDate = DateTime.Parse(sdrreader[14].ToString());
                    deliverynotedetailsinfo.Extra1 = sdrreader[15].ToString();
                    deliverynotedetailsinfo.Extra2 = sdrreader[16].ToString();
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
            return deliverynotedetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="DeliveryNoteDetailsId"></param>
        /// <returns></returns>
        public decimal DeliveryNoteDetailsDelete(decimal DeliveryNoteDetailsId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = DeliveryNoteDetailsId;
                int ineffectedRow = Convert.ToInt32(sccmd.ExecuteNonQuery().ToString());
                if (ineffectedRow > 0)
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
        /// Function to  get the next id for DeliveryNoteDetails table
        /// </summary>
        /// <returns></returns>
        public int DeliveryNoteDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteDetailsMax", sqlcon);
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
        /// Function to get values of pending based on parameters
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <param name="decRejectionInMasterId"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(decimal decDeliveryNoteMasterId, decimal decRejectionInMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                //DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparam.Value = decDeliveryNoteMasterId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sqlparam.Value = decRejectionInMasterId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get values of Sales based on DeliveryNote with parameters passed
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <param name="SIMasterId"></param>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails(decimal decDeliveryNoteMasterId, decimal SIMasterId, decimal voucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decDeliveryNoteMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = SIMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = voucherTypeId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view DeliveryNote Details based on parameter
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteDetailsViewByDeliveryNoteMasterId(decimal decDeliveryNoteMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteDetailsViewByDeliveryNoteMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decDeliveryNoteMasterId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get Quantity details based on parameters
        /// </summary>
        /// <param name="decDeliveryNoteId"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public DeliveryNoteDetailsInfo QuantityEditingAfterCheckingSalesAndRejectionInForDeliveryNote(decimal decDeliveryNoteId, decimal decProductId)
        {
            DeliveryNoteDetailsInfo infoDeliveryNoteDetails = new DeliveryNoteDetailsInfo();
            SqlDataReader sdrReader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("QuantityEditingAfterCheckingSalesAndRejectionInForDeliveryNote", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDeliveryNoteId;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sdrReader = sqlcmd.ExecuteReader();
                while (sdrReader.Read())
                {
                    infoDeliveryNoteDetails.Qty = Convert.ToDecimal(sdrReader["Qty"].ToString());
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
            return infoDeliveryNoteDetails;
        }
    }
}
