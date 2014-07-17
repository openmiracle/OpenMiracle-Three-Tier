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
//Summary description for ContraMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ContraMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ContraMaster Table
        /// </summary>
        /// <param name="contramasterinfo"></param>
        /// <returns></returns>
        public decimal ContraMasterAdd(ContraMasterInfo contramasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = contramasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.VoucherTypeId;
                //sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                //sprmparam.Value = contramasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.FinancialYearId;
                //sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                //sprmparam.Value = contramasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Extra2;
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
        /// Function to Update values in ContraMaster Table
        /// </summary>
        /// <param name="contramasterinfo"></param>
        public void ContraMasterEdit(ContraMasterInfo contramasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.ContraMasterId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = contramasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = contramasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = contramasterinfo.Extra2;
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
        /// Function to get all the values from ContraMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable ContraMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ContraMasterViewAll", sqlcon);
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
        /// Function to get particular values from ContraMaster table based on the parameter
        /// </summary>
        /// <param name="contraMasterId"></param>
        /// <returns></returns>
        public ContraMasterInfo ContraMasterView(decimal contraMasterId)
        {
            ContraMasterInfo contramasterinfo = new ContraMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = contraMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    contramasterinfo.ContraMasterId = decimal.Parse(sdrreader[0].ToString());
                    contramasterinfo.VoucherNo = sdrreader[1].ToString();
                    contramasterinfo.InvoiceNo = sdrreader[2].ToString();
                    contramasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    contramasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    contramasterinfo.LedgerId = decimal.Parse(sdrreader[5].ToString());
                    contramasterinfo.Type = sdrreader[6].ToString();
                    contramasterinfo.TotalAmount = decimal.Parse(sdrreader[7].ToString());
                    contramasterinfo.Narration = sdrreader[8].ToString();
                    contramasterinfo.UserId = decimal.Parse(sdrreader[9].ToString());
                    contramasterinfo.VoucherTypeId = decimal.Parse(sdrreader[10].ToString());
                    contramasterinfo.FinancialYearId = decimal.Parse(sdrreader[11].ToString());
                    contramasterinfo.ExtraDate = DateTime.Parse(sdrreader[12].ToString());
                    contramasterinfo.Extra1 = sdrreader[13].ToString();
                    contramasterinfo.Extra2 = sdrreader[14].ToString();
                    contramasterinfo.date = sdrreader["date"].ToString();
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
            return contramasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ContraMasterId"></param>
        public void ContraMasterDelete(decimal ContraMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = ContraMasterId;
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
        /// Function to  get the next id for ContraMaster table
        /// </summary>
        /// <returns></returns>
        public int ContraMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraMasterMax", sqlcon);
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
        /// Function to  get the next id for ContraMaster table based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string ContraVoucherMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraVoucherMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = sccmd.ExecuteScalar().ToString();
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
        /// Function to  get the next id for ContraMaster table based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal ContraVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraVoucherMasterMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
        /// Function to Check existence of Voucher based on parameters
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="masterId"></param>
        /// <returns></returns>
        public bool ContraVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ContraVoucherCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sprmparam = sccmd.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = masterId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        trueOrfalse = true;
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
            return trueOrfalse;
        }
        /// <summary>
        /// Function to get particular values from ContraMaster table based on the parameter
        /// </summary>
        /// <param name="dtdateFrom"></param>
        /// <param name="dtdateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> ContraVoucherRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherNo, string strLedgerName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(decimal));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ContraVoucherRegisterSearch", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
                sqlcmd.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
                sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
                sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlcmd.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcmd;
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
        /// Function to get all the values for Printing
        /// </summary>
        /// <param name="decContraMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet ContraVoucherPrinting(decimal decContraMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ContraVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@contraMasterId", SqlDbType.Decimal);
                sprmparam.Value = decContraMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sdaadapter.Fill(dSt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dSt;
        }
        /// <summary>
        /// Function to get all the values for Report based on parameters
        /// </summary>
        /// <param name="dtdateFrom"></param>
        /// <param name="dtdateTo"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public List<DataTable> ContraReport(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherType, string strLedgerName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ContraReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@dateFrom", SqlDbType.DateTime).Value = dtdateFrom;
                sqlda.SelectCommand.Parameters.Add("@dateTo", SqlDbType.DateTime).Value = dtdateTo;
                sqlda.SelectCommand.Parameters.Add("@voucherType", SqlDbType.VarChar).Value = strVoucherType;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
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
        /// Function to view all Cash/Bank ledgers for combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CashOrBankComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(listObj[0]);
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
        /// Function to view all voucherTypes
        /// </summary>
        /// <returns></returns>
        public DataTable VoucherTypeViewAll()
        {
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeViewAll", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
        /// Function to get the next VoucherNo  based on parameters
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal GetVoucherNoMaxByVoucherTypeIdForContraVoucher(decimal decVoucherTypeId)
        {
            decimal decVoucherNo = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GetVoucherNoMaxByVoucherTypeIdForContraVoucher", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                decVoucherNo = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decVoucherNo;
        }
    }
}
