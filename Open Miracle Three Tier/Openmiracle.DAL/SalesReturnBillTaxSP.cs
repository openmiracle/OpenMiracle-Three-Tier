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
//Summary description for SalesReturnBillTaxSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SalesReturnBillTaxSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesReturnBillTax Table
        /// </summary>
        /// <param name="salesreturnbilltaxinfo"></param>
        public void SalesReturnBillTaxAdd(SalesReturnBillTaxInfo salesreturnbilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.SalesReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturnbilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturnbilltaxinfo.Extra2;
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
        /// Function to Update values in SalesReturnBillTax Table
        /// </summary>
        /// <param name="salesreturnbilltaxinfo"></param>
        public void SalesReturnBillTaxEdit(SalesReturnBillTaxInfo salesreturnbilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.SalesReturnBillTaxId;
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.SalesReturnMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesreturnbilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesreturnbilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesreturnbilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesreturnbilltaxinfo.Extra2;
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
        ///  Function to get all the values from SalesReturnBillTax Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesReturnBillTaxViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesReturnBillTaxViewAll", sqlcon);
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
        /// Function to get particular values from SalesReturnBillTax Table based on the parameter
        /// </summary>
        /// <param name="salesReturnBillTaxId"></param>
        /// <returns></returns>
        public SalesReturnBillTaxInfo SalesReturnBillTaxView(decimal salesReturnBillTaxId)
        {
            SalesReturnBillTaxInfo salesreturnbilltaxinfo = new SalesReturnBillTaxInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = salesReturnBillTaxId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesreturnbilltaxinfo.SalesReturnBillTaxId = decimal.Parse(sdrreader[0].ToString());
                    salesreturnbilltaxinfo.SalesReturnMasterId = decimal.Parse(sdrreader[1].ToString());
                    salesreturnbilltaxinfo.TaxId = decimal.Parse(sdrreader[2].ToString());
                    salesreturnbilltaxinfo.TaxAmount = decimal.Parse(sdrreader[3].ToString());
                    salesreturnbilltaxinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    salesreturnbilltaxinfo.Extra1 = sdrreader[5].ToString();
                    salesreturnbilltaxinfo.Extra2 = sdrreader[6].ToString();
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
            return salesreturnbilltaxinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalesReturnBillTaxId"></param>
        public void SalesReturnBillTaxDelete(decimal SalesReturnBillTaxId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = SalesReturnBillTaxId;
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
        /// Function to  get the next id for SalesReturnBillTax Table
        /// </summary>
        /// <returns></returns>
        public int SalesReturnBillTaxGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxMax", sqlcon);
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
        /// Function to view TaxDetails based on parameter
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        /// <returns></returns>
        public List<DataTable> TaxDetailsViewBySalesReturnMasterId(decimal decSalesReturnMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxDetailsViewBySalesReturnMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal).Value = decSalesReturnMasterId;
                sqlda.Fill(dtbl);
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
        /// Function to delete TaxDetails based on parameter
        /// </summary>
        /// <param name="SalesReturnMasterId"></param>
        public void SalesReturnBillTaxDeleteBySalesReturnMasterId(decimal SalesReturnMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesReturnBillTaxDeleteBySalesReturnMasterId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesReturnMasterId", SqlDbType.Decimal);
                sprmparam.Value = SalesReturnMasterId;
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
