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
//Summary description for PurchaseReturnDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PurchaseReturnDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to accountgroup Table
        /// </summary>
        /// <param name="purchasereturndetailsinfo"></param>
        public void PurchaseReturnDetailsAdd(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseReturnDetailsId;
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchasereturndetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturndetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra2;
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
        /// Function to Update values in accountgroup Table
        /// </summary>
        /// <param name="purchasereturndetailsinfo"></param>
        public void PurchaseReturnDetailsEdit(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseReturnDetailsId;
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchasereturndetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturndetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra2;
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
        /// Function to get all the values from accountgroup Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseReturnDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnDetailsViewAll", sqlcon);
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
        /// Function to get particular values from accountgroup Table based on the parameter
        /// </summary>
        /// <param name="purchaseReturnDetailsId"></param>
        /// <returns></returns>
        public PurchaseReturnDetailsInfo PurchaseReturnDetailsView(decimal purchaseReturnDetailsId)
        {
            PurchaseReturnDetailsInfo purchasereturndetailsinfo = new PurchaseReturnDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchaseReturnDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchasereturndetailsinfo.PurchaseReturnDetailsId = decimal.Parse(sdrreader[0].ToString());
                    purchasereturndetailsinfo.PurchaseReturnMasterId = decimal.Parse(sdrreader[1].ToString());
                    purchasereturndetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    purchasereturndetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    purchasereturndetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    purchasereturndetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    purchasereturndetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    purchasereturndetailsinfo.Discount = decimal.Parse(sdrreader[7].ToString());
                    purchasereturndetailsinfo.TaxId = decimal.Parse(sdrreader[8].ToString());
                    purchasereturndetailsinfo.BatchId = decimal.Parse(sdrreader[9].ToString());
                    purchasereturndetailsinfo.GodownId = decimal.Parse(sdrreader[10].ToString());
                    purchasereturndetailsinfo.RackId = decimal.Parse(sdrreader[11].ToString());
                    purchasereturndetailsinfo.TaxAmount = decimal.Parse(sdrreader[12].ToString());
                    purchasereturndetailsinfo.GrossAmount = decimal.Parse(sdrreader[13].ToString());
                    purchasereturndetailsinfo.NetAmount = decimal.Parse(sdrreader[14].ToString());
                    purchasereturndetailsinfo.Amount = decimal.Parse(sdrreader[15].ToString());
                    purchasereturndetailsinfo.SlNo = int.Parse(sdrreader[16].ToString());
                    purchasereturndetailsinfo.ExtraDate = DateTime.Parse(sdrreader[17].ToString());
                    purchasereturndetailsinfo.Extra1 = sdrreader[18].ToString();
                    purchasereturndetailsinfo.Extra2 = sdrreader[19].ToString();
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
            return purchasereturndetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table BankReconciliation
        /// </summary>
        /// <param name="PurchaseReturnDetailsId"></param>
        public void PurchaseReturnDetailsDelete(decimal PurchaseReturnDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnDetailsId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseReturnDetailsId;
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
        /// Function to  get the next id for AdditionalCost Table
        /// </summary>
        /// <returns></returns>
        public int PurchaseReturnDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsMax", sqlcon);
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
        /// Function to insert values to accountgroup Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="purchasereturndetailsinfo"></param>
        /// <returns></returns>
        public decimal PurchaseReturnDetailsAddWithReturnIdentity(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.PurchaseDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@discount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Discount;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@grossAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.GrossAmount;
                sprmparam = sccmd.Parameters.Add("@netAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.NetAmount;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = purchasereturndetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = purchasereturndetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasereturndetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasereturndetailsinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to get the PurchaseReturn Details  By Purchase return MasterId
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnDetailsViewByMasterId(decimal decPurchaseReturnMasterId)
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
                SqlCommand sqlcmd = new SqlCommand("PurchaseReturnDetailsViewByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal).Value = decPurchaseReturnMasterId;
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
        /// FUnction to use the Vouchertype combofill for purchase return
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeComboFillForPurchaseReturn()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForPurchaseReturn", sqlcon);
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
        /// Function to use the PurchaseReturn Details Qty View By PurchaseDetailsId for Purchase Invoice
        /// </summary>
        /// <param name="decPurchaseDetailsId"></param>
        /// <returns></returns>
        public decimal PurchaseReturnDetailsQtyViewByPurchaseDetailsId(decimal decPurchaseDetailsId)
        {
            decimal decQty = 0;
            object objQty = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseReturnDetailsQtyViewByPurchaseDetailsId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseDetailsId;
                objQty = sccmd.ExecuteScalar();
                if (objQty != null)
                {
                    decQty = Convert.ToDecimal(objQty.ToString());
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
            return decQty;
        }
    }
}
