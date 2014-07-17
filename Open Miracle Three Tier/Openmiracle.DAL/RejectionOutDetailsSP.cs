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
//Summary description for RejectionOutDetailsSP    
//</summary>    
namespace OpenMiracle.DAL  
{
    public class RejectionOutDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to RejectionOutDetails Table
        /// </summary>
        /// <param name="rejectionoutdetailsinfo"></param>
        public void RejectionOutDetailsAdd(RejectionOutDetailsInfo rejectionoutdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = rejectionoutdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra2;
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
        /// Function to insert values to RejectionOutDetails Table
        /// </summary>
        /// <param name="rejectionoutdetailsinfo"></param>
        /// <returns></returns>
        public decimal RejectionOutDetailsAddWithReturnIdentity(RejectionOutDetailsInfo rejectionoutdetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = rejectionoutdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra2;
                Object obj = Convert.ToDecimal(sccmd.ExecuteScalar());
                if (obj != null)
                {
                    decIdentity = Convert.ToDecimal(obj);
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
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in RejectionOutDetails Table
        /// </summary>
        /// <param name="rejectionoutdetailsinfo"></param>
        public void RejectionOutDetailsEdit(RejectionOutDetailsInfo rejectionoutdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RejectionOutDetailsId;
                sprmparam = sccmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RejectionOutMasterId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.MaterialReceiptDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = rejectionoutdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = rejectionoutdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rejectionoutdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionoutdetailsinfo.Extra2;
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
        /// Function to get all the values from RejectionOutDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable RejectionOutDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutDetailsViewAll", sqlcon);
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
        /// Function to get particular values from RejectionOutDetails table based on the parameter
        /// </summary>
        /// <param name="rejectionOutDetailsId"></param>
        /// <returns></returns>
        public RejectionOutDetailsInfo RejectionOutDetailsView(decimal rejectionOutDetailsId)
        {
            RejectionOutDetailsInfo rejectionoutdetailsinfo = new RejectionOutDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionOutDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    rejectionoutdetailsinfo.RejectionOutDetailsId = decimal.Parse(sdrreader[0].ToString());
                    rejectionoutdetailsinfo.RejectionOutMasterId = decimal.Parse(sdrreader[1].ToString());
                    rejectionoutdetailsinfo.MaterialReceiptDetailsId = decimal.Parse(sdrreader[2].ToString());
                    rejectionoutdetailsinfo.ProductId = decimal.Parse(sdrreader[3].ToString());
                    rejectionoutdetailsinfo.Qty = decimal.Parse(sdrreader[4].ToString());
                    rejectionoutdetailsinfo.Rate = decimal.Parse(sdrreader[5].ToString());
                    rejectionoutdetailsinfo.UnitId = decimal.Parse(sdrreader[6].ToString());
                    rejectionoutdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[7].ToString());
                    rejectionoutdetailsinfo.BatchId = decimal.Parse(sdrreader[8].ToString());
                    rejectionoutdetailsinfo.GodownId = decimal.Parse(sdrreader[9].ToString());
                    rejectionoutdetailsinfo.RackId = decimal.Parse(sdrreader[10].ToString());
                    rejectionoutdetailsinfo.Amount = decimal.Parse(sdrreader[11].ToString());
                    rejectionoutdetailsinfo.Slno = int.Parse(sdrreader[12].ToString());
                    rejectionoutdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[13].ToString());
                    rejectionoutdetailsinfo.Extra1 = sdrreader[14].ToString();
                    rejectionoutdetailsinfo.Extra2 = sdrreader[15].ToString();
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
            return rejectionoutdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="RejectionOutDetailsId"></param>
        public void RejectionOutDetailsDelete(decimal RejectionOutDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionOutDetailsId", SqlDbType.Decimal);
                sprmparam.Value = RejectionOutDetailsId;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decRejectionOutMasterId"></param>
        public void RejectionOutDetailsDeleteByRejectionOutMasterId(decimal decRejectionOutMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionOutDetailsDeleteByRejectionOutMasterId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                param.Value = decRejectionOutMasterId;
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
        /// Function to  get the next id for RejectionOutDetails table
        /// </summary>
        /// <returns></returns>
        public int RejectionOutDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionOutDetailsMax", sqlcon);
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
        /// Function to fill vouchertype combobox for rejectionout report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeComboFillForRejectionOutReport()
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("VoucherTypeComboFillForRejectionOutReport", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
                DataRow dr = list[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
                list[0].Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get particular values from RejectionOutDetails table based on the parameter
        /// </summary>
        /// <param name="decRejectionOutMasterId"></param>
        /// <returns></returns>
        public List<DataTable> RejectionOutDetailsViewByRejectionOutMasterId(decimal decRejectionOutMasterId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("RejectionOutDetailsViewByRejectionOutMasterId", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decRejectionOutMasterId;
                sqldataadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
    }
}
