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
//Summary description for RackSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class RackSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Rack Table
        /// </summary>
        /// <param name="rackinfo"></param>
        /// <returns></returns>
        public decimal RackAdd(RackInfo rackinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.RackName;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rackinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rackinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Extra2;
                decimal decEffectedRow = Convert.ToDecimal(sccmd.ExecuteScalar());
                if (decEffectedRow > 0)
                {
                    return decEffectedRow;
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
        /// Function to Update values in Rack Table
        /// </summary>
        /// <param name="rackinfo"></param>
        /// <returns></returns>
        public bool RackEdit(RackInfo rackinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rackinfo.RackId;
                sprmparam = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.RackName;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = rackinfo.GodownId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = rackinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rackinfo.Extra2;
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
        /// Function to get all the values from Rack Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RackViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAll", sqlcon);
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
        /// Function to get particular values from Rack Table based on the parameter
        /// </summary>
        /// <param name="rackId"></param>
        /// <returns></returns>
        public RackInfo RackView(decimal rackId)
        {
            RackInfo rackinfo = new RackInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = rackId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    rackinfo.RackId = decimal.Parse(sdrreader[0].ToString());
                    rackinfo.RackName = sdrreader[1].ToString();
                    rackinfo.GodownId = decimal.Parse(sdrreader[2].ToString());
                    rackinfo.Narration = sdrreader[3].ToString();
                    rackinfo.Extra1 = sdrreader[4].ToString();
                    rackinfo.Extra2 = sdrreader[5].ToString();
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
            return rackinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table Rack
        /// </summary>
        /// <param name="RackId"></param>
        public void RackDelete(decimal RackId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = RackId;
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
        /// Function to  get the next id for Rack Table
        /// </summary>
        /// <returns></returns>
        public int RackGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackMax", sqlcon);
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
        /// Function to get the Racks all by godownId
        /// </summary>
        /// <param name="dgvCurrent"></param>
        /// <param name="godownId"></param>
        /// <param name="inRowIndex"></param>
        /// <returns></returns>
        public DataTable RackViewAllByGodownId(DataGridView dgvCurrent, decimal godownId, int inRowIndex)
        {
            DataTable dtblRack = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAllByGodownId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.VarChar);
                sqlparameter.Value = godownId;
                sdaadapter.Fill(dtblRack);
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
                DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvCmbRack"].Index, inRowIndex];
                dgvCurrent[dgvCurrent.Columns["dgvCmbRack"].Index, inRowIndex].Value = null;
                if (dtblRack.Rows.Count > 0)
                {
                    dgvcmbUnit.DataSource = dtblRack;
                    dgvcmbUnit.DisplayMember = "rackName";
                    dgvcmbUnit.ValueMember = "rackId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtblRack;
        }
        /// <summary>
        /// Function to Rack get ViewAll Under the Godown For Combobox fill function
        /// </summary>
        /// <param name="godownId"></param>
        /// <returns></returns>
        public List<DataTable> RackViewAllByGodownForCombo(decimal godownId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RackViewAllByGodownForCombo", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                sqlda.Fill(dtbl);
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
        /// Function to fill the racks under the godown for others
        /// </summary>
        /// <param name="decGodown"></param>
        /// <returns></returns>
        public List<DataTable> RackViewAllByGodown(decimal decGodown)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackViewAllByGodown", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodown;
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
        /// Function to fill the racks under the godown for Stock
        /// </summary>
        /// <param name="decGodown"></param>
        /// <returns></returns>
        public List<DataTable> RackFillForStock(decimal decGodown)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackFillForStock", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal).Value = decGodown;
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
        /// Here Check the References of Rack Based on the rack name and godownId
        /// </summary>
        /// <param name="strRackName"></param>
        /// <param name="decRackId"></param>
        /// <param name="decGodownId"></param>
        /// <returns></returns>
        public bool RackCheckExistence(string strRackName, decimal decRackId, decimal decGodownId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackName", SqlDbType.VarChar);
                sprmparam.Value = strRackName;
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = decRackId;
                sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
                sprmparam.Value = decGodownId;
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
        /// Function to use search a rack under the godown and rackname
        /// </summary>
        /// <param name="strRackName"></param>
        /// <param name="strGodownname"></param>
        /// <returns></returns>
        public List<DataTable> RackSearch(string strRackName, string strGodownname)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.SelectCommand.Parameters.Add("@rackName", SqlDbType.VarChar).Value = strRackName;
                sdaadapter.SelectCommand.Parameters.Add("@godownName", SqlDbType.VarChar).Value = strGodownname;
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
        /// Checking references for Rack Delete
        /// </summary>
        /// <param name="RackId"></param>
        /// <returns></returns>
        public decimal RackDeleteReference(decimal RackId)
        {
           
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RackDeleteReference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rackId", SqlDbType.Decimal);
                sprmparam.Value = RackId;
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
        /// <summary>
        /// Rack view for rejection out
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RejectionOutRackViewFromGodownId()
        {
            List<DataTable> listObjGodown = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RejectionOutRackViewFromGodownId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObjGodown.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjGodown;
        }
        /// <summary>
        /// here list the RackNames Corresponding To GodownId
        /// </summary>
        /// <param name="decgodownId"></param>
        /// <returns></returns>
        public List<DataTable> RackNamesCorrespondingToGodownId(decimal decgodownId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RackNamesCorrespondingToGodownId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@godownId", SqlDbType.VarChar).Value = decgodownId;
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
        
    }
}
