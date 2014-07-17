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
//Summary description for PayHeadSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PayHeadSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PayHead Table
        /// </summary>
        /// <param name="payheadinfo"></param>
        public void PayHeadAdd(PayHeadInfo payheadinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.PayHeadName;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Type;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = payheadinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Extra2;
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
        /// Function to Update values in PayHead Table
        /// </summary>
        /// <param name="payheadinfo"></param>
        public void PayHeadEdit(PayHeadInfo payheadinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = payheadinfo.PayHeadId;
                sprmparam = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.PayHeadName;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Type;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = payheadinfo.Narration;
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
        /// Function to get all the values from PayHead Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PayHeadViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("Slno:", typeof(int));
                dtbl.Columns["Slno:"].AutoIncrement = true;
                dtbl.Columns["Slno:"].AutoIncrementSeed = 1;
                dtbl.Columns["Slno:"].AutoIncrementStep = 1;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PayHeadViewAll", sqlcon);
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
        /// Function to get particular values from PayHead Table based on the parameter
        /// </summary>
        /// <param name="payHeadId"></param>
        /// <returns></returns>
        public PayHeadInfo PayHeadView(decimal payHeadId)
        {
            PayHeadInfo payheadinfo = new PayHeadInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = payHeadId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    payheadinfo.PayHeadId = Convert.ToDecimal(sdrreader[0].ToString());
                    payheadinfo.PayHeadName = sdrreader[1].ToString();
                    payheadinfo.Type = sdrreader[2].ToString();
                    payheadinfo.Narration = sdrreader[3].ToString();
                    payheadinfo.ExtraDate = DateTime.Parse(sdrreader[4].ToString());
                    payheadinfo.Extra1 = sdrreader[5].ToString();
                    payheadinfo.Extra2 = sdrreader[6].ToString();
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
            return payheadinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table PayHead
        /// </summary>
        /// <param name="PayHeadId"></param>
        public void PayHeadDelete(decimal PayHeadId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = PayHeadId;
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
        /// Function to  get the next id for PayHead Table
        /// </summary>
        /// <returns></returns>
        public int PayHeadGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadMax", sqlcon);
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
        /// Function to search a payhead based on the condition
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public List<DataTable> PayHeadSearch(string a)    
        {
            List<DataTable> listObj = new List<DataTable>();                        
            DataTable dtblpayhead = new DataTable();
            dtblpayhead.Columns.Add("Slno:", typeof(int));
            dtblpayhead.Columns["Slno:"].AutoIncrement = true;
            dtblpayhead.Columns["Slno:"].AutoIncrementSeed = 1;
            dtblpayhead.Columns["Slno:"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PayHeadSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@a", SqlDbType.VarChar).Value = a;
                sqlda.Fill(dtblpayhead);
                listObj.Add(dtblpayhead);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        
        /// <summary>
        /// Function to check Existance of Payhead
        /// </summary>
        /// <param name="PaheadName"></param>
        /// <param name="PayHeadId"></param>
        /// <returns></returns>
        public bool PayheadCheckExistence(string PaheadName,decimal PayHeadId) 
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayheadCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
                sprmparam.Value = PaheadName;
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = PayHeadId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isSave = true;
                    }
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
            return isSave;
        }
        /// <summary>
        /// Function to delete a payhead based on vouchertype to reference check
        /// </summary>
        /// <param name="PayHeadId"></param>
        /// <returns></returns>
        public bool PayHeadDeleteVoucherTypeCheckReference(decimal PayHeadId)
        {
           bool inPayHeadId = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PayHeadDeleteVoucherTypeCheckReference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PayHeadId", SqlDbType.Decimal);
                sprmparam.Value = PayHeadId;
                int ina = sccmd.ExecuteNonQuery();
                if (ina == -1)
               {
                   inPayHeadId = true;
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
            return inPayHeadId;
            
        }
        /// <summary>
        /// Payhead check reference for others
        /// </summary>
        /// <param name="PayHeadId"></param>
        /// <param name="PayHeadName"></param>
        /// <param name="Type"></param>
        /// <param name="Narration"></param>
        /// <returns></returns>
        public bool payheadTypeCheckeferences(decimal PayHeadId, string PayHeadName, string Type, string Narration) 
        {
            bool RefPayHeadId = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("payheadTypeCheckeferences", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = PayHeadId;
                sprmparam = sccmd.Parameters.Add("@payHeadName", SqlDbType.VarChar);
                sprmparam.Value = PayHeadName;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = Type;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = Narration;
               int invalue   =Convert.ToInt32( sccmd.ExecuteScalar());
               if (invalue == 1)
                {
                    RefPayHeadId = false;
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
            return RefPayHeadId;
        }
        /// <summary>
        /// Function to get all the details about PayHead For purticular Report
        /// </summary>
        /// <param name="strPayHeadName"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> PayHeadViewAllForPayHeadReport(string strPayHeadName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtblPayHead = new DataTable();
            dtblPayHead.Columns.Add("SlNo", typeof(int));
            dtblPayHead.Columns["SlNo"].AutoIncrement = true;
            dtblPayHead.Columns["SlNo"].AutoIncrementSeed = 1;
            dtblPayHead.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PayHeadViewAllForPayHeadReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@payheadName", SqlDbType.VarChar).Value = strPayHeadName;
                sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
                sqlda.Fill(dtblPayHead);
                listObj.Add(dtblPayHead);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObj;
        }
    
    }
}
   
   
    
