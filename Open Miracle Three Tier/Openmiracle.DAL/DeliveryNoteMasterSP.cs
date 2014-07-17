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
//Summary description for DeliveryNoteMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class DeliveryNoteMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to DeliveryNoteMaster Table
        /// </summary>
        /// <param name="deliverynotemasterinfo"></param>
        /// <returns></returns>
        public decimal DeliveryNoteMasterAdd(DeliveryNoteMasterInfo deliverynotemasterinfo)
        {
            decimal decDeliveryNoteMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = deliverynotemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.Extra2;
                decDeliveryNoteMasterId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decDeliveryNoteMasterId;
        }
        /// <summary>
        /// Function to Update values in DeliveryNoteMaster Table
        /// </summary>
        /// <param name="deliverynotemasterinfo"></param>
        public void DeliveryNoteMasterEdit(DeliveryNoteMasterInfo deliverynotemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.DeliveryNoteMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = deliverynotemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.EmployeeId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = deliverynotemasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.QuotationMasterId;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = deliverynotemasterinfo.FinancialYearId;
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
        /// Function to get all the values from DeliveryNoteMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable DeliveryNoteMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterViewAll", sqlcon);
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
        /// Function to get particular values from DeliveryNoteMaster Table based on the parameter
        /// </summary>
        /// <param name="deliveryNoteMasterId"></param>
        /// <returns></returns>
        public DeliveryNoteMasterInfo DeliveryNoteMasterView(decimal deliveryNoteMasterId)
        {
            DeliveryNoteMasterInfo deliverynotemasterinfo = new DeliveryNoteMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliveryNoteMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    deliverynotemasterinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader[0].ToString());
                    deliverynotemasterinfo.VoucherNo = sdrreader[1].ToString();
                    deliverynotemasterinfo.InvoiceNo = sdrreader[2].ToString();
                    deliverynotemasterinfo.VoucherTypeId = decimal.Parse(sdrreader[3].ToString());
                    deliverynotemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[4].ToString());
                    deliverynotemasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    deliverynotemasterinfo.LedgerId = decimal.Parse(sdrreader[6].ToString());
                    deliverynotemasterinfo.OrderMasterId = decimal.Parse(sdrreader[7].ToString());
                    deliverynotemasterinfo.PricinglevelId = decimal.Parse(sdrreader[8].ToString());
                    deliverynotemasterinfo.EmployeeId = decimal.Parse(sdrreader[9].ToString());
                    deliverynotemasterinfo.Narration = sdrreader[10].ToString();
                    deliverynotemasterinfo.ExchangeRateId = decimal.Parse(sdrreader[11].ToString());
                    deliverynotemasterinfo.TotalAmount = decimal.Parse(sdrreader[12].ToString());
                    deliverynotemasterinfo.UserId = decimal.Parse(sdrreader[13].ToString());
                    deliverynotemasterinfo.LrNo = sdrreader[14].ToString();
                    deliverynotemasterinfo.TransportationCompany = sdrreader[15].ToString();
                    deliverynotemasterinfo.QuotationMasterId = decimal.Parse(sdrreader[16].ToString());
                    deliverynotemasterinfo.FinancialYearId = decimal.Parse(sdrreader[17].ToString());
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
            return deliverynotemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table DeliveryNoteMaster
        /// </summary>
        /// <param name="DeliveryNoteMasterId"></param>
        /// <returns></returns>
        public decimal DeliveryNoteMasterDelete(decimal DeliveryNoteMasterId)
        {
            decimal deliveryNoteId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = DeliveryNoteMasterId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    deliveryNoteId = 1;
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
            return deliveryNoteId;
        }
        /// <summary>
        /// Function to Stock Posting Deleting For DeliveryNote form
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strInvoiceNo"></param>
        /// <returns></returns>
        public decimal StockPostDeletingForDeliveryNote(decimal decVoucherTypeId, string strVoucherNo, string strInvoiceNo)
        {
            decimal deliveryNoteId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("StockPostDeletingForDeliveryNote", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@againstVoucherNo", SqlDbType.Decimal);
                sprmparam.Value = strVoucherNo;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    deliveryNoteId = 1;
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
            return deliveryNoteId;
        }
        /// <summary>
        /// Function to print the delivery note details
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decOrderId"></param>
        /// <param name="decQuotationId"></param>
        /// <returns></returns>
        public DataSet DeliveryNotePrinting(decimal decDeliveryNoteMasterId, decimal decCompanyId, decimal decOrderId, decimal decQuotationId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNotePrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDeliveryNoteMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sprmparam.Value = decQuotationId;
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
        /// <summary>
        /// Function to  get the next id for DeliveryNoteMaster Table
        /// </summary>
        /// <returns></returns>
        public int DeliveryNoteMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterMax", sqlcon);
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
        /// Function to  get the next id for DeliveryNoteMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal DeliveryNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliverNoteMasterMax1", sqlcon);
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
            return max + 1;
        }
        /// <summary>
        /// Function to  get the next id for DeliveryNoteMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string DeliveryNoteMasterMax1(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliverNoteMasterMax1", sqlcon);
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
        /// Function to get details of Deliverynote curresponding to the ledger
        /// </summary>
        /// <param name="decledgerid"></param>
        /// <param name="decrejectioninmasterid"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteNoCorrespondingToLedger(decimal decledgerid, decimal decrejectioninmasterid, decimal decVoucherTypeId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                //GetDeliveryNoteNoCorrespondingtoLedger
                SqlDataAdapter sqlda = new SqlDataAdapter("GetDeliveryNoteNoCorrespondingtoLedger", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decledgerid;
                sqlda.SelectCommand.Parameters.Add("@rejectionInMasterId", SqlDbType.Decimal).Value = decrejectioninmasterid;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
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
        /// Function to DeliveryNote Master View SalesMan And Pricing
        /// </summary>
        /// <param name="deliveryNoteMasterId"></param>
        /// <returns></returns>
        public DeliveryNoteMasterInfo DeliveryNoteMasterViewSalesManAndPricing(decimal deliveryNoteMasterId)
        {
            DeliveryNoteMasterInfo deliverynotemasterinfo = new DeliveryNoteMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterViewSalesManAndPricing", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = deliveryNoteMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    deliverynotemasterinfo.DeliveryNoteMasterId = decimal.Parse(sdrreader["deliveryNoteMasterId"].ToString());
                    deliverynotemasterinfo.PricinglevelId = decimal.Parse(sdrreader["pricinglevelId"].ToString());
                    deliverynotemasterinfo.EmployeeId = decimal.Parse(sdrreader["employeeId"].ToString());
                    deliverynotemasterinfo.ExchangeRateId = decimal.Parse(sdrreader["exchangeRateId"].ToString());
                    deliverynotemasterinfo.UserId = decimal.Parse(sdrreader["userId"].ToString());
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
            return deliverynotemasterinfo;
        }
        /// <summary>
        /// to get voucher no in delivery note
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public string GetDeliveryNoteVoucherNo(decimal decDeliveryNoteMasterId)
        {
            string strDeliveryNoteVoucherNo;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand cmd = new SqlCommand("DeliveryNoteVoucherNoViewByDlvryNteMstrId", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = cmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDeliveryNoteMasterId;
                strDeliveryNoteVoucherNo = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return strDeliveryNoteVoucherNo;
        }
        /// <summary>
        /// Function to get DeliveryNote No Corresponding To Ledger For Report
        /// </summary>
        /// <param name="decledgerid"></param>
        /// <returns></returns>
        public DataTable DeliveryNoteNoCorrespondingToLedgerForReport(decimal decledgerid)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("GetDeliveryNoteNoCorrepondingToLedgerForReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decledgerid;
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
        /// <summary>
        /// Function to Get Delevery Note No Include Pending Corresponding to Ledger For SalesInvoice
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decSalesMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI(decimal decLedgerId, decimal decSalesMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@salesMasterId", SqlDbType.Decimal);
                sqlparameter.Value = decSalesMasterId;
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlparameter.Value = decVoucherTypeId;
                sqldataadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to SalesInvoice Gridfill Againest DeliveryNote
        /// </summary>
        /// <param name="DecDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> SalesInvoiceGridfillAgainestDeliveryNote(decimal DecDeliveryNoteMasterId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("SalesInvoiceGridfillAgainestDeliveryNote", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sqlparameter.Value = DecDeliveryNoteMasterId;
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
        /// Function to check Delivery Not Number Check Existence
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public bool DeliveryNotNumberCheckExistence(string strInvoiceNo, decimal decDeliveryNoteMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DeliveryNotNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                sprmparam.Value = decDeliveryNoteMasterId;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
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
        /// Function to view DeliveryNoteInvoice based on date
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public DataTable DeliveryNoteInvoiceViewBasedOnDate(DateTime fromDate, DateTime toDate)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdlda = new SqlDataAdapter("DeliveryNoteInvoiceViewBasedOnDate", sqlcon);
                sdlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sdlda.Fill(dtbl);
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
        /// DeliveryNote Register GridFill Corresponding To Invoice No And Ledger
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLdger"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="inDecimalPlaces"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger(string strInvoiceNo, decimal decLdger, DateTime fromDate, DateTime toDate, int inDecimalPlaces)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdlda = new SqlDataAdapter("DeliveryNoteRegisterGridFillCorrespondingToInvoiceNoAndLedger", sqlcon);
                sdlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sqlparameter.Value = strInvoiceNo;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLdger;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparameter.Value = fromDate;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparameter.Value = toDate;
                sqlparameter = sdlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sqlparameter.Value = inDecimalPlaces;
                sdlda.Fill(dtbl);
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
        /// Function to Delivery Note Master View All By MasterId
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public DeliveryNoteMasterInfo DeliveryNoteMasterViewAllByMasterId(decimal decDeliveryNoteMasterId)
        {
            DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
            SqlDataReader sdrReader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("DeliveryNoteMasterViewAllByMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlcmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDeliveryNoteMasterId;
                sdrReader = sqlcmd.ExecuteReader();
                while (sdrReader.Read())
                {
                    infoDeliveryNoteMaster.DeliveryNoteMasterId = decimal.Parse(sdrReader["deliveryNoteMasterId"].ToString());
                    infoDeliveryNoteMaster.VoucherNo = sdrReader["voucherNo"].ToString();
                    infoDeliveryNoteMaster.InvoiceNo = sdrReader["invoiceNo"].ToString();
                    infoDeliveryNoteMaster.VoucherTypeId = Convert.ToDecimal(sdrReader["voucherTypeId"].ToString());
                    infoDeliveryNoteMaster.SuffixPrefixId = Convert.ToDecimal(sdrReader["suffixPrefixId"].ToString());
                    infoDeliveryNoteMaster.Date = Convert.ToDateTime(sdrReader["date"].ToString());
                    infoDeliveryNoteMaster.LedgerId = Convert.ToDecimal(sdrReader["ledgerId"].ToString());
                    infoDeliveryNoteMaster.PricinglevelId = Convert.ToDecimal(sdrReader["pricingLevelId"].ToString());
                    infoDeliveryNoteMaster.EmployeeId = Convert.ToDecimal(sdrReader["employeeId"].ToString());
                    infoDeliveryNoteMaster.Narration = (sdrReader["narration"].ToString());
                    infoDeliveryNoteMaster.SuffixPrefixId = Convert.ToDecimal(sdrReader["suffixPrefixId"].ToString());
                    infoDeliveryNoteMaster.ExchangeRateId = Convert.ToDecimal(sdrReader["exchangeRateId"].ToString());
                    infoDeliveryNoteMaster.TotalAmount = Convert.ToDecimal(sdrReader["totalAmount"].ToString());
                    infoDeliveryNoteMaster.UserId = Convert.ToDecimal(sdrReader["userId"].ToString());
                    infoDeliveryNoteMaster.TransportationCompany = (sdrReader["transportationCompany"].ToString());
                    infoDeliveryNoteMaster.LrNo = (sdrReader["lrNo"].ToString());
                    infoDeliveryNoteMaster.OrderMasterId = Convert.ToDecimal((sdrReader["orderMasterId"].ToString()));
                    infoDeliveryNoteMaster.QuotationMasterId = Convert.ToDecimal((sdrReader["quotationMasterId"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
            return infoDeliveryNoteMaster;
        }
        public DataTable DeliveryNoteReportGridBasedOnSalesQuotation(decimal decVoucherTypeId, int inNoOfDecimals)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridBasedOnSalesQuotation", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decVoucherTypeId;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sqlParameter.Value = inNoOfDecimals;
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
        /// <summary>
        /// Function for DeliveryNoteReportGrid Based On SalesOrder
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="inNoOfDecimals"></param>
        /// <returns></returns>
        public DataTable DeliveryNoteReportGridBasedOnSalesOrder(decimal decVoucherTypeId, int inNoOfDecimals)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridBasedOnSalesOrder", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decVoucherTypeId;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlaces", SqlDbType.Int);
                sqlParameter.Value = inNoOfDecimals;
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
        /// <summary>
        /// Function to fill the DeliveryNote Report Grid Fill
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decSalesMan"></param>
        /// <param name="strProdCod"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strStatus"></param>
        /// <param name="decOrderId"></param>
        /// <param name="decQuotationId"></param>
        /// <param name="inDecimalPlaces"></param>
        /// <param name="decDeliveryMode"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decSalesMan, string strProdCod, string strVoucherNo, decimal decVoucherTypeId, string strStatus, int inDecimalPlaces, string strDeliveryMode, string strInvoiceNo, decimal decAgainstVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlParameter.Value = fromDate;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlParameter.Value = toDate;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlParameter.Value = decLedgerId;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@employeeId", SqlDbType.Decimal);
                sqlParameter.Value = decSalesMan;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sqlParameter.Value = strProdCod;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sqlParameter.Value = strVoucherNo;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sqlParameter.Value = decVoucherTypeId;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
                sqlParameter.Value = strStatus;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@DelMode", SqlDbType.VarChar);
                sqlParameter.Value = strDeliveryMode;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sqlParameter.Value = strInvoiceNo;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sqlParameter.Value = decAgainstVoucherTypeId;
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
        /// Function to fill Delivery Note Report Corresponding To SalesOrder
       /// </summary>
       /// <param name="decSalesOrderId"></param>
       /// <returns></returns>
        public DataTable DeliveryNoteReportGridFillCorrespondingToSalesOrder(decimal decSalesOrderId)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFillCorrespondingToSalesOrder", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@salesOrderMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decSalesOrderId;
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
        /// <summary>
        /// Function to Fill the grid Delivery Note Report Corresponding To SalesQuotation
        /// </summary>
        /// <param name="decSalesQuotation"></param>
        /// <returns></returns>
        public DataTable DeliveryNoteReportGridFillCorrespondingToSalesQuotation(decimal decSalesQuotation)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportGridFillCorrespondingToSalesQuotation", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter();
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                sqlParameter = sqlda.SelectCommand.Parameters.Add("@quotationMasterId", SqlDbType.Decimal);
                sqlParameter.Value = decSalesQuotation;
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
        /// <summary>
        /// Function to Print Delivery Note Report 
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public DataSet DeliveryNoteReportPrinting(decimal decCompanyId, decimal decLedgerId, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, string strStatus, string strDeliveryMode, string strInvoiceNo)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("DeliveryNoteReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@DelMode", SqlDbType.VarChar);
                sprmparam.Value = strDeliveryMode;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
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
        /// <summary>
        /// Function to VoucherTypes BasedOn Type Of Vouchers
        /// </summary>
        /// <param name="typeOfVouchers"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypesBasedOnTypeOfVouchers(string typeOfVouchers)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypesBasedOnTypeOfVouchers", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@typeOfVoucher", SqlDbType.VarChar).Value = typeOfVouchers;
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
        /// Function to VoucherType ViewAll Corresponding To SalesOrder And SalesQuotation
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                
                SqlDataAdapter sqlda = new SqlDataAdapter("VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Function to DeliveryNote CheckReference In SalesInvoice form
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public bool DeliveryNoteCheckReferenceInSalesInvoice(decimal decDeliveryNoteMasterId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteCheckReferenceInSalesInvoice", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal).Value = decDeliveryNoteMasterId;
                isExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
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
        /// Function to DeliveryNote CheckReference In RejectionIn form
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public bool DeliveryNoteMasterReferenceCheckRejectionIn(decimal decDeliveryNoteMasterId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("DeliveryNoteMasterReferenceCheckRejectionIn", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal).Value = decDeliveryNoteMasterId;
                isExist = Convert.ToBoolean(sccmd.ExecuteScalar().ToString());
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
        /// Function to DeliveryNote Check quantity reference In RejectionIn form
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteMasterReferenceCheckRejectionInQty(decimal decDeliveryNoteMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterReferenceCheckRejectionInQty", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sdaadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDeliveryNoteMasterId;
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
        /// Function to DeliveryNote Check quantity reference In SalesInvoice form
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        /// <returns></returns>
        public List<DataTable> DeliveryNoteMasterReferenceCheckSalesInvoiceQty(decimal decDeliveryNoteMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("DeliveryNoteMasterReferenceCheckSalesInvoiceQty", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sdaadapter.SelectCommand.Parameters.Add("@deliveryNoteMasterId", SqlDbType.Decimal);
                param.Value = decDeliveryNoteMasterId;
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
