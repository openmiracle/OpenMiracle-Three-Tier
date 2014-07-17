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
//Summary description for PhysicalStockMasterSP    
//</summary>    
namespace OpenMiracle.DAL  
{
    public class PhysicalStockMasterSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to PhysicalStockMaster Table
        /// </summary>
        /// <param name="physicalstockmasterinfo"></param>
        /// <returns></returns>
        public decimal PhysicalStockMasterAdd(PhysicalStockMasterInfo physicalstockmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = physicalstockmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Extra2;
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
        /// Function to Update values in PhysicalStockMaster Table
        /// </summary>
        /// <param name="physicalstockmasterinfo"></param>
        public void PhysicalStockMasterEdit(PhysicalStockMasterInfo physicalstockmasterinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.PhysicalStockMasterId;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = physicalstockmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@totalAmount", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
                sprmparam.Value = physicalstockmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = physicalstockmasterinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = physicalstockmasterinfo.Extra2;
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
        /// Function to get all the values from PhysicalStockMaster Table
        /// </summary>
        /// <returns></returns>
        public DataTable PhysicalStockMasterViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockMasterViewAll", sqlcon);
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
        /// Function to get particular values from PhysicalStockMaster table based on the parameter
        /// </summary>
        /// <param name="physicalStockMasterId"></param>
        /// <returns></returns>
        public PhysicalStockMasterInfo PhysicalStockMasterView(decimal physicalStockMasterId)
        {
            PhysicalStockMasterInfo physicalstockmasterinfo = new PhysicalStockMasterInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = physicalStockMasterId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    physicalstockmasterinfo.PhysicalStockMasterId = decimal.Parse(sdrreader[0].ToString());
                    physicalstockmasterinfo.VoucherNo = sdrreader[1].ToString();
                    physicalstockmasterinfo.InvoiceNo = sdrreader[2].ToString();
                    physicalstockmasterinfo.SuffixPrefixId = decimal.Parse(sdrreader[3].ToString());
                    physicalstockmasterinfo.VoucherTypeId = decimal.Parse(sdrreader[4].ToString());
                    physicalstockmasterinfo.Date = DateTime.Parse(sdrreader[5].ToString());
                    physicalstockmasterinfo.Narration = sdrreader[6].ToString();
                    physicalstockmasterinfo.TotalAmount = decimal.Parse(sdrreader[7].ToString());
                    physicalstockmasterinfo.FinancialYearId = decimal.Parse(sdrreader[8].ToString());
                    physicalstockmasterinfo.ExtraDate = DateTime.Parse(sdrreader[9].ToString());
                    physicalstockmasterinfo.Extra1 = sdrreader[10].ToString();
                    physicalstockmasterinfo.Extra2 = sdrreader[11].ToString();
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
            return physicalstockmasterinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="PhysicalStockMasterId"></param>
        public void PhysicalStockMasterDelete(decimal PhysicalStockMasterId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = PhysicalStockMasterId;
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
        /// Function to  get the next id for PhysicalStockMaster table
        /// </summary>
        /// <returns></returns>
        public int PhysicalStockMasterGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterMax", sqlcon);
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
        /// Function to get max id from physicalstockmaster table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PhysicalStockMasterVoucherMax(decimal decVoucherTypeId)
        {
            decimal decVoucherNoMax = 0;
            try
            {
                SqlCommand sccmd = new SqlCommand("PhysicalStockMasterVoucherMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                decVoucherNoMax = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                throw;
            }
            return decVoucherNoMax;
        }
        /// <summary>
        /// Function to get the details for printing PhysicalStock voucher printing
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PhysicalStockPrinting(decimal decPhysicalStockMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PhysicalStockPrinting", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPhysicalStockMasterId;
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
        /// Function for physical stock register grid fill
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public List<DataTable> PhysicalStockRegisterGridFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
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
                SqlCommand sccmd = new SqlCommand("PhysicalStockRegisterGridFill", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dateFrom", SqlDbType.DateTime);
                sprmparam.Value = dtDateFrom;
                sprmparam = sccmd.Parameters.Add("@dateTo", SqlDbType.DateTime);
                sprmparam.Value = dtDateTo;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sccmd;
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
        /// Function to get particular values from PhysicalStock table based on the parameter
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        /// <returns></returns>
        public List<DataTable> PhysicalStockViewbyMasterId(decimal decPhysicalStockMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl=new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("PhysicalStockViewbyMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal).Value = decPhysicalStockMasterId;
                sdaadapter.SelectCommand = sqlcmd;
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
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PhysicalStockDelete(decimal decPhysicalStockMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("PhysicalStockDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@physicalStockMasterId", SqlDbType.Decimal);
                sprmparam.Value = decPhysicalStockMasterId;
                sprmparam = sqlcmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                sprmparam = sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sqlcmd.ExecuteNonQuery();
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
        /// Function to fill the physical stock report
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strProductName"></param>
        /// <param name="decProductCode"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> PhysicalStockReportFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo, string strProductName, decimal decProductCode, decimal decVoucherTypeId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> listObj = new List<DataTable>();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PhysicalStockReportFill", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@dateFrom", SqlDbType.DateTime);
                sprmparam.Value = dtDateFrom;
                sprmparam = sccmd.Parameters.Add("@dateTo", SqlDbType.DateTime);
                sprmparam.Value = dtDateTo;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
                sprmparam.Value = strProductName;
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductCode;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sccmd;
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
        /// Function to get the batch by productId
        /// </summary>
        /// <param name="decProductId"></param>
        /// <returns></returns>
        public decimal BatchViewByProductId(decimal decProductId)
        {
            decimal decStock = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("BatchViewByProductId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@productId", SqlDbType.Decimal);
                sprmparam.Value = decProductId;
                decStock = decimal.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decStock;
        }
    }
}
