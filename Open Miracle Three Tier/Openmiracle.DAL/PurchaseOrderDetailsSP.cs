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
//Summary description for PurchaseOrderDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PurchaseOrderDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseOrderDetails Table
        /// </summary>
        /// <param name="purchaseorderdetailsinfo"></param>
        public void PurchaseOrderDetailsAdd(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.PurchaseOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchaseorderdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchaseorderdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchaseorderdetailsinfo.Extra2;
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
        /// Function to Update values in PurchaseOrderDetails Table
        /// </summary>
        /// <param name="purchaseorderdetailsinfo"></param>
        public void PurchaseOrderDetailsEdit(PurchaseOrderDetailsInfo purchaseorderdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.PurchaseOrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.PurchaseOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchaseorderdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchaseorderdetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchaseorderdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchaseorderdetailsinfo.Extra2;
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
        /// Function to get all the values from PurchaseOrderDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseOrderDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseOrderDetailsViewAll", sqlcon);
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
        /// Function to get particular values from PurchaseOrderDetails Table based on the parameter
        /// </summary>
        /// <param name="purchaseOrderDetailsId"></param>
        /// <returns></returns>
        public PurchaseOrderDetailsInfo PurchaseOrderDetailsView(decimal purchaseOrderDetailsId)
        {
            PurchaseOrderDetailsInfo purchaseorderdetailsinfo = new PurchaseOrderDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchaseOrderDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchaseorderdetailsinfo.PurchaseOrderDetailsId = decimal.Parse(sdrreader[0].ToString());
                    purchaseorderdetailsinfo.PurchaseOrderMasterId = decimal.Parse(sdrreader[1].ToString());
                    purchaseorderdetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    purchaseorderdetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    purchaseorderdetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    purchaseorderdetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    purchaseorderdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    purchaseorderdetailsinfo.Amount = decimal.Parse(sdrreader[7].ToString());
                    purchaseorderdetailsinfo.SlNo = int.Parse(sdrreader[8].ToString());
                    purchaseorderdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[9].ToString());
                    purchaseorderdetailsinfo.Extra1 = sdrreader[10].ToString();
                    purchaseorderdetailsinfo.Extra2 = sdrreader[11].ToString();
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
            return purchaseorderdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table PurchaseOrderDetails
        /// </summary>
        /// <param name="PurchaseOrderDetailsId"></param>
        /// <returns></returns>
        public decimal PurchaseOrderDetailsDelete(decimal PurchaseOrderDetailsId)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseOrderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseOrderDetailsId;
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
        /// Function to  get the next id for PurchaseOrderDetails Table
        /// </summary>
        /// <returns></returns>
        public int PurchaseOrderDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseOrderDetailsMax", sqlcon);
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
        /// PurchaseOrder Details View By PurchaseOrder MasterId
        /// </summary>
        /// <param name="decpurchaseOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderDetailsViewByMasterId(decimal decpurchaseOrderMasterId)
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
                SqlCommand sqlcmd = new SqlCommand("PurchaseOrderDetailsViewByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal).Value = decpurchaseOrderMasterId;
                sdaadapter.SelectCommand = sqlcmd;
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
        /// Purchase Order Details View With Remaining qty
        /// </summary>
        /// <param name="decpurchaseOrderMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderDetailsViewWithRemaining(decimal decpurchaseOrderMasterId)
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
                SqlCommand sqlcmd = new SqlCommand("PurchaseOrderDetailsViewWithRemaining", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal).Value = decpurchaseOrderMasterId;
                sdaadapter.SelectCommand = sqlcmd;
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
        /// VoucherType Combofill function for Purchase OrderReport 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeCombofillforPurchaseOrderReport()
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
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeCombofillforPurchaseOrderReport", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                DataRow dr = ListObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "NA";
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
        /// PurchaseOrder Details View By PurchaseOrder MasterId With Remaining qty
        /// </summary>
        /// <param name="decOrderMasterId"></param>
        /// <param name="decReceiptMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemaining(decimal decOrderMasterId, decimal decReceiptMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemaining", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decOrderMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decReceiptMasterId;
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
        /// PurchaseOrder Details View By Purchase Order MasterId With Remaining Qty For Purchase Invoice
        /// </summary>
        /// <param name="decPurchaseOrderMasterId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI(decimal decPurchaseOrderMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemainingByNotInCurrPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseOrderMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseMasterId;
                sqlparameter = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
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
        /// PurchaseOrder Details View By Purchase Order MasterId With Remaining For Updation
        /// </summary>
        /// <param name="decOrderMasterId"></param>
        /// <param name="decReceiptMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit(decimal decOrderMasterId, decimal decReceiptMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decOrderMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decReceiptMasterId;
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
    }
}
