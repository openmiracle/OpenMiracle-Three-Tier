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
//Summary description for PurchaseMasterSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class PurchaseMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PurchaseMaster Table
        /// </summary>
        /// <param name="purchasemasterinfo"></param>
        /// <returns></returns>
        public decimal PurchaseMasterAdd(PurchaseMasterInfo purchasemasterinfo)
        {
            decimal decPurchaseMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@vendorInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.VendorInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@vendorInvoiceDate", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.VendorInvoiceDate;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.PurchaseAccount;
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.PurchaseOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.TotalTax;
                sprmparam = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.BillDiscount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Extra2;
                decPurchaseMasterId = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decPurchaseMasterId;
        }
        /// <summary>
        /// Function to Update values in PurchaseMaster Table
        /// </summary>
        /// <param name="purchasemasterinfo"></param>
        public void PurchaseMasterEdit(PurchaseMasterInfo purchasemasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.PurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@vendorInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.VendorInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@vendorInvoiceDate", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.VendorInvoiceDate;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@purchaseAccount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.PurchaseAccount;
                sprmparam = sccmd.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.PurchaseOrderMasterId;
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@additionalCost", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.AdditionalCost;
                sprmparam = sccmd.Parameters.Add("@totalTax", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.TotalTax;
                sprmparam = sccmd.Parameters.Add("@billDiscount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.BillDiscount;
                sprmparam = sccmd.Parameters.Add("@grandTotal", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.GrandTotal;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = purchasemasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = purchasemasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = purchasemasterinfo.Extra2;
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
        /// Function to get all the values from PurchaseMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PurchaseMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseMasterViewAll", sqlcon);
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
        /// Function to get particular values from PurchaseMaster table based on the parameter
        /// </summary>
        /// <param name="purchaseMasterId"></param>
        /// <returns></returns>
        public PurchaseMasterInfo PurchaseMasterView(Decimal purchaseMasterId)
        {
            PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = purchaseMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    purchasemasterinfo.PurchaseMasterId = decimal.Parse(sdrreader[0].ToString());
                    purchasemasterinfo.VoucherNo = sdrreader[1].ToString();
                    purchasemasterinfo.InvoiceNo = sdrreader[2].ToString();
                    purchasemasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    purchasemasterinfo.VoucherTypeId = decimal.Parse(sdrreader[4].ToString());
                    purchasemasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    purchasemasterinfo.LedgerId = decimal.Parse(sdrreader[6].ToString());
                    purchasemasterinfo.VendorInvoiceNo = sdrreader[7].ToString();
                    purchasemasterinfo.VendorInvoiceDate = DateTime.Parse(sdrreader[8].ToString());
                    purchasemasterinfo.CreditPeriod = sdrreader[9].ToString();
                    purchasemasterinfo.ExchangeRateId = decimal.Parse(sdrreader[10].ToString());
                    purchasemasterinfo.Narration = sdrreader[11].ToString();
                    purchasemasterinfo.PurchaseAccount = decimal.Parse(sdrreader[12].ToString());
                    purchasemasterinfo.PurchaseOrderMasterId = decimal.Parse(sdrreader[13].ToString());
                    purchasemasterinfo.MaterialReceiptMasterId = decimal.Parse(sdrreader[14].ToString());
                    purchasemasterinfo.AdditionalCost = decimal.Parse(sdrreader[15].ToString());
                    purchasemasterinfo.TotalTax = decimal.Parse(sdrreader[16].ToString());
                    purchasemasterinfo.BillDiscount = decimal.Parse(sdrreader[17].ToString());
                    purchasemasterinfo.GrandTotal = decimal.Parse(sdrreader[18].ToString());
                    purchasemasterinfo.TotalAmount = decimal.Parse(sdrreader[19].ToString());
                    purchasemasterinfo.UserId = decimal.Parse(sdrreader[20].ToString());
                    purchasemasterinfo.LrNo = sdrreader[21].ToString();
                    purchasemasterinfo.TransportationCompany = sdrreader[22].ToString();
                    purchasemasterinfo.FinancialYearId = decimal.Parse(sdrreader[23].ToString());
                    purchasemasterinfo.ExtraDate = DateTime.Parse(sdrreader[24].ToString());
                    purchasemasterinfo.Extra1 = sdrreader[25].ToString();
                    purchasemasterinfo.Extra2 = sdrreader[26].ToString();
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
            return purchasemasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PurchaseMasterId"></param>
        public void PurchaseMasterDelete(decimal PurchaseMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = PurchaseMasterId;
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
        /// Function to  get the next id for PurchaseMaster table
        /// </summary>
        /// <returns></returns>
        public int PurchaseMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterMax", sqlcon);
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
        /// Function to fill purchase account combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> PurchaseInvoicePurchaseAccountFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("PurchaseInvoicePurchaseAccountComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get orderno corresponding to ledger not in current purchase invoice
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decVoucherType"></param>
        /// <returns></returns>
        public List<DataTable> GetOrderNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherType)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("GetOrderNoCorrespondingtoLedgerByNotInCurrPI", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get orderno corresponding to ledger
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decReceiptMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetOrderNoCorrespondingtoLedger(decimal decLedgerId, decimal decReceiptMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("GetOrderNoCorrespondingtoLedger", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@receiptMasterId", SqlDbType.Decimal).Value = decReceiptMasterId;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("pmsp" + ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to  get the next id for PurchaseMaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PurchaseMasterVoucherMax(decimal decVoucherTypeId)
        {
            decimal decVoucherNoMax = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterVoucherMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                decVoucherNoMax = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decVoucherNoMax;
        }
        /// <summary>
        /// Function to get MaterialReceiptNo corresponding to ledger not in current purchase invoice
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function for account ledger view for additional cost
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewForAdditionalCost()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get the details for PurchaseInvoice Register
        /// </summary>
        /// <param name="strColumn"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strPurchaseMode"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseInvoiceRegisterFill(string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strPurchaseMode,
            decimal decVoucherTypeId, string strInvoiceNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceRegisterFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
                sprmparam.Value = strColumn;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtFromDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dtToDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
                sprmparam.Value = strPurchaseMode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Purchase InvoiceNo View All By ProductCode And BatchNo For Barcode Printing
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        /// <param name="cmbPurchaseInvoice"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting(decimal decProductId, decimal decBatchId, ComboBox cmbPurchaseInvoice, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                sprmparam = sda.SelectCommand.Parameters.Add("@batchId", SqlDbType.Decimal);
                sprmparam.Value = decBatchId;
                sda.Fill(dtbl);
                ListObj.Add(dtbl);
                if (isAll)
                {
                    if (ListObj[0].Rows.Count != 0)
                    {
                        DataRow dr = ListObj[0].NewRow();
                        dr["invoiceNo"] = "All";
                        dr["purchaseMasterId"] = 0;
                        ListObj[0].Rows.InsertAt(dr, 0);
                    }
                    else
                    {
                        cmbPurchaseInvoice.Text = string.Empty;
                    }
                }
                cmbPurchaseInvoice.DataSource = ListObj[0];
                cmbPurchaseInvoice.DisplayMember = "invoiceNo";
                cmbPurchaseInvoice.ValueMember = "purchaseMasterId";
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
        /// Function to check reference in purchasemaster
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decPurchaseDetailsId"></param>
        /// <returns></returns>
        public int PurchaseMasterReferenceCheck(decimal decPurchaseMasterId, decimal decPurchaseDetailsId)
        {
            int inQty = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sprmparam = sccmd.Parameters.Add("@purchaseDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseDetailsId;
                inQty = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inQty;
        }
        /// <summary>
        /// Function to check existance of voucherno
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public int PurchaseInvoiceVoucherNoCheckExistance(string strInvoiceNo, string strVoucherNo, decimal decVoucherTypeId, decimal decPurchaseMasterId)
        {
            int inRef = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseInvoiceVoucherNoCheckExistance", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                inRef = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inRef;
        }
        /// <summary>
        /// Purchase InvoiceNo View All For Barcode Printing
        /// </summary>
        /// <param name="cmbPurchaseInvoice"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseInvoiceNoViewAllForBarcodePrinting(ComboBox cmbPurchaseInvoice, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("PurchaseInvoiceNoViewAllForBarcodePrinting", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.Fill(dtbl);
                ListObj.Add(dtbl);
                if (isAll)
                {
                    DataRow dr = ListObj[0].NewRow();
                    dr["invoiceNo"] = "All";
                    dr["purchaseMasterId"] = 0;
                    ListObj[0].Rows.InsertAt(dr, 0);
                }
                cmbPurchaseInvoice.DataSource = ListObj[0];
                cmbPurchaseInvoice.DisplayMember = "invoiceNo";
                cmbPurchaseInvoice.ValueMember = "purchaseMasterId";
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
        /// Function to fill the grid in report
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="strColumn"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strStatus"></param>
        /// <param name="strPurchaseMode"></param>
        /// <param name="decAgainstVoucherTypeId"></param>
        /// <param name="strAgainstVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseInvoiceReportFill(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus,
             string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo,
            string strProductCode, string strProductName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceReportFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
                sprmparam.Value = strColumn;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtFromDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dtToDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
                sprmparam.Value = strPurchaseMode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decAgainstVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strAgainstVoucherNo;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get InvoiceNo Corresponding to Ledger
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetInvoiceNoCorrespondingtoLedger(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("GetPurchaseReturnInvoiceNoCorrespondingtoLedger", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal).Value = decPurchaseMasterId;
                sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal).Value = decVoucherTypeId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("pmsp" + ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to  Get InvoiceNo Corresponding to Ledger In Register
        /// </summary>
        /// <returns></returns>
        public List<DataTable> GetInvoiceNoCorrespondingtoLedgerInRegister()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("GetInvoiceNoCorrespondingtoLedgerInRegister", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("pmsp" + ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get details for printing purchaseinvoice 
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="decPurchaseOrderMasterId"></param>
        /// <param name="decMaterialReceiptMasterId"></param>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public DataSet PurchaseInvoicePrinting(decimal decCompanyId, decimal decPurchaseOrderMasterId, decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoicePrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseOrderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseOrderMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPurchaseMasterId;
                sdaadapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        /// <summary>
        /// Function to get details for printing purchaseinvoice report
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="strColumn"></param>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strStatus"></param>
        /// <param name="strPurchaseMode"></param>
        /// <param name="decAgainstVoucherTypeId"></param>
        /// <param name="strAgainstVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public DataSet PurchaseInvoiceReportPrinting(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus,
             string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo,
            string strProductCode, string strProductName)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseInvoiceReportPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@column", SqlDbType.VarChar);
                sprmparam.Value = strColumn;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = dtFromDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = dtToDate;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@purchaseMode", SqlDbType.VarChar);
                sprmparam.Value = strPurchaseMode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@againstVoucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decAgainstVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@againstInvoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strAgainstVoucherNo;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sdaadapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        /// <summary>
        /// Function to get purchasemasterid by voucherno and vouchertype
        /// </summary>
        /// <param name="decVouchertypeid"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public decimal PurchaseMasterIdViewByvoucherNoAndVoucherType(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PurchaseMasterIdViewByvoucherNoAndVoucherType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeid;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                decid = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decid;
        }
    }
}
