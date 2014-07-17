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
//Summary description for TaxDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class TaxDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to TaxDetails Table
        /// </summary>
        /// <param name="taxdetailsinfo"></param>
        public void TaxDetailsAdd(TaxDetailsInfo taxdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.TaxdetailsId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.SelectedtaxId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = taxdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra2;
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
        /// Function to Update values in TaxDetails Table
        /// </summary>
        /// <param name="taxdetailsinfo"></param>
        public void TaxDetailsEdit(TaxDetailsInfo taxdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.TaxdetailsId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.SelectedtaxId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = taxdetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra2;
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
        /// Function to get all the values from TaxDetails Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxDetailsViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxDetailsViewAll", sqlcon);
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
        /// Function to get particular values from TaxDetails Table based on the parameter
        /// </summary>
        /// <param name="taxdetailsId"></param>
        /// <returns></returns>
        public TaxDetailsInfo TaxDetailsView(decimal taxdetailsId)
        {
            TaxDetailsInfo taxdetailsinfo = new TaxDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    taxdetailsinfo.TaxdetailsId = decimal.Parse(sdrreader[0].ToString());
                    taxdetailsinfo.TaxId = decimal.Parse(sdrreader[1].ToString());
                    taxdetailsinfo.SelectedtaxId = decimal.Parse(sdrreader[2].ToString());
                    taxdetailsinfo.ExtraDate = DateTime.Parse(sdrreader[3].ToString());
                    taxdetailsinfo.Extra1 = sdrreader[4].ToString();
                    taxdetailsinfo.Extra2 = sdrreader[5].ToString();
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
            return taxdetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="TaxdetailsId"></param>
        public void TaxDetailsDelete(decimal TaxdetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxdetailsId", SqlDbType.Decimal);
                sprmparam.Value = TaxdetailsId;
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
        /// Function to  get the next id for TaxDetails Table
        /// </summary>
        /// <returns></returns>
        public int TaxDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsMax", sqlcon);
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
        /// Function to insert values without id
        /// </summary>
        /// <param name="taxdetailsinfo"></param>
        public void TaxDetailsAddWithoutId(TaxDetailsInfo taxdetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsAddWithoutId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@selectedtaxId", SqlDbType.Decimal);
                sprmparam.Value = taxdetailsinfo.SelectedtaxId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxdetailsinfo.Extra2;
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
        /// Function to delete Tax Details based on parameter
        /// </summary>
        /// <param name="TaxdetailsId"></param>
        public void TaxDetailsDeleteWithTaxId(decimal TaxdetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDetailsDeleteWithTaxId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = TaxdetailsId;
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
        /// Function to view tax Details based on Parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxDetailsViewallByTaxId(decimal decTaxId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxDetailsViewallByTaxId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = decTaxId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
    }
}
