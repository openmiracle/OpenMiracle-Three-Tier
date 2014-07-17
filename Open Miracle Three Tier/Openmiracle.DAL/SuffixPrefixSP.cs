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
//Summary description for SuffixPrefixSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class SuffixPrefixSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SuffixPrefix Table
        /// </summary>
        /// <param name="suffixprefixinfo"></param>
        public void SuffixPrefixAdd(SuffixPrefixInfo suffixprefixinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.SuffixprefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@startIndex", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.StartIndex;
                sprmparam = sccmd.Parameters.Add("@prefix", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Prefix;
                sprmparam = sccmd.Parameters.Add("@suffix", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Suffix;
                sprmparam = sccmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Int);
                sprmparam.Value = suffixprefixinfo.WidthOfNumericalPart;
                sprmparam = sccmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit);
                sprmparam.Value = suffixprefixinfo.PrefillWithZero;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Extra2;
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
        /// Function to Update values in SuffixPrefix Table
        /// </summary>
        /// <param name="suffixprefixinfo"></param>
        public void SuffixPrefixEdit(SuffixPrefixInfo suffixprefixinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.SuffixprefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@startIndex", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixinfo.StartIndex;
                sprmparam = sccmd.Parameters.Add("@prefix", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Prefix;
                sprmparam = sccmd.Parameters.Add("@suffix", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Suffix;
                sprmparam = sccmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Int);
                sprmparam.Value = suffixprefixinfo.WidthOfNumericalPart;
                sprmparam = sccmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit);
                sprmparam.Value = suffixprefixinfo.PrefillWithZero;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = suffixprefixinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = suffixprefixinfo.Extra2;
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
        /// Function to get all the values from SuffixPrefix Table
        /// </summary>
        /// <returns></returns>
        public DataTable SuffixPrefixViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SuffixPrefixViewAll", sqlcon);
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
        /// Function to get particular values from SuffixPrefix Table based on the parameter
        /// </summary>
        /// <param name="suffixprefixId"></param>
        /// <returns></returns>
        public SuffixPrefixInfo SuffixPrefixView(decimal suffixprefixId)
        {
            SuffixPrefixInfo suffixprefixinfo = new SuffixPrefixInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = suffixprefixId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    suffixprefixinfo.SuffixprefixId = decimal.Parse(sdrreader[0].ToString());
                    suffixprefixinfo.VoucherTypeId = decimal.Parse(sdrreader[1].ToString());
                    suffixprefixinfo.FromDate = DateTime.Parse(sdrreader[2].ToString());
                    suffixprefixinfo.ToDate = DateTime.Parse(sdrreader[3].ToString());
                    suffixprefixinfo.StartIndex = decimal.Parse(sdrreader[4].ToString());
                    suffixprefixinfo.Prefix = sdrreader[5].ToString();
                    suffixprefixinfo.Suffix = sdrreader[6].ToString();
                    suffixprefixinfo.WidthOfNumericalPart = int.Parse(sdrreader[7].ToString());
                    suffixprefixinfo.PrefillWithZero = bool.Parse(sdrreader[8].ToString());
                    suffixprefixinfo.Narration = sdrreader[9].ToString();
                    suffixprefixinfo.ExtraDate = DateTime.Parse(sdrreader[10].ToString());
                    suffixprefixinfo.Extra1 = sdrreader[11].ToString();
                    suffixprefixinfo.Extra2 = sdrreader[12].ToString();
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
            return suffixprefixinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SuffixprefixId"></param>
        public void SuffixPrefixDelete(decimal SuffixprefixId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = SuffixprefixId;
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
        /// Function to  get the next id for  SuffixPrefix Table
        /// </summary>
        /// <returns></returns>
        public int SuffixPrefixGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixMax", sqlcon);
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
        /// Function to get SuffixPrefix details based on parameter
        /// </summary>
        /// <param name="vouchertypeId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public SuffixPrefixInfo GetSuffixPrefixDetails(decimal vouchertypeId, DateTime date)
        {
            SuffixPrefixInfo suffixprefixinfo = new SuffixPrefixInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GetSuffixPrefixDetails", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherId", SqlDbType.Decimal);
                sprmparam.Value = vouchertypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = date;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    suffixprefixinfo.SuffixprefixId = decimal.Parse(sdrreader[0].ToString());
                    suffixprefixinfo.VoucherTypeId = decimal.Parse(sdrreader[1].ToString());
                    suffixprefixinfo.FromDate = DateTime.Parse(sdrreader[2].ToString());
                    suffixprefixinfo.ToDate = DateTime.Parse(sdrreader[3].ToString());
                    suffixprefixinfo.StartIndex = decimal.Parse(sdrreader[4].ToString());
                    suffixprefixinfo.Prefix = sdrreader[5].ToString();
                    suffixprefixinfo.Suffix = sdrreader[6].ToString();
                    suffixprefixinfo.WidthOfNumericalPart = int.Parse(sdrreader[7].ToString());
                    suffixprefixinfo.PrefillWithZero = bool.Parse(sdrreader[8].ToString());
                    suffixprefixinfo.Narration = sdrreader[9].ToString();
                    suffixprefixinfo.ExtraDate = DateTime.Parse(sdrreader[10].ToString());
                    suffixprefixinfo.Extra1 = sdrreader[11].ToString();
                    suffixprefixinfo.Extra2 = sdrreader[12].ToString();
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
            return suffixprefixinfo;
        }
        /// <summary>
        /// Function to get VoucherTypes with SuffixPrefix for Combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAllInSuffixPrefix()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAllInSuffixPrefix", sqlcon);
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
        /// Function to get details for Search based on Parameter
        /// </summary>
        /// <param name="strVoucherTypeName"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeSearchInSuffixPrefix(String strVoucherTypeName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(decimal));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeSearchInSuffixPrefix", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherTypeName;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listObj;
        }
        /// <summary>
        /// Function to check existence for insert based on parameter
        /// </summary>
        /// <param name="strfromDate"></param>
        /// <param name="strtoDate"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="decsuffixprefixId"></param>
        /// <returns></returns>
        public bool SuffixPrefixCheckExistenceForAdd(String strfromDate, String strtoDate, decimal decvoucherTypeId, decimal decsuffixprefixId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SuffixPrefixCheckExistenceForAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = DateTime.Parse(strfromDate);
                sprmparam = sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = DateTime.Parse(strtoDate);
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
                sprmparam = sqlcmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = decsuffixprefixId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = decimal.Parse(obj.ToString());
                }
                if (decCount > 0)
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
            }
            finally
            {
                sqlcon.Close();
            }
            return false;
        }
        /// <summary>
        /// Function to get id for suffixprefix insert
        /// </summary>
        /// <param name="Infosuffixprefix"></param>
        /// <returns></returns>
        public bool SuffixPrefixAddWithId(SuffixPrefixInfo Infosuffixprefix)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SuffixPrefixAddWithId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = Infosuffixprefix.VoucherTypeId;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Infosuffixprefix.FromDate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Infosuffixprefix.ToDate;
                sqlcmd.Parameters.Add("@startIndex", SqlDbType.Decimal).Value = Infosuffixprefix.StartIndex;
                sqlcmd.Parameters.Add("@prefix", SqlDbType.VarChar).Value = Infosuffixprefix.Prefix;
                sqlcmd.Parameters.Add("@suffix", SqlDbType.VarChar).Value = Infosuffixprefix.Suffix;
                sqlcmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Decimal).Value = Infosuffixprefix.WidthOfNumericalPart;
                sqlcmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit).Value = Infosuffixprefix.PrefillWithZero;
                sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = Infosuffixprefix.Narration;
                sqlcmd.Parameters.Add("@extra1", SqlDbType.VarChar).Value = Infosuffixprefix.Extra1;
                sqlcmd.Parameters.Add("@extra2", SqlDbType.VarChar).Value = Infosuffixprefix.Extra2;
                int ineffectedrow = sqlcmd.ExecuteNonQuery();
                if (ineffectedrow > 0)
                {
                    isSave = true;
                }
                else
                {
                    isSave = false;
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
        /// Function to get id for update
        /// </summary>
        /// <param name="Infosuffixprefix"></param>
        /// <returns></returns>
        public bool SuffixPrefixSettingsEdit(SuffixPrefixInfo Infosuffixprefix)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SuffixPrefixSettingsEdit", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal).Value = Infosuffixprefix.SuffixprefixId;
                sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = Infosuffixprefix.VoucherTypeId;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = Infosuffixprefix.FromDate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = Infosuffixprefix.ToDate;
                sqlcmd.Parameters.Add("@startIndex", SqlDbType.VarChar).Value = Infosuffixprefix.StartIndex;
                sqlcmd.Parameters.Add("@prefix", SqlDbType.VarChar).Value = Infosuffixprefix.Prefix;
                sqlcmd.Parameters.Add("@suffix", SqlDbType.VarChar).Value = Infosuffixprefix.Suffix;
                sqlcmd.Parameters.Add("@widthOfNumericalPart", SqlDbType.Decimal).Value = Infosuffixprefix.WidthOfNumericalPart;
                sqlcmd.Parameters.Add("@prefillWithZero", SqlDbType.Bit).Value = Infosuffixprefix.PrefillWithZero;
                sqlcmd.Parameters.Add("@narration", SqlDbType.VarChar).Value = Infosuffixprefix.Narration;
                int ineffectedrow = sqlcmd.ExecuteNonQuery();
                if (ineffectedrow > 0)
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
        /// Function for delete based on parameter
        /// </summary>
        /// <param name="SuffixprefixId"></param>
        /// <returns></returns>
        public decimal SuffixPrefixSettingsDeleting(decimal SuffixprefixId)
        {
            decimal decId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SuffixPrefixSettingsDeleting", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@suffixprefixId", SqlDbType.Decimal);
                sprmparam.Value = SuffixprefixId;
                decId = decimal.Parse(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decId;
        }
    }
}
