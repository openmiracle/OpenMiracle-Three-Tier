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
//Summary description for MaterialReceiptMasterSP    
//</summary>    
namespace OpenMiracle.DAL  
{
    public class MaterialReceiptMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to MaterialReceiptMaster Table
        /// </summary>
        /// <param name="materialreceiptmasterinfo"></param>
        /// <returns></returns>
        public decimal MaterialReceiptMasterAdd(MaterialReceiptMasterInfo materialreceiptmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.exchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
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
        /// Function to Update values in MaterialReceiptMaster Table
       /// </summary>
       /// <param name="materialreceiptmasterinfo"></param>
        public void MaterialReceiptMasterEdit(MaterialReceiptMasterInfo materialreceiptmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.MaterialReceiptMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.OrderMasterId;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.exchangeRateId;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("@lrNo", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.LrNo;
                sprmparam = sccmd.Parameters.Add("@transportationCompany", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.TransportationCompany;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = materialreceiptmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = materialreceiptmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = materialreceiptmasterinfo.Extra2;
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
        /// Function to get MaterialReceiptMaster ViewAll
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public List<DataTable> MaterialReceiptMasterViewAll(string strInvoiceNo,  decimal decLedgerId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("MaterialReceiptRgistersearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sdaadapter.SelectCommand = sccmd;
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
        /// Function to fill the MaterialReceiptReport 
        /// </summary>
        /// <param name="decOrderId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        public List<DataTable> MaterialReceiptReportViewAll(decimal decOrderId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, string strProductCode, DateTime FromDate, DateTime ToDate,string strStatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(int));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sccmd = new SqlCommand("MaterialReceiptReportsearch", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderId;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sccmd.Parameters.Add("@strproductCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sccmd.Parameters.Add("@condition", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sdaadapter.SelectCommand = sccmd;
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
        /// Function to MaterialReceipt Quantity Details Against PurcahseInvoice And RejectionOut
        /// </summary>
        /// <param name="decMaterialReceiptDetailsId"></param>
        /// <returns></returns>
       
        public decimal MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut(decimal decMaterialReceiptDetailsId)
        {
            decimal decQty = 0;
            object objQty = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetilsId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptDetailsId;
                objQty = sccmd.ExecuteScalar();
                if (objQty != null)
                {
                    decQty = Convert.ToDecimal(objQty.ToString());
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
            return decQty;
        }
        /// <summary>
        /// Function to MaterialReceiptMaster Reference Check
        /// </summary>
        /// <param name="decMaterialReceiptMasterId"></param>
        /// <returns></returns>
        public decimal MaterialReceiptMasterReferenceCheck(decimal decMaterialReceiptMasterId)
        {
            decimal decStatus = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptMasterId;
                
                decStatus  = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStatus;
        }
        /// <summary>
        /// Function to MaterialReceipt Details Reference Check
        /// </summary>
        /// <param name="decMaterialReceiptDetailsId"></param>
        /// <returns></returns>
        public decimal MaterialReceiptDetailsReferenceCheck(decimal decMaterialReceiptDetailsId)
        {
            decimal decStatus = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDetailsReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptDetailsId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptDetailsId;
                decStatus = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStatus;
        }
        /// <summary>
        /// Function to MaterialReceipt Report Printing
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="strStatus"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="decVouchertypeId"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="decOrderMasterId"></param>
        /// <returns></returns>
        public DataSet MaterialReceiptReportPrinting(decimal decCompanyId, string strInvoiceNo,string strStatus, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate,decimal decOrderMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strInvoiceNo;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@strProductCode", SqlDbType.VarChar);
                sprmparam.Value = strProductCode;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVouchertypeId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = FromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = ToDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@condition", SqlDbType.VarChar);
                sprmparam.Value = strStatus;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderMasterId;
               
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
        /// Function to get particular values from MaterialReceiptMaster Table based on the parameter
        /// </summary>
        /// <param name="materialReceiptMasterId"></param>
        /// <returns></returns>
        public MaterialReceiptMasterInfo MaterialReceiptMasterView(decimal materialReceiptMasterId)
        {
            MaterialReceiptMasterInfo materialreceiptmasterinfo = new MaterialReceiptMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = materialReceiptMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    materialreceiptmasterinfo.MaterialReceiptMasterId = decimal.Parse(sdrreader[0].ToString());
                    materialreceiptmasterinfo.VoucherNo = sdrreader[1].ToString();
                    materialreceiptmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    materialreceiptmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    materialreceiptmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[4].ToString());
                    materialreceiptmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    materialreceiptmasterinfo.LedgerId = decimal.Parse(sdrreader[6].ToString());
                    materialreceiptmasterinfo.OrderMasterId = decimal.Parse(sdrreader[7].ToString());
                    materialreceiptmasterinfo.Narration = sdrreader[8].ToString();
                    materialreceiptmasterinfo.exchangeRateId = Convert.ToDecimal (sdrreader[9].ToString());
                    materialreceiptmasterinfo.TotalAmount = decimal.Parse(sdrreader[10].ToString());
                    materialreceiptmasterinfo.UserId = decimal.Parse(sdrreader[11].ToString());
                    materialreceiptmasterinfo.LrNo = sdrreader[12].ToString();
                    materialreceiptmasterinfo.TransportationCompany = sdrreader[13].ToString();
                    materialreceiptmasterinfo.FinancialYearId = decimal.Parse(sdrreader[14].ToString());
                    materialreceiptmasterinfo.Extra1 = sdrreader[15].ToString();
                    materialreceiptmasterinfo.Extra2 = sdrreader[16].ToString();
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
            return materialreceiptmasterinfo;
        }
       
         /// <summary>
        /// Function to delete particular details based on the parameter From Table MaterialReceiptMaster
         /// </summary>
         /// <param name="MaterialReceiptMasterId"></param>
         /// <returns></returns>
        public decimal  MaterialReceiptDelete(decimal MaterialReceiptMasterId)
        {
            decimal decResult = 0;
            try
            {
               
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = MaterialReceiptMasterId;
                int ineffeftedRow = Convert.ToInt32(sccmd.ExecuteNonQuery());
                if (ineffeftedRow > 0)
                {
                    decResult = 1;
                }
                else
                {
                    decResult = 0;
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
            return decResult;
        }
        /// <summary>
        /// Function to get OrderNo Corresponding to Ledger For MaterialReceiptRpt
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable>  GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt(decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt", sqlcon);
                sqldataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sqldataadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sqlparameter.Value = decLedgerId;
                sqldataadapter.Fill(dtbl);
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
        /// Function to get MaterialReceiptMaster Id Plus One
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        
        public decimal MaterialReceiptMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterMax", sqlcon);
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
        /// Function to  get the next id for MaterialReceiptMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string MaterialReceiptMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("MaterialReceiptMasterMax", sqlcon);
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
        /// Function to get MaterialReceipt No For RejectionOut
       /// </summary>
       /// <param name="decLedgerId"></param>
       /// <param name="decRejectionOutMasterId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
        public List<DataTable> ShowMaterialReceiptNoForRejectionOut(decimal decLedgerId, decimal decRejectionOutMasterId,decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ShowMaterialReceiptNoForRejectionOut", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@rejectionOutMasterId", SqlDbType.Decimal);
                sprmparam.Value = decRejectionOutMasterId;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
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
        /// Function to MaterialReceipt Number CheckExistence
       /// </summary>
       /// <param name="strinvoiceNo"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
        public bool MaterialReceiptNumberCheckExistence(string strinvoiceNo,  decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("MaterialReceiptNumberCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = strinvoiceNo;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
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
        /// Function to MaterialReceipt No Corresponding To Ledger For Report
        /// </summary>
        /// <param name="decledgerid"></param>
        /// <returns></returns>
        public List<DataTable> MaterialReceiptNoCorrespondingToLedgerForReport(decimal decledgerid)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("GetMaterialReceiptNoCorrepondingToLedgerForReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decledgerid;
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
        /// Function to get the details of Material receipt for printing 
        /// </summary>
        /// <param name="decmaterialReceiptMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decOrderMasterId"></param>
        /// <returns></returns>
        public DataSet MaterialReceiptPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId,decimal decOrderMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decmaterialReceiptMasterId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@orderMasterId", SqlDbType.Decimal);
                sprmparam.Value = decOrderMasterId;
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
        /// Function to MaterialReceipt Master View By ReceiptMasterId
        /// </summary>
        /// <param name="decMaterialReceiptMasterId"></param>
        /// <returns></returns>
        public List<DataTable> MaterialReceiptMasterViewByReceiptMasterId(decimal decMaterialReceiptMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("MaterialReceiptMasterViewByReceiptMasterId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlda.SelectCommand.Parameters.Add("@materialReceiptMasterId", SqlDbType.Decimal);
                sprmparam.Value = decMaterialReceiptMasterId;
                sqlda.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
    }
}
