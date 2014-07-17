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
//Summary description for PhysicalStockDetailsSP    
//</summary>    
namespace OpenMiracle.DAL    
{
    public class PhysicalStockDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PhysicalStockDetails Table
        /// </summary>
        /// <param name="physicalstockdetailsinfo"></param>
        public void PhysicalStockDetailsAdd(PhysicalStockDetailsInfo physicalstockdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.PhysicalStockMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = physicalstockdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = physicalstockdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = physicalstockdetailsinfo.Extra2;
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
        /// Function to Update values in PhysicalStockDetails Table
        /// </summary>
        /// <param name="physicalstockdetailsinfo"></param>
        public void PhysicalStockDetailsEdit(PhysicalStockDetailsInfo physicalstockdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.PhysicalStockDetailsId;
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.PhysicalStockMasterId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@qty", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Qty;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitConversionId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.UnitConversionId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = physicalstockdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@slno", SqlDbType.Int);
                sprmparam.Value = physicalstockdetailsinfo.Slno;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = physicalstockdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = physicalstockdetailsinfo.Extra2;
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
        /// Function to get all the values from PhysicalStockDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable PhysicalStockDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockDetailsViewAll", sqlcon);
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
        /// Function to get particular values from PhysicalStockDetails table based on the parameter
        /// </summary>
        /// <param name="physicalStockDetailsId"></param>
        /// <returns></returns>
        public PhysicalStockDetailsInfo PhysicalStockDetailsView(decimal physicalStockDetailsId)
        {
            PhysicalStockDetailsInfo physicalstockdetailsinfo = new PhysicalStockDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
                sprmparam.Value = physicalStockDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    physicalstockdetailsinfo.PhysicalStockDetailsId = decimal.Parse(sdrreader[0].ToString());
                    physicalstockdetailsinfo.PhysicalStockMasterId = decimal.Parse(sdrreader[1].ToString());
                    physicalstockdetailsinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    physicalstockdetailsinfo.Qty = decimal.Parse(sdrreader[3].ToString());
                    physicalstockdetailsinfo.Rate = decimal.Parse(sdrreader[4].ToString());
                    physicalstockdetailsinfo.UnitId = decimal.Parse(sdrreader[5].ToString());
                    physicalstockdetailsinfo.UnitConversionId = decimal.Parse(sdrreader[6].ToString());
                    physicalstockdetailsinfo.BatchId = decimal.Parse(sdrreader[7].ToString());
                    physicalstockdetailsinfo.GodownId = decimal.Parse(sdrreader[8].ToString());
                    physicalstockdetailsinfo.RackId = decimal.Parse(sdrreader[9].ToString());
                    physicalstockdetailsinfo.Amount = decimal.Parse(sdrreader[10].ToString());
                    physicalstockdetailsinfo.Slno = int.Parse(sdrreader[11].ToString());
                    physicalstockdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[12].ToString());
                    physicalstockdetailsinfo.Extra1 = sdrreader[13].ToString();
                    physicalstockdetailsinfo.Extra2 = sdrreader[14].ToString();
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
            return physicalstockdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PhysicalStockDetailsId"></param>
        public void PhysicalStockDetailsDelete(decimal PhysicalStockDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockDetailsId", SqlDbType.Decimal);
                sprmparam.Value = PhysicalStockDetailsId;
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
        /// Function to  get the next id for PhysicalStockDetails table
        /// </summary>
        /// <returns></returns>
        public int PhysicalStockDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsMax", sqlcon);
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
        /// Function to delete particular details based on the parameter while updating
        /// </summary>
        /// <param name="decMasterId"></param>
        public void PhysicalStockDetailsDeleteWhenUpdate(decimal decMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockDetailsDeleteWhenUpdate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
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
        /// Function to fill the product details based on the product code in sales invoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public DataTable PhysicalStockDetailsViewByProductCode(decimal decVoucherTypeId, string strProductCode)
        {
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PhysicalStockDetailsViewByProductCode", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sqlda.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtbl;
        }
    }
}
