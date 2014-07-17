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
//Summary description for ExchangeRateSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ExchangeRateSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ExchangeRate Table
        /// </summary>
        /// <param name="exchangerateinfo"></param>
        public void ExchangeRateAdd(ExchangeRateInfo exchangerateinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = exchangerateinfo.Date;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = exchangerateinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra2;
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
        /// Function to Update values in ExchangeRate Table
        /// </summary>
        /// <param name="exchangerateinfo"></param>
        public void ExchangeRateEdit(ExchangeRateInfo exchangerateinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = exchangerateinfo.Date;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra2;
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
        /// Function to get all the values from ExchangeRate Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ExchangeRateViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ExchangeRateViewAll", sqlcon);
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
        /// Function to get particular values from ExchangeRate Table based on the parameter
        /// </summary>
        /// <param name="exchangeRateId"></param>
        /// <returns></returns>
        public ExchangeRateInfo ExchangeRateView(decimal exchangeRateId)
        {
            ExchangeRateInfo exchangerateinfo = new ExchangeRateInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = exchangeRateId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    exchangerateinfo.ExchangeRateId = decimal.Parse(sdrreader[0].ToString());
                    exchangerateinfo.CurrencyId = decimal.Parse(sdrreader[1].ToString());
                    exchangerateinfo.Date = DateTime.Parse(sdrreader[2].ToString());
                    exchangerateinfo.Rate = decimal.Parse(sdrreader[3].ToString());
                    exchangerateinfo.Narration = sdrreader[4].ToString();
                    exchangerateinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    exchangerateinfo.Extra1 = sdrreader[6].ToString();
                    exchangerateinfo.Extra2 = sdrreader[7].ToString();
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
            return exchangerateinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ExchangeRateId"></param>
        public void ExchangeRateDelete(decimal ExchangeRateId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = ExchangeRateId;
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
        /// Function to  get the next id for ExchangeRate table
        /// </summary>
        /// <returns></returns>
        public int ExchangeRateGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateMax", sqlcon);
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
        /// Function to insert particular values to ExchangeRate Table
        /// </summary>
        /// <param name="exchangerateinfo"></param>
        public void ExchangeRateAddParticularFields(ExchangeRateInfo exchangerateinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateAddParticularFields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = exchangerateinfo.Date;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = exchangerateinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = exchangerateinfo.Extra2;
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
        /// Function to get values for search based on parameters
        /// </summary>
        /// <param name="strCurrencyname"></param>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <returns></returns>
        public List<DataTable> ExchangeRateSearch(String strCurrencyname, DateTime dtDateFrom, DateTime dtDateTo)
        {
            List<DataTable> listObj = new List<DataTable>();         
            try
            {
                DataTable dtbl = new DataTable(); 
                SqlDataAdapter sqlda = new SqlDataAdapter("ExchangeRateSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(decimal));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@currencyName", SqlDbType.VarChar).Value = strCurrencyname;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtDateTo;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtDateFrom;
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
        /// Function to check existence based on parameters and return status
        /// </summary>
        /// <param name="dtDate"></param>
        /// <param name="decCurrencyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public bool ExchangeRateCheckExistence(DateTime dtDate, decimal decCurrencyId, decimal decExchangeRateId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dtDate;
                sprmparam = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                sprmparam = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = decCurrencyId;
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
        /// Function to get id based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        public decimal GetExchangeRateId(decimal decCurrencyId, DateTime dtDate)
        {
            decimal decCount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("GetExchangeRateId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
                sqlcmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtDate;
                Object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
            return decCount;
        }
        /// <summary>
        /// Function to check refernce bassed on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal ExchangeRateCheckReferences(decimal decExchangeRateId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckReferences", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
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
        /// Function to get rate based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal GetExchangeRateByExchangeRateId(decimal decExchangeRateId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("GetExchangeRateByExchangeRateId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteScalar().ToString());
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
        /// Function to view rate based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public decimal ExchangeRateViewByExchangeRateId(decimal decExchangeRateId)
        {
            decimal exchangeRate = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangeRateViewByExchangeRateId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                exchangeRate = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return exchangeRate;
        }
        /// <summary>
        /// Function to get decimal places based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public int NoOfDecimalNumberViewByExchangeRateId(decimal decExchangeRateId)
        {
            int NoOfDecimalNumber = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("NoOfDecimalNumberViewByExchangeRateId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                NoOfDecimalNumber = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return NoOfDecimalNumber;
        }
        /// <summary>
        /// Function to get decimal places based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public int NoOfDecimalNumberViewByCurrencyId(decimal decCurrencyId)
        {
            int NoOfDecimalNumber = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("NoOfDecimalNumberViewByCurrencyId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = decCurrencyId;
                NoOfDecimalNumber = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return NoOfDecimalNumber;
        }
        /// <summary>
        /// Function to get value based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public decimal ExchangerateViewByCurrencyId(decimal decCurrencyId)
        {
            decimal decExchangerateId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ExchangerateViewByCurrencyId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = decCurrencyId;
                decExchangerateId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decExchangerateId;
        }
        /// <summary>
        /// Function to check existence based on parameters and return status
        /// </summary>
        /// <param name="dtDate"></param>
        /// <param name="decCurrencyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public bool ExchangeRateCheckExistanceForUpdationAndDelete(DateTime dtDate, decimal decExchangeRateId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ExchangeRateCheckExistanceForUpdationAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = dtDate;
                sprmparam = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
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
    }
}
