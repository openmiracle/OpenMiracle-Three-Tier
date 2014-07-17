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
//Summary description for CompanyPathSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class CompanyPathSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to CompanyPath Table
        /// </summary>
        /// <param name="companypathinfo"></param>
        public void CompanyPathAdd(CompanyPathInfo companypathinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@companyPath", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyPath;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = companypathinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra2;
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
        /// Function to Update values in CompanyPath Table
        /// </summary>
        /// <param name="companypathinfo"></param>
        public void CompanyPathEdit(CompanyPathInfo companypathinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = companypathinfo.CompanyId;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@companyPath", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.CompanyPath;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = companypathinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = companypathinfo.Extra2;
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
        /// Function to get all the values from CompanyPath Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CompanyPathViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CompanyPathViewAll", sqlcon);
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
        /// Function to get particular values from CompanyPath Table based on the parameter
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public CompanyPathInfo CompanyPathView(decimal companyId)
        {
            CompanyPathInfo companypathinfo = new CompanyPathInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = companyId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    companypathinfo.CompanyId = decimal.Parse(sdrreader[0].ToString());
                    companypathinfo.CompanyName = sdrreader[1].ToString();
                    companypathinfo.CompanyPath = sdrreader[2].ToString();
                    companypathinfo.IsDefault = bool.Parse(sdrreader[3].ToString());
                    companypathinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    companypathinfo.Extra1 = sdrreader[5].ToString();
                    companypathinfo.Extra2 = sdrreader[6].ToString();
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
            return companypathinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table CompanyPath
        /// </summary>
        /// <param name="CompanyId"></param>
        public void CompanyPathDelete(decimal CompanyId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathDelete", sqlcon);
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
        /// Function to  get the next id for CompanyPath Table
        /// </summary>
        /// <returns></returns>
        public int CompanyPathGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyPathMax", sqlcon);
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
        /// Function to Company View For Default Company
        /// </summary>
        /// <returns></returns>
        public decimal CompanyViewForDefaultCompany()
        {
            decimal decCompanyId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CompanyViewForDefaultCompany", sqlcon);
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
    }
}
