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
//Summary description for AdditionalCostSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class AdditionalCostSP : DBConnection
    {
        /// <summary>
        ///  Function to insert values to AdditionCost table
        /// </summary>
        /// <param name="additionalcostinfo"></param>
        public void AdditionalCostAdd(AdditionalCostInfo additionalcostinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = additionalcostinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra2;
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
        /// Function to Update values in AdditionCost table
        /// </summary>
        /// <param name="additionalcostinfo"></param>
        public void AdditionalCostEdit(AdditionalCostInfo additionalcostinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.AdditionalCostId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = additionalcostinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra2;
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
        /// Function to get all the values from AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public DataTable AdditionalCostViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AdditionalCostViewAll", sqlcon);
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
        /// Function to get particular values from AdditionalCost table based on the parameter
        /// </summary>
        /// <param name="additionalCostId"></param>
        /// <returns></returns>
        public AdditionalCostInfo AdditionalCostView(decimal additionalCostId)
        {
            AdditionalCostInfo additionalcostinfo = new AdditionalCostInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
                sprmparam.Value = additionalCostId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    additionalcostinfo.AdditionalCostId = decimal.Parse(sdrreader[0].ToString());
                    additionalcostinfo.VoucherTypeId = decimal.Parse(sdrreader[1].ToString());
                    additionalcostinfo.VoucherNo = sdrreader[2].ToString();
                    additionalcostinfo.LedgerId = decimal.Parse(sdrreader[3].ToString());
                    additionalcostinfo.Debit = decimal.Parse(sdrreader[4].ToString());
                    additionalcostinfo.Credit = decimal.Parse(sdrreader[5].ToString());
                    additionalcostinfo.ExtraDate = DateTime.Parse(sdrreader[6].ToString());
                    additionalcostinfo.Extra1 = sdrreader[7].ToString();
                    additionalcostinfo.Extra2 = sdrreader[8].ToString();
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
            return additionalcostinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="AdditionalCostId"></param>
        public void AdditionalCostDelete(decimal AdditionalCostId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@additionalCostId", SqlDbType.Decimal);
                sprmparam.Value = AdditionalCostId;
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
        /// To get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int AdditionalCostGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostMax", sqlcon);
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
        /// Function to get all  values from AdditionalCost table based on the parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> AdditionalCostViewAllByVoucherTypeIdAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AdditionalCostViewAllByVoucherTypeIdAndVoucherNo", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Update particular values from AdditionalCost table based on the parameter 
        /// </summary>
        /// <param name="additionalcostinfo"></param>
        public void AdditionalCostEditByVoucherTypeIdAndVoucherNo(AdditionalCostInfo additionalcostinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AdditionalCostEditByVoucherTypeIdAndVoucherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Debit;
                sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
                sprmparam.Value = additionalcostinfo.Credit;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = additionalcostinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = additionalcostinfo.Extra2;
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
        /// Function to get all the AdditionalCost for StockJournal Register or Report
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public DataSet StockJournalAdditionalCostForRegisteOrReport(string strVoucherNo, decimal decVoucherTypeId)
        {
            DataSet dsData = new DataSet();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("StockJournalAdditionalCostForRegisteOrReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.Fill(dsData);
            }
            catch (Exception)
            {
                throw;
            }
            return dsData;
        }
        /// <summary>
        /// Function to delete particular values based on parameters
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        public void DeleteAdditionalCostForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeleteAdditionalCostForStockJournalEdit", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                cmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
    }
}
