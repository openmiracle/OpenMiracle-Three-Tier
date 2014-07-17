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
//Summary description for BarcodeSettingsSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class BarcodeSettingsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to BarcodeSettings table
        /// </summary>
        /// <param name="barcodesettingsinfo"></param>
        public void BarcodeSettingsAdd(BarcodeSettingsInfo barcodesettingsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsAddorEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@showProductCode", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowProductCode;
                sprmparam = sccmd.Parameters.Add("@showCompanyName", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowCompanyName;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@showPurchaseRate", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowPurchaseRate;
                sprmparam = sccmd.Parameters.Add("@showMRP", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowMRP;
                sprmparam = sccmd.Parameters.Add("@point", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Point;
                sprmparam = sccmd.Parameters.Add("@zero", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Zero;
                sprmparam = sccmd.Parameters.Add("@one", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.One;
                sprmparam = sccmd.Parameters.Add("@two", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Two;
                sprmparam = sccmd.Parameters.Add("@three", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Three;
                sprmparam = sccmd.Parameters.Add("@four", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Four;
                sprmparam = sccmd.Parameters.Add("@five", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Five;
                sprmparam = sccmd.Parameters.Add("@six", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Six;
                sprmparam = sccmd.Parameters.Add("@seven", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Seven;
                sprmparam = sccmd.Parameters.Add("@eight", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Eight;
                sprmparam = sccmd.Parameters.Add("@nine", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Nine;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Extra2;
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
        /// Function to Update values in BarcodeSettings table
        /// </summary>
        /// <param name="barcodesettingsinfo"></param>
        public void BarcodeSettingsEdit(BarcodeSettingsInfo barcodesettingsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
                sprmparam.Value = barcodesettingsinfo.BarcodeSettingsId;
                sprmparam = sccmd.Parameters.Add("@showProductCode", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowProductCode;
                sprmparam = sccmd.Parameters.Add("@showCompanyName", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowCompanyName;
                sprmparam = sccmd.Parameters.Add("@companyName", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.CompanyName;
                sprmparam = sccmd.Parameters.Add("@showPurchaseRate", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowPurchaseRate;
                sprmparam = sccmd.Parameters.Add("@showMRP", SqlDbType.Bit);
                sprmparam.Value = barcodesettingsinfo.ShowMRP;
                sprmparam = sccmd.Parameters.Add("@point", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Point;
                sprmparam = sccmd.Parameters.Add("@zero", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Zero;
                sprmparam = sccmd.Parameters.Add("@one", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.One;
                sprmparam = sccmd.Parameters.Add("@two", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Two;
                sprmparam = sccmd.Parameters.Add("@three", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Three;
                sprmparam = sccmd.Parameters.Add("@four", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Four;
                sprmparam = sccmd.Parameters.Add("@five", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Five;
                sprmparam = sccmd.Parameters.Add("@six", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Six;
                sprmparam = sccmd.Parameters.Add("@seven", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Seven;
                sprmparam = sccmd.Parameters.Add("@eight", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Eight;
                sprmparam = sccmd.Parameters.Add("@nine", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Nine;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = barcodesettingsinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = barcodesettingsinfo.ExtraDate;
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
        /// Function to view all details from BarcodeSettings table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BarcodeSettingsViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                DataTable dtbl = new DataTable();
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BarcodeSettingsViewAll", sqlcon);
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
        /// Function to view particular values based on parameter
        /// </summary>
        /// <param name="barcodeSettingsId"></param>
        /// <returns></returns>
        public BarcodeSettingsInfo BarcodeSettingsView(decimal barcodeSettingsId)
        {
            BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
                sprmparam.Value = barcodeSettingsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    barcodesettingsinfo.BarcodeSettingsId = decimal.Parse(sdrreader[0].ToString());
                    barcodesettingsinfo.ShowProductCode = bool.Parse(sdrreader[1].ToString());
                    barcodesettingsinfo.ShowCompanyName = bool.Parse(sdrreader[2].ToString());
                    barcodesettingsinfo.CompanyName = sdrreader[3].ToString();
                    barcodesettingsinfo.ShowPurchaseRate = bool.Parse(sdrreader[4].ToString());
                    barcodesettingsinfo.ShowMRP = bool.Parse(sdrreader[5].ToString());
                    barcodesettingsinfo.Point = sdrreader[6].ToString();
                    barcodesettingsinfo.Zero = sdrreader[7].ToString();
                    barcodesettingsinfo.One = sdrreader[8].ToString();
                    barcodesettingsinfo.Two = sdrreader[9].ToString();
                    barcodesettingsinfo.Three = sdrreader[10].ToString();
                    barcodesettingsinfo.Four = sdrreader[11].ToString();
                    barcodesettingsinfo.Five = sdrreader[12].ToString();
                    barcodesettingsinfo.Six = sdrreader[13].ToString();
                    barcodesettingsinfo.Seven = sdrreader[14].ToString();
                    barcodesettingsinfo.Eight = sdrreader[15].ToString();
                    barcodesettingsinfo.Nine = sdrreader[16].ToString();
                    barcodesettingsinfo.Extra1 = sdrreader[17].ToString();
                    barcodesettingsinfo.Extra2 = sdrreader[18].ToString();
                    barcodesettingsinfo.ExtraDate = DateTime.Parse(sdrreader[19].ToString());
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
            return barcodesettingsinfo;
        }
        /// <summary>
        /// Function to view all values for Barcode Printing
        /// </summary>
        /// <returns></returns>
        public BarcodeSettingsInfo BarcodeSettingsViewForBarCodePrinting()
        {
            BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsViewForBarcodePrinting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    barcodesettingsinfo.BarcodeSettingsId = decimal.Parse(sdrreader[0].ToString());
                    barcodesettingsinfo.ShowProductCode = bool.Parse(sdrreader[2].ToString());
                    barcodesettingsinfo.ShowCompanyName = bool.Parse(sdrreader[1].ToString());
                    barcodesettingsinfo.CompanyName = sdrreader[3].ToString();
                    barcodesettingsinfo.ShowPurchaseRate = bool.Parse(sdrreader[4].ToString());
                    barcodesettingsinfo.ShowMRP = bool.Parse(sdrreader[5].ToString());
                    barcodesettingsinfo.Point = sdrreader[6].ToString();
                    barcodesettingsinfo.Zero = sdrreader[7].ToString();
                    barcodesettingsinfo.One = sdrreader[8].ToString();
                    barcodesettingsinfo.Two = sdrreader[9].ToString();
                    barcodesettingsinfo.Three = sdrreader[10].ToString();
                    barcodesettingsinfo.Four = sdrreader[11].ToString();
                    barcodesettingsinfo.Five = sdrreader[12].ToString();
                    barcodesettingsinfo.Six = sdrreader[13].ToString();
                    barcodesettingsinfo.Seven = sdrreader[14].ToString();
                    barcodesettingsinfo.Eight = sdrreader[15].ToString();
                    barcodesettingsinfo.Nine = sdrreader[16].ToString();
                    barcodesettingsinfo.Extra1 = sdrreader[17].ToString();
                    barcodesettingsinfo.Extra2 = sdrreader[18].ToString();
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
            return barcodesettingsinfo;
        }
        /// <summary>
        /// Function to delete particular values based on parameter
        /// </summary>
        /// <param name="BarcodeSettingsId"></param>
        public void BarcodeSettingsDelete(decimal BarcodeSettingsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@barcodeSettingsId", SqlDbType.Decimal);
                sprmparam.Value = BarcodeSettingsId;
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
        /// Function to  get the next id for BarcodeSettings table
        /// </summary>
        /// <returns></returns>
        public int BarcodeSettingsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BarcodeSettingsMax", sqlcon);
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
    }
}
