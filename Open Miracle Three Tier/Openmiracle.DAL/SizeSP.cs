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
//Summary description for SizeSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SizeSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Size Table
        /// </summary>
        /// <param name="sizeinfo"></param>
        public void SizeAdd(SizeInfo sizeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = sizeinfo.SizeId;
                sprmparam = sccmd.Parameters.Add("@size", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Size;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = sizeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Extra2;
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
        /// Function to Update values in Size Table
        /// </summary>
        /// <param name="sizeinfo"></param>
        public void SizeEdit(SizeInfo sizeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = sizeinfo.SizeId;
                sprmparam = sccmd.Parameters.Add("@size", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Size;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = sizeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = sizeinfo.Extra2;
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
        /// Function to get all the values from Size Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SizeViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SizeViewAll", sqlcon);
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
        /// Function to get particular values from Size Table based on the parameter
        /// </summary>
        /// <param name="sizeId"></param>
        /// <returns></returns>
        public SizeInfo SizeView(decimal sizeId)
        {
            SizeInfo sizeinfo = new SizeInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = sizeId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    sizeinfo.SizeId = decimal.Parse(sdrreader[0].ToString());
                    sizeinfo.Size = sdrreader[1].ToString();
                    sizeinfo.Narration = sdrreader[2].ToString();
                    sizeinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    sizeinfo.Extra1 = sdrreader[4].ToString();
                    sizeinfo.Extra2 = sdrreader[5].ToString();
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
            return sizeinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SizeId"></param>
        public void SizeDelete(decimal SizeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = SizeId;
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
        /// Function to  get the next id for Size Table
        /// </summary>
        /// <returns></returns>
        public int SizeGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeMax", sqlcon);
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
        /// Function to insert values to Size Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="infoSize"></param>
        /// <returns></returns>
        public decimal SizeAdding(SizeInfo infoSize)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SizeAdding", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@size", SqlDbType.VarChar).Value = infoSize.Size;
                sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = infoSize.Narration;
                sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = infoSize.Extra1;
                sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = infoSize.Extra2;
                decimal deceffectedrow = Convert.ToDecimal(sqlcmd.ExecuteScalar());
                if (deceffectedrow > 0)
                {
                    return deceffectedrow;
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
        /// Function to Update values in Size Table and return the status
        /// </summary>
        /// <param name="infoSize"></param>
        /// <returns></returns>
        public bool SizeEditing(SizeInfo infoSize)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SizeEditing", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = infoSize.SizeId;
                sqlcmd.Parameters.Add("@size", SqlDbType.VarChar).Value = infoSize.Size;
                sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = infoSize.Narration;
                int ineffectedrow = sqlcmd.ExecuteNonQuery();
                if (ineffectedrow > 0)
                {
                    isEdit = true;
                }
                else
                {
                    isEdit = false;
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
            return isEdit;
        }
        /// <summary>
        /// Function to get  values from Size Table based on the parameter
        /// </summary>
        /// <param name="decSizeId"></param>
        /// <returns></returns>
        public SizeInfo SizeViewing(decimal decSizeId)
        {
            SizeInfo infoSize = new SizeInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SizeViewing", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal).Value = decSizeId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoSize.SizeId = decimal.Parse(sqldr["SizeId"].ToString());
                    infoSize.Size = sqldr["Size"].ToString();
                    infoSize.Narration = sqldr["Narration"].ToString();
                    infoSize.Extra1 = sqldr["Extra1"].ToString();
                    infoSize.Extra2 = sqldr["Extra2"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return infoSize;
        }
        /// <summary>
        /// Function to get all values from Size Table 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SizeViewAlling()
        {
            List<DataTable> ListObjSize = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl.No", typeof(decimal));
            dtbl.Columns["Sl.No"].AutoIncrement = true;
            dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SizeViewAlling", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                ListObjSize.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObjSize;
        }
        /// <summary>
        /// Function to check existence of size based on parameter
        /// </summary>
        /// <param name="strSizeName"></param>
        /// <param name="decSizeId"></param>
        /// <returns></returns>
        public bool SizeNameCheckExistence(String strSizeName, decimal decSizeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SizeNameCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@size", SqlDbType.VarChar);
                sprmparam.Value = strSizeName;
                sprmparam = sqlcmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = decSizeId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = decimal.Parse(obj.ToString());
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
        /// Function to delete size based on parameter and return corresponding id
        /// </summary>
        /// <param name="SizeId"></param>
        /// <returns></returns>
        public decimal SizeDeleting(decimal SizeId)
        {
            decimal decId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SizeDeleting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@sizeId", SqlDbType.Decimal);
                sprmparam.Value = SizeId;
                decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decId;
        }
    }
}
