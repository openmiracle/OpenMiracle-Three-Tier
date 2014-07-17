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
//Summary description for VoucherTypeSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class VoucherTypeSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to VoucherType Table
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        public void VoucherTypeAdd(VoucherTypeInfo vouchertypeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.VoucherTypeName;
                sprmparam = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.TypeOfVoucher;
                sprmparam = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.MethodOfVoucherNumbering;
                sprmparam = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsTaxApplicable;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
                sprmparam.Value = vouchertypeinfo.MasterId;
                sprmparam = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Declarartion;
                sprmparam = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading1;
                sprmparam = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading2;
                sprmparam = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading3;
                sprmparam = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading4;
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
        /// Function to Update values in VoucherType Table
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        public void VoucherTypeEdit(VoucherTypeInfo vouchertypeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = vouchertypeinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.VoucherTypeName;
                sprmparam = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.TypeOfVoucher;
                sprmparam = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.MethodOfVoucherNumbering;
                sprmparam = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsTaxApplicable;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
                sprmparam.Value = vouchertypeinfo.MasterId;
                sprmparam = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Declarartion;
                sprmparam = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading1;
                sprmparam = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading2;
                sprmparam = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading3;
                sprmparam = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading4;
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
        /// Function to view VoucherTypes for combobfill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherWiseProductSearchCombofill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherWiseProductSearchCombofill", sqlcon);
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
        ///Function to get all the values from VoucherType Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAll", sqlcon);
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
        /// Function to get Vouchertype for combofill
        /// </summary>
        /// <param name="cmbVoucherType"></param>
        /// <param name="isAll"></param>
        public void voucherTypeComboFill(ComboBox cmbVoucherType, bool isAll)
        {
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("voucherTypeSelectionForVoucherSearch", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["voucherTypeName"] = "All";
                    dr["voucherTypeId"] = 0;
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbVoucherType.DataSource = dtbl;
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
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
        /// Function to Get Type Of Voucher From VoucherType
        /// </summary>
        /// <param name="strvoucherTypeName"></param>
        /// <returns></returns>
        public string TypeOfVoucherView(string strvoucherTypeName)
        {
            string StrTypeOfVoucher = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GetTypeOfVoucherFromVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@voucherType", SqlDbType.VarChar).Value = strvoucherTypeName;
                StrTypeOfVoucher = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return StrTypeOfVoucher;
        }
        /// <summary>
        /// Function to view all VoucherTypes based on parameter
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public VoucherTypeInfo VoucherTypeView(decimal voucherTypeId)
        {
            VoucherTypeInfo vouchertypeinfo = new VoucherTypeInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    vouchertypeinfo.VoucherTypeId = Convert.ToDecimal(sdrreader[0].ToString());
                    vouchertypeinfo.VoucherTypeName = sdrreader[1].ToString();
                    vouchertypeinfo.TypeOfVoucher = sdrreader[2].ToString();
                    vouchertypeinfo.MethodOfVoucherNumbering = sdrreader[3].ToString();
                    vouchertypeinfo.IsTaxApplicable = Convert.ToBoolean(sdrreader[4].ToString());
                    vouchertypeinfo.Narration = sdrreader[5].ToString();
                    vouchertypeinfo.ExtraDate = Convert.ToDateTime(sdrreader[6].ToString());
                    vouchertypeinfo.Extra1 = sdrreader[7].ToString();
                    vouchertypeinfo.Extra2 = sdrreader[8].ToString();
                    vouchertypeinfo.IsActive = Convert.ToBoolean(sdrreader[9].ToString());
                    vouchertypeinfo.MasterId = Convert.ToInt32(sdrreader[10].ToString());
                    vouchertypeinfo.Declarartion = sdrreader[11].ToString();
                    vouchertypeinfo.Heading1 = sdrreader[12].ToString();
                    vouchertypeinfo.Heading2 = sdrreader[13].ToString();
                    vouchertypeinfo.Heading3 = sdrreader[14].ToString();
                    vouchertypeinfo.Heading4 = sdrreader[15].ToString();
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
            return vouchertypeinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="VoucherTypeId"></param>
        public void VoucherTypeDelete(decimal VoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = VoucherTypeId;
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
        /// Function to  get the next id for VoucherType Table
        /// </summary>
        /// <returns></returns>
        public int VoucherTypeGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeMax", sqlcon);
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
        /// Function to get all vouchers based on parameters
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeSelectionComboFill(string strVoucherType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSelectionComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
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
        /// Function to view all VoucherType by Voucherno
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAllByVoucherNo()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllByVoucherNo", sqlcon);
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
        /// Function for VoucherNo Combofill By VoucherType based on parameter
        /// </summary>
        /// <param name="decGodown"></param>
        /// <returns></returns>
        public List<DataTable> VoucherNoCombofillByVoucherType(decimal decGodown)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherNoCombofillByVoucherType", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decGodown;
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
        /// Function to check method fo voucher numbering based on parameter
        /// </summary>
        /// <param name="voucherTypeId"></param>
        /// <returns></returns>
        public bool CheckMethodOfVoucherNumbering(decimal voucherTypeId)
        {
            VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
            SqlDataReader sdrreader = null;
            bool isAutomatic = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckMethodOfVoucherNumbering", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    infoVoucherType.MethodOfVoucherNumbering = sdrreader["methodOfVoucherNumbering"].ToString();
                }
                if (infoVoucherType.MethodOfVoucherNumbering == "Automatic")
                {
                    isAutomatic = true;
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
            return isAutomatic;
        }
        /// <summary>
        /// Function to get all details based on parameter for Search
        /// </summary>
        /// <param name="strVoucherName"></param>
        /// <param name="strTypeOfvoucher"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeSearch(string strVoucherName, string strTypeOfvoucher)
        {
            List<DataTable> listObjSearch = new List<DataTable>();
            DataTable dtbl = new DataTable();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSearch", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherName;
                sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = strTypeOfvoucher;
                sdaadapter.Fill(dtbl);
                listObjSearch.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjSearch;
        }
        /// <summary>
        /// Function for VoucherType combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TypeOfVoucherComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TypeOfVoucherComboFill", sqlcon);
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
        /// Function to insert values to table and return id 
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        /// <returns></returns>
        public decimal VoucherTypeAddWithIdentity(VoucherTypeInfo vouchertypeinfo)
        {
            decimal decVoucherTypeId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.VoucherTypeName;
                sprmparam = sccmd.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.TypeOfVoucher;
                sprmparam = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.MethodOfVoucherNumbering;
                sprmparam = sccmd.Parameters.Add("@isTaxApplicable", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsTaxApplicable;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@IsDefault", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@masterId", SqlDbType.Int);
                sprmparam.Value = vouchertypeinfo.MasterId;
                sprmparam = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Declarartion;
                sprmparam = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading1;
                sprmparam = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading2;
                sprmparam = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading3;
                sprmparam = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading4;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decVoucherTypeId = Convert.ToDecimal(obj.ToString());
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
            return decVoucherTypeId;
        }
        /// <summary>
        /// Function to check existence of Voucher based on parameters
        /// </summary>
        /// <param name="strvoucherTypeName"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <returns></returns>
        public bool VoucherTypeCheckExistence(string strvoucherTypeName, decimal decvoucherTypeId)
        {
            bool isExists = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = strvoucherTypeName;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (obj.ToString() == "0")
                    {
                        isExists = true;
                    }
                    else
                    {
                        isExists = false;
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
            return isExists;
        }
        /// <summary>
        /// Function to get tax id for tax selection based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetTaxIdForTaxSelection(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("GetTaxIdForTaxSelection", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function to  Check For Default VoucherType based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool CheckForDefaultVoucherType(decimal decVoucherTypeId)
        {
            bool isDefault = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckForDefaultVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (obj.ToString() == "1")
                    {
                        isDefault = true;
                    }
                    else
                    {
                        isDefault = false;
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
            return isDefault;
        }
        /// <summary>
        /// Function for update VoucherType For Default Vouchers
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        public void VoucherTypeEditForDefaultVouchers(VoucherTypeInfo vouchertypeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeEditForDefaultVouchers", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = vouchertypeinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@methodOfVoucherNumbering", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.MethodOfVoucherNumbering;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isActive", SqlDbType.Bit);
                sprmparam.Value = vouchertypeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("@declaration", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Declarartion;
                sprmparam = sccmd.Parameters.Add("@heading1", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading1;
                sprmparam = sccmd.Parameters.Add("@heading2", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading2;
                sprmparam = sccmd.Parameters.Add("@heading3", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading3;
                sprmparam = sccmd.Parameters.Add("@heading4", SqlDbType.VarChar);
                sprmparam.Value = vouchertypeinfo.Heading4;
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
        /// Function to check reference based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool VoucherTypeChechReferences(decimal decVoucherTypeId)
        {
            bool isActive = true;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherTypeChechReferences", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (obj.ToString() == "1")
                    {
                        isActive = true;
                    }
                    else
                    {
                        isActive = false;
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
            return isActive;
        }
        /// <summary>
        /// Function for VoucherTypename combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeNameComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameComboFill", sqlcon);
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
        /// Function to view VoucherType For AgainstBill Details
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAllForAgainstBillDetails()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllForAgainstBillDetails", sqlcon);
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
        /// Function to view all VoucherTypeName For ComboFill based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeNameViewAllForComboFill(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameViewAllForComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
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
        /// Function to get Declaration And Heading based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> DeclarationAndHeadingGetByVoucherTypeId(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("DeclarationAndHeadingGetByVoucherTypeId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
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
        /// Function to get values for search based on parameters
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decEmployeeId"></param>
        /// <returns></returns>
        public List<DataTable> VoucherSearchFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decEmployeeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No");
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("VoucherSearch", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherType", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sqlparameter.Value = strVoucherNo;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlparameter.Value = decEmployeeId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
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
        /// Function for Vat ComboFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VatComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VatComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get all details based on parameters for search
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherName"></param>
        /// <param name="format"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        public List<DataTable> VatGridFill(DateTime fromDate, DateTime toDate, string voucherName, decimal decVoucherTypeId, string format, string tax)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VatGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromdate", SqlDbType.DateTime).Value = fromDate;
                sqlda.SelectCommand.Parameters.Add("@todate", SqlDbType.DateTime).Value = toDate;
                sqlda.SelectCommand.Parameters.Add("@voucherName", SqlDbType.VarChar).Value = voucherName;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.SelectCommand.Parameters.Add("@format", SqlDbType.VarChar).Value = format;
                sqlda.SelectCommand.Parameters.Add("@tax", SqlDbType.VarChar).Value = tax;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view Taxnames
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VatViewTaxNames()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VatViewTaxNames", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get sum of quantity for vochers based on parameter
        /// </summary>
        /// <param name="dSalesId"></param>
        /// <returns></returns>
        public string VoucherreportsumQty(decimal dSalesId,string strVoucherType)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherreportsumQty", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@salesMasterId", SqlDbType.Decimal).Value = dSalesId;
                sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
                string qty = sccmd.ExecuteScalar().ToString();
                return qty;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get id for PrinterSettings based on parameter
        /// </summary>
        /// <param name="inMasterId"></param>
        /// <returns></returns>
        public int FormIdGetForPrinterSettings(int inMasterId)
        {
            int frmId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("FormIdGetForPrinterSettings", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@masterId", SqlDbType.Decimal).Value = inMasterId;
                frmId = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return frmId;
        }
        /// <summary>
        /// Function to view type of voucher based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public VoucherTypeInfo TypeOfVoucherBasedOnVoucherTypeId(decimal decVoucherTypeId)
        {
            SqlDataReader sdrReader = null;
            VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("TypeOfVoucherBasedOnVoucherTypeId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sdrReader = sqlcmd.ExecuteReader();
                while (sdrReader.Read())
                {
                    infoVoucherType.TypeOfVoucher = sdrReader["typeOfVoucher"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VTSP:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sdrReader.Close();
                sqlcon.Close();
            }
            return infoVoucherType;
        }
        /// <summary>
        /// Function to get Type of Vouchers for combofill in tax report and vat report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TypeOfVoucherCombofillForVatAndTaxReport()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TypeOfVoucherCombofillForVatAndTaxReport", sqlcon);
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
        /// Function to get VoucherTypename for combofill in Tax And vat report
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeCombofillForTaxAndVat(string strVoucherType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeNameCorrespondingToTypeOfVoucher", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = strVoucherType;
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
