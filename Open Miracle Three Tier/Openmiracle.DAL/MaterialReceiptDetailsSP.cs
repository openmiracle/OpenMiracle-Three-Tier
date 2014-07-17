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
//Summary description for MaterialReceiptDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class MaterialReceiptDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to MaterialReceiptDetails Table
        /// </summary>
        /// <param name="materialreceiptdetailsinfo"></param>
        public void MaterialReceiptDetailsAdd(MaterialReceiptDetailsInfo materialreceiptdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = materialreceiptdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@exta2", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptdetailsinfo.Exta2;
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
        /// Function to Update values in MaterialReceiptDetails Table
        /// </summary>
        /// <param name="materialreceiptdetailsinfo"></param>
        public void MaterialReceiptDetailsEdit(MaterialReceiptDetailsInfo materialreceiptdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.MaterialReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = materialreceiptdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@exta2", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptdetailsinfo.Exta2;
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
        /// Function to get all the values from MaterialReceiptDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable MaterialReceiptDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("MaterialReceiptDetailsViewAll", sqlcon);
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
        /// Function to get particular values from MaterialReceiptDetails Table based on the parameter
        /// </summary>
        /// <param name="materialReceiptDetailsId"></param>
        /// <returns></returns>
        public MaterialReceiptDetailsInfo MaterialReceiptDetailsView(decimal materialReceiptDetailsId)
        {
            MaterialReceiptDetailsInfo materialreceiptdetailsinfo = new MaterialReceiptDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = materialReceiptDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    materialreceiptdetailsinfo.MaterialReceiptDetailsId = decimal.Parse(sdrreader[0].ToString());
                    materialreceiptdetailsinfo.MaterialReceiptMasterId = decimal.Parse(sdrreader[1].ToString());
                    materialreceiptdetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    materialreceiptdetailsinfo.OrderDetailsId = decimal.Parse(sdrreader[3].ToString());
                    materialreceiptdetailsinfo.Qty = decimal.Parse(sdrreader[4].ToString());
                    materialreceiptdetailsinfo.Rate = decimal.Parse(sdrreader[5].ToString());
                    materialreceiptdetailsinfo.UnitId = decimal.Parse(sdrreader[6].ToString());
                    materialreceiptdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[7].ToString());
                    materialreceiptdetailsinfo.BatchId = decimal.Parse(sdrreader[8].ToString());
                    materialreceiptdetailsinfo.GodownId = decimal.Parse(sdrreader[9].ToString());
                    materialreceiptdetailsinfo.RackId = decimal.Parse(sdrreader[10].ToString());
                    materialreceiptdetailsinfo.Amount = decimal.Parse(sdrreader[11].ToString());
                    materialreceiptdetailsinfo.Slno = int.Parse(sdrreader[12].ToString());
                    materialreceiptdetailsinfo.Extra1 = sdrreader[14].ToString();
                    materialreceiptdetailsinfo.Exta2 = sdrreader[15].ToString();
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
            return materialreceiptdetailsinfo;
        }
        /// <summary>
        /// Function to  get the next id for MaterialReceiptDetails Table
        /// </summary>
        /// <returns></returns>
        public int MaterialReceiptDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsMax", sqlcon);
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
        /// Function to get MaterialReceipt Details View By MasterId
        /// </summary>
        /// <param name="decMaterialReceiptMasterId"></param>
        /// <returns></returns>
        public List<DataTable>  MaterialReceiptDetailsViewByMasterId(decimal decMaterialReceiptMasterId)
        {
            List<DataTable> ListObl = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("MaterialReceiptDetailsViewByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal).Value = decMaterialReceiptMasterId;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListObl.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObl;
        }
        /// <summary>
        /// Function to get VoucherType Combofill for MaterialReceipt
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeCombofillforMaterialReceipt()
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
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforMaterialReceipt", sqlcon);
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
        /// <summary>
        /// Function Show MaterialReceipt Details View by MaterialReceiptDetails Id With Pending
        /// </summary>
        /// <param name="decmaterialReceiptMasterId"></param>
        /// <param name="decrejectionOutMasterId"></param>
        /// <returns></returns>
        public List<DataTable> ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending(decimal decmaterialReceiptMasterId, decimal decrejectionOutMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decmaterialReceiptMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = decrejectionOutMasterId;
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
        /// Function to MaterialReceiptDetails Delete
        /// </summary>
        /// <param name="MaterialReceiptDetailsId"></param>
        public void MaterialReceiptDetailsDelete(decimal MaterialReceiptDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@detailsId", SqlDbType.Decimal);
                sprmparam.Value = MaterialReceiptDetailsId;
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
        /// Function to get MaterialReceiptDetails View By MaterialReceiptMasterId With Remaining By NotIn Current for Purchase Invoice
        /// </summary>
        /// <param name="decMaterialReceiptMasterId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI(decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
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
