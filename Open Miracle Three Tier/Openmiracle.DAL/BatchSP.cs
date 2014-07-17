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
//Summary description for BatchSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class BatchSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Batch Table
        /// </summary>
        /// <param name="batchinfo"></param>
        public void BatchAdd(BatchInfo batchinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
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
        /// Function to insert values to Batch Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="batchinfo"></param>
        /// <returns></returns>
        public decimal BatchAddReturnIdentity(BatchInfo batchinfo)
        {
            decimal decBatchId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAddReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.barcode;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
                decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBatchId;
        }
        /// <summary>
        /// FUnction to get Batch Add And Delete
        /// </summary>
        /// <param name="batchinfo"></param>
        /// <param name="decProductIdForEdit"></param>
        /// <returns></returns>
        public decimal BatchAddAndDelete(BatchInfo batchinfo, decimal decProductIdForEdit)
        {
            decimal decBatchId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAddAndDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.barcode;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
                sprmparam = sccmd.Parameters.Add("@deleteId", SqlDbType.VarChar);
                sprmparam.Value = decProductIdForEdit;
                decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBatchId;
        }
        /// <summary>
        /// Function to Update values in Batch Table
        /// </summary>
        /// <param name="batchinfo"></param>
        public void BatchEdit(BatchInfo batchinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
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
        /// Function to Batch Edit For Product Edit
        /// </summary>
        /// <param name="batchinfo"></param>
        /// <returns></returns>
        public bool BatchEditForProductEdit(BatchInfo batchinfo)
        {
            decimal decResult = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchEditForProductEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
                decResult = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            if (decResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Function to get all the values from Batch Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BatchViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewAll", sqlcon);
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
        /// Function to get Batch view all based on the product
        /// </summary>
        /// <param name="dgvCurrent"></param>
        /// <param name="decProductId"></param>
        /// <param name="inRowIndex"></param>
        /// <returns></returns>
        public List<DataTable> BatchViewAll1(DataGridView dgvCurrent, decimal decProductId, int inRowIndex)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblBatch = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DGVBatchFillByProductName", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sqlparameter.Value = decProductId;
                sdaadapter.Fill(dtblBatch);
                listObj.Add(dtblBatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            try
            {
                DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbBatch"].Index, inRowIndex];
                dgvCurrent[dgvCurrent.Columns["dgvCmbBatch"].Index, inRowIndex].Value = null;
                if (dtblBatch.Rows.Count > 0)
                {
                    dgvcmbUnit.DataSource = dtblBatch;
                    dgvcmbUnit.DisplayMember = "batchNo";
                    dgvcmbUnit.ValueMember = "batchId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to view all Batches Without NA
        /// </summary>
        /// <returns></returns>
        public AutoCompleteStringCollection BatchViewAllWithoutNA()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchViewAllWithoutNA", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    strCollection.Add(sdrreader[1].ToString());
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
            return strCollection;
        }
        /// <summary>
        /// Function to get particular values from Batch Table based on the parameter
        /// </summary>
        /// <param name="batchId"></param>
        /// <returns></returns>
        public BatchInfo BatchView(decimal batchId)
        {
            BatchInfo batchinfo = new BatchInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = batchId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    batchinfo.BatchId = decimal.Parse(sdrreader["BatchId"].ToString());
                    batchinfo.BatchNo = sdrreader["BatchNo"].ToString();
                    batchinfo.ProductId = decimal.Parse(sdrreader["ProductId"].ToString());
                    batchinfo.ManufacturingDate = DateTime.Parse(sdrreader["ManufacturingDate"].ToString());
                    batchinfo.ExpiryDate = DateTime.Parse(sdrreader["ExpiryDate"].ToString());
                    batchinfo.Extra1 = sdrreader["Extra1"].ToString();
                    batchinfo.Extra2 = sdrreader["Extra2"].ToString();
                    batchinfo.narration = (sdrreader["narration"].ToString());
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
            return batchinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table Batch
        /// </summary>
        /// <param name="BatchId"></param>
        public void BatchDelete(decimal BatchId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = BatchId;
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
        /// Function to  get the next id for Batch Table
        /// </summary>
        /// <returns></returns>
        public int BatchGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchMax", sqlcon);
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
        /// Function to add a Batch with purticular table
        /// </summary>
        /// <param name="batchinfo"></param>
        public void BatchAddParticularFields(BatchInfo batchinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAddParticularFields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.barcode;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
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
        /// Function to Search a Batch based on the Condition
        /// </summary>
        /// <param name="strBatchNo"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> BatchSearch(String strBatchNo, String strProductName)
        {
            // 
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BatchSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@batchNo", SqlDbType.VarChar).Value = strBatchNo;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
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
        /// Function to get BatchName And ProductName Check Existence
        /// </summary>
        /// <param name="strBatchName"></param>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        /// <returns></returns>
        public bool BatchNameAndProductNameCheckExistence(String strBatchName, decimal decProductId, decimal decBatchId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BatchNameAndProductNameCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = strBatchName;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
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
        /// Function to Batch Check References
        /// </summary>
        /// <param name="decBatchId"></param>
        /// <returns></returns>
        public decimal BatchCheckReferences(decimal decBatchId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BatchCheckReferences", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
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
        /// <summary>
        /// Function to Batch Check References Based on the batch no and Batch Id
        /// </summary>
        /// <param name="strBatchNo"></param>
        /// <param name="decBatchId"></param>
        /// <returns></returns>
        public bool BatchNameExistenceChecking(string strBatchNo, decimal decBatchId)
        {
            string strResult = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("BatchNameExistenceChecking", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = strBatchNo;
                sprmparam = sqlcmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                strResult = Convert.ToString(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            if (strResult == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Function to Delete Batch For Product Updation
        /// </summary>
        /// <param name="decProductId"></param>
        public void DeleteBatchForProductUpdate(decimal decProductId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeleteBatchForProductUpdate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
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
        /// Function to View Batches for Combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BatchViewForComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewForComboFill", sqlcon);
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
        /// Function to Batch View by ProductId For ComboFill
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> BatchViewbyProductIdForComboFill(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewbyProductIdForComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = decProductId;
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
        /// Function to Batch View By Barcode
        /// </summary>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public decimal BatchViewByBarcode(string strBarcode)
        {
            decimal decBatchId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchViewBYBarcode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = strBarcode;
                decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBatchId;
        }
        /// <summary>
        /// Function to View Batches by name
        /// </summary>
        /// <param name="strBatch"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> BatchViewByName(string strBatch, decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchViewByName", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@batchNo", SqlDbType.VarChar).Value = strBatch;
                sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
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
        /// Function to use Batch Names Corresponding To Product
        /// </summary>
        /// <param name="decproductId"></param>
        /// <returns></returns>
        public List<DataTable> BatchNamesCorrespondingToProduct(decimal decproductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BatchNamesCorrespondingToProduct", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decproductId;
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
        /// Function to Automatic Barcode Generation
        /// </summary>
        /// <returns></returns>
        public int AutomaticBarcodeGeneration()
        {
            int inBarcode = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AutomaticBarcodeGeneration", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                inBarcode = Convert.ToInt32(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inBarcode;
        }
        /// <summary>
        /// Function to Batch Add With BarCode
        /// </summary>
        /// <param name="batchinfo"></param>
        /// <returns></returns>
        public int BatchAddWithBarCode(BatchInfo batchinfo)
        {
            int inResultId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAddWithBarCode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.BatchNo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = batchinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@manufacturingDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ManufacturingDate;
                sprmparam = sccmd.Parameters.Add("@expiryDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExpiryDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = batchinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.narration;
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.barcode;
                sprmparam = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = batchinfo.partNo;
                inResultId = Convert.ToInt32(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inResultId;
        }
        /// <summary>
        /// Function to get the partno from Product Table
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public string PartNoReturn(decimal decProductId)
        {
            string strPartNo = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartNoReturn", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                strPartNo = Convert.ToString(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strPartNo;
        }
        /// <summary>
        /// Function to Part No Update
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="strPartNo"></param>
        public void PartNoUpdate(decimal decProductId, string strPartNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartNoUpdate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sccmd.Parameters.Add("@partNo", SqlDbType.VarChar);
                sprmparam.Value = strPartNo;
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
        /// Function to get Product Code View By BarCode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public List<DataTable> ProductCodeViewByBarCode(string barcode)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductViewByBarcode", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = barcode;
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
        /// Function to get Product Batch Barcode View By BatchId
        /// </summary>
        /// <param name="decBathId"></param>
        /// <returns></returns>
        public string ProductBatchBarcodeViewByBatchId(decimal decBathId)
        {
            string barCode = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductBatchBarcodeViewByBatchId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBathId;
                barCode = Convert.ToString(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return barCode;
        }
        /// <summary>
        /// Function to BatchId For Stock Posting
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public int BatchIdForStockPosting(decimal decProductId)
        {
            int inBatchId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchIdForStockPosting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                inBatchId = Convert.ToInt32(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inBatchId;
        }
        /// <summary>
        /// Function to Batch And Product View By Barcode
        /// </summary>
        /// <param name="strBarcode"></param>
        /// <returns></returns>
        public BatchInfo BatchAndProductViewByBarcode(string strBarcode)
        {
            BatchInfo batchinfo = new BatchInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchAndProductViewByBarcode", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                sprmparam.Value = strBarcode;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    batchinfo.BatchId = decimal.Parse(sdrreader[0].ToString());
                    batchinfo.BatchNo = sdrreader[1].ToString();
                    batchinfo.ProductId = decimal.Parse(sdrreader[2].ToString());
                    batchinfo.barcode = sdrreader[3].ToString();
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
            return batchinfo;
        }
        /// <summary>
        /// Function to Batch View by ProductId For ComboFill In Grid
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="dgvCurrent"></param>
        /// <param name="inRowIndex"></param>
        /// <returns></returns>
        public List<DataTable> BatchViewbyProductIdForComboFillInGrid(decimal decProductId, DataGridView dgvCurrent, int inRowIndex)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("BatchViewbyProductIdForComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = decProductId;
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
            try
            {
                DataGridViewComboBoxCell dgvcmbBatch = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvcmbBatch"].Index, inRowIndex];
                dgvCurrent[dgvCurrent.Columns["dgvcmbBatch"].Index, inRowIndex].Value = null;
                if (dtbl.Rows.Count > 0)
                {
                    dgvcmbBatch.DataSource = dtbl;
                    dgvcmbBatch.DisplayMember = "batchNo";
                    dgvcmbBatch.ValueMember = "batchId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to get batch no based on the product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> BatchNoViewByProductId(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BatchNoViewByProductId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
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
        /// Fuction to get batch id based on the product id 
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public decimal BatchIdViewByProductId(decimal decProductId)
        {
            decimal decBatchId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchIdViewByProductId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                decBatchId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decBatchId;
        }
        /// <summary>
        /// Function to Batch View All By ProductCode For Barcode Printing
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="cmbBatch"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> BatchViewAllByProductCodeForBarcodePrinting(decimal decProductId, ComboBox cmbBatch, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("BatchViewAllByProductCodeForBarcodePrinting", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sda.Fill(dtbl);
                listObj.Add(dtbl);
                if (isAll)
                {
                    if (dtbl.Rows.Count != 0)
                    {
                        DataRow dr = dtbl.NewRow();
                        dr["batchNo"] = "All";
                        dr["batchId"] = 0;
                        dtbl.Rows.InsertAt(dr, 0);
                    }
                    else
                    {
                        cmbBatch.Text = string.Empty;
                    }
                }
                cmbBatch.DataSource = listObj[0];
                cmbBatch.DisplayMember = "batchNo";
                cmbBatch.ValueMember = "batchId";
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
        /// Function to get Barcode Printing GridFill
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public List<DataTable> BarcodePrintingGrideFill(decimal decProductId, decimal decBatchId, decimal decPurchaseMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("BarcodePrintingGrideFill", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sda.SelectCommand.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                sprmparam = sda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sda.Fill(dtbl);
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
    }
}
