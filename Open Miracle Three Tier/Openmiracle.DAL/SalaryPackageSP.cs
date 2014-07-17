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
//Summary description for SalaryPackageSP    
//</summary>    
namespace OpenMiracle.DAL    
{
    public class SalaryPackageSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalaryPackage Table
        /// </summary>
        /// <param name="salarypackageinfo"></param>
        /// <returns></returns>
        public decimal SalaryPackageAdd(SalaryPackageInfo salarypackageinfo)
        {
            decimal decIdentity = -1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageWithRetunIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.SalaryPackageName;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = salarypackageinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salarypackageinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Extra2;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decIdentity = Convert.ToDecimal(obj.ToString());
                }
                else
                {
                    decIdentity = -1;
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
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in SalaryPackage Table
        /// </summary>
        /// <param name="salarypackageinfo"></param>
        public void SalaryPackageEdit(SalaryPackageInfo salarypackageinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = salarypackageinfo.SalaryPackageId;
                sprmparam = sccmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.SalaryPackageName;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = salarypackageinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = salarypackageinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salarypackageinfo.Extra2;
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
        /// Function to get all the values from SalaryPackage Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SalaryPackageViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from SalaryPackage table based on the parameter
        /// </summary>
        /// <param name="salaryPackageId"></param>
        /// <returns></returns>
        public SalaryPackageInfo SalaryPackageView(decimal salaryPackageId)
        {
            SalaryPackageInfo salarypackageinfo = new SalaryPackageInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = salaryPackageId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salarypackageinfo.SalaryPackageId = Convert.ToDecimal(sdrreader[0].ToString());
                    salarypackageinfo.SalaryPackageName = sdrreader[1].ToString();
                    salarypackageinfo.IsActive = Convert.ToBoolean(sdrreader[2].ToString());
                    salarypackageinfo.Narration = sdrreader[3].ToString();
                    salarypackageinfo.Extra1 = sdrreader[4].ToString();
                    salarypackageinfo.Extra2 = sdrreader[5].ToString();
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
            return salarypackageinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalaryPackageId"></param>
        public void SalaryPackageDelete(decimal SalaryPackageId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = SalaryPackageId;
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
        /// Function to  get the next id for SalaryPackage table
        /// </summary>
        /// <returns></returns>
        public int SalaryPackageGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageMax", sqlcon);
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
        /// Function to get all the values from SalaryPackage Table for monthlysalarysettings
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SalaryPackageViewAllForMonthlySalarySettings()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAllForMonthlySalarySettings", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalaryPackageId"></param>
        public void SalaryPackageDeleteAll(decimal SalaryPackageId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDeleteAll", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = SalaryPackageId;
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
        /// Function to check existance of salarypackagename
        /// </summary>
        /// <param name="strSalaryPackageName"></param>
        /// <returns></returns>
        public bool SalaryPackageNameCheckExistance(string strSalaryPackageName)
        {
            bool isExists = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalaryPackageNameCheckExistance", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salaryPackageName", SqlDbType.VarChar);
                sprmparam.Value = strSalaryPackageName;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    isExists = true;
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
            return isExists;
        }
        /// <summary>
        /// Function to get the details for salarypackage register
        /// </summary>
        /// <param name="strSalaryPackageName"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> SalaryPackageregisterSearch(string strSalaryPackageName, string strStatus)
        {
            SalaryPackageSP spSalaryPackage = new SalaryPackageSP();
            DataTable dtblSalaryPackage = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageregisterSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblSalaryPackage.Columns.Add("SLNO", typeof(decimal));
                dtblSalaryPackage.Columns["SLNO"].AutoIncrement = true;
                dtblSalaryPackage.Columns["SLNO"].AutoIncrementSeed = 1;
                dtblSalaryPackage.Columns["SLNO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@salaryPackageName", SqlDbType.VarChar).Value = strSalaryPackageName;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strStatus;
                sqlda.Fill(dtblSalaryPackage);
                ListObj.Add(dtblSalaryPackage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get the details for salarypackage report
        /// </summary>
        /// <param name="strPackageName"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> SalaryPackageViewAllForSalaryPackageReport(string strPackageName, string strStatus)
        {
            DataTable dtblSalaryPackage = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            dtblSalaryPackage.Columns.Add("SlNo", typeof(int));
            dtblSalaryPackage.Columns["SlNo"].AutoIncrement = true;
            dtblSalaryPackage.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblSalaryPackage.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageViewAllForSalaryPackageReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@packageName", SqlDbType.VarChar).Value = strPackageName;
                sqlda.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strStatus;
                sqlda.Fill(dtblSalaryPackage);
                ListObj.Add(dtblSalaryPackage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get all the values from SalaryPackage Table for active
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SalaryPackageViewAllForActive()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageViewAllForActive", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
    }
}
