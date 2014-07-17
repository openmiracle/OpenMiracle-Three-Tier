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
//Summary description for ContraDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class ContraDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ContraDetails Table
        /// </summary>
        /// <param name="contradetailsinfo"></param>
        /// <returns></returns>
        public decimal ContraDetailsAdd(ContraDetailsInfo contradetailsinfo)
        {
            decimal deceffect = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ContraMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = contradetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra2;
                deceffect = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return deceffect;
        }
        /// <summary>
        /// Function to Update values in ContraDetails Table
        /// </summary>
        /// <param name="contradetailsinfo"></param>
        public void ContraDetailsEdit(ContraDetailsInfo contradetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ContraDetailsId;
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ContraMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = contradetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra2;
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
        /// Function to get all the values from ContraDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable ContraDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ContraDetailsViewAll", sqlcon);
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
        /// Function to get particular values from ContraDetails Table based on the parameter
        /// </summary>
        /// <param name="contraDetailsId"></param>
        /// <returns></returns>
        public ContraDetailsInfo ContraDetailsView(decimal contraDetailsId)
        {
            ContraDetailsInfo contradetailsinfo = new ContraDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
                sprmparam.Value = contraDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    contradetailsinfo.ContraDetailsId = decimal.Parse(sdrreader[0].ToString());
                    contradetailsinfo.ContraMasterId = decimal.Parse(sdrreader[1].ToString());
                    contradetailsinfo.LedgerId = decimal.Parse(sdrreader[2].ToString());
                    contradetailsinfo.Amount = decimal.Parse(sdrreader[3].ToString());
                    contradetailsinfo.ChequeNo = sdrreader[4].ToString();
                    contradetailsinfo.ChequeDate = DateTime.Parse(sdrreader[5].ToString());
                    contradetailsinfo.ExtraDate = DateTime.Parse(sdrreader[6].ToString());
                    contradetailsinfo.Extra1 = sdrreader[7].ToString();
                    contradetailsinfo.Extra2 = sdrreader[8].ToString();
                    contradetailsinfo.ExchangeRateId = decimal.Parse(sdrreader["Currency"].ToString());
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
            return contradetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table ContraDetails
        /// </summary>
        /// <param name="ContraDetailsId"></param>
        public void ContraDetailsDelete(decimal ContraDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraDetailsId", SqlDbType.Decimal);
                sprmparam.Value = ContraDetailsId;
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
        /// Function to  get the next id for ContraDetails Table
        /// </summary>
        /// <returns></returns>
        public int ContraDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsMax", sqlcon);
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
        /// Function to Cash Or Bank ComboFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CashOrBankComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
        /// Function to insert values to ContraDetails Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="contradetailsinfo"></param>
        /// <returns></returns>
        public decimal ContraDetailsAddReturnWithhIdentity(ContraDetailsInfo contradetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraDetailsAddReturnWithhIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ContraMasterId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = contradetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
                sprmparam.Value = contradetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = contradetailsinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
        /// Function to delete particular details based on the parameter From Table ContraDetails
        /// </summary>
        /// <param name="ContraDetailsId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void ContraVoucherDelete(decimal ContraDetailsId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraVoucherDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = ContraDetailsId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.Decimal);
                sprmparam.Value = strVoucherNo;
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
        /// Function to Contra Details View With MasterId
        /// </summary>
        /// <param name="decpurchaseId"></param>
        /// <returns></returns>
        public List<DataTable> ContraDetailsViewWithMasterId(decimal decpurchaseId)
        {
            List<DataTable> listObjContraDetails = new List<DataTable>();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ContraDetailsViewWithMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal).Value = decpurchaseId;
                sqlda.SelectCommand = sqlcmd;
                sqlda.Fill(dtbl);
                listObjContraDetails.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjContraDetails;
        }
    }
}
