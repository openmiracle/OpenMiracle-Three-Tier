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
//Summary description for PDCClearanceMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PDCClearanceMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PDCClearanceMaster Table
        /// </summary>
        /// <param name="pdcclearancemasterinfo"></param>
        /// <returns></returns>
        public decimal PDCClearanceMasterAdd(PDCClearanceMasterInfo pdcclearancemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = pdcclearancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@againstId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.AgainstId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Status;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Extra2;
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
        /// Function to Update values in PDCClearanceMaster Table
        /// </summary>
        /// <param name="pdcclearancemasterinfo"></param>
        public void PDCClearanceMasterEdit(PDCClearanceMasterInfo pdcclearancemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.PDCClearanceMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = pdcclearancemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Type;
                sprmparam = sccmd.Parameters.Add("@againstId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.AgainstId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Status;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = pdcclearancemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = pdcclearancemasterinfo.Extra2;
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
        /// Function to get all the values from PDCClearanceMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PDCClearanceMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceMasterViewAll", sqlcon);
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
        /// Function to get particular values from PDCClearanceMaster Table based on the parameter
        /// </summary>
        /// <param name="PDCClearanceMasterId"></param>
        /// <returns></returns>
        public PDCClearanceMasterInfo PDCClearanceMasterView(decimal PDCClearanceMasterId)
        {
            PDCClearanceMasterInfo pdcclearancemasterinfo = new PDCClearanceMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = PDCClearanceMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    pdcclearancemasterinfo.PDCClearanceMasterId = decimal.Parse(sdrreader[0].ToString());
                    pdcclearancemasterinfo.VoucherNo = sdrreader[1].ToString();
                    pdcclearancemasterinfo.InvoiceNo = sdrreader[2].ToString();
                    pdcclearancemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    pdcclearancemasterinfo.Date = DateTime.Parse(sdrreader[4].ToString());
                    pdcclearancemasterinfo.LedgerId = decimal.Parse(sdrreader[5].ToString());
                    pdcclearancemasterinfo.Type = sdrreader[6].ToString();
                    pdcclearancemasterinfo.AgainstId = decimal.Parse(sdrreader[7].ToString());
                    pdcclearancemasterinfo.VoucherTypeId = decimal.Parse(sdrreader[8].ToString());
                    pdcclearancemasterinfo.Narration = sdrreader[9].ToString();
                    pdcclearancemasterinfo.Status = sdrreader[10].ToString();
                    pdcclearancemasterinfo.UserId = decimal.Parse(sdrreader[11].ToString());
                    pdcclearancemasterinfo.FinancialYearId = decimal.Parse(sdrreader[12].ToString());
                    pdcclearancemasterinfo.ExtraDate = DateTime.Parse(sdrreader[13].ToString());
                    pdcclearancemasterinfo.Extra1 = sdrreader[14].ToString();
                    pdcclearancemasterinfo.Extra2 = sdrreader[15].ToString();
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
            return pdcclearancemasterinfo;
        }
        /// <summary>
        ///  Function to  get the next id for PDCClearanceMaster Table
        /// </summary>
        /// <returns></returns>
        public int PDCClearanceMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMasterMax", sqlcon);
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
        /// Function to fill the combobox under vouchertype
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VouchertypeComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeForPDCClearance", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to fill PDCClearanceMax UnderVoucherType PlusOne
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PDCClearanceMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMaxUnderVoucherType", sqlcon);
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
        /// Function to fill PDCClearanceMax UnderVoucherType PlusOne
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string PDCClearanceMaxUnderVoucherType(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceMaxUnderVoucherType", sqlcon);
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
        /// Function to fill the InvoiceNumber Combobox Under the VoucherType
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <param name="MasterId"></param>
        /// <returns></returns>
        public List<DataTable> InvoiceNumberCombofillUnderVoucherType(string strVoucherType, decimal MasterId)
        {
            List<DataTable> listObjPdcPayableId = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("InvoiceNumberCombofillUnderVoucherType", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = strVoucherType;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@MasterId", SqlDbType.VarChar);
                sprmparam.Value = MasterId;
                sdaadapter.Fill(dtbl);
                listObjPdcPayableId.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjPdcPayableId;
        }
        /// <summary>
        /// Function to fill the product details based on the search
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <param name="decmasterId"></param>
        /// <returns></returns>
        public List<DataTable> pdcclearancedetailsFill(string strVoucherType, decimal decmasterId)
        {
            List<DataTable> listObjPdcPayableId = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceFillDetails", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = strVoucherType;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@MasterId", SqlDbType.Int);
                sprmparam.Value = decmasterId;
                sdaadapter.Fill(dtbl);
                listObjPdcPayableId.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjPdcPayableId;
        }
        /// <summary>
        /// Function to check the references of pdc clearence
        /// </summary>
        /// <param name="voucherNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="PDCClearanceMasterId"></param>
        /// <returns></returns>
        public bool PDCclearanceCheckExistence(string voucherNo, decimal voucherTypeId, decimal PDCClearanceMasterId)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCclearanceCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = voucherNo;
                sprmparam = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = PDCClearanceMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = voucherTypeId;
                sccmd.ExecuteNonQuery();
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (Convert.ToDecimal(obj.ToString()) == 0)
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
        /// Function to get the TypeOf Voucher Return Under the Voucher
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <returns></returns>
        public string TypeOfVoucherReturnUnderVoucherName(string strVoucherType)
        {
            string VoucherType = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TypeOfVoucherReturnUnderVoucherName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar);
                sprmparam.Value = strVoucherType;
                VoucherType = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return VoucherType;
        }
        /// <summary>
        /// Function to fill the grid based on the search condition and fill the grid
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtTodate"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="voucherTypeName"></param>
        /// <param name="strchequeNo"></param>
        /// <param name="decBankId"></param>
        /// <param name="strstatus"></param>
        /// <returns></returns>
        public List<DataTable> PDCClearanceRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string strchequeNo, decimal decBankId, string strstatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlCommand sqlcmd = new SqlCommand("PDCClearanceRegisterSearch", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
                sqlcmd.Parameters.Add("@chequeNo", SqlDbType.VarChar).Value = strchequeNo;
                sqlcmd.Parameters.Add("@bankId", SqlDbType.Decimal).Value = decBankId;
                sqlcmd.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcmd;
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
        /// Function to delete the items from table used on the parameter
        /// </summary>
        /// <param name="PdcClearanceId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PDCClearanceDelete(decimal PdcClearanceId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = PdcClearanceId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
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
        /// Function to search and fill the report grid
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtTodate"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="voucherTypeName"></param>
        /// <param name="voucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PDCClearanceReportSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
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
                SqlCommand sqlcmd = new SqlCommand("PDCClearanceReportSearch", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
                sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcmd;
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
        /// Function to print the details of PDC in print forms
        /// </summary>
        /// <param name="decPDCClearanceId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PDCClearanceVoucherPrinting(decimal decPDCClearanceId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCClearanceVoucherPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@pdcClearanceId", SqlDbType.Decimal);
                sprmparam.Value = decPDCClearanceId;
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
        /// Function to get PDC clearence against the ledger 
        /// </summary>
        /// <param name="decclearanceId"></param>
        /// <returns></returns>
        public decimal PDCClearanceAgainstIdUnderClearanceId(decimal decclearanceId)
        {
            decimal decAgainstId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PDCClearanceAgainstIdUnderClearanceId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@PDCClearanceMasterId", SqlDbType.Decimal);
                sprmparam.Value = decclearanceId;
                decAgainstId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decAgainstId;
        }
        /// <summary>
        /// Function to Print the PDC Clearence  Report for printing
        /// </summary>
        /// <param name="dtFromdate"></param>
        /// <param name="dtTodate"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="voucherTypeName"></param>
        /// <param name="voucherNo"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PDCClearanceReportPrinting(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo, decimal decCompanyId)
        {
            DataSet dtbl = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PDCClearanceReportPrinting", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
                sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
                sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
                sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
                sqlcmd.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = voucherTypeName;
                sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = voucherNo;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcmd;
                sqlda.Fill(dtbl);
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
    }
}
