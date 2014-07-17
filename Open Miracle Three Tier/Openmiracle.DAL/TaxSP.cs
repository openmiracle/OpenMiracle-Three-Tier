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
//Summary description for TaxSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class TaxSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to  Tax Table
        /// </summary>
        /// <param name="taxinfo"></param>
        public void TaxAdd(TaxInfo taxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.TaxName;
                sprmparam = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.ApplicableOn;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = taxinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.CalculatingMode;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = taxinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = taxinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra2;
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
        /// Function to Update values in Tax Table
        /// </summary>
        /// <param name="taxinfo"></param>
        public void TaxEdit(TaxInfo taxinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxinfo.TaxId;
                sprmparam = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.TaxName;
                sprmparam = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.ApplicableOn;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = taxinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.CalculatingMode;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = taxinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra2;
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
        /// Function to get all the values from Tax Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAll", sqlcon);
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
        /// Function to get particular values from Tax Table based on the parameter
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public TaxInfo TaxView(decimal taxId)
        {
            TaxInfo taxinfo = new TaxInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = taxId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    taxinfo.TaxId = decimal.Parse(sdrreader[0].ToString());
                    taxinfo.TaxName = sdrreader[1].ToString();
                    taxinfo.ApplicableOn = sdrreader[2].ToString();
                    taxinfo.Rate = decimal.Parse(sdrreader[3].ToString());
                    taxinfo.CalculatingMode = sdrreader[4].ToString();
                    taxinfo.Narration = sdrreader[5].ToString();
                    taxinfo.IsActive = bool.Parse(sdrreader[6].ToString());
                    taxinfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
                    taxinfo.Extra1 = sdrreader[8].ToString();
                    taxinfo.Extra2 = sdrreader[9].ToString();
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
            return taxinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="TaxId"></param>
        public void TaxDelete(decimal TaxId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = TaxId;
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
        /// Function to  get the next id for Tax Table
        /// </summary>
        /// <returns></returns>
        public int TaxGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxMax", sqlcon);
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
        /// Function to check existence of tax based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <param name="strTaxName"></param>
        /// <returns></returns>
        public bool TaxCheckExistence(decimal decTaxId, string strTaxName)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("TaxCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = decTaxId;
                sprmparam = sqlcmd.Parameters.Add("@taxName", SqlDbType.VarChar);
                sprmparam.Value = strTaxName;
                object obj = sqlcmd.ExecuteScalar();
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
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function for insert values and return id
        /// </summary>
        /// <param name="taxinfo"></param>
        /// <returns></returns>
        public decimal TaxAddWithIdentity(TaxInfo taxinfo)
        {
            decimal decTaxId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxName", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.TaxName;
                sprmparam = sccmd.Parameters.Add("@applicableOn", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.ApplicableOn;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = taxinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@calculatingMode", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.CalculatingMode;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = taxinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = taxinfo.Extra2;
                object objTaxId = sccmd.ExecuteScalar();
                if (objTaxId != null)
                {
                    decTaxId = decimal.Parse(objTaxId.ToString());
                }
                else
                {
                    decTaxId = 0;
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
            return decTaxId;
        }
        /// <summary>
        /// Function to view Tax for Selection
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForTaxSelection()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForTaxSelection", sqlcon);
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
        /// Function for tax search based on parameter
        /// </summary>
        /// <param name="strTaxName"></param>
        /// <param name="strApplicableOn"></param>
        /// <param name="strCalculatingMode"></param>
        /// <param name="strActive"></param>
        /// <returns></returns>
        public List<DataTable> TaxSearch(String strTaxName, String strApplicableOn, String strCalculatingMode, string strActive)
        {
            DataTable dtblTaxSearch = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            dtblTaxSearch.Columns.Add("Sl No", typeof(decimal));
            dtblTaxSearch.Columns["Sl No"].AutoIncrement = true;
            dtblTaxSearch.Columns["Sl No"].AutoIncrementSeed = 1;
            dtblTaxSearch.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@taxName", SqlDbType.VarChar).Value = strTaxName;
                sqlda.SelectCommand.Parameters.Add("@applicableOn", SqlDbType.VarChar).Value = strApplicableOn;
                sqlda.SelectCommand.Parameters.Add("@calculatingMode", SqlDbType.VarChar).Value = strCalculatingMode;
                sqlda.SelectCommand.Parameters.Add("@isActive", SqlDbType.VarChar).Value = strActive;
                sqlda.Fill(dtblTaxSearch);
                ListObj.Add(dtblTaxSearch);
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
        /// Function for Check refernce based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public bool TaxReferenceCheck(decimal decTaxId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("TaxReferenceCheck", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = decTaxId;
                isExist = bool.Parse(sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        /// <summary>
        /// Function to view tax for voucherType
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForVoucherType()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("SlNo", typeof(decimal));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForVoucherType", sqlcon);
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
        /// Function to view TaxId For Tax Selection Update based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxIdForTaxSelectionUpdate(decimal decTaxId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblTax = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxIdForTaxSelectionUpdate", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
                sqlda.Fill(dtblTax);
                ListObj.Add(dtblTax);
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
        /// Function for Check reference and delete
        /// </summary>
        /// <param name="TaxId"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public decimal TaxReferenceDelete(decimal TaxId, decimal decLedgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxReferenceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = TaxId;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
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
        /// Function to get Tax Rate By TaxId 
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public decimal TaxRateFindByTaxId(decimal decTaxId)
        {
            decimal dcRate = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxRateFindByTaxId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = decTaxId;
                dcRate = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return dcRate;
        }
        /// <summary>
        /// Function for Tax View All By VoucherTypeId
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeId(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function for Tax View All By VoucherTypeId For PurchaseInvoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdForPurchaseInvoice(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdForPurchaseInvoice", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function for Tax View All By VoucherTypeId With Cess
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdWithCess(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdWithCess", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function for view TaxId Corresponding To Cess TaxId
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxIdCorrespondingToCessTaxId(decimal decTaxId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxIdCorrespondingToCessTaxId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal).Value = decTaxId;
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
        /// Function for  Tax ViewAll By VoucherTypeId
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strTaxApplicable"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeId1(decimal decVoucherTypeId, string strTaxApplicable)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdApplicableOnProduct", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.SelectCommand.Parameters.Add("@applicableOn", SqlDbType.VarChar).Value = strTaxApplicable;
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
        /// Function for Tax View By ProductId
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public TaxInfo TaxViewByProductId(string strProductCode)
        {
            TaxInfo taxInfo = new TaxInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxViewByProductId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    taxInfo.TaxId = Convert.ToDecimal(sdrreader["taxId"].ToString());
                    taxInfo.TaxName = sdrreader["taxName"].ToString();
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
            return taxInfo;
        }
        /// <summary>
        /// Function for Tax ViewAll By VoucherTypeId Applicale For Product
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdApplicaleForProduct(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewAllByVoucherTypeIdApplicaleForProduct", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function for Tax View By ProductId Applicable For Product
        /// </summary>
        /// <param name="dcProductId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewByProductIdApplicableForProduct(decimal dcProductId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxViewByProductIdApplicableForProduct", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal).Value = dcProductId;
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
        /// Function for TotalBill Tax Calculation Based on applicable On
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TotalBillTaxCalculationBtapplicableOn()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TotalBillTaxViewAllByApplicableOn", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Function to view tax for Product
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForProduct()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAllForProduct", sqlcon);
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
        /// Function to view all tax details for Tax Report By Productwise based on parameter
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public List<DataTable> TaxReportGridFillByProductwise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("SlNo", typeof(int));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxReportGridFillByProductwise", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
                sprmparam.Value = fromdate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
                sprmparam.Value = todate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = dectaxId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
                sprmparam.Value = strTypeofVoucher;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
                sprmparam.Value = isInput;
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
        /// Function to view all tax details for Tax Report By Productwise based on parameter
        /// </summary>
        /// <param name="deccompanyId"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public DataSet TaxCrystalReportGridFillByProductwise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxCrystalReportGridFillByProductwise", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = deccompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
                sprmparam.Value = fromdate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
                sprmparam.Value = todate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sprmparam.Value = dectaxId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
                sprmparam.Value = isInput;
                sdaadapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
        /// <summary>
        /// Function to view all tax details for Report by bill wise based on parameter
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public List<DataTable> TaxReportGridFillByBillWise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                dtbl.Columns.Add("SlNo", typeof(int));
                dtbl.Columns["SlNo"].AutoIncrement = true;
                dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
                dtbl.Columns["SlNo"].AutoIncrementStep = 1;
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxReportGridFillByBillWise", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
                sqlparam.Value = fromdate;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
                sqlparam.Value = todate;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sqlparam.Value = dectaxId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparam.Value = decvoucherTypeId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
                sqlparam.Value = strTypeofVoucher;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
                sqlparam.Value = isInput;
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
        /// Function for view Tax values for report by bill wise based on parameter
        /// </summary>
        /// <param name="deccompanyId"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public DataSet TaxCrystalReportGridFillByBillWise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("TaxCrystalReportGridFillByBillWise", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sqlparam.Value = deccompanyId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime);
                sqlparam.Value = fromdate;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime);
                sqlparam.Value = todate;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                sqlparam.Value = dectaxId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparam.Value = decvoucherTypeId;
                sqlparam = sqlda.SelectCommand.Parameters.Add("@input", SqlDbType.Bit);
                sqlparam.Value = isInput;
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ds;
        }
    }
}
