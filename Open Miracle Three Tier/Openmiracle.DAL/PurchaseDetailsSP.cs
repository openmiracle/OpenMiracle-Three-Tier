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
//Summary description for PurchaseDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PurchaseDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseDetails Table
        /// </summary>
        /// <param name="purchasedetailsinfo"></param>
        public void PurchaseDetailsAdd(PurchaseDetailsInfo purchasedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.ReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchasedetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasedetailsinfo.Extra2;
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
        /// Function to Update values in PurchaseDetails Table
        /// </summary>
        /// <param name="purchasedetailsinfo"></param>
        public void PurchaseDetailsEdit(PurchaseDetailsInfo purchasedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.PurchaseDetailsId;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@receiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.ReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@orderDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.OrderDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchasedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchasedetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasedetailsinfo.Extra2;
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
        /// Function to get all the values from PurchaseDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseDetailsViewAll", sqlcon);
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
        /// Function to get particular values from PurchaseDetails table based on the parameter
        /// </summary>
        /// <param name="purchaseDetailsId"></param>
        /// <returns></returns>
        public PurchaseDetailsInfo PurchaseDetailsView(decimal purchaseDetailsId)
        {
            PurchaseDetailsInfo purchasedetailsinfo = new PurchaseDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchaseDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchasedetailsinfo.PurchaseDetailsId = decimal.Parse(sdrreader[0].ToString());
                    purchasedetailsinfo.PurchaseMasterId = decimal.Parse(sdrreader[1].ToString());
                    purchasedetailsinfo.ReceiptDetailsId = decimal.Parse(sdrreader[2].ToString());
                    purchasedetailsinfo.OrderDetailsId = decimal.Parse(sdrreader[3].ToString());
                    purchasedetailsinfo.ProductId = decimal.Parse(sdrreader[4].ToString());
                    purchasedetailsinfo.Qty = decimal.Parse(sdrreader[5].ToString());
                    purchasedetailsinfo.Rate = decimal.Parse(sdrreader[6].ToString());
                    purchasedetailsinfo.UnitId = decimal.Parse(sdrreader[7].ToString());
                    purchasedetailsinfo.UnitConversionId = decimal.Parse(sdrreader[8].ToString());
                    purchasedetailsinfo.Discount = decimal.Parse(sdrreader[9].ToString());
                    purchasedetailsinfo.TaxId = decimal.Parse(sdrreader[10].ToString());
                    purchasedetailsinfo.BatchId = decimal.Parse(sdrreader[11].ToString());
                    purchasedetailsinfo.GodownId = decimal.Parse(sdrreader[12].ToString());
                    purchasedetailsinfo.RackId = decimal.Parse(sdrreader[13].ToString());
                    purchasedetailsinfo.TaxAmount = decimal.Parse(sdrreader[14].ToString());
                    purchasedetailsinfo.GrossAmount = decimal.Parse(sdrreader[15].ToString());
                    purchasedetailsinfo.NetAmount = decimal.Parse(sdrreader[16].ToString());
                    purchasedetailsinfo.Amount = decimal.Parse(sdrreader[17].ToString());
                    purchasedetailsinfo.SlNo = int.Parse(sdrreader[18].ToString());
                    purchasedetailsinfo.PurchaseDetailsId = decimal.Parse(sdrreader[19].ToString());
                    purchasedetailsinfo.ExtraDate = DateTime.Parse(sdrreader[20].ToString());
                    purchasedetailsinfo.Extra1 = sdrreader[21].ToString();
                    purchasedetailsinfo.Extra2 = sdrreader[22].ToString();
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
            return purchasedetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PurchaseDetailsId"></param>
        public void PurchaseDetailsDelete(decimal PurchaseDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseDetailsId;
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
        /// Function to  get the next id for PurchaseDetails table
        /// </summary>
        /// <returns></returns>
        public int PurchaseDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsMax", sqlcon);
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
        /// Function to get particular values from PurchaseDetails table based on purchasemasterid with pending quantity
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decPurchaseReturnMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decimal decPurchaseMasterId, decimal decPurchaseReturnMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("PurchaseDetailsViewByPurchaseMasterIdWithRemaining", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decPurchaseReturnMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
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
        /// Function to get particular values from PurchaseDetails table by productcode
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseDetailsViewByProductCodeForPI(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByProductCodeForPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from PurchaseDetails table by productName
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseDetailsViewByProductNameForPI(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByProductNameForPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from PurchaseDetails table by Barcode
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseDetailsViewByBarcodeForPI(decimal decVoucherTypeId, string strBarcode)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByBarcodeForPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strBarcode;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from PurchaseDetails table by purchasemasterid
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseDetailsViewByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseDetailsViewByPurchaseMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to delete from PurchaseDetails table by PurchaseMasterId
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        public void PurchaseDetailsDeleteByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseDetailsDeleteByPurchaseMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
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
        /// Function to get details for vouchertype combobox for purchase invoice
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeComboFillForPurchaseInvoice()
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
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForPurchaseInvoice", sqlcon);
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
    }
}
