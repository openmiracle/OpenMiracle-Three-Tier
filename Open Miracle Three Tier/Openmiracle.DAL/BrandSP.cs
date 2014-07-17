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
//Summary description for BrandSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class BrandSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to brand Table
        /// </summary>
        /// <param name="brandinfo"></param>
        /// <returns></returns>
        public decimal BrandAdd(BrandInfo brandinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.BrandName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@manufacturer", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Manufacturer;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = brandinfo.ExtraDate;
                decimal inEffectedRow = Convert.ToDecimal(sccmd.ExecuteScalar());
                if (inEffectedRow > 0)
                {
                    return inEffectedRow;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in brand Table
        /// </summary>
        /// <param name="brandinfo"></param>
        /// <returns></returns>
        public bool BrandEdit(BrandInfo brandinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = brandinfo.BrandId;
                sprmparam = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.BrandName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@manufacturer", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Manufacturer;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = brandinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = brandinfo.ExtraDate;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
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
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get all the values from Brand Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BrandViewAll()
        {
            List<DataTable> listobj=new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BrandViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listobj;
        }
        /// <summary>
        /// Function to get particular values from brand table based on the parameter
        /// </summary>
        /// <param name="brandId"></param>
        /// <returns></returns>
        public BrandInfo BrandView(decimal brandId)
        {
            BrandInfo brandinfo = new BrandInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = brandId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    brandinfo.BrandName = sdrreader[1].ToString();
                    brandinfo.Narration = sdrreader[2].ToString();
                    brandinfo.Manufacturer = sdrreader[3].ToString();
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
            return brandinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BrandId"></param>
        public void BrandDelete(decimal BrandId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = BrandId;
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
        /// Function to  get the next id for brand table
        /// </summary>
        /// <returns></returns>
        public int BrandGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandMax", sqlcon);
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
        /// Function to search a brand
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <returns></returns>
        public List<DataTable> BrandSearch(string strBrandName)
        {
            List<DataTable> listobj = new List<DataTable>();
            EmployeeInfo infoEmployee = new EmployeeInfo();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("BrandSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@brandName", SqlDbType.VarChar).Value = strBrandName;
                sqlda.Fill(dtbl);
                listobj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listobj;
        }
       
        /// <summary>
        /// Function to check existance of a brand
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <param name="decBrandId"></param>
        /// <returns></returns>
        public bool BrandCheckIfExist(string strBrandName, decimal decBrandId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandCheckIfExist", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandName", SqlDbType.VarChar);
                sprmparam.Value = strBrandName;
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = decBrandId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to delete a brand by checking existance
        /// </summary>
        /// <param name="BrandId"></param>
        /// <returns></returns>
        public decimal BrandDeleteCheckExistence(decimal BrandId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BrandDeleteCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@brandId", SqlDbType.Decimal);
                sprmparam.Value = BrandId;
                decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
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
    }
}
