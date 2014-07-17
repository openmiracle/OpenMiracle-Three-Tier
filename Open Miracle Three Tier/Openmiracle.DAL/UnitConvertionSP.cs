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
//Summary description for UnitConvertionSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class UnitConvertionSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to UnitConversion table
        /// </summary>
        /// <param name="unitconvertioninfo"></param>
        public void UnitConvertionAdd(UnitConvertionInfo unitconvertioninfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConvertionAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@conversionRate", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.ConversionRate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = unitconvertioninfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = unitconvertioninfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@quantities", SqlDbType.VarChar);
                sprmparam.Value = unitconvertioninfo.Quantities;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = unitconvertioninfo.Extra2;
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
        /// Function to get all the values from UnitConversion table
        /// </summary>
        /// <param name="unitconvertioninfo"></param>
        public void UnitConvertionEdit(UnitConvertionInfo unitconvertioninfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConvertionEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.UnitconvertionId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@conversionRate", SqlDbType.Decimal);
                sprmparam.Value = unitconvertioninfo.ConversionRate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = unitconvertioninfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = unitconvertioninfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = unitconvertioninfo.Extra2;
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
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable UnitConvertionViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitConvertionViewAll", sqlcon);
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
        /// Function to get particular values from UnitConversion table based on the parameter
        /// </summary>
        /// <param name="unitconvertionId"></param>
        /// <returns></returns>
        public UnitConvertionInfo UnitConvertionView(decimal unitconvertionId)
        {
            UnitConvertionInfo unitconvertioninfo = new UnitConvertionInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConvertionView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
                sprmparam.Value = unitconvertionId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    unitconvertioninfo.UnitconvertionId = decimal.Parse(sdrreader[0].ToString());
                    unitconvertioninfo.ProductId = decimal.Parse(sdrreader[1].ToString());
                    unitconvertioninfo.UnitId = decimal.Parse(sdrreader[2].ToString());
                    unitconvertioninfo.ConversionRate = decimal.Parse(sdrreader[3].ToString());
                    unitconvertioninfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    unitconvertioninfo.Extra1 = sdrreader[5].ToString();
                    unitconvertioninfo.Extra2 = sdrreader[6].ToString();
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
            return unitconvertioninfo;
        }
        /// <summary>
        /// Function for delete based on parameter
        /// </summary>
        /// <param name="UnitconvertionId"></param>
        /// <returns></returns>
        public decimal UnitConvertionDelete(decimal UnitconvertionId)
        {
            decimal decConfirm = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConvertionDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
                sprmparam.Value = UnitconvertionId;
                decConfirm = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decConfirm;
        }
        /// <summary>
        /// Function for Delete multiple unit for updation based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public decimal MulUnitDeleteForUpdation(decimal decProductId)
        {
            decimal decConfirm = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MulUnitDeleteForUpdation", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                decConfirm = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decConfirm;
        }
        /// <summary>
        /// Function to  get the next id for UnitConversion table
        /// </summary>
        /// <returns></returns>
        public int UnitConvertionGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConvertionMax", sqlcon);
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
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> UnitConverstionTableForEdit(decimal decProductId)
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
                SqlCommand sqlcmd = new SqlCommand("UnitConverstionTableForEdit", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
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
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="decUnitConvetionId"></param>
        /// <returns></returns>
        public decimal MulUnitRemoveRows(decimal decUnitConvetionId)
        {
            decimal decConfirm = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MulUnitRemoveRows", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitconvertionId", SqlDbType.Decimal);
                sprmparam.Value = decUnitConvetionId;
                decConfirm = sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decConfirm;
        }
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="unitConvertionInfo"></param>
        public void UnitConverstionEditWhenProductUpdating(UnitConvertionInfo unitConvertionInfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConverstionEditWhenProductUpdating", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = unitConvertionInfo.ProductId;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitConvertionInfo.UnitId;
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
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="decConversionId"></param>
        /// <returns></returns>
        public decimal UnitConversionRateByUnitConversionId(decimal decConversionId)
        {
            decimal decConversionRate = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ConversionRateById", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitconversionId", SqlDbType.Decimal);
                sprmparam.Value = decConversionId;
                decConversionRate = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decConversionRate;
        }
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="decUnitId"></param>
        /// <param name="productName"></param>
        /// <returns></returns>
        public List<DataTable> DGVUnitConvertionRateByUnitId(decimal decUnitId, string productName)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ConversionRateViewByUnitId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@unitId", SqlDbType.Decimal).Value = decUnitId;
                sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = productName;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> UnitsOfPerticularProduct(decimal decProductId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitsOfPerticularProduct", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar).Value = decProductId;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get details based on parameter
        /// </summary>
        /// <param name="dcProductid"></param>
        /// <returns></returns>
        public UnitConvertionInfo UnitViewAllByProductId(decimal dcProductid)
        {
            UnitConvertionInfo UnitConvertionInfo = new UnitConvertionInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitViewAllByProductId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = dcProductid;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    UnitConvertionInfo.UnitconvertionId = decimal.Parse(sdrreader["unitconversionId"].ToString());
                    UnitConvertionInfo.UnitId = decimal.Parse(sdrreader["unitId"].ToString());
                    UnitConvertionInfo.ConversionRate = decimal.Parse(sdrreader["conversionRate"].ToString());
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
            return UnitConvertionInfo;
        }
        /// <summary>
        /// Function To get unit conversion rate based on parameter
        /// </summary>
        /// <param name="strProductId"></param>
        /// <returns></returns>
        public List<DataTable> UnitConversionIdAndConRateViewallByProductId(string strProductId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitConversionIdAndConRateViewallByProductId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar);
                sqlparameter.Value = strProductId;
                sdaadapter.Fill(dtbl);
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
        /// <summary>
        /// Function for Unit view by id based on parameters
        /// </summary>
        /// <param name="unitId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public decimal UnitconversionIdViewByUnitIdAndProductId(decimal unitId, decimal productId)
        {
            decimal decValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("UnitconversionIdViewByUnitIdAndProductId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitId;
                sprmparam = sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = productId;
                decValue = Convert.ToDecimal(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decValue;
        }
    }
}
