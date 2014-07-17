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
//Summary description for CurrencySP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class CurrencySP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Currency Table
        /// </summary>
        /// <param name="currencyinfo"></param>
        public void CurrencyAdd(CurrencyInfo currencyinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = currencyinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencySymbol;
                sprmparam = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencyName;
                sprmparam = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.SubunitName;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sprmparam.Value = currencyinfo.NoOfDecimalPlaces;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = currencyinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = currencyinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra2;
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
        /// Function to Update values in Currency Table
        /// </summary>
        /// <param name="currencyinfo"></param>
        public void CurrencyEdit(CurrencyInfo currencyinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = currencyinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencySymbol;
                sprmparam = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencyName;
                sprmparam = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.SubunitName;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sprmparam.Value = currencyinfo.NoOfDecimalPlaces;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = currencyinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra2;
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
        /// Function to get all the values from Currency Table
        /// </summary>
        /// <returns></returns>
        public DataTable CurrencyViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAll", sqlcon);
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
        /// Function to get particular values from Currency table based on the parameter
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable CurrencyViewAllByDate(DateTime date)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllByDate", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = date;
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
        /// Function to get all the values from Currency Table based on the parameter 
        /// </summary>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public CurrencyInfo CurrencyView(decimal currencyId)
        {
            CurrencyInfo currencyinfo = new CurrencyInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = currencyId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    currencyinfo.CurrencyId = decimal.Parse(sdrreader[0].ToString());
                    currencyinfo.CurrencySymbol = sdrreader[1].ToString();
                    currencyinfo.CurrencyName = sdrreader[2].ToString();
                    currencyinfo.SubunitName = sdrreader[3].ToString();
                    currencyinfo.NoOfDecimalPlaces = int.Parse(sdrreader[4].ToString());
                    currencyinfo.Narration = sdrreader[5].ToString();
                    currencyinfo.IsDefault = bool.Parse(sdrreader[6].ToString());
                    currencyinfo.Extra1 = sdrreader[8].ToString();
                    currencyinfo.Extra2 = sdrreader[9].ToString();
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
            return currencyinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="CurrencyId"></param>
        public void CurrencyDelete(decimal CurrencyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = CurrencyId;
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
        /// Function to  get the next id for Currency Table
        /// </summary>
        /// <returns></returns>
        public int CurrencyGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyMax", sqlcon);
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
        /// Function to view for Currency combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CurrencyViewAllForCombo()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllForCombo", sqlcon);
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
        /// Function to view for ExchangeRate combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CurrencyViewAllForExchangeRateCombo()
        {
            List<DataTable> listObj = new List<DataTable>();
          
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyViewAllForExchangeRateCombo", sqlcon);
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
        /// Function to insert values to table and return id
        /// </summary>
        /// <param name="currencyinfo"></param>
        /// <returns></returns>
        public decimal CurrencyAddwithIdentity(CurrencyInfo currencyinfo)
        {
            decimal decCurrencyId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CurrencyAddwithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencySymbol;
                sprmparam = sccmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.CurrencyName;
                sprmparam = sccmd.Parameters.Add("@subunitName", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.SubunitName;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sprmparam.Value = currencyinfo.NoOfDecimalPlaces;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = currencyinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = currencyinfo.Extra2;
                object ObjCurrencytId = sccmd.ExecuteScalar();
                if (ObjCurrencytId != null)
                {
                    decCurrencyId = Convert.ToDecimal(ObjCurrencytId.ToString());
                }
                else
                {
                    decCurrencyId = 0;
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
            return decCurrencyId;
        }
        /// <summary>
        /// Function to check existence of currency based on parameter and return status
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public bool CurrencyNameCheckExistence(String strName,string strCurrencySymb, decimal decCurrencyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CurrencyNameCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@currencyName", SqlDbType.VarChar);
                sprmparam.Value = strName;
                sprmparam = sqlcmd.Parameters.Add("@currencySymbol", SqlDbType.VarChar);
                sprmparam.Value = strCurrencySymb;
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
        /// Function to view all values for search based on parameters
        /// </summary>
        /// <param name="strname"></param>
        /// <param name="strsymbol"></param>
        /// <returns></returns>
        public List<DataTable> CurrencySearch(String strname, String strsymbol)
        {
            List<DataTable> listObj = new List<DataTable>();
            
            try
            {
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter("CurrencySearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SL.NO", typeof(decimal));
                dtbl.Columns["SL.NO"].AutoIncrement = true;
                dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
                dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@currencyName", SqlDbType.VarChar).Value = strname;
                sqlda.SelectCommand.Parameters.Add("@currencySymbol", SqlDbType.VarChar).Value = strsymbol;
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
        /// Function to check reference based on parameters
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public decimal CurrencyCheckReferences(decimal decCurrencyId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CurrencyCheckReferences", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = decCurrencyId;
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
        /// Function to get Currency symbol based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public string CurrencySymbolById(decimal decCurrencyId)
        {
            string strReturnValue = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CurrencySymbolById", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = decCurrencyId;
                strReturnValue = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strReturnValue;
        }
        /// <summary>
        ///  Function to get Currency symbol based on parameter
        /// </summary>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public string GetCurrencySymbolByExchangeRateId(decimal decExchangeRateId)
        {
            string strCurrencySymbol = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("GetCurrencySymbolByExchangeRateId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = decExchangeRateId;
                strCurrencySymbol = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strCurrencySymbol;
        }
        /// <summary>
        /// Function to get Default Currency Symbol
        /// </summary>
        /// <returns></returns>
        public string GetDefaultCurrencySymbol()
        {
            string strCurrencySymbol = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("GetDefaultCurrencySymbol", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                strCurrencySymbol = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strCurrencySymbol;
        }
        /// <summary>
        /// Function to check Default Currency based on parameter
        /// </summary>
        /// <param name="decCurrencyId"></param>
        /// <returns></returns>
        public bool DefaultCurrencyCheck(decimal decCurrencyId)
        {
            bool isDefault = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DefaultCurrencyCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
                isDefault = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isDefault;
        }
        public void DefaultCurrencySet(decimal decCurrencyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DefaultCurrencySet", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal).Value = decCurrencyId;
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
    }
}
