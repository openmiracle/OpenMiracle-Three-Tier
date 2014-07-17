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
//Summary description for CompanySP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class CompanySP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Company Table
        /// </summary>
        /// <param name="companyinfo"></param>
        public void CompanyAdd(CompanyInfo companyinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = companyinfo.CompanyId;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.EmailId;
                sprmparam = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Web;
                sprmparam = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Country;
                sprmparam = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.State;
                sprmparam = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pin;
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = companyinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.FinancialYearFrom;
                sprmparam = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.BooksBeginingFrom;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.CurrentDate;
                sprmparam = sccmd.Parameters.Add("@logo", SqlDbType.Image);
                sprmparam.Value = companyinfo.Logo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.ExtraDate;
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
        /// Function to Update values in Company Table
        /// </summary>
        /// <param name="companyinfo"></param>
        public void CompanyEdit(CompanyInfo companyinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = companyinfo.CompanyId;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.EmailId;
                sprmparam = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Web;
                sprmparam = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Country;
                sprmparam = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.State;
                sprmparam = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pin;
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = companyinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.FinancialYearFrom;
                sprmparam = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.BooksBeginingFrom;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.CurrentDate;
                sprmparam = sccmd.Parameters.Add("@logo", SqlDbType.Image);
                sprmparam.Value = companyinfo.Logo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra2;
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
        /// Function to get all the values from Company Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CompanyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CompanyViewAll", sqlcon);
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
        /// Function to get particular values from Company table based on the parameter
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public CompanyInfo CompanyView(decimal companyId)
        {
            CompanyInfo companyinfo = new CompanyInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = companyId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    companyinfo.CompanyId = decimal.Parse(sdrreader[0].ToString());
                    companyinfo.CompanyName = sdrreader[1].ToString();
                    companyinfo.MailingName = sdrreader[2].ToString();
                    companyinfo.Address = sdrreader[3].ToString();
                    companyinfo.Phone = sdrreader[4].ToString();
                    companyinfo.Mobile = sdrreader[5].ToString();
                    companyinfo.EmailId = sdrreader[6].ToString();
                    companyinfo.Web = sdrreader[7].ToString();
                    companyinfo.Country = sdrreader[8].ToString();
                    companyinfo.State = sdrreader[9].ToString();
                    companyinfo.Pin = sdrreader[10].ToString();
                    companyinfo.CurrencyId = decimal.Parse(sdrreader[11].ToString());
                    companyinfo.FinancialYearFrom = DateTime.Parse(sdrreader[12].ToString());
                    companyinfo.BooksBeginingFrom = DateTime.Parse(sdrreader[13].ToString());
                    companyinfo.Tin = sdrreader[14].ToString();
                    companyinfo.Cst = sdrreader[15].ToString();
                    companyinfo.Pan = sdrreader[16].ToString();
                    companyinfo.CurrentDate = DateTime.Parse(sdrreader[17].ToString());
                    companyinfo.Logo = (byte[])(sdrreader[18]);
                    companyinfo.Extra1 = sdrreader[19].ToString();
                    companyinfo.Extra2 = sdrreader[20].ToString();
                    companyinfo.ExtraDate = DateTime.Parse(sdrreader[21].ToString());
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
            return companyinfo;
        }
        
        /// <summary>
        /// Function to get the company details for dotmatrix
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CompanyViewForDotMatrix()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl=new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("CompanyViewForDotMatrix", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
       /// <summary>
       /// Company view details in a datatable
       /// </summary>
       /// <param name="companyId"></param>
       /// <returns></returns>
        public List<DataTable> CompanyViewDataTable(decimal companyId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("CompanyView", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = companyId;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="CompanyId"></param>
        public void CompanyDelete(decimal CompanyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = CompanyId;
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
        /// Function to  get the next id for Company table
        /// </summary>
        /// <returns></returns>
        public int CompanyGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyMax", sqlcon);
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
        /// Function to insert values to Company Table
        /// </summary>
        /// <param name="companyinfo"></param>
        /// <returns></returns>
        public decimal CompanyAddParticularFeilds(CompanyInfo companyinfo)
        {
            decimal decCopmanyId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyAddParticularFeilds", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@emailId", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.EmailId;
                sprmparam = sccmd.Parameters.Add("@web", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Web;
                sprmparam = sccmd.Parameters.Add("@country", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Country;
                sprmparam = sccmd.Parameters.Add("@state", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.State;
                sprmparam = sccmd.Parameters.Add("@pin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pin;
                sprmparam = sccmd.Parameters.Add("@currencyId", SqlDbType.Decimal);
                sprmparam.Value = companyinfo.CurrencyId;
                sprmparam = sccmd.Parameters.Add("@financialYearFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.FinancialYearFrom;
                sprmparam = sccmd.Parameters.Add("@booksBeginingFrom", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.BooksBeginingFrom;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@currentDate", SqlDbType.DateTime);
                sprmparam.Value = companyinfo.CurrentDate;
                sprmparam = sccmd.Parameters.Add("@logo", SqlDbType.Image);
                sprmparam.Value = companyinfo.Logo;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companyinfo.Extra2;
                decCopmanyId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decCopmanyId;
        }
       /// <summary>
       /// Function to check existance of company
       /// </summary>
       /// <param name="strCompanyName"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
        public bool CompanyCheckExistence(String strCompanyName, decimal decCompanyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CompanyCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = strCompanyName;
                sprmparam = sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
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
       /// Function to count the company
       /// </summary>
       /// <returns></returns>
        public int CompanyCount()
        {
            int inCount = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    try
                    {
                        sqlcon.Open();
                    }
                    catch
                    {
                        inCount = -1;
                    }
                }
                SqlCommand sccmd = new SqlCommand("CompanyCount", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                inCount = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                inCount = -1;
            }
            finally
            {
                sqlcon.Close();
            }
            return inCount;
        }
        /// <summary>
        /// Company current date edit
        /// </summary>
        /// <param name="dtCurrentDate"></param>
        public void CompanyCurrentDateEdit(DateTime dtCurrentDate)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("CompanyCurrentDateEdit", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal).Value = 1;//PublicVariables._decCurrentCompanyId;
                sqlcmd.Parameters.Add("@currentDate", SqlDbType.DateTime).Value = dtCurrentDate;
                sqlcmd.ExecuteNonQuery();
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
        /// Function to view all company for selectcompany form
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CompanyViewAllForSelectCompany()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CompanyViewAllForSelectCompany", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SlNo", typeof(decimal));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
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
        /// Company get Id for the company
        /// </summary>
        /// <returns></returns>
        public decimal CompanyGetIdIfSingleCompany()
        {
            decimal decCompanyId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyGetIdIfSingleCompany", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                decCompanyId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decCompanyId;
        }
        
        /// <summary>
        /// Function for storedprocedure inserter
        /// </summary>
        /// <param name="strParameter"></param>
        /// <returns></returns>
        public string StoredProcedureInserter(string strParameter)
        {
            string error = "";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string str = "IF NOT EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name='StoredProcedureInserter')"
                + " BEGIN EXECUTE('CREATE PROCEDURE StoredProcedureInserter @parameter varchar(max) AS execute(@parameter)')"
                + " END";
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                sqlcmd.ExecuteNonQuery();
                SqlCommand sccmd = new SqlCommand("StoredProcedureInserter", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@parameter", SqlDbType.VarChar);
                sprmparam.Value = strParameter;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                sqlcon.Close();
            }
            return error;
        }
    }
}
