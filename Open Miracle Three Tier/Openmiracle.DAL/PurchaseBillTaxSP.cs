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
//Summary description for PurchaseBillTaxSP    
//</summary>    
namespace OpenMiracle.DAL 
{
    public class PurchaseBillTaxSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseBillTax Table
        /// </summary>
        /// <param name="purchasebilltaxinfo"></param>
        public void PurchaseBillTaxAdd(PurchaseBillTaxInfo purchasebilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseBillTaxAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasebilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasebilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasebilltaxinfo.Extra2;
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
        /// Function to Update values in PurchaseBillTax Table
        /// </summary>
        /// <param name="purchasebilltaxinfo"></param>
        public void PurchaseBillTaxEdit(PurchaseBillTaxInfo purchasebilltaxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseBillTaxEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.PurchaseBillTaxId;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasebilltaxinfo.TaxAmount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasebilltaxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasebilltaxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasebilltaxinfo.Extra2;
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
        /// Function to get all the values from PurchaseBillTax Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseBillTaxViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseBillTaxViewAll", sqlcon);
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
        /// Function to get particular values from PurchaseBillTax table based on the parameter
        /// </summary>
        /// <param name="purchaseBillTaxId"></param>
        /// <returns></returns>
        public PurchaseBillTaxInfo PurchaseBillTaxView(decimal purchaseBillTaxId)
        {
            PurchaseBillTaxInfo purchasebilltaxinfo = new PurchaseBillTaxInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseBillTaxView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = purchaseBillTaxId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchasebilltaxinfo.PurchaseBillTaxId = decimal.Parse(sdrreader[0].ToString());
                    purchasebilltaxinfo.PurchaseMasterId = decimal.Parse(sdrreader[1].ToString());
                    purchasebilltaxinfo.TaxId = decimal.Parse(sdrreader[2].ToString());
                    purchasebilltaxinfo.TaxAmount = decimal.Parse(sdrreader[3].ToString());
                    purchasebilltaxinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    purchasebilltaxinfo.Extra1 = sdrreader[5].ToString();
                    purchasebilltaxinfo.Extra2 = sdrreader[6].ToString();
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
            return purchasebilltaxinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PurchaseBillTaxId"></param>
        public void PurchaseBillTaxDelete(decimal PurchaseBillTaxId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseBillTaxDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseBillTaxId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseBillTaxId;
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
        /// Function to  get the next id for PurchaseBillTax table
        /// </summary>
        /// <returns></returns>
        public int PurchaseBillTaxGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseBillTaxMax", sqlcon);
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
        /// Function to get all the values from PurchaseBillTax Table by purchasemasterid
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseBillTaxViewAllByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseBillTaxViewAllByPurchaseMasterId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sdaadapter.Fill(dtbl);
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
