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
//Summary description for SalesBillTaxSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SalesBillTaxSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalesBillTax Table
        /// </summary>
        /// <param name="salesbilltaxinfo"></param>
        /// <returns></returns>
        public decimal SalesBillTaxAdd(SalesBillTaxInfo salesbilltaxinfo)
        {
            decimal dcSalesBillTaxId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesbilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra2;
                dcSalesBillTaxId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dcSalesBillTaxId;
        }
        /// <summary>
        /// Function to Update values in SalesBillTax Table
        /// </summary>
        /// <param name="salesbilltaxinfo"></param>
        public void SalesBillTaxEdit(SalesBillTaxInfo salesbilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.SalesBillTaxId;
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesbilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra2;
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
        /// Function to get all the values from SalesBillTax Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalesBillTaxViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesBillTaxViewAll", sqlcon);
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
        /// Function to get particular values from SalesBillTax Table based on the parameter
        /// </summary>
        /// <param name="salesBillTaxId"></param>
        /// <returns></returns>
        public SalesBillTaxInfo SalesBillTaxView(decimal salesBillTaxId)
        {
            SalesBillTaxInfo salesbilltaxinfo = new SalesBillTaxInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = salesBillTaxId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salesbilltaxinfo.SalesBillTaxId = decimal.Parse(sdrreader[0].ToString());
                    salesbilltaxinfo.SalesMasterId = decimal.Parse(sdrreader[1].ToString());
                    salesbilltaxinfo.TaxId = decimal.Parse(sdrreader[2].ToString());
                    salesbilltaxinfo.TaxAmount = decimal.Parse(sdrreader[3].ToString());
                    salesbilltaxinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    salesbilltaxinfo.Extra1 = sdrreader[5].ToString();
                    salesbilltaxinfo.Extra2 = sdrreader[6].ToString();
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
            return salesbilltaxinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table SalesBillTax
        /// </summary>
        /// <param name="SalesBillTaxId"></param>
        public void SalesBillTaxDelete(decimal SalesBillTaxId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = SalesBillTaxId;
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
        /// Function to  get the next id for SalesBillTax Table
        /// </summary>
        /// <returns></returns>
        public int SalesBillTaxGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxMax", sqlcon);
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
        /// Function to view SalesInvoice SalesBill Tax  All By using SalesMasterId
        /// </summary>
        /// <param name="dcSalesmasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decimal dcSalesmasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesInvoiceSalesBillTaxViewAllBySalesMasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = dcSalesmasterId;
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
        /// Function to SalesBill Tax Edit By using SalesMasterId And TaxId
        /// </summary>
        /// <param name="salesbilltaxinfo"></param>
        public void SalesBillTaxEditBySalesMasterIdAndTaxId(SalesBillTaxInfo salesbilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalesBillTaxEditBySalesMasterIdAndTaxId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.SalesMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = salesbilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salesbilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salesbilltaxinfo.Extra2;
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
