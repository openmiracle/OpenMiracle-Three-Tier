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
//Summary description for UnitSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public class UnitSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to account group Table
        /// </summary>
        /// <param name="unitinfo"></param>
        /// <returns></returns>
        public decimal UnitAdd(UnitInfo unitinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.UnitName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
                sprmparam.Value = unitinfo.noOfDecimalplaces;
                sprmparam = sccmd.Parameters.Add("@formalName", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.formalName;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Extra2;
                decIdentity = decimal.Parse(sccmd.ExecuteScalar().ToString());
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
        /// Function to Update values in account group Table
        /// </summary>
        /// <param name="unitinfo"></param>
        /// <returns></returns>
        public bool UnitEdit(UnitInfo unitinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitinfo.UnitId;
                sprmparam = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.UnitName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@noOfDecimalplaces", SqlDbType.Decimal);
                sprmparam.Value = unitinfo.noOfDecimalplaces;
                sprmparam = sccmd.Parameters.Add("@formalName", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.formalName;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = unitinfo.Extra2;
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
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> UnitViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
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
        /// Function to get particular values from account group table based on the parameter
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public UnitInfo UnitView(decimal unitId)
        {
            UnitInfo unitinfo = new UnitInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = unitId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    unitinfo.UnitId = Convert.ToDecimal(sdrreader["unitId"]);
                    unitinfo.UnitName = sdrreader["unitName"].ToString();
                    unitinfo.Narration = sdrreader["narration"].ToString();
                    unitinfo.noOfDecimalplaces = Convert.ToDecimal(sdrreader["noOfDecimalplaces"].ToString());
                    unitinfo.formalName = sdrreader["formalName"].ToString();
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
            return unitinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="UnitId"></param>
        public void UnitDelete(decimal UnitId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = UnitId;
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
        /// Function to  get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int UnitGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitMax", sqlcon);
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
        /// Function to get all details for search based on parameter
        /// </summary>
        /// <param name="strUnitName"></param>
        /// <returns></returns>
        public List<DataTable> UnitSearch(string strUnitName)
        {
            EmployeeInfo infoEmployee = new EmployeeInfo();
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("UnitSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@unitName", SqlDbType.VarChar).Value = strUnitName;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existence of Unit based on parameter
        /// </summary>
        /// <param name="strUnitName"></param>
        /// <param name="decUnitid"></param>
        /// <returns></returns>
        public bool UnitCheckExistence(string strUnitName, decimal decUnitid)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
                sprmparam.Value = strUnitName;
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.VarChar);
                sprmparam.Value = decUnitid;
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
        /// Function for unit VieW For StandardRate based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public UnitInfo unitVieWForStandardRate(decimal decProductId)
        {
            UnitInfo infoUnit = new UnitInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("unitVieWForStandardRate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoUnit.UnitId = Convert.ToDecimal(sqldr["unitId"].ToString());
                    infoUnit.UnitName = (sqldr["unitName"].ToString());
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
            return infoUnit;
        }
        /// <summary>
        /// Function for Unit view for PriceListPopUp based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public UnitInfo UnitViewForPriceListPopUp(decimal decProductId)
        {
            UnitInfo infoUnit = new UnitInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("UnitViewForPriceListPopUp", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@productId", SqlDbType.Decimal).Value = decProductId;
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    infoUnit.UnitId = Convert.ToDecimal(sqldr["unitId"].ToString());
                    infoUnit.UnitName = (sqldr["unitName"].ToString());
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
            return infoUnit;
        }
        /// <summary>
        /// Function to check refernce and delete based on parameter
        /// </summary>
        /// <param name="UnitId"></param>
        /// <returns></returns>
        public decimal UnitDeleteCheck(decimal UnitId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitDeleteCheckexistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = UnitId;
                decReturnValue = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
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
        /// Function to get Unit name based on parameter
        /// </summary>
        /// <param name="UnitId"></param>
        /// <returns></returns>
        public string UnitName(decimal UnitId)
        {
            string strReturnValue = "";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = UnitId;
                strReturnValue = Convert.ToString((sccmd.ExecuteScalar()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strReturnValue;
        }
        /// <summary>
        /// Function to view unit based on parameter
        /// </summary>
        /// <param name="UnitName"></param>
        /// <returns></returns>
        public decimal UnitIdByUnitName(string UnitName)
        {
            decimal decUnitId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitIdBYUnitName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitName", SqlDbType.VarChar);
                sprmparam.Value = UnitName;
                decUnitId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decUnitId;
        }
        /// <summary>
        /// Function to vioew all unit based on parameter
        /// </summary>
        /// <param name="decUnitId"></param>
        /// <returns></returns>
        public List<DataTable> UnitViewAllWithoutPerticularId(decimal decUnitId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitViewAllWithoutPerticularId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = decUnitId;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAllWithoutPerticularId", sqlcon);
                sdaadapter.SelectCommand = sccmd;
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
        /// Function for unit combofill based on parameter
        /// </summary>
        /// <param name="dgvCurrent"></param>
        /// <param name="strProductId"></param>
        /// <param name="inRowIndex"></param>
        /// <returns></returns>
        public DataTable DGVUnitComboFillByProductId(DataGridView dgvCurrent, string strProductId, int inRowIndex)
        {
            DataTable dtblUnitViewAll = new DataTable();
            string strUnitName = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAllByProductIdForSalesReturn", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar);
                sqlparameter.Value = strProductId;
                sdaadapter.Fill(dtblUnitViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            try
            {
                DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbUnit"].Index, inRowIndex];
                dgvCurrent[dgvCurrent.Columns["dgvCmbUnit"].Index, inRowIndex].Value = null;
                if (dtblUnitViewAll.Rows.Count > 0)
                {
                    dgvcmbUnit.DataSource = dtblUnitViewAll;
                    foreach (DataRow item in dtblUnitViewAll.Rows)
                    {
                        strUnitName = item["unitName"].ToString();
                        if (strUnitName != "NA")
                        {
                            DataRow dr = dtblUnitViewAll.NewRow();
                            dr["unitName"] = "NA";
                            dr["unitId"] = 1;
                            dtblUnitViewAll.Rows.InsertAt(dr, 0);
                        }
                        break;
                    }
                    dgvcmbUnit.DisplayMember = "unitName";
                    dgvcmbUnit.ValueMember = "unitId";
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
            return dtblUnitViewAll;
        }
        /// <summary>
        /// Function for Unit Conversion check based on parameter
        /// </summary>
        /// <param name="decUnitId"></param>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public string UnitConversionCheck(decimal decUnitId, decimal decProductId)
        {
            string strQuantities = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("UnitConversionCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@unitId", SqlDbType.Decimal);
                sprmparam.Value = decUnitId;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                strQuantities = Convert.ToString(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strQuantities;
        }
        /// <summary>
        /// Function to view all based on parameter
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public List<DataTable> UnitViewAllByProductId(decimal decProductId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("UnitViewAllByProductId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
    }
}
