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
//Summary description for StandardRateSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class StandardRateSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to StandardRate Table
        /// </summary>
        /// <param name="standardrateinfo"></param>
        public void StandardRateAdd(StandardRateInfo standardrateinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.StandardRateId;
                sprmparam = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableFrom;
                sprmparam = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableTo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra2;
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
        /// Function to Update values in StandardRate Table
        /// </summary>
        /// <param name="standardrateinfo"></param>
        public void StandardRateEdit(StandardRateInfo standardrateinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.StandardRateId;
                sprmparam = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableFrom;
                sprmparam = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableTo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra2;
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
        /// Function to get all the values from StandardRate Table
        /// </summary>
        /// <returns></returns>
        public DataTable StandardRateViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("StandardRateViewAll", sqlcon);
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
        /// Function to get particular values from StandardRate table based on the parameter
        /// </summary>
        /// <param name="standardRateId"></param>
        /// <returns></returns>
        public StandardRateInfo StandardRateView(decimal standardRateId)
        {
            StandardRateInfo standardrateinfo = new StandardRateInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
                sprmparam.Value = standardRateId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    standardrateinfo.StandardRateId = decimal.Parse(sdrreader[0].ToString());
                    standardrateinfo.ApplicableFrom = DateTime.Parse(sdrreader[1].ToString());
                    standardrateinfo.ApplicableTo = DateTime.Parse(sdrreader[2].ToString());
                    standardrateinfo.ProductId = decimal.Parse(sdrreader[3].ToString());
                    standardrateinfo.UnitId = decimal.Parse(sdrreader[4].ToString());
                    standardrateinfo.BatchId = decimal.Parse(sdrreader[5].ToString());
                    standardrateinfo.Rate = decimal.Parse(sdrreader[6].ToString());
                    standardrateinfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
                    standardrateinfo.Extra1 = sdrreader[8].ToString();
                    standardrateinfo.Extra2 = sdrreader[9].ToString();
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
            return standardrateinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="StandardRateId"></param>
        public void StandardRateDelete(decimal StandardRateId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
                sprmparam.Value = StandardRateId;
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
        /// Function to  get the next id for StandardRate table
        /// </summary>
        /// <returns></returns>
        public int StandardRateGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateMax", sqlcon);
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
        /// Function to insert values to StandardRate Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="standardrateinfo"></param>
        /// <returns></returns>
        public decimal StandardRateAddParticularfields(StandardRateInfo standardrateinfo)
        {
            decimal decStandardRateId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StandardRateAddParticularfields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableFrom;
                sprmparam = sccmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
                sprmparam.Value = standardrateinfo.ApplicableTo;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.BatchId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = standardrateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = standardrateinfo.Extra2;
                object ObjStandardRateId = sccmd.ExecuteScalar();
                if (ObjStandardRateId != null)
                {
                    decStandardRateId = Convert.ToDecimal(ObjStandardRateId.ToString());
                }
                else
                {
                    decStandardRateId = 0;
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
            return decStandardRateId;
        }
        /// <summary>
        /// Function to check existence of StandardRate based on the parameter
        /// </summary>
        /// <param name="decstandardRateId"></param>
        /// <param name="dtapplicableFrom"></param>
        /// <param name="dtapplicableTo"></param>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        /// <returns></returns>
        public bool StandardrateCheckExistence(decimal decstandardRateId, DateTime dtapplicableFrom, DateTime dtapplicableTo, decimal decProductId, decimal decBatchId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("StandardrateCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@standardRateId", SqlDbType.Decimal);
                sprmparam.Value = decstandardRateId;
                sprmparam = sqlcmd.Parameters.Add("@applicableFrom", SqlDbType.DateTime);
                sprmparam.Value = dtapplicableFrom;
                sprmparam = sqlcmd.Parameters.Add("@applicableTo", SqlDbType.DateTime);
                sprmparam.Value = dtapplicableTo;
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
        /// Function to get all details for Gridfill based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> StandardRateGridFill(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("StandardRateGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    }
}
