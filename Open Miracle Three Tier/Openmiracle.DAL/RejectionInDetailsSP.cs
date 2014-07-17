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
//Summary description for RejectionInDetailsSP    
//</summary>    
namespace OpenMiracle.DAL   
{
    public class RejectionInDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to RejectionInDetails Table
        /// </summary>
        /// <param name="rejectionindetailsinfo"></param>
        public void RejectionInDetailsAdd(RejectionInDetailsInfo rejectionindetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.RejectionInMasterId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.DeliveryNoteDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = rejectionindetailsinfo.SlNo;
                
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionindetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionindetailsinfo.Extra2;
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
        /// Function to Update values in RejectionInDetails Table
        /// </summary>
        /// <param name="rejectionindetailsinfo"></param>
        public void RejectionInDetailsEdit(RejectionInDetailsInfo rejectionindetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionInDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.RejectionInDetailsId;
                sprmparam = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.RejectionInMasterId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteDetailsId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.DeliveryNoteDetailsId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = rejectionindetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slNo", SqlDbType.Int);
                sprmparam.Value = rejectionindetailsinfo.SlNo;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rejectionindetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectionindetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectionindetailsinfo.Extra2;
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
        /// Function to delete from RejectionInDetails table based on the parameter
       /// </summary>
       /// <param name="decRejectionInMasterId"></param>
        public void DeleteRejectionInDetailsByRejectionInMasterId(decimal decRejectionInMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionInDetailsDeleteByRejectionInMasterId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                param.Value = decRejectionInMasterId;
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
        /// Function to get particular values from RejectionInDetails table based on the parameter
       /// </summary>
       /// <param name="decRejectionInMasterId"></param>
       /// <returns></returns>
        public List<DataTable> RejectionInDetailsViewByRejectionInMasterId(decimal decRejectionInMasterId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInDetailsViewByRejectionInMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                param.Value = decRejectionInMasterId;
                sqlda.Fill(dtbl);
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
