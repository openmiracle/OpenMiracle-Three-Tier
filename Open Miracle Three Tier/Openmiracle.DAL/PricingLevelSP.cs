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
//Summary description for PricingLevelSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PricingLevelSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PricingLevel Table
        /// </summary>
        /// <param name="pricinglevelinfo"></param>
        public void PricingLevelAdd(PricingLevelInfo pricinglevelinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricinglevelinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.PricinglevelName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra2;
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
        /// Function to Update values in PricingLevel Table
        /// </summary>
        /// <param name="pricinglevelinfo"></param>
        public void PricingLevelEdit(PricingLevelInfo pricinglevelinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricinglevelinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.PricinglevelName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra2;
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
        /// Function to get all the values from PricingLevel Table
        /// </summary>
        /// <returns></returns>
        public DataTable PricingLevelViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelViewAll", sqlcon);
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
        /// Function to get particular values from PricingLevel table based on the parameter
        /// </summary>
        /// <param name="pricinglevelId"></param>
        /// <returns></returns>
        public PricingLevelInfo PricingLevelView(decimal pricinglevelId)
        {
            PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricinglevelId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    pricinglevelinfo.PricinglevelId = Convert.ToDecimal(sdrreader[0].ToString());
                    pricinglevelinfo.PricinglevelName = sdrreader[1].ToString();
                    pricinglevelinfo.Narration = sdrreader[2].ToString();
                    pricinglevelinfo.Extra1 = sdrreader[4].ToString();
                    pricinglevelinfo.Extra2 = sdrreader[5].ToString();
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
            return pricinglevelinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PricinglevelId"></param>
        public void PricingLevelDelete(decimal PricinglevelId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = PricinglevelId;
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
        /// Function to  get the next id for PricingLevel table
        /// </summary>
        /// <returns></returns>
        public int PricingLevelGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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
        /// Function to insert values to PricingLevel table without same PricingLevel
        /// </summary>
        /// <param name="pricinglevelinfo"></param>
        /// <returns></returns>
        public decimal PricingLevelAddWithoutSamePricingLevel(PricingLevelInfo pricinglevelinfo)
        {
            decimal decPricingLevelId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelAddWithoutSamePricingLevel", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.PricinglevelName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Extra2;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decPricingLevelId = Convert.ToDecimal(obj.ToString());
                }
                else
                {
                    decPricingLevelId = 0;
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
            return decPricingLevelId;
        }
        /// <summary>
        /// Function to view all pricinglevel with serialno
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PricingLevelOnlyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelOnlyViewAll", sqlcon);
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
        /// Function to view all pricinglevel with narration
        /// </summary>
        /// <param name="decPricinglevelId"></param>
        /// <returns></returns>
        public PricingLevelInfo PricingLevelWithNarrationView(decimal decPricinglevelId)
        {
            PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelWithNarrationView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decPricinglevelId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    pricinglevelinfo.PricinglevelId = Convert.ToDecimal(sdrreader[0].ToString());
                    pricinglevelinfo.PricinglevelName = sdrreader[1].ToString();
                    pricinglevelinfo.Narration = sdrreader[2].ToString();
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
            return pricinglevelinfo;
        }
        /// <summary>
        /// Function to check existance of pricinglevel
        /// </summary>
        /// <param name="strPricingLevelName"></param>
        /// <param name="decPricingLevelId"></param>
        /// <returns></returns>
        public bool PricingLevelCheckIfExist(String strPricingLevelName, decimal decPricingLevelId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PricingLevelCheckIfExist", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
                sprmparam.Value = strPricingLevelName;
                sprmparam = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decPricingLevelId;
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
                    return false; ;
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
        /// Function to Update values in PricingLevel Table
        /// </summary>
        /// <param name="pricinglevelinfo"></param>
        /// <returns></returns>
        public bool PricingLevelEditParticularFields(PricingLevelInfo pricinglevelinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PricingLevelEditParticularField", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = pricinglevelinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelName", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.PricinglevelName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pricinglevelinfo.Narration;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
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
        /// Function to view all pricinglevel
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PricelistPricingLevelViewAllForComboBox()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricelistPricingLevelViewAllForComboBox", sqlcon);
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
        /// Function to delete particular details based on the parameter by checking reference
        /// </summary>
        /// <param name="decPricingLevelId"></param>
        /// <returns></returns>
        public decimal PricingLevelCheckReferenceAndDelete(decimal decPricingLevelId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PricingLevelCheckReferenceAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = decPricingLevelId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
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
        /// <summary>
        /// PricingLevel Name View For PriceList PopUp
        /// </summary>
        /// <param name="decPricingLevel"></param>
        /// <param name="decProductId"></param>
        /// <param name="decUnitId"></param>
        /// <returns></returns>
        public PricingLevelInfo PricingLevelNameViewForPriceListPopUp(decimal decPricingLevel, decimal decProductId, decimal decUnitId)
        {
            PricingLevelInfo infoPricingLevel = new PricingLevelInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PricingLevelNameViewForPriceListPopUp", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal).Value = decPricingLevel;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqlcmd.Parameters.Add("@unitId", SqlDbType.Decimal).Value = decUnitId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoPricingLevel.PricinglevelId = Convert.ToDecimal(sqldr["pricinglevelId"].ToString());
                    infoPricingLevel.PricinglevelName = sqldr["pricinglevelName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
                sqldr.Close();
            }
            return infoPricingLevel;
        }
    }
}
