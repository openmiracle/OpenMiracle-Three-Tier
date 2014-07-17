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
//Summary description for PriceListSP    
//</summary> 
namespace OpenMiracle.DAL
{
    public class PriceListSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PriceList Table
        /// </summary>
        /// <param name="pricelistinfo"></param>
        public void PriceListAdd(PriceListInfo pricelistinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PriceListAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pricelistinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pricelistinfo.Extra2;
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
        /// Function to Update values in PriceList Table
        /// </summary>
        /// <param name="pricelistinfo"></param>
        public void PriceListEdit(PriceListInfo pricelistinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PriceListEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.PricelistId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = pricelistinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pricelistinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pricelistinfo.Extra2;
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
        /// Function to get all the values from PriceList Table
        /// </summary>
        /// <returns></returns>
        public DataTable PriceListViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewAll", sqlcon);
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
        /// Function to get particular values from PriceList Table based on the parameter
        /// </summary>
        /// <param name="pricelistId"></param>
        /// <returns></returns>
        public PriceListInfo PriceListView(decimal pricelistId)
        {
            PriceListInfo pricelistinfo = new PriceListInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PriceListView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
                sprmparam.Value = pricelistId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    pricelistinfo.PricelistId = Convert.ToDecimal(sdrreader[0].ToString());
                    pricelistinfo.ProductId = Convert.ToDecimal(sdrreader[1].ToString());
                    pricelistinfo.PricinglevelId = Convert.ToDecimal(sdrreader[2].ToString());
                    pricelistinfo.UnitId = Convert.ToDecimal(sdrreader[3].ToString());
                    pricelistinfo.BatchId = Convert.ToDecimal(sdrreader[4].ToString());
                    pricelistinfo.Rate = Convert.ToDecimal(sdrreader[5].ToString());
                    pricelistinfo.ExtraDate = Convert.ToDateTime(sdrreader[6].ToString());
                    pricelistinfo.Extra1 = sdrreader[7].ToString();
                    pricelistinfo.Extra2 = sdrreader[8].ToString();
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
            return pricelistinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table PriceList
        /// </summary>
        /// <param name="PricelistId"></param>
        public void PriceListDelete(decimal PricelistId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PriceListDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
                sprmparam.Value = PricelistId;
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
        /// Function to  get the next id for PriceList Table
        /// </summary>
        /// <returns></returns>
        public int PriceListGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PriceListMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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
        /// Get the all are the product group for combo fill in pricelist
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PricelistProductGroupViewAllForComboBox()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistProductGroupViewAllForComboBox", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
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
        /// Pricing level view all for priclist form combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PricelistPricingLevelViewAllForComboBox()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistPricingLevelViewAllForComboBox", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
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
        /// Product details vieww all for gridfill  based on search
        /// </summary>
        /// <param name="decgroupId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <param name="strPricingLevelName"></param>
        /// <returns></returns>
        public List<DataTable> ProductDetailsViewGridfill(decimal decgroupId, string strProductCode, string strProductName, string strPricingLevelName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductDetailsViewGridfill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
                sqlda.SelectCommand.Parameters.Add("@pricingLevelName", SqlDbType.VarChar).Value = strPricingLevelName;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to use the use fill the grid
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PriceListGridFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PriceListGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to use fill the grid pricelist popup grid
        /// </summary>
        /// <param name="decPriceLevelId"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> PriceListPopupGridFill(decimal decPriceLevelId, decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PriceListPopupGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decPriceLevelId;
                sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to PriceList CheckExistence
        /// </summary>
        /// <param name="decpricelistId"></param>
        /// <param name="decpricinglevelId"></param>
        /// <param name="decbatchId"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public bool PriceListCheckExistence(decimal decpricelistId, decimal decpricinglevelId, decimal decbatchId, decimal decProductId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PriceListCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@pricelistId", SqlDbType.Decimal);
                sprmparam.Value = decpricelistId;
                sprmparam = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decpricinglevelId;
                sprmparam = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decbatchId;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
                }
                if (decCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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
            return false;
        }
        /// <summary>
        /// Price list get by batchid Or product
        /// </summary>
        /// <param name="dcBatchId"></param>
        /// <returns></returns>
        public PriceListInfo PriceListViewByBatchIdORProduct(decimal dcBatchId)
        {
            PriceListInfo infoPriceList = new PriceListInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PriceListViewByBatchIdORProduct", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal).Value = dcBatchId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoPriceList.ProductId = Convert.ToDecimal(sqldr["productId"].ToString());
                    infoPriceList.BatchId = Convert.ToDecimal(sqldr["batchId"].ToString());
                    infoPriceList.PricinglevelId = Convert.ToDecimal(sqldr["pricinglevelId"].ToString());
                    infoPriceList.Rate = Convert.ToDecimal(sqldr["rate"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
                sqldr.Close();
            }
            return infoPriceList;
        }
        /// <summary>
        /// Function to use the pricelist gridfill
        /// </summary>
        /// <param name="decgroupId"></param>
        /// <param name="strproductName"></param>
        /// <param name="decsizeId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decpricinglevelId"></param>
        /// <returns></returns>
        public List<DataTable> PriceListGridFill(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PriceListReportGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strproductName;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decpricinglevelId;
                sqlda.Fill(dtbl);
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
        /// Function to use print the report of pricelist details based on search
        /// </summary>
        /// <param name="decgroupId"></param>
        /// <param name="strproductName"></param>
        /// <param name="decsizeId"></param>
        /// <param name="decModelNoId"></param>
        /// <param name="decpricinglevelId"></param>
        /// <returns></returns>
        public List<DataTable> PriceListReportPrint(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PriceListReportPrint", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strproductName;
                sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decsizeId;
                sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal).Value = decModelNoId;
                sqlda.SelectCommand.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decpricinglevelId;
                sqlda.Fill(dtbl);
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
        /// Pricelist check reference for delete
        /// </summary>
        /// <param name="decpricinglevelId"></param>
        /// <returns></returns>
        public decimal PriceListCheckReferenceAndDelete(decimal decpricinglevelId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PriceListCheckReferenceAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decpricinglevelId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
    }
}
