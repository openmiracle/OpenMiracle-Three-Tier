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
//Summary description for FinancialYearSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class FinancialYearSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to FinancialYear Table
        /// </summary>
        /// <param name="financialyearinfo"></param>
        public void FinancialYearAdd(FinancialYearInfo financialyearinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ExtraDate;
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
        /// Function to Update values in FinancialYear Table
        /// </summary>
        /// <param name="financialyearinfo"></param>
        public void FinancialYearEdit(FinancialYearInfo financialyearinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = financialyearinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = financialyearinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = financialyearinfo.Extra2;
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
        /// Function to get all the values from FinancialYear Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> FinancialYearViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("FinancialYearViewAll", sqlcon);
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
        /// Function to get particular values from FinancialYear  table based on the parameter
        /// </summary>
        /// <param name="financialYearId"></param>
        /// <returns></returns>
        public FinancialYearInfo FinancialYearView(decimal financialYearId)
        {
            FinancialYearInfo financialyearinfo = new FinancialYearInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = financialYearId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    financialyearinfo.FinancialYearId = decimal.Parse(sdrreader[0].ToString());
                    financialyearinfo.FromDate = DateTime.Parse(sdrreader[1].ToString());
                    financialyearinfo.ToDate = DateTime.Parse(sdrreader[2].ToString());
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
            return financialyearinfo;
        }
        /// <summary>
        /// Function to get particular values from FinancialYear table For AccountLedger based on the parameter
        /// </summary>
        /// <param name="financialYearId"></param>
        /// <returns></returns>
        public FinancialYearInfo FinancialYearViewForAccountLedger(decimal financialYearId)
        {
            FinancialYearInfo financialyearinfo = new FinancialYearInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearViewForAccountLedger", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = financialYearId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    financialyearinfo.FinancialYearId = decimal.Parse(sdrreader[0].ToString());
                    financialyearinfo.FromDate = DateTime.Parse(sdrreader[1].ToString());
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
            return financialyearinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="FinancialYearId"></param>
        public void FinancialYearDelete(decimal FinancialYearId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = FinancialYearId;
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
        /// Function to  get the next id for FinancialYear table
        /// </summary>
        /// <returns></returns>
        public string FinancialYearGetMax()
        {
            string strMax = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strMax = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strMax;
        }
        /// <summary>
        /// Function to insert values and return id 
        /// </summary>
        /// <param name="financialyearinfo"></param>
        /// <returns></returns>
        public decimal FinancialYearAddWithReturnIdentity(FinancialYearInfo financialyearinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = financialyearinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = financialyearinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = financialyearinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
        /// Function to check existence based on parameter and return status
        /// </summary>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <returns></returns>
        public bool FinancialYearExistenceCheck(DateTime dtFromDate, DateTime dtToDate)
        {
            bool trueOrfalse = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FinancialYearExistenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtFromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dtToDate;
                int inD = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
                if (inD == 0)
                {
                    trueOrfalse = true;
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
            return trueOrfalse;
        }
    }
}
