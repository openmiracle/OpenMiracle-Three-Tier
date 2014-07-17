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
//Summary description for RejectionInMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class RejectionInMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to RejectionInMaster Table
        /// </summary>
        /// <param name="rejectioninmasterinfo"></param>
        /// <returns></returns>
        public decimal RejectionInMasterAdd(RejectionInMasterInfo rejectioninmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = rejectioninmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Extra2;
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
        /// Function to Update values in RejectionInMaster Table
        /// </summary>
        /// <param name="rejectioninmasterinfo"></param>
        public void RejectionInMasterEdit(RejectionInMasterInfo rejectioninmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.RejectionInMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = rejectioninmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = rejectioninmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = rejectioninmasterinfo.Extra2;
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
        public List<DataTable> CurrencyComboByDate(ComboBox cmbCurrency, DateTime date, bool isAll)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyComboByDate", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime);
                sqlparameter.Value = date;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
                if (isAll)
                {
                    DataRow dRow = list[0].NewRow();
                    dRow["exchangeRateId"] = 0;
                    dRow["currencyName"] = "All";
                    list[0].Rows.InsertAt(dRow, 0);
                }
                cmbCurrency.DataSource = list[0];
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.DisplayMember = "currencyName";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        public List<DataTable> DeliveryNoteNoComboFillToLedger(ComboBox cmbDeliveryNoteNo, decimal decLedgerId, bool isAll)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("GetDeliveryNoteNoCorrepondingToLedgerForReport", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sdaadapter.Fill(dtbl);
                list.Add(dtbl);
                cmbDeliveryNoteNo.SelectedIndex = -1;
                if (isAll)
                {
                    DataRow dRow = list[0].NewRow();
                    dRow["deliveryNoteMasterId"] = 0;
                    dRow["voucherNo"] = "All";
                    list[0].Rows.InsertAt(dRow, 0);
                }
                cmbDeliveryNoteNo.DataSource = list[0];
                cmbDeliveryNoteNo.DisplayMember = "voucherNo";
                cmbDeliveryNoteNo.ValueMember = "deliveryNoteMasterId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        
        /// <summary>
        /// Function to get particular values from RejectionInMaster table based on the parameter
        /// </summary>
        /// <param name="rejectionInMasterId"></param>
        /// <returns></returns>
        public RejectionInMasterInfo RejectionInMasterView(decimal rejectionInMasterId)
        {
            RejectionInMasterInfo rejectioninmasterinfo = new RejectionInMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sprmparam.Value = rejectionInMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    rejectioninmasterinfo.RejectionInMasterId = decimal.Parse(sdrreader[0].ToString());
                    rejectioninmasterinfo.VoucherNo = sdrreader[1].ToString();
                    rejectioninmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    rejectioninmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[3].ToString());
                    rejectioninmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[4].ToString());
                    rejectioninmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    rejectioninmasterinfo.LedgerId = decimal.Parse(sdrreader[6].ToString());
                    rejectioninmasterinfo.PricinglevelId = decimal.Parse(sdrreader[7].ToString());
                    rejectioninmasterinfo.EmployeeId = decimal.Parse(sdrreader[8].ToString());
                    rejectioninmasterinfo.Narration = sdrreader[9].ToString();
                    rejectioninmasterinfo.ExchangeRateId = decimal.Parse(sdrreader[10].ToString());
                    rejectioninmasterinfo.TotalAmount = decimal.Parse(sdrreader[11].ToString());
                    rejectioninmasterinfo.UserId = decimal.Parse(sdrreader[12].ToString());
                    rejectioninmasterinfo.LrNo = sdrreader[13].ToString();
                    rejectioninmasterinfo.TransportationCompany = sdrreader[14].ToString();
                    rejectioninmasterinfo.FinancialYearId = decimal.Parse(sdrreader[15].ToString());
                    rejectioninmasterinfo.ExtraDate = DateTime.Parse(sdrreader[16].ToString());
                    rejectioninmasterinfo.Extra1 = sdrreader[17].ToString();
                    rejectioninmasterinfo.Extra2 = sdrreader[18].ToString();
                    rejectioninmasterinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader[19].ToString());
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
            return rejectioninmasterinfo;
        }
        /// <summary>
        /// Function to check the existance RejectionIn VoucherNo
        /// </summary>
        /// <param name="strvoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decMasterId"></param>
        /// <returns></returns>
        public bool RejectionInVoucherNoCheckExistence(string strvoucherNo, decimal decVoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("RejectionInVoucherNoCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strvoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMasterId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (Convert.ToInt32(obj.ToString()) == 1)
                    {
                        trueOrfalse = true;
                    }
                    else
                    {
                        trueOrfalse = false;
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
        /// <summary
        /// Function to get details of rejectionin printing
        /// </summary>
        /// <param name="decRejectionInMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet RejectionInPrinting(decimal decRejectionInMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                param.Value = decRejectionInMasterId;
                param = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                param.Value = decCompanyId;
                sqlda.Fill(dSt);
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
        /// Function to get voucherNo based on masterid
        /// </summary>
        /// <param name="decRejectionInMasterId"></param>
        /// <returns></returns>
        public string GetRejectionInVoucherNo(decimal decRejectionInMasterId)
        {
            string strRejectionInVoucherNo;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionInVoucherNoViewByRejectionInMstrId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                param.Value = decRejectionInMasterId;
                strRejectionInVoucherNo = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return strRejectionInVoucherNo;
        }
        /// <summary>
        /// Function to get details of rejectionin report printing
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decDlvryNteMstrId"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public DataSet RejectionInReportPrinting(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDlvryNteMstrId, decimal decEmployeeId, string strProductCode)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDlvryNteMstrId;
                param = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                param.Value = decEmployeeId;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                sqlda.Fill(dSt);
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decRejectionInMasterId"></param>
        public void RejectionInMasterAndDetailsDelete(decimal decRejectionInMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("RejectionInMasterAndDetailsDelete", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal);
                param.Value = decRejectionInMasterId;
                cmd.ExecuteNonQuery();
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
        public List<DataTable> RejectionInRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strVoucherNo, decimal decVoucherTypeId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInRegisterFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        /// <summary>
        /// Function to get the details for RejectionIn Report
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <param name="decEmployeeId"></param>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public List<DataTable> RejectionInReportFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDeliveryNoteMasterId, decimal decEmployeeId, string strProductCode)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("RejectionInReportFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                param.Value = decVoucherTypeId;
                param = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                param.Value = strVoucherNo;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
                param = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDeliveryNoteMasterId;
                param = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                param.Value = decEmployeeId;
                param = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                param.Value = strProductCode;
                sqlda.Fill(dtbl);
                list.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        public List<DataTable> VoucherTypeSelectionFill(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            List<DataTable> list = new List<DataTable>();
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
                list.Add(dtbl);
                cmbVoucherType.SelectedIndex = -1;
                if (isAll)
                {
                    DataRow dRow = list[0].NewRow();
                    dRow["voucherTypeName"] = "All";
                    dRow["voucherTypeId"] = 0;
                    list[0].Rows.InsertAt(dRow, 0);
                }
                cmbVoucherType.DataSource = list[0];
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return list;
        }
        
       
    }
}
